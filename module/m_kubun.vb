Imports System.Data.SqlClient

Module m_kubun

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

    Sub kubun_1_set()



    End Sub

End Module
