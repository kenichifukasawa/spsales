Imports System.Data.SqlClient

Module m_shiire

    Sub set_shiire_rireki_shousai(dgv_count As Integer, shiire_id As String, hiduke As String, gyousha_mei As String)

        If dgv_count = 0 Then
            msg_go("履歴が表示されていません。")
            Exit Sub
        End If

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
                .Columns(5).Width = 188
                .Columns(6).Width = 0
                .Columns(7).Width = 0

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(3).DefaultCellStyle.Format = "#,##0"
                .Columns(4).DefaultCellStyle.Format = "#,##0"

                ' 行の高さの指定
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 25

                Dim currentFont As Font = .DefaultCellStyle.Font
                .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

                Dim currentColumnFont As Font = .ColumnHeadersDefaultCellStyle.Font
                .ColumnHeadersDefaultCellStyle.Font = New Font(currentColumnFont.FontFamily, 11.25F, currentColumnFont.Style)

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

    End Sub

End Module
