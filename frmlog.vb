Imports System.Data.SqlClient

Public Class frmlog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim newitsu As String = DateTime.Now.ToString("yyyyMMdd")
        Dim newnanji As String = DateTime.Now.ToString("HHmm")

        Dim s_log As String = Trim(txtlog.Text)
        If s_log = "" Then
            msg_go("ログが入力されていません。再度実行してください。")
            Exit Sub
        End If

        Dim s_tenpoid As String = Trim(frmmain.lbltenpoid.Text)

        Dim s_id As String = Trim(lblid.Text)

        Dim s_tantou As String = Trim(lbltantoushamei.Text)


        Dim s_houhou As String = ""
        If cmbkubun2.SelectedIndex = -1 Then
            msg_go("種類が選択されていません。再度実行してください。")
            Exit Sub
        Else
            s_houhou = cmbkubun2.SelectedIndex.ToString
        End If

        Dim s_st As String = ""
        If cmbst.SelectedIndex = 0 Then
            s_st = "0"
        Else
            s_st = "1"
        End If

        If s_id = "" Then
            Dim newid As String, newid2 As String, settei2_res As String

            newid = Trim(setting2(13, 0, "renban", ""))
            If newid = "-1" Then
                msg_go("IDの取得に失敗しました。再度実行してください。")
                Exit Sub
            ElseIf newid = "0" Then
                newid2 = "2"
                newid = "00000001"
            Else
                newid2 = (CInt(newid) + 1).ToString
                newid = newid.ToString.PadLeft(8, "0"c)
            End If

            settei2_res = setting2(13, 1, "renban", newid2)
            If settei2_res = "-1" Then
                msg_go("IDの更新に失敗しました。再度実行してください。")
                Exit Sub
            End If


            Try


                Dim cn_server As New SqlConnection

                'cn_server.ConnectionString = connectionstring_sqlserver.ConnectionString
                cn_server.ConnectionString = connectionstring_sqlserver

                sql = "SELECT TOP 1 * FROM log"

                Dim da_server As SqlDataAdapter

                da_server = New SqlDataAdapter(sql, cn_server)

                Dim ds_server As New DataSet

                da_server.Fill(ds_server, "t_jm_s")

                Dim s_comr As SqlClient.SqlCommandBuilder

                s_comr = New SqlClient.SqlCommandBuilder(da_server)

                Dim ret_rows As DataRow

                ret_rows = ds_server.Tables("t_jm_s").NewRow()

                ret_rows("logid") = newid
                ret_rows("kojinid") = s_tenpoid
                ret_rows("nichiji") = newitsu
                ret_rows("jikan") = newnanji
                ret_rows("tantou") = s_tantou
                ret_rows("youken") = s_log
                ret_rows("sakujo") = "0"
                ret_rows("kekka") = "0"
                'ret_rows("dare") = ""
                'ret_rows("saki") = s_cl
                ret_rows("houhou") = s_houhou

                ds_server.Tables("t_jm_s").Rows.Add(ret_rows)

                da_server.Update(ds_server, "t_jm_s")

                ds_server.Clear()


                msg_go("データを登録しました。", 64)


            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try
        Else

            Dim cn_shounin As New SqlConnection
            Dim da_shounin As New SqlDataAdapter
            Dim ds_shounin As New DataSet

            Dim cmdbuilder_shounin As New SqlCommandBuilder


            Try


                cn_shounin.ConnectionString = connectionstring_sqlserver

                sql = "select * from log where logid ='" & s_id & "'"



                da_shounin = New SqlDataAdapter(sql, cn_shounin)

                da_shounin.Fill(ds_shounin, "t_jouhouhens")


                '書き込み

                ds_shounin.Tables("t_jouhouhens").Rows(0)("youken") = s_log

                'ds_shounin.Tables("t_jouhouhens").Rows(0)("sakujo") = s_st
                ds_shounin.Tables("t_jouhouhens").Rows(0)("kekka") = s_st
                ds_shounin.Tables("t_jouhouhens").Rows(0)("houhou") = s_houhou
                '  ds_shounin.Tables("t_jouhouhens").Rows(0)("tantou") = s_tantou


                cmdbuilder_shounin.DataAdapter = da_shounin

                da_shounin.Update(ds_shounin, "t_jouhouhens")

                ds_shounin.Clear()
            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try


        End If


        log_main_set(s_tenpoid)


        Me.Close()
        Me.Dispose()


    End Sub

    Sub log_main_set(s_tenpoid As String, Optional s_del As String = "")

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver

            If s_del = "1" Then
                Sql = "SELECT * FROM log WHERE tenpoid ='" & s_tenpoid & "'  order by logid desc"
            Else
                Sql = "SELECT * FROM log WHERE tenpoid ='" & s_tenpoid & "' and sakujo ='0' order by logid desc"
            End If



            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(8) As String

            With frmmain.dgv_log

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 7
                .Columns(0).Name = "ID"
                .Columns(1).Name = "日時"
                .Columns(2).Name = "担当"
                .Columns(3).Name = "区分"
                .Columns(4).Name = "内容"
                .Columns(5).Name = "状況"
                .Columns(6).Name = "削"
                .Columns(0).Width = 0
                .Columns(1).Width = 120
                .Columns(2).Width = 70
                .Columns(3).Width = 70
                .Columns(4).Width = 550
                .Columns(5).Width = 60
                .Columns(6).Width = 50

                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With


            For i = 0 To dt_server.Rows.Count - 1
                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("logid"))
                mojiretsu(1) = Mid(Trim(dt_server.Rows.Item(i).Item("nichiji")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("nichiji")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("nichiji")), 7, 2)
                mojiretsu(1) = mojiretsu(1) & " " & Mid(Trim(dt_server.Rows.Item(i).Item("jikan")), 1, 2) & ":" & Mid(Trim(dt_server.Rows.Item(i).Item("jikan")), 3, 2)

                If IsDBNull(dt_server.Rows.Item(i).Item("tantou")) Then
                    mojiretsu(2) = ""
                Else
                    mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("tantou"))
                End If
                Select Case Trim(dt_server.Rows.Item(i).Item("houhou"))
                    Case "0"
                        mojiretsu(3) = "TV"
                    Case "1"
                        mojiretsu(3) = "NET"
                    Case "2"
                        mojiretsu(3) = "STB"
                    Case "3"
                        mojiretsu(3) = "CL"
                    Case "4"
                        mojiretsu(3) = "MVNO"
                    Case "5"
                        mojiretsu(3) = "料金"
                    Case "6"
                        mojiretsu(3) = "口座"
                    Case "7"
                        mojiretsu(3) = "その他"
                    Case Else
                        mojiretsu(3) = ""
                End Select
                If IsDBNull(dt_server.Rows.Item(i).Item("youken")) Then
                    mojiretsu(4) = ""
                Else
                    mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("youken"))
                End If
                Select Case Trim(dt_server.Rows.Item(i).Item("kekka"))
                    Case "1"
                        mojiretsu(5) = "終了"
                    Case Else
                        mojiretsu(5) = "稼働"
                End Select
                If IsDBNull(dt_server.Rows.Item(i).Item("sakujo")) Then
                    mojiretsu(6) = ""
                Else
                    If Trim(dt_server.Rows.Item(i).Item("sakujo")) = "1" Then
                        mojiretsu(6) = "削"
                    Else
                        mojiretsu(6) = ""
                    End If
                End If


                frmmain.dgv_log.Rows.Add(mojiretsu)
            Next i
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)

        End Try

    End Sub
End Class