Imports System.Data.SqlClient

Public Class frmshiharai_rireki

    Private Sub frmshiharai_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima = CInt(DateTime.Now.ToString("yyyy"))

        cbx_nen.Items.Clear()
        For i = STARTED_YEAR To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))

        cbx_tsuki.Items.Clear()
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next
        cbx_tsuki.SelectedIndex = cbx_tsuki.FindStringExact(Now.ToString("MM"))

        set_gyousha_cbx(2, chk_hyouji_subete_gyousha.Checked)

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click
        set_shuukei()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        If dgv_kensakukekka.Rows.Count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

        Dim shukkin_id = dgv_kensakukekka.CurrentRow.Cells(1).Value
        Dim hiduke = dgv_kensakukekka.CurrentRow.Cells(2).Value
        Dim gyousha_mei = dgv_kensakukekka.CurrentRow.Cells(3).Value

        With frmshiharai_rireki_shousai

            With .dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 5

                .Columns(0).Name = "NO"
                .Columns(1).Name = "仕入ID"
                .Columns(2).Name = "仕入日"
                .Columns(3).Name = "仕入金額"
                .Columns(4).Name = "伝票番号"

                .Columns(0).Width = 40
                .Columns(1).Width = 100
                .Columns(2).Width = 110
                .Columns(3).Width = 90
                .Columns(4).Width = 100

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(3).DefaultCellStyle.Format = "#,##0"

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            End With

            Dim sum_goukei_gaku = 0

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT shiire.*, gyousha.gyoushamei FROM shiire RIGHT JOIN gyousha ON shiire.gyoushaid = gyousha.gyoushaid" +
                    " WHERE shiire.shukkinid = '" + shukkin_id + "' AND shiire.joukyou = '1'" +
                    " ORDER BY shiire.shiirebi, gyousha.gyoushafurigana"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_shiireshousai")
                Dim dt_server As DataTable = ds_server.Tables("t_shiireshousai")

                Dim mojiretsu(4)
                For i = 0 To dt_server.Rows.Count - 1

                    mojiretsu(0) = (i + 1).ToString()
                    mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shiireid"))
                    mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shiirebi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")

                    Dim goukeikingaku = 0
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("goukeikingaku")) Then
                        goukeikingaku = CInt(Trim(dt_server.Rows.Item(i).Item("goukeikingaku")))
                    End If
                    sum_goukei_gaku += goukeikingaku
                    mojiretsu(3) = goukeikingaku

                    Dim denban = ""
                    If Not IsDBNull(dt_server.Rows.Item(i).Item("denban")) Then
                        denban = Trim(dt_server.Rows.Item(i).Item("denban"))
                    End If
                    mojiretsu(4) = denban

                    .dgv_kensakukekka.Rows.Add(mojiretsu)

                Next

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Exit Sub
            End Try

            .lbl_hiduke.Text = hiduke
            .lbl_shukkin_id.Text = shukkin_id
            .lbl_shiiresaki.Text = gyousha_mei
            .lbl_kingaku.Text = sum_goukei_gaku.ToString("#,0") + "円"

            .ShowDialog()

        End With

        set_shuukei()

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

        Dim shukkin_id = dgv_kensakukekka.CurrentRow.Cells(1).Value

        Dim result As DialogResult = MessageBox.Show("以下の支払履歴を本当に削除しますか？" + vbCrLf + vbCrLf + "支払ID：" + shukkin_id, "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shiire WHERE shukkinid = '" + shukkin_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_shiire"
            da.Fill(ds, temp_table_name)

            Dim count = ds.Tables(temp_table_name).Rows.Count
            If count = 0 Then
                msg_go("選択した伝票が見つかりません")
                ds.Clear()
                Exit Sub
            End If

            For i = 0 To count - 1
                ds.Tables(temp_table_name).Rows(i)("joukyou") = "0"
                ds.Tables(temp_table_name).Rows(i)("shukkinid") = DBNull.Value
                ds.Tables(temp_table_name).Rows(i)("shiharaibi") = DBNull.Value
            Next

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Try
            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shukkin WHERE shukkinid = '" + shukkin_id + "'"

            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_shukkin"
            da.Fill(ds, temp_table_name)

            If ds.Tables(temp_table_name).Rows.Count > 0 Then
                ds.Tables(temp_table_name).Rows(0).Delete()
            Else
                msg_go("出金記録の削除に失敗しました。")
                ds.Clear()
                Exit Sub
            End If

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        msg_go("選択した支払伝票を削除しました。", 64)
        set_shuukei()

    End Sub

    Private Sub btn_clear_gyousha_Click(sender As Object, e As EventArgs) Handles btn_clear_gyousha.Click
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_kikan_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_kikan.Click
        gbx_shiharai_tsuki.Enabled = True
        gbx_gyousha.Enabled = False
        cbx_gyousha.SelectedIndex = -1
    End Sub

    Private Sub rbn_shubetsu_gyousha_Click(sender As Object, e As EventArgs) Handles rbn_shubetsu_gyousha.Click
        gbx_shiharai_tsuki.Enabled = False
        gbx_gyousha.Enabled = True
        cbx_tsuki.SelectedIndex = -1
        cbx_nen.SelectedIndex = cbx_nen.FindStringExact(Now.ToString("yyyy"))
    End Sub

    Private Sub chk_hyouji_subete_gyousha_Click(sender As Object, e As EventArgs) Handles chk_hyouji_subete_gyousha.Click
        set_gyousha_cbx(2, chk_hyouji_subete_gyousha.Checked)
    End Sub

    Private Sub cbx_nen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_nen.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_tsuki_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tsuki.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub cbx_gyousha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_gyousha.SelectedIndexChanged
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub set_shuukei()

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 8

            .Columns(0).Name = "NO"
            .Columns(1).Name = "支払ID"
            .Columns(2).Name = "支払日"
            .Columns(3).Name = "業者名"
            .Columns(4).Name = "支払金額"
            .Columns(5).Name = "支払方法"
            .Columns(6).Name = "支払期日"
            .Columns(7).Name = "備考"

            .Columns(0).Width = 50
            .Columns(1).Width = 90
            .Columns(2).Width = 110
            .Columns(3).Width = 280
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 110
            .Columns(7).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(4).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Try

            Dim query = "SELECT shukkin.*, gyousha.gyoushamei FROM shukkin RIGHT JOIN gyousha ON shukkin.gyoushaid = gyousha.gyoushaid"

            Dim query_where = ""
            If rbn_shubetsu_kikan.Checked Then

                Dim nen = cbx_nen.Text
                Dim tsuki = cbx_tsuki.Text
                If nen = "" Or tsuki = "" Then
                    msg_go("年と月は両方選択してください。")
                    Exit Sub
                End If
                Dim hinichi_kaishi = nen + tsuki + "01"
                Dim hinichi_owari = nen + tsuki + "31"

                query_where += " WHERE shukkin.shukkinbi BETWEEN '" + hinichi_kaishi + "' AND '" + hinichi_owari + "'"

            ElseIf rbn_shubetsu_gyousha.Checked Then

                Dim gyousha_id = Mid(Trim(cbx_gyousha.Text), 1, 3)
                If gyousha_id = "" Then
                    msg_go("業者を選択してください。")
                    Exit Sub
                End If

                query_where += " WHERE shukkin.gyoushaid = '" + gyousha_id + "'"

            End If

            query += query_where + " ORDER BY shukkin.shukkinbi DESC, gyousha.gyoushafurigana"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_shukkin"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(7)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shukkinid"))
                mojiretsu(2) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("shukkinbi")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("gyoushamei"))

                Dim shukkingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shukkingaku")) Then
                    shukkingaku = CInt(Trim(dt_server.Rows.Item(i).Item("shukkingaku")))
                End If
                mojiretsu(4) = shukkingaku

                mojiretsu(5) = PaymentMethodsInvoice.GetNameById(Trim(dt_server.Rows.Item(i).Item("shukkinhouhou")))

                Dim kijitsu = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kijitsu")) Then
                    kijitsu = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("kijitsu")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                End If
                mojiretsu(6) = kijitsu

                Dim bikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    bikou = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If
                mojiretsu(7) = bikou

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