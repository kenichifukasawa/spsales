<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.btn_touroku = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_del = New System.Windows.Forms.Label()
        Me.lbl_log_id = New System.Windows.Forms.Label()
        Me.cbx_status = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_shain_mei = New System.Windows.Forms.Label()
        Me.cbx_log_kubun = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtlog = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_sakujo)
        Me.GroupBox1.Controls.Add(Me.btn_touroku)
        Me.GroupBox1.Controls.Add(Me.btn_modoru)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(617, 71)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_sakujo.Location = New System.Drawing.Point(15, 18)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 35
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        Me.btn_sakujo.Visible = False
        '
        'btn_touroku
        '
        Me.btn_touroku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_touroku.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_touroku.Location = New System.Drawing.Point(332, 18)
        Me.btn_touroku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_touroku.Name = "btn_touroku"
        Me.btn_touroku.Size = New System.Drawing.Size(127, 44)
        Me.btn_touroku.TabIndex = 34
        Me.btn_touroku.Text = "登録"
        Me.btn_touroku.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(475, 18)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_del)
        Me.GroupBox2.Controls.Add(Me.lbl_log_id)
        Me.GroupBox2.Controls.Add(Me.cbx_status)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_shain_mei)
        Me.GroupBox2.Controls.Add(Me.cbx_log_kubun)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.txtlog)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 358)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ログ情報"
        '
        'lbl_del
        '
        Me.lbl_del.BackColor = System.Drawing.Color.White
        Me.lbl_del.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_del.ForeColor = System.Drawing.Color.Red
        Me.lbl_del.Location = New System.Drawing.Point(205, 81)
        Me.lbl_del.Name = "lbl_del"
        Me.lbl_del.Size = New System.Drawing.Size(101, 16)
        Me.lbl_del.TabIndex = 120
        Me.lbl_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_log_id
        '
        Me.lbl_log_id.BackColor = System.Drawing.Color.White
        Me.lbl_log_id.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_log_id.Location = New System.Drawing.Point(86, 0)
        Me.lbl_log_id.Name = "lbl_log_id"
        Me.lbl_log_id.Size = New System.Drawing.Size(130, 16)
        Me.lbl_log_id.TabIndex = 119
        Me.lbl_log_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbx_status
        '
        Me.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_status.FormattingEnabled = True
        Me.cbx_status.Location = New System.Drawing.Point(475, 79)
        Me.cbx_status.Name = "cbx_status"
        Me.cbx_status.Size = New System.Drawing.Size(103, 23)
        Me.cbx_status.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "状況"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shain_mei
        '
        Me.lbl_shain_mei.BackColor = System.Drawing.Color.White
        Me.lbl_shain_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shain_mei.Location = New System.Drawing.Point(477, 41)
        Me.lbl_shain_mei.Name = "lbl_shain_mei"
        Me.lbl_shain_mei.Size = New System.Drawing.Size(101, 16)
        Me.lbl_shain_mei.TabIndex = 100
        Me.lbl_shain_mei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbx_log_kubun
        '
        Me.cbx_log_kubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_log_kubun.FormattingEnabled = True
        Me.cbx_log_kubun.Location = New System.Drawing.Point(153, 39)
        Me.cbx_log_kubun.Name = "cbx_log_kubun"
        Me.cbx_log_kubun.Size = New System.Drawing.Size(153, 23)
        Me.cbx_log_kubun.TabIndex = 99
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 41)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(111, 16)
        Me.Label36.TabIndex = 98
        Me.Label36.Text = "区分"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtlog
        '
        Me.txtlog.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtlog.Location = New System.Drawing.Point(15, 116)
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(587, 225)
        Me.txtlog.TabIndex = 97
        Me.txtlog.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "内容"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "社員名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmlog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログ管理"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_touroku As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlog As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_shain_mei As Label
    Friend WithEvents cbx_log_kubun As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cbx_status As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_log_id As Label
    Friend WithEvents lbl_del As Label
    Friend WithEvents btn_sakujo As Button
End Class
