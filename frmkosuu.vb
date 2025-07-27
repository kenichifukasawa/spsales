Public Class frmkosuu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmkosuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nyuuryokutekiyou = ""

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
        '    newshoukei = sentakukakaku2 * inpkosuu2




        '    Dim MONOI As Long
        '    Dim newhacchuushousaiid As String ', newhacchuushousaiid2 As Double
        '    Dim rs_hacchu2 As ADODB.Recordset

        '    MONOI = CLng(setting2_10(0, 3, 1, 1, 0))
        '    ' MONOI = CLng(setting2(0, 3, 0, 1, "", 0))
        '    If MONOI = -1 Then
        '        MsgBox "発注詳細番号を参照できませんでした。再度実行してください。"
        '   Exit Sub
        '    End If
        '    If MONOI = 0 Then
        '        newhacchuushousaiid = "0000000001"
        '    Else
        '        newhacchuushousaiid = Format(MONOI, "000000000#")
        '    End If



        '    '発注詳細テーブル登録



        '    Set rs_hacchu2 = New ADODB.Recordset

        '    rs_hacchu2.CursorType = adOpenForwardOnly 'adOpenKeyset


        '    rs_hacchu2.LockType = adLockOptimistic
        '    rs_hacchu2.Open "hacchuushousai", cnn, , , adCmdTable


        '        rs_hacchu2.AddNew

        '    rs_hacchu2!hachuushousaiid = newhacchuushousaiid
        '    rs_hacchu2!hacchuuid = s_pcname   'newhacchuuid
        '    rs_hacchu2!shouhinid = sentakuid ' karitourokudata(karitousuu - 1, 1)
        '    rs_hacchu2!kosuu = inpkosuu2  'karitourokudata(karitousuu - 1, 2)
        '    rs_hacchu2!tanka = sentakukakaku2 ' karitourokudata(karitousuu - 1, 3)
        '    rs_hacchu2!kei = newshoukei ' karitourokudata(karitousuu - 1, 4)
        '    rs_hacchu2!tekiyou = nyuuryokutekiyou  'karitourokudata(karitousuu - 1, 5)
        '    rs_hacchu2!kakutei = CStr(nyuuryokufukakutei) ' karitourokudata(karitousuu - 1, 6)

        '    If Trim(s_keigen) <> "" Then
        '        rs_hacchu2!keigen = Trim(s_keigen)  ' karitourokudata(karitousuu - 1, 7)
        '    End If

        '    rs_hacchu2.Update




        '    tenpo_orderchu_set_10()


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