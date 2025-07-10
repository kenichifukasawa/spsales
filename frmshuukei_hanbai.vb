Imports System.Data.SqlClient

Public Class frmshuukei_hanbai

    Private Sub frmshuukei_hanbai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")

        set_gyousha_kubun(1)
        set_shouhin_kubun_1(1)
        set_tenpo_name(1, chk_hihyouji_torihiki_nai.Checked)
        set_shain_name(1)

#If DEBUG Then ' TODO:Debug
        dtp_hinichi_kaishi.Value = Now.ToString("2025/05/01")
        dtp_hinichi_owari.Value = Now.ToString("2025/05/31")
        cbx_gyousha_kubun.SelectedIndex = 0
        cbx_shain.SelectedIndex = 3
#End If

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("集計結果が表示されていません。")
            Exit Sub
        End If

        If dgv_kensakukekka.CurrentRow.Index = -1 Then
            msg_go("詳細を表示したい項目を選択してから実行してください。")
            Exit Sub
        End If
        Dim current_row = dgv_kensakukekka.CurrentRow

        Dim hinichi_kanshi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_owari.Value.ToString("yyyyMMdd")

        Dim salon_name = current_row.Cells(1).Value
        Dim shouhin_name = current_row.Cells(2).Value
        Dim suuryou = current_row.Cells(3).Value.ToString
        Dim kingaku = current_row.Cells(4).Value.ToString
        Dim shouhin_id = current_row.Cells(5).Value
        Dim tenpo_id = current_row.Cells(6).Value

        With frmshuukei_hanbai_shousai

            .lbl_tenpo_mei.Text = ""
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

            End With

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuushousai.*, hacchuu.iraibi" +
                " FROM tenpo RIGHT JOIN" +
                " (hacchuu RIGHT hash JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" +
                " ON tenpo.tenpoid = hacchuu.tenpoid" +
                " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
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

        dgv_kensakukekka.Rows.Clear()

    End Sub
    Private Sub btn_clear_2_Click(sender As Object, e As EventArgs) Handles btn_clear_2.Click

        cbx_tenpo.SelectedIndex = -1
        cbx_shain.SelectedIndex = -1
        dgv_kensakukekka.Rows.Clear()

    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

        ' TODO
        msg_go("未開発")
        Exit Sub

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("抽出結果が表示されていません。")
            Exit Sub
        End If

    End Sub

    Private Sub btn_denwa_chou_Click(sender As Object, e As EventArgs) Handles btn_denwa_chou.Click

    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2(1, shouhin_kubun_1_id)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_name(1, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub set_hanbai_shuukei()

        lbl_kekka.Text = ""

        Dim hinichi_kanshi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
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
            .Columns(1).Name = "サロン名"
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

        End With

        Dim sum_goukei_suu = 0
        Dim sum_goukei_gaku = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhin"

            query = "SELECT hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban" +
                    ", SUM(hacchuushousai.kosuu) AS goukeisuu, SUM(hacchuushousai.kei) AS goukeigaku" +
                    " FROM shouhin"

            If tenpo_id = "" And shain_id = "" Then
                query += " RIGHT JOIN ((hacchuu LEFT JOIN tenpo ON hacchuu.tenpoid = tenpo.tenpoid) LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid) ON shouhin.shouhinid = hacchuushousai.shouhinid"
            Else
                query += " RIGHT JOIN (tenpo RIGHT JOIN (hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid) ON tenpo.tenpoid = hacchuu.tenpoid) ON shouhin.shouhinid = hacchuushousai.shouhinid"
            End If

            Dim query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'"


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

            If tenpo_id = "" And shain_id = "" Then
                query += query_where + " GROUP BY shouhin.shouhinmei, hacchuushousai.shouhinid, hacchuu.tenpoid, tenpo.tenpomei, shouhin.haiban"
            Else
                If is_shuukei_shinai_torihikinai_tenpo = "1" Then
                    query_where += " AND (tenpo.kadou = '0' OR tenpo.kadou IS NULL) "
                End If
                query += query_where + " GROUP BY hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban"
            End If

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

        ' ----------------------------------------------------------

        ''shouhin_shuukei(kai1, kai2, ku1, ku2, ku3, ten, newsa, newsa2, ku0, shain_id)
        ''Sub shouhin_shuukei(hinichi_kanshi As String, hinichi_owari As String, shouhin_kubun_1 As String, shouhin_kubun_2 As String, shitei_shouhin As String, tenpo_id As String, is_shuukei_shinai_service_denpyou As String, is_shuukei_shinai_torihikinai_tenpo As String, gyousha_kubun As String, shain_id As String)


        ''Dim query_where = ""
        ''Dim query = ""

        'If tenpo_id <> "" Then
        '    ''query = "SELECT hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei," &
        '    ''            "Sum(hacchuushousai.kosuu) AS goukeisuu, Sum(hacchuushousai.kei) AS goukeigaku," &
        '    ''            "shouhin.shouhinkubunid,shouhin.shouhinkubunid2,shouhin.haiban" &
        '    ''            " FROM shouhin RIGHT JOIN" &
        '    ''            "(tenpo RIGHT JOIN (hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid =" &
        '    ''            "hacchuushousai.hacchuuid) ON tenpo.tenpoid = hacchuu.tenpoid) ON shouhin.shouhinid =" &
        '    ''            "hacchuushousai.shouhinid" &
        '    ''            " WHERE (hacchuu.iraibi Between '" & hinichi_kanshi & "' And '" & hinichi_owari & "')" &
        '    ''            " and hacchuu.tenpoid ='" & tenpo_id & "'"
        '    ''If gyousha_kubun <> "" Then
        '    ''    query_where += " and shouhin.shouhinkubunid0='" & gyousha_kubun & "'"
        '    ''End If

        '    ''If shouhin_kubun_1 <> "" Then
        '    ''    query_where += " and shouhin.shouhinkubunid='" & shouhin_kubun_1 & "'"
        '    ''    If shouhin_kubun_2 <> "" Then
        '    ''        query_where += " and shouhin.shouhinkubunid2='" & shouhin_kubun_2 & "'"
        '    ''        If shitei_shouhin <> "" Then
        '    ''            query_where += " and hacchuushousai.shouhinid='" & shitei_shouhin & "'"
        '    ''        End If
        '    ''    End If
        '    ''End If
        '    ''If is_shuukei_shinai_service_denpyou = "1" Then
        '    ''    query_where += " and hacchuushousai.kei<>0"
        '    ''End If
        '    ''If is_shuukei_shinai_torihikinai_tenpo = "1" Then
        '    ''    query_where += " and (tenpo.kadou = '0' or tenpo.kadou is null) "
        '    ''End If
        '    ''query += query_where & " GROUP BY hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban"


        '    frmshuukeishouhin.lblsql.Caption = query

        '    If FcSQlGet(1, rs_shoushuu, query, WMsg) = False Then

        '    Else
        '        frmshuukeishouhin.gridkekka.Clear
        '        hacchuurirekicount = rs_shoushuu.RecordCount
        '        rs_shoushuu.MoveFirst

        '        For hacchuurirekiGROW = 1 To hacchuurirekicount
        '            With frmshuukeishouhin.gridkekka
        '                If IsNull(rs_shoushuu!haiban) Then
        '                Else
        '                    .Cell(flexcpBackColor, hacchuurirekiGROW, 1, hacchuurirekiGROW, 6) = &HC0C0FF
        '                End If
        '                .Row = hacchuurirekiGROW
        '                .Col = 0
        '                .Text = Format(hacchuurirekiGROW, "000000")
        '                .Col = 1
        '                .Text = rs_shoushuu!tenpomei
        '                .Col = 2
        '                .Text = rs_shoushuu!shouhinmei
        '                .Col = 3
        '                If IsNull(rs_shoushuu!goukeisuu) Then
        '                    .Text = ""
        '                Else
        '                    goukei_suu = goukei_suu + CLng(rs_shoushuu!goukeisuu)
        '                    .Text = Format(rs_shoushuu!goukeisuu, "#,##0;-#,##0")
        '                End If
        '                .Col = 4
        '                If IsNull(rs_shoushuu!goukeigaku) Then
        '                    .Text = ""
        '                Else
        '                    goukei_gaku = goukei_gaku + CLng(rs_shoushuu!goukeigaku)
        '                    .Text = Format(rs_shoushuu!goukeigaku, "#,##0;-#,##0")
        '                End If
        '                .Col = 5
        '                .Text = rs_shoushuu!shouhinid
        '                .Col = 6
        '                .Text = rs_shoushuu!tenpoid
        '            End With
        '            rs_shoushuu.MoveNext
        '        Next hacchuurirekiGROW
        '        rs_shoushuu.Close

        '        cnn.Close
        '        Screen.MousePointer = vbDefault

        '    End If

        'Else


        '    If shain_id <> "" Then

        '        ''query = "SELECT hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei," &
        '        ''                          "Sum(hacchuushousai.kosuu) AS goukeisuu, Sum(hacchuushousai.kei) AS goukeigaku," &
        '        ''                          "shouhin.shouhinkubunid,shouhin.shouhinkubunid2,shouhin.haiban" &
        '        ''                          " FROM shouhin RIGHT JOIN" &
        '        ''                          "(tenpo RIGHT JOIN (hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid =" &
        '        ''                          "hacchuushousai.hacchuuid) ON tenpo.tenpoid = hacchuu.tenpoid) ON shouhin.shouhinid =" &
        '        ''                          "hacchuushousai.shouhinid" &
        '        ''                          " WHERE (hacchuu.iraibi Between '" & hinichi_kanshi & "' And '" & hinichi_owari & "')" &
        '        ''                          " and tenpo.shainid ='" & shain_id & "'"
        '        ''If gyousha_kubun <> "" Then
        '        ''    query_where += " and shouhin.shouhinkubunid0='" & gyousha_kubun & "'"
        '        ''End If

        '        ''If shouhin_kubun_1 <> "" Then
        '        ''    query_where += " and shouhin.shouhinkubunid='" & shouhin_kubun_1 & "'"
        '        ''    If shouhin_kubun_2 <> "" Then
        '        ''        query_where += " and shouhin.shouhinkubunid2='" & shouhin_kubun_2 & "'"
        '        ''        If shitei_shouhin <> "" Then
        '        ''            query_where += " and hacchuushousai.shouhinid='" & shitei_shouhin & "'"
        '        ''        End If
        '        ''    End If
        '        ''End If
        '        ''If is_shuukei_shinai_service_denpyou = "1" Then
        '        ''    query_where += " and hacchuushousai.kei<>0"
        '        ''End If
        '        ''If is_shuukei_shinai_torihikinai_tenpo = "1" Then
        '        ''    query_where += " and (tenpo.kadou = '0' or tenpo.kadou is null) "
        '        ''End If
        '        ''query += query_where & " GROUP BY hacchuu.tenpoid, tenpo.kadou, tenpo.tenpomei, hacchuushousai.shouhinid, shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid2, shouhin.haiban"


        '        frmshuukeishouhin.lblsql.Caption = query

        '        If FcSQlGet(1, rs_shoushuu, query, WMsg) = False Then

        '        Else
        '            frmshuukeishouhin.gridkekka.Clear
        '            hacchuurirekicount = rs_shoushuu.RecordCount
        '            rs_shoushuu.MoveFirst

        '            For hacchuurirekiGROW = 1 To hacchuurirekicount
        '                With frmshuukeishouhin.gridkekka
        '                    If IsNull(rs_shoushuu!haiban) Then
        '                    Else
        '                        .Cell(flexcpBackColor, hacchuurirekiGROW, 1, hacchuurirekiGROW, 6) = &HC0C0FF
        '                    End If
        '                    .Row = hacchuurirekiGROW
        '                    .Col = 0
        '                    .Text = Format(hacchuurirekiGROW, "000000")
        '                    .Col = 1
        '                    .Text = rs_shoushuu!tenpomei
        '                    .Col = 2
        '                    .Text = rs_shoushuu!shouhinmei
        '                    .Col = 3
        '                    If IsNull(rs_shoushuu!goukeisuu) Then
        '                        .Text = ""
        '                    Else
        '                        goukei_suu = goukei_suu + CLng(rs_shoushuu!goukeisuu)
        '                        .Text = Format(rs_shoushuu!goukeisuu, "#,##0;-#,##0")
        '                    End If
        '                    .Col = 4
        '                    If IsNull(rs_shoushuu!goukeigaku) Then
        '                        .Text = ""
        '                    Else
        '                        goukei_gaku = goukei_gaku + CLng(rs_shoushuu!goukeigaku)
        '                        .Text = Format(rs_shoushuu!goukeigaku, "#,##0;-#,##0")
        '                    End If
        '                    .Col = 5
        '                    .Text = rs_shoushuu!shouhinid
        '                    .Col = 6
        '                    .Text = rs_shoushuu!tenpoid
        '                End With
        '                rs_shoushuu.MoveNext
        '            Next hacchuurirekiGROW
        '            rs_shoushuu.Close

        '            cnn.Close
        '            Screen.MousePointer = vbDefault

        '        End If

        '    Else

        '        ''query = "SELECT Sum(hacchuushousai.kosuu) AS goukeisuu, Sum(hacchuushousai.kei) AS goukeigaku," &
        '        ''                            "hacchuu.tenpoid, shouhin.shouhinmei,hacchuushousai.shouhinid,shouhin.haiban,tenpo.tenpomei " &
        '        ''                            " FROM shouhin RIGHT JOIN ((hacchuu left join tenpo on hacchuu.tenpoid=tenpo.tenpoid) LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" &
        '        ''                            "ON shouhin.shouhinid = hacchuushousai.shouhinid" &
        '        ''                            " WHERE (hacchuu.iraibi Between '" & hinichi_kanshi & "' And '" & hinichi_owari & "')"

        '        ''query_where = ""
        '        ''If gyousha_kubun <> "" Then
        '        ''    query_where += " and shouhin.shouhinkubunid0='" & gyousha_kubun & "'"
        '        ''End If
        '        ''If shouhin_kubun_1 <> "" Then
        '        ''    query_where += " and (shouhin.shouhinkubunid='" & shouhin_kubun_1 & "')"
        '        ''    If shouhin_kubun_2 <> "" Then
        '        ''        query_where += " and (shouhin.shouhinkubunid2='" & shouhin_kubun_2 & "')"
        '        ''        If shitei_shouhin <> "" Then
        '        ''            query_where += " and (hacchuushousai.shouhinid='" & shitei_shouhin & "')"
        '        ''        End If
        '        ''    End If
        '        ''End If
        '        ''query_where += query_where

        '        ''If is_shuukei_shinai_service_denpyou = "1" Then
        '        ''    query_where += " and (hacchuushousai.kei<>0)"
        '        ''End If
        '        ''query += query_where & " GROUP BY  shouhin.shouhinmei,hacchuushousai.shouhinid,hacchuu.tenpoid,tenpo.tenpomei,shouhin.haiban"

        '        frmshuukeishouhin.lblsql.Caption = query

        '        riarucount = 1
        '        sakujosuu = 0
        '        If FcSQlGet(1, rs_shoushuu, query, WMsg) = False Then

        '        Else
        '            frmshuukeishouhin.gridkekka.Clear
        '            hacchuurirekicount = rs_shoushuu.RecordCount
        '            rs_shoushuu.MoveFirst

        '            For hacchuurirekiGROW = 1 To hacchuurirekicount
        '                With frmshuukeishouhin.gridkekka
        '                    If IsNull(rs_shoushuu!haiban) Then
        '                    Else
        '                        .Cell(flexcpBackColor, riarucount, 1, riarucount, 6) = &HC0C0FF
        '                    End If
        '                    .Row = riarucount
        '                    .Col = 1

        '                    .Text = rs_shoushuu!tenpomei
        '                    .Col = 0
        '                    .Text = Format(hacchuurirekiGROW, "000000")
        '                    .Col = 2
        '                    .Text = rs_shoushuu!shouhinmei
        '                    .Col = 3
        '                    If IsNull(rs_shoushuu!goukeisuu) Then
        '                        .Text = ""
        '                    Else
        '                        goukei_suu = goukei_suu + CLng(rs_shoushuu!goukeisuu)
        '                        .Text = Format(rs_shoushuu!goukeisuu, "#,##0;-#,##0")
        '                    End If
        '                    .Col = 4
        '                    If IsNull(rs_shoushuu!goukeigaku) Then
        '                        .Text = ""
        '                    Else
        '                        goukei_gaku = goukei_gaku + CLng(rs_shoushuu!goukeigaku)
        '                        .Text = Format(rs_shoushuu!goukeigaku, "#,##0;-#,##0")
        '                    End If
        '                    .Col = 5
        '                    .Text = rs_shoushuu!shouhinid
        '                    .Col = 6
        '                    .Text = rs_shoushuu!tenpoid
        '                End With
        '                rs_shoushuu.MoveNext
        '                riarucount = riarucount + 1
        '            Next hacchuurirekiGROW
        '            rs_shoushuu.Close

        '            cnn.Close
        '            Screen.MousePointer = vbDefault

        '        End If
        '    End If

        'End If

        'frmshuukeishouhin.l1.Caption = goukei_suu
        'frmshuukeishouhin.l2.Caption = Format(goukei_gaku, "#,##0;-#,##0")
        'frmshuukeishouhin.lblgoukei.Caption = "抽出結果：　合計数　" & goukei_suu & "　個, 合計額　" & Format(goukei_gaku, "#,##0;-#,##0") & "　円"

        'Exit Sub

    End Sub

End Class