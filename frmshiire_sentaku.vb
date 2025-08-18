Public Class frmshiire_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shori_Click(sender As Object, e As EventArgs) Handles btn_shori.Click
        Me.Close() : Me.Dispose()


        shouhin_shiirechu_set()

        frmshiire.ShowDialog()
    End Sub

    Private Sub btn_rireki_Click(sender As Object, e As EventArgs) Handles btn_rireki.Click
        Me.Close() : Me.Dispose()
        frmshiire_rireki.ShowDialog()
    End Sub
End Class