<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshouhinkubun0
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblkubun0id = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblkubun0mei = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtkubun0id = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtkubun0mei = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 99)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "旧業者区分"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lblkubun0id)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox5.TabIndex = 193
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "区分ID"
        '
        'lblkubun0id
        '
        Me.lblkubun0id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblkubun0id.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkubun0id.Location = New System.Drawing.Point(20, 24)
        Me.lblkubun0id.Name = "lblkubun0id"
        Me.lblkubun0id.Size = New System.Drawing.Size(99, 21)
        Me.lblkubun0id.TabIndex = 169
        Me.lblkubun0id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.lblkubun0mei)
        Me.GroupBox6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(161, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox6.TabIndex = 190
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "区分名"
        '
        'lblkubun0mei
        '
        Me.lblkubun0mei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblkubun0mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkubun0mei.Location = New System.Drawing.Point(44, 24)
        Me.lblkubun0mei.Name = "lblkubun0mei"
        Me.lblkubun0mei.Size = New System.Drawing.Size(243, 21)
        Me.lblkubun0mei.TabIndex = 172
        Me.lblkubun0mei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(12, 223)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 46)
        Me.Button1.TabIndex = 201
        Me.Button1.Text = "更新"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(358, 223)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 46)
        Me.Button2.TabIndex = 200
        Me.Button2.Text = "戻る"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.GroupBox12)
        Me.GroupBox11.Controls.Add(Me.GroupBox13)
        Me.GroupBox11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(479, 99)
        Me.GroupBox11.TabIndex = 199
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "新業者区分"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.txtkubun0id)
        Me.GroupBox12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox12.TabIndex = 194
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "区分ID"
        '
        'txtkubun0id
        '
        Me.txtkubun0id.BackColor = System.Drawing.Color.White
        Me.txtkubun0id.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubun0id.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkubun0id.Location = New System.Drawing.Point(23, 24)
        Me.txtkubun0id.MaxLength = 2
        Me.txtkubun0id.Name = "txtkubun0id"
        Me.txtkubun0id.Size = New System.Drawing.Size(96, 22)
        Me.txtkubun0id.TabIndex = 179
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(Me.txtkubun0mei)
        Me.GroupBox13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(161, 21)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox13.TabIndex = 190
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "区分名"
        '
        'txtkubun0mei
        '
        Me.txtkubun0mei.BackColor = System.Drawing.Color.White
        Me.txtkubun0mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubun0mei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtkubun0mei.Location = New System.Drawing.Point(47, 24)
        Me.txtkubun0mei.MaxLength = 20
        Me.txtkubun0mei.Name = "txtkubun0mei"
        Me.txtkubun0mei.Size = New System.Drawing.Size(240, 22)
        Me.txtkubun0mei.TabIndex = 178
        '
        'frmshouhinkubun0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox11)
        Me.Name = "frmshouhinkubun0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "業者区分"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblkubun0id As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblkubun0mei As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents txtkubun0id As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents txtkubun0mei As TextBox
End Class
