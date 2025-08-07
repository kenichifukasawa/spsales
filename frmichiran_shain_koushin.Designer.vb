<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmichiran_shain_koushin
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
        Me.btn_koushin = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_shin = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_zaishoku = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_shain_ryaku_mei = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_shain_mei = New System.Windows.Forms.TextBox()
        Me.gbx_kyuu = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_shain_id = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lbl_zaishoku = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbl_shain_ryaku_mei = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lbl_shain_mei = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.gbx_shin.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbx_kyuu.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_koushin
        '
        Me.btn_koushin.BackColor = System.Drawing.SystemColors.Control
        Me.btn_koushin.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_koushin.Location = New System.Drawing.Point(12, 223)
        Me.btn_koushin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_koushin.Name = "btn_koushin"
        Me.btn_koushin.Size = New System.Drawing.Size(751, 46)
        Me.btn_koushin.TabIndex = 165
        Me.btn_koushin.Text = "登録 OR 変更"
        Me.btn_koushin.UseVisualStyleBackColor = False
        '
        'btn_modoru
        '
        Me.btn_modoru.BackColor = System.Drawing.SystemColors.Control
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(771, 222)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(224, 46)
        Me.btn_modoru.TabIndex = 164
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = False
        '
        'gbx_shin
        '
        Me.gbx_shin.BackColor = System.Drawing.Color.White
        Me.gbx_shin.Controls.Add(Me.GroupBox5)
        Me.gbx_shin.Controls.Add(Me.GroupBox4)
        Me.gbx_shin.Controls.Add(Me.GroupBox3)
        Me.gbx_shin.Controls.Add(Me.GroupBox2)
        Me.gbx_shin.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_shin.Location = New System.Drawing.Point(12, 117)
        Me.gbx_shin.Name = "gbx_shin"
        Me.gbx_shin.Size = New System.Drawing.Size(983, 99)
        Me.gbx_shin.TabIndex = 163
        Me.gbx_shin.TabStop = False
        Me.gbx_shin.Text = "新社員詳細"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.chk_zaishoku)
        Me.GroupBox4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(684, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox4.TabIndex = 192
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "在職表示"
        '
        'chk_zaishoku
        '
        Me.chk_zaishoku.AutoSize = True
        Me.chk_zaishoku.Location = New System.Drawing.Point(19, 26)
        Me.chk_zaishoku.Name = "chk_zaishoku"
        Me.chk_zaishoku.Size = New System.Drawing.Size(102, 19)
        Me.chk_zaishoku.TabIndex = 188
        Me.chk_zaishoku.Text = "在職している"
        Me.chk_zaishoku.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txt_shain_ryaku_mei)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(509, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 60)
        Me.GroupBox3.TabIndex = 191
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "社員略名"
        '
        'txt_shain_ryaku_mei
        '
        Me.txt_shain_ryaku_mei.BackColor = System.Drawing.Color.White
        Me.txt_shain_ryaku_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_shain_ryaku_mei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_shain_ryaku_mei.Location = New System.Drawing.Point(17, 24)
        Me.txt_shain_ryaku_mei.MaxLength = 10
        Me.txt_shain_ryaku_mei.Name = "txt_shain_ryaku_mei"
        Me.txt_shain_ryaku_mei.Size = New System.Drawing.Size(136, 22)
        Me.txt_shain_ryaku_mei.TabIndex = 187
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_shain_mei)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(198, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "社員名"
        '
        'txt_shain_mei
        '
        Me.txt_shain_mei.BackColor = System.Drawing.Color.White
        Me.txt_shain_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_shain_mei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_shain_mei.Location = New System.Drawing.Point(17, 24)
        Me.txt_shain_mei.MaxLength = 50
        Me.txt_shain_mei.Name = "txt_shain_mei"
        Me.txt_shain_mei.Size = New System.Drawing.Size(270, 22)
        Me.txt_shain_mei.TabIndex = 178
        '
        'gbx_kyuu
        '
        Me.gbx_kyuu.BackColor = System.Drawing.Color.White
        Me.gbx_kyuu.Controls.Add(Me.GroupBox1)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox7)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox8)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox9)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox10)
        Me.gbx_kyuu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_kyuu.Location = New System.Drawing.Point(12, 12)
        Me.gbx_kyuu.Name = "gbx_kyuu"
        Me.gbx_kyuu.Size = New System.Drawing.Size(983, 99)
        Me.gbx_kyuu.TabIndex = 194
        Me.gbx_kyuu.TabStop = False
        Me.gbx_kyuu.Text = "旧社員詳細"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_shain_id)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(53, 21)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox7.TabIndex = 193
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "社員ID"
        '
        'lbl_shain_id
        '
        Me.lbl_shain_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_shain_id.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shain_id.Location = New System.Drawing.Point(20, 24)
        Me.lbl_shain_id.Name = "lbl_shain_id"
        Me.lbl_shain_id.Size = New System.Drawing.Size(99, 21)
        Me.lbl_shain_id.TabIndex = 169
        Me.lbl_shain_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.lbl_zaishoku)
        Me.GroupBox8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(684, 21)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox8.TabIndex = 192
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "在職表示"
        '
        'lbl_zaishoku
        '
        Me.lbl_zaishoku.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_zaishoku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_zaishoku.Location = New System.Drawing.Point(21, 24)
        Me.lbl_zaishoku.Name = "lbl_zaishoku"
        Me.lbl_zaishoku.Size = New System.Drawing.Size(99, 21)
        Me.lbl_zaishoku.TabIndex = 170
        Me.lbl_zaishoku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.lbl_shain_ryaku_mei)
        Me.GroupBox9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(509, 21)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(169, 60)
        Me.GroupBox9.TabIndex = 191
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "社員略名"
        '
        'lbl_shain_ryaku_mei
        '
        Me.lbl_shain_ryaku_mei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_shain_ryaku_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shain_ryaku_mei.Location = New System.Drawing.Point(14, 24)
        Me.lbl_shain_ryaku_mei.Name = "lbl_shain_ryaku_mei"
        Me.lbl_shain_ryaku_mei.Size = New System.Drawing.Size(139, 21)
        Me.lbl_shain_ryaku_mei.TabIndex = 171
        Me.lbl_shain_ryaku_mei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.lbl_shain_mei)
        Me.GroupBox10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(198, 21)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(305, 60)
        Me.GroupBox10.TabIndex = 190
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "社員名"
        '
        'lbl_shain_mei
        '
        Me.lbl_shain_mei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_shain_mei.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shain_mei.Location = New System.Drawing.Point(14, 24)
        Me.lbl_shain_mei.Name = "lbl_shain_mei"
        Me.lbl_shain_mei.Size = New System.Drawing.Size(273, 21)
        Me.lbl_shain_mei.TabIndex = 172
        Me.lbl_shain_mei.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblpw)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(829, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "パスワード"
        '
        'lblpw
        '
        Me.lblpw.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblpw.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblpw.Location = New System.Drawing.Point(21, 24)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(99, 21)
        Me.lblpw.TabIndex = 170
        Me.lblpw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txtpw)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(829, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox5.TabIndex = 193
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "パスワード"
        '
        'txtpw
        '
        Me.txtpw.BackColor = System.Drawing.Color.White
        Me.txtpw.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtpw.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtpw.Location = New System.Drawing.Point(24, 24)
        Me.txtpw.MaxLength = 8
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(96, 22)
        Me.txtpw.TabIndex = 187
        '
        'frmichiran_shain_koushin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_kyuu)
        Me.Controls.Add(Me.btn_koushin)
        Me.Controls.Add(Me.btn_modoru)
        Me.Controls.Add(Me.gbx_shin)
        Me.Name = "frmichiran_shain_koushin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登録 OR 変更"
        Me.gbx_shin.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbx_kyuu.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_koushin As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents gbx_shin As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_shain_mei As TextBox
    Friend WithEvents gbx_kyuu As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_shain_id As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lbl_shain_mei As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chk_zaishoku As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_shain_ryaku_mei As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lbl_zaishoku As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lbl_shain_ryaku_mei As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblpw As Label
End Class
