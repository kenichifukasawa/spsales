Imports System.Data.SqlClient

Module m_shuukei

    Sub set_gyousha_kubun_cbx(frm_no As Integer)

        Select Case frm_no
            Case 0
                frmshuukei_shouhin.cbx_gyousha_kubun.Items.Clear()
            Case 1
                frmshuukei_hanbai.cbx_gyousha_kubun.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun0 ORDER BY shouhinkubunid0"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun0")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun0")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid0")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei0"))
                Select Case frm_no
                    Case 0
                        frmshuukei_shouhin.cbx_gyousha_kubun.Items.Add(item_name)
                    Case 1
                        frmshuukei_hanbai.cbx_gyousha_kubun.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shouhin_kubun_1_cbx(frm_no As Integer)

        Select Case frm_no
            Case 0
                frmshuukei_shouhin.cbx_shouhin_kubun_1.Items.Clear()
                frmshuukei_shouhin.cbx_shouhin_kubun_2.Items.Clear()
                frmshuukei_shouhin.cbx_shitei_shouhin.Items.Clear()
            Case 1
                frmshuukei_hanbai.cbx_shouhin_kubun_1.Items.Clear()
                frmshuukei_hanbai.cbx_shouhin_kubun_2.Items.Clear()
                frmshuukei_hanbai.cbx_shitei_shouhin.Items.Clear()
            Case 2
                frmcheck_shouhin_check.cbx_shouhin_kubun_1.Items.Clear()
                frmcheck_shouhin_check.cbx_shouhin_kubun_2.Items.Clear()
                frmcheck_shouhin_check.cbx_shitei_shouhin.Items.Clear()
            Case 3
                frmcheck_shouhin_log.cbx_shitei_shouhin.Items.Clear()
                frmcheck_shouhin_log.cbx_shouhin_kubun_2.Items.Clear()
                frmcheck_shouhin_log.cbx_shouhin_kubun_1.Items.Clear()
            Case 4
                frmcheck_kosuu_henkou.cbx_shouhin_kubun_1.Items.Clear()
                frmcheck_kosuu_henkou.cbx_shouhin_kubun_2.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun ORDER BY shouhinkubunid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei"))
                Select Case frm_no
                    Case 0
                        frmshuukei_shouhin.cbx_shouhin_kubun_1.Items.Add(item_name)
                    Case 1
                        frmshuukei_hanbai.cbx_shouhin_kubun_1.Items.Add(item_name)
                    Case 2
                        frmcheck_shouhin_check.cbx_shouhin_kubun_1.Items.Add(item_name)
                    Case 3
                        frmcheck_shouhin_log.cbx_shouhin_kubun_1.Items.Add(item_name)
                    Case 4
                        frmcheck_kosuu_henkou.cbx_shouhin_kubun_1.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shouhin_kubun_2_cbx(frm_no As Integer, shouhin_kubun_1_id As String)

        Select Case frm_no
            Case 0
                frmshuukei_shouhin.cbx_shouhin_kubun_2.Items.Clear()
            Case 1
                frmshuukei_hanbai.cbx_shouhin_kubun_2.Items.Clear()
            Case 2
                frmcheck_shouhin_check.cbx_shouhin_kubun_2.Items.Clear()
            Case 3
                frmcheck_shouhin_log.cbx_shouhin_kubun_2.Items.Clear()
            Case 4
                frmcheck_kosuu_henkou.cbx_shouhin_kubun_2.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhinkubun2 WHERE shouhinkubunid = '" & shouhin_kubun_1_id & "' ORDER BY narabe"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhinkubun2")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhinkubun2")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("shouhinkubunid2")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinkubunmei2"))
                Select Case frm_no
                    Case 0
                        frmshuukei_shouhin.cbx_shouhin_kubun_2.Items.Add(item_name)
                    Case 1
                        frmshuukei_hanbai.cbx_shouhin_kubun_2.Items.Add(item_name)
                    Case 2
                        frmcheck_shouhin_check.cbx_shouhin_kubun_2.Items.Add(item_name)
                    Case 3
                        frmcheck_shouhin_log.cbx_shouhin_kubun_2.Items.Add(item_name)
                    Case 4
                        frmcheck_kosuu_henkou.cbx_shouhin_kubun_2.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shitei_shouhin_cbx(frm_no As Integer, shouhin_kubun_1_id As String, shouhin_kubun_2_id As String, Optional is_haiban As Boolean = True, Optional is_mishiyou_hihyouji As Boolean = False)

        Select Case frm_no
            Case 0
                frmshuukei_shouhin.cbx_shitei_shouhin.Items.Clear()
            Case 1
                frmshuukei_hanbai.cbx_shitei_shouhin.Items.Clear()
            Case 2
                frmcheck_shouhin_check.cbx_shitei_shouhin.Items.Clear()
            Case 3
                frmcheck_shouhin_log.cbx_shitei_shouhin.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shouhin"

            Dim query_where = ""
            If shouhin_kubun_1_id <> "" Then
                query_where = " WHERE shouhinkubunid = '" + shouhin_kubun_1_id + "'"
            End If

            If shouhin_kubun_2_id <> "" Then
                If query_where = "" Then
                    query_where = " WHERE shouhinkubunid2 = '" + shouhin_kubun_2_id + "'"
                Else
                    query_where += " AND shouhinkubunid2 = '" + shouhin_kubun_2_id + "'"
                End If
            End If

            If is_haiban = False Then
                If query_where = "" Then
                    query_where = " WHERE haiban IS NULL"
                Else
                    query_where += " AND haiban IS NULL"
                End If
            End If

            If is_mishiyou_hihyouji = True Then
                If query_where = "" Then
                    query_where = " WHERE mishiyou = '0'"
                Else
                    query_where += " AND mishiyou = '0'"
                End If
            End If

            query += query_where + " ORDER BY shouhinid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shouhin")
            Dim dt_server As DataTable = ds_server.Tables("t_shouhin")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("shouhinid")) + "   " + Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                Select Case frm_no
                    Case 0
                        frmshuukei_shouhin.cbx_shitei_shouhin.Items.Add(item_name)
                    Case 1
                        frmshuukei_hanbai.cbx_shitei_shouhin.Items.Add(item_name)
                    Case 2
                        frmcheck_shouhin_check.cbx_shitei_shouhin.Items.Add(item_name)
                    Case 3
                        frmcheck_shouhin_log.cbx_shitei_shouhin.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_tenpo_cbx(frm_no As Integer, is_hihyouji_torihiki_nai As Boolean)

        Select Case frm_no
            Case 1
                frmshuukei_hanbai.cbx_tenpo.Items.Clear()
            Case 2
                frmcheck_kurikoshi_log.cbx_tenpo.Items.Clear()
            Case 3
                frmseikyuu_rireki.cbx_tenpo.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT tenpoid, tenpomei FROM tenpo"

            Dim query_where = ""
            If is_hihyouji_torihiki_nai Then
                query_where = " WHERE kadou = '0' OR kadou IS NULL"
            End If

            query += query_where + " ORDER BY tenpofurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_tenpo")
            Dim dt_server As DataTable = ds_server.Tables("t_tenpo")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("tenpoid")) + "   " + Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                Select Case frm_no
                    Case 1
                        frmshuukei_hanbai.cbx_tenpo.Items.Add(item_name)
                    Case 2
                        frmcheck_kurikoshi_log.cbx_tenpo.Items.Add(item_name)
                    Case 3
                        frmseikyuu_rireki.cbx_tenpo.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_shain_cbx(frm_no As Integer)

        Select Case frm_no
            Case 1
                frmshuukei_hanbai.cbx_shain.Items.Clear()
            Case 2
                frmnyuukin_rireki.cbx_shain.Items.Clear()
            Case 3
                frmnouhinsho_rireki.cbx_shain.Items.Clear()
            Case 4
                frmsettei.cmbshain.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM shain WHERE zaishoku = '0' ORDER BY shainid"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shain")
            Dim dt_server As DataTable = ds_server.Tables("t_shain")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("shainid")) + "   " + Trim(dt_server.Rows.Item(i).Item("shainmei"))
                Select Case frm_no
                    Case 1
                        frmshuukei_hanbai.cbx_shain.Items.Add(item_name)
                    Case 2
                        frmnyuukin_rireki.cbx_shain.Items.Add(item_name)
                    Case 3
                        frmnouhinsho_rireki.cbx_shain.Items.Add(item_name)
                    Case 4
                        frmsettei.cmbshain.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub set_gyousha_cbx(frm_no As Integer, Optional is_hyouji_subete As Boolean = True)

        Select Case frm_no
            Case 1
                frmshiire_rireki.cbx_gyousha.Items.Clear()
            Case 2
                frmshiharai_rireki.cbx_gyousha.Items.Clear()
            Case Else
                msg_go("frm_no取得エラー")
                Exit Sub
        End Select

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT gyousha.*, mailno_m.adress1 FROM gyousha LEFT JOIN mailno_m ON gyousha.mailno = mailno_m.mailno"

            Dim where_str = ""
            If is_hyouji_subete = False Then
                where_str = " WHERE fuyou IS NULL "
            End If

            query += where_str + " ORDER BY gyoushafurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_gyousha")
            Dim dt_server As DataTable = ds_server.Tables("t_gyousha")

            For i = 0 To dt_server.Rows.Count - 1
                Dim item_name = Trim(dt_server.Rows.Item(i).Item("gyoushaid")) + "   " + Trim(dt_server.Rows.Item(i).Item("gyoushamei"))
                Select Case frm_no
                    Case 1
                        frmshiire_rireki.cbx_gyousha.Items.Add(item_name)
                    Case 2
                        frmshiharai_rireki.cbx_gyousha.Items.Add(item_name)
                End Select
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub

End Module
