Imports System.Data.SqlClient

Public Class frmshouhinkubun1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kubun1_id = Trim(txtkubunid.Text)
        If kubun1_id = "" Then
            msg_go("区分１IDを入力してください。")
            Exit Sub
        Else
            ' 数値変換
            Dim s_d As Double
            If Not Double.TryParse(kubun1_id, s_d) Then
                msg_go("数値で入力してください。")
                txtkubunid.Focus()
                Exit Sub
            Else
                If s_d >= 99 Then
                    msg_go("数値は９９までで入力してください。")
                    txtkubunid.Focus()
                    Exit Sub
                End If
            End If
            '2桁チェック
            If Len(kubun1_id) <> 2 Then
                msg_go("２ケタで入力してください。")
                txtkubunid.Focus()
                Exit Sub
            End If
        End If

        Dim kubun1_mei = Trim(txtkubunmei.Text)
        If kubun1_mei = "" Then
            msg_go("区分１名を入力してください。")
            Exit Sub
        End If

        Dim gyoushakubunid As String = Trim(lblkubunid.Text)

        If gyoushakubunid = "" Then

            'すでに登録済かのチェック
            If kubun_1_umu_chk(kubun1_id) <> "0" Then
                msg_go("この区分ＩＤは、すでに登録されています。")
                Exit Sub
            End If

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT TOP 1 * FROM shouhinkubun"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                da.Fill(ds, "t_shain")
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables("t_shain").NewRow()

                data_row("shouhinkubunid") = kubun1_id

                data_row("shouhinkubunmei") = kubun1_mei

                ds.Tables("t_shain").Rows.Add(data_row)
                da.Update(ds, "t_shain")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("登録しました。", 64)

        Else '変更

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM shouhinkubun WHERE shouhinkubunid ='" + gyoushakubunid + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                da.Fill(ds, "t_shain")

                ds.Tables("t_shain").Rows(0)("shouhinkubunmei") = kubun1_mei

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, "t_shain")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("変更しました。", 64)

        End If

        kubun_1_set()

        Me.Close() : Me.Dispose()

    End Sub
End Class