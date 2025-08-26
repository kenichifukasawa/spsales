Imports System.Data.SqlClient

Public Class frmkosuu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmkosuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbtekiyou.Items.Clear()
        cmbtekiyou.Items.Add("ｻｰﾋﾞｽ")
        cmbtekiyou.Items.Add("ｻﾝ")
        cmbtekiyou.Items.Add("ｷｬﾝﾍﾟｰﾝ")
        cmbtekiyou.Items.Add("交換")
        cmbtekiyou.Items.Add("直送")
        cmbtekiyou.Items.Add("ｷﾞｬﾗﾘｰ")
        cmbtekiyou.Items.Add("あっぷる")

        cmbtekiyou.SelectedIndex = -1

        If frmmain.txtkubun1.Text = "99" Then
            txtkosuu.Text = "1"
            txtkosuu.Visible = False
            Label7.Text = "値引額"
            Label10.Visible = False
            lblzaiko.Visible = False
            Label6.Visible = False
        End If


    End Sub

    Private Sub btn_hozon_Click(sender As Object, e As EventArgs) Handles btn_hozon.Click

        Dim s_pcname As String = Trim(frmmain.lblpcname.Text)

        Dim s_shouhinid As String = Trim(lblshouhinid.Text)
        If s_shouhinid = "" Then
            msg_go("商品IDが不正です。")
            Exit Sub
        End If

        Dim s_kosuu As String = Trim(txtkosuu.Text)
        If s_kosuu = "" Then
            msg_go("個数を入力して下さい。")
            txtkosuu.Focus()
            Exit Sub
        Else
            Dim s_d As Double
            If Not Double.TryParse(s_kosuu, s_d) Then
                msg_go("個数を数値で入力してください。")
                txtkosuu.Focus()
                Exit Sub
            End If
        End If

        Dim s_tanka As String = Trim(txttanka.Text)
        If s_tanka = "" Then
            msg_go("単価を入力して下さい。")
            txttanka.Focus()
            Exit Sub
        Else
            Dim s_d As Double
            If Not Double.TryParse(s_tanka, s_d) Then
                msg_go("単価を数値で入力してください。")
                txttanka.Focus()
                Exit Sub
            End If
        End If

        Dim s_kei As String = Trim(txtgoukei.Text)
        If s_kei = "" Then
            msg_go("合計が不正です。")
            Exit Sub
        Else
            Dim s_d As Double
            If Not Double.TryParse(s_kei, s_d) Then
                msg_go("合計を数値で入力してください。")
                txtgoukei.Focus()
                Exit Sub
            End If
        End If

        Dim s_tekiyou As String = Trim(cmbtekiyou.Text)

        Dim s_kakutei As String = Trim(lblkakutei.Text)

        Dim s_keigen As String = Trim(lblkeigen.Text)

        Dim s_hacchuushousai_count As Integer = 1
        Dim s_hacchuushousai_data(10, s_hacchuushousai_count) As String

        s_hacchuushousai_data(0, s_hacchuushousai_count - 1) = s_pcname
        s_hacchuushousai_data(1, s_hacchuushousai_count - 1) = s_shouhinid
        s_hacchuushousai_data(2, s_hacchuushousai_count - 1) = s_kosuu
        s_hacchuushousai_data(3, s_hacchuushousai_count - 1) = s_tanka
        s_hacchuushousai_data(4, s_hacchuushousai_count - 1) = s_kei
        s_hacchuushousai_data(5, s_hacchuushousai_count - 1) = s_tekiyou
        s_hacchuushousai_data(6, s_hacchuushousai_count - 1) = s_kakutei
        s_hacchuushousai_data(7, s_hacchuushousai_count - 1) = s_keigen


        If hacchuushousai_touroku(s_hacchuushousai_count, s_hacchuushousai_data) = -1 Then
            msg_go("登録に失敗しました。")
            Exit Sub
        Else
            tenpo_orderchu_set_10()

            Me.Close()
            Me.Dispose()
        End If



    End Sub

    Private Sub cmbtekiyou_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtekiyou.SelectedIndexChanged

    End Sub

    Private Sub cmbtekiyou_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbtekiyou.KeyDown

        If e.KeyCode = Keys.Enter Then
            btn_hozon.PerformClick()
        End If

    End Sub

    Private Sub cmbtekiyou_GotFocus(sender As Object, e As EventArgs) Handles cmbtekiyou.GotFocus

        cmbtekiyou.Select(0, cmbtekiyou.Text.Length)

    End Sub

    Private Sub txttanka_TextChanged(sender As Object, e As EventArgs) Handles txttanka.TextChanged

    End Sub

    Private Sub txttanka_KeyDown(sender As Object, e As KeyEventArgs) Handles txttanka.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim inpkosuu As String, sentakukakaku As String, inpkosuu2 As Double, sentakukakaku2 As Double

            inpkosuu = Trim(Me.txtkosuu.Text)
            If inpkosuu = "" Then
                msg_go("オーダー数を入力してください。")
                txtkosuu.Focus()
                Exit Sub
            Else
                inpkosuu2 = CDbl(inpkosuu)
            End If

            sentakukakaku = Trim(Me.txttanka.Text)
            If sentakukakaku = "" Then
                sentakukakaku2 = 0
                chkfukakutei.Checked = True
            Else
                If Not Double.TryParse(sentakukakaku, sentakukakaku2) Then
                    msg_go("数値で入力してください。")
                    txtkosuu.Focus()
                    Exit Sub
                Else
                    sentakukakaku2 = CDbl(sentakukakaku)
                End If

                chkfukakutei.Checked = False
            End If

            Me.txtgoukei.Text = sentakukakaku2 * inpkosuu2
            cmbtekiyou.Focus()

        End If
    End Sub

    Private Sub txttanka_GotFocus(sender As Object, e As EventArgs) Handles txttanka.GotFocus
        txttanka.Select(0, txttanka.Text.Length)
    End Sub

    Private Sub txtkosuu_TextChanged(sender As Object, e As EventArgs) Handles txtkosuu.TextChanged

    End Sub

    Private Sub txtkosuu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkosuu.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim inpkosuu As String, chksuu As Integer, inpkosuu2 As Double

            inpkosuu = Trim(Me.txtkosuu.Text)
            If inpkosuu = "" Or inpkosuu = "0" Then
                msg_go("オーダー数を入力してください。")
                txtkosuu.Focus()
                Exit Sub
            Else

                ' 数値変換
                If Not Double.TryParse(inpkosuu, inpkosuu2) Then
                    msg_go("数値で入力してください。")
                    txtkosuu.Focus()
                    Exit Sub
                Else
                    inpkosuu2 = CDbl(inpkosuu)
                End If

                chksuu = CInt(Math.Floor(inpkosuu2 + 0.99))
                If chksuu <> inpkosuu2 Then
                    msg_go("整数で入力してください。")
                    txtkosuu.Focus()
                    Exit Sub
                End If
            End If
            If Trim(txttanka.Text) = "" Then
                msg_go("商品の単価が不正です。")
                Exit Sub
            Else
                Me.txtgoukei.Text = CDbl(txttanka.Text) * inpkosuu2
                txttanka.Focus()
            End If

        End If


    End Sub
End Class