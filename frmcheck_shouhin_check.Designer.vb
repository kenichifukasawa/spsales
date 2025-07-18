<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheck_shouhin_check
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hinichi_kaishi = New System.Windows.Forms.DateTimePicker()
        Me.btn_kensaku = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbx_shitei_shouhin = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_mishiyou_hihyouji = New System.Windows.Forms.CheckBox()
        Me.cbx_shouhin_kubun_2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shouhin_kubun_1 = New System.Windows.Forms.ComboBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_shinkou_joukyou = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_shinkou_percent = New System.Windows.Forms.Label()
        Me.pgb_shinkou_joukyou = New System.Windows.Forms.ProgressBar()
        Me.lbl_shinkou_doai = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_shinkou_joukyou.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.btn_kensaku)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox4)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 12)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(811, 971)
        Me.gbx_main.TabIndex = 55
        Me.gbx_main.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_check)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_kaishi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(469, 75)
        Me.GroupBox3.TabIndex = 193
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "登録済みの納品書を基に移動記録が正確に記録されているかをチェックします。"
        '
        'btn_check
        '
        Me.btn_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_check.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_check.Location = New System.Drawing.Point(323, 22)
        Me.btn_check.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(127, 44)
        Me.btn_check.TabIndex = 194
        Me.btn_check.Text = "チェック"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "以降のデータについて"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_hinichi_kaishi
        '
        Me.dtp_hinichi_kaishi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_kaishi.Location = New System.Drawing.Point(19, 34)
        Me.dtp_hinichi_kaishi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_kaishi.Name = "dtp_hinichi_kaishi"
        Me.dtp_hinichi_kaishi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_kaishi.TabIndex = 263
        Me.dtp_hinichi_kaishi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'btn_kensaku
        '
        Me.btn_kensaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kensaku.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kensaku.Location = New System.Drawing.Point(510, 175)
        Me.btn_kensaku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kensaku.Name = "btn_kensaku"
        Me.btn_kensaku.Size = New System.Drawing.Size(127, 44)
        Me.btn_kensaku.TabIndex = 197
        Me.btn_kensaku.Text = "検索"
        Me.btn_kensaku.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 234)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(778, 717)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(6, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(766, 693)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbx_shitei_shouhin)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(660, 61)
        Me.GroupBox4.TabIndex = 192
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "指定商品"
        '
        'cbx_shitei_shouhin
        '
        Me.cbx_shitei_shouhin.BackColor = System.Drawing.Color.White
        Me.cbx_shitei_shouhin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shitei_shouhin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shitei_shouhin.FormattingEnabled = True
        Me.cbx_shitei_shouhin.Location = New System.Drawing.Point(19, 24)
        Me.cbx_shitei_shouhin.Name = "cbx_shitei_shouhin"
        Me.cbx_shitei_shouhin.Size = New System.Drawing.Size(619, 24)
        Me.cbx_shitei_shouhin.TabIndex = 128
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_mishiyou_hihyouji)
        Me.GroupBox2.Controls.Add(Me.cbx_shouhin_kubun_2)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "商品選択区分２"
        '
        'chk_mishiyou_hihyouji
        '
        Me.chk_mishiyou_hihyouji.AutoSize = True
        Me.chk_mishiyou_hihyouji.Checked = True
        Me.chk_mishiyou_hihyouji.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mishiyou_hihyouji.Location = New System.Drawing.Point(112, -1)
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
        Me.btn_modoru.Location = New System.Drawing.Point(662, 175)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'gbx_shinkou_joukyou
        '
        Me.gbx_shinkou_joukyou.BackColor = System.Drawing.Color.LightCyan
        Me.gbx_shinkou_joukyou.Controls.Add(Me.GroupBox5)
        Me.gbx_shinkou_joukyou.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_shinkou_joukyou.Location = New System.Drawing.Point(886, 25)
        Me.gbx_shinkou_joukyou.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Name = "gbx_shinkou_joukyou"
        Me.gbx_shinkou_joukyou.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Size = New System.Drawing.Size(307, 121)
        Me.gbx_shinkou_joukyou.TabIndex = 223
        Me.gbx_shinkou_joukyou.TabStop = False
        Me.gbx_shinkou_joukyou.Text = "進行状況"
        Me.gbx_shinkou_joukyou.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lbl_shinkou_percent)
        Me.GroupBox5.Controls.Add(Me.pgb_shinkou_joukyou)
        Me.GroupBox5.Controls.Add(Me.lbl_shinkou_doai)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(267, 82)
        Me.GroupBox5.TabIndex = 222
        Me.GroupBox5.TabStop = False
        '
        'lbl_shinkou_percent
        '
        Me.lbl_shinkou_percent.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shinkou_percent.Location = New System.Drawing.Point(20, 12)
        Me.lbl_shinkou_percent.Name = "lbl_shinkou_percent"
        Me.lbl_shinkou_percent.Size = New System.Drawing.Size(228, 15)
        Me.lbl_shinkou_percent.TabIndex = 126
        Me.lbl_shinkou_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgb_shinkou_joukyou
        '
        Me.pgb_shinkou_joukyou.Location = New System.Drawing.Point(20, 30)
        Me.pgb_shinkou_joukyou.Name = "pgb_shinkou_joukyou"
        Me.pgb_shinkou_joukyou.Size = New System.Drawing.Size(228, 23)
        Me.pgb_shinkou_joukyou.TabIndex = 0
        '
        'lbl_shinkou_doai
        '
        Me.lbl_shinkou_doai.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shinkou_doai.Location = New System.Drawing.Point(20, 56)
        Me.lbl_shinkou_doai.Name = "lbl_shinkou_doai"
        Me.lbl_shinkou_doai.Size = New System.Drawing.Size(228, 15)
        Me.lbl_shinkou_doai.TabIndex = 125
        Me.lbl_shinkou_doai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmcheck_shouhin_check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_shinkou_joukyou)
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmcheck_shouhin_check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品推移チェック"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_shinkou_joukyou.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_kensaku As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbx_shitei_shouhin As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_mishiyou_hihyouji As CheckBox
    Friend WithEvents cbx_shouhin_kubun_2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_1 As ComboBox
    Friend WithEvents btn_check As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtp_hinichi_kaishi As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents gbx_shinkou_joukyou As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_shinkou_percent As Label
    Friend WithEvents pgb_shinkou_joukyou As ProgressBar
    Friend WithEvents lbl_shinkou_doai As Label
End Class
