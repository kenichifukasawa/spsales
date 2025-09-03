Imports System.Data.SqlClient

Public Class frmseikyuusho_hakkou_insatsu_shousai

    Private Sub frmseikyuusho_hakkou_insatsu_shousai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim hiduke = ConvertYmdSlashStringToYmd(Trim(lbl_hiduke.Text))
        Dim tenpo_id = lbl_tenpo_id.Text

        With dgv_kensakukekka

            .Rows.Clear()
            .RowHeadersWidth = 4
            .Columns.Clear()
            .ColumnCount = 11

            .Columns(0).Name = "ID"
            .Columns(1).Name = "納品日"
            .Columns(2).Name = "社員"
            .Columns(3).Name = "金額"
            .Columns(4).Name = "値引き"
            .Columns(5).Name = "納品書NO"
            .Columns(6).Name = "社員ID"
            .Columns(7).Name = "プリント種類"
            .Columns(8).Name = "ダミー2"
            .Columns(9).Name = "備考1"
            .Columns(10).Name = "備考2"

            .Columns(0).Width = 90
            .Columns(1).Width = 110
            .Columns(2).Width = 80
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 100
            .Columns(9).Width = 100
            .Columns(10).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(3).DefaultCellStyle.Format = "#,##0"
            .Columns(4).DefaultCellStyle.Format = "#,##0"

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        Dim seikyuu_goukei = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.*, shain.ryakumei FROM hacchuu LEFT JOIN shain ON hacchuu.shainid = shain.shainid" +
                " WHERE hacchuu.tenpoid = '" + tenpo_id + "'AND hacchuu.joukyou = '0' AND hacchuu.iraibi <= '" + hiduke + "'" +
                " ORDER BY hacchuu.iraibi"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_hacchuu"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            Dim mojiretsu(11)
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("hacchuuid"))
                mojiretsu(1) = ConvertYmdStringToYmdSlash(Trim(dt_server.Rows.Item(i).Item("iraibi")))
                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("ryakumei"))

                Dim goukei = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("goukei")) Then
                    goukei = CInt(Trim(dt_server.Rows.Item(i).Item("goukei")))
                End If
                seikyuu_goukei += goukei
                mojiretsu(3) = goukei

                Dim nebiki = 0
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nebiki")) Then
                    nebiki = CInt(Trim(dt_server.Rows.Item(i).Item("nebiki")))
                End If
                mojiretsu(4) = nebiki

                Dim nouhinshoid = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("nouhinshoid")) Then
                    nouhinshoid = Trim(dt_server.Rows.Item(i).Item("nouhinshoid"))
                End If
                mojiretsu(5) = nouhinshoid

                mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("shainid"))

                Dim print_shurui = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("print_shurui")) Then
                    print_shurui = PrintCategory.GetNameById(Trim(dt_server.Rows.Item(i).Item("print_shurui")))
                End If
                mojiretsu(7) = print_shurui

                Dim dami2 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("dami2")) Then
                    dami2 = Trim(dt_server.Rows.Item(i).Item("dami2"))
                End If
                mojiretsu(8) = dami2

                Dim bikou1 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou1")) Then
                    bikou1 = Trim(dt_server.Rows.Item(i).Item("bikou1"))
                End If
                mojiretsu(9) = bikou1

                Dim bikou2 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou2")) Then
                    bikou2 = Trim(dt_server.Rows.Item(i).Item("bikou2"))
                End If
                mojiretsu(10) = bikou2

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        lbl_kekka.Text = "売上金額 : " + seikyuu_goukei.ToString("#,0") + " 円、  " + "入金金額 : " & Trim(lbl_kekka.Text) & " 円"

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        Dim dgv = dgv_kensakukekka
        If dgv.Rows.Count = 0 Then
            msg_go("項目が表示されていません。")
            Exit Sub
        End If

        Dim current_row = dgv.CurrentRow
        Dim hacchuuid As String = Trim(current_row.Cells(0).Value)
        Dim hinichi As String = Trim(current_row.Cells(1).Value)
        Dim nouhinsho_no As String = Trim(current_row.Cells(5).Value)
        Dim bikou1 As String = Trim(current_row.Cells(9).Value)
        Dim bikou2 As String = Trim(current_row.Cells(10).Value)
        Dim print_shurui_id As String = Trim(current_row.Cells(7).Value)
        Dim dami2 As String = Trim(current_row.Cells(8).Value)
        Dim shain_id As String = Trim(current_row.Cells(6).Value)
        Dim tenpo_mei = Trim(lbl_tenpo_mei.Text)

        set_shain_cbx(7)

        With frmdenpyou

            .GroupBox5.Text += "　（ " + tenpo_mei + " )"

            .cbx_shurui.Items.Clear()
            .cbx_shurui.Items.AddRange(PrintCategory.Names)
            .cbx_shurui.SelectedIndex = .cbx_shurui.FindStringExact(PrintCategory.GetNameById(print_shurui_id))

            .DateTimePicker1.Text = hinichi
            .txt_nouhinsho_no.Text = nouhinsho_no

            If nouhinsho_no = "" Then
                .chk_nouhinsho_pc.Checked = True
                .txt_nouhinsho_no.Enabled = False
            Else
                .chk_nouhinsho_pc.Checked = False
                .txt_nouhinsho_no.Enabled = True
            End If

            .txtbikou1.Text = bikou1
            .txtbikou2.Text = bikou2
            .cbx_shain.SelectedIndex = .cbx_shain.FindString(shain_id)

            If dami2 = "1" Then
                .chk_nouhinsho_houkoku.Checked = True
            Else
                .chk_nouhinsho_houkoku.Checked = False
            End If

            .lbl_hacchuuid.Text = hacchuuid

            .ShowDialog()

        End With

    End Sub

End Class