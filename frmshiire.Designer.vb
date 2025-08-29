<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiire
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstshien = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtsentakugyou = New System.Windows.Forms.TextBox()
        Me.txtsentakutanka = New System.Windows.Forms.TextBox()
        Me.btn_jouken_kensaku = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtbikou = New System.Windows.Forms.TextBox()
        Me.txtkin = New System.Windows.Forms.TextBox()
        Me.txtsuu = New System.Windows.Forms.TextBox()
        Me.lblshouhinmei = New System.Windows.Forms.Label()
        Me.lblshouhinid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfurigana2 = New System.Windows.Forms.TextBox()
        Me.txtfurigana = New System.Windows.Forms.TextBox()
        Me.txtkubun2 = New System.Windows.Forms.TextBox()
        Me.txtkubun1 = New System.Windows.Forms.TextBox()
        Me.txtkubun = New System.Windows.Forms.TextBox()
        Me.dgv_shien = New System.Windows.Forms.DataGridView()
        Me.chkhaiban = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblgoukei = New System.Windows.Forms.Label()
        Me.lblshiiresuu = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdshiiiresaki = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgv_shiire = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgvshiirerireki = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.lblgyousha = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_shien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_shiire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvshiirerireki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lstshien)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.dgv_shien)
        Me.GroupBox1.Controls.Add(Me.chkhaiban)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(594, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 980)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "仕入伝票入力"
        '
        'lstshien
        '
        Me.lstshien.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstshien.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstshien.FormattingEnabled = True
        Me.lstshien.ItemHeight = 16
        Me.lstshien.Location = New System.Drawing.Point(29, 71)
        Me.lstshien.Name = "lstshien"
        Me.lstshien.Size = New System.Drawing.Size(236, 708)
        Me.lstshien.TabIndex = 73
        Me.lstshien.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtsentakugyou)
        Me.GroupBox6.Controls.Add(Me.txtsentakutanka)
        Me.GroupBox6.Controls.Add(Me.btn_jouken_kensaku)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.txtbikou)
        Me.GroupBox6.Controls.Add(Me.txtkin)
        Me.GroupBox6.Controls.Add(Me.txtsuu)
        Me.GroupBox6.Controls.Add(Me.lblshouhinmei)
        Me.GroupBox6.Controls.Add(Me.lblshouhinid)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtfurigana2)
        Me.GroupBox6.Controls.Add(Me.txtfurigana)
        Me.GroupBox6.Controls.Add(Me.txtkubun2)
        Me.GroupBox6.Controls.Add(Me.txtkubun1)
        Me.GroupBox6.Controls.Add(Me.txtkubun)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(545, 174)
        Me.GroupBox6.TabIndex = 72
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "条件"
        '
        'txtsentakugyou
        '
        Me.txtsentakugyou.BackColor = System.Drawing.Color.White
        Me.txtsentakugyou.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtsentakugyou.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtsentakugyou.Location = New System.Drawing.Point(241, 111)
        Me.txtsentakugyou.MaxLength = 50
        Me.txtsentakugyou.Name = "txtsentakugyou"
        Me.txtsentakugyou.Size = New System.Drawing.Size(50, 23)
        Me.txtsentakugyou.TabIndex = 217
        '
        'txtsentakutanka
        '
        Me.txtsentakutanka.BackColor = System.Drawing.Color.White
        Me.txtsentakutanka.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtsentakutanka.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtsentakutanka.Location = New System.Drawing.Point(241, 82)
        Me.txtsentakutanka.MaxLength = 50
        Me.txtsentakutanka.Name = "txtsentakutanka"
        Me.txtsentakutanka.Size = New System.Drawing.Size(50, 23)
        Me.txtsentakutanka.TabIndex = 216
        '
        'btn_jouken_kensaku
        '
        Me.btn_jouken_kensaku.BackColor = System.Drawing.Color.Honeydew
        Me.btn_jouken_kensaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jouken_kensaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_jouken_kensaku.Location = New System.Drawing.Point(448, 10)
        Me.btn_jouken_kensaku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_jouken_kensaku.Name = "btn_jouken_kensaku"
        Me.btn_jouken_kensaku.Size = New System.Drawing.Size(85, 37)
        Me.btn_jouken_kensaku.TabIndex = 215
        Me.btn_jouken_kensaku.Text = "検　索"
        Me.btn_jouken_kensaku.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(313, 74)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 44)
        Me.Button1.TabIndex = 214
        Me.Button1.Text = "クリア"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(423, 74)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 44)
        Me.Button2.TabIndex = 213
        Me.Button2.Text = "商品"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.Location = New System.Drawing.Point(313, 119)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 44)
        Me.Button4.TabIndex = 212
        Me.Button4.Text = "追加"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button6.Location = New System.Drawing.Point(423, 119)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 44)
        Me.Button6.TabIndex = 211
        Me.Button6.Text = "原価"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtbikou
        '
        Me.txtbikou.BackColor = System.Drawing.Color.White
        Me.txtbikou.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtbikou.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtbikou.Location = New System.Drawing.Point(103, 140)
        Me.txtbikou.MaxLength = 50
        Me.txtbikou.Name = "txtbikou"
        Me.txtbikou.Size = New System.Drawing.Size(154, 23)
        Me.txtbikou.TabIndex = 210
        '
        'txtkin
        '
        Me.txtkin.BackColor = System.Drawing.Color.White
        Me.txtkin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkin.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkin.Location = New System.Drawing.Point(103, 111)
        Me.txtkin.MaxLength = 50
        Me.txtkin.Name = "txtkin"
        Me.txtkin.Size = New System.Drawing.Size(78, 23)
        Me.txtkin.TabIndex = 209
        '
        'txtsuu
        '
        Me.txtsuu.BackColor = System.Drawing.Color.White
        Me.txtsuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtsuu.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtsuu.Location = New System.Drawing.Point(103, 80)
        Me.txtsuu.MaxLength = 50
        Me.txtsuu.Name = "txtsuu"
        Me.txtsuu.Size = New System.Drawing.Size(78, 23)
        Me.txtsuu.TabIndex = 208
        '
        'lblshouhinmei
        '
        Me.lblshouhinmei.BackColor = System.Drawing.SystemColors.Control
        Me.lblshouhinmei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblshouhinmei.Location = New System.Drawing.Point(115, 46)
        Me.lblshouhinmei.Name = "lblshouhinmei"
        Me.lblshouhinmei.Size = New System.Drawing.Size(418, 22)
        Me.lblshouhinmei.TabIndex = 207
        Me.lblshouhinmei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblshouhinid
        '
        Me.lblshouhinid.BackColor = System.Drawing.SystemColors.Control
        Me.lblshouhinid.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblshouhinid.Location = New System.Drawing.Point(11, 46)
        Me.lblshouhinid.Name = "lblshouhinid"
        Me.lblshouhinid.Size = New System.Drawing.Size(89, 22)
        Me.lblshouhinid.TabIndex = 206
        Me.lblshouhinid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 192
        Me.Label1.Text = "円"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(187, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 16)
        Me.Label14.TabIndex = 190
        Me.Label14.Text = "個"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "備　考"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "仕入金額"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "仕入個数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "商品"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtfurigana2
        '
        Me.txtfurigana2.BackColor = System.Drawing.Color.White
        Me.txtfurigana2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtfurigana2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtfurigana2.Location = New System.Drawing.Point(319, 15)
        Me.txtfurigana2.MaxLength = 50
        Me.txtfurigana2.Name = "txtfurigana2"
        Me.txtfurigana2.Size = New System.Drawing.Size(96, 23)
        Me.txtfurigana2.TabIndex = 183
        '
        'txtfurigana
        '
        Me.txtfurigana.BackColor = System.Drawing.Color.White
        Me.txtfurigana.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtfurigana.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtfurigana.Location = New System.Drawing.Point(218, 15)
        Me.txtfurigana.MaxLength = 50
        Me.txtfurigana.Name = "txtfurigana"
        Me.txtfurigana.Size = New System.Drawing.Size(96, 23)
        Me.txtfurigana.TabIndex = 182
        '
        'txtkubun2
        '
        Me.txtkubun2.BackColor = System.Drawing.Color.White
        Me.txtkubun2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubun2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkubun2.Location = New System.Drawing.Point(168, 15)
        Me.txtkubun2.MaxLength = 50
        Me.txtkubun2.Name = "txtkubun2"
        Me.txtkubun2.Size = New System.Drawing.Size(45, 23)
        Me.txtkubun2.TabIndex = 181
        '
        'txtkubun1
        '
        Me.txtkubun1.BackColor = System.Drawing.Color.White
        Me.txtkubun1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubun1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkubun1.Location = New System.Drawing.Point(118, 15)
        Me.txtkubun1.MaxLength = 50
        Me.txtkubun1.Name = "txtkubun1"
        Me.txtkubun1.Size = New System.Drawing.Size(45, 23)
        Me.txtkubun1.TabIndex = 180
        '
        'txtkubun
        '
        Me.txtkubun.BackColor = System.Drawing.Color.White
        Me.txtkubun.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubun.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkubun.Location = New System.Drawing.Point(67, 15)
        Me.txtkubun.MaxLength = 50
        Me.txtkubun.Name = "txtkubun"
        Me.txtkubun.Size = New System.Drawing.Size(45, 23)
        Me.txtkubun.TabIndex = 179
        '
        'dgv_shien
        '
        Me.dgv_shien.AllowUserToAddRows = False
        Me.dgv_shien.AllowUserToDeleteRows = False
        Me.dgv_shien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_shien.Location = New System.Drawing.Point(16, 200)
        Me.dgv_shien.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_shien.MultiSelect = False
        Me.dgv_shien.Name = "dgv_shien"
        Me.dgv_shien.ReadOnly = True
        Me.dgv_shien.RowTemplate.Height = 24
        Me.dgv_shien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_shien.Size = New System.Drawing.Size(547, 765)
        Me.dgv_shien.TabIndex = 71
        '
        'chkhaiban
        '
        Me.chkhaiban.AutoSize = True
        Me.chkhaiban.Checked = True
        Me.chkhaiban.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkhaiban.Location = New System.Drawing.Point(387, 4)
        Me.chkhaiban.Name = "chkhaiban"
        Me.chkhaiban.Size = New System.Drawing.Size(101, 19)
        Me.chkhaiban.TabIndex = 191
        Me.chkhaiban.Text = "廃盤非表示"
        Me.chkhaiban.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.dgv_shiire)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1176, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 980)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "仮伝票"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblgoukei)
        Me.GroupBox3.Controls.Add(Me.lblshiiresuu)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmdshiiiresaki)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 174)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        '
        'lblgoukei
        '
        Me.lblgoukei.BackColor = System.Drawing.SystemColors.Control
        Me.lblgoukei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblgoukei.Location = New System.Drawing.Point(100, 139)
        Me.lblgoukei.Name = "lblgoukei"
        Me.lblgoukei.Size = New System.Drawing.Size(156, 22)
        Me.lblgoukei.TabIndex = 221
        Me.lblgoukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblshiiresuu
        '
        Me.lblshiiresuu.BackColor = System.Drawing.SystemColors.Control
        Me.lblshiiresuu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblshiiresuu.Location = New System.Drawing.Point(444, 10)
        Me.lblshiiresuu.Name = "lblshiiresuu"
        Me.lblshiiresuu.Size = New System.Drawing.Size(89, 22)
        Me.lblshiiresuu.TabIndex = 220
        Me.lblshiiresuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button10.Location = New System.Drawing.Point(567, 20)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 44)
        Me.Button10.TabIndex = 219
        Me.Button10.Text = "バーコード"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(323, 86)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 19)
        Me.CheckBox2.TabIndex = 217
        Me.CheckBox2.Text = "仕入先を固定"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button9.Location = New System.Drawing.Point(567, 119)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 44)
        Me.Button9.TabIndex = 218
        Me.Button9.Text = "戻る"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "円"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdshiiiresaki
        '
        Me.cmdshiiiresaki.BackColor = System.Drawing.Color.White
        Me.cmdshiiiresaki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdshiiiresaki.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmdshiiiresaki.FormattingEnabled = True
        Me.cmdshiiiresaki.Location = New System.Drawing.Point(103, 45)
        Me.cmdshiiiresaki.Name = "cmdshiiiresaki"
        Me.cmdshiiiresaki.Size = New System.Drawing.Size(430, 24)
        Me.cmdshiiiresaki.TabIndex = 215
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "仕入先"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 22)
        Me.DateTimePicker1.TabIndex = 213
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button7.Location = New System.Drawing.Point(453, 119)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 44)
        Me.Button7.TabIndex = 212
        Me.Button7.Text = "登録"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button8.Location = New System.Drawing.Point(567, 71)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 44)
        Me.Button8.TabIndex = 211
        Me.Button8.Text = "削除"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox5.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox5.Location = New System.Drawing.Point(103, 108)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(154, 23)
        Me.TextBox5.TabIndex = 209
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox6.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox6.Location = New System.Drawing.Point(103, 77)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(154, 23)
        Me.TextBox6.TabIndex = 208
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "合計金額"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "備　考"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "伝票番号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 16)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "日付"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_shiire
        '
        Me.dgv_shiire.AllowUserToAddRows = False
        Me.dgv_shiire.AllowUserToDeleteRows = False
        Me.dgv_shiire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_shiire.Location = New System.Drawing.Point(16, 200)
        Me.dgv_shiire.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_shiire.MultiSelect = False
        Me.dgv_shiire.Name = "dgv_shiire"
        Me.dgv_shiire.ReadOnly = True
        Me.dgv_shiire.RowTemplate.Height = 24
        Me.dgv_shiire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_shiire.Size = New System.Drawing.Size(683, 765)
        Me.dgv_shiire.TabIndex = 71
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.lblgyousha)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.dgvshiirerireki)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 382)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 605)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "伝票"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(345, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 44)
        Me.Button3.TabIndex = 214
        Me.Button3.Text = "戻し"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button5.Location = New System.Drawing.Point(455, 15)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 44)
        Me.Button5.TabIndex = 213
        Me.Button5.Text = "削除"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgvshiirerireki
        '
        Me.dgvshiirerireki.AllowUserToAddRows = False
        Me.dgvshiirerireki.AllowUserToDeleteRows = False
        Me.dgvshiirerireki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvshiirerireki.Location = New System.Drawing.Point(18, 66)
        Me.dgvshiirerireki.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvshiirerireki.MultiSelect = False
        Me.dgvshiirerireki.Name = "dgvshiirerireki"
        Me.dgvshiirerireki.ReadOnly = True
        Me.dgvshiirerireki.RowTemplate.Height = 24
        Me.dgvshiirerireki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvshiirerireki.Size = New System.Drawing.Size(547, 520)
        Me.dgvshiirerireki.TabIndex = 72
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(576, 365)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "商品"
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button11.Location = New System.Drawing.Point(345, 307)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 44)
        Me.Button11.TabIndex = 214
        Me.Button11.Text = "戻し"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button12.Location = New System.Drawing.Point(455, 307)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(110, 44)
        Me.Button12.TabIndex = 213
        Me.Button12.Text = "削除"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'lblgyousha
        '
        Me.lblgyousha.BackColor = System.Drawing.SystemColors.Control
        Me.lblgyousha.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblgyousha.Location = New System.Drawing.Point(15, 21)
        Me.lblgyousha.Name = "lblgyousha"
        Me.lblgyousha.Size = New System.Drawing.Size(316, 35)
        Me.lblgyousha.TabIndex = 215
        Me.lblgyousha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshiire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmshiire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "仕入伝票"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgv_shien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_shiire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvshiirerireki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstshien As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfurigana2 As TextBox
    Friend WithEvents txtfurigana As TextBox
    Friend WithEvents txtkubun2 As TextBox
    Friend WithEvents txtkubun1 As TextBox
    Friend WithEvents txtkubun As TextBox
    Friend WithEvents dgv_shien As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents chkhaiban As CheckBox
    Friend WithEvents txtbikou As TextBox
    Friend WithEvents txtkin As TextBox
    Friend WithEvents txtsuu As TextBox
    Friend WithEvents lblshouhinmei As Label
    Friend WithEvents lblshouhinid As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dgv_shiire As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdshiiiresaki As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents dgvshiirerireki As DataGridView
    Friend WithEvents btn_jouken_kensaku As Button
    Friend WithEvents txtsentakugyou As TextBox
    Friend WithEvents txtsentakutanka As TextBox
    Friend WithEvents lblshiiresuu As Label
    Friend WithEvents lblgoukei As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents lblgyousha As Label
End Class
