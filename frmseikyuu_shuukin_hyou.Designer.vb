<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuu_shuukin_hyou
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
        Me.gbx_main = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_kingaku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shain = New System.Windows.Forms.ComboBox()
        Me.btn_clear_shain = New System.Windows.Forms.Button()
        Me.btn_insatsu = New System.Windows.Forms.Button()
        Me.gbx_shiharai_tsuki = New System.Windows.Forms.GroupBox()
        Me.cbx_shimebi = New System.Windows.Forms.ComboBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.gbx_shiharai_tsuki.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(637, 971)
        Me.gbx_main.TabIndex = 59
        Me.gbx_main.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.Group1)
        Me.GroupBox1.Controls.Add(Me.btn_insatsu)
        Me.GroupBox1.Controls.Add(Me.gbx_shiharai_tsuki)
        Me.GroupBox1.Controls.Add(Me.btn_modoru)
        Me.GroupBox1.Controls.Add(Me.btn_shuukei)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 158)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_kingaku)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(156, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(146, 61)
        Me.GroupBox7.TabIndex = 207
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "合計金額"
        '
        'lbl_kingaku
        '
        Me.lbl_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kingaku.Location = New System.Drawing.Point(6, 24)
        Me.lbl_kingaku.Name = "lbl_kingaku"
        Me.lbl_kingaku.Size = New System.Drawing.Size(107, 23)
        Me.lbl_kingaku.TabIndex = 190
        Me.lbl_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(117, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "円"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.cbx_shain)
        Me.Group1.Controls.Add(Me.btn_clear_shain)
        Me.Group1.Location = New System.Drawing.Point(6, 87)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(296, 61)
        Me.Group1.TabIndex = 195
        Me.Group1.TabStop = False
        Me.Group1.Text = "店舗担当社員"
        '
        'cbx_shain
        '
        Me.cbx_shain.BackColor = System.Drawing.Color.White
        Me.cbx_shain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shain.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shain.FormattingEnabled = True
        Me.cbx_shain.Location = New System.Drawing.Point(32, 23)
        Me.cbx_shain.Name = "cbx_shain"
        Me.cbx_shain.Size = New System.Drawing.Size(183, 24)
        Me.cbx_shain.TabIndex = 130
        '
        'btn_clear_shain
        '
        Me.btn_clear_shain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_shain.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_shain.Location = New System.Drawing.Point(220, 20)
        Me.btn_clear_shain.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_shain.Name = "btn_clear_shain"
        Me.btn_clear_shain.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_shain.TabIndex = 34
        Me.btn_clear_shain.Text = "クリア"
        Me.btn_clear_shain.UseVisualStyleBackColor = True
        '
        'btn_insatsu
        '
        Me.btn_insatsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insatsu.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_insatsu.Location = New System.Drawing.Point(307, 99)
        Me.btn_insatsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insatsu.Name = "btn_insatsu"
        Me.btn_insatsu.Size = New System.Drawing.Size(127, 44)
        Me.btn_insatsu.TabIndex = 203
        Me.btn_insatsu.Text = "印刷"
        Me.btn_insatsu.UseVisualStyleBackColor = True
        '
        'gbx_shiharai_tsuki
        '
        Me.gbx_shiharai_tsuki.Controls.Add(Me.cbx_shimebi)
        Me.gbx_shiharai_tsuki.Location = New System.Drawing.Point(6, 20)
        Me.gbx_shiharai_tsuki.Name = "gbx_shiharai_tsuki"
        Me.gbx_shiharai_tsuki.Size = New System.Drawing.Size(144, 61)
        Me.gbx_shiharai_tsuki.TabIndex = 192
        Me.gbx_shiharai_tsuki.TabStop = False
        Me.gbx_shiharai_tsuki.Text = "〆日"
        '
        'cbx_shimebi
        '
        Me.cbx_shimebi.BackColor = System.Drawing.Color.White
        Me.cbx_shimebi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shimebi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shimebi.FormattingEnabled = True
        Me.cbx_shimebi.Location = New System.Drawing.Point(26, 24)
        Me.cbx_shimebi.Name = "cbx_shimebi"
        Me.cbx_shimebi.Size = New System.Drawing.Size(93, 23)
        Me.cbx_shimebi.TabIndex = 132
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(452, 34)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shuukei.Location = New System.Drawing.Point(307, 34)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 183)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(604, 771)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(594, 747)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'frmseikyuu_shuukin_hyou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmseikyuu_shuukin_hyou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集金表"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.Group1.ResumeLayout(False)
        Me.gbx_shiharai_tsuki.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_insatsu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbx_shiharai_tsuki As GroupBox
    Friend WithEvents cbx_shimebi As ComboBox
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents btn_modoru As Button
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents cbx_shain As ComboBox
    Friend WithEvents btn_clear_shain As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_kingaku As Label
    Friend WithEvents Label2 As Label
End Class
