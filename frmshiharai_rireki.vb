Public Class frmshiharai_rireki

    Private Sub frmshiharai_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        set_gyousha_cbx(2, chk_hyouji_subete_gyousha.Checked)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub

    Private Sub btn_clear_gyousha_Click(sender As Object, e As EventArgs) Handles btn_clear_gyousha.Click
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_shiharai_tsuki_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_shiharai_tsuki.Click
        gbx_shiharai_tsuki.Enabled = True
        gbx_gyousha.Enabled = False
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_gyousha_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_gyousha.Click
        gbx_shiharai_tsuki.Enabled = False
        gbx_gyousha.Enabled = True
        cbx_tsuki.SelectedIndex = -1
    End Sub

    Private Sub chk_hyouji_subete_gyousha_Click(sender As Object, e As EventArgs) Handles chk_hyouji_subete_gyousha.Click
        set_gyousha_cbx(2, chk_hyouji_subete_gyousha.Checked)
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_gyousha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gyousha.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub
End Class