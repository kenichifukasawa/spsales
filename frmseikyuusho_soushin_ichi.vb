Public Class frmseikyuusho_soushin_ichi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        seikyuusho_set()

    End Sub

    Private Sub frmseikyuusho_soushin_ichi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        seikyuusho_set()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If chkchuushi.Checked = False Then
            msg_go("「STを中止する」にレ点を入れてから、再度実行してください。")
            Exit Sub
        End If
        chkchuushi.Checked = False
        result = MessageBox.Show("STを中止に更新しますか？一度変更するともとに戻せなくなります。", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim n_id As String

        For i = 0 To dgrireki.Rows.Count - 1
            If dgrireki(0, i).Value = True Then

                n_id = Trim(dgrireki(7, i).Value)
                If n_id = "" Then
                    msg_go("中止する送信予約IDが不正です。")
                    Exit Sub
                End If


                'ST更新
                If st_koushin(n_id, "3") = -1 Then
                    'log_add("請求書のメール送信のステータスの更新に失敗しました。", "1")
                    msg_go("中止の処理に失敗しました。")
                    Exit Sub
                Else
                    'log_add("請求書の発送のステータスを更新しました。", "1")

                End If

            End If
        Next

        seikyuusho_set()

        msg_go("中止の処理が完了しました。", 64)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgrireki.Rows.Count = 0 Then
            msg_go("送信するファイルの一覧が表示されていません。")
            Exit Sub
        End If

        s_soushin_suu = 0
        Dim n_id As String


        For i = 0 To dgrireki.Rows.Count - 1
            If dgrireki(0, i).Value = True Then

                n_id = Trim(dgrireki(7, i).Value)
                If n_id = "" Then
                    msg_go("送信する送信予約IDが不正です。")
                    Exit Sub
                End If


                s_soushin_suu = s_soushin_suu + 1
                ReDim Preserve s_soushin_data(4, s_soushin_suu)
                s_soushin_data(0, s_soushin_suu - 1) = n_id
                s_soushin_data(1, s_soushin_suu - 1) = i.ToString
                s_soushin_data(2, s_soushin_suu - 1) = Trim(dgrireki(5, i).Value) 'mail
                s_soushin_data(3, s_soushin_suu - 1) = Trim(lblpath.Text) & "\" & Trim(dgrireki(6, i).Value) 'File

            End If
        Next

        Dim n_hi As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim n_jikan As String = DateTime.Now.ToString("HH:mm:ss")

        If s_soushin_suu = 0 Then
            msg_go("送信するファイルが選択されていません。")
            Exit Sub
        End If

        'チェック
        For i = 0 To s_soushin_suu - 1
            If s_soushin_data(2, i) = "" Then
                msg_go("送信しようとしている行に、送信設定にレ点がついていないか、メールアドレスが登録されていません。")
                Exit Sub
            End If

            If Dir(s_soushin_data(3, i)) = "" Then
                msg_go("送信しようとしている行の送信元ファイルが存在しません。")
                Exit Sub
            End If

        Next


        frmseikyuusho_soushin_log.Button1.Enabled = False

        frmseikyuusho_soushin_log.ShowDialog()


    End Sub
End Class