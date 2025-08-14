Imports System.Data.SqlClient

Public Class frmshiharai_shori
    Private Sub frmshiharai_shori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_gyousha_cbx(3, False)
        dtp_shiharai_bi.Value = Now.ToString("yyyy/MM/dd")
        dtp_shiharai_kijitsu.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.Items.AddRange(PaymentMethodsInvoice.Names)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

    End Sub

    Private Sub btn_shiire_shousai_Click(sender As Object, e As EventArgs) Handles btn_shiire_shousai.Click

    End Sub

    Private Sub btn_shiharai_shousai_Click(sender As Object, e As EventArgs) Handles btn_shiharai_shousai.Click

    End Sub

    Private Sub cbx_gyousha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gyousha.SelectedIndexChanged
        set_shuukei()
    End Sub

    Private Sub dtp_shiharai_bi_CloseUp(sender As Object, e As EventArgs) Handles dtp_shiharai_bi.CloseUp
        cbx_shiharai_houhou.Focus()
    End Sub

    Private Sub dtp_shiharai_kijitsu_CloseUp(sender As Object, e As EventArgs) Handles dtp_shiharai_kijitsu.CloseUp
        cbx_shiharai_houhou.Focus()
    End Sub

    Private Sub cbx_shiharai_houhou_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_shiharai_houhou.KeyDown
        txt_kingaku.Focus()
    End Sub

    Private Sub txt_kingaku_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kingaku.KeyDown
        txt_bikou.Focus()
    End Sub

    Private Sub txt_bikou_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bikou.KeyDown
        btn_touroku.PerformClick()
    End Sub

    Private Sub clear_shiharai_denpyou_touroku()
        dtp_shiharai_bi.Value = Now.ToString("yyyy/MM/dd")
        dtp_shiharai_kijitsu.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.SelectedIndex = -1
        txt_kingaku.Text = ""
        txt_bikou.Text = ""
        lbl_goukei_kingaku.Text = ""
    End Sub

    Private Sub set_shuukei()

        clear_shiharai_denpyou_touroku()

        With dgv_kensakukekka_shiire

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 8

            .Columns(0).Name = ""
            .Columns(1).Name = "NO"
            .Columns(2).Name = "仕入ID"
            .Columns(3).Name = "仕入日"
            .Columns(4).Name = "仕入" + vbCrLf + "金額"
            .Columns(5).Name = "伝票" + vbCrLf + "番号"
            .Columns(6).Name = "支払ID"
            .Columns(7).Name = "支払日"

            .Columns(0).Width = 30
            .Columns(1).Width = 40
            .Columns(2).Width = 90
            .Columns(3).Width = 110
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 90
            .Columns(7).Width = 110

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        With dgv_kensakukekka_shiharai

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 7

            .Columns(0).Name = "NO"
            .Columns(1).Name = "支払ID"
            .Columns(2).Name = "支払日"
            .Columns(3).Name = "支払" + vbCrLf + "金額"
            .Columns(4).Name = "支払" + vbCrLf + "方法"
            .Columns(5).Name = "支払期日"
            .Columns(6).Name = "備考"

            .Columns(0).Width = 50
            .Columns(1).Width = 90
            .Columns(2).Width = 110
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 110
            .Columns(6).Width = 130

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(3).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim gyousha_id = Mid(Trim(cbx_gyousha.Text), 1, 6)
        If gyousha_id = "" Then
            Exit Sub
        End If

        Try

            Dim query = "SELECT shiire.*, gyousha.gyoushamei FROM shiire LEFT JOIN gyousha ON shiire.gyoushaid = gyousha.gyoushaid" +
                " WHERE shiire.gyoushaid = '" + gyousha_id + "' AND shiire.joukyou = '0'" +
                " ORDER BY shiire.shiirebi, gyousha.gyoushafurigana"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shiire"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(7)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = ""
                mojiretsu(1) = (i + 1).ToString
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shiireid"))
                mojiretsu(3) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiirebi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                Dim goukeikingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeikingaku")) Then
                    goukeikingaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeikingaku")))
                End If
                mojiretsu(4) = goukeikingaku

                Dim denban = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("denban")) Then
                    denban = Trim(dt_server.Rows.Item(i).Item("denban"))
                End If
                mojiretsu(5) = denban

                Dim shukkinid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkinid")) Then
                    shukkinid = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                End If
                mojiretsu(6) = shukkinid

                Dim shiharaibi = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shiharaibi")) Then
                    shiharaibi = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiharaibi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(7) = shiharaibi

                Dim dgv = dgv_kensakukekka_shiire
                dgv.Rows.Add(mojiretsu)

                dgv.Rows(i).Cells(0) = New DataGridViewCheckBoxCell
                dgv.Rows(i).Cells(0).Value = False

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Try

            Dim query = "SELECT shukkin.*, gyousha.gyoushamei FROM shukkin LEFT JOIN gyousha ON shukkin.gyoushaid = gyousha.gyoushaid" +
                " WHERE shukkin.gyoushaid = '" + gyousha_id + "'" +
                " ORDER BY shukkin.shukkinbi DESC, gyousha.gyoushafurigana"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shukkin"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shukkinbi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                Dim shukkingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkingaku")) Then
                    shukkingaku = CInt(Trim(dt_server.Rows.Item(i).Item("shukkingaku")))
                End If
                mojiretsu(3) = shukkingaku

                mojiretsu(4) = PaymentMethodsInvoice.GetNameById(Trim(dt_server.Rows.Item(i).Item("shukkinhouhou")))

                Dim kijitsu = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kijitsu")) Then
                    kijitsu = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("kijitsu")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(5) = kijitsu


                Dim bikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    bikou = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If
                mojiretsu(6) = bikou

                dgv_kensakukekka_shiharai.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class