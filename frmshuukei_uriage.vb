Imports System.Data.SqlClient

Public Class frmshuukei_uriage

    Private Sub frmshuukei_uriage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_hinichi_kaishi.Value = Now.ToString("yyyy/MM/dd")
        dtp_hinichi_owari.Value = Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_nouhinsho_denpyou_sousuu.Text = ""
        lbl_nouhinsho_goukei_kingaku.Text = ""
        lbl_shiire_denpyou_goukei_kingaku.Text = ""
        lbl_shiire_denpyou_sousuu.Text = ""
        lbl_shiharai_denpyou_goukei_kingaku.Text = ""
        lbl_shiharai_denpyou_sousuu.Text = ""
        lbl_seikyuusho_uriagegaku.Text = ""
        lbl_seikyuusho_shouhizei_gaku.Text = ""
        lbl_seikyuusho_souseikyuu_goukei.Text = ""
        lbl_seikyuusho_hakkou_sousuu.Text = ""
        lbl_nyuukin_goukei_kingaku.Text = ""
        lbl_nyuukin_sousuu.Text = ""
        dgv_kensakukekka.Rows.Clear()
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

        Dim hinichi_kanshi = dtp_hinichi_kaishi.Value.ToString("yyyyMMdd")
        Dim hinichi_owari = dtp_hinichi_owari.Value.ToString("yyyyMMdd")

        ' 納品書伝票集計
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT COUNT(hacchuuid) AS dcount, SUM(goukei) AS dkingaku FROM hacchuu" +
                " WHERE iraibi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                " AND dami2 IS NULL"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_hacchuu")
            Dim dt_server As DataTable = ds_server.Tables("t_hacchuu")

            If dt_server.Rows.Count = 0 Then
                lbl_nouhinsho_goukei_kingaku.Text = "0 円"
                lbl_nouhinsho_denpyou_sousuu.Text = "0 件"
            Else
                If IsDBNull(dt_server.Rows.Item(0).Item("dkingaku")) Then
                    lbl_nouhinsho_goukei_kingaku.Text = "0 円"
                Else
                    lbl_nouhinsho_goukei_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("dkingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
                lbl_nouhinsho_denpyou_sousuu.Text = CInt(dt_server.Rows.Item(0).Item("dcount")).ToString("#,##0;-#,##0") + " 件"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try


        ' 仕入伝票集計
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT COUNT(shiireid) AS dcount, SUM(goukeikingaku) AS dkingaku FROM shiire" +
                " WHERE shiirebi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shiire")
            Dim dt_server As DataTable = ds_server.Tables("t_shiire")

            If dt_server.Rows.Count = 0 Then
                lbl_shiire_denpyou_goukei_kingaku.Text = "0 円"
                lbl_shiire_denpyou_sousuu.Text = "0 件"
            Else
                If IsDBNull(dt_server.Rows.Item(0).Item("dkingaku")) Then
                    lbl_shiire_denpyou_goukei_kingaku.Text = "0 円"
                Else
                    lbl_shiire_denpyou_goukei_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("dkingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
                lbl_shiire_denpyou_sousuu.Text = CInt(dt_server.Rows.Item(0).Item("dcount")).ToString("#,##0;-#,##0") + " 件"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 支払伝票集計
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT COUNT(shukkinid) AS dcount, SUM(shukkingaku) AS dkingaku FROM shukkin" +
                " WHERE shukkinbi BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shukkin")
            Dim dt_server As DataTable = ds_server.Tables("t_shukkin")

            If dt_server.Rows.Count = 0 Then
                lbl_shiharai_denpyou_goukei_kingaku.Text = "0 円"
                lbl_shiharai_denpyou_sousuu.Text = "0 件"
            Else
                If IsDBNull(dt_server.Rows.Item(0).Item("dkingaku")) Then
                    lbl_shiharai_denpyou_goukei_kingaku.Text = "0 円"
                Else
                    lbl_shiharai_denpyou_goukei_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("dkingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
                lbl_shiharai_denpyou_sousuu.Text = CInt(dt_server.Rows.Item(0).Item("dcount")).ToString("#,##0;-#,##0") + " 件"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 請求集計
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT COUNT(seikyuushoid) AS dcount, SUM(seikyuukingaku) AS dkingaku" +
                ", SUM(shoukei) AS dshoukei, SUM(shouhizei) AS dshouhizei" +
                " FROM seikyuusho" +
                " WHERE hiduke BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                " AND seikyuu_st = '0' AND dami IS NULL"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_seikyuusho")
            Dim dt_server As DataTable = ds_server.Tables("t_seikyuusho")

            If dt_server.Rows.Count = 0 Then
                lbl_seikyuusho_hakkou_sousuu.Text = "0 円"
                lbl_seikyuusho_uriagegaku.Text = "0 円"
                lbl_seikyuusho_souseikyuu_goukei.Text = "0 円"
                lbl_seikyuusho_shouhizei_gaku.Text = "0 件"
            Else
                If IsDBNull(dt_server.Rows.Item(0).Item("dshoukei")) Then
                    lbl_seikyuusho_uriagegaku.Text = "0 円"
                Else
                    lbl_seikyuusho_uriagegaku.Text = CInt(dt_server.Rows.Item(0).Item("dshoukei")).ToString("#,##0;-#,##0") + " 円"
                End If

                If IsDBNull(dt_server.Rows.Item(0).Item("dshouhizei")) Then
                    lbl_seikyuusho_shouhizei_gaku.Text = "0 円"
                Else
                    lbl_seikyuusho_shouhizei_gaku.Text = CInt(dt_server.Rows.Item(0).Item("dshouhizei")).ToString("#,##0;-#,##0") + " 円"
                End If

                If IsDBNull(dt_server.Rows.Item(0).Item("dkingaku")) Then
                    lbl_seikyuusho_souseikyuu_goukei.Text = "0 円"
                Else
                    lbl_seikyuusho_souseikyuu_goukei.Text = CInt(dt_server.Rows.Item(0).Item("dkingaku")).ToString("#,##0;-#,##0") + " 円"
                End If

                lbl_seikyuusho_hakkou_sousuu.Text = CInt(dt_server.Rows.Item(0).Item("dcount")).ToString("#,##0;-#,##0") + " 件"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        ' 入金集計
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT COUNT(seikyuushoid) AS dcount, SUM(seikyuukingaku) AS dkingaku" +
                " FROM seikyuusho" +
                " WHERE hiduke BETWEEN '" & hinichi_kanshi & "' AND '" & hinichi_owari & "'" +
                " AND seikyuu_st = '1' AND dami IS NULL"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_seikyuusho")
            Dim dt_server As DataTable = ds_server.Tables("t_seikyuusho")

            If dt_server.Rows.Count = 0 Then
                lbl_nyuukin_goukei_kingaku.Text = "0 円"
                lbl_nyuukin_sousuu.Text = "0 件"
            Else
                If IsDBNull(dt_server.Rows.Item(0).Item("dkingaku")) Then
                    lbl_nyuukin_goukei_kingaku.Text = "0 円"
                Else
                    lbl_nyuukin_goukei_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("dkingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
                lbl_nyuukin_sousuu.Text = CInt(dt_server.Rows.Item(0).Item("dcount")).ToString("#,##0;-#,##0") + " 件"
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        '社員別
        'mwgmwg = InputBox("パスワードを入力してください。", "パスワード確認") ' TODO
        'If mwgmwg <> "kamifusafusa" Then
        '    Exit Sub
        'End If

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 4

            .Columns(0).Name = "社員名"
            .Columns(1).Name = "売上金額"
            .Columns(2).Name = "入金金額"
            .Columns(3).Name = "繰越金額"

            .Columns(0).Width = 200
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 150

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shain WHERE zaishoku = '0' ORDER BY shainid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shain")
            Dim dt_server As DataTable = ds_server.Tables("t_shain")

            Dim mojiretsu(3)
            For i = 0 To dt_server.Rows.Count - 1

                Dim shainid = Trim(dt_server.Rows.Item(i).Item("shainid"))
                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                mojiretsu(1) = get_uriage_kingaku(shainid, hinichi_kanshi, hinichi_owari)
                mojiretsu(2) = get_nyuukin_kingaku(shainid, hinichi_kanshi, hinichi_owari)
                mojiretsu(3) = get_kurikoshi_kingaku(shainid, hinichi_kanshi, hinichi_owari)

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        dgv_kensakukekka.ClearSelection()

    End Sub

    Private Function get_uriage_kingaku(shainid As String, hinichi_kaishi As String, hinichi_owari As String) As String

        Dim kingaku = "0 円"

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT SUM(hacchuu.goukei) AS goukei_kingaku" +
                " FROM tenpo RIGHT JOIN hacchuu ON tenpo.tenpoid = hacchuu.tenpoid" +
                " WHERE tenpo.shainid = '" & shainid & "' AND hacchuu.iraibi BETWEEN '" & hinichi_kaishi & "' AND '" & hinichi_owari & "' AND hacchuu.dami2 IS NULL"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_hacchuu")
            Dim dt_server As DataTable = ds_server.Tables("t_hacchuu")

            If dt_server.Rows.Count <> 0 Then
                If Not IsDBNull(dt_server.Rows.Item(0).Item("goukei_kingaku")) Then
                    kingaku = CInt(dt_server.Rows.Item(0).Item("goukei_kingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
            End If

            dt_server.Clear()
            ds_server.Clear()

            Return kingaku

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

    Private Function get_nyuukin_kingaku(shainid As String, hinichi_kaishi As String, hinichi_owari As String) As String

        Dim kingaku = "0 円"

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT SUM(seikyuusho.seikyuukingaku) AS goukei_kingaku" +
                " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
                " WHERE tenpo.shainid = '" & shainid & "' AND seikyuusho.hiduke BETWEEN '" & hinichi_kaishi & "' And '" & hinichi_owari & "' AND seikyuusho.dami IS NULL AND seikyuusho.seikyuu_st = '1'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_seikyuusho")
            Dim dt_server As DataTable = ds_server.Tables("t_seikyuusho")

            If dt_server.Rows.Count <> 0 Then
                If Not IsDBNull(dt_server.Rows.Item(0).Item("goukei_kingaku")) Then
                    kingaku = CInt(dt_server.Rows.Item(0).Item("goukei_kingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
            End If

            dt_server.Clear()
            ds_server.Clear()

            Return kingaku

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

    Private Function get_kurikoshi_kingaku(shainid As String, hinichi_kaishi As String, hinichi_owari As String) As String

        Dim kingaku = "0 円"

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT SUM(tenpo.kurikoshi) AS goukei_kingaku FROM tenpo WHERE tenpo.shainid='" & shainid & "'"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            If dt_server.Rows.Count <> 0 Then
                If Not IsDBNull(dt_server.Rows.Item(0).Item("goukei_kingaku")) Then
                    kingaku = CInt(dt_server.Rows.Item(0).Item("goukei_kingaku")).ToString("#,##0;-#,##0") + " 円"
                End If
            End If

            dt_server.Clear()
            ds_server.Clear()

            Return kingaku

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

End Class