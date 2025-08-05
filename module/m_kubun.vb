Imports System.Data.SqlClient

Module m_kubun

    Function kubun_1_umu_chk(s_kubun1_id As String) As String

        kubun_1_umu_chk = ""

        Try

            Sql = "SELECT * FROM shouhinkubun where shouhinkubunid = '" & s_kubun1_id & "' ORDER BY shouhinkubunid0"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count = 0 Then
                kubun_1_umu_chk = "0"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try


    End Function

    Function kubun_gyousha_umu_chk(s_kubun0id As String) As String

        kubun_gyousha_umu_chk = ""

        Try

            Sql = "SELECT * FROM shouhinkubun0 where shouhinkubunid0 = '" & s_kubun0id & "' ORDER BY shouhinkubunid0"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count = 0 Then
                kubun_gyousha_umu_chk = "0"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Function
    Sub kubun_gyousha_set()

        Try

            Sql = "SELECT * FROM shouhinkubun0  ORDER BY shouhinkubunid0"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            With frmshouhinkubun.dgv_kubun0

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 2

                .Columns(0).Name = "業者区分ID"
                .Columns(1).Name = "業者区分名"

                .Columns(0).Width = 90
                .Columns(1).Width = 150

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With


            Dim mojiretsu(2) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0"))
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0"))

                frmshouhinkubun.dgv_kubun0.Rows.Add(mojiretsu)

            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try


    End Sub

    Sub kubun_1_set2(s_no As Integer)

        Try

            Sql = "SELECT * FROM shouhinkubun  ORDER BY shouhinkubunid"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Select Case s_no
                Case 0
                    frmshouhinkubun2.cmbkubun1.Items.Clear()
            End Select

            Dim mojiretsu(2) As String, s_str As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid"))
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))


                s_str = mojiretsu(0) & "." & mojiretsu(1)

                Select Case s_no
                    Case 0
                        frmshouhinkubun2.cmbkubun1.Items.Add(s_str)
                End Select
            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Sub kubun_1_set()

        Try

            Sql = "SELECT * FROM shouhinkubun  ORDER BY shouhinkubunid"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            With frmshouhinkubun.dgv_kubun1

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 2

                .Columns(0).Name = "区分1ID"
                .Columns(1).Name = "区分1名"

                .Columns(0).Width = 90
                .Columns(1).Width = 150

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With

            frmshouhinkubun.cmbkubun1.Items.Clear()

            Dim mojiretsu(2) As String, s_str As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid"))
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))

                frmshouhinkubun.dgv_kubun1.Rows.Add(mojiretsu)

                s_str = mojiretsu(0) & "." & mojiretsu(1)
                frmshouhinkubun.cmbkubun1.Items.Add(s_str)
            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try


    End Sub

    Sub kubun_2_set(s_kubun_1 As String)

        Try

            Sql = "SELECT shouhinkubun2.*,shouhinkubun.shouhinkubunmei" &
                    " FROM shouhinkubun2 left join shouhinkubun" &
                    " on shouhinkubun2.shouhinkubunid=shouhinkubun.shouhinkubunid" &
                    " where shouhinkubun2.shouhinkubunid='" & s_kubun_1 & "'" &
                    " ORDER BY shouhinkubunid2"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            With frmshouhinkubun.dgv_kubun2

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 5

                .Columns(0).Name = "区分2ID"
                .Columns(1).Name = "区分2名"
                .Columns(2).Name = "区分1名"
                .Columns(3).Name = "区分管理ID"
                .Columns(4).Name = "Wella"

                .Columns(0).Width = 90
                .Columns(1).Width = 300
                .Columns(2).Width = 300
                .Columns(3).Width = 100
                .Columns(4).Width = 100

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With


            Dim mojiretsu(5) As String
            For i = 0 To dt_server.Rows.Count - 1
                If IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunid2")) Then
                    mojiretsu(0) = ""
                Else
                    mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid2"))
                End If
                If IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunmei2")) Then
                    mojiretsu(1) = ""
                Else
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                End If
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))
                If IsDBNull(dt_server.Rows.Item(i).Item("NARABE")) Then
                    mojiretsu(3) = ""
                Else
                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("NARABE"))
                End If
                If IsDBNull(dt_server.Rows.Item(i).Item("wella")) Then
                    mojiretsu(4) = ""
                Else
                    Select Case Trim(dt_server.Rows.Item(i).Item("wella"))
                        Case "0"
                            mojiretsu(4) = "ウエラ"
                        Case "1"
                            mojiretsu(4) = "セバスチャン"
                        Case Else
                            mojiretsu(4) = ""
                    End Select
                End If

                frmshouhinkubun.dgv_kubun2.Rows.Add(mojiretsu)

            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

End Module
