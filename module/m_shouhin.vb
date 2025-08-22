Imports System.Data.SqlClient

Module m_shouhin


    Sub shouhin_chk(s_no As String, kensakuber As String)



        Try

            Sql = "SELECT * FROM shouhin where barcode='" & kensakuber & "'"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count = 0 Then
                msg_go("このバーコードは登録されていません。")

                If s_no = "" Then
                    With frmbarcode
                        .lblshouhin1.Text = ""
                        .lbltanka.Text = ""
                        .txtbaercode.Text = ""
                        .lblkeigen.Text = ""
                        .txtbaercode.Focus()
                    End With
                Else


                End If

            Else
                If dt_server.Rows.Count >= 2 Then
                    Dim s_err_msg As String = ""
                    For i = 0 To dt_server.Rows.Count - 1
                        If s_err_msg = "" Then
                            s_err_msg = Trim(dt_server.Rows.Item(0).Item("shouhinkubunid"))
                        Else
                            s_err_msg = s_err_msg & "," & Trim(dt_server.Rows.Item(0).Item("shouhinkubunid"))
                        End If
                    Next
                    msg_go("このバーコードは、2つ以上登録されています。確認して下さい。" & Chr(13) & Chr(13) & s_err_msg)
                End If



                If s_no = "" Then
                    With frmbarcode
                        .lblshouhin1.Text = Trim(dt_server.Rows.Item(0).Item("shouhinkubunid")) & " " & Trim(dt_server.Rows.Item(0).Item("shouhinkubunmei"))
                        .lbltanka.Text = Trim(dt_server.Rows.Item(0).Item("kakaku"))
                        If IsDBNull(dt_server.Rows.Item(0).Item("keigen_s")) Then
                            .lblkeigen.Text = ""
                        Else
                            .lblkeigen.Text = Trim(dt_server.Rows.Item(0).Item("keigen_s"))
                        End If

                        .txtshiteikosuu.Focus()
                    End With
                Else


                End If
            End If



            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try



    End Sub




End Module
