Public Class frmpassword
    Private Sub frmpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = txt_password
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txt_password.Text = "" Then
            msg_go("パスワードを入力してください。")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_password.Text = "" Then
                msg_go("パスワードを入力してください。")
                Exit Sub
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    ' パスワードを取得するためのプロパティ
    Public ReadOnly Property Password As String
        Get
            Return txt_password.Text
        End Get
    End Property
End Class