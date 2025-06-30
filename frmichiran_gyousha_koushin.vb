Imports System.Data.SqlClient

Public Class frmichiran_gyousha_koushin

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_koushin_Click(sender As Object, e As EventArgs) Handles btn_koushin.Click

        Dim gyousha_mei = Trim(txt_gyousha_mei.Text)
        If gyousha_mei = "" Then
            msg_go("業者名を入力してください。")
            Exit Sub
        End If

        Dim furigana = Trim(txt_furigana.Text)
        If furigana = "" Then
            msg_go("業者名のふりがなを入力してください。")
            Exit Sub
        End If

        Dim yuubin_bangou = Trim(txt_yuubin_bangou.Text)

        Dim juusho_1 = Trim(lbl_juusho_1.Text)
        If yuubin_bangou <> "" And juusho_1 = "" Then
            msg_go("住所１を表示してください。")
            Exit Sub
        End If

        Dim juusho_2 = Trim(txt_juusho_2.Text)
        Dim tel = Trim(txt_tel.Text)
        Dim fax = Trim(txt_fax.Text)
        Dim tantousha = Trim(txt_tantousha.Text)
        Dim tel_keitai = Trim(txt_tel_keitai.Text)
        Dim daihyousha = Trim(txt_daihyousha.Text)
        Dim shiharai_jouken = Trim(txt_shiharai_jouken.Text)

        Dim shiharai_houhou = Trim(cbx_shiharai_houhou.Text)
        If shiharai_houhou <> "" Then
            shiharai_houhou = PaymentMethods.GetIdByName(shiharai_houhou)
        End If

        Dim shimebi = Trim(cbx_shimebi.Text)
        If shimebi <> "" Then
            shimebi = Deadline.GetIdByName(shimebi)
        End If

        Dim shouhizei = Trim(cbx_shouhizei.Text)
        If shouhizei <> "" Then
            shouhizei = ConsumptionTax.GetIdByName(shouhizei)
        End If

        Dim hasuu = Trim(cbx_hasuu.Text)
        If hasuu <> "" Then
            hasuu = Rounding.GetIdByName(hasuu)
        End If

        Dim tekikaku_bangou = Trim(txt_tekikaku_bangou.Text)
        Dim ginkou_mei = Trim(txt_ginkou_mei.Text)
        Dim shiten_mei = Trim(txt_shiten_mei.Text)

        Dim ginkou_type = ""
        If rbn_futsuu.Checked Then
            ginkou_type = ID_FUTSUU
        ElseIf rbn_touza.Checked Then
            ginkou_type = ID_TOUZA
        End If

        Dim kouza_bangou = Trim(txt_kouza_bangou.Text)
        Dim kouza_meigi = Trim(txt_kouza_meigi.Text)
        Dim bikou_1 = Trim(txt_bikou_1.Text)
        Dim bikou_2 = Trim(txt_bikou_2.Text)
        Dim bikou_3 = Trim(txt_bikou_3.Text)
        Dim mail_user = Trim(txt_mail_user.Text)
        Dim mail_domain = Trim(txt_mail_domain.Text)

        If mail_user = "" And mail_domain <> "" Then
            msg_go("メールアドレスのユーザー（前半部分）を入力してください。")
            Exit Sub
        End If

        If mail_user <> "" And mail_domain = "" Then
            msg_go("メールアドレスのドメイン（後半部分）を入力してください。")
            Exit Sub
        End If

        Dim fuyou = ""
        If chk_fuyou.Checked Then
            fuyou = "1"
        End If

        If Trim(btn_koushin.Text).IndexOf("登録") <> -1 Then

            Dim id = 1
            Dim s_no = 6
            Dim new_id = get_settings(id:=id, s_no:=s_no)
            Dim next_id As String
            If new_id = "" Then
                msg_go("IDの取得に失敗しました。")
                Exit Sub
            ElseIf new_id = "0" Then
                next_id = "2"
                new_id = "001"
            Else
                next_id = (CLng(new_id) + 1).ToString
                new_id = new_id.ToString.PadLeft(3, "0"c)
            End If

            Dim response = update_settings(id:=id, s_no:=s_no, new_value:=next_id)
            If Not response Then
                msg_go("IDの更新に失敗しました。")
                Exit Sub
            End If

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM gyousha"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                da.Fill(ds, "t_gyousha")
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables("t_gyousha").NewRow()

                data_row("gyoushaid") = new_id
                data_row("gyoushamei") = gyousha_mei
                data_row("gyoushafurigana") = furigana

                If yuubin_bangou <> "" Then
                    data_row("mailno") = yuubin_bangou
                End If

                If juusho_2 <> "" Then
                    data_row("gyoushaadress") = juusho_2
                End If

                If tel <> "" Then
                    data_row("gyoushatel") = tel
                End If

                If fax <> "" Then
                    data_row("gyoushafax") = fax
                End If

                If tantousha <> "" Then
                    data_row("gyoushatantou") = tantousha
                End If

                If tel_keitai <> "" Then
                    data_row("gyoushakeitai") = tel_keitai
                End If

                If daihyousha <> "" Then
                    data_row("gyoushadaihyou") = daihyousha
                End If

                If bikou_1 <> "" Then
                    data_row("gyoushabikou") = bikou_1
                End If

                If bikou_2 <> "" Then
                    data_row("gyoushabikou2") = bikou_2
                End If

                If bikou_3 <> "" Then
                    data_row("gyoushabikou3") = bikou_3
                End If

                If shimebi <> "" Then
                    data_row("gyoushashimebi") = shimebi
                End If

                If shouhizei <> "" Then
                    data_row("shouhizei") = shouhizei
                End If

                If hasuu <> "" Then
                    data_row("hasuu") = hasuu
                End If

                If shiharai_houhou <> "" Then
                    data_row("shiharaihouhou") = shiharai_houhou
                End If

                If shiharai_jouken <> "" Then
                    data_row("shiharaijouken") = shiharai_jouken
                End If

                If ginkou_mei <> "" Then
                    data_row("bankmei") = ginkou_mei
                End If

                If ginkou_type <> "" Then
                    data_row("bankshurui") = ginkou_type
                End If

                If shiten_mei <> "" Then
                    data_row("bankshitenmei") = shiten_mei
                End If

                If kouza_bangou <> "" Then
                    data_row("bankno") = kouza_bangou
                End If

                If kouza_meigi <> "" Then
                    data_row("bankkouzamei") = kouza_meigi
                End If

                If mail_user <> "" Then
                    data_row("usermei") = mail_user
                End If

                If mail_domain <> "" Then
                    data_row("domainname") = mail_domain
                End If

                If fuyou <> "" Then
                    data_row("fuyou") = fuyou
                End If

                If tekikaku_bangou <> "" Then
                    data_row("tekikakubangou") = tekikaku_bangou
                End If

                ds.Tables("t_gyousha").Rows.Add(data_row)
                da.Update(ds, "t_gyousha")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("業者を登録しました。", 64)

        Else '変更

            Dim gyousha_id = Trim(lbl_gyousha_id.Text)
            If gyousha_id = "" Then
                msg_go("業者IDを取得できませんでした。")
                Exit Sub
            End If

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM gyousha WHERE gyoushaid ='" + gyousha_id + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                da.Fill(ds, "t_gyousha")

                ds.Tables("t_gyousha").Rows(0)("gyoushamei") = gyousha_mei
                ds.Tables("t_gyousha").Rows(0)("gyoushafurigana") = furigana

                If yuubin_bangou = "" Then
                    ds.Tables("t_gyousha").Rows(0)("mailno") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("mailno") = yuubin_bangou
                End If

                If juusho_2 = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushaadress") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushaadress") = juusho_2
                End If

                If tel = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushatel") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushatel") = tel
                End If

                If fax = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushafax") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushafax") = fax
                End If

                If tantousha = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushatantou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushatantou") = tantousha
                End If

                If tel_keitai = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushakeitai") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushakeitai") = tel_keitai
                End If

                If daihyousha = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushadaihyou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushadaihyou") = daihyousha
                End If

                If bikou_1 = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou") = bikou_1
                End If

                If bikou_2 = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou2") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou2") = bikou_2
                End If

                If bikou_3 = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou3") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushabikou3") = bikou_3
                End If

                If shimebi = "" Then
                    ds.Tables("t_gyousha").Rows(0)("gyoushashimebi") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("gyoushashimebi") = shimebi
                End If

                If shouhizei = "" Then
                    ds.Tables("t_gyousha").Rows(0)("shouhizei") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("shouhizei") = shouhizei
                End If

                If hasuu = "" Then
                    ds.Tables("t_gyousha").Rows(0)("hasuu") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("hasuu") = hasuu
                End If

                If shiharai_houhou = "" Then
                    ds.Tables("t_gyousha").Rows(0)("shiharaihouhou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("shiharaihouhou") = shiharai_houhou
                End If

                If shiharai_jouken = "" Then
                    ds.Tables("t_gyousha").Rows(0)("shiharaijouken") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("shiharaijouken") = shiharai_jouken
                End If

                If ginkou_mei = "" Then
                    ds.Tables("t_gyousha").Rows(0)("bankmei") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("bankmei") = ginkou_mei
                End If

                If ginkou_type = "" Then
                    ds.Tables("t_gyousha").Rows(0)("bankshurui") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("bankshurui") = ginkou_type
                End If

                If shiten_mei = "" Then
                    ds.Tables("t_gyousha").Rows(0)("bankshitenmei") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("bankshitenmei") = shiten_mei
                End If

                If kouza_bangou = "" Then
                    ds.Tables("t_gyousha").Rows(0)("bankno") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("bankno") = kouza_bangou
                End If

                If kouza_meigi = "" Then
                    ds.Tables("t_gyousha").Rows(0)("bankkouzamei") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("bankkouzamei") = kouza_meigi
                End If

                If mail_user = "" Then
                    ds.Tables("t_gyousha").Rows(0)("usermei") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("usermei") = mail_user
                End If

                If mail_domain = "" Then
                    ds.Tables("t_gyousha").Rows(0)("domainname") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("domainname") = mail_domain
                End If

                If fuyou = "" Then
                    ds.Tables("t_gyousha").Rows(0)("fuyou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("fuyou") = fuyou
                End If

                If tekikaku_bangou = "" Then
                    ds.Tables("t_gyousha").Rows(0)("tekikakubangou") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("tekikakubangou") = tekikaku_bangou
                End If

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, "t_gyousha")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("業者情報を変更しました。", 64)

        End If

        ' TODO : 郵便番号登録
        If yuubin_bangou <> "" Then

            Dim is_tourokuzumi = False
            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM mailno_m WHERE mailno = '" + yuubin_bangou + "'"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_mailno_m")
                Dim dt_server As DataTable = ds_server.Tables("t_mailno_m")

                Dim can_delete = True

                If dt_server.Rows.Count > 0 Then
                    is_tourokuzumi = True
                End If

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
            End Try

            If Not is_tourokuzumi Then

                Try

                    Dim cn_server As New SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = "SELECT * FROM mailno_m"

                    Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds As New DataSet
                    da.Fill(ds, "t_mailno_m")
                    Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                    Dim data_row As DataRow = ds.Tables("t_mailno_m").NewRow()

                    data_row("mailno") = yuubin_bangou
                    data_row("adress1") = juusho_1
                    data_row("shousai") = "TODO"

                    ds.Tables("t_mailno_m").Rows.Add(data_row)
                    da.Update(ds, "t_mailno_m")
                    ds.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    Exit Sub
                End Try

                msg_go("郵便番号も登録しました。", 64)

            End If

        End If

        Me.Close() : Me.Dispose()

    End Sub

    Private Sub txt_yuubin_bangou_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_yuubin_bangou.KeyDown

        lbl_juusho_1.Text = ""

        If e.KeyCode <> Keys.Enter Then
            Exit Sub
        End If

        Dim yuubin_bangou = Trim(txt_yuubin_bangou.Text)
        If yuubin_bangou = "" Then
            Exit Sub
        End If

        If Len(yuubin_bangou) <> 8 Or yuubin_bangou.IndexOf("-") = -1 Then
            msg_go("(例) 405-0018 のように、'-'(ハイフン)ありの8桁で入力して下さい。")
            Exit Sub
        End If

        'lbl_juusho_1.Text = GetAddress1ByZipCode(yuubin_bangou)
        lbl_juusho_1.Text = GetAddressFromZipCode(yuubin_bangou)

    End Sub
End Class