Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmshiire

    Private kubundodoo As Integer
    Private kuku2dou As Integer


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub txtkubun_TextChanged(sender As Object, e As EventArgs) Handles txtkubun.TextChanged

    End Sub

    Private Sub txtkubun_GotFocus(sender As Object, e As EventArgs) Handles txtkubun.GotFocus

        If shouhinkubun_shien_grid_set(5) <> -1 Then
            lstshien.Left = 50
            lstshien.Visible = True
            kubundodoo = 0
        End If


    End Sub

    Private Sub txtkubun_LostFocus(sender As Object, e As EventArgs) Handles txtkubun.LostFocus
        If Trim(txtkubun.Text) <> "" Then
            lstshien.Visible = False
            'kubundodoo = 2
            kubundodoo = 1
        End If
    End Sub

    Private Sub txtkubun_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun.KeyDown
        If e.KeyCode = Keys.Enter Then

            'kubundodoo = 2
            kubundodoo = 1
            txtkubun1.Focus()

        End If
    End Sub

    Private Sub txtkubun1_TextChanged(sender As Object, e As EventArgs) Handles txtkubun1.TextChanged

    End Sub

    Private Sub txtkubun1_GotFocus(sender As Object, e As EventArgs) Handles txtkubun1.GotFocus

        If shouhinkubun_shien_grid_set(6) <> -1 Then
            lstshien.Left = 100
            lstshien.Visible = True
            kubundodoo = 1
        End If

    End Sub

    Private Sub txtkubun1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtkubun1.Text) = "" Then
                lstshien.Focus()
            Else
                kubundodoo = 2
                txtkubun2.Focus()
            End If
        End If
    End Sub

    Private Sub txtkubun1_LostFocus(sender As Object, e As EventArgs) Handles txtkubun1.LostFocus
        If Trim(txtkubun1.Text) <> "" Then
            lstshien.Visible = False
            kubundodoo = 2
        End If
    End Sub

    Private Sub txtkubun2_TextChanged(sender As Object, e As EventArgs) Handles txtkubun2.TextChanged

    End Sub

    Private Sub txtkubun2_GotFocus(sender As Object, e As EventArgs) Handles txtkubun2.GotFocus
        If shouhinkubun_shien_grid_set(1, Trim(txtkubun1.Text)) <> -1 Then
            lstshien.Left = 150
            lstshien.Visible = True
            txtkubun2.Focus()
        Else
            lstshien.Visible = False

        End If
        kuku2dou = 0
    End Sub

    Private Sub txtkubun2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkubun2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtkubun2.Text) = "" Then
                kuku2dou = 1
                If lstshien.Visible = True Then
                    lstshien.Focus()
                End If
                'kuku2dou = 0
            Else
                txtfurigana.Text = ""
                txtfurigana2.Text = ""
                txtfurigana.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            txtkubun1.Focus()
        End If
    End Sub

    Private Sub txtkubun2_LostFocus(sender As Object, e As EventArgs) Handles txtkubun2.LostFocus
        If kuku2dou = 0 Then
            lstshien.Visible = False
        End If
    End Sub

    Private Sub txtfurigana_TextChanged(sender As Object, e As EventArgs) Handles txtfurigana.TextChanged

    End Sub

    Private Sub txtfurigana_GotFocus(sender As Object, e As EventArgs) Handles txtfurigana.GotFocus
        If Trim(txtkubun1.Text) = "" Then
            lstshien.Visible = False
        Else
            If Trim(txtkubun2.Text) = "" Then
                lstshien.Visible = False
            End If
        End If
    End Sub

    Private Sub txtfurigana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfurigana.KeyPress

    End Sub

    Private Sub txtfurigana_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfurigana.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtfurigana.Text) = "" Then
                txtfurigana2.Focus()
            Else
                txtfurigana2.Text = ""
                btn_jouken_kensaku.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtfurigana2_TextChanged(sender As Object, e As EventArgs) Handles txtfurigana2.TextChanged

    End Sub

    Private Sub txtfurigana2_GotFocus(sender As Object, e As EventArgs) Handles txtfurigana2.GotFocus
        If Trim(txtkubun1.Text) = "" Then
            lstshien.Visible = False
        Else
            If Trim(txtkubun2.Text) = "" Then
                lstshien.Visible = False
            End If
        End If
    End Sub

    Private Sub txtfurigana2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfurigana2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_jouken_kensaku.PerformClick()
        End If
    End Sub

    Private Sub btn_jouken_kensaku_Click(sender As Object, e As EventArgs) Handles btn_jouken_kensaku.Click
        Dim newkubun1 As String, newkubun2 As String, newfuri1 As String, newfuri2 As String
        Dim strstr As String, haibankai As Integer

        Dim newkubun0 As String

        newkubun0 = Trim(txtkubun.Text)
        newkubun1 = Trim(txtkubun1.Text)
        newkubun2 = Trim(txtkubun2.Text)
        newfuri1 = Trim(txtfurigana.Text)
        newfuri2 = Trim(txtfurigana2.Text)

        If chkhaiban.Checked = True Then
            haibankai = 1
        Else
            haibankai = 0
        End If

        Sql = "select shouhin.shouhinmei,shouhin.shouhinid,shouhin.kakaku,shouhin.genzaikosuu " &
            ",shouhinkubun2.shouhinkubunmei2,shouhinkubun.shouhinkubunmei" &
            " from (shouhin left join shouhinkubun2 " &
            " on shouhin.shouhinkubunid2=shouhinkubun2.shouhinkubunid2) left join shouhinkubun" &
            " on shouhin.shouhinkubunid=shouhinkubun.shouhinkubunid "

        strstr = ""

        If newkubun1 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinkubunid='" & newkubun1 & "'"
            End If
        End If
        If newkubun2 <> "" Then
            If strstr = "" Then
                strstr = " where shouhinkubun2.narabe='" & newkubun2 & "'"
            Else
                strstr = strstr & " and shouhinkubun2.narabe='" & newkubun2 & "'"
            End If
        End If
        If newkubun0 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinkubunid0='" & newkubun0 & "'"
            Else
                strstr = strstr & " and shouhin.shouhinkubunid0='" & newkubun0 & "'"
            End If
        End If

        If newfuri1 <> "" Then
            If strstr = "" Then
                strstr = " where shouhin.shouhinfurigana like '%" & newfuri1 & "%'"
            Else
                strstr = strstr & " and shouhin.shouhinfurigana like '%" & newfuri1 & "%'"
            End If
        Else
            If newfuri2 <> "" Then
                If strstr = "" Then
                    strstr = " where shouhin.shouhinfurigana like '%" & newfuri2 & "%'"
                Else
                    strstr = strstr & " and shouhin.shouhinfurigana like '%" & newfuri2 & "%'"
                End If
            End If
        End If

        If strstr = "" Then
            strstr = " where shouhin.mishiyou='0'"
        Else
            strstr = strstr & " and shouhin.mishiyou='0'"
        End If

        If haibankai = 1 Then
            If strstr = "" Then
                strstr = " where shouhin.haiban is null"
            Else
                strstr = strstr & " and shouhin.haiban is null"
            End If
        End If


        Sql = Sql & strstr & " order by shouhin.shouhinid"

        grid_shien_head_set("1")

        Try

            Dim cn_server As New SqlConnection

            cn_server.ConnectionString = connectionstring_sqlserver
            Dim da_server As SqlDataAdapter = New SqlDataAdapter(Sql, cn_server)
            Dim ds_server As New DataSet
            da_server.Fill(ds_server, "t_shoukaii")
            Dim dt_server As DataTable = ds_server.Tables("t_shoukaii")

            Dim mojiretsu(4) As String
            Dim s_kin As Decimal

            If dt_server.Rows.Count = 0 Then
                txtkubun.Focus()
                Exit Sub
            End If

            For i = 0 To dt_server.Rows.Count - 1

                mojiretsu(1) = Trim(dt_server.Rows.Item(i).Item("shouhinmei"))
                mojiretsu(0) = Trim(dt_server.Rows.Item(i).Item("shouhinid"))

                s_kin = dt_server.Rows.Item(i).Item("kakaku")
                mojiretsu(2) = s_kin.ToString("#,##0")

                If IsDBNull(dt_server.Rows.Item(i).Item("genzaikosuu")) Then
                    mojiretsu(3) = "0"
                Else
                    mojiretsu(3) = Trim(dt_server.Rows.Item(i).Item("genzaikosuu"))
                End If

                Me.dgv_shien.Rows.Add(mojiretsu)

            Next i

            dt_server.Clear()
            ds_server.Clear()

            Me.dgv_shien.Focus()
            If dgv_shien.Rows.Count > 1 Then
                dgv_shien.CurrentCell = dgv_shien.Rows(0).Cells(1)
            End If


        Catch ex As Exception
            msg_go(ex.Message)
        End Try

    End Sub

    Private Sub dgv_shien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_shien.CellContentClick

    End Sub

    Private Sub dgv_shien_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_shien.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Me.dgv_shien.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim sentakuid As String = Trim(Me.dgv_shien.CurrentRow.Cells(0).Value.ToString)
            Dim sentakushouhinmei As String = Trim(Me.dgv_shien.CurrentRow.Cells(1).Value.ToString)
            Dim sentakuzaiko As String = Trim(Me.dgv_shien.CurrentRow.Cells(3).Value.ToString)
            Dim sentakutanka As String = Trim(Me.dgv_shien.CurrentRow.Cells(2).Value.ToString)

            If sentakutanka = "" Then
                sentakutanka = "0"
            End If

            If sentakuid = "" Then
                msg_go("商品IDが不正です。")
                Exit Sub
            End If

            lblshouhinid.Text = sentakuid
            lblshouhinmei.Text = sentakushouhinmei
            txtkin.Text = sentakutanka
            txtsentakutanka.Text = sentakutanka
            ' txtsentakugyou.Text = frmshiiredenpyou.gridshien.Row
            txtsuu.Focus
            Exit Sub




        ElseIf e.KeyCode = Keys.Back Then
            txtkubun.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            dgv_shien.Visible = False
        End If



    End Sub

    Private Sub txtsuu_TextChanged(sender As Object, e As EventArgs) Handles txtsuu.TextChanged

    End Sub

    Private Sub txtsuu_GotFocus(sender As Object, e As EventArgs) Handles txtsuu.GotFocus


        txtsuu.SelectAll()

    End Sub

    Private Sub txtsuu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsuu.KeyDown
        Dim n_suu As Integer, n_kin As Integer

        If e.KeyCode = Keys.Enter Then
            Dim nyusuu As String = Trim(txtsuu.Text)

            Dim s_d As Double
            If Not Double.TryParse(nyusuu, s_d) Then
                msg_go("数値で入力してください。")
                txtsuu.Focus()
                Exit Sub
            Else
                n_suu = CInt(nyusuu)
            End If

            Dim nowkinkin As String = Trim(txtkin.Text)
            If Not Double.TryParse(nowkinkin, s_d) Then
                msg_go("金額が不正です。")
                txtkin.Focus()
                Exit Sub
            Else
                n_kin = CInt(nowkinkin)
            End If


            txtkin.Text = (n_suu * n_kin).ToString

            txtkin.Focus()
        End If


    End Sub

    Private Sub txtkin_TextChanged(sender As Object, e As EventArgs) Handles txtkin.TextChanged

    End Sub

    Private Sub txtkin_GotFocus(sender As Object, e As EventArgs) Handles txtkin.GotFocus

        txtkin.SelectAll()

    End Sub

    Private Sub txtkin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkin.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim nowkinkin As String = Trim(txtkin.Text)
            Dim s_d As Double

            If Not Double.TryParse(nowkinkin, s_d) Then
                msg_go("金額が不正です。")
                txtkin.Focus()
                Exit Sub
            End If

            txtbikou.Focus()

        End If


    End Sub

    Private Sub txtbikou_TextChanged(sender As Object, e As EventArgs) Handles txtbikou.TextChanged

    End Sub

    Private Sub txtbikou_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbikou.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            .lblshouhinid.Text = ""
            .lblshouhinmei.Text = ""
            .txtkubun.Text = ""
            .txtkubun1.Text = ""
            .txtkubun2.Text = ""
            .txtfurigana.Text = ""
            .txtfurigana2.Text = ""
            .txtsuu.Text = ""
            .txtkin.Text = ""
            .txtbikou.Text = ""

            grid_shien_head_set("1")

            .txtkubun.Focus()
        End With

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim chksuu As Integer
        Dim newshouhinid As String, newshiireid As String, newbikou As String
        Dim newsuu As String, newsuu2 As Integer, newkin2 As Integer, newshouhinmei As String


        With Me
            chksuu = CInt(.lblshiiresuu.Text)
            If chksuu >= 100 Then
                msg_go("伝票登録数が９９を超えています。")
                Exit Sub
            End If
            newshouhinid = Trim(.lblshouhinid.Text)
            If newshouhinid = "" Then
                msg_go("商品IDを入力してから実行してください。")
                Exit Sub
            End If
            newshouhinmei = Trim(.lblshouhinmei.Text)
            If newshouhinmei = "" Then
                msg_go("商品名を入力してから実行してください。")
                Exit Sub
            End If

            newsuu = Trim(.txtsuu.Text)
            Dim s_d As Double
            If Not Double.TryParse(newsuu, s_d) Then
                msg_go("数量を入力してから実行してください。")
                txtsuu.Focus()
                Exit Sub
            Else
                newsuu2 = CInt(newsuu)
            End If

            Dim nowkinkin As String = Trim(txtkin.Text)
            If Not Double.TryParse(nowkinkin, s_d) Then
                msg_go("金額を入力してから実行してください。")
                txtkin.Focus()
                Exit Sub
            Else
                newkin2 = CInt(nowkinkin)
            End If

            newbikou = Trim(.txtbikou.Text)
            If newbikou = "" Then
                newbikou = Space(1)
            End If

            '    '欠番を判定
            newshiireid = ""
            Dim s_no As String = ""
            For i = 0 To dgv_shiire.Rows.Count - 1

                s_no = Trim(dgv_shiire(0, i).Value)
                If i <> CInt(s_no) Then
                    newshiireid = i.ToString("000")
                    Exit For
                End If
            Next
            If newshiireid = "" Then
                newshiireid = (dgv_shiire.Rows.Count + 1).ToString("000")
            End If

            'ローカルに登録
            Try
                Using cn As New OleDbConnection(connectionstring_mdb)
                    cn.Open()

                    Dim sql As String = "INSERT INTO shiirechu" +
                    " (shiirechuid, shouhinid, shouhinmei, shiiresuu, shiirekingaku, bikou)" +
                    " VALUES" +
                    " (?, ?, ?, ?, ?, ?)"

                    Using cmd As New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@p1", newshiireid)
                        cmd.Parameters.AddWithValue("@p2", newshouhinid)
                        cmd.Parameters.AddWithValue("@p3", newshouhinmei)
                        cmd.Parameters.AddWithValue("@p4", newsuu2)
                        cmd.Parameters.AddWithValue("@p5", newkin2)
                        cmd.Parameters.AddWithValue("@p6", newbikou)

                        Dim result As Integer = cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                msg_go("MDBのshiirechuの登録時にエラーが発生しました: " & ex.Message)
                Exit Sub
            End Try

        End With

        shouhin_shiirechu_set()

        lblshouhinid.Text = ""
        lblshouhinmei.Text = ""
        txtsuu.Text = ""
        txtkin.Text = ""
        txtbikou.Text = ""
        dgv_shien.Focus()

    End Sub

    Private Sub frmshiire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class