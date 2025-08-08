<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnouhinsho_idou
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
        Me.gbx_tenpo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_nouhinsho = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.btn_denwachou = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_idou = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_tenpo_2 = New System.Windows.Forms.ComboBox()
        Me.btn_denwachou_1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_tenpo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_tenpo
        '
        Me.gbx_tenpo.Controls.Add(Me.Label2)
        Me.gbx_tenpo.Controls.Add(Me.cbx_nouhinsho)
        Me.gbx_tenpo.Controls.Add(Me.Label1)
        Me.gbx_tenpo.Controls.Add(Me.cbx_tenpo)
        Me.gbx_tenpo.Controls.Add(Me.btn_denwachou)
        Me.gbx_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_tenpo.Location = New System.Drawing.Point(24, 30)
        Me.gbx_tenpo.Name = "gbx_tenpo"
        Me.gbx_tenpo.Size = New System.Drawing.Size(580, 167)
        Me.gbx_tenpo.TabIndex = 194
        Me.gbx_tenpo.TabStop = False
        Me.gbx_tenpo.Text = "移動したい店舗と納品書を選択"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "納品書"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbx_nouhinsho
        '
        Me.cbx_nouhinsho.BackColor = System.Drawing.Color.White
        Me.cbx_nouhinsho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nouhinsho.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_nouhinsho.FormattingEnabled = True
        Me.cbx_nouhinsho.Location = New System.Drawing.Point(23, 118)
        Me.cbx_nouhinsho.Name = "cbx_nouhinsho"
        Me.cbx_nouhinsho.Size = New System.Drawing.Size(397, 24)
        Me.cbx_nouhinsho.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "店舗"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbx_tenpo
        '
        Me.cbx_tenpo.BackColor = System.Drawing.Color.White
        Me.cbx_tenpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tenpo.FormattingEnabled = True
        Me.cbx_tenpo.Location = New System.Drawing.Point(23, 56)
        Me.cbx_tenpo.Name = "cbx_tenpo"
        Me.cbx_tenpo.Size = New System.Drawing.Size(397, 24)
        Me.cbx_tenpo.TabIndex = 128
        '
        'btn_denwachou
        '
        Me.btn_denwachou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwachou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_denwachou.Location = New System.Drawing.Point(425, 47)
        Me.btn_denwachou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwachou.Name = "btn_denwachou"
        Me.btn_denwachou.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwachou.TabIndex = 204
        Me.btn_denwachou.Text = "電話帳"
        Me.btn_denwachou.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btn_idou)
        Me.GroupBox1.Controls.Add(Me.btn_modoru)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.gbx_tenpo)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 535)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "登録済み納品書の移動"
        '
        'btn_idou
        '
        Me.btn_idou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_idou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_idou.Location = New System.Drawing.Point(375, 240)
        Me.btn_idou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_idou.Name = "btn_idou"
        Me.btn_idou.Size = New System.Drawing.Size(127, 44)
        Me.btn_idou.TabIndex = 209
        Me.btn_idou.Text = "下の店舗に移動"
        Me.btn_idou.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(477, 466)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 206
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbx_tenpo_2)
        Me.GroupBox2.Controls.Add(Me.btn_denwachou_1)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 118)
        Me.GroupBox2.TabIndex = 208
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "移動先の店舗を選択"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 205
        Me.Label6.Text = "店舗"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbx_tenpo_2
        '
        Me.cbx_tenpo_2.BackColor = System.Drawing.Color.White
        Me.cbx_tenpo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tenpo_2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tenpo_2.FormattingEnabled = True
        Me.cbx_tenpo_2.Location = New System.Drawing.Point(23, 56)
        Me.cbx_tenpo_2.Name = "cbx_tenpo_2"
        Me.cbx_tenpo_2.Size = New System.Drawing.Size(397, 24)
        Me.cbx_tenpo_2.TabIndex = 128
        '
        'btn_denwachou_1
        '
        Me.btn_denwachou_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwachou_1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_denwachou_1.Location = New System.Drawing.Point(425, 47)
        Me.btn_denwachou_1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwachou_1.Name = "btn_denwachou_1"
        Me.btn_denwachou_1.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwachou_1.TabIndex = 204
        Me.btn_denwachou_1.Text = "電話帳"
        Me.btn_denwachou_1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(580, 45)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "↓↓↓"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmnouhinsho_idou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmnouhinsho_idou"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "納品書移動"
        Me.gbx_tenpo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_tenpo As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents btn_denwachou As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_nouhinsho As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_tenpo_2 As ComboBox
    Friend WithEvents btn_denwachou_1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_modoru As Button
    Friend WithEvents btn_idou As Button
End Class
