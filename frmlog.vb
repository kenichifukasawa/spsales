Imports System.Data.SqlClient

Public Class frmlog

    Private Sub frmlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

        If cbx_log_kubun.SelectedIndex = -1 Then
            msg_go("種類を選択してください。")
            Exit Sub
        End If
        Dim category_id As String = LogCategory.GetIdByName(cbx_log_kubun.Text)

        If cbx_status.SelectedIndex = -1 Then
            msg_go("状況を選択してください。")
            Exit Sub
        End If
        Dim status_id As String = LogStatus.GetIdByName(cbx_status.Text)

        Dim youken As String = Trim(txtlog.Text)
        If youken = "" Then
            msg_go("内容を入力してください。")
            Exit Sub
        End If

        Dim log_id As String = Trim(lbl_log_id.Text)
        Dim tenpo_id As String = Trim(frmmain.lbltenpoid.Text)
        Dim shain_id As String = Trim(frmmain.lblshokuinid.Text)
        Dim newitsu As String = DateTime.Now.ToString("yyyyMMdd")
        Dim newnanji As String = DateTime.Now.ToString("HHmmss")

        If log_id = "" Then

            Dim id = 1 ' TODO
            Dim s_no = 18 ' TODO
            Dim ketasuu = 10
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

                Dim sc As New SqlConnection
                sc.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT TOP 1 * FROM log"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, sc)
                Dim ds As New DataSet
                Dim temp_table_name = "t_log"
                da.Fill(ds, temp_table_name)
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

                data_row("log_id") = new_id
                data_row("tenpoid") = tenpo_id
                data_row("kubun_id") = category_id
                data_row("st_id") = status_id
                data_row("youken") = youken
                data_row("itsu") = newitsu
                data_row("nanji") = newnanji
                data_row("shainid") = shain_id

                ds.Tables(temp_table_name).Rows.Add(data_row)

                da.Update(ds, temp_table_name)
                ds.Clear()

                msg_go("データを登録しました。", 64)

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        Else

            Try

                Dim sc As New SqlConnection
                sc.ConnectionString = connectionstring_sqlserver

                Sql = "SELECT * FROM log WHERE log_id = '" + log_id + "'"

                Dim sda As New SqlDataAdapter
                sda = New SqlDataAdapter(Sql, sc)
                Dim ds As New DataSet
                Dim temp_table_name = "t_log"
                sda.Fill(ds, temp_table_name)
                Dim dt = ds.Tables(temp_table_name)

                If dt.Rows.Count = 0 Then
                    msg_go("更新に失敗しました。")
                    ds.Clear()
                    Exit Sub
                End If

                Dim row = dt.Rows(0)

                row("kubun_id") = category_id
                row("st_id") = status_id
                row("youken") = youken

                Dim cmdbuilder_shounin As New SqlCommandBuilder
                cmdbuilder_shounin.DataAdapter = sda
                sda.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        End If

        log_main_set(tenpo_id)

        Me.Close()
        Me.Dispose()

    End Sub

End Class