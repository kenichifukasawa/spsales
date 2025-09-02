<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuusho_hakkou_insatsu_shousai
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_kekka = New System.Windows.Forms.Label()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.lbl_nyuukin_gaku = New System.Windows.Forms.Label()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tenpo_id = New System.Windows.Forms.Label()
        Me.lbl_hiduke = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_tenpo_mei = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.lbl_nyuukin_gaku)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(635, 972)
        Me.gbx_main.TabIndex = 58
        Me.gbx_main.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lbl_kekka)
        Me.GroupBox1.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 804)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "納品書情報"
        '
        'lbl_kekka
        '
        Me.lbl_kekka.BackColor = System.Drawing.Color.White
        Me.lbl_kekka.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_kekka.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kekka.Location = New System.Drawing.Point(6, 19)
        Me.lbl_kekka.Name = "lbl_kekka"
        Me.lbl_kekka.Size = New System.Drawing.Size(596, 21)
        Me.lbl_kekka.TabIndex = 42
        Me.lbl_kekka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 49)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(598, 750)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'lbl_nyuukin_gaku
        '
        Me.lbl_nyuukin_gaku.BackColor = System.Drawing.Color.White
        Me.lbl_nyuukin_gaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_nyuukin_gaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_nyuukin_gaku.Location = New System.Drawing.Point(627, 52)
        Me.lbl_nyuukin_gaku.Name = "lbl_nyuukin_gaku"
        Me.lbl_nyuukin_gaku.Size = New System.Drawing.Size(125, 21)
        Me.lbl_nyuukin_gaku.TabIndex = 42
        Me.lbl_nyuukin_gaku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Group1.Controls.Add(Me.Label1)
        Me.Group1.Controls.Add(Me.lbl_tenpo_id)
        Me.Group1.Controls.Add(Me.lbl_hiduke)
        Me.Group1.Controls.Add(Me.Label7)
        Me.Group1.Controls.Add(Me.lbl_tenpo_mei)
        Me.Group1.Controls.Add(Me.Label5)
        Me.Group1.Controls.Add(Me.btn_modoru)
        Me.Group1.Controls.Add(Me.btn_shousai)
        Me.Group1.Location = New System.Drawing.Point(13, 19)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(608, 128)
        Me.Group1.TabIndex = 193
        Me.Group1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "まで"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tenpo_id
        '
        Me.lbl_tenpo_id.BackColor = System.Drawing.Color.White
        Me.lbl_tenpo_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_tenpo_id.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_tenpo_id.Location = New System.Drawing.Point(303, 37)
        Me.lbl_tenpo_id.Name = "lbl_tenpo_id"
        Me.lbl_tenpo_id.Size = New System.Drawing.Size(125, 21)
        Me.lbl_tenpo_id.TabIndex = 41
        Me.lbl_tenpo_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_tenpo_id.Visible = False
        '
        'lbl_hiduke
        '
        Me.lbl_hiduke.BackColor = System.Drawing.Color.White
        Me.lbl_hiduke.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_hiduke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_hiduke.Location = New System.Drawing.Point(109, 37)
        Me.lbl_hiduke.Name = "lbl_hiduke"
        Me.lbl_hiduke.Size = New System.Drawing.Size(125, 21)
        Me.lbl_hiduke.TabIndex = 40
        Me.lbl_hiduke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "抽出期間"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tenpo_mei
        '
        Me.lbl_tenpo_mei.BackColor = System.Drawing.Color.White
        Me.lbl_tenpo_mei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_tenpo_mei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_tenpo_mei.Location = New System.Drawing.Point(109, 84)
        Me.lbl_tenpo_mei.Name = "lbl_tenpo_mei"
        Me.lbl_tenpo_mei.Size = New System.Drawing.Size(333, 21)
        Me.lbl_tenpo_mei.TabIndex = 38
        Me.lbl_tenpo_mei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "店舗名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(453, 23)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shousai.Location = New System.Drawing.Point(453, 71)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 36
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'frmseikyuusho_hakkou_insatsu_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmseikyuusho_hakkou_insatsu_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求書詳細"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_shousai As Button
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents btn_modoru As Button
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents lbl_tenpo_id As Label
    Friend WithEvents lbl_hiduke As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_tenpo_mei As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_nyuukin_gaku As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_kekka As Label
    Friend WithEvents Label1 As Label
End Class
