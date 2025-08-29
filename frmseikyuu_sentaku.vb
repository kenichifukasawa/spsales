Public Class frmseikyuu_sentaku
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_hakkou_insatsu_Click(sender As Object, e As EventArgs) Handles btn_hakkou_insatsu.Click
        Me.Close() : Me.Dispose()
        With frmseikyuusho_hakkou_insatsu
            .chk_mail.Checked = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_hakkou_pdf_Click(sender As Object, e As EventArgs) Handles btn_hakkou_pdf.Click
        Me.Close() : Me.Dispose()
        With frmseikyuusho_hakkou_insatsu
            .chk_mail.Checked = True
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_rireki_Click(sender As Object, e As EventArgs) Handles btn_rireki.Click
        Me.Close() : Me.Dispose()
        frmseikyuu_rireki.ShowDialog()
    End Sub

    Private Sub btn_shuukin_hyou_Click(sender As Object, e As EventArgs) Handles btn_shuukin_hyou.Click
        Me.Close() : Me.Dispose()
        frmseikyuu_shuukin_hyou.ShowDialog()
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click



        ' ----------------------------------------------------------

        'Dim rs_chk As New ADODB.Recordset
        'Dim rs_saikyu2 As ADODB.Recordset
        'Dim rs_chk2 As ADODB.Recordset

        'Dim log_flg = False
        'If chklog.Checked Then
        '    log_write("請求前チェックの開始********************************************")
        '    log_flg = True
        'End If

        'Dim sql_chk As String = "select * from tenpo order by tenpoid"

        'If FcSQlGet(1, rs_chk, sql_chk, WMsg) = False Then
        '    msg_go("チェックしたいデータが存在しません。")
        '    If log_flg Then
        '        log_write("請求前チェックの終了********************************************")
        '    End If
        '    Exit Sub
        'End If

        'rs_chk.MoveFirst
        'Do Until rs_chk.EOF

        '    'If tochuu_stop = 1 Then
        '    '    log_write("請求前チェックのSTOP********************************************")
        '    '    Exit Sub
        '    'End If

        '    Dim sql_chk2 As String = "SELECT seikyuusho.*, tenpo.tenpomei, tenpo.tenpofurigana FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
        '        " WHERE seikyuusho.tenpoid = '" + rs_chk!tenpoid + "' AND seikyuusho.seikyuu_st = '0' ORDER BY seikyuusho.hiduke, tenpo.tenpofurigana"

        '    'Set rs_chk2 = New ADODB.Recordset
        '    If FcSQlGet(0, rs_chk2, sql_chk2, WMsg) = True Then

        '        rs_chk2.MoveFirst

        '        Dim iconter2 As Long = 1
        '        Do Until rs_chk2.EOF

        '            Dim ato_data As Long
        '            Dim mae_data As Long
        '            If iconter2 = 1 Then
        '                mae_data = rs_chk2!seikyuukingaku
        '                ato_data = mae_data
        '            Else
        '                ato_data = rs_chk2!kuri
        '            End If

        '            If ato_data <> mae_data Then

        '                Dim mae_nashi As String
        '                If IsDBNull(rs_chk2!nashi) Then
        '                    mae_nashi = ""
        '                Else
        '                    mae_nashi = Trim(rs_chk2!nashi)
        '                End If

        '                If chkall.Checked Then
        '                    Dim error_msg As String = "[請求前チェック]データの繰越金額に差異があります。" + rs_chk2!tenpoid + Space(3) + Trim(rs_chk2!tenpomei) +
        '                        "   請求書ID：" + Trim(rs_chk2!seikyuushoid) + "   前回請求金額：" + mae_data + "円   今回請求金額：" + ato_data + "円"
        '                    If log_flg Then
        '                        log_write(error_msg)
        '                    Else
        '                        msg_go(error_msg)
        '                    End If
        '                Else
        '                    If mae_nashi = "" Then
        '                        Dim error_msg As String = "[請求前チェック]データの繰越金額に差異があります。" + rs_chk2!tenpoid + Space(3) + Trim(rs_chk2!tenpomei) +
        '                            "   請求書ID：" + Trim(rs_chk2!seikyuushoid) + "   前回請求金額：" + mae_data + "円   今回請求金額：" + ato_data + "円"
        '                        If log_flg Then
        '                            log_write(error_msg)
        '                        Else
        '                            msg_go(error_msg)
        '                        End If
        '                    End If
        '                End If

        '            End If

        '            mae_data = rs_chk2!seikyuukingaku
        '            iconter2 = iconter2 + 1
        '            rs_chk2.MoveNext

        '        Loop

        '        rs_chk2.MoveLast

        '        '次回発行時チェック
        '        If rs_chk!kadou <> "1" Then

        '            Dim sss_seikyuugaku As Long = rs_chk2!seikyuukingaku
        '            Dim sql_seikyu2 As String = "SELECT SUM(seikyuukingaku) AS newnyuukingoukei FROM seikyuusho WHERE seikyuu_st = '1' AND tenpoid = '" + rs_chk!tenpoid + "' AND hiduke >= '" + rs_chk2!hiduke + "' AND joukyou IS NULL"
        '            'Set rs_saikyu2 = New ADODB.Recordset

        '            Dim sss_nyuukingaku As Long
        '            If FcSQlGet(0, rs_saikyu2, sql_seikyu2, WMsg) = True Then
        '                If IsDBNull(rs_saikyu2!newnyuukingoukei) Then
        '                    sss_nyuukingaku = 0
        '                Else
        '                    sss_nyuukingaku = rs_saikyu2!newnyuukingoukei
        '                End If
        '            Else
        '                sss_nyuukingaku = 0
        '            End If

        '            Dim sss_kurikoshikingaku As Long
        '            If IsDBNull(rs_chk!kurikoshi) Then
        '                sss_kurikoshikingaku = 0
        '            Else
        '                sss_kurikoshikingaku = rs_chk!kurikoshi
        '            End If

        '            If sss_kurikoshikingaku + sss_nyuukingaku <> sss_seikyuugaku Then

        '                Dim s_kin As Long = sss_kurikoshikingaku + sss_nyuukingaku
        '                Dim error_msg As String = "[請求前チェック]データの最終繰越金額にエラーがあります。" + rs_chk2!tenpoid + Space(3) + Trim(rs_chk2!tenpomei) +
        '                    "   請求書ID：" + Trim(rs_chk2!seikyuushoid) + " 金額：" + CStr(s_kin) + "円," + sss_seikyuugaku + "円"
        '                If log_flg Then
        '                    log_write(error_msg)
        '                Else
        '                    msg_go(error_msg)
        '                End If

        '            End If
        '        End If
        '        rs_chk2.Close
        '    End If

        '    rs_chk.MoveNext

        'Loop

        'rs_chk.Close
        'cnn.Close
        'msg_go("チェック終了しました。")

        'If log_flg Then
        '    log_write("請求前チェックの終了********************************************")
        'End If

    End Sub

    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click
        Me.Close() : Me.Dispose()
        frmseikyuusho_soushin_ichi.ShowDialog()
    End Sub

End Class