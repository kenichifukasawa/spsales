Public Class frmseikyuu_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_hakkou_insatsu_Click(sender As Object, e As EventArgs) Handles btn_hakkou_insatsu.Click
        Me.Close() : Me.Dispose()
        With frmseikyuusho_hakkou_insatsu
            .chk_mail.Checked = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_hakkou_pdf_Click(sender As Object, e As EventArgs) Handles btn_hakkou_pdf.Click
        Me.Close() : Me.Dispose()
        With frmseikyuusho_hakkou_insatsu
            .chk_mail.Checked = True
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_rireki_Click(sender As Object, e As EventArgs) Handles btn_rireki.Click
        Me.Close() : Me.Dispose()
        frmseikyuu_rireki.ShowDialog()
    End Sub

    Private Sub btn_shuukin_hyou_Click(sender As Object, e As EventArgs) Handles btn_shuukin_hyou.Click
        Me.Close() : Me.Dispose()
        frmseikyuu_shuukin_hyou.ShowDialog()
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click

    End Sub

    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click
        Me.Close() : Me.Dispose()
        frmseikyuusho_soushin_ichi.ShowDialog()
    End Sub
End Class