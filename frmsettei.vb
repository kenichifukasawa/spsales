Imports System.Data.SqlClient

Public Class frmsettei
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = MessageBox.Show("コンバート処理をしますか？", "SPSALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then
            Exit Sub
        End If

        'kojinに郵便局初期FLGを追加
        Dim result2 As String = MessageBox.Show("「shouhinkubun」のリサイズとコンバートをしますか？", "SPSALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result2 = DialogResult.Yes Then
            ' 接続文字列を環境に合わせて修正してください
            Using cn As New SqlConnection(connectionstring_sqlserver)
                cn.Open()
                Dim sql1 As String = "ALTER TABLE shouhinkubun ALTER COLUMN shouhinkubunid nvarchar(3) NOT NULL;"
                Using cmd1 As New SqlCommand(sql1, cn)
                    cmd1.ExecuteNonQuery()
                End Using

                Dim sql2 As String = "ALTER TABLE shouhinkubun2 ALTER COLUMN shouhinkubunid nvarchar(3) NOT NULL;"
                Using cmd2 As New SqlCommand(sql2, cn)
                    cmd2.ExecuteNonQuery()
                End Using

                ' データをゼロ埋めで3桁に変換
                Dim sql12 As String = "UPDATE shouhinkubun SET shouhinkubunid = RIGHT('000' + code, 3);"
                Using cmd12 As New SqlCommand(sql12, cn)
                    cmd12.ExecuteNonQuery()
                End Using

                ' データをゼロ埋めで3桁に変換
                Dim sql22 As String = "UPDATE shouhinkubun2 SET shouhinkubunid = RIGHT('000' + code, 3);"
                Using cmd22 As New SqlCommand(sql22, cn)
                    cmd22.ExecuteNonQuery()
                End Using



            End Using

        End If


        ''kojinに郵便局初期FLGを追加
        'Dim result2 As String = MessageBox.Show("「yuubin_flg」を追加しますか？", "SPSALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        'If result2 = DialogResult.Yes Then
        '    ' 接続文字列を環境に合わせて修正してください
        '    ' Dim connectionString As String = "Server=サーバー名;Database=データベース名;User Id=ユーザー名;Password=パスワード;"
        '    Using cn As New SqlConnection(connectionstring_sqlserver)
        '        cn.Open()
        '        Dim sql As String = "ALTER TABLE kojin ADD yuubin_flg nchar(1) NULL;"
        '        Using cmd As New SqlCommand(sql, cn)
        '            cmd.ExecuteNonQuery()
        '        End Using
        '    End Using
        'End If





        msg_go("終了しました。", 64)
    End Sub

    Private Sub frmsettei_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_p_nouhinsho.Items.Add("なし")
        cmb_p_shousai.Items.Add("なし")
        cmb_p_seikyuusho.Items.Add("なし")
        Dim s As String
        For Each s In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cmb_p_nouhinsho.Items.Add(s)
            cmb_p_shousai.Items.Add(s)
            cmb_p_seikyuusho.Items.Add(s)
        Next (s)

        set_shain_cbx(4)

        'プリンター
        settei_res = Setting1(10, 0, "", 0)
        If settei_res = "0" Then
            cmb_p_nouhinsho.SelectedIndex = 0
        Else
            cmb_p_nouhinsho.Text = settei_res
        End If

        settei_res = Setting1(8, 0, "", 0)
        If settei_res = "0" Then
            cmb_p_shousai.SelectedIndex = 0
        Else
            cmb_p_shousai.Text = settei_res
        End If

        settei_res = Setting1(12, 0, "", 0)
        If settei_res = "0" Then
            cmb_p_seikyuusho.SelectedIndex = 0
        Else
            cmb_p_seikyuusho.Text = settei_res
        End If


        '個人
        'settei_res = Setting1(2, 0, "", 0)
        'If settei_res = "0" Then
        '    txtpassword.Text = ""
        'Else
        '    txtpassword.Text = settei_res
        'End If

        settei_res = Setting1(3, 0, "", 0)
        If settei_res = "0" Then
            txtuser.Text = ""
        Else
            txtuser.Text = settei_res
        End If

        settei_res = Setting1(4, 0, "", 0)
        If settei_res = "0" Then
            cmbshain.SelectedIndex = -1
        Else
            cmbshain.SelectedIndex = cmbshain.FindString(settei_res)
        End If

        settei_res = Setting1(5, 0, "", 0)
        If settei_res = "0" Then
            txtkaisha.Text = ""
        Else
            txtkaisha.Text = settei_res
        End If
        '印刷用紙番号
        settei_res = Setting1(6, 0, "", 0)
        If settei_res = "0" Then
            txtnouhinshoyoushi.Text = ""
        Else
            txtnouhinshoyoushi.Text = settei_res
        End If

        settei_res = Setting1(28, 0, "", 0)
        If settei_res = "0" Then
            txtseikyuushoyoushi.Text = ""
        Else
            txtseikyuushoyoushi.Text = settei_res
        End If



        'サーバ
        settei_res = Setting1(20, 0, "", 0)
        If settei_res = "0" Then
            txtip.Text = ""
        Else
            txtip.Text = settei_res
        End If

        settei_res = Setting1(21, 0, "", 0)
        If settei_res = "0" Then
            txtdatabase.Text = ""
        Else
            txtdatabase.Text = settei_res
        End If

        settei_res = Setting1(22, 0, "", 0)
        If settei_res = "0" Then
            txtusername.Text = ""
        Else
            txtusername.Text = settei_res
        End If

        settei_res = Setting1(23, 0, "", 0)
        If settei_res = "0" Then
            txtpass.Text = ""
        Else
            txtpass.Text = settei_res
        End If

        'バージョンアップパス
        settei_res = Setting1(16, 0, "", 0)
        If settei_res = "0" Then
            txtverpath.Text = ""
        Else
            txtverpath.Text = settei_res
        End If

        'wella保存パス
        settei_res = Setting1(15, 0, "", 0)
        If settei_res = "0" Then
            txtwella.Text = ""
        Else
            txtwella.Text = settei_res
        End If

        'バックアップパス
        settei_res = Setting1(13, 0, "", 0)
        If settei_res = "0" Then
            txtbackup.Text = ""
        Else
            txtbackup.Text = settei_res
        End If

        '同期
        settei_res = Setting1(9, 0, "", 0)
        If settei_res = "0" Then
            txtdouki.Text = ""
        Else
            txtdouki.Text = settei_res
        End If

        'マインサーバ
        settei_res = Setting1(7, 0, "", 0)
        If settei_res = "0" Then
            txtmainserverpath.Text = ""
        Else
            txtmainserverpath.Text = settei_res
        End If

        'yuubinパス
        settei_res = Setting1(25, 0, "", 0)
        If settei_res = "0" Then
            txtyuubin.Text = ""
        Else
            txtyuubin.Text = settei_res
        End If

        '請求書保存
        settei_res = Setting1(29, 0, "", 0)
        If settei_res = "0" Then
            txtseikyuu.Text = ""
        Else
            txtseikyuu.Text = settei_res
        End If



        '経理担当者
        settei_res = Trim(setting2(19, 0, "2", ""))
        If settei_res = "0" Then
            txtkeiritantou.Text = ""
        Else
            txtkeiritantou.Text = settei_res
        End If

        '適格登録番号
        settei_res = Trim(setting2(20, 0, "2", ""))
        If settei_res = "0" Then
            txttekikakubangou.Text = ""
        Else
            txttekikakubangou.Text = settei_res
        End If

        settei_res = Trim(setting2(17, 0, "2", ""))
        If settei_res = "0" Then
            chknouhinsho.Checked = False
        Else
            chknouhinsho.Checked = True
        End If

        settei_res = Trim(setting2(18, 0, "2", ""))
        If settei_res = "0" Then
            chkseikyuusho.Checked = False
        Else
            chkseikyuusho.Checked = True
        End If







    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim s_new_str As String

        'プリンター
        If cmb_p_nouhinsho.SelectedIndex = -1 Then
            s_new_str = "0"
        Else
            s_new_str = cmb_p_nouhinsho.Text
        End If
        settei_res = Setting1(10, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。Print1 :" & s_new_str)
            Exit Sub
        End If

        If cmb_p_shousai.SelectedIndex = -1 Then
            s_new_str = "0"
        Else
            s_new_str = cmb_p_shousai.Text
        End If
        settei_res = Setting1(8, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。Print2 :" & s_new_str)
            Exit Sub
        End If

        If cmb_p_seikyuusho.SelectedIndex = -1 Then
            s_new_str = "0"
        Else
            s_new_str = cmb_p_seikyuusho.Text
        End If
        settei_res = Setting1(12, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。Print3 :" & s_new_str)
            Exit Sub
        End If

        '個人
        'If Trim(txtpassword.Text) = "" Then
        '    s_new_str = "0"
        'Else
        '    s_new_str = Trim(txtpassword.Text)
        'End If
        'settei_res = Setting1(2, 1, s_new_str, 0)
        'If settei_res = "-1" Then
        '    msg_go("設定の更新に失敗しました。PW :" & s_new_str)
        '    Exit Sub
        'End If

        If Trim(txtuser.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtuser.Text)
        End If
        settei_res = Setting1(3, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。user :" & s_new_str)
            Exit Sub
        End If

        If cmbshain.SelectedIndex = -1 Then
            s_new_str = "0"
        Else
            s_new_str = Mid(Trim(cmbshain.Text), 1, 3)
        End If
        settei_res = Setting1(4, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。def :" & s_new_str)
            Exit Sub
        End If

        If Trim(txtkaisha.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtkaisha.Text)
        End If
        settei_res = Setting1(5, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。kaisha :" & s_new_str)
            Exit Sub
        End If

        '印刷用紙番号
        If Trim(txtnouhinshoyoushi.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtnouhinshoyoushi.Text)
        End If
        settei_res = Setting1(6, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。paperno1 :" & s_new_str)
            Exit Sub
        End If

        If Trim(txtseikyuushoyoushi.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtseikyuushoyoushi.Text)
        End If
        settei_res = Setting1(28, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。paperno2 :" & s_new_str)
            Exit Sub
        End If

        'サーバ
        If Trim(txtip.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtip.Text)
        End If
        settei_res = Setting1(20, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。server1 :" & s_new_str)
            Exit Sub
        End If

        If Trim(txtdatabase.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtdatabase.Text)
        End If
        settei_res = Setting1(21, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。server2 :" & s_new_str)
            Exit Sub
        End If

        If Trim(txtusername.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtusername.Text)
        End If
        settei_res = Setting1(22, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。server3 :" & s_new_str)
            Exit Sub
        End If

        If Trim(txtpass.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtpass.Text)
        End If
        settei_res = Setting1(23, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。server4 :" & s_new_str)
            Exit Sub
        End If

        'バージョンアップパス
        If Trim(txtverpath.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtverpath.Text)
        End If
        settei_res = Setting1(16, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path1 :" & s_new_str)
            Exit Sub
        End If

        'wella保存パス
        If Trim(txtwella.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtwella.Text)
        End If
        settei_res = Setting1(15, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path2 :" & s_new_str)
            Exit Sub
        End If

        'バックアップパス
        If Trim(txtbackup.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtbackup.Text)
        End If
        settei_res = Setting1(13, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path3 :" & s_new_str)
            Exit Sub
        End If

        '同期
        If Trim(txtdouki.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtdouki.Text)
        End If
        settei_res = Setting1(9, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path4 :" & s_new_str)
            Exit Sub
        End If

        'マインサーバ
        If Trim(txtmainserverpath.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtmainserverpath.Text)
        End If
        settei_res = Setting1(7, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path5 :" & s_new_str)
            Exit Sub
        End If

        'yuubinパス
        If Trim(txtyuubin.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtyuubin.Text)
        End If
        settei_res = Setting1(25, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path6 :" & s_new_str)
            Exit Sub
        End If

        '請求書保存
        If Trim(txtseikyuu.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtseikyuu.Text)
        End If
        settei_res = Setting1(29, 1, s_new_str, 0)
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。path7 :" & s_new_str)
            Exit Sub
        End If

        '経理担当者
        If Trim(txtkeiritantou.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txtkeiritantou.Text)
        End If
        settei_res = Trim(setting2(19, 1, "2", s_new_str))
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。経理担当者 :" & s_new_str)
            Exit Sub
        End If

        '適格登録番号
        If Trim(txttekikakubangou.Text) = "" Then
            s_new_str = "0"
        Else
            s_new_str = Trim(txttekikakubangou.Text)
        End If
        settei_res = Trim(setting2(20, 1, "2", s_new_str))
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。適格登録番号 :" & s_new_str)
            Exit Sub
        End If

        If chknouhinsho.Checked = False Then
            s_new_str = "0"
        Else
            s_new_str = "1"
        End If
        settei_res = Trim(setting2(17, 1, "2", s_new_str))
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。納品書対応 :" & s_new_str)
            Exit Sub
        End If

        If chkseikyuusho.Checked = False Then
            s_new_str = "0"
        Else
            s_new_str = "1"
        End If
        settei_res = Trim(setting2(18, 1, "2", s_new_str))
        If settei_res = "-1" Then
            msg_go("設定の更新に失敗しました。chkseikyuusho :" & s_new_str)
            Exit Sub
        End If


        msg_go("更新しました。一度終了します。", 64)

        End

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtverpath.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtwella.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtbackup.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtdouki.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtmainserverpath.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtyuubin.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            'Console.WriteLine(fbd.SelectedPath)
            txtseikyuu.Text = fbd.SelectedPath
        End If
    End Sub
End Class