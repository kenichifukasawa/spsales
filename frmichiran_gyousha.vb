Imports System.Data.SqlClient

Public Class frmichiran_gyousha
    Private Sub frmichiran_gyousha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_gyousha_ichiran()
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_touroku_Click(sender As Object, e As EventArgs) Handles btn_touroku.Click

    End Sub

    Private Sub btn_henkou_Click(sender As Object, e As EventArgs) Handles btn_henkou.Click

    End Sub

    Private Sub btn_sakujo_Click(sender As Object, e As EventArgs) Handles btn_sakujo.Click

    End Sub

    Private Sub set_gyousha_ichiran()

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM gyousha" +
                " LEFT JOIN mailno_m" +
                " ON gyousha.mailno = mailno_m.mailno"

            Dim query_where = ""
            If chk_fuyou_hyouji.Checked = False Then
                query_where = " WHERE gyousha.fuyou IS NULL"
            End If

            query += query_where + " ORDER BY gyousha.gyoushafurigana"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_set_gyousha_ichiran")
            Dim dt_server As DataTable = ds_server.Tables("t_set_gyousha_ichiran")

            With dgv_kensakukekka

                .Rows.Clear()
                .Columns.Clear()
                .ColumnCount = 22

                .Columns(0).Name = "業者ID"
                .Columns(1).Name = "業者名"
                .Columns(2).Name = "ふりがな"
                .Columns(3).Name = "郵便番号"
                .Columns(4).Name = "住所"
                .Columns(5).Name = "電話番号"
                .Columns(6).Name = "FAX番号"
                .Columns(7).Name = "担当者"
                .Columns(8).Name = "携帯番号"
                .Columns(9).Name = "代表者"
                .Columns(10).Name = "〆日"
                .Columns(11).Name = "支払い" + vbCrLf + "方法"
                .Columns(12).Name = "消費税"
                .Columns(13).Name = "端数"
                .Columns(14).Name = "支払い条件"
                .Columns(15).Name = "銀行口座"
                .Columns(16).Name = "備考１"
                .Columns(17).Name = "備考２"
                .Columns(18).Name = "備考３"
                .Columns(19).Name = "メールアドレス"
                .Columns(20).Name = "不要"
                .Columns(21).Name = "適格番号"

                .Columns(0).Width = 75
                .Columns(1).Width = 250
                .Columns(2).Width = 220
                .Columns(3).Width = 90
                .Columns(4).Width = 250
                .Columns(5).Width = 110
                .Columns(6).Width = 110
                .Columns(7).Width = 100
                .Columns(8).Width = 110
                .Columns(9).Width = 100
                .Columns(10).Width = 75
                .Columns(11).Width = 80
                .Columns(12).Width = 100
                .Columns(13).Width = 100
                .Columns(14).Width = 100
                .Columns(15).Width = 100
                .Columns(16).Width = 250
                .Columns(17).Width = 250
                .Columns(18).Width = 250
                .Columns(19).Width = 250
                .Columns(20).Width = 75
                .Columns(21).Width = 130

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(1).Frozen = True

            End With

            Dim mojiretsu(21) As String
            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("gyoushaid"))

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("gyoushamei"))

                mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("gyoushafurigana"))

                If IsDBNull(dt_server.Rows.Item(i).Item("mailno")) Then
                    mojiretsu(3) = ""
                Else
                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("mailno"))
                End If

                Dim juusho_1 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("adress1")) Then
                    juusho_1 = Trim(dt_server.Rows.Item(i).Item("adress1"))
                End If
                Dim juusho_2 = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("gyoushaadress")) Then
                    juusho_2 = Trim(dt_server.Rows.Item(i).Item("gyoushaadress"))
                End If
                mojiretsu(4) = juusho_1 + juusho_2

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushatel")) Then
                    mojiretsu(5) = ""
                Else
                    mojiretsu(5) = Trim(dt_server.Rows.Item(i).Item("gyoushatel"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushafax")) Then
                    mojiretsu(6) = ""
                Else
                    mojiretsu(6) = Trim(dt_server.Rows.Item(i).Item("gyoushafax"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushatantou")) Then
                    mojiretsu(7) = ""
                Else
                    mojiretsu(7) = Trim(dt_server.Rows.Item(i).Item("gyoushatantou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushakeitai")) Then
                    mojiretsu(8) = ""
                Else
                    mojiretsu(8) = Trim(dt_server.Rows.Item(i).Item("gyoushakeitai"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushadaihyou")) Then
                    mojiretsu(9) = ""
                Else
                    mojiretsu(9) = Trim(dt_server.Rows.Item(i).Item("gyoushadaihyou"))
                End If

                Dim shimebi = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("gyoushashimebi")) Then
                    Select Case Trim(dt_server.Rows.Item(i).Item("gyoushashimebi"))
                        Case "0"
                            shimebi = "５日"
                        Case "1"
                            shimebi = "１０日"
                        Case "2"
                            shimebi = "１５日"
                        Case "3"
                            shimebi = "２０日"
                        Case "4"
                            shimebi = "２５日"
                        Case "5"
                            shimebi = "月末日"
                        Case "6"
                            shimebi = "随時"
                        Case Else
                            shimebi = "エラー"
                    End Select
                End If
                mojiretsu(10) = shimebi

                Dim shiharai_houhou As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shiharaihouhou")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("shiharaihouhou").ToString())
                    shiharai_houhou = PaymentMethods.GetNameById(id)
                End If
                mojiretsu(11) = shiharai_houhou

                Dim shouhizei As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("shouhizei")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("shouhizei").ToString())
                    shouhizei = ConsumptionTax.GetNameById(id)
                End If
                mojiretsu(12) = shouhizei

                Dim hasuu As String = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("hasuu")) Then
                    Dim id As String = Trim(dt_server.Rows.Item(i).Item("hasuu").ToString())
                    hasuu = Rounding.GetNameById(id)
                End If
                mojiretsu(13) = hasuu

                If IsDBNull(dt_server.Rows.Item(i).Item("shiharaijouken")) Then
                    mojiretsu(14) = ""
                Else
                    mojiretsu(14) = Trim(dt_server.Rows.Item(i).Item("shiharaijouken"))
                End If

                Dim ginkou_kouza = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("bankmei")) Then
                    ginkou_kouza = Trim(dt_server.Rows.Item(i).Item("bankmei"))

                    If Not IsDBNull(dt_server.Rows.Item(i).Item("bankshitenmei")) Then
                        ginkou_kouza += " " + Trim(dt_server.Rows.Item(i).Item("bankshitenmei"))

                        Dim bank_shurui = ""
                        If Not IsDBNull(dt_server.Rows.Item(i).Item("bankshurui")) Then
                            If Not IsDBNull(dt_server.Rows.Item(i).Item("bankshurui")) Then
                                Dim id As String = Trim(dt_server.Rows.Item(i).Item("bankshurui").ToString())
                                bank_shurui = BankAccountType.GetNameById(id)
                            End If
                            ginkou_kouza += " " + bank_shurui

                            If Not IsDBNull(dt_server.Rows.Item(i).Item("bankno")) Then
                                ginkou_kouza += " " + Trim(dt_server.Rows.Item(i).Item("bankno"))

                                If Not IsDBNull(dt_server.Rows.Item(i).Item("bankkouzamei")) Then
                                    ginkou_kouza += " " + Trim(dt_server.Rows.Item(i).Item("bankkouzamei"))
                                End If
                            End If
                        End If
                    End If
                End If
                mojiretsu(15) = ginkou_kouza

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou")) Then
                    mojiretsu(16) = ""
                Else
                    mojiretsu(16) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou2")) Then
                    mojiretsu(17) = ""
                Else
                    mojiretsu(17) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou2"))
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("gyoushabikou3")) Then
                    mojiretsu(18) = ""
                Else
                    mojiretsu(18) = Trim(dt_server.Rows.Item(i).Item("gyoushabikou3"))
                End If

                Dim user_mei = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("usermei")) Then
                    user_mei = Trim(dt_server.Rows.Item(i).Item("usermei"))
                End If

                Dim domain_name = ""
                If Not IsDBNull(dt_server.Rows.Item(i).Item("domainname")) Then
                    domain_name = " " + Trim(dt_server.Rows.Item(i).Item("domainname"))
                End If
                mojiretsu(19) = Trim(user_mei + domain_name)

                If IsDBNull(dt_server.Rows.Item(i).Item("fuyou")) Then
                    mojiretsu(20) = ""
                Else
                    mojiretsu(20) = "不要"
                End If

                If IsDBNull(dt_server.Rows.Item(i).Item("tekikakubangou")) Then
                    mojiretsu(21) = ""
                Else
                    mojiretsu(21) = Trim(dt_server.Rows.Item(i).Item("tekikakubangou"))
                End If

                dgv_kensakukekka.Rows.Add(mojiretsu)

            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Private Sub chk_fuhitsuyou_hyouji_Click(sender As Object, e As EventArgs) Handles chk_fuyou_hyouji.Click
        set_gyousha_ichiran()
    End Sub
End Class