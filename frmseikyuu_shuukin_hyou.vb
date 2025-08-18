Imports System.Data.SqlClient

Public Class frmseikyuu_shuukin_hyou

    Private Sub frmseikyuu_shuukin_hyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_shimebi.Items.AddRange(Deadline.Names)
        set_shain_cbx(5)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_shain_Click(sender As Object, e As EventArgs) Handles btn_clear_shain.Click
        cbx_shain.SelectedIndex = -1
    End Sub

    Private Sub btn_shuukei_Click(sender As Object, e As EventArgs) Handles btn_shuukei.Click

        If cbx_shimebi.SelectedIndex = -1 Then
            msg_go("〆日を選択して下さい。")
            Exit Sub
        End If
        Dim shimebi_id = Deadline.GetIdByName(Trim(cbx_shimebi.Text))

        Dim shain_id = Mid(Trim(cbx_shain.Text), 1, 2)

        lbl_kingaku.Text = ""

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 4

            .Columns(0).Name = "NO"
            .Columns(1).Name = "店舗ID"
            .Columns(2).Name = "店舗名"
            .Columns(3).Name = "繰越金額"

            .Columns(0).Width = 50
            .Columns(1).Width = 90
            .Columns(2).Width = 300
            .Columns(3).Width = 90

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(3).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim sum_goukei_gaku = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT tenpo.*, mailno_m.adress1 FROM tenpo LEFT JOIN mailno_m ON tenpo.mailno = mailno_m.mailno"

            Dim query_where = " WHERE tenpo.shimebi ='" + shimebi_id + "' AND tenpo.kadou <> '1' AND kurikoshi <> 0 AND kurikoshi IS NOT NULL "

            If shain_id <> "" Then
                query_where += " AND tenpo.shainid = '" & shain_id & "'"
            End If

            query += query_where + " ORDER BY tenpo.tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_tenpo"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(3)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = (i + 1).ToString()
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                Dim kurikoshi = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kurikoshi")) Then
                    kurikoshi = CInt(Trim(dt_server.Rows.Item(i).Item("kurikoshi")))
                End If
                mojiretsu(3) = kurikoshi
                sum_goukei_gaku += kurikoshi

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kingaku.Text = sum_goukei_gaku.ToString("#,0") + " 円"

        ' ----------------------------------------------------------

        ''Dim sql_seikyus As String, rs_saikyus As New ADODB.Recordset, newseikyusuu43 As Integer
        ''Dim sensenshainid As String, sousougoukei As Double

        'sub_kurikoshi_grid_set(1)
        'frmseikyuukurikoshi.lblgoukeigaku.Caption = "0"
        'sousougoukei = 0
        'If senshainid = -1 Then
        '    sql_seikyus = "select tenpo.*,mailno_m.adress1" &
        '                " from tenpo left join mailno_m on tenpo.mailno=mailno_m.mailno" &
        '                " where tenpo.shimebi ='" & karishime2 & "' and tenpo.kadou <> '1'" &
        '                " and (kurikoshi<>0 and kurikoshi is not null) " &
        '                  " order by tenpo.tenpofurigana"
        'Else
        '    sensenshainid = shainIDTbl(senshainid, 0)
        '    sql_seikyus = "select tenpo.*,mailno_m.adress1" &
        '                " from tenpo left join mailno_m on tenpo.mailno=mailno_m.mailno" &
        '                " where tenpo.shimebi ='" & karishime2 & "' and tenpo.kadou <> '1'" &
        '                " and shainid='" & sensenshainid & "'" &
        '                " and (kurikoshi<>0 and kurikoshi is not null) " &
        '                  " order by tenpo.tenpofurigana"
        'End If
        'If FcSQlGet(1, rs_saikyus, sql_seikyus, WMsg) = True Then
        '    newseikyusuu43 = 1
        '    sub_kurikoshi_grid_set(rs_saikyus.RecordCount + 1)
        '    With frmseikyuukurikoshi.gridseikyu
        '        Do Until rs_saikyus.EOF
        '            .Row = newseikyusuu43
        '            .Col = 0
        '            .Text = newseikyusuu43
        '            .Col = 1
        '            .Text = rs_saikyus!tenpoid
        '            .Col = 2
        '            .Text = rs_saikyus!tenpomei
        '            .Col = 3
        '            If IsNull(rs_saikyus!kurikoshi) Then
        '                .Text = "0"
        '            Else
        '                .Text = Format(rs_saikyus!kurikoshi, "#,##0;-#,##0")
        '                sousougoukei = sousougoukei + rs_saikyus!kurikoshi
        '            End If
        '            newseikyusuu43 = newseikyusuu43 + 1
        '            rs_saikyus.MoveNext
        '        Loop
        '        rs_saikyus.Close
        '    End With
        '    frmseikyuukurikoshi.lblgoukeigaku.Caption = Format(sousougoukei, "#,##0;-#,##0")

        'End If

    End Sub

    Private Sub btn_insatsu_Click(sender As Object, e As EventArgs) Handles btn_insatsu.Click

        msg_go("未開発")
        Exit Sub

        ' TODO

    End Sub

    Private Sub cbx_shimebi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shimebi.SelectedIndexChanged
        clear()
    End Sub

    Private Sub cbx_shain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_shain.SelectedIndexChanged
        clear()
    End Sub

    Private Sub clear()
        dgv_kensakukekka.Rows.Clear()
        lbl_kingaku.Text = ""
    End Sub

End Class