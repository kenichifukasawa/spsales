Imports System.Data.SqlClient

Public Class frmichiran_gyousha
    Private Sub frmichiran_gyousha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_gyousha_ichiran()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click
        set_combo_box()
        frmichiran_gyousha_koushin.ShowDialog()
    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click
        set_combo_box()
        With frmichiran_gyousha_koushin

            .Text = "変更"
            .btn_koushin.Text = "変更"

            Dim current_row = dgv_kensakukekka.CurrentRow
            .lbl_gyousha_id.Text = current_row.Cells(0).Value
            .txt_gyousha_mei.Text = current_row.Cells(1).Value
            .txt_furigana.Text = current_row.Cells(2).Value
            .txt_yuubin_bangou.Text = current_row.Cells(3).Value
            .lbl_juusho_1.Text = current_row.Cells(22).Value
            .txt_juusho_2.Text = current_row.Cells(23).Value
            .txt_tel.Text = current_row.Cells(5).Value
            .txt_fax.Text = current_row.Cells(6).Value
            .txt_tantousha.Text = current_row.Cells(7).Value
            .txt_tel_keitai.Text = current_row.Cells(8).Value
            .txt_daihyousha.Text = current_row.Cells(9).Value
            .txt_shiharai_jouken.Text = current_row.Cells(14).Value
            .txt_tekikaku_bangou.Text = current_row.Cells(21).Value
            .txt_ginkou_mei.Text = current_row.Cells(24).Value
            .txt_shiten_mei.Text = current_row.Cells(25).Value
            .txt_kouza_bangou.Text = current_row.Cells(27).Value
            .txt_kouza_meigi.Text = current_row.Cells(28).Value
            .txt_bikou_1.Text = current_row.Cells(16).Value
            .txt_bikou_2.Text = current_row.Cells(17).Value
            .txt_bikou_3.Text = current_row.Cells(18).Value
            .txt_mail_user.Text = current_row.Cells(29).Value
            .txt_mail_domain.Text = current_row.Cells(30).Value

            Dim shiharai_houhou = dgv_kensakukekka.CurrentRow.Cells(11).Value
            Dim shimebi = dgv_kensakukekka.CurrentRow.Cells(10).Value
            Dim shouhizei = dgv_kensakukekka.CurrentRow.Cells(12).Value
            Dim hasuu = dgv_kensakukekka.CurrentRow.Cells(13).Value

            .cbx_shiharai_houhou.SelectedIndex = .cbx_shiharai_houhou.FindStringExact(shiharai_houhou)
            .cbx_shimebi.SelectedIndex = .cbx_shimebi.FindStringExact(shimebi)
            .cbx_shouhizei.SelectedIndex = .cbx_shouhizei.FindStringExact(shouhizei)
            .cbx_hasuu.SelectedIndex = .cbx_hasuu.FindStringExact(hasuu)

            Dim bank_account_type = dgv_kensakukekka.CurrentRow.Cells(26).Value
            Select Case bank_account_type
                Case .rbn_futsuu.Text
                    .rbn_futsuu.Checked = True
                Case .rbn_touza.Text
                    .rbn_touza.Checked = True
            End Select

            Dim fuyou = dgv_kensakukekka.CurrentRow.Cells(20).Value
            If fuyou <> "" Then
                .chk_fuyou.Checked = True
            End If

            .ShowDialog()

        End With

        set_gyousha_ichiran()

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

        Dim gyousha_id = Trim(dgv_kensakukekka.CurrentRow.Cells(0).Value)
        Dim gyousha_mei = Trim(dgv_kensakukekka.CurrentRow.Cells(1).Value)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shiire WHERE gyoushaid = '" + gyousha_id + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            Dim can_delete = True

            If dt_server.Rows.Count > 0 Then
                can_delete = False
            End If

            dt_server.Clear()
            ds_server.Clear()

            If Not can_delete Then
                msg_go("この業者は仕入情報がすでに使用されているため、削除できません。")
                Exit Sub
            End If

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

        Dim result As DialogResult = MessageBox.Show(
            "以下の業者を削除しますか？" + vbCrLf + vbCrLf + "業者ID：" + gyousha_id + vbCrLf + "業者名：" + gyousha_mei,
            "SpSales",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM gyousha WHERE gyoushaid ='" + gyousha_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_gyousha")

            If ds.Tables("t_gyousha").Rows.Count > 0 Then
                ds.Tables("t_gyousha").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_gyousha")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する業者が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        set_gyousha_ichiran()

    End Sub

    Private Sub set_gyousha_ichiran()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM gyousha" +
                " LEFT JOIN mailno_m" +
                " ON gyousha.mailno = mailno_m.mailno"

            Dim query_where = ""
            If chk_fuyou_hyouji.Checked = False Then
                query_where = " WHERE gyousha.fuyou IS NULL"
            End If

            query += query_where + " ORDER BY gyousha.gyoushafurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_gyousha_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_gyousha_ichiran")

            With dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 31

                .Columns(0).Name = "業者ID"
                .Columns(1).Name = "業者名"
                .Columns(2).Name = "ふりがな"
                .Columns(3).Name = "郵便番号"
                .Columns(4).Name = "住所"
                .Columns(5).Name = "電話番号"
                .Columns(6).Name = "FAX番号"
                .Columns(7).Name = "担当者"
                .Columns(8).Name = "携帯番号"
                .Columns(9).Name = "代表者"
                .Columns(10).Name = "〆日"
                .Columns(11).Name = "支払い" + vbCrLf + "方法"
                .Columns(12).Name = "消費税"
                .Columns(13).Name = "端数"
                .Columns(14).Name = "支払い条件"
                .Columns(15).Name = "銀行口座"
                .Columns(16).Name = "備考１"
                .Columns(17).Name = "備考２"
                .Columns(18).Name = "備考３"
                .Columns(19).Name = "メールアドレス"
                .Columns(20).Name = "不要"
                .Columns(21).Name = "適格番号"
                .Columns(22).Name = "住所１"
                .Columns(23).Name = "住所２"
                .Columns(24).Name = "銀行名"
                .Columns(25).Name = "支店名"
                .Columns(26).Name = "口座種類"
                .Columns(27).Name = "口座番号"
                .Columns(28).Name = "口座名義"
                .Columns(29).Name = "メールユーザー"
                .Columns(30).Name = "メールドメイン"

                .Columns(0).Width = 75
                .Columns(1).Width = 250
                .Columns(2).Width = 220
                .Columns(3).Width = 90
                .Columns(4).Width = 250
                .Columns(5).Width = 110
                .Columns(6).Width = 110
                .Columns(7).Width = 100
                .Columns(8).Width = 110
                .Columns(9).Width = 100
                .Columns(10).Width = 75
                .Columns(11).Width = 80
                .Columns(12).Width = 100
                .Columns(13).Width = 100
                .Columns(14).Width = 100
                .Columns(15).Width = 100
                .Columns(16).Width = 250
                .Columns(17).Width = 250
                .Columns(18).Width = 250
                .Columns(19).Width = 250
                .Columns(20).Width = 75
                .Columns(21).Width = 130
                .Columns(22).Width = 0
                .Columns(23).Width = 0
                .Columns(24).Width = 0
                .Columns(25).Width = 0
                .Columns(26).Width = 0
                .Columns(27).Width = 0
                .Columns(28).Width = 0
                .Columns(29).Width = 0
                .Columns(30).Width = 0

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(1).Frozen = True

            End With

            Dim mojiretsu(30) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("gyoushaid"))

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("gyoushamei"))

                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("gyoushafurigana"))

                If IsDBNull(dt_server.Rows.Item(i).Item("mailno")) Then
                    mojiretsu(3) = ""
                Else
                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("mailno"))
                End If

                Dim juusho_1 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("adress1")) Then
                    juusho_1 = Trim(dt_server.Rows.Item(i).Item("adress1"))
                End If
                Dim juusho_2 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("gyoushaadress")) Then
                    juusho_2 = Trim(dt_server.Rows.Item(i).Item("gyoushaadress"))
                End If
                mojiretsu(4) = juusho_1 + juusho_2

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushatel")) Then
                    mojiretsu(5) = ""
                Else
                    mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("gyoushatel"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushafax")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("gyoushafax"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushatantou")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("gyoushatantou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushakeitai")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(dt_server.Rows.Item(i).Item("gyoushakeitai"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushadaihyou")) Then
                    mojiretsu(9) = ""
                Else
                    mojiretsu(9) = Trim(dt_server.Rows.Item(i).Item("gyoushadaihyou"))
                End If

                Dim shimebi As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("gyoushashimebi")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("gyoushashimebi").ToString())
                    shimebi = Deadline.GetNameById(id)
                End If
                mojiretsu(10) = shimebi

                Dim shiharai_houhou As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shiharaihouhou")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("shiharaihouhou").ToString())
                    shiharai_houhou = PaymentMethods.GetNameById(id)
                End If
                mojiretsu(11) = shiharai_houhou

                Dim shouhizei As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhizei")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("shouhizei").ToString())
                    shouhizei = ConsumptionTax.GetNameById(id)
                End If
                mojiretsu(12) = shouhizei

                Dim hasuu As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("hasuu")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("hasuu").ToString())
                    hasuu = Rounding.GetNameById(id)
                End If
                mojiretsu(13) = hasuu

                If IsDBNull(dt_server.Rows.Item(i).Item("shiharaijouken")) Then
                    mojiretsu(14) = ""
                Else
                    mojiretsu(14) = Trim(dt_server.Rows.Item(i).Item("shiharaijouken"))
                End If

                Dim ginkou_kouza = ""
                Dim bank_mei = ""
                Dim bank_shiten_mei = ""
                Dim bank_shurui = ""
                Dim bank_no = ""
                Dim bank_kouza_mei = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bankmei")) Then
                    bank_mei = Trim(dt_server.Rows.Item(i).Item("bankmei"))
                    ginkou_kouza = bank_mei

                    If Not IsDBNull(dt_server.Rows.Item(i).Item("bankshitenmei")) Then
                        bank_shiten_mei = Trim(dt_server.Rows.Item(i).Item("bankshitenmei"))
                        ginkou_kouza += " " + bank_shiten_mei

                        If Not IsDBNull(dt_server.Rows.Item(i).Item("bankshurui")) Then
                            Dim id As String = Trim(dt_server.Rows.Item(i).Item("bankshurui").ToString())
                            bank_shurui = BankAccountType.GetNameById(id)
                        End If
                        ginkou_kouza += " " + bank_shurui

                        If Not IsDBNull(dt_server.Rows.Item(i).Item("bankno")) Then
                            bank_no = Trim(dt_server.Rows.Item(i).Item("bankno"))
                            ginkou_kouza += " " + bank_no

                            If Not IsDBNull(dt_server.Rows.Item(i).Item("bankkouzamei")) Then
                                bank_kouza_mei = Trim(dt_server.Rows.Item(i).Item("bankkouzamei"))
                                ginkou_kouza += " " + bank_kouza_mei
                            End If
                        End If
                    End If
                End If
                mojiretsu(15) = ginkou_kouza

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou")) Then
                    mojiretsu(16) = ""
                Else
                    mojiretsu(16) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou2")) Then
                    mojiretsu(17) = ""
                Else
                    mojiretsu(17) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou2"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou3")) Then
                    mojiretsu(18) = ""
                Else
                    mojiretsu(18) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou3"))
                End If

                Dim user_mei = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("usermei")) Then
                    user_mei = Trim(dt_server.Rows.Item(i).Item("usermei"))
                End If

                Dim domain_name = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("domainname")) Then
                    domain_name = " " + Trim(dt_server.Rows.Item(i).Item("domainname"))
                End If
                mojiretsu(19) = Trim(user_mei + domain_name)

                If IsDBNull(dt_server.Rows.Item(i).Item("fuyou")) Then
                    mojiretsu(20) = ""
                Else
                    mojiretsu(20) = "不要"
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("tekikakubangou")) Then
                    mojiretsu(21) = ""
                Else
                    mojiretsu(21) = Trim(dt_server.Rows.Item(i).Item("tekikakubangou"))
                End If

                mojiretsu(22) = juusho_1
                mojiretsu(23) = juusho_2
                mojiretsu(24) = bank_mei
                mojiretsu(25) = bank_shiten_mei
                mojiretsu(26) = bank_shurui
                mojiretsu(27) = bank_no
                mojiretsu(28) = bank_kouza_mei
                mojiretsu(29) = user_mei
                mojiretsu(30) = domain_name

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Private Sub chk_fuhitsuyou_hyouji_Click(sender As Object, e As EventArgs) Handles chk_fuyou_hyouji.Click
        set_gyousha_ichiran()
    End Sub

    Private Sub set_combo_box()

        With frmichiran_gyousha_koushin
            .cbx_shiharai_houhou.Items.AddRange(PaymentMethods.Names)
            .cbx_shimebi.Items.AddRange(Deadline.Names)
            .cbx_shouhizei.Items.AddRange(ConsumptionTax.Names)
            .cbx_hasuu.Items.AddRange(Rounding.Names)
        End With

    End Sub
End Class