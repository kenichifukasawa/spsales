Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document

Public Class rp_seikyuusho2
    Private Sub rp_seikyuusho2_ReportStart(sender As Object, e As EventArgs) Handles Me.ReportStart
        With Me
            .fhakkoubi.Text = heder_data(1)
            .fseikyuushoid.Text = heder_data(2)
            .fmaisuu.Text = heder_data(3)

            .f1.Text = heder_data(4)
            .f2.Text = heder_data(5)
            .f3.Text = heder_data(6)
            .f4.Text = heder_data(7)
            .f5.Text = heder_data(8)
            .f6.Text = heder_data(9)
            .fsougoukei.Text = heder_data(10)

            .fmail.Text = heder_data(11)
            .fadress.Text = heder_data(12)
            .fmeishou.Text = heder_data(13)

            If s_tourokubangou <> "" Then
                .lbltourokubangou.Text = s_tourokubangou
            Else
                .lbltourokubangou.Text = ""
            End If
        End With
    End Sub

    Private Sub PageHeader_BeforePrint(sender As Object, e As EventArgs) Handles PageHeader.BeforePrint
        If CInt(Me.txtnow.Text) = 1 Then
            Me.f1.Visible = True
            Me.f2.Visible = True
            Me.f3.Visible = True
            Me.f4.Visible = True
            Me.f5.Visible = True
            Me.f6.Visible = True
            Me.fsougoukei.Visible = True
        Else
            Me.f1.Visible = False
            Me.f2.Visible = False
            Me.f3.Visible = False
            Me.f4.Visible = False
            Me.f5.Visible = False
            Me.f6.Visible = False
            Me.fsougoukei.Visible = False
        End If

    End Sub
End Class
