<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiire_rireki_shousai
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbx_main = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.lbl_kingaku = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.lbl_hiduke = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_shiiresaki = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_shiire_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.dgv_kensakukekka)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(968, 972)
        Me.gbx_main.TabIndex = 56
        Me.gbx_main.TabStop = False
        Me.gbx_main.Text = "仮伝票"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_kensakukekka.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_kensakukekka.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(24, 161)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(915, 788)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Group1.Controls.Add(Me.Label2)
        Me.Group1.Controls.Add(Me.lbl_shiire_id)
        Me.Group1.Controls.Add(Me.lbl_kingaku)
        Me.Group1.Controls.Add(Me.Label9)
        Me.Group1.Controls.Add(Me.btn_modoru)
        Me.Group1.Controls.Add(Me.lbl_hiduke)
        Me.Group1.Controls.Add(Me.Label7)
        Me.Group1.Controls.Add(Me.lbl_shiiresaki)
        Me.Group1.Controls.Add(Me.Label5)
        Me.Group1.Location = New System.Drawing.Point(24, 19)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(915, 137)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        '
        'lbl_kingaku
        '
        Me.lbl_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kingaku.Location = New System.Drawing.Point(616, 34)
        Me.lbl_kingaku.Name = "lbl_kingaku"
        Me.lbl_kingaku.Size = New System.Drawing.Size(125, 21)
        Me.lbl_kingaku.TabIndex = 7
        Me.lbl_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(527, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "合計金額"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(765, 71)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'lbl_hiduke
        '
        Me.lbl_hiduke.BackColor = System.Drawing.Color.White
        Me.lbl_hiduke.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_hiduke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_hiduke.Location = New System.Drawing.Point(89, 34)
        Me.lbl_hiduke.Name = "lbl_hiduke"
        Me.lbl_hiduke.Size = New System.Drawing.Size(125, 21)
        Me.lbl_hiduke.TabIndex = 5
        Me.lbl_hiduke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "日付"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiiresaki
        '
        Me.lbl_shiiresaki.BackColor = System.Drawing.Color.White
        Me.lbl_shiiresaki.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiiresaki.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiiresaki.Location = New System.Drawing.Point(89, 81)
        Me.lbl_shiiresaki.Name = "lbl_shiiresaki"
        Me.lbl_shiiresaki.Size = New System.Drawing.Size(333, 21)
        Me.lbl_shiiresaki.TabIndex = 3
        Me.lbl_shiiresaki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "仕入先"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiire_id
        '
        Me.lbl_shiire_id.BackColor = System.Drawing.Color.White
        Me.lbl_shiire_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiire_id.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiire_id.Location = New System.Drawing.Point(337, 34)
        Me.lbl_shiire_id.Name = "lbl_shiire_id"
        Me.lbl_shiire_id.Size = New System.Drawing.Size(125, 21)
        Me.lbl_shiire_id.TabIndex = 34
        Me.lbl_shiire_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "仕入ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshiire_rireki_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshiire_rireki_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "仕入伝票詳細"
        Me.gbx_main.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents lbl_kingaku As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_hiduke As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_shiiresaki As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_shiire_id As Label
End Class
