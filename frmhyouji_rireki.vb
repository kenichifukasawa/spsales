Public Class frmhyouji_rireki

    Private Sub frmhyouji_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 2

            .Columns(0).Name = "店舗ID"
            .Columns(1).Name = "店舗名"

            .Columns(0).Width = 90
            .Columns(1).Width = 500

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With



        ' ----------------------------------------------------------


    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click



        ' ----------------------------------------------------------

        '        Dim settei_res3 As String, sql_rirekisakujo As String, rs_rirekisakujo As New ADODB.Recordset
        '        Dim res_sa

        '        res_sa = MsgBox("削除してもいいですか？", vbYesNo)
        '        If res_sa = vbNo Then
        '            Exit Sub
        '        End If
        '        'On Error GoTo errrirekisakujo
        '        'データベースオープン
        '        data_r_open
        '        'トランジット開始
        '        cnn_r.BeginTrans
        '        '履歴テーブルを削除
        '        sql_rirekisakujo = "select * from rireki"
        '        rs_rirekisakujo.CursorType = adOpenDynamic
        '        rs_rirekisakujo.LockType = adLockOptimistic
        '        rs_rirekisakujo.Open sql_rirekisakujo, cnn_r
        '    If rs_rirekisakujo.RecordCount = 0 Then
        '            ret = MsgBox("履歴ファイルがないか、読み込めません。履歴が削除されていません。", 16, "総合管理システム「SPSALES」")
        '            cnn_r.Close
        '            Exit Sub
        '        Else
        '            rs_rirekisakujo.MoveFirst
        '            Do Until rs_rirekisakujo.EOF
        '                rs_rirekisakujo.Delete
        '                rs_rirekisakujo.MoveNext
        '            Loop
        '            rs_rirekisakujo.Close
        '        End If
        '        '履歴IDを削除
        '        settei_res3 = setting(0, 19, 1, "0", 0)
        '        Select Case settei_res3
        '            Case "-1"
        '                ret = MsgBox("設定ファイルがないか、読み込めません。履歴が削除されていません。", 16, "総合管理システム「SPSALES」")
        '                cnn_r.RollbackTrans
        '                cnn_r.Close
        '                Exit Sub
        '        End Select

        '        'コミットする
        '        cnn_r.CommitTrans
        '        'On Error GoTo 0
        '        cnn_r.Close
        '        'グリッドを削除
        '        rirekiset
        '        ret = MsgBox("履歴を削除しました。", 64, "総合管理システム「SPSALES」")

        '        Exit Sub

        'errrirekisakujo:
        '        ret = MsgBox("履歴情報の削除に失敗しました。", 48, "総合管理システム「SPSALES」")
        '        cnn_r.RollbackTrans
        '        cnn_r.Close
        '        Exit Sub

    End Sub

    Private Sub dgv_kensakukekka_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kensakukekka.CellMouseDoubleClick

        Dim dgv = dgv_kensakukekka
        If dgv.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim tenpo_id = dgv.CurrentRow.Cells(0).Value
        mainset(tenpo_id)

        Me.Close() : Me.Dispose()

    End Sub
End Class