<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseikyuu_sentaku
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
        Me.gbx_modoru = New System.Windows.Forms.GroupBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_shuukin_hyou = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_shuukin_hyou = New System.Windows.Forms.Button()
        Me.gbx_hakkou_insatsu = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_hakkou_insatsu = New System.Windows.Forms.Button()
        Me.gbx_rireki = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_rireki = New System.Windows.Forms.Button()
        Me.gbx_seikyuusho_soushin_kanri = New System.Windows.Forms.GroupBox()
        Me.btn_seikyuusho_soushin_kanri = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_hakkou_pdf = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_hakkou_pdf = New System.Windows.Forms.Button()
        Me.gbx_check = New System.Windows.Forms.GroupBox()
        Me.chk_check_log = New System.Windows.Forms.CheckBox()
        Me.chk_check_all = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.gbx_shinkou_joukyou = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_shinkou_percent = New System.Windows.Forms.Label()
        Me.pgb_shinkou_joukyou = New System.Windows.Forms.ProgressBar()
        Me.lbl_shinkou_doai = New System.Windows.Forms.Label()
        Me.chk_check_chuushi = New System.Windows.Forms.CheckBox()
        Me.gbx_modoru.SuspendLayout()
        Me.gbx_shuukin_hyou.SuspendLayout()
        Me.gbx_hakkou_insatsu.SuspendLayout()
        Me.gbx_rireki.SuspendLayout()
        Me.gbx_seikyuusho_soushin_kanri.SuspendLayout()
        Me.gbx_hakkou_pdf.SuspendLayout()
        Me.gbx_check.SuspendLayout()
        Me.gbx_shinkou_joukyou.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_modoru
        '
        Me.gbx_modoru.BackColor = System.Drawing.Color.White
        Me.gbx_modoru.Controls.Add(Me.btn_modoru)
        Me.gbx_modoru.Location = New System.Drawing.Point(716, 12)
        Me.gbx_modoru.Name = "gbx_modoru"
        Me.gbx_modoru.Size = New System.Drawing.Size(170, 147)
        Me.gbx_modoru.TabIndex = 130
        Me.gbx_modoru.TabStop = False
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(13, 89)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(147, 44)
        Me.btn_modoru.TabIndex = 97
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'gbx_shuukin_hyou
        '
        Me.gbx_shuukin_hyou.BackColor = System.Drawing.Color.White
        Me.gbx_shuukin_hyou.Controls.Add(Me.Label1)
        Me.gbx_shuukin_hyou.Controls.Add(Me.btn_shuukin_hyou)
        Me.gbx_shuukin_hyou.Location = New System.Drawing.Point(540, 12)
        Me.gbx_shuukin_hyou.Name = "gbx_shuukin_hyou"
        Me.gbx_shuukin_hyou.Size = New System.Drawing.Size(170, 147)
        Me.gbx_shuukin_hyou.TabIndex = 131
        Me.gbx_shuukin_hyou.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "「TODO」情報の管理をします。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_shuukin_hyou
        '
        Me.btn_shuukin_hyou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukin_hyou.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukin_hyou.Location = New System.Drawing.Point(13, 89)
        Me.btn_shuukin_hyou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukin_hyou.Name = "btn_shuukin_hyou"
        Me.btn_shuukin_hyou.Size = New System.Drawing.Size(147, 44)
        Me.btn_shuukin_hyou.TabIndex = 97
        Me.btn_shuukin_hyou.Text = "集金表"
        Me.btn_shuukin_hyou.UseVisualStyleBackColor = True
        '
        'gbx_hakkou_insatsu
        '
        Me.gbx_hakkou_insatsu.BackColor = System.Drawing.Color.White
        Me.gbx_hakkou_insatsu.Controls.Add(Me.Label21)
        Me.gbx_hakkou_insatsu.Controls.Add(Me.btn_hakkou_insatsu)
        Me.gbx_hakkou_insatsu.Location = New System.Drawing.Point(12, 12)
        Me.gbx_hakkou_insatsu.Name = "gbx_hakkou_insatsu"
        Me.gbx_hakkou_insatsu.Size = New System.Drawing.Size(170, 147)
        Me.gbx_hakkou_insatsu.TabIndex = 129
        Me.gbx_hakkou_insatsu.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 54)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "「TODO」情報の管理をします。"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_hakkou_insatsu
        '
        Me.btn_hakkou_insatsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hakkou_insatsu.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hakkou_insatsu.Location = New System.Drawing.Point(13, 89)
        Me.btn_hakkou_insatsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hakkou_insatsu.Name = "btn_hakkou_insatsu"
        Me.btn_hakkou_insatsu.Size = New System.Drawing.Size(147, 44)
        Me.btn_hakkou_insatsu.TabIndex = 97
        Me.btn_hakkou_insatsu.Text = "請求書発行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（印刷）"
        Me.btn_hakkou_insatsu.UseVisualStyleBackColor = True
        '
        'gbx_rireki
        '
        Me.gbx_rireki.BackColor = System.Drawing.Color.White
        Me.gbx_rireki.Controls.Add(Me.Label2)
        Me.gbx_rireki.Controls.Add(Me.btn_rireki)
        Me.gbx_rireki.Location = New System.Drawing.Point(188, 12)
        Me.gbx_rireki.Name = "gbx_rireki"
        Me.gbx_rireki.Size = New System.Drawing.Size(170, 147)
        Me.gbx_rireki.TabIndex = 130
        Me.gbx_rireki.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 54)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "「TODO」情報の管理をします。"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_rireki
        '
        Me.btn_rireki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rireki.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_rireki.Location = New System.Drawing.Point(13, 89)
        Me.btn_rireki.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_rireki.Name = "btn_rireki"
        Me.btn_rireki.Size = New System.Drawing.Size(147, 44)
        Me.btn_rireki.TabIndex = 97
        Me.btn_rireki.Text = "請求履歴"
        Me.btn_rireki.UseVisualStyleBackColor = True
        '
        'gbx_seikyuusho_soushin_kanri
        '
        Me.gbx_seikyuusho_soushin_kanri.BackColor = System.Drawing.Color.White
        Me.gbx_seikyuusho_soushin_kanri.Controls.Add(Me.btn_seikyuusho_soushin_kanri)
        Me.gbx_seikyuusho_soushin_kanri.Controls.Add(Me.Label3)
        Me.gbx_seikyuusho_soushin_kanri.Location = New System.Drawing.Point(364, 12)
        Me.gbx_seikyuusho_soushin_kanri.Name = "gbx_seikyuusho_soushin_kanri"
        Me.gbx_seikyuusho_soushin_kanri.Size = New System.Drawing.Size(170, 147)
        Me.gbx_seikyuusho_soushin_kanri.TabIndex = 130
        Me.gbx_seikyuusho_soushin_kanri.TabStop = False
        '
        'btn_seikyuusho_soushin_kanri
        '
        Me.btn_seikyuusho_soushin_kanri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seikyuusho_soushin_kanri.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_seikyuusho_soushin_kanri.Location = New System.Drawing.Point(13, 89)
        Me.btn_seikyuusho_soushin_kanri.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_seikyuusho_soushin_kanri.Name = "btn_seikyuusho_soushin_kanri"
        Me.btn_seikyuusho_soushin_kanri.Size = New System.Drawing.Size(147, 44)
        Me.btn_seikyuusho_soushin_kanri.TabIndex = 98
        Me.btn_seikyuusho_soushin_kanri.Text = "請求書送信管理"
        Me.btn_seikyuusho_soushin_kanri.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "「TODO」情報の管理をします。"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbx_hakkou_pdf
        '
        Me.gbx_hakkou_pdf.BackColor = System.Drawing.Color.White
        Me.gbx_hakkou_pdf.Controls.Add(Me.Label4)
        Me.gbx_hakkou_pdf.Controls.Add(Me.btn_hakkou_pdf)
        Me.gbx_hakkou_pdf.Location = New System.Drawing.Point(12, 165)
        Me.gbx_hakkou_pdf.Name = "gbx_hakkou_pdf"
        Me.gbx_hakkou_pdf.Size = New System.Drawing.Size(170, 147)
        Me.gbx_hakkou_pdf.TabIndex = 130
        Me.gbx_hakkou_pdf.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "「TODO」情報の管理をします。"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_hakkou_pdf
        '
        Me.btn_hakkou_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hakkou_pdf.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hakkou_pdf.Location = New System.Drawing.Point(13, 89)
        Me.btn_hakkou_pdf.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hakkou_pdf.Name = "btn_hakkou_pdf"
        Me.btn_hakkou_pdf.Size = New System.Drawing.Size(147, 44)
        Me.btn_hakkou_pdf.TabIndex = 97
        Me.btn_hakkou_pdf.Text = "請求書発行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（PDF）"
        Me.btn_hakkou_pdf.UseVisualStyleBackColor = True
        '
        'gbx_check
        '
        Me.gbx_check.BackColor = System.Drawing.Color.White
        Me.gbx_check.Controls.Add(Me.chk_check_log)
        Me.gbx_check.Controls.Add(Me.chk_check_all)
        Me.gbx_check.Controls.Add(Me.Label5)
        Me.gbx_check.Controls.Add(Me.btn_check)
        Me.gbx_check.Location = New System.Drawing.Point(188, 165)
        Me.gbx_check.Name = "gbx_check"
        Me.gbx_check.Size = New System.Drawing.Size(698, 147)
        Me.gbx_check.TabIndex = 132
        Me.gbx_check.TabStop = False
        '
        'chk_check_log
        '
        Me.chk_check_log.AutoSize = True
        Me.chk_check_log.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_check_log.Location = New System.Drawing.Point(225, 89)
        Me.chk_check_log.Name = "chk_check_log"
        Me.chk_check_log.Size = New System.Drawing.Size(213, 19)
        Me.chk_check_log.TabIndex = 99
        Me.chk_check_log.Text = "デスクトップのテキストに記録する"
        Me.chk_check_log.UseVisualStyleBackColor = True
        '
        'chk_check_all
        '
        Me.chk_check_all.AutoSize = True
        Me.chk_check_all.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_check_all.Location = New System.Drawing.Point(225, 42)
        Me.chk_check_all.Name = "chk_check_all"
        Me.chk_check_all.Size = New System.Drawing.Size(264, 19)
        Me.chk_check_all.TabIndex = 98
        Me.chk_check_all.Text = "回避フラッグを無視し、全件をチェックする"
        Me.chk_check_all.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 54)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "「TODO」情報の管理をします。"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_check
        '
        Me.btn_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_check.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_check.Location = New System.Drawing.Point(13, 89)
        Me.btn_check.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(147, 44)
        Me.btn_check.TabIndex = 97
        Me.btn_check.Text = "請求前チェック"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'gbx_shinkou_joukyou
        '
        Me.gbx_shinkou_joukyou.BackColor = System.Drawing.Color.LightCyan
        Me.gbx_shinkou_joukyou.Controls.Add(Me.chk_check_chuushi)
        Me.gbx_shinkou_joukyou.Controls.Add(Me.GroupBox7)
        Me.gbx_shinkou_joukyou.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_shinkou_joukyou.Location = New System.Drawing.Point(12, 433)
        Me.gbx_shinkou_joukyou.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Name = "gbx_shinkou_joukyou"
        Me.gbx_shinkou_joukyou.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Size = New System.Drawing.Size(307, 121)
        Me.gbx_shinkou_joukyou.TabIndex = 224
        Me.gbx_shinkou_joukyou.TabStop = False
        Me.gbx_shinkou_joukyou.Text = "進行状況"
        Me.gbx_shinkou_joukyou.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbl_shinkou_percent)
        Me.GroupBox7.Controls.Add(Me.pgb_shinkou_joukyou)
        Me.GroupBox7.Controls.Add(Me.lbl_shinkou_doai)
        Me.GroupBox7.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(267, 82)
        Me.GroupBox7.TabIndex = 222
        Me.GroupBox7.TabStop = False
        '
        'lbl_shinkou_percent
        '
        Me.lbl_shinkou_percent.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shinkou_percent.Location = New System.Drawing.Point(20, 12)
        Me.lbl_shinkou_percent.Name = "lbl_shinkou_percent"
        Me.lbl_shinkou_percent.Size = New System.Drawing.Size(228, 15)
        Me.lbl_shinkou_percent.TabIndex = 126
        Me.lbl_shinkou_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgb_shinkou_joukyou
        '
        Me.pgb_shinkou_joukyou.Location = New System.Drawing.Point(20, 30)
        Me.pgb_shinkou_joukyou.Name = "pgb_shinkou_joukyou"
        Me.pgb_shinkou_joukyou.Size = New System.Drawing.Size(228, 23)
        Me.pgb_shinkou_joukyou.TabIndex = 0
        '
        'lbl_shinkou_doai
        '
        Me.lbl_shinkou_doai.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shinkou_doai.Location = New System.Drawing.Point(20, 56)
        Me.lbl_shinkou_doai.Name = "lbl_shinkou_doai"
        Me.lbl_shinkou_doai.Size = New System.Drawing.Size(228, 15)
        Me.lbl_shinkou_doai.TabIndex = 125
        Me.lbl_shinkou_doai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_check_chuushi
        '
        Me.chk_check_chuushi.AutoSize = True
        Me.chk_check_chuushi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_check_chuushi.Location = New System.Drawing.Point(222, 4)
        Me.chk_check_chuushi.Name = "chk_check_chuushi"
        Me.chk_check_chuushi.Size = New System.Drawing.Size(80, 19)
        Me.chk_check_chuushi.TabIndex = 100
        Me.chk_check_chuushi.Text = "中止する"
        Me.chk_check_chuushi.UseVisualStyleBackColor = True
        '
        'frmseikyuu_sentaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_shinkou_joukyou)
        Me.Controls.Add(Me.gbx_check)
        Me.Controls.Add(Me.gbx_hakkou_pdf)
        Me.Controls.Add(Me.gbx_rireki)
        Me.Controls.Add(Me.gbx_seikyuusho_soushin_kanri)
        Me.Controls.Add(Me.gbx_modoru)
        Me.Controls.Add(Me.gbx_shuukin_hyou)
        Me.Controls.Add(Me.gbx_hakkou_insatsu)
        Me.Name = "frmseikyuu_sentaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請求管理"
        Me.gbx_modoru.ResumeLayout(False)
        Me.gbx_shuukin_hyou.ResumeLayout(False)
        Me.gbx_hakkou_insatsu.ResumeLayout(False)
        Me.gbx_rireki.ResumeLayout(False)
        Me.gbx_seikyuusho_soushin_kanri.ResumeLayout(False)
        Me.gbx_hakkou_pdf.ResumeLayout(False)
        Me.gbx_check.ResumeLayout(False)
        Me.gbx_check.PerformLayout()
        Me.gbx_shinkou_joukyou.ResumeLayout(False)
        Me.gbx_shinkou_joukyou.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_modoru As GroupBox
    Friend WithEvents btn_modoru As Button
    Friend WithEvents gbx_shuukin_hyou As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_shuukin_hyou As Button
    Friend WithEvents gbx_hakkou_insatsu As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_hakkou_insatsu As Button
    Friend WithEvents gbx_rireki As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_rireki As Button
    Friend WithEvents gbx_seikyuusho_soushin_kanri As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbx_hakkou_pdf As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_hakkou_pdf As Button
    Friend WithEvents gbx_check As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_check As Button
    Friend WithEvents btn_seikyuusho_soushin_kanri As Button
    Friend WithEvents chk_check_log As CheckBox
    Friend WithEvents chk_check_all As CheckBox
    Friend WithEvents gbx_shinkou_joukyou As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_shinkou_percent As Label
    Friend WithEvents pgb_shinkou_joukyou As ProgressBar
    Friend WithEvents lbl_shinkou_doai As Label
    Friend WithEvents chk_check_chuushi As CheckBox
End Class
