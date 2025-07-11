Imports System.Data.SqlClient

Public Class frmdenwachou

    Private Sub frmdenwachou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_denwachou()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub tcl_denwachou_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcl_denwachou.SelectedIndexChanged

        set_denwachou()

    End Sub

    Private Sub set_denwachou()

        ' VB6:kokyakuichiran()

        For Each page As TabPage In tcl_denwachou.TabPages
            page.Text = page.Text.Replace("★", "")
        Next
        tcl_denwachou.SelectedTab.Text = "★" + tcl_denwachou.SelectedTab.Text

        Dim currentTab As TabPage = tcl_denwachou.SelectedTab
        If Not currentTab.Controls.Contains(dgv_kensakukekka) Then
            dgv_kensakukekka.Parent = currentTab
            lbl_kensuu.Parent = currentTab
        End If

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .ColumnCount = 3

            .Columns(0).Name = "番号"
            .Columns(1).Name = "フリガナ"
            .Columns(2).Name = "店舗名"

            .Columns(0).Width = 100
            .Columns(1).Width = 320
            .Columns(2).Width = 320

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        End With

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT tenpoid, tenpomei,tenpofurigana FROM tenpo WHERE kadou = '0' ORDER BY tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            ' 選択中のタブのインデックスを取得
            Dim tabIndex As Integer = tcl_denwachou.SelectedIndex

            ' タブごとの判定パターンを用意
            Dim patterns As String()() = {
            New String() {"[ア-オ]*", "[あ-お]*", "[ヴ]*"}, ' あ行
            New String() {"[カ-コ]*", "[ガ-ゴ]*", "[か-こ]*", "[が-ご]*"}, ' か行
            New String() {"[サ-ソ]*", "[ザ-ゾ]*", "[さ-そ]*", "[ざ-ぞ]*"}, ' さ行
            New String() {"[タ-ト]*", "[ダ-ド]*", "[た-と]*", "[だ-ど]*"}, ' た行
            New String() {"[ナ-ノ]*", "[な-の]*"}, ' な行
            New String() {"[ハ-ホ]*", "[バ-ボ]*", "[パ-ポ]*", "[は-ほ]*", "[ば-ぼ]*", "[ぱ-ぽ]*"}, ' は行
            New String() {"[マ-モ]*", "[ま-も]*"}, ' ま行
            New String() {"[ヤ-ヨ]*", "[や-よ]*"}, ' や行
            New String() {"[ラ-ロ]*", "[ら-ろ]*"}, ' ら行
            New String() {} ' わ行（その他）
        }

            Dim tenpo_count = 0
            For i = 0 To dt_server.Rows.Count - 1
                Dim tenpo_id = Trim(dt_server.Rows(i).Item("tenpoid").ToString())
                Dim furigana = Trim(dt_server.Rows(i).Item("tenpofurigana").ToString())
                Dim tenpomei = Trim(dt_server.Rows(i).Item("tenpomei").ToString())

                Dim furigana_kashiramoji = Mid(furigana, 1, 1)
                furigana_kashiramoji = StrConv(furigana_kashiramoji, VbStrConv.Katakana)

                Dim match As Boolean = False

                If tabIndex < 9 Then
                    ' あ行～ら行
                    For Each pat In patterns(tabIndex)
                        If furigana_kashiramoji Like pat Then
                            match = True
                            Exit For
                        End If
                    Next
                Else
                    ' わ行（その他）
                    Dim found As Boolean = False
                    For j = 0 To 8
                        For Each pat In patterns(j)
                            If furigana_kashiramoji Like pat Then
                                found = True
                                Exit For
                            End If
                        Next
                        If found Then Exit For
                    Next
                    match = Not found
                End If

                If match Then
                    tenpo_count += 1
                    dgv_kensakukekka.Rows.Add(tenpo_id, furigana, tenpomei)
                End If
            Next

            dt_server.Clear()
            ds_server.Clear()

            lbl_kensuu.Text = tenpo_count.ToString("#,0") + " 件"

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub dgv_kensakukekka_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kensakukekka.CellMouseDoubleClick

    End Sub
End Class