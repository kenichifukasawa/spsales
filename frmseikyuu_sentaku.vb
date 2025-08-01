Public Class frmseikyuu_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_hakkou_insatsu_Click(sender As Object, e As EventArgs) Handles btn_hakkou_insatsu.Click

    End Sub

    Private Sub btn_hakkou_pdf_Click(sender As Object, e As EventArgs) Handles btn_hakkou_pdf.Click

    End Sub

    Private Sub btn_rireki_Click(sender As Object, e As EventArgs) Handles btn_rireki.Click
        frmseikyuu_rireki.ShowDialog()
    End Sub

    Private Sub btn_mail_Click(sender As Object, e As EventArgs) Handles btn_mail.Click

    End Sub

    Private Sub btn_nenkin_hyou_Click(sender As Object, e As EventArgs) Handles btn_nenkin_hyou.Click

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click

    End Sub

    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click
        frmseikyuusho_soushin_ichi.ShowDialog()
    End Sub
End Class