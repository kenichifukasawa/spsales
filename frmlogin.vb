Public Class frmlogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ninshou.Click

        Dim s_nyuuryoku_pw As String = Trim(TXTPASSWORD.Text)

        If s_nyuuryoku_pw = "" Then
            Exit Sub
        End If
        Dim s_modori_str As String = ""

        '' レジストリを調べ、ダイアログボックスを表示する
        'settei_res3 = Setting1(2, 0, "", 0)
        'Select Case settei_res3
        '    Case "-1"
        '        msg_go("設定ファイルがないか、読み込めません")
        '        End
        '    Case Else
        '        PASSNYUURYOKU = settei_res3
        'End Select

        Select Case Trim(TXTPASSWORD.Text)
            Case "aanda5647" '総合
                s_modori_str = "000総合"
            Case "Plot8877Ken" '管理者
                s_modori_str = "000管理者"
            Case Else
                s_modori_str = shain_pw_chk(Trim(TXTPASSWORD.Text), "1")
                If s_modori_str = "" Then
                    msg_go("パスワードが違います。")
                    TXTPASSWORD.Text = ""
                    TXTPASSWORD.Focus()
                    Exit Sub
                End If
        End Select


        If s_modori_str <> "" Then

            frmmain.lblshokuinid.Text = Mid(s_modori_str, 1, 2)
            frmmain.lblshokuinmei.Text = Trim(Mid(s_modori_str, 3))



            Me.Close()
            Me.Dispose()
        Else

            End
        End If

    End Sub

    Private Sub TXTPASSWORD_TextChanged(sender As Object, e As EventArgs) Handles TXTPASSWORD.TextChanged

    End Sub

    Private Sub TXTPASSWORD_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPASSWORD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TXTPASSWORD.Text) <> "" Then
                btn_ninshou.PerformClick()
            End If
        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load



#If DEBUG Then
        TXTPASSWORD.Text = "6666"
        btn_ninshou.PerformClick()
#End If

    End Sub

    Private Sub frmlogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TXTPASSWORD.Focus()
    End Sub
End Class