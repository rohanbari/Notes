﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnApplyChanges = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectFont = New System.Windows.Forms.Button()
        Me.chkStrikethrough = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.labelHead = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApplyChanges
        '
        Me.btnApplyChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyChanges.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnApplyChanges.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyChanges.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApplyChanges.ForeColor = System.Drawing.Color.White
        Me.btnApplyChanges.Location = New System.Drawing.Point(197, 174)
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Size = New System.Drawing.Size(100, 25)
        Me.btnApplyChanges.TabIndex = 3
        Me.btnApplyChanges.Text = "Apply Changes"
        Me.btnApplyChanges.UseVisualStyleBackColor = False
        '
        'btnDiscard
        '
        Me.btnDiscard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiscard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscard.ForeColor = System.Drawing.Color.DimGray
        Me.btnDiscard.Location = New System.Drawing.Point(91, 174)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(100, 25)
        Me.btnDiscard.TabIndex = 5
        Me.btnDiscard.Text = "Go Back"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSelectFont)
        Me.GroupBox1.Controls.Add(Me.chkStrikethrough)
        Me.GroupBox1.Controls.Add(Me.chkItalic)
        Me.GroupBox1.Controls.Add(Me.chkBold)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Look and Feel"
        '
        'btnSelectFont
        '
        Me.btnSelectFont.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSelectFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFont.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelectFont.ForeColor = System.Drawing.Color.DimGray
        Me.btnSelectFont.Location = New System.Drawing.Point(42, 50)
        Me.btnSelectFont.Name = "btnSelectFont"
        Me.btnSelectFont.Size = New System.Drawing.Size(200, 25)
        Me.btnSelectFont.TabIndex = 10
        Me.btnSelectFont.Text = "Open Font Selector"
        Me.btnSelectFont.UseVisualStyleBackColor = True
        '
        'chkStrikethrough
        '
        Me.chkStrikethrough.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkStrikethrough.AutoSize = True
        Me.chkStrikethrough.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkStrikethrough.Location = New System.Drawing.Point(150, 25)
        Me.chkStrikethrough.Name = "chkStrikethrough"
        Me.chkStrikethrough.Size = New System.Drawing.Size(98, 19)
        Me.chkStrikethrough.TabIndex = 9
        Me.chkStrikethrough.Text = "Strikethrough"
        Me.chkStrikethrough.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkItalic.Location = New System.Drawing.Point(93, 25)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(51, 19)
        Me.chkItalic.TabIndex = 8
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkBold.AutoSize = True
        Me.chkBold.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkBold.Location = New System.Drawing.Point(37, 25)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(50, 19)
        Me.chkBold.TabIndex = 7
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'labelHead
        '
        Me.labelHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelHead.Location = New System.Drawing.Point(12, 9)
        Me.labelHead.Name = "labelHead"
        Me.labelHead.Size = New System.Drawing.Size(239, 35)
        Me.labelHead.TabIndex = 0
        Me.labelHead.Text = "Customize your notes in your own way."
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(309, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelHead)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnApplyChanges)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "Preferences"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApplyChanges As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelHead As Label
    Friend WithEvents chkStrikethrough As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents btnSelectFont As Button
End Class
