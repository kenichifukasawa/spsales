

Imports System.Data.SqlClient

Public Class frminfo


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

    Private Sub LogoPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles LogoPictureBox.DoubleClick


        Dim result As String = MessageBox.Show("引継ぎ処理をしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then
            Exit Sub
        End If


        '職員にパスワードを追加
        Dim result1 As String = MessageBox.Show("shokuinテーブルに「password」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result1 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql As String = "ALTER TABLE shain ADD password nchar(8) NULL;"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If

        '職員にdamiを追加
        Dim result4 As String = MessageBox.Show("shokuinテーブルに「nouhinsho_dami」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result4 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql As String = "ALTER TABLE shain ADD nouhinsho_dami nchar(1) NULL;"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If

        '発注に備考１２を追加
        Dim result2 As String = MessageBox.Show("hacchuuテーブルに「bikou1,2」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result2 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql As String = "ALTER TABLE hacchuu ADD bikou1 nchar(100) NULL, bikou2 nchar(100) NULL;"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If

        '発注にprint_shuruiを追加
        Dim result3 As String = MessageBox.Show("hacchuuテーブルに「print_shurui」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result3 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql As String = "ALTER TABLE hacchuu ADD print_shurui nchar(1) NULL;"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If



        msg_go("終了しました。", 64)

    End Sub
End Class