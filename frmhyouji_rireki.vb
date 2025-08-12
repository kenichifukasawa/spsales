Imports System.Data.SqlClient

Public Class frmhyouji_rireki

    Private Sub frmhyouji_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_rireki()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("表示履歴をすべて削除してもいいですか？", "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using cn As New OleDb.OleDbConnection(connectionstring_mdb)
                cn.Open()
                Dim sql As String = "DELETE FROM rireki"
                Using cmd As New OleDb.OleDbCommand(sql, cn)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        msg_go("履歴ファイルがないか、読み込めません。したがって履歴が削除できません。")
                    Else
                    End If
                End Using
            End Using
        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        settei_res = Setting1(19, 1, "0", 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。")
            Exit Sub
        End If

        msg_go("履歴を削除しました。", 64)

        set_rireki()

    End Sub

    Private Sub dgv_kensakukekka_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kensakukekka.CellMouseDoubleClick

        Dim dgv = dgv_kensakukekka
        If dgv.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim tenpo_id = dgv.CurrentRow.Cells(0).Value
        mainset(tenpo_id)

        Me.Close() : Me.Dispose()

    End Sub

    Private Sub set_rireki()

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 3

            .Columns(0).Name = "店舗ID"
            .Columns(1).Name = "店舗名"
            .Columns(2).Name = "日時"

            .Columns(0).Width = 80
            .Columns(1).Width = 344
            .Columns(2).Width = 170

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Try
            Using cn As New OleDb.OleDbConnection(connectionstring_mdb)
                Dim query As String = "SELECT * FROM rireki ORDER BY junban DESC"
                Dim da As New OleDb.OleDbDataAdapter(query, cn)
                Dim ds As New DataSet()
                Dim tableName As String = "t_rireki"
                da.Fill(ds, tableName)
                Dim dt As DataTable = ds.Tables(tableName)

                Dim mojiretsu(2) As String
                For i = 0 To dt.Rows.Count - 1
                    mojiretsu(0) = Trim(dt.Rows(i).Item("kaishaid").ToString())
                    mojiretsu(1) = Trim(dt.Rows(i).Item("kaishamei").ToString())
                    mojiretsu(2) = ConvertToFormattedDateTime(Trim(dt.Rows(i).Item("junban").ToString()))
                    dgv_kensakukekka.Rows.Add(mojiretsu)
                Next

                dt.Clear()
                ds.Clear()
            End Using

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Function ConvertToFormattedDateTime(input As String) As String
        Try
            Dim dt As DateTime = DateTime.ParseExact(input, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture)
            Return dt.ToString("yyyy/MM/dd HH:mm:ss")
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

End Class