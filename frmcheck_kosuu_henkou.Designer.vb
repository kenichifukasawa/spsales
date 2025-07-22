<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheck_kosuu_henkou
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbx_main = New System.Windows.Forms.GroupBox()
        Me.txt_kaishi_tsuki_hi = New System.Windows.Forms.TextBox()
        Me.chk_kouryo = New System.Windows.Forms.CheckBox()
        Me.btn_hozon = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_mishiyou_hihyouji = New System.Windows.Forms.CheckBox()
        Me.cbx_shouhin_kubun_2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shouhin_kubun_1 = New System.Windows.Forms.ComboBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_shuuryou_hinichi = New System.Windows.Forms.Label()
        Me.lbl_kaishi_nen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.btn_hozon)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(12, 12)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1436, 971)
        Me.gbx_main.TabIndex = 56
        Me.gbx_main.TabStop = False
        '
        'txt_kaishi_tsuki_hi
        '
        Me.txt_kaishi_tsuki_hi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_kaishi_tsuki_hi.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_kaishi_tsuki_hi.Location = New System.Drawing.Point(363, 24)
        Me.txt_kaishi_tsuki_hi.MaxLength = 5
        Me.txt_kaishi_tsuki_hi.Name = "txt_kaishi_tsuki_hi"
        Me.txt_kaishi_tsuki_hi.Size = New System.Drawing.Size(69, 23)
        Me.txt_kaishi_tsuki_hi.TabIndex = 198
        Me.txt_kaishi_tsuki_hi.Text = "05/20"
        '
        'chk_kouryo
        '
        Me.chk_kouryo.AutoSize = True
        Me.chk_kouryo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_kouryo.Location = New System.Drawing.Point(19, 26)
        Me.chk_kouryo.Name = "chk_kouryo"
        Me.chk_kouryo.Size = New System.Drawing.Size(251, 19)
        Me.chk_kouryo.TabIndex = 196
        Me.chk_kouryo.Text = "右の日以降も考慮（なければ 02/01）"
        Me.chk_kouryo.UseVisualStyleBackColor = True
        '
        'btn_hozon
        '
        Me.btn_hozon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hozon.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hozon.Location = New System.Drawing.Point(1161, 33)
        Me.btn_hozon.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hozon.Name = "btn_hozon"
        Me.btn_hozon.Size = New System.Drawing.Size(127, 44)
        Me.btn_hozon.TabIndex = 197
        Me.btn_hozon.Text = "保存"
        Me.btn_hozon.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 86)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1402, 868)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_kensakukekka.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_kensakukekka.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(6, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1391, 844)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.chk_mishiyou_hihyouji)
        Me.GroupBox2.Controls.Add(Me.cbx_shouhin_kubun_2)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 61)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "商品選択区分２"
        '
        'chk_mishiyou_hihyouji
        '
        Me.chk_mishiyou_hihyouji.AutoSize = True
        Me.chk_mishiyou_hihyouji.Checked = True
        Me.chk_mishiyou_hihyouji.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mishiyou_hihyouji.Location = New System.Drawing.Point(141, 0)
        Me.chk_mishiyou_hihyouji.Name = "chk_mishiyou_hihyouji"
        Me.chk_mishiyou_hihyouji.Size = New System.Drawing.Size(149, 18)
        Me.chk_mishiyou_hihyouji.TabIndex = 195
        Me.chk_mishiyou_hihyouji.Text = "未使用商品を非表示"
        Me.chk_mishiyou_hihyouji.UseVisualStyleBackColor = True
        '
        'cbx_shouhin_kubun_2
        '
        Me.cbx_shouhin_kubun_2.BackColor = System.Drawing.Color.White
        Me.cbx_shouhin_kubun_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shouhin_kubun_2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shouhin_kubun_2.FormattingEnabled = True
        Me.cbx_shouhin_kubun_2.Location = New System.Drawing.Point(19, 24)
        Me.cbx_shouhin_kubun_2.Name = "cbx_shouhin_kubun_2"
        Me.cbx_shouhin_kubun_2.Size = New System.Drawing.Size(217, 24)
        Me.cbx_shouhin_kubun_2.TabIndex = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbx_shouhin_kubun_1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "商品選択区分１"
        '
        'cbx_shouhin_kubun_1
        '
        Me.cbx_shouhin_kubun_1.BackColor = System.Drawing.Color.White
        Me.cbx_shouhin_kubun_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shouhin_kubun_1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shouhin_kubun_1.FormattingEnabled = True
        Me.cbx_shouhin_kubun_1.Location = New System.Drawing.Point(19, 24)
        Me.cbx_shouhin_kubun_1.Name = "cbx_shouhin_kubun_1"
        Me.cbx_shouhin_kubun_1.Size = New System.Drawing.Size(217, 24)
        Me.cbx_shouhin_kubun_1.TabIndex = 128
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1292, 33)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(241, 20)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(49, 32)
        Me.btn_clear.TabIndex = 199
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lbl_kaishi_nen)
        Me.GroupBox3.Controls.Add(Me.lbl_shuuryou_hinichi)
        Me.GroupBox3.Controls.Add(Me.chk_kouryo)
        Me.GroupBox3.Controls.Add(Me.txt_kaishi_tsuki_hi)
        Me.GroupBox3.Location = New System.Drawing.Point(595, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 61)
        Me.GroupBox3.TabIndex = 193
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "期間"
        '
        'lbl_shuuryou_hinichi
        '
        Me.lbl_shuuryou_hinichi.AutoSize = True
        Me.lbl_shuuryou_hinichi.BackColor = System.Drawing.Color.White
        Me.lbl_shuuryou_hinichi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shuuryou_hinichi.Location = New System.Drawing.Point(459, 28)
        Me.lbl_shuuryou_hinichi.Name = "lbl_shuuryou_hinichi"
        Me.lbl_shuuryou_hinichi.Size = New System.Drawing.Size(88, 16)
        Me.lbl_shuuryou_hinichi.TabIndex = 263
        Me.lbl_shuuryou_hinichi.Text = "2025/07/18"
        Me.lbl_shuuryou_hinichi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_kaishi_nen
        '
        Me.lbl_kaishi_nen.AutoSize = True
        Me.lbl_kaishi_nen.BackColor = System.Drawing.Color.White
        Me.lbl_kaishi_nen.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kaishi_nen.Location = New System.Drawing.Point(312, 28)
        Me.lbl_kaishi_nen.Name = "lbl_kaishi_nen"
        Me.lbl_kaishi_nen.Size = New System.Drawing.Size(48, 16)
        Me.lbl_kaishi_nen.TabIndex = 264
        Me.lbl_kaishi_nen.Text = "2025/"
        Me.lbl_kaishi_nen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "～"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmcheck_kosuu_henkou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1465, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmcheck_kosuu_henkou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "現在個数簡易変更"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_hozon As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_mishiyou_hihyouji As CheckBox
    Friend WithEvents cbx_shouhin_kubun_2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_1 As ComboBox
    Friend WithEvents btn_modoru As Button
    Friend WithEvents chk_kouryo As CheckBox
    Friend WithEvents txt_kaishi_tsuki_hi As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_kaishi_nen As Label
    Friend WithEvents lbl_shuuryou_hinichi As Label
    Friend WithEvents Label1 As Label
End Class
