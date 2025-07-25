<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.lblkanrisha = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ninshou = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblkanrisha)
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Controls.Add(Me.TXTPASSWORD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 142)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'lblkanrisha
        '
        Me.lblkanrisha.BackColor = System.Drawing.SystemColors.Control
        Me.lblkanrisha.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblkanrisha.Location = New System.Drawing.Point(17, 2)
        Me.lblkanrisha.Name = "lblkanrisha"
        Me.lblkanrisha.Size = New System.Drawing.Size(23, 27)
        Me.lblkanrisha.TabIndex = 30
        Me.lblkanrisha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblkanrisha.Visible = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(20, 32)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(84, 93)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 27
        Me.LogoPictureBox.TabStop = False
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TXTPASSWORD.Location = New System.Drawing.Point(152, 71)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD.Size = New System.Drawing.Size(190, 22)
        Me.TXTPASSWORD.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "パスワードを入力してください。"
        '
        'btn_ninshou
        '
        Me.btn_ninshou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ninshou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ninshou.Location = New System.Drawing.Point(424, 31)
        Me.btn_ninshou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ninshou.Name = "btn_ninshou"
        Me.btn_ninshou.Size = New System.Drawing.Size(112, 44)
        Me.btn_ninshou.TabIndex = 33
        Me.btn_ninshou.Text = "認証"
        Me.btn_ninshou.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(424, 93)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 44)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_ninshou)
        Me.Controls.Add(Me.Button2)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblkanrisha As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents TXTPASSWORD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ninshou As Button
    Friend WithEvents Button2 As Button
End Class
