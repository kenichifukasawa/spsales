Imports System.Data.SqlClient

Public Class frmshiharai_shori
    Private Sub frmshiharai_shori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_gyousha_cbx(3, False)
        dtp_shiharai_bi.Value = Now.ToString("yyyy/MM/dd")
        dtp_shiharai_kijitsu.Value = Now.ToString("yyyy/MM/dd")
        dtp_shiharai_kijitsu.Checked = False
        cbx_shiharai_houhou.Items.AddRange(PaymentMethodsInvoice.Names)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

        Dim dgv = dgv_kensakukekka_shiire
        Dim can = False
        For i = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = True Then
                can = True
            End If
        Next
        If Not can Then
            msg_go("関連にしたい項目を選択してから実行してください。")
            Exit Sub
        End If

        Dim gyousha_id = Mid(Trim(cbx_gyousha.Text), 1, 6)
        If gyousha_id = "" Then
            msg_go("業者を選択してください。")
            Exit Sub
        End If

        Dim houhou = Trim(cbx_shiharai_houhou.Text)
        If houhou = "" Then
            msg_go("方法を選択してください。")
            Exit Sub
        End If
        Dim houhou_id = PaymentMethodsInvoice.GetIdByName(houhou)

        Dim shiharai_kingaku = Trim(txt_kingaku.Text)
        If shiharai_kingaku = "" Then
            msg_go("金額を入力してください。")
            Exit Sub
        End If
        Dim int_shiharai_kingaku = CInt(shiharai_kingaku)

        Dim shiharaibi = dtp_shiharai_bi.Value.ToString("yyyyMMdd")

        Dim kijitsu = dtp_shiharai_kijitsu.Value.ToString("yyyyMMdd")
        If dtp_shiharai_kijitsu.Checked = False Then
            Dim result As DialogResult = MessageBox.Show("支払期日が設定されていませんがよろしいですか？", "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
                Exit Sub
            End If
            kijitsu = ""
        End If

        Dim bikou = Trim(txt_bikou.Text)

        Dim id_busy = 2
        Dim s_no_busy = 4
        Dim get_response_busy = get_settings(id:=id_busy, s_no:=s_no_busy)
        If get_response_busy = "" Then
            msg_go("ビジーの取得に失敗しました。")
            Exit Sub
        Else

            If get_response_busy <> "0" Then
                msg_go("サーバがビジーです。少ししてから再度実行してください。")
                Exit Sub
            End If

            Dim update_response = update_settings(id:=id_busy, s_no:=s_no_busy, new_value:="1")
            If Not update_response Then
                msg_go("ビジーの更新に失敗しました。")
                Exit Sub
            End If

        End If

        Dim id = 1
        Dim s_no = 14
        Dim ketasuu = 8
        Dim new_id = get_settings(id:=id, s_no:=s_no)
        Dim next_id As String
        If new_id = "" Then
            msg_go("IDの取得に失敗しました。")
            Exit Sub
        ElseIf new_id = "0" Then
            next_id = "2"
            new_id = 1.ToString("D" + ketasuu.ToString)
        Else
            next_id = (CLng(new_id) + 1).ToString
            new_id = new_id.ToString.PadLeft(ketasuu, "0"c)
        End If

        Dim response = update_settings(id:=id, s_no:=s_no, new_value:=next_id)
        If Not response Then
            msg_go("IDの更新に失敗しました。")
            Exit Sub
        End If

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shukkin"

            Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds As New DataSet
            Dim temp_table_name = "t_shukkin"
            da.Fill(ds, temp_table_name)
            Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

            data_row("shukkinid") = new_id
            data_row("gyoushaid") = gyousha_id
            data_row("shukkinbi") = shiharaibi
            data_row("shukkingaku") = int_shiharai_kingaku
            data_row("shukkinhouhou") = houhou_id

            If bikou <> "" Then
                data_row("bikou") = bikou
            End If

            If kijitsu <> "" Then
                data_row("kijitsu") = kijitsu
            End If

            ds.Tables(temp_table_name).Rows.Add(data_row)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        For i = 0 To dgv.Rows.Count - 1

            If dgv.Rows(i).Cells(0).Value = False Then
                Continue For
            End If

            Dim shiireid = dgv.Rows(i).Cells(2).Value

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM shiire WHERE shiireid = '" + shiireid + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                Dim temp_table_name = "t_shiire"
                da.Fill(ds, temp_table_name)

                Dim table = ds.Tables(temp_table_name)

                table.Rows(0)("shukkinid") = new_id
                table.Rows(0)("shiharaibi") = shiharaibi
                table.Rows(0)("joukyou") = "1"

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        Next

        Dim update_response_2 = update_settings(id:=id_busy, s_no:=s_no_busy, new_value:="0")
        If Not update_response_2 Then
            msg_go("ビジーの更新に失敗しました。")
            Exit Sub
        End If

        msg_go("登録しました。", 64)

        set_shuukei()

    End Sub

    Private Sub btn_shiire_shousai_Click(sender As Object, e As EventArgs) Handles btn_shiire_shousai.Click

        Dim dgv = dgv_kensakukekka_shiire
        If dgv.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        Dim shiire_id = dgv.CurrentRow.Cells(2).Value
        Dim hiduke = dgv.CurrentRow.Cells(3).Value
        Dim gyousha_mei = Mid(Trim(cbx_gyousha.Text), 1, 10)

        set_shiire_rireki_shousai(dgv.Rows.Count, shiire_id, hiduke, gyousha_mei)

    End Sub

    Private Sub btn_shiharai_shousai_Click(sender As Object, e As EventArgs) Handles btn_shiharai_shousai.Click

        Dim dgv = dgv_kensakukekka_shiharai
        If dgv.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        Dim shukkin_id = dgv.CurrentRow.Cells(1).Value
        Dim hiduke = dgv.CurrentRow.Cells(2).Value
        Dim gyousha_mei = Mid(Trim(cbx_gyousha.Text), 1, 10)

        With frmshiharai_rireki_shousai

            .lbl_hiduke.Text = hiduke
            .lbl_shukkin_id.Text = shukkin_id
            .lbl_shiiresaki.Text = gyousha_mei

            .ShowDialog()

        End With

    End Sub

    Private Sub dgv_kensakukekka_shiire_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kensakukekka_shiire.CellMouseClick

        Dim dgv = dgv_kensakukekka_shiire

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            Dim currentRow As DataGridViewRow = dgv.Rows(e.RowIndex)
            Dim isChecked As Boolean = CBool(currentRow.Cells(0).Value)

            If isChecked Then
                currentRow.Cells(0).Value = False

                If currentRow.Index Mod 2 = 0 Then
                    currentRow.DefaultCellStyle.BackColor = dgv.RowsDefaultCellStyle.BackColor
                Else
                    currentRow.DefaultCellStyle.BackColor = dgv.AlternatingRowsDefaultCellStyle.BackColor
                End If

            Else
                currentRow.Cells(0).Value = True
                currentRow.DefaultCellStyle.BackColor = Color.Yellow
            End If

            dgv.ClearSelection()

        End If

        Dim goukei_kingaku = 0
        For i = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = True Then
                Dim kingaku = dgv.Rows(i).Cells(4).Value
                goukei_kingaku += CInt(kingaku)
            End If
        Next
        lbl_goukei_kingaku.Text = goukei_kingaku.ToString("#,0")

    End Sub

    Private Sub cbx_gyousha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gyousha.SelectedIndexChanged
        set_shuukei()
    End Sub

    Private Sub dtp_shiharai_bi_CloseUp(sender As Object, e As EventArgs) Handles dtp_shiharai_bi.CloseUp
        cbx_shiharai_houhou.Focus()
    End Sub

    Private Sub dtp_shiharai_kijitsu_CloseUp(sender As Object, e As EventArgs) Handles dtp_shiharai_kijitsu.CloseUp
        cbx_shiharai_houhou.Focus()
    End Sub

    Private Sub cbx_shiharai_houhou_KeyDown(sender As Object, e As KeyEventArgs) Handles cbx_shiharai_houhou.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_kingaku.Focus()
        End If
    End Sub

    Private Sub txt_kingaku_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kingaku.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_bikou.Focus()
        End If
    End Sub

    Private Sub txt_bikou_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bikou.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_touroku.PerformClick()
        End If
    End Sub

    Private Sub clear_shiharai_denpyou_touroku()
        dtp_shiharai_bi.Value = Now.ToString("yyyy/MM/dd")
        dtp_shiharai_kijitsu.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.SelectedIndex = -1
        txt_kingaku.Text = ""
        txt_bikou.Text = ""
        lbl_goukei_kingaku.Text = ""
    End Sub

    Private Sub set_shuukei()

        clear_shiharai_denpyou_touroku()

        With dgv_kensakukekka_shiire

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 8

            .Columns(0).Name = ""
            .Columns(1).Name = "NO"
            .Columns(2).Name = "仕入ID"
            .Columns(3).Name = "仕入日"
            .Columns(4).Name = "仕入" + vbCrLf + "金額"
            .Columns(5).Name = "伝票" + vbCrLf + "番号"
            .Columns(6).Name = "支払ID"
            .Columns(7).Name = "支払日"

            .Columns(0).Width = 30
            .Columns(1).Width = 40
            .Columns(2).Width = 90
            .Columns(3).Width = 110
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 90
            .Columns(7).Width = 110

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(4).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        With dgv_kensakukekka_shiharai

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 7

            .Columns(0).Name = "NO"
            .Columns(1).Name = "支払ID"
            .Columns(2).Name = "支払日"
            .Columns(3).Name = "支払" + vbCrLf + "金額"
            .Columns(4).Name = "支払" + vbCrLf + "方法"
            .Columns(5).Name = "支払期日"
            .Columns(6).Name = "備考"

            .Columns(0).Width = 50
            .Columns(1).Width = 90
            .Columns(2).Width = 110
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 110
            .Columns(6).Width = 130

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(3).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim gyousha_id = Mid(Trim(cbx_gyousha.Text), 1, 6)
        If gyousha_id = "" Then
            Exit Sub
        End If

        Try

            Dim query = "SELECT shiire.*, gyousha.gyoushamei FROM shiire LEFT JOIN gyousha ON shiire.gyoushaid = gyousha.gyoushaid" +
                " WHERE shiire.gyoushaid = '" + gyousha_id + "' AND shiire.joukyou = '0'" +
                " ORDER BY shiire.shiirebi, gyousha.gyoushafurigana"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shiire"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(7)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = ""
                mojiretsu(1) = (i + 1).ToString
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shiireid"))
                mojiretsu(3) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiirebi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                Dim goukeikingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeikingaku")) Then
                    goukeikingaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeikingaku")))
                End If
                mojiretsu(4) = goukeikingaku

                Dim denban = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("denban")) Then
                    denban = Trim(dt_server.Rows.Item(i).Item("denban"))
                End If
                mojiretsu(5) = denban

                Dim shukkinid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkinid")) Then
                    shukkinid = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                End If
                mojiretsu(6) = shukkinid

                Dim shiharaibi = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shiharaibi")) Then
                    shiharaibi = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiharaibi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(7) = shiharaibi

                Dim dgv = dgv_kensakukekka_shiire
                dgv.Rows.Add(mojiretsu)

                dgv.Rows(i).Cells(0) = New DataGridViewCheckBoxCell
                dgv.Rows(i).Cells(0).Value = False

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Try

            Dim query = "SELECT shukkin.*, gyousha.gyoushamei FROM shukkin LEFT JOIN gyousha ON shukkin.gyoushaid = gyousha.gyoushaid" +
                " WHERE shukkin.gyoushaid = '" + gyousha_id + "'" +
                " ORDER BY shukkin.shukkinbi DESC, gyousha.gyoushafurigana"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shukkin"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(6)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shukkinbi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                Dim shukkingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkingaku")) Then
                    shukkingaku = CInt(Trim(dt_server.Rows.Item(i).Item("shukkingaku")))
                End If
                mojiretsu(3) = shukkingaku

                mojiretsu(4) = PaymentMethodsInvoice.GetNameById(Trim(dt_server.Rows.Item(i).Item("shukkinhouhou")))

                Dim kijitsu = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kijitsu")) Then
                    kijitsu = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("kijitsu")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(5) = kijitsu


                Dim bikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    bikou = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If
                mojiretsu(6) = bikou

                dgv_kensakukekka_shiharai.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class