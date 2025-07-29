Imports System.Data.SqlClient

Public Class frmnyuukin_rireki
    Private Sub frmnyuukin_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))
        Dim sakanobori_nensuu = 20

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

        set_shain_cbx(2)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_kakunin_Click(sender As Object, e As EventArgs) Handles btn_kakunin.Click

    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

        Dim nen = cbx_nen.Text
        Dim tsuki = cbx_tsuki.Text
        If nen = "" Or tsuki = "" Then
            msg_go("年と月は両方選択してください。")
            Exit Sub
        End If

        Dim hi = cbx_hi.Text
        Dim hinichi_kaishi = ""
        Dim hinichi_owari = ""
        If hi = "" Then
            hinichi_kaishi = nen + tsuki + "01"
            hinichi_owari = nen + tsuki + "31"
        Else
            hinichi_kaishi = nen + tsuki + hi
            hinichi_owari = nen + tsuki + hi
        End If

        Dim shain_id = Mid(Trim(cbx_shain.Text), 1, 2)

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 10

            .Columns(0).Name = ""
            .Columns(1).Name = "NO"
            .Columns(2).Name = "日付"
            .Columns(3).Name = "伝票NO"
            .Columns(4).Name = "店舗名"
            .Columns(5).Name = "金額"
            .Columns(6).Name = "方法"
            .Columns(7).Name = "確認状況"
            .Columns(8).Name = "備考"
            .Columns(9).Name = "請求書ID"

            .Columns(0).Width = 30
            .Columns(1).Width = 50
            .Columns(2).Width = 110
            .Columns(3).Width = 100
            .Columns(4).Width = 300
            .Columns(5).Width = 90
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 289
            .Columns(9).Width = 0

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(4).DefaultCellStyle.Format = "#,##0"

        End With

        Dim sum_goukei_gaku = 0
        Dim kensuu = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT seikyuusho.*, tenpo.tenpomei FROM seikyuusho RIGHT JOIN tenpo ON seikyuusho.tenpoid = tenpo.tenpoid"

            Dim query_where = " WHERE seikyuusho.seikyuu_st = '1' AND seikyuusho.hiduke BETWEEN '" + hinichi_kaishi + "' AND '" + hinichi_owari + "'"

            If shain_id <> "" Then
                query_where += " AND tenpo.shainid = '" & shain_id & "'"
            End If

            If chk_hyouji_shinai.Checked Then
                query_where += " AND seikyuusho.kakunin IS NULL"
            End If

            query += query_where + " ORDER BY seikyuusho.hiduke, tenpo.tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            kensuu = dt_server.Rows.Count
            Dim mojiretsu(9)
            For i = 0 To kensuu - 1

                mojiretsu(0) = ""
                mojiretsu(1) = (i + 1).ToString("D3")

                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                If Not IsDBNull(dt_server.Rows.Item(i).Item("dami")) Then
                    Dim dami = Trim(dt_server.Rows.Item(i).Item("dami"))
                    If dami = "1" Then
                        ' TODO
                        '.Cell(flexcpBackColor, seikyuuGROW, 1) = &HC0E0FF
                    End If
                End If

                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("ryoushuuno"))
                mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                Dim seikyuukingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuukingaku")) Then
                    seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                End If
                mojiretsu(5) = seikyuukingaku
                sum_goukei_gaku += seikyuukingaku

                Dim seikyuu_name = "不明"
                Select Case Trim(dt_server.Rows.Item(i).Item("seikyuutanni"))
                    Case "0"
                        seikyuu_name = "現金"
                    Case "1"
                        seikyuu_name = "振込"
                    Case "2"
                        seikyuu_name = "小切手"
                    Case "3"
                        seikyuu_name = "相殺"
                    Case "4"
                        seikyuu_name = "手数料"
                    Case "5"
                        seikyuu_name = "値引"
                    Case "6"
                        seikyuu_name = "その他"
                    Case "7"
                        seikyuu_name = "クレジット"
                End Select
                mojiretsu(6) = seikyuu_name

                Dim kakunin = "未確認"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kakunin")) Then
                    kakunin = "確認済み"
                End If
                mojiretsu(7) = kakunin

                Dim seikyuubikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuubikou")) Then
                    seikyuubikou = Trim(dt_server.Rows.Item(i).Item("seikyuubikou"))
                End If
                mojiretsu(8) = seikyuubikou

                mojiretsu(9) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))

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

    Private Sub btn_clear_hi_Click(sender As Object, e As EventArgs) Handles btn_clear_hi.Click
        cbx_hi.SelectedIndex = -1
    End Sub

    Private Sub btn_clear_shain_Click(sender As Object, e As EventArgs) Handles btn_clear_shain.Click
        cbx_shain.SelectedIndex = -1
    End Sub

    Private Sub chk_hyouji_shinai_Click(sender As Object, e As EventArgs) Handles chk_hyouji_shinai.Click
        clear_shuukei()
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        set_hinichi_cbx()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        set_hinichi_cbx()
    End Sub

    Private Sub cbx_hi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_hi.SelectedIndexChanged
        clear_shuukei()
    End Sub

    Private Sub cbx_shain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shain.SelectedIndexChanged
        clear_shuukei()
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

    Private Sub set_hinichi_cbx()

        clear_shuukei()

        Dim nen = cbx_nen.Text
        Dim tsuki = cbx_tsuki.Text
        If nen = "" Or tsuki = "" Then
            Exit Sub
        End If

        Dim nissuu = get_tsuki_saishuubi(nen, tsuki)

        cbx_hi.Items.Clear()
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