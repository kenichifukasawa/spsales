Public Class frmkosuu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmkosuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nyuuryokutekiyou = ""

        cmbtekiyou.Items.Clear()
        cmbtekiyou.Items.Add("ｻｰﾋﾞｽ")
        cmbtekiyou.Items.Add("ｻﾝ")
        cmbtekiyou.Items.Add("ｷｬﾝﾍﾟｰﾝ")
        cmbtekiyou.Items.Add("交換")
        cmbtekiyou.Items.Add("直送")
        cmbtekiyou.Items.Add("ｷﾞｬﾗﾘｰ")
        cmbtekiyou.Items.Add("あっぷる")

        cmbtekiyou.SelectedIndex = -1

        If frmmain.txtkubun1.Text = "99" Then
            txtkosuu.Text = "1"
            txtkosuu.Visible = False
            Label7.Text = "値引額"
            Label10.Visible = False
            lblzaiko.Visible = False
            Label6.Visible = False
        End If


    End Sub
End Class