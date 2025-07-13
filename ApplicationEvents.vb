Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' 次のイベントは MyApplication に対して利用できます:
    ' Startup:アプリケーションが開始されたとき、スタートアップ フォームが作成される前に発生します。
    ' Shutdown:アプリケーション フォームがすべて閉じられた後に発生します。このイベントは、アプリケーションが異常終了したときには発生しません。
    ' UnhandledException:ハンドルされない例外がアプリケーションで発生したときに発生します。
    ' StartupNextInstance:単一インスタンス アプリケーションが起動され、それが既にアクティブであるときに発生します。 
    ' NetworkAvailabilityChanged:ネットワーク接続が接続されたとき、または切断されたときに発生します。
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            '2重起動防止
            If Diagnostics.Process.GetProcessesByName(
             Diagnostics.Process.GetCurrentProcess.ProcessName).Length > 1 Then
                'すでに起動していると判断する
                msg_go("多重起動はできません")
                End
            End If

            kidoupassword = "kamifusafusa"

            '総合パス
            sougou_path = GetAppPath()

            DESKTOP_PATH = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)


            ver_file_path = sougou_path & "\spsales_ver.exe"

            settei_mdb_path = sougou_path & "\cliant.mdb"

            print_mdb_path = sougou_path & "\print.mdb"


            If Dir(ver_file_path) = "" Then
                msg_go("spsales_ver.exeファイルが見つかりません。")
                System.Windows.Forms.Application.DoEvents()
                ' End
            End If

            If Dir(settei_mdb_path) = "" Then
                msg_go("cliant.mdbファイルが見つかりません。")
                System.Windows.Forms.Application.DoEvents()
                End
            End If

            If Dir(print_mdb_path) = "" Then
                msg_go("print.mdbファイルが見つかりません。")
                System.Windows.Forms.Application.DoEvents()
                'End
            End If


            log_path = sougou_path & "\log\"
            If System.IO.Directory.Exists(log_path) Then
            Else
                System.IO.Directory.CreateDirectory(log_path)
            End If


            temp_path = sougou_path & "\temp"
            If System.IO.Directory.Exists(temp_path) Then
            Else
                System.IO.Directory.CreateDirectory(temp_path)
            End If



            '接続文字列
            connectionstring_mdb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & settei_mdb_path & ";Jet OLEDB:Database Password=kamifusafusa"


            'パスワード



            settei_res = Setting1(29, 0, "", 0)

            If settei_res = "0" Then
                msg_go("PDFファイルの保存先の設定がされていません。")
                System.Windows.Forms.Application.DoEvents()
                End
            Else
                hozonsaki_path = settei_res
            End If



            newserver(0) = "133.167.100.26" ' "192.168.40.27" ' "153.127.48.237"
            newserver(1) = "sa"
            newserver(2) = "Plot8877Ken"

            '接続文字

            connectionstring_sqlserver = "Data Source=" & newserver(0) & ";Initial Catalog=spsales;" &
                           "User ID=" & newserver(1) & ";Password=" & newserver(2) & ";"



        End Sub
    End Class
End Namespace
