Public Class frmshutsuryoku_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_shouhin_Click(sender As Object, e As EventArgs) Handles btn_shouhin.Click
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "商品情報出力"
            .chk_plus_alpha.Text = "使用していない商品を出力する"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_tenpo_Click(sender As Object, e As EventArgs) Handles btn_tenpo.Click
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "店舗情報出力"
            .chk_plus_alpha.Text = "取引していない店舗も出力する"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_kurikoshizan_Click(sender As Object, e As EventArgs) Handles btn_kurikoshizan.Click
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "繰越残情報出力"
            .chk_plus_alpha.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_wella_hanbai_jisseki_Click(sender As Object, e As EventArgs) Handles btn_wella_hanbai_jisseki.Click
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "Wella売上通知データ出力"
            .chk_plus_alpha.Text = "期間指定"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_wella_shouhin_zaiko_Click(sender As Object, e As EventArgs) Handles btn_wella_shouhin_zaiko.Click
        With frmshuturyoku_csv
            .lbl_shutsuryoku_type.Text = "ウエラ商品情報出力"
            .chk_plus_alpha.Visible = False
            .ShowDialog()
        End With
    End Sub
End Class