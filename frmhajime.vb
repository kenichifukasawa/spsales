Public Class frmhajime

    Private Sub frmhajime_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' PictureBox1.Image = My.Resources.logo.ToBitmap()  '新規
        'アプリケーション タイトル
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "SPSales" 'My.Application.Info.Title
        Else
            'アプリケーション タイトルがない場合は、拡張子なしのアプリケーション名を使用します
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = "Version : " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision

        '著作権情報
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub lblshinkou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblshinkou.Click

    End Sub

    Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copyright.Click

    End Sub
End Class