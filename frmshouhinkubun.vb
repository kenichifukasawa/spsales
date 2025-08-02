Public Class frmshouhinkubun
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmshouhinkubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kubun_gyousha_set()

        kubun_1_set()

    End Sub

    Private Sub cmbkubun1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkubun1.SelectedIndexChanged

        If cmbkubun1.SelectedIndex <> -1 Then
            kubun_2_set(Mid(Trim(cmbkubun1.Text), 1, 2))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        frmshouhinkubun0.ShowDialog()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        '選択
        If Me.dgv_kubun0.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim sentakuid As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(0).Value.ToString)
        Dim sentakumei As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(1).Value.ToString)

        With frmshouhinkubun0

            .lblkubun0id.Text = sentakuid
            .txtkubun0id.Text = sentakuid
            .txtkubun0id.Enabled = False
            .lblkubun0mei.Text = sentakumei
            .txtkubun0mei.Text = sentakumei


            .ShowDialog()
        End With
    End Sub
End Class