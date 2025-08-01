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

        ' TODO:main画面に詳細が移動したため、保留
        frmnouhinsho_rireki_shousai.ShowDialog()

    End Sub

    Private Sub btn_kakunin_Click(sender As Object, e As EventArgs) Handles btn_kakunin.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        Dim can_delete = False
        For i = 0 To dgv_kensakukekka.Rows.Count - 1
            If dgv_kensakukekka(0, i).Value = True Then
                can_delete = True
                Exit For
            End If
        Next

        If can_delete = False Then
            msg_go("確認したい項目を選択してから実行してください。")
            Exit Sub
        End If

        For i = 0 To dgv_kensakukekka.Rows.Count - 1

            If dgv_kensakukekka(0, i).Value = False Then
                Continue For
            End If

            Dim hacchuuid = dgv_kensakukekka(3, i).Value
            Dim motokakunin = dgv_kensakukekka(9, i).Value

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "select * from hacchuu WHERE hacchuuid = '" + hacchuuid + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                Dim temp_table_name = "t_hacchuu"
                da.Fill(ds, temp_table_name)

                Select Case motokakunin
                    Case "確認済み"
                        ds.Tables(temp_table_name).Rows(0)("kakunin") = DBNull.Value
                    Case "未確認"
                        ds.Tables(temp_table_name).Rows(0)("kakunin") = "1"
                    Case Else
                        ds.Tables(temp_table_name).Rows(0)("kakunin") = DBNull.Value
                End Select

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        Next

        set_shuukei()

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
            .ColumnCount = 10

            .Columns(0).Name = ""
            .Columns(1).Name = "NO"
            .Columns(2).Name = "納品日"
            .Columns(3).Name = "伝票NO"
            .Columns(4).Name = "納品書ID"
            .Columns(5).Name = "店舗名"
            .Columns(6).Name = "金額"
            .Columns(7).Name = "発行社員名"
            .Columns(8).Name = "発行状況"
            .Columns(9).Name = "確認状況"

            .Columns(0).Width = 30
            .Columns(1).Width = 75
            .Columns(2).Width = 110
            .Columns(3).Width = 100
            .Columns(4).Width = 110
            .Columns(5).Width = 275
            .Columns(6).Width = 90
            .Columns(7).Width = 100
            .Columns(8).Width = 100
            .Columns(9).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

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

                mojiretsu(0) = ""
                mojiretsu(1) = (i + 1).ToString()
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("iraibi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("hacchuuid"))

                Dim nouhinshoid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    nouhinshoid = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If
                mojiretsu(4) = nouhinshoid

                mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                Dim goukei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukei")) Then
                    goukei = CInt(Trim(dt_server.Rows.Item(i).Item("goukei")))
                End If
                mojiretsu(6) = goukei
                sum_goukei_gaku += goukei

                mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("shainid")) + " " + Trim(dt_server.Rows.Item(i).Item("ryakumei"))

                Dim shutsu = "未発行"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shutsu")) Then
                    shutsu = "発行済み"
                End If
                mojiretsu(8) = shutsu

                Dim kakunin = "未確認"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kakunin")) Then
                    kakunin = "確認済み"
                End If
                mojiretsu(9) = kakunin

                dgv_kensakukekka.Rows.Add(mojiretsu)

                dgv_kensakukekka.Rows(i).Cells(0) = New DataGridViewCheckBoxCell
                dgv_kensakukekka.Rows(i).Cells(0).Value = False

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