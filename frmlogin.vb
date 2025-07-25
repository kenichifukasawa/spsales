Public Class frmlogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ninshou.Click
        Dim PASSNYUURYOKU As String = ""

        Dim settei_res3 As String, unlsuru As Integer = 1



        ' レジストリを調べ、ダイアログボックスを表示する
        settei_res3 = Setting1(2, 0, "", 0)
        Select Case settei_res3
            Case "-1"
                msg_go("設定ファイルがないか、読み込めません")
                End
            Case Else
                PASSNYUURYOKU = settei_res3
        End Select

        Select Case Trim(TXTPASSWORD.Text)
            Case "aanda5647" '総合
                unlsuru = 0
            Case "Plot8877Ken" '管理者
                unlsuru = 0
            Case Else
                If Trim(TXTPASSWORD.Text) = PASSNYUURYOKU Then '通常
                    unlsuru = 0
                Else
                    msg_go("パスワードが違います。")
                    TXTPASSWORD.Text = ""
                    TXTPASSWORD.Focus()
                    Exit Sub
                End If
        End Select



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
                btn_ninshou.PerformClick()
            End If
        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load



#If DEBUG Then
        TXTPASSWORD.Text = "8877"
        btn_ninshou.PerformClick()
#End If
    End Sub

    Private Sub frmlogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TXTPASSWORD.Focus()
    End Sub
End Class