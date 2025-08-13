Imports System.Data.SqlClient

Public Class frmnyuukin_shori

    Private Sub frmnyuukin_shori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_tenpo_cbx(5, chk_hihyouji_torihiki_nai.Checked)
        dtp_hinichi.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.Items.AddRange(PaymentMethodsDeposit.Names)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_tenpo_Click(sender As Object, e As EventArgs) Handles btn_clear_tenpo.Click
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "5"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

        Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)
        If tenpo_id = "" Then
            msg_go("店舗を選択してください。")
            Exit Sub
        End If

        Dim nyuukin_kingaku = Trim(txt_kingaku.Text)
        If nyuukin_kingaku = "" Then
            msg_go("金額を入力してください。")
            Exit Sub
        End If
        Dim int_nyuukin_kingaku = CInt(nyuukin_kingaku)

        Dim houhou = Trim(cbx_shiharai_houhou.Text)
        If houhou = "" Then
            msg_go("方法を選択してください。")
            Exit Sub
        End If
        Dim houhou_id = PaymentMethodsDeposit.GetIdByName(houhou)

        Dim ryoushuusho_no = Trim(txt_ryoushuusho_no.Text)
        If ryoushuusho_no = "" Then
            msg_go("領収書NOを入力してください。")
            Exit Sub
        End If

        Dim nyuukinbi = dtp_hinichi.Value.ToString("yyyyMMdd")
        Dim bikou = Trim(txt_bikou.Text)
        Dim dami = Trim(lbl_dami.Text)
        Dim sabun_kingaku As Integer

        If Trim(btn_touroku.Text) = "登録" Then

            Dim nebiki = Trim(lbl_nebiki.Text)

            Dim id = 1
            Dim s_no = 12
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

                Dim query = "SELECT * FROM seikyuusho"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                Dim temp_table_name = "t_seikyuusho"
                da.Fill(ds, temp_table_name)
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

                data_row("seikyuushoid") = new_id
                data_row("tenpoid") = tenpo_id
                data_row("hiduke") = nyuukinbi
                data_row("shoukei") = 0
                data_row("shouhizei") = 0
                data_row("seikyuukingaku") = int_nyuukin_kingaku
                data_row("seikyuu_st") = "1"
                data_row("seikyuutanni") = houhou_id
                data_row("ryoushuuno") = ryoushuusho_no

                If nebiki <> "" Then
                    data_row("seikyuunebiki") = nebiki
                End If

                If bikou <> "" Then
                    data_row("seikyuubikou") = bikou
                End If

                If dami <> "" Then
                    data_row("dami") = "1"
                End If

                ds.Tables(temp_table_name).Rows.Add(data_row)
                da.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            sabun_kingaku = int_nyuukin_kingaku

        Else '変更

            Dim seikyuusho_id = Trim(lbl_seikyuu_id.Text)
            If seikyuusho_id = "" Then
                msg_go("伝票NOを取得できませんでした。")
                Exit Sub
            End If

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid ='" + seikyuusho_id + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                Dim temp_table_name = "t_seikyuusho"
                da.Fill(ds, temp_table_name)

                Dim table = ds.Tables(temp_table_name)

                table.Rows(0)("hiduke") = nyuukinbi
                table.Rows(0)("seikyuukingaku") = int_nyuukin_kingaku
                table.Rows(0)("seikyuutanni") = houhou_id
                table.Rows(0)("ryoushuuno") = ryoushuusho_no
                table.Rows(0)("kakunin") = DBNull.Value

                If bikou = "" Then
                    table.Rows(0)("seikyuubikou") = DBNull.Value
                Else
                    table.Rows(0)("seikyuubikou") = bikou
                End If

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            sabun_kingaku = int_nyuukin_kingaku - CInt(Trim(lbl_moto_nyuukin_kingaku.Text))

        End If

        If Not update_tenpo_kurikoshi(tenpo_id, -sabun_kingaku) Then
            msg_go("店舗の繰越金額の更新に失敗しました。")
            Exit Sub
        End If

        If Trim(btn_touroku.Text) = "登録" Then
            msg_go("登録しました。", 64)
        Else
            msg_go("変更しました。", 64)
        End If

        set_shuukei()

    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

        clear_nyuukin_denpyou_touroku()

        Dim dgv = dgv_kensakukekka_nyuukin
        If dgv.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        Dim hakkou = dgv.CurrentRow.Cells(6).Value
        If hakkou <> "" Then
            msg_go("すでに請求書発行処理をしているため、変更できません。")
            Exit Sub
        End If

        Dim nyuukinbi = dgv.CurrentRow.Cells(0).Value
        Dim seikyuusho_id = dgv.CurrentRow.Cells(1).Value
        Dim nyuukin_kingaku = CInt(dgv.CurrentRow.Cells(2).Value).ToString("")
        Dim houhou = dgv.CurrentRow.Cells(3).Value
        Dim bikou = dgv.CurrentRow.Cells(4).Value
        Dim ryoushuusho_no = dgv.CurrentRow.Cells(5).Value
        Dim nebiki = dgv.CurrentRow.Cells(7).Value
        Dim dami = dgv.CurrentRow.Cells(8).Value

        lbl_seikyuu_id.Text = seikyuusho_id
        dtp_hinichi.Value = nyuukinbi
        cbx_shiharai_houhou.SelectedIndex = cbx_shiharai_houhou.FindStringExact(houhou)
        txt_kingaku.Text = nyuukin_kingaku
        txt_ryoushuusho_no.Text = ryoushuusho_no
        txt_bikou.Text = bikou
        lbl_nebiki.Text = nebiki
        lbl_dami.Text = dami
        lbl_moto_nyuukin_kingaku.Text = nyuukin_kingaku

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        Dim dgv = dgv_kensakukekka_nyuukin
        If dgv.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        If chk_sakujo.Checked = False Then
            msg_go("「削除する」にチェックをつけてから実行してください。")
            Exit Sub
        End If
        chk_sakujo.Checked = False

        Dim hakkou = dgv.CurrentRow.Cells(6).Value
        If hakkou <> "" Then
            msg_go("すでに請求書発行処理をしているため、削除できません。")
            Exit Sub
        End If

        Dim tenpo = Trim(cbx_tenpo.Text)
        Dim tenpo_mei = Mid(tenpo, 8)
        Dim seikyuusho_id = dgv.CurrentRow.Cells(1).Value
        Dim nyuukin_kingaku = CInt(dgv.CurrentRow.Cells(2).Value).ToString("#,0")
        Dim houhou = dgv.CurrentRow.Cells(3).Value
        Dim bikou = dgv.CurrentRow.Cells(4).Value

        Dim msg = "以下の入金履歴を削除しますか？" + vbCrLf + vbCrLf + "店舗名：" + tenpo_mei + vbCrLf + "伝票NO：" + seikyuusho_id + vbCrLf + "入金金額：" + nyuukin_kingaku + "円" + vbCrLf + "方法：" + houhou
        If bikou <> "" Then
            msg += vbCrLf + "備考：" + bikou
        End If
        Dim result As DialogResult = MessageBox.Show(msg, "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' 請求書
        Dim seikyuugaku = Nothing
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count > 0 Then
                seikyuugaku = ds.Tables(temp_table_name).Rows(0)("seikyuukingaku")
                ds.Tables(temp_table_name).Rows(0).Delete()
                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, temp_table_name)
            Else
                msg_go("入金記録の削除に失敗しました。")
                ds.Clear()
                Exit Sub
            End If

            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        '店舗
        Dim tenpo_id = Mid(tenpo, 1, 6)
        If Not update_tenpo_kurikoshi(tenpo_id, seikyuugaku) Then
            msg_go("店舗の繰越金額の更新に失敗しました。")
            Exit Sub
        End If

        msg_go("選択した入金履歴を正常に削除しました。", 64)
        set_shuukei()

    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_cbx(5, chk_hihyouji_torihiki_nai.Checked)
        set_shuukei()
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        set_shuukei()
    End Sub

    Private Sub lbl_seikyuu_id_TextChanged(sender As Object, e As EventArgs) Handles lbl_seikyuu_id.TextChanged
        If lbl_seikyuu_id.Text = "" Then
            btn_touroku.Text = "登録"
            grp_nyuukin_denpyou.BackColor = Color.White
        Else
            btn_touroku.Text = "変更"
            grp_nyuukin_denpyou.BackColor = Color.LightCyan
        End If
    End Sub

    Private Sub set_shuukei()

        clear_nyuukin_denpyou_touroku()

        With dgv_kensakukekka_nyuukin

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 9

            .Columns(0).Name = "入金日"
            .Columns(1).Name = "伝票NO"
            .Columns(2).Name = "入金金額"
            .Columns(3).Name = "方法"
            .Columns(4).Name = "備考"
            .Columns(5).Name = "領収NO"
            .Columns(6).Name = "発行済"
            .Columns(7).Name = "値引き"
            .Columns(8).Name = "ダミー"

            .Columns(0).Width = 110
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 100
            .Columns(4).Width = 350
            .Columns(5).Width = 90
            .Columns(6).Width = 0
            .Columns(7).Width = 90
            .Columns(8).Width = 90

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).DefaultCellStyle.Format = "#,##0"
            .Columns(7).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        With dgv_kensakukekka_seikyuu

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 4

            .Columns(0).Name = "請求日"
            .Columns(1).Name = "伝票NO"
            .Columns(2).Name = "請求金額"
            .Columns(3).Name = "税額"

            .Columns(0).Width = 110
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 90

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(2).DefaultCellStyle.Format = "#,##0"
            .Columns(3).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)
        If tenpo_id = "" Then
            Exit Sub
        End If

        Try

            Dim query = "SELECT * FROM seikyuusho WHERE tenpoid = '" + tenpo_id + "' AND seikyuu_st = '1' ORDER BY hiduke DESC"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(8)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))

                Dim seikyuukingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuukingaku")) Then
                    seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                End If
                mojiretsu(2) = seikyuukingaku

                mojiretsu(3) = PaymentMethodsDeposit.GetNameById(Trim(dt_server.Rows.Item(i).Item("seikyuutanni")))

                Dim seikyuubikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuubikou")) Then
                    seikyuubikou = Trim(dt_server.Rows.Item(i).Item("seikyuubikou"))
                End If
                mojiretsu(4) = seikyuubikou

                Dim ryoushuuno = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("ryoushuuno")) Then
                    ryoushuuno = Trim(dt_server.Rows.Item(i).Item("ryoushuuno"))
                End If
                mojiretsu(5) = ryoushuuno

                Dim hakkou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("joukyou")) Then
                    If Trim(dt_server.Rows.Item(i).Item("joukyou")) = "1" Then
                        hakkou = "○"
                    End If
                End If
                mojiretsu(6) = hakkou

                Dim seikyuunebiki = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuunebiki")) Then
                    seikyuunebiki = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuunebiki")))
                End If
                mojiretsu(7) = seikyuunebiki

                Dim dami = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("dami")) Then
                    dami = Trim(dt_server.Rows.Item(i).Item("dami"))
                End If
                mojiretsu(8) = dami

                dgv_kensakukekka_nyuukin.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Try

            Dim query = "SELECT * FROM seikyuusho WHERE tenpoid = '" + tenpo_id + "' AND seikyuu_st = '0' ORDER BY hiduke DESC"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho_2"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(3)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))

                Dim seikyuukingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuukingaku")) Then
                    seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                End If
                mojiretsu(2) = seikyuukingaku

                Dim shouhizei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhizei")) Then
                    shouhizei = CInt(Trim(dt_server.Rows.Item(i).Item("shouhizei")))
                End If
                mojiretsu(3) = shouhizei

                dgv_kensakukekka_seikyuu.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kurikoshi_kingaku.Text = "0"
        Try

            Dim query = "SELECT * FROM tenpo WHERE tenpoid = '" + tenpo_id + "'"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_tenpo"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count > 0 Then
                Dim kurikoshi = dt_server.Rows.Item(0).Item("kurikoshi")
                If Not IsDBNull(kurikoshi) Then
                    lbl_kurikoshi_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("kurikoshi")).ToString("#,0")
                End If
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Function update_tenpo_kurikoshi(tenpo_id As String, sabun_kingaku As Integer) As Boolean

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM tenpo WHERE tenpoid = '" + tenpo_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_tenpo"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count = 0 Then
                msg_go("該当する店舗が見つかりません")
                ds.Clear()
                Return False
            End If

            Dim table = ds.Tables(temp_table_name)

            Dim kurikoshi = table.Rows(0)("kurikoshi") + sabun_kingaku
            table.Rows(0)("kurikoshi") = kurikoshi

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

            Return True

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

    End Function

    Sub clear_nyuukin_denpyou_touroku()

        lbl_seikyuu_id.Text = ""
        dtp_hinichi.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.SelectedIndex = -1
        txt_kingaku.Text = ""
        txt_ryoushuusho_no.Text = ""
        txt_bikou.Text = ""
        lbl_nebiki.Text = ""
        lbl_dami.Text = ""
        lbl_moto_nyuukin_kingaku.Text = ""
        chk_houkoku.Checked = False

    End Sub

End Class