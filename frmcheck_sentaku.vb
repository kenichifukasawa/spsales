Public Class frmcheck_sentaku

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_shouhin_check_Click(sender As Object, e As EventArgs) Handles btn_shouhin_check.Click
        frmcheck_shouhin_check.ShowDialog()
    End Sub

    Private Sub btn_shouhin_log_Click(sender As Object, e As EventArgs) Handles btn_shouhin_log.Click
        frmcheck_shouhin_log.ShowDialog()
    End Sub

    Private Sub btn_kurikoshi_log_Click(sender As Object, e As EventArgs) Handles btn_kurikoshi_log.Click
        frmcheck_kurikoshi_log.ShowDialog()
    End Sub

    Private Sub btn_kosuu_henkou_Click(sender As Object, e As EventArgs) Handles btn_kosuu_henkou.Click
        frmcheck_kosuu_henkou.ShowDialog()
    End Sub
End Class