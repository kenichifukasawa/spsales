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

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

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

        If dgv_kensakukekka.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim tenpo_id = dgv_kensakukekka.CurrentRow.Cells(0).Value

        Dim form_id = Trim(lbl_form_id.Text)
        Select Case form_id
            Case "0" ' メイン画面
                mainset(tenpo_id)
            Case "1" ' 販売集計
                frmshuukei_hanbai.cbx_tenpo.SelectedIndex = frmshuukei_hanbai.cbx_tenpo.FindString(tenpo_id)
            Case "2" ' 繰越推移ログ
                frmcheck_kurikoshi_log.cbx_tenpo.SelectedIndex = frmcheck_kurikoshi_log.cbx_tenpo.FindString(tenpo_id)
            Case "3" ' 請求履歴
                frmseikyuu_rireki.cbx_tenpo.SelectedIndex = frmseikyuu_rireki.cbx_tenpo.FindString(tenpo_id)
            Case "4" ' 納品書移動
                Dim frm = frmnouhinsho_idou
                Dim button_no = Trim(lbl_button_no.Text)
                Select Case button_no
                    Case "0"
                        frm.cbx_tenpo.SelectedIndex = frm.cbx_tenpo.FindString(tenpo_id)
                    Case "1"
                        frm.cbx_tenpo_2.SelectedIndex = frm.cbx_tenpo_2.FindString(tenpo_id)
                    Case Else
                        msg_go("不明なボタンNOです。")
                        Exit Sub
                End Select
            Case Else
                msg_go("不明なフォームIDです。")
                Exit Sub
        End Select

        Me.Close() : Me.Dispose()

        ' ----------------------------------------------------------

        'If denwacho_no = 0 Then  'メイン画面

        '    If all_main_set(tenpo_id) = -1 Then
        '        Exit Sub
        '    End If

        '    tenpo_orderchu_set_10

        'ElseIf denwacho_no = 1 Then '請求書履歴のコンボ（OK）
        '    frmseikyuurireki.cmbtenpo.ListIndex = -1
        '    frmseikyuurireki.cmbtenpo.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'ElseIf denwacho_no = 2 Then '入金のコンボ
        '    frmnyuukin.cmbtenpo.ListIndex = -1
        '    frmnyuukin.cmbtenpo.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'ElseIf denwacho_no = 3 Then '入金のコンボ
        '    frmketsugou.cmbtenpo3.ListIndex = -1
        '    frmketsugou.cmbtenpo3.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'ElseIf denwacho_no = 4 Then '入金のコンボ
        '    frmketsugou.cmbtenpo4.ListIndex = -1
        '    frmketsugou.cmbtenpo4.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'ElseIf denwacho_no = 5 Then '請求書追加
        '    shitei_open(tenpo_id)
        'ElseIf denwacho_no = 6 Then '入金のコンボ （OK）
        '    frmshuukeishouhin.cmbtenpo.ListIndex = -1
        '    frmshuukeishouhin.cmbtenpo.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'ElseIf denwacho_no = 7 Then 'のコンボ （OK）
        '    frmkurikoshicheck.cmbtenpo.ListIndex = -1
        '    frmkurikoshicheck.cmbtenpo.ListIndex = FcCmbtenpoindexGet(tenpo_id)
        'End If

        'Me.Hide()

    End Sub
End Class