Imports System.Data.SqlClient

Public Class frmcheck_shouhin_check
    Private Sub frmcheck_shouhin_check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        set_shouhin_kubun_1(2)
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
            .ColumnCount = 7

            .Columns(0).Name = "NO"
            .Columns(1).Name = "日時"
            .Columns(2).Name = "社員"
            .Columns(3).Name = "作業内容"
            .Columns(4).Name = "元値"
            .Columns(5).Name = "移動値"
            .Columns(6).Name = "先値"

            .Columns(0).Width = 40
            .Columns(1).Width = 180
            .Columns(2).Width = 120
            .Columns(3).Width = 170
            .Columns(4).Width = 65
            .Columns(5).Width = 65
            .Columns(6).Width = 65

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(4).DefaultCellStyle.Format = "#,##0"
            .Columns(5).DefaultCellStyle.Format = "#,##0"
            .Columns(6).DefaultCellStyle.Format = "#,##0"

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT zaiko_ch.zaikoid, zaiko_ch.sonotoki, zaiko_ch.shouhinid, shouhin.shouhinmei, zaiko_ch.shainid" +
                ", shain.shainmei, zaiko_ch.motosuu, zaiko_ch.naiyou, zaiko_ch.idousuu, zaiko_ch.sakisuu" +
                " FROM shain RIGHT JOIN (zaiko_ch LEFT JOIN shouhin ON zaiko_ch.shouhinid = shouhin.shouhinid) ON shain.shainid = zaiko_ch.shainid" +
                " WHERE zaiko_ch.shouhinid = '" + shouhin_id + "'" +
                " ORDER BY zaiko_ch.sonotoki DESC, zaiko_ch.zaikoid DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_zaiko_ch")
            Dim dt_server As DataTable = ds_server.Tables("t_zaiko_ch")

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                Dim nichiji = Trim(dt_server.Rows.Item(i).Item("sonotoki"))
                Dim itsu = Date.ParseExact(Mid(nichiji, 1, 8), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                Dim nanji = Date.ParseExact(Mid(nichiji, 9), "HHmmss", Nothing).ToString("HH:mm:ss")
                mojiretsu(1) = itsu + " " + nanji
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shainmei"))

                Dim naiyou_no = Trim(dt_server.Rows.Item(i).Item("naiyou"))
                mojiretsu(3) = get_naiyou_name_by_no(naiyou_no)

                Dim motone = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("motosuu")) Then
                    motone = CInt(Trim(dt_server.Rows.Item(i).Item("motosuu")))
                End If
                mojiretsu(4) = motone

                Dim idoune = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("idousuu")) Then
                    idoune = CInt(Trim(dt_server.Rows.Item(i).Item("idousuu")))
                End If
                mojiretsu(5) = idoune

                Dim sakine = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("sakisuu")) Then
                    sakine = CInt(Trim(dt_server.Rows.Item(i).Item("sakisuu")))
                End If
                mojiretsu(6) = sakine

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' ----------------------------------------------------------

        'Dim sql_shouhin As String, rs_shouhin As New ADODB.Recordset
        'Dim shouhincount As Integer, shouhinGROW As Integer

        'Screen.MousePointer = vbHourglass

        'If no = 0 Then
        '    sql_shouhin = "SELECT zaiko_ch.zaikoid, zaiko_ch.sonotoki, zaiko_ch.shouhinid, shouhin.shouhinmei," &
        '        "zaiko_ch.shainid, shain.shainmei, zaiko_ch.motosuu, zaiko_ch.naiyou, zaiko_ch.idousuu," &
        '        "zaiko_ch.sakisuu" &
        '        " FROM shain RIGHT JOIN (zaiko_ch LEFT JOIN shouhin ON zaiko_ch.shouhinid = shouhin.shouhinid)" &
        '        " ON shain.shainid = zaiko_ch.shainid" &
        '        " Where (((zaiko_ch.shouhinid) = '" & shiteishouhinid & "'))" &
        '        " ORDER BY zaiko_ch.sonotoki DESC,zaiko_ch.zaikoid DESC;"
        'Else
        '    sql_shouhin = "SELECT zaiko_log.logid, zaiko_log.sonotoki, zaiko_log.shouhinid, shouhin.shouhinmei," &
        '        "zaiko_log.shainid, shain.shainmei, zaiko_log.newatai, zaiko_log.naiyou," &
        '        "zaiko_log.bikou" &
        '        " FROM shain RIGHT JOIN (zaiko_log LEFT JOIN shouhin ON zaiko_log.shouhinid = shouhin.shouhinid)" &
        '        " ON shain.shainid = zaiko_log.shainid" &
        '        " Where (((zaiko_log.shouhinid) = '" & shiteishouhinid & "'))" &
        '        " ORDER BY zaiko_log.sonotoki DESC,zaiko_log.logid DESC;"
        'End If


        'If FcSQlGet(1, rs_shouhin, sql_shouhin, WMsg) = False Then
        '    'If no = 0 Then
        '    '    With frmshouhincheck.DBGKEKKA
        '    '        .Rows = 1
        '    '        .ColWidth(0) = 500
        '    '        .ColWidth(1) = 2500
        '    '        .ColWidth(2) = 1500
        '    '        .ColWidth(3) = 2500
        '    '        .ColWidth(4) = 1000
        '    '        .ColWidth(5) = 1000
        '    '        .ColWidth(6) = 1000
        '    '        .Row = 0
        '    '        .Col = 0
        '    '        .CellAlignment = 4
        '    '        .Text = "No"
        '    '        .Col = 1
        '    '        .CellAlignment = 4
        '    '        .Text = "日時"
        '    '        .Col = 2
        '    '        .CellAlignment = 4
        '    '        .Text = "社員"
        '    '        .Col = 3
        '    '        .CellAlignment = 4
        '    '        .Text = "作業内容"
        '    '        .Col = 4
        '    '        .CellAlignment = 4
        '    '        .Text = "元値"
        '    '        .Col = 5
        '    '        .CellAlignment = 4
        '    '        .Text = "移動値"
        '    '        .Col = 6
        '    '        .CellAlignment = 4
        '    '        .Text = "先値"
        '    '    End With
        '    'Else
        '    '    With frmshouhincheck2.DBGKEKKA
        '    '        .Rows = 1
        '    '        .ColWidth(0) = 500
        '    '        .ColWidth(1) = 2500
        '    '        .ColWidth(2) = 1500
        '    '        .ColWidth(3) = 2500
        '    '        .ColWidth(4) = 1500
        '    '        .ColWidth(5) = 3800
        '    '        .ColWidth(6) = 0
        '    '        .Row = 0
        '    '        .Col = 0
        '    '        .CellAlignment = 4
        '    '        .Text = "No"
        '    '        .Col = 1
        '    '        .CellAlignment = 4
        '    '        .Text = "日時"
        '    '        .Col = 2
        '    '        .CellAlignment = 4
        '    '        .Text = "社員"
        '    '        .Col = 3
        '    '        .CellAlignment = 4
        '    '        .Text = "内容"
        '    '        .Col = 4
        '    '        .CellAlignment = 4
        '    '        .Text = "値"
        '    '        .Col = 5
        '    '        .CellAlignment = 4
        '    '        .Text = "備考"
        '    '    End With
        '    'End If
        '    'cnn.Close
        '    'Screen.MousePointer = vbDefault
        'Else
        '    If no = 0 Then
        '        frmshouhincheck.DBGKEKKA.Clear
        '    Else
        '        frmshouhincheck2.DBGKEKKA.Clear
        '    End If
        '    shouhincount = rs_shouhin.RecordCount
        '    rs_shouhin.MoveFirst
        '    If no = 0 Then
        '        With frmshouhincheck.DBGKEKKA
        '            .Rows = shouhincount + 1
        '            .ColWidth(0) = 500
        '            .ColWidth(1) = 2500
        '            .ColWidth(2) = 1500
        '            .ColWidth(3) = 2500
        '            .ColWidth(4) = 1000
        '            .ColWidth(5) = 1000
        '            .ColWidth(6) = 1000
        '            .Row = 0
        '            .Col = 0
        '            .CellAlignment = 4
        '            .Text = "No"
        '            .Col = 1
        '            .CellAlignment = 4
        '            .Text = "日時"
        '            .Col = 2
        '            .CellAlignment = 4
        '            .Text = "社員"
        '            .Col = 3
        '            .CellAlignment = 4
        '            .Text = "作業内容"
        '            .Col = 4
        '            .CellAlignment = 4
        '            .Text = "元値"
        '            .Col = 5
        '            .CellAlignment = 4
        '            .Text = "移動値"
        '            .Col = 6
        '            .CellAlignment = 4
        '            .Text = "先値"
        '        End With
        '    Else
        '        With frmshouhincheck2.DBGKEKKA
        '            .Rows = shouhincount + 1
        '            .ColWidth(0) = 500
        '            .ColWidth(1) = 2500
        '            .ColWidth(2) = 1500
        '            .ColWidth(3) = 2500
        '            .ColWidth(4) = 1500
        '            .ColWidth(5) = 3800
        '            .ColWidth(6) = 0
        '            .Row = 0
        '            .Col = 0
        '            .CellAlignment = 4
        '            .Text = "No"
        '            .Col = 1
        '            .CellAlignment = 4
        '            .Text = "日時"
        '            .Col = 2
        '            .CellAlignment = 4
        '            .Text = "社員"
        '            .Col = 3
        '            .CellAlignment = 4
        '            .Text = "内容"
        '            .Col = 4
        '            .CellAlignment = 4
        '            .Text = "値"
        '            .Col = 5
        '            .CellAlignment = 4
        '            .Text = "備考"
        '        End With
        '    End If
        '    For shouhinGROW = 1 To shouhincount
        '        If no = 0 Then
        '            With frmshouhincheck.DBGKEKKA
        '                .Row = shouhinGROW
        '                .Col = 0
        '                .Text = shouhinGROW
        '                .Col = 1
        '                .Text = Format(Mid(rs_shouhin!sonotoki, 1, 8), "@@@@/@@/@@") & Space(1) & Format(Mid(rs_shouhin!sonotoki, 9), "@@:@@:@@")
        '                .Col = 2
        '                .Text = rs_shouhin!shainmei
        '                .Col = 3
        '                Select Case rs_shouhin!naiyou
        '                    Case "0"
        '                        .Text = "納品書登録"
        '                    Case "1"
        '                        .Text = "仕入登録"
        '                    Case "2"
        '                        .Text = "仕入削除（伝票画面）"
        '                    Case "3"
        '                        .Text = "仕入削除（一覧画面）"
        '                    Case "4"
        '                        .Text = "納品書削除（メイン）"
        '                    Case "5"
        '                        .Text = "納品書削除（印刷画面）"
        '                    Case "6"
        '                        .Text = "納品書変更（印刷画面）"
        '                    Case "7"
        '                        .Text = "在庫数登録（商品一覧）"
        '                    Case "8"
        '                        .Text = "在庫数変更（商品一覧）"
        '                    Case "9"
        '                        .Text = "簡易変更（商品一覧）"
        '                End Select
        '                .Col = 4
        '                .Text = Format(rs_shouhin!motosuu, "#,##0;-#,##0")
        '                .Col = 5
        '                .Text = Format(rs_shouhin!idousuu, "#,##0;-#,##0")
        '                .Col = 6
        '                .Text = Format(rs_shouhin!sakisuu, "#,##0;-#,##0")
        '            End With
        '        Else
        '            With frmshouhincheck2.DBGKEKKA
        '                .Row = shouhinGROW
        '                .Col = 0
        '                .Text = shouhinGROW
        '                .Col = 1
        '                .Text = Format(Mid(rs_shouhin!sonotoki, 1, 8), "@@@@/@@/@@") & Space(1) & Format(Mid(rs_shouhin!sonotoki, 9), "@@:@@:@@")
        '                .Col = 2
        '                .Text = rs_shouhin!shainmei
        '                .Col = 3
        '                Select Case rs_shouhin!naiyou
        '                    Case "00", "0"
        '                        .Text = "売上登録"
        '                    Case "01"
        '                        .Text = "仕入登録"
        '                    Case "02"
        '                        .Text = "追加売上"
        '                    Case "03"
        '                        .Text = "商品登録"
        '                    Case "04"
        '                        .Text = "商品変更"
        '                    Case "05"
        '                        .Text = "納品書削除"
        '                    Case "06"
        '                        .Text = "仕入伝票戻し"
        '                    Case "07"
        '                        .Text = "仕入伝票削除"
        '                    Case "08"
        '                        .Text = "仕入履歴削除"
        '                    Case "09"
        '                        .Text = "メイン画面納品書削除"
        '                    Case "10"
        '                        .Text = "納品書数量直し"
        '                    Case "11"
        '                        .Text = "商品画面在庫直し"
        '                    Case "12"
        '                        .Text = "日時変更"
        '                End Select
        '                .Col = 4
        '                .CellAlignment = 4
        '                .Text = Trim(rs_shouhin!newatai)
        '                .Col = 5
        '                .Text = rs_shouhin!bikou
        '            End With
        '        End If
        '        rs_shouhin.MoveNext
        '    Next shouhinGROW
        '    rs_shouhin.Close
        '    cnn.Close
        '    Screen.MousePointer = vbDefault

        'End If

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click

        Dim kyou = Now.ToString("yyyyMMdd")
        Dim shiteibi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        If shiteibi = kyou Then
            Dim result = MessageBox.Show("チェック開始日が本日です。本日分のみのチェックでよろしいですか？。", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If

        cbx_shitei_shouhin.SelectedIndex = -1
        cbx_shouhin_kubun_2.SelectedIndex = -1
        cbx_shouhin_kubun_1.SelectedIndex = -1

        Dim error_data(5, 0) As String
        Dim error_data_count = 0

        error_data(0, 0) = "依頼日"
        error_data(1, 0) = "社員ID"
        error_data(2, 0) = "商品ID"
        error_data(3, 0) = "個数"
        error_data(4, 0) = "店舗ID"
        error_data(5, 0) = "納品書ID"

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.iraibi, hacchuu.shainid, hacchuu.tenpoid, hacchuu.nouhinshoid, hacchuushousai.*" +
                " FROM hacchuushousai LEFT JOIN hacchuu ON hacchuushousai.hacchuuid = hacchuu.hacchuuid" +
                " WHERE hacchuu.iraibi >= '" + shiteibi + "'" +
                " ORDER BY hacchuu.iraibi"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_hacchuu")
            Dim dt_server As DataTable = ds_server.Tables("t_hacchuu")

            Dim data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("チェックしたいデータが存在しません。")
                hide_shinkou_joukyou()
                Exit Sub
            End If

            Dim debug_counter = 0
            For i = 0 To data_count - 1

                If i = 0 Then
                    show_shinkou_joukyou(data_count)
                End If

                Dim iraibi = Trim(dt_server.Rows.Item(i).Item("iraibi").ToString())
                Dim shain_id = Trim(dt_server.Rows.Item(i).Item("shainid"))
                Dim shouhin_id = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                Dim kosuu = Trim(dt_server.Rows.Item(i).Item("kosuu").ToString)
                Dim tenpo_id = Trim(dt_server.Rows.Item(i).Item("tenpoid"))

                Dim nouhinsho_id = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    nouhinsho_id = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If

                Try

                    Dim query_2 = "SELECT * FROM zaiko_ch" +
                        " WHERE shouhinid = '" + shouhin_id + "' AND shainid = '" + shain_id + "'" +
                        " AND idousuu = " + kosuu + " AND naiyou = '0' AND iraibi = '" + iraibi + "'"

                    Dim da_server_2 As SqlDataAdapter = New SqlDataAdapter(query_2, cn_server)
                    Dim ds_server_2 As New DataSet
                    da_server_2.Fill(ds_server_2, "t_zaiko_ch")
                    Dim dt_server_2 As DataTable = ds_server_2.Tables("t_zaiko_ch")

                    If dt_server_2.Rows.Count = 0 Then

                        error_data_count += 1

                        ReDim Preserve error_data(5, error_data_count)
                        error_data(0, error_data_count) = Date.ParseExact(iraibi, "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                        error_data(1, error_data_count) = shain_id
                        error_data(2, error_data_count) = shouhin_id
                        error_data(3, error_data_count) = kosuu
                        error_data(4, error_data_count) = tenpo_id
                        error_data(5, error_data_count) = nouhinsho_id

                    End If

                    dt_server_2.Clear()
                    ds_server_2.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

                debug_counter += 1
                calculate_shinkou_joukyou(debug_counter, data_count)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            hide_shinkou_joukyou()
            Exit Sub
        End Try


        If error_data_count = 0 Then
            msg_go("チェックが完了しました。エラーはありませんでした。", 64)
            hide_shinkou_joukyou()
            Exit Sub
        End If

        msg_go("適合できないデータがあります。デスクトップに保存します。", 64)

        Dim filePath As String = DESKTOP_PATH + "\err_" & Now.ToString("yyyyMMdd") & "-" & Now.ToString("hhmmss") & ".csv"

        If create_csv_file(error_data, filePath, error_data_count) Then
            msg_go("デスクトップにデータを保存しました。", 64)
        End If

        hide_shinkou_joukyou()

    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2(2, shouhin_kubun_1_id)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_mishiyou_hihyouji = chk_mishiyou_hihyouji.Checked
        set_shitei_shouhin(2, shouhin_kubun_1_id, shouhin_kubun_2_id, , is_mishiyou_hihyouji)
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_mishiyou_hihyouji = chk_mishiyou_hihyouji.Checked
        set_shitei_shouhin(2, shouhin_kubun_1_id, shouhin_kubun_2_id, , is_mishiyou_hihyouji)
    End Sub

    Private Sub chk_mishiyou_hihyouji_Click(sender As Object, e As EventArgs) Handles chk_mishiyou_hihyouji.Click
        dgv_kensakukekka.Rows.Clear()
        set_shouhin_kubun_1(2)
    End Sub

    Private Function get_naiyou_name_by_no(naiyou_no As String)

        Dim naiyou_name = ""
        Select Case naiyou_no
            Case "0"
                naiyou_name = "納品書登録"
            Case "1"
                naiyou_name = "仕入登録"
            Case "2"
                naiyou_name = "仕入削除（伝票画面）"
            Case "3"
                naiyou_name = "仕入削除（一覧画面）"
            Case "4"
                naiyou_name = "納品書削除（メイン）"
            Case "5"
                naiyou_name = "納品書削除（印刷画面）"
            Case "6"
                naiyou_name = "納品書変更（印刷画面）"
            Case "7"
                naiyou_name = "在庫数登録（商品一覧）"
            Case "8"
                naiyou_name = "在庫数変更（商品一覧）"
            Case "9"
                naiyou_name = "簡易変更（商品一覧）"
        End Select

        Return naiyou_name

    End Function

    Private Sub show_shinkou_joukyou(max_count As Integer)

        gbx_shinkou_joukyou.Visible = True
        gbx_shinkou_joukyou.BringToFront()
        Dim x As Integer = 275
        Dim y As Integer = (ClientSize.Height - gbx_shinkou_joukyou.Height) \ 2
        gbx_shinkou_joukyou.Location = New Point(x, y)
        pgb_shinkou_joukyou.Minimum = 0
        pgb_shinkou_joukyou.Maximum = max_count
        pgb_shinkou_joukyou.Value = 0
        gbx_main.Enabled = False

        System.Windows.Forms.Application.DoEvents()

    End Sub

    Private Sub hide_shinkou_joukyou()

        gbx_main.Enabled = True
        gbx_shinkou_joukyou.Visible = False

    End Sub

    Private Sub calculate_shinkou_joukyou(counter As Integer, max_count As Integer)

        lbl_shinkou_doai.Text = counter.ToString("#,0") + " / " + max_count.ToString("#,0")
        lbl_shinkou_percent.Text = "" + (CDbl(counter) / CDbl(max_count) * 100).ToString(".00") + "%"
        pgb_shinkou_joukyou.Value = counter

        System.Windows.Forms.Application.DoEvents()

    End Sub

End Class