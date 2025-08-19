Public Class frmseikyuusho_hakkou_insatsu
    Private Sub frmseikyuusho_hakkou_insatsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_shimebi.Items.AddRange(Deadline.Names)
        cbx_shimebi.Items.Add("指定")

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))

        cbx_nen.Items.Clear()
        For i = STARTED_YEAR To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))

        cbx_tsuki.Items.Clear()
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))

        set_hinichi_cbx(1)
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(Now.ToString("dd"))

        dtp_hinichi.Value = Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "6"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        dgv_kensakukekka.Rows.Clear()
        cbx_shimebi.SelectedIndex = -1
        cbx_nen.SelectedIndex = -1
        cbx_tsuki.SelectedIndex = -1
    End Sub

    Private Sub btn_seikyuusho_sakusei_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_sakusei.Click

    End Sub

    Private Sub cbx_shimebi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shimebi.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        Dim hi = cbx_hi.Text
        dgv_kensakukekka.Rows.Clear()
        set_hinichi_cbx(0)
        cbx_hi.SelectedIndex = cbx_hi.FindStringExact(hi)
    End Sub

    Private Sub cbx_hi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_hi.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub dtp_hinichi_CloseUp(sender As Object, e As EventArgs) Handles dtp_hinichi.CloseUp
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_hi_hyouji_Click(sender As Object, e As EventArgs) Handles chk_hi_hyouji.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_lock_Click(sender As Object, e As EventArgs) Handles chk_lock.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub chk_mail_Click(sender As Object, e As EventArgs) Handles chk_mail.Click

    End Sub

    Private Sub chk_insatsu_shinai_Click(sender As Object, e As EventArgs) Handles chk_insatsu_shinai.Click

    End Sub

    Private Sub chk_houkokuyou_Click(sender As Object, e As EventArgs) Handles chk_houkokuyou.Click

    End Sub
End Class