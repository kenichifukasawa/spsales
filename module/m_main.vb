Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Module m_main

    Public newserver(3) As String
    Public sougou_path As String
    Public versionup_path As String = ""

    Public hozonsaki_path As String
    Public DESKTOP_PATH As String

    Public settei_mdb_path As String
    Public print_mdb_path As String
    Public ver_file_path As String
    Public map_exe_path As String

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

    Public barcodenono As Integer


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

    Public STARTED_YEAR As Integer = 2006

    Sub system_check(s_versionup_path As String)

        Dim s_verfile_path As String = s_versionup_path & "\spsales.exe"

        If System.IO.File.Exists(s_verfile_path) = False Then
            'msg_go("設定ファイル「settei.mdb」がありません。")
            Exit Sub
        End If

        'バージョン情報を取得
        ' FileVersionInfoオブジェクトを取得
        Dim vi As FileVersionInfo = FileVersionInfo.GetVersionInfo(s_verfile_path)

        ' バージョン情報を表示
        'Console.WriteLine("ファイル名: " & vi.FileName)
        'Console.WriteLine("バージョン: " & vi.FileVersion)
        'Console.WriteLine("メジャーバージョン: " & vi.FileMajorPart)
        'Console.WriteLine("マイナーバージョン: " & vi.FileMinorPart)
        'Console.WriteLine("ビルド番号: " & vi.FileBuildPart)
        'Console.WriteLine("プライベートパート: " & vi.FilePrivatePart)
        Dim s_new_version As String = vi.FileVersion.ToString  ' + vi.FileMajorPart.ToString + vi.FileMinorPart.ToString + vi.FileBuildPart.ToString

        '現在の実行ファイルのバージョン
        Dim ver As System.Diagnostics.FileVersionInfo
        ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location)

        ' ファイルバージョンを表示
        'Console.WriteLine(ver.FileVersion)
        Dim s_now_version As String = ver.FileVersion.ToString   '+ ver.FileMajorPart.ToString + ver.FileMinorPart.ToString + ver.FileBuildPart.ToString

        '比較
        If s_new_version > s_now_version Then

            If System.IO.File.Exists(ver_file_path) = False Then
                msg_go("コピーアプリ「spsales_copy.exe」がないため、バージョンアップできませんでした。")
            Else


                Dim arguments As String = "s=" & s_versionup_path & "\"

                ' アップデータを起動し、自分自身を終了
                Process.Start(ver_file_path, arguments)

                System.Threading.Thread.Sleep(200) ' 200ミリ秒待機（必要に応じ調整）

                Environment.Exit(0) ' 即時プロセス終了
            End If


        End If

    End Sub

    Sub BARSHINKOU(ByVal msmsms As String)



        frmhajime.lstshinkou.Items.Insert(0, msmsms)
        System.Windows.Forms.Application.DoEvents()

    End Sub
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
    Sub grid_shien_head_set(Optional s_no As String = "")

        If s_no = "" Then
            With frmmain.dgv_shien

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 4
                .Columns(0).Name = "商品ID"
                .Columns(1).Name = "商品名"
                .Columns(2).Name = "価格"
                .Columns(3).Name = "在庫"
                .Columns(0).Width = 0
                .Columns(1).Width = 320
                .Columns(2).Width = 80
                .Columns(3).Width = 80

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 30


                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With
        ElseIf s_no = "1" Then
            With frmshiire.dgv_shien

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 4
                .Columns(0).Name = "商品ID"
                .Columns(1).Name = "商品名"
                .Columns(2).Name = "価格"
                .Columns(3).Name = "在庫"
                .Columns(0).Width = 0
                .Columns(1).Width = 320
                .Columns(2).Width = 80
                .Columns(3).Width = 80

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 30

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            End With
        End If

    End Sub

    Sub mdb_clear()


        Dim cn_setting As New OleDbConnection
        Dim cmd_setting As New OleDbCommand
        'dbを初期化
        Try
            cn_setting.ConnectionString = connectionstring_mdb

            cmd_setting.Connection = cn_setting


            cmd_setting.CommandText = "delete from pr_shichousonbetsu"


            cn_setting.Open()

            cmd_setting.ExecuteNonQuery()

            cn_setting.Close()


        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try


    End Sub


    Sub shouhin_shiirechu_set()
        With frmshiire.dgv_shiire

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 7

            .Columns(0).Name = "NO"
            .Columns(1).Name = "商品ID"
            .Columns(2).Name = "商品名"
            .Columns(3).Name = "数量"
            .Columns(4).Name = "金額"
            .Columns(5).Name = "備考"
            .Columns(6).Name = "削除"

            .Columns(0).Width = 60
            .Columns(1).Width = 0
            .Columns(2).Width = 320
            .Columns(3).Width = 50
            .Columns(4).Width = 90
            .Columns(5).Width = 100
            .Columns(6).Width = 35

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            '.Columns(6).ReadOnly = True
            .EditMode = DataGridViewEditMode.EditOnEnter


        End With

        frmshiire.lblshiiresuu.Text = "0"

        Dim newgoukei2 As Integer, newretsu2 As Integer

        Try
            Using cn As New OleDb.OleDbConnection(connectionstring_mdb)
                Dim query As String = "SELECT * FROM shiirechu ORDER BY shiirechuid"
                Dim da As New OleDb.OleDbDataAdapter(query, cn)
                Dim ds As New DataSet()
                Dim tableName As String = "t_rireki"
                da.Fill(ds, tableName)
                Dim dt As DataTable = ds.Tables(tableName)

                Dim mojiretsu(7) As String, s_suuji As Integer

                newretsu2 = dt.Rows.Count

                For i = 0 To dt.Rows.Count - 1
                    mojiretsu(0) = Trim(dt.Rows(i).Item("shiirechuid").ToString())
                    mojiretsu(1) = Trim(dt.Rows(i).Item("shouhinid").ToString())
                    If IsDBNull(dt.Rows.Item(i).Item("shouhinmei")) Then
                        mojiretsu(2) = "Error"
                    Else
                        mojiretsu(2) = Trim(dt.Rows(i).Item("shouhinmei").ToString())
                    End If
                    s_suuji = CInt(dt.Rows(i).Item("shiiresuu"))
                    mojiretsu(3) = s_suuji.ToString("#,0")
                    s_suuji = CInt(dt.Rows(i).Item("shiirekingaku"))
                    mojiretsu(4) = s_suuji.ToString("#,0")
                    If IsDBNull(dt.Rows.Item(i).Item("bikou")) Then
                        mojiretsu(5) = ""
                    Else
                        mojiretsu(5) = Trim(dt.Rows(i).Item("bikou").ToString())
                    End If
                    mojiretsu(6) = ""

                    newgoukei2 = newgoukei2 + CInt(Trim(dt.Rows(i).Item("shiirekingaku")))

                    frmshiire.dgv_shiire.Rows.Add(mojiretsu)


                    frmshiire.dgv_shiire.Rows(i).Cells(6) = New DataGridViewCheckBoxCell
                    frmshiire.dgv_shiire.Rows(i).Cells(6).Value = False

                Next

                dt.Clear()
                ds.Clear()
            End Using

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        frmshiire.lblshiiresuu.Text = CStr(newretsu2)  'CStr(CInt(rs_or2!shiirechuid) + 1)
        frmshiire.lblgoukei.Text = Format(newgoukei2, "#,##0;-#,##0")

        'frmshiire.gridshiire.ShowCell frmshiiredenpyou.gridshiire.Row, frmshiiredenpyou.gridshiire.Col



        'If newretsu2 >= 99 Then
        '        ret = MsgBox("伝票登録数が規定値９９に達しました。これ以上の登録はできません。", 64, "総合管理システム「SPSALES」")
        '    End If


    End Sub

    Function shouhinkubun_shien_grid_set(no As Integer, Optional sentaku1id As String = "", Optional sentakuid2 As String = "") As Integer


        Dim shouhinkubuncount As Integer, shouhinkubunGROW As Integer, cmdicmdi3 As Integer

        Dim lngStyle As Long

        shouhinkubun_shien_grid_set = 0

        Select Case no
            Case 0, 1, 4
                frmmain.lstshien.Items.Clear()
            Case 5, 6
                frmshiire.lstshien.Items.Clear()
                '    For cmdicmdi3 = 0 To 99
                '        frmmain.cmd2(cmdicmdi3).Caption = ""
                '    Next
                'Case 2
                '    For cmdicmdi3 = 0 To 99
                '        frmmain.cmd1(cmdicmdi3).Caption = ""
                '    Next
        End Select




        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver

            Select Case no
                Case 4, 5
                    Sql = "SELECT*FROM shouhinkubun0 ORDER BY shouhinkubunid0"

                Case 0, 6

                    Sql = "SELECT*FROM shouhinkubun ORDER BY shouhinkubunid"

                Case 1

                    Sql = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"

                    'Case 2

                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun ORDER BY shouhinkubunid"

                    '    frmmain.cmd1(0).Caption = "なし"
                    'Case 3
                    '    If Trim(sentaku1id) = "" Then
                    '        shouhinkubun_shien_grid_set = -1
                    '        Screen.MousePointer = 0
                    '        Exit Function
                    '    End If
                    '    'sql_shouhinkubun = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"
                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun2 where shouhinkubunid='" & sentaku1id & "' ORDER BY narabe"
                    '    frmmain.cmd2(0).Caption = "なし"
                    'Case 5
                    '    sql_shouhinkubun = "SELECT*FROM shouhinkubun0 ORDER BY shouhinkubunid0"
                    '    frmmain.cmd0(0).Caption = "なし"
            End Select

            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_shoukaii")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_shoukaii")

            Dim s_str As String = ""

            For i = 0 To dt_server.Rows.Count - 1
                Select Case no
                    Case 4
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0"))
                        frmmain.lstshien.Items.Add(s_str)
                    Case 0
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))
                        frmmain.lstshien.Items.Add(s_str)

                    Case 1
                        s_str = Trim(dt_server.Rows.Item(i).Item("NARABE")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                        frmmain.lstshien.Items.Add(s_str)

                    Case 5
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0"))
                        frmshiire.lstshien.Items.Add(s_str)

                    Case 6
                        s_str = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) & "   " & Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))
                        frmshiire.lstshien.Items.Add(s_str)

                        '                frmmain.cmd1(CInt(rs_shouhinkubun!shouhinkubunid)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei)
                        '            Case 3
                        '                frmmain.cmd2(CInt(rs_shouhinkubun!NARABE)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei2)
                        '            Case 5
                        '                frmmain.cmd0(CInt(rs_shouhinkubun!shouhinkubunid0)).Caption = Trim(rs_shouhinkubun!shouhinkubunmei0)
                End Select
            Next i
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            shouhinkubun_shien_grid_set = -1
        End Try

    End Function


    Sub mainset(s_tenpoid As String)

        If s_tenpoid = "" Then
            Exit Sub
        End If

        tenpo_main_set(s_tenpoid)

        tenpo_hacchuurireki_set(s_tenpoid)

        tenpo_seikyuurireki_set(s_tenpoid)

        tenpo_log_set(s_tenpoid)

        tenpo_orderchu_set_10()

        log_main_set(s_tenpoid)

    End Sub
    Sub tenpo_hacchuurireki_set2(s_hacchuuid As String)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuushousai.*, hacchuu.*,shouhin.* FROM (hacchuushousai left join shouhin on  hacchuushousai.shouhinid = shouhin.shouhinid) LEFT JOIN hacchuu ON hacchuushousai.hacchuuid = hacchuu.hacchuuid" +
                " WHERE hacchuushousai.hacchuuid = '" + s_hacchuuid + "'"

            'Dim query = "SELECT * FROM hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid" +
            '    " WHERE hacchuu.hacchuuid = '" + s_hacchuuid + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shoukaii")
            Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(9) As String

            With frmdenpyou.dgv_nouhinsho

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 9
                .Columns(0).Name = "納品詳細ID"
                .Columns(1).Name = "商品ID"
                .Columns(2).Name = "商品名"
                .Columns(3).Name = "数量"
                .Columns(4).Name = "単価"
                .Columns(5).Name = "小計"
                .Columns(6).Name = "摘要"
                .Columns(7).Name = "確定"
                .Columns(8).Name = "軽減税率"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 700
                .Columns(3).Width = 60
                .Columns(4).Width = 100
                .Columns(5).Width = 100
                .Columns(6).Width = 100
                .Columns(7).Width = 0
                .Columns(8).Width = 50

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            End With

            Dim s_kin As Decimal
            Dim s_kakutei As Integer

            Dim s_sougaku As Integer = 0, s_10 As Integer = 0, s_8 As Integer = 0, s_konkai As Integer

            For i = 0 To dt_server.Rows.Count - 1
                s_kakutei = 0
                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("hachuushousaiid"))
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))

                s_kin = dt_server.Rows.Item(i).Item("kosuu")
                mojiretsu(3) = s_kin.ToString("#,##0")

                s_kin = dt_server.Rows.Item(i).Item("tanka")
                mojiretsu(4) = s_kin.ToString("#,##0")

                s_kin = dt_server.Rows.Item(i).Item("kei")

                s_konkai = s_kin
                s_sougaku = s_sougaku + s_kin

                mojiretsu(5) = s_kin.ToString("#,##0")


                If IsDBNull(dt_server.Rows.Item(i).Item("tekiyou")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("tekiyou"))
                End If
                If IsDBNull(dt_server.Rows.Item(i).Item("kakutei")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("kakutei"))
                    '色の判定
                    If Trim(dt_server.Rows.Item(i).Item("kakutei")) = "1" Then
                        s_kakutei = 1
                    End If
                End If
                If IsDBNull(dt_server.Rows.Item(i).Item("keigen")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(dt_server.Rows.Item(i).Item("keigen"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("hikazei")) Then
                    If IsDBNull(dt_server.Rows.Item(i).Item("keigen")) Then
                        s_10 = s_10 + s_konkai
                    Else
                        s_8 = s_8 + s_konkai
                    End If
                End If

                frmdenpyou.dgv_nouhinsho.Rows.Add(mojiretsu)

                '色をいれる
                If s_kakutei = 1 Then
                    frmdenpyou.dgv_nouhinsho.Rows(i).Cells(4).Style.BackColor = Color.FromArgb(&HC0E0FF)
                End If

            Next i

            dt_server.Clear()
            ds_server.Clear()

            frmdenpyou.lbl_shouhizei_10_percent.Text = s_10.ToString("#,0")
            frmdenpyou.lbl_shouhizei_8_percent.Text = s_8.ToString("#,0")
            frmdenpyou.lbl_nouhinsho_goukei.Text = s_sougaku.ToString("#,0")

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Sub tenpo_hacchuurireki_set(s_tenpoid As String)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Sql = "SELECT hacchuu.*,shain.ryakumei" &
                    " FROM hacchuu right join shain" &
                    " on hacchuu.shainid=shain.shainid" &
                    " where tenpoid='" & s_tenpoid & "'and joukyou='0' ORDER BY iraibi DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shoukaii")
            Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(11) As String

            With frmmain.dgv_denpyou

                .Rows.Clear()
                .RowHeadersWidth = 4
                .Columns.Clear()
                .ColumnCount = 10

                .Columns(0).Name = "納品日"
                .Columns(1).Name = "伝票NO"
                .Columns(2).Name = "金額"
                .Columns(3).Name = "社員名"
                .Columns(4).Name = "印刷"
                .Columns(5).Name = "納品書ID"
                .Columns(6).Name = "備考1"
                .Columns(7).Name = "備考2"
                .Columns(8).Name = "Print"
                .Columns(9).Name = "ダミー"
                .Columns(0).Width = 90
                .Columns(1).Width = 90
                .Columns(2).Width = 90
                .Columns(3).Width = 80
                .Columns(4).Width = 45
                .Columns(5).Width = 100
                .Columns(6).Width = 0
                .Columns(7).Width = 0
                .Columns(8).Width = 0
                .Columns(9).Width = 0

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                '列ヘッダーの高さを変える
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With

            Dim s_kin As Decimal
            Dim s_dami As Integer, s_shutsuryoku As Integer

            For i = 0 To dt_server.Rows.Count - 1
                s_dami = 0
                s_shutsuryoku = 0

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("hacchuuid"))
                mojiretsu(0) = Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("iraibi")), 7, 2)

                s_kin = dt_server.Rows.Item(i).Item("goukei")
                mojiretsu(2) = s_kin.ToString("#,##0")

                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("shainid")) & " " & Trim(dt_server.Rows.Item(i).Item("ryakumei"))



                If IsDBNull(dt_server.Rows.Item(i).Item("shutsu")) Then
                    mojiretsu(4) = ""
                    s_shutsuryoku = 1
                Else
                    mojiretsu(4) = "未"　　'Trim(dt_server.Rows.Item(i).Item("shutsu"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    mojiretsu(5) = ""
                Else
                    mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("bikou1")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("bikou1"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("bikou2")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("bikou2"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("print_shurui")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(dt_server.Rows.Item(i).Item("print_shurui"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("dami2")) Then
                    mojiretsu(9) = ""
                Else
                    mojiretsu(9) = Trim(dt_server.Rows.Item(i).Item("dami2"))
                End If

                '色の判定
                If IsDBNull(dt_server.Rows.Item(i).Item("dami2")) Then
                Else
                    If Trim(dt_server.Rows.Item(i).Item("nouhinshoid")) = "1" Then
                        s_dami = 1
                    End If
                End If


                frmmain.dgv_denpyou.Rows.Add(mojiretsu)

                '色をいれる
                If s_dami = 1 Then
                    frmmain.dgv_denpyou.Rows(i).Cells(0).Style.BackColor = Color.FromArgb(&HC0E0FF)
                End If

                If s_shutsuryoku = 1 Then
                    frmmain.dgv_denpyou.Rows(i).Cells(1).Style.BackColor = Color.FromArgb(&HC0C0FF)
                End If

            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Sub tenpo_seikyuurireki_set(s_tenpoid As String)

        Try

            Sql = "SELECT * FROM seikyuusho WHERE tenpoid = '" & s_tenpoid & "' ORDER BY hiduke DESC, seikyuushoid DESC"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shoukaii"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            With frmmain.dgv_seikyuusho

                .Rows.Clear()
                .RowHeadersWidth = 4
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

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

                ' 奇数行の既定セル・スタイルの背景色を設定
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            End With

            Dim mojiretsu(7) As String, s_dami As Integer

            For i = 0 To dt_server.Rows.Count - 1

                s_dami = 0

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))
                mojiretsu(0) = Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("hiduke")), 7, 2)

                If Trim(dt_server.Rows.Item(i).Item("seikyuu_st")) = "0" Then
                    mojiretsu(2) = "請求"
                Else
                    mojiretsu(2) = "入金"
                    Dim houhou_mei = PaymentMethodsDeposit.GetNameById(Trim(dt_server.Rows.Item(i).Item("seikyuutanni")))
                    If houhou_mei = "不明" Then
                        mojiretsu(2) = "エラー"
                    Else
                        mojiretsu(2) += " (" + houhou_mei + ")"
                    End If
                End If

                Dim s_kin As Decimal = dt_server.Rows.Item(i).Item("seikyuukingaku")
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

                If IsDBNull(dt_server.Rows.Item(i).Item("dami")) Then
                Else
                    If Trim(dt_server.Rows.Item(i).Item("dami")) = "" Then
                        s_dami = 1
                    End If
                End If

                frmmain.dgv_seikyuusho.Rows.Add(mojiretsu)

                If s_dami = 1 Then
                    frmmain.dgv_seikyuusho.Rows(i).Cells(0).Style.BackColor = Color.FromArgb(&HC0E0FF)
                End If

            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Sub tenpo_log_set(s_tenpoid As String)

    End Sub

    Sub tenpo_orderchu_set_10()


        With frmmain.dgv_nouhinsho

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 11
            .Columns(0).Name = "No"
            .Columns(1).Name = "商品ID"
            .Columns(2).Name = "商品名"
            .Columns(3).Name = "数"
            .Columns(4).Name = "単価"
            .Columns(5).Name = "小計"
            .Columns(6).Name = "摘要"
            .Columns(7).Name = ""
            .Columns(8).Name = ""
            .Columns(9).Name = ""
            .Columns(10).Name = ""
            .Columns(0).Width = 40
            .Columns(1).Width = 0
            .Columns(2).Width = 250
            .Columns(3).Width = 40
            .Columns(4).Width = 60
            .Columns(5).Width = 80
            .Columns(6).Width = 90
            .Columns(7).Width = 50
            .Columns(8).Width = 0
            .Columns(9).Width = 0
            .Columns(10).Width = 0


            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            '列ヘッダーの高さを変える
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 30

            ' 奇数行の既定セル・スタイルの背景色を設定
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            '.Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = True
            .Columns(9).ReadOnly = True
            .Columns(10).ReadOnly = True
            .EditMode = DataGridViewEditMode.EditOnEnter



        End With

        frmmain.lbl_nouhinsho_goukei.Text = ""

        Dim s_goukeigaku As Integer = 0

        Dim s_pcname As String = Trim(frmmain.lblpcname.Text)
        If s_pcname = "" Then
            msg_go("ユーザー情報が登録されていないため、発注伝票の登録・表示はできません。")
            Exit Sub
        End If


        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Sql = "SELECT hacchuushousai.*,shouhin.* FROM hacchuushousai left join shouhin on hacchuushousai.shouhinid = shouhin.shouhinid" &
                    " where hacchuushousai.hacchuuid='" & s_pcname & "' ORDER BY hacchuushousai.hachuushousaiid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shoukaii")
            Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(11) As String



            Dim s_kin As Decimal

            For i = 0 To dt_server.Rows.Count - 1
                mojiretsu(0) = (i + 1).ToString
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))

                s_kin = dt_server.Rows.Item(i).Item("kosuu")
                mojiretsu(3) = s_kin.ToString("#,##0")

                s_kin = dt_server.Rows.Item(i).Item("tanka")
                mojiretsu(4) = s_kin.ToString("#,##0")


                s_kin = dt_server.Rows.Item(i).Item("kei")

                s_goukeigaku = s_goukeigaku + s_kin

                mojiretsu(5) = s_kin.ToString("#,##0")

                If IsDBNull(dt_server.Rows.Item(i).Item("tekiyou")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("tekiyou"))
                End If

                mojiretsu(7) = ""

                If IsDBNull(dt_server.Rows.Item(i).Item("kakutei")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(dt_server.Rows.Item(i).Item("kakutei"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("keigen")) Then
                    mojiretsu(9) = ""
                Else
                    mojiretsu(9) = Trim(dt_server.Rows.Item(i).Item("keigen"))
                End If

                mojiretsu(10) = Trim(dt_server.Rows.Item(i).Item("hachuushousaiid"))


                frmmain.dgv_nouhinsho.Rows.Add(mojiretsu)


                frmmain.dgv_nouhinsho.Rows(i).Cells(7) = New DataGridViewCheckBoxCell
                frmmain.dgv_nouhinsho.Rows(i).Cells(7).Value = False

                '単価の設定で色を入れる(todo)
                'If Trim(rs_seikyuu_n!kakutei) = "1" Then
                If Trim(dt_server.Rows.Item(i).Item("kakutei")) = "1" Then
                    '.Cell(flexcpBackColor, newretsu, 4) = &HC0C0FF
                    frmmain.dgv_nouhinsho.Rows(i).Cells(4).Style.BackColor = Color.FromArgb(&HC0, &HC0, &HFF) ' 薄い青系
                Else
                    '    .Cell(flexcpBackColor, newretsu, 4) = &HFFFFFF
                    frmmain.dgv_nouhinsho.Rows(i).Cells(4).Style.BackColor = Color.White
                End If

            Next i

            dt_server.Clear()
            ds_server.Clear()



            frmmain.lbl_nouhinsho_goukei.Text = s_goukeigaku.ToString("#,##0")

            If frmmain.dgv_nouhinsho.CurrentCell IsNot Nothing Then
                ' 現在選択されているセルの行インデックス
                Dim rowIdx As Integer = frmmain.dgv_nouhinsho.CurrentCell.RowIndex
                Dim colIdx As Integer = frmmain.dgv_nouhinsho.CurrentCell.ColumnIndex

                ' (rowIdx, colIdx)を表示領域内に持ってくる
                If Not frmmain.dgv_nouhinsho(rowIdx, colIdx).Displayed Then
                    frmmain.dgv_nouhinsho.CurrentCell = frmmain.dgv_nouhinsho(rowIdx, colIdx)
                End If
            End If


        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Sub log_main_set(tenpo_id As String)

        With frmmain.dgv_log

            .Rows.Clear()
            .RowHeadersWidth = 4
            .Columns.Clear()
            .ColumnCount = 7

            .Columns(0).Name = "ID"
            .Columns(1).Name = "日時"
            .Columns(2).Name = "社員"
            .Columns(3).Name = "区分"
            .Columns(4).Name = "内容"
            .Columns(5).Name = "状況"
            .Columns(6).Name = "削徐"

            .Columns(0).Width = 0
            .Columns(1).Width = 100
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 550
            .Columns(5).Width = 60
            .Columns(6).Width = 50

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 25

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM log LEFT JOIN shain ON log.shainid = shain.shainid"

            Dim query_where = " WHERE log.tenpoid ='" + tenpo_id + "'"
            If Not frmmain.chk_log_sakujozumi.Checked Then
                query_where += " AND log.del IS NULL"
            End If

            query += query_where + " ORDER BY log.log_id DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_log"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(7) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("log_id"))
                mojiretsu(1) = ConvertYmdStringToYmdSlash(Trim(dt_server.Rows.Item(i).Item("itsu"))) + " " + ConvertHmsStringToHmsColon(Trim(dt_server.Rows.Item(i).Item("nanji")))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("ryakumei"))
                mojiretsu(3) = LogCategory.GetNameById(Trim(dt_server.Rows.Item(i).Item("kubun_id")))
                mojiretsu(4) = Trim(dt_server.Rows.Item(i).Item("youken"))
                mojiretsu(5) = LogStatus.GetNameById(Trim(dt_server.Rows.Item(i).Item("st_id")))

                Dim db_del = dt_server.Rows.Item(i).Item("del")
                Dim del = ""
                If Not IsDBNull(db_del) Then
                    del = Trim(db_del)
                    del = "社員ID:" + Mid(del, 1, 2) + " " + ConvertYmdStringToYmdSlash(Mid(del, 3, 8)) + " " + ConvertHmsStringToHmsColon(Mid(del, 11))
                End If
                mojiretsu(6) = del

                frmmain.dgv_log.Rows.Add(mojiretsu)

            Next i

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub tenpo_henkou_set(s_tenpoid As String)

        With frmkojin

            .cmbshime.Items.Clear()
            .cmbshime.Items.AddRange(Deadline.Names)

        End With


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



            Dim mojiretsu(3) As String

            If dt_server.Rows.Count <> 0 Then
                With frmkojin
                    .lbltenpoid.Text = Trim(dt_server.Rows.Item(0).Item("tenpoid"))
                    .txttenpomei.Text = Trim(dt_server.Rows.Item(0).Item("tenpomei"))
                    If IsDBNull(dt_server.Rows.Item(0).Item("tenpofurigana")) Then
                        .txtfurigana.Text = ""
                    Else
                        .txtfurigana.Text = Trim(dt_server.Rows.Item(0).Item("tenpofurigana"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("insatsumei")) Then
                        .txtinsatsumei.Text = ""
                    Else
                        .txtinsatsumei.Text = Trim(dt_server.Rows.Item(0).Item("insatsumei"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("mailno")) Then
                        .txtyuubin.Text = ""
                        .txtyuubin2.Text = ""
                    Else
                        .txtyuubin.Text = Mid(Trim(dt_server.Rows.Item(0).Item("mailno")), 1, 3)
                        .txtyuubin2.Text = Mid(Trim(dt_server.Rows.Item(0).Item("mailno")), 5, 4)
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("adress1")) Then
                        .txtjuusho.Text = ""
                    Else
                        .txtjuusho.Text = Trim(dt_server.Rows.Item(0).Item("adress1"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("tenpoadress")) Then
                        .txtjuusho2.Text = ""
                    Else
                        .txtjuusho2.Text = Trim(dt_server.Rows.Item(0).Item("tenpoadress"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("tel")) Then
                        .txttel.Text = ""
                    Else
                        .txttel.Text = Trim(dt_server.Rows.Item(0).Item("tel"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("keitai")) Then
                        .txtkeitai.Text = ""
                    Else
                        .txtkeitai.Text = Trim(dt_server.Rows.Item(0).Item("keitai"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("fax")) Then
                        .txtfax.Text = ""
                    Else
                        .txtfax.Text = Trim(dt_server.Rows.Item(0).Item("fax"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("daihyou")) Then
                        .txtdaihyou.Text = ""
                    Else
                        .txtdaihyou.Text = Trim(dt_server.Rows.Item(0).Item("daihyou"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("tantou")) Then
                        .txttantou.Text = ""
                    Else
                        .txttantou.Text = Trim(dt_server.Rows.Item(0).Item("tantou"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("juugyouinsuu")) Then
                        .txtjuugyouinsuu.Text = ""
                    Else
                        .txtjuugyouinsuu.Text = Trim(dt_server.Rows.Item(0).Item("juugyouinsuu"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("email")) Then
                        .txtemail1.Text = ""
                        .cmbmail.Text = ""
                    Else
                        If Trim(dt_server.Rows.Item(0).Item("email")) = "" Then
                            .txtemail1.Text = ""
                            .cmbmail.Text = ""
                        Else
                            Dim s_mail As String = Trim(dt_server.Rows.Item(0).Item("email"))
                            Dim s_len As Integer = s_mail.IndexOf("@")

                            .txtemail1.Text = Mid(s_mail, 1, s_len)
                            .cmbmail.Text = Mid(s_mail, s_len + 2)
                        End If
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("url")) Then
                        .txturl.Text = ""
                    Else
                        .txturl.Text = Trim(dt_server.Rows.Item(0).Item("url"))
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("shimebi")) Then
                        .cmbshime.SelectedIndex = -1
                    Else
                        If Trim(dt_server.Rows.Item(0).Item("shimebi")) = "" Then
                            .cmbshime.SelectedIndex = -1
                        Else
                            .cmbshime.SelectedIndex = CInt(Trim(dt_server.Rows.Item(0).Item("shimebi")))
                        End If
                    End If


                    If IsDBNull(dt_server.Rows.Item(0).Item("souhasuu")) Then
                        .rkeisanseikyuusho.Checked = False
                        .rkeisannouhinsho.Checked = False
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("souhasuu"))
                            Case "0"
                                ' .lblkeisanhouhou.Text = "請求書毎"
                                .rkeisanseikyuusho.Checked = True
                            Case "1"
                                ' .lblkeisanhouhou.Text = "納品書毎"
                                .rkeisannouhinsho.Checked = True
                            Case Else
                                ' .lblkeisanhouhou.Text = "エラー"
                                .rkeisanseikyuusho.Checked = False
                                .rkeisannouhinsho.Checked = False
                        End Select
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("zeihasuu")) Then
                        .rkirisute.Checked = False
                        .rshishagonyuu.Checked = False
                        .rkiriage.Checked = False
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("zeihasuu"))
                            Case "0"
                                ' .lblhasuu.Text = "切り捨て"
                                .rkirisute.Checked = True
                            Case "1"
                                '.lblhasuu.Text = "四捨五入"
                                .rshishagonyuu.Checked = True
                            Case "2"
                                ' .lblhasuu.Text = "切り上げ"
                                .rkiriage.Checked = True
                            Case Else
                                ' .lblhasuu.Text = "エラー"
                                .rkirisute.Checked = False
                                .rshishagonyuu.Checked = False
                                .rkiriage.Checked = False
                        End Select
                    End If
                    If IsDBNull(dt_server.Rows.Item(0).Item("kubun")) Then
                        .rkubunkaisha.Checked = False
                        .rkubuntenpo.Checked = False
                        .rkubuniroiro.Checked = False
                    Else
                        Select Case Trim(dt_server.Rows.Item(0).Item("kubun"))
                            Case "0"
                                ' .lblkubun.Text = "会社単位"
                                .rkubunkaisha.Checked = True
                            Case "1"
                                '  .lblkubun.Text = "店舗単位"
                                .rkubuntenpo.Checked = True
                            Case "2"
                                ' .lblkubun.Text = "いろいろ"
                                .rkubuniroiro.Checked = True
                            Case Else
                                '.lblkubun.Text = "エラー"
                                .rkubunkaisha.Checked = False
                                .rkubuntenpo.Checked = False
                                .rkubuniroiro.Checked = False
                        End Select
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("bikou")) Then
                        .txtbikou.Text = ""
                    Else
                        .txtbikou.Text = Trim(dt_server.Rows.Item(0).Item("bikou"))
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("kurikoshi")) Then
                        .txtkurikoshikin.Text = ""
                    Else
                        .txtkurikoshikin.Text = CInt(Trim(dt_server.Rows.Item(0).Item("kurikoshi"))).ToString
                    End If

                    If IsDBNull(dt_server.Rows.Item(0).Item("seikyuubi")) Then
                        .txtzenkaiseikyuubi.Text = ""
                    Else
                        .txtzenkaiseikyuubi.Text = Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 5, 2) & "/" & Mid(Trim(dt_server.Rows.Item(0).Item("seikyuubi")), 7, 2)
                    End If


                End With
            End If
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)

        End Try


    End Sub

    Sub tenpo_main_set(s_tenpoid As String)

        Dim tenpo_mei = ""

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
                    tenpo_mei = Trim(dt_server.Rows.Item(0).Item("tenpomei"))
                    .lbltenpomei.Text = tenpo_mei
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
                    Dim shimebi = ""
                    If Not IsDBNull(dt_server.Rows.Item(0).Item("shimebi")) Then
                        shimebi = Deadline.GetNameById(Trim(dt_server.Rows.Item(0).Item("shimebi")))
                    End If
                    .lblshimebi.Text = shimebi
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

                    If IsDBNull(dt_server.Rows.Item(0).Item("kadou")) Then
                        .lbltorihikinashi.Text = "0"
                    Else
                        If Trim(dt_server.Rows.Item(0).Item("kadou")) = "1" Then
                            .lbltorihikinashi.Text = "1"
                            ' If frmmain.chktenpoend.Value = 1 Then
                            '                ret = MsgBox("現在取引のない店舗を表示しようとしています。設定を変更します。", 64, "総合管理システム「SPSALES」")
                            '                frmmain.chktenpoend.Value = 0
                            '                SbtenponameSet 1, 0, 0
                            'End If
                        Else
                            .lbltorihikinashi.Text = "0"
                        End If
                    End If


                End With
            End If
            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' MDBのrirekiテーブルに追加
        Dim rirekiid = "0001"
        Try
            Using cn As New OleDb.OleDbConnection(connectionstring_mdb)
                Dim query As String = "SELECT * FROM rireki ORDER BY rirekiid DESC"
                Dim da As New OleDb.OleDbDataAdapter(query, cn)
                Dim ds As New DataSet()
                Dim tableName As String = "t_rireki"
                da.Fill(ds, tableName)
                Dim dt As DataTable = ds.Tables(tableName)

                If dt.Rows.Count > 0 Then
                    rirekiid = Trim(dt.Rows(0).Item("rirekiid").ToString())
                End If

                dt.Clear()
                ds.Clear()
            End Using

        Catch ex As Exception
            msg_go("MDBのrirekiの参照時にエラーが発生しました: " & ex.Message)
            Exit Sub
        End Try

        Try
            Using cn As New OleDbConnection(connectionstring_mdb)
                cn.Open()

                Dim sql As String = "INSERT INTO rireki" +
                    " (rirekiid, kaishaid, kaishamei, junban)" +
                    " VALUES" +
                    " (?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@p1", (CInt(rirekiid) + 1).ToString("D4"))
                    cmd.Parameters.AddWithValue("@p2", s_tenpoid)
                    cmd.Parameters.AddWithValue("@p3", tenpo_mei)
                    cmd.Parameters.AddWithValue("@p4", Now.ToString("yyyyMMddHHmmss"))

                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            msg_go("MDBのrirekiの登録時にエラーが発生しました: " & ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub wait_msg(s_msg As String, s_p_count As Integer, Optional s_p_sousuu As String = "")

        frmomachi.lblmsg.Text = s_msg

        If s_p_sousuu <> "" Then
            frmomachi.p1.Minimum = 0
            frmomachi.p1.Maximum = CInt(s_p_sousuu)
        End If

        frmomachi.p1.Value = s_p_count

        System.Windows.Forms.Application.DoEvents()
    End Sub

    Sub wait_on(Optional s_msg As String = "", Optional s_p_on As String = "")

        If s_msg <> "" Then
            frmomachi.lblmsg.Text = s_msg
        End If
        If s_p_on = "1" Then
            frmomachi.p1.Visible = True
        End If

        frmomachi.Show()
        System.Windows.Forms.Application.DoEvents()


    End Sub
    Sub wait_off()

        frmomachi.Close()
        frmomachi.Dispose()
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Function main_hontouroku(s_iraibi As String, s_goukei As String, s_shainid As String, s_tenpoid As String, s_nouhinshoid As String, s_dami As String) As Integer

        main_hontouroku = -1

        Dim kari_touroku_suu As Integer = frmmain.dgv_nouhinsho.Rows.Count

        Dim karitourokudata(7, kari_touroku_suu) As String

        wait_msg("伝票情報を取得中・・", 1, "10")

        For i = 0 To kari_touroku_suu - 1
            karitourokudata(0, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(1).Value.ToString)
            karitourokudata(1, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(3).Value.ToString)
            karitourokudata(2, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(4).Value.ToString)
            karitourokudata(3, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(5).Value.ToString)
            karitourokudata(4, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(6).Value.ToString)

            Dim lenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(karitourokudata(4, i))
            If lenB > 10 Then
                msg_go("備考の文字数が多いです。再度編集してください。")
                Exit Function
            End If

            karitourokudata(5, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(7).Value.ToString)
            karitourokudata(6, i) = Trim(frmmain.dgv_shien.CurrentRow.Cells(9).Value.ToString)
        Next


        wait_msg("保存情報を書き込み中・・", 2)

        'If create_hacchuu_and_hacchuushousai(shouhin_id, sagaku_suu) = False Then ' 本登録へ
        '    msg_go("発注テーブルまたは発注詳細テーブルの更新でエラーが発生しました。")
        '    Exit Sub
        'End If




    End Function

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
    Function shain_pw_chk(s_pw As String, Optional s_zaishoku As String = "") As String

        shain_pw_chk = ""

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query
            If s_zaishoku = "" Then
                query = "SELECT * FROM shain where password = '" & s_pw & "' ORDER BY shainid"
            Else
                query = "SELECT * FROM shain where password = '" & s_pw & "' and zaishoku ='0' ORDER BY shainid"
            End If


            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_shain_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_shain_ichiran")

            If dt_server.Rows.Count > 0 Then

                shain_pw_chk = Trim(dt_server.Rows.Item(0).Item("shainid")) & Trim(dt_server.Rows.Item(0).Item("shainmei"))
            End If


            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
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

    Function hacchuushousai_touroku(s_hacchuushousai_count As Integer, s_hacchuushousai_data(,) As String) As Integer

        Try
            Dim table_name = "hacchuushousai"
            Dim s_no = 3
            Dim id = 1
            Dim ketasuu = 10
            Dim new_id = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT TOP 1 * FROM " + table_name

            Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds As New DataSet
            Dim temp_table_name = "t_" + table_name
            da.Fill(ds, temp_table_name)
            Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

            For i = 0 To s_hacchuushousai_count - 1

                data_row("hachuushousaiid") = new_id
                data_row("hacchuuid") = s_hacchuushousai_data(0, i)
                data_row("shouhinid") = s_hacchuushousai_data(1, i)
                data_row("kosuu") = CInt(s_hacchuushousai_data(2, i))
                data_row("tanka") = CInt(s_hacchuushousai_data(3, i))
                data_row("kei") = CInt(s_hacchuushousai_data(4, i))
                data_row("tekiyou") = s_hacchuushousai_data(5, i)
                data_row("kakutei") = s_hacchuushousai_data(6, i)

                If s_hacchuushousai_data(7, i) <> "" Then
                    data_row("keigen") = s_hacchuushousai_data(7, i)
                End If

                ds.Tables(temp_table_name).Rows.Add(data_row)
            Next

            da.Update(ds, temp_table_name)
            ds.Clear()

            Return 1

        Catch ex As Exception
            msg_go(ex.Message)
            Return -1
        End Try

    End Function

    Function get_settei(id As Integer, s_no As Integer) As String ' TODO:移行後、削除し「get_settings」へ移行

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

    Function get_settings(table_name As String) As String ' TODO:移行後、削除し「get_settings」へ移行

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM settings WHERE table_name = '" + table_name + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_settings")
            Dim dt_server As DataTable = ds_server.Tables("t_settings")

            If dt_server.Rows.Count = 0 Then
                Return ""
            End If

            Dim response = Trim(dt_server.Rows.Item(0).Item("next_id"))

            dt_server.Clear()
            ds_server.Clear()

            Return response

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

    Function update_settei(id As Integer, s_no As Integer, new_value As String) As Boolean ' TODO:移行後、削除し「update_settings」へ移行

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

    Function update_settings(table_name As String, new_value As String) As Boolean ' TODO:移行後、削除し「update_settings」へ移行

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM settings WHERE table_name = '" + table_name + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_settings"
            da.Fill(ds, temp_table_name)

            Dim data_row = ds.Tables(temp_table_name).Rows(0)
            data_row("next_id") = new_value

            Dim cb As New SqlCommandBuilder
            cb.DataAdapter = da
            da.Update(ds, temp_table_name)
            ds.Clear()

            Return True

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

    End Function

    Function get_and_update_settings( ' TODO:移行後、菅野が書き換え（※）
                              table_name As String,
                              id As Integer,
                              s_no As Integer,
                              ketasuu As Integer,
                              Optional henkasuu As Integer = 1 ' 親子関係のテーブルの登録の場合の子のテーブルの登録数。子テーブルの登録のFor文の中でnew_idを加算していく。
                              ) As String

        Dim conn As SqlConnection = Nothing
        Dim new_id As String = "" ' TODO:移行後削除
        Dim new_id_2 As String = ""

        Try

            '=============================== ' TODO:移行後削除（※）
            ' settei テーブル処理
            '===============================

            conn = New SqlConnection(connectionstring_sqlserver)
            conn.Open()

            Dim query = "SELECT * FROM settei WHERE id = '" + id.ToString + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            Dim table_name_settei = "t_settei"
            da.Fill(ds, table_name_settei)

            If ds.Tables(table_name_settei).Rows.Count = 0 Then
                Throw New Exception("IDが存在しません。")
            End If

            Dim row As DataRow = ds.Tables(table_name_settei).Rows(0)

            Dim current_id_settei As String = Trim(row("s" & s_no.ToString).ToString())
            Dim next_id As String = ""
            If current_id_settei = "" Then
                Throw New Exception("IDの取得に失敗しました。")
            ElseIf current_id_settei = "0" Then
                next_id = "2"
                new_id = 1.ToString("D" & ketasuu.ToString())
            Else
                next_id = (CLng(current_id_settei) + henkasuu).ToString()
                new_id = current_id_settei.PadLeft(ketasuu, "0"c)
            End If

            row("s" & s_no.ToString) = next_id

            Dim cb As New SqlCommandBuilder(da)
            da.UpdateCommand = cb.GetUpdateCommand()
            da.Update(ds, table_name_settei)

            '===============================
            ' settings テーブル処理
            '===============================

            ' テーブル存在確認
            Dim existsQuery As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'settings'"
            Using cmdExists As New SqlCommand(existsQuery, conn)
                Dim exists As Integer = Convert.ToInt32(cmdExists.ExecuteScalar())
                If exists > 0 Then ' TODO:移行後、exists は削除する（※）

                    Dim selQuery As String = "SELECT * FROM settings WHERE table_name = '" + table_name + "'"
                    Dim da2 As New SqlDataAdapter(selQuery, conn)
                    Dim ds2 As New DataSet()
                    Dim table_name_settings = "t_settings"
                    da2.Fill(ds2, table_name_settings)

                    If ds2.Tables(table_name_settings).Rows.Count > 0 Then

                        Dim row2 As DataRow = ds2.Tables(table_name_settings).Rows(0)

                        Dim current_id_settings As String = Trim(row2("next_id").ToString())
                        Dim next_id_2 As String = ""
                        If current_id_settings = "" Then
                            Throw New Exception("IDの取得に失敗しました。")
                        ElseIf current_id_settings = "0" Then
                            next_id_2 = "2"
                            new_id_2 = 1.ToString("D" & ketasuu.ToString())
                        Else
                            next_id_2 = (CLng(current_id_settings) + henkasuu).ToString()
                            new_id_2 = current_id_settings.PadLeft(ketasuu, "0"c)
                        End If

                        row2("next_id") = next_id ' TODO:next_id_2に変更する。（※）

                        Dim cb2 As New SqlCommandBuilder(da2)
                        da2.UpdateCommand = cb2.GetUpdateCommand()
                        da2.Update(ds2, table_name_settings)

                    End If

                End If
            End Using

            Return new_id ' TODO:移行後、new_id_2（※）

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

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

    Function create_csv_file(csv_data(,) As String, hozon_path As String, data_count As Integer) As Boolean

        convert_nothing_to_karamoji(csv_data)

        Try
            Using sw As New StreamWriter(hozon_path, False, Encoding.GetEncoding("Shift_JIS"))
                Dim header As String = get_header(csv_data)
                sw.WriteLine(header)

                For i = 1 To data_count
                    Dim line As String = get_line_hairetsu(csv_data, i)
                    sw.WriteLine(line)
                Next
            End Using

            Return True ' 成功
        Catch ex As Exception
            msg_go("CSVファイル作成中にエラーが発生しました: " & ex.Message)
            Return False ' 失敗
        End Try

    End Function

    Private Sub convert_nothing_to_karamoji(ByRef data(,) As String)

        Dim data_count As Integer = data.GetLength(1) - 1
        Dim retsu_count As Integer = data.GetLength(0)
        For i = 1 To data_count
            For j = 1 To retsu_count - 1
                If data(j, i) Is Nothing Then
                    data(j, i) = ""
                End If
            Next
        Next

    End Sub

    Private Function get_header(data(,) As String) As String

        Dim retsu_count As Integer = data.GetLength(0)
        Dim columnsToExport As String() = New String(retsu_count - 1) {}

        For i As Integer = 0 To retsu_count - 1
            columnsToExport(i) = $"""{data(i, 0)}"""
        Next

        Dim header As String = String.Join(",", columnsToExport)

        Return header

    End Function

    Private Function get_line_hairetsu(data(,) As String, colIndex As Integer) As String

        Dim columnValues As New List(Of String)
        For rowIndex As Integer = 0 To data.GetUpperBound(0)
            columnValues.Add($"""{data(rowIndex, colIndex)}""")
        Next
        Return String.Join(",", columnValues)

    End Function

    Function shouhin_zaiko_log(shainid As String, shouhinid As String, naiyou As Integer, new_atai As String, bikou As String, Optional shiteibi As String = "") As Boolean ' TODO : いずれ、「create_zaiko_log」に名称変更

        Dim sonotoki As String = If(String.IsNullOrEmpty(shiteibi), Now.ToString("yyyyMMddHHmmss"), shiteibi)
        Dim conn As SqlConnection = Nothing

        Try

            conn = New SqlConnection(connectionstring_sqlserver)
            conn.Open()

            Dim table_name = "zaiko_log"
            Dim id = 2
            Dim s_no = 16
            Dim ketasuu = 10
            Dim new_id As String = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)

            Dim query = "SELECT TOP 1 * FROM " & table_name

            Using da As New SqlDataAdapter(query, conn)

                Dim ds As New DataSet
                Dim temp_table_name = "t_" & table_name
                da.Fill(ds, temp_table_name)
                Dim cb As New SqlCommandBuilder(da)

                Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()
                data_row("logid") = new_id
                data_row("sonotoki") = sonotoki
                data_row("shouhinid") = shouhinid
                data_row("shainid") = shainid
                data_row("naiyou") = naiyou.ToString("D2")
                data_row("newatai") = new_atai
                data_row("bikou") = bikou

                ds.Tables(temp_table_name).Rows.Add(data_row)
                da.Update(ds, temp_table_name)
                ds.Clear()

            End Using

            Return True

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        Finally
            If conn IsNot Nothing Then
                conn.Close()
                conn.Dispose()
            End If
        End Try

    End Function



    Function kurikoshi_log_edit(shainid As String, tenpoid As String, naiyou As Integer, new_atai As String, bikou As String) As String

        Dim sonotoki = Now.ToString("yyyyMMddHHmmss")

        Dim table_name = "kurikoshi_log"
        Dim id = 1
        Dim s_no = 17
        Dim ketasuu = 10
        Dim new_id = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM " + table_name

            Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds As New DataSet
            Dim temp_table_name = "t_" + table_name
            da.Fill(ds, temp_table_name)
            Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

            data_row("kurilogid") = new_id
            data_row("sonotoki") = sonotoki
            data_row("tenpoid") = tenpoid
            data_row("shainid") = shainid
            data_row("naiyou") = naiyou.ToString("D2")
            data_row("newatai") = new_atai
            data_row("bikou") = bikou

            ds.Tables(temp_table_name).Rows.Add(data_row)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        Return True

    End Function

    Function check_user(check_type As Integer) As Boolean

        ' TODO:権限と社員IDのセットをモデル化する

#If DEBUG Then
        msg_go("デバッグのため、権限チェックを省略します。", 64)
        Return True
#End If

        Dim shain_id = Trim(frmmain.lblshokuinid.Text)
        If shain_id = "" Then
            msg_go("社員の設定がされていません。")
            Return False
        End If

        Select Case check_type
            Case 0
            Case 1
            Case 2

            Case 3
            Case 4
            Case 5
            Case 6
        End Select

    End Function

    Sub write_log(msg As String, Optional folder_path As String = "")

        Dim day = Now.ToString("yyyyMMdd")
        Dim txt_path = ""
        If folder_path <> "" Then
            txt_path = folder_path + "log_" + day + ".txt"
        Else
            txt_path = log_path + "log_" + day + ".txt"
        End If

        Dim time = Now.ToString("HHmmss")
        Dim message = day + " " + time + " " + msg

        Dim encoding As Encoding = Encoding.UTF8

        Using writer As New StreamWriter(txt_path, True, encoding)
            writer.WriteLine(message)
        End Using

    End Sub

End Module
