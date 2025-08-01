Public Class frmseikyuu_rireki

    Private Sub frmseikyuu_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))
        Dim sakanobori_nensuu = 20

        cbx_nen.Items.Clear()
        For i = nen_ima - sakanobori_nensuu To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))

        cbx_tsuki.Items.Clear()
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))

        set_tenpo_cbx(3, chk_hihyouji_torihiki_nai.Checked)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "3"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

    End Sub

    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click

    End Sub

    Private Sub btn_clear_tenpo_Click(sender As Object, e As EventArgs) Handles btn_clear_tenpo.Click
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_cbx(3, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub chk_invoice_Click(sender As Object, e As EventArgs) Handles chk_invoice.Click
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub rbn_shubetsu_kikan_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_kikan.Click
        gbx_shiharai_tsuki.Enabled = True
        gbx_tenpo.Enabled = False
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_tenpo_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_tenpo.Click
        gbx_shiharai_tsuki.Enabled = False
        gbx_tenpo.Enabled = True
        cbx_tsuki.SelectedIndex = -1
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

End Class