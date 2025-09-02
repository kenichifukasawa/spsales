<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkensaku
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rnouhinshono = New System.Windows.Forms.RadioButton()
        Me.txtnouhinshono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gnarabe = New System.Windows.Forms.GroupBox()
        Me.rid = New System.Windows.Forms.RadioButton()
        Me.rfuri = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.rseikyuushoid = New System.Windows.Forms.RadioButton()
        Me.rippan = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rand = New System.Windows.Forms.RadioButton()
        Me.ror = New System.Windows.Forms.RadioButton()
        Me.chkmitorihiki = New System.Windows.Forms.CheckBox()
        Me.txtshichousonmei = New System.Windows.Forms.TextBox()
        Me.txtbanchi = New System.Windows.Forms.TextBox()
        Me.txtbikou = New System.Windows.Forms.TextBox()
        Me.txttenpoid = New System.Windows.Forms.TextBox()
        Me.txtfurigana = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.cmbshainid = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtseikyuushoid = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvkekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.gnarabe.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvkekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(1551, 66)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 44)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "検索"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rnouhinshono)
        Me.GroupBox1.Controls.Add(Me.txtnouhinshono)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.gnarabe)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.rseikyuushoid)
        Me.GroupBox1.Controls.Add(Me.rippan)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtseikyuushoid)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1696, 124)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索項目"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(1384, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "）"
        '
        'rnouhinshono
        '
        Me.rnouhinshono.AutoSize = True
        Me.rnouhinshono.Location = New System.Drawing.Point(1106, 42)
        Me.rnouhinshono.Name = "rnouhinshono"
        Me.rnouhinshono.Size = New System.Drawing.Size(86, 18)
        Me.rnouhinshono.TabIndex = 114
        Me.rnouhinshono.Text = "納品書NO"
        Me.rnouhinshono.UseVisualStyleBackColor = True
        '
        'txtnouhinshono
        '
        Me.txtnouhinshono.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtnouhinshono.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtnouhinshono.Location = New System.Drawing.Point(1248, 39)
        Me.txtnouhinshono.MaxLength = 10
        Me.txtnouhinshono.Name = "txtnouhinshono"
        Me.txtnouhinshono.Size = New System.Drawing.Size(130, 22)
        Me.txtnouhinshono.TabIndex = 112
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(1227, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 19)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "("
        '
        'gnarabe
        '
        Me.gnarabe.Controls.Add(Me.rid)
        Me.gnarabe.Controls.Add(Me.rfuri)
        Me.gnarabe.Location = New System.Drawing.Point(1410, 22)
        Me.gnarabe.Name = "gnarabe"
        Me.gnarabe.Size = New System.Drawing.Size(129, 90)
        Me.gnarabe.TabIndex = 111
        Me.gnarabe.TabStop = False
        Me.gnarabe.Text = "並べ替え"
        '
        'rid
        '
        Me.rid.AutoSize = True
        Me.rid.Location = New System.Drawing.Point(28, 53)
        Me.rid.Name = "rid"
        Me.rid.Size = New System.Drawing.Size(51, 18)
        Me.rid.TabIndex = 101
        Me.rid.Text = "ID順"
        Me.rid.UseVisualStyleBackColor = True
        '
        'rfuri
        '
        Me.rfuri.AutoSize = True
        Me.rfuri.Checked = True
        Me.rfuri.Location = New System.Drawing.Point(28, 24)
        Me.rfuri.Name = "rfuri"
        Me.rfuri.Size = New System.Drawing.Size(78, 18)
        Me.rfuri.TabIndex = 100
        Me.rfuri.TabStop = True
        Me.rfuri.Text = "フリガナ順"
        Me.rfuri.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label27.Location = New System.Drawing.Point(1384, 78)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(15, 15)
        Me.Label27.TabIndex = 106
        Me.Label27.Text = "）"
        '
        'rseikyuushoid
        '
        Me.rseikyuushoid.AutoSize = True
        Me.rseikyuushoid.Location = New System.Drawing.Point(1106, 78)
        Me.rseikyuushoid.Name = "rseikyuushoid"
        Me.rseikyuushoid.Size = New System.Drawing.Size(107, 18)
        Me.rseikyuushoid.TabIndex = 103
        Me.rseikyuushoid.Text = "請求書管理ID"
        Me.rseikyuushoid.UseVisualStyleBackColor = True
        '
        'rippan
        '
        Me.rippan.AutoSize = True
        Me.rippan.Checked = True
        Me.rippan.Location = New System.Drawing.Point(26, 21)
        Me.rippan.Name = "rippan"
        Me.rippan.Size = New System.Drawing.Size(81, 18)
        Me.rippan.TabIndex = 98
        Me.rippan.TabStop = True
        Me.rippan.Text = "一般検索"
        Me.rippan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.chkmitorihiki)
        Me.GroupBox3.Controls.Add(Me.txtshichousonmei)
        Me.GroupBox3.Controls.Add(Me.txtbanchi)
        Me.GroupBox3.Controls.Add(Me.txtbikou)
        Me.GroupBox3.Controls.Add(Me.txttenpoid)
        Me.GroupBox3.Controls.Add(Me.txtfurigana)
        Me.GroupBox3.Controls.Add(Me.txttel)
        Me.GroupBox3.Controls.Add(Me.cmbshainid)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1077, 90)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(922, 27)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 44)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "クリア"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rand)
        Me.GroupBox4.Controls.Add(Me.ror)
        Me.GroupBox4.Location = New System.Drawing.Point(984, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(75, 76)
        Me.GroupBox4.TabIndex = 108
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "条件"
        '
        'rand
        '
        Me.rand.AutoSize = True
        Me.rand.Checked = True
        Me.rand.Location = New System.Drawing.Point(16, 20)
        Me.rand.Name = "rand"
        Me.rand.Size = New System.Drawing.Size(52, 18)
        Me.rand.TabIndex = 104
        Me.rand.TabStop = True
        Me.rand.Text = "AND"
        Me.rand.UseVisualStyleBackColor = True
        '
        'ror
        '
        Me.ror.AutoSize = True
        Me.ror.Location = New System.Drawing.Point(16, 50)
        Me.ror.Name = "ror"
        Me.ror.Size = New System.Drawing.Size(44, 18)
        Me.ror.TabIndex = 105
        Me.ror.Text = "OR"
        Me.ror.UseVisualStyleBackColor = True
        '
        'chkmitorihiki
        '
        Me.chkmitorihiki.AutoSize = True
        Me.chkmitorihiki.Checked = True
        Me.chkmitorihiki.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkmitorihiki.Location = New System.Drawing.Point(771, 59)
        Me.chkmitorihiki.Name = "chkmitorihiki"
        Me.chkmitorihiki.Size = New System.Drawing.Size(122, 18)
        Me.chkmitorihiki.TabIndex = 107
        Me.chkmitorihiki.Text = "未取引は非表示"
        Me.chkmitorihiki.UseVisualStyleBackColor = True
        '
        'txtshichousonmei
        '
        Me.txtshichousonmei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtshichousonmei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtshichousonmei.Location = New System.Drawing.Point(327, 20)
        Me.txtshichousonmei.MaxLength = 5
        Me.txtshichousonmei.Name = "txtshichousonmei"
        Me.txtshichousonmei.Size = New System.Drawing.Size(130, 22)
        Me.txtshichousonmei.TabIndex = 60
        '
        'txtbanchi
        '
        Me.txtbanchi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtbanchi.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtbanchi.Location = New System.Drawing.Point(327, 57)
        Me.txtbanchi.Name = "txtbanchi"
        Me.txtbanchi.Size = New System.Drawing.Size(130, 22)
        Me.txtbanchi.TabIndex = 61
        '
        'txtbikou
        '
        Me.txtbikou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtbikou.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtbikou.Location = New System.Drawing.Point(771, 20)
        Me.txtbikou.MaxLength = 13
        Me.txtbikou.Name = "txtbikou"
        Me.txtbikou.Size = New System.Drawing.Size(130, 22)
        Me.txtbikou.TabIndex = 64
        '
        'txttenpoid
        '
        Me.txttenpoid.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txttenpoid.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txttenpoid.Location = New System.Drawing.Point(98, 57)
        Me.txttenpoid.MaxLength = 5
        Me.txttenpoid.Name = "txttenpoid"
        Me.txttenpoid.Size = New System.Drawing.Size(130, 22)
        Me.txttenpoid.TabIndex = 0
        '
        'txtfurigana
        '
        Me.txtfurigana.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtfurigana.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtfurigana.Location = New System.Drawing.Point(98, 20)
        Me.txtfurigana.Name = "txtfurigana"
        Me.txtfurigana.Size = New System.Drawing.Size(130, 22)
        Me.txtfurigana.TabIndex = 1
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txttel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txttel.Location = New System.Drawing.Point(563, 20)
        Me.txttel.MaxLength = 13
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(130, 22)
        Me.txttel.TabIndex = 56
        '
        'cmbshainid
        '
        Me.cmbshainid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbshainid.FormattingEnabled = True
        Me.cmbshainid.Location = New System.Drawing.Point(563, 57)
        Me.cmbshainid.Name = "cmbshainid"
        Me.cmbshainid.Size = New System.Drawing.Size(130, 22)
        Me.cmbshainid.TabIndex = 96
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Location = New System.Drawing.Point(477, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 15)
        Me.Label25.TabIndex = 95
        Me.Label25.Text = "担当社員"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(714, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "備考"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "店舗ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "店舗フリガナ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(477, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "電話番号"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "市町村名"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "番地"
        '
        'txtseikyuushoid
        '
        Me.txtseikyuushoid.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtseikyuushoid.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtseikyuushoid.Location = New System.Drawing.Point(1248, 75)
        Me.txtseikyuushoid.MaxLength = 8
        Me.txtseikyuushoid.Name = "txtseikyuushoid"
        Me.txtseikyuushoid.Size = New System.Drawing.Size(130, 22)
        Me.txtseikyuushoid.TabIndex = 93
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label24.Location = New System.Drawing.Point(1227, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 19)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "("
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(1551, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 44)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "戻る"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dgvkekka)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1693, 710)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "検索結果"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(825, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(372, 15)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "※選択行をダブルクリック、または、エンターキーで表示！！"
        '
        'dgvkekka
        '
        Me.dgvkekka.AllowUserToAddRows = False
        Me.dgvkekka.AllowUserToDeleteRows = False
        Me.dgvkekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkekka.Location = New System.Drawing.Point(16, 25)
        Me.dgvkekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvkekka.Name = "dgvkekka"
        Me.dgvkekka.ReadOnly = True
        Me.dgvkekka.RowTemplate.Height = 24
        Me.dgvkekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkekka.Size = New System.Drawing.Size(1659, 676)
        Me.dgvkekka.TabIndex = 0
        '
        'frmkensaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1716, 850)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmkensaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "検索"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gnarabe.ResumeLayout(False)
        Me.gnarabe.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvkekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfurigana As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttenpoid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvkekka As System.Windows.Forms.DataGridView
    Friend WithEvents txttel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbikou As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbanchi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtshichousonmei As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbshainid As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtseikyuushoid As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents gnarabe As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents rseikyuushoid As RadioButton
    Friend WithEvents rippan As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rid As RadioButton
    Friend WithEvents rfuri As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents rnouhinshono As RadioButton
    Friend WithEvents txtnouhinshono As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rand As RadioButton
    Friend WithEvents ror As RadioButton
    Friend WithEvents chkmitorihiki As CheckBox
    Friend WithEvents Button3 As Button
End Class
