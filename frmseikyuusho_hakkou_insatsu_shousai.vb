Imports System.Data.SqlClient

Public Class frmseikyuusho_hakkou_insatsu_shousai

    Private Sub frmseikyuusho_hakkou_insatsu_shousai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim hiduke = ConvertYmdSlashStringToYmd(Trim(lbl_hiduke.Text))
        Dim tenpo_id = lbl_tenpo_id.Text

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 6
            .RowHeadersWidth = 4

            .Columns(0).Name = "ID"
            .Columns(1).Name = "納品日"
            .Columns(2).Name = "社員"
            .Columns(3).Name = "金額"
            .Columns(4).Name = "値引き"
            .Columns(5).Name = "納品NO"

            .Columns(0).Width = 90
            .Columns(1).Width = 110
            .Columns(2).Width = 80
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 100

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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

            Dim mojiretsu(5)
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

        ' TODO:main画面に詳細が移動したため、保留
        frmdenpyou.ShowDialog()

    End Sub

End Class