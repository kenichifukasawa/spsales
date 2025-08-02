Public Class frmshouhinkubun
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmshouhinkubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kubun_gyousha_set()

        kubun_1_set()

    End Sub

    Private Sub cmbkubun1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkubun1.SelectedIndexChanged

        If cmbkubun1.SelectedIndex <> -1 Then
            kubun_2_set(Mid(Trim(cmbkubun1.Text), 1, 2))
        End If

    End Sub
End Class