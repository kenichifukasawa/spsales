Public Class frmbarcode
    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmbarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If barcodenono = 0 Then
            ltanka.text = "単価"
            lbltanka.Visible = True
            txtshiteikin.Visible = False
        Else
            ltanka.text = "仕入額"
            lbltanka.Visible = False
            txtshiteikin.Visible = True
        End If

    End Sub

    Private Sub frmbarcode_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtbaercode.Focus()

    End Sub

    Private Sub txtbaercode_TextChanged(sender As Object, e As EventArgs) Handles txtbaercode.TextChanged

    End Sub

    Private Sub txtbaercode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbaercode.KeyDown
        Dim kensakuber As String

        If e.KeyCode = Keys.Enter Then
            kensakuber = Trim(txtbaercode.Text)
            If kensakuber = "" Then
                lblshouhin1.text = ""
                Exit Sub
            End If



        End If
    End Sub

    Private Sub txtshiteikosuu_TextChanged(sender As Object, e As EventArgs) Handles txtshiteikosuu.TextChanged

    End Sub

    Private Sub txtshiteikosuu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtshiteikosuu.KeyDown
        If e.KeyCode = Keys.Enter Then
            If barcodenono = 0 Then
                Button1.PerformClick()
            Else
                txtshiteikin.Focus()
            End If
        End If
    End Sub

    Private Sub txtshiteikin_TextChanged(sender As Object, e As EventArgs) Handles txtshiteikin.TextChanged

    End Sub

    Private Sub txtshiteikin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtshiteikin.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class