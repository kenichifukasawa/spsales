Imports System.Data.SqlClient

Public Class frmnouhinsho_idou
    Private Sub frmnouhinsho_idou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_tenpo_cbx(4, True)
    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_denwachou_Click(sender As Object, e As EventArgs) Handles btn_denwachou.Click

        With frmdenwachou
            .lbl_form_id.Text = "4"
            .lbl_button_no.Text = "0"
            .ShowDialog()
        End With

    End Sub

    Private Sub btn_denwachou_1_Click(sender As Object, e As EventArgs) Handles btn_denwachou_1.Click

        With frmdenwachou
            .lbl_form_id.Text = "4"
            .lbl_button_no.Text = "1"
            .ShowDialog()
        End With

    End Sub

    Private Sub btn_idou_Click(sender As Object, e As EventArgs) Handles btn_idou.Click

        Dim moto_tenpo = Trim(cbx_tenpo.Text)
        Dim moto_tenpo_id = Mid(moto_tenpo, 1, 6)
        If moto_tenpo_id = "" Then
            msg_go("移動元の店舗が選択されていません。")
            Exit Sub
        End If

        Dim saki_tenpo = Trim(cbx_tenpo_2.Text)
        Dim saki_tenpo_id = Mid(saki_tenpo, 1, 6)
        If saki_tenpo_id = "" Then
            msg_go("移動先の店舗が選択されていません。")
            Exit Sub
        End If

        If moto_tenpo_id = saki_tenpo_id Then
            msg_go("同じ店舗が選択されています。")
            Exit Sub
        End If

        Dim nouhinsho_jouhou = Trim(cbx_nouhinsho.Text)
        Dim hacchuu_id = Mid(nouhinsho_jouhou, 1, 8)
        If hacchuu_id = "" Then
            msg_go("納品書が選択されていません。")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show(
            "以下の条件で納品書を移動しますか？" + vbCrLf + vbCrLf +
            "・納品書ID： " + hacchuu_id + vbCrLf + "・納品書情報： " + Trim(nouhinsho_jouhou.Replace(hacchuu_id, "")) + vbCrLf + vbCrLf +
            "・移動元の店舗： " + moto_tenpo + vbCrLf + "　　　↓" + vbCrLf + "・移動先の店舗： " + saki_tenpo,
            "SpSales", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try

            Dim conn As New SqlConnection
            conn.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT * FROM hacchuu WHERE hacchuuid = '" + hacchuu_id + "'"

            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(query, conn)
            Dim ds As New DataSet
            Dim temp_table_name = "t_hacchuu"
            da.Fill(ds, temp_table_name)

            ds.Tables(temp_table_name).Rows(0)("tenpoid") = saki_tenpo_id
            ds.Tables(temp_table_name).Rows(0)("kakunin") = DBNull.Value

            If IsDBNull(ds.Tables(temp_table_name).Rows(0)("nouhinshoid")) Then
                ds.Tables(temp_table_name).Rows(0)("shutsu") = DBNull.Value
            Else
                If Trim(ds.Tables(temp_table_name).Rows(0)("nouhinshoid")) = "" Then
                    ds.Tables(temp_table_name).Rows(0)("shutsu") = DBNull.Value
                End If
            End If

            Dim cb As New SqlCommandBuilder
            cb.DataAdapter = da
            da.Update(ds, temp_table_name)
            ds.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

        msg_go("移動が完了しました", 64)
        Me.Close() : Me.Dispose()

    End Sub

    Private Sub cbx_tenpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tenpo.SelectedIndexChanged

        cbx_nouhinsho.Items.Clear()
        Dim tenpo_id = Mid(Trim(cbx_tenpo.Text), 1, 6)

        Try

            Dim cn_server As New SqlConnection
            cn_server.ConnectionString = connectionstring_sqlserver

            Dim query = "SELECT hacchuu.*, shain.ryakumei FROM hacchuu LEFT JOIN shain ON hacchuu.shainid = shain.shainid WHERE tenpoid = '" + tenpo_id + "' and joukyou = '0' ORDER BY iraibi DESC"

            Dim da_server As SqlDataAdapter = New SqlDataAdapter(query, cn_server)
            Dim ds_server As New DataSet
            Dim temp_table_name = "t_hacchuu"
            da_server.Fill(ds_server, temp_table_name)
            Dim dt_server As DataTable = ds_server.Tables(temp_table_name)

            For i = 0 To dt_server.Rows.Count - 1
                Dim goukei = CInt(Trim(dt_server.Rows.Item(i).Item("goukei"))).ToString("#,0")
                Dim item = Trim(dt_server.Rows.Item(i).Item("hacchuuid")) + Space(3) +
                    ConvertYmdStringToYmdSlash(Trim(dt_server.Rows.Item(i).Item("iraibi"))) + Space(3) +
                    Space(7 - goukei.Length) + goukei + "円" + Space(3) + Trim(dt_server.Rows.Item(i).Item("ryakumei"))
                cbx_nouhinsho.Items.Add(item)
            Next

            dt_server.Clear()
            ds_server.Clear()

        Catch ex As Exception
            msg_go(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class