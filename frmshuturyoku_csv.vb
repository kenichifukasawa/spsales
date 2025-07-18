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
                If cbx_nen.SelectedIndex = -1 Or cbx_tsuki.SelectedIndex = -1 Then
                    msg_go("期間を指定してください。")
                    Exit Sub
                End If
                Dim shitei_nen = Trim(cbx_nen.Text)
                Dim shitei_tsuki = Trim(cbx_tsuki.Text)
                response = output_csv_kurikoshi(hozon_path:=hozon_path, shitei_nen:=shitei_nen, shitei_tsuki:=shitei_tsuki)
                hide_shinkou_joukyou()
            Case "Wella売上通知データ出力"

                response = output_csv_wella_uriage(hozon_path)

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

    End Function

    Function output_csv_wella_uriage(hozon_path As String) As Boolean

        Dim encording_name As String = "shift_jis" ' JISコード指定
        Dim nincode = "001224"
        Dim daicode = "3708001224"
        Dim kyou = Now.ToString("yyyyMMddhhmm")
        Dim dairiten_mei = "有限会社オールビューティＡ＆Ａ"
        Dim torihikisaki_code = "4902565"
        Dim maker_mei = "ウエラジャパン"
        Dim row_counter = 1

        Dim shitei_nen = Trim(cbx_nen.Text)
        Dim shitei_tsuki = Trim(cbx_tsuki.Text)
        If chk_plus_alpha.Checked Then
            If shitei_nen = "" Or shitei_tsuki = "" Then
                msg_go("期間を指定してください。")
                Return False
            End If
        Else
            shitei_nen = Now.AddMonths(-1).ToString("yyyy")
            shitei_tsuki = Now.AddMonths(-1).ToString("MM")
        End If

        Dim file_nen_tsuki = Mid(shitei_nen, 3, 2) + shitei_tsuki
        Dim hiduke_hajime = shitei_nen + shitei_tsuki + "01"
        Dim hiduke_owari = shitei_nen + shitei_tsuki + get_tsuki_saishuubi(shitei_nen, shitei_tsuki)

        'ファイル名作成
        Dim folder_path = DESKTOP_PATH & "\w" & nincode & "_" & file_nen_tsuki & "_オールビューティーエーアンドエー_data"
        Directory.CreateDirectory(folder_path)

        Dim file_1_path = folder_path & "\W" & nincode & "_" & file_nen_tsuki & ".dat"
        If System.IO.File.Exists(file_1_path) Then
            System.IO.File.Delete(file_1_path)
            'Application.DoEvents() ' Windowsフォームアプリの場合
        End If

        Dim file_2_path = folder_path & "\S" & nincode & "_" & file_nen_tsuki & ".dat"
        If System.IO.File.Exists(file_2_path) Then
            System.IO.File.Delete(file_2_path)
            'Application.DoEvents() ' Windowsフォームアプリの場合
        End If

        ' No.1
        ' ヘッダー
        Dim header(11) As String
        header(0) = row_counter.ToString().PadLeft(6)
        header(1) = "0"
        header(2) = "W"
        header(3) = daicode.PadRight(10)
        header(4) = "W"
        header(5) = hiduke_hajime
        header(6) = hiduke_owari
        header(7) = kyou
        header(8) = PadRightByByte(dairiten_mei, 40)
        header(9) = torihikisaki_code
        header(10) = PadRightByByte(maker_mei, 14)
        header(11) = Space(148)
        Dim header_line As String = String.Join("", header) & vbCrLf

        ' データ
        Dim data_line As String = ""
        Dim data_count As Integer = 0
        Dim sougoukeigaku As Integer = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.iraibi, shouhinkubun2.wella, shain.shainmei, tenpo.tel, tenpo.tenpomei, hacchuu.hacchuuid" +
                ", hacchuushousai.shouhinid, shouhin.shouhinmei, hacchuushousai.kosuu, hacchuushousai.tanka, hacchuushousai.kei" +
                ", hacchuu.tenpoid, tenpo.shainid" +
                " FROM shouhinkubun2" +
                " RIGHT JOIN" +
                " (shain RIGHT JOIN" +
                " (shouhin RIGHT JOIN ((tenpo RIGHT JOIN hacchuu ON tenpo.tenpoid = hacchuu.tenpoid)" +
                " LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid)" +
                " ON shouhin.shouhinid = hacchuushousai.shouhinid) ON shain.shainid = tenpo.shainid)" +
                " ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" +
                " WHERE hacchuu.iraibi BETWEEN '" + hiduke_hajime + "' AND '" + hiduke_owari + "'" +
                " AND shouhinkubun2.wella = '0' AND tenpo.wellaon IS NULL" +
                " ORDER BY tenpo.tenpomei OPTION (FORCE ORDER)"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv_1")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv_1")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータ(No.1)が存在しませんでした。")
                dt_server.Clear()
                ds_server.Clear()
                Return False
            End If

            row_counter = 2
            Dim data(20, data_count - 1) As String

            For i = 0 To data_count - 1

                Dim tenpoid = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                If IsDBNull(dt_server.Rows.Item(i).Item("shainid")) Then
                    msg_go("「" & tenpoid & "」の店舗の担当社員を指定してから再度実行してください。")
                    dt_server.Clear()
                    ds_server.Clear()
                    Return False
                End If

                Dim shainid = Trim(dt_server.Rows.Item(i).Item("shainid"))
                Dim shainmei = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    shainmei = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                End If

                Dim tel = ""
                Dim henkan_tel = ""
                Dim tenpomei = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                If Not IsDBNull(dt_server.Rows.Item(i).Item("tel")) Then
                    tel = Trim(dt_server.Rows.Item(i).Item("tel"))
                    henkan_tel = tel.Replace("-", "")
                    If tel <> "" And henkan_tel.Length <> 10 And henkan_tel.Length <> 11 Then
                        msg_go("電話番号データが10,11桁ではありません。すべて空白で出力します。" + tenpomei + ":" + tel)
                        tel = ""
                    End If
                End If

                Dim tanka = "0"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("tanka")) Then
                    tanka = Trim(dt_server.Rows.Item(i).Item("tanka").ToString)
                End If

                Dim kosuu = Trim(dt_server.Rows.Item(i).Item("kosuu"))

                Dim kei = "0"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kei")) Then
                    kei = Trim(dt_server.Rows.Item(i).Item("kei").ToString)
                End If
                sougoukeigaku += CInt(kei)

                data(0, i) = row_counter.ToString().PadLeft(6)
                data(1, i) = "1"
                data(2, i) = "W"
                data(3, i) = daicode.PadRight(10)
                data(4, i) = "D"
                data(5, i) = tenpoid.PadRight(15)
                data(6, i) = shainid.PadRight(5)
                data(7, i) = PadRightByByte(shainmei, 20)
                data(8, i) = henkan_tel.PadLeft(13)
                data(9, i) = PadRightByByte(tenpomei, 40)
                data(10, i) = Trim(dt_server.Rows.Item(i).Item("iraibi"))
                data(11, i) = Trim(dt_server.Rows.Item(i).Item("hacchuuid")).PadRight(8)
                data(12, i) = "D"
                data(13, i) = Trim(dt_server.Rows.Item(i).Item("shouhinid")).PadRight(16)
                data(14, i) = PadRightByByte(Trim(dt_server.Rows.Item(i).Item("shouhinmei")), 40)
                data(15, i) = Space(20)

                If tanka = "0" Then
                    data(16, i) = "0".PadLeft(6)
                    data(17, i) = kosuu.PadLeft(6)
                Else
                    data(16, i) = kosuu.PadLeft(6)
                    data(17, i) = "0".PadLeft(6)
                End If

                data(18, i) = tanka.PadLeft(8)
                data(19, i) = kei.PadLeft(10)
                data(20, i) = Space(21)

                row_counter += 1

            Next

            For i As Integer = 0 To data_count - 1
                Dim row(20) As String
                For j As Integer = 0 To 20
                    row(j) = data(j, i)
                Next
                data_line += String.Join("", row) & vbCrLf
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        'フッター情報
        Dim footer(6) As String
        footer(0) = row_counter.ToString.PadLeft(6)
        footer(1) = "2"
        footer(2) = "W"
        footer(3) = daicode.PadRight(10)
        footer(4) = data_count.ToString.PadLeft(6)
        footer(5) = sougoukeigaku.ToString.PadLeft(10)
        footer(6) = Space(222)
        Dim footer_line As String = String.Join("", footer)

        '書き込み
        Try
            Dim enc As Encoding = Encoding.GetEncoding(encording_name)
            Dim sw As New System.IO.StreamWriter(file_1_path, False, enc)
            sw.Write(header_line + data_line + footer_line)
            sw.Close()
            msg_go("データ(No.1)を出力しました。", 64)
        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        ' No.2
        row_counter = 1

        ' ヘッダー
        ReDim header(11)
        header(0) = row_counter.ToString().PadLeft(6)
        header(1) = "0"
        header(2) = "W"
        header(3) = daicode.PadRight(10)
        header(4) = "W"
        header(5) = hiduke_hajime
        header(6) = hiduke_owari
        header(7) = kyou
        header(8) = PadRightByByte(dairiten_mei, 40)
        header(9) = torihikisaki_code
        header(10) = PadRightByByte(maker_mei, 14)
        header(11) = Space(148)
        header_line = String.Join("", header) & vbCrLf

        ' データ
        data_line = ""
        data_count = 0
        sougoukeigaku = 0
        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.iraibi, shouhinkubun2.wella, shain.shainmei, tenpo.tel, tenpo.tenpomei, hacchuu.hacchuuid" +
                ", hacchuushousai.shouhinid, shouhin.shouhinmei, hacchuushousai.kosuu, hacchuushousai.tanka, hacchuushousai.kei, hacchuu.tenpoid, tenpo.shainid" +
                " FROM shouhinkubun2" +
                " RIGHT JOIN (shain RIGHT JOIN (shouhin RIGHT JOIN ((tenpo RIGHT JOIN hacchuu ON tenpo.tenpoid = hacchuu.tenpoid)" +
                " LEFT JOIN hacchuushousai ON hacchuu.hacchuuid = hacchuushousai.hacchuuid) ON shouhin.shouhinid = hacchuushousai.shouhinid) ON shain.shainid = tenpo.shainid) ON shouhinkubun2.shouhinkubunid2 = shouhin.shouhinkubunid2" +
                " WHERE hacchuu.iraibi BETWEEN '" + hiduke_hajime + "' AND '" + hiduke_owari + "' AND shouhinkubun2.wella = '1' AND tenpo.wellaon IS NULL" &
                " ORDER BY tenpo.tenpomei OPTION (FORCE ORDER)"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_output_csv_2")
            Dim dt_server As DataTable = ds_server.Tables("t_output_csv_2")

            data_count = dt_server.Rows.Count
            If data_count = 0 Then
                msg_go("作成したいデータ(No.2)が存在しませんでした。")
                dt_server.Clear()
                ds_server.Clear()
                Return True
            End If

            row_counter = 2
            Dim data(20, data_count - 1) As String

            For i = 0 To data_count - 1

                Dim tenpoid = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                If IsDBNull(dt_server.Rows.Item(i).Item("shainid")) Then
                    msg_go("「" & tenpoid & "」の店舗の担当社員を指定してから再度実行してください。")
                    dt_server.Clear()
                    ds_server.Clear()
                    Return False
                End If

                Dim shainid = Trim(dt_server.Rows.Item(i).Item("shainid"))
                Dim shainmei = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shainmei")) Then
                    shainmei = Trim(dt_server.Rows.Item(i).Item("shainmei"))
                End If

                Dim tel = ""
                Dim henkan_tel = ""
                Dim tenpomei = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                If Not IsDBNull(dt_server.Rows.Item(i).Item("tel")) Then
                    tel = Trim(dt_server.Rows.Item(i).Item("tel"))
                    henkan_tel = tel.Replace("-", "")
                    If tel <> "" And henkan_tel.Length <> 10 And henkan_tel.Length <> 11 Then
                        msg_go("電話番号データが10,11桁ではありません。すべて空白で出力します。" + tenpomei + ":" + tel)
                        tel = ""
                    End If
                End If

                Dim tanka = "0"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("tanka")) Then
                    tanka = Trim(dt_server.Rows.Item(i).Item("tanka").ToString)
                End If

                Dim kosuu = Trim(dt_server.Rows.Item(i).Item("kosuu"))

                Dim kei = "0"
                If Not IsDBNull(dt_server.Rows.Item(i).Item("kei")) Then
                    kei = Trim(dt_server.Rows.Item(i).Item("kei").ToString)
                End If
                sougoukeigaku += CInt(kei)

                data(0, i) = row_counter.ToString().PadLeft(6)
                data(1, i) = "1"
                data(2, i) = "W"
                data(3, i) = daicode.PadRight(10)
                data(4, i) = "D"
                data(5, i) = tenpoid.PadRight(15)
                data(6, i) = shainid.PadRight(5)
                data(7, i) = PadRightByByte(shainmei, 20)
                data(8, i) = henkan_tel.PadLeft(13)
                data(9, i) = PadRightByByte(tenpomei, 40)
                data(10, i) = Trim(dt_server.Rows.Item(i).Item("iraibi"))
                data(11, i) = Trim(dt_server.Rows.Item(i).Item("hacchuuid")).PadRight(8)
                data(12, i) = "D"
                data(13, i) = Trim(dt_server.Rows.Item(i).Item("shouhinid")).PadRight(16)
                data(14, i) = PadRightByByte(Trim(dt_server.Rows.Item(i).Item("shouhinmei")), 40)
                data(15, i) = Space(20)

                If tanka = "0" Then
                    data(16, i) = "0".PadLeft(6)
                    data(17, i) = kosuu.PadLeft(6)
                Else
                    data(16, i) = kosuu.PadLeft(6)
                    data(17, i) = "0".PadLeft(6)
                End If

                data(18, i) = tanka.PadLeft(8)
                data(19, i) = kei.PadLeft(10)
                data(20, i) = Space(21)

                row_counter += 1

            Next

            For i As Integer = 0 To data_count - 1
                Dim row(20) As String
                For j As Integer = 0 To 20
                    row(j) = data(j, i)
                Next
                data_line += String.Join("", row) & vbCrLf
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        'フッター情報
        ReDim footer(6)
        footer(0) = row_counter.ToString.PadLeft(6)
        footer(1) = "2"
        footer(2) = "W"
        footer(3) = daicode.PadRight(10)
        footer(4) = data_count.ToString.PadLeft(6)
        footer(5) = sougoukeigaku.ToString.PadLeft(10)
        footer(6) = Space(222)
        footer_line = String.Join("", footer)

        '書き込み
        Try
            Dim enc As Encoding = Encoding.GetEncoding(encording_name)
            Dim sw As New System.IO.StreamWriter(file_2_path, False, enc)
            sw.Write(header_line + data_line + footer_line)
            sw.Close()
            msg_go("データ(No.2)を出力しました。", 64)
        Catch ex As Exception
            msg_go(ex.Message)
            Return False
        End Try

        Return True

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

    Private Sub calculate_shinkou_joukyou(counter As Integer, max_count As Integer)

        lbl_shinkou_doai.Text = counter.ToString("#,0") + " / " + max_count.ToString("#,0")
        lbl_shinkou_percent.Text = "" + (CDbl(counter) / CDbl(max_count) * 100).ToString(".00") + "%"
        pgb_shinkou_joukyou.Value = counter

        System.Windows.Forms.Application.DoEvents()

    End Sub

    Private Sub frmshuturyoku_csv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nen_ima As Integer = CInt(DateTime.Now.ToString("yyyy"))
        'Dim sakanobori_nensuu = 3
        Dim sakanobori_nensuu = 5

        cbx_nen.Items.Clear()
        cbx_tsuki.Items.Clear()
        For i = nen_ima - sakanobori_nensuu To nen_ima
            cbx_nen.Items.Add(i.ToString)
        Next
        For i = 1 To 12
            cbx_tsuki.Items.Add(i.ToString("D2"))
        Next

    End Sub

    Private Sub chk_plus_alpha_Click(sender As Object, e As EventArgs) Handles chk_plus_alpha.Click

        Dim shurui_name = Trim(lbl_shutsuryoku_type.Text)
        If shurui_name <> "Wella売上通知データ出力" Then
            Exit Sub
        End If

        If chk_plus_alpha.Checked Then
            grp_kikan_shitei.Visible = True
        Else
            grp_kikan_shitei.Visible = False
            cbx_nen.SelectedIndex = -1
            cbx_tsuki.SelectedIndex = -1
        End If

    End Sub

    Private Function PadRightByByte(input As String, targetBytes As Integer, Optional enc As System.Text.Encoding = Nothing) As String
        If enc Is Nothing Then enc = System.Text.Encoding.GetEncoding("shift_jis")
        Dim byteLen As Integer = enc.GetByteCount(input)
        If byteLen = targetBytes Then
            Return input
        ElseIf byteLen < targetBytes Then
            ' 不足分だけスペース追加
            Return input & New String(" "c, targetBytes - byteLen)
        Else
            ' 超過時はバイト単位で切り詰め
            Dim bytes() As Byte = enc.GetBytes(input)
            Dim cutStr As String = enc.GetString(bytes, 0, targetBytes)
            ' 末尾が分断文字の場合、1バイト減らして再取得
            If enc.GetByteCount(cutStr) > targetBytes Then
                cutStr = enc.GetString(bytes, 0, targetBytes - 1)
            End If
            Return cutStr
        End If
    End Function
End Class