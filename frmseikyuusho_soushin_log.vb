Public Class frmseikyuusho_soushin_log

    Private s_count As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Me.Dispose()

        frmseikyuusho_soushin_ichi.Button3.PerformClick()

    End Sub

    Private Sub frmseikyuusho_soushin_log_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmseikyuusho_soushin_log_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        log_add("請求書の発送処理を開始します。", "1")

        s_count = 0

        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If s_count <= 2 Then
            s_count = s_count + 1
            log_add("請求書の発送処理の開始を待機中します。", "1")
            Exit Sub
        End If

        Timer1.Stop()

        Dim path_all As String
        Dim s_mailadress2(0) As String
        Dim s_st As String

        '送信
        log_add("請求書のメールの準備中・・。", "1")

        For i = 0 To s_soushin_suu - 1
            log_add("請求書の発送を実施します。NO." & (i + 1).ToString, "1")

            s_mailadress2(0) = s_soushin_data(2, i)
            path_all = s_soushin_data(3, i)


            If SendMail(s_from, s_mailadress2, s_mailadress_cc, s_dai, s_honbun, path_all) = False Then
                log_add("請求書のメール送信に失敗しました。", "1")

                s_st = "1"
            Else
                log_add("請求書の発送しました。NO." & (i + 1).ToString, "1")
                s_st = "2"

            End If

            'ST更新
            If st_koushin(s_soushin_data(0, i), s_st, s_soushin_data(2, i)) = -1 Then
                log_add("請求書のメール送信のステータスの更新に失敗しました。", "1")
            Else
                log_add("請求書の発送のステータスを更新しました。", "1")
            End If



        Next

        log_add("処理が完了しました。", "1")

        Me.Button1.Enabled = True

    End Sub
End Class