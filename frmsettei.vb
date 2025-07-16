Imports System.Data.SqlClient

Public Class frmsettei
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = MessageBox.Show("コンバート処理をしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then
            Exit Sub
        End If

        'kojinに郵便局初期FLGを追加
        Dim result2 As String = MessageBox.Show("「shouhinkubun」のリサイズとコンバートをしますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

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
        'Dim result2 As String = MessageBox.Show("「yuubin_flg」を追加しますか？", "EzManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

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

        set_shain_name(4)

        'プリンター



        '個人
        settei_res = Setting1(2, 0, "", 0)
        If settei_res = "0" Then
            txtpassword.Text = ""
        Else
            txtpassword.Text = settei_res
        End If

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

        'パス
        settei_res = Setting1(29, 0, "", 0)
        If settei_res = "0" Then
            txtseikyuu.Text = ""
        Else
            txtseikyuu.Text = settei_res
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

        'プリンターのリストをコンボに！





    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class