Public Class frmshouhinkubun
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmshouhinkubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kubun_gyousha_set()

        kubun_1_set()

    End Sub
End Class