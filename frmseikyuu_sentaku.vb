Imports System.Data.SqlClient

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

        ' TODO : 停止機能を作る

        Dim folder_path = DESKTOP_PATH + "\"
        Dim log_flg = False
        If chk_check_log.Checked Then
            write_log("請求前チェックの開始********************************************", folder_path)
            log_flg = True
        End If

        Dim log_end_msg = "請求前チェックの終了********************************************"
        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM tenpo ORDER BY tenpoid"

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(query, conn)
            Dim data_set As New DataSet
            Dim temp_table_name = "t_tenpo"
            data_adapter.Fill(data_set, temp_table_name)
            Dim data_table As DataTable = data_set.Tables(temp_table_name)

            Dim count_1 = data_table.Rows.Count
            If count_1 = 0 Then
                msg_go("チェックしたいデータが存在しません。")
                If log_flg Then
                    write_log(log_end_msg, folder_path)
                End If
                Me.Close() : Me.Dispose()
                Exit Sub
            End If

            show_shinkou_joukyou(count_1)
            For i = 0 To count_1 - 1

                If chk_check_chuushi.Checked Then
                    hide_shinkou_joukyou()
                    Exit Sub
                End If

                Dim item = data_table.Rows.Item(i)
                Dim tenpo_id = Trim(item.Item("tenpoid"))
                Dim tenpo_mei = Trim(item.Item("tenpomei"))
                Dim kadou = Trim(item.Item("kadou"))
                Dim kurikoshi = item.Item("kurikoshi")

                Try

                    Dim conn_2 As New SqlConnection
                    conn_2.ConnectionString = connectionstring_sqlserver

                    Dim query_2 = "SELECT seikyuusho.*, tenpo.tenpomei, tenpo.tenpofurigana FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
                " WHERE seikyuusho.tenpoid = '" + tenpo_id + "' AND seikyuusho.seikyuu_st = '0' ORDER BY seikyuusho.hiduke, tenpo.tenpofurigana"

                    Dim data_adapter_2 As SqlDataAdapter = New SqlDataAdapter(query_2, conn_2)
                    Dim data_set_2 As New DataSet
                    Dim temp_table_name_2 = "t_seikyuusho"
                    data_adapter_2.Fill(data_set_2, temp_table_name_2)
                    Dim data_table_2 As DataTable = data_set_2.Tables(temp_table_name_2)

                    Dim count = data_table_2.Rows.Count
                    If count > 0 Then

                        For j = 0 To data_table_2.Rows.Count - 1

                            Dim item_2 = data_table_2.Rows.Item(j)
                            Dim seikyuushoid = Trim(item_2.Item("seikyuushoid"))
                            Dim seikyuukingaku As Integer = item_2.Item("seikyuukingaku")

                            Dim ato_data As Integer
                            Dim mae_data As Integer
                            If j = 0 Then
                                mae_data = seikyuukingaku
                                ato_data = mae_data
                            Else
                                ato_data = Trim(item_2.Item("kuri"))
                            End If

                            If ato_data <> mae_data Then

                                Dim mae_nashi As String = ""
                                Dim db_nashi = item_2.Item("kuri")
                                If Not IsDBNull(db_nashi) Then
                                    mae_nashi = Trim(db_nashi)
                                End If

                                If chk_check_all.Checked Then
                                    Dim error_msg As String = "[請求前チェック]データの繰越金額に差異があります。" + tenpo_id + Space(3) + tenpo_mei +
                                        "   請求書ID：" + seikyuushoid + "   前回請求金額：" + mae_data.ToString("#,0") + "円   今回請求金額：" + ato_data.ToString("#,0") + "円"
                                    If log_flg Then
                                        write_log(error_msg, folder_path)
                                    Else
                                        msg_go(error_msg)
                                    End If
                                Else
                                    If mae_nashi = "" Then
                                        Dim error_msg As String = "[請求前チェック]データの繰越金額に差異があります。" + tenpo_id + Space(3) + tenpo_mei +
                                            "   請求書ID：" + seikyuushoid + "   前回請求金額：" + mae_data.ToString("#,0") + "円   今回請求金額：" + ato_data.ToString("#,0") + "円"
                                        If log_flg Then
                                            write_log(error_msg, folder_path)
                                        Else
                                            msg_go(error_msg)
                                        End If
                                    End If
                                End If

                            End If

                            mae_data = seikyuukingaku

                        Next

                        '次回発行時チェック
                        If kadou <> "1" Then

                            Dim item_2 = data_table_2.Rows.Item(count - 1)
                            Dim hiduke = Trim(item_2.Item("hiduke"))

                            Try

                                Dim conn_3 As New SqlConnection
                                conn_3.ConnectionString = connectionstring_sqlserver

                                Dim query_3 = "SELECT SUM(seikyuukingaku) AS newnyuukingoukei FROM seikyuusho WHERE seikyuu_st = '1' AND tenpoid = '" + tenpo_id + "' AND hiduke >= '" + hiduke + "' AND joukyou IS NULL"

                                Dim data_adapter_3 As SqlDataAdapter = New SqlDataAdapter(query_3, conn_3)
                                Dim data_set_3 As New DataSet
                                Dim temp_table_name_3 = "t_"
                                data_adapter_3.Fill(data_set_3, temp_table_name_3)
                                Dim data_table_3 As DataTable = data_set_3.Tables(temp_table_name_3)

                                Dim newnyuukingoukei As Integer = 0
                                If data_table_3.Rows.Count > 0 Then
                                    Dim db_newnyuukingoukei = data_table_3.Rows.Item(0).Item("newnyuukingoukei")
                                    If Not IsDBNull(db_newnyuukingoukei) Then
                                        newnyuukingoukei = db_newnyuukingoukei
                                    End If
                                End If

                                Dim l_kurikoshi As Integer = 0
                                If Not IsDBNull(kurikoshi) Then
                                    l_kurikoshi = kurikoshi
                                End If

                                Dim seikyuukingaku As Integer = item_2.Item("seikyuukingaku")
                                If l_kurikoshi + newnyuukingoukei <> seikyuukingaku Then

                                    Dim kingaku As Integer = l_kurikoshi + newnyuukingoukei
                                    Dim seikyuushoid = Trim(item_2.Item("seikyuushoid"))
                                    Dim error_msg As String = "[請求前チェック]データの最終繰越金額にエラーがあります。" + tenpo_id + Space(3) + tenpo_mei +
                                    "   請求書ID：" + seikyuushoid + "   金額：" + kingaku.ToString("#,0") + "円, " + seikyuukingaku.ToString("#,0") + "円"
                                    If log_flg Then
                                        write_log(error_msg, folder_path)
                                    Else
                                        msg_go(error_msg)
                                    End If

                                End If

                                data_table_3.Clear()
                                data_set_3.Clear()

                            Catch ex As Exception
                                msg_go(ex.Message)
                                If log_flg Then
                                    write_log(log_end_msg, folder_path)
                                End If
                                hide_shinkou_joukyou()
                                Exit Sub
                            End Try

                        End If

                    End If

                    data_table_2.Clear()
                    data_set_2.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    If log_flg Then
                        write_log(log_end_msg, folder_path)
                    End If
                    hide_shinkou_joukyou()
                    Exit Sub
                End Try

                calculate_shinkou_joukyou(i + 1, count_1)

            Next

            data_table.Clear()
            data_set.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            If log_flg Then
                write_log(log_end_msg, folder_path)
            End If
            hide_shinkou_joukyou()
            Exit Sub
        End Try

        If log_flg Then
            write_log(log_end_msg, folder_path)
        End If

        msg_go("チェック終了しました。", 64)
        hide_shinkou_joukyou()

    End Sub

    Private Sub btn_seikyuusho_soushin_kanri_Click(sender As Object, e As EventArgs) Handles btn_seikyuusho_soushin_kanri.Click
        Me.Close() : Me.Dispose()
        frmseikyuusho_soushin_ichi.ShowDialog()
    End Sub

    Private Sub show_shinkou_joukyou(max_count As Integer)

        gbx_shinkou_joukyou.Visible = True
        gbx_shinkou_joukyou.BringToFront()
        Dim x As Integer = 275
        Dim y As Integer = (ClientSize.Height - gbx_shinkou_joukyou.Height) \ 2
        gbx_shinkou_joukyou.Location = New Point(x, y)
        pgb_shinkou_joukyou.Minimum = 0
        pgb_shinkou_joukyou.Maximum = max_count
        pgb_shinkou_joukyou.Value = 0
        gbx_check.Enabled = False
        gbx_hakkou_insatsu.Enabled = False
        gbx_hakkou_pdf.Enabled = False
        gbx_modoru.Enabled = False
        gbx_rireki.Enabled = False
        gbx_seikyuusho_soushin_kanri.Enabled = False
        gbx_shuukin_hyou.Enabled = False

        System.Windows.Forms.Application.DoEvents()

    End Sub

    Private Sub hide_shinkou_joukyou()

        gbx_check.Enabled = True
        gbx_hakkou_insatsu.Enabled = True
        gbx_hakkou_pdf.Enabled = True
        gbx_modoru.Enabled = True
        gbx_rireki.Enabled = True
        gbx_seikyuusho_soushin_kanri.Enabled = True
        gbx_shuukin_hyou.Enabled = True

        gbx_shinkou_joukyou.Visible = False

        Me.Close() : Me.Dispose()

    End Sub

    Private Sub calculate_shinkou_joukyou(counter As Integer, max_count As Integer)

        lbl_shinkou_doai.Text = counter.ToString("#,0") + " / " + max_count.ToString("#,0")
        lbl_shinkou_percent.Text = "" + (CDbl(counter) / CDbl(max_count) * 100).ToString(".00") + "%"
        pgb_shinkou_joukyou.Value = counter

        System.Windows.Forms.Application.DoEvents()

    End Sub

End Class