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
                response = output_csv_shouhin(hozon_path)
            Case "店舗情報出力"
                response = output_csv_tenpo(hozon_path)
            Case "繰越残情報出力"
                Dim shitei_nen = "2023"
                Dim shitei_tsuki = "04"
                response = output_csv_kurikoshi(hozon_path:=hozon_path, shitei_nen:=shitei_nen, shitei_tsuki:=shitei_tsuki)
                hide_shinkou_joukyou()
            Case "Wella売上通知データ出力"
                msg_go("開発中")
                Exit Sub
            Case "ウエラ商品情報出力"
                response = output_csv_wella_shouhin(hozon_path)
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

    Function output_csv_shouhin(hozon_path As String) As Boolean

        Dim csv_data(11, 0) As String
        Dim data_count = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query_where = ""
            If chk_plus_alpha.Checked = False Then
                query_where = " WHERE shouhin.mishiyou <> '1'"
            End If

            Dim query = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" +
                " FROM shouhinkubun2" +
                " RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" +
                " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" +
                query_where +
                " ORDER BY shouhin.shouhinid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータが存在しません。")
                Return False
            End If

            ReDim csv_data(11, data_count)
            csv_data(0, 0) = "商品ID"
            csv_data(1, 0) = "商品名"
            csv_data(2, 0) = "商品フリガナ"
            csv_data(3, 0) = "区分１"
            csv_data(4, 0) = "区分２"
            csv_data(5, 0) = "バーコード"
            csv_data(6, 0) = "価格"
            csv_data(7, 0) = "原価"
            csv_data(8, 0) = "現在庫"
            csv_data(9, 0) = "未使用(=1)"
            csv_data(10, 0) = "非課税(=1)"
            csv_data(11, 0) = "業者区分"

            For i = 0 To data_count - 1

                csv_data(0, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                csv_data(1, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                csv_data(2, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinfurigana"))
                csv_data(3, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunmei2")) Then
                    csv_data(4, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("barcode")) Then
                    csv_data(5, i + 1) = Trim(dt_server.Rows.Item(i).Item("barcode"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("kakaku")) Then
                    csv_data(6, i + 1) = Trim(dt_server.Rows.Item(i).Item("kakaku"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("genka")) Then
                    csv_data(7, i + 1) = Trim(dt_server.Rows.Item(i).Item("genka"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    csv_data(8, i + 1) = Trim(dt_server.Rows.Item(i).Item("genzaikosuu"))
                End If

                csv_data(9, i + 1) = Trim(dt_server.Rows.Item(i).Item("mishiyou"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("hikazei")) Then
                    csv_data(10, i + 1) = Trim(dt_server.Rows.Item(i).Item("hikazei"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunid0")) Then
                    csv_data(11, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0"))
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

    End Function

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

            For i = 0 To data_count - 1

                csv_data(0, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                csv_data(1, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                csv_data(2, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpofurigana"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("mailno")) Then
                    csv_data(3, i + 1) = Trim(dt_server.Rows.Item(i).Item("mailno"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("adress1")) Then
                    csv_data(4, i + 1) = Trim(dt_server.Rows.Item(i).Item("adress1"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("tenpoadress")) Then
                    csv_data(5, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpoadress"))
                End If

                csv_data(6, i + 1) = Trim(dt_server.Rows.Item(i).Item("tel"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("fax")) Then
                    csv_data(7, i + 1) = Trim(dt_server.Rows.Item(i).Item("fax"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("keitai")) Then
                    csv_data(8, i + 1) = Trim(dt_server.Rows.Item(i).Item("keitai"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("daihyou")) Then
                    csv_data(9, i + 1) = Trim(dt_server.Rows.Item(i).Item("daihyou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("tantou")) Then
                    csv_data(10, i + 1) = Trim(dt_server.Rows.Item(i).Item("tantou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("juugyouinsuu")) Then
                    csv_data(11, i + 1) = Trim(dt_server.Rows.Item(i).Item("juugyouinsuu"))
                End If

                csv_data(12, i + 1) = Deadline.GetNameById(Trim(dt_server.Rows.Item(i).Item("shimebi")))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("email")) Then
                    csv_data(13, i + 1) = Trim(dt_server.Rows.Item(i).Item("email"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                    csv_data(14, i + 1) = Trim(dt_server.Rows.Item(i).Item("bikou"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("kadou")) Then
                    csv_data(15, i + 1) = Trim(dt_server.Rows.Item(i).Item("kadou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("kurikoshi")) Then
                    csv_data(16, i + 1) = 0
                Else
                    csv_data(16, i + 1) = Trim(dt_server.Rows.Item(i).Item("kurikoshi"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    csv_data(17, i + 1) = Trim(dt_server.Rows.Item(i).Item("shainmei"))
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

    End Function

    Function output_csv_kurikoshi(hozon_path As String, shitei_nen As String, shitei_tsuki As String) As Boolean

        Dim hhh = shitei_nen + shitei_tsuki + "01"
        Dim ooo = shitei_nen + shitei_tsuki + "31"

        Dim csv_data(6, 0) As String
        Dim data_count = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM tenpo ORDER BY tenpoid" ' 本チャン
            'Dim query = "SELECT TOP (30) * FROM tenpo ORDER BY tenpoid" ' TODO : テスト

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータが存在しません。")
                Return False
            End If

            ReDim csv_data(6, data_count)
            csv_data(0, 0) = "店舗ID"
            csv_data(1, 0) = "店舗名"
            csv_data(2, 0) = "請求金額"
            csv_data(3, 0) = "入金金額"
            csv_data(4, 0) = "未請求額"
            csv_data(5, 0) = "繰越総額"
            csv_data(6, 0) = "〆日"

            For i = 0 To data_count - 1

                csv_data(0, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                csv_data(1, i + 1) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shimebi")) Then
                    csv_data(6, i + 1) = Deadline.GetCsvNameById(Trim(dt_server.Rows.Item(i).Item("shimebi")))
                End If

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        Dim debug_counter = 0
        show_shinkou_joukyou(data_count)

        Dim seikyuu_2 As Integer

        For i = 1 To data_count

            seikyuu_2 = 0

            ' 請求額を算出

            Dim motobi = shitei_nen + shitei_tsuki + "01"
            Dim sakibi = shitei_nen + shitei_tsuki + "31"
            Dim nyuukinyokujitsu = ""
            Dim motobi2 = ""
            Dim kitensiid = ""

            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT seikyuusho.hiduke, seikyuusho.tenpoid, seikyuusho.seikyuukingaku, seikyuusho.seikyuushoid" +
                    " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
                    " WHERE seikyuusho.seikyuu_st = '0'" +
                    " AND seikyuusho.hiduke BETWEEN '" + motobi + "' AND '" + sakibi + "'" +
                    " AND seikyuusho.tenpoid = '" + csv_data(0, i) + "'" +
                    " ORDER BY seikyuusho.hiduke DESC, seikyuusho.seikyuushoid DESC"

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_tenpo_1")
                Dim dt_server As DataTable = ds_server.Tables("t_tenpo_1")

                Dim aaa As Integer
                Dim bbb = ""

                If dt_server.Rows.Count = 0 Then

                    If csv_data(6, i) = "00" Then

                        Try

                            Dim cn_server_2 As New SqlConnection
                            cn_server_2.ConnectionString = connectionstring_sqlserver

                            Dim query_where = ""
                            If chk_plus_alpha.Checked = False Then
                                query_where = " WHERE shouhin.mishiyou <> '1'"
                            End If

                            Dim query_2 = "SELECT seikyuusho.hiduke, seikyuusho.tenpoid, seikyuusho.seikyuukingaku, seikyuusho.seikyuushoid" +
                                " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid " +
                                " WHERE seikyuusho.seikyuu_st = '0' " +
                                " AND seikyuusho.tenpoid = '" + csv_data(0, i) + "'" +
                                " ORDER BY seikyuusho.hiduke DESC, seikyuusho.seikyuushoid DESC"

                            Dim da_server_2 As SqlDataAdapter = New SqlDataAdapter(query_2, cn_server_2)
                            Dim ds_server_2 As New DataSet
                            da_server_2.Fill(ds_server_2, "t_tenpo_2")
                            Dim dt_server_2 As DataTable = ds_server_2.Tables("t_tenpo_2")

                            If dt_server_2.Rows.Count = 0 Then
                                csv_data(2, i) = "0"
                                kitensiid = ""
                                motobi = shitei_nen + shitei_tsuki & "01"
                                motobi2 = shitei_nen + shitei_tsuki & "01"
                                nyuukinyokujitsu = motobi
                            Else
                                csv_data(2, i) = dt_server_2.Rows.Item(0).Item("seikyuukingaku")
                                kitensiid = dt_server_2.Rows.Item(0).Item("seikyuushoid")
                                motobi = CStr(dt_server_2.Rows.Item(0).Item("hiduke"))
                                motobi2 = CStr(dt_server_2.Rows.Item(0).Item("hiduke"))
                                bbb = Mid(motobi, 1, 6)
                                If Strings.Right(motobi, 2) = "31" Then
                                    aaa = 31
                                Else
                                    aaa = CInt(Strings.Right(motobi, 2)) + 1
                                End If
                                nyuukinyokujitsu = bbb & Format(aaa, "00")
                            End If

                            dt_server_2.Clear()
                            ds_server_2.Clear()

                        Catch ex As Exception
                            msg_go(ex.Message)
                            Return False
                        End Try

                    Else

                        csv_data(2, i) = "0"
                        kitensiid = ""
                        motobi = shitei_nen + shitei_tsuki & "01"
                        motobi2 = shitei_nen + shitei_tsuki & "01"
                        nyuukinyokujitsu = motobi

                    End If

                Else

                    If dt_server.Rows.Count = 1 Then

                        csv_data(2, i) = Trim(dt_server.Rows.Item(0).Item("seikyuukingaku"))
                        kitensiid = Trim(dt_server.Rows.Item(0).Item("seikyuushoid"))
                        motobi = CStr(Trim(dt_server.Rows.Item(0).Item("hiduke")))
                        motobi2 = CStr(Trim(dt_server.Rows.Item(0).Item("hiduke")))
                        If Strings.Right(motobi, 2) = "31" Then
                            aaa = 31
                        Else
                            aaa = CInt(Strings.Right(motobi, 2)) + 1
                        End If
                        nyuukinyokujitsu = Mid(motobi, 1, 6) & Format(aaa, "00")

                    Else

                        For j = 0 To dt_server.Rows.Count - 1
                            csv_data(2, i) += dt_server.Rows.Item(j).Item("seikyuukingaku")
                            If j = 0 Then
                                motobi2 = CStr(Trim(dt_server.Rows.Item(j).Item("hiduke")))
                            End If
                        Next
                        kitensiid = ""
                        motobi = shitei_nen + shitei_tsuki + "01"
                        If Strings.Right(motobi2, 2) = "31" Then
                            aaa = 31
                        Else
                            aaa = CInt(Strings.Right(motobi2, 2)) + 1
                        End If
                        nyuukinyokujitsu = Mid(motobi2, 1, 6) & Format(aaa, "00")
                        seikyuu_2 = 1

                    End If

                End If

                csv_data(2, i) = CInt(csv_data(2, i)).ToString

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Return False
            End Try


            ' 入金額を算出
            Try

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = ""
                If seikyuu_2 = 1 Then
                    query = "SELECT SUM(seikyuusho.seikyuukingaku) AS gonyu" +
                    " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
                    " WHERE seikyuusho.seikyuu_st = '1' AND seikyuusho.hiduke BETWEEN '" + motobi + "' AND '" + sakibi + "'" +
                    " AND seikyuusho.tenpoid = '" + csv_data(0, i) + "'"
                Else
                    query = "SELECT SUM(seikyuusho.seikyuukingaku) AS gonyu" +
                    " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid" +
                    " WHERE seikyuusho.seikyuu_st = '1' AND seikyuusho.hiduke BETWEEN '" + nyuukinyokujitsu + "' AND '" + sakibi + "'" +
                    " AND seikyuusho.tenpoid = '" + csv_data(0, i) + "'"
                End If

                Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds_server As New DataSet
                da_server.Fill(ds_server, "t_tenpo_3")
                Dim dt_server As DataTable = ds_server.Tables("t_tenpo_3")

                If dt_server.Rows.Count = 0 Then
                    csv_data(3, i) = "0"
                Else
                    If IsDBNull(dt_server.Rows.Item(0).Item("gonyu")) Then
                        csv_data(3, i) = "0"
                    Else
                        csv_data(3, i) = Trim(dt_server.Rows.Item(0).Item("gonyu"))
                    End If

                End If

                csv_data(3, i) = CInt(csv_data(3, i)).ToString

                dt_server.Clear()
                ds_server.Clear()

            Catch ex As Exception
                msg_go(ex.Message)
                Return False
            End Try

            motobi = shitei_nen & shitei_tsuki & csv_data(6, i)
            If csv_data(6, i) = "31" Then
                If motobi2 < motobi Then
                    motobi = motobi2
                End If
            End If

            ' 未請求額を算出
            If seikyuu_2 = 1 Then
                csv_data(4, i) = "0"
            Else

                Try

                    Dim cn_server As New SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = ""
                    If kitensiid = "" Then
                        query = "SELECT SUM(hacchuu.goukei) AS gomisei FROM hacchuu" +
                            " WHERE hacchuu.iraibi BETWEEN '" + motobi + "' AND '" + sakibi + "'" +
                            " AND hacchuu.tenpoid = '" + csv_data(0, i) + "'"
                    Else
                        If csv_data(6, i) = "00" Then
                            query = "SELECT SUM(hacchuu.goukei) AS gomisei FROM hacchuu" +
                                " WHERE hacchuu.iraibi BETWEEN '" + nyuukinyokujitsu + "' AND '" + sakibi + "'" +
                                " AND (hacchuu.seikyuushoid <> '" + kitensiid + "' OR hacchuu.seikyuushoid IS NULL)" +
                                " AND hacchuu.tenpoid = '" + csv_data(0, i) + "'"
                        Else
                            query = "SELECT SUM(hacchuu.goukei) AS gomisei FROM hacchuu" +
                                " WHERE hacchuu.iraibi BETWEEN '" + motobi + "' AND '" + sakibi + "'" +
                                " AND (hacchuu.seikyuushoid <> '" + kitensiid + "' OR hacchuu.seikyuushoid IS NULL)" +
                                " AND hacchuu.tenpoid = '" + csv_data(0, i) + "'"
                        End If
                    End If

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    da_server.Fill(ds_server, "t_hacchuu_1")
                    Dim dt_server As DataTable = ds_server.Tables("t_hacchuu_1")

                    If dt_server.Rows.Count = 0 Then
                        csv_data(4, i) = "0"
                    Else
                        If IsDBNull(dt_server.Rows.Item(0).Item("gomisei")) Then
                            csv_data(4, i) = "0"
                        Else
                            csv_data(4, i) = Trim(dt_server.Rows.Item(0).Item("gomisei"))
                        End If

                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    Return False
                End Try

            End If

            ' 閉め日からそれ以前で、請求書番号が違うチェック
            If seikyuu_2 = 1 Then
                csv_data(5, i) = "複数の請求書があります。"
            Else

                Try

                    Dim cn_server As New SqlConnection
                    cn_server.ConnectionString = connectionstring_sqlserver

                    Dim query = ""
                    If kitensiid = "" Then
                        query = "SELECT * FROM hacchuu" +
                            " WHERE hacchuu.iraibi BETWEEN '" + hhh + "' AND '" + motobi + "'" +
                            " AND hacchuu.tenpoid = '" + csv_data(0, i) + "'"
                    Else
                        query = "SELECT * FROM hacchuu" +
                            " WHERE hacchuu.iraibi BETWEEN '" + hhh + "' AND '" + motobi + "'" +
                            " AND (hacchuu.seikyuushoid <> '" + kitensiid + "' OR hacchuu.seikyuushoid IS NULL)" +
                            " AND hacchuu.tenpoid = '" + csv_data(0, i) + "'"
                    End If

                    Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                    Dim ds_server As New DataSet
                    da_server.Fill(ds_server, "t_hacchuu_2")
                    Dim dt_server As DataTable = ds_server.Tables("t_hacchuu_2")

                    If dt_server.Rows.Count = 0 Then
                        csv_data(5, i) = CStr(CInt(csv_data(2, i)) - CInt(csv_data(3, i)) + CInt(csv_data(4, i)))
                    Else
                        csv_data(5, i) = "期間内に請求書ＩＤが違う納品書が存在します。"
                    End If

                    dt_server.Clear()
                    ds_server.Clear()

                Catch ex As Exception
                    msg_go(ex.Message)
                    Return False
                End Try

            End If

            debug_counter += 1
            calculate_shinkou_joukyou(debug_counter, data_count)

        Next

        ' 全て0のものとcsv_data(6, i)を排除
        Dim new_data_count As Integer = 0
        For i = LBound(csv_data, 2) To UBound(csv_data, 2)
            If Not (csv_data(2, i) = "0" And csv_data(3, i) = "0" And csv_data(4, i) = "0" And csv_data(5, i) = "0") Then
                new_data_count = new_data_count + 1
            End If
        Next i

        Dim new_csv_data(5, new_data_count - 1) As String
        new_data_count = 0
        For i = LBound(csv_data, 2) To UBound(csv_data, 2)
            If Not (csv_data(2, i) = "0" And csv_data(3, i) = "0" And csv_data(4, i) = "0" And csv_data(5, i) = "0") Then
                For j = 0 To 5
                    new_csv_data(j, new_data_count) = csv_data(j, i)
                Next j
                new_data_count = new_data_count + 1
            End If
        Next i

        If create_csv_file(new_csv_data, hozon_path, new_data_count - 1) Then
            Return True
        Else
            Return False
        End If

        ' ----------------------------------------------------------

        'Open shutsu_path For Output Access Write As 1
        'For writecounter = 0 To datasuu
        '    If csv_data(2, writecounter) = "0" And csv_data(3, writecounter) = "0" And csv_data(4, writecounter) = "0" And csv_data(5, writecounter) = "0" Then
        '    Else
        '        Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter), csv_data(5, writecounter)
        '    End If
        'Next

        ' ----------------------------------------------------------

        'Dim sql_sentaku As String, rs_sentaku As New ADODB.Recordset, csv_data()
        'Dim datasuu As Long, writecounter As Long, rs_tsutsu As ADODB.Recordset, sql_tsutsu As String
        'Dim kotoshi As String, rs_sentaku2 As New ADODB.Recordset
        'Dim kitensiid As String, motobi2 As String, nyuukinyokujitsu As String, aaa As Integer
        'Dim seikyuu_2 As Integer, seikyuu_2_hajimete As Integer, bbb As String
        'Dim rs_tsutsu_7 As ADODB.Recordset, sql_tsutsu_7 As String

        ''kotoshi = Format(Date, "yyyy")
        'kotoshi = shitenen

        ''hhh = kotoshi & "0101"
        ''ooo = kotoshi & "0131"
        'hhh = kotoshi & shitetsuki & "01"
        'ooo = kotoshi & shitetsuki & "31"
        'sql_sentaku = "SELECT * FROM tenpo order by tenpoid"

        ''sql_sentaku = "SELECT * FROM tenpo  where tenpoid ='001592' or tenpoid ='001593'order by tenpoid"

        'If FcSQlGet(1, rs_sentaku2, sql_sentaku, WMsg) = False Then
        '    'ret = MsgBox("作成したいデータが存在しません。", 16, "総合管理システム「SPSALES」")
        '    'Exit Sub
        'Else
        '    'datasuu = rs_sentaku2.RecordCount
        '    'ReDim csv_data(6, datasuu)
        '    'csv_data(0, 0) = "店舗ID"
        '    'csv_data(1, 0) = "店舗名"
        '    'csv_data(2, 0) = "請求金額"
        '    'csv_data(3, 0) = "入金金額"
        '    'csv_data(4, 0) = "未請求額"
        '    'csv_data(5, 0) = "繰越総額"
        '    'csv_data(6, 0) = "〆日"
        '    rs_sentaku2.MoveFirst
        '    i = 1
        '    Do Until rs_sentaku2.EOF
        '        csv_data(0, i) = rs_sentaku2!tenpoid
        '        csv_data(1, i) = Trim(rs_sentaku2!tenpomei)
        '        Select Case rs_sentaku2!shimebi
        '            Case "0"
        '                csv_data(6, i) = "05"
        '            Case "1"
        '                csv_data(6, i) = "10"
        '            Case "2"
        '                csv_data(6, i) = "15"
        '            Case "3"
        '                csv_data(6, i) = "20"
        '            Case "4"
        '                csv_data(6, i) = "25"
        '            Case "5"
        '                csv_data(6, i) = "31"
        '            Case "6"
        '                csv_data(6, i) = "00"
        '        End Select
        '        i = i + 1
        '        rs_sentaku2.MoveNext
        '    Loop
        '    rs_sentaku2.Close
        'End If

        'data_base_open

        'frmcsv.pb1.Max = datasuu
        'frmcsv.pb1.Value = 0
        'DoEvents

        'For i = 1 To datasuu

        'seikyuu_2 = 0
        '*******請求額を算出****************************************************
        'motobi = kotoshi & "0101"
        'sakibi = kotoshi & "0131"           
        'Set rs_tsutsu = New ADODB.Recordset
        'sql_tsutsu = "SELECT seikyuusho.hiduke, seikyuusho.tenpoid," &
        '            "seikyuusho.seikyuukingaku, seikyuusho.seikyuushoid" &
        '            " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid " &
        '            " WHERE seikyuusho.seikyuu_st='0' AND" &
        '            " seikyuusho.hiduke Between '" & motobi & "' And '" & sakibi & "'" &
        '            " AND seikyuusho.tenpoid='" & csv_data(0, i) & "'" &
        '            " ORDER BY seikyuusho.hiduke DESC,seikyuusho.seikyuushoid DESC"



        'If FcSQlGet(0, rs_tsutsu, sql_tsutsu, WMsg) = False Then

        '    If csv_data(6, i) = "00" Then
        '    Set rs_tsutsu_7 = New ADODB.Recordset
        '    sql_tsutsu_7 = "SELECT seikyuusho.hiduke, seikyuusho.tenpoid," &
        '                "seikyuusho.seikyuukingaku, seikyuusho.seikyuushoid" &
        '                " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid " &
        '                " WHERE seikyuusho.seikyuu_st='0' " &
        '                " AND seikyuusho.tenpoid='" & csv_data(0, i) & "'" &
        '                " ORDER BY seikyuusho.hiduke DESC,seikyuusho.seikyuushoid DESC"
        '        If FcSQlGet(0, rs_tsutsu_7, sql_tsutsu_7, WMsg) = False Then
        '            csv_data(2, i) = "0"
        '            'motobi = kotoshi & "0101"
        '            'motobi2 = kotoshi & "0101"
        '            motobi = kotoshi & shitetsuki & "01"
        '            motobi2 = kotoshi & shitetsuki & "01"
        '            kitensiid = ""
        '            nyuukinyokujitsu = motobi
        '        Else
        '            csv_data(2, i) = rs_tsutsu_7!seikyuukingaku
        '            kitensiid = rs_tsutsu_7!seikyuushoid
        '            motobi = CStr(rs_tsutsu_7!hiduke)
        '            motobi2 = CStr(rs_tsutsu_7!hiduke)
        '            bbb = Mid(motobi, 1, 6)
        '            If Right(motobi, 2) = "31" Then
        '                aaa = 31
        '            Else
        '                aaa = CInt(Right(motobi, 2)) + 1
        '            End If
        '            nyuukinyokujitsu = bbb & Format(aaa, "00")
        '            rs_tsutsu_7.Close
        '            rs_tsutsu.Close
        '        End If
        '    Else
        '        csv_data(2, i) = "0"
        '        'motobi = kotoshi & "0101"
        '        'motobi2 = kotoshi & "0101"
        '        motobi = kotoshi & shitetsuki & "01"
        '        motobi2 = kotoshi & shitetsuki & "01"
        '        kitensiid = ""
        '        nyuukinyokujitsu = motobi
        '    End If

        'Else

        '    If rs_tsutsu.RecordCount = 1 Then
        '        csv_data(2, i) = rs_tsutsu!seikyuukingaku
        '        kitensiid = rs_tsutsu!seikyuushoid
        '        motobi = CStr(rs_tsutsu!hiduke)
        '        motobi2 = CStr(rs_tsutsu!hiduke)
        '        If Right(motobi, 2) = "31" Then
        '            aaa = 31
        '        Else
        '            aaa = CInt(Right(motobi, 2)) + 1
        '        End If
        '        nyuukinyokujitsu = Mid(motobi, 1, 6) & Format(aaa, "00")
        '    Else
        '        rs_tsutsu.MoveFirst
        '        seikyuu_2_hajimete = 0
        '        Do Until rs_tsutsu.EOF
        '            csv_data(2, i) = csv_data(2, i) + rs_tsutsu!seikyuukingaku
        '            If seikyuu_2_hajimete = 0 Then
        '                motobi2 = CStr(rs_tsutsu!hiduke)
        '            End If
        '            rs_tsutsu.MoveNext
        '            seikyuu_2_hajimete = seikyuu_2_hajimete + 1
        '        Loop
        '        motobi = kotoshi & shitetsuki & "01"
        '        kitensiid = ""
        '        If Right(motobi2, 2) = "31" Then
        '            aaa = 31
        '        Else
        '            aaa = CInt(Right(motobi2, 2)) + 1
        '        End If
        '        nyuukinyokujitsu = Mid(motobi2, 1, 6) & Format(aaa, "00")
        '        seikyuu_2 = 1
        '    End If
        '    rs_tsutsu.Close

        'End If

        ''*******入金額を算出****************************************************

        ''Set rs_tsutsu = New ADODB.Recordset
        'If seikyuu_2 = 1 Then
        '    sql_tsutsu = "SELECT sum(seikyuusho.seikyuukingaku) as gonyu" &
        '                " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid " &
        '                " WHERE seikyuusho.seikyuu_st='1'" &
        '                " AND seikyuusho.hiduke Between '" & motobi & "' And '" & sakibi & "'" &
        '                " AND seikyuusho.tenpoid='" & csv_data(0, i) & "'"
        'Else
        '    sql_tsutsu = "SELECT sum(seikyuusho.seikyuukingaku) as gonyu" &
        '                " FROM tenpo RIGHT JOIN seikyuusho ON tenpo.tenpoid = seikyuusho.tenpoid " &
        '                " WHERE seikyuusho.seikyuu_st='1'" &
        '                " AND seikyuusho.hiduke Between '" & nyuukinyokujitsu & "' And '" & sakibi & "'" &
        '                " AND seikyuusho.tenpoid='" & csv_data(0, i) & "'"
        'End If
        'If FcSQlGet(0, rs_tsutsu, sql_tsutsu, WMsg) = False Then
        '    csv_data(3, i) = "0"
        'Else
        '    If IsNull(rs_tsutsu!gonyu) Then
        '        csv_data(3, i) = "0"
        '    Else
        '        csv_data(3, i) = rs_tsutsu!gonyu
        '    End If
        '    rs_tsutsu.Close
        'End If
        ''motobi = kotoshi & "01" & csv_data(6, i)
        'motobi = kotoshi & shitetsuki & csv_data(6, i)
        'If csv_data(6, i) = "31" Then
        '    If motobi2 < motobi Then
        '        motobi = motobi2
        '    End If
        'End If

        ''*******未請求額を算出****************************************************

        '        Set rs_tsutsu = New ADODB.Recordset
        '        If seikyuu_2 = 1 Then
        '    csv_data(4, i) = "0"
        'Else
        '    If kitensiid = "" Then
        '        sql_tsutsu = "SELECT sum(hacchuu.goukei) as gomisei" &
        '                    " FROM hacchuu" &
        '                    " WHERE hacchuu.iraibi Between '" & motobi & "' And '" & sakibi & "'" &
        '                    " AND hacchuu.tenpoid=" & csv_data(0, i) & ""
        '    Else
        '        If csv_data(6, i) = "00" Then
        '            sql_tsutsu = "SELECT sum(hacchuu.goukei) as gomisei" &
        '                        " FROM hacchuu" &
        '                        " WHERE hacchuu.iraibi Between '" & nyuukinyokujitsu & "' And '" & sakibi & "'" &
        '                        " AND (hacchuu.seikyuushoid<>'" & kitensiid & "'  or hacchuu.seikyuushoid is null)" &
        '                        " AND hacchuu.tenpoid='" & csv_data(0, i) & "'"
        '        Else
        '            sql_tsutsu = "SELECT sum(hacchuu.goukei) as gomisei" &
        '                        " FROM hacchuu" &
        '                        " WHERE hacchuu.iraibi Between '" & motobi & "' And '" & sakibi & "'" &
        '                        " AND (hacchuu.seikyuushoid<>'" & kitensiid & "'  or hacchuu.seikyuushoid is null)" &
        '                        " AND hacchuu.tenpoid='" & csv_data(0, i) & "'"
        '        End If
        '    End If

        '    If FcSQlGet(0, rs_tsutsu, sql_tsutsu, WMsg) = False Then
        '        csv_data(4, i) = "0"
        '    Else
        '        If IsNull(rs_tsutsu!gomisei) Then
        '            csv_data(4, i) = "0"
        '        Else
        '            csv_data(4, i) = rs_tsutsu!gomisei
        '        End If
        '        rs_tsutsu.Close
        '    End If
        'End If


        ''閉め日からそれ以前で、請求書番号が違うチェック
        'If seikyuu_2 = 1 Then
        '    csv_data(5, i) = "複数の請求書があります。"
        'Else
        '            Set rs_tsutsu = New ADODB.Recordset
        '            If kitensiid = "" Then
        '        sql_tsutsu = "SELECT *" &
        '                    " FROM hacchuu" &
        '                    " WHERE hacchuu.iraibi Between '" & hhh & "' And '" & motobi & "'" &
        '                    " AND hacchuu.tenpoid=" & csv_data(0, i) & ""
        '    Else
        '        sql_tsutsu = "SELECT *" &
        '                    " FROM hacchuu" &
        '                    " WHERE hacchuu.iraibi Between '" & hhh & "' And '" & motobi & "'" &
        '                    " AND (hacchuu.seikyuushoid<>'" & kitensiid & "'  or hacchuu.seikyuushoid is null)" &
        '                    " AND hacchuu.tenpoid='" & csv_data(0, i) & "'"
        '    End If
        '    If FcSQlGet(0, rs_tsutsu, sql_tsutsu, WMsg) = True Then
        '        'MsgBox "閉め日からそれ以前で、算定する請求書番号が違うか存在しないため、発注情報に基づく金額が違います。手動で確認をしてください。ID:" & csv_data(0, i)
        '        csv_data(5, i) = "期間内に請求書ＩＤが違う納品書が存在します。"
        '    Else
        '        csv_data(5, i) = CStr(CLng(csv_data(2, i)) - CLng(csv_data(3, i)) + CLng(csv_data(4, i)))
        '    End If
        'End If

        'frmcsv.pb1.Value = i
        'frmcsv.lblcounter.Caption = CStr(i) & " / " & CStr(datasuu)
        'DoEvents

        'Next

        'Open shutsu_path For Output Access Write As 1
        'For writecounter = 0 To datasuu
        '    If csv_data(2, writecounter) = "0" And csv_data(3, writecounter) = "0" And csv_data(4, writecounter) = "0" And csv_data(5, writecounter) = "0" Then
        '    Else
        '        Write #1, csv_data(0, writecounter), csv_data(1, writecounter), csv_data(2, writecounter), csv_data(3, writecounter), csv_data(4, writecounter), csv_data(5, writecounter) ' TODO : csv_data(6, writecounter)を出力していない
        '    End If
        'Next

        'Close #1

        'ret = MsgBox("指定データのエクスポートが完了しました。", 64, "総合管理システム「SPSALES」")

    End Function

    Function output_csv_wella_shouhin(hozon_path As String) As Boolean

        Dim csv_data(12, 0) As String
        Dim data_count = 0

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2, shouhinkubun2.wella" +
                " FROM shouhinkubun2" +
                " RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" +
                " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" +
                " WHERE shouhin.haiban IS NULL AND (shouhinkubun2.wella = '0' OR shouhinkubun2.wella = '1')" +
                " ORDER BY shouhin.shouhinid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータが存在しません。")
                Return False
            End If

            ReDim csv_data(12, data_count)
            csv_data(0, 0) = "商品ID"
            csv_data(1, 0) = "商品名"
            csv_data(2, 0) = "商品フリガナ"
            csv_data(3, 0) = "区分１"
            csv_data(4, 0) = "区分２"
            csv_data(5, 0) = "バーコード"
            csv_data(6, 0) = "価格"
            csv_data(7, 0) = "原価"
            csv_data(8, 0) = "現在庫"
            csv_data(9, 0) = "未使用(=1)"
            csv_data(10, 0) = "非課税(=1)"
            csv_data(11, 0) = "種類(Wella=0､ｾﾊﾞ=1)"
            csv_data(12, 0) = "業者区分"

            For i = 0 To data_count - 1

                csv_data(0, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))
                csv_data(1, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                csv_data(2, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinfurigana"))
                csv_data(3, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunmei2")) Then
                    csv_data(4, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("barcode")) Then
                    csv_data(5, i + 1) = Trim(dt_server.Rows.Item(i).Item("barcode"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("kakaku")) Then
                    csv_data(6, i + 1) = Trim(dt_server.Rows.Item(i).Item("kakaku"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("genka")) Then
                    csv_data(7, i + 1) = Trim(dt_server.Rows.Item(i).Item("genka"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    csv_data(8, i + 1) = Trim(dt_server.Rows.Item(i).Item("genzaikosuu"))
                End If

                csv_data(9, i + 1) = Trim(dt_server.Rows.Item(i).Item("mishiyou"))

                If Not IsDBNull(dt_server.Rows.Item(i).Item("hikazei")) Then
                    csv_data(10, i + 1) = Trim(dt_server.Rows.Item(i).Item("hikazei"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("wella")) Then
                    csv_data(11, i + 1) = Trim(dt_server.Rows.Item(i).Item("wella"))
                End If

                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhinkubunid0")) Then
                    csv_data(12, i + 1) = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0"))
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

        '        Dim sql_sentaku As String, rs_sentaku As New ADODB.Recordset, i As Long
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
        '    If chkchk = 1 Then
        '        sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" &
        '" FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" &
        '" ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" &
        '" ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" &
        '" order by shouhin.shouhinid"
        '    Else
        '        sql_sentaku = "SELECT shouhin.*, shouhinkubun.shouhinkubunmei, shouhinkubun2.shouhinkubunmei2" &
        '" FROM shouhinkubun2 RIGHT JOIN (shouhinkubun RIGHT JOIN shouhin" &
        '" ON shouhinkubun.shouhinkubunid = shouhin.shouhinkubunid)" &
        '" ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" &
        '" where shouhin.mishiyou <> '1'" &
        '" order by shouhin.shouhinid"
        '    End If
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
        '                i = 1
        '                Do Until rs_sentaku.EOF
        '                    Select Case csv_shurui
        '                        Case 1  '店舗情報
        '                            csv_data(0, i) = rs_sentaku!tenpoid
        '                            csv_data(1, i) = Trim(rs_sentaku!tenpomei)
        '                            csv_data(2, i) = rs_sentaku!tenpofurigana
        '                            csv_data(3, i) = rs_sentaku!mailno
        '                            csv_data(4, i) = Trim(rs_sentaku!adress1)
        '                            csv_data(5, i) = Trim(rs_sentaku!tenpoadress)
        '                            csv_data(6, i) = rs_sentaku!tel
        '                            csv_data(7, i) = rs_sentaku!fax
        '                            csv_data(8, i) = rs_sentaku!keitai
        '                            csv_data(9, i) = rs_sentaku!daihyou
        '                            csv_data(10, i) = Trim(rs_sentaku!tantou)
        '                            csv_data(11, i) = rs_sentaku!juugyouinsuu
        '                            Select Case CInt(rs_sentaku!shimebi)
        '                                Case 0
        '                                    csv_data(12, i) = "５日"
        '                                Case 1
        '                                    csv_data(12, i) = "１０日"
        '                                Case 2
        '                                    csv_data(12, i) = "１５日"
        '                                Case 3
        '                                    csv_data(12, i) = "２０日"
        '                                Case 4
        '                                    csv_data(12, i) = "２５日"
        '                                Case 5
        '                                    csv_data(12, i) = "月末"
        '                                Case 6
        '                                    csv_data(12, i) = "随時"
        '                            End Select
        '                            csv_data(13, i) = rs_sentaku!email
        '                            csv_data(14, i) = rs_sentaku!bikou
        '                            csv_data(15, i) = rs_sentaku!kadou
        '                            If IsNull(rs_sentaku!kurikoshi) Then
        '                                csv_data(16, i) = 0
        '                            Else
        '                                csv_data(16, i) = rs_sentaku!kurikoshi
        '                            End If
        '                            csv_data(17, i) = rs_sentaku!shainmei
        '                        Case 2  '商品情報
        '                            csv_data(0, i) = rs_sentaku!shouhinid
        '                            csv_data(1, i) = rs_sentaku!shouhinmei
        '                            csv_data(2, i) = rs_sentaku!shouhinfurigana
        '                            csv_data(3, i) = rs_sentaku!shouhinkubunmei
        '                            csv_data(4, i) = rs_sentaku!shouhinkubunmei2
        '                            csv_data(5, i) = rs_sentaku!Barcode
        '                            csv_data(6, i) = rs_sentaku!kakaku
        '                            csv_data(7, i) = rs_sentaku!genka
        '                            csv_data(8, i) = rs_sentaku!genzaikosuu
        '                            csv_data(9, i) = rs_sentaku!mishiyou
        '                            csv_data(10, i) = rs_sentaku!hikazei
        '                            csv_data(11, i) = rs_sentaku!shouhinkubunid0
        '                        Case 3  '商品情報
        '                            csv_data(0, i) = rs_sentaku!shouhinid
        '                            csv_data(1, i) = rs_sentaku!shouhinmei
        '                            csv_data(2, i) = rs_sentaku!shouhinfurigana
        '                            csv_data(3, i) = rs_sentaku!shouhinkubunmei
        '                            csv_data(4, i) = rs_sentaku!shouhinkubunmei2
        '                            csv_data(5, i) = rs_sentaku!Barcode
        '                            csv_data(6, i) = rs_sentaku!kakaku
        '                            csv_data(7, i) = rs_sentaku!genka
        '                            csv_data(8, i) = rs_sentaku!genzaikosuu
        '                            csv_data(9, i) = rs_sentaku!mishiyou
        '                            csv_data(10, i) = rs_sentaku!hikazei
        '                            csv_data(11, i) = rs_sentaku!wella
        '                            csv_data(12, i) = rs_sentaku!shouhinkubunid0
        '                    End Select

        '                    i = i + 1
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
        '            i = 1
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

        convert_nothing_to_karamoji(csv_data)

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


    Private Sub show_shinkou_joukyou(max_count As Integer)

        gbx_shinkou_joukyou.Visible = True
        gbx_shinkou_joukyou.BringToFront()
        Dim x As Integer = 275
        Dim y As Integer = (ClientSize.Height - gbx_shinkou_joukyou.Height) \ 2
        gbx_shinkou_joukyou.Location = New Point(x, y)
        pgb_shinkou_joukyou.Minimum = 0
        pgb_shinkou_joukyou.Maximum = max_count
        pgb_shinkou_joukyou.Value = 0
        gbx_main.Enabled = False

        System.Windows.Forms.Application.DoEvents()

    End Sub

    Private Sub hide_shinkou_joukyou()

        gbx_main.Enabled = True
        gbx_shinkou_joukyou.Visible = False

    End Sub

    Sub calculate_shinkou_joukyou(counter As Integer, max_count As Integer)

        lbl_shinkou_doai.Text = counter.ToString("#,0") + " / " + max_count.ToString("#,0")
        lbl_shinkou_percent.Text = "" + (CDbl(counter) / CDbl(max_count) * 100).ToString(".00") + "%"
        pgb_shinkou_joukyou.Value = counter

        System.Windows.Forms.Application.DoEvents()

    End Sub

End Class