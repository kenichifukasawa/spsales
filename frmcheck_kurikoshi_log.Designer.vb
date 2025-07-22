<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheck_kurikoshi_log
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_denwa_chou = New System.Windows.Forms.Button()
        Me.cbx_tenpo = New System.Windows.Forms.ComboBox()
        Me.chk_hihyouji_torihiki_nai = New System.Windows.Forms.CheckBox()
        Me.btn_kensaku = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgv_kensakukekka = New System.Windows.Forms.DataGridView()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.gbx_main.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_main
        '
        Me.gbx_main.BackColor = System.Drawing.Color.White
        Me.gbx_main.Controls.Add(Me.GroupBox5)
        Me.gbx_main.Controls.Add(Me.btn_kensaku)
        Me.gbx_main.Controls.Add(Me.GroupBox6)
        Me.gbx_main.Controls.Add(Me.btn_modoru)
        Me.gbx_main.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbx_main.Location = New System.Drawing.Point(12, 12)
        Me.gbx_main.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Name = "gbx_main"
        Me.gbx_main.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_main.Size = New System.Drawing.Size(900, 971)
        Me.gbx_main.TabIndex = 57
        Me.gbx_main.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_denwa_chou)
        Me.GroupBox5.Controls.Add(Me.cbx_tenpo)
        Me.GroupBox5.Controls.Add(Me.chk_hihyouji_torihiki_nai)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(580, 86)
        Me.GroupBox5.TabIndex = 198
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "繰り越し金額の推移を表示したい店舗を選択してください。"
        '
        'btn_denwa_chou
        '
        Me.btn_denwa_chou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_denwa_chou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_denwa_chou.Location = New System.Drawing.Point(22, 28)
        Me.btn_denwa_chou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_denwa_chou.Name = "btn_denwa_chou"
        Me.btn_denwa_chou.Size = New System.Drawing.Size(127, 44)
        Me.btn_denwa_chou.TabIndex = 200
        Me.btn_denwa_chou.Text = "電話帳"
        Me.btn_denwa_chou.UseVisualStyleBackColor = True
        '
        'cbx_tenpo
        '
        Me.cbx_tenpo.BackColor = System.Drawing.Color.White
        Me.cbx_tenpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cbx_tenpo.FormattingEnabled = True
        Me.cbx_tenpo.Location = New System.Drawing.Point(164, 38)
        Me.cbx_tenpo.Name = "cbx_tenpo"
        Me.cbx_tenpo.Size = New System.Drawing.Size(397, 24)
        Me.cbx_tenpo.TabIndex = 128
        '
        'chk_hihyouji_torihiki_nai
        '
        Me.chk_hihyouji_torihiki_nai.AutoSize = True
        Me.chk_hihyouji_torihiki_nai.Checked = True
        Me.chk_hihyouji_torihiki_nai.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_hihyouji_torihiki_nai.Location = New System.Drawing.Point(404, 0)
        Me.chk_hihyouji_torihiki_nai.Name = "chk_hihyouji_torihiki_nai"
        Me.chk_hihyouji_torihiki_nai.Size = New System.Drawing.Size(170, 18)
        Me.chk_hihyouji_torihiki_nai.TabIndex = 189
        Me.chk_hihyouji_torihiki_nai.Text = "取引のない店舗は非表示"
        Me.chk_hihyouji_torihiki_nai.UseVisualStyleBackColor = True
        '
        'btn_kensaku
        '
        Me.btn_kensaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kensaku.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kensaku.Location = New System.Drawing.Point(619, 47)
        Me.btn_kensaku.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kensaku.Name = "btn_kensaku"
        Me.btn_kensaku.Size = New System.Drawing.Size(127, 44)
        Me.btn_kensaku.TabIndex = 197
        Me.btn_kensaku.Text = "検索"
        Me.btn_kensaku.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgv_kensakukekka)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 111)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(866, 842)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "抽出結果"
        '
        'dgv_kensakukekka
        '
        Me.dgv_kensakukekka.AllowUserToAddRows = False
        Me.dgv_kensakukekka.AllowUserToDeleteRows = False
        Me.dgv_kensakukekka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kensakukekka.Location = New System.Drawing.Point(6, 19)
        Me.dgv_kensakukekka.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_kensakukekka.Name = "dgv_kensakukekka"
        Me.dgv_kensakukekka.ReadOnly = True
        Me.dgv_kensakukekka.RowTemplate.Height = 24
        Me.dgv_kensakukekka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_kensakukekka.Size = New System.Drawing.Size(854, 818)
        Me.dgv_kensakukekka.TabIndex = 192
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(750, 47)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(127, 44)
        Me.btn_modoru.TabIndex = 32
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'frmcheck_kurikoshi_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 994)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_main)
        Me.Name = "frmcheck_kurikoshi_log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "繰越推移ログ"
        Me.gbx_main.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgv_kensakukekka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_main As GroupBox
    Friend WithEvents btn_kensaku As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgv_kensakukekka As DataGridView
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbx_tenpo As ComboBox
    Friend WithEvents chk_hihyouji_torihiki_nai As CheckBox
    Friend WithEvents btn_denwa_chou As Button
End Class
