<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuu_rireki
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
        Me.btn_path = New System.Windows.Forms.Button()
        Me.btn_insatsu = New System.Windows.Forms.Button()
        Me.chk_sakujo = New System.Windows.Forms.CheckBox()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbx_tenpo = New System.Windows.Forms.GroupBox()
        Me.btn_clear_tenpo = New System.Windows.Forms.Button()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.btn_denwachou = New System.Windows.Forms.Button()
        Me.chk_hihyouji_torihiki_nai = New System.Windows.Forms.CheckBox()
        Me.rbn_shubetsu_tenpo = New System.Windows.Forms.RadioButton()
        Me.rbn_shubetsu_kikan = New System.Windows.Forms.RadioButton()
        Me.gbx_shiharai_tsuki = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_kekka = New System.Windows.Forms.Label()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_tenpo.SuspendLayout()
        Me.gbx_shiharai_tsuki.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.btn_path)
        Me.gbx_main.Controls.Add(Me.btn_insatsu)
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
        Me.gbx_main.Size = New System.Drawing.Size(1329, 971)
        Me.gbx_main.TabIndex = 58
        Me.gbx_main.TabStop = False
        '
        'btn_path
        '
        Me.btn_path.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_path.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_path.Location = New System.Drawing.Point(1179, 33)
        Me.btn_path.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(127, 44)
        Me.btn_path.TabIndex = 205
        Me.btn_path.Text = "パス"
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'btn_insatsu
        '
        Me.btn_insatsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insatsu.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_insatsu.Location = New System.Drawing.Point(1048, 33)
        Me.btn_insatsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insatsu.Name = "btn_insatsu"
        Me.btn_insatsu.Size = New System.Drawing.Size(127, 44)
        Me.btn_insatsu.TabIndex = 203
        Me.btn_insatsu.Text = "印刷"
        Me.btn_insatsu.UseVisualStyleBackColor = True
        '
        'chk_sakujo
        '
        Me.chk_sakujo.AutoSize = True
        Me.chk_sakujo.Location = New System.Drawing.Point(1224, 948)
        Me.chk_sakujo.Name = "chk_sakujo"
        Me.chk_sakujo.Size = New System.Drawing.Size(77, 18)
        Me.chk_sakujo.TabIndex = 202
        Me.chk_sakujo.Text = "削除する"
        Me.chk_sakujo.UseVisualStyleBackColor = True
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shousai.Location = New System.Drawing.Point(1048, 81)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 201
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbx_tenpo)
        Me.GroupBox1.Controls.Add(Me.rbn_shubetsu_tenpo)
        Me.GroupBox1.Controls.Add(Me.rbn_shubetsu_kikan)
        Me.GroupBox1.Controls.Add(Me.gbx_shiharai_tsuki)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 111)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        '
        'gbx_tenpo
        '
        Me.gbx_tenpo.Controls.Add(Me.btn_clear_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.cbx_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.btn_denwachou)
        Me.gbx_tenpo.Controls.Add(Me.chk_hihyouji_torihiki_nai)
        Me.gbx_tenpo.Enabled = False
        Me.gbx_tenpo.Location = New System.Drawing.Point(227, 45)
        Me.gbx_tenpo.Name = "gbx_tenpo"
        Me.gbx_tenpo.Size = New System.Drawing.Size(626, 61)
        Me.gbx_tenpo.TabIndex = 193
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
        'btn_denwachou
        '
        Me.btn_denwachou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwachou.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_denwachou.Location = New System.Drawing.Point(476, 12)
        Me.btn_denwachou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwachou.Name = "btn_denwachou"
        Me.btn_denwachou.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwachou.TabIndex = 204
        Me.btn_denwachou.Text = "電話帳"
        Me.btn_denwachou.UseVisualStyleBackColor = True
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
        'rbn_shubetsu_tenpo
        '
        Me.rbn_shubetsu_tenpo.AutoSize = True
        Me.rbn_shubetsu_tenpo.Location = New System.Drawing.Point(243, 21)
        Me.rbn_shubetsu_tenpo.Name = "rbn_shubetsu_tenpo"
        Me.rbn_shubetsu_tenpo.Size = New System.Drawing.Size(67, 18)
        Me.rbn_shubetsu_tenpo.TabIndex = 201
        Me.rbn_shubetsu_tenpo.Text = "店舗別"
        Me.rbn_shubetsu_tenpo.UseVisualStyleBackColor = True
        '
        'rbn_shubetsu_kikan
        '
        Me.rbn_shubetsu_kikan.AutoSize = True
        Me.rbn_shubetsu_kikan.Checked = True
        Me.rbn_shubetsu_kikan.Location = New System.Drawing.Point(25, 21)
        Me.rbn_shubetsu_kikan.Name = "rbn_shubetsu_kikan"
        Me.rbn_shubetsu_kikan.Size = New System.Drawing.Size(81, 18)
        Me.rbn_shubetsu_kikan.TabIndex = 200
        Me.rbn_shubetsu_kikan.TabStop = True
        Me.rbn_shubetsu_kikan.Text = "発行月別"
        Me.rbn_shubetsu_kikan.UseVisualStyleBackColor = True
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
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_sakujo.Location = New System.Drawing.Point(917, 33)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 197
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_kekka)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 136)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1289, 806)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'lbl_kekka
        '
        Me.lbl_kekka.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_kekka.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kekka.Location = New System.Drawing.Point(6, 22)
        Me.lbl_kekka.Name = "lbl_kekka"
        Me.lbl_kekka.Size = New System.Drawing.Size(1278, 24)
        Me.lbl_kekka.TabIndex = 194
        Me.lbl_kekka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 55)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1279, 746)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shuukei.Location = New System.Drawing.Point(917, 81)
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
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(1179, 81)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmseikyuu_rireki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmseikyuu_rireki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求履歴"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbx_tenpo.ResumeLayout(False)
        Me.gbx_tenpo.PerformLayout()
        Me.gbx_shiharai_tsuki.ResumeLayout(False)
        Me.gbx_shiharai_tsuki.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_sakujo As CheckBox
    Friend WithEvents btn_shousai As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbn_shubetsu_tenpo As RadioButton
    Friend WithEvents rbn_shubetsu_kikan As RadioButton
    Friend WithEvents gbx_shiharai_tsuki As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
    Friend WithEvents btn_sakujo As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents btn_path As Button
    Friend WithEvents btn_denwachou As Button
    Friend WithEvents btn_insatsu As Button
    Friend WithEvents gbx_tenpo As GroupBox
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents chk_hihyouji_torihiki_nai As CheckBox
    Friend WithEvents btn_clear_tenpo As Button
    Friend WithEvents lbl_kekka As Label
End Class
