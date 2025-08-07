Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmshuukei_hanbai

    Private Sub frmshuukei_hanbai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")

        set_gyousha_kubun_cbx(1)
        set_shouhin_kubun_1_cbx(1)
        set_tenpo_cbx(1, chk_hihyouji_torihiki_nai.Checked)
        set_shain_cbx(1)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        If dgv_kensakukekka.CurrentRow.Index = -1 Then
            msg_go("詳細を表示したい項目を選択してから実行してください。")
            Exit Sub
        End If
        Dim current_row = dgv_kensakukekka.CurrentRow

        Dim hinichi_kaishi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_owari.Value.ToString("yyyyMMdd")

        Dim salon_name = current_row.Cells(1).Value
        Dim shouhin_name = current_row.Cells(2).Value
        Dim suuryou = current_row.Cells(3).Value.ToString
        Dim kingaku = current_row.Cells(4).Value.ToString
        Dim shouhin_id = current_row.Cells(5).Value
        Dim tenpo_id = current_row.Cells(6).Value

        With frmshuukei_hanbai_shousai

            .lbl_shouhin_mei.Text = shouhin_name
            .lbl_kosuu.Text = CInt(suuryou).ToString("#,0") + "個"
            .lbl_kingaku.Text = CInt(kingaku).ToString("#,0") + "円"

            With .dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 5

                .Columns(0).Name = "NO"
                .Columns(1).Name = "納品日"
                .Columns(2).Name = "個数"
                .Columns(3).Name = "単価"
                .Columns(4).Name = "金額"

                .Columns(0).Width = 60
                .Columns(1).Width = 100
                .Columns(2).Width = 90
                .Columns(3).Width = 90
                .Columns(4).Width = 90

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            End With

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuushousai.*, hacchuu.iraibi" +
                " FROM tenpo RIGHT JOIN" +
                " (hacchuu RIGHT hash JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" +
                " ON tenpo.tenpoid = hacchuu.tenpoid" +
                " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kaishi & "' AND '" & hinichi_owari & "'" +
                " AND hacchuu.tenpoid = '" & tenpo_id & "' AND hacchuushousai.shouhinid = '" & shouhin_id & "'" +
                " ORDER BY hacchuu.iraibi DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            Dim mojiretsu(4)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                mojiretsu(1) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("iraibi").ToString()), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(2) = CInt(Trim(dt_server.Rows.Item(i).Item("kosuu"))).ToString("#,0")

                Dim tanka = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("tanka")) Then
                    tanka = CInt(Trim(dt_server.Rows.Item(i).Item("tanka")))
                End If
                mojiretsu(3) = tanka.ToString("#,0")

                Dim kei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kei")) Then
                    kei = CInt(Trim(dt_server.Rows.Item(i).Item("kei")))
                End If
                mojiretsu(4) = kei.ToString("#,0")

                frmshuukei_hanbai_shousai.dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        frmshuukei_hanbai_shousai.ShowDialog()

    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_hanbai_shuukei()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If cbx_shitei_shouhin.SelectedIndex <> -1 Then
            cbx_shitei_shouhin.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_2.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_2.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_1.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_1.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_gyousha_kubun.SelectedIndex <> -1 Then
            cbx_gyousha_kubun.SelectedIndex = -1
            Exit Sub
        End If

    End Sub
    Private Sub btn_clear_2_Click(sender As Object, e As EventArgs) Handles btn_clear_2.Click

        cbx_tenpo.SelectedIndex = -1
        cbx_shain.SelectedIndex = -1

    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click

        Dim dataGridView = dgv_kensakukekka

        If dataGridView.Rows.Count = 0 Then
            msg_go("抽出結果が表示されていません。")
            Exit Sub
        End If

        Dim filePath As String = DESKTOP_PATH + "\販売集計結果_" & Now.ToString("yyyyMMdd") & "-" & Now.ToString("hhmm") & ".csv"

        Dim columnsToExport As String() = {"NO", "店舗名", "商品名", "数量", "金額"}

        If output_csv_by_data_grid_view(filePath, dataGridView, columnsToExport) Then
            msg_go("デスクトップにCSVファイルを作成しました。", 64)
        End If

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

        ' TODO
        msg_go("未開発")
        Exit Sub

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

    End Sub

    Private Sub btn_denwa_chou_Click(sender As Object, e As EventArgs) Handles btn_denwa_chou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "1"
            .ShowDialog()
        End With
    End Sub

    Private Sub dtp_hinichi_kaishi_TextChanged(sender As Object, e As EventArgs) Handles dtp_hinichi_kaishi.TextChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub dtp_hinichi_owari_TextChanged(sender As Object, e As EventArgs) Handles dtp_hinichi_owari.TextChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_shain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shain.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_gyousha_kubun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gyousha_kubun.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2_cbx(1, shouhin_kubun_1_id)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin_cbx(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin_cbx(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub cbx_shitei_shouhin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shitei_shouhin.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        dgv_kensakukekka.Rows.Clear()
        set_tenpo_cbx(1, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub chk_haiban_Click(sender As Object, e As EventArgs) Handles chk_haiban.Click
        dgv_kensakukekka.Rows.Clear()
        set_shouhin_kubun_1_cbx(1)
    End Sub

    Private Sub chk_shuukei_shinai_torihikinai_tenpo_Click(sender As Object, e As EventArgs) Handles chk_shuukei_shinai_torihikinai_tenpo.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_shuukei_shinai_service_denpyou_Click(sender As Object, e As EventArgs) Handles chk_shuukei_shinai_service_denpyou.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub set_hanbai_shuukei()

        lbl_kekka.Text = ""

        Dim hinichi_kaishi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_owari.Value.ToString("yyyyMMdd")
        Dim gyousha_kubun = Mid(Trim(cbx_gyousha_kubun.Text), 1, 2)
        Dim shouhin_kubun_1 = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2 = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim shouhin_id = Mid(Trim(cbx_shitei_shouhin.Text), 1, 10)
        Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)
        Dim shain_id = Mid(Trim(cbx_shain.Text), 1, 2)

        If tenpo_id <> "" And shain_id <> "" Then
            msg_go("店舗と社員が両方選択されています。")
            Exit Sub
        End If

        If tenpo_id = "" And gyousha_kubun = "" Then
            If shain_id = "" Then
                msg_go("店舗または業者区分、区分１が選択されていません。")
            Else
                msg_go("業者区分、区分１が選択されていません。")
            End If
            Exit Sub
        End If

        Dim is_shuukei_shinai_torihikinai_tenpo = ""
        If chk_shuukei_shinai_torihikinai_tenpo.Checked Then
            is_shuukei_shinai_torihikinai_tenpo = "1"
        End If

        Dim is_shuukei_shinai_service_denpyou = ""
        If chk_shuukei_shinai_service_denpyou.Checked Then
            is_shuukei_shinai_service_denpyou = "1"
        End If

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 7

            .Columns(0).Name = "NO"
            .Columns(1).Name = "店舗名"
            .Columns(2).Name = "商品名"
            .Columns(3).Name = "数量"
            .Columns(4).Name = "金額"
            .Columns(5).Name = "商品ID"
            .Columns(6).Name = "店舗ID"

            .Columns(0).Width = 75
            .Columns(1).Width = 300
            .Columns(2).Width = 400
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 0
            .Columns(6).Width = 0

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(3).DefaultCellStyle.Format = "#,##0"
            .Columns(4).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 25

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim sum_goukei_suu = 0
        Dim sum_goukei_gaku = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid" +
                ", shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban" +
                ", SUM(hacchuushousai.kosuu) AS goukeisuu, SUM(hacchuushousai.kei) AS goukeigaku" +
                " FROM shouhin"

            If tenpo_id = "" And shain_id = "" Then
                query += " RIGHT JOIN ((hacchuu LEFT JOIN tenpo ON hacchuu.tenpoid = tenpo.tenpoid)" +
                    " LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid) ON shouhin.shouhinid = hacchuushousai.shouhinid"
            Else
                query += " RIGHT JOIN (tenpo RIGHT JOIN (hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" +
                    " ON tenpo.tenpoid = hacchuu.tenpoid) ON shouhin.shouhinid = hacchuushousai.shouhinid"
            End If

            Dim query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kaishi & "' AND '" & hinichi_owari & "'"


            If tenpo_id <> "" Then
                query_where += " AND hacchuu.tenpoid = '" & tenpo_id & "'"
            End If

            If shain_id <> "" Then
                query_where += " AND tenpo.shainid ='" & shain_id & "'"
            End If

            If gyousha_kubun <> "" Then
                query_where += " AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
            End If

            If shouhin_kubun_1 <> "" Then
                query_where += " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "'"
                If shouhin_kubun_2 <> "" Then
                    query_where += " AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "'"
                    If shouhin_id <> "" Then
                        query_where += " AND hacchuushousai.shouhinid = '" & shouhin_id & "'"
                    End If
                End If
            End If

            If is_shuukei_shinai_service_denpyou = "1" Then
                query_where += " AND hacchuushousai.kei <> 0"
            End If

            If tenpo_id <> "" Or shain_id <> "" Then
                If is_shuukei_shinai_torihikinai_tenpo = "1" Then
                    query_where += " AND (tenpo.kadou = '0' OR tenpo.kadou IS NULL) "
                End If
            End If

            query += query_where +
                " GROUP BY hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid" +
                ", shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban" +
                " ORDER BY shouhinid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin")

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString("D6")
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))

                Dim goukei_suu = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeisuu")) Then
                    goukei_suu = CInt(Trim(dt_server.Rows.Item(i).Item("goukeisuu")))
                End If
                mojiretsu(3) = goukei_suu
                sum_goukei_suu += goukei_suu

                Dim goukei_gaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeigaku")) Then
                    goukei_gaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeigaku")))
                End If
                mojiretsu(4) = goukei_gaku
                sum_goukei_gaku += goukei_gaku

                mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kekka.Text = "抽出結果：　合計数　" & sum_goukei_suu.ToString("#,0") & "　個, 合計額　" & sum_goukei_gaku.ToString("#,0") & "　円"

    End Sub

End Class