<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuukei_sentaku
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_gyousha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_kubun = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_shouhin = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btn_modoru)
        Me.GroupBox3.Location = New System.Drawing.Point(552, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(13, 89)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(147, 44)
        Me.btn_modoru.TabIndex = 97
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_gyousha)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 54)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "「販売集計」情報の管理をします。"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_gyousha
        '
        Me.btn_gyousha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gyousha.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_gyousha.Location = New System.Drawing.Point(13, 89)
        Me.btn_gyousha.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gyousha.Name = "btn_gyousha"
        Me.btn_gyousha.Size = New System.Drawing.Size(147, 44)
        Me.btn_gyousha.TabIndex = 97
        Me.btn_gyousha.Text = "販売集計"
        Me.btn_gyousha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_kubun)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "「売上集計」情報の管理をします。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_kubun
        '
        Me.btn_kubun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kubun.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kubun.Location = New System.Drawing.Point(13, 89)
        Me.btn_kubun.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kubun.Name = "btn_kubun"
        Me.btn_kubun.Size = New System.Drawing.Size(147, 44)
        Me.btn_kubun.TabIndex = 97
        Me.btn_kubun.Text = "売上集計"
        Me.btn_kubun.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.White
        Me.GroupBox16.Controls.Add(Me.Label21)
        Me.GroupBox16.Controls.Add(Me.btn_shouhin)
        Me.GroupBox16.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox16.TabIndex = 119
        Me.GroupBox16.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 54)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "「商品集計」情報の管理をします。"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_shouhin
        '
        Me.btn_shouhin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shouhin.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shouhin.Location = New System.Drawing.Point(13, 89)
        Me.btn_shouhin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shouhin.Name = "btn_shouhin"
        Me.btn_shouhin.Size = New System.Drawing.Size(147, 44)
        Me.btn_shouhin.TabIndex = 97
        Me.btn_shouhin.Text = "商品集計"
        Me.btn_shouhin.UseVisualStyleBackColor = True
        '
        'frmshuukei_sentaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox16)
        Me.Name = "frmshuukei_sentaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集計"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_gyousha As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_kubun As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_shouhin As Button
End Class
