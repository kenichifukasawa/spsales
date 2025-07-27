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
            lstshien.Left = 100
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
            lstshien.Left = 200
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
            lstshien.Left = 300
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

        ' TODO:納品書のセットの関数をここにも書く

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

        ' TODO:納品書のセットの関数をここにも書く

    End Sub

    Private Sub btn_seikyuu_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuu_kanri.Click
        frmseikyuu_sentaku.ShowDialog()

        ' TODO:納品書のセットの関数をここにも書く

    End Sub

    Private Sub btn_nyuukin_kanri_Click(sender As Object, e As EventArgs) Handles btn_nyuukin_kanri.Click
        frmnyuukin_sentaku.ShowDialog()

        ' TODO:納品書のセットの関数をここにも書く

    End Sub

    Private Sub btn_shiharai_kanri_Click(sender As Object, e As EventArgs) Handles btn_shiharai_kanri.Click
        frmshiharai_sentaku.ShowDialog()

        ' TODO:納品書のセットの関数をここにも書く

    End Sub

    Private Sub btn_nouhinsho_kanri_Click(sender As Object, e As EventArgs) Handles btn_nouhinsho_kanri.Click
        frmnouhinsho_sentaku.ShowDialog()

        ' TODO:納品書のセットの関数をここにも書く

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

            If gridorder.Rows > 99 Then
                msg_go("納品書に登録できる件数は９９件までです。")
                Exit Sub
            End If



            With frmmain.gridshien
                .Col = 0
                sentakuid = Trim(.Text)  'shouhinid
                sqlsql = "SELECT shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2," &
                " shouhin.shouhinkubunid, shouhinkubun2.narabe,shouhin.keigen_s" &
                " FROM shouhinkubun RIGHT JOIN (shouhinkubun2 RIGHT JOIN shouhin" &
                " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2)" &
                " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid" &
                " WHERE (((shouhin.shouhinid)='" & sentakuid & "'));"
                If FcSQlGet(1, rsrsrs, sqlsql, WMsg) = False Then
                    frmkosuu.lblkubun1.Caption = "Err"
                    frmkosuu.lblkubun2.Caption = "Err"
                    s_keigen = Space(1)
                Else
                    frmkosuu.lblkubun1.Caption = rsrsrs!shouhinkubunid & Space(2) & rsrsrs!shouhinkubunmei
                    frmkosuu.lblkubun2.Caption = rsrsrs!NARABE & Space(2) & rsrsrs!shouhinkubunmei2
                    If IsNull(rsrsrs!keigen_s) Then
                        s_keigen = Space(1)
                    Else
                        s_keigen = rsrsrs!keigen_s
                    End If

                    rsrsrs.Close
                End If
                .Col = 1
                sentakushouhinmei = Trim(.Text) 'shouhinmei
                .Col = 2
                sentakutanka = Trim(.Text) 'tanka
                If sentakutanka = "" Then
                    sentakukakaku2 = 0
                Else
                    On Error GoTo errsu
                    sentakukakaku2 = CDbl(sentakutanka)
                    On Error GoTo 0
                End If
                .Col = 3
                sentakuzaiko = Trim(.Text)
                frmkosuu.txttanka.Text = sentakutanka
                frmkosuu.lblshouhinmei.Caption = sentakushouhinmei
                frmkosuu.lblzaiko.Caption = sentakuzaiko
                If frmkosuu.txttanka.Text = "0" Then
                    frmkosuu.chkfukakutei.Value = 1
                    nyuuryokufukakutei = 1
                Else
                    frmkosuu.chkfukakutei.Value = 0
                    nyuuryokufukakutei = 0
                End If

            End With



            '個数入力
            kosuukadou = 0

            frmkosuu.Show 1

        If kosuukadou = 0 Then
                Exit Sub
            End If




            newshoukei = sentakukakaku2 * inpkosuu2




            Dim MONOI As Long
            Dim newhacchuushousaiid As String ', newhacchuushousaiid2 As Double
            Dim rs_hacchu2 As ADODB.Recordset

            MONOI = CLng(setting2_10(0, 3, 1, 1, 0))
            ' MONOI = CLng(setting2(0, 3, 0, 1, "", 0))
            If MONOI = -1 Then
                MsgBox "発注詳細番号を参照できませんでした。再度実行してください。"
           Exit Sub
            End If
            If MONOI = 0 Then
                newhacchuushousaiid = "0000000001"
            Else
                newhacchuushousaiid = Format(MONOI, "000000000#")
            End If

            'newhacchuushousaiid2 = MONOI + 1
            'If setting2(0, 3, 1, 1, CStr(newhacchuushousaiid2), 0) = "-1" Then
            ' ret = MsgBox("発注詳細番号の更新に失敗しました。少し時間をおいて再度実行してください。", 16, "総合管理システム「SPSALES」")
            ' Exit Sub
            'End If

            '発注詳細テーブル登録
            On Error GoTo errjitsutouroku2

            If cnn Is Nothing Then
                data_base_open
            End If

            data_base_open
            
            Set rs_hacchu2 = New ADODB.Recordset
            
            rs_hacchu2.CursorType = adOpenForwardOnly 'adOpenKeyset


            rs_hacchu2.LockType = adLockOptimistic
            rs_hacchu2.Open "hacchuushousai", cnn, , , adCmdTable


                rs_hacchu2.AddNew

            rs_hacchu2!hachuushousaiid = newhacchuushousaiid
            rs_hacchu2!hacchuuid = s_pcname   'newhacchuuid
            rs_hacchu2!shouhinid = sentakuid ' karitourokudata(karitousuu - 1, 1)
            rs_hacchu2!kosuu = inpkosuu2  'karitourokudata(karitousuu - 1, 2)
            rs_hacchu2!tanka = sentakukakaku2 ' karitourokudata(karitousuu - 1, 3)
            rs_hacchu2!kei = newshoukei ' karitourokudata(karitousuu - 1, 4)
            rs_hacchu2!tekiyou = nyuuryokutekiyou  'karitourokudata(karitousuu - 1, 5)
            rs_hacchu2!kakutei = CStr(nyuuryokufukakutei) ' karitourokudata(karitousuu - 1, 6)

            If Trim(s_keigen) <> "" Then
                rs_hacchu2!keigen = Trim(s_keigen)  ' karitourokudata(karitousuu - 1, 7)
            End If

            rs_hacchu2.Update


            On Error GoTo 0





            tenpo_orderchu_set_10()



        ElseIf KeyAscii = 8 Then
            txtkubun.SetFocus
        ElseIf KeyAscii = 27 Then
            frmmain.fshien1.Visible = False
        End If

        End If

    End Sub
End Class
