Imports System.Data.SqlClient

Public Class frmshouhinkubun
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmshouhinkubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kubun_gyousha_set()

        kubun_1_set()

    End Sub

    Private Sub cmbkubun1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkubun1.SelectedIndexChanged

        If cmbkubun1.SelectedIndex <> -1 Then
            kubun_2_set(Mid(Trim(cmbkubun1.Text), 1, 2))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        frmshouhinkubun0.ShowDialog()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        '選択
        If Me.dgv_kubun0.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim sentakuid As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(0).Value.ToString)
        Dim sentakumei As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(1).Value.ToString)

        With frmshouhinkubun0

            .lblkubun0id.Text = sentakuid
            .txtkubun0id.Text = sentakuid
            .txtkubun0id.Enabled = False
            .lblkubun0mei.Text = sentakumei
            .txtkubun0mei.Text = sentakumei


            .ShowDialog()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        frmshouhinkubun1.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '選択
        If Me.dgv_kubun1.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim sentakuid As String = Trim(Me.dgv_kubun1.CurrentRow.Cells(0).Value.ToString)
        Dim sentakumei As String = Trim(Me.dgv_kubun1.CurrentRow.Cells(1).Value.ToString)

        With frmshouhinkubun1

            .lblkubunid.Text = sentakuid
            .txtkubunid.Text = sentakuid
            .txtkubunid.Enabled = False
            .lblkubunmei.Text = sentakumei
            .txtkubunmei.Text = sentakumei


            .ShowDialog()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        '  If cmbkubun1.SelectedIndex =

        With frmshouhinkubun2
            .cmbwella.Items.Clear()
            .cmbwella.Items.Add("なし")
            .cmbwella.Items.Add("ウエラ")
            .cmbwella.Items.Add("セバスチャン")


            kubun_1_set2(0)

            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '選択
        If Me.dgv_kubun0.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim sentakuid As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(0).Value.ToString)
        Dim sentakumei As String = Trim(Me.dgv_kubun0.CurrentRow.Cells(1).Value.ToString)

        Dim result As DialogResult = MessageBox.Show(
            "以下の業者区分を削除しますか？" + vbCrLf + vbCrLf + "業者区分ID：" + sentakuid + vbCrLf + "業者区分名：" + sentakumei,
            "SpSales",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        'すでに使用されているかのチェック
        'If kubun_1_umu_chk() = "1" Then


        'End If
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun0 WHERE shouhinkubunid0 ='" + sentakuid + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_gyousha")

            If ds.Tables("t_gyousha").Rows.Count > 0 Then
                ds.Tables("t_gyousha").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_gyousha")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する業者区分が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        kubun_gyousha_set()


    End Sub
End Class