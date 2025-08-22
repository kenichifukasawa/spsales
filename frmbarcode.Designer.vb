<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbarcode
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtshiteikin = New System.Windows.Forms.TextBox()
        Me.ltanka = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtshiteikosuu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblshouhin1 = New System.Windows.Forms.Label()
        Me.txtbaercode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltanka = New System.Windows.Forms.Label()
        Me.lblkeigen = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblkeigen)
        Me.GroupBox1.Controls.Add(Me.lbltanka)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtshiteikin)
        Me.GroupBox1.Controls.Add(Me.ltanka)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtshiteikosuu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblshouhin1)
        Me.GroupBox1.Controls.Add(Me.txtbaercode)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "詳細"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(513, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "円"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtshiteikin
        '
        Me.txtshiteikin.BackColor = System.Drawing.Color.White
        Me.txtshiteikin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtshiteikin.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtshiteikin.Location = New System.Drawing.Point(400, 158)
        Me.txtshiteikin.MaxLength = 7
        Me.txtshiteikin.Name = "txtshiteikin"
        Me.txtshiteikin.Size = New System.Drawing.Size(107, 23)
        Me.txtshiteikin.TabIndex = 209
        '
        'ltanka
        '
        Me.ltanka.BackColor = System.Drawing.Color.White
        Me.ltanka.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ltanka.Location = New System.Drawing.Point(285, 160)
        Me.ltanka.Name = "ltanka"
        Me.ltanka.Size = New System.Drawing.Size(91, 16)
        Me.ltanka.TabIndex = 208
        Me.ltanka.Text = "単価"
        Me.ltanka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "個"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtshiteikosuu
        '
        Me.txtshiteikosuu.BackColor = System.Drawing.Color.White
        Me.txtshiteikosuu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtshiteikosuu.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtshiteikosuu.Location = New System.Drawing.Point(142, 159)
        Me.txtshiteikosuu.MaxLength = 3
        Me.txtshiteikosuu.Name = "txtshiteikosuu"
        Me.txtshiteikosuu.Size = New System.Drawing.Size(64, 23)
        Me.txtshiteikosuu.TabIndex = 206
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "個数"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "商品名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblshouhin1
        '
        Me.lblshouhin1.BackColor = System.Drawing.Color.White
        Me.lblshouhin1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblshouhin1.Location = New System.Drawing.Point(139, 96)
        Me.lblshouhin1.Name = "lblshouhin1"
        Me.lblshouhin1.Size = New System.Drawing.Size(442, 22)
        Me.lblshouhin1.TabIndex = 203
        Me.lblshouhin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbaercode
        '
        Me.txtbaercode.BackColor = System.Drawing.Color.White
        Me.txtbaercode.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtbaercode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtbaercode.Location = New System.Drawing.Point(142, 42)
        Me.txtbaercode.MaxLength = 50
        Me.txtbaercode.Name = "txtbaercode"
        Me.txtbaercode.Size = New System.Drawing.Size(245, 23)
        Me.txtbaercode.TabIndex = 202
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(27, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 201
        Me.Label21.Text = "バーコード"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_info
        '
        Me.btn_info.BackColor = System.Drawing.SystemColors.Control
        Me.btn_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_info.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_info.Location = New System.Drawing.Point(487, 248)
        Me.btn_info.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(133, 44)
        Me.btn_info.TabIndex = 143
        Me.btn_info.Text = "戻る"
        Me.btn_info.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 248)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(471, 44)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "登録"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltanka
        '
        Me.lbltanka.BackColor = System.Drawing.SystemColors.Control
        Me.lbltanka.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbltanka.Location = New System.Drawing.Point(400, 184)
        Me.lbltanka.Name = "lbltanka"
        Me.lbltanka.Size = New System.Drawing.Size(107, 22)
        Me.lbltanka.TabIndex = 211
        Me.lbltanka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblkeigen
        '
        Me.lblkeigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblkeigen.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkeigen.Location = New System.Drawing.Point(457, 18)
        Me.lblkeigen.Name = "lblkeigen"
        Me.lblkeigen.Size = New System.Drawing.Size(107, 22)
        Me.lblkeigen.TabIndex = 212
        Me.lblkeigen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmbarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_info)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmbarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品指定画面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbaercode As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtshiteikin As TextBox
    Friend WithEvents ltanka As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtshiteikosuu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblshouhin1 As Label
    Friend WithEvents btn_info As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbltanka As Label
    Friend WithEvents lblkeigen As Label
End Class
