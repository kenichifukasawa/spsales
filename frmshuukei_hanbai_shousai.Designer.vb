<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuukei_hanbai_shousai
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
        Me.lbl_kingaku = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.lbl_kosuu = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_shouhin_mei = New System.Windows.Forms.Label()
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
        Me.gbx_main.Size = New System.Drawing.Size(619, 804)
        Me.gbx_main.TabIndex = 55
        Me.gbx_main.TabStop = False
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(24, 161)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(572, 616)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group1
        '
        Me.Group1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Group1.Controls.Add(Me.lbl_kingaku)
        Me.Group1.Controls.Add(Me.Label9)
        Me.Group1.Controls.Add(Me.btn_modoru)
        Me.Group1.Controls.Add(Me.lbl_kosuu)
        Me.Group1.Controls.Add(Me.Label7)
        Me.Group1.Controls.Add(Me.lbl_shouhin_mei)
        Me.Group1.Controls.Add(Me.Label5)
        Me.Group1.Location = New System.Drawing.Point(24, 19)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(572, 137)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        '
        'lbl_kingaku
        '
        Me.lbl_kingaku.BackColor = System.Drawing.Color.White
        Me.lbl_kingaku.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_kingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kingaku.Location = New System.Drawing.Point(279, 81)
        Me.lbl_kingaku.Name = "lbl_kingaku"
        Me.lbl_kingaku.Size = New System.Drawing.Size(98, 21)
        Me.lbl_kingaku.TabIndex = 7
        Me.lbl_kingaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(212, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "金額"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(415, 81)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'lbl_kosuu
        '
        Me.lbl_kosuu.BackColor = System.Drawing.Color.White
        Me.lbl_kosuu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_kosuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kosuu.Location = New System.Drawing.Point(90, 81)
        Me.lbl_kosuu.Name = "lbl_kosuu"
        Me.lbl_kosuu.Size = New System.Drawing.Size(98, 21)
        Me.lbl_kosuu.TabIndex = 5
        Me.lbl_kosuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "個数"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_shouhin_mei
        '
        Me.lbl_shouhin_mei.BackColor = System.Drawing.Color.White
        Me.lbl_shouhin_mei.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_shouhin_mei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shouhin_mei.Location = New System.Drawing.Point(90, 34)
        Me.lbl_shouhin_mei.Name = "lbl_shouhin_mei"
        Me.lbl_shouhin_mei.Size = New System.Drawing.Size(452, 21)
        Me.lbl_shouhin_mei.TabIndex = 3
        Me.lbl_shouhin_mei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "商品名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshuukei_hanbai_shousai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 831)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshuukei_hanbai_shousai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "詳細情報"
        Me.gbx_main.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents lbl_kingaku As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_kosuu As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_shouhin_mei As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_modoru As Button
End Class
