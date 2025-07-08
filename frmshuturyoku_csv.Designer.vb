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
        Me.gbx_main = New System.Windows.Forms.GroupBox()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.lbl_shutsuryoku_type = New System.Windows.Forms.Label()
        Me.chk_plus_alpha = New System.Windows.Forms.CheckBox()
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_shinkou_joukyou = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_shinkou_percent = New System.Windows.Forms.Label()
        Me.pgb_shinkou_joukyou = New System.Windows.Forms.ProgressBar()
        Me.lbl_shinkou_doai = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.gbx_shinkou_joukyou.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.grp_kikan_shitei)
        Me.gbx_main.Controls.Add(Me.lbl_shutsuryoku_type)
        Me.gbx_main.Controls.Add(Me.chk_plus_alpha)
        Me.gbx_main.Controls.Add(Me.btn_csv)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 10)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(579, 143)
        Me.gbx_main.TabIndex = 52
        Me.gbx_main.TabStop = False
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.Controls.Add(Me.Label7)
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_tsuki)
        Me.grp_kikan_shitei.Controls.Add(Me.Label8)
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_nen)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(309, 19)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(258, 61)
        Me.grp_kikan_shitei.TabIndex = 191
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "期間"
        Me.grp_kikan_shitei.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "月"
        '
        'cbx_tsuki
        '
        Me.cbx_tsuki.BackColor = System.Drawing.Color.White
        Me.cbx_tsuki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tsuki.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tsuki.FormattingEnabled = True
        Me.cbx_tsuki.Location = New System.Drawing.Point(148, 26)
        Me.cbx_tsuki.Name = "cbx_tsuki"
        Me.cbx_tsuki.Size = New System.Drawing.Size(53, 23)
        Me.cbx_tsuki.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 15)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "年"
        '
        'cbx_nen
        '
        Me.cbx_nen.BackColor = System.Drawing.Color.White
        Me.cbx_nen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nen.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_nen.FormattingEnabled = True
        Me.cbx_nen.Location = New System.Drawing.Point(36, 26)
        Me.cbx_nen.Name = "cbx_nen"
        Me.cbx_nen.Size = New System.Drawing.Size(69, 23)
        Me.cbx_nen.TabIndex = 128
        '
        'lbl_shutsuryoku_type
        '
        Me.lbl_shutsuryoku_type.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_shutsuryoku_type.Location = New System.Drawing.Point(26, 25)
        Me.lbl_shutsuryoku_type.Name = "lbl_shutsuryoku_type"
        Me.lbl_shutsuryoku_type.Size = New System.Drawing.Size(265, 32)
        Me.lbl_shutsuryoku_type.TabIndex = 190
        Me.lbl_shutsuryoku_type.Text = "出力データ名"
        Me.lbl_shutsuryoku_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_plus_alpha
        '
        Me.chk_plus_alpha.AutoSize = True
        Me.chk_plus_alpha.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chk_plus_alpha.Location = New System.Drawing.Point(52, 87)
        Me.chk_plus_alpha.Name = "chk_plus_alpha"
        Me.chk_plus_alpha.Size = New System.Drawing.Size(54, 19)
        Me.chk_plus_alpha.TabIndex = 189
        Me.chk_plus_alpha.Text = "+ α"
        Me.chk_plus_alpha.UseVisualStyleBackColor = True
        '
        'btn_csv
        '
        Me.btn_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_csv.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_csv.Location = New System.Drawing.Point(309, 87)
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
        Me.btn_modoru.Location = New System.Drawing.Point(440, 87)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'gbx_shinkou_joukyou
        '
        Me.gbx_shinkou_joukyou.BackColor = System.Drawing.Color.LightCyan
        Me.gbx_shinkou_joukyou.Controls.Add(Me.GroupBox5)
        Me.gbx_shinkou_joukyou.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_shinkou_joukyou.Location = New System.Drawing.Point(144, 227)
        Me.gbx_shinkou_joukyou.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Name = "gbx_shinkou_joukyou"
        Me.gbx_shinkou_joukyou.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_shinkou_joukyou.Size = New System.Drawing.Size(307, 121)
        Me.gbx_shinkou_joukyou.TabIndex = 222
        Me.gbx_shinkou_joukyou.TabStop = False
        Me.gbx_shinkou_joukyou.Text = "進行状況"
        Me.gbx_shinkou_joukyou.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lbl_shinkou_percent)
        Me.GroupBox5.Controls.Add(Me.pgb_shinkou_joukyou)
        Me.GroupBox5.Controls.Add(Me.lbl_shinkou_doai)
        Me.GroupBox5.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(267, 82)
        Me.GroupBox5.TabIndex = 222
        Me.GroupBox5.TabStop = False
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
        'frmshuturyoku_csv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_shinkou_joukyou)
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshuturyoku_csv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "データ出力"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.grp_kikan_shitei.PerformLayout()
        Me.gbx_shinkou_joukyou.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_plus_alpha As CheckBox
    Friend WithEvents btn_csv As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents lbl_shutsuryoku_type As Label
    Friend WithEvents gbx_shinkou_joukyou As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_shinkou_percent As Label
    Friend WithEvents pgb_shinkou_joukyou As ProgressBar
    Friend WithEvents lbl_shinkou_doai As Label
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
End Class
