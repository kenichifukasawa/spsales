Imports System.Data.SqlClient

Public Class frmseikyuu_rireki_shousai

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_koushin_Click(sender As Object, e As EventArgs) Handles btn_koushin.Click

        Dim seikyuusho_id = Trim(lbl_seikyuusho_id.Text)
        Dim bikou = Trim(txt_bikou.Text)

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM seikyuusho WHERE seikyuushoid = '" + seikyuusho_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da.Fill(ds, temp_table_name)

            If bikou = "" Then
                ds.Tables(temp_table_name).Rows(0)("seikyuubikou") = DBNull.Value
            Else
                ds.Tables(temp_table_name).Rows(0)("seikyuubikou") = bikou
            End If

            Dim cb As New SqlCommandBuilder
            cb.DataAdapter = da
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        frmseikyuu_rireki.dgv_kensakukekka.CurrentRow.Cells(15).Value = bikou
        msg_go("備考を更新しました", 64)

    End Sub
End Class