Public Class frmshuukei_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btn_shouhin_Click(sender As Object, e As EventArgs) Handles btn_shouhin.Click
        Me.Close() : Me.Dispose()
        frmshuukei_shouhin.ShowDialog()
    End Sub

    Private Sub btn_kubun_Click(sender As Object, e As EventArgs) Handles btn_kubun.Click
        Me.Close() : Me.Dispose()
        frmshuukei_uriage.ShowDialog()
    End Sub

    Private Sub btn_gyousha_Click(sender As Object, e As EventArgs) Handles btn_gyousha.Click
        Me.Close() : Me.Dispose()
        frmshuukei_hanbai.ShowDialog()
    End Sub
End Class