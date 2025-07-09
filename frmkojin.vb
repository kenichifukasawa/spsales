Imports System.Data.SqlClient

Public Class frmkojin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles b_koushin.Click

        Dim newitsu As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim newnanji As String = DateTime.Now.ToString("HH:mm:ss")


        Dim tenpoid As String = Trim(lbtenpoid.Text)

        Dim s_furigana As String = ""
        If Trim(txtfurigana.Text) = "" Then
            msg_go("フリガナを入力してから、再度実行してください。")
            Exit Sub
        Else
            s_furigana = Trim(txtfurigana.Text)
        End If

        Dim s_name As String = ""
        If Trim(txttenpomei.Text) = "" Then
            msg_go("フリガナを入力してから、再度実行してください。")
            Exit Sub
        Else
            s_name = Trim(txttenpomei.Text)
        End If

        Dim s_insatsumei As String = ""
        If Trim(txtinsatsumei.Text) = "" Then
            msg_go("印刷名を入力してから、再度実行してください。")
            Exit Sub
        Else
            s_insatsumei = Trim(txtinsatsumei.Text)
        End If

        Dim s_yuubin As String = ""
        If Trim(txtyuubin.Text) <> "" Then
            If Len(Trim(txtyuubin.Text)) <> 3 Then
                msg_go("郵便番号は3ケタと4ケタで入力してください。")
                Exit Sub
            Else
                If Trim(txtyuubin2.Text) <> "" Then
                    If Len(Trim(txtyuubin2.Text)) <> 4 Then
                        msg_go("郵便番号は3ケタと4ケタで入力してください。")
                        Exit Sub
                    Else
                        s_yuubin = Trim(txtyuubin.Text) & "-" & Trim(txtyuubin2.Text)
                    End If
                Else
                    msg_go("郵便番号は3ケタと4ケタで入力してください。")
                    Exit Sub
                End If
            End If
        End If

        Dim s_juusho As String = Trim(txtjuusho.Text)
        Dim s_juusho2 As String = Trim(txtjuusho2.Text)
        Dim s_soufusaki As String = Trim(txtsoufusaki.Text)

        Dim s_tel1 As String = Trim(txttel.Text)
        If s_tel1 <> "" Then
            If Len(s_tel1) <> 12 Then
                msg_go("電話番号は12ケタで入力してください。")
                Exit Sub
            End If
        End If

        Dim s_keitai As String = Trim(txtkeitai.Text)
        If s_keitai <> "" Then
            If Len(s_keitai) <> 13 Then
                msg_go("携帯番号は13ケタで入力してください。")
                Exit Sub
            End If
        End If
        Dim s_fax As String = Trim(txtfax.Text)
        If s_fax <> "" Then
            If Len(s_fax) <> 12 Then
                msg_go("FAX番号は12ケタで入力してください。")
                Exit Sub
            End If
        End If

        Dim s_tantou As String = Trim(txttantou.Text)
        Dim s_daihyou As String = Trim(txtdaihyou.Text)
        Dim s_juugyouinsuu As String = Trim(txtjuugyouinsuu.Text)
        Dim s_url As String = Trim(txturl.Text)

        Dim s_email As String = ""

        If Trim(txtemail1.Text) <> "" Then
            If Trim(cmbmail.Text) <> "" Then
                s_email = Trim(txtemail1.Text) & "@" & Trim(cmbmail.Text)
            End If
        End If

        Dim s_torihikinashi As String = "0"
        If chktorihikinashi.Checked = True Then
            s_torihikinashi = "1"
        End If

        Dim s_ueranashi As String = ""
        If chkueranashi.Checked = True Then
            s_ueranashi = "1"
        End If

        Dim s_mailsoufu As String = ""
        If chkmailsoufu.Checked = True Then
            s_mailsoufu = "1"
        End If

        Dim s_shime As String = ""
        If cmbshime.SelectedIndex <> -1 Then
            s_shime = cmbshime.SelectedIndex.ToString
        Else
            msg_go("〆日を選択してください。")
            Exit Sub
        End If

        Dim s_shain As String = ""
        If cmbshain.SelectedIndex <> -1 Then
            s_shain = Mid(Trim(cmbshain.Text), 1, 3)
        End If

        Dim s_kubun As String = ""
        If rkubunkaisha.Checked = True Then
            s_kubun = "0"
        Else
            If rkubuntenpo.Checked = True Then
                s_kubun = "1"
            Else
                If rkubuniroiro.Checked = True Then
                    s_kubun = "2"
                Else
                    msg_go("区分を選択してください。")
                    Exit Sub
                End If
            End If
        End If

        Dim s_hasuu As String = ""
        If rkirisute.Checked = True Then
            s_hasuu = "0"
        Else
            If rshishagonyuu.Checked = True Then
                s_hasuu = "1"
            Else
                If rkiriage.Checked = True Then
                    s_hasuu = "2"
                Else
                    msg_go("端数処理を選択してください。")
                    Exit Sub
                End If
            End If
        End If

        Dim s_keisan As String = ""
        If rkeisanseikyuusho.Checked = True Then
            s_keisan = "0"
        Else
            If rkeisannouhinsho.Checked = True Then
                s_keisan = "1"
            Else
                msg_go("計算方法を選択してください。")
                Exit Sub
            End If
        End If


        Dim s_bikou As String = Trim(txtbikou.Text)

        Dim s_kurikoshikingaku As String = Trim(txtkurikoshikin.Text)

        Dim s_zenkaiseikyuubi As String = Trim(txtzenkaiseikyuubi.Text)
        If s_zenkaiseikyuubi <> "" Then
            If Len(s_zenkaiseikyuubi) <> 10 Then
                msg_go("CATV加入日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_zenkaiseikyuubi = Mid(s_zenkaiseikyuubi, 1, 4) & Mid(s_zenkaiseikyuubi, 6, 2) & Mid(s_zenkaiseikyuubi, 9, 2)
            End If
        End If


        '新規登録
        If tenpoid = "" Then
            Dim newid As String, newid2 As String, settei2_res As String

            newid = Trim(setting2(7, 0, "1", ""))
            If newid = "-1" Then
                msg_go("IDの取得に失敗しました。再度実行してください。")
                Exit Sub
            ElseIf newid = "0" Then
                newid2 = "2"
                newid = "000001"
            Else
                newid2 = (CInt(newid) + 1).ToString
                newid = newid.ToString.PadLeft(6, "0"c)
            End If

            settei2_res = setting2(7, 1, "1", newid2)
            If settei2_res = "-1" Then
                msg_go("IDの更新に失敗しました。再度実行してください。")
                Exit Sub
            End If


            Try


                Dim cn_server As New SqlConnection

                'cn_server.ConnectionString = connectionstring_sqlserver.ConnectionString
                cn_server.ConnectionString = connectionstring_sqlserver

                Sql = "SELECT TOP 1 * FROM tenpo"

                Dim da_server As SqlDataAdapter

                da_server = New SqlDataAdapter(Sql, cn_server)

                Dim ds_server As New DataSet

                da_server.Fill(ds_server, "t_jm_s")

                Dim s_comr As SqlClient.SqlCommandBuilder

                s_comr = New SqlClient.SqlCommandBuilder(da_server)

                Dim ret_rows As DataRow

                ret_rows = ds_server.Tables("t_jm_s").NewRow()

                ret_rows("tenpoid") = newid
                ret_rows("tenpofurigana") = s_furigana
                ret_rows("tenpomei") = s_name
                ret_rows("insatsumei") = s_insatsumei
                If s_yuubin <> "" Then
                    ret_rows("mailno") = s_yuubin
                End If
                If s_juusho2 <> "" Then
                    ret_rows("tenpoadress") = s_juusho2
                End If
                If s_tel1 <> "" Then
                    ret_rows("tel") = s_tel1
                End If
                If s_keitai <> "" Then
                    ret_rows("keitai") = s_keitai
                End If
                If s_fax <> "" Then
                    ret_rows("fax") = s_fax
                End If
                If s_bikou <> "" Then
                    ret_rows("bikou") = s_bikou
                End If
                If s_daihyou <> "" Then
                    ret_rows("daihyou") = s_daihyou
                End If
                If s_tantou <> "" Then
                    ret_rows("tantou") = s_tantou
                End If
                If s_juugyouinsuu <> "" Then
                    ret_rows("juugyouinsuu") = s_juugyouinsuu
                End If
                ret_rows("shimebi") = s_shime
                If s_email <> "" Then
                    ret_rows("email") = s_email
                End If
                If s_kurikoshikingaku <> "" Then
                    ret_rows("kurikoshi") = s_kurikoshikingaku
                End If
                If s_zenkaiseikyuubi <> "" Then
                    ret_rows("seikyuubi") = s_zenkaiseikyuubi
                End If
                If s_ueranashi <> "" Then
                    ret_rows("wellaon") = s_ueranashi
                End If
                If s_url <> "" Then
                    ret_rows("url") = s_url
                End If
                If s_mailsoufu <> "" Then
                    ret_rows("soushin") = s_mailsoufu
                End If
                If s_soufusaki <> "" Then
                    ret_rows("soushinsaki") = s_soufusaki
                End If

                ret_rows("shainid") = s_shain
                ret_rows("kubun") = s_kubun
                ret_rows("zeihasuu") = s_hasuu
                ret_rows("souhasuu") = s_keisan
                ret_rows("kadou") = s_torihikinashi



                ds_server.Tables("t_jm_s").Rows.Add(ret_rows)

                da_server.Update(ds_server, "t_jm_s")

                ds_server.Clear()


            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try


            mainset(newid)


            msg_go("データを登録しました。", 64)


        Else
            '修正


            Dim cn_shounin As New SqlConnection
            Dim da_shounin As New SqlDataAdapter
            Dim ds_shounin As New DataSet

            Dim cmdbuilder_shounin As New SqlCommandBuilder


            Try


                cn_shounin.ConnectionString = connectionstring_sqlserver

                Sql = "select * from tenpo where tenpoid ='" & tenpoid & "'"



                da_shounin = New SqlDataAdapter(Sql, cn_shounin)

                da_shounin.Fill(ds_shounin, "t_jouhouhens")


                '書き込み


                ds_shounin.Tables("t_jouhouhens").Rows(0)("tenpofurigana") = s_furigana
                ds_shounin.Tables("t_jouhouhens").Rows(0)("tenpomei") = s_name
                ds_shounin.Tables("t_jouhouhens").Rows(0)("insatsumei") = s_insatsumei
                If s_yuubin <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("mailno") = s_yuubin
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("mailno") = DBNull.Value
                End If
                If s_juusho2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tenpoadress") = s_juusho2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tenpoadress") = DBNull.Value
                End If
                If s_tel1 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel") = s_tel1
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel") = DBNull.Value
                End If
                If s_keitai <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("keitai") = s_keitai
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("keitai") = DBNull.Value
                End If
                If s_fax <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("fax") = s_fax
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("fax") = DBNull.Value
                End If
                If s_bikou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("bikou") = s_bikou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("bikou") = DBNull.Value
                End If
                If s_daihyou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("daihyou") = s_daihyou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("daihyou") = DBNull.Value
                End If
                If s_tantou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tantou") = s_tantou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tantou") = DBNull.Value
                End If
                If s_juugyouinsuu <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juugyouinsuu") = s_juugyouinsuu
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juugyouinsuu") = DBNull.Value
                End If
                ds_shounin.Tables("t_jouhouhens").Rows(0)("shimebi") = s_shime
                If s_email <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("email") = s_email
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("email") = DBNull.Value
                End If
                If s_kurikoshikingaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kurikoshi") = s_kurikoshikingaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kurikoshi") = DBNull.Value
                End If
                If s_zenkaiseikyuubi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuubi") = s_zenkaiseikyuubi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuubi") = DBNull.Value
                End If
                If s_ueranashi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("wellaon") = s_ueranashi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("wellaon") = DBNull.Value
                End If
                If s_url <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("url") = s_url
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("url") = DBNull.Value
                End If
                If s_mailsoufu <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("soushin") = s_mailsoufu
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("soushin") = DBNull.Value
                End If
                If s_soufusaki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("soushinsaki") = s_soufusaki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("soushinsaki") = DBNull.Value
                End If

                ds_shounin.Tables("t_jouhouhens").Rows(0)("shainid") = s_shain
                ds_shounin.Tables("t_jouhouhens").Rows(0)("kubun") = s_kubun
                ds_shounin.Tables("t_jouhouhens").Rows(0)("zeihasuu") = s_hasuu
                ds_shounin.Tables("t_jouhouhens").Rows(0)("souhasuu") = s_keisan
                ds_shounin.Tables("t_jouhouhens").Rows(0)("kadou") = s_torihikinashi


                cmdbuilder_shounin.DataAdapter = da_shounin

                da_shounin.Update(ds_shounin, "t_jouhouhens")

                ds_shounin.Clear()
            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try





            mainset(tenpoid)

            msg_go("更新しました。", 64)

        End If


        Me.Close()
        Me.Dispose()

    End Sub



End Class