<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnouhinsho_rireki
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
        Me.chk_mi_check = New System.Windows.Forms.CheckBox()
        Me.chk_hyouji_shinai = New System.Windows.Forms.CheckBox()
        Me.btn_kakunin = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_kensuu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_goukeigaku = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.Group2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear_hi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_hi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_tsuki = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_nen = New System.Windows.Forms.ComboBox()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shain = New System.Windows.Forms.ComboBox()
        Me.btn_clear_shain = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group2.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.chk_mi_check)
        Me.gbx_main.Controls.Add(Me.chk_hyouji_shinai)
        Me.gbx_main.Controls.Add(Me.btn_kakunin)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.Group2)
        Me.gbx_main.Controls.Add(Me.btn_shousai)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.Group1)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1200, 971)
        Me.gbx_main.TabIndex = 57
        Me.gbx_main.TabStop = False
        '
        'chk_mi_check
        '
        Me.chk_mi_check.AutoSize = True
        Me.chk_mi_check.Location = New System.Drawing.Point(282, 12)
        Me.chk_mi_check.Name = "chk_mi_check"
        Me.chk_mi_check.Size = New System.Drawing.Size(105, 18)
        Me.chk_mi_check.TabIndex = 203
        Me.chk_mi_check.Text = "未チェック確認"
        Me.chk_mi_check.UseVisualStyleBackColor = True
        '
        'chk_hyouji_shinai
        '
        Me.chk_hyouji_shinai.AutoSize = True
        Me.chk_hyouji_shinai.Checked = True
        Me.chk_hyouji_shinai.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_hyouji_shinai.Location = New System.Drawing.Point(75, 12)
        Me.chk_hyouji_shinai.Name = "chk_hyouji_shinai"
        Me.chk_hyouji_shinai.Size = New System.Drawing.Size(201, 18)
        Me.chk_hyouji_shinai.TabIndex = 198
        Me.chk_hyouji_shinai.Text = "チェック済みの伝票は表示しない"
        Me.chk_hyouji_shinai.UseVisualStyleBackColor = True
        '
        'btn_kakunin
        '
        Me.btn_kakunin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kakunin.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_kakunin.Location = New System.Drawing.Point(923, 37)
        Me.btn_kakunin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kakunin.Name = "btn_kakunin"
        Me.btn_kakunin.Size = New System.Drawing.Size(127, 44)
        Me.btn_kakunin.TabIndex = 197
        Me.btn_kakunin.Text = "確認"
        Me.btn_kakunin.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_kensuu)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.lbl_goukeigaku)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 93)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1164, 863)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'lbl_kensuu
        '
        Me.lbl_kensuu.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_kensuu.Location = New System.Drawing.Point(725, 14)
        Me.lbl_kensuu.Name = "lbl_kensuu"
        Me.lbl_kensuu.Size = New System.Drawing.Size(96, 19)
        Me.lbl_kensuu.TabIndex = 205
        Me.lbl_kensuu.Text = "0 件"
        Me.lbl_kensuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(671, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = "件数"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_goukeigaku
        '
        Me.lbl_goukeigaku.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_goukeigaku.Location = New System.Drawing.Point(972, 14)
        Me.lbl_goukeigaku.Name = "lbl_goukeigaku"
        Me.lbl_goukeigaku.Size = New System.Drawing.Size(142, 19)
        Me.lbl_goukeigaku.TabIndex = 4
        Me.lbl_goukeigaku.Text = "0 円"
        Me.lbl_goukeigaku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(904, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "合計額"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 37)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1154, 821)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'Group2
        '
        Me.Group2.Controls.Add(Me.btn_clear_hi)
        Me.Group2.Controls.Add(Me.Label1)
        Me.Group2.Controls.Add(Me.cbx_hi)
        Me.Group2.Controls.Add(Me.Label7)
        Me.Group2.Controls.Add(Me.cbx_tsuki)
        Me.Group2.Controls.Add(Me.Label8)
        Me.Group2.Controls.Add(Me.cbx_nen)
        Me.Group2.Location = New System.Drawing.Point(17, 26)
        Me.Group2.Name = "Group2"
        Me.Group2.Size = New System.Drawing.Size(362, 61)
        Me.Group2.TabIndex = 192
        Me.Group2.TabStop = False
        Me.Group2.Text = "抽出日"
        '
        'btn_clear_hi
        '
        Me.btn_clear_hi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_hi.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_hi.Location = New System.Drawing.Point(299, 21)
        Me.btn_clear_hi.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_hi.Name = "btn_clear_hi"
        Me.btn_clear_hi.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_hi.TabIndex = 131
        Me.btn_clear_hi.Text = "クリア"
        Me.btn_clear_hi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "日"
        '
        'cbx_hi
        '
        Me.cbx_hi.BackColor = System.Drawing.Color.White
        Me.cbx_hi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_hi.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_hi.FormattingEnabled = True
        Me.cbx_hi.Location = New System.Drawing.Point(213, 24)
        Me.cbx_hi.Name = "cbx_hi"
        Me.cbx_hi.Size = New System.Drawing.Size(53, 23)
        Me.cbx_hi.TabIndex = 136
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "月"
        '
        'cbx_tsuki
        '
        Me.cbx_tsuki.BackColor = System.Drawing.Color.White
        Me.cbx_tsuki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tsuki.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tsuki.FormattingEnabled = True
        Me.cbx_tsuki.Location = New System.Drawing.Point(123, 24)
        Me.cbx_tsuki.Name = "cbx_tsuki"
        Me.cbx_tsuki.Size = New System.Drawing.Size(53, 23)
        Me.cbx_tsuki.TabIndex = 134
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 15)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "年"
        '
        'cbx_nen
        '
        Me.cbx_nen.BackColor = System.Drawing.Color.White
        Me.cbx_nen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nen.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_nen.FormattingEnabled = True
        Me.cbx_nen.Location = New System.Drawing.Point(19, 24)
        Me.cbx_nen.Name = "cbx_nen"
        Me.cbx_nen.Size = New System.Drawing.Size(69, 23)
        Me.cbx_nen.TabIndex = 132
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shousai.Location = New System.Drawing.Point(792, 37)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 202
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shuukei.Location = New System.Drawing.Point(661, 37)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "抽出"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.cbx_shain)
        Me.Group1.Controls.Add(Me.btn_clear_shain)
        Me.Group1.Location = New System.Drawing.Point(385, 26)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(271, 61)
        Me.Group1.TabIndex = 191
        Me.Group1.TabStop = False
        Me.Group1.Text = "店舗担当社員"
        '
        'cbx_shain
        '
        Me.cbx_shain.BackColor = System.Drawing.Color.White
        Me.cbx_shain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shain.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_shain.FormattingEnabled = True
        Me.cbx_shain.Location = New System.Drawing.Point(18, 23)
        Me.cbx_shain.Name = "cbx_shain"
        Me.cbx_shain.Size = New System.Drawing.Size(183, 24)
        Me.cbx_shain.TabIndex = 130
        '
        'btn_clear_shain
        '
        Me.btn_clear_shain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear_shain.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear_shain.Location = New System.Drawing.Point(206, 21)
        Me.btn_clear_shain.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear_shain.Name = "btn_clear_shain"
        Me.btn_clear_shain.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear_shain.TabIndex = 34
        Me.btn_clear_shain.Text = "クリア"
        Me.btn_clear_shain.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(1054, 37)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmnouhinsho_rireki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmnouhinsho_rireki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "納品書履歴"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents chk_hyouji_shinai As CheckBox
    Friend WithEvents btn_kakunin As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents Group2 As GroupBox
    Friend WithEvents btn_clear_hi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_hi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_tsuki As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_nen As ComboBox
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents cbx_shain As ComboBox
    Friend WithEvents btn_clear_shain As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents btn_shousai As Button
    Friend WithEvents lbl_kensuu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_goukeigaku As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_mi_check As CheckBox
End Class
