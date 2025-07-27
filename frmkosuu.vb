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
        End If

        Dim s_tanka As String = Trim(txttanka.Text)
        If s_tanka = "" Then
            msg_go("単価を入力して下さい。")
            txttanka.Focus()
            Exit Sub
        End If

        Dim s_kei As String = Trim(txtgoukei.Text)
        If s_kei = "" Then
            msg_go("合計が不正です。")
            Exit Sub
        End If

        Dim s_tekiyou As String = Trim(cmbtekiyou.Text)

        Dim s_kakutei As String = Trim(lblkakutei.Text)

        Dim s_keigen As String = Trim(lblkeigen.Text)

        Dim newid As String, newid2 As String, settei2_res As String

        newid = Trim(setting2(3, 0, "1", ""))
        If newid = "-1" Then
            msg_go("IDの取得に失敗しました。再度実行してください。")
            Exit Sub
        ElseIf newid = "0" Then
            newid2 = "2"
            newid = "0000000001"
        Else
            newid2 = (CInt(newid) + 1).ToString
            newid = newid.ToString.PadLeft(10, "0"c)
        End If

        settei2_res = setting2(3, 1, "1", newid2)
        If settei2_res = "-1" Then
            msg_go("IDの更新に失敗しました。再度実行してください。")
            Exit Sub
        End If


        Try


            Dim cn_server As New SqlConnection

            'cn_server.ConnectionString = connectionstring_sqlserver.ConnectionString
            cn_server.ConnectionString = connectionstring_sqlserver

            Sql = "SELECT TOP 1 * FROM hacchuushousai"

            Dim da_server As SqlDataAdapter

            da_server = New SqlDataAdapter(Sql, cn_server)

            Dim ds_server As New DataSet

            da_server.Fill(ds_server, "t_jm_s")

            Dim s_comr As SqlClient.SqlCommandBuilder

            s_comr = New SqlClient.SqlCommandBuilder(da_server)

            Dim ret_rows As DataRow

            ret_rows = ds_server.Tables("t_jm_s").NewRow()

            ret_rows("hachuushousaiid") = newid
            ret_rows("hacchuuid") = s_pcname
            ret_rows("shouhinid") = s_shouhinid
            ret_rows("kosuu") = s_kosuu
            ret_rows("tanka") = s_tanka
            ret_rows("kei") = s_kei
            ret_rows("tekiyou") = s_tekiyou
            ret_rows("kakutei") = s_kakutei

            If s_keigen <> "" Then
                ret_rows("keigen") = s_keigen
            End If

            ds_server.Tables("t_jm_s").Rows.Add(ret_rows)

            da_server.Update(ds_server, "t_jm_s")

            ds_server.Clear()


        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        tenpo_orderchu_set_10()

        Me.Close()
        Me.Dispose()

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