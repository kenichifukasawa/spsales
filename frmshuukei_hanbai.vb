Public Class frmshuukei_hanbai

    Private Sub frmshuukei_hanbai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")
        set_gyousha_kubun(1)
        set_shouhin_kubun_1(1)
        set_tenpo_name(1, chk_hihyouji_torihiki_nai.Checked)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If cbx_shitei_shouhin.SelectedIndex <> -1 Then
            cbx_shitei_shouhin.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_2.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_2.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_1.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_1.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_gyousha_kubun.SelectedIndex <> -1 Then
            cbx_gyousha_kubun.SelectedIndex = -1
            Exit Sub
        End If

    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

        ' TODO
        msg_go("未開発")
        Exit Sub

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("抽出結果が表示されていません。")
            Exit Sub
        End If

    End Sub

    Private Sub btn_denwa_chou_Click(sender As Object, e As EventArgs) Handles btn_denwa_chou.Click

    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2(1, shouhin_kubun_1_id)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim is_haiban = chk_haiban.Checked
        set_shitei_shouhin(1, shouhin_kubun_1_id, shouhin_kubun_2_id, is_haiban)
    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_name(1, chk_hihyouji_torihiki_nai.Checked)
    End Sub
End Class