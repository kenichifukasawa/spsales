Imports System.Data.SqlClient

Public Class frmshiharai_rireki_shousai

    Private Sub frmshiharai_rireki_shousai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim shukkin_id = lbl_shukkin_id.Text
        Dim hiduke = lbl_hiduke.Text

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 5

            .Columns(0).Name = "NO"
            .Columns(1).Name = "仕入ID"
            .Columns(2).Name = "仕入日"
            .Columns(3).Name = "仕入金額"
            .Columns(4).Name = "伝票番号"

            .Columns(0).Width = 40
            .Columns(1).Width = 100
            .Columns(2).Width = 110
            .Columns(3).Width = 90
            .Columns(4).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(3).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim sum_goukei_gaku = 0

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT shiire.*, gyousha.gyoushamei FROM shiire RIGHT JOIN gyousha ON shiire.gyoushaid = gyousha.gyoushaid" +
                    " WHERE shiire.shukkinid = '" + shukkin_id + "' AND shiire.joukyou = '1'" +
                    " ORDER BY shiire.shiirebi, gyousha.gyoushafurigana"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_shiireshousai")
                Dim dt_server As DataTable = ds_server.Tables("t_shiireshousai")

                Dim mojiretsu(4)
                For i = 0 To dt_server.Rows.Count - 1

                    mojiretsu(0) = (i + 1).ToString()
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shiireid"))
                mojiretsu(2) = ConvertYmdStringToYmdSlash(Trim(dt_server.Rows.Item(i).Item("shiirebi")))

                Dim goukeikingaku = 0
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeikingaku")) Then
                        goukeikingaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeikingaku")))
                    End If
                    sum_goukei_gaku += goukeikingaku
                    mojiretsu(3) = goukeikingaku

                    Dim denban = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("denban")) Then
                        denban = Trim(dt_server.Rows.Item(i).Item("denban"))
                    End If
                    mojiretsu(4) = denban

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        lbl_kingaku.Text = sum_goukei_gaku.ToString("#,0") + "円"

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        Dim dgv = dgv_kensakukekka
        If dgv.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        Dim shiire_id = dgv.CurrentRow.Cells(1).Value
        Dim hiduke = dgv.CurrentRow.Cells(2).Value
        Dim gyousha_mei = Trim(lbl_shiiresaki.Text)

        set_shiire_rireki_shousai(dgv.Rows.Count, shiire_id, hiduke, gyousha_mei)

    End Sub

End Class