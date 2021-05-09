<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.BtnApplyChanges = New System.Windows.Forms.Button()
        Me.BtnDiscard = New System.Windows.Forms.Button()
        Me.GroupMain = New System.Windows.Forms.GroupBox()
        Me.BtnSelectFont = New System.Windows.Forms.Button()
        Me.ChkStrikethrough = New System.Windows.Forms.CheckBox()
        Me.ChkItalic = New System.Windows.Forms.CheckBox()
        Me.ChkBold = New System.Windows.Forms.CheckBox()
        Me.LabelHead = New System.Windows.Forms.Label()
        Me.GroupMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnApplyChanges
        '
        Me.BtnApplyChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnApplyChanges.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnApplyChanges.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.BtnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnApplyChanges.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnApplyChanges.ForeColor = System.Drawing.Color.White
        Me.BtnApplyChanges.Location = New System.Drawing.Point(197, 174)
        Me.BtnApplyChanges.Name = "BtnApplyChanges"
        Me.BtnApplyChanges.Size = New System.Drawing.Size(100, 25)
        Me.BtnApplyChanges.TabIndex = 3
        Me.BtnApplyChanges.Text = "Apply Changes"
        Me.BtnApplyChanges.UseVisualStyleBackColor = False
        '
        'BtnDiscard
        '
        Me.BtnDiscard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDiscard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiscard.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDiscard.Location = New System.Drawing.Point(91, 174)
        Me.BtnDiscard.Name = "BtnDiscard"
        Me.BtnDiscard.Size = New System.Drawing.Size(100, 25)
        Me.BtnDiscard.TabIndex = 5
        Me.BtnDiscard.Text = "Go Back"
        Me.BtnDiscard.UseVisualStyleBackColor = True
        '
        'GroupMain
        '
        Me.GroupMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupMain.Controls.Add(Me.BtnSelectFont)
        Me.GroupMain.Controls.Add(Me.ChkStrikethrough)
        Me.GroupMain.Controls.Add(Me.ChkItalic)
        Me.GroupMain.Controls.Add(Me.ChkBold)
        Me.GroupMain.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupMain.ForeColor = System.Drawing.Color.DimGray
        Me.GroupMain.Location = New System.Drawing.Point(12, 47)
        Me.GroupMain.Name = "GroupMain"
        Me.GroupMain.Size = New System.Drawing.Size(285, 100)
        Me.GroupMain.TabIndex = 6
        Me.GroupMain.TabStop = False
        Me.GroupMain.Text = "Look and Feel"
        '
        'BtnSelectFont
        '
        Me.BtnSelectFont.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSelectFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSelectFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectFont.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSelectFont.ForeColor = System.Drawing.Color.DimGray
        Me.BtnSelectFont.Location = New System.Drawing.Point(42, 50)
        Me.BtnSelectFont.Name = "BtnSelectFont"
        Me.BtnSelectFont.Size = New System.Drawing.Size(200, 25)
        Me.BtnSelectFont.TabIndex = 10
        Me.BtnSelectFont.Text = "Open Font Selector"
        Me.BtnSelectFont.UseVisualStyleBackColor = True
        '
        'ChkStrikethrough
        '
        Me.ChkStrikethrough.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkStrikethrough.AutoSize = True
        Me.ChkStrikethrough.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChkStrikethrough.Location = New System.Drawing.Point(150, 25)
        Me.ChkStrikethrough.Name = "ChkStrikethrough"
        Me.ChkStrikethrough.Size = New System.Drawing.Size(98, 19)
        Me.ChkStrikethrough.TabIndex = 9
        Me.ChkStrikethrough.Text = "Strikethrough"
        Me.ChkStrikethrough.UseVisualStyleBackColor = True
        '
        'ChkItalic
        '
        Me.ChkItalic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkItalic.AutoSize = True
        Me.ChkItalic.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChkItalic.Location = New System.Drawing.Point(93, 25)
        Me.ChkItalic.Name = "ChkItalic"
        Me.ChkItalic.Size = New System.Drawing.Size(51, 19)
        Me.ChkItalic.TabIndex = 8
        Me.ChkItalic.Text = "Italic"
        Me.ChkItalic.UseVisualStyleBackColor = True
        '
        'ChkBold
        '
        Me.ChkBold.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkBold.AutoSize = True
        Me.ChkBold.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChkBold.Location = New System.Drawing.Point(37, 25)
        Me.ChkBold.Name = "ChkBold"
        Me.ChkBold.Size = New System.Drawing.Size(50, 19)
        Me.ChkBold.TabIndex = 7
        Me.ChkBold.Text = "Bold"
        Me.ChkBold.UseVisualStyleBackColor = True
        '
        'LabelHead
        '
        Me.LabelHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHead.Location = New System.Drawing.Point(12, 9)
        Me.LabelHead.Name = "LabelHead"
        Me.LabelHead.Size = New System.Drawing.Size(239, 35)
        Me.LabelHead.TabIndex = 0
        Me.LabelHead.Text = "Customize your notes in your own way."
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(309, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelHead)
        Me.Controls.Add(Me.GroupMain)
        Me.Controls.Add(Me.BtnDiscard)
        Me.Controls.Add(Me.BtnApplyChanges)
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
        Me.GroupMain.ResumeLayout(False)
        Me.GroupMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnApplyChanges As Button
    Friend WithEvents BtnDiscard As Button
    Friend WithEvents GroupMain As GroupBox
    Friend WithEvents LabelHead As Label
    Friend WithEvents ChkStrikethrough As CheckBox
    Friend WithEvents ChkItalic As CheckBox
    Friend WithEvents ChkBold As CheckBox
    Friend WithEvents BtnSelectFont As Button
End Class
