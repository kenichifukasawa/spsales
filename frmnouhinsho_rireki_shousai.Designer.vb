<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnouhinsho_rireki_shousai
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
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nouhinsho_no = New System.Windows.Forms.Label()
        Me.lbl_shoukei = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.lbl_hiduke = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_shouhizei_10_per = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_shouhizei_8_per = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_goukei = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_shain_ryakumei = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_gyousha_mei = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbx_main.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.dgv_kensakukekka)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1274, 972)
        Me.gbx_main.TabIndex = 57
        Me.gbx_main.TabStop = False
        Me.gbx_main.Text = "納品書（山梨サロン）"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(24, 258)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1167, 691)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Group1.Controls.Add(Me.GroupBox1)
        Me.Group1.Controls.Add(Me.btn_modoru)
        Me.Group1.Location = New System.Drawing.Point(24, 19)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(1167, 234)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "納品書NO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nouhinsho_no
        '
        Me.lbl_nouhinsho_no.BackColor = System.Drawing.Color.White
        Me.lbl_nouhinsho_no.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nouhinsho_no.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nouhinsho_no.Location = New System.Drawing.Point(123, 49)
        Me.lbl_nouhinsho_no.Name = "lbl_nouhinsho_no"
        Me.lbl_nouhinsho_no.Size = New System.Drawing.Size(113, 21)
        Me.lbl_nouhinsho_no.TabIndex = 34
        Me.lbl_nouhinsho_no.Text = "0000000000"
        Me.lbl_nouhinsho_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shoukei
        '
        Me.lbl_shoukei.BackColor = System.Drawing.Color.White
        Me.lbl_shoukei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shoukei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shoukei.Location = New System.Drawing.Point(266, 49)
        Me.lbl_shoukei.Name = "lbl_shoukei"
        Me.lbl_shoukei.Size = New System.Drawing.Size(88, 21)
        Me.lbl_shoukei.TabIndex = 7
        Me.lbl_shoukei.Text = "100,000,000"
        Me.lbl_shoukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(266, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "小計"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1023, 96)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'lbl_hiduke
        '
        Me.lbl_hiduke.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_hiduke.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_hiduke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_hiduke.Location = New System.Drawing.Point(9, 17)
        Me.lbl_hiduke.Name = "lbl_hiduke"
        Me.lbl_hiduke.Size = New System.Drawing.Size(108, 21)
        Me.lbl_hiduke.TabIndex = 5
        Me.lbl_hiduke.Text = "2025/08/01"
        Me.lbl_hiduke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txt_gyousha_mei)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_shain_ryakumei)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_goukei)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_shouhizei_8_per)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_shouhizei_10_per)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_hiduke)
        Me.GroupBox1.Controls.Add(Me.lbl_shoukei)
        Me.GroupBox1.Controls.Add(Me.lbl_nouhinsho_no)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 119)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "円"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "円"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shouhizei_10_per
        '
        Me.lbl_shouhizei_10_per.BackColor = System.Drawing.Color.White
        Me.lbl_shouhizei_10_per.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shouhizei_10_per.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhizei_10_per.Location = New System.Drawing.Point(394, 49)
        Me.lbl_shouhizei_10_per.Name = "lbl_shouhizei_10_per"
        Me.lbl_shouhizei_10_per.Size = New System.Drawing.Size(88, 21)
        Me.lbl_shouhizei_10_per.TabIndex = 38
        Me.lbl_shouhizei_10_per.Text = "100,000,000"
        Me.lbl_shouhizei_10_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(394, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "消費税(10%)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(613, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "円"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shouhizei_8_per
        '
        Me.lbl_shouhizei_8_per.BackColor = System.Drawing.Color.White
        Me.lbl_shouhizei_8_per.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shouhizei_8_per.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhizei_8_per.Location = New System.Drawing.Point(522, 49)
        Me.lbl_shouhizei_8_per.Name = "lbl_shouhizei_8_per"
        Me.lbl_shouhizei_8_per.Size = New System.Drawing.Size(88, 21)
        Me.lbl_shouhizei_8_per.TabIndex = 41
        Me.lbl_shouhizei_8_per.Text = "100,000,000"
        Me.lbl_shouhizei_8_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(522, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "消費税(8%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(767, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 21)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "円"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_goukei
        '
        Me.lbl_goukei.BackColor = System.Drawing.Color.White
        Me.lbl_goukei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_goukei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_goukei.Location = New System.Drawing.Point(651, 49)
        Me.lbl_goukei.Name = "lbl_goukei"
        Me.lbl_goukei.Size = New System.Drawing.Size(113, 21)
        Me.lbl_goukei.TabIndex = 44
        Me.lbl_goukei.Text = "100,000,000,000"
        Me.lbl_goukei.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(651, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 21)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "合計"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shain_ryakumei
        '
        Me.lbl_shain_ryakumei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_shain_ryakumei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shain_ryakumei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shain_ryakumei.Location = New System.Drawing.Point(9, 49)
        Me.lbl_shain_ryakumei.Name = "lbl_shain_ryakumei"
        Me.lbl_shain_ryakumei.Size = New System.Drawing.Size(108, 21)
        Me.lbl_shain_ryakumei.TabIndex = 46
        Me.lbl_shain_ryakumei.Text = "山梨"
        Me.lbl_shain_ryakumei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "備考"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_gyousha_mei
        '
        Me.txt_gyousha_mei.BackColor = System.Drawing.Color.White
        Me.txt_gyousha_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_gyousha_mei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_gyousha_mei.Location = New System.Drawing.Point(126, 81)
        Me.txt_gyousha_mei.MaxLength = 25
        Me.txt_gyousha_mei.Name = "txt_gyousha_mei"
        Me.txt_gyousha_mei.Size = New System.Drawing.Size(298, 22)
        Me.txt_gyousha_mei.TabIndex = 179
        Me.txt_gyousha_mei.Text = "ああああああああああいいいいいいいいいいううううう"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBox1.Location = New System.Drawing.Point(447, 81)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 22)
        Me.TextBox1.TabIndex = 180
        Me.TextBox1.Text = "ああああああああああいいいいいいいいいいうううううううううう"
        '
        'frmnouhinsho_rireki_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmnouhinsho_rireki_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "納品書詳細"
        Me.gbx_main.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nouhinsho_no As Label
    Friend WithEvents lbl_shoukei As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_hiduke As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_goukei As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_shouhizei_8_per As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_shouhizei_10_per As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_shain_ryakumei As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_gyousha_mei As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
