<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuturyoku_csv
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
        Me.chk_mishiyou_shouhin = New System.Windows.Forms.CheckBox()
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.lbl_shutsuryoku_type = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbl_shutsuryoku_type)
        Me.GroupBox1.Controls.Add(Me.chk_mishiyou_shouhin)
        Me.GroupBox1.Controls.Add(Me.btn_csv)
        Me.GroupBox1.Controls.Add(Me.btn_modoru)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 105)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'chk_mishiyou_shouhin
        '
        Me.chk_mishiyou_shouhin.AutoSize = True
        Me.chk_mishiyou_shouhin.Location = New System.Drawing.Point(56, 71)
        Me.chk_mishiyou_shouhin.Name = "chk_mishiyou_shouhin"
        Me.chk_mishiyou_shouhin.Size = New System.Drawing.Size(199, 18)
        Me.chk_mishiyou_shouhin.TabIndex = 189
        Me.chk_mishiyou_shouhin.Text = "使用していない商品も出力する"
        Me.chk_mishiyou_shouhin.UseVisualStyleBackColor = True
        '
        'btn_csv
        '
        Me.btn_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_csv.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_csv.Location = New System.Drawing.Point(309, 31)
        Me.btn_csv.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.Size = New System.Drawing.Size(127, 44)
        Me.btn_csv.TabIndex = 34
        Me.btn_csv.Text = "CSV出力"
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(440, 31)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'lbl_shutsuryoku_type
        '
        Me.lbl_shutsuryoku_type.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shutsuryoku_type.Location = New System.Drawing.Point(26, 25)
        Me.lbl_shutsuryoku_type.Name = "lbl_shutsuryoku_type"
        Me.lbl_shutsuryoku_type.Size = New System.Drawing.Size(259, 32)
        Me.lbl_shutsuryoku_type.TabIndex = 190
        Me.lbl_shutsuryoku_type.Text = "出力データ名"
        Me.lbl_shutsuryoku_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmshuturyoku_csv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 125)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmshuturyoku_csv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "データ出力"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_mishiyou_shouhin As CheckBox
    Friend WithEvents btn_csv As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_shutsuryoku_type As Label
End Class
