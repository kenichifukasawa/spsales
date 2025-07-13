Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Module m_main

    Public newserver(3) As String
    Public sougou_path As String

    Public hozonsaki_path As String
    Public DESKTOP_PATH As String

    Public settei_mdb_path As String
    Public print_mdb_path As String
    Public ver_file_path As String

    Public temp_path As String
    Public log_path As String


    Public kidoupassword As String

    Public s_soushin_data(4, 0) As String
    Public s_soushin_suu As Integer

    Public ret
    Public Sql As String

    Public connectionstring_sqlserver As String
    Public connectionstring_mdb As String

    Public settei_res




    Public result As DialogResult


    Public s_from As String
    Public s_dai As String
    Public s_honbun As String
    Public s_user As String
    Public s_pw As String
    Public s_port As Long
    Public s_host As String

    Public s_file_name As String = ""
    Public s_file_path As String = ""
    Public s_mailadress As String = ""
    Public s_mailadress_cc() As String

    Function setting2(id As Integer, ByVal docchi As Integer, ByVal retsu As String, ByVal newid As String) As String

        '******* サーバの設定を参照・更新　*********

        Dim cn_setting2 As New SqlConnection
        Dim da_setting2 As New SqlDataAdapter
        Dim ds_setting2 As New DataSet
        Dim dt_setting2 As DataTable
        Dim cmdbuilder As New SqlCommandBuilder
        Dim mojiretsu_setting2 As String


        Try



            cn_setting2.ConnectionString = connectionstring_sqlserver

            Sql = "select * from settei where id ='" & retsu & "'"
            setting2 = "0"


            da_setting2 = New SqlDataAdapter(Sql, cn_setting2)

            da_setting2.Fill(ds_setting2, "t_settei2")

            If docchi = 0 Then '読み込み

                dt_setting2 = ds_setting2.Tables("t_settei2")

                mojiretsu_setting2 = dt_setting2.Rows(0)(id)

                setting2 = mojiretsu_setting2

            Else '書き込み
                ds_setting2.Tables("t_settei2").Rows(0)(id) = newid

                cmdbuilder.DataAdapter = da_setting2

                da_setting2.Update(ds_setting2, "t_settei2")
            End If
            ds_setting2.Clear()
            Exit Function


        Catch ex As Exception
            setting2 = "-1"
            msg_go("設定を参照できませんでした：" & ex.Message)
        End Try

    End Function

    Sub mainset(s_tenpoid As String)

        tenpo_main_set(s_tenpoid)

        tenpo_hachuurireki_set(s_tenpoid)

        tenpo_seikyuurireki_set(s_tenpoid)

        tenpo_log_set(s_tenpoid)


    End Sub
    Sub tenpo_hachuurireki_set(s_tenpoid As String)

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver


            Sql = "SELECT hacchuu.*,shain.ryakumei" &
                    " FROM hacchuu right join shain" &
                    " on hacchuu.shainid=shain.shainid" &
                    " where tenpoid='" & s_tenpoid & "'and joukyou='0' ORDER BY iraibi DESC"


            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(5) As String

            With frmmain.dgv_nouhinsho

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 5
                .Columns(0).Name = "納品日"
                .Columns(1).Name = "伝票NO"
                .Columns(2).Name = "金額"
                .Columns(3).Name = "社員名"
                .Columns(4).Name = "納品書ID"
                .Columns(0).Width = 90
                .Columns(1).Width = 90
                .Columns(2).Width = 90
                .Columns(3).Width = 80
                .Columns(4).Width = 100

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor _
                                                        = Color.LightBlue
            End With

            Dim s_kin As Decimal

            For i = 0 To dt_server.Rows.Count - 1
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("hacchuuid"))
                mojiretsu(0) = Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 7, 2)



                s_kin = dt_server.Rows.Item(i).Item("goukei")
                mojiretsu(2) = s_kin.ToString("#,##0")

                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("shainid")) & " " & Trim(dt_server.Rows.Item(i).Item("ryakumei"))


                If IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    mojiretsu(4) = ""
                Else
                    mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If



                frmmain.dgv_nouhinsho.Rows.Add(mojiretsu)
            Next i
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)

        End Try

    End Sub
    Sub tenpo_seikyuurireki_set(s_tenpoid As String)

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver


            Sql = "SELECT * FROM seikyuusho" &
                    " where tenpoid='" & s_tenpoid & "' ORDER BY hiduke DESC,seikyuushoid DESC"


            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(7) As String

            With frmmain.dgv_seikyuusho

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 7
                .Columns(0).Name = "日時"
                .Columns(1).Name = "伝票NO"
                .Columns(2).Name = "内容"
                .Columns(3).Name = "金額"
                .Columns(4).Name = "消費税"
                .Columns(5).Name = "備考"
                .Columns(6).Name = "インボイス"
                .Columns(0).Width = 90
                .Columns(1).Width = 90
                .Columns(2).Width = 100
                .Columns(3).Width = 90
                .Columns(4).Width = 0
                .Columns(5).Width = 100
                .Columns(6).Width = 0

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor _
                                                        = Color.LightBlue
            End With

            Dim s_kin As Decimal

            For i = 0 To dt_server.Rows.Count - 1
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))
                mojiretsu(0) = Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 7, 2)

                If Trim(dt_server.Rows.Item(i).Item("seikyuu_st")) = "0" Then
                    mojiretsu(2) = "請求"
                Else
                    mojiretsu(2) = "入金"
                    Select Case Trim(dt_server.Rows.Item(i).Item("seikyuutanni"))
                        Case "0"
                            mojiretsu(2) = mojiretsu(2) & " (現金)"
                        Case "1"
                            mojiretsu(2) = mojiretsu(2) & " (振込)"
                        Case "2"
                            mojiretsu(2) = mojiretsu(2) & " (小切手)"
                        Case "3"
                            mojiretsu(2) = mojiretsu(2) & " (相殺)"
                        Case "4"
                            mojiretsu(2) = mojiretsu(2) & " (手数料)"
                        Case "5"
                            mojiretsu(2) = mojiretsu(2) & " (値引)"
                        Case "6"
                            mojiretsu(2) = mojiretsu(2) & " (その他)"
                        Case "7"
                            mojiretsu(2) = mojiretsu(2) & " (クレジット)"
                        Case Else
                            mojiretsu(2) = "エラー"
                    End Select
                End If

                s_kin = dt_server.Rows.Item(i).Item("seikyuukingaku")
                mojiretsu(3) = s_kin.ToString("#,##0")

                s_kin = dt_server.Rows.Item(i).Item("shouhizei")
                mojiretsu(4) = s_kin.ToString("#,##0")


                If IsDBNull(dt_server.Rows.Item(i).Item("seikyuubikou")) Then
                    mojiretsu(5) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("seikyuubikou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("invoice")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("invoice"))
                End If


                frmmain.dgv_seikyuusho.Rows.Add(mojiretsu)
            Next i
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)

        End Try

    End Sub

    Sub tenpo_log_set(s_tenpoid As String)

    End Sub


    Sub tenpo_main_set(s_tenpoid As String)

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver

            Sql = "SELECT tenpo.*, MAILNO_M.ADRESS1, shain.shainmei" &
                " FROM shain RIGHT JOIN (MAILNO_M RIGHT JOIN tenpo ON MAILNO_M.MAILNO = tenpo.mailno)" &
                " ON shain.shainid = tenpo.shainid" &
                " WHERE tenpo.tenpoid = '" & s_tenpoid & "'"


            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")


            'With frmmain.dgv_voip

            '    .Rows.Clear()
            '    .Columns.Clear()
            '    .ColumnCount = 3
            '    .Columns(0).Name = "番号"
            '    .Columns(1).Name = "契約日"
            '    .Columns(2).Name = ""
            '    .Columns(0).Width = 100
            '    .Columns(1).Width = 100
            '    .Columns(2).Width = 0

            '    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'End With


            Dim mojiretsu(3) As String

            If dt_server.Rows.Count <> 0 Then
                With frmmain
                    .lbltenpoid.Text = Trim(dt_server.Rows.Item(0).Item("tenpoid"))
                    .lbltenpomei.Text = Trim(dt_server.Rows.Item(0).Item("tenpomei"))
                    If IsDBNull(dt_server.Rows.Item(0).Item("tenpofurigana")) Then
                        .lblfurigana.Text = ""
                    Else
                        .lblfurigana.Text = Trim(dt_server.Rows.Item(0).Item("tenpofurigana"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("insatsumei")) Then
                        .lblinsatsumeishou.Text = ""
                    Else
                        .lblinsatsumeishou.Text = Trim(dt_server.Rows.Item(0).Item("insatsumei"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("mailno")) Then
                        .lblyuubin.Text = ""
                    Else
                        .lblyuubin.Text = Trim(dt_server.Rows.Item(0).Item("mailno"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("adress1")) Then
                        .lbljuusho.Text = ""
                    Else
                        .lbljuusho.Text = Trim(dt_server.Rows.Item(0).Item("adress1"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("tenpoadress")) Then
                        '.lbljuusho.Text = ""
                    Else
                        .lbljuusho.Text = Trim(.lbljuusho.Text) & Trim(dt_server.Rows.Item(0).Item("tenpoadress"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("tel")) Then
                        .lbltel1.Text = ""
                    Else
                        .lbltel1.Text = Trim(dt_server.Rows.Item(0).Item("tel"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("keitai")) Then
                        .lblkeitai.Text = ""
                    Else
                        .lblkeitai.Text = Trim(dt_server.Rows.Item(0).Item("keitai"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("fax")) Then
                        .lblfax.Text = ""
                    Else
                        .lblfax.Text = Trim(dt_server.Rows.Item(0).Item("fax"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("daihyou")) Then
                        .lbldaihyousha.Text = ""
                    Else
                        .lbldaihyousha.Text = Trim(dt_server.Rows.Item(0).Item("daihyou"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("tantou")) Then
                        .lbltantousha.Text = ""
                    Else
                        .lbltantousha.Text = Trim(dt_server.Rows.Item(0).Item("tantou"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("juugyouinsuu")) Then
                        .lbljuugyouinsuu.Text = ""
                    Else
                        .lbljuugyouinsuu.Text = Trim(dt_server.Rows.Item(0).Item("juugyouinsuu"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("email")) Then
                        .lblemail.Text = ""
                    Else
                        .lblemail.Text = Trim(dt_server.Rows.Item(0).Item("email"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("url")) Then
                        .lblurl.Text = ""
                    Else
                        .lblurl.Text = Trim(dt_server.Rows.Item(0).Item("url"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("shimebi")) Then
                        .lblshimebi.Text = ""
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("shimebi"))
                            Case "0"
                                .lblshimebi.Text = "５日"
                            Case "1"
                                .lblshimebi.Text = "１０日"
                            Case "2"
                                .lblshimebi.Text = "１５日"
                            Case "3"
                                .lblshimebi.Text = "２０日"
                            Case "4"
                                .lblshimebi.Text = "２５日"
                            Case "5"
                                .lblshimebi.Text = "月末"
                            Case "6"
                                .lblshimebi.Text = "随時"
                            Case Else
                                .lblshimebi.Text = "エラー"
                        End Select
                    End If


                    If IsDBNull(dt_server.Rows.Item(0).Item("souhasuu")) Then
                        .lblkeisanhouhou.Text = ""
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("souhasuu"))
                            Case "0"
                                .lblkeisanhouhou.Text = "請求書毎"
                            Case "1"
                                .lblkeisanhouhou.Text = "納品書毎"
                            Case Else
                                .lblkeisanhouhou.Text = "エラー"
                        End Select
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("zeihasuu")) Then
                        .lblhasuu.Text = ""
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("zeihasuu"))
                            Case "0"
                                .lblhasuu.Text = "切り捨て"
                            Case "1"
                                .lblhasuu.Text = "四捨五入"
                            Case "2"
                                .lblhasuu.Text = "切り上げ"
                            Case Else
                                .lblhasuu.Text = "エラー"
                        End Select
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("kubun")) Then
                        .lblkubun.Text = ""
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("kubun"))
                            Case "0"
                                .lblkubun.Text = "会社単位"
                            Case "1"
                                .lblkubun.Text = "店舗単位"
                            Case "2"
                                .lblkubun.Text = "いろいろ"
                            Case Else
                                .lblkubun.Text = "エラー"
                        End Select
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("bikou")) Then
                        .lblbikou.Text = ""
                    Else
                        .lblbikou.Text = Trim(dt_server.Rows.Item(0).Item("bikou"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("kurikoshi")) Then
                        .lblkurikoshikingaku.Text = ""
                    Else
                        .lblkurikoshikingaku.Text = Trim(dt_server.Rows.Item(0).Item("kurikoshi"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("seikyuubi")) Then
                        .lblzenkaiseikyuubi.Text = ""
                    Else
                        .lblzenkaiseikyuubi.Text = Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 7, 2)
                    End If


                End With
            End If
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)

        End Try


    End Sub

    Public Function SendMail(s_from As String, ByVal strMailAdr() As String,
                            Optional ByVal strMailCC() As String = Nothing,
                            Optional ByVal strMailSubject As String = "",
                            Optional ByVal strBody As String = "",
                            Optional ByVal File_NAME As String = "") As Boolean
        Try
            Dim i As Integer
            ''【メールの送信】
            ''文字コード
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
            ''メッセージの作成
            Dim msg As New System.Net.Mail.MailMessage()
            ''件名と本文の文字コードを指定する
            msg.SubjectEncoding = enc
            msg.BodyEncoding = enc
            ''送信者
            msg.From = New System.Net.Mail.MailAddress(s_from, "", enc)
            ''宛先
            For i = 0 To UBound(strMailAdr)
                If strMailAdr(i) <> "" Then
                    msg.To.Add(New System.Net.Mail.MailAddress(strMailAdr(i), "", enc))
                End If
            Next
            ''CC
            If Not IsNothing(strMailCC) Then
                For i = 0 To UBound(strMailCC)
                    If strMailCC(i) <> "" Then
                        msg.CC.Add(New System.Net.Mail.MailAddress(strMailCC(i), "", enc))
                    End If
                Next
            End If
            ''件名
            msg.Subject = strMailSubject
            ''本文
            msg.Body = strBody
            ''ファイルを添付する
            If File_NAME <> "" Then
                Dim attach1 As New System.Net.Mail.Attachment(File_NAME)
                msg.Attachments.Add(attach1)
            End If
            ''SMTPサーバーを指定する
            Dim sc As New System.Net.Mail.SmtpClient()
            sc.Host = s_host  ' "XXXXXX"
            sc.Credentials = New System.Net.NetworkCredential(s_user, s_pw)
            ''【メッセージを送信する】
            Try
                sc.Port = s_port  '587
                sc.Send(msg)
            Catch ex As Exception
                Throw ex
            Finally
                ''後始末
                msg.Dispose()
            End Try

            SendMail = True

            'log_add("請求書のメール送信完了")

            Return True
        Catch ex As Exception
            'Throw ex
            log_add(ex.Message)
            SendMail = False
        End Try
    End Function

    Sub log_add(s_str As String, Optional s_no As String = "")

        DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        If s_no <> "" Then
            frmseikyuusho_soushin_log.txtlog.Text = Trim(frmseikyuusho_soushin_log.txtlog.Text) & Chr(13) & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " " & s_str

            System.Windows.Forms.Application.DoEvents()
        End If


        'ログ記録

        ' hozonsaki_path = "C:\Users\Administrator\Desktop\ログ"

        Dim logfile As String = hozonsaki_path & "\log\mail_" & DateTime.Now.ToString("yyyyMMdd") & "_log.txt"


        Try
            Dim enc2 As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            Dim sr As New System.IO.StreamWriter(logfile, True, enc2) '開く

            'フィールドを書き込む
            'sr.Write(kakikomistr)
            sr.WriteLine(DateTime.Now.ToString("yyyy/MM/dd") & " " & DateTime.Now.ToString("HH:mm:ss") & " " & s_str)
            '閉じる
            sr.Close()

        Catch ex As Exception
            'ログ記録
            msg_go("ログの登録に失敗しました。" & ex.Message)
        End Try



    End Sub

    Function GetAppPath() As String
        Return System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location)
    End Function
    Sub msg_go(ByVal msgmsg As String, Optional ByVal No As Integer = 16)
        If No = 16 Then
            ret = MsgBox(msgmsg, 16, "SpSales")
        Else
            ret = MsgBox(msgmsg, No, "SpSales")
        End If
    End Sub
    Function Setting1(ByVal id As Integer, ByVal docchi As Integer, ByVal newid As String, ByVal No As Integer) As String

        '******  クライアントの設定を参照・更新 ********

        Dim sql_setstr As String
        Dim cn_setting As New OleDbConnection
        Dim cmd_setting As New OleDbCommand
        Dim dr_setting As OleDbDataReader
        Dim i_setting As Integer

        Setting1 = "0"

        On Error GoTo errsetting

        cn_setting.ConnectionString = connectionstring_mdb

        cmd_setting.Connection = cn_setting

        If docchi = 0 Then '読み込み

            cmd_setting.CommandText = "select * from settei where id ='" & CStr(No) & "'"

            cn_setting.Open()

            dr_setting = cmd_setting.ExecuteReader()
            Do While dr_setting.Read()
                Setting1 = dr_setting(id)
                Exit Do
            Loop
            dr_setting.Close()

        Else '書き込み

            cmd_setting.CommandText = "update settei set s" & CStr(id) & "='" & newid & "' where id='" & CStr(No) & "'"

            cn_setting.Open()

            cmd_setting.ExecuteNonQuery()
            Setting1 = "1"

        End If

        cn_setting.Close()
        On Error GoTo 0
        Exit Function

errsetting:
        Setting1 = "-1"
        Exit Function

    End Function

    Function get_settings(id As Integer, s_no As Integer) As String

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM settei WHERE id = '" + id.ToString + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_shain_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_shain_ichiran")

            If dt_server.Rows.Count = 0 Then
                Return ""
            End If

            Dim response = Trim(dt_server.Rows.Item(0).Item("s" + s_no.ToString))

            dt_server.Clear()
            ds_server.Clear()

            Return response

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

    Function update_settings(id As Integer, s_no As Integer, new_value As String) As Boolean

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM settei WHERE id = '" + id.ToString + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_settei")

            ds.Tables("t_settei").Rows(0)("s" + s_no.ToString) = new_value

            Dim cb As New SqlCommandBuilder
            cb.DataAdapter = da
            da.Update(ds, "t_settei")
            ds.Clear()

            Return True

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

    End Function

    Function get_tsuki_saishuubi(nen As String, tsuki As String)

        Dim int_nen As Integer = CInt(nen)
        Dim int_tsuki As Integer = CInt(tsuki)
        Dim tsuki_saishuubi As Integer = DateTime.DaysInMonth(int_nen, int_tsuki)
        Return tsuki_saishuubi.ToString("D2")

    End Function

    Function output_csv_by_data_grid_view(filePath As String, dataGridView As DataGridView, Optional columnsToExport As String() = Nothing) As Boolean

        ' columnsToExportを指定しなければ、DataGridViewのものがそのまま入る

        If columnsToExport Is Nothing Then
            columnsToExport = dataGridView.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) c.Name.Replace(vbCrLf, "")).ToArray()
        End If

        Try
            ' Shift-JIS で出力（Excel のデフォルトエンコーディング）
            Using sw As New StreamWriter(filePath, False, Encoding.GetEncoding("Shift_JIS"))
                ' ヘッダーを書き込む
                Dim header As String = String.Join(",", columnsToExport)
                sw.WriteLine(header)

                ' 行データを書き込む
                For Each row As DataGridViewRow In dataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim line As String = String.Join(",", columnsToExport.Select(
                                                         Function(col)
                                                             ' DataGridView の列名も同じ処理を適用して検索
                                                             Dim column As DataGridViewColumn = dataGridView.Columns.Cast(Of DataGridViewColumn)().FirstOrDefault(Function(c) c.Name.Replace(vbCrLf, "") = col)
                                                             If column IsNot Nothing Then
                                                                 Dim cellObj As Object = row.Cells(column.Index).Value
                                                                 Dim cellValue As String = ""
                                                                 If cellObj IsNot Nothing Then
                                                                     ' カラム型またはセル値型が数値型ならカンマ区切り
                                                                     Dim isNumberType As Boolean =
                                                                         (column.ValueType IsNot Nothing AndAlso
                                                                          (column.ValueType Is GetType(Integer) OrElse
                                                                           column.ValueType Is GetType(Int64) OrElse
                                                                           column.ValueType Is GetType(Double) OrElse
                                                                           column.ValueType Is GetType(Decimal) OrElse
                                                                           column.ValueType Is GetType(Single))) OrElse
                                                                         (TypeOf cellObj Is Integer OrElse
                                                                          TypeOf cellObj Is Int64 OrElse
                                                                          TypeOf cellObj Is Double OrElse
                                                                          TypeOf cellObj Is Decimal OrElse
                                                                          TypeOf cellObj Is Single)
                                                                     If isNumberType Then
                                                                         cellValue = Convert.ToDecimal(cellObj).ToString("#,0")
                                                                     Else
                                                                         cellValue = cellObj.ToString()
                                                                     End If
                                                                     Return $"""{cellValue.Replace("""", """""")}"""
                                                                 Else
                                                                     Return """"""
                                                                 End If
                                                             Else
                                                                 Return """"""
                                                             End If
                                                         End Function))
                        sw.WriteLine(line)
                    End If
                Next

            End Using

        Catch ex As Exception
            msg_go("CSVファイル作成中にエラーが発生しました: " & ex.Message)
            Return False
        End Try

        Return True

    End Function

End Module
