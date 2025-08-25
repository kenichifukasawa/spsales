Imports System.Data.SqlClient

Public Class frmseikyuusho_hakkou_insatsu
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub frmseikyuusho_hakkou_insatsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_shimebi.Items.AddRange(Deadline.Names)
        cbx_shimebi.Items.Add("指定")

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

        set_hinichi_cbx(1)
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(Now.ToString("dd"))

        dtp_hinichi.Value = Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_shuukei()
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "6"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        dgv_kensakukekka.Rows.Clear()
        cbx_shimebi.SelectedIndex = -1
        cbx_nen.SelectedIndex = -1
        cbx_tsuki.SelectedIndex = -1
    End Sub

    Private Sub btn_seikyuusho_sakusei_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_sakusei.Click

    End Sub

    Private Sub cbx_shimebi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shimebi.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
        If cbx_shimebi.Text = "指定" Then
            btn_denwachou.Enabled = True
            btn_denwachou.PerformClick()
        Else
            lbl_tenpo_id.Text = ""
            btn_denwachou.Enabled = False
        End If
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        Dim hi = cbx_hi.Text
        dgv_kensakukekka.Rows.Clear()
        set_hinichi_cbx(0)
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(hi)
    End Sub

    Private Sub cbx_hi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_hi.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub dtp_hinichi_CloseUp(sender As Object, e As EventArgs) Handles dtp_hinichi.CloseUp
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_hi_hyouji_Click(sender As Object, e As EventArgs) Handles chk_hi_hyouji.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_lock_Click(sender As Object, e As EventArgs) Handles chk_lock.Click
        If chk_lock.Checked Then
            btn_shuukei.Enabled = False
            btn_clear.Enabled = False
        Else
            btn_shuukei.Enabled = True
            btn_clear.Enabled = True
        End If
    End Sub

    Private Sub chk_mail_Click(sender As Object, e As EventArgs) Handles chk_mail.Click

    End Sub

    Private Sub chk_insatsu_shinai_Click(sender As Object, e As EventArgs) Handles chk_insatsu_shinai.Click

    End Sub

    Private Sub chk_houkokuyou_Click(sender As Object, e As EventArgs) Handles chk_houkokuyou.Click

    End Sub

    Private Sub chk_new_Click(sender As Object, e As EventArgs) Handles chk_new.Click

    End Sub

    Private Sub lbl_tenpo_id_TextChanged(sender As Object, e As EventArgs) Handles lbl_tenpo_id.TextChanged
        set_shuukei()
    End Sub

    Private Sub dgv_kensakukekka_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kensakukekka.CellMouseClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            Dim currentRow As DataGridViewRow = dgv_kensakukekka.Rows(e.RowIndex)
            Dim isChecked As Boolean = CBool(currentRow.Cells(0).Value)

            If isChecked Then
                currentRow.Cells(0).Value = False

                If currentRow.Index Mod 2 = 0 Then
                    currentRow.DefaultCellStyle.BackColor = dgv_kensakukekka.RowsDefaultCellStyle.BackColor
                Else
                    currentRow.DefaultCellStyle.BackColor = dgv_kensakukekka.AlternatingRowsDefaultCellStyle.BackColor
                End If

            Else
                currentRow.Cells(0).Value = True
                currentRow.DefaultCellStyle.BackColor = Color.Yellow
            End If

            dgv_kensakukekka.ClearSelection()

        End If

    End Sub
    Private Sub set_shuukei()

        txtseikyuu2.Text = ""
        Dim s_seikyuu_pdf = ""

        If chk_mail.Checked Then
            If Trim(txtseikyuu.Text) = "" Then
                ret = MsgBox("請求書データの保存先が設定されていません。", 16, "総合管理システム「SPSALES」")
                Exit Sub
            End If
            txtseikyuu2.Text = "1"
            s_seikyuu_pdf = "1"

            chk_insatsu_shinai.Checked = False
            chk_insatsu_shinai.Enabled = False
            chk_houkokuyou.Checked = False
            chk_houkokuyou.Enabled = False
        Else
            chk_insatsu_shinai.Checked = False
            chk_insatsu_shinai.Enabled = True
            chk_houkokuyou.Checked = False
            chk_houkokuyou.Enabled = True
        End If

        Dim hihyou = 0
        If chk_hi_hyouji.Checked Then
            hihyou = 1
        End If

        Dim shimebi = Trim(cbx_shimebi.Text)
        If shimebi = "" Then
            msg_go("〆日を選択してください。")
            Exit Sub
        End If
        Dim shimebi_id = Deadline.GetIdByName(shimebi)
        Dim tenpo_id = ""
        If shimebi = "指定" Then
            tenpo_id = Trim(lbl_tenpo_id.Text)
            If tenpo_id = "" Then
                msg_go("店舗IDの取得に失敗しました。")
                Exit Sub
            End If
        End If

        Dim nen = cbx_nen.Text
        Dim tsuki = cbx_tsuki.Text
        Dim hi = cbx_hi.Text
        If nen = "" Or tsuki = "" Or hi = "" Then
            msg_go("年と月と日をすべて選択してください。")
            Exit Sub
        End If

        Dim hinichi = nen + tsuki + hi

        'log_write("請求書の抽出開始********************************************") ' TODO

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 23
            .RowHeadersWidth = 4

            .Columns(0).Name = ""
            .Columns(1).Name = "NO"
            .Columns(2).Name = "ID"
            .Columns(3).Name = "店舗ID"
            .Columns(4).Name = "店舗名"
            .Columns(5).Name = "前請求額"
            .Columns(6).Name = "入金額"
            .Columns(7).Name = "繰越残高"
            .Columns(8).Name = "今月売上"
            .Columns(9).Name = "返品額"
            .Columns(10).Name = "消費税額"
            .Columns(11).Name = "請求金額"
            .Columns(12).Name = "区"
            .Columns(13).Name = "端"
            .Columns(14).Name = "単"
            .Columns(15).Name = "枚数"
            .Columns(16).Name = "備考"
            .Columns(17).Name = "郵便"
            .Columns(18).Name = "住所"
            .Columns(19).Name = "印刷店舗名"
            .Columns(20).Name = ""
            .Columns(21).Name = ""
            .Columns(22).Name = "エラー"

            .Columns(0).Width = 30
            .Columns(1).Width = 40
            .Columns(2).Width = 30
            .Columns(3).Width = 80
            .Columns(4).Width = 280
            .Columns(5).Width = 90
            .Columns(6).Width = 90
            .Columns(7).Width = 90
            .Columns(8).Width = 90
            .Columns(9).Width = 90
            .Columns(10).Width = 90
            .Columns(11).Width = 90
            .Columns(12).Width = 0
            .Columns(13).Width = 0
            .Columns(14).Width = 30
            .Columns(15).Width = 60
            .Columns(16).Width = 400
            .Columns(17).Width = 100
            .Columns(18).Width = 400
            .Columns(19).Width = 400
            .Columns(20).Width = 30
            .Columns(21).Width = 30
            .Columns(22).Width = 30

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(5).DefaultCellStyle.Format = "#,##0"
            .Columns(6).DefaultCellStyle.Format = "#,##0"
            .Columns(7).DefaultCellStyle.Format = "#,##0"
            .Columns(8).DefaultCellStyle.Format = "#,##0"
            .Columns(9).DefaultCellStyle.Format = "#,##0"
            .Columns(10).DefaultCellStyle.Format = "#,##0"
            .Columns(11).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim seikyuu_moto_data(27, 0)
        Dim seikyuu_moto_data_count = 0
        Try

            Dim cn_server As New SqlClient.SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query_tenpo = "SELECT tenpo.*, mailno_m.adress1 FROM tenpo LEFT JOIN mailno_m ON tenpo.mailno = mailno_m.mailno"
            Dim query_tenpo_where = " WHERE  tenpo.kadou <> '1'"

            If tenpo_id <> "" Then
                query_tenpo_where += " AND tenpo.tenpoid = '" + tenpo_id + "'"
            Else
                query_tenpo_where += " AND tenpo.shimebi ='" & shimebi_id & "'"
            End If

            '〆日指定の店舗情報
            If hihyou = 1 Then
                query_tenpo_where += " AND (tenpo.seikyuubi <= '" & Now.AddDays(-10).ToString("yyyyMMdd") & "' OR tenpo.seikyuubi IS NULL)"
            End If

            If s_seikyuu_pdf <> "" Then
                query_tenpo_where += " and tenpo.soushin = '1'"
            End If

            query_tenpo += query_tenpo_where + " ORDER BY tenpo.tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query_tenpo, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_tenpo"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            seikyuu_moto_data_count = dt_server.Rows.Count
            If seikyuu_moto_data_count = 0 Then
                msg_go("該当するデータがありませんでした。")
                dt_server.Clear()
                ds_server.Clear()
                Exit Sub
            End If

            show_shinkou_joukyou("計算元データの取得中...", seikyuu_moto_data_count)

            ReDim seikyuu_moto_data(27, seikyuu_moto_data_count)
            For i = 0 To seikyuu_moto_data_count - 1

                Dim row_tenpo_id = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                Dim zengetsuseikyuukingaku As Integer
                Dim hajime_no_ippo = 0

                Dim temp_kurikoshi = dt_server.Rows.Item(i).Item("kurikoshi")
                Dim kurikoshi = ""
                If Not IsDBNull(temp_kurikoshi) Then
                    kurikoshi = Trim(temp_kurikoshi)
                End If

                Dim hikaku_kurikoshi = 0

                Try

                    Dim cn_server_seikyuusho As New SqlClient.SqlConnection
                    cn_server_seikyuusho.ConnectionString = connectionstring_sqlserver

                    Dim query_seikyuusho = "SELECT * FROM seikyuusho WHERE seikyuu_st = '0' AND tenpoid = '" + row_tenpo_id + "' ORDER BY hiduke DESC, seikyuushoid DESC"

                    Dim da_server_seikyuusho As SqlDataAdapter = New SqlDataAdapter(query_seikyuusho, cn_server_seikyuusho)
                    Dim ds_server_seikyuusho As New DataSet
                    Dim temp_table_name_seikyuusho = "t_seikyuusho"
                    da_server_seikyuusho.Fill(ds_server_seikyuusho, temp_table_name_seikyuusho)
                    Dim dt_server_seikyuusho As DataTable = ds_server_seikyuusho.Tables(temp_table_name_seikyuusho)

                    If dt_server_seikyuusho.Rows.Count = 0 Then

                        Try

                            Dim cn_server_seikyuusho_2 As New SqlClient.SqlConnection
                            cn_server_seikyuusho_2.ConnectionString = connectionstring_sqlserver

                            Dim query_seikyuusho_2 = "SELECT * FROM seikyuusho WHERE seikyuu_st <> '0' AND tenpoid = '" + row_tenpo_id + "' ORDER BY hiduke DESC, seikyuushoid DESC"

                            Dim da_server_seikyuusho_2 As SqlDataAdapter = New SqlDataAdapter(query_seikyuusho_2, cn_server_seikyuusho_2)
                            Dim ds_server_seikyuusho_2 As New DataSet
                            Dim temp_table_name_seikyuusho_2 = "t_seikyuusho_2"
                            da_server_seikyuusho_2.Fill(ds_server_seikyuusho_2, temp_table_name_seikyuusho_2)
                            Dim dt_server_seikyuusho_2 As DataTable = ds_server_seikyuusho_2.Tables(temp_table_name_seikyuusho_2)

                            If dt_server_seikyuusho_2.Rows.Count > 0 Then

                                hajime_no_ippo = 1

                                If kurikoshi <> "" Then
                                    hikaku_kurikoshi = CInt(kurikoshi)
                                End If

                            End If

                            dt_server_seikyuusho_2.Clear()
                            ds_server_seikyuusho_2.Clear()

                        Catch ex As Exception
                            msg_go(ex.Message)
                            hide_shinkou_joukyou()
                            Exit Sub
                        End Try

                        zengetsuseikyuukingaku = 0

                    Else
                        ' 請求書で、入金されていないデータがない（入金済み）
                        ' 先月の請求金額を
                        zengetsuseikyuukingaku = CInt(Trim(dt_server_seikyuusho.Rows.Item(0).Item("seikyuukingaku")))
                    End If

                    dt_server_seikyuusho.Clear()
                    ds_server_seikyuusho.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

                seikyuu_moto_data(0, i) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                seikyuu_moto_data(1, i) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                seikyuu_moto_data(2, i) = Trim(dt_server.Rows.Item(i).Item("insatsumei"))

                Dim temp_mailno = dt_server.Rows.Item(i).Item("mailno")
                Dim mailno = ""
                If Not IsDBNull(temp_mailno) Then
                    mailno = Trim(temp_mailno)
                End If
                seikyuu_moto_data(3, i) = mailno

                Dim temp_adress1 = dt_server.Rows.Item(i).Item("adress1")
                Dim adress1 = ""
                If Not IsDBNull(temp_adress1) Then
                    adress1 = Trim(temp_adress1)
                End If
                seikyuu_moto_data(4, i) = adress1

                Dim temp_tenpoadress = dt_server.Rows.Item(i).Item("tenpoadress")
                Dim tenpoadress = ""
                If Not IsDBNull(temp_tenpoadress) Then
                    tenpoadress = Trim(temp_tenpoadress)
                End If
                seikyuu_moto_data(5, i) = tenpoadress

                If kurikoshi = "" Then
                    seikyuu_moto_data(6, i) = 0 ' 繰越額
                    seikyuu_moto_data(13, i) = 0 ' 計算繰越
                Else
                    seikyuu_moto_data(6, i) = CInt(kurikoshi) ' 繰越額
                    seikyuu_moto_data(13, i) = CInt(kurikoshi) ' 計算繰越
                End If

                seikyuu_moto_data(7, i) = Trim(dt_server.Rows.Item(i).Item("kubun")) ' 区分
                seikyuu_moto_data(8, i) = Trim(dt_server.Rows.Item(i).Item("zeihasuu")) ' 税金端数
                seikyuu_moto_data(9, i) = Trim(dt_server.Rows.Item(i).Item("souhasuu")) ' 税金 … 0:請求書毎, 1:伝票毎

                Dim temp_seikyuubi = dt_server.Rows.Item(i).Item("seikyuubi")
                Dim seikyuubi = ""
                If Not IsDBNull(temp_seikyuubi) Then
                    seikyuubi = Trim(temp_seikyuubi)
                End If
                seikyuu_moto_data(10, i) = seikyuubi ' 前回請求日

                seikyuu_moto_data(11, i) = 0 ' 今回入金額
                seikyuu_moto_data(12, i) = 0 ' 売上
                seikyuu_moto_data(14, i) = 0 ' 消費税
                seikyuu_moto_data(15, i) = 0 ' 今月そう合計額
                seikyuu_moto_data(16, i) = 0 ' 表示フラグ
                seikyuu_moto_data(17, i) = 0 ' 今月返品額
                seikyuu_moto_data(18, i) = 0 ' 売上+今月返品額
                seikyuu_moto_data(19, i) = 0 ' 枚数
                seikyuu_moto_data(20, i) = 0 ' 非課税額合計
                seikyuu_moto_data(21, i) = Trim(dt_server.Rows.Item(i).Item("shainid"))
                seikyuu_moto_data(22, i) = zengetsuseikyuukingaku ' チェック用前回請求金額
                seikyuu_moto_data(23, i) = hajime_no_ippo ' はじめかどうか
                seikyuu_moto_data(24, i) = hikaku_kurikoshi
                seikyuu_moto_data(25, i) = 0 ' 消費税10％
                seikyuu_moto_data(26, i) = 0 ' 消費税8％
                seikyuu_moto_data(27, i) = 0

                calculate_shinkou_joukyou(i, seikyuu_moto_data_count)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            hide_shinkou_joukyou()
            Exit Sub
        End Try

        show_shinkou_joukyou("各項目を計算中...", seikyuu_moto_data_count)

        Dim newseikyusuu2 = 0
        For i = 0 To seikyuu_moto_data_count - 1

            Dim row_tenpo_id = seikyuu_moto_data(0, i)
            Dim sashihiki_nyuukingaku = 0
            If shimebi_id = Deadline.ID_ZUIJI Then '随時請求の場合

                Dim kyoumade = Now.ToString("yyyyMMdd")
                Dim dt As DateTime
                If Not TryParseDateString(hinichi, dt) Then
                    msg_go("日付の変換（String -> DateTime）に失敗しました。")
                    hide_shinkou_joukyou()
                    Exit Sub
                End If
                Dim hinichi_tsuginohi = dt.AddDays(1).ToString("yyyyMMdd")

                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT SUM(seikyuukingaku) AS newnyuukingoukei FROM seikyuusho" +
                        " WHERE seikyuu_st = '1' AND tenpoid = '" + row_tenpo_id + "' AND hiduke BETWEEN '" + hinichi_tsuginohi + "' AND '" + kyoumade + "' AND joukyou IS NULL"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_seikyuusho"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    If dt_server.Rows.Count > 0 Then

                        Dim newnyuukingoukei = dt_server.Rows.Item(0).Item("newnyuukingoukei")
                        If Not IsDBNull(newnyuukingoukei) Then
                            sashihiki_nyuukingaku = CInt(Trim(newnyuukingoukei))
                        End If

                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

            End If

            '最終請求書発効日の取得
            Dim s_saishuu_seikyuubi As String = ""
            If chk_new.Checked Then

                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT * FROM seikyuusho WHERE seikyuu_st = '0' AND tenpoid = '" & row_tenpo_id & "' ORDER BY hiduke DESC"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_seikyuusho"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    If dt_server.Rows.Count > 0 Then

                        Dim hiduke = dt_server.Rows.Item(0).Item("hiduke")
                        If Not IsDBNull(hiduke) Then
                            s_saishuu_seikyuubi = Trim(hiduke)
                        End If

                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

            End If

            '今回の入金額
            Try

                Dim cn_server As New SqlClient.SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT SUM(seikyuukingaku) AS newnyuukingoukei FROM seikyuusho"


                Dim query_where = " WHERE seikyuu_st = '1' AND tenpoid = '" + row_tenpo_id + "' AND joukyou IS NULL"
                If s_saishuu_seikyuubi = "" Then
                    query_where += " AND hiduke <= '" + hinichi + "'"
                Else
                    query_where += " AND hiduke BETWEEN '" + s_saishuu_seikyuubi + "' AND '" + hinichi + "'"
                End If

                query += query_where

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                Dim temp_table_name = "t_seikyuusho"
                da_server.Fill(ds_server, temp_table_name)
                Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                If dt_server.Rows.Count > 0 Then

                    Dim newnyuukingoukei = dt_server.Rows.Item(0).Item("newnyuukingoukei")
                    If Not IsDBNull(newnyuukingoukei) Then
                        seikyuu_moto_data(11, i) = newnyuukingoukei
                        If seikyuu_moto_data(23, seikyuu_moto_data_count) = 1 Then
                            seikyuu_moto_data(6, i) = seikyuu_moto_data(24, seikyuu_moto_data_count) + Trim(newnyuukingoukei) + sashihiki_nyuukingaku
                            seikyuu_moto_data(13, i) = seikyuu_moto_data(24, seikyuu_moto_data_count) + sashihiki_nyuukingaku
                        Else

                            Try

                                Dim cn_server_2 As New SqlClient.SqlConnection
                                cn_server_2.ConnectionString = connectionstring_sqlserver

                                Dim query_2 = "SELECT * FROM seikyuusho WHERE seikyuu_st = '0' AND tenpoid = '" + row_tenpo_id + "'"

                                Dim da_server_2 As SqlDataAdapter = New SqlDataAdapter(query_2, cn_server_2)
                                Dim ds_server_2 As New DataSet
                                Dim temp_table_name_2 = "t_seikyuusho_2"
                                da_server_2.Fill(ds_server_2, temp_table_name_2)
                                Dim dt_server_2 As DataTable = ds_server_2.Tables(temp_table_name_2)

                                If dt_server_2.Rows.Count = 0 Then
                                    seikyuu_moto_data(6, i) = 0 + sashihiki_nyuukingaku
                                    seikyuu_moto_data(13, i) = 0 - Trim(newnyuukingoukei) + sashihiki_nyuukingaku
                                Else
                                    seikyuu_moto_data(6, i) += Trim(newnyuukingoukei) + sashihiki_nyuukingaku
                                    seikyuu_moto_data(13, i) += sashihiki_nyuukingaku
                                End If

                                dt_server_2.Clear()
                                ds_server_2.Clear()

                            Catch ex As Exception
                                msg_go(ex.Message)
                                hide_shinkou_joukyou()
                                Exit Sub
                            End Try

                        End If

                    End If

                End If

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                hide_shinkou_joukyou()
                Exit Sub
            End Try

            Dim genzai_zeiritsu = 10 ' TODO:どこで宣言？
            Dim taishouzeigaku = 0 ' 税額（総計）
            Dim taishouzeigaku10 = 0 ' 税額額（10％）
            Dim taishouzeigaku8 = 0 ' 課税対象額（8％）
            Dim newdensuu = 0
            Dim keisan_hikazeigaku As Double = 0
            If seikyuu_moto_data(9, i) = "1" Then '伝票毎

                ' 今回売上
                Dim taishougaku As Double = 0 ' 売り上げ合計
                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT hacchuu.hacchuuid, hacchuu.goukei FROM hacchuu" +
                        " WHERE hacchuu.joukyou = '0' AND hacchuu.tenpoid = '" + row_tenpo_id + "' AND hacchuu.iraibi <= '" + hinichi + "'"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_hacchuu"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    If dt_server.Rows.Count > 0 Then

                        For j = 0 To dt_server.Rows.Count - 1

                            Dim hacchuuid = Trim(dt_server.Rows.Item(j).Item("hacchuuid"))
                            Dim goukei = Trim(dt_server.Rows.Item(j).Item("goukei"))

                            Try

                                Dim cn_server_2 As New SqlClient.SqlConnection
                                cn_server_2.ConnectionString = connectionstring_sqlserver

                                'Dim query_2 = "SELECT SUM(hacchuushousai.kei) AS denhika, hacchuushousai.keigen" + ' 元々はRIGHT
                                '    " FROM hacchuushousai RIGHT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid" +
                                '    " WHERE hacchuushousai.hacchuuid = '" + hacchuuid + "' GROUP BY hacchuushousai.keigen"

                                Dim query_2 = "SELECT SUM(hacchuushousai.kei) AS denhika, hacchuushousai.keigen" + ' 修正版はLEFT
                                    " FROM hacchuushousai LEFT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid" +
                                    " WHERE hacchuushousai.hacchuuid = '" + hacchuuid + "' GROUP BY hacchuushousai.keigen"

                                Dim da_server_2 As SqlDataAdapter = New SqlDataAdapter(query_2, cn_server_2)
                                Dim ds_server_2 As New DataSet
                                Dim temp_table_name_2 = "t_hacchuu"
                                da_server_2.Fill(ds_server_2, temp_table_name_2)
                                Dim dt_server_2 As DataTable = ds_server_2.Tables(temp_table_name_2)

                                Dim tanzeigaku As Double
                                If dt_server_2.Rows.Count = 0 Then
                                    tanzeigaku = zeikinkeisan(CDbl(goukei), genzai_zeiritsu, CStr(seikyuu_moto_data(8, i)))
                                    taishougaku += CDbl(goukei)
                                    taishouzeigaku10 += tanzeigaku
                                Else

                                    For k = 0 To dt_server_2.Rows.Count - 1

                                        If IsDBNull(dt_server_2.Rows.Item(k).Item("keigen")) Then ' 10%

                                            Dim denhika = dt_server_2.Rows.Item(k).Item("denhika")
                                            If IsDBNull(denhika) Then
                                                tanzeigaku = zeikinkeisan(CDbl(goukei), genzai_zeiritsu, CStr(seikyuu_moto_data(8, i)))
                                                taishouzeigaku10 += tanzeigaku
                                            Else
                                                Dim sanhika = CDbl(denhika)
                                                If sanhika = 0 Then
                                                    tanzeigaku = 0
                                                    taishouzeigaku10 += tanzeigaku
                                                Else
                                                    tanzeigaku = zeikinkeisan(sanhika, genzai_zeiritsu, CStr(seikyuu_moto_data(8, i)))
                                                    taishouzeigaku10 += tanzeigaku
                                                End If
                                            End If


                                        Else ' 8%

                                            Dim denhika = dt_server_2.Rows.Item(k).Item("denhika")
                                            If IsDBNull(denhika) Then
                                                tanzeigaku = zeikinkeisan(CDbl(goukei), 8, CStr(seikyuu_moto_data(8, i)))
                                                taishouzeigaku8 += tanzeigaku
                                            Else
                                                Dim sanhika = CDbl(denhika)
                                                If sanhika = 0 Then
                                                    tanzeigaku = 0
                                                    taishouzeigaku8 += tanzeigaku
                                                Else
                                                    tanzeigaku = zeikinkeisan(sanhika, 8, CStr(seikyuu_moto_data(8, i)))
                                                    taishouzeigaku8 += tanzeigaku
                                                End If
                                            End If

                                        End If

                                    Next

                                    taishougaku += CDbl(goukei)

                                End If

                                dt_server_2.Clear()
                                ds_server_2.Clear()

                            Catch ex As Exception
                                msg_go(ex.Message)
                                hide_shinkou_joukyou()
                                Exit Sub
                            End Try

                            newdensuu += 1

                        Next

                        taishouzeigaku = taishouzeigaku8 + taishouzeigaku10
                        seikyuu_moto_data(12, i) = taishougaku ' 売り上げ合計
                        seikyuu_moto_data(18, i) = taishougaku

                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

            Else

                ' 今回売上
                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT SUM(goukei) AS newhachuugoukei, COUNT(hacchuuid) AS newdencount FROM hacchuu" +
                        " WHERE joukyou = '0' AND tenpoid = '" + row_tenpo_id + "' AND iraibi <= '" + hinichi + "'"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_hacchuu"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    If dt_server.Rows.Count > 0 Then
                        Dim newhachuugoukei = dt_server.Rows.Item(0).Item("newhachuugoukei")
                        If IsDBNull(newhachuugoukei) Then
                            seikyuu_moto_data(12, i) = 0
                            seikyuu_moto_data(18, i) = 0
                        Else
                            seikyuu_moto_data(12, i) = Trim(newhachuugoukei)
                            seikyuu_moto_data(18, i) = Trim(newhachuugoukei)
                            newdensuu = dt_server.Rows.Item(0).Item("newdencount")
                        End If
                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

                ' 軽減税率対応
                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    'Dim query = "SELECT SUM(hacchuushousai.kei) AS denhika, hacchuushousai.keigen" +
                    '    " FROM (hacchuu LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" + ' TODO : RIGHT JOINでは？
                    '    " LEFT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid" +
                    '    " WHERE hacchuu.tenpoid = '" + row_tenpo_id + "' AND hacchuu.joukyou = '0' AND hacchuu.iraibi <= '" + hinichi + "' AND shouhin.hikazei IS NULL" +
                    '    " GROUP BY hacchuushousai.keigen"

                    Dim query = "SELECT SUM(hacchuushousai.kei) AS denhika, hacchuushousai.keigen" +
                        " FROM (hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" + ' TODO : RIGHT JOINでは？
                        " LEFT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid" +
                        " WHERE hacchuu.tenpoid = '" + row_tenpo_id + "' AND hacchuu.joukyou = '0' AND hacchuu.iraibi <= '" + hinichi + "' AND shouhin.hikazei IS NULL" +
                        " GROUP BY hacchuushousai.keigen"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_hacchuu"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    Dim tanzeigaku As Double
                    If dt_server.Rows.Count = 0 Then
                        taishouzeigaku += tanzeigaku
                    Else

                        For j = 0 To dt_server.Rows.Count - 1

                            Dim sanhika = CDbl(dt_server.Rows.Item(j).Item("denhika"))
                            If IsDBNull(dt_server.Rows.Item(j).Item("keigen")) Then ' 10%
                                tanzeigaku = zeikinkeisan(sanhika, genzai_zeiritsu, CStr(seikyuu_moto_data(8, i)))
                                taishouzeigaku10 = taishouzeigaku10 + tanzeigaku
                            Else ' 8%
                                tanzeigaku = zeikinkeisan(sanhika, 8, CStr(seikyuu_moto_data(8, i)))
                                taishouzeigaku8 = taishouzeigaku8 + tanzeigaku
                            End If

                        Next

                        taishouzeigaku = taishouzeigaku8 + taishouzeigaku10

                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

                ' 期間中の非課税合計額
                Try

                    Dim cn_server As New SqlClient.SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT SUM(hacchuushousai.kei) AS newhika" &
                                " FROM hacchuu RIGHT JOIN (hacchuushousai RIGHT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid) ON hacchuu.hacchuuid = hacchuushousai.hacchuuid" &
                                " WHERE shouhin.hikazei = '1' AND hacchuu.tenpoid = '" + row_tenpo_id + "' AND hacchuu.joukyou = '0' AND hacchuu.iraibi <= '" + hinichi + "'"

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    Dim temp_table_name = "t_hacchuu"
                    da_server.Fill(ds_server, temp_table_name)
                    Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                    If dt_server.Rows.Count > 0 Then
                        Dim newhika = dt_server.Rows.Item(0).Item("newhika")
                        If Not IsDBNull(newhika) Then
                            keisan_hikazeigaku = CDbl(Trim(newhika))
                        End If
                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

            End If

            seikyuu_moto_data(20, i) = keisan_hikazeigaku
            seikyuu_moto_data(19, i) = newdensuu ' 枚数

            ' 今回返品
            Try

                Dim cn_server As New SqlClient.SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT SUM(hacchuushousai.kei) AS newhenpingoukei" +
                        " FROM hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid" &
                        " WHERE hacchuu.joukyou = '0' AND hacchuu.tenpoid = '" + row_tenpo_id + "' AND hacchuu.iraibi <= '" + hinichi + "' AND hacchuushousai.kosuu <= 0"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                Dim temp_table_name = "t_hacchuu"
                da_server.Fill(ds_server, temp_table_name)
                Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                If dt_server.Rows.Count > 0 Then
                    Dim temp_newhenpingoukei = dt_server.Rows.Item(0).Item("newhenpingoukei")
                    Dim newhenpingoukei = 0
                    If Not IsDBNull(temp_newhenpingoukei) Then

                        newhenpingoukei = CInt(Trim(temp_newhenpingoukei))
                        seikyuu_moto_data(12, i) -= newhenpingoukei
                    End If
                    seikyuu_moto_data(17, i) = newhenpingoukei
                End If

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                hide_shinkou_joukyou()
                Exit Sub
            End Try

            ' 消費税計算
            If seikyuu_moto_data(12, i) = 0 Then
                If seikyuu_moto_data(17, i) = 0 Then ' 返品なし
                    seikyuu_moto_data(14, i) = 0
                    seikyuu_moto_data(25, i) = 0
                    seikyuu_moto_data(26, i) = 0
                Else
                    seikyuu_moto_data(14, i) = taishouzeigaku
                    seikyuu_moto_data(25, i) = taishouzeigaku10
                    seikyuu_moto_data(26, i) = taishouzeigaku8
                End If
            Else
                seikyuu_moto_data(14, i) = taishouzeigaku
                seikyuu_moto_data(25, i) = taishouzeigaku10
                seikyuu_moto_data(26, i) = taishouzeigaku8
            End If

            ' 再計算
            seikyuu_moto_data(15, i) = seikyuu_moto_data(13, i) + seikyuu_moto_data(18, i) + seikyuu_moto_data(14, i)

            ' 作成するかをチェック
            If seikyuu_moto_data(12, i) = 0 And seikyuu_moto_data(11, i) = 0 And seikyuu_moto_data(17, i) = 0 Then
                If seikyuu_moto_data(13, i) = 0 Then ' 計算繰越と売上と入金と返品が０のとき
                    If seikyuu_moto_data(19, i) <> 0 Then  ' 納品書枚数が0以外のときは、出す
                        seikyuu_moto_data(16, i) = 1
                        newseikyusuu2 += 1
                    End If
                Else
                    Try

                        Dim cn_server As New SqlClient.SqlConnection
                        cn_server.ConnectionString = connectionstring_sqlserver

                        Dim query = "SELECT SUM(seikyuukingaku) AS newnyuukingoukei FROM seikyuusho" +
                            " WHERE seikyuu_st = '1' AND tenpoid = '" + row_tenpo_id + "' AND hiduke > '" + hinichi + "' AND joukyou IS NULL"

                        Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                        Dim ds_server As New DataSet
                        Dim temp_table_name = "t_seikyuusho"
                        da_server.Fill(ds_server, temp_table_name)
                        Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                        If dt_server.Rows.Count = 0 Then
                            seikyuu_moto_data(16, i) = 1
                            newseikyusuu2 += 1
                        Else
                            Dim newnyuukingoukei = dt_server.Rows.Item(0).Item("newnyuukingoukei")
                            If IsDBNull(newnyuukingoukei) Then
                                seikyuu_moto_data(16, i) = 1
                                newseikyusuu2 += 1
                            Else
                                If Not (CInt(dt_server.Rows.Item(0).Item("newnyuukingoukei")) * -1 = seikyuu_moto_data(13, i)) Then
                                    seikyuu_moto_data(16, i) = 1
                                    newseikyusuu2 += 1
                                End If
                            End If
                        End If

                        dt_server.Clear()
                        ds_server.Clear()

                    Catch ex As Exception
                        msg_go(ex.Message)
                        hide_shinkou_joukyou()
                        Exit Sub
                    End Try
                End If
            Else
                seikyuu_moto_data(16, i) = 1
                newseikyusuu2 += 1
            End If

            calculate_shinkou_joukyou(i, seikyuu_moto_data_count)

        Next

        If newseikyusuu2 <> 0 Then
            Dim mojiretsu(30)
            show_shinkou_joukyou("表示処理中...", seikyuu_moto_data_count)
            Dim hi_hyouji_count = 0
            For i = 0 To seikyuu_moto_data_count - 1

                If seikyuu_moto_data(16, i) = 0 Then
                    hi_hyouji_count += 1
                    Continue For
                End If

                mojiretsu(0) = ""
                mojiretsu(1) = (i - hi_hyouji_count + 1).ToString
                mojiretsu(2) = seikyuu_moto_data(21, i) ' ID
                mojiretsu(3) = seikyuu_moto_data(0, i) ' 店舗ID
                mojiretsu(4) = seikyuu_moto_data(1, i) ' 店舗名
                mojiretsu(5) = CLng(seikyuu_moto_data(6, i)).ToString("#,0") ' 前回請求額
                mojiretsu(6) = CLng(seikyuu_moto_data(11, i)).ToString("#,0") ' 今回入金額
                mojiretsu(7) = CLng(seikyuu_moto_data(13, i)).ToString("#,0") ' 計算繰越
                mojiretsu(8) = CLng(seikyuu_moto_data(12, i)).ToString("#,0") ' 売上
                mojiretsu(9) = CLng(seikyuu_moto_data(17, i)).ToString("#,0") ' 今月返品額
                mojiretsu(10) = CLng(seikyuu_moto_data(14, i)).ToString("#,0") ' 消費税
                mojiretsu(11) = CLng(seikyuu_moto_data(15, i)).ToString("#,0") ' 今月総合計額
                mojiretsu(12) = seikyuu_moto_data(7, i)
                mojiretsu(13) = seikyuu_moto_data(8, i)
                mojiretsu(14) = seikyuu_moto_data(9, i)
                mojiretsu(15) = seikyuu_moto_data(19, i)
                mojiretsu(16) = "備考"
                mojiretsu(17) = seikyuu_moto_data(3, i)
                mojiretsu(18) = seikyuu_moto_data(4, i) + seikyuu_moto_data(5, i)
                mojiretsu(19) = seikyuu_moto_data(2, i)
                mojiretsu(20) = seikyuu_moto_data(25, i) ' 消費税10％
                mojiretsu(21) = seikyuu_moto_data(26, i) ' 消費税8％
                mojiretsu(22) = seikyuu_moto_data(27, i) ' エラー

                dgv_kensakukekka.Rows.Add(mojiretsu)

                dgv_kensakukekka.Rows(i - hi_hyouji_count).Cells(0) = New DataGridViewCheckBoxCell
                dgv_kensakukekka.Rows(i - hi_hyouji_count).Cells(0).Value = False

                calculate_shinkou_joukyou(i, seikyuu_moto_data_count)

            Next

        End If

        hide_shinkou_joukyou()

        'log_write("請求書の抽出終了********************************************") ' TODO


        ' ----------------------------------------------------------

        'Dim shimebi_id As Integer, shimekikan As Integer
        'Dim karitsuki As Integer, karihi As String, hihyou As Integer

        'txtseikyuu2.Text = ""
        's_seikyuu_pdf = ""

        'If chkmail.Value = 1 Then
        '    If Trim(txtseikyuu.Text) = "" Then
        '        ret = MsgBox("請求書データの保存先が設定されていません。", 16, "総合管理システム「SPSALES」")
        '        Exit Sub
        '    End If
        '    txtseikyuu2.Text = "1"
        '    s_seikyuu_pdf = "1"

        '    chkinsatsu.Value = 0
        '    chkinsatsu.Enabled = False
        '    chkhoukoku.Value = 0
        '    chkhoukoku.Enabled = False
        'Else
        '    chkinsatsu.Value = 0
        '    chkinsatsu.Enabled = True
        '    chkhoukoku.Value = 0
        '    chkhoukoku.Enabled = True

        'End If

        'hihyou = 0
        'If chkhi.Value = 1 Then
        '    hihyou = 1
        'End If

        'If cmbhi.ListIndex = -1 Then
        '    ret = MsgBox("日を選択してから実行してください。", 16, "総合管理システム「SPSALES」")
        '    Exit Sub
        'End If
        'If cmbnen.ListIndex = -1 Then
        '    ret = MsgBox("年を選択してから実行してください。", 16, "総合管理システム「SPSALES」")
        '    Exit Sub
        'End If
        'If cmbtsuki.ListIndex = -1 Then
        '    ret = MsgBox("月を選択してから実行してください。", 16, "総合管理システム「SPSALES」")
        '    Exit Sub
        'End If
        'shimebi_id = combkikan.ListIndex
        'If shimebi_id = -1 Then
        '    ret = MsgBox("期間を選択してから実行してください。", 16, "総合管理システム「SPSALES」")
        '    Exit Sub
        'End If

        'hinichi = cmbnen.Text & cmbtsuki.Text & Format(cmbhi.Text, "00")


        'log_write("請求書の抽出開始********************************************")

        'seikyuusho_sakusei_ichi2 hinichi, shimebi_id, hihyou, "", s_seikyuu_pdf
        'seikyuusho_sakusei_ichi2(hinichi As String, shimebi_id As Integer, hihyou As Integer, Optional tenpo_id As String, Optional s_seikyuu_pdf As String = "")

        'Dim sql_seikyu As String, rs_saikyu As New ADODB.Recordset, seikyuu_moto_data(), newseikyusuu As Long
        'Dim sql_seikyu2 As String, rs_saikyu2 As ADODB.Recordset, newseikyusuu2 As Long, newdensuu As Integer
        'Dim sql_seikyu3 As String, rs_saikyu3 As ADODB.Recordset, newseikyusuu3 As Long, tanzeigaku As Double
        'Dim sql_seikyu4 As String, rs_saikyu4 As ADODB.Recordset, taishougaku As Double, taishouzeigaku As Double, taishouzeigaku10 As Double, taishouzeigaku8 As Double
        'Dim sql_seikyu5 As String, rs_saikyu5 As ADODB.Recordset
        'Dim ii As Long, scoun As Long, wherewhere As String, nnhi As Integer, newhi As Integer, newtsuki As Integer
        'Dim nntsuki As Integer, newnen As Long, nnnen As Long, newnewhiduke As String
        'Dim sql_hika As String, rs_hika As ADODB.Recordset, keisan_hikazeigaku As Double, sanhika As Double
        'Dim sql_seikyu12 As String, rs_saikyu12 As ADODB.Recordset
        'Dim sql_cont24 As String, rs_cont24 As New ADODB.Recordset
        'Dim hatsu_seikyuu As Integer, sql_hatsu As String, rs_hatsu As New ADODB.Recordset

        'Dim sql_seikyuu As String, rs_seikyuu As ADODB.Recordset, hajime_no_ippo As Integer
        'Dim sql_seikyuu2 As String, rs_seikyuu2 As ADODB.Recordset
        'Dim hikaku_kurikoshi As Long, zengetsuseikyuukingaku As Long
        'Dim sql_seikyuu3 As String, rs_seikyuu3 As ADODB.Recordset
        'Dim kyoumade As String, hinichi_tsuginohi As String
        'Dim hinichi_hi As Integer
        'Dim sashihiki_nyuukingaku As Long

        'Dim sql_seikyu222 As String, rs_saikyu222 As ADODB.Recordset

        'grid_seikyu_set(1)

        ''〆日指定の店舗情報
        'If hihyou = 1 Then
        '    nnhi = CInt(Format(Of Date, "dd")())
        '    nntsuki = CInt(Format(Of Date, "mm")())
        '    nnnen = CLng(Format(Of Date, "yyyy")())
        '    If nnhi <= 10 Then
        '        newhi = nnhi + 30 - 10
        '        If nntsuki = 1 Then
        '            newtsuki = 12
        '            newnen = nnnen - 1
        '        Else
        '            newtsuki = nntsuki - 1
        '            newnen = nnnen
        '        End If
        '    Else
        '        newhi = nnhi - 10
        '        newtsuki = nntsuki
        '        newnen = nnnen
        '    End If
        '    newnewhiduke = CStr(newnen) & Format(newtsuki, "00") & Format(newhi, "00")
        '    wherewhere = " and (tenpo.seikyuubi<='" & newnewhiduke & "' or tenpo.seikyuubi is null)"
        'Else
        '    wherewhere = ""
        'End If

        'If shimebi_id = 6 Then '随時請求の場合
        '    kyoumade = Format(Of Date, "yyyymmdd")()
        '    hinichi_hi = CInt(Right(hinichi, 2)) + 1
        '    hinichi_tsuginohi = Mid(hinichi, 1, 6) & Format(hinichi_hi, "00")
        'End If
        'If tenpo_id <> "" Then
        '    sql_seikyu = "select tenpo.*,mailno_m.adress1" &
        '            " from tenpo left join mailno_m on tenpo.mailno=mailno_m.mailno" &
        '            " where tenpo.tenpoid='" & tenpo_id & "' and tenpo.kadou <> '1'" &
        '            wherewhere
        'Else
        '    sql_seikyu = "select tenpo.*,mailno_m.adress1" &
        '            " from tenpo left join mailno_m on tenpo.mailno=mailno_m.mailno" &
        '            " where tenpo.shimebi ='" & shimebi_id & "' and tenpo.kadou <> '1'" &
        '            wherewhere
        'End If

        'If s_seikyuu_pdf <> "" Then
        '    sql_seikyu += " and tenpo.soushin='1'"
        'End If

        'sql_seikyu += " order by tenpo.tenpofurigana"

        'Dim seikyuu_moto_data_count = 0
        'If FcSQlGet(1, rs_saikyu, sql_seikyu, WMsg) = True Then

        '    'seikyuu_moto_data_count = rs_saikyu.RecordCount

        '    'frmseikyuu.ppp.Visible = True
        '    'frmseikyuu.ppp.Max = seikyuu_moto_data_count
        '    'frmseikyuu.ppp.Value = 0
        '    'DoEvents

        '    'ReDim seikyuu_moto_data(seikyuu_moto_data_count, 28)  ', 24)

        '    'rs_saikyu.MoveFirst
        '    'ii = 0

        '    Do Until rs_saikyu.EOF

        '        ''初請求で繰越金額があるかをﾁｪｯｸ
        '        'hajime_no_ippo = 0
        '        ''請求書データがなければ********************************************
        '        'Set rs_seikyuu = New ADODB.Recordset
        '        'sql_seikyuu = "SELECT * FROM seikyuusho" &
        '        '                    " where seikyuu_st='0' and tenpoid='" & rs_saikyu!tenpoid & "' ORDER BY hiduke DESC,seikyuushoid DESC"
        '        'If FcSQlGet(0, rs_seikyuu, sql_seikyuu, WMsg) = False Then
        '        '        '入金のデータがあれば
        '        '        Set rs_seikyuu2 = New ADODB.Recordset
        '        '        sql_seikyuu2 = "SELECT * FROM seikyuusho" &
        '        '                            " where seikyuu_st<>'0' and tenpoid='" & rs_saikyu!tenpoid & "' ORDER BY hiduke DESC,seikyuushoid DESC"
        '        '    If FcSQlGet(0, rs_seikyuu2, sql_seikyuu2, WMsg) = True Then
        '        '        hajime_no_ippo = 1
        '        '        If IsNull(rs_saikyu!kurikoshi) Or rs_saikyu!kurikoshi = 0 Then
        '        '            hikaku_kurikoshi = 0
        '        '        Else
        '        '            hikaku_kurikoshi = CLng(rs_saikyu!kurikoshi)
        '        '        End If
        '        '    End If
        '        '    zengetsuseikyuukingaku = 0
        '        'Else
        '        '    '請求書で、入金されていないデータがない（入金済み）
        '        '    '先月の請求金額を
        '        '    zengetsuseikyuukingaku = rs_seikyuu!seikyuukingaku

        '        'End If

        '        'seikyuu_moto_data(ii, 0) = Trim(rs_saikyu!tenpoid)
        '        'seikyuu_moto_data(ii, 21) = Trim(rs_saikyu!shainid)
        '        'seikyuu_moto_data(ii, 1) = Trim(rs_saikyu!tenpomei)
        '        'seikyuu_moto_data(ii, 2) = Trim(rs_saikyu!insatsumei)
        '        'seikyuu_moto_data(ii, 3) = rs_saikyu!mailno
        '        'seikyuu_moto_data(ii, 4) = Trim(rs_saikyu!adress1)
        '        'seikyuu_moto_data(ii, 5) = Trim(rs_saikyu!tenpoadress)
        '        'If IsNull(rs_saikyu!kurikoshi) Then
        '        '    seikyuu_moto_data(ii, 6) = 0  '繰越額
        '        '    seikyuu_moto_data(ii, 13) = 0     '計算繰越
        '        'Else
        '        '    seikyuu_moto_data(ii, 6) = rs_saikyu!kurikoshi '繰越額
        '        '    seikyuu_moto_data(ii, 13) = rs_saikyu!kurikoshi     '計算繰越
        '        'End If
        '        'seikyuu_moto_data(ii, 7) = rs_saikyu!kubun '区分
        '        'seikyuu_moto_data(ii, 8) = rs_saikyu!zeihasuu '税金端数
        '        'seikyuu_moto_data(ii, 9) = rs_saikyu!souhasuu '税金0:請求書毎1:伝票毎
        '        'seikyuu_moto_data(ii, 10) = rs_saikyu!seikyuubi   '前回請求日
        '        'seikyuu_moto_data(ii, 12) = 0   '売上
        '        'seikyuu_moto_data(ii, 14) = 0   '消費税
        '        'seikyuu_moto_data(ii, 15) = 0 '今月そう合計額
        '        'seikyuu_moto_data(ii, 17) = 0 '今月返品額
        '        'seikyuu_moto_data(ii, 18) = 0 '売上+今月返品額
        '        'seikyuu_moto_data(ii, 20) = 0 '非課税額合計
        '        'seikyuu_moto_data(ii, 22) = zengetsuseikyuukingaku 'チェック用前回請求金額
        '        'seikyuu_moto_data(ii, 23) = hajime_no_ippo 'はじめか？
        '        'seikyuu_moto_data(ii, 24) = hikaku_kurikoshi
        '        'seikyuu_moto_data(ii, 25) = 0 '消費税10％
        '        'seikyuu_moto_data(ii, 26) = 0  '消費税8％
        '        'seikyuu_moto_data(ii, 27) = 0
        '        rs_saikyu.MoveNext
        '        ii = ii + 1
        '        frmseikyuu.ppp.Value = ii - 1
        '        DoEvents
        '    Loop
        '    rs_saikyu.Close
        'End If

        'newseikyusuu2 = 0
        'frmseikyuu.ppp.Visible = True

        'If seikyuu_moto_data_count <> 0 Then
        '    frmseikyuu.ppp.Max = seikyuu_moto_data_count
        '    frmseikyuu.ppp.Value = 0
        '    DoEvents
        'End If
        'DoEvents

        ' ----------------------------！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！ここまで終了！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！------------------------------

        'For i = 0 To seikyuu_moto_data_count - 1

        'sashihiki_nyuukingaku = 0
        'If shimebi_id = 6 Then '随時請求の場合
        '    sql_seikyu222 = "select sum(seikyuukingaku) as newnyuukingoukei" &
        '            " from seikyuusho where seikyuu_st='1'" &
        '            " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '            " and hiduke between'" & hinichi_tsuginohi & "' and '" & kyoumade & "' and joukyou is null"
        '    'Set rs_saikyu222 = New ADODB.Recordset
        '    If FcSQlGet(1, rs_saikyu222, sql_seikyu222, WMsg) = True Then
        '        If IsNull(rs_saikyu222!newnyuukingoukei) Then
        '            sashihiki_nyuukingaku = 0
        '        Else
        '            sashihiki_nyuukingaku = rs_saikyu222!newnyuukingoukei
        '            rs_saikyu222.Close
        '        End If
        '    End If
        'End If


        ''最終請求書発効日の取得
        'Dim s_saishuu_seikyuubi As String = ""
        'If frmseikyuu.chknew.Value = 1 Then
        '    sql_cont24 = "select *" &
        '            " from seikyuusho where seikyuu_st='0'" &
        '            " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '            " order by hiduke desc"

        '    If FcSQlGet(1, rs_cont24, sql_cont24, WMsg) = False Then
        '        s_saishuu_seikyuubi = ""
        '    Else
        '        rs_cont24.MoveFirst
        '        Do Until rs_cont24.EOF
        '            s_saishuu_seikyuubi = Trim(rs_cont24!hiduke) '日付
        '            Exit Do
        '        Loop
        '        rs_cont24.Close
        '    End If

        'End If


        ''今回入金額
        'If s_saishuu_seikyuubi = "" Then
        '    sql_seikyu2 = "select sum(seikyuukingaku) as newnyuukingoukei" &
        '            " from seikyuusho where seikyuu_st='1'" &
        '            " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '            " and hiduke<='" & hinichi & "' and joukyou is null"
        'Else
        '    sql_seikyu2 = "select sum(seikyuukingaku) as newnyuukingoukei" &
        '            " from seikyuusho where seikyuu_st='1'" &
        '            " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '            " and hiduke between '" & s_saishuu_seikyuubi & "' and '" & hinichi & "' and joukyou is null"
        'End If

        ''Set rs_saikyu2 = New ADODB.Recordset
        'If FcSQlGet(1, rs_saikyu2, sql_seikyu2, WMsg) = True Then
        '    '入金がある場合*************************************************************
        '    If IsNull(rs_saikyu2!newnyuukingoukei) Then
        '        seikyuu_moto_data(i, 11) = 0
        '    Else
        '        seikyuu_moto_data(i, 11) = rs_saikyu2!newnyuukingoukei
        '        'If hajime_no_ippo = 1 Then

        '        If seikyuu_moto_data(ii, 23) = 1 Then
        '            seikyuu_moto_data(i, 6) = seikyuu_moto_data(ii, 24) + rs_saikyu2!newnyuukingoukei + sashihiki_nyuukingaku
        '            seikyuu_moto_data(i, 13) = seikyuu_moto_data(ii, 24) + sashihiki_nyuukingaku
        '        Else
        '            '請求書の有無の確認
        '            sql_seikyu12 = "select * from seikyuusho where seikyuu_st='0'" &
        '                        " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'"
        '            Set rs_saikyu12 = New ADODB.Recordset
        '            If FcSQlGet(1, rs_saikyu12, sql_seikyu12, WMsg) = False Then
        '                seikyuu_moto_data(i, 6) = 0 + sashihiki_nyuukingaku
        '                seikyuu_moto_data(i, 13) = 0 - rs_saikyu2!newnyuukingoukei + sashihiki_nyuukingaku
        '            Else
        '                seikyuu_moto_data(i, 6) = seikyuu_moto_data(i, 6) + rs_saikyu2!newnyuukingoukei + sashihiki_nyuukingaku
        '                'seikyuu_moto_data(scoun, 13) = seikyuu_moto_data(scoun, 13) - rs_saikyu2!newnyuukingoukei
        '                seikyuu_moto_data(i, 13) = seikyuu_moto_data(i, 13) + sashihiki_nyuukingaku
        '                rs_saikyu2.Close
        '                rs_saikyu12.Close
        '            End If
        '        End If
        '    End If

        'End If



        'If seikyuu_moto_data(i, 9) = "1" Then '伝票毎

        '    'taishougaku = 0 '売り上げ合計
        '    'taishouzeigaku = 0    '税額（総計）
        '    'taishouzeigaku10 = 0    '税額額（１０％
        '    'taishouzeigaku8 = 0    '課税対象額（８％
        '    'newdensuu = 0
        '    ''今回売上
        '    'sql_seikyu3 = "select hacchuu.hacchuuid,hacchuu.goukei" &
        '    '            " from hacchuu" &
        '    '            " where hacchuu.joukyou='0'" &
        '    '            " and hacchuu.tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '    '            " and hacchuu.iraibi<='" & hinichi & "'"
        '    ''Set rs_saikyu3 = New ADODB.Recordset
        '    'If FcSQlGet(1, rs_saikyu3, sql_seikyu3, WMsg) = True Then
        '    '    rs_saikyu3.MoveFirst
        '    '    Do Until rs_saikyu3.EOF
        '    '        sql_hika = "select sum(hacchuushousai.kei) as denhika" &
        '    '                " from hacchuushousai  right join shouhin" &
        '    '                " on hacchuushousai.shouhinid=shouhin.shouhinid" &
        '    '                " where shouhin.hikazei='1'and hacchuushousai.hacchuuid='" & rs_saikyu3!hacchuuid & "'"

        '    '        sql_hika = "select sum(hacchuushousai.kei) as denhika,shouhin.keigen_s" &
        '    '                " from hacchuushousai  right join shouhin" &
        '    '                " on hacchuushousai.shouhinid=shouhin.shouhinid" &
        '    '                " where shouhin.hikazei='1'and hacchuushousai.hacchuuid='" & rs_saikyu3!hacchuuid & "' group by shouhin.keigen_s"

        '    '        sql_hika = "select sum(hacchuushousai.kei) as denhika,hacchuushousai.keigen" &
        '    '                " from hacchuushousai  right join shouhin" &
        '    '                " on hacchuushousai.shouhinid=shouhin.shouhinid" &
        '    '                " where shouhin.hikazei ='1' and hacchuushousai.hacchuuid='" & rs_saikyu3!hacchuuid & "' group by hacchuushousai.keigen"

        '    '        sql_hika = "select sum(hacchuushousai.kei) as denhika,hacchuushousai.keigen" &
        '    '                " from hacchuushousai  right join shouhin" &
        '    '                " on hacchuushousai.shouhinid=shouhin.shouhinid" &
        '    '                " where hacchuushousai.hacchuuid='" & rs_saikyu3!hacchuuid & "' group by hacchuushousai.keigen"



        '    '        'Set rs_hika = New ADODB.Recordset
        '    '        If FcSQlGet(1, rs_hika, sql_hika, WMsg) = True Then
        '    '            rs_hika.MoveFirst
        '    '            Do Until rs_hika.EOF
        '    '                If IsNull(rs_hika!keigen) Then '10%
        '    '                    If IsNull(rs_hika!denhika) Then
        '    '                        tanzeigaku = zeikinkeisan(CDbl(rs_saikyu3!goukei), genzai_zeiritsu, CStr(seikyuu_moto_data(i, 8)))
        '    '                        taishouzeigaku10 = taishouzeigaku10 + tanzeigaku
        '    '                    Else
        '    '                        sanhika = CDbl(rs_hika!denhika)
        '    '                        If sanhika = 0 Then
        '    '                            tanzeigaku = 0
        '    '                            taishouzeigaku10 = taishouzeigaku10 + tanzeigaku
        '    '                        Else
        '    '                            tanzeigaku = zeikinkeisan(sanhika, genzai_zeiritsu, CStr(seikyuu_moto_data(i, 8)))
        '    '                            taishouzeigaku10 = taishouzeigaku10 + tanzeigaku
        '    '                        End If
        '    '                    End If

        '    '                Else '8%
        '    '                    If IsNull(rs_hika!denhika) Then
        '    '                        tanzeigaku = zeikinkeisan(CDbl(rs_saikyu3!goukei), 8, CStr(seikyuu_moto_data(i, 8)))
        '    '                        taishouzeigaku8 = taishouzeigaku8 + tanzeigaku
        '    '                    Else
        '    '                        sanhika = CDbl(rs_hika!denhika)
        '    '                        If sanhika = 0 Then
        '    '                            tanzeigaku = 0
        '    '                            taishouzeigaku8 = taishouzeigaku8 + tanzeigaku
        '    '                        Else
        '    '                            tanzeigaku = zeikinkeisan(sanhika, 8, CStr(seikyuu_moto_data(i, 8)))
        '    '                            taishouzeigaku8 = taishouzeigaku8 + tanzeigaku
        '    '                        End If
        '    '                    End If

        '    '                End If

        '    '                rs_hika.MoveNext
        '    '            Loop

        '    '            taishougaku = taishougaku + rs_saikyu3!goukei
        '    '        Else
        '    '            tanzeigaku = zeikinkeisan(CDbl(rs_saikyu3!goukei), genzai_zeiritsu, CStr(seikyuu_moto_data(i, 8)))
        '    '            taishougaku = taishougaku + rs_saikyu3!goukei
        '    '            taishouzeigaku10 = taishouzeigaku10 + tanzeigaku
        '    '        End If



        '    '        newdensuu = newdensuu + 1
        '    '        rs_saikyu3.MoveNext
        '    '    Loop
        '    '    rs_saikyu3.Close

        '    '    taishouzeigaku = taishouzeigaku8 + taishouzeigaku10
        '    '    seikyuu_moto_data(i, 12) = taishougaku '売り上げ合計
        '    '    seikyuu_moto_data(i, 18) = taishougaku
        '    'End If




        'Else



        '    ''今回売上
        '    'newdensuu = 0
        '    'sql_seikyu3 = "select sum(goukei) as newhachuugoukei,count(hacchuuid) as newdencount" &
        '    '            " from hacchuu where joukyou='0'" &
        '    '            " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '    '            " and iraibi<='" & hinichi & "'"
        '    ''Set rs_saikyu3 = New ADODB.Recordset
        '    'If FcSQlGet(1, rs_saikyu3, sql_seikyu3, WMsg) = True Then
        '    '    If IsNull(rs_saikyu3!newhachuugoukei) Then
        '    '        seikyuu_moto_data(i, 12) = 0
        '    '        seikyuu_moto_data(i, 18) = 0
        '    '    Else
        '    '        seikyuu_moto_data(i, 12) = rs_saikyu3!newhachuugoukei
        '    '        seikyuu_moto_data(i, 18) = rs_saikyu3!newhachuugoukei
        '    '        newdensuu = rs_saikyu3!newdencount
        '    '        rs_saikyu3.Close
        '    '    End If

        '    'End If




        '    ''軽減税率対応
        '    'taishouzeigaku10 = 0    '税額額（１０％
        '    'taishouzeigaku8 = 0    '課税対象額（８％
        '    'sql_hika = "select sum(hacchuushousai.kei) as denhika,hacchuushousai.keigen" &
        '    '            " from (hacchuu left join hacchuushousai on hacchuu.hacchuuid=hacchuushousai.hacchuuid) left join shouhin" &
        '    '            " on hacchuushousai.shouhinid=shouhin.shouhinid" &
        '    '            " where hacchuu.tenpoid='" & seikyuu_moto_data(i, 0) & "' and hacchuu.joukyou='0' and hacchuu.iraibi <= '" & hinichi & "' and shouhin.hikazei is null group by hacchuushousai.keigen"

        '    ''Set rs_hika = New ADODB.Recordset
        '    'If FcSQlGet(1, rs_hika, sql_hika, WMsg) = True Then
        '    '    rs_hika.MoveFirst
        '    '    Do Until rs_hika.EOF
        '    '        If IsNull(rs_hika!keigen) Then '10%

        '    '            sanhika = CDbl(rs_hika!denhika)
        '    '            tanzeigaku = zeikinkeisan(sanhika, genzai_zeiritsu, CStr(seikyuu_moto_data(i, 8)))
        '    '            taishouzeigaku10 = taishouzeigaku10 + tanzeigaku


        '    '        Else '8%

        '    '            sanhika = CDbl(rs_hika!denhika)

        '    '            tanzeigaku = zeikinkeisan(sanhika, 8, CStr(seikyuu_moto_data(i, 8)))
        '    '            taishouzeigaku8 = taishouzeigaku8 + tanzeigaku

        '    '        End If


        '    '        rs_hika.MoveNext
        '    '    Loop

        '    '    taishouzeigaku = taishouzeigaku8 + taishouzeigaku10
        '    'Else
        '    '    taishouzeigaku = taishouzeigaku + tanzeigaku
        '    'End If



        '    ''期間中の非課税合計額
        '    'keisan_hikazeigaku = 0
        '    'sql_hika = "select sum(hacchuushousai.kei) as newhika" &
        '    '                " from hacchuu right join (hacchuushousai  right join shouhin" &
        '    '                " on hacchuushousai.shouhinid=shouhin.shouhinid)" &
        '    '                " on hacchuu.hacchuuid=hacchuushousai.hacchuuid" &
        '    '                " where shouhin.hikazei='1'" &
        '    '                " and hacchuu.tenpoid='" & seikyuu_moto_data(i, 0) & "' and hacchuu.joukyou='0'" &
        '    '                " and hacchuu.iraibi<='" & hinichi & "'"
        '    ''Set rs_hika = New ADODB.Recordset
        '    'If FcSQlGet(1, rs_hika, sql_hika, WMsg) = True Then
        '    '    If IsNull(rs_hika!newhika) Then
        '    '        keisan_hikazeigaku = 0
        '    '    Else
        '    '        keisan_hikazeigaku = rs_hika!newhika
        '    '    End If
        '    'End If

        'End If



        'seikyuu_moto_data(i, 20) = keisan_hikazeigaku
        ''枚数
        'seikyuu_moto_data(i, 19) = newdensuu
        ''今回返品
        'sql_seikyu4 = "select sum(hacchuushousai.kei) as newhenpingoukei" &
        '            " from hacchuu right join hacchuushousai" &
        '            " on hacchuu.hacchuuid=hacchuushousai.hacchuuid" &
        '            " where hacchuu.joukyou='0'" &
        '            " and hacchuu.tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '            " and hacchuu.iraibi<='" & hinichi & "'" &
        '            " and hacchuushousai.kosuu<=0"
        'Set rs_saikyu4 = New ADODB.Recordset
        'If FcSQlGet(1, rs_saikyu4, sql_seikyu4, WMsg) = True Then
        '    If IsNull(rs_saikyu4!newhenpingoukei) Then
        '        seikyuu_moto_data(i, 17) = 0
        '    Else
        '        seikyuu_moto_data(i, 17) = rs_saikyu4!newhenpingoukei
        '        seikyuu_moto_data(i, 12) = seikyuu_moto_data(i, 12) - rs_saikyu4!newhenpingoukei
        '        rs_saikyu4.Close
        '    End If
        'End If

        'If seikyuu_moto_data(i, 9) = "1" Then '伝票毎
        '    '消費税計算

        '    If seikyuu_moto_data(i, 12) = 0 Then
        '        If seikyuu_moto_data(i, 17) = 0 Then '返品なし
        '            seikyuu_moto_data(i, 14) = 0
        '            seikyuu_moto_data(i, 25) = 0
        '            seikyuu_moto_data(i, 26) = 0
        '        Else
        '            seikyuu_moto_data(i, 25) = taishouzeigaku10
        '            seikyuu_moto_data(i, 26) = taishouzeigaku8
        '            seikyuu_moto_data(i, 14) = taishouzeigaku
        '        End If
        '    Else
        '        seikyuu_moto_data(i, 25) = taishouzeigaku10
        '        seikyuu_moto_data(i, 26) = taishouzeigaku8
        '        seikyuu_moto_data(i, 14) = taishouzeigaku
        '    End If
        'Else
        '    '消費税計算
        '    If seikyuu_moto_data(i, 12) = 0 Then
        '        If seikyuu_moto_data(i, 17) = 0 Then '返品なし
        '            seikyuu_moto_data(i, 14) = 0
        '            seikyuu_moto_data(i, 25) = 0
        '            seikyuu_moto_data(i, 26) = 0
        '        Else
        '            'seikyuu_moto_data(scoun, 14) = zeikinkeisan(CDbl(seikyuu_moto_data(scoun, 17)) - CDbl(seikyuu_moto_data(scoun, 20)), genzai_zeiritsu, CStr(seikyuu_moto_data(scoun, 8)))

        '            seikyuu_moto_data(i, 25) = taishouzeigaku10
        '            seikyuu_moto_data(i, 26) = taishouzeigaku8
        '            seikyuu_moto_data(i, 14) = taishouzeigaku
        '        End If
        '    Else
        '        'seikyuu_moto_data(scoun, 14) = zeikinkeisan(CDbl(seikyuu_moto_data(scoun, 18)) - CDbl(seikyuu_moto_data(scoun, 20)), genzai_zeiritsu, CStr(seikyuu_moto_data(scoun, 8)))
        '        seikyuu_moto_data(i, 25) = taishouzeigaku10
        '        seikyuu_moto_data(i, 26) = taishouzeigaku8
        '        seikyuu_moto_data(i, 14) = taishouzeigaku
        '    End If
        'End If



        ''再計算
        'seikyuu_moto_data(i, 15) = seikyuu_moto_data(i, 13) + seikyuu_moto_data(i, 18) + seikyuu_moto_data(i, 14)

        ''作成するかをチェック
        'If seikyuu_moto_data(i, 12) = 0 And seikyuu_moto_data(i, 11) = 0 And seikyuu_moto_data(i, 17) = 0 Then
        '    If seikyuu_moto_data(i, 13) = 0 Then
        '        '計算繰越と売上と入金と返品が０のとき
        '        If seikyuu_moto_data(i, 19) = 0 Then
        '            '納品書枚数が０のときは、出さない
        '            seikyuu_moto_data(i, 16) = 0
        '        Else
        '            '納品書枚数が０以外のときは、出す
        '            seikyuu_moto_data(i, 16) = 1
        '            newseikyusuu2 = newseikyusuu2 + 1
        '        End If
        '    Else
        '        sql_seikyu5 = "select sum(seikyuukingaku) as newnyuukingoukei" &
        '                " from seikyuusho where seikyuu_st='1'" &
        '                " and tenpoid ='" & seikyuu_moto_data(i, 0) & "'" &
        '                " and hiduke>'" & hinichi & "' and joukyou is null"
        '    Set rs_saikyu5 = New ADODB.Recordset
        '    If FcSQlGet(1, rs_saikyu5, sql_seikyu5, WMsg) = True Then
        '            If (rs_saikyu5!newnyuukingoukei) * -1 = seikyuu_moto_data(i, 13) Then
        '                seikyuu_moto_data(i, 16) = 0
        '            Else
        '                seikyuu_moto_data(i, 16) = 1
        '                newseikyusuu2 = newseikyusuu2 + 1
        '            End If
        '        Else
        '            seikyuu_moto_data(i, 16) = 1
        '            newseikyusuu2 = newseikyusuu2 + 1
        '        End If
        '    End If
        'Else
        '    seikyuu_moto_data(i, 16) = 1
        '    newseikyusuu2 = newseikyusuu2 + 1
        'End If



        ''データチェック
        'If seikyuu_moto_data(i, 6) - seikyuu_moto_data(i, 11) <> seikyuu_moto_data(i, 13) Then
        '    ret = MsgBox("繰越残高が不正です。" & seikyuu_moto_data(i, 0) & Space(2) & seikyuu_moto_data(i, 1), 16, "総合管理システム「SPSALES」")
        '    log_write("[請求書]繰越残高が不正です。" & seikyuu_moto_data(i, 0) & Space(2) & seikyuu_moto_data(i, 1))
        '    seikyuu_moto_data(i, 27) = 1
        'End If
        'If seikyuu_moto_data(i, 13) + seikyuu_moto_data(i, 12) + seikyuu_moto_data(i, 17) + seikyuu_moto_data(i, 14) <> seikyuu_moto_data(i, 15) Then
        '    ret = MsgBox("総計が不正です。" & seikyuu_moto_data(i, 0) & Space(2) & seikyuu_moto_data(i, 1), 16, "総合管理システム「SPSALES」")
        '    log_write("[請求書]総計が不正です。" & seikyuu_moto_data(i, 0) & Space(2) & seikyuu_moto_data(i, 1))
        '    seikyuu_moto_data(i, 27) = 2
        'End If
        'If seikyuu_moto_data(i, 6) <> seikyuu_moto_data(i, 22) Then
        '    'ret = MsgBox("前月の請求金額と今月の繰越金額が違います。" & seikyuu_moto_data(scoun, 0) & Space(2) & seikyuu_moto_data(scoun, 1), 16, "総合管理システム「SPSALES」")

        '    'ret = MsgBox("出来れば印刷せずベンダーにご連絡ください。", 16, "総合管理システム「SPSALES」")
        '    log_write("[請求書]前月の請求金額と今月の繰越金額の違いを修正しました。" & seikyuu_moto_data(i, 0) & Space(2) & seikyuu_moto_data(i, 1))
        '    seikyuu_moto_data(i, 6) = seikyuu_moto_data(i, 22)

        'End If


        'frmseikyuu.ppp.Value = i
        'DoEvents

        'Next i

        'frmseikyuu.ppp.Value = 0
        'frmseikyuu.ppp.Visible = False
        'DoEvents

        'If newseikyusuu2 <> 0 Then
        '    grid_seikyu_set(newseikyusuu2 + 1)
        '    newseikyusuu3 = 1
        '    For scoun = 0 To seikyuu_moto_data_count - 1
        '        With frmseikyuu.gridseikyu
        '            If seikyuu_moto_data(scoun, 16) = 1 Then
        '                .Row = newseikyusuu3
        '                .Col = 0
        '                .Text = newseikyusuu3
        '                .CellChecked = 2
        '                .CellPictureAlignment = flexPicAlignLeftCenter
        '                .Editable = flexEDKbd
        '                .Col = 1
        '                .Text = seikyuu_moto_data(scoun, 21) 'ID
        '                .Col = 2
        '                .Text = seikyuu_moto_data(scoun, 0) '店舗ID
        '                .Col = 3
        '                .Text = seikyuu_moto_data(scoun, 1) '店舗名
        '                .Col = 4
        '                .Text = Format(seikyuu_moto_data(scoun, 6), "#,##0;-#,##0") '前回請求額
        '                .Col = 5
        '                .Text = Format(seikyuu_moto_data(scoun, 11), "#,##0;-#,##0") '今回入金額
        '                .Col = 6
        '                .Text = Format(seikyuu_moto_data(scoun, 13), "#,##0;-#,##0") '計算繰越
        '                .Col = 7
        '                .Text = Format(seikyuu_moto_data(scoun, 12), "#,##0;-#,##0") '売上
        '                .Col = 8
        '                .Text = Format(seikyuu_moto_data(scoun, 17), "#,##0;-#,##0") '今月返品額
        '                .Col = 9
        '                .Text = Format(seikyuu_moto_data(scoun, 14), "#,##0;-#,##0") '消費税
        '                .Col = 10
        '                .Text = Format(seikyuu_moto_data(scoun, 15), "#,##0;-#,##0") '今月そう合計額
        '                .Col = 11
        '                .Text = seikyuu_moto_data(scoun, 7)
        '                .Col = 12
        '                .Text = seikyuu_moto_data(scoun, 8)
        '                .Col = 13
        '                .Text = seikyuu_moto_data(scoun, 9)
        '                .Col = 14
        '                .Text = seikyuu_moto_data(scoun, 19)
        '                .Col = 15
        '                .Text = "備考"
        '                .Col = 16
        '                If IsNull(seikyuu_moto_data(scoun, 3)) Then
        '                    .Text = ""
        '                Else
        '                    .Text = seikyuu_moto_data(scoun, 3)
        '                End If
        '                .Col = 17
        '                If IsNull(seikyuu_moto_data(scoun, 4)) Then
        '                    If IsNull(seikyuu_moto_data(scoun, 5)) Then
        '                        .Text = ""
        '                    Else
        '                        .Text = seikyuu_moto_data(scoun, 5)
        '                    End If
        '                Else
        '                    If IsNull(seikyuu_moto_data(scoun, 5)) Then
        '                        .Text = seikyuu_moto_data(scoun, 4)
        '                    Else
        '                        .Text = seikyuu_moto_data(scoun, 4) & seikyuu_moto_data(scoun, 5)
        '                    End If
        '                End If
        '                .Col = 18
        '                .Text = seikyuu_moto_data(scoun, 2)

        '                .Col = 19
        '                .Text = seikyuu_moto_data(scoun, 25) '消費税10％

        '                .Col = 20
        '                .Text = seikyuu_moto_data(scoun, 26) '消費税8％

        '                .Col = 21
        '                .Text = seikyuu_moto_data(scoun, 27) 'エラー

        '                newseikyusuu3 = newseikyusuu3 + 1
        '            End If

        '        End With

        '    Next

        'End If

        'cnn.Close

        'log_write("請求書の抽出終了********************************************")

    End Sub

    Private Function zeikinkeisan(motone As Double, zeiritsu As Double, zeitype As String) As Double

        If motone = 0 Then
            Return 0
        End If

        Dim karishouhizei_sub As Double = Math.Abs(motone) * zeiritsu / 100

        Dim zeigaku As Double
        Select Case zeitype
            Case "0" ' 切り捨て
                zeigaku = Math.Floor(karishouhizei_sub)
            Case "1" ' 四捨五入
                zeigaku = Math.Round(karishouhizei_sub, 0, MidpointRounding.AwayFromZero)
            Case "2" ' 切り上げ
                zeigaku = Math.Ceiling(karishouhizei_sub)
            Case Else
                msg_go("店舗の税端数情報を取得できませんでした。戻り値「税額」は、0円です。")
                Return 0
        End Select

        If motone < 0 Then
            zeigaku = -zeigaku
        End If

        Return zeigaku

    End Function

    Private Sub show_shinkou_joukyou(title As String, max_count As Integer)

        gbx_shinkou_joukyou.Visible = True
        lbl_shinkou_title.Text = title

        gbx_shinkou_joukyou.BringToFront()
        Dim x As Integer = (ClientSize.Width - gbx_shinkou_joukyou.Width) \ 2
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