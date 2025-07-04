<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshuukei_shouhin
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hinichi_owari = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hinichi_kaishi = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbx_shouhin_kubun_2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbx_shouhin_kubun_1 = New System.Windows.Forms.ComboBox()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.btn_insatsu = New System.Windows.Forms.Button()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.cbx_gyousha_kubun = New System.Windows.Forms.ComboBox()
        Me.chk_haiban = New System.Windows.Forms.CheckBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbx_shitei_shouhin = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbn_shouhin_id = New System.Windows.Forms.RadioButton()
        Me.rbn_shouhin_furigana = New System.Windows.Forms.RadioButton()
        Me.rbn_shouhin_shiire = New System.Windows.Forms.RadioButton()
        Me.rbn_shouhin_uriage = New System.Windows.Forms.RadioButton()
        Me.rbn_shouhin_zaiko = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_kekka = New System.Windows.Forms.Label()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox5)
        Me.gbx_main.Controls.Add(Me.GroupBox4)
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.GroupBox2)
        Me.gbx_main.Controls.Add(Me.GroupBox1)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.btn_insatsu)
        Me.gbx_main.Controls.Add(Me.grp_kikan_shitei)
        Me.gbx_main.Controls.Add(Me.chk_haiban)
        Me.gbx_main.Controls.Add(Me.btn_clear)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1220, 970)
        Me.gbx_main.TabIndex = 53
        Me.gbx_main.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_owari)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_kaishi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 61)
        Me.GroupBox3.TabIndex = 192
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "抽出期間"
        Me.GroupBox3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "～"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_hinichi_owari
        '
        Me.dtp_hinichi_owari.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_owari.Location = New System.Drawing.Point(219, 24)
        Me.dtp_hinichi_owari.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_owari.Name = "dtp_hinichi_owari"
        Me.dtp_hinichi_owari.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_owari.TabIndex = 261
        Me.dtp_hinichi_owari.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'dtp_hinichi_kaishi
        '
        Me.dtp_hinichi_kaishi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_kaishi.Location = New System.Drawing.Point(30, 24)
        Me.dtp_hinichi_kaishi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_kaishi.Name = "dtp_hinichi_kaishi"
        Me.dtp_hinichi_kaishi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_kaishi.TabIndex = 260
        Me.dtp_hinichi_kaishi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbx_shouhin_kubun_2)
        Me.GroupBox2.Location = New System.Drawing.Point(947, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "商品選択区分２"
        Me.GroupBox2.Visible = False
        '
        'cbx_shouhin_kubun_2
        '
        Me.cbx_shouhin_kubun_2.BackColor = System.Drawing.Color.White
        Me.cbx_shouhin_kubun_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shouhin_kubun_2.FormattingEnabled = True
        Me.cbx_shouhin_kubun_2.Location = New System.Drawing.Point(19, 26)
        Me.cbx_shouhin_kubun_2.Name = "cbx_shouhin_kubun_2"
        Me.cbx_shouhin_kubun_2.Size = New System.Drawing.Size(217, 22)
        Me.cbx_shouhin_kubun_2.TabIndex = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbx_shouhin_kubun_1)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "商品選択区分１"
        Me.GroupBox1.Visible = False
        '
        'cbx_shouhin_kubun_1
        '
        Me.cbx_shouhin_kubun_1.BackColor = System.Drawing.Color.White
        Me.cbx_shouhin_kubun_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shouhin_kubun_1.FormattingEnabled = True
        Me.cbx_shouhin_kubun_1.Location = New System.Drawing.Point(19, 26)
        Me.cbx_shouhin_kubun_1.Name = "cbx_shouhin_kubun_1"
        Me.cbx_shouhin_kubun_1.Size = New System.Drawing.Size(217, 22)
        Me.cbx_shouhin_kubun_1.TabIndex = 128
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shuukei.Location = New System.Drawing.Point(816, 168)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'btn_insatsu
        '
        Me.btn_insatsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insatsu.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_insatsu.Location = New System.Drawing.Point(685, 168)
        Me.btn_insatsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insatsu.Name = "btn_insatsu"
        Me.btn_insatsu.Size = New System.Drawing.Size(127, 44)
        Me.btn_insatsu.TabIndex = 193
        Me.btn_insatsu.Text = "印刷"
        Me.btn_insatsu.UseVisualStyleBackColor = True
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(7, 58)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1176, 672)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_gyousha_kubun)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(419, 19)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(258, 61)
        Me.grp_kikan_shitei.TabIndex = 191
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "業者区分"
        Me.grp_kikan_shitei.Visible = False
        '
        'cbx_gyousha_kubun
        '
        Me.cbx_gyousha_kubun.BackColor = System.Drawing.Color.White
        Me.cbx_gyousha_kubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gyousha_kubun.FormattingEnabled = True
        Me.cbx_gyousha_kubun.Location = New System.Drawing.Point(19, 26)
        Me.cbx_gyousha_kubun.Name = "cbx_gyousha_kubun"
        Me.cbx_gyousha_kubun.Size = New System.Drawing.Size(217, 22)
        Me.cbx_gyousha_kubun.TabIndex = 128
        '
        'chk_haiban
        '
        Me.chk_haiban.AutoSize = True
        Me.chk_haiban.Location = New System.Drawing.Point(1101, 112)
        Me.chk_haiban.Name = "chk_haiban"
        Me.chk_haiban.Size = New System.Drawing.Size(93, 18)
        Me.chk_haiban.TabIndex = 189
        Me.chk_haiban.Text = "廃盤を表示"
        Me.chk_haiban.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(947, 168)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(127, 44)
        Me.btn_clear.TabIndex = 34
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(1078, 168)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbx_shitei_shouhin)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(660, 61)
        Me.GroupBox4.TabIndex = 192
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "指定商品"
        Me.GroupBox4.Visible = False
        '
        'cbx_shitei_shouhin
        '
        Me.cbx_shitei_shouhin.BackColor = System.Drawing.Color.White
        Me.cbx_shitei_shouhin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_shitei_shouhin.FormattingEnabled = True
        Me.cbx_shitei_shouhin.Location = New System.Drawing.Point(19, 26)
        Me.cbx_shitei_shouhin.Name = "cbx_shitei_shouhin"
        Me.cbx_shitei_shouhin.Size = New System.Drawing.Size(619, 22)
        Me.cbx_shitei_shouhin.TabIndex = 128
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbn_shouhin_zaiko)
        Me.GroupBox5.Controls.Add(Me.rbn_shouhin_uriage)
        Me.GroupBox5.Controls.Add(Me.rbn_shouhin_shiire)
        Me.GroupBox5.Controls.Add(Me.rbn_shouhin_furigana)
        Me.GroupBox5.Controls.Add(Me.rbn_shouhin_id)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 153)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(660, 61)
        Me.GroupBox5.TabIndex = 193
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "並べ替え"
        Me.GroupBox5.Visible = False
        '
        'rbn_shouhin_id
        '
        Me.rbn_shouhin_id.AutoSize = True
        Me.rbn_shouhin_id.Location = New System.Drawing.Point(49, 27)
        Me.rbn_shouhin_id.Name = "rbn_shouhin_id"
        Me.rbn_shouhin_id.Size = New System.Drawing.Size(79, 18)
        Me.rbn_shouhin_id.TabIndex = 0
        Me.rbn_shouhin_id.TabStop = True
        Me.rbn_shouhin_id.Text = "商品ID順"
        Me.rbn_shouhin_id.UseVisualStyleBackColor = True
        '
        'rbn_shouhin_furigana
        '
        Me.rbn_shouhin_furigana.AutoSize = True
        Me.rbn_shouhin_furigana.Location = New System.Drawing.Point(152, 27)
        Me.rbn_shouhin_furigana.Name = "rbn_shouhin_furigana"
        Me.rbn_shouhin_furigana.Size = New System.Drawing.Size(106, 18)
        Me.rbn_shouhin_furigana.TabIndex = 1
        Me.rbn_shouhin_furigana.TabStop = True
        Me.rbn_shouhin_furigana.Text = "商品フリガナ順"
        Me.rbn_shouhin_furigana.UseVisualStyleBackColor = True
        '
        'rbn_shouhin_shiire
        '
        Me.rbn_shouhin_shiire.AutoSize = True
        Me.rbn_shouhin_shiire.Location = New System.Drawing.Point(282, 27)
        Me.rbn_shouhin_shiire.Name = "rbn_shouhin_shiire"
        Me.rbn_shouhin_shiire.Size = New System.Drawing.Size(95, 18)
        Me.rbn_shouhin_shiire.TabIndex = 2
        Me.rbn_shouhin_shiire.TabStop = True
        Me.rbn_shouhin_shiire.Text = "商品仕入順"
        Me.rbn_shouhin_shiire.UseVisualStyleBackColor = True
        '
        'rbn_shouhin_uriage
        '
        Me.rbn_shouhin_uriage.AutoSize = True
        Me.rbn_shouhin_uriage.Location = New System.Drawing.Point(401, 27)
        Me.rbn_shouhin_uriage.Name = "rbn_shouhin_uriage"
        Me.rbn_shouhin_uriage.Size = New System.Drawing.Size(95, 18)
        Me.rbn_shouhin_uriage.TabIndex = 3
        Me.rbn_shouhin_uriage.TabStop = True
        Me.rbn_shouhin_uriage.Text = "商品売上順"
        Me.rbn_shouhin_uriage.UseVisualStyleBackColor = True
        '
        'rbn_shouhin_zaiko
        '
        Me.rbn_shouhin_zaiko.AutoSize = True
        Me.rbn_shouhin_zaiko.Location = New System.Drawing.Point(520, 27)
        Me.rbn_shouhin_zaiko.Name = "rbn_shouhin_zaiko"
        Me.rbn_shouhin_zaiko.Size = New System.Drawing.Size(95, 18)
        Me.rbn_shouhin_zaiko.TabIndex = 4
        Me.rbn_shouhin_zaiko.TabStop = True
        Me.rbn_shouhin_zaiko.Text = "商品在庫順"
        Me.rbn_shouhin_zaiko.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_kekka)
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 220)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1188, 735)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        Me.GroupBox6.Visible = False
        '
        'lbl_kekka
        '
        Me.lbl_kekka.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_kekka.Location = New System.Drawing.Point(7, 22)
        Me.lbl_kekka.Name = "lbl_kekka"
        Me.lbl_kekka.Size = New System.Drawing.Size(1176, 24)
        Me.lbl_kekka.TabIndex = 193
        Me.lbl_kekka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmshuukei_shouhin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshuukei_shouhin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品集計"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents cbx_gyousha_kubun As ComboBox
    Friend WithEvents chk_haiban As CheckBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents btn_insatsu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbx_shouhin_kubun_2 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_hinichi_owari As DateTimePicker
    Friend WithEvents dtp_hinichi_kaishi As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbx_shitei_shouhin As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbn_shouhin_zaiko As RadioButton
    Friend WithEvents rbn_shouhin_uriage As RadioButton
    Friend WithEvents rbn_shouhin_shiire As RadioButton
    Friend WithEvents rbn_shouhin_furigana As RadioButton
    Friend WithEvents rbn_shouhin_id As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbl_kekka As Label
End Class
