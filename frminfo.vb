

Public Class frminfo
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmsettei.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frmichi.ShowDialog()

    End Sub

    Private Sub frminfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' フォームのタイトルを設定します。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("{0} のバージョン情報", ApplicationTitle)
        ' バージョン情報ボックスに表示されたテキストをすべて初期化します。
        ' TODO: [プロジェクト] メニューの下にある [プロジェクト プロパティ] ダイアログの [アプリケーション] ペインで、アプリケーションのアセンブリ情報をカスタマイズします。
        Me.ApplicationTitle.Text = "SpSales" ' My.Application.Info.ProductName
        Me.Version.Text = String.Format("バージョン {0}", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision)
        Me.Copyright.Text = My.Application.Info.Copyright
        ' Me.LogoPictureBox.Image = My.Resources.logo.ToBitmap()  'ロゴ



    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim version_up_exe = sougou_path & "\spsales_versionup.exe"


        If Dir(version_up_exe) = "" Then
            msg_go("spsales_versionup.exeファイルが見つかりません。")
            System.Windows.Forms.Application.DoEvents()
            Exit Sub
        End If


        Dim p2 As System.Diagnostics.Process = System.Diagnostics.Process.Start(version_up_exe)


    End Sub
End Class