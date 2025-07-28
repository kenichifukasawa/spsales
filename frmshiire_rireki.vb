Imports System.Data.SqlClient

Public Class frmshiire_rireki

    Private Sub frmshiire_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM") + "/01"
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")

        set_gyousha(1)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_shiire_rireki()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        Dim shiire_id = dgv_kensakukekka.CurrentRow.Cells(1).Value
        Dim hiduke = dgv_kensakukekka.CurrentRow.Cells(2).Value
        Dim gyousha_mei = dgv_kensakukekka.CurrentRow.Cells(7).Value

        With frmshiire_rireki_shousai

            With .dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 6

                .Columns(0).Name = "NO"
                .Columns(1).Name = "詳細ID"
                .Columns(2).Name = "商品名"
                .Columns(3).Name = "数量"
                .Columns(4).Name = "金額"
                .Columns(5).Name = "備考"

                .Columns(0).Width = 75
                .Columns(1).Width = 110
                .Columns(2).Width = 300
                .Columns(3).Width = 80
                .Columns(4).Width = 90
                .Columns(5).Width = 200

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(3).DefaultCellStyle.Format = "#,##0"
                .Columns(4).DefaultCellStyle.Format = "#,##0"

            End With

            Dim sum_goukei_gaku = 0

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT shiireshousai.*, shouhin.shouhinmei" +
                    " FROM shiireshousai LEFT JOIN shouhin ON shiireshousai.shouhinid = shouhin.shouhinid" +
                    " WHERE shiireshousai.shiireid = '" + shiire_id + "'" +
                    " ORDER BY shiireshousai.shiireshousaiid"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_shiireshousai")
                Dim dt_server As DataTable = ds_server.Tables("t_shiireshousai")

                Dim mojiretsu(5)
                For i = 0 To dt_server.Rows.Count - 1

                    mojiretsu(0) = (i + 1).ToString()
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shiireshousaiid"))
                    mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))

                    Dim kosuu = 0
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("kosuu")) Then
                        kosuu = CInt(Trim(dt_server.Rows.Item(i).Item("kosuu")))
                    End If
                    mojiretsu(3) = kosuu

                    Dim kingaku = 0
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("kin")) Then
                        kingaku = CInt(Trim(dt_server.Rows.Item(i).Item("kin")))
                    End If
                    sum_goukei_gaku += kingaku
                    mojiretsu(4) = kingaku

                    Dim bikou = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                        bikou = Trim(dt_server.Rows.Item(i).Item("bikou"))
                    End If
                    mojiretsu(5) = bikou

                    .dgv_kensakukekka.Rows.Add(mojiretsu)

                Next

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            .lbl_hiduke.Text = hiduke
            .lbl_shiire_id.Text = shiire_id
            .lbl_shiiresaki.Text = gyousha_mei
            .lbl_kingaku.Text = sum_goukei_gaku.ToString("#,0") + "円"

            .ShowDialog()

        End With

        set_shiire_rireki()

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            Exit Sub
        End If

        If chk_sakujo.Checked = False Then
            msg_go("「削除する」にチェックをつけてから実行してください。")
            Exit Sub
        End If
        chk_sakujo.Checked = False

        Dim shiire_id = dgv_kensakukekka.CurrentRow.Cells(1).Value

        Dim result As DialogResult = MessageBox.Show("以下の仕入履歴を本当に削除しますか？" + vbCrLf + vbCrLf + "仕入ID：" + shiire_id, "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shiireshousai WHERE shiireid = '" & shiire_id & "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            da.Fill(ds, "t_shiireshousai")

            If ds.Tables("t_shiireshousai").Rows.Count > 0 Then
                ds.Tables("t_shiireshousai").Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "t_shiireshousai")
                ds.Clear()

                msg_go("削除しました。", 64)
            Else
                msg_go("該当する仕入履歴が見つかりません。")
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' TODO

        set_shiire_rireki()

        ' ----------------------------------------------------------

        ''Dim sentakukokyakuid1 As Double, sentakukokyakuid As String, rs_saku3 As New ADODB.Recordset
        ''Dim sql_saku As String, rs_saku As New ADODB.Recordset, rs_saku2 As New ADODB.Recordset, sssi As Integer
        ''Dim resres, sakujosurudata(), sakujosurusuu As Integer
        ''Dim rs_saku4 As ADODB.Recordset, hen_shou_id4 As String, sql_saku4 As String
        ''Dim newbikou As String

        ''If user_check(1) = False Then
        ''    Exit Sub
        ''End If

        'With gridshiirerireki

        '    ''On Error GoTo ERRORREC1
        '    'sentakukokyakuid1 = CDbl(.Cell(flexcpText, , 1))
        '    ''On Error GoTo 0
        '    'sentakukokyakuid = Trim(.Cell(flexcpText, , 1))
        '    'If sentakukokyakuid = "" Then
        '    '    ret = MsgBox("削除したい仕入伝票を選択してから再度実行してください。", 16, "総合管理システム「SPSALES」")
        '    '    Exit Sub
        '    'End If
        '    'resres = MsgBox("本当に削除してよいですか？", vbYesNo)
        '    'If resres = vbNo Then
        '    '    Exit Sub
        '    'End If

        '    sql_saku = "select * from shiire where shiireid='" & sentakukokyakuid & "'"

        '    If FcSQlGet(1, rs_saku, sql_saku, WMsg) = False Then
        '        'ret = MsgBox("選択した納品書がみつかりません。", 16, "総合管理システム「SPSALES」")
        '        'Exit Sub
        '    Else

        '        cnn.BeginTrans
        '        rs_saku2.CursorLocation = adUseClient
        '        rs_saku2.CursorType = adOpenForwardOnly ' adOpenStatic
        '        rs_saku2.LockType = adLockBatchOptimistic
        '        rs_saku2.Open("SELECT * FROM shiireshousai where shiireid='" & sentakukokyakuid & "'", cnn, , , adCmdText)

        '        If rs_saku2.RecordCount > 0 Then
        '            sakujosurusuu = rs_saku2.RecordCount
        '            ReDim sakujosurudata(sakujosurusuu, 3)
        '            rs_saku2.MoveFirst
        '            sssi = 1
        '            Do Until rs_saku2.EOF
        '                sakujosurudata(sssi, 0) = rs_saku2!shouhinid
        '                sakujosurudata(sssi, 1) = rs_saku2!kosuu
        '                rs_saku2.Delete
        '                rs_saku2.MoveNext
        '                sssi = sssi + 1
        '            Loop
        '            rs_saku2.UpdateBatch
        '            rs_saku2.Close
        '        End If

        '        rs_saku3.CursorLocation = adUseClient
        '        rs_saku3.CursorType = adOpenForwardOnly ' adOpenStatic
        '        rs_saku3.LockType = adLockBatchOptimistic
        '        rs_saku3.Open("SELECT * FROM shiire where shiireid='" & sentakukokyakuid & "'", cnn, , , adCmdText)

        '        If rs_saku3.RecordCount > 0 Then
        '            rs_saku3.MoveFirst
        '            Do Until rs_saku3.EOF
        '                rs_saku3.Delete
        '                rs_saku3.MoveNext
        '            Loop
        '            rs_saku3.UpdateBatch
        '            rs_saku3.Close
        '        End If

        '        '在庫数の調整
        '        Dim msuu As Double, isuu As Double, ssuu As Double
        '        For sssi = 1 To sakujosurusuu
        '        Set rs_saku4 = New ADODB.Recordset
        '        hen_shou_id4 = CStr(sakujosurudata(sssi, 0))
        '            sql_saku4 = "select * from shouhin " &
        '                      " WHERE shouhinid = '" & hen_shou_id4 & "'"
        '            rs_saku4.CursorType = adOpenKeyset
        '            rs_saku4.LockType = adLockOptimistic
        '            rs_saku4.Open(sql_saku4, cnn, , , adCmdText)
        '            msuu = rs_saku4!genzaikosuu
        '            isuu = sakujosurudata(sssi, 1)
        '            ssuu = rs_saku4!genzaikosuu - sakujosurudata(sssi, 1)
        '            rs_saku4!genzaikosuu = rs_saku4!genzaikosuu - sakujosurudata(sssi, 1)
        '            'If shouhin_zaiko_check(hen_shou_id4, "10", 3, msuu, isuu, ssuu) = False Then
        '            '    ret = MsgBox("在庫チェック作業中にエラーが発生しました。", 16, "総合管理システム「SPSALES」")
        '            'End If
        '            newbikou = "旧在庫：" & msuu & " 新在庫：" & ssuu
        '            If shouhin_zaiko_log("10", hen_shou_id4, 8, CStr(isuu), newbikou) = False Then
        '                ret = MsgBox("在庫ログ登録作業中にエラーが発生しました", 16, "総合管理システム「SPSALES」")
        '            End If
        '            rs_saku4.Update
        '            rs_saku4.Close
        '        Next sssi
        '        cnn.CommitTrans

        '        Picture16_Click
        '        ret = MsgBox("選択した仕入伝票を削除しました。", 64, "総合管理システム「SPSALES」")
        '    End If

        'End With

        'Exit Sub

        ''ERRORREC1:
        ''        ret = MsgBox("削除したい仕入伝票を選択してから再度実行してください。", 16, "総合管理システム「SPSALES」")
        ''        Exit Sub

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        dgv_kensakukekka.Rows.Clear()
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub set_shiire_rireki()

        Dim hinichi_kanshi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_owari.Value.ToString("yyyyMMdd")
        Dim gyousha_id = Mid(Trim(cbx_gyousha.Text), 1, 3)

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 9

            .Columns(0).Name = "NO"
            .Columns(1).Name = "仕入ID"
            .Columns(2).Name = "仕入日"
            .Columns(3).Name = "伝票番号"
            .Columns(4).Name = "仕入金額"
            .Columns(5).Name = "支払ID"
            .Columns(6).Name = "支払日"
            .Columns(7).Name = "業者"
            .Columns(8).Name = "備考"

            .Columns(0).Width = 75
            .Columns(1).Width = 100
            .Columns(2).Width = 110
            .Columns(3).Width = 100
            .Columns(4).Width = 90
            .Columns(5).Width = 100
            .Columns(6).Width = 110
            .Columns(7).Width = 250
            .Columns(8).Width = 250

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(4).DefaultCellStyle.Format = "#,##0"

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT shiire.*, gyousha.gyoushamei FROM shiire RIGHT JOIN gyousha ON shiire.gyoushaid = gyousha.gyoushaid"

            Dim query_where = " WHERE shiire.shiirebi BETWEEN '" + hinichi_kanshi + "' AND '" + hinichi_owari + "'"

            If gyousha_id <> "" Then
                query_where += " AND shiire.gyoushaid = '" & gyousha_id & "'"
            End If

            query += query_where + " ORDER BY shiire.shiirebi,gyousha.gyoushafurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shiire")
            Dim dt_server As DataTable = ds_server.Tables("t_shiire")

            Dim mojiretsu(8)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shiireid"))
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiirebi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                Dim denban = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("denban")) Then
                    denban = Trim(dt_server.Rows.Item(i).Item("denban"))
                End If
                mojiretsu(3) = denban

                Dim goukeikingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeikingaku")) Then
                    goukeikingaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeikingaku")))
                End If
                mojiretsu(4) = goukeikingaku

                Dim shukkinid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkinid")) Then
                    shukkinid = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                End If
                mojiretsu(5) = shukkinid

                Dim shiharaibi = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shiharaibi")) Then
                    shiharaibi = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiharaibi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(6) = shiharaibi

                mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("gyoushamei"))

                Dim bikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    bikou = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If
                mojiretsu(8) = bikou

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class