Imports System.Data.SqlClient

Public Class frmichiran_shain

    Private Sub frmichiran_shain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_shain_ichiran()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

        With frmichiran_shain_koushin
            .Text = "登録"
            .btn_koushin.Text = "登録"
            .ShowDialog()
        End With
        set_shain_ichiran()

    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim shain_id = Trim(dgv_kensakukekka.CurrentRow.Cells(0).Value)
        Dim shain_mei = Trim(dgv_kensakukekka.CurrentRow.Cells(1).Value)
        Dim ryaku_mei = Trim(dgv_kensakukekka.CurrentRow.Cells(2).Value)
        Dim zaishoku = Trim(dgv_kensakukekka.CurrentRow.Cells(3).Value)
        Dim pw = Trim(dgv_kensakukekka.CurrentRow.Cells(4).Value)

        With frmichiran_shain_koushin
            .Text = "変更"
            .btn_koushin.Text = "変更"
            .lbl_shain_id.Text = shain_id
            .lbl_shain_mei.Text = shain_mei
            .txt_shain_mei.Text = shain_mei
            .lbl_shain_ryaku_mei.Text = ryaku_mei
            .txt_shain_ryaku_mei.Text = ryaku_mei
            .lbl_zaishoku.Text = zaishoku

            .lblpw.Text = pw
            .txtpw.Text = pw

            If zaishoku = "○" Then
                .chk_zaishoku.Checked = True
            End If
            .ShowDialog()
        End With

        set_shain_ichiran()

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            Exit Sub
        End If

        If chk_sakujo.Checked = False Then
            msg_go("「削除する」にチェックをつけてから実行してください。")
            Exit Sub
        End If
        chk_sakujo.Checked = False

        Dim shain_id = Trim(dgv_kensakukekka.CurrentRow.Cells(0).Value)
        Dim shain_mei = Trim(dgv_kensakukekka.CurrentRow.Cells(1).Value)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM tenpo WHERE shainid = '" + shain_id + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            Dim can_delete = True

            If dt_server.Rows.Count > 0 Then
                can_delete = False
            End If

            dt_server.Clear()
            ds_server.Clear()

            If Not can_delete Then
                msg_go("この社員は店舗情報で使用しているため、削除できません。")
                Exit Sub
            End If

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuu WHERE shainid = '" + shain_id + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_hacchuu")
            Dim dt_server As DataTable = ds_server.Tables("t_hacchuu")

            Dim can_delete = True

            If dt_server.Rows.Count > 0 Then
                can_delete = False
            End If

            dt_server.Clear()
            ds_server.Clear()

            If Not can_delete Then
                msg_go("この社員は納品書情報で使用しているため、削除できません。")
                Exit Sub
            End If

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

        Dim result As DialogResult = MessageBox.Show(
            "以下の社員を削除しますか？" + vbCrLf + vbCrLf + "社員ID：" + shain_id + vbCrLf + "社員名：" + shain_mei,
            "SpSales",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shain WHERE shainid ='" + shain_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_shain")

            If ds.Tables("t_shain").Rows.Count > 0 Then
                ds.Tables("t_shain").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_shain")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する社員が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        set_shain_ichiran()

    End Sub

    Private Sub set_shain_ichiran()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shain ORDER BY shainid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_shain_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_shain_ichiran")

            With dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 5

                .Columns(0).Name = "社員ID"
                .Columns(1).Name = "社員名"
                .Columns(2).Name = "略名"
                .Columns(3).Name = "在職"
                .Columns(4).Name = "パスワード"

                .Columns(0).Width = 75
                .Columns(1).Width = 160
                .Columns(2).Width = 110
                .Columns(3).Width = 75
                .Columns(4).Width = 90

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            End With

            Dim mojiretsu(10) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shainid"))

                If IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    mojiretsu(1) = ""
                Else
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("ryakumei")) Then
                    mojiretsu(2) = ""
                Else
                    mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("ryakumei"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("zaishoku")) Then
                    mojiretsu(3) = "不明"
                Else
                    If Trim(dt_server.Rows.Item(i).Item("zaishoku")) = "0" Then
                        mojiretsu(3) = "○"
                    Else
                        mojiretsu(3) = "×"
                    End If
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("password")) Then
                    mojiretsu(4) = ""
                Else
                    mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("password"))
                End If

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

End Class