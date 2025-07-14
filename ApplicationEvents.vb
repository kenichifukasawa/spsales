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

            '総合パス
            sougou_path = GetAppPath()
            DESKTOP_PATH = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)

            'newserver(0) = "192.168.40.27" ' "153.127.48.237"
            newserver(0) = "133.167.100.26" ' TODO：Debug
            newserver(1) = "sa"
            newserver(2) = "Plot8877Ken"

            '接続文字

            connectionstring_sqlserver = "Data Source=" & newserver(0) & ";Initial Catalog=spsales;" &
                           "User ID=" & newserver(1) & ";Password=" & newserver(2) & ";"

            Dim settei_mdb_path As String = sougou_path & "\cliant.mdb"
            'Dim settei_mdb_path As String = "C:\Users\Administrator\Documents\開発_plot\spsales_pdf\spsales_pdf\bin\Debug\cliant.mdb"

            '接続文字列
            connectionstring_mdb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & settei_mdb_path & ";Jet OLEDB:Database Password=kamifusafusa"

            If Dir(settei_mdb_path) = "" Then
                msg_go("cliant.mdbファイルが見つかりません。")
                System.Windows.Forms.Application.DoEvents()
                End
            Else

                settei_res = Setting1(29, 0, "", 0)

                If settei_res = "0" Then
                    msg_go("PDFファイルの保存先の設定がされていません。")
                    System.Windows.Forms.Application.DoEvents()
                    End
                Else
                    hozonsaki_path = settei_res
                End If

            End If







        End Sub
    End Class
End Namespace
