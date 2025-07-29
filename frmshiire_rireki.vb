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
                .ColumnCount = 8

                .Columns(0).Name = "NO"
                .Columns(1).Name = "詳細ID"
                .Columns(2).Name = "商品名"
                .Columns(3).Name = "数量"
                .Columns(4).Name = "金額"
                .Columns(5).Name = "備考"
                .Columns(6).Name = "商品ID"
                .Columns(7).Name = "区分ID（業者, 選択1, 選択2）"

                .Columns(0).Width = 75
                .Columns(1).Width = 110
                .Columns(2).Width = 300
                .Columns(3).Width = 80
                .Columns(4).Width = 90
                .Columns(5).Width = 194
                .Columns(6).Width = 0
                .Columns(7).Width = 0

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

                Dim query = "SELECT shiireshousai.*" +
                    ", shouhin.shouhinid, shouhin.shouhinmei, shouhin.shouhinkubunid, shouhin.shouhinkubunid0, shouhin.shouhinkubunid2" +
                    " FROM shiireshousai LEFT JOIN shouhin ON shiireshousai.shouhinid = shouhin.shouhinid" +
                    " WHERE shiireshousai.shiireid = '" + shiire_id + "'" +
                    " ORDER BY shiireshousai.shiireshousaiid"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_shiireshousai")
                Dim dt_server As DataTable = ds_server.Tables("t_shiireshousai")

                Dim mojiretsu(7)
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

                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) + ", " +
                         Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) + ", " +
                        Trim(dt_server.Rows.Item(i).Item("shouhinkubunid2"))

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

            Dim query = "SELECT * FROM shiire WHERE shiireid = '" & shiire_id & "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_shiire"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count > 0 Then
                ds.Tables(temp_table_name).Rows(0).Delete()

                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, temp_table_name)
                ds.Clear()

            Else
                msg_go("該当する仕入が見つかりません。")
                Exit Sub
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Dim shiireshousai_count As Integer = 0
        Dim shiireshousai_data(1, 0)
        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shiireshousai WHERE shiireid = '" & shiire_id & "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_shiireshousai"
            da.Fill(ds, temp_table_name)

            shiireshousai_count = ds.Tables(temp_table_name).Rows.Count
            ReDim shiireshousai_data(1, shiireshousai_count - 1)
            If shiireshousai_count > 0 Then
                Dim counter = 0
                For i As Integer = shiireshousai_count - 1 To 0 Step -1
                    shiireshousai_data(0, counter) = ds.Tables(temp_table_name).Rows(i)("shouhinid")
                    shiireshousai_data(1, counter) = ds.Tables(temp_table_name).Rows(i)("kosuu")
                    ds.Tables(temp_table_name).Rows(i).Delete()
                    counter += 1
                Next
                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, temp_table_name)
            End If

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        '在庫数の調整
        For i = 0 To shiireshousai_count - 1

            Dim shouhin_id = shiireshousai_data(0, i)

            Try

                Dim conn As New SqlConnection
                conn.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM shouhin WHERE shouhinid ='" + shouhin_id + "'"

                Dim da As New SqlDataAdapter
                da = New SqlDataAdapter(query, conn)
                Dim ds As New DataSet
                Dim temp_table_name = "t_shouhin"
                da.Fill(ds, temp_table_name)

                Dim kyuu_suu = ds.Tables(temp_table_name).Rows(0)("genzaikosuu")
                Dim shiire_suu = shiireshousai_data(1, i)
                Dim shin_suu = kyuu_suu - shiire_suu

                ds.Tables(temp_table_name).Rows(0)("genzaikosuu") = shin_suu

                Dim bikou = "旧在庫：" & kyuu_suu.ToString & " 新在庫：" & shin_suu.ToString
                Dim shainid = "10"
                Dim naiyou = 8
                Dim new_atai = shiire_suu.ToString
                If shouhin_zaiko_log(shainid, shouhin_id, naiyou, new_atai, bikou) = False Then
                    msg_go("在庫ログ登録作業中にエラーが発生しました。")
                    Exit Sub
                End If

                Dim cb As New SqlCommandBuilder
                cb.DataAdapter = da
                da.Update(ds, temp_table_name)
                ds.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

        Next

        msg_go("選択した仕入伝票を削除しました。", 64)
        set_shiire_rireki()

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