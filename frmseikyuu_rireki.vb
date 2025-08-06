Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmseikyuu_rireki

    Private Sub frmseikyuu_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))

        cbx_nen.Items.Clear()
        For i = STARTED_YEAR To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))

        cbx_tsuki.Items.Clear()
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))

        set_tenpo_cbx(3, chk_hihyouji_torihiki_nai.Checked)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "3"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_shuukei()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        With frmseikyuu_rireki_shousai

            With .dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 9

                .Columns(0).Name = "NO"
                .Columns(1).Name = "発注詳細ID"
                .Columns(2).Name = "納品日"
                .Columns(3).Name = "品名"
                .Columns(4).Name = "数量"
                .Columns(5).Name = "単価"
                .Columns(6).Name = "小計"
                .Columns(7).Name = "伝票番号"
                .Columns(8).Name = "摘要"

                .Columns(0).Width = 40
                .Columns(1).Width = 100
                .Columns(2).Width = 80
                .Columns(3).Width = 250
                .Columns(4).Width = 90
                .Columns(5).Width = 90
                .Columns(6).Width = 90
                .Columns(7).Width = 100
                .Columns(8).Width = 200

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(4).DefaultCellStyle.Format = "#,##0"
                .Columns(5).DefaultCellStyle.Format = "#,##0"
                .Columns(6).DefaultCellStyle.Format = "#,##0"

                '' 行の高さの指定
                '.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                '.ColumnHeadersHeight = 25

            End With

            Dim seikyuusho_id = dgv_kensakukekka.CurrentRow.Cells(1).Value
            Dim seikyuusho_hiduke = dgv_kensakukekka.CurrentRow.Cells(2).Value
            Dim tenpo_mei = dgv_kensakukekka.CurrentRow.Cells(3).Value
            Dim zengetsu_seikyuu_gaku = dgv_kensakukekka.CurrentRow.Cells(4).Value
            Dim shouhizei = dgv_kensakukekka.CurrentRow.Cells(9).Value
            Dim seikyuusho_bikou = dgv_kensakukekka.CurrentRow.Cells(15).Value
            Dim invoice = dgv_kensakukekka.CurrentRow.Cells(16).Value

            Dim nyuukin_gaku_goukei = 0
            Dim shoukei_gaku_goukei = 0
            Dim goukei_gaku_goukei = 0

            Dim debug_counter = 0
            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM seikyuushousai WHERE seikyuushoid = '" + seikyuusho_id + "'"

                Dim query_order = ""
                If invoice = "" Then
                    query_order = " ORDER BY motohizuke, seikyuushousaiid"
                Else
                    query_order = " ORDER BY seikyuushousaiid"
                End If

                query += query_order

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                Dim temp_table_name = "t_seikyuushousai"
                da_server.Fill(ds_server, temp_table_name)
                Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                Dim mojiretsu(8)
                For i = 0 To dt_server.Rows.Count - 1

                    debug_counter = i
                    If debug_counter = 22 Then
                        Dim test = 0
                    End If

                    mojiretsu(0) = (i + 1).ToString()
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("hacchuushousaiid"))

                    Dim hiduke = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("hizuke")) Then
                        Select Case hiduke
                            Case "", "9999"
                                hiduke = ""
                            Case "*****"
                                hiduke = "*****"
                            Case Else
                                hiduke = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hizuke")), "yyyyMMdd", Nothing).ToString("MM/dd")
                        End Select
                    End If
                    mojiretsu(2) = hiduke

                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("koumoku"))

                    Dim suuryou = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("suuryou")) Then
                        If Trim(dt_server.Rows.Item(i).Item("suuryou")) <> "" Then
                            suuryou = CInt(Trim(dt_server.Rows.Item(i).Item("suuryou")))
                        End If
                    End If
                    mojiretsu(4) = suuryou

                    Dim tannka = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("tannka")) Then
                        If Trim(dt_server.Rows.Item(i).Item("tannka")) <> "" Then
                            tannka = Trim(dt_server.Rows.Item(i).Item("tannka"))
                        End If
                    End If
                    mojiretsu(5) = tannka

                    Dim shoukei = 0
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("soukei")) Then
                        If Trim(dt_server.Rows.Item(i).Item("soukei")) <> "" Then
                            shoukei = CInt(Trim(dt_server.Rows.Item(i).Item("soukei")))
                        End If
                    End If
                    shoukei_gaku_goukei += shoukei
                    goukei_gaku_goukei += shoukei

                    Dim nyuukin = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("nyuukin")) Then
                        Dim temp_nyuukin = Trim(dt_server.Rows.Item(i).Item("nyuukin"))
                        If temp_nyuukin <> "" Then
                            Dim temp As Integer
                            If Integer.TryParse(temp_nyuukin.ToString(), temp) Then
                                nyuukin = CInt(temp_nyuukin).ToString("#,0")
                            Else
                                nyuukin = temp_nyuukin
                            End If
                        End If
                    End If

                    If invoice = "" Then
                        'Dim nyuukin = 0
                        'If Not IsDBNull(dt_server.Rows.Item(i).Item("nyuukin")) Then
                        '    nyuukin = CInt(Trim(dt_server.Rows.Item(i).Item("nyuukin")))
                        'End If
                        nyuukin_gaku_goukei += CInt(nyuukin)
                        mojiretsu(6) = nyuukin
                        mojiretsu(7) = shoukei
                    Else
                        mojiretsu(6) = shoukei
                        mojiretsu(7) = nyuukin
                    End If


                    Dim tekiyou = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("tekiyou")) Then
                        tekiyou = Trim(dt_server.Rows.Item(i).Item("tekiyou"))
                    End If
                    mojiretsu(8) = tekiyou

                    .dgv_kensakukekka.Rows.Add(mojiretsu)

                Next

                shoukei_gaku_goukei -= shouhizei

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                msg_go("i = " + debug_counter.ToString)
                Exit Sub
            End Try

            Dim souseikyuugaku = zengetsu_seikyuu_gaku - nyuukin_gaku_goukei + goukei_gaku_goukei

            .lbl_hiduke.Text = seikyuusho_hiduke
            .lbl_seikyuusho_id.Text = seikyuusho_id
            .lbl_tenpo_mei.Text = tenpo_mei
            .txt_bikou.Text = seikyuusho_bikou
            If invoice = "" Then
                .lbl_shoukei.Text = shoukei_gaku_goukei.ToString("#,0")
                .lbl_shouhizei.Text = shouhizei.ToString("#,0")
                .lbl_goukei.Text = goukei_gaku_goukei.ToString("#,0")
                .lbl_zengetsu_seikyuu_gaku.Text = zengetsu_seikyuu_gaku.ToString("#,0") '
                .lbl_nyuukin_gaku.Text = nyuukin_gaku_goukei.ToString("#,0")
                .lbl_seikyuu_gaku.Text = souseikyuugaku.ToString("#,0")
            Else
                set_seikyuusho_shousai_kingaku(seikyuusho_id)
            End If

            .ShowDialog()

        End With

        set_shuukei()

        ' ----------------------------------------------------------

        'Dim gridseikyuurireki As Long, shiteiseikyuushoid As String, sql_srs As String, rs_srs As New ADODB.Recordset
        'Dim ii As Integer, sousaisoukei As Long, sousaishouhizei As Long, sousaigoukei As Long
        'Dim zensiekyuu As Long, sounyuukin As Long, souseikyuugaku As Long, bibikou As String

        'Dim s_invoice As String

        ''On Error GoTo ERRORREC2
        'gridseikyuurireki = CLng(frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 0))
        ''On Error GoTo 0
        'shiteiseikyuushoid = frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 1)
        'sousaisoukei = 0
        'sounyuukin = 0
        'zensiekyuu = CLng(frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 4))
        'sousaishouhizei = CLng(frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 9))
        'bibikou = Trim(frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 15))

        's_invoice = Trim(frmseikyuurireki.gridseikyuurireki.Cell(flexcpText, , 16))

        'sousaigoukei = 0

        'If s_invoice = "" Then
        '    sql_srs = "SELECT *" &
        '        " FROM seikyuushousai" &
        '        " where seikyuushoid='" & shiteiseikyuushoid & "' order by motohizuke,seikyuushousaiid"
        'Else
        '    sql_srs = "SELECT *" &
        '        " FROM seikyuushousai" &
        '        " where seikyuushoid='" & shiteiseikyuushoid & "' order by seikyuushousaiid"
        'End If

        'If FcSQlGet(1, rs_srs, sql_srs, WMsg) = True Then
        '    ''grid_seikyurirekishousai_set rs_srs.RecordCount, s_invoice
        '    'rs_srs.MoveFirst
        '    'ii = 1
        '    'Do Until rs_srs.EOF
        '    '    With frmseikyuushorirekishousai.gridseikyuushonaiyoushousai
        '    '        .Row = ii
        '    '        .Col = 0
        '    '        .Text = ii
        '    '        .Col = 1
        '    '        .Text = rs_srs!hacchuushousaiid
        '    '        .Col = 2
        '    '        If IsNull(rs_srs!hizuke) Or Trim(rs_srs!hizuke) = "" Then
        '    '            .Text = ""
        '    '        ElseIf Trim(rs_srs!hizuke) = "*****" Then
        '    '            .Text = "*****"
        '    '        ElseIf Trim(rs_srs!hizuke) = "9999" Then
        '    '            .Text = ""
        '    '        Else
        '    '            .Text = Format(rs_srs!hizuke, "@@/@@")
        '    '        End If
        '    '        .Col = 3
        '    '        .CellAlignment = flexAlignLeftCenter
        '    '        .Text = Trim(rs_srs!koumoku)
        '    '        .Col = 4
        '    '        .CellAlignment = flexAlignRightCenter
        '    '        .Text = Format(rs_srs!suuryou, "#,##0;-#,##0")
        '    '        .Col = 5
        '    '        .CellAlignment = flexAlignRightCenter
        '    '        .Text = Format(rs_srs!tannka, "#,##0;-#,##0")

        '    '        If s_invoice = "" Then
        '    '            .Col = 6
        '    '            .CellAlignment = flexAlignRightCenter
        '    '            .Text = Format(rs_srs!nyuukin, "#,##0;-#,##0")
        '    '            If Trim(rs_srs!nyuukin) <> "" Then
        '    '                sounyuukin = sounyuukin + CLng(rs_srs!nyuukin)
        '    '            End If
        '    '            .Col = 7
        '    '            .CellAlignment = flexAlignRightCenter
        '    '            .Text = Format(rs_srs!soukei, "#,##0;-#,##0")
        '    '            If Trim(rs_srs!soukei) <> "" Then
        '    '                sousaisoukei = sousaisoukei + CLng(rs_srs!soukei)
        '    '                sousaigoukei = sousaigoukei + CLng(rs_srs!soukei)
        '    '            End If
        '    '        Else
        '    '            .Col = 7
        '    '            .CellAlignment = flexAlignRightCenter
        '    '            If IsNull(rs_srs!nyuukin) Then
        '    '                .Text = ""
        '    '            Else
        '    '                .Text = Trim(rs_srs!nyuukin)
        '    '            End If
        '    '            .Col = 6
        '    '            .CellAlignment = flexAlignRightCenter
        '    '            .Text = Format(rs_srs!soukei, "#,##0;-#,##0")
        '    '            If Trim(rs_srs!soukei) <> "" Then
        '    '                sousaisoukei = sousaisoukei + CLng(rs_srs!soukei)
        '    '                sousaigoukei = sousaigoukei + CLng(rs_srs!soukei)
        '    '            End If
        '    '        End If


        '    '        .Col = 8
        '    '        .CellAlignment = flexAlignLeftCenter
        '    '        If IsNull(rs_srs!tekiyou) Then
        '    '            .Text = ""
        '    '        Else
        '    '            .Text = Trim(rs_srs!tekiyou)
        '    '        End If

        '    '    End With
        '    '    ii = ii + 1
        '    '    rs_srs.MoveNext
        '    'Loop
        '    'sousaisoukei = sousaisoukei - sousaishouhizei
        '    'rs_srs.Close
        'Else
        '    'grid_seikyurirekishousai_set 0, s_invoice
        'End If

        '        cnn.Close
        '        souseikyuugaku = zensiekyuu - sounyuukin + sousaigoukei
        '        If s_invoice = "" Then
        '            frmseikyuushorirekishousai.lblhoukoku = "小計「" & Format(sousaisoukei, "#,##0;-#,##0") & "」" &
        '                                            "　消費税額「" & Format(sousaishouhizei, "#,##0;-#,##0") & "」" &
        '                                            "　売上総合計「" & Format(sousaigoukei, "#,##0;-#,##0") & "」" &
        '                                            "前月請求額「" & Format(zensiekyuu, "#,##0;-#,##0") & "」" &
        '                                             "　入金額「" & Format(sounyuukin, "#,##0;-#,##0") & "」" &
        '                                             "　請求額「" & Format(souseikyuugaku, "#,##0;-#,##0") & "」"
        '        Else
        '            frmseikyuushorirekishousai.lblhoukoku = seikyuu_shousai_gouke_get(0, shiteiseikyuushoid)
        '        End If

        '        frmseikyuushorirekishousai.txtbikou = bibikou
        '        frmseikyuushorirekishousai.lblseikyuushoid.Caption = shiteiseikyuushoid
        '        frmseikyuushorirekishousai.Show 1
        'Exit Sub
        'ERRORREC2:
        '        ret = MsgBox("詳細を表示したい項目を選択してから実行してください。", 16, "総合管理システム「SPSALES」")
        '        Exit Sub

    End Sub

    Private Sub set_seikyuusho_shousai_kingaku(seikyuusho_id As String)

        Dim shoukei = 0
        Dim shouhizei = 0
        Dim goukei = 0
        Dim nyuukin_gaku = 0
        Dim zengetsu_seikyuu_gaku = 0
        Dim seikyuu_gaku = 0
        Dim henpin_gaku = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid = '" & seikyuusho_id & "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count > 0 Then

                shoukei = CInt(Trim(dt_server.Rows.Item(0).Item("shoukei")))

                If Not IsDBNull(dt_server.Rows.Item(0).Item("hen")) Then
                    henpin_gaku = CInt(Trim(dt_server.Rows.Item(0).Item("hen")))
                    shoukei += henpin_gaku
                End If

                If Not IsDBNull(dt_server.Rows.Item(0).Item("shouhizei")) Then
                    shouhizei = CInt(Trim(dt_server.Rows.Item(0).Item("shouhizei")))
                    goukei = shoukei + shouhizei
                End If

                If Not IsDBNull(dt_server.Rows.Item(0).Item("nyuu")) Then
                    nyuukin_gaku = CInt(Trim(dt_server.Rows.Item(0).Item("nyuu")))
                End If

                If Not IsDBNull(dt_server.Rows.Item(0).Item("kuri")) Then
                    zengetsu_seikyuu_gaku = CInt(Trim(dt_server.Rows.Item(0).Item("kuri")))
                End If

                If Not IsDBNull(dt_server.Rows.Item(0).Item("seikyuukingaku")) Then
                    seikyuu_gaku = CInt(Trim(dt_server.Rows.Item(0).Item("seikyuukingaku")))
                End If

            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        With frmseikyuu_rireki_shousai
            .lbl_shoukei.Text = shoukei.ToString("#,0")
            .lbl_shouhizei.Text = shouhizei.ToString("#,0")
            .lbl_goukei.Text = goukei.ToString("#,0")
            .lbl_zengetsu_seikyuu_gaku.Text = zengetsu_seikyuu_gaku.ToString("#,0") '
            .lbl_nyuukin_gaku.Text = nyuukin_gaku.ToString("#,0")
            .lbl_seikyuu_gaku.Text = seikyuu_gaku.ToString("#,0")
        End With

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            Exit Sub
        End If

        If chk_sakujo.Checked = False Then
            msg_go("「削除する」にチェックをつけてから実行してください。")
            Exit Sub
        End If
        chk_sakujo.Checked = False

        If Not rbn_shubetsu_tenpo.Checked Then
            msg_go("削除は'店舗別'での集計後に実行してください。")
            Exit Sub
        End If

        Dim dgv = dgv_kensakukekka
        If Not (dgv.SortedColumn Is Nothing OrElse dgv.SortOrder = System.Windows.Forms.SortOrder.None) Then
            msg_go("並べ替えられていると削除できません。集計を再度行ってください。")
            Exit Sub
        End If

        Dim seikyuusho_id = dgv.CurrentRow.Cells(1).Value
        Dim tenpo_id = dgv.CurrentRow.Cells(12).Value

        msg_go("削除を開始します。", 64)
        Dim result As DialogResult = MessageBox.Show(
            "削除すると店舗に持っている繰越金額と前回請求日を削除したデータに基づいて書き換えます。他の値に変えたい場合は、削除する前にデータを確認してください。以下の請求履歴を削除しますか？" +
            vbCrLf + vbCrLf + "請求書ID： " + seikyuusho_id + vbCrLf + "店舗ID： " + tenpo_id, "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim kurikoshi_kingaku = dgv.CurrentRow.Cells(6).Value ' 入金後の繰越金額
        Dim kongetsu_uriagegaku = dgv.CurrentRow.Cells(7).Value
        Dim kongetsu_henpingaku = dgv.CurrentRow.Cells(8).Value
        Dim zeigaku = dgv.CurrentRow.Cells(9).Value
        Dim seikyuu_kingaku = dgv.CurrentRow.Cells(10).Value

        Dim currentRowIndex As Integer = dgv.CurrentCell.RowIndex
        Dim zenkai_seikyuubi = ""
        If currentRowIndex <dgv.Rows.Count - 1 Then
            zenkai_seikyuubi= Date.ParseExact(dgv(2, currentRowIndex + 1).Value, "yyyy/MM/dd", Nothing).ToString("yyyyMMdd")
        End If

        ' 請求詳細を削除
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuushousai WHERE seikyuushoid = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_seikyuushousai"
            da.Fill(ds, temp_table_name)

            Dim count = ds.Tables(temp_table_name).Rows.Count
            If count > 0 Then
                For i = count - 1 To 0 Step -1
                    ds.Tables(temp_table_name).Rows(i).Delete()
                Next
                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, temp_table_name)
            Else
                msg_go("請求詳細記録の削除に失敗しました。")
                ds.Clear()
                Exit Sub
            End If

            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 請求書を削除
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_seikyuusho_1"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count > 0 Then

                ds.Tables(temp_table_name).Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, temp_table_name)
                ds.Clear()

            Else
                msg_go("該当する請求書が見つかりません。")
                ds.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 入金
        Dim db_seikyuukingaku = 0
        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid2 = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_seikyuusho_2"
            da.Fill(ds, temp_table_name)

            For i = 0 To ds.Tables(temp_table_name).Rows.Count - 1
                db_seikyuukingaku += ds.Tables(temp_table_name).Rows(i)("seikyuukingaku")
                ds.Tables(temp_table_name).Rows(i)("joukyou") = DBNull.Value
                ds.Tables(temp_table_name).Rows(i)("seikyuushoid2") = DBNull.Value
            Next

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 売上
        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuu WHERE seikyuushoid = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_hacchuu"
            da.Fill(ds, temp_table_name)

            For i = 0 To ds.Tables(temp_table_name).Rows.Count - 1
                ds.Tables(temp_table_name).Rows(i)("joukyou") = "0"
                ds.Tables(temp_table_name).Rows(i)("seikyuushoid") = DBNull.Value
            Next

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        '店舗
        Dim moto_kurikoshi_kingaku = 0
        Dim new_kurikoshi_kingaku = 0
        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM tenpo WHERE tenpoid = '" + tenpo_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_tenpo"
            da.Fill(ds, temp_table_name)

            Dim count = ds.Tables(temp_table_name).Rows.Count
            If count = 0 Then
                msg_go("該当する店舗が見つかりません")
                ds.Clear()
                Exit Sub
            End If

            ' 元の繰越金額
            If Not IsDBNull(ds.Tables(temp_table_name).Rows(0)("kurikoshi")) Then
                moto_kurikoshi_kingaku = ds.Tables(temp_table_name).Rows(0)("kurikoshi")
            End If

            ' 今回の計算額 
            Dim keisangaku As Integer = kongetsu_uriagegaku + kongetsu_henpingaku + zeigaku

            ' 元の繰越金額 - 今回の計算額
            new_kurikoshi_kingaku = moto_kurikoshi_kingaku - keisangaku

            ' 請求書の繰越金額とDB上の繰越金額とチェック
            If seikyuu_kingaku <> moto_kurikoshi_kingaku Then
                msg_go("請求書の繰越額とDB上の繰越金額が違います。チェックしてください。")
            End If

            ' 入金後の繰越額と上記の計算が同じかどうかをチェック
            If kurikoshi_kingaku <> new_kurikoshi_kingaku Then
                msg_go("繰越額が不正です。チェックしてください。")
            End If

            ' 繰越金額
            ds.Tables(temp_table_name).Rows(0)("kurikoshi") = new_kurikoshi_kingaku

            ' 請求日
            If zenkai_seikyuubi = "" Then
                ds.Tables(temp_table_name).Rows(0)("seikyuubi") = DBNull.Value
            Else
                ds.Tables(temp_table_name).Rows(0)("seikyuubi") = zenkai_seikyuubi
            End If

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Dim bikou = "旧繰越：" + moto_kurikoshi_kingaku.ToString("#,0") + "   新繰越：" + new_kurikoshi_kingaku.ToString("#,0")
        Dim shainid = frmmain.lblshokuinid.Text
        Dim naiyou = 3
        Dim new_atai = db_seikyuukingaku.ToString
        If kurikoshi_log_edit(shainid, tenpo_id, naiyou, new_atai, bikou) = False Then
            msg_go("繰越ログ登録作業中にエラーが発生しました。")
            Exit Sub
        End If

        msg_go("選択した請求書を正常に削除しました。", 64)
        set_shuukei()

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click
        ' TODO
    End Sub

    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click

    End Sub

    Private Sub btn_clear_tenpo_Click(sender As Object, e As EventArgs) Handles btn_clear_tenpo.Click
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_cbx(3, chk_hihyouji_torihiki_nai.Checked)
        clear_shuukei()
    End Sub

    Private Sub chk_invoice_Click(sender As Object, e As EventArgs) Handles chk_invoice.Click
        clear_shuukei()
    End Sub

    Private Sub rbn_shubetsu_kikan_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_kikan.Click
        gbx_shiharai_tsuki.Enabled = True
        gbx_tenpo.Enabled = False
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_tenpo_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_tenpo.Click
        gbx_shiharai_tsuki.Enabled = False
        gbx_tenpo.Enabled = True
        cbx_tsuki.SelectedIndex = -1
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub clear_shuukei()
        dgv_kensakukekka.Rows.Clear()
        lbl_kekka.Text = "総請求合計額 0円 " & "　（内消費税 0円）"
    End Sub

    Private Sub set_shuukei()

        lbl_kekka.Text = "総請求合計額 0円 " & "　（内消費税 0円）"

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 17

            .Columns(0).Name = "NO"
            .Columns(1).Name = "請求書ID"
            .Columns(2).Name = "発行日"
            .Columns(3).Name = "店舗名"
            .Columns(4).Name = "前月" + vbCrLf + "請求額"
            .Columns(5).Name = "今月" + vbCrLf + "入金額"
            .Columns(6).Name = "繰越" + vbCrLf + "額"
            .Columns(7).Name = "今月" + vbCrLf + "売上額"
            .Columns(8).Name = "今月" + vbCrLf + "返品額"
            .Columns(9).Name = "消費" + vbCrLf + "税"
            .Columns(10).Name = "請求" + vbCrLf + "額"
            .Columns(11).Name = "伝数"
            .Columns(12).Name = "n/a"
            .Columns(13).Name = ""
            .Columns(14).Name = ""
            .Columns(15).Name = ""
            .Columns(16).Name = ""

            .Columns(0).Width = 50
            .Columns(1).Width = 90
            .Columns(2).Width = 110
            .Columns(3).Width = 280
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(6).Width = 80
            .Columns(7).Width = 80
            .Columns(8).Width = 80
            .Columns(9).Width = 80
            .Columns(10).Width = 80
            .Columns(11).Width = 60
            .Columns(12).Width = 60
            .Columns(13).Width = 60
            .Columns(14).Width = 60
            .Columns(15).Width = 60
            .Columns(16).Width = 60

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(4).DefaultCellStyle.Format = "#,##0"
            .Columns(5).DefaultCellStyle.Format = "#,##0"
            .Columns(6).DefaultCellStyle.Format = "#,##0"
            .Columns(7).DefaultCellStyle.Format = "#,##0"
            .Columns(8).DefaultCellStyle.Format = "#,##0"
            .Columns(9).DefaultCellStyle.Format = "#,##0"
            .Columns(10).DefaultCellStyle.Format = "#,##0"
            .Columns(11).DefaultCellStyle.Format = "#,##0"

        End With

        Dim goukei_seikyuugaku = 0
        Dim goukei_shouhizei = 0
        Try

            Dim query = "SELECT seikyuusho.*, tenpo.tenpomei, tenpo.tenpofurigana" +
                " FROM seikyuusho LEFT JOIN tenpo ON seikyuusho.tenpoid = tenpo.tenpoid"

            Dim query_where = " WHERE seikyuusho.seikyuu_st = '0'"
            Dim query_order = ""
            If rbn_shubetsu_kikan.Checked Then

                Dim nen = cbx_nen.Text
                Dim tsuki = cbx_tsuki.Text
                If nen = "" Or tsuki = "" Then
                    msg_go("年と月は両方選択してください。")
                    Exit Sub
                End If
                Dim hinichi_kaishi = nen + tsuki + "01"
                Dim hinichi_owari = nen + tsuki + "31"

                query_where += " AND seikyuusho.hiduke BETWEEN '" + hinichi_kaishi + "' AND '" + hinichi_owari + "'"
                query_order = " ORDER BY seikyuusho.hiduke, tenpo.tenpofurigana"

            ElseIf rbn_shubetsu_tenpo.Checked Then

                Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)
                If tenpo_id = "" Then
                    msg_go("店舗を選択してください。")
                    Exit Sub
                End If

                query_where += " AND seikyuusho.tenpoid = '" + tenpo_id + "'"
                query_order = " ORDER BY seikyuusho.hiduke DESC, tenpo.tenpofurigana"

            End If

            query += query_where + query_order

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(16)
            For i = 0 To dt_server.Rows.Count - 1

                Dim dami = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("dami")) Then
                    dami = Trim(dt_server.Rows.Item(i).Item("dami"))
                End If
                If dami <> "1" Then
                    dami = ""
                End If

                mojiretsu(0) = (i + 1).ToString()
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                Dim kuri = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kuri")) Then
                    kuri = CInt(Trim(dt_server.Rows.Item(i).Item("kuri")))
                End If
                mojiretsu(4) = kuri

                Dim nyuu = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nyuu")) Then
                    nyuu = CInt(Trim(dt_server.Rows.Item(i).Item("nyuu")))
                End If
                mojiretsu(5) = nyuu

                Dim zan = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("zan")) Then
                    zan = CInt(Trim(dt_server.Rows.Item(i).Item("zan")))
                End If
                mojiretsu(6) = zan

                Dim shoukei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shoukei")) Then
                    shoukei = CInt(Trim(dt_server.Rows.Item(i).Item("shoukei")))
                End If
                mojiretsu(7) = shoukei

                Dim hen = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("hen")) Then
                    hen = CInt(Trim(dt_server.Rows.Item(i).Item("hen")))
                End If
                mojiretsu(8) = hen

                Dim shouhizei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhizei")) Then
                    shouhizei = CInt(Trim(dt_server.Rows.Item(i).Item("shouhizei")))
                End If
                mojiretsu(9) = shouhizei
                goukei_shouhizei += shouhizei

                Dim seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                mojiretsu(10) = seikyuukingaku
                goukei_seikyuugaku += seikyuukingaku

                mojiretsu(11) = CInt(Trim(dt_server.Rows.Item(i).Item("maisuu")))
                mojiretsu(12) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                mojiretsu(13) = dami

                Dim nashi = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nashi")) Then
                    nashi = "1"
                End If
                mojiretsu(14) = nashi

                Dim seikyuubikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuubikou")) Then
                    seikyuubikou = Trim(dt_server.Rows.Item(i).Item("seikyuubikou"))
                End If
                mojiretsu(15) = seikyuubikou

                Dim invoice = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("invoice")) Then
                    invoice = Trim(dt_server.Rows.Item(i).Item("invoice"))
                End If
                If invoice <> "1" Then
                    invoice = ""
                End If
                mojiretsu(16) = invoice

                dgv_kensakukekka.Rows.Add(mojiretsu)

                If dami = "1" Then
                    dgv_kensakukekka.Rows(i).Cells(2).Style.BackColor = Color.Yellow
                End If

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kekka.Text = "総請求合計額 " + goukei_seikyuugaku.ToString("#,0") + "円 " & "　（内消費税 " + goukei_shouhizei.ToString("#,0") + "円）"

    End Sub

End Class