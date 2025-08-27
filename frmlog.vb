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

        Dim table_name = "log"
        If log_id = "" Then

            Dim id = 1
            Dim s_no = 18
            Dim ketasuu = 10
            Dim new_id = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)
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

                Dim query = "SELECT TOP 1 * FROM " + table_name

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

                Sql = "SELECT * FROM " + table_name + " WHERE log_id = '" + log_id + "'"

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

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        Dim frm = frmmain
        Dim shain_id As String = Trim(frm.lblshokuinid.Text)
        If shain_id = "" Then
            msg_go("社員IDが取得できませんでした。")
            Exit Sub
        End If

        Dim log_id As String = Trim(lbl_log_id.Text)
        Dim youken As String = Trim(frm.dgv_log.CurrentRow.Cells(4).Value.ToString)

        Dim result As String = MessageBox.Show("削除しますか？" + vbCrLf + vbCrLf + "【内容】" + vbCrLf + youken, "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT TOP 1 * FROM log WHERE log_id = '" + log_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_log"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count = 0 Then
                msg_go("該当する店舗が見つかりません")
                ds.Clear()
                Exit Sub
            End If

            Dim table = ds.Tables(temp_table_name)

            table.Rows(0)("del") = shain_id + Now.ToString("yyyyMMddHHmmss")

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        msg_go("削除しました。", 64)

        log_main_set(Trim(frm.lbltenpoid.Text))

        Me.Close() : Me.Dispose()

    End Sub

    Private Sub lbl_log_id_TextChanged(sender As Object, e As EventArgs) Handles lbl_log_id.TextChanged
        If Trim(lbl_log_id.Text) <> "" Then
            btn_sakujo.Visible = True
        End If
    End Sub

    Private Sub lbl_del_TextChanged(sender As Object, e As EventArgs) Handles lbl_del.TextChanged
        If Trim(lbl_del.Text) <> "" Then
            btn_sakujo.Enabled = False
        End If
    End Sub
End Class