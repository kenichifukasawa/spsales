Public Class frmichi
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shouhin_Click(sender As Object, e As EventArgs) Handles btn_shouhin.Click
        Me.Close() : Me.Dispose()
        frmshouhin.ShowDialog()

    End Sub

    Private Sub btn_kubun_Click(sender As Object, e As EventArgs) Handles btn_kubun.Click
        Me.Close() : Me.Dispose()
        frmshouhinkubun.ShowDialog()

    End Sub

    Private Sub btn_gyousha_Click(sender As Object, e As EventArgs) Handles btn_gyousha.Click
        Me.Close() : Me.Dispose()
        frmichiran_gyousha.ShowDialog()
    End Sub

    Private Sub btn_yuubin_bangou_Click(sender As Object, e As EventArgs) Handles btn_yuubin_bangou.Click
        Me.Close() : Me.Dispose()
        frmichiran_yuubin.ShowDialog()
    End Sub

    Private Sub btn_shain_Click(sender As Object, e As EventArgs) Handles btn_shain.Click

        Me.Close() : Me.Dispose()
        frmichiran_shain.ShowDialog()
    End Sub
End Class