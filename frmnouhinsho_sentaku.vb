Public Class frmnouhinsho_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_idou_Click(sender As Object, e As EventArgs) Handles btn_idou.Click
        frmnouhinsho_idou.ShowDialog()
    End Sub

    Private Sub btn_rireki_Click(sender As Object, e As EventArgs) Handles btn_rireki.Click
        frmnouhinsho_rireki.ShowDialog()
    End Sub

End Class