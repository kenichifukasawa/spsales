Imports System.Data.SqlClient

Public Class frmshuukei_shouhin

    Private Sub frmshuukei_shouhin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")
        set_gyousha_kubun()
        set_shouhin_kubun_1()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If cbx_shitei_shouhin.SelectedIndex <> -1 Then
            cbx_shitei_shouhin.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_2.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_2.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_shouhin_kubun_1.SelectedIndex <> -1 Then
            cbx_shouhin_kubun_1.SelectedIndex = -1
            Exit Sub
        End If

        If cbx_gyousha_kubun.SelectedIndex <> -1 Then
            cbx_gyousha_kubun.SelectedIndex = -1
            Exit Sub
        End If

    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

        lbl_kekka.Text = ""

        Dim hinichi_kanshi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim gyousha_kubun = Mid(Trim(cbx_gyousha_kubun.Text), 1, 2)
        Dim shouhin_kubun_1 = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2 = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)
        Dim shitei_shouhin = Mid(Trim(cbx_shitei_shouhin.Text), 1, 10)
        rbn_shouhin_id.Checked = True

        Dim shouhin_data(6, 0) As String
        Dim shouhin_count = 0
        ' すべての商品
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhin"

            If gyousha_kubun <> "" Then

                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query += " WHERE shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query += " WHERE shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                        Else
                            query += " WHERE shouhin.shouhinid = '" & shitei_shouhin & "' AND shouhin.shouhinkubunid0 ='" & gyousha_kubun & "'"
                        End If
                    End If
                Else
                    query += " WHERE shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                End If

            Else

                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query += " WHERE shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query += " WHERE shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "'"
                        Else
                            query += " WHERE shouhin.shouhinid = '" & shitei_shouhin & "'"
                        End If
                    End If
                Else
                    msg_go("業者区分、商品区分１が選択されていません。")
                    Exit Sub
                End If

            End If

            If rbn_shouhin_furigana.Checked = True Then
                query += " ORDER BY shouhinfurigana,shouhinmei"
            ElseIf rbn_shouhin_uriage.Checked = True Then
                query += " ORDER BY shouhinfurigana,shouhinmei"
            Else
                query += " ORDER BY shouhinid"
            End If

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin")

            shouhin_count = dt_server.Rows.Count
            If shouhin_count = 0 Then
                msg_go("商品が登録されていません。")
                Exit Sub
            End If

            ReDim shouhin_data(6, shouhin_count - 1)
            For i = 0 To shouhin_count - 1
                shouhin_data(1, i) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                shouhin_data(2, i) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                If Not IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    shouhin_data(5, i) = Trim(dt_server.Rows.Item(i).Item("genzaikosuu"))
                End If
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 仕入の商品
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT shouhin.shouhinid, shouhin.shouhinmei, SUM(shiireshousai.kosuu) AS shiiresuu" &
                " FROM (shouhin LEFT JOIN shiireshousai ON shouhin.shouhinid = shiireshousai.shouhinid)" &
                " LEFT JOIN shiire ON shiireshousai.shiireid = shiire.shiireid"

            Dim query_where = ""
            If gyousha_kubun = "" Then

                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                            " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                                " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "'"
                        Else
                            query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                                " AND shouhin.shouhinid = '" & shitei_shouhin & "'"
                        End If
                    End If
                Else
                    query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'"
                End If

            Else

                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                            " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                                " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                        Else
                            query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                                " AND shouhin.shouhinid = '" & shitei_shouhin & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                        End If
                    End If
                Else
                    query_where = " WHERE shiire.shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                End If

            End If

            query += query_where + " GROUP BY shouhin.shouhinid, shouhin.shouhinmei"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin_2")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin_2")

            For i = 0 To dt_server.Rows.Count - 1
                Dim shouhin_id = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                For j = 0 To shouhin_count - 1
                    If shouhin_data(1, j) = shouhin_id Then
                        shouhin_data(3, j) = Trim(dt_server.Rows.Item(i).Item("shiiresuu"))
                        Exit For
                    End If
                Next
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        '売上の商品
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT shouhin.shouhinid, shouhin.shouhinmei, SUM(hacchuushousai.kosuu) AS urisuu" &
                " FROM hacchuu RIGHT JOIN (hacchuushousai RIGHT JOIN shouhin ON hacchuushousai.shouhinid =" &
                "shouhin.shouhinid) ON hacchuu.hacchuuid = hacchuushousai.hacchuuid"

            Dim query_where = ""
            If gyousha_kubun = "" Then
                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "'"
                        Else
                            query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinid = '" & shitei_shouhin & "'"
                        End If
                    End If
                Else
                    query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'"

                End If
            Else

                If shouhin_kubun_1 <> "" Then
                    If shouhin_kubun_2 = "" Then
                        query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                    Else
                        If shitei_shouhin = "" Then
                            query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinkubunid = '" & shouhin_kubun_1 & "' AND shouhin.shouhinkubunid2 = '" & shouhin_kubun_2 & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                        Else
                            query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" &
                                        " AND shouhin.shouhinid = '" & shitei_shouhin & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"
                        End If
                    End If
                Else
                    query_where = " WHERE hacchuu.iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "' AND shouhin.shouhinkubunid0 = '" & gyousha_kubun & "'"

                End If
            End If

            query += query_where + " GROUP BY shouhin.shouhinid, shouhin.shouhinmei"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin_3")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin_3")

            For i = 0 To dt_server.Rows.Count - 1
                Dim shouhin_id = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                For j = 0 To shouhin_count - 1
                    If shouhin_data(1, j) = shouhin_id Then
                        shouhin_data(4, j) = Trim(dt_server.Rows.Item(i).Item("urisuu"))
                        Exit For
                    End If
                Next
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 6

            .Columns(0).Name = "NO"
            .Columns(1).Name = "商品ID"
            .Columns(2).Name = "商品名"
            .Columns(3).Name = "仕入数"
            .Columns(4).Name = "売上数"
            .Columns(5).Name = "現在庫数"

            .Columns(0).Width = 75
            .Columns(1).Width = 100
            .Columns(2).Width = 400
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 90

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End With

        Dim hacchuu_rireki_count = 0
        Dim sum_shiire = 0
        Dim sum_uriage = 0
        Dim sum_zaiko = 0
        Dim mojiretsu(5) As String

        For i = 0 To shouhin_count - 1
            If (shouhin_data(3, i) <> "" And shouhin_data(3, i) <> "0") Or (shouhin_data(4, i) <> "" And shouhin_data(4, i) <> "0") Or (shouhin_data(5, i) <> "" And shouhin_data(5, i) <> "0") Then
                hacchuu_rireki_count += 1

                mojiretsu(0) = hacchuu_rireki_count.ToString("D6")
                mojiretsu(1) = shouhin_data(1, i)
                mojiretsu(2) = shouhin_data(2, i)

                Dim shiire_suu = 0
                If Not shouhin_data(3, i) Then
                    shiire_suu = CInt(shouhin_data(3, i))
                End If
                mojiretsu(3) = shiire_suu.ToString("#,##0;-#,##0")
                sum_shiire += shiire_suu

                Dim uriage_suu = 0
                If Not shouhin_data(4, i) Then
                    uriage_suu = CInt(shouhin_data(4, i))
                End If
                mojiretsu(4) = uriage_suu.ToString("#,##0;-#,##0")
                sum_uriage += uriage_suu

                Dim zaiko_suu = 0
                If Not shouhin_data(5, i) Then
                    zaiko_suu = CInt(shouhin_data(5, i))
                End If
                mojiretsu(5) = zaiko_suu.ToString("#,##0;-#,##0")
                sum_zaiko += zaiko_suu

                dgv_kensakukekka.Rows.Add(mojiretsu)

            End If
        Next

        If hacchuu_rireki_count = 0 Then
            lbl_kekka.Text = "抽出結果：　仕入商品合計数　0　個、　売上商品合計数　0　個"
        Else
            lbl_kekka.Text = "抽出結果：　仕入合計　" & sum_shiire.ToString("#,0") & "　個、　売上合計　" & sum_uriage.ToString("#,0") & "　個 、　在庫合計　" & sum_zaiko.ToString("#,0") & "　個         "
        End If

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

    End Sub

    Private Sub cbx_shouhin_kubun_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_1.SelectedIndexChanged
        set_shouhin_kubun_2()
        set_shitei_shouhin()
    End Sub

    Private Sub cbx_shouhin_kubun_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shouhin_kubun_2.SelectedIndexChanged
        set_shitei_shouhin()
    End Sub

    Sub set_gyousha_kubun()

        cbx_gyousha_kubun.Items.Clear()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun0 ORDER BY shouhinkubunid0"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun0")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun0")

            For i = 0 To dt_server.Rows.Count - 1
                cbx_gyousha_kubun.Items.Add(Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shouhin_kubun_1()

        cbx_shouhin_kubun_1.Items.Clear()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun ORDER BY shouhinkubunid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun")

            For i = 0 To dt_server.Rows.Count - 1
                cbx_shouhin_kubun_1.Items.Add(Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shouhin_kubun_2()

        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)

        cbx_shouhin_kubun_2.Items.Clear()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun2 WHERE shouhinkubunid = '" & shouhin_kubun_1_id & "' ORDER BY narabe"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun2")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun2")

            For i = 0 To dt_server.Rows.Count - 1
                cbx_shouhin_kubun_2.Items.Add(Trim(dt_server.Rows.Item(i).Item("shouhinkubunid2")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shitei_shouhin()

        ' TODO

        Dim shouhin_kubun_1_id = Mid(Trim(cbx_shouhin_kubun_1.Text), 1, 2)
        Dim shouhin_kubun_2_id = Mid(Trim(cbx_shouhin_kubun_2.Text), 1, 4)

        cbx_shitei_shouhin.Items.Clear()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhin"

            Dim query_where = ""
            If shouhin_kubun_1_id <> "" Then
                query_where = " WHERE shouhinkubunid = '" + shouhin_kubun_1_id + "'"
            End If

            If shouhin_kubun_2_id <> "" Then
                If query_where = "" Then
                    query_where = " WHERE shouhinkubunid2 = '" + shouhin_kubun_2_id + "'"
                Else
                    query_where = " AND shouhinkubunid2 = '" + shouhin_kubun_2_id + "'"
                End If
            End If

            If chk_haiban.Checked = False Then
                If query_where = "" Then
                    query_where = " WHERE haiban IS NULL"
                Else
                    query_where = " AND haiban IS NULL"
                End If
            End If

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin")

            For i = 0 To dt_server.Rows.Count - 1
                cbx_shitei_shouhin.Items.Add(Trim(dt_server.Rows.Item(i).Item("shouhinid")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinmei")))
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class