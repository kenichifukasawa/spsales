<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuusho_soushin_ichi
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.chkchuushi = New System.Windows.Forms.CheckBox()
        Me.dgrireki = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chksumi = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgrireki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblpath)
        Me.GroupBox2.Controls.Add(Me.chkchuushi)
        Me.GroupBox2.Controls.Add(Me.dgrireki)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1011, 517)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'lblpath
        '
        Me.lblpath.Location = New System.Drawing.Point(12, 15)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(985, 17)
        Me.lblpath.TabIndex = 144
        Me.lblpath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkchuushi
        '
        Me.chkchuushi.AutoSize = True
        Me.chkchuushi.Location = New System.Drawing.Point(877, 502)
        Me.chkchuushi.Name = "chkchuushi"
        Me.chkchuushi.Size = New System.Drawing.Size(90, 16)
        Me.chkchuushi.TabIndex = 144
        Me.chkchuushi.Text = "STを中止する"
        Me.chkchuushi.UseVisualStyleBackColor = True
        '
        'dgrireki
        '
        Me.dgrireki.AllowUserToAddRows = False
        Me.dgrireki.AllowUserToDeleteRows = False
        Me.dgrireki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrireki.Location = New System.Drawing.Point(14, 35)
        Me.dgrireki.Margin = New System.Windows.Forms.Padding(2)
        Me.dgrireki.MultiSelect = False
        Me.dgrireki.Name = "dgrireki"
        Me.dgrireki.RowTemplate.Height = 24
        Me.dgrireki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgrireki.Size = New System.Drawing.Size(983, 462)
        Me.dgrireki.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.chksumi)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 67)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.Location = New System.Drawing.Point(498, 17)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 44)
        Me.Button4.TabIndex = 145
        Me.Button4.Text = "ST更新（中止）"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(156, 17)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 44)
        Me.Button3.TabIndex = 143
        Me.Button3.Text = "抽出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chksumi
        '
        Me.chksumi.AutoSize = True
        Me.chksumi.Checked = True
        Me.chksumi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksumi.Location = New System.Drawing.Point(25, 32)
        Me.chksumi.Name = "chksumi"
        Me.chksumi.Size = New System.Drawing.Size(105, 16)
        Me.chksumi.TabIndex = 142
        Me.chksumi.Text = "送信済を非表示"
        Me.chksumi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(726, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 44)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "送信"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(877, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 44)
        Me.Button2.TabIndex = 140
        Me.Button2.Text = "戻る"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmseikyuusho_soushin_ichi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmseikyuusho_soushin_ichi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求書送信管理"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgrireki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblpath As Label
    Friend WithEvents chkchuushi As CheckBox
    Friend WithEvents dgrireki As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chksumi As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
