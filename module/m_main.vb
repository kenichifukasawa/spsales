Imports System.Data.OleDb
Imports System.Data.SqlClient

Module m_main

    Public newserver(3) As String
    Public sougou_path As String

    Public s_soushin_data(4, 0) As String
    Public s_soushin_suu As Integer

    Public ret
    Public Sql As String

    Public connectionstring_sqlserver As String
    Public connectionstring_mdb As String

    Public settei_res

    Public hozonsaki_path As String
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


            cmd_setting.CommandText = "select * from settei where id ='" & CStr(No + 1) & "'"


            cn_setting.Open()


            dr_setting = cmd_setting.ExecuteReader()
            Do While dr_setting.Read()
                Setting1 = dr_setting(id)
                Exit Do
            Loop
            dr_setting.Close()

        Else '書き込み


            cmd_setting.CommandText = "update settei set s" & CStr(id) & "='" & newid & "' where id='" & CStr(No + 1) & "'"


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
End Module
