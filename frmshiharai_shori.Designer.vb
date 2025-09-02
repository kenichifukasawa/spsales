<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmshiharai_shori
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka_shiharai = New System.Windows.Forms.DataGridView()
        Me.grp_nyuukin_denpyou = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_shiharai_kijitsu = New System.Windows.Forms.DateTimePicker()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.cbx_gyousha = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_shiire_shousai = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_goukei_kingaku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_shiharai_bi = New System.Windows.Forms.DateTimePicker()
        Me.btn_touroku = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_bikou = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kingaku = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.cbx_shiharai_houhou = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka_shiire = New System.Windows.Forms.DataGridView()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_shiharai_shousai = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgv_kensakukekka_shiharai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_nyuukin_denpyou.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka_shiire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dgv_kensakukekka_shiharai)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(708, 900)
        Me.GroupBox8.TabIndex = 202
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "支払伝票一覧"
        '
        'dgv_kensakukekka_shiharai
        '
        Me.dgv_kensakukekka_shiharai.AllowUserToAddRows = False
        Me.dgv_kensakukekka_shiharai.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka_shiharai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka_shiharai.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka_shiharai.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka_shiharai.Name = "dgv_kensakukekka_shiharai"
        Me.dgv_kensakukekka_shiharai.ReadOnly = True
        Me.dgv_kensakukekka_shiharai.RowTemplate.Height = 24
        Me.dgv_kensakukekka_shiharai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka_shiharai.Size = New System.Drawing.Size(698, 876)
        Me.dgv_kensakukekka_shiharai.TabIndex = 192
        '
        'grp_nyuukin_denpyou
        '
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox2)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.grp_kikan_shitei)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.btn_shiire_shousai)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox7)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox1)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.btn_touroku)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox5)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox4)
        Me.grp_nyuukin_denpyou.Controls.Add(Me.GroupBox13)
        Me.grp_nyuukin_denpyou.Location = New System.Drawing.Point(6, 21)
        Me.grp_nyuukin_denpyou.Name = "grp_nyuukin_denpyou"
        Me.grp_nyuukin_denpyou.Size = New System.Drawing.Size(691, 226)
        Me.grp_nyuukin_denpyou.TabIndex = 193
        Me.grp_nyuukin_denpyou.TabStop = False
        Me.grp_nyuukin_denpyou.Text = "支払伝票登録"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.dtp_shiharai_kijitsu)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(211, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 60)
        Me.GroupBox2.TabIndex = 261
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "支払期日"
        '
        'dtp_shiharai_kijitsu
        '
        Me.dtp_shiharai_kijitsu.Checked = False
        Me.dtp_shiharai_kijitsu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_shiharai_kijitsu.Location = New System.Drawing.Point(19, 24)
        Me.dtp_shiharai_kijitsu.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_shiharai_kijitsu.Name = "dtp_shiharai_kijitsu"
        Me.dtp_shiharai_kijitsu.ShowCheckBox = True
        Me.dtp_shiharai_kijitsu.Size = New System.Drawing.Size(153, 23)
        Me.dtp_shiharai_kijitsu.TabIndex = 260
        Me.dtp_shiharai_kijitsu.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_gyousha)
        Me.grp_kikan_shitei.Controls.Add(Me.btn_clear)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(13, 21)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(529, 61)
        Me.grp_kikan_shitei.TabIndex = 211
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "支払先の業者"
        '
        'cbx_gyousha
        '
        Me.cbx_gyousha.BackColor = System.Drawing.Color.White
        Me.cbx_gyousha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gyousha.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_gyousha.FormattingEnabled = True
        Me.cbx_gyousha.Location = New System.Drawing.Point(35, 24)
        Me.cbx_gyousha.Name = "cbx_gyousha"
        Me.cbx_gyousha.Size = New System.Drawing.Size(408, 24)
        Me.cbx_gyousha.TabIndex = 128
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(448, 21)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear.TabIndex = 34
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_shiire_shousai
        '
        Me.btn_shiire_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shiire_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shiire_shousai.Location = New System.Drawing.Point(554, 165)
        Me.btn_shiire_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shiire_shousai.Name = "btn_shiire_shousai"
        Me.btn_shiire_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shiire_shousai.TabIndex = 203
        Me.btn_shiire_shousai.Text = "詳細"
        Me.btn_shiire_shousai.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_goukei_kingaku)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(383, 154)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(159, 60)
        Me.GroupBox7.TabIndex = 210
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "選択した伝票の合計"
        '
        'lbl_goukei_kingaku
        '
        Me.lbl_goukei_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_goukei_kingaku.Location = New System.Drawing.Point(12, 24)
        Me.lbl_goukei_kingaku.Name = "lbl_goukei_kingaku"
        Me.lbl_goukei_kingaku.Size = New System.Drawing.Size(107, 23)
        Me.lbl_goukei_kingaku.TabIndex = 190
        Me.lbl_goukei_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(123, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "円"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtp_shiharai_bi)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 60)
        Me.GroupBox1.TabIndex = 204
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "支払日"
        '
        'dtp_shiharai_bi
        '
        Me.dtp_shiharai_bi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_shiharai_bi.Location = New System.Drawing.Point(20, 24)
        Me.dtp_shiharai_bi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_shiharai_bi.Name = "dtp_shiharai_bi"
        Me.dtp_shiharai_bi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_shiharai_bi.TabIndex = 260
        Me.dtp_shiharai_bi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'btn_touroku
        '
        Me.btn_touroku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_touroku.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_touroku.Location = New System.Drawing.Point(554, 99)
        Me.btn_touroku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_touroku.Name = "btn_touroku"
        Me.btn_touroku.Size = New System.Drawing.Size(127, 44)
        Me.btn_touroku.TabIndex = 203
        Me.btn_touroku.Text = "登録"
        Me.btn_touroku.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txt_bikou)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(180, 154)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(197, 60)
        Me.GroupBox5.TabIndex = 206
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "備考"
        '
        'txt_bikou
        '
        Me.txt_bikou.BackColor = System.Drawing.Color.White
        Me.txt_bikou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_bikou.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_bikou.Location = New System.Drawing.Point(21, 24)
        Me.txt_bikou.MaxLength = 10
        Me.txt_bikou.Name = "txt_bikou"
        Me.txt_bikou.Size = New System.Drawing.Size(153, 22)
        Me.txt_bikou.TabIndex = 187
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_kingaku)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(162, 60)
        Me.GroupBox4.TabIndex = 204
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "支払金額"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(127, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 23)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "円"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_kingaku
        '
        Me.txt_kingaku.BackColor = System.Drawing.Color.White
        Me.txt_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_kingaku.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_kingaku.Location = New System.Drawing.Point(19, 24)
        Me.txt_kingaku.MaxLength = 10
        Me.txt_kingaku.Name = "txt_kingaku"
        Me.txt_kingaku.Size = New System.Drawing.Size(102, 22)
        Me.txt_kingaku.TabIndex = 187
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(Me.cbx_shiharai_houhou)
        Me.GroupBox13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(409, 88)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(133, 60)
        Me.GroupBox13.TabIndex = 203
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "支払方法"
        '
        'cbx_shiharai_houhou
        '
        Me.cbx_shiharai_houhou.BackColor = System.Drawing.Color.White
        Me.cbx_shiharai_houhou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shiharai_houhou.FormattingEnabled = True
        Me.cbx_shiharai_houhou.Location = New System.Drawing.Point(19, 23)
        Me.cbx_shiharai_houhou.Name = "cbx_shiharai_houhou"
        Me.cbx_shiharai_houhou.Size = New System.Drawing.Size(94, 23)
        Me.cbx_shiharai_houhou.TabIndex = 194
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka_shiire)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 253)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(691, 711)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "仕入伝票一覧"
        '
        'dgv_kensakukekka_shiire
        '
        Me.dgv_kensakukekka_shiire.AllowUserToAddRows = False
        Me.dgv_kensakukekka_shiire.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka_shiire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka_shiire.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka_shiire.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka_shiire.Name = "dgv_kensakukekka_shiire"
        Me.dgv_kensakukekka_shiire.ReadOnly = True
        Me.dgv_kensakukekka_shiire.RowTemplate.Height = 24
        Me.dgv_kensakukekka_shiire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka_shiire.Size = New System.Drawing.Size(681, 687)
        Me.dgv_kensakukekka_shiire.TabIndex = 192
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(576, 18)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btn_shiharai_shousai)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.btn_modoru)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(721, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 970)
        Me.GroupBox3.TabIndex = 203
        Me.GroupBox3.TabStop = False
        '
        'btn_shiharai_shousai
        '
        Me.btn_shiharai_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shiharai_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shiharai_shousai.Location = New System.Drawing.Point(445, 18)
        Me.btn_shiharai_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shiharai_shousai.Name = "btn_shiharai_shousai"
        Me.btn_shiharai_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shiharai_shousai.TabIndex = 262
        Me.btn_shiharai_shousai.Text = "詳細"
        Me.btn_shiharai_shousai.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.grp_nyuukin_denpyou)
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(703, 970)
        Me.GroupBox9.TabIndex = 204
        Me.GroupBox9.TabStop = False
        '
        'frmshiharai_shori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox9)
        Me.Name = "frmshiharai_shori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "支払処理"
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgv_kensakukekka_shiharai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_nyuukin_denpyou.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka_shiire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents dgv_kensakukekka_shiharai As DataGridView
    Friend WithEvents grp_nyuukin_denpyou As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_shiharai_bi As DateTimePicker
    Friend WithEvents btn_touroku As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txt_bikou As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kingaku As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents cbx_shiharai_houhou As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka_shiire As DataGridView
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_shiire_shousai As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_goukei_kingaku As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents cbx_gyousha As ComboBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_shiharai_kijitsu As DateTimePicker
    Friend WithEvents btn_shiharai_shousai As Button
End Class
