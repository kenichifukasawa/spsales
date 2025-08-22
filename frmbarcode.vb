Imports System.Data.SqlClient

Public Class frmbarcode
    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmbarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If barcodenono = 0 Then
            ltanka.Text = "単価"
            lbltanka.Visible = True
            txtshiteikin.Visible = False
        Else
            ltanka.Text = "仕入額"
            lbltanka.Visible = False
            txtshiteikin.Visible = True
        End If

    End Sub

    Private Sub frmbarcode_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtbaercode.Focus()

    End Sub

    Private Sub txtbaercode_TextChanged(sender As Object, e As EventArgs) Handles txtbaercode.TextChanged

    End Sub

    Private Sub txtbaercode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbaercode.KeyDown
        Dim kensakuber As String

        If e.KeyCode = Keys.Enter Then
            kensakuber = Trim(txtbaercode.Text)
            If kensakuber = "" Then
                lblshouhin1.Text = ""
                Exit Sub
            End If



        End If
    End Sub

    Private Sub txtshiteikosuu_TextChanged(sender As Object, e As EventArgs) Handles txtshiteikosuu.TextChanged

    End Sub

    Private Sub txtshiteikosuu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtshiteikosuu.KeyDown
        If e.KeyCode = Keys.Enter Then
            If barcodenono = 0 Then
                Button1.PerformClick()
            Else
                txtshiteikin.Focus()
            End If
        End If
    End Sub

    Private Sub txtshiteikin_TextChanged(sender As Object, e As EventArgs) Handles txtshiteikin.TextChanged

    End Sub

    Private Sub txtshiteikin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtshiteikin.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim s_pcname As String

        s_pcname = Trim(frmmain.lblpcname.Text)
        If s_pcname = "" Then
            Exit Sub
        End If


        If Trim(lblshouhin1.Text) = "" Then
            msg_go("バーコードが入力されていません。")
            Exit Sub
        End If
        If Trim(lblshouhin1.Text) = "" Then
            msg_go("商品詳細がありません。")
            Exit Sub
        End If

        Dim karikosuu As String = Trim(txtshiteikosuu.Text)
        Dim karikosuu2 As Integer
        If karikosuu = "" Then
            msg_go("数量が入力されていません。")
            Exit Sub
        Else
            Dim s_d As Double
            If Not Double.TryParse(karikosuu, s_d) Then
                msg_go("数値で入力してください。")
                txtshiteikosuu.Focus()
                Exit Sub
            Else
                karikosuu2 = CInt(karikosuu)
            End If
        End If

        Dim s_keigen As String = Trim(lblkeigen.Text)
        If s_keigen = "" Then
            s_keigen = Space(1)
        End If

        Dim sentakuid As String = Mid(lblshouhin1.Text, 1, 10)  'shouhinid
        Dim sentakushouhinmei As String = Trim(Mid(lblshouhin1.Text, 14)) 'shouhinmei

        Dim sentakutanka As String = Trim(lbltanka.Text)  'tanka
        If sentakutanka = "" Then
            sentakukakaku23 = 0
        Else

            sentakukakaku23 = CDbl(sentakutanka)

        End If

        newshoukei3 = sentakukakaku23 * karikosuu2

        If barcodenono = 0 Then
            '仮登録
            Try
                Dim s_no = 3
                Dim id = 1
                Dim ketasuu = 10
                Dim new_id = get_settings(id:=id, s_no:=s_no)
                Dim next_id As String
                If new_id = "" Then
                    msg_go("IDの取得に失敗しました。")
                    Exit Sub
                ElseIf new_id = "0" Then
                    next_id = "2"
                    new_id = 1.ToString("D" + ketasuu.ToString)
                Else
                    next_id = (CLng(new_id) + 1).ToString
                    new_id = new_id.ToString.PadLeft(ketasuu, "0"c)
                End If

                Dim response = update_settings(id:=id, s_no:=s_no, new_value:=next_id)
                If Not response Then
                    msg_go("IDの更新に失敗しました。")
                    Exit Sub
                End If

                Dim cn_server As New SqlConnection
                cn_server.ConnectionString = connectionstring_sqlserver

                Dim query = "SELECT * FROM hacchuu"

                Dim da As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
                Dim ds As New DataSet
                da.Fill(ds, "t_hacchuu")
                Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim data_row As DataRow = ds.Tables("t_hacchuu").NewRow()

                data_row("hacchuuid") = new_id
                data_row("iraibi") = Now.ToString("yyyyMMdd")
                data_row("shainid") = "00"
                data_row("tenpoid") = "999999"
                data_row("goukei") = 0
                data_row("joukyou") = "0"

                ds.Tables("t_hacchuu").Rows.Add(data_row)
                da.Update(ds, "t_hacchuu")
                ds.Clear()

                new_hacchuu_id = new_id

            Catch ex As Exception
                msg_go(ex.Message)
                Return False
            End Try

            Dim MONOI As Long
            Dim newhacchuushousaiid As String    ', newhacchuushousaiid2 As Double
            Dim rs_hacchu2 As ADODB.Recordset

            MONOI = CLng(setting2_10(0, 3, 1, 1, 0))
            'MONOI = CLng(setting2(0, 3, 0, 1, "", 0))
            If MONOI = -1 Then
                MsgBox "発注詳細番号を参照できませんでした。再度実行してください。"
                   Exit Sub
            End If
            If MONOI = 0 Then
                newhacchuushousaiid = "0000000001"
            Else
                newhacchuushousaiid = Format(MONOI, "000000000#")
            End If

            ' newhacchuushousaiid2 = MONOI + 1
            ' If setting2(0, 3, 1, 1, CStr(newhacchuushousaiid2), 0) = "-1" Then
            '  ret = MsgBox("発注詳細番号の更新に失敗しました。少し時間をおいて再度実行してください。", 16, "総合管理システム「SPSALES」")
            '   Exit Sub
            '  End If

            '発注詳細テーブル登録
           
                    
                    
                    Set rs_hacchu2 = New ADODB.Recordset
                    
                    rs_hacchu2.CursorType = adOpenKeyset


            rs_hacchu2.LockType = adLockOptimistic
            rs_hacchu2.Open "hacchuushousai", cnn, , , adCmdTable


                        rs_hacchu2.AddNew

            rs_hacchu2!hachuushousaiid = newhacchuushousaiid
            rs_hacchu2!hacchuuid = s_pcname   'newhacchuuid
            rs_hacchu2!shouhinid = sentakuid ' karitourokudata(karitousuu - 1, 1)
            rs_hacchu2!kosuu = karikosuu2  'karitourokudata(karitousuu - 1, 2)
            rs_hacchu2!tanka = sentakukakaku23 ' karitourokudata(karitousuu - 1, 3)
            rs_hacchu2!kei = newshoukei3 ' karitourokudata(karitousuu - 1, 4)
            rs_hacchu2!tekiyou = " " ' nyuuryokutekiyou  'karitourokudata(karitousuu - 1, 5)
            rs_hacchu2!kakutei = " " '  CStr(nyuuryokufukakutei) ' karitourokudata(karitousuu - 1, 6)

            If Trim(s_keigen) <> "" Then
                rs_hacchu2!keigen = Trim(s_keigen)  ' karitourokudata(karitousuu - 1, 7)
            End If

            rs_hacchu2.Update



            tenpo_orderchu_set_10()

        Else
            '仕入れ

            newkin = Trim(txtshiteikin.Text)
            If newkin = "" Then
                ret = MsgBox("仕入金額を入力してから実行してください。", 48, "総合管理システム「SPSALES」")
                Exit Sub
            Else

                newkin2 = CDbl(newkin)

            End If



            neworderid = Format(frmshiiredenpyou.lblshiiresuu.Caption, "00")

            data_r_open

            rs_order.CursorType = adOpenKeyset
            rs_order.LockType = adLockOptimistic
            rs_order.Open "shiirechu", cnn_r, , , adCmdTable
        rs_order.AddNew
            rs_order!shiirechuid = neworderid
            rs_order!shouhinid = sentakuid
            rs_order!shouhinmei = sentakushouhinmei
            rs_order!shiiresuu = karikosuu2
            rs_order!shiirekingaku = newkin2
            rs_order.Update
            rs_order.Close
            cnn_r.Close
            shouhin_shiirechu_set()


        End If
        If barcodenono = 0 Then
            lblshouhin1.Caption = ""
            lbltanka.Caption = ""
            txtshiteikosuu.Text = ""
            txtshiteicode.Text = ""
            txtshiteicode.SetFocus
        Else
            Unload Me
End If
    End Sub
End Class