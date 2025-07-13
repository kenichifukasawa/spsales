Public Class frmlogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PASSNYUURYOKU As String = ""

        Dim settei_res3 As String, kyupas3 As String, unlsuru As Integer



        ' レジストリを調べ、ダイアログボックスを表示する
        settei_res3 = setting(1, 2, 0, "", 1)
        Select Case settei_res3
            Case "-1"
                ret = MsgBox("設定ファイルがないか、読み込めません", 16, "総合管理システム「SPSALES」")
                unlsuru = 0
            Case Else
                PASSNYUURYOKU = settei_res3
        End Select

        If TXTPASSWORD.Text = "aanda5647" Then     '総合
            unlsuru = 0
        Else
            If TXTPASSWORD.Text = PASSNYUURYOKU Then '通常
                unlsuru = 0
            Else
                ret = MsgBox("パスワードが違います。", 48, "総合管理システム「SPSALES」")
                TXTPASSWORD.Text = ""
                TXTPASSWORD.Focus()
                Exit Sub
            End If
        End If

        If unlsuru = 0 Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub TXTPASSWORD_TextChanged(sender As Object, e As EventArgs) Handles TXTPASSWORD.TextChanged

    End Sub

    Private Sub TXTPASSWORD_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPASSWORD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TXTPASSWORD.Text) <> "" Then
                Button1.PerformClick()
            End If
        End If
    End Sub
End Class