Imports System.Data.SqlClient

Public Class frmshouhinkubun2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        Me.Dispose()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim s_kubun2_mei As String = Trim(txtkubun2mei.Text)

        If s_kubun2_mei = "" Then
            msg_go("区分２名を入力してください。")
            Exit Sub
        End If

        Dim s_kubun1id As String = ""

        If cmbkubun1.SelectedIndex <> -1 Then
            s_kubun1id = Mid(Trim(cmbkubun1.Text), 1, 2)
        Else
            msg_go("区分１を選択してください。")
            Exit Sub
        End If

        Dim s_kanriid As String = ""

        If cmbkanriid.SelectedIndex <> -1 Then
            s_kanriid = Trim(cmbkanriid.Text)
        End If

        Dim s_wella As String = ""

        Select Case cmbwella.SelectedIndex
            Case -1, 0
                s_wella = ""
            Case Else
                s_wella = (cmbwella.SelectedIndex - 1).ToString
        End Select


        Dim gyoushakubunid As String = Trim(lblkubun2id.Text)

        If gyoushakubunid = "" Then


            Dim id = 1
            Dim s_no = 9
            Dim ketasuu = 4
            Dim new_id = get_settings(id:=id, s_no:=s_no)
            Dim next_id As String
            If new_id = "" Then
                msg_go("IDの取得に失敗しました。")
                Exit Sub
            ElseIf new_id = "0" Then
                next_id = "2"
                new_id = 1.ToString("D" + ketasuu.ToString)
            Else
                next_id = (CLng(new_id) + 1).ToString
                new_id = new_id.ToString.PadLeft(ketasuu, "0"c)
            End If

            Dim response = update_settings(id:=id, s_no:=s_no, new_value:=next_id)
            If Not response Then
                msg_go("IDの更新に失敗しました。")
                Exit Sub
            End If

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT TOP 1 * FROM shouhinkubun2"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                da.Fill(ds, "t_gyousha")
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables("t_gyousha").NewRow()

                data_row("shouhinkubunid2") = new_id
                data_row("shouhinkubunmei2") = s_kubun2_mei
                data_row("shouhinkubunid") = s_kubun1id

                If s_kanriid <> "" Then
                    data_row("NARABE") = s_kanriid
                End If

                If s_wella <> "" Then
                    data_row("wella") = s_wella
                End If


                ds.Tables("t_gyousha").Rows.Add(data_row)
                da.Update(ds, "t_gyousha")
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

                Dim query = "SELECT * FROM shouhinkubun2 WHERE shouhinkubunid2 ='" + gyoushakubunid + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                da.Fill(ds, "t_gyousha")

                ds.Tables("t_gyousha").Rows(0)("shouhinkubunmei2") = s_kubun2_mei
                ds.Tables("t_gyousha").Rows(0)("shouhinkubunid") = s_kubun1id

                If s_kanriid = "" Then
                    ds.Tables("t_gyousha").Rows(0)("NARABE") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("NARABE") = s_kanriid
                End If

                If s_wella = "" Then
                    ds.Tables("t_gyousha").Rows(0)("wella") = DBNull.Value
                Else
                    ds.Tables("t_gyousha").Rows(0)("wella") = s_wella
                End If



                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, "t_gyousha")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("変更しました。", 64)

        End If

        If frmshouhinkubun.cmbkubun1.SelectedIndex <> -1 Then
            kubun_2_set(Mid(Trim(frmshouhinkubun.cmbkubun1.Text), 1, 2))
        End If

        Me.Close() : Me.Dispose()

    End Sub

    Private Sub frmshouhinkubun2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbkubun1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkubun1.SelectedIndexChanged


        cmbkanriid.Items.Clear()

        Dim narabestr As String
        Dim naraidid(100) As String

        If cmbkubun1.SelectedIndex <> -1 Then

            Dim s_kubun_id As String = Trim(Mid(Trim(cmbkubun1.Text), 1, 2))

            Try

                Sql = "SELECT * FROM shouhinkubun2 where shouhinkubunid = '" & s_kubun_id & "'  ORDER BY NARABE"

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver
                Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
                Dim ds_server As New DataSet
                Dim temp_table_name = "t_shoukaii"
                da_server.Fill(ds_server, temp_table_name)
                Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

                If dt_server.Rows.Count = 0 Then
                    For inarabe = 1 To 98
                        narabestr = inarabe.ToString("00")
                        cmbkanriid.Items.Add(narabestr)
                    Next
                Else
                    For i = 0 To dt_server.Rows.Count - 1
                        naraidid(CInt(Trim(dt_server.Rows.Item(i).Item("NARABE")))) = "1"
                    Next

                    For inarabe = 1 To 98
                        If naraidid(inarabe) <> "1" Then
                            narabestr = inarabe.ToString("00")
                            cmbkanriid.Items.Add(narabestr)
                        End If
                    Next

                End If


                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
            End Try


        End If


    End Sub

    Private Sub cmbkubun1_Click(sender As Object, e As EventArgs) Handles cmbkubun1.Click



    End Sub

    Private Sub txtkubun2mei_TextChanged(sender As Object, e As EventArgs) Handles txtkubun2mei.TextChanged

    End Sub

    Private Sub txtkubun2mei_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun2mei.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbkubun1.Focus()
        End If
    End Sub

    Private Sub cmbkanriid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkanriid.SelectedIndexChanged

    End Sub

    Private Sub cmbkanriid_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbkanriid.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbwella.Focus()
        End If
    End Sub

    Private Sub cmbwella_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbwella.SelectedIndexChanged

    End Sub

    Private Sub cmbwella_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbwella.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class