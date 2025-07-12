Imports System.Data.SqlClient

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

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

        Dim result As String = MessageBox.Show("引継ぎ処理をしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then
            Exit Sub
        End If

        'kojinに郵便局初期FLGを追加
        Dim result2 As String = MessageBox.Show("「」をリサイずしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result2 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql As String = "ALTER TABLE kojin ADD yuubin_flg nchar(1) NULL;"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If


        ''kojinに郵便局初期FLGを追加
        'Dim result2 As String = MessageBox.Show("「yuubin_flg」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        'If result2 = DialogResult.Yes Then
        '    ' 接続文字列を環境に合わせて修正してください
        '    ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
        '    Using cn As New SqlConnection(connectionstring_sqlserver)
        '        cn.Open()
        '        Dim sql As String = "ALTER TABLE kojin ADD yuubin_flg nchar(1) NULL;"
        '        Using cmd As New SqlCommand(sql, cn)
        '            cmd.ExecuteNonQuery()
        '        End Using
        '    End Using
        'End If





        msg_go("終了しました。", 64)
    End Sub
End Class