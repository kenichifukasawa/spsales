Public Class frmseikyuu_shuukin_hyou

    Private Sub frmseikyuu_shuukin_hyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_shimebi.Items.AddRange(Deadline.Names)
        set_shain_cbx(3)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

        msg_go("未開発")
        Exit Sub

        ' TODO

    End Sub

    Private Sub cbx_shimebi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shimebi.SelectedIndexChanged
        clear()
    End Sub

    Private Sub cbx_shain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shain.SelectedIndexChanged
        clear()
    End Sub

    Private Sub clear()
        dgv_kensakukekka.Rows.Clear()
        lbl_kingaku.Text = ""
    End Sub
End Class