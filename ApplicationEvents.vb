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

            '待機画面
            frmhajime.Show()
            System.Windows.Forms.Application.DoEvents()

            BARSHINKOU("初期設定ロード中・・")


            kidoupassword = "kamifusafusa"

            '総合パス
            sougou_path = GetAppPath()

            DESKTOP_PATH = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)


            ver_file_path = sougou_path & "\spsales_copy.exe"

            map_exe_path = sougou_path & "\ezmanager_map.exe"

            settei_mdb_path = sougou_path & "\cliant.mdb"

            print_mdb_path = sougou_path & "\print.mdb"


            If Dir(map_exe_path) = "" Then
                msg_go("ezmanager_map.exeファイルが見つかりません。")
                System.Windows.Forms.Application.DoEvents()
                ' End
            End If

            If Dir(ver_file_path) = "" Then
                msg_go("spsales_copy.exeファイルが見つかりません。")
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





            BARSHINKOU("初期設定ロード完了！")

            'パスワード
            frmlogin.ShowDialog()



            '自動バージョンアップ
            'バージョンアップパス
            BARSHINKOU("システムのチェック中・・・")
            'バージョンアップパス
            settei_res = Setting1(16, 0, "", 0)

#If DEBUG Then
            settei_res = "c:\"
#End If

            If settei_res = "0" Then
                msg_go("あとで、バックアップパスの設定を行って下さい。", 16)
            Else
                versionup_path = settei_res

                If System.IO.Directory.Exists(versionup_path) Then

                Else
                    msg_go("バージョンアップパスが無効です。ネットワークを確認して下さい。", 16)
                End If
            End If


            If versionup_path <> "" Then
                If System.IO.Directory.Exists(versionup_path) = True Then
                    '    'システムのバージョンアップ
                    system_check(versionup_path)
                End If
            End If


            BARSHINKOU("システムのチェック完了！")



            BARSHINKOU("設定ファイルのチェック中・・・")


            BARSHINKOU("サーバーの設定チェック中・・・" & newserver(0))
            'サーバ
            settei_res = Setting1(20, 0, "", 0)
            If settei_res = "0" Then
                newserver(0) = ""
            Else
                newserver(0) = settei_res
            End If

            settei_res = Setting1(21, 0, "", 0)
            If settei_res = "0" Then
                newserver(3) = ""
            Else
                newserver(3) = settei_res
            End If

            settei_res = Setting1(22, 0, "", 0)
            If settei_res = "0" Then
                newserver(1) = ""
            Else
                newserver(1) = settei_res
            End If

            settei_res = Setting1(23, 0, "", 0)
            If settei_res = "0" Then
                newserver(2) = ""
            Else
                newserver(2) = settei_res
            End If

            '初期
            If newserver(0) = "" Or newserver(0) = "" Or newserver(0) = "" Or newserver(0) = "" Then



            End If


#If DEBUG Then
            newserver(0) = "133.167.100.26" ' "192.168.40.27" ' "153.127.48.237"
            newserver(1) = "sa"
            newserver(2) = "Plot8877Ken"
            newserver(3) = "spsales"
#End If

            BARSHINKOU("サーバーの設定チェック完了！" & newserver(0))



            '接続文字

            connectionstring_sqlserver = "Data Source=" & newserver(0) & ";Initial Catalog=" & newserver(3) & ";" &
                           "User ID=" & newserver(1) & ";Password=" & newserver(2) & ";"

            'PC名
            settei_res = Setting1(3, 0, "", 0)
            If settei_res = "0" Then
                ' ret = MsgBox("ユーザー名を設定してください。設定しないと商品を発注できません。", 16, "総合管理システム「SPSALES」")
                msg_go("ユーザー名を設定してください。設定しないと商品を発注できません。")
                frmmain.lblpcname.Text = ""
            Else
                frmmain.lblpcname.Text = settei_res
            End If



            BARSHINKOU("システムの保存先初期化完了")


            frmhajime.Close()
            frmhajime.Dispose()

        End Sub
    End Class
End Namespace
