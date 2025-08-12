Imports System.Data.SqlClient

Public Class frmnyuukin_shori
    Private Sub frmnyuukin_shori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_tenpo_cbx(5, chk_hihyouji_torihiki_nai.Checked)
        dtp_hinichi.Value = Now.ToString("yyyy/MM/dd")
        cbx_shiharai_houhou.Items.AddRange(PaymentMethodsDeposit.Names)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_clear_tenpo_Click(sender As Object, e As EventArgs) Handles btn_clear_tenpo.Click
        cbx_tenpo.SelectedIndex = -1
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click
        With frmdenwachou
            .Text = "簡易検索"
            .lbl_form_id.Text = "5"
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub

    Private Sub chk_hihyouji_torihiki_nai_Click(sender As Object, e As EventArgs) Handles chk_hihyouji_torihiki_nai.Click
        set_tenpo_cbx(5, chk_hihyouji_torihiki_nai.Checked)
        set_shuukei()
    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged
        set_shuukei()
    End Sub

    Private Sub set_shuukei()

        With dgv_kensakukekka_nyuukin

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 6

            .Columns(0).Name = "入金日"
            .Columns(1).Name = "伝票NO"
            .Columns(2).Name = "入金金額"
            .Columns(3).Name = "方法"
            .Columns(4).Name = "備考"
            .Columns(5).Name = "領収NO"

            .Columns(0).Width = 110
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 100
            .Columns(4).Width = 350
            .Columns(5).Width = 90

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(2).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        With dgv_kensakukekka_seikyuu

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 4

            .Columns(0).Name = "請求日"
            .Columns(1).Name = "伝票NO"
            .Columns(2).Name = "請求金額"
            .Columns(3).Name = "税額"

            .Columns(0).Width = 110
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 90

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(2).DefaultCellStyle.Format = "#,##0"
            .Columns(3).DefaultCellStyle.Format = "#,##0"

            ' 行の高さの指定
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 40

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

        Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)
        If tenpo_id = "" Then
            Exit Sub
        End If

        Try

            Dim query = "SELECT * FROM seikyuusho WHERE tenpoid = '" + tenpo_id + "' AND seikyuu_st = '1' ORDER BY hiduke DESC"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(5)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))

                Dim seikyuukingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuukingaku")) Then
                    seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                End If
                mojiretsu(2) = seikyuukingaku

                mojiretsu(3) = PaymentMethodsDeposit.GetNameById(Trim(dt_server.Rows.Item(i).Item("seikyuutanni")))

                Dim seikyuubikou = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuubikou")) Then
                    seikyuubikou = Trim(dt_server.Rows.Item(i).Item("seikyuubikou"))
                End If
                mojiretsu(4) = seikyuubikou

                Dim ryoushuuno = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("ryoushuuno")) Then
                    ryoushuuno = Trim(dt_server.Rows.Item(i).Item("ryoushuuno"))
                End If
                mojiretsu(5) = ryoushuuno

                dgv_kensakukekka_nyuukin.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        Try

            Dim query = "SELECT * FROM seikyuusho WHERE tenpoid = '" + tenpo_id + "' AND seikyuu_st = '0' ORDER BY hiduke DESC"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_seikyuusho_2"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(3)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Date.ParseExact(Trim(dt_server.Rows.Item(i).Item("hiduke")), "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("seikyuushoid"))

                Dim seikyuukingaku = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("seikyuukingaku")) Then
                    seikyuukingaku = CInt(Trim(dt_server.Rows.Item(i).Item("seikyuukingaku")))
                End If
                mojiretsu(2) = seikyuukingaku

                Dim shouhizei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhizei")) Then
                    shouhizei = CInt(Trim(dt_server.Rows.Item(i).Item("shouhizei")))
                End If
                mojiretsu(3) = shouhizei

                dgv_kensakukekka_seikyuu.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try


        Try

            Dim query = "SELECT * FROM tenpo WHERE tenpoid = '" + tenpo_id + "'"

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_tenpo"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            If dt_server.Rows.Count > 0 Then
                lbl_kurikoshi_kingaku.Text = CInt(dt_server.Rows.Item(0).Item("kurikoshi")).ToString("#,0")
            End If

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Class