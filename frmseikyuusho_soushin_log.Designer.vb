<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuusho_soushin_log
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlog = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtlog)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 459)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "状況"
        '
        'txtlog
        '
        Me.txtlog.Location = New System.Drawing.Point(6, 14)
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(624, 390)
        Me.txtlog.TabIndex = 1
        Me.txtlog.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "戻る"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmseikyuusho_soushin_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmseikyuusho_soushin_log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求書メール送信状況"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtlog As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
