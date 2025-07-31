Imports System.Data.SqlClient

Public Class frmshiharai_rireki_shousai
    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

    Private Sub btn_shousai_Click(sender As Object, e As EventArgs) Handles btn_shousai.Click

        Dim shiire_id = dgv_kensakukekka.CurrentRow.Cells(1).Value
        Dim hiduke = dgv_kensakukekka.CurrentRow.Cells(2).Value
        Dim gyousha_mei = Trim(lbl_shiiresaki.Text)
        set_shiire_rireki_shousai(dgv_kensakukekka.Rows.Count, shiire_id, hiduke, gyousha_mei)

    End Sub

End Class