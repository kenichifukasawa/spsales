<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshiire_rireki
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
        Me.chk_sakujo = New System.Windows.Forms.CheckBox()
        Me.btn_shousai = New System.Windows.Forms.Button()
        Me.btn_sakujo = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_hinichi_owari = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hinichi_kaishi = New System.Windows.Forms.DateTimePicker()
        Me.btn_shuukei = New System.Windows.Forms.Button()
        Me.grp_kikan_shitei = New System.Windows.Forms.GroupBox()
        Me.cbx_gyousha = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grp_kikan_shitei.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.chk_sakujo)
        Me.gbx_main.Controls.Add(Me.btn_shousai)
        Me.gbx_main.Controls.Add(Me.btn_sakujo)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.GroupBox3)
        Me.gbx_main.Controls.Add(Me.btn_shuukei)
        Me.gbx_main.Controls.Add(Me.grp_kikan_shitei)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(11, 11)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(1425, 971)
        Me.gbx_main.TabIndex = 55
        Me.gbx_main.TabStop = False
        '
        'chk_sakujo
        '
        Me.chk_sakujo.AutoSize = True
        Me.chk_sakujo.Location = New System.Drawing.Point(1331, 948)
        Me.chk_sakujo.Name = "chk_sakujo"
        Me.chk_sakujo.Size = New System.Drawing.Size(77, 18)
        Me.chk_sakujo.TabIndex = 198
        Me.chk_sakujo.Text = "削除する"
        Me.chk_sakujo.UseVisualStyleBackColor = True
        '
        'btn_shousai
        '
        Me.btn_shousai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shousai.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shousai.Location = New System.Drawing.Point(1019, 31)
        Me.btn_shousai.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shousai.Name = "btn_shousai"
        Me.btn_shousai.Size = New System.Drawing.Size(127, 44)
        Me.btn_shousai.TabIndex = 197
        Me.btn_shousai.Text = "詳細"
        Me.btn_shousai.UseVisualStyleBackColor = True
        '
        'btn_sakujo
        '
        Me.btn_sakujo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sakujo.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_sakujo.Location = New System.Drawing.Point(1150, 31)
        Me.btn_sakujo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sakujo.Name = "btn_sakujo"
        Me.btn_sakujo.Size = New System.Drawing.Size(127, 44)
        Me.btn_sakujo.TabIndex = 195
        Me.btn_sakujo.Text = "削除"
        Me.btn_sakujo.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 86)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1391, 856)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(5, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(1381, 832)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_owari)
        Me.GroupBox3.Controls.Add(Me.dtp_hinichi_kaishi)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 61)
        Me.GroupBox3.TabIndex = 192
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "抽出期間"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 259
        Me.Label2.Text = "～"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_hinichi_owari
        '
        Me.dtp_hinichi_owari.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_owari.Location = New System.Drawing.Point(201, 24)
        Me.dtp_hinichi_owari.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_owari.Name = "dtp_hinichi_owari"
        Me.dtp_hinichi_owari.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_owari.TabIndex = 261
        Me.dtp_hinichi_owari.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'dtp_hinichi_kaishi
        '
        Me.dtp_hinichi_kaishi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dtp_hinichi_kaishi.Location = New System.Drawing.Point(12, 24)
        Me.dtp_hinichi_kaishi.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_hinichi_kaishi.Name = "dtp_hinichi_kaishi"
        Me.dtp_hinichi_kaishi.Size = New System.Drawing.Size(153, 23)
        Me.dtp_hinichi_kaishi.TabIndex = 260
        Me.dtp_hinichi_kaishi.Value = New Date(2025, 7, 4, 0, 0, 0, 0)
        '
        'btn_shuukei
        '
        Me.btn_shuukei.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shuukei.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_shuukei.Location = New System.Drawing.Point(888, 31)
        Me.btn_shuukei.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shuukei.Name = "btn_shuukei"
        Me.btn_shuukei.Size = New System.Drawing.Size(127, 44)
        Me.btn_shuukei.TabIndex = 194
        Me.btn_shuukei.Text = "集計"
        Me.btn_shuukei.UseVisualStyleBackColor = True
        '
        'grp_kikan_shitei
        '
        Me.grp_kikan_shitei.Controls.Add(Me.cbx_gyousha)
        Me.grp_kikan_shitei.Controls.Add(Me.btn_clear)
        Me.grp_kikan_shitei.Location = New System.Drawing.Point(390, 19)
        Me.grp_kikan_shitei.Name = "grp_kikan_shitei"
        Me.grp_kikan_shitei.Size = New System.Drawing.Size(493, 61)
        Me.grp_kikan_shitei.TabIndex = 191
        Me.grp_kikan_shitei.TabStop = False
        Me.grp_kikan_shitei.Text = "業者"
        '
        'cbx_gyousha
        '
        Me.cbx_gyousha.BackColor = System.Drawing.Color.White
        Me.cbx_gyousha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gyousha.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_gyousha.FormattingEnabled = True
        Me.cbx_gyousha.Location = New System.Drawing.Point(16, 24)
        Me.cbx_gyousha.Name = "cbx_gyousha"
        Me.cbx_gyousha.Size = New System.Drawing.Size(408, 24)
        Me.cbx_gyousha.TabIndex = 128
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(429, 21)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(47, 30)
        Me.btn_clear.TabIndex = 34
        Me.btn_clear.Text = "クリア"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modoru.Location = New System.Drawing.Point(1281, 31)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmshiire_rireki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmshiire_rireki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "仕入履歴"
        Me.gbx_main.ResumeLayout(False)
        Me.gbx_main.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_kikan_shitei.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_shousai As Button
    Friend WithEvents btn_sakujo As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_hinichi_owari As DateTimePicker
    Friend WithEvents dtp_hinichi_kaishi As DateTimePicker
    Friend WithEvents btn_shuukei As Button
    Friend WithEvents grp_kikan_shitei As GroupBox
    Friend WithEvents cbx_gyousha As ComboBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_modoru As Button
    Friend WithEvents chk_sakujo As CheckBox
End Class
