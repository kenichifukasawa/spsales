Imports System.Data.SqlClient

Public Class frmcheck_kosuu_henkou

    Private can_set = True
    Private kubun_1_index = -1
    Private kubun_2_index = -1

    Private Sub frmcheck_kosuu_henkou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_kaishi_nen.Text = Now.ToString("yyyy")
        lbl_shuuryou_hinichi.Text = Now.ToString("yyyy/MM/dd")
        txt_kaishi_tsuki_hi.Text = ""
        set_shouhin_kubun_1_cbx(4)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_hozon_Click(sender As Object, e As EventArgs) Handles btn_hozon.Click

        Dim dgv = dgv_kensakukekka
        For i = 0 To dgv.Rows.Count - 1

            If Trim(dgv(6, i).Value) = "" Then
                msg_go("棚卸し数が未入力の箇所があります。")
                Exit Sub
            End If

            Dim shouhin_id = dgv(0, i).Value
            If shouhin_id = "" Then
                msg_go("NOが取得できませんでした。")
                Exit Sub
            End If

        Next

        Try
            Using conn As New SqlConnection(connectionstring_sqlserver)
                conn.Open()

                Using trans = conn.BeginTransaction()

                    Try

                        For i = 0 To dgv.Rows.Count - 1

                            If Trim(dgv(10, i).Value) <> "○" Then
                                Continue For
                            End If

                            Dim shouhin_id = dgv(0, i).Value
                            Dim int_new_henkou_suu = CInt(Trim(dgv(6, i).Value))
                            Dim int_old_henkou_suu = CInt(Trim(dgv(11, i).Value))
                            Dim chousei_suu = Trim(dgv(12, i).Value)

                            Dim dbl_new_value As Integer
                            Dim sagaku_suu = ""

                            If chk_kouryo.Checked Then ' 考慮する場合

                                Dim int_chousei_suu = 0

                                If chousei_suu <> "err" And chousei_suu <> "" And chousei_suu <> "0" Then
                                    int_chousei_suu = CInt(chousei_suu)
                                End If

                                ' 現在庫 + 調整数 = 当時の在庫
                                Dim touji_suu = int_old_henkou_suu + int_chousei_suu

                                ' 棚卸数 - 当時の在庫 = 差額
                                sagaku_suu = (touji_suu - int_new_henkou_suu).ToString

                                ' 最終数
                                dbl_new_value = int_new_henkou_suu - int_chousei_suu

                            Else ' 考慮しない場合
                                dbl_new_value = int_new_henkou_suu
                            End If

                            Try

                                Dim query = "SELECT * FROM shouhin WHERE shouhinid ='" + shouhin_id + "'"

                                Dim da As New SqlDataAdapter
                                da = New SqlDataAdapter(query, conn)
                                Dim ds As New DataSet
                                da.Fill(ds, "t_shouhin")

                                ds.Tables("t_shouhin").Rows(0)("genzaikosuu") = dbl_new_value

                                Dim cb As New SqlCommandBuilder
                                cb.DataAdapter = da
                                da.Update(ds, "t_shouhin")
                                ds.Clear()

                            Catch ex As Exception
                                trans.Rollback()
                                msg_go(ex.Message)
                                Exit Sub
                            End Try

                            If create_hacchuu_and_hacchuushousai(shouhin_id, sagaku_suu, trans) = False Then
                                trans.Rollback()
                                msg_go("発注テーブルまたは発注詳細テーブルの更新でエラーが発生しました。")
                                Exit Sub
                            End If

                            Dim bikou = "旧在庫：" & int_old_henkou_suu.ToString & " 新在庫：" & dbl_new_value.ToString
                            Dim shainid = "10"
                            Dim naiyou = 11
                            Dim new_atai = dbl_new_value.ToString
                            If shouhin_zaiko_log(shainid, shouhin_id, naiyou, new_atai, bikou, , trans) = False Then
                                trans.Rollback()
                                msg_go("在庫ログ登録作業中にエラーが発生しました。")
                                Exit Sub
                            End If

                        Next

                        msg_go("テスト", 64)
                        trans.Rollback()
                        Exit Sub

                        trans.Commit()

                    Catch ex As Exception
                        trans.Rollback()
                        msg_go(ex.Message)
                        Exit Sub
                    End Try

                End Using

            End Using

        Catch ex As Exception
            msg_go("DB接続エラー：" & ex.Message)
            Exit Sub
        End Try

        msg_go("更新が完了しました。", 64)
        set_shouhin_ichiran()

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cbx_shouhin_kubun_2.SelectedIndex = -1
    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged

        If can_set = False Then
            can_set = True
            Exit Sub
        End If

        Dim index = cbx_shouhin_kubun_1.SelectedIndex
        If index <> kubun_1_index And check_changed() = True Then
            Dim result = MessageBox.Show("変更箇所が保存されていませんが、区分を変更してよろしいですか？", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
                can_set = False
                cbx_shouhin_kubun_1.SelectedIndex = kubun_1_index
                Exit Sub
            End If
        End If
        kubun_1_index = index

        can_set = False
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2_cbx(4, shouhin_kubun_1_id)
        can_set = True

        set_shouhin_ichiran()

    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged

        If can_set = False Then
            can_set = True
            Exit Sub
        End If

        Dim index = cbx_shouhin_kubun_2.SelectedIndex
        If index <> kubun_2_index And check_changed() = True Then
            Dim result = MessageBox.Show("変更箇所が保存されていませんが、区分を変更してよろしいですか？", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
                can_set = False
                cbx_shouhin_kubun_2.SelectedIndex = kubun_2_index
                Exit Sub
            End If
        End If
        kubun_2_index = index

        set_shouhin_ichiran()
        can_set = True
    End Sub

    Private Sub chk_kouryo_Click(sender As Object, e As EventArgs) Handles chk_kouryo.Click
        set_shouhin_ichiran()
    End Sub

    Private Sub txt_tsuki_hi_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kaishi_tsuki_hi.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim tsuki_hi = Trim(txt_kaishi_tsuki_hi.Text)

            Dim parts() As String = tsuki_hi.Split("/"c)
            Dim num1 As Integer, num2 As Integer
            Dim is_integer = True
            If Not (parts.Length = 2 AndAlso Integer.TryParse(parts(0), num1) AndAlso Integer.TryParse(parts(1), num2)) Then
                is_integer = False
            End If

            If tsuki_hi.Length <> 5 Or Mid(tsuki_hi, 3, 1) <> "/" Or is_integer = False Then
                msg_go("形式が違います。'/'(スラッシュ)ありの5ケタで入力してください。" + vbCrLf + vbCrLf + "（例）12/31")
                txt_kaishi_tsuki_hi.Text = ""
                Exit Sub
            End If

            If chk_kouryo.Checked = False Then
                msg_go("チェックボックスにチェックをつけると入力した期間が反映されます。", 64)
                Exit Sub
            End If

            set_shouhin_ichiran()

        End If

    End Sub

    Private Sub dgv_kensakukekka_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_kensakukekka.CellBeginEdit
        dgv_kensakukekka.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.LightYellow
    End Sub

    Private Sub dgv_kensakukekka_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_kensakukekka.CellEndEdit

        Dim dgv = dgv_kensakukekka
        Dim row = dgv.Rows(e.RowIndex)

        If e.ColumnIndex = 6 Then
            Dim tanaoroshiStr = row.Cells(6).Value?.ToString()
            Dim genzaiStr = row.Cells(11).Value?.ToString()

            Dim tanaoroshi As Integer
            Dim genzai As Integer

            If Integer.TryParse(tanaoroshiStr, tanaoroshi) AndAlso Integer.TryParse(genzaiStr, genzai) Then
                If tanaoroshi <> genzai Then
                    row.Cells(10).Value = "○"
                End If
            End If
        End If

        If e.RowIndex Mod 2 = 0 Then
            row.Cells(e.ColumnIndex).Style.BackColor = dgv.DefaultCellStyle.BackColor
        Else
            row.Cells(e.ColumnIndex).Style.BackColor = dgv.AlternatingRowsDefaultCellStyle.BackColor
        End If

    End Sub

    Private Sub set_shouhin_ichiran()

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 13

            .Columns(0).Name = "商品ID"
            .Columns(1).Name = "商品名"
            .Columns(2).Name = "区分１"
            .Columns(3).Name = "区分２"
            .Columns(4).Name = "価格"
            .Columns(5).Name = "原価"
            .Columns(6).Name = "棚卸し" + vbCrLf + "数"
            .Columns(7).Name = "使用/廃盤"
            .Columns(8).Name = "コード"
            .Columns(9).Name = "税区分"
            .Columns(10).Name = "変更"
            .Columns(11).Name = "現在" + vbCrLf + "庫数"
            .Columns(12).Name = "移動数"

            .Columns(0).Width = 110
            .Columns(1).Width = 400
            .Columns(2).Width = 30
            .Columns(3).Width = 150
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(6).Width = 80
            .Columns(7).Width = 100
            .Columns(8).Width = 0
            .Columns(9).Width = 80
            .Columns(10).Width = 45
            .Columns(11).Width = 80
            If chk_kouryo.Checked Then
                .Columns(12).Width = 90
            Else
                .Columns(12).Width = 0
            End If

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 50

            .ReadOnly = False
            For i = 0 To .ColumnCount - 1
                If i = 6 Then
                    .Columns(i).ReadOnly = False
                Else
                    .Columns(i).ReadOnly = True
                End If
            Next

        End With

        If can_set = False Then
            Exit Sub
        End If

        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        If shouhin_kubun_1_id = "" And shouhin_kubun_2_id = "" Then
            Exit Sub
        End If


        Dim tsuki_hi = Trim(txt_kaishi_tsuki_hi.Text)

        Dim parts() As String = tsuki_hi.Split("/"c)
        Dim num1 As Integer, num2 As Integer
        Dim is_integer = True
        If Not (parts.Length = 2 AndAlso Integer.TryParse(parts(0), num1) AndAlso Integer.TryParse(parts(1), num2)) Then
            is_integer = False
        End If

        If chk_kouryo.Checked Then

            If txt_kaishi_tsuki_hi.Text <> "" And (tsuki_hi.Length <> 5 Or Mid(tsuki_hi, 3, 1) <> "/" Or is_integer = False) Then
                msg_go("形式が違います。'/'(スラッシュ)ありの5ケタで入力してください。" + vbCrLf + vbCrLf + "（例）12/31")
                txt_kaishi_tsuki_hi.Text = ""
                chk_kouryo.Checked = False
                Exit Sub
            End If

            If txt_kaishi_tsuki_hi.Text = "" Then
                Dim result = MessageBox.Show("月日が入力されていないため、" + Now.ToString("yyyy") + "/02/01以降で計算します。時間がかかりますがよろしいですか？", "nPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.No Then
                    chk_kouryo.Checked = False
                    Exit Sub
                End If
            End If

        End If

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" +
                " FROM (shouhin LEFT JOIN shouhinkubun ON shouhin.shouhinkubunid = shouhinkubun.shouhinkubunid)" +
                " LEFT JOIN shouhinkubun2 ON shouhin.shouhinkubunid2 = shouhinkubun2.shouhinkubunid2"

            Dim query_where = " WHERE shouhin.shouhinkubunid = '" + shouhin_kubun_1_id + "'"

            If shouhin_kubun_2_id <> "" Then
                query_where += " AND shouhin.shouhinkubunid2 = '" + shouhin_kubun_2_id + "'"
            End If

            If chk_mishiyou_hihyouji.Checked Then
                query_where += " AND shouhin.mishiyou = '0'"
            End If

            query += query_where + " ORDER BY shouhin.shouhinid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin")

            Dim mojiretsu(15) As String
            For i = 0 To dt_server.Rows.Count - 1

                Dim shouhin_id = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                mojiretsu(0) = shouhin_id

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))

                Dim shouhinkubunmei2 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunmei2")) Then
                    shouhinkubunmei2 = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                End If
                mojiretsu(3) = shouhinkubunmei2

                mojiretsu(4) = Trim(CInt(dt_server.Rows.Item(i).Item("kakaku")).ToString("#,0"))

                Dim genka = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("genka")) Then
                    genka = Trim(CInt(dt_server.Rows.Item(i).Item("genka")).ToString("#,0"))
                End If
                mojiretsu(5) = genka

                Dim motoatai = "0"
                Dim genzaikosuu = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    genzaikosuu = Trim(CInt(dt_server.Rows.Item(i).Item("genzaikosuu")).ToString("#,0"))
                    motoatai = genzaikosuu
                End If
                mojiretsu(6) = genzaikosuu

                Dim mishiyou = ""
                If Trim(dt_server.Rows.Item(i).Item("mishiyou")) = "0" Then
                    mishiyou = "○"
                Else
                    mishiyou = "×"
                End If

                Dim haiban = ""
                If IsDBNull(dt_server.Rows.Item(i).Item("haiban")) Then
                    haiban = "/×"
                Else
                    haiban = "/○"
                End If
                mojiretsu(7) = mishiyou + haiban

                Dim barcode = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("barcode")) Then
                    barcode = Trim(dt_server.Rows.Item(i).Item("barcode"))
                End If
                mojiretsu(8) = barcode

                Dim hikazei = ""
                If IsDBNull(dt_server.Rows.Item(i).Item("hikazei")) Then
                    hikazei = "課税"
                Else
                    hikazei = "非課税"
                End If
                mojiretsu(9) = hikazei

                mojiretsu(10) = "×"
                mojiretsu(11) = motoatai

                Dim modorikouryo = ""
                If chk_kouryo.Checked Then
                    modorikouryo = calcurate_kouryo(shouhin_id)
                    If modorikouryo = "" Then
                        modorikouryo = "err"
                    End If
                End If
                mojiretsu(12) = modorikouryo

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Function calcurate_kouryo(shouhin_id As String)

        Dim kikan_kaishi = Now.ToString("yyyy")
        Dim tsuki_hi = Trim(txt_kaishi_tsuki_hi.Text)
        If tsuki_hi = "" Then
            kikan_kaishi += "0201"
        Else
            kikan_kaishi += Mid(tsuki_hi, 1, 2) + Mid(tsuki_hi, 4, 2)
        End If

        Dim kikan_shuuryou = Trim(lbl_shuuryou_hinichi.Text)

        Dim kikansousuu = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuu RIGHT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid" +
                " WHERE hacchuushousai.shouhinid = '" + shouhin_id + "' AND hacchuu.iraibi BETWEEN '" + kikan_kaishi + "' AND '" + kikan_shuuryou + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_hacchuu")
            Dim dt_server As DataTable = ds_server.Tables("t_hacchuu")

            For i = 0 To dt_server.Rows.Count - 1
                kikansousuu += CInt(Trim(dt_server.Rows.Item(i).Item("kosuu")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return -1
        End Try

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shiire RIGHT JOIN shiireshousai ON shiire.shiireid = shiireshousai.shiireid" +
                " WHERE shiireshousai.shouhinid = '" + shouhin_id + "' AND shiire.shiirebi BETWEEN '" + kikan_kaishi + "' AND '" + kikan_shuuryou + "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shiire")
            Dim dt_server As DataTable = ds_server.Tables("t_shiire")

            For i = 0 To dt_server.Rows.Count - 1
                kikansousuu -= CInt(Trim(dt_server.Rows.Item(i).Item("kosuu")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return -1
        End Try

        Return kikansousuu.ToString("#,0")

    End Function

    Private Function check_changed() As Boolean

        Dim dgv = dgv_kensakukekka

        For i = 0 To dgv.Rows.Count - 1
            If dgv(10, i).Value = "○" Then
                Return True
            End If
        Next

        Return False

    End Function

    Private Function create_hacchuu_and_hacchuushousai(shouhin_id As String, kosuu As String, Optional extTrans As SqlTransaction = Nothing) As Boolean

        If kosuu = "" Then
            Return True
        End If

        Dim conn As SqlConnection = Nothing
        Dim trans As SqlTransaction = extTrans
        Dim localConn As Boolean = False

        Try
            If trans Is Nothing Then
                conn = New SqlConnection(connectionstring_sqlserver)
                conn.Open()
                trans = conn.BeginTransaction()
                localConn = True
            Else
                conn = trans.Connection
            End If

            Dim table_name = "hacchuu"
            Dim id = 1
            Dim s_no = 2
            Dim ketasuu = 8
            Dim new_id = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)

            Dim query = "SELECT TOP 1 * FROM " + table_name

            Dim new_hacchuu_id = ""
            Using da As New SqlDataAdapter(query, conn)
                da.SelectCommand.Transaction = trans

                Dim ds As New DataSet
                Dim temp_table_name = "t_" + table_name
                da.Fill(ds, temp_table_name)

                Dim cb As New SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

                data_row("hacchuuid") = new_id
                data_row("iraibi") = Now.ToString("yyyyMMdd")
                data_row("shainid") = "00"
                data_row("tenpoid") = "999999"
                data_row("goukei") = 0
                data_row("joukyou") = "0"

                ds.Tables(temp_table_name).Rows.Add(data_row)

                da.Update(ds, temp_table_name)
                ds.Clear()

                new_hacchuu_id = new_id
            End Using

            ' 発注詳細テーブル insert
            table_name = "hacchuushousai"
            id = 1
            s_no = 3
            ketasuu = 10
            new_id = get_and_update_settings(table_name:=table_name, id:=id, s_no:=s_no, ketasuu:=ketasuu)

            query = "SELECT TOP 1 * FROM " + table_name

            Using da As New SqlDataAdapter(query, conn)
                da.SelectCommand.Transaction = trans

                Dim ds As New DataSet
                Dim temp_table_name = "t_" + table_name
                da.Fill(ds, temp_table_name)

                Dim cb As New SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables(temp_table_name).NewRow()

                data_row("hachuushousaiid") = new_id
                data_row("hacchuuid") = new_hacchuu_id
                data_row("shouhinid") = shouhin_id
                data_row("kosuu") = CInt(kosuu)

                ds.Tables(temp_table_name).Rows.Add(data_row)

                da.Update(ds, temp_table_name)
                ds.Clear()
            End Using

            If localConn Then
                trans.Commit()
            End If

            Return True

        Catch ex As Exception
            If trans IsNot Nothing AndAlso localConn Then
                trans.Rollback()
            End If

            msg_go(ex.Message)
            Return False

        Finally
            If localConn AndAlso conn IsNot Nothing Then
                conn.Close()
                conn.Dispose()
            End If
        End Try

    End Function

End Class