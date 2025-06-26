Imports System.Data.SqlClient

Public Class frmichiran_yuubin_koushin
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_koushin_Click(sender As Object, e As EventArgs) Handles btn_koushin.Click

        Dim juusho = Trim(txt_juusho.Text)
        If juusho = "" Then
            msg_go("住所を入力してください。")
            Exit Sub
        End If

        Dim shousai = Trim(txt_shousai.Text)
        If shousai = "" Then
            msg_go("詳細を入力してください。")
            Exit Sub
        End If

        Dim yuubin_bangou = Trim(lbl_yuubin_bangou_kyuu.Text)
        If yuubin_bangou = "" Then
            msg_go("郵便番号が取得できませんでした。")
            Exit Sub
        End If

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM mailno_m WHERE mailno ='" + yuubin_bangou + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_mailno_m")

            ds.Tables("t_mailno_m").Rows(0)("adress1") = juusho
            ds.Tables("t_mailno_m").Rows(0)("shousai") = shousai

            Dim cb As New SqlCommandBuilder
            cb.DataAdapter = da
            da.Update(ds, "t_mailno_m")
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        msg_go("変更しました。", 64)

        Me.Close() : Me.Dispose()

    End Sub
End Class