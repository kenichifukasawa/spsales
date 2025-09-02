Imports System.Data.SqlClient

Public Class frmkensaku

    Private Sub frmkensaku_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click



        kensakukekka_set()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub dgkensakukekka_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvkekka.CellContentClick


    End Sub



    Private Sub txtkanjaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttenpoid.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Len(txttenpoid.Text) <> 5 Then
                txttenpoid.Text = txttenpoid.Text.ToString.PadLeft(5, "0"c)
            End If
            Button2.PerformClick()
        End If
    End Sub

    Private Sub txtkanjaid_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttenpoid.StyleChanged

    End Sub



    Private Sub dgkensakukekka_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvkekka.DoubleClick
        '    Dim newlogonid As String = Trim(frmmain.lblshokunid.Text)
        Dim sentakuid As String, sentakuseibetsu As String, selectjoukyou As Integer, modori_ukeid As String

        If Me.dgvkekka.Rows.Count < 1 Then
            msg_go("検索結果が表示されていません。検索後、再度実行してください。")
            Exit Sub
        End If

        '選択
        sentakuid = Me.dgvkekka.CurrentRow.Cells(0).Value.ToString



        mainset(sentakuid)

        'main clear
        Me.Close()
        Me.Dispose()

        'kanja set


    End Sub


    Private Sub txtfurigana2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub



    Private Sub txtk_seinengappi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub txtk_seinengappi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtk_seinengappi2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtk_seinengappi2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub dgkensakukekka_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkekka.CellDoubleClick
        If Me.dgvkekka.Rows.Count = 0 Then
            Exit Sub
        End If

        '選択

        Dim donoretsu As Integer = Me.dgvkekka.CurrentCell.ColumnIndex

        Dim sentakuid As String = Me.dgvkekka.CurrentRow.Cells(0).Value.ToString



        mainset(sentakuid)

        Me.Close()
        Me.Dispose()


    End Sub

    Private Sub dgkensakukekka_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvkekka.KeyDown


        If Me.dgvkekka.Rows.Count = 0 Then
            Exit Sub
        End If

        '選択
        If e.KeyCode = Keys.Enter Then
            Dim donoretsu As Integer = Me.dgvkekka.CurrentCell.ColumnIndex

            Dim sentakuid As String = Me.dgvkekka.CurrentRow.Cells(0).Value.ToString



            mainset(sentakuid)

            Me.Close()
            Me.Dispose()

        End If

    End Sub

    Private Sub txtkanjaid_TextChanged(sender As Object, e As EventArgs) Handles txttenpoid.TextChanged

    End Sub

    Private Sub txtfurigana_TextChanged(sender As Object, e As EventArgs) Handles txtfurigana.TextChanged

    End Sub

    Private Sub txtfurigana_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfurigana.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtfurigana.Text) <> "" Then
                Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub frmkensaku_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        txttenpoid.Focus()

    End Sub

    Sub kensakukekka_set()

        With Me

            Dim sql_moji As String = ""

            Dim s_tenpoid As String = Trim(.txttenpoid.Text)
            Dim s_furigana As String = Trim(.txtfurigana.Text)

            Dim s_shichouson As String = Trim(.txtshichousonmei.Text)
            Dim s_banchi As String = Trim(.txtbanchi.Text)

            Dim s_tel As String = Trim(.txttel.Text)

            Dim s_bikou As String = Trim(.txtbikou.Text)

            Dim s_tantou As String = ""

            If .cmbshainid.SelectedIndex <> -1 Then
                s_tantou = Mid(Trim(cmbshainid.Text), 1, 3)
            End If

            Dim s_andor As String = ""

            If rand.Checked = True Then
                s_andor = "and"
            Else
                s_andor = "or"
            End If

            Dim s_mitorihiki As String = ""
            If chkmitorihiki.Checked = True Then
                s_mitorihiki = "1"
            End If


            Try


                Dim cn_server As New SqlConnection

                cn_server.ConnectionString = connectionstring_sqlserver

                If .rippan.Checked = True Then

                    If s_tenpoid <> "" Then

                        sql_moji = "tenpoid='" & s_tenpoid & "'"
                    End If

                    If s_furigana <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "tenpofurigana like '%" & s_furigana & "%'"
                        Else
                            sql_moji = sql_moji & s_andor & " tenpofurigana like '%" & s_furigana & "%'"
                        End If
                    End If

                    If s_shichouson <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "ADRESS1 like '%" & s_shichouson & "%'"
                        Else
                            sql_moji = sql_moji & s_andor & " ADRESS1 like '%" & s_shichouson & "%'"
                        End If
                    End If

                    If s_banchi <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "tenpoadress like '%" & s_banchi & "%'"
                        Else
                            sql_moji = sql_moji & s_andor & " tenpoadress like '%" & s_banchi & "%'"
                        End If
                    End If

                    If s_bikou <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "bikou like '%" & s_bikou & "%'"
                        Else
                            sql_moji = sql_moji & s_andor & " bikou like '%" & s_bikou & "%'"
                        End If
                    End If

                    If s_tel <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "tel like '%" & s_tel & "%'"
                        Else
                            sql_moji = sql_moji & s_andor & " tel like '%" & s_tel & "%'"
                        End If
                    End If

                    If s_tantou <> "" Then
                        If sql_moji = "" Then
                            sql_moji = "shainid = '" & s_tantou & "'"
                        Else
                            sql_moji = sql_moji & s_andor & " shainid = '" & s_tantou & "'"
                        End If
                    End If

                    If s_mitorihiki = "1" Then
                        If sql_moji = "" Then
                            sql_moji = "kadou <> '1'"
                        Else
                            sql_moji = sql_moji & s_andor & " kadou <> '1'"
                        End If
                    End If



                ElseIf .rnouhinshono.Checked = True Then
                    If Trim(.txtnouhinshono.Text) <> "" Then
                        sql_moji = Trim(.txtnouhinshono.Text)
                    Else
                        msg_go("納品書NOを入力してから、再度実行してください。")
                        Exit Sub
                    End If

                ElseIf .rseikyuushoid.Checked = True Then
                    If Trim(.txtseikyuushoid.Text) <> "" Then
                        sql_moji = Trim(.txtseikyuushoid.Text)
                    Else
                        msg_go("請求書ID入力してから、再度実行してください。")
                        Exit Sub
                    End If
                End If

                If sql_moji = "" Then
                    msg_go("検索条件を選択・入力してから、再度実行してください。")
                    Exit Sub
                End If

                If .rippan.Checked = True Then
                    Sql = "SELECT MAILNO_M.ADRESS1,tenpo.*,tenpo.tenpofurigana" &
                      " FROM tenpo LEFT JOIN MAILNO_M " &
                      "ON tenpo.MAILNO = MAILNO_M.MAILNO "

                    Sql = Sql & " where " & sql_moji

                    If .rfuri.Checked = True Then
                        Sql = Sql & " order by tenpo.tenpofurigana"
                    Else
                        Sql = Sql & " order by tenpo.tenpoid"
                    End If

                ElseIf .rnouhinshono.Checked = True Then
                    Sql = "select * from hacchuu where hacchuuid ='" & sql_moji & "'" &
                        " or nouhinshoid ='" & sql_moji & "'"

                ElseIf .rseikyuushoid.Checked = True Then
                    Sql = "select * from seikyuusho where seikyuushoid ='" & sql_moji & "'"

                End If


                Dim da_server As SqlDataAdapter

                da_server = New SqlDataAdapter(Sql, cn_server)

                Dim ds_server As New DataSet

                da_server.Fill(ds_server, "t_kensaku")

                Dim dt_server As DataTable

                dt_server = ds_server.Tables("t_kensaku")



                Dim mojiretsu(5) As String
                If .rippan.Checked = True Then

                    With Me.dgvkekka

                        .Rows.Clear()
                        .Columns.Clear()
                        .ColumnCount = 4

                        .Columns(0).Name = "ＩＤ"
                        .Columns(1).Name = "店舗名"
                        .Columns(2).Name = "メモ"
                        .Columns(3).Name = "住所"

                        .Columns(0).Width = 65
                        .Columns(1).Width = 400
                        .Columns(2).Width = 800
                        .Columns(3).Width = 300

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    End With

                End If

                Dim i As Integer

                If dt_server.Rows.Count = 0 Then
                    dt_server.Clear()
                    ds_server.Clear()
                    msg_go("該当店舗は見つかりませんでした。")
                    Exit Sub
                End If
                If .rippan.Checked = True Then
                    For i = 0 To dt_server.Rows.Count - 1

                        mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("tenpoid"))
                        mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("tenpomei"))
                        If IsDBNull(dt_server.Rows.Item(i).Item("bikou")) Then
                            mojiretsu(2) = ""
                        Else
                            mojiretsu(2) = Trim(dt_server.Rows.Item(i).Item("bikou"))
                        End If

                        If IsDBNull(dt_server.Rows.Item(i).Item("adress1")) Then
                            mojiretsu(3) = ""
                        Else
                            mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("adress1")) & Trim(dt_server.Rows.Item(i).Item("tenpoadress"))
                        End If


                        Me.dgvkekka.Rows.Add(mojiretsu)

                    Next i



                    Me.dgvkekka.Select()

                    dt_server.Clear()
                    ds_server.Clear()

                Else  'If .rnouhinshono.Checked = True Then
                    Dim n_tenpoid As String = Trim(dt_server.Rows.Item(0).Item("tenpoid"))

                    dt_server.Clear()
                    ds_server.Clear()

                    mainset(n_tenpoid)

                    Me.Close()
                    Me.Dispose()
                    'ElseIf .rseikyuushoid.Checked = True Then
                    '    Dim n_tenpoid As String = Trim(dt_server.Rows.Item(0).Item("tenpoid"))

                    '    dt_server.Clear()
                    '    ds_server.Clear()

                    '    mainset(n_tenpoid)

                    '    Me.Close()
                    '    Me.Dispose()
                End If




            Catch ex As Exception
                msg_go(ex.Message)

            End Try
        End With




    End Sub

    Private Sub txtnouhinshono_TextChanged(sender As Object, e As EventArgs) Handles txtnouhinshono.TextChanged

    End Sub

    Private Sub txtnouhinshono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnouhinshono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtnouhinshono.Text) <> "" Then
                Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtseikyuushoid_TextChanged(sender As Object, e As EventArgs) Handles txtseikyuushoid.TextChanged

    End Sub

    Private Sub txtseikyuushoid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtseikyuushoid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtseikyuushoid.Text) <> "" Then
                Button2.PerformClick()
            End If
        End If
    End Sub
End Class