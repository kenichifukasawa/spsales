Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmshuturyoku_csv
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click

        Dim shurui_name = Trim(lbl_shutsuryoku_type.Text)
        Dim hozon_path = DESKTOP_PATH + "\" + shurui_name + "_" + Now.ToString("yyyyMMdd") + "_" + Now.ToString("hhmm") + ".txt"
        Dim response As Boolean
        Select Case shurui_name
            Case "商品情報出力"
                msg_go("開発中")
                Exit Sub
            Case "店舗情報出力"
                response = output_csv_tenpo(hozon_path)
            Case "繰越残情報出力"
                msg_go("開発中")
                Exit Sub
            Case "Wella売上通知データ出力"
                msg_go("開発中")
                Exit Sub
            Case "ウエラ商品情報出力"
                msg_go("開発中")
                Exit Sub
            Case Else
                msg_go("出力タイプが判別できませんでした。")
                Exit Sub
        End Select

        If response Then
            msg_go("指定データのエクスポートが完了しました。", 64)
            Me.Close() : Me.Dispose()
        Else
            msg_go("指定データのエクスポートに失敗しました。")
        End If

        ' ----------------------------------------------------------

        'Dim sql_csv As String, rs_csv As New ADODB.Recordset, tsuika_kaishaid As String
        'Dim tsuika_genbaid As String, csvfailename As String, ddcounter As Long, hozonpath As String
        'Dim fileno As Integer, iremono As String, dddata(), ddcount As Long, ddi As Long, ddcounter2 As Long

        'With frmcsv

        '    If frmcsv.lblshurui.Caption = "店舗情報出力" Then

        '        csvfailename = hozonpath & "\店舗情報出力_" & Format(Of Date, "yyyymmdd")() & "-" & Format(Time, "hhmm") & ".txt"
        '        If frmcsv.chkchk.Value = 1 Then
        '            csv_csv2(1, csvfailename, 1)
        '        Else
        '            csv_csv2(1, csvfailename)
        '        End If

        '    ElseIf frmcsv.lblshurui.Caption = "商品情報出力" Then

        '        csvfailename = hozonpath & "\商品情報出力_" & Format(Of Date, "yyyymmdd")() & "-" & Format(Time, "hhmm") & ".txt"
        '        If frmcsv.chkchk.Value = 1 Then
        '            csv_csv2(2, csvfailename, 1)
        '        Else
        '            csv_csv2(2, csvfailename)
        '        End If

        '    ElseIf frmcsv.lblshurui.Caption = "ウエラ商品情報出力" Then

        '        csvfailename = hozonpath & "\ウエラ商品情報出力_" & Format(Of Date, "yyyymmdd")() & "-" & Format(Time, "hhmm") & ".txt"
        '        csv_csv2(3, csvfailename)

        '    ElseIf frmcsv.lblshurui.Caption = "繰越残情報出力" Then

        '        csvfailename = hozonpath & "\繰越残情報出力_" & Format(Of Date, "yyyymmdd")() & "-" & Format(Time, "hhmm") & ".txt"
        '        frmkikan.Show

        '        If shimenokikan = "" Then
        '            ret = MsgBox("中止しました。", 64, "総合管理システム「SPSALES」")
        '            Exit Sub
        '        End If

        '        csv_csv3(csvfailename, Mid(shimenokikan, 1, 4), Mid(shimenokikan, 5, 2))

        '    End If

        'End With

    End Sub

    Function output_csv_tenpo(hozon_path As String) As Boolean

        Dim csv_data(17, 0) As String
        Dim data_count = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query_where = ""
            If chk_plus_alpha.Checked = False Then
                query_where = " WHERE tenpo.kadou = '0'"
            End If

            Dim query = "SELECT tenpo.*, mailno_m.adress1, shain.shainmei" +
                " FROM shain RIGHT JOIN" +
                " (mailno_m RIGHT JOIN tenpo ON mailno_m.mailno = tenpo.mailno)" +
                " ON shain.shainid = tenpo.shainid" +
                query_where +
                " ORDER BY tenpo.tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータが存在しません。")
                Return False
            End If

            ReDim csv_data(17, data_count)
            csv_data(0, 0) = "店舗ID"
            csv_data(1, 0) = "店舗名"
            csv_data(2, 0) = "店舗フリガナ"
            csv_data(3, 0) = "郵便番号"
            csv_data(4, 0) = "住所１"
            csv_data(5, 0) = "住所２"
            csv_data(6, 0) = "電話番号"
            csv_data(7, 0) = "FAX番号"
            csv_data(8, 0) = "携帯番号"
            csv_data(9, 0) = "代表者名"
            csv_data(10, 0) = "担当者名"
            csv_data(11, 0) = "従業員数"
            csv_data(12, 0) = "〆情報"
            csv_data(13, 0) = "Eメール"
            csv_data(14, 0) = "備考"
            csv_data(15, 0) = "稼動(=0)"
            csv_data(16, 0) = "繰越金額"
            csv_data(17, 0) = "担当社員"

            For i = 1 To data_count - 1

                csv_data(0, i) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                csv_data(1, i) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                csv_data(2, i) = Trim(dt_server.Rows.Item(i).Item("tenpofurigana"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("mailno")) Then
                    csv_data(3, i) = Trim(dt_server.Rows.Item(i).Item("mailno"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("adress1")) Then
                    csv_data(4, i) = Trim(dt_server.Rows.Item(i).Item("adress1"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("tenpoadress")) Then
                    csv_data(5, i) = Trim(dt_server.Rows.Item(i).Item("tenpoadress"))
                End If

                csv_data(6, i) = Trim(dt_server.Rows.Item(i).Item("tel"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("fax")) Then
                    csv_data(7, i) = Trim(dt_server.Rows.Item(i).Item("fax"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("keitai")) Then
                    csv_data(8, i) = Trim(dt_server.Rows.Item(i).Item("keitai"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("daihyou")) Then
                    csv_data(9, i) = Trim(dt_server.Rows.Item(i).Item("daihyou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("tantou")) Then
                    csv_data(10, i) = Trim(dt_server.Rows.Item(i).Item("tantou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("juugyouinsuu")) Then
                    csv_data(11, i) = Trim(dt_server.Rows.Item(i).Item("juugyouinsuu"))
                End If

                csv_data(12, i) = Deadline.GetNameById(Trim(dt_server.Rows.Item(i).Item("shimebi")))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("email")) Then
                    csv_data(13, i) = Trim(dt_server.Rows.Item(i).Item("email"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    csv_data(14, i) = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("kadou")) Then
                    csv_data(15, i) = Trim(dt_server.Rows.Item(i).Item("kadou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("kurikoshi")) Then
                    csv_data(16, i) = Trim(dt_server.Rows.Item(i).Item("kurikoshi"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    csv_data(17, i) = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                End If

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        If create_csv_file(csv_data, hozon_path, data_count) Then
            Return True
        Else
            Return False
        End If

        ' ----------------------------------------------------------


        '        Dim sql_sentaku As String, rs_sentaku As New ADODB.Recordset, sususu As Long
        '        Dim datasuu As Long, writecounter As Long, rs_tsutsu As ADODB.Recordset, sql_tsutsu As String
        '        Dim kotoshi As String, motobi As String, hhh As String, ooo As String, ngyousuu As Long

        '        kotoshi = Format(Of Date, "yyyy")()

        '        Select Case csv_shurui
        '            Case 4
        '                datasuu = frmshuukeishouhin.gridkekka.Rows - 1
        '            Case 1  '店舗情報
        '                If chkchk = 1 Then
        '                    sql_sentaku = "SELECT tenpo.*, MAILNO_M.ADRESS1, shain.shainmei " &
        '          "FROM shain RIGHT JOIN (MAILNO_M RIGHT JOIN tenpo " &
        '          "ON MAILNO_M.MAILNO = tenpo.mailno) ON shain.shainid = tenpo.shainid " &
        '          "order by tenpo.tenpofurigana"
        '                Else
        '                    sql_sentaku = "SELECT tenpo.*, MAILNO_M.ADRESS1, shain.shainmei " &
        '          "FROM shain RIGHT JOIN (MAILNO_M RIGHT JOIN tenpo " &
        '          "ON MAILNO_M.MAILNO = tenpo.mailno) ON shain.shainid = tenpo.shainid " &
        '          " where tenpo.kadou ='0'" &
        '          "order by tenpo.tenpofurigana"
        '                End If
        '            Case 2  '商品情報
        '                If chkchk = 1 Then
        '                    sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" &
        '            " FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" &
        '            " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" &
        '            " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" &
        '            " order by shouhin.shouhinid"
        '                Else
        '                    sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" &
        '            " FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" &
        '            " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" &
        '            " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" &
        '            " where shouhin.mishiyou <> '1'" &
        '            " order by shouhin.shouhinid"
        '                End If
        '            Case 3   '商品情報
        '    'sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" & _
        '            ",shouhinkubun2.wella" & _
        '            " FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" & _
        '            " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" & _
        '            " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" & _
        '            " where shouhinkubun2.wella='0' or shouhinkubun2.wella='1'" & _
        '            " order by shouhin.shouhinid"
        '    sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" &
        '            ",shouhinkubun2.wella" &
        '            " FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" &
        '            " ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" &
        '            " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" &
        '            " where shouhin.haiban is null and (shouhinkubun2.wella='0' or shouhinkubun2.wella='1')" &
        '            " order by shouhin.shouhinid"
        '                'haiban = Null
        '        End Select
        '        If csv_shurui <> 4 Then
        '            If FcSQlGet(1, rs_sentaku, sql_sentaku, WMsg) = False Then
        '                ret = MsgBox("作成したいデータが存在しません。", 16, "総合管理システム「SPSALES」")
        '                Exit Sub
        '            Else
        '                datasuu = rs_sentaku.RecordCount
        '                Select Case csv_shurui
        '                    Case 1  '店舗情報
        '                        ReDim csv_data(18, datasuu)
        '                        csv_data(0, 0) = "店舗ID"
        '                        csv_data(1, 0) = "店舗名"
        '                        csv_data(2, 0) = "店舗フリガナ"
        '                        csv_data(3, 0) = "郵便番号"
        '                        csv_data(4, 0) = "住所１"
        '                        csv_data(5, 0) = "住所２"
        '                        csv_data(6, 0) = "電話番号"
        '                        csv_data(7, 0) = "FAX番号"
        '                        csv_data(8, 0) = "携帯番号"
        '                        csv_data(9, 0) = "代表者名"
        '                        csv_data(10, 0) = "担当者名"
        '                        csv_data(11, 0) = "従業員数"
        '                        csv_data(12, 0) = "〆情報"
        '                        csv_data(13, 0) = "Eメール"
        '                        csv_data(14, 0) = "備考"
        '                        csv_data(15, 0) = "稼動(=0)"
        '                        csv_data(16, 0) = "繰越金額"
        '                        csv_data(17, 0) = "担当社員"
        '                    Case 2  '商品情報
        '                        ReDim csv_data(12, datasuu)
        '                        csv_data(0, 0) = "商品ID"
        '                        csv_data(1, 0) = "商品名"
        '                        csv_data(2, 0) = "商品フリガナ"
        '                        csv_data(3, 0) = "区分１"
        '                        csv_data(4, 0) = "区分２"
        '                        csv_data(5, 0) = "バーコード"
        '                        csv_data(6, 0) = "価格"
        '                        csv_data(7, 0) = "原価"
        '                        csv_data(8, 0) = "現在庫"
        '                        csv_data(9, 0) = "未使用(=1)"
        '                        csv_data(10, 0) = "非課税(=1)"
        '                        csv_data(11, 0) = "業者区分"
        '                    Case 3  '商品情報
        '                        ReDim csv_data(13, datasuu)
        '                        csv_data(0, 0) = "商品ID"
        '                        csv_data(1, 0) = "商品名"
        '                        csv_data(2, 0) = "商品フリガナ"
        '                        csv_data(3, 0) = "区分１"
        '                        csv_data(4, 0) = "区分２"
        '                        csv_data(5, 0) = "バーコード"
        '                        csv_data(6, 0) = "価格"
        '                        csv_data(7, 0) = "原価"
        '                        csv_data(8, 0) = "現在庫"
        '                        csv_data(9, 0) = "未使用(=1)"
        '                        csv_data(10, 0) = "非課税(=1)"
        '                        csv_data(11, 0) = "種類(wella=0､ｾﾊﾞ=1)"
        '                        csv_data(12, 0) = "業者区分"
        '                End Select

        '                rs_sentaku.MoveFirst
        '                sususu = 1
        '                Do Until rs_sentaku.EOF
        '                    Select Case csv_shurui
        '                        Case 1  '店舗情報
        '                            csv_data(0, sususu) = rs_sentaku!tenpoid
        '                            csv_data(1, sususu) = Trim(rs_sentaku!tenpomei)
        '                            csv_data(2, sususu) = rs_sentaku!tenpofurigana
        '                            csv_data(3, sususu) = rs_sentaku!mailno
        '                            csv_data(4, sususu) = Trim(rs_sentaku!adress1)
        '                            csv_data(5, sususu) = Trim(rs_sentaku!tenpoadress)
        '                            csv_data(6, sususu) = rs_sentaku!tel
        '                            csv_data(7, sususu) = rs_sentaku!fax
        '                            csv_data(8, sususu) = rs_sentaku!keitai
        '                            csv_data(9, sususu) = rs_sentaku!daihyou
        '                            csv_data(10, sususu) = Trim(rs_sentaku!tantou)
        '                            csv_data(11, sususu) = rs_sentaku!juugyouinsuu
        '                            Select Case CInt(rs_sentaku!shimebi)
        '                                Case 0
        '                                    csv_data(12, sususu) = "５日"
        '                                Case 1
        '                                    csv_data(12, sususu) = "１０日"
        '                                Case 2
        '                                    csv_data(12, sususu) = "１５日"
        '                                Case 3
        '                                    csv_data(12, sususu) = "２０日"
        '                                Case 4
        '                                    csv_data(12, sususu) = "２５日"
        '                                Case 5
        '                                    csv_data(12, sususu) = "月末"
        '                                Case 6
        '                                    csv_data(12, sususu) = "随時"
        '                            End Select
        '                            csv_data(13, sususu) = rs_sentaku!email
        '                            csv_data(14, sususu) = rs_sentaku!bikou
        '                            csv_data(15, sususu) = rs_sentaku!kadou
        '                            If IsNull(rs_sentaku!kurikoshi) Then
        '                                csv_data(16, sususu) = 0
        '                            Else
        '                                csv_data(16, sususu) = rs_sentaku!kurikoshi
        '                            End If
        '                            csv_data(17, sususu) = rs_sentaku!shainmei
        '                        Case 2  '商品情報
        '                            csv_data(0, sususu) = rs_sentaku!shouhinid
        '                            csv_data(1, sususu) = rs_sentaku!shouhinmei
        '                            csv_data(2, sususu) = rs_sentaku!shouhinfurigana
        '                            csv_data(3, sususu) = rs_sentaku!shouhinkubunmei
        '                            csv_data(4, sususu) = rs_sentaku!shouhinkubunmei2
        '                            csv_data(5, sususu) = rs_sentaku!Barcode
        '                            csv_data(6, sususu) = rs_sentaku!kakaku
        '                            csv_data(7, sususu) = rs_sentaku!genka
        '                            csv_data(8, sususu) = rs_sentaku!genzaikosuu
        '                            csv_data(9, sususu) = rs_sentaku!mishiyou
        '                            csv_data(10, sususu) = rs_sentaku!hikazei
        '                            csv_data(11, sususu) = rs_sentaku!shouhinkubunid0
        '                        Case 3  '商品情報
        '                            csv_data(0, sususu) = rs_sentaku!shouhinid
        '                            csv_data(1, sususu) = rs_sentaku!shouhinmei
        '                            csv_data(2, sususu) = rs_sentaku!shouhinfurigana
        '                            csv_data(3, sususu) = rs_sentaku!shouhinkubunmei
        '                            csv_data(4, sususu) = rs_sentaku!shouhinkubunmei2
        '                            csv_data(5, sususu) = rs_sentaku!Barcode
        '                            csv_data(6, sususu) = rs_sentaku!kakaku
        '                            csv_data(7, sususu) = rs_sentaku!genka
        '                            csv_data(8, sususu) = rs_sentaku!genzaikosuu
        '                            csv_data(9, sususu) = rs_sentaku!mishiyou
        '                            csv_data(10, sususu) = rs_sentaku!hikazei
        '                            csv_data(11, sususu) = rs_sentaku!wella
        '                            csv_data(12, sususu) = rs_sentaku!shouhinkubunid0
        '                    End Select

        '                    sususu = sususu + 1
        '                    rs_sentaku.MoveNext
        '                Loop
        '                rs_sentaku.Close

        '            End If
        '        Else
        '            ReDim csv_data(5, datasuu)
        '            csv_data(0, 0) = "NO"
        '            csv_data(1, 0) = "店舗名"
        '            csv_data(2, 0) = "商品名"
        '            csv_data(3, 0) = "数量"
        '            csv_data(4, 0) = "金額"
        '            sususu = 1
        '            For ngyousuu = 1 To datasuu
        '                frmshuukeishouhin.gridkekka.Row = ngyousuu
        '                frmshuukeishouhin.gridkekka.Col = 0
        '                csv_data(0, ngyousuu) = Trim(frmshuukeishouhin.gridkekka.Text)
        '                frmshuukeishouhin.gridkekka.Col = 1
        '                csv_data(1, ngyousuu) = Trim(frmshuukeishouhin.gridkekka.Text)
        '                frmshuukeishouhin.gridkekka.Col = 2
        '                csv_data(2, ngyousuu) = Trim(frmshuukeishouhin.gridkekka.Text)
        '                frmshuukeishouhin.gridkekka.Col = 3
        '                csv_data(3, ngyousuu) = Trim(frmshuukeishouhin.gridkekka.Text)
        '                frmshuukeishouhin.gridkekka.Col = 4
        '                csv_data(4, ngyousuu) = Trim(frmshuukeishouhin.gridkekka.Text)
        '            Next
        '        End If

        '        Open shutsu_path For Output Access Write As 1
        'For writecounter = 0 To datasuu
        '            Select Case csv_shurui
        '                Case 1  '店舗情報
        '                    Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter), csv_data(5, writecounter), csv_data(6, writecounter), csv_data(7, writecounter), csv_data(8, writecounter), csv_data(9, writecounter), csv_data(10, writecounter), csv_data(11, writecounter), csv_data(12, writecounter), csv_data(13, writecounter), csv_data(14, writecounter), csv_data(15, writecounter), csv_data(16, writecounter), csv_data(17, writecounter)
        '    Case 2  '商品情報
        '                    Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter), csv_data(5, writecounter), csv_data(6, writecounter), csv_data(7, writecounter), csv_data(8, writecounter), csv_data(9, writecounter), csv_data(10, writecounter), csv_data(11, writecounter)
        '    Case 3  '商品情報
        '                    Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter), csv_data(5, writecounter), csv_data(6, writecounter), csv_data(7, writecounter), csv_data(8, writecounter), csv_data(9, writecounter), csv_data(10, writecounter), csv_data(11, writecounter), csv_data(12, writecounter)
        '    Case 4
        '                    Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter)
        '    End Select
        '        Next

        '        Close #1

        'ret = MsgBox("指定データのエクスポートが完了しました。", 64, "総合管理システム「SPSALES」")



    End Function

    Private Function create_csv_file(csv_data(,) As String, hozon_path As String, data_count As Integer) As Boolean
        'convert_nothing_to_karamoji(csv_data)

        Try
            Using sw As New StreamWriter(hozon_path, False, Encoding.GetEncoding("Shift_JIS"))
                Dim header As String = get_header(csv_data)
                sw.WriteLine(header)

                For i = 1 To data_count
                    Dim line As String = get_line_hairetsu(csv_data, i)
                    sw.WriteLine(line)
                Next
            End Using

            Return True ' 成功
        Catch ex As Exception
            msg_go("CSVファイル作成中にエラーが発生しました: " & ex.Message)
            Return False ' 失敗
        End Try
    End Function

    Private Sub convert_nothing_to_karamoji(ByRef data(,) As String)

        Dim data_count As Integer = data.GetLength(1) - 1
        Dim retsu_count As Integer = data.GetLength(0)
        For i = 1 To data_count
            For j = 1 To retsu_count - 1
                If data(j, i) Is Nothing Then
                    data(j, i) = ""
                End If
            Next
        Next

    End Sub

    Private Function get_header(data(,) As String) As String

        Dim retsu_count As Integer = data.GetLength(0)
        Dim columnsToExport As String() = New String(retsu_count - 1) {}

        For i As Integer = 0 To retsu_count - 1
            columnsToExport(i) = $"""{data(i, 0)}"""
        Next

        Dim header As String = String.Join(",", columnsToExport)

        Return header

    End Function

    Private Function get_line_hairetsu(data(,) As String, colIndex As Integer) As String

        Dim columnValues As New List(Of String)
        For rowIndex As Integer = 0 To data.GetUpperBound(0)
            columnValues.Add($"""{data(rowIndex, colIndex)}""")
        Next
        Return String.Join(",", columnValues)

    End Function

End Class