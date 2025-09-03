Imports System.Data.SqlClient

Public Class frmdenpyou

    Private Sub frmdenpyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tenpo_hacchuurireki_set2(Trim(lbl_hacchuuid.Text))
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tenpo_hacchuurireki_set2(s_hacchuuid As String)

        With dgv_nouhinsho

            .Rows.Clear()
            .RowHeadersWidth = 4
            .Columns.Clear()
            .ColumnCount = 9

            .Columns(0).Name = "納品詳細ID"
            .Columns(1).Name = "商品ID"
            .Columns(2).Name = "商品名"
            .Columns(3).Name = "数量"
            .Columns(4).Name = "単価"
            .Columns(5).Name = "小計"
            .Columns(6).Name = "摘要"
            .Columns(7).Name = "確定"
            .Columns(8).Name = "軽減税率"

            .Columns(0).Width = 110
            .Columns(1).Width = 110
            .Columns(2).Width = 700
            .Columns(3).Width = 60
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(6).Width = 150
            .Columns(7).Width = 0
            .Columns(8).Width = 50

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            '列ヘッダーの高さを変える
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersHeight = 25

            ' 奇数行の既定セル・スタイルの背景色を設定
            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuushousai.*, hacchuu.*, shouhin.*" +
                " FROM (hacchuushousai LEFT JOIN shouhin ON hacchuushousai.shouhinid = shouhin.shouhinid)" +
                " LEFT JOIN hacchuu ON hacchuushousai.hacchuuid = hacchuu.hacchuuid" +
                " WHERE hacchuushousai.hacchuuid = '" + s_hacchuuid + "'"

            Dim data_adapter As SqlDataAdapter = New SqlDataAdapter(query, conn)
            Dim data_set As New DataSet
            data_adapter.Fill(data_set, "t_shoukaii")
            Dim data_table As DataTable = data_set.Tables("t_shoukaii")

            Dim s_kin As Decimal
            Dim s_sougaku As Integer = 0, s_10 As Integer = 0, s_8 As Integer = 0
            Dim mojiretsu(8) As String
            For i = 0 To data_table.Rows.Count - 1

                Dim item = data_table.Rows.Item(i)

                mojiretsu(0) = Trim(item("hachuushousaiid"))
                mojiretsu(1) = Trim(item("shouhinid"))
                mojiretsu(2) = Trim(item("shouhinmei"))

                s_kin = item("kosuu")
                mojiretsu(3) = s_kin.ToString("#,##0")

                s_kin = item("tanka")
                mojiretsu(4) = s_kin.ToString("#,##0")

                s_kin = item("kei")

                Dim s_konkai As Integer = s_kin
                s_sougaku += s_kin

                mojiretsu(5) = s_kin.ToString("#,##0")

                If IsDBNull(item("tekiyou")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(item("tekiyou"))
                End If

                Dim s_kakutei As Integer = 0
                If IsDBNull(item("kakutei")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(item("kakutei"))
                    '色の判定
                    If Trim(item("kakutei")) = "1" Then
                        s_kakutei = 1
                    End If
                End If
                If IsDBNull(item("keigen")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(item("keigen"))
                End If

                If IsDBNull(item("hikazei")) Then
                    If IsDBNull(item("keigen")) Then
                        s_10 += s_konkai
                    Else
                        s_8 += s_konkai
                    End If
                End If

                dgv_nouhinsho.Rows.Add(mojiretsu)

                '色をいれる
                If s_kakutei = 1 Then
                    dgv_nouhinsho.Rows(i).Cells(4).Style.BackColor = Color.FromArgb(&HC0E0FF)
                End If

            Next i

            data_table.Clear()
            data_set.Clear()

            lbl_shouhizei_10_percent.Text = s_10.ToString("#,0")
            lbl_shouhizei_8_percent.Text = s_8.ToString("#,0")
            lbl_nouhinsho_goukei.Text = s_sougaku.ToString("#,0")

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Private Sub btn_shuusei_Click(sender As Object, e As EventArgs) Handles btn_shuusei.Click

    End Sub

    Private Sub btn_sumi_Click(sender As Object, e As EventArgs) Handles btn_sumi.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub
End Class