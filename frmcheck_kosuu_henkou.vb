Imports System.Data.SqlClient

Public Class frmcheck_kosuu_henkou

    Private can_set = False

    Private Sub frmcheck_kosuu_henkou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_kaishi_nen.Text = Now.ToString("yyyy")
        lbl_shuuryou_hinichi.Text = Now.ToString("yyyy/MM/dd")
        txt_kaishi_tsuki_hi.Text = ""
        set_shouhin_kubun_1(4)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_hozon_Click(sender As Object, e As EventArgs) Handles btn_hozon.Click

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cbx_shouhin_kubun_2.SelectedIndex = -1
    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        can_set = False
        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        set_shouhin_kubun_2(4, shouhin_kubun_1_id)
        can_set = True
        set_shouhin_ichiran()
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        set_shouhin_ichiran()
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
            End If

            set_shouhin_ichiran()

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

End Class