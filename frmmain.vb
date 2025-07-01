Public Class frmmain
    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click

        frmseikyuusho_soushin_ichi.ShowDialog()

    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        frminfo.ShowDialog()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        frmshuukei_sentaku.ShowDialog()
    End Sub

    Private Sub btn_shutsuryoku_Click(sender As Object, e As EventArgs) Handles btn_shutsuryoku.Click
        frmshutsuryoku_sentaku.ShowDialog()
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        frmcheck_sentaku.ShowDialog()
    End Sub

End Class
