Public Class frmhyouji_rireki

    Private Sub frmhyouji_rireki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With dgv_kensakukekka

            .Rows.Clear()
            .Columns.Clear()
            .RowHeadersWidth = 4
            .ColumnCount = 2

            .Columns(0).Name = "店舗ID"
            .Columns(1).Name = "店舗名"

            .Columns(0).Width = 90
            .Columns(1).Width = 500

            .AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim currentFont As Font = .DefaultCellStyle.Font
            .DefaultCellStyle.Font = New Font(currentFont.FontFamily, 11.25F, currentFont.Style)

        End With

    End Sub

    Private Sub btn_modoru_Click(sender As Object, e As EventArgs) Handles btn_modoru.Click
        Me.Close() : Me.Dispose()
    End Sub

End Class