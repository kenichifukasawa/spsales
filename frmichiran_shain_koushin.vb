Imports System.Data.SqlClient

Public Class frmichiran_shain_koushin
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_koushin_Click(sender As Object, e As EventArgs) Handles btn_koushin.Click

        Dim shain_mei = Trim(txt_shain_mei.Text)
        If shain_mei = "" Then
            msg_go("社員名を入力してください。")
            Exit Sub
        End If

        Dim shain_ryaku_mei = Trim(txt_shain_ryaku_mei.Text)
        If shain_ryaku_mei = "" Then
            msg_go("社員略名を入力してください。")
            Exit Sub
        End If

        Dim shain_pw = Trim(txtpw.Text)
        If shain_pw = "" Then
            msg_go("パスワードを入力してください。")
            Exit Sub
        End If

        Dim zaishoku = "1"
        If chk_zaishoku.Checked Then
            zaishoku = "0"
        End If

        If Trim(btn_koushin.Text).IndexOf("登録") <> -1 Then

            Dim id = 1
            Dim s_no = 5
            Dim ketasuu = 2
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

                Dim query = "SELECT * FROM shain"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                da.Fill(ds, "t_shain")
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables("t_shain").NewRow()

                data_row("shainid") = new_id

                If shain_mei <> "" Then
                    data_row("shainmei") = shain_mei
                End If

                If shain_ryaku_mei <> "" Then
                    data_row("ryakumei") = shain_ryaku_mei
                End If

                If zaishoku <> "" Then
                    data_row("zaishoku") = zaishoku
                End If

                data_row("password") = shain_pw

                ds.Tables("t_shain").Rows.Add(data_row)
                da.Update(ds, "t_shain")
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            msg_go("登録しました。", 64)

        Else '変更

            Dim shain_id = Trim(lbl_shain_id.Text)
            If shain_id = "" Then
                msg_go("社員IDを取得できませんでした。")
                Exit Sub
            End If

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM shain WHERE shainid ='" + shain_id + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                da.Fill(ds, "t_shain")

                ds.Tables("t_shain").Rows(0)("shainmei") = shain_mei

                If shain_ryaku_mei = "" Then
                    ds.Tables("t_shain").Rows(0)("ryakumei") = DBNull.Value
                Else
                    ds.Tables("t_shain").Rows(0)("ryakumei") = shain_ryaku_mei
                End If

                If zaishoku = "" Then
                    ds.Tables("t_shain").Rows(0)("zaishoku") = DBNull.Value
                Else
                    ds.Tables("t_shain").Rows(0)("zaishoku") = zaishoku
                End If

                ds.Tables("t_shain").Rows(0)("password") = shain_pw

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

        Me.Close() : Me.Dispose()

    End Sub
End Class