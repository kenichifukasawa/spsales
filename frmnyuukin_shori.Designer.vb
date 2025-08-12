<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnyuukin_shori
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka_seikyuu = New System.Windows.Forms.DataGridView()
        Me.gbx_tenpo = New System.Windows.Forms.GroupBox()
        Me.btn_clear_tenpo = New System.Windows.Forms.Button()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.btn_denwachou = New System.Windows.Forms.Button()
        Me.chk_hihyouji_torihiki_nai = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_kurikoshi_kingaku = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_touroku = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_bikou = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ryoushuusho_no = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kingaku = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.cbx_shiharai_houhou = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_hinichi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka_nyuukin = New System.Windows.Forms.DataGridView()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.chk_sakujo = New System.Windows.Forms.CheckBox()
        Me.btn_henkou = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.chk_houkoku = New System.Windows.Forms.CheckBox()
        Me.lbl_nyuukin_id = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgv_kensakukekka_seikyuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_tenpo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka_nyuukin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox8)
        Me.gbx_main.Controls.Add(Me.gbx_tenpo)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1329, 971)
        Me.gbx_main.TabIndex = 59
        Me.gbx_main.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dgv_kensakukekka_seikyuu)
        Me.GroupBox8.Location = New System.Drawing.Point(902, 185)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(414, 770)
        Me.GroupBox8.TabIndex = 202
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "請求一覧"
        '
        'dgv_kensakukekka_seikyuu
        '
        Me.dgv_kensakukekka_seikyuu.AllowUserToAddRows = False
        Me.dgv_kensakukekka_seikyuu.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka_seikyuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka_seikyuu.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka_seikyuu.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka_seikyuu.Name = "dgv_kensakukekka_seikyuu"
        Me.dgv_kensakukekka_seikyuu.ReadOnly = True
        Me.dgv_kensakukekka_seikyuu.RowTemplate.Height = 24
        Me.dgv_kensakukekka_seikyuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka_seikyuu.Size = New System.Drawing.Size(404, 746)
        Me.dgv_kensakukekka_seikyuu.TabIndex = 192
        '
        'gbx_tenpo
        '
        Me.gbx_tenpo.Controls.Add(Me.btn_clear_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.cbx_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.btn_denwachou)
        Me.gbx_tenpo.Controls.Add(Me.chk_hihyouji_torihiki_nai)
        Me.gbx_tenpo.Location = New System.Drawing.Point(12, 19)
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
        Me.btn_denwachou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.btn_touroku)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox13)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1304, 93)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "入金伝票登録"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_kurikoshi_kingaku)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(1016, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(146, 60)
        Me.GroupBox7.TabIndex = 206
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "現在の繰越金額"
        '
        'lbl_kurikoshi_kingaku
        '
        Me.lbl_kurikoshi_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kurikoshi_kingaku.Location = New System.Drawing.Point(6, 24)
        Me.lbl_kurikoshi_kingaku.Name = "lbl_kurikoshi_kingaku"
        Me.lbl_kurikoshi_kingaku.Size = New System.Drawing.Size(107, 23)
        Me.lbl_kurikoshi_kingaku.TabIndex = 190
        Me.lbl_kurikoshi_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btn_touroku
        '
        Me.btn_touroku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_touroku.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_touroku.Location = New System.Drawing.Point(1167, 31)
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
        Me.GroupBox5.Controls.Add(Me.chk_houkoku)
        Me.GroupBox5.Controls.Add(Me.txt_bikou)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(583, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(427, 60)
        Me.GroupBox5.TabIndex = 206
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "備考"
        '
        'txt_bikou
        '
        Me.txt_bikou.BackColor = System.Drawing.Color.White
        Me.txt_bikou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_bikou.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_bikou.Location = New System.Drawing.Point(17, 24)
        Me.txt_bikou.MaxLength = 50
        Me.txt_bikou.Name = "txt_bikou"
        Me.txt_bikou.Size = New System.Drawing.Size(392, 22)
        Me.txt_bikou.TabIndex = 187
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_ryoushuusho_no)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(473, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 60)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "領収書NO"
        '
        'txt_ryoushuusho_no
        '
        Me.txt_ryoushuusho_no.BackColor = System.Drawing.Color.White
        Me.txt_ryoushuusho_no.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_ryoushuusho_no.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_ryoushuusho_no.Location = New System.Drawing.Point(13, 24)
        Me.txt_ryoushuusho_no.MaxLength = 8
        Me.txt_ryoushuusho_no.Name = "txt_ryoushuusho_no"
        Me.txt_ryoushuusho_no.Size = New System.Drawing.Size(78, 22)
        Me.txt_ryoushuusho_no.TabIndex = 187
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_kingaku)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(318, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(149, 60)
        Me.GroupBox4.TabIndex = 204
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "入金金額"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(121, 22)
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
        Me.txt_kingaku.Location = New System.Drawing.Point(13, 24)
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
        Me.GroupBox13.Location = New System.Drawing.Point(191, 20)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(121, 60)
        Me.GroupBox13.TabIndex = 203
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "入金方法"
        '
        'cbx_shiharai_houhou
        '
        Me.cbx_shiharai_houhou.BackColor = System.Drawing.Color.White
        Me.cbx_shiharai_houhou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shiharai_houhou.FormattingEnabled = True
        Me.cbx_shiharai_houhou.Location = New System.Drawing.Point(13, 23)
        Me.cbx_shiharai_houhou.Name = "cbx_shiharai_houhou"
        Me.cbx_shiharai_houhou.Size = New System.Drawing.Size(94, 23)
        Me.cbx_shiharai_houhou.TabIndex = 194
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 60)
        Me.GroupBox3.TabIndex = 202
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "入金日"
        '
        'dtp_hinichi
        '
        Me.dtp_hinichi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi.Location = New System.Drawing.Point(13, 25)
        Me.dtp_hinichi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi.Name = "dtp_hinichi"
        Me.dtp_hinichi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi.TabIndex = 260
        Me.dtp_hinichi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_nyuukin_id)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka_nyuukin)
        Me.GroupBox6.Controls.Add(Me.btn_sakujo)
        Me.GroupBox6.Controls.Add(Me.chk_sakujo)
        Me.GroupBox6.Controls.Add(Me.btn_henkou)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(884, 770)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "入金一覧"
        '
        'dgv_kensakukekka_nyuukin
        '
        Me.dgv_kensakukekka_nyuukin.AllowUserToAddRows = False
        Me.dgv_kensakukekka_nyuukin.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka_nyuukin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka_nyuukin.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka_nyuukin.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka_nyuukin.Name = "dgv_kensakukekka_nyuukin"
        Me.dgv_kensakukekka_nyuukin.ReadOnly = True
        Me.dgv_kensakukekka_nyuukin.RowTemplate.Height = 24
        Me.dgv_kensakukekka_nyuukin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka_nyuukin.Size = New System.Drawing.Size(874, 698)
        Me.dgv_kensakukekka_nyuukin.TabIndex = 192
        '
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_sakujo.Location = New System.Drawing.Point(752, 721)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 197
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        '
        'chk_sakujo
        '
        Me.chk_sakujo.AutoSize = True
        Me.chk_sakujo.Location = New System.Drawing.Point(11, 734)
        Me.chk_sakujo.Name = "chk_sakujo"
        Me.chk_sakujo.Size = New System.Drawing.Size(77, 18)
        Me.chk_sakujo.TabIndex = 202
        Me.chk_sakujo.Text = "削除する"
        Me.chk_sakujo.UseVisualStyleBackColor = True
        '
        'btn_henkou
        '
        Me.btn_henkou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_henkou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_henkou.Location = New System.Drawing.Point(621, 721)
        Me.btn_henkou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_henkou.Name = "btn_henkou"
        Me.btn_henkou.Size = New System.Drawing.Size(127, 44)
        Me.btn_henkou.TabIndex = 201
        Me.btn_henkou.Text = "変更"
        Me.btn_henkou.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1179, 31)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'chk_houkoku
        '
        Me.chk_houkoku.AutoSize = True
        Me.chk_houkoku.Location = New System.Drawing.Point(84, 0)
        Me.chk_houkoku.Name = "chk_houkoku"
        Me.chk_houkoku.Size = New System.Drawing.Size(71, 19)
        Me.chk_houkoku.TabIndex = 206
        Me.chk_houkoku.Text = "報告用"
        Me.chk_houkoku.UseVisualStyleBackColor = True
        '
        'lbl_nyuukin_id
        '
        Me.lbl_nyuukin_id.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_nyuukin_id.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nyuukin_id.Location = New System.Drawing.Point(94, 729)
        Me.lbl_nyuukin_id.Name = "lbl_nyuukin_id"
        Me.lbl_nyuukin_id.Size = New System.Drawing.Size(107, 23)
        Me.lbl_nyuukin_id.TabIndex = 191
        Me.lbl_nyuukin_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmnyuukin_shori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmnyuukin_shori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "入金処理"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgv_kensakukekka_seikyuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_tenpo.ResumeLayout(False)
        Me.gbx_tenpo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgv_kensakukekka_nyuukin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_sakujo As CheckBox
    Friend WithEvents btn_henkou As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbx_tenpo As GroupBox
    Friend WithEvents btn_clear_tenpo As Button
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents btn_denwachou As Button
    Friend WithEvents chk_hihyouji_torihiki_nai As CheckBox
    Friend WithEvents btn_sakujo As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka_nyuukin As DataGridView
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtp_hinichi As DateTimePicker
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents cbx_shiharai_houhou As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_kingaku As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txt_bikou As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_ryoushuusho_no As TextBox
    Friend WithEvents btn_touroku As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_kurikoshi_kingaku As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents dgv_kensakukekka_seikyuu As DataGridView
    Friend WithEvents chk_houkoku As CheckBox
    Friend WithEvents lbl_nyuukin_id As Label
End Class
