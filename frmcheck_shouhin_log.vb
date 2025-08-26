Imports System.Data.SqlClient

Public Class frmcheck_shouhin_log

    Private Sub frmcheck_shouhin_log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_shouhin_kubun_1_cbx(3)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_kensaku_Click(sender As Object, e As EventArgs) Handles btn_kensaku.Click

        Dim shouhin_id = Mid(cbx_shitei_shouhin.Text, 1, 10)
        If shouhin_id = "" Then
            msg_go("商品が選択されていません。")
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
            .Columns(3).Width = 160
            .Columns(4).Width = 100
            .Columns(5).Width = 260

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT zaiko_log.logid, zaiko_log.sonotoki, zaiko_log.shouhinid, shouhin.shouhinmei" +
                ", zaiko_log.shainid, shain.shainmei, zaiko_log.newatai, zaiko_log.naiyou,zaiko_log.bikou" +
                " FROM shain RIGHT JOIN (zaiko_log LEFT JOIN shouhin ON zaiko_log.shouhinid = shouhin.shouhinid)" +
                " ON shain.shainid = zaiko_log.shainid" +
                " WHERE zaiko_log.shouhinid = '" + shouhin_id + "'" +
                " ORDER BY zaiko_log.sonotoki DESC, zaiko_log.logid DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_zaiko_log")
            Dim dt_server As DataTable = ds_server.Tables("t_zaiko_log")

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                Dim nichiji = Trim(dt_server.Rows.Item(i).Item("sonotoki"))
                Dim itsu = ConvertYmdStringToYmdSlash(Mid(nichiji, 1, 8))
                Dim nanji = ConvertHmsStringToHmsColon(Mid(nichiji, 9))
                mojiretsu(1) = itsu + " " + nanji
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shainmei"))

                Dim naiyou_no = Trim(dt_server.Rows.Item(i).Item("naiyou"))
                mojiretsu(3) = get_naiyou_name_by_no(naiyou_no)

                Dim atai = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("newatai")) Then
                    atai = CInt(Trim(dt_server.Rows.Item(i).Item("newatai")))
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

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2_cbx(3, shouhin_kubun_1_id)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_mishiyou_hihyouji = chk_mishiyou_hihyouji.Checked
        set_shitei_shouhin_cbx(3, shouhin_kubun_1_id, shouhin_kubun_2_id, , is_mishiyou_hihyouji)
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_mishiyou_hihyouji = chk_mishiyou_hihyouji.Checked
        set_shitei_shouhin_cbx(3, shouhin_kubun_1_id, shouhin_kubun_2_id, , is_mishiyou_hihyouji)
    End Sub

    Private Sub chk_mishiyou_hihyouji_Click(sender As Object, e As EventArgs) Handles chk_mishiyou_hihyouji.Click
        dgv_kensakukekka.Rows.Clear()
        set_shouhin_kubun_1_cbx(3)
    End Sub

    Private Function get_naiyou_name_by_no(naiyou_no As String)

        Dim naiyou_name = ""
        Select Case naiyou_no
            Case "00", "0"
                naiyou_name = "売上登録"
            Case "01"
                naiyou_name = "仕入登録"
            Case "02"
                naiyou_name = "追加売上"
            Case "03"
                naiyou_name = "商品登録"
            Case "04"
                naiyou_name = "商品変更"
            Case "05"
                naiyou_name = "納品書削除"
            Case "06"
                naiyou_name = "仕入伝票戻し"
            Case "07"
                naiyou_name = "仕入伝票削除"
            Case "08"
                naiyou_name = "仕入履歴削除"
            Case "09"
                naiyou_name = "メイン画面納品書削除"
            Case "10"
                naiyou_name = "納品書数量直し"
            Case "11"
                naiyou_name = "商品画面在庫直し"
            Case "12"
                naiyou_name = "日時変更"
            Case Else
                naiyou_name = "不明"
        End Select

        Return naiyou_name

    End Function

End Class