Imports System.Data.SqlClient

Public Class frmsettei
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = MessageBox.Show("コンバート処理をしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then
            Exit Sub
        End If

        'kojinに郵便局初期FLGを追加
        Dim result2 As String = MessageBox.Show("「shouhinkubun」のリサイズとコンバートをしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result2 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql1 As String = "ALTER TABLE shouhinkubun ALTER COLUMN shouhinkubunid nvarchar(3) NOT NULL;"
                Using cmd1 As New SqlCommand(sql1, cn)
                    cmd1.ExecuteNonQuery()
                End Using

                Dim sql2 As String = "ALTER TABLE shouhinkubun2 ALTER COLUMN shouhinkubunid nvarchar(3) NOT NULL;"
                Using cmd2 As New SqlCommand(sql2, cn)
                    cmd2.ExecuteNonQuery()
                End Using

                ' データをゼロ埋めで3桁に変換
                Dim sql12 As String = "UPDATE shouhinkubun SET shouhinkubunid = RIGHT('000' + code, 3);"
                Using cmd12 As New SqlCommand(sql12, cn)
                    cmd12.ExecuteNonQuery()
                End Using

                ' データをゼロ埋めで3桁に変換
                Dim sql22 As String = "UPDATE shouhinkubun2 SET shouhinkubunid = RIGHT('000' + code, 3);"
                Using cmd22 As New SqlCommand(sql22, cn)
                    cmd22.ExecuteNonQuery()
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

    Private Sub frmsettei_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class