Imports System.Data.SqlClient



Public Class frmmain

    Private kubundodoo As Integer
    Private kuku2dou As Integer




    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click

        frmseikyuusho_soushin_ichi.ShowDialog()

    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        frminfo.ShowDialog()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
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
            .AlternatingRowsDefaultCellStyle.BackColor _
                                                    = Color.LightBlue
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

            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(4) As String
            Dim s_kin As Decimal

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

        Catch ex As Exception
            msg_go(ex.Message)

        End Try


    End Sub

    Private Sub btn_tenpo_denwachou_Click(sender As Object, e As EventArgs) Handles btn_tenpo_denwachou.Click
        frmdenwachou.ShowDialog()
    End Sub
End Class
