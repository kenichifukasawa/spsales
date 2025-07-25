<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhajime
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.lblshinkou = New System.Windows.Forms.Label()
        Me.lstshinkou = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(30, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(207, 62)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(232, 78)
        Me.ApplicationTitle.TabIndex = 1
        Me.ApplicationTitle.Text = "SP Sales"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(467, 140)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(188, 20)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(524, 43)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(143, 20)
        Me.Copyright.TabIndex = 3
        Me.Copyright.Text = "著作権"
        '
        'lblshinkou
        '
        Me.lblshinkou.AutoSize = True
        Me.lblshinkou.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblshinkou.Location = New System.Drawing.Point(237, 164)
        Me.lblshinkou.Name = "lblshinkou"
        Me.lblshinkou.Size = New System.Drawing.Size(0, 13)
        Me.lblshinkou.TabIndex = 4
        '
        'lstshinkou
        '
        Me.lstshinkou.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstshinkou.FormattingEnabled = True
        Me.lstshinkou.ItemHeight = 15
        Me.lstshinkou.Location = New System.Drawing.Point(30, 203)
        Me.lstshinkou.Name = "lstshinkou"
        Me.lstshinkou.Size = New System.Drawing.Size(634, 139)
        Me.lstshinkou.TabIndex = 7
        '
        'frmhajime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstshinkou)
        Me.Controls.Add(Me.lblshinkou)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmhajime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents lblshinkou As System.Windows.Forms.Label
    Friend WithEvents lstshinkou As ListBox
End Class
