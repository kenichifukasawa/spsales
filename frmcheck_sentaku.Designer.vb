﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheck_sentaku
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_kosuu_henkou = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_kurikoshi_log = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_shouhin_log = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_shouhin_check = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btn_kosuu_henkou)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 165)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox4.TabIndex = 134
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "「現在個数簡易変更」情報の管理をします。"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_kosuu_henkou
        '
        Me.btn_kosuu_henkou.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kosuu_henkou.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kosuu_henkou.Location = New System.Drawing.Point(13, 89)
        Me.btn_kosuu_henkou.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kosuu_henkou.Name = "btn_kosuu_henkou"
        Me.btn_kosuu_henkou.Size = New System.Drawing.Size(147, 44)
        Me.btn_kosuu_henkou.TabIndex = 97
        Me.btn_kosuu_henkou.Text = "現在個数簡易変更"
        Me.btn_kosuu_henkou.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.btn_kurikoshi_log)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox5.TabIndex = 133
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "「繰越推移ログ」情報の管理をします。"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_kurikoshi_log
        '
        Me.btn_kurikoshi_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kurikoshi_log.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kurikoshi_log.Location = New System.Drawing.Point(13, 89)
        Me.btn_kurikoshi_log.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kurikoshi_log.Name = "btn_kurikoshi_log"
        Me.btn_kurikoshi_log.Size = New System.Drawing.Size(147, 44)
        Me.btn_kurikoshi_log.TabIndex = 97
        Me.btn_kurikoshi_log.Text = "繰越推移ログ"
        Me.btn_kurikoshi_log.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btn_modoru)
        Me.GroupBox3.Location = New System.Drawing.Point(364, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox3.TabIndex = 130
        Me.GroupBox3.TabStop = False
        '
        'btn_modoru
        '
        Me.btn_modoru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modoru.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_modoru.Location = New System.Drawing.Point(13, 89)
        Me.btn_modoru.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modoru.Name = "btn_modoru"
        Me.btn_modoru.Size = New System.Drawing.Size(147, 44)
        Me.btn_modoru.TabIndex = 97
        Me.btn_modoru.Text = "戻る"
        Me.btn_modoru.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_shouhin_log)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "「商品推移ログ」情報の管理をします。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_shouhin_log
        '
        Me.btn_shouhin_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shouhin_log.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shouhin_log.Location = New System.Drawing.Point(13, 89)
        Me.btn_shouhin_log.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shouhin_log.Name = "btn_shouhin_log"
        Me.btn_shouhin_log.Size = New System.Drawing.Size(147, 44)
        Me.btn_shouhin_log.TabIndex = 97
        Me.btn_shouhin_log.Text = "商品推移ログ"
        Me.btn_shouhin_log.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.White
        Me.GroupBox16.Controls.Add(Me.Label21)
        Me.GroupBox16.Controls.Add(Me.btn_shouhin_check)
        Me.GroupBox16.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox16.TabIndex = 129
        Me.GroupBox16.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 54)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "「商品推移チェック」情報の管理をします。"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_shouhin_check
        '
        Me.btn_shouhin_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shouhin_check.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shouhin_check.Location = New System.Drawing.Point(13, 89)
        Me.btn_shouhin_check.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shouhin_check.Name = "btn_shouhin_check"
        Me.btn_shouhin_check.Size = New System.Drawing.Size(147, 44)
        Me.btn_shouhin_check.TabIndex = 97
        Me.btn_shouhin_check.Text = "商品推移チェック"
        Me.btn_shouhin_check.UseVisualStyleBackColor = True
        '
        'frmcheck_sentaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox16)
        Me.Name = "frmcheck_sentaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "チェック"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_kosuu_henkou As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_kurikoshi_log As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_shouhin_log As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_shouhin_check As Button
End Class
