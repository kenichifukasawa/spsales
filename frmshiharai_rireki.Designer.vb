<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiharai_rireki
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
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbn_shubetsu_gyousha = New System.Windows.Forms.RadioButton()
        Me.rbn_shubetsu_shiharai_tsuki = New System.Windows.Forms.RadioButton()
        Me.gbx_shiharai_tsuki = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.gbx_gyousha = New System.Windows.Forms.GroupBox()
        Me.cbx_gyousha = New System.Windows.Forms.ComboBox()
        Me.chk_hyouji_subete_gyousha = New System.Windows.Forms.CheckBox()
        Me.btn_clear_gyousha = New System.Windows.Forms.Button()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.chk_sakujo = New System.Windows.Forms.CheckBox()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_shiharai_tsuki.SuspendLayout()
        Me.gbx_gyousha.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.chk_sakujo)
        Me.gbx_main.Controls.Add(Me.btn_shousai)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_sakujo)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1025, 971)
        Me.gbx_main.TabIndex = 57
        Me.gbx_main.TabStop = False
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shousai.Location = New System.Drawing.Point(749, 81)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 201
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbn_shubetsu_gyousha)
        Me.GroupBox1.Controls.Add(Me.rbn_shubetsu_shiharai_tsuki)
        Me.GroupBox1.Controls.Add(Me.gbx_shiharai_tsuki)
        Me.GroupBox1.Controls.Add(Me.gbx_gyousha)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 111)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        '
        'rbn_shubetsu_gyousha
        '
        Me.rbn_shubetsu_gyousha.AutoSize = True
        Me.rbn_shubetsu_gyousha.Location = New System.Drawing.Point(243, 21)
        Me.rbn_shubetsu_gyousha.Name = "rbn_shubetsu_gyousha"
        Me.rbn_shubetsu_gyousha.Size = New System.Drawing.Size(95, 18)
        Me.rbn_shubetsu_gyousha.TabIndex = 201
        Me.rbn_shubetsu_gyousha.Text = "仕入業者別"
        Me.rbn_shubetsu_gyousha.UseVisualStyleBackColor = True
        '
        'rbn_shubetsu_shiharai_tsuki
        '
        Me.rbn_shubetsu_shiharai_tsuki.AutoSize = True
        Me.rbn_shubetsu_shiharai_tsuki.Checked = True
        Me.rbn_shubetsu_shiharai_tsuki.Location = New System.Drawing.Point(25, 21)
        Me.rbn_shubetsu_shiharai_tsuki.Name = "rbn_shubetsu_shiharai_tsuki"
        Me.rbn_shubetsu_shiharai_tsuki.Size = New System.Drawing.Size(81, 18)
        Me.rbn_shubetsu_shiharai_tsuki.TabIndex = 200
        Me.rbn_shubetsu_shiharai_tsuki.TabStop = True
        Me.rbn_shubetsu_shiharai_tsuki.Text = "支払月別"
        Me.rbn_shubetsu_shiharai_tsuki.UseVisualStyleBackColor = True
        '
        'gbx_shiharai_tsuki
        '
        Me.gbx_shiharai_tsuki.Controls.Add(Me.Label7)
        Me.gbx_shiharai_tsuki.Controls.Add(Me.cbx_tsuki)
        Me.gbx_shiharai_tsuki.Controls.Add(Me.Label8)
        Me.gbx_shiharai_tsuki.Controls.Add(Me.cbx_nen)
        Me.gbx_shiharai_tsuki.Location = New System.Drawing.Point(6, 45)
        Me.gbx_shiharai_tsuki.Name = "gbx_shiharai_tsuki"
        Me.gbx_shiharai_tsuki.Size = New System.Drawing.Size(215, 61)
        Me.gbx_shiharai_tsuki.TabIndex = 192
        Me.gbx_shiharai_tsuki.TabStop = False
        Me.gbx_shiharai_tsuki.Text = "抽出期間"
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
        'gbx_gyousha
        '
        Me.gbx_gyousha.Controls.Add(Me.cbx_gyousha)
        Me.gbx_gyousha.Controls.Add(Me.chk_hyouji_subete_gyousha)
        Me.gbx_gyousha.Controls.Add(Me.btn_clear_gyousha)
        Me.gbx_gyousha.Enabled = False
        Me.gbx_gyousha.Location = New System.Drawing.Point(227, 45)
        Me.gbx_gyousha.Name = "gbx_gyousha"
        Me.gbx_gyousha.Size = New System.Drawing.Size(493, 61)
        Me.gbx_gyousha.TabIndex = 199
        Me.gbx_gyousha.TabStop = False
        Me.gbx_gyousha.Text = "業者"
        '
        'cbx_gyousha
        '
        Me.cbx_gyousha.BackColor = System.Drawing.Color.White
        Me.cbx_gyousha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gyousha.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_gyousha.FormattingEnabled = True
        Me.cbx_gyousha.Location = New System.Drawing.Point(16, 24)
        Me.cbx_gyousha.Name = "cbx_gyousha"
        Me.cbx_gyousha.Size = New System.Drawing.Size(408, 24)
        Me.cbx_gyousha.TabIndex = 128
        '
        'chk_hyouji_subete_gyousha
        '
        Me.chk_hyouji_subete_gyousha.AutoSize = True
        Me.chk_hyouji_subete_gyousha.Checked = True
        Me.chk_hyouji_subete_gyousha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_hyouji_subete_gyousha.Location = New System.Drawing.Point(223, 3)
        Me.chk_hyouji_subete_gyousha.Name = "chk_hyouji_subete_gyousha"
        Me.chk_hyouji_subete_gyousha.Size = New System.Drawing.Size(161, 18)
        Me.chk_hyouji_subete_gyousha.TabIndex = 198
        Me.chk_hyouji_subete_gyousha.Text = "すべての業者を表示する"
        Me.chk_hyouji_subete_gyousha.UseVisualStyleBackColor = True
        '
        'btn_clear_gyousha
        '
        Me.btn_clear_gyousha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_gyousha.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_gyousha.Location = New System.Drawing.Point(429, 21)
        Me.btn_clear_gyousha.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_gyousha.Name = "btn_clear_gyousha"
        Me.btn_clear_gyousha.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_gyousha.TabIndex = 34
        Me.btn_clear_gyousha.Text = "クリア"
        Me.btn_clear_gyousha.UseVisualStyleBackColor = True
        '
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_sakujo.Location = New System.Drawing.Point(880, 33)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 197
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 136)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(990, 806)
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
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(980, 782)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(749, 33)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(880, 81)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'chk_sakujo
        '
        Me.chk_sakujo.AutoSize = True
        Me.chk_sakujo.Location = New System.Drawing.Point(930, 948)
        Me.chk_sakujo.Name = "chk_sakujo"
        Me.chk_sakujo.Size = New System.Drawing.Size(77, 18)
        Me.chk_sakujo.TabIndex = 202
        Me.chk_sakujo.Text = "削除する"
        Me.chk_sakujo.UseVisualStyleBackColor = True
        '
        'frmshiharai_rireki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshiharai_rireki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "支払履歴"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbx_shiharai_tsuki.ResumeLayout(False)
        Me.gbx_shiharai_tsuki.PerformLayout()
        Me.gbx_gyousha.ResumeLayout(False)
        Me.gbx_gyousha.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_hyouji_subete_gyousha As CheckBox
    Friend WithEvents btn_sakujo As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents gbx_shiharai_tsuki As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents gbx_gyousha As GroupBox
    Friend WithEvents cbx_gyousha As ComboBox
    Friend WithEvents btn_clear_gyousha As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbn_shubetsu_gyousha As RadioButton
    Friend WithEvents rbn_shubetsu_shiharai_tsuki As RadioButton
    Friend WithEvents btn_shousai As Button
    Friend WithEvents chk_sakujo As CheckBox
End Class
