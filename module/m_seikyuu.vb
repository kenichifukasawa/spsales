Imports System.Data.SqlClient

Module m_seikyuu
    Function st_koushin(s_id As String, s_st As String, Optional s_adress As String = "") As Integer



        Dim newitsu As String, newnanji As String
        '  Dim newkijunbi As String



        newitsu = DateTime.Now.ToString("yyyy/MM/dd")
        newnanji = DateTime.Now.ToString("HH:mm:ss")


        Try

            Dim cn_server As New SqlConnection
            Dim da_server As SqlDataAdapter
            Dim ds_server As New DataSet


            'cn_server.ConnectionString = connectionstring_sqlserver.ConnectionString
            cn_server.ConnectionString = connectionstring_sqlserver




            Sql = "SELECT * FROM hassou_yoyaku where hassou_yoyaku_id ='" & s_id & "'"

            da_server = New SqlDataAdapter(Sql, cn_server)

            da_server.Fill(ds_server, "t_ninshin_s")


            '書き込み



            If s_st <> "" Then
                ds_server.Tables("t_ninshin_s").Rows(0)("st") = s_st
            Else
                ds_server.Tables("t_ninshin_s").Rows(0)("st") = DBNull.Value
            End If

            If s_adress <> "" Then

                ds_server.Tables("t_ninshin_s").Rows(0)("mailadress") = s_adress

            End If


            ds_server.Tables("t_ninshin_s").Rows(0)("st_itsu") = newitsu

            ds_server.Tables("t_ninshin_s").Rows(0)("st_nanji") = newnanji



            Dim cmdbuilder_kubun As New SqlCommandBuilder

            cmdbuilder_kubun.DataAdapter = da_server

            da_server.Update(ds_server, "t_ninshin_s")



            ds_server.Clear()

            st_koushin = 0



        Catch ex As Exception
            msg_go(ex.Message)
            st_koushin = -1
        End Try



    End Function

    Sub seikyuusho_set()

        Dim s_sumi As String = ""

        If frmseikyuusho_soushin_ichi.chksumi.Checked = True Then
            s_sumi = " and hassou_yoyaku.st<>'2' and hassou_yoyaku.st<>'3'"
        End If

        Try


            Dim cn_server As New SqlConnection


            cn_server.ConnectionString = connectionstring_sqlserver




            Sql = "SELECT hassou_yoyaku.*,tenpo.*  FROM hassou_yoyaku left join tenpo on hassou_yoyaku.tenpoid = tenpo.tenpoid" &
                " where  hassou_yoyaku.del is null" & s_sumi &
                  " order by hassou_yoyaku.hassou_yoyaku_id desc"

            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_path2")

            Dim dt_server As DataTable

            dt_server = ds_server.Tables("t_path2")

            Dim pathsuu As Integer = dt_server.Rows.Count


            With frmseikyuusho_soushin_ichi.dgrireki
                .RowHeadersWidth = 25
                .Rows.Clear()
                .Columns.Clear()

                .ColumnCount = 8

                .Columns(0).Name = ""
                .Columns(1).Name = "店舗ID"
                .Columns(2).Name = "店舗名"
                .Columns(3).Name = "年月"
                .Columns(4).Name = "ステータス"
                .Columns(5).Name = "メール"
                .Columns(6).Name = "ファイル"
                .Columns(7).Name = "ID"
                .Columns(0).Width = 35
                .Columns(1).Width = 50
                .Columns(2).Width = 200
                .Columns(3).Width = 60
                .Columns(4).Width = 200
                .Columns(5).Width = 150
                .Columns(6).Width = 250
                .Columns(7).Width = 0

                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True

                ' .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = True
                .EditMode = DataGridViewEditMode.EditOnEnter

                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing

                .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            End With

            Dim mojiretsu(20) As String, jitsucount2 As Integer = 0

            Dim s_soushin_joukyou As Integer

            For i = 0 To dt_server.Rows.Count - 1
                s_soushin_joukyou = 0
                mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("hassou_yoyaku_id"))

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))

                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))

                mojiretsu(3) = Mid(Trim(dt_server.Rows.Item(i).Item("nentsuki")), 1, 4) & "/" & Mid(Trim(dt_server.Rows.Item(i).Item("nentsuki")), 5, 2)

                Select Case Trim(dt_server.Rows.Item(i).Item("st"))
                    Case "0"
                        mojiretsu(4) = "未送信"
                    Case "1"
                        mojiretsu(4) = "送信エラー"
                        s_soushin_joukyou = 1
                    Case "2"
                        mojiretsu(4) = "送信ＯＫ"
                        s_soushin_joukyou = 1
                    Case "3"
                        mojiretsu(4) = "中止"
                        s_soushin_joukyou = 1
                End Select


                If IsDBNull(dt_server.Rows.Item(i).Item("st_itsu")) Then
                Else
                    If IsDBNull(dt_server.Rows.Item(i).Item("st_nanji")) Then
                    Else
                        mojiretsu(4) = mojiretsu(4) & "(" & Trim(dt_server.Rows.Item(i).Item("st_itsu")) & " " & Trim(dt_server.Rows.Item(i).Item("st_nanji")) & ")"
                    End If
                End If


                If s_soushin_joukyou = 0 Then
                    If IsDBNull(dt_server.Rows.Item(i).Item("soushin")) Then
                        mojiretsu(5) = ""
                    Else
                        If IsDBNull(dt_server.Rows.Item(i).Item("soushinsaki")) Then
                            mojiretsu(5) = ""
                        Else
                            mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("soushinsaki"))
                        End If
                    End If
                Else

                    If IsDBNull(dt_server.Rows.Item(i).Item("mailadress")) Then
                        mojiretsu(5) = ""
                    Else
                        mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("mailadress"))
                    End If

                End If

                mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("filename"))


                frmseikyuusho_soushin_ichi.dgrireki.Rows.Add(mojiretsu)


                frmseikyuusho_soushin_ichi.dgrireki.Rows(jitsucount2).Cells(0) = New DataGridViewCheckBoxCell
                frmseikyuusho_soushin_ichi.dgrireki.Rows(jitsucount2).Cells(0).Value = False
                jitsucount2 = jitsucount2 + 1

            Next



            dt_server.Clear()
            ds_server.Clear()




        Catch ex As Exception
            msg_go(ex.Message)

        End Try

    End Sub

End Module
