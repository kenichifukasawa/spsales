<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshouhinkubun1
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
        Me.lblkubunid = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblkubunmei = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtkubunid = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtkubunmei = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 99)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "旧区分１"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lblkubunid)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox5.TabIndex = 193
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "区分ID"
        '
        'lblkubunid
        '
        Me.lblkubunid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblkubunid.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkubunid.Location = New System.Drawing.Point(20, 24)
        Me.lblkubunid.Name = "lblkubunid"
        Me.lblkubunid.Size = New System.Drawing.Size(99, 21)
        Me.lblkubunid.TabIndex = 169
        Me.lblkubunid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.lblkubunmei)
        Me.GroupBox6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(161, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox6.TabIndex = 190
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "区分名"
        '
        'lblkubunmei
        '
        Me.lblkubunmei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblkubunmei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkubunmei.Location = New System.Drawing.Point(44, 24)
        Me.lblkubunmei.Name = "lblkubunmei"
        Me.lblkubunmei.Size = New System.Drawing.Size(243, 21)
        Me.lblkubunmei.TabIndex = 172
        Me.lblkubunmei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(14, 224)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 46)
        Me.Button1.TabIndex = 205
        Me.Button1.Text = "更新"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(360, 224)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 46)
        Me.Button2.TabIndex = 204
        Me.Button2.Text = "戻る"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.GroupBox12)
        Me.GroupBox11.Controls.Add(Me.GroupBox13)
        Me.GroupBox11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(14, 118)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(479, 99)
        Me.GroupBox11.TabIndex = 203
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "新区分１"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.txtkubunid)
        Me.GroupBox12.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox12.TabIndex = 194
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "区分ID"
        '
        'txtkubunid
        '
        Me.txtkubunid.BackColor = System.Drawing.Color.White
        Me.txtkubunid.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubunid.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtkubunid.Location = New System.Drawing.Point(23, 24)
        Me.txtkubunid.MaxLength = 2
        Me.txtkubunid.Name = "txtkubunid"
        Me.txtkubunid.Size = New System.Drawing.Size(96, 22)
        Me.txtkubunid.TabIndex = 179
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(Me.txtkubunmei)
        Me.GroupBox13.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(161, 21)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox13.TabIndex = 190
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "区分名"
        '
        'txtkubunmei
        '
        Me.txtkubunmei.BackColor = System.Drawing.Color.White
        Me.txtkubunmei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtkubunmei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtkubunmei.Location = New System.Drawing.Point(47, 24)
        Me.txtkubunmei.MaxLength = 20
        Me.txtkubunmei.Name = "txtkubunmei"
        Me.txtkubunmei.Size = New System.Drawing.Size(240, 22)
        Me.txtkubunmei.TabIndex = 178
        '
        'frmshouhinkubun1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox11)
        Me.Name = "frmshouhinkubun1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "区分１"
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
    Friend WithEvents lblkubunid As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblkubunmei As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents txtkubunid As TextBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents txtkubunmei As TextBox
End Class
