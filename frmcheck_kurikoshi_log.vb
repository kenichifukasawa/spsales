Imports System.Data.SqlClient

Public Class frmcheck_kurikoshi_log

    Private Sub frmcheck_kurikoshi_log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_tenpo_cbx(2, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_kensaku_Click(sender As Object, e As EventArgs) Handles btn_kensaku.Click

        Dim tenpo_id = Mid(cbx_tenpo.Text, 1, 6)
        If tenpo_id = "" Then
            msg_go("店舗が選択されていません。")
            Exit Sub
        End If

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 6

            .Columns(0).Name = "NO"
            .Columns(1).Name = "日時"
            .Columns(2).Name = "社員"
            .Columns(3).Name = "内容"
            .Columns(4).Name = "値"
            .Columns(5).Name = "備考"

            .Columns(0).Width = 40
            .Columns(1).Width = 180
            .Columns(2).Width = 120
            .Columns(3).Width = 120
            .Columns(4).Width = 90
            .Columns(5).Width = 240

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(4).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT kurikoshi_log.kurilogid, kurikoshi_log.sonotoki, kurikoshi_log.tenpoid, tenpo.tenpomei" +
                ", kurikoshi_log.shainid, shain.shainmei,  kurikoshi_log.naiyou, kurikoshi_log.newatai, kurikoshi_log.bikou" +
                " FROM shain RIGHT JOIN (kurikoshi_log LEFT JOIN tenpo ON kurikoshi_log.tenpoid = tenpo.tenpoid)" +
                " ON shain.shainid = kurikoshi_log.shainid" +
                " WHERE kurikoshi_log.tenpoid = '" + tenpo_id + "'" +
                " ORDER BY kurikoshi_log.sonotoki DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_kurikoshi_log")
            Dim dt_server As DataTable = ds_server.Tables("t_kurikoshi_log")

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                Dim nichiji = Trim(dt_server.Rows.Item(i).Item("sonotoki"))
                Dim itsu = ConvertYmdStringToYmdSlash(Mid(nichiji, 1, 8))
                Dim nanji = Date.ParseExact(Mid(nichiji, 9), "HHmmss", Nothing).ToString("HH:mm:ss")
                mojiretsu(1) = itsu + " " + nanji
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shainmei"))

                Dim naiyou_no = Trim(dt_server.Rows.Item(i).Item("naiyou"))
                mojiretsu(3) = get_kurikoshi_naiyou_name_by_no(naiyou_no)

                Dim atai = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("newatai")) Then
                    atai = CInt(Trim(dt_server.Rows.Item(i).Item("newatai"))).ToString("#,0")
                End If
                mojiretsu(4) = atai

                mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("bikou"))

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btn_denwa_chou_Click(sender As Object, e As EventArgs) Handles btn_denwa_chou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "2"
            .ShowDialog()
        End With
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        dgv_kensakukekka.Rows.Clear()
        set_tenpo_cbx(2, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Function get_kurikoshi_naiyou_name_by_no(naiyou_no As String)

        Dim naiyou_name = ""
        Select Case naiyou_no
            Case "01"
                naiyou_name = "住所録登録"
            Case "02"
                naiyou_name = "住所録変更"
            Case "03"
                naiyou_name = "請求履歴削除"
            Case "04"
                naiyou_name = "請求書発行"
            Case "05"
                naiyou_name = "請求修正"
            Case "06"
                naiyou_name = "入金登録"
            Case "07"
                naiyou_name = "入金削除"
            Case "08"
                naiyou_name = "入金変更"
            Case Else
                naiyou_name = "不明"
        End Select

        Return naiyou_name

    End Function

End Class