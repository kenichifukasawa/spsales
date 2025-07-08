Imports System.Data.SqlClient

Public Class frmkojin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles b_koushin.Click

        Dim newitsu As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim newnanji As String = DateTime.Now.ToString("HH:mm:ss")


        Dim kojinid As String = Trim(lblkojinid.Text)

        Dim s_furigana As String = ""
        If Trim(txtfurigana.Text) = "" And Trim(txtfurigana2.Text) = "" Then
            msg_go("フリガナを入力してから、再度実行してください。")
            Exit Sub
        Else
            s_furigana = Trim(txtfurigana.Text) & " " & Trim(txtfurigana2.Text)
        End If

        Dim s_name As String = ""
        If Trim(txtname.Text) = "" And Trim(txtname2.Text) = "" Then
            msg_go("フリガナを入力してから、再度実行してください。")
            Exit Sub
        Else
            s_name = Trim(txtname.Text) & " " & Trim(txtname2.Text)
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
                        s_yuubin = Trim(txtyuubin.Text) & Trim(txtyuubin2.Text)
                    End If
                Else
                    msg_go("郵便番号は3ケタと4ケタで入力してください。")
                    Exit Sub
                End If
            End If
        End If

        Dim s_chiiki As String = ""
        If cmbchiikikubun.SelectedIndex <> -1 Then
            s_chiiki = cmbchiikikubun.SelectedIndex.ToString
        End If

        Dim s_juutaku As String = ""
        If comjuutaku.SelectedIndex <> -1 Then
            s_juutaku = comjuutaku.SelectedIndex.ToString
        End If

        Dim s_juusho As String = Trim(txtjuusho.Text)
        Dim s_juusho2 As String = Trim(txtjuusho2.Text)

        Dim s_tel1 As String = Trim(txttel1.Text)
        If s_tel1 <> "" Then
            If Len(s_tel1) <> 12 Then
                msg_go("電話番号は12ケタで入力してください。")
                Exit Sub
            End If
        End If
        Dim s_tel2 As String = Trim(txttel2.Text)
        If s_tel2 <> "" Then
            If Len(s_tel2) <> 12 Then
                msg_go("電話番号は12ケタで入力してください。")
                Exit Sub
            End If
        End If
        Dim s_keitai As String = Trim(txtkeitai.Text)
        If s_keitai <> "" Then
            If Len(s_keitai) <> 13 Then
                msg_go("携帯番号は12ケタで入力してください。")
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

        Dim s_bikou As String = Trim(txtbikou.Text)
        Dim s_kannriid As String = Trim(txtkannriid.Text)
        Dim s_seikyuusakiid As String = Trim(txtseikyuusakiid.Text)

        Dim s_cadix As String = ""
        If chkcadix.Checked = True Then
            s_cadix = "1"
        End If

        Dim s_secchifuri As String = Trim(txtsecchifuri.Text)
        Dim s_secchiname As String = Trim(txtsecchiname.Text)
        Dim s_secchijuusho As String = Trim(txtsecchijuusho.Text)
        Dim s_secchitel As String = Trim(txtsecchitel.Text)
        Dim s_secchimemo As String = Trim(txtsecchimemo.Text)

        Dim s_secchifuri_new As String = Trim(txtsecchifuri_new.Text)
        Dim s_secchiname_new As String = Trim(txtsecchiname_new.Text)
        Dim s_secchijuusho_new As String = Trim(txtsecchijuusho_new.Text)
        Dim s_secchitel_new As String = Trim(txtsecchitel_new.Text)
        Dim s_secchimemo_new As String = Trim(txtsecchimemo_new.Text)

        Dim s_cellid As String = ""
        If cmbcellid.SelectedIndex <> -1 Then
            If cmbcellid.Text <> "なし" Then
                s_cellid = Mid(Trim(cmbcellid.Text), 1, 2)
            End If
        End If
        Dim s_cellno As String = ""
        If cmbcellno.SelectedIndex <> -1 Then
            If cmbcellno.Text <> "なし" Then
                s_cellno = Trim(cmbcellno.Text)
            End If
        End If

        Dim s_setaisuu As String = Trim(txtsetaisuu.Text)
        If s_setaisuu = "" Then
            msg_go("区分を入力してください。")
            Exit Sub
        End If
        Dim s_tvsuu As String = Trim(txttvsuu.Text)
        If s_tvsuu = "" Then
            msg_go("TV数を入力してください。")
            Exit Sub
        End If
        Dim s_aki As String = "0"
        If s_juutaku = "2" Then
            If Trim(txtaki.Text) <> "" Then
                s_aki = Trim(txtaki.Text)
            End If
        End If

        Dim s_q As String = "", s_q_nentsuki As String = ""
        If chkq.Checked = True Then
            s_q = "1"
            If Trim(txtqnen.Text) = "" Then
                msg_go("Qの年を入力してください。")
                Exit Sub
            Else
                If Trim(txtqtsuki.Text) = "" Then
                    msg_go("Qの月を入力してください。")
                    Exit Sub
                Else
                    s_q_nentsuki = Trim(txtqnen.Text) & Trim(txtqtsuki.Text)
                End If
            End If
        End If
        Dim s_black As String = "0"
        If chkblack.Checked = True Then
            s_black = "1"
        End If
        Dim s_kyuushi As String = "0"
        If chkkyuushi.Checked = True Then
            s_kyuushi = "1"
        End If

        Dim s_koujihi As String = Trim(txtkoujihi.Text)
        Dim s_koujihi2 As String = Trim(txtkoujihi2.Text)
        Dim s_waribiki As String = Trim(txtwaribiki.Text)
        If s_waribiki <> "" Then
            Dim d As Double
            If Double.TryParse(s_waribiki, d) Then
                '変換出来たら、dにその数値が入る
                'Console.WriteLine("{0} は数値 {1} に変換できます。", Str, d)
            Else
                'Console.WriteLine("{0} は数字ではありません。", Str)
                msg_go("割引金は数字を入力してください。")
                Exit Sub
            End If
        End If
        Dim s_waribiki2 As String = Trim(txtwaribiki2.Text)
        If s_waribiki2 <> "" Then
            Dim d As Double
            If Double.TryParse(s_waribiki2, d) Then
                '変換出来たら、dにその数値が入る
                'Console.WriteLine("{0} は数値 {1} に変換できます。", Str, d)
            Else
                'Console.WriteLine("{0} は数字ではありません。", Str)
                msg_go("割引金は数字を入力してください。")
                Exit Sub
            End If
        End If

        Dim s_riyuu As String = Trim(txtriyuu.Text)
        Dim s_riyuu2 As String = Trim(txtriyuu2.Text)

        Dim s_kanyuubi As String = Trim(txtkanyuubi.Text)
        Dim s_kanyuubi2 As String = Trim(txtkanyuubi2.Text)
        If s_kanyuubi <> "" Then
            If Len(s_kanyuubi) <> 10 Then
                msg_go("CATV加入日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_kanyuubi = Mid(s_kanyuubi, 1, 4) & Mid(s_kanyuubi, 6, 2) & Mid(s_kanyuubi, 9, 2)
            End If
        End If
        If s_kanyuubi2 <> "" Then
            If Len(s_kanyuubi2) <> 10 Then
                msg_go("Internet加入日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_kanyuubi2 = Mid(s_kanyuubi2, 1, 4) & Mid(s_kanyuubi2, 6, 2) & Mid(s_kanyuubi2, 9, 2)
            End If
        End If

        Dim s_catvsaikai As String = Trim(txtcatvsaikai.Text)
        If s_catvsaikai <> "" Then
            If Len(s_catvsaikai) <> 10 Then
                msg_go("CATV再開日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_catvsaikai = Mid(s_catvsaikai, 1, 4) & Mid(s_catvsaikai, 6, 2) & Mid(s_catvsaikai, 9, 2)
            End If
        End If
        Dim s_catvkyuushi As String = Trim(txtcatvkyuushi.Text)
        If s_catvkyuushi <> "" Then
            If Len(s_catvkyuushi) <> 10 Then
                msg_go("CATV休止日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_catvkyuushi = Mid(s_catvkyuushi, 1, 4) & Mid(s_catvkyuushi, 6, 2) & Mid(s_catvkyuushi, 9, 2)
            End If
        End If
        Dim s_catvkaiyaku As String = Trim(txtcatvkaiyaku.Text)
        If s_catvkaiyaku <> "" Then
            If Len(s_catvkaiyaku) <> 10 Then
                msg_go("CATV解約日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_catvkaiyaku = Mid(s_catvkaiyaku, 1, 4) & Mid(s_catvkaiyaku, 6, 2) & Mid(s_catvkaiyaku, 9, 2)
            End If
        End If
        Dim s_intersaikai As String = Trim(txtintersaikai.Text)
        If s_intersaikai <> "" Then
            If Len(s_intersaikai) <> 10 Then
                msg_go("Internet再開日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_intersaikai = Mid(s_intersaikai, 1, 4) & Mid(s_intersaikai, 6, 2) & Mid(s_intersaikai, 9, 2)
            End If
        End If
        Dim s_interkyuushi As String = Trim(txtinterkyuushi.Text)
        If s_interkyuushi <> "" Then
            If Len(s_interkyuushi) <> 10 Then
                msg_go("Internet休止日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_interkyuushi = Mid(s_interkyuushi, 1, 4) & Mid(s_interkyuushi, 6, 2) & Mid(s_interkyuushi, 9, 2)
            End If
        End If
        Dim s_interkaiyaku As String = Trim(txtinterkaiyaku.Text)
        If s_interkaiyaku <> "" Then
            If Len(s_interkaiyaku) <> 10 Then
                msg_go("Internet解約日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_interkaiyaku = Mid(s_interkaiyaku, 1, 4) & Mid(s_interkaiyaku, 6, 2) & Mid(s_interkaiyaku, 9, 2)
            End If
        End If
        Dim s_clkanyuubi As String = Trim(txtclkanyuubi.Text)
        If s_clkanyuubi <> "" Then
            If Len(s_clkanyuubi) <> 10 Then
                msg_go("CL加入日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_clkanyuubi = Mid(s_clkanyuubi, 1, 4) & Mid(s_clkanyuubi, 6, 2) & Mid(s_clkanyuubi, 9, 2)
            End If
        End If
        Dim s_clkaiyakubi As String = Trim(txtclkaiyakubi.Text)
        If s_clkaiyakubi <> "" Then
            If Len(s_clkaiyakubi) <> 10 Then
                msg_go("CL解約日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_clkaiyakubi = Mid(s_clkaiyakubi, 1, 4) & Mid(s_clkaiyakubi, 6, 2) & Mid(s_clkaiyakubi, 9, 2)
            End If
        End If
        Dim s_mvnokanyuubi As String = Trim(txtmvnokanyuubi.Text)
        If s_mvnokanyuubi <> "" Then
            If Len(s_mvnokanyuubi) <> 10 Then
                msg_go("MVNO解約日は、10ケタで入力してください。")
                Exit Sub
            Else
                s_mvnokanyuubi = Mid(s_mvnokanyuubi, 1, 4) & Mid(s_mvnokanyuubi, 6, 2) & Mid(s_mvnokanyuubi, 9, 2)
            End If
        End If

        Dim s_shiharaihouhou As String = ""
        Dim s_bank As String = "", s_kouzashurui As String = "", s_kouzabangou As String = "", s_kouzameigi As String = ""
        Dim s_card_shurui As String = "", s_card_bangou As String = "", s_card_meibi As String = "", s_card_kigen As String = ""
        If rkouza.Checked = True Then
            s_shiharaihouhou = "0"
            If cmbbank.SelectedIndex = -1 Then
                msg_go("口座指定の場合は、金融機関名を選択してください。")
                Exit Sub
            Else
                s_bank = Mid(Trim(cmbbank.Text), 1, 3)
            End If
            If rfutsuu.Checked = True Then
                s_kouzashurui = "0"
            Else
                If rtouza.Checked = True Then
                    s_kouzashurui = "1"
                Else
                    msg_go("口座指定の場合は、種類を選択してください。")
                    Exit Sub
                End If
            End If
            If Trim(txtkouzabangou.Text) = "" Then
                msg_go("口座指定の場合は、番号を入力してください。")
                Exit Sub
            Else
                s_kouzabangou = Trim(txtkouzabangou.Text)
            End If
            If Trim(txtkouzameigi.Text) = "" Then
                msg_go("口座指定の場合は、名義を入力してください。")
                Exit Sub
            Else
                s_kouzameigi = Trim(txtkouzameigi.Text)
            End If

        Else
            If rgenkin.Checked = True Then
                s_shiharaihouhou = "1"
            Else
                If rseikyuusho.Checked = True Then
                    If rseikyuu1.Checked = True Then
                        s_shiharaihouhou = "2"
                    Else
                        If rseikyuu3.Checked = True Then
                            s_shiharaihouhou = "3"
                        Else
                            If rseikyuu6.Checked = True Then
                                s_shiharaihouhou = "4"
                            Else
                                If rseikyuu12.Checked = True Then
                                    s_shiharaihouhou = "5"
                                Else
                                    If rseikyuusonota.Checked = True Then
                                        s_shiharaihouhou = "6"
                                    Else
                                        msg_go("請求書の場合は、請求書を発行する期間を選択してください。")
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                Else
                    If rcard.Checked = True Then
                        s_shiharaihouhou = "9"
                        If rvisa.Checked = True Then
                            s_card_shurui = "0"
                        Else
                            If rmaster.Checked = True Then
                                s_card_shurui = "1"
                            Else
                                If rjcb.Checked = True Then
                                    s_card_shurui = "2"
                                Else
                                    If ramex.Checked = True Then
                                        s_card_shurui = "3"
                                    Else
                                        msg_go("クレジットカードの種類を選択してください。")
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                        If Trim(txtcardbangou.Text) = "" Then
                            msg_go("カードの場合は、番号を入力してください。")
                            Exit Sub
                        Else
                            s_card_bangou = Trim(txtcardbangou.Text)
                        End If

                        If Trim(txtcardmeigi.Text) = "" Then
                            msg_go("カードの場合は、名義を入力してください。")
                            Exit Sub
                        Else
                            s_card_meibi = Trim(txtcardmeigi.Text)
                        End If

                        If Trim(txtkigentsuki.Text) = "" Then
                            msg_go("カードの場合は、期限を入力してください。")
                            Exit Sub
                        Else
                            If Trim(txtkigennen.Text) = "" Then
                                msg_go("カードの場合は、期限を入力してください。")
                                Exit Sub
                            Else
                                s_card_kigen = Trim(txtkigentsuki.Text) & Trim(txtkigennen.Text)
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Dim s_kyuukouza As String = Trim(txtkyuukouza.Text)
        Dim s_kyuukouza2 As String = Trim(txtkyuukouza2.Text)
        Dim s_kannrikouza As String = Trim(txtkannrikouza.Text)

        Dim s_nyuukinbi As String = Trim(txtnyuukinbi.Text)
        If s_nyuukinbi <> "" Then
            If Len(s_nyuukinbi) <> 10 Then
                msg_go("入金日は、例に従って１０ケタで入力してください。例）2024/02/04")
                Exit Sub
            Else
                s_nyuukinbi = Mid(s_nyuukinbi, 1, 4) & Mid(s_nyuukinbi, 6, 2) & Mid(s_nyuukinbi, 9, 2)
            End If
        End If
        Dim s_nyuukingaku As String = Trim(txtnyuukingaku.Text)
        Dim s_zangaku As String = Trim(txtzangaku.Text)
        Dim s_kanren_nen As String = ""
        If Trim(txtkanrennen.Text) <> "" Then
            If Trim(txtkanrentsuki.Text) <> "" Then
                s_kanren_nen = Trim(txtkanrennen.Text) & Trim(txtkanrentsuki.Text)
            Else
                msg_go("入金の関連月を入力してから、再度実行してください。")
                Exit Sub
            End If
        End If
        Dim s_netwari_nentsuki As String=""
        If Trim(txtnetwari_nen.Text) <> "" Then
            If Len(Trim(txtnetwari_nen.Text)) <> 4 Then
                msg_go("ネット割の年を正確に入力してから、再度実行してください。")
                Exit Sub
            End If
            If Trim(txtnetwari_tsuki.Text) = "" Then
                msg_go("ネット割の月を入力してから、再度実行してください。")
                Exit Sub
            Else
                If Len(Trim(txtnetwari_tsuki.Text)) <> 2 Then
                    msg_go("ネット割の月を正確に入力してから、再度実行してください。")
                    Exit Sub
                End If
                s_netwari_nentsuki = Trim(txtnetwari_nen.Text) & Trim(txtnetwari_tsuki.Text)
            End If
        End If
        Dim s_ht_hoshoukin As String = Trim(txtht_hoshoukin.Text)

        Dim s_karijuusho As String = Trim(txtkarijuusho.Text)

        Dim s_yuubin_meigi_chk As String = ""
        If chkyuubinflg.Checked = True Then
            s_yuubin_meigi_chk = "1"
        End If

        Dim s_nhkno As String = Trim(txtnhkno.Text)
        Dim s_nhkname As String = Trim(txtnhknamae.Text)
        Dim s_nhkfuri As String = Trim(txtnhkfurigana.Text)

        Dim s_end_flg As String = ""
        If chkend.Checked = True Then
            s_end_flg = "1"
        End If
        '元の値がendのとき
        If Trim(txtend_moto.Text) = "1" Then
            If s_end_flg = "" Then
                msg_go("一度「完全終了」したデータは、元に戻すことはできません。")
                Exit Sub
            End If
        Else
            If s_end_flg = "1" Then
                Dim result As DialogResult = MessageBox.Show("「完全終了」にすると元に戻せません。それでも「完全終了」にしますか？", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If


        Dim s_hikiotoshiichiran As String = "0"
        If chkhikiotoshiichiran.Checked = True Then
            s_hikiotoshiichiran = "1"
        End If

        '新規登録
        If kojinid = "" Then
            Dim newid As String, newid2 As String

            newid = Trim(setting2(1, 0, "renban", ""))
            If newid = "-1" Then
                msg_go("IDの取得に失敗しました。再度実行してください。")
                Exit Sub
            ElseIf newid = "0" Then
                newid2 = "2"
                newid = "00001"
            Else
                newid2 = (CInt(newid) + 1).ToString
                newid = newid.ToString.PadLeft(5, "0"c)
            End If

            settei2_res = setting2(1, 1, "renban", newid2)
            If settei2_res = "-1" Then
                msg_go("IDの更新に失敗しました。再度実行してください。")
                Exit Sub
            End If


            Try


                Dim cn_server As New SqlConnection

                'cn_server.ConnectionString = connectionstring_sqlserver.ConnectionString
                cn_server.ConnectionString = connectionstring_sqlserver

                sql = "SELECT TOP 1 * FROM kojin"

                Dim da_server As SqlDataAdapter

                da_server = New SqlDataAdapter(sql, cn_server)

                Dim ds_server As New DataSet

                da_server.Fill(ds_server, "t_jm_s")

                Dim s_comr As SqlClient.SqlCommandBuilder

                s_comr = New SqlClient.SqlCommandBuilder(da_server)

                Dim ret_rows As DataRow

                ret_rows = ds_server.Tables("t_jm_s").NewRow()

                ret_rows("kojinid") = newid
                ret_rows("furigana") = s_furigana
                ret_rows("name") = s_name
                If s_yuubin <> "" Then
                    ret_rows("yuubin") = s_yuubin
                End If
                If s_chiiki <> "" Then
                    ret_rows("chiikiid") = s_chiiki
                End If
                If s_juutaku <> "" Then
                    ret_rows("juutaku") = s_juutaku
                End If
                If s_juusho <> "" Then
                    ret_rows("juusho1") = s_juusho
                End If
                If s_juusho2 <> "" Then
                    ret_rows("juusho2") = s_juusho2
                End If
                If s_tel1 <> "" Then
                    ret_rows("tel1") = s_tel1
                End If
                If s_tel2 <> "" Then
                    ret_rows("tel2") = s_tel2
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
                If s_kannriid <> "" Then
                    ret_rows("kanriid") = s_kannriid
                End If
                If s_seikyuusakiid <> "" Then
                    ret_rows("seikyuusakiid") = s_seikyuusakiid
                End If
                If s_cadix <> "" Then
                    ret_rows("f_cadix") = s_cadix
                End If
                If s_secchifuri <> "" Then
                    ret_rows("k_furigana") = s_secchifuri
                End If
                If s_secchiname <> "" Then
                    ret_rows("k_name") = s_secchiname
                End If
                If s_secchijuusho <> "" Then
                    ret_rows("k_juusho") = s_secchijuusho
                End If
                If s_secchitel <> "" Then
                    ret_rows("k_tel") = s_secchitel
                End If
                If s_secchimemo <> "" Then
                    ret_rows("k_memo") = s_secchimemo
                End If
                If s_secchifuri_new <> "" Then
                    ret_rows("s_furigana") = s_secchifuri_new
                End If
                If s_secchiname_new <> "" Then
                    ret_rows("s_name") = s_secchiname_new
                End If
                If s_secchijuusho_new <> "" Then
                    ret_rows("s_juusho") = s_secchijuusho_new
                End If
                If s_secchitel_new <> "" Then
                    ret_rows("s_tel") = s_secchitel_new
                End If
                If s_secchimemo_new <> "" Then
                    ret_rows("s_memo") = s_secchimemo_new
                End If
                If s_cellid <> "" Then
                    ret_rows("cellid") = s_cellid
                End If
                If s_cellno <> "" Then
                    ret_rows("cellno") = s_cellno
                End If
                If s_setaisuu <> "" Then
                    ret_rows("setaisuu") = s_setaisuu
                End If
                If s_tvsuu <> "" Then
                    ret_rows("tvsuu") = s_tvsuu
                End If
                If s_aki <> "" Then
                    ret_rows("aki") = s_aki
                End If
                If s_q <> "" Then
                    ret_rows("qshiyou") = s_q
                End If
                If s_q_nentsuki <> "" Then
                    ret_rows("qhiduke") = s_q_nentsuki
                End If
                If s_black <> "" Then
                    ret_rows("f2") = s_black
                End If
                If s_kyuushi <> "" Then
                    ret_rows("f3") = s_kyuushi
                End If
                If s_koujihi <> "" Then
                    ret_rows("koujihi") = s_koujihi
                End If
                If s_koujihi2 <> "" Then
                    ret_rows("waribiki") = s_koujihi2
                End If
                If s_waribiki <> "" Then
                    ret_rows("koujihi2") = s_waribiki
                End If
                If s_waribiki2 <> "" Then
                    ret_rows("waribiki2") = s_waribiki2
                End If
                If s_riyuu <> "" Then
                    ret_rows("riyuu") = s_riyuu
                End If
                If s_riyuu2 <> "" Then
                    ret_rows("riyuu2") = s_riyuu2
                End If
                If s_kanyuubi <> "" Then
                    ret_rows("kanyuubi") = s_kanyuubi
                End If
                If s_kanyuubi2 <> "" Then
                    ret_rows("kanyuubi2") = s_kanyuubi2
                End If
                If s_catvsaikai <> "" Then
                    ret_rows("catv_saikai") = s_catvsaikai
                End If
                If s_catvkyuushi <> "" Then
                    ret_rows("catv_kyuushi") = s_catvkyuushi
                End If
                If s_catvkaiyaku <> "" Then
                    ret_rows("catv_kaiyaku") = s_catvkaiyaku
                End If
                If s_intersaikai <> "" Then
                    ret_rows("net_saikai") = s_intersaikai
                End If
                If s_interkyuushi <> "" Then
                    ret_rows("net_kyuushi") = s_interkyuushi
                End If
                If s_interkaiyaku <> "" Then
                    ret_rows("net_kaiyaku") = s_interkaiyaku
                End If
                If s_clkanyuubi <> "" Then
                    ret_rows("koushinbi_cl") = s_clkanyuubi
                End If
                If s_clkaiyakubi <> "" Then
                    ret_rows("cl_kaiyaku") = s_clkaiyakubi
                End If
                If s_mvnokanyuubi <> "" Then
                    ret_rows("koushinbi_mvno") = s_mvnokanyuubi
                End If
                If s_shiharaihouhou <> "" Then
                    ret_rows("seikyuu") = s_shiharaihouhou
                End If
                If s_bank <> "" Then
                    ret_rows("bankid") = s_bank
                End If
                If s_kouzashurui <> "" Then
                    ret_rows("kouzakubun") = s_kouzashurui
                End If
                If s_kouzabangou <> "" Then
                    ret_rows("kouzabangou") = s_kouzabangou
                End If
                If s_kouzameigi <> "" Then
                    ret_rows("meigi") = s_kouzameigi
                End If
                If s_card_shurui <> "" Then
                    ret_rows("card_shurui") = s_card_shurui
                End If
                If s_card_bangou <> "" Then
                    ret_rows("card_no") = s_card_bangou
                End If
                If s_card_meibi <> "" Then
                    ret_rows("card_name") = s_card_meibi
                End If
                If s_card_kigen <> "" Then
                    ret_rows("card_kigen") = s_card_kigen
                End If
                If s_kyuukouza <> "" Then
                    ret_rows("kyukouza") = s_kyuukouza
                End If
                If s_kyuukouza2 <> "" Then
                    ret_rows("kyukouza2") = s_kyuukouza2
                End If
                If s_kannrikouza <> "" Then
                    ret_rows("kanrikouza") = s_kannrikouza
                End If
                If s_nyuukinbi <> "" Then
                    ret_rows("nyuukinbi") = s_nyuukinbi
                End If
                If s_nyuukingaku <> "" Then
                    ret_rows("nyuukingaku") = s_nyuukingaku
                End If
                If s_zangaku <> "" Then
                    ret_rows("zankin") = s_zangaku
                End If
                If s_kanren_nen <> "" Then
                    ret_rows("kanrennbi") = s_kanren_nen
                End If
                If s_netwari_nentsuki <> "" Then
                    ret_rows("netwari") = s_netwari_nentsuki
                End If
                If s_ht_hoshoukin <> "" Then
                    ret_rows("ht4") = s_ht_hoshoukin
                End If

                If s_karijuusho <> "" Then
                    ret_rows("karijusho") = s_karijuusho
                End If

                If s_yuubin_meigi_chk <> "" Then
                    ret_rows("yuubin_flg") = s_yuubin_meigi_chk
                End If

                If s_nhkno <> "" Then
                    ret_rows("nhkno") = s_nhkno
                End If
                If s_nhkname <> "" Then
                    ret_rows("nhkname") = s_nhkname
                End If
                If s_nhkfuri <> "" Then
                    ret_rows("nhkfuri") = s_nhkfuri
                End If
                If s_end_flg <> "" Then
                    ret_rows("end_flg") = s_end_flg
                End If
                If s_hikiotoshiichiran <> "" Then
                    ret_rows("hiki") = s_hikiotoshiichiran
                End If





                ret_rows("sakuseibi") = newitsu

                ds_server.Tables("t_jm_s").Rows.Add(ret_rows)

                da_server.Update(ds_server, "t_jm_s")

                ds_server.Clear()


                msg_go("データを登録しました。", 64)


            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try
        Else
            '修正


            Dim cn_shounin As New SqlConnection
            Dim da_shounin As New SqlDataAdapter
            Dim ds_shounin As New DataSet

            Dim cmdbuilder_shounin As New SqlCommandBuilder


            Try


                cn_shounin.ConnectionString = connectionstring_sqlserver

                sql = "select * from kojin where kojinid ='" & kojinid & "'"



                da_shounin = New SqlDataAdapter(sql, cn_shounin)

                da_shounin.Fill(ds_shounin, "t_jouhouhens")


                '書き込み


                ds_shounin.Tables("t_jouhouhens").Rows(0)("furigana") = s_furigana
                ds_shounin.Tables("t_jouhouhens").Rows(0)("name") = s_name
                If s_yuubin <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("yuubin") = s_yuubin
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("yuubin") = DBNull.Value
                End If
                If s_chiiki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("chiikiid") = s_chiiki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("chiikiid") = DBNull.Value
                End If
                If s_juutaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juutaku") = s_juutaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juutaku") = DBNull.Value
                End If
                If s_juusho <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juusho1") = s_juusho
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juusho1") = DBNull.Value
                End If
                If s_juusho2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juusho2") = s_juusho2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("juusho2") = DBNull.Value
                End If
                If s_tel1 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel1") = s_tel1
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel1") = DBNull.Value
                End If
                If s_tel2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel2") = s_tel2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tel2") = DBNull.Value
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
                If s_kannriid <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanriid") = s_kannriid
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanriid") = DBNull.Value
                End If
                If s_seikyuusakiid <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuusakiid") = s_seikyuusakiid
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuusakiid") = DBNull.Value
                End If
                If s_cadix <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f_cadix") = s_cadix
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f_cadix") = DBNull.Value
                End If
                If s_secchifuri <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_furigana") = s_secchifuri
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_furigana") = DBNull.Value
                End If
                If s_secchiname <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_name") = s_secchiname
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_name") = DBNull.Value
                End If
                If s_secchijuusho <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_juusho") = s_secchijuusho
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_juusho") = DBNull.Value
                End If
                If s_secchitel <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_tel") = s_secchitel
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_tel") = DBNull.Value
                End If
                If s_secchimemo <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_memo") = s_secchimemo
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("k_memo") = DBNull.Value
                End If
                If s_secchifuri_new <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_furigana") = s_secchifuri_new
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_furigana") = DBNull.Value
                End If
                If s_secchiname_new <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_name") = s_secchiname_new
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_name") = DBNull.Value
                End If
                If s_secchijuusho_new <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_juusho") = s_secchijuusho_new
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_juusho") = DBNull.Value
                End If
                If s_secchitel_new <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_tel") = s_secchitel_new
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_tel") = DBNull.Value
                End If
                If s_secchimemo_new <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_bikou") = s_secchimemo_new
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("s_bikou") = DBNull.Value
                End If
                If s_cellid <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cellid") = s_cellid
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cellid") = DBNull.Value
                End If
                If s_cellno <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cellno") = s_cellno
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cellno") = DBNull.Value
                End If
                If s_setaisuu <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("setaisuu") = s_setaisuu
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("setaisuu") = DBNull.Value
                End If
                If s_tvsuu <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tvsuu") = s_tvsuu
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("tvsuu") = DBNull.Value
                End If
                If s_aki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("aki") = s_aki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("aki") = DBNull.Value
                End If
                If s_q <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("qshiyou") = s_q
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("qshiyou") = DBNull.Value
                End If
                If s_q_nentsuki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("qhiduke") = s_q_nentsuki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("qhiduke") = DBNull.Value
                End If
                If s_black <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f2") = s_black
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f2") = DBNull.Value
                End If
                If s_kyuushi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f3") = s_kyuushi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("f3") = DBNull.Value
                End If
                If s_koujihi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koujihi") = s_koujihi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koujihi") = DBNull.Value
                End If
                If s_koujihi2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("waribiki") = s_koujihi2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("waribiki") = DBNull.Value
                End If
                If s_waribiki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koujihi2") = s_waribiki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koujihi2") = DBNull.Value
                End If
                If s_waribiki2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("waribiki2") = s_waribiki2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("waribiki2") = DBNull.Value
                End If
                If s_riyuu <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("riyuu") = s_riyuu
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("riyuu") = DBNull.Value
                End If
                If s_riyuu2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("riyuu2") = s_riyuu2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("riyuu2") = DBNull.Value
                End If
                If s_kanyuubi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanyuubi") = s_kanyuubi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanyuubi") = DBNull.Value
                End If
                If s_kanyuubi2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanyuubi2") = s_kanyuubi2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanyuubi2") = DBNull.Value
                End If
                If s_catvsaikai <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_saikai") = s_catvsaikai
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_saikai") = DBNull.Value
                End If
                If s_catvkyuushi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_kyuushi") = s_catvkyuushi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_kyuushi") = DBNull.Value
                End If
                If s_catvkaiyaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_kaiyaku") = s_catvkaiyaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("catv_kaiyaku") = DBNull.Value
                End If
                If s_intersaikai <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_saikai") = s_intersaikai
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_saikai") = DBNull.Value
                End If
                If s_interkyuushi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_kyuushi") = s_interkyuushi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_kyuushi") = DBNull.Value
                End If
                If s_interkaiyaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_kaiyaku") = s_interkaiyaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("net_kaiyaku") = DBNull.Value
                End If
                If s_clkanyuubi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koushinbi_cl") = s_clkanyuubi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koushinbi_cl") = DBNull.Value
                End If
                If s_clkaiyakubi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cl_kaiyaku") = s_clkaiyakubi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("cl_kaiyaku") = DBNull.Value
                End If
                If s_mvnokanyuubi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koushinbi_mvno") = s_mvnokanyuubi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("koushinbi_mvno") = DBNull.Value
                End If
                If s_shiharaihouhou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuu") = s_shiharaihouhou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("seikyuu") = DBNull.Value
                End If
                If s_bank <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("bankid") = s_bank
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("bankid") = DBNull.Value
                End If
                If s_kouzashurui <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kouzakubun") = s_kouzashurui
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kouzakubun") = DBNull.Value
                End If
                If s_kouzabangou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kouzabangou") = s_kouzabangou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kouzabangou") = DBNull.Value
                End If
                If s_kouzameigi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("meigi") = s_kouzameigi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("meigi") = DBNull.Value
                End If
                If s_card_shurui <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_shurui") = s_card_shurui
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_shurui") = DBNull.Value
                End If
                If s_card_bangou <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_no") = s_card_bangou
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_no") = DBNull.Value
                End If
                If s_card_meibi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_name") = s_card_meibi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_name") = DBNull.Value
                End If
                If s_card_kigen <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_kigen") = s_card_kigen
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("card_kigen") = DBNull.Value
                End If
                If s_kyuukouza <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kyukouza") = s_kyuukouza
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kyukouza") = DBNull.Value
                End If
                If s_kyuukouza2 <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kyukouza2") = s_kyuukouza2
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kyukouza2") = DBNull.Value
                End If
                If s_kannrikouza <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanrikouza") = s_kannrikouza
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanrikouza") = DBNull.Value
                End If
                If s_nyuukinbi <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nyuukinbi") = s_nyuukinbi
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nyuukinbi") = DBNull.Value
                End If
                If s_nyuukingaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nyuukingaku") = s_nyuukingaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nyuukingaku") = DBNull.Value
                End If
                If s_zangaku <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("zankin") = s_zangaku
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("zankin") = DBNull.Value
                End If
                If s_kanren_nen <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanrennbi") = s_kanren_nen
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("kanrennbi") = DBNull.Value
                End If
                If s_netwari_nentsuki <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("netwari") = s_netwari_nentsuki
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("netwari") = DBNull.Value
                End If
                If s_ht_hoshoukin <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("ht4") = s_ht_hoshoukin
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("ht4") = DBNull.Value
                End If
                If s_karijuusho <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("karijusho") = s_karijuusho
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("karijusho") = DBNull.Value
                End If
                If s_yuubin_meigi_chk <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("yuubin_flg") = s_yuubin_meigi_chk
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("yuubin_flg") = DBNull.Value
                End If


                If s_nhkno <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkno") = s_nhkno
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkno") = DBNull.Value
                End If
                If s_nhkname <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkname") = s_nhkname
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkname") = DBNull.Value
                End If
                If s_nhkfuri <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkfuri") = s_nhkfuri
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("nhkfuri") = DBNull.Value
                End If

                If s_end_flg <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("end_flg") = s_end_flg
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("end_flg") = DBNull.Value
                End If

                If s_hikiotoshiichiran <> "" Then
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("hiki") = s_hikiotoshiichiran
                Else
                    ds_shounin.Tables("t_jouhouhens").Rows(0)("hiki") = DBNull.Value
                End If






                cmdbuilder_shounin.DataAdapter = da_shounin

                da_shounin.Update(ds_shounin, "t_jouhouhens")

                ds_shounin.Clear()
            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try






        End If

        mainset(kojinid)

        msg_go("更新しました。", 64)

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmkojin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If cmbbank.SelectedIndex = -1 Then
            msg_go("金融機関名が選択されていません。")
            Exit Sub
        End If
        txtkyuukouza.Text = cmbbank.Text

        If rfutsuu.Checked = True Then
            txtkyuukouza2.Text = "当座 " & Trim(txtkouzabangou.Text) & Space(1) & Trim(txtkouzameigi.Text)
        ElseIf rtouza.Checked = True Then
            txtkyuukouza2.Text = "普通 " & Trim(txtkouzabangou.Text) & Space(1) & Trim(txtkouzameigi.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        cmbcellid.SelectedIndex = -1
        cmbcellno.SelectedIndex = -1

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Dim s_msg As String = InputBox("パスワードを入力して下さい。", "パスワード")

        If s_msg = "" Then
            Exit Sub
        End If

        Dim s_kojinid As String = Trim(lblkojinid.Text)

        '修正


        Dim cn_shounin As New SqlConnection
        Dim da_shounin As New SqlDataAdapter
        Dim ds_shounin As New DataSet

        Dim cmdbuilder_shounin As New SqlCommandBuilder


        Try


            cn_shounin.ConnectionString = connectionstring_sqlserver

            Sql = "select * from kojin where kojinid ='" & s_kojinid & "'"



            da_shounin = New SqlDataAdapter(Sql, cn_shounin)

            da_shounin.Fill(ds_shounin, "t_jouhouhens")


            '書き込み

            ds_shounin.Tables("t_jouhouhens").Rows(0)("f2") = "0"


            cmdbuilder_shounin.DataAdapter = da_shounin

            da_shounin.Update(ds_shounin, "t_jouhouhens")

            ds_shounin.Clear()
        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try



        mainset(s_kojinid)

        msg_go("更新しました。", 64)

        Me.Close()
        Me.Dispose()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        frmbank_shien.ShowDialog()


    End Sub


End Class