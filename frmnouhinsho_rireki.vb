Imports System.Data.SqlClient

Public Class frmnouhinsho_rireki
    Private Sub frmnouhinsho_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))
        Dim sakanobori_nensuu = 22

        cbx_nen.Items.Clear()
        For i = nen_ima - sakanobori_nensuu To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))

        cbx_tsuki.Items.Clear()
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))

        set_hinichi_cbx()
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(Now.ToString("dd"))

        set_shain_cbx(3)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_shuukei()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_kakunin_Click(sender As Object, e As EventArgs) Handles btn_kakunin.Click

    End Sub

    Private Sub btn_clear_hi_Click(sender As Object, e As EventArgs) Handles btn_clear_hi.Click

        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))
        set_hinichi_cbx()
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(Now.ToString("dd"))

    End Sub

    Private Sub btn_clear_shain_Click(sender As Object, e As EventArgs) Handles btn_clear_shain.Click
        cbx_shain.SelectedIndex = -1
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged

        Dim hi = cbx_hi.Text
        set_hinichi_cbx()
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(hi)

    End Sub

    Private Sub cbx_hi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_hi.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub cbx_shain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shain.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub chk_hyouji_shinai_Click(sender As Object, e As EventArgs) Handles chk_hyouji_shinai.Click
        clear_shuukei()
    End Sub

    Private Sub chk_mi_check_Click(sender As Object, e As EventArgs) Handles chk_mi_check.Click
        If chk_mi_check.Checked = True Then
            chk_hyouji_shinai.Checked = True
        End If
        clear_shuukei()
    End Sub

    Private Sub set_shuukei()

        Dim nen = cbx_nen.Text
        Dim tsuki = cbx_tsuki.Text
        Dim hi = cbx_hi.Text
        If nen = "" Or tsuki = "" Or hi = "" Then
            msg_go("年と月と日をすべて選択してください。")
            Exit Sub
        End If

        Dim hinichi = nen + tsuki + hi

        Dim shain_id = Mid(Trim(cbx_shain.Text), 1, 2)

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 9

            .Columns(0).Name = "NO"
            .Columns(1).Name = "納品日"
            .Columns(2).Name = "伝票NO"
            .Columns(3).Name = "納品書ID"
            .Columns(4).Name = "店舗名"
            .Columns(5).Name = "金額"
            .Columns(6).Name = "発行社員名"
            .Columns(7).Name = "発行状況"
            .Columns(8).Name = "確認状況"

            .Columns(0).Width = 75
            .Columns(1).Width = 110
            .Columns(2).Width = 100
            .Columns(3).Width = 110
            .Columns(4).Width = 305
            .Columns(5).Width = 90
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).DefaultCellStyle.Format = "#,##0"

        End With

        Dim sum_goukei_gaku = 0
        Dim kensuu = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.*, shain.ryakumei, tenpo.tenpomei" +
                " FROM (hacchuu RIGHT JOIN tenpo ON hacchuu.tenpoid = tenpo.tenpoid)" +
                " RIGHT JOIN shain ON hacchuu.shainid = shain.shainid"

            Dim query_where = ""

            If chk_mi_check.Checked Then
                Dim hinichi_kaishi = Date.ParseExact(hinichi, "yyyyMMdd", Nothing).AddYears(-1).ToString("yyyyMMdd")
                query_where = " WHERE hacchuu.iraibi BETWEEN '" + hinichi_kaishi + "' AND '" + hinichi + "'"
            Else
                query_where = " WHERE hacchuu.iraibi = '" + hinichi + "'"
            End If

            If shain_id <> "" Then
                query_where += " AND tenpo.shainid = '" & shain_id & "'"
            End If

            If chk_hyouji_shinai.Checked Then
                query_where += " AND hacchuu.kakunin IS NULL"
            End If

            query += query_where + " ORDER BY hacchuu.hacchuuid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_hacchuu"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            kensuu = dt_server.Rows.Count
            Dim mojiretsu(9)
            For i = 0 To kensuu - 1

                mojiretsu(0) = (i + 1).ToString()

                mojiretsu(1) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("iraibi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("hacchuuid"))

                Dim nouhinshoid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    nouhinshoid = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If
                mojiretsu(3) = nouhinshoid

                mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                Dim goukei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukei")) Then
                    goukei = CInt(Trim(dt_server.Rows.Item(i).Item("goukei")))
                End If
                mojiretsu(5) = goukei
                sum_goukei_gaku += goukei

                mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("shainid")) + " " + Trim(dt_server.Rows.Item(i).Item("ryakumei"))

                Dim shutsu = "未発行"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shutsu")) Then
                    shutsu = "発行済み"
                End If
                mojiretsu(7) = shutsu

                Dim kakunin = "未確認"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kakunin")) Then
                    kakunin = "確認済み"
                End If
                mojiretsu(8) = kakunin

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kensuu.Text = kensuu.ToString("#,0") + " 件"
        lbl_goukeigaku.Text = sum_goukei_gaku.ToString("#,0") + " 円"

    End Sub

    Private Sub set_hinichi_cbx()

        clear_shuukei()

        Dim nen = cbx_nen.Text
        Dim tsuki = cbx_tsuki.Text
        If nen = "" Or tsuki = "" Then
            Exit Sub
        End If

        cbx_hi.Items.Clear()
        Dim nissuu = get_tsuki_saishuubi(nen, tsuki)
        For i = 1 To CInt(nissuu)
            cbx_hi.Items.Add(i.ToString("D2"))
        Next

    End Sub

    Private Sub clear_shuukei()
        dgv_kensakukekka.Rows.Clear()
        lbl_kensuu.Text = "0 件"
        lbl_goukeigaku.Text = "0 円"
    End Sub

End Class