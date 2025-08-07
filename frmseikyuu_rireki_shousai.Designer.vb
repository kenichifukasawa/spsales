<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuu_rireki_shousai
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
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_bikou = New System.Windows.Forms.TextBox()
        Me.btn_koushin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_seikyuu_gaku = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_nyuukin_gaku = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_zengetsu_seikyuu_gaku = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_goukei = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_shouhizei = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hiduke = New System.Windows.Forms.Label()
        Me.lbl_shoukei = New System.Windows.Forms.Label()
        Me.lbl_seikyuusho_id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(12, 12)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Size = New System.Drawing.Size(1132, 970)
        Me.gbx_main.TabIndex = 191
        Me.gbx_main.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1120, 795)
        Me.GroupBox3.TabIndex = 194
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "請求書内容詳細"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 20)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1110, 770)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_bikou)
        Me.GroupBox2.Controls.Add(Me.btn_koushin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(953, 62)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        '
        'txt_bikou
        '
        Me.txt_bikou.BackColor = System.Drawing.Color.White
        Me.txt_bikou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_bikou.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_bikou.Location = New System.Drawing.Point(207, 25)
        Me.txt_bikou.MaxLength = 50
        Me.txt_bikou.Name = "txt_bikou"
        Me.txt_bikou.Size = New System.Drawing.Size(505, 22)
        Me.txt_bikou.TabIndex = 179
        Me.txt_bikou.Text = "今日は朝から天気が良く、公園で友人と楽しく散歩をしながら会話を楽しみました。"
        '
        'btn_koushin
        '
        Me.btn_koushin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_koushin.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_koushin.Location = New System.Drawing.Point(735, 18)
        Me.btn_koushin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_koushin.Name = "btn_koushin"
        Me.btn_koushin.Size = New System.Drawing.Size(92, 34)
        Me.btn_koushin.TabIndex = 193
        Me.btn_koushin.Text = "備考更新"
        Me.btn_koushin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "備考"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuu_gaku)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_nyuukin_gaku)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_zengetsu_seikyuu_gaku)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_goukei)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_shouhizei)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_hiduke)
        Me.GroupBox1.Controls.Add(Me.lbl_shoukei)
        Me.GroupBox1.Controls.Add(Me.lbl_seikyuusho_id)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1120, 82)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(1049, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 21)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "円"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_seikyuu_gaku
        '
        Me.lbl_seikyuu_gaku.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuu_gaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuu_gaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuu_gaku.Location = New System.Drawing.Point(958, 43)
        Me.lbl_seikyuu_gaku.Name = "lbl_seikyuu_gaku"
        Me.lbl_seikyuu_gaku.Size = New System.Drawing.Size(88, 21)
        Me.lbl_seikyuu_gaku.TabIndex = 54
        Me.lbl_seikyuu_gaku.Text = "100,000,000"
        Me.lbl_seikyuu_gaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(958, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 21)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "請求額"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(920, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "円"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nyuukin_gaku
        '
        Me.lbl_nyuukin_gaku.BackColor = System.Drawing.Color.White
        Me.lbl_nyuukin_gaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nyuukin_gaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nyuukin_gaku.Location = New System.Drawing.Point(829, 43)
        Me.lbl_nyuukin_gaku.Name = "lbl_nyuukin_gaku"
        Me.lbl_nyuukin_gaku.Size = New System.Drawing.Size(88, 21)
        Me.lbl_nyuukin_gaku.TabIndex = 51
        Me.lbl_nyuukin_gaku.Text = "100,000,000"
        Me.lbl_nyuukin_gaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(829, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "入金額"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(791, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "円"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_zengetsu_seikyuu_gaku
        '
        Me.lbl_zengetsu_seikyuu_gaku.BackColor = System.Drawing.Color.White
        Me.lbl_zengetsu_seikyuu_gaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_zengetsu_seikyuu_gaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_zengetsu_seikyuu_gaku.Location = New System.Drawing.Point(700, 43)
        Me.lbl_zengetsu_seikyuu_gaku.Name = "lbl_zengetsu_seikyuu_gaku"
        Me.lbl_zengetsu_seikyuu_gaku.Size = New System.Drawing.Size(88, 21)
        Me.lbl_zengetsu_seikyuu_gaku.TabIndex = 48
        Me.lbl_zengetsu_seikyuu_gaku.Text = "100,000,000"
        Me.lbl_zengetsu_seikyuu_gaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(700, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "前月請求額"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(663, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "円"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_goukei
        '
        Me.lbl_goukei.BackColor = System.Drawing.Color.White
        Me.lbl_goukei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_goukei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_goukei.Location = New System.Drawing.Point(572, 43)
        Me.lbl_goukei.Name = "lbl_goukei"
        Me.lbl_goukei.Size = New System.Drawing.Size(88, 21)
        Me.lbl_goukei.TabIndex = 41
        Me.lbl_goukei.Text = "100,000,000"
        Me.lbl_goukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(572, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "売上額合計"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "円"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shouhizei
        '
        Me.lbl_shouhizei.BackColor = System.Drawing.Color.White
        Me.lbl_shouhizei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shouhizei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhizei.Location = New System.Drawing.Point(444, 43)
        Me.lbl_shouhizei.Name = "lbl_shouhizei"
        Me.lbl_shouhizei.Size = New System.Drawing.Size(88, 21)
        Me.lbl_shouhizei.TabIndex = 38
        Me.lbl_shouhizei.Text = "100,000,000"
        Me.lbl_shouhizei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "消費税"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "円"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_hiduke
        '
        Me.lbl_hiduke.BackColor = System.Drawing.Color.White
        Me.lbl_hiduke.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_hiduke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_hiduke.Location = New System.Drawing.Point(38, 43)
        Me.lbl_hiduke.Name = "lbl_hiduke"
        Me.lbl_hiduke.Size = New System.Drawing.Size(113, 21)
        Me.lbl_hiduke.TabIndex = 5
        Me.lbl_hiduke.Text = "2025/08/01"
        Me.lbl_hiduke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shoukei
        '
        Me.lbl_shoukei.BackColor = System.Drawing.Color.White
        Me.lbl_shoukei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shoukei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shoukei.Location = New System.Drawing.Point(316, 43)
        Me.lbl_shoukei.Name = "lbl_shoukei"
        Me.lbl_shoukei.Size = New System.Drawing.Size(88, 21)
        Me.lbl_shoukei.TabIndex = 7
        Me.lbl_shoukei.Text = "100,000,000"
        Me.lbl_shoukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_seikyuusho_id
        '
        Me.lbl_seikyuusho_id.BackColor = System.Drawing.Color.White
        Me.lbl_seikyuusho_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_seikyuusho_id.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_seikyuusho_id.Location = New System.Drawing.Point(177, 43)
        Me.lbl_seikyuusho_id.Name = "lbl_seikyuusho_id"
        Me.lbl_seikyuusho_id.Size = New System.Drawing.Size(113, 21)
        Me.lbl_seikyuusho_id.TabIndex = 34
        Me.lbl_seikyuusho_id.Text = "0000000000"
        Me.lbl_seikyuusho_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "売上額小計"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "請求書ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(973, 114)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmseikyuu_rireki_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmseikyuu_rireki_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "発行済請求履歴詳細"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_bikou As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_goukei As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_shouhizei As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_hiduke As Label
    Friend WithEvents lbl_shoukei As Label
    Friend WithEvents lbl_seikyuusho_id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_modoru As Button
    Friend WithEvents btn_koushin As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_seikyuu_gaku As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nyuukin_gaku As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_zengetsu_seikyuu_gaku As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
