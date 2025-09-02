<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmichiran_yuubin_koushin
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
        Me.gbx_kyuu = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_yuubin_bangou_kyuu = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbl_shousai = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lbl_juusho = New System.Windows.Forms.Label()
        Me.btn_koushin = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_shin = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_yuubin_bangou_shin = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_shousai = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_juusho = New System.Windows.Forms.TextBox()
        Me.gbx_kyuu.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.gbx_shin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_kyuu
        '
        Me.gbx_kyuu.BackColor = System.Drawing.Color.White
        Me.gbx_kyuu.Controls.Add(Me.GroupBox7)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox9)
        Me.gbx_kyuu.Controls.Add(Me.GroupBox10)
        Me.gbx_kyuu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_kyuu.Location = New System.Drawing.Point(12, 12)
        Me.gbx_kyuu.Name = "gbx_kyuu"
        Me.gbx_kyuu.Size = New System.Drawing.Size(1121, 99)
        Me.gbx_kyuu.TabIndex = 198
        Me.gbx_kyuu.TabStop = False
        Me.gbx_kyuu.Text = "旧郵便番号詳細"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_yuubin_bangou_kyuu)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(53, 21)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox7.TabIndex = 193
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "郵便番号"
        '
        'lbl_yuubin_bangou_kyuu
        '
        Me.lbl_yuubin_bangou_kyuu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_yuubin_bangou_kyuu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_yuubin_bangou_kyuu.Location = New System.Drawing.Point(20, 24)
        Me.lbl_yuubin_bangou_kyuu.Name = "lbl_yuubin_bangou_kyuu"
        Me.lbl_yuubin_bangou_kyuu.Size = New System.Drawing.Size(99, 21)
        Me.lbl_yuubin_bangou_kyuu.TabIndex = 169
        Me.lbl_yuubin_bangou_kyuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.lbl_shousai)
        Me.GroupBox9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(627, 21)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(434, 60)
        Me.GroupBox9.TabIndex = 191
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "詳細"
        '
        'lbl_shousai
        '
        Me.lbl_shousai.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_shousai.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shousai.Location = New System.Drawing.Point(14, 24)
        Me.lbl_shousai.Name = "lbl_shousai"
        Me.lbl_shousai.Size = New System.Drawing.Size(402, 21)
        Me.lbl_shousai.TabIndex = 171
        Me.lbl_shousai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.lbl_juusho)
        Me.GroupBox10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(198, 21)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(423, 60)
        Me.GroupBox10.TabIndex = 190
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "住所１"
        '
        'lbl_juusho
        '
        Me.lbl_juusho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_juusho.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_juusho.Location = New System.Drawing.Point(14, 24)
        Me.lbl_juusho.Name = "lbl_juusho"
        Me.lbl_juusho.Size = New System.Drawing.Size(393, 21)
        Me.lbl_juusho.TabIndex = 172
        Me.lbl_juusho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_koushin
        '
        Me.btn_koushin.BackColor = System.Drawing.SystemColors.Control
        Me.btn_koushin.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_koushin.Location = New System.Drawing.Point(12, 223)
        Me.btn_koushin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_koushin.Name = "btn_koushin"
        Me.btn_koushin.Size = New System.Drawing.Size(889, 46)
        Me.btn_koushin.TabIndex = 197
        Me.btn_koushin.Text = "変更"
        Me.btn_koushin.UseVisualStyleBackColor = False
        '
        'btn_modoru
        '
        Me.btn_modoru.BackColor = System.Drawing.SystemColors.Control
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(909, 223)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(224, 46)
        Me.btn_modoru.TabIndex = 196
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = False
        '
        'gbx_shin
        '
        Me.gbx_shin.BackColor = System.Drawing.Color.White
        Me.gbx_shin.Controls.Add(Me.GroupBox1)
        Me.gbx_shin.Controls.Add(Me.GroupBox3)
        Me.gbx_shin.Controls.Add(Me.GroupBox2)
        Me.gbx_shin.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_shin.Location = New System.Drawing.Point(12, 117)
        Me.gbx_shin.Name = "gbx_shin"
        Me.gbx_shin.Size = New System.Drawing.Size(1121, 99)
        Me.gbx_shin.TabIndex = 195
        Me.gbx_shin.TabStop = False
        Me.gbx_shin.Text = "新郵便番号詳細"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbl_yuubin_bangou_shin)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 60)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "郵便番号"
        '
        'lbl_yuubin_bangou_shin
        '
        Me.lbl_yuubin_bangou_shin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_yuubin_bangou_shin.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_yuubin_bangou_shin.Location = New System.Drawing.Point(20, 24)
        Me.lbl_yuubin_bangou_shin.Name = "lbl_yuubin_bangou_shin"
        Me.lbl_yuubin_bangou_shin.Size = New System.Drawing.Size(99, 21)
        Me.lbl_yuubin_bangou_shin.TabIndex = 169
        Me.lbl_yuubin_bangou_shin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txt_shousai)
        Me.GroupBox3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(627, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 60)
        Me.GroupBox3.TabIndex = 191
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "詳細"
        '
        'txt_shousai
        '
        Me.txt_shousai.BackColor = System.Drawing.Color.White
        Me.txt_shousai.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_shousai.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_shousai.Location = New System.Drawing.Point(17, 24)
        Me.txt_shousai.MaxLength = 10
        Me.txt_shousai.Name = "txt_shousai"
        Me.txt_shousai.Size = New System.Drawing.Size(399, 22)
        Me.txt_shousai.TabIndex = 187
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_juusho)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(198, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 60)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "住所１"
        '
        'txt_juusho
        '
        Me.txt_juusho.BackColor = System.Drawing.Color.White
        Me.txt_juusho.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_juusho.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt_juusho.Location = New System.Drawing.Point(17, 24)
        Me.txt_juusho.MaxLength = 50
        Me.txt_juusho.Name = "txt_juusho"
        Me.txt_juusho.Size = New System.Drawing.Size(390, 22)
        Me.txt_juusho.TabIndex = 178
        '
        'frmichiran_yuubin_koushin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_kyuu)
        Me.Controls.Add(Me.btn_koushin)
        Me.Controls.Add(Me.btn_modoru)
        Me.Controls.Add(Me.gbx_shin)
        Me.Name = "frmichiran_yuubin_koushin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "変更"
        Me.gbx_kyuu.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.gbx_shin.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_kyuu As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_yuubin_bangou_kyuu As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lbl_shousai As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lbl_juusho As Label
    Friend WithEvents btn_koushin As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents gbx_shin As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_shousai As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_juusho As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_yuubin_bangou_shin As Label
End Class
