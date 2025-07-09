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

        Dim s_kojinid As String = Trim(frmmain.lblkojinid.Text)

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
            Dim newid As String, newid2 As String

            newid = Trim(setting2(13, 0, "renban", ""))
            If newid = "-1" Then
                msg_go("IDの取得に失敗しました。再度実行してください。")
                Exit Sub
            ElseIf newid = "0" Then
                newid2 = "2"
                newid = "00000001"
            Else
                newid2 = (Cint(newid) + 1).ToString
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
                ret_rows("kojinid") = s_kojinid
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


        log_main_set(s_kojinid)


        Me.Close()
        Me.Dispose()


    End Sub
End Class