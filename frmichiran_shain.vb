Imports System.Data.SqlClient

Public Class frmichiran_shain

    Private Sub frmichiran_shain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_shain_ichiran()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub

    Private Sub set_shain_ichiran()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Sql = "SELECT * FROM shain ORDER BY shainid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_shain_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_shain_ichiran")

            With dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 4

                .Columns(0).Name = "社員ID"
                .Columns(1).Name = "社員名"
                .Columns(2).Name = "略名"
                .Columns(3).Name = "在職"

                .Columns(0).Width = 75
                .Columns(1).Width = 150
                .Columns(2).Width = 100
                .Columns(3).Width = 75

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With

            Dim mojiretsu(10) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shainid"))

                If IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    mojiretsu(1) = ""
                Else
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("ryakumei")) Then
                    mojiretsu(2) = ""
                Else
                    mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("ryakumei"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("zaishoku")) Then
                    mojiretsu(3) = "不明"
                Else
                    If Trim(dt_server.Rows.Item(i).Item("zaishoku")) = "0" Then
                        mojiretsu(3) = "○"
                    Else
                        mojiretsu(3) = "×"
                    End If
                End If

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

End Class