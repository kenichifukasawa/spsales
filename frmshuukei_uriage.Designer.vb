<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuukei_uriage
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hinichi_owari = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hinichi_kaishi = New System.Windows.Forms.DateTimePicker()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nouhinsho_goukei_kingaku = New System.Windows.Forms.Label()
        Me.lbl_nouhinsho_denpyou_sousuu = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_shiire_denpyou_goukei_kingaku = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_shiire_denpyou_sousuu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_shiharai_denpyou_goukei_kingaku = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_shiharai_denpyou_sousuu = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_nyuukin_sousuu = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_nyuukin_goukei_kingaku = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_seikyuusho_hakkou_sousuu = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_seikyuusho_souseikyuu_goukei = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_seikyuusho_shouhizei_gaku = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_seikyuusho_uriagegaku = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.btn_clear)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(834, 970)
        Me.gbx_main.TabIndex = 54
        Me.gbx_main.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Controls.Add(Me.grp_kikan_shitei)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 86)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(800, 867)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "集計内容"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(7, 300)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(783, 562)
        Me.dgv_kensakukekka.TabIndex = 192
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
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(418, 32)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.BackColor = System.Drawing.SystemColors.Control
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_shiharai_denpyou_sousuu)
        Me.grp_kikan_shitei.Controls.Add(Me.Label13)
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_shiharai_denpyou_goukei_kingaku)
        Me.grp_kikan_shitei.Controls.Add(Me.Label11)
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_shiire_denpyou_sousuu)
        Me.grp_kikan_shitei.Controls.Add(Me.Label9)
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_shiire_denpyou_goukei_kingaku)
        Me.grp_kikan_shitei.Controls.Add(Me.Label7)
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_nouhinsho_denpyou_sousuu)
        Me.grp_kikan_shitei.Controls.Add(Me.Label5)
        Me.grp_kikan_shitei.Controls.Add(Me.lbl_nouhinsho_goukei_kingaku)
        Me.grp_kikan_shitei.Controls.Add(Me.Label1)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(7, 20)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(389, 275)
        Me.grp_kikan_shitei.TabIndex = 191
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "伝票集計"
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(549, 32)
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
        Me.btn_modoru.Location = New System.Drawing.Point(680, 32)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "納品書合計金額(税抜)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nouhinsho_goukei_kingaku
        '
        Me.lbl_nouhinsho_goukei_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_nouhinsho_goukei_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nouhinsho_goukei_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nouhinsho_goukei_kingaku.Location = New System.Drawing.Point(209, 34)
        Me.lbl_nouhinsho_goukei_kingaku.Name = "lbl_nouhinsho_goukei_kingaku"
        Me.lbl_nouhinsho_goukei_kingaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_nouhinsho_goukei_kingaku.TabIndex = 1
        Me.lbl_nouhinsho_goukei_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nouhinsho_denpyou_sousuu
        '
        Me.lbl_nouhinsho_denpyou_sousuu.BackColor = System.Drawing.Color.White
        Me.lbl_nouhinsho_denpyou_sousuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nouhinsho_denpyou_sousuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nouhinsho_denpyou_sousuu.Location = New System.Drawing.Point(209, 73)
        Me.lbl_nouhinsho_denpyou_sousuu.Name = "lbl_nouhinsho_denpyou_sousuu"
        Me.lbl_nouhinsho_denpyou_sousuu.Size = New System.Drawing.Size(156, 21)
        Me.lbl_nouhinsho_denpyou_sousuu.TabIndex = 3
        Me.lbl_nouhinsho_denpyou_sousuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "納品書伝票総数"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiire_denpyou_goukei_kingaku
        '
        Me.lbl_shiire_denpyou_goukei_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_shiire_denpyou_goukei_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiire_denpyou_goukei_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiire_denpyou_goukei_kingaku.Location = New System.Drawing.Point(209, 112)
        Me.lbl_shiire_denpyou_goukei_kingaku.Name = "lbl_shiire_denpyou_goukei_kingaku"
        Me.lbl_shiire_denpyou_goukei_kingaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_shiire_denpyou_goukei_kingaku.TabIndex = 5
        Me.lbl_shiire_denpyou_goukei_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "仕入伝票合計金額"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiire_denpyou_sousuu
        '
        Me.lbl_shiire_denpyou_sousuu.BackColor = System.Drawing.Color.White
        Me.lbl_shiire_denpyou_sousuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiire_denpyou_sousuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiire_denpyou_sousuu.Location = New System.Drawing.Point(209, 151)
        Me.lbl_shiire_denpyou_sousuu.Name = "lbl_shiire_denpyou_sousuu"
        Me.lbl_shiire_denpyou_sousuu.Size = New System.Drawing.Size(156, 21)
        Me.lbl_shiire_denpyou_sousuu.TabIndex = 7
        Me.lbl_shiire_denpyou_sousuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "仕入伝票総数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiharai_denpyou_goukei_kingaku
        '
        Me.lbl_shiharai_denpyou_goukei_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_shiharai_denpyou_goukei_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiharai_denpyou_goukei_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiharai_denpyou_goukei_kingaku.Location = New System.Drawing.Point(209, 190)
        Me.lbl_shiharai_denpyou_goukei_kingaku.Name = "lbl_shiharai_denpyou_goukei_kingaku"
        Me.lbl_shiharai_denpyou_goukei_kingaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_shiharai_denpyou_goukei_kingaku.TabIndex = 9
        Me.lbl_shiharai_denpyou_goukei_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 21)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "支払伝票合計金額"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiharai_denpyou_sousuu
        '
        Me.lbl_shiharai_denpyou_sousuu.BackColor = System.Drawing.Color.White
        Me.lbl_shiharai_denpyou_sousuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiharai_denpyou_sousuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiharai_denpyou_sousuu.Location = New System.Drawing.Point(209, 229)
        Me.lbl_shiharai_denpyou_sousuu.Name = "lbl_shiharai_denpyou_sousuu"
        Me.lbl_shiharai_denpyou_sousuu.Size = New System.Drawing.Size(156, 21)
        Me.lbl_shiharai_denpyou_sousuu.TabIndex = 11
        Me.lbl_shiharai_denpyou_sousuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "支払伝票総数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lbl_nyuukin_sousuu)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_nyuukin_goukei_kingaku)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuusho_hakkou_sousuu)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuusho_souseikyuu_goukei)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuusho_shouhizei_gaku)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuusho_uriagegaku)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 275)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "請求・入金集計"
        '
        'lbl_nyuukin_sousuu
        '
        Me.lbl_nyuukin_sousuu.BackColor = System.Drawing.Color.White
        Me.lbl_nyuukin_sousuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nyuukin_sousuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nyuukin_sousuu.Location = New System.Drawing.Point(209, 229)
        Me.lbl_nyuukin_sousuu.Name = "lbl_nyuukin_sousuu"
        Me.lbl_nyuukin_sousuu.Size = New System.Drawing.Size(156, 21)
        Me.lbl_nyuukin_sousuu.TabIndex = 11
        Me.lbl_nyuukin_sousuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "入金総数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nyuukin_goukei_kingaku
        '
        Me.lbl_nyuukin_goukei_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_nyuukin_goukei_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nyuukin_goukei_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nyuukin_goukei_kingaku.Location = New System.Drawing.Point(209, 190)
        Me.lbl_nyuukin_goukei_kingaku.Name = "lbl_nyuukin_goukei_kingaku"
        Me.lbl_nyuukin_goukei_kingaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_nyuukin_goukei_kingaku.TabIndex = 9
        Me.lbl_nyuukin_goukei_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 21)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "入金合計金額"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_seikyuusho_hakkou_sousuu
        '
        Me.lbl_seikyuusho_hakkou_sousuu.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuusho_hakkou_sousuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuusho_hakkou_sousuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuusho_hakkou_sousuu.Location = New System.Drawing.Point(209, 151)
        Me.lbl_seikyuusho_hakkou_sousuu.Name = "lbl_seikyuusho_hakkou_sousuu"
        Me.lbl_seikyuusho_hakkou_sousuu.Size = New System.Drawing.Size(156, 21)
        Me.lbl_seikyuusho_hakkou_sousuu.TabIndex = 7
        Me.lbl_seikyuusho_hakkou_sousuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(164, 21)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "請求書発行総数"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_seikyuusho_souseikyuu_goukei
        '
        Me.lbl_seikyuusho_souseikyuu_goukei.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuusho_souseikyuu_goukei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuusho_souseikyuu_goukei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuusho_souseikyuu_goukei.Location = New System.Drawing.Point(209, 112)
        Me.lbl_seikyuusho_souseikyuu_goukei.Name = "lbl_seikyuusho_souseikyuu_goukei"
        Me.lbl_seikyuusho_souseikyuu_goukei.Size = New System.Drawing.Size(156, 21)
        Me.lbl_seikyuusho_souseikyuu_goukei.TabIndex = 5
        Me.lbl_seikyuusho_souseikyuu_goukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(164, 21)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "請求書総請求合計"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_seikyuusho_shouhizei_gaku
        '
        Me.lbl_seikyuusho_shouhizei_gaku.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuusho_shouhizei_gaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuusho_shouhizei_gaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuusho_shouhizei_gaku.Location = New System.Drawing.Point(209, 73)
        Me.lbl_seikyuusho_shouhizei_gaku.Name = "lbl_seikyuusho_shouhizei_gaku"
        Me.lbl_seikyuusho_shouhizei_gaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_seikyuusho_shouhizei_gaku.TabIndex = 3
        Me.lbl_seikyuusho_shouhizei_gaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(164, 21)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "請求書消費税額"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_seikyuusho_uriagegaku
        '
        Me.lbl_seikyuusho_uriagegaku.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuusho_uriagegaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuusho_uriagegaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuusho_uriagegaku.Location = New System.Drawing.Point(209, 34)
        Me.lbl_seikyuusho_uriagegaku.Name = "lbl_seikyuusho_uriagegaku"
        Me.lbl_seikyuusho_uriagegaku.Size = New System.Drawing.Size(156, 21)
        Me.lbl_seikyuusho_uriagegaku.TabIndex = 1
        Me.lbl_seikyuusho_uriagegaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Location = New System.Drawing.Point(20, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(164, 21)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "請求書売上額"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshuukei_uriage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshuukei_uriage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上集計"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_hinichi_owari As DateTimePicker
    Friend WithEvents dtp_hinichi_kaishi As DateTimePicker
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_nouhinsho_goukei_kingaku As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_nyuukin_sousuu As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_nyuukin_goukei_kingaku As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_seikyuusho_hakkou_sousuu As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_seikyuusho_souseikyuu_goukei As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_seikyuusho_shouhizei_gaku As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_seikyuusho_uriagegaku As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_shiharai_denpyou_sousuu As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_shiharai_denpyou_goukei_kingaku As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_shiire_denpyou_sousuu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_shiire_denpyou_goukei_kingaku As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nouhinsho_denpyou_sousuu As Label
    Friend WithEvents Label5 As Label
End Class
