﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmshutsuryoku_sentaku
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_modoru = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_kurikoshizan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_tenpo = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_shouhin = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_wella_shouhin_zaiko = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_wella_hanbai_jisseki = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btn_modoru)
        Me.GroupBox3.Location = New System.Drawing.Point(364, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox3.TabIndex = 124
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_kurikoshizan)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 54)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "「繰越残データ」情報を出力をします。"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_kurikoshizan
        '
        Me.btn_kurikoshizan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kurikoshizan.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_kurikoshizan.Location = New System.Drawing.Point(13, 89)
        Me.btn_kurikoshizan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kurikoshizan.Name = "btn_kurikoshizan"
        Me.btn_kurikoshizan.Size = New System.Drawing.Size(147, 44)
        Me.btn_kurikoshizan.TabIndex = 97
        Me.btn_kurikoshizan.Text = "繰越残データ"
        Me.btn_kurikoshizan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_tenpo)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "「店舗データ」情報を出力します。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_tenpo
        '
        Me.btn_tenpo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tenpo.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_tenpo.Location = New System.Drawing.Point(13, 89)
        Me.btn_tenpo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tenpo.Name = "btn_tenpo"
        Me.btn_tenpo.Size = New System.Drawing.Size(147, 44)
        Me.btn_tenpo.TabIndex = 97
        Me.btn_tenpo.Text = "店舗データ"
        Me.btn_tenpo.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.White
        Me.GroupBox16.Controls.Add(Me.Label21)
        Me.GroupBox16.Controls.Add(Me.btn_shouhin)
        Me.GroupBox16.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox16.TabIndex = 123
        Me.GroupBox16.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 54)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "「商品データ」情報を出力します。"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_shouhin
        '
        Me.btn_shouhin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shouhin.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_shouhin.Location = New System.Drawing.Point(13, 89)
        Me.btn_shouhin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_shouhin.Name = "btn_shouhin"
        Me.btn_shouhin.Size = New System.Drawing.Size(147, 44)
        Me.btn_shouhin.TabIndex = 97
        Me.btn_shouhin.Text = "商品データ"
        Me.btn_shouhin.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btn_wella_shouhin_zaiko)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 165)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox4.TabIndex = 128
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "「ウエラ商品在庫」情報を出力します。"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_wella_shouhin_zaiko
        '
        Me.btn_wella_shouhin_zaiko.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_wella_shouhin_zaiko.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_wella_shouhin_zaiko.Location = New System.Drawing.Point(13, 89)
        Me.btn_wella_shouhin_zaiko.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_wella_shouhin_zaiko.Name = "btn_wella_shouhin_zaiko"
        Me.btn_wella_shouhin_zaiko.Size = New System.Drawing.Size(147, 44)
        Me.btn_wella_shouhin_zaiko.TabIndex = 97
        Me.btn_wella_shouhin_zaiko.Text = "ウエラ商品在庫"
        Me.btn_wella_shouhin_zaiko.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.btn_wella_hanbai_jisseki)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(170, 147)
        Me.GroupBox5.TabIndex = 127
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "「ウエラ販売実績」情報を出力します。"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_wella_hanbai_jisseki
        '
        Me.btn_wella_hanbai_jisseki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_wella_hanbai_jisseki.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_wella_hanbai_jisseki.Location = New System.Drawing.Point(13, 89)
        Me.btn_wella_hanbai_jisseki.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_wella_hanbai_jisseki.Name = "btn_wella_hanbai_jisseki"
        Me.btn_wella_hanbai_jisseki.Size = New System.Drawing.Size(147, 44)
        Me.btn_wella_hanbai_jisseki.TabIndex = 97
        Me.btn_wella_hanbai_jisseki.Text = "ウエラ販売実績"
        Me.btn_wella_hanbai_jisseki.UseVisualStyleBackColor = True
        '
        'frmshutsuryoku_sentaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox16)
        Me.Name = "frmshutsuryoku_sentaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出力"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_modoru As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_kurikoshizan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_tenpo As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_shouhin As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_wella_shouhin_zaiko As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_wella_hanbai_jisseki As Button
End Class
