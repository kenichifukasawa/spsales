Imports System.Data.SqlClient

Public Class frmichiran_yuubin
    Private Sub frmichiran_yuubin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_yuubin_ichiran()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        Dim yuubin_bangou = Trim(dgv_kensakukekka.CurrentRow.Cells(0).Value)
        Dim juusho = Trim(dgv_kensakukekka.CurrentRow.Cells(1).Value)
        Dim shousai = Trim(dgv_kensakukekka.CurrentRow.Cells(2).Value)

        With frmichiran_yuubin_koushin
            .Text = "変更"
            .btn_koushin.Text = "変更"
            .lbl_yuubin_bangou_kyuu.Text = yuubin_bangou
            .lbl_yuubin_bangou_shin.Text = yuubin_bangou
            .lbl_juusho.Text = juusho
            .txt_juusho.Text = juusho
            .lbl_shousai.Text = shousai
            .txt_shousai.Text = shousai
            .ShowDialog()
        End With

        set_yuubin_ichiran()

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        If chk_sakujo.Checked = False Then
            msg_go("「削除する」にチェックをつけてから実行してください。")
            Exit Sub
        End If
        chk_sakujo.Checked = False

        Dim yuubin_bangou = Trim(dgv_kensakukekka.CurrentRow.Cells(0).Value)
        Dim juusho = Trim(dgv_kensakukekka.CurrentRow.Cells(1).Value)
        Dim shousai = Trim(dgv_kensakukekka.CurrentRow.Cells(2).Value)

        Dim result As DialogResult = MessageBox.Show(
            "以下の郵便番号を削除しますか？" + vbCrLf + vbCrLf + "郵便番号：" + yuubin_bangou + vbCrLf + "住所：" + juusho + vbCrLf + "詳細：" + shousai,
            "SpSales",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM mailno_m WHERE mailno ='" + yuubin_bangou + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_mailno_m")

            If ds.Tables("t_mailno_m").Rows.Count > 0 Then
                ds.Tables("t_mailno_m").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_mailno_m")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する郵便番号が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        set_yuubin_ichiran()

    End Sub

    Private Sub txt_yuubin_bangou_TextChanged(sender As Object, e As EventArgs) Handles txt_yuubin_bangou.TextChanged
        set_yuubin_ichiran()
    End Sub

    Private Sub txt_juusho_TextChanged(sender As Object, e As EventArgs) Handles txt_juusho.TextChanged
        set_yuubin_ichiran()
    End Sub

    Private Sub set_yuubin_ichiran()

        Dim juusho = Trim(txt_juusho.Text)
        Dim yuubin_bangou = Trim(txt_yuubin_bangou.Text)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM mailno_m"

            Dim query_where = ""
            If juusho <> "" Then
                query_where = " WHERE adress1 LIKE '%" + juusho + "%'"
            End If

            If yuubin_bangou <> "" Then
                If query_where = "" Then
                    query_where = " WHERE mailno LIKE '%" + yuubin_bangou + "%'"
                Else
                    query_where += " AND mailno LIKE '%" + yuubin_bangou + "%'"
                End If
            End If

            query += query_where + " ORDER BY mailno"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_yuubin_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_yuubin_ichiran")

            With dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 3

                .Columns(0).Name = "郵便番号"
                .Columns(1).Name = "住所１"
                .Columns(2).Name = "詳細"

                .Columns(0).Width = 90
                .Columns(1).Width = 300
                .Columns(2).Width = 300

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            End With

            Dim mojiretsu(10) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("mailno"))
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("adress1"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shousai"))

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

End Class