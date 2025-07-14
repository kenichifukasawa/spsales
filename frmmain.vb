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

    Private Sub btn_tenpo_kensaku_Click(sender As Object, e As EventArgs) Handles btn_tenpo_kensaku.Click

        frmkensaku.ShowDialog()

    End Sub

    Private Sub lbltenpoid_Click(sender As Object, e As EventArgs) Handles lbltenpoid.Click

        mainset("000087")
    End Sub

    Private Sub btn_tenpo_denwachou_Click(sender As Object, e As EventArgs) Handles btn_tenpo_denwachou.Click

        With frmdenwachou
            .lbl_form_id.Text = "0"
            .ShowDialog()
        End With

        ' TODO:納品書のセットの関数をここにも書く

    End Sub

End Class
