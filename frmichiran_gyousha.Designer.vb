<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmichiran_gyousha
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
        Me.chk_sakujo = New System.Windows.Forms.CheckBox()
        Me.btn_touroku = New System.Windows.Forms.Button()
        Me.btn_henkou = New System.Windows.Forms.Button()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chk_sakujo)
        Me.GroupBox1.Controls.Add(Me.btn_touroku)
        Me.GroupBox1.Controls.Add(Me.btn_henkou)
        Me.GroupBox1.Controls.Add(Me.btn_sakujo)
        Me.GroupBox1.Controls.Add(Me.btn_modoru)
        Me.GroupBox1.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1880, 972)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'chk_sakujo
        '
        Me.chk_sakujo.AutoSize = True
        Me.chk_sakujo.Location = New System.Drawing.Point(1789, 949)
        Me.chk_sakujo.Name = "chk_sakujo"
        Me.chk_sakujo.Size = New System.Drawing.Size(77, 18)
        Me.chk_sakujo.TabIndex = 189
        Me.chk_sakujo.Text = "削除する"
        Me.chk_sakujo.UseVisualStyleBackColor = True
        '
        'btn_touroku
        '
        Me.btn_touroku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_touroku.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_touroku.Location = New System.Drawing.Point(1346, 18)
        Me.btn_touroku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_touroku.Name = "btn_touroku"
        Me.btn_touroku.Size = New System.Drawing.Size(127, 44)
        Me.btn_touroku.TabIndex = 35
        Me.btn_touroku.Text = "登録"
        Me.btn_touroku.UseVisualStyleBackColor = True
        '
        'btn_henkou
        '
        Me.btn_henkou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_henkou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_henkou.Location = New System.Drawing.Point(1477, 18)
        Me.btn_henkou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_henkou.Name = "btn_henkou"
        Me.btn_henkou.Size = New System.Drawing.Size(127, 44)
        Me.btn_henkou.TabIndex = 34
        Me.btn_henkou.Text = "変更"
        Me.btn_henkou.UseVisualStyleBackColor = True
        '
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_sakujo.Location = New System.Drawing.Point(1608, 18)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 33
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1739, 18)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(13, 76)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1853, 868)
        Me.dgv_kensakukekka.TabIndex = 0
        '
        'frmichiran_gyousha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmichiran_gyousha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "業者一覧"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_sakujo As CheckBox
    Friend WithEvents btn_touroku As Button
    Friend WithEvents btn_henkou As Button
    Friend WithEvents btn_sakujo As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents dgv_kensakukekka As DataGridView
End Class
