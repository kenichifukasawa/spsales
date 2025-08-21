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

    Private Sub btn_shouhin_check_Click(sender As Object, e As EventArgs) Handles btn_shouhin_check.Click

        Me.Close() : Me.Dispose()
        frmcheck_shouhin_check.ShowDialog()
    End Sub

    Private Sub btn_shouhin_log_Click(sender As Object, e As EventArgs) Handles btn_shouhin_log.Click
        Me.Close() : Me.Dispose()
        frmcheck_shouhin_log.ShowDialog()
    End Sub

    Private Sub btn_kurikoshi_log_Click(sender As Object, e As EventArgs) Handles btn_kurikoshi_log.Click
        Me.Close() : Me.Dispose()
        frmcheck_kurikoshi_log.ShowDialog()
    End Sub

    Private Sub btn_kosuu_henkou_Click(sender As Object, e As EventArgs) Handles btn_kosuu_henkou.Click
        Me.Close() : Me.Dispose()
        frmcheck_kosuu_henkou.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() : Me.Dispose()
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "商品情報出力"
            .chk_plus_alpha.Text = "使用していない商品を出力する"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_tenpo_Click(sender As Object, e As EventArgs) Handles btn_tenpo.Click
        Me.Close() : Me.Dispose()
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "店舗情報出力"
            .chk_plus_alpha.Text = "取引していない店舗も出力する"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_kurikoshizan_Click(sender As Object, e As EventArgs) Handles btn_kurikoshizan.Click
        Me.Close() : Me.Dispose()
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "繰越残情報出力"
            .chk_plus_alpha.Visible = False
            .grp_kikan_shitei.Visible = True
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_wella_hanbai_jisseki_Click(sender As Object, e As EventArgs) Handles btn_wella_hanbai_jisseki.Click
        Me.Close() : Me.Dispose()
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "Wella売上通知データ出力"
            .chk_plus_alpha.Text = "期間指定"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_wella_shouhin_zaiko_Click(sender As Object, e As EventArgs) Handles btn_wella_shouhin_zaiko.Click
        Me.Close() : Me.Dispose()
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "ウエラ商品情報出力"
            .chk_plus_alpha.Visible = False
            .ShowDialog()
        End With
    End Sub
End Class