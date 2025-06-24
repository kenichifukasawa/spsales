Public Class frmichi
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shouhin_Click(sender As Object, e As EventArgs) Handles btn_shouhin.Click

    End Sub

    Private Sub btn_kubun_Click(sender As Object, e As EventArgs) Handles btn_kubun.Click

    End Sub

    Private Sub btn_gyousha_Click(sender As Object, e As EventArgs) Handles btn_gyousha.Click

    End Sub

    Private Sub btn_yuubin_bangou_Click(sender As Object, e As EventArgs) Handles btn_yuubin_bangou.Click

    End Sub

    Private Sub btn_shain_Click(sender As Object, e As EventArgs) Handles btn_shain.Click
        frmichiran_shain.ShowDialog()
    End Sub
End Class