<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdenpyou
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cbx_shain = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_shouhizei_8_percent = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbl_shouhizei_10_percent = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_nouhinsho_goukei = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chk_nouhinsho_houkoku = New System.Windows.Forms.CheckBox()
        Me.chk_nouhinsho_pc = New System.Windows.Forms.CheckBox()
        Me.txt_nouhinsho_no = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgv_nouhinsho = New System.Windows.Forms.DataGridView()
        Me.btn_kensaku = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.cbx_shurui = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgv_nouhinsho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.btn_kensaku)
        Me.GroupBox5.Controls.Add(Me.btn_modoru)
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.dgv_nouhinsho)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1450, 980)
        Me.GroupBox5.TabIndex = 199
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "納品書"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.cbx_shurui)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.cbx_shain)
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(650, 57)
        Me.GroupBox10.TabIndex = 203
        Me.GroupBox10.TabStop = False
        '
        'cbx_shain
        '
        Me.cbx_shain.BackColor = System.Drawing.Color.White
        Me.cbx_shain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shain.FormattingEnabled = True
        Me.cbx_shain.Location = New System.Drawing.Point(310, 22)
        Me.cbx_shain.Name = "cbx_shain"
        Me.cbx_shain.Size = New System.Drawing.Size(104, 23)
        Me.cbx_shain.TabIndex = 195
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 16)
        Me.Label19.TabIndex = 186
        Me.Label19.Text = "日付"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(257, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 16)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "社員"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(188, 26)
        Me.DateTimePicker1.TabIndex = 192
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.lbl_shouhizei_8_percent)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.lbl_shouhizei_10_percent)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.TextBox7)
        Me.GroupBox8.Controls.Add(Me.TextBox6)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.lbl_nouhinsho_goukei)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 81)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1258, 57)
        Me.GroupBox8.TabIndex = 199
        Me.GroupBox8.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(1307, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 44)
        Me.Button2.TabIndex = 209
        Me.Button2.Text = "削除"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_shouhizei_8_percent
        '
        Me.lbl_shouhizei_8_percent.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_shouhizei_8_percent.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhizei_8_percent.Location = New System.Drawing.Point(889, 23)
        Me.lbl_shouhizei_8_percent.Name = "lbl_shouhizei_8_percent"
        Me.lbl_shouhizei_8_percent.Size = New System.Drawing.Size(89, 16)
        Me.lbl_shouhizei_8_percent.TabIndex = 208
        Me.lbl_shouhizei_8_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label28.Location = New System.Drawing.Point(982, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 16)
        Me.Label28.TabIndex = 207
        Me.Label28.Text = "円"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label29.Location = New System.Drawing.Point(836, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 16)
        Me.Label29.TabIndex = 206
        Me.Label29.Text = "８％"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shouhizei_10_percent
        '
        Me.lbl_shouhizei_10_percent.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_shouhizei_10_percent.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhizei_10_percent.Location = New System.Drawing.Point(701, 23)
        Me.lbl_shouhizei_10_percent.Name = "lbl_shouhizei_10_percent"
        Me.lbl_shouhizei_10_percent.Size = New System.Drawing.Size(89, 16)
        Me.lbl_shouhizei_10_percent.TabIndex = 205
        Me.lbl_shouhizei_10_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.Location = New System.Drawing.Point(794, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 16)
        Me.Label23.TabIndex = 204
        Me.Label23.Text = "円"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Location = New System.Drawing.Point(648, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 16)
        Me.Label25.TabIndex = 203
        Me.Label25.Text = "１０％"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox7.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox7.Location = New System.Drawing.Point(388, 21)
        Me.TextBox7.MaxLength = 50
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(194, 22)
        Me.TextBox7.TabIndex = 202
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox6.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox6.Location = New System.Drawing.Point(63, 21)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(313, 22)
        Me.TextBox6.TabIndex = 200
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 199
        Me.Label21.Text = "備考"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_nouhinsho_goukei
        '
        Me.lbl_nouhinsho_goukei.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nouhinsho_goukei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nouhinsho_goukei.Location = New System.Drawing.Point(1091, 23)
        Me.lbl_nouhinsho_goukei.Name = "lbl_nouhinsho_goukei"
        Me.lbl_nouhinsho_goukei.Size = New System.Drawing.Size(89, 16)
        Me.lbl_nouhinsho_goukei.TabIndex = 198
        Me.lbl_nouhinsho_goukei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(1176, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 16)
        Me.Label15.TabIndex = 190
        Me.Label15.Text = "円"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(1038, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 16)
        Me.Label16.TabIndex = 189
        Me.Label16.Text = "合計"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.chk_nouhinsho_houkoku)
        Me.GroupBox7.Controls.Add(Me.chk_nouhinsho_pc)
        Me.GroupBox7.Controls.Add(Me.txt_nouhinsho_no)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Location = New System.Drawing.Point(664, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(414, 57)
        Me.GroupBox7.TabIndex = 70
        Me.GroupBox7.TabStop = False
        '
        'chk_nouhinsho_houkoku
        '
        Me.chk_nouhinsho_houkoku.AutoSize = True
        Me.chk_nouhinsho_houkoku.Location = New System.Drawing.Point(343, 24)
        Me.chk_nouhinsho_houkoku.Name = "chk_nouhinsho_houkoku"
        Me.chk_nouhinsho_houkoku.Size = New System.Drawing.Size(56, 19)
        Me.chk_nouhinsho_houkoku.TabIndex = 199
        Me.chk_nouhinsho_houkoku.Text = "報告"
        Me.chk_nouhinsho_houkoku.UseVisualStyleBackColor = True
        '
        'chk_nouhinsho_pc
        '
        Me.chk_nouhinsho_pc.AutoSize = True
        Me.chk_nouhinsho_pc.Checked = True
        Me.chk_nouhinsho_pc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_nouhinsho_pc.Location = New System.Drawing.Point(236, 24)
        Me.chk_nouhinsho_pc.Name = "chk_nouhinsho_pc"
        Me.chk_nouhinsho_pc.Size = New System.Drawing.Size(75, 19)
        Me.chk_nouhinsho_pc.TabIndex = 197
        Me.chk_nouhinsho_pc.Text = "PC登録"
        Me.chk_nouhinsho_pc.UseVisualStyleBackColor = True
        '
        'txt_nouhinsho_no
        '
        Me.txt_nouhinsho_no.BackColor = System.Drawing.Color.White
        Me.txt_nouhinsho_no.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_nouhinsho_no.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_nouhinsho_no.Location = New System.Drawing.Point(98, 22)
        Me.txt_nouhinsho_no.MaxLength = 50
        Me.txt_nouhinsho_no.Name = "txt_nouhinsho_no"
        Me.txt_nouhinsho_no.Size = New System.Drawing.Size(111, 22)
        Me.txt_nouhinsho_no.TabIndex = 196
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 16)
        Me.Label17.TabIndex = 188
        Me.Label17.Text = "納品書NO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_nouhinsho
        '
        Me.dgv_nouhinsho.AllowUserToAddRows = False
        Me.dgv_nouhinsho.AllowUserToDeleteRows = False
        Me.dgv_nouhinsho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_nouhinsho.Location = New System.Drawing.Point(8, 143)
        Me.dgv_nouhinsho.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_nouhinsho.MultiSelect = False
        Me.dgv_nouhinsho.Name = "dgv_nouhinsho"
        Me.dgv_nouhinsho.RowTemplate.Height = 24
        Me.dgv_nouhinsho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_nouhinsho.Size = New System.Drawing.Size(1426, 820)
        Me.dgv_nouhinsho.TabIndex = 67
        '
        'btn_kensaku
        '
        Me.btn_kensaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kensaku.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kensaku.Location = New System.Drawing.Point(1155, 30)
        Me.btn_kensaku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kensaku.Name = "btn_kensaku"
        Me.btn_kensaku.Size = New System.Drawing.Size(127, 44)
        Me.btn_kensaku.TabIndex = 205
        Me.btn_kensaku.Text = "修正"
        Me.btn_kensaku.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1307, 30)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 204
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'cbx_shurui
        '
        Me.cbx_shurui.BackColor = System.Drawing.Color.White
        Me.cbx_shurui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shurui.FormattingEnabled = True
        Me.cbx_shurui.Location = New System.Drawing.Point(491, 22)
        Me.cbx_shurui.Name = "cbx_shurui"
        Me.cbx_shurui.Size = New System.Drawing.Size(129, 23)
        Me.cbx_shurui.TabIndex = 203
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label30.Location = New System.Drawing.Point(439, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 16)
        Me.Label30.TabIndex = 202
        Me.Label30.Text = "印刷"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmdenpyou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 1003)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "frmdenpyou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "伝票"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgv_nouhinsho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents cbx_shain As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_shouhizei_8_percent As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbl_shouhizei_10_percent As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_nouhinsho_goukei As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents chk_nouhinsho_houkoku As CheckBox
    Friend WithEvents chk_nouhinsho_pc As CheckBox
    Friend WithEvents txt_nouhinsho_no As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dgv_nouhinsho As DataGridView
    Friend WithEvents btn_kensaku As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents cbx_shurui As ComboBox
    Friend WithEvents Label30 As Label
End Class
