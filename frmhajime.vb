Public Class frmhajime

    Private Sub frmhajime_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' PictureBox1.Image = My.Resources.logo.ToBitmap()  '�V�K
        '�A�v���P�[�V���� �^�C�g��
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "SPSales" 'My.Application.Info.Title
        Else
            '�A�v���P�[�V���� �^�C�g�����Ȃ��ꍇ�́A�g���q�Ȃ��̃A�v���P�[�V���������g�p���܂�
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = "Version : " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision

        '���쌠���
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub lblshinkou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblshinkou.Click

    End Sub

    Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copyright.Click

    End Sub
End Class