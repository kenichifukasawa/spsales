<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuukei_hanbai
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
        Me.btn_clear_2 = New System.Windows.Forms.Button()
        Me.chk_shuukei_shinai_service_denpyou = New System.Windows.Forms.CheckBox()
        Me.chk_shuukei_shinai_torihikinai_tenpo = New System.Windows.Forms.CheckBox()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.btn_denwa_chou = New System.Windows.Forms.Button()
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbx_shain = New System.Windows.Forms.ComboBox()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.chk_hihyouji_torihiki_nai = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_kekka = New System.Windows.Forms.Label()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbx_shitei_shouhin = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hinichi_owari = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hinichi_kaishi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_haiban = New System.Windows.Forms.CheckBox()
        Me.cbx_shouhin_kubun_2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shouhin_kubun_1 = New System.Windows.Forms.ComboBox()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.btn_insatsu = New System.Windows.Forms.Button()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.cbx_gyousha_kubun = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.btn_clear_2)
        Me.gbx_main.Controls.Add(Me.chk_shuukei_shinai_service_denpyou)
        Me.gbx_main.Controls.Add(Me.chk_shuukei_shinai_torihikinai_tenpo)
        Me.gbx_main.Controls.Add(Me.btn_shousai)
        Me.gbx_main.Controls.Add(Me.btn_denwa_chou)
        Me.gbx_main.Controls.Add(Me.btn_csv)
        Me.gbx_main.Controls.Add(Me.GroupBox5)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox4)
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.btn_insatsu)
        Me.gbx_main.Controls.Add(Me.grp_kikan_shitei)
        Me.gbx_main.Controls.Add(Me.btn_clear)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 12)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1220, 971)
        Me.gbx_main.TabIndex = 54
        Me.gbx_main.TabStop = False
        '
        'btn_clear_2
        '
        Me.btn_clear_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_2.Location = New System.Drawing.Point(1073, 26)
        Me.btn_clear_2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_2.Name = "btn_clear_2"
        Me.btn_clear_2.Size = New System.Drawing.Size(127, 44)
        Me.btn_clear_2.TabIndex = 199
        Me.btn_clear_2.Text = "クリア"
        Me.btn_clear_2.UseVisualStyleBackColor = True
        '
        'chk_shuukei_shinai_service_denpyou
        '
        Me.chk_shuukei_shinai_service_denpyou.AutoSize = True
        Me.chk_shuukei_shinai_service_denpyou.Location = New System.Drawing.Point(992, 217)
        Me.chk_shuukei_shinai_service_denpyou.Name = "chk_shuukei_shinai_service_denpyou"
        Me.chk_shuukei_shinai_service_denpyou.Size = New System.Drawing.Size(170, 18)
        Me.chk_shuukei_shinai_service_denpyou.TabIndex = 198
        Me.chk_shuukei_shinai_service_denpyou.Text = "サービス伝票は集計しない"
        Me.chk_shuukei_shinai_service_denpyou.UseVisualStyleBackColor = True
        '
        'chk_shuukei_shinai_torihikinai_tenpo
        '
        Me.chk_shuukei_shinai_torihikinai_tenpo.AutoSize = True
        Me.chk_shuukei_shinai_torihikinai_tenpo.Location = New System.Drawing.Point(733, 217)
        Me.chk_shuukei_shinai_torihikinai_tenpo.Name = "chk_shuukei_shinai_torihikinai_tenpo"
        Me.chk_shuukei_shinai_torihikinai_tenpo.Size = New System.Drawing.Size(189, 18)
        Me.chk_shuukei_shinai_torihikinai_tenpo.TabIndex = 196
        Me.chk_shuukei_shinai_torihikinai_tenpo.Text = "取引のない店舗は集計しない"
        Me.chk_shuukei_shinai_torihikinai_tenpo.UseVisualStyleBackColor = True
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shousai.Location = New System.Drawing.Point(943, 159)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 197
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'btn_denwa_chou
        '
        Me.btn_denwa_chou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwa_chou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_denwa_chou.Location = New System.Drawing.Point(812, 92)
        Me.btn_denwa_chou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwa_chou.Name = "btn_denwa_chou"
        Me.btn_denwa_chou.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwa_chou.TabIndex = 196
        Me.btn_denwa_chou.Text = "電話帳"
        Me.btn_denwa_chou.UseVisualStyleBackColor = True
        '
        'btn_csv
        '
        Me.btn_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_csv.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_csv.Location = New System.Drawing.Point(1073, 92)
        Me.btn_csv.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.Size = New System.Drawing.Size(127, 44)
        Me.btn_csv.TabIndex = 195
        Me.btn_csv.Text = "CSV"
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbx_shain)
        Me.GroupBox5.Controls.Add(Me.cbx_tenpo)
        Me.GroupBox5.Controls.Add(Me.chk_hihyouji_torihiki_nai)
        Me.GroupBox5.Location = New System.Drawing.Point(419, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(651, 61)
        Me.GroupBox5.TabIndex = 192
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "店舗名 または 担当社員"
        '
        'cbx_shain
        '
        Me.cbx_shain.BackColor = System.Drawing.Color.White
        Me.cbx_shain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shain.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shain.FormattingEnabled = True
        Me.cbx_shain.Location = New System.Drawing.Point(443, 24)
        Me.cbx_shain.Name = "cbx_shain"
        Me.cbx_shain.Size = New System.Drawing.Size(183, 24)
        Me.cbx_shain.TabIndex = 129
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.lbl_kekka)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 241)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1188, 714)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 15)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "※列名をクリックすると並び替えることができます。"
        '
        'lbl_kekka
        '
        Me.lbl_kekka.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_kekka.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kekka.Location = New System.Drawing.Point(19, 22)
        Me.lbl_kekka.Name = "lbl_kekka"
        Me.lbl_kekka.Size = New System.Drawing.Size(1147, 24)
        Me.lbl_kekka.TabIndex = 193
        Me.lbl_kekka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(7, 75)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1176, 634)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbx_shitei_shouhin)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 153)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_owari)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_kaishi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 61)
        Me.GroupBox3.TabIndex = 192
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "抽出期間"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "～"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_hinichi_owari
        '
        Me.dtp_hinichi_owari.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_owari.Location = New System.Drawing.Point(219, 24)
        Me.dtp_hinichi_owari.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_owari.Name = "dtp_hinichi_owari"
        Me.dtp_hinichi_owari.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_owari.TabIndex = 261
        Me.dtp_hinichi_owari.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'dtp_hinichi_kaishi
        '
        Me.dtp_hinichi_kaishi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_kaishi.Location = New System.Drawing.Point(30, 24)
        Me.dtp_hinichi_kaishi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_kaishi.Name = "dtp_hinichi_kaishi"
        Me.dtp_hinichi_kaishi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_kaishi.TabIndex = 260
        Me.dtp_hinichi_kaishi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_haiban)
        Me.GroupBox2.Controls.Add(Me.cbx_shouhin_kubun_2)
        Me.GroupBox2.Location = New System.Drawing.Point(545, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "商品選択区分２"
        '
        'chk_haiban
        '
        Me.chk_haiban.AutoSize = True
        Me.chk_haiban.Location = New System.Drawing.Point(136, -1)
        Me.chk_haiban.Name = "chk_haiban"
        Me.chk_haiban.Size = New System.Drawing.Size(116, 18)
        Me.chk_haiban.TabIndex = 195
        Me.chk_haiban.Text = "廃盤も表示する"
        Me.chk_haiban.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(281, 86)
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
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(812, 159)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'btn_insatsu
        '
        Me.btn_insatsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insatsu.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_insatsu.Location = New System.Drawing.Point(943, 92)
        Me.btn_insatsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insatsu.Name = "btn_insatsu"
        Me.btn_insatsu.Size = New System.Drawing.Size(127, 44)
        Me.btn_insatsu.TabIndex = 193
        Me.btn_insatsu.Text = "印刷"
        Me.btn_insatsu.UseVisualStyleBackColor = True
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_gyousha_kubun)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(17, 86)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(258, 61)
        Me.grp_kikan_shitei.TabIndex = 191
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "業者区分"
        '
        'cbx_gyousha_kubun
        '
        Me.cbx_gyousha_kubun.BackColor = System.Drawing.Color.White
        Me.cbx_gyousha_kubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gyousha_kubun.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_gyousha_kubun.FormattingEnabled = True
        Me.cbx_gyousha_kubun.Location = New System.Drawing.Point(19, 24)
        Me.cbx_gyousha_kubun.Name = "cbx_gyousha_kubun"
        Me.cbx_gyousha_kubun.Size = New System.Drawing.Size(217, 24)
        Me.cbx_gyousha_kubun.TabIndex = 128
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(682, 159)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(127, 44)
        Me.btn_clear.TabIndex = 34
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1074, 159)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmshuukei_hanbai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshuukei_hanbai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "販売集計"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_kekka As Label
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbx_shitei_shouhin As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_hinichi_owari As DateTimePicker
    Friend WithEvents dtp_hinichi_kaishi As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_1 As ComboBox
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents btn_insatsu As Button
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents cbx_gyousha_kubun As ComboBox
    Friend WithEvents chk_hihyouji_torihiki_nai As CheckBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents chk_haiban As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbx_shain As ComboBox
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents chk_shuukei_shinai_torihikinai_tenpo As CheckBox
    Friend WithEvents btn_shousai As Button
    Friend WithEvents btn_denwa_chou As Button
    Friend WithEvents btn_csv As Button
    Friend WithEvents chk_shuukei_shinai_service_denpyou As CheckBox
    Friend WithEvents btn_clear_2 As Button
End Class
