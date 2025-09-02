Imports System.Data.SqlClient



Public Class frmmain

    Private kubundodoo As Integer
    Private kuku2dou As Integer




    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs)

        frmseikyuusho_soushin_ichi.ShowDialog()

    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        frminfo.ShowDialog()
    End Sub



    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        frmshuukei_sentaku.ShowDialog()
    End Sub



    Private Sub btn_tenpo_kensaku_Click(sender As Object, e As EventArgs) Handles btn_tenpo_kensaku.Click

        frmkensaku.ShowDialog()

    End Sub

    Private Sub lbltenpoid_Click(sender As Object, e As EventArgs) Handles lbltenpoid.Click

        mainset("000087")
    End Sub

    Private Sub txtkubun_TextChanged(sender As Object, e As EventArgs) Handles txtkubun.TextChanged

    End Sub

    Private Sub txtkubun_GotFocus(sender As Object, e As EventArgs) Handles txtkubun.GotFocus
        'txtkubun.SelStart = 0
        'txtkubun.SelLength = Len(txtkubun.Text)

        If shouhinkubun_shien_grid_set(4) <> -1 Then
            lstshien.Left = 50
            lstshien.Visible = True
            kubundodoo = 0
        End If
    End Sub

    Private Sub txtkubun_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun.KeyDown
        If e.KeyCode = Keys.Enter Then

            'kubundodoo = 2
            kubundodoo = 1
            txtkubun1.Focus()

        End If
    End Sub

    Private Sub txtkubun_LostFocus(sender As Object, e As EventArgs) Handles txtkubun.LostFocus
        If Trim(txtkubun.Text) <> "" Then
            lstshien.Visible = False
            'kubundodoo = 2
            kubundodoo = 1
        End If
    End Sub



    Private Sub txtkubun1_TextChanged(sender As Object, e As EventArgs) Handles txtkubun1.TextChanged

    End Sub

    Private Sub txtkubun1_GotFocus(sender As Object, e As EventArgs) Handles txtkubun1.GotFocus
        'txtkubun1.SelStart = 0
        'txtkubun1.SelLength = Len(txtkubun1.Text)

        If shouhinkubun_shien_grid_set(0) <> -1 Then
            lstshien.Left = 100
            lstshien.Visible = True
            kubundodoo = 1
        End If
    End Sub

    Private Sub txtkubun1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtkubun1.Text) = "" Then
                lstshien.Focus()
            Else
                kubundodoo = 2
                txtkubun2.Focus()
            End If
        End If
    End Sub

    Private Sub txtkubun1_LostFocus(sender As Object, e As EventArgs) Handles txtkubun1.LostFocus
        If Trim(txtkubun1.Text) <> "" Then
            lstshien.Visible = False
            kubundodoo = 2
        End If
    End Sub

    Private Sub txtkubun2_TextChanged(sender As Object, e As EventArgs) Handles txtkubun2.TextChanged

    End Sub

    Private Sub txtkubun2_GotFocus(sender As Object, e As EventArgs) Handles txtkubun2.GotFocus
        'txtkubun2.SelStart = 0
        'txtkubun2.SelLength = Len(txtkubun2.Text)

        If shouhinkubun_shien_grid_set(1, Trim(txtkubun1.Text)) <> -1 Then
            lstshien.Left = 150
            lstshien.Visible = True
            txtkubun2.Focus()
        Else
            lstshien.Visible = False

        End If
        kuku2dou = 0
    End Sub

    Private Sub txtkubun2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtkubun2.Text) = "" Then
                kuku2dou = 1
                If lstshien.Visible = True Then
                    lstshien.Focus()
                End If
                'kuku2dou = 0
            Else
                txtfurigana.Text = ""
                txtfurigana2.Text = ""
                txtfurigana.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            txtkubun1.Focus()
        End If

    End Sub

    Private Sub txtkubun2_LostFocus(sender As Object, e As EventArgs) Handles txtkubun2.LostFocus
        If kuku2dou = 0 Then
            lstshien.Visible = False
        End If
    End Sub

    Private Sub btn_jouken_clear_Click(sender As Object, e As EventArgs) Handles btn_jouken_clear.Click

        fshin1_all_clear()

    End Sub

    Sub fshin1_all_clear()

        With Me
            .txtkubun.Text = ""
            .txtkubun1.Text = ""
            .txtkubun2.Text = ""
            .txtfurigana.Text = ""
            .txtfurigana2.Text = ""
        End With

        grid_shien_head_set()

    End Sub



    Private Sub txtfurigana_TextChanged(sender As Object, e As EventArgs) Handles txtfurigana.TextChanged

    End Sub

    Private Sub txtfurigana_GotFocus(sender As Object, e As EventArgs) Handles txtfurigana.GotFocus
        'txtfurigana.SelStart = 0
        'txtfurigana.SelLength = Len(txtfurigana.Text)
        If Trim(txtkubun1.Text) = "" Then
            lstshien.Visible = False
        Else
            If Trim(txtkubun2.Text) = "" Then
                lstshien.Visible = False
            End If
        End If
    End Sub

    Private Sub txtfurigana_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfurigana.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtfurigana.Text) = "" Then
                txtfurigana2.Focus()
            Else
                txtfurigana2.Text = ""
                btn_jouken_kensaku.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtfurigana2_TextChanged(sender As Object, e As EventArgs) Handles txtfurigana2.TextChanged

    End Sub

    Private Sub txtfurigana2_GotFocus(sender As Object, e As EventArgs) Handles txtfurigana2.GotFocus
        'txtfurigana2.SelStart = 0
        'txtfurigana2.SelLength = Len(txtfurigana2.Text)
        If Trim(txtkubun1.Text) = "" Then
            lstshien.Visible = False
        Else
            If Trim(txtkubun2.Text) = "" Then
                lstshien.Visible = False
            End If
        End If
    End Sub

    Private Sub txtfurigana2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfurigana2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_jouken_kensaku.PerformClick()
        End If
    End Sub

    Private Sub btn_jouken_kensaku_Click(sender As Object, e As EventArgs) Handles btn_jouken_kensaku.Click

        Dim newkubun1 As String, newkubun2 As String, newfuri1 As String, newfuri2 As String
        Dim strstr As String, iriri As Long

        Dim newkubun0 As String

        newkubun0 = Trim(txtkubun.Text)
        newkubun1 = Trim(txtkubun1.Text)
        newkubun2 = Trim(txtkubun2.Text)
        newfuri1 = Trim(txtfurigana.Text)
        newfuri2 = Trim(txtfurigana2.Text)

        Sql = "select shouhin.shouhinmei,shouhin.shouhinid,shouhin.kakaku,shouhin.genzaikosuu " &
            ",shouhinkubun2.shouhinkubunmei2,shouhinkubun.shouhinkubunmei" &
            " from (shouhin left join shouhinkubun2 " &
            " on shouhin.shouhinkubunid2=shouhinkubun2.shouhinkubunid2) left join shouhinkubun" &
            " on shouhin.shouhinkubunid=shouhinkubun.shouhinkubunid "

        strstr = ""

        If newkubun1 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinkubunid='" & newkubun1 & "'"
            End If
        End If
        If newkubun2 <> "" Then
            If strstr = "" Then
                strstr = " where shouhinkubun2.narabe='" & newkubun2 & "'"
            Else
                strstr = strstr & " and shouhinkubun2.narabe='" & newkubun2 & "'"
            End If
        End If
        If newkubun0 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinkubunid0='" & newkubun0 & "'"
            Else
                strstr = strstr & " and shouhin.shouhinkubunid0='" & newkubun0 & "'"
            End If
        End If

        If newfuri1 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinfurigana like '%" & newfuri1 & "%'"
            Else
                strstr = strstr & " and shouhin.shouhinfurigana like '%" & newfuri1 & "%'"
            End If
        Else
            If newfuri2 <> "" Then
                If strstr = "" Then
                    strstr = " where shouhin.shouhinfurigana like '%" & newfuri2 & "%'"
                Else
                    strstr = strstr & " and shouhin.shouhinfurigana like '%" & newfuri2 & "%'"
                End If
            End If
        End If

        If strstr = "" Then
            strstr = " where shouhin.mishiyou='0'"
        Else
            strstr = strstr & " and shouhin.mishiyou='0'"
        End If

        Sql = Sql & strstr & " order by shouhin.shouhinid"

        grid_shien_head_set()

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shoukaii")
            Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(4) As String
            Dim s_kin As Decimal

            If dt_server.Rows.Count = 0 Then
                txtkubun.Focus()
                Exit Sub
            End If

            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))

                s_kin = dt_server.Rows.Item(i).Item("kakaku")
                mojiretsu(2) = s_kin.ToString("#,##0")

                If IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    mojiretsu(3) = "0"
                Else
                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("genzaikosuu"))
                End If

                Me.dgv_shien.Rows.Add(mojiretsu)

            Next i

            dt_server.Clear()
            ds_server.Clear()

            Me.dgv_shien.Focus()
            If dgv_shien.Rows.Count > 1 Then
                dgv_shien.CurrentCell = dgv_shien.Rows(0).Cells(1)
            End If


        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Private Sub btn_tenpo_denwachou_Click(sender As Object, e As EventArgs) Handles btn_tenpo_denwachou.Click

        With frmdenwachou
            .lbl_form_id.Text = "0"
            .ShowDialog()
        End With

    End Sub

    Private Sub btn_tenpo_shinki_Click(sender As Object, e As EventArgs) Handles btn_tenpo_shinki.Click
        frmkojin.ShowDialog()
    End Sub

    Private Sub cmb_henkou_Click(sender As Object, e As EventArgs) Handles cmb_henkou.Click

        Dim s_tenpoid As String = Trim(lbltenpoid.Text)
        If s_tenpoid = "" Then
            Exit Sub
        End If

        tenpo_henkou_set(s_tenpoid)

        frmkojin.ShowDialog()

    End Sub

    Private Sub btn_shiire_kanri_Click(sender As Object, e As EventArgs) Handles btn_shiire_kanri.Click
        frmshiire_sentaku.ShowDialog()

        Dim tenpo_id = Trim(lbltenpoid.Text)
        mainset(tenpo_id)
    End Sub

    Private Sub btn_seikyuu_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuu_kanri.Click
        frmseikyuu_sentaku.ShowDialog()

        Dim tenpo_id = Trim(lbltenpoid.Text)
        mainset(tenpo_id)
    End Sub

    Private Sub btn_nyuukin_kanri_Click(sender As Object, e As EventArgs) Handles btn_nyuukin_kanri.Click
        frmnyuukin_sentaku.ShowDialog()

        Dim tenpo_id = Trim(lbltenpoid.Text)
        mainset(tenpo_id)
    End Sub

    Private Sub btn_shiharai_kanri_Click(sender As Object, e As EventArgs) Handles btn_shiharai_kanri.Click
        frmshiharai_sentaku.ShowDialog()

        Dim tenpo_id = Trim(lbltenpoid.Text)
        mainset(tenpo_id)
    End Sub

    Private Sub btn_nouhinsho_kanri_Click(sender As Object, e As EventArgs) Handles btn_nouhinsho_kanri.Click
        frmnouhinsho_sentaku.ShowDialog()

        Dim tenpo_id = Trim(lbltenpoid.Text)
        mainset(tenpo_id)
    End Sub

    Private Sub dgv_shien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_shien.CellContentClick

    End Sub

    Private Sub dgv_shien_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_shien.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim s_pcname As String

            s_pcname = Trim(lblpcname.Text)
            If s_pcname = "" Then
                msg_go("ユーザー名を設定してください。設定しないと商品を発注できません。")
                Exit Sub
            End If

            '９９件までのチェック

            If Me.dgv_nouhinsho.Rows.Count > 99 Then
                msg_go("納品書に仮登録できる件数は９９件までです。")
                Exit Sub
            End If

            Dim sentakutanka2 As Integer

            Dim sentakuid As String = Trim(Me.dgv_shien.CurrentRow.Cells(0).Value.ToString)
            Dim sentakushouhinmei As String = Trim(Me.dgv_shien.CurrentRow.Cells(1).Value.ToString)
            Dim sentakuzaiko As String = Trim(Me.dgv_shien.CurrentRow.Cells(3).Value.ToString)
            Dim sentakutanka As String = Trim(Me.dgv_shien.CurrentRow.Cells(2).Value.ToString)

            If sentakutanka = "" Then
                sentakutanka2 = 0
            Else
                sentakutanka2 = CInt(sentakutanka)
            End If

            If sentakuid = "" Then
                msg_go("商品IDが不正です。")
                Exit Sub
            End If


            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Sql = "SELECT shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2," &
                " shouhin.shouhinkubunid, shouhinkubun2.narabe,shouhin.keigen_s" &
                " FROM shouhinkubun RIGHT JOIN (shouhinkubun2 RIGHT JOIN shouhin" &
                " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2)" &
                " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid" &
                " WHERE (((shouhin.shouhinid)='" & sentakuid & "'))"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_shoukaii")
                Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

                If dt_server.Rows.Count = 0 Then
                    frmkosuu.lblkubun1.text = "Err"
                    frmkosuu.lblkubun2.text = "Err"
                    frmkosuu.lblkeigen.Text = ""
                Else

                    frmkosuu.lblkubun1.Text = Trim(dt_server.Rows.Item(0).Item("shouhinkubunid")) & Space(2) & Trim(dt_server.Rows.Item(0).Item("shouhinkubunmei"))
                    frmkosuu.lblkubun2.Text = Trim(dt_server.Rows.Item(0).Item("NARABE")) & Space(2) & Trim(dt_server.Rows.Item(0).Item("shouhinkubunmei2"))
                    If IsDBNull(dt_server.Rows.Item(0).Item("keigen_s")) Then
                        frmkosuu.lblkeigen.Text = ""
                    Else
                        frmkosuu.lblkeigen.Text = Trim(dt_server.Rows.Item(0).Item("keigen_s"))
                    End If

                    dt_server.Clear()
                    ds_server.Clear()
                End If
            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try


            If sentakutanka = "0" Then
                frmkosuu.chkfukakutei.Checked = True
                frmkosuu.lblkakutei.Text = "1"
            Else
                frmkosuu.chkfukakutei.Checked = False
                frmkosuu.lblkakutei.Text = "0"
            End If


            '個数入力
            With frmkosuu
                .txttanka.Text = sentakutanka
                .lblshouhinmei.text = sentakushouhinmei
                .lblzaiko.Text = sentakuzaiko
                .lblshouhinid.Text = sentakuid

                .ShowDialog()
            End With


        ElseIf e.KeyCode = Keys.Back Then
            txtkubun.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            dgv_log.Visible = False
        End If


    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newtabsize As Integer = (Me.TabControl1.Width - 10) / 2

        'タブのサイズを変更できるようにする
        Me.TabControl1.SizeMode = TabSizeMode.Fixed
        'タブのサイズを 80x30 にする
        Me.TabControl1.ItemSize = New Size(newtabsize, 25)

        newtabsize = (Me.TabControl2.Width - 10) / 5

        'タブのサイズを変更できるようにする
        Me.TabControl2.SizeMode = TabSizeMode.Fixed
        'タブのサイズを 80x30 にする
        Me.TabControl2.ItemSize = New Size(newtabsize, 25)



        set_shain_cbx(6)

        settei_res = Setting1(4, 0, "", 0)
        If settei_res = "0" Then
            cbx_shain.SelectedIndex = -1
        Else
            cbx_shain.SelectedIndex = cbx_shain.FindString(settei_res)
        End If

        cbx_shurui.Items.Clear()
        cbx_shurui.Items.AddRange(PrintCategory.Names)

    End Sub


    Private Sub btn_tenpo_hyouji_rireki_Click(sender As Object, e As EventArgs) Handles btn_tenpo_hyouji_rireki.Click
        frmhyouji_rireki.ShowDialog()
    End Sub

    Private Sub btn_denpyou_henkou_Click(sender As Object, e As EventArgs) Handles btn_denpyou_henkou.Click

        Dim dgv = dgv_denpyou
        If dgv.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim current_row = dgv.CurrentRow
        Dim hacchuuid As String = Trim(current_row.Cells(1).Value)
        Dim hinichi As String = Trim(current_row.Cells(0).Value)
        Dim nouhinsho_no As String = Trim(current_row.Cells(5).Value)
        Dim inji As String = Trim(current_row.Cells(6).Value)
        Dim bikou1 As String = Trim(current_row.Cells(7).Value)
        Dim bikou2 As String = Trim(current_row.Cells(8).Value)
        Dim print As String = Trim(current_row.Cells(9).Value)
        Dim dami2 As String = Trim(current_row.Cells(10).Value)
        Dim shain_id As String = Mid(Trim(current_row.Cells(3).Value), 1, 2)
        Dim tenpo_mei = Trim(lbltenpomei.Text)

        set_shain_cbx(7)

        With frmdenpyou

            .GroupBox5.Text += "　（ " + tenpo_mei + " )"

            .cbx_shurui.Items.Clear()
            .cbx_shurui.Items.AddRange(PrintCategory.Names)
            .cbx_shurui.SelectedIndex = .cbx_shurui.FindStringExact(inji)

            .DateTimePicker1.Text = hinichi
            .txt_nouhinsho_no.Text = nouhinsho_no

            If nouhinsho_no = "" Then
                .chk_nouhinsho_pc.Checked = True
                .txt_nouhinsho_no.Enabled = False
            Else
                .chk_nouhinsho_pc.Checked = False
                .txt_nouhinsho_no.Enabled = True
            End If

            .txtbikou1.Text = bikou1
            .txtbikou2.Text = bikou2
            .cbx_shain.SelectedIndex = .cbx_shain.FindString(shain_id)

            If dami2 = "1" Then
                .chk_nouhinsho_houkoku.Checked = True
            Else
                .chk_nouhinsho_houkoku.Checked = False
            End If

            .lbl_hacchuuid.Text = hacchuuid

            .ShowDialog()

        End With

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click
        If dgv_denpyou.Rows.Count = 0 Then
            Exit Sub
        End If



    End Sub

    Private Sub txtfurigana_LostFocus(sender As Object, e As EventArgs) Handles txtfurigana.LostFocus

    End Sub

    Private Sub Button326_Click(sender As Object, e As EventArgs) Handles Button326.Click
        End
    End Sub

    Private Sub btn_seikyuu_nyuukin_shousai_Click(sender As Object, e As EventArgs) Handles btn_seikyuu_nyuukin_shousai.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim newshainid As String, newtenpoid As String, newnouhinshokanriid As String, dami3 As String

        Dim s_pcname As String

        s_pcname = Trim(lblpcname.Text)
        If s_pcname = "" Then
            msg_go("ユーザー名を登録してから再度実行してください。")
            Exit Sub
        End If


        '        If nouhinsho_tourokuchu = 1 Then
        '            Exit Sub
        '        End If

        '        nouhinsho_tourokuchu = 1

        If Me.dgv_nouhinsho.Rows.Count = 0 Then
            msg_go("納品書に仮登録されていません。")
            Exit Sub
        End If


        If Me.lbltorihikinashi.Text = "1" Then
            ret = MsgBox("取引のない店舗の伝票の登録はできません。店舗情報の設定を変更してから再度実行してください。", 16, "総合管理システム「SPSALES」")
            ' nouhinsho_tourokuchu = 0
            Exit Sub
        End If

        If Me.cbx_shain.SelectedIndex <> -1 Then
            newshainid = Mid(Trim(cbx_shain.Text), 1, 2)
        Else
            msg_go("納品書の社員が選択されていません。")
            ' nouhinsho_tourokuchu = 0
            Exit Sub
        End If

        Dim newinji As String
        If Me.cbx_shurui.SelectedIndex <> -1 Then
            newinji = Me.cbx_shurui.SelectedIndex.ToString
        Else
            msg_go("納品書の備考印字が選択されていません。")
            ' nouhinsho_tourokuchu = 0
            Exit Sub
        End If

        newtenpoid = Trim(Me.lbltenpoid.Text)
        If newtenpoid = "" Then
            msg_go("店舗が選択されていません。")
            ' nouhinsho_tourokuchu = 0
            Exit Sub
        End If

        Dim newiraibi As String = Trim(Me.DateTimePicker1.Value.ToString("yyyyMMdd"))


        Dim newgoukei As String = Trim(Me.lbl_nouhinsho_goukei.Text)

        If newgoukei = "" Then
            msg_go("合計金額が表示されていません。再度実行してください。No4",)
            '  nouhinsho_tourokuchu = 0
            Exit Sub
        End If

        Dim newnebiki2 As Integer = 0

        Dim s_bikou1 As String = Trim(txtbikou1.Text)
        Dim s_bikou2 As String = Trim(txtbikou2.Text)

        If chk_nouhinsho_pc.Checked = True Then
            newnouhinshokanriid = ""
        Else
            Dim newdata As String = Now.ToString("yyyy")
            newnouhinshokanriid = Trim(txt_nouhinsho_no.Text)
            Dim lenlen As Integer = Len(newnouhinshokanriid)
            If lenlen = 6 Then
                newnouhinshokanriid = newdata & newnouhinshokanriid
            ElseIf lenlen = 5 Then
                newnouhinshokanriid = newdata & "0" & newnouhinshokanriid
            ElseIf lenlen = 4 Then
                newnouhinshokanriid = newdata & "00" & newnouhinshokanriid
            Else
                msg_go("納品書IDが正確に入力されていません。３桁以下です。")
                '7 nouhinsho_tourokuchu = 0
                Exit Sub
            End If
        End If


        If chk_nouhinsho_houkoku.Checked = True Then
            'If user_check(6) = False Then
            '    msg_go("ダミーは使用できません。")
            '    nouhinsho_tourokuchu = 0
            '    Exit Sub
            'End If

            dami3 = "1"
        Else
            dami3 = ""
        End If




        '仮登録状態から本登録へ

        wait_on("", "1")


        If main_hontouroku(newiraibi, newgoukei, newshainid, newtenpoid, newnouhinshokanriid, dami3, newinji, s_bikou1, s_bikou2) = -1 Then


        End If


        wait_off()

        '        nouhinsho_tourokuchu = 0


    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        frmshouhin.ShowDialog()
    End Sub

    Private Sub chk_nouhinsho_pc_CheckedChanged(sender As Object, e As EventArgs) Handles chk_nouhinsho_pc.CheckedChanged

    End Sub

    Private Sub chk_nouhinsho_pc_Click(sender As Object, e As EventArgs) Handles chk_nouhinsho_pc.Click

        If chk_nouhinsho_pc.Checked = True Then
            txt_nouhinsho_no.Text = ""
            txt_nouhinsho_no.Enabled = False
        Else
            txt_nouhinsho_no.Text = ""
            txt_nouhinsho_no.Enabled = True
            txt_nouhinsho_no.Focus()
        End If
    End Sub

    Private Sub btn_nouhinsho_bar_Click(sender As Object, e As EventArgs) Handles btn_nouhinsho_bar.Click
        If lbltenpoid.Text = "" Then
            msg_go("店舗が選択されていません。")
            Exit Sub
        End If

        barcodenono = 0

        frmbarcode.ShowDialog()

    End Sub

    Private Sub btn_nouhinsho_clear_Click(sender As Object, e As EventArgs) Handles btn_nouhinsho_clear.Click

        If Trim(lbltenpoid.Text) = "" Then
            msg_go("店舗が選択されていません。")
            Exit Sub
        End If

        Dim s_pcname As String

        s_pcname = Trim(lblpcname.Text)
        If s_pcname = "" Then
            msg_go("ユーザー名を登録してから再度実行してください。")
            Exit Sub
        End If

        Dim result = MessageBox.Show("仮登録のオーダー内容の消去をキャンセルしてよいですか？", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuushousai WHERE hacchuuid ='" + s_pcname + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_gyousha")

            If ds.Tables("t_gyousha").Rows.Count > 0 Then

                ' すべての一致する行を削除
                For Each row As DataRow In ds.Tables("t_gyousha").Rows
                    row.Delete()
                Next
                '一部のみ
                'ds.Tables("t_gyousha").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_gyousha")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する仮登録情報が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try



        tenpo_orderchu_set_10()


        txt_nouhinsho_no.Text = ""
        chk_nouhinsho_pc.Checked = True
        chk_nouhinsho_houkoku.Checked = False
        txtbikou1.Text = ""
        txtbikou2.Text = ""


    End Sub

    Private Sub btn_nouhinsho_hozon_Click(sender As Object, e As EventArgs) Handles btn_nouhinsho_hozon.Click


        Dim sakujosusunoka As Integer = 0

        For i = 1 To dgv_nouhinsho.Rows.Count - 1
            If dgv_nouhinsho(7, i).Value = True Then
                sakujosusunoka = 1
                Exit For
            End If
        Next

        If sakujosusunoka = 0 Then
            msg_go("削除したい商品伝票が選択されていません。")
            Exit Sub
        End If


        Dim s_where_str As String = "", s_atai As String
        For i = 1 To dgv_nouhinsho.Rows.Count - 1
            If dgv_nouhinsho(7, i).Value = True Then
                s_atai = Trim(dgv_nouhinsho(10, i).Value)
                If s_where_str = "" Then
                    s_where_str = "hachuushousaiid ='" + s_atai + "'"
                Else
                    s_where_str = s_where_str + "or hachuushousaiid ='" + s_atai + "'"
                End If
            End If
        Next

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuushousai WHERE " & s_where_str

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_gyousha")

            If ds.Tables("t_gyousha").Rows.Count > 0 Then

                ' すべての一致する行を削除
                For Each row As DataRow In ds.Tables("t_gyousha").Rows
                    row.Delete()
                Next
                '一部のみ
                'ds.Tables("t_gyousha").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_gyousha")
                ds.Clear()

                ' msg_go("削除しました。", 64)
            Else
                msg_go("該当する仮登録情報が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try



        tenpo_orderchu_set_10()



    End Sub

    Private Sub btn_log_touroku_Click(sender As Object, e As EventArgs) Handles btn_log_touroku.Click

        Dim tenpo_id As String = Trim(lbltenpoid.Text)
        If tenpo_id = "" Then
            msg_go("店舗が表示されていません。")
            Exit Sub
        End If

        With frmlog

            .cbx_log_kubun.Items.AddRange(LogCategory.Names)
            .cbx_status.Items.AddRange(LogStatus.Names)

            .lbl_shain_mei.Text = Trim(lblshokuinmei.Text)

            .cbx_status.SelectedIndex = 0

            .ShowDialog()

        End With

    End Sub

    Private Sub dgv_log_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_log.MouseDoubleClick

        Dim dgv = dgv_log
        If dgv.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim current_row = dgv.CurrentRow
        Dim log_id = current_row.Cells(0).Value
        Dim kubun_mei = current_row.Cells(3).Value
        Dim youken = current_row.Cells(4).Value
        Dim st_name = current_row.Cells(5).Value
        Dim del = current_row.Cells(6).Value

        With frmlog

            .btn_touroku.Text = "更新"

            .cbx_log_kubun.Items.AddRange(LogCategory.Names)
            .cbx_status.Items.AddRange(LogStatus.Names)

            .lbl_shain_mei.Text = Trim(lblshokuinmei.Text)
            .lbl_log_id.Text = log_id

            .txtlog.Text = youken

            .cbx_log_kubun.SelectedIndex = .cbx_log_kubun.FindStringExact(kubun_mei)
            .cbx_status.SelectedIndex = .cbx_status.FindStringExact(st_name)

            If del = "" Then
                .lbl_del.Text = ""
                .btn_touroku.Enabled = True
            Else
                .lbl_del.Text = "削除済"
                .btn_touroku.Enabled = False
            End If

            .ShowDialog()

        End With

    End Sub

    Private Sub chk_log_sakujozumi_Click(sender As Object, e As EventArgs) Handles chk_log_sakujozumi.Click
        log_main_set(Trim(lbltenpoid.Text))
    End Sub

    Private Sub Button328_Click(sender As Object, e As EventArgs) Handles Button328.Click

        Dim s_r As String = InputBox("R番号入力")
        Dim s_g As String = InputBox("G番号入力")
        Dim s_b As String = InputBox("B番号入力")

        If s_r = "" Or s_g = "" Or s_b = "" Then
            msg_go("値が不正です。")
            Exit Sub
        End If


        GroupBox13.BackColor = Color.FromArgb(CInt(s_r), CInt(s_g), CInt(s_b))
        GroupBox2.BackColor = Color.FromArgb(CInt(s_r), CInt(s_g), CInt(s_b))
        GroupBox1.BackColor = Color.FromArgb(CInt(s_r), CInt(s_g), CInt(s_b))
        GroupBox5.BackColor = Color.FromArgb(CInt(s_r), CInt(s_g), CInt(s_b))
        GroupBox4.BackColor = Color.FromArgb(CInt(s_r), CInt(s_g), CInt(s_b))



    End Sub
End Class
