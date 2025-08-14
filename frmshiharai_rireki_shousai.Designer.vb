<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiharai_rireki_shousai
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
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_shukkin_id = New System.Windows.Forms.Label()
        Me.lbl_kingaku = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.lbl_hiduke = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_shiiresaki = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.dgv_kensakukekka)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(555, 972)
        Me.gbx_main.TabIndex = 57
        Me.gbx_main.TabStop = False
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(24, 200)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(506, 749)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Group1.Controls.Add(Me.btn_shousai)
        Me.Group1.Controls.Add(Me.Label2)
        Me.Group1.Controls.Add(Me.lbl_shukkin_id)
        Me.Group1.Controls.Add(Me.lbl_kingaku)
        Me.Group1.Controls.Add(Me.Label9)
        Me.Group1.Controls.Add(Me.btn_modoru)
        Me.Group1.Controls.Add(Me.lbl_hiduke)
        Me.Group1.Controls.Add(Me.Label7)
        Me.Group1.Controls.Add(Me.lbl_shiiresaki)
        Me.Group1.Controls.Add(Me.Label5)
        Me.Group1.Location = New System.Drawing.Point(24, 19)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(506, 176)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shousai.Location = New System.Drawing.Point(230, 118)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 36
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "支払ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shukkin_id
        '
        Me.lbl_shukkin_id.BackColor = System.Drawing.Color.White
        Me.lbl_shukkin_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shukkin_id.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shukkin_id.Location = New System.Drawing.Point(337, 34)
        Me.lbl_shukkin_id.Name = "lbl_shukkin_id"
        Me.lbl_shukkin_id.Size = New System.Drawing.Size(125, 21)
        Me.lbl_shukkin_id.TabIndex = 34
        Me.lbl_shukkin_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_kingaku
        '
        Me.lbl_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kingaku.Location = New System.Drawing.Point(111, 128)
        Me.lbl_kingaku.Name = "lbl_kingaku"
        Me.lbl_kingaku.Size = New System.Drawing.Size(103, 21)
        Me.lbl_kingaku.TabIndex = 7
        Me.lbl_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "合計金額"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(361, 118)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'lbl_hiduke
        '
        Me.lbl_hiduke.BackColor = System.Drawing.Color.White
        Me.lbl_hiduke.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_hiduke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_hiduke.Location = New System.Drawing.Point(89, 34)
        Me.lbl_hiduke.Name = "lbl_hiduke"
        Me.lbl_hiduke.Size = New System.Drawing.Size(125, 21)
        Me.lbl_hiduke.TabIndex = 5
        Me.lbl_hiduke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "支払日"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shiiresaki
        '
        Me.lbl_shiiresaki.BackColor = System.Drawing.Color.White
        Me.lbl_shiiresaki.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shiiresaki.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shiiresaki.Location = New System.Drawing.Point(89, 81)
        Me.lbl_shiiresaki.Name = "lbl_shiiresaki"
        Me.lbl_shiiresaki.Size = New System.Drawing.Size(333, 21)
        Me.lbl_shiiresaki.TabIndex = 3
        Me.lbl_shiiresaki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "仕入先"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshiharai_rireki_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshiharai_rireki_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "支払詳細"
        Me.gbx_main.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_shukkin_id As Label
    Friend WithEvents lbl_kingaku As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_hiduke As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_shiiresaki As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_shousai As Button
End Class
