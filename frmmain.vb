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

    Private Sub btn_shutsuryoku_Click(sender As Object, e As EventArgs) Handles btn_shutsuryoku.Click
        frmshutsuryoku_sentaku.ShowDialog()
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        frmcheck_sentaku.ShowDialog()
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

    Function shouhinkubun_shien_grid_set(no As Integer, Optional sentaku1id As String = "", Optional sentakuid2 As String = "") As Integer


        Dim shouhinkubuncount As Integer, shouhinkubunGROW As Integer, cmdicmdi3 As Integer

        Dim lngStyle As Long

        shouhinkubun_shien_grid_set = 0

        Select Case no
            Case 0, 1, 4
                Me.lstshien.Items.Clear()
                'Case 3
                '    For cmdicmdi3 = 0 To 99
                '        frmmain.cmd2(cmdicmdi3).Caption = ""
                '    Next
                'Case 2
                '    For cmdicmdi3 = 0 To 99
                '        frmmain.cmd1(cmdicmdi3).Caption = ""
                '    Next
        End Select




        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver

            Select Case no
                Case 4
                    Sql = "SELECT*FROM shouhinkubun0 ORDER BY shouhinkubunid0"

                Case 0

                    Sql = "SELECT*FROM shouhinkubun ORDER BY shouhinkubunid"

                Case 1

                    Sql = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"

                    'Case 2

                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun ORDER BY shouhinkubunid"

                    '    frmmain.cmd1(0).Caption = "なし"
                    'Case 3
                    '    If Trim(sentaku1id) = "" Then
                    '        shouhinkubun_shien_grid_set = -1
                    '        Screen.MousePointer = 0
                    '        Exit Function
                    '    End If
                    '    'sql_shouhinkubun = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"
                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"
                    '    frmmain.cmd2(0).Caption = "なし"
                    'Case 5
                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun0 ORDER BY shouhinkubunid0"
                    '    frmmain.cmd0(0).Caption = "なし"
            End Select

            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim s_str As String = ""

            For i = 0 To dt_server.Rows.Count - 1
                Select Case no
                    Case 4
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0"))
                        Me.lstshien.Items.Add(s_str)
                    Case 0
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))
                        Me.lstshien.Items.Add(s_str)

                    Case 1
                        s_str = Trim(dt_server.Rows.Item(i).Item("NARABE")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                        Me.lstshien.Items.Add(s_str)

                        'Case 2
                        '                frmmain.cmd1(CInt(rs_shouhinkubun!shouhinkubunid)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei)
                        '            Case 3
                        '                frmmain.cmd2(CInt(rs_shouhinkubun!NARABE)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei2)
                        '            Case 5
                        '                frmmain.cmd0(CInt(rs_shouhinkubun!shouhinkubunid0)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei0)
                End Select
            Next i
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            shouhinkubun_shien_grid_set = -1
        End Try

    End Function

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

    Sub grid_shien_head_set()

        With Me.dgv_shien

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 4
            .Columns(0).Name = "商品ID"
            .Columns(1).Name = "商品名"
            .Columns(2).Name = "価格"
            .Columns(3).Name = ""
            .Columns(0).Width = 100
            .Columns(1).Width = 300
            .Columns(2).Width = 80
            .Columns(3).Width = 0

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            ' 奇数行の既定セル・スタイルの背景色を設定
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

        End With

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

            If Me.dgv_shien.Rows.Count > 99 Then
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
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub GroupBox16_Enter(sender As Object, e As EventArgs) Handles GroupBox16.Enter

    End Sub

    Private Sub btn_tenpo_hyouji_rireki_Click(sender As Object, e As EventArgs) Handles btn_tenpo_hyouji_rireki.Click
        frmhyouji_rireki.ShowDialog()
    End Sub
End Class
