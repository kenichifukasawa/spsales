<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnyuukin_rireki
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbx_main = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_goukeigaku = New System.Windows.Forms.Label()
        Me.lbl_kensuu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_hyouji_shinai = New System.Windows.Forms.CheckBox()
        Me.btn_kakunin = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.Group2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear_hi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_hi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shain = New System.Windows.Forms.ComboBox()
        Me.btn_clear_shain = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group2.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.chk_hyouji_shinai)
        Me.gbx_main.Controls.Add(Me.btn_kakunin)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.Group2)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1279, 971)
        Me.gbx_main.TabIndex = 56
        Me.gbx_main.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_goukeigaku)
        Me.GroupBox1.Controls.Add(Me.lbl_kensuu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 61)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        '
        'lbl_goukeigaku
        '
        Me.lbl_goukeigaku.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_goukeigaku.Location = New System.Drawing.Point(92, 36)
        Me.lbl_goukeigaku.Name = "lbl_goukeigaku"
        Me.lbl_goukeigaku.Size = New System.Drawing.Size(103, 19)
        Me.lbl_goukeigaku.TabIndex = 3
        Me.lbl_goukeigaku.Text = "0 円"
        Me.lbl_goukeigaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kensuu
        '
        Me.lbl_kensuu.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kensuu.Location = New System.Drawing.Point(92, 13)
        Me.lbl_kensuu.Name = "lbl_kensuu"
        Me.lbl_kensuu.Size = New System.Drawing.Size(103, 19)
        Me.lbl_kensuu.TabIndex = 2
        Me.lbl_kensuu.Text = "0 件"
        Me.lbl_kensuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "入金合計額"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "入金件数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_hyouji_shinai
        '
        Me.chk_hyouji_shinai.AutoSize = True
        Me.chk_hyouji_shinai.Checked = True
        Me.chk_hyouji_shinai.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_hyouji_shinai.Location = New System.Drawing.Point(162, 12)
        Me.chk_hyouji_shinai.Name = "chk_hyouji_shinai"
        Me.chk_hyouji_shinai.Size = New System.Drawing.Size(201, 18)
        Me.chk_hyouji_shinai.TabIndex = 198
        Me.chk_hyouji_shinai.Text = "チェック済みの伝票は表示しない"
        Me.chk_hyouji_shinai.UseVisualStyleBackColor = True
        '
        'btn_kakunin
        '
        Me.btn_kakunin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kakunin.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kakunin.Location = New System.Drawing.Point(1003, 37)
        Me.btn_kakunin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kakunin.Name = "btn_kakunin"
        Me.btn_kakunin.Size = New System.Drawing.Size(127, 44)
        Me.btn_kakunin.TabIndex = 197
        Me.btn_kakunin.Text = "確認"
        Me.btn_kakunin.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 93)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1244, 863)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_kensakukekka.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_kensakukekka.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1234, 839)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group2
        '
        Me.Group2.Controls.Add(Me.btn_clear_hi)
        Me.Group2.Controls.Add(Me.Label1)
        Me.Group2.Controls.Add(Me.cbx_hi)
        Me.Group2.Controls.Add(Me.Label7)
        Me.Group2.Controls.Add(Me.cbx_tsuki)
        Me.Group2.Controls.Add(Me.Label8)
        Me.Group2.Controls.Add(Me.cbx_nen)
        Me.Group2.Location = New System.Drawing.Point(17, 26)
        Me.Group2.Name = "Group2"
        Me.Group2.Size = New System.Drawing.Size(362, 61)
        Me.Group2.TabIndex = 192
        Me.Group2.TabStop = False
        Me.Group2.Text = "抽出期間"
        '
        'btn_clear_hi
        '
        Me.btn_clear_hi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_hi.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_hi.Location = New System.Drawing.Point(299, 21)
        Me.btn_clear_hi.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_hi.Name = "btn_clear_hi"
        Me.btn_clear_hi.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_hi.TabIndex = 131
        Me.btn_clear_hi.Text = "クリア"
        Me.btn_clear_hi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "日"
        '
        'cbx_hi
        '
        Me.cbx_hi.BackColor = System.Drawing.Color.White
        Me.cbx_hi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_hi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_hi.FormattingEnabled = True
        Me.cbx_hi.Location = New System.Drawing.Point(213, 24)
        Me.cbx_hi.Name = "cbx_hi"
        Me.cbx_hi.Size = New System.Drawing.Size(53, 23)
        Me.cbx_hi.TabIndex = 136
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "月"
        '
        'cbx_tsuki
        '
        Me.cbx_tsuki.BackColor = System.Drawing.Color.White
        Me.cbx_tsuki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tsuki.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tsuki.FormattingEnabled = True
        Me.cbx_tsuki.Location = New System.Drawing.Point(123, 24)
        Me.cbx_tsuki.Name = "cbx_tsuki"
        Me.cbx_tsuki.Size = New System.Drawing.Size(53, 23)
        Me.cbx_tsuki.TabIndex = 134
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 15)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "年"
        '
        'cbx_nen
        '
        Me.cbx_nen.BackColor = System.Drawing.Color.White
        Me.cbx_nen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nen.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_nen.FormattingEnabled = True
        Me.cbx_nen.Location = New System.Drawing.Point(19, 24)
        Me.cbx_nen.Name = "cbx_nen"
        Me.cbx_nen.Size = New System.Drawing.Size(69, 23)
        Me.cbx_nen.TabIndex = 132
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(872, 37)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.cbx_shain)
        Me.Group1.Controls.Add(Me.btn_clear_shain)
        Me.Group1.Location = New System.Drawing.Point(385, 26)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(271, 61)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        Me.Group1.Text = "社員"
        '
        'cbx_shain
        '
        Me.cbx_shain.BackColor = System.Drawing.Color.White
        Me.cbx_shain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shain.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shain.FormattingEnabled = True
        Me.cbx_shain.Location = New System.Drawing.Point(18, 23)
        Me.cbx_shain.Name = "cbx_shain"
        Me.cbx_shain.Size = New System.Drawing.Size(183, 24)
        Me.cbx_shain.TabIndex = 130
        '
        'btn_clear_shain
        '
        Me.btn_clear_shain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_shain.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_shain.Location = New System.Drawing.Point(206, 21)
        Me.btn_clear_shain.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_shain.Name = "btn_clear_shain"
        Me.btn_clear_shain.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_shain.TabIndex = 34
        Me.btn_clear_shain.Text = "クリア"
        Me.btn_clear_shain.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1134, 37)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmnyuukin_rireki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmnyuukin_rireki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "入金履歴"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_hyouji_shinai As CheckBox
    Friend WithEvents btn_kakunin As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group2 As GroupBox
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents btn_clear_shain As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_hi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
    Friend WithEvents cbx_shain As ComboBox
    Friend WithEvents btn_clear_hi As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_goukeigaku As Label
    Friend WithEvents lbl_kensuu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
