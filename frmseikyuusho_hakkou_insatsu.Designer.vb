<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuusho_hakkou_insatsu
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
        Me.chk_houkokuyou = New System.Windows.Forms.CheckBox()
        Me.chk_insatsu_shinai = New System.Windows.Forms.CheckBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_denwachou = New System.Windows.Forms.Button()
        Me.chk_mail = New System.Windows.Forms.CheckBox()
        Me.gbx_shiharai_tsuki = New System.Windows.Forms.GroupBox()
        Me.cbx_shimebi = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_hinichi = New System.Windows.Forms.DateTimePicker()
        Me.chk_lock = New System.Windows.Forms.CheckBox()
        Me.Group2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_hi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.chk_hi_hyouji = New System.Windows.Forms.CheckBox()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.btn_seikyuusho_sakusei = New System.Windows.Forms.Button()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_tenpo = New System.Windows.Forms.GroupBox()
        Me.btn_clear_tenpo = New System.Windows.Forms.Button()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chk_hihyouji_torihiki_nai = New System.Windows.Forms.CheckBox()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbx_shiharai_tsuki.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_tenpo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.chk_houkokuyou)
        Me.gbx_main.Controls.Add(Me.chk_insatsu_shinai)
        Me.gbx_main.Controls.Add(Me.btn_clear)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.btn_seikyuusho_sakusei)
        Me.gbx_main.Controls.Add(Me.btn_shousai)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1772, 971)
        Me.gbx_main.TabIndex = 58
        Me.gbx_main.TabStop = False
        '
        'chk_houkokuyou
        '
        Me.chk_houkokuyou.AutoSize = True
        Me.chk_houkokuyou.Location = New System.Drawing.Point(1005, 1)
        Me.chk_houkokuyou.Name = "chk_houkokuyou"
        Me.chk_houkokuyou.Size = New System.Drawing.Size(68, 18)
        Me.chk_houkokuyou.TabIndex = 209
        Me.chk_houkokuyou.Text = "報告用"
        Me.chk_houkokuyou.UseVisualStyleBackColor = True
        '
        'chk_insatsu_shinai
        '
        Me.chk_insatsu_shinai.AutoSize = True
        Me.chk_insatsu_shinai.Location = New System.Drawing.Point(900, 1)
        Me.chk_insatsu_shinai.Name = "chk_insatsu_shinai"
        Me.chk_insatsu_shinai.Size = New System.Drawing.Size(99, 18)
        Me.chk_insatsu_shinai.TabIndex = 208
        Me.chk_insatsu_shinai.Text = "印刷はしない"
        Me.chk_insatsu_shinai.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(1510, 19)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(127, 44)
        Me.btn_clear.TabIndex = 204
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbx_tenpo)
        Me.GroupBox2.Controls.Add(Me.btn_denwachou)
        Me.GroupBox2.Controls.Add(Me.chk_mail)
        Me.GroupBox2.Controls.Add(Me.gbx_shiharai_tsuki)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.chk_lock)
        Me.GroupBox2.Controls.Add(Me.Group2)
        Me.GroupBox2.Controls.Add(Me.chk_hi_hyouji)
        Me.GroupBox2.Controls.Add(Me.btn_shuukei)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1488, 206)
        Me.GroupBox2.TabIndex = 194
        Me.GroupBox2.TabStop = False
        '
        'btn_denwachou
        '
        Me.btn_denwachou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwachou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_denwachou.Location = New System.Drawing.Point(1356, 30)
        Me.btn_denwachou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwachou.Name = "btn_denwachou"
        Me.btn_denwachou.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwachou.TabIndex = 207
        Me.btn_denwachou.Text = "電話帳"
        Me.btn_denwachou.UseVisualStyleBackColor = True
        '
        'chk_mail
        '
        Me.chk_mail.AutoSize = True
        Me.chk_mail.Enabled = False
        Me.chk_mail.Location = New System.Drawing.Point(796, 54)
        Me.chk_mail.Name = "chk_mail"
        Me.chk_mail.Size = New System.Drawing.Size(122, 18)
        Me.chk_mail.TabIndex = 206
        Me.chk_mail.Text = "請求書をメールで"
        Me.chk_mail.UseVisualStyleBackColor = True
        '
        'gbx_shiharai_tsuki
        '
        Me.gbx_shiharai_tsuki.Controls.Add(Me.cbx_shimebi)
        Me.gbx_shiharai_tsuki.Location = New System.Drawing.Point(6, 20)
        Me.gbx_shiharai_tsuki.Name = "gbx_shiharai_tsuki"
        Me.gbx_shiharai_tsuki.Size = New System.Drawing.Size(130, 61)
        Me.gbx_shiharai_tsuki.TabIndex = 204
        Me.gbx_shiharai_tsuki.TabStop = False
        Me.gbx_shiharai_tsuki.Text = "〆日"
        '
        'cbx_shimebi
        '
        Me.cbx_shimebi.BackColor = System.Drawing.Color.White
        Me.cbx_shimebi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shimebi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shimebi.FormattingEnabled = True
        Me.cbx_shimebi.Location = New System.Drawing.Point(18, 24)
        Me.cbx_shimebi.Name = "cbx_shimebi"
        Me.cbx_shimebi.Size = New System.Drawing.Size(93, 23)
        Me.cbx_shimebi.TabIndex = 132
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtp_hinichi)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(480, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 61)
        Me.GroupBox1.TabIndex = 205
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "発行日"
        '
        'dtp_hinichi
        '
        Me.dtp_hinichi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi.Location = New System.Drawing.Point(13, 24)
        Me.dtp_hinichi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi.Name = "dtp_hinichi"
        Me.dtp_hinichi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi.TabIndex = 260
        Me.dtp_hinichi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'chk_lock
        '
        Me.chk_lock.AutoSize = True
        Me.chk_lock.Location = New System.Drawing.Point(870, 30)
        Me.chk_lock.Name = "chk_lock"
        Me.chk_lock.Size = New System.Drawing.Size(54, 18)
        Me.chk_lock.TabIndex = 203
        Me.chk_lock.Text = "ロック"
        Me.chk_lock.UseVisualStyleBackColor = True
        '
        'Group2
        '
        Me.Group2.Controls.Add(Me.Label1)
        Me.Group2.Controls.Add(Me.cbx_hi)
        Me.Group2.Controls.Add(Me.Label7)
        Me.Group2.Controls.Add(Me.cbx_tsuki)
        Me.Group2.Controls.Add(Me.Label8)
        Me.Group2.Controls.Add(Me.cbx_nen)
        Me.Group2.Location = New System.Drawing.Point(142, 20)
        Me.Group2.Name = "Group2"
        Me.Group2.Size = New System.Drawing.Size(332, 61)
        Me.Group2.TabIndex = 192
        Me.Group2.TabStop = False
        Me.Group2.Text = "抽出期間"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "日まで"
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
        'chk_hi_hyouji
        '
        Me.chk_hi_hyouji.AutoSize = True
        Me.chk_hi_hyouji.Location = New System.Drawing.Point(796, 30)
        Me.chk_hi_hyouji.Name = "chk_hi_hyouji"
        Me.chk_hi_hyouji.Size = New System.Drawing.Size(68, 18)
        Me.chk_hi_hyouji.TabIndex = 198
        Me.chk_hi_hyouji.Text = "非表示"
        Me.chk_hi_hyouji.UseVisualStyleBackColor = True
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(664, 30)
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
        Me.GroupBox6.Location = New System.Drawing.Point(17, 231)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1593, 721)
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
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1582, 696)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'btn_seikyuusho_sakusei
        '
        Me.btn_seikyuusho_sakusei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seikyuusho_sakusei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_seikyuusho_sakusei.Location = New System.Drawing.Point(1641, 66)
        Me.btn_seikyuusho_sakusei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_seikyuusho_sakusei.Name = "btn_seikyuusho_sakusei"
        Me.btn_seikyuusho_sakusei.Size = New System.Drawing.Size(127, 44)
        Me.btn_seikyuusho_sakusei.TabIndex = 197
        Me.btn_seikyuusho_sakusei.Text = "請求書作成"
        Me.btn_seikyuusho_sakusei.UseVisualStyleBackColor = True
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shousai.Location = New System.Drawing.Point(1510, 67)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 202
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1641, 18)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'gbx_tenpo
        '
        Me.gbx_tenpo.Controls.Add(Me.btn_clear_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.cbx_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.Button1)
        Me.gbx_tenpo.Controls.Add(Me.chk_hihyouji_torihiki_nai)
        Me.gbx_tenpo.Enabled = False
        Me.gbx_tenpo.Location = New System.Drawing.Point(6, 87)
        Me.gbx_tenpo.Name = "gbx_tenpo"
        Me.gbx_tenpo.Size = New System.Drawing.Size(626, 61)
        Me.gbx_tenpo.TabIndex = 208
        Me.gbx_tenpo.TabStop = False
        Me.gbx_tenpo.Text = "店舗"
        '
        'btn_clear_tenpo
        '
        Me.btn_clear_tenpo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_tenpo.Location = New System.Drawing.Point(425, 21)
        Me.btn_clear_tenpo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_tenpo.Name = "btn_clear_tenpo"
        Me.btn_clear_tenpo.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_tenpo.TabIndex = 205
        Me.btn_clear_tenpo.Text = "クリア"
        Me.btn_clear_tenpo.UseVisualStyleBackColor = True
        '
        'cbx_tenpo
        '
        Me.cbx_tenpo.BackColor = System.Drawing.Color.White
        Me.cbx_tenpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tenpo.FormattingEnabled = True
        Me.cbx_tenpo.Location = New System.Drawing.Point(23, 24)
        Me.cbx_tenpo.Name = "cbx_tenpo"
        Me.cbx_tenpo.Size = New System.Drawing.Size(397, 24)
        Me.cbx_tenpo.TabIndex = 128
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(476, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 44)
        Me.Button1.TabIndex = 204
        Me.Button1.Text = "電話帳"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chk_hihyouji_torihiki_nai
        '
        Me.chk_hihyouji_torihiki_nai.AutoSize = True
        Me.chk_hihyouji_torihiki_nai.Checked = True
        Me.chk_hihyouji_torihiki_nai.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_hihyouji_torihiki_nai.Location = New System.Drawing.Point(250, -1)
        Me.chk_hihyouji_torihiki_nai.Name = "chk_hihyouji_torihiki_nai"
        Me.chk_hihyouji_torihiki_nai.Size = New System.Drawing.Size(170, 18)
        Me.chk_hihyouji_torihiki_nai.TabIndex = 189
        Me.chk_hihyouji_torihiki_nai.Text = "取引のない店舗は非表示"
        Me.chk_hihyouji_torihiki_nai.UseVisualStyleBackColor = True
        '
        'frmseikyuusho_hakkou_insatsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmseikyuusho_hakkou_insatsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求書発行"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbx_shiharai_tsuki.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_tenpo.ResumeLayout(False)
        Me.gbx_tenpo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_lock As CheckBox
    Friend WithEvents chk_hi_hyouji As CheckBox
    Friend WithEvents btn_seikyuusho_sakusei As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_hi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
    Friend WithEvents btn_shousai As Button
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents gbx_shiharai_tsuki As GroupBox
    Friend WithEvents cbx_shimebi As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_hinichi As DateTimePicker
    Friend WithEvents btn_clear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_mail As CheckBox
    Friend WithEvents btn_denwachou As Button
    Friend WithEvents chk_houkokuyou As CheckBox
    Friend WithEvents chk_insatsu_shinai As CheckBox
    Friend WithEvents gbx_tenpo As GroupBox
    Friend WithEvents btn_clear_tenpo As Button
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chk_hihyouji_torihiki_nai As CheckBox
End Class
