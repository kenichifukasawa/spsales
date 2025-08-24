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

            shouhin_get("", kensakuber)

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


        If Trim(txtbaercode.Text) = "" Then
            msg_go("バーコードが入力されていません。")
            Exit Sub
        End If
        If Trim(lblshouhin1.Text) = "" Then
            msg_go("商品詳細がありません。")
            Exit Sub
        End If

        Dim karikosuu As String = Trim(txtshiteikosuu.Text)
        If karikosuu = "" Then
            msg_go("数量が入力されていません。")
            Exit Sub
        Else
            Dim s_d As Double
            If Not Double.TryParse(karikosuu, s_d) Then
                msg_go("数値で入力してください。")
                txtshiteikosuu.Focus()
                Exit Sub
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
            sentakutanka = "0"
        Else
            Dim s_d As Double
            If Not Double.TryParse(sentakutanka, s_d) Then
                msg_go("数値で入力してください。")
                txtshiteikosuu.Focus()
                Exit Sub
            End If
        End If

        Dim newshoukei As Integer = CInt(karikosuu) * CInt(sentakutanka)

        If barcodenono = 0 Then
            '仮登録
            '          
            Dim s_hacchuushousai_count As Integer = 1
            Dim s_hacchuushousai_data(10, s_hacchuushousai_count) As String

            s_hacchuushousai_data(0, s_hacchuushousai_count - 1) = s_pcname
            s_hacchuushousai_data(1, s_hacchuushousai_count - 1) = sentakuid
            s_hacchuushousai_data(2, s_hacchuushousai_count - 1) = karikosuu
            s_hacchuushousai_data(3, s_hacchuushousai_count - 1) = sentakutanka
            s_hacchuushousai_data(4, s_hacchuushousai_count - 1) = newshoukei.ToString
            s_hacchuushousai_data(5, s_hacchuushousai_count - 1) = Space(1)
            s_hacchuushousai_data(6, s_hacchuushousai_count - 1) = Space(1)
            s_hacchuushousai_data(7, s_hacchuushousai_count - 1) = s_keigen


            If hacchuushousai_touroku(s_hacchuushousai_count, s_hacchuushousai_data) = -1 Then
                msg_go("登録に失敗しました。")
                Exit Sub
            Else
                tenpo_orderchu_set_10()

                lblshouhin1.Text = ""
                lbltanka.Text = ""
                txtshiteikosuu.Text = ""
                txtbaercode.Text = ""
                txtbaercode.Focus()

            End If



        Else
            '仕入れ

            '            newkin = Trim(txtshiteikin.Text)
            '            If newkin = "" Then
            '                ret = MsgBox("仕入金額を入力してから実行してください。", 48, "総合管理システム「SPSALES」")
            '                Exit Sub
            '            Else

            '                newkin2 = CDbl(newkin)

            '            End If



            '            neworderid = Format(frmshiiredenpyou.lblshiiresuu.Caption, "00")

            '            data_r_open

            '            rs_order.CursorType = adOpenKeyset
            '            rs_order.LockType = adLockOptimistic
            '            rs_order.Open "shiirechu", cnn_r, , , adCmdTable
            '        rs_order.AddNew
            '            rs_order!shiirechuid = neworderid
            '            rs_order!shouhinid = sentakuid
            '            rs_order!shouhinmei = sentakushouhinmei
            '            rs_order!shiiresuu = karikosuu2
            '            rs_order!shiirekingaku = newkin2
            '            rs_order.Update
            '            rs_order.Close
            '            cnn_r.Close
            '            shouhin_shiirechu_set()


            '        End If
            '        If barcodenono = 0 Then
            '            lblshouhin1.Caption = ""
            '            lbltanka.Caption = ""
            '            txtshiteikosuu.Text = ""
            '            txtshiteicode.Text = ""
            '            txtshiteicode.SetFocus
            '        Else
            '            Unload Me
        End If
    End Sub
End Class