<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewNote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSaveToNotes = New System.Windows.Forms.Button()
        Me.btnDiscardDraft = New System.Windows.Forms.Button()
        Me.btnPreferences = New System.Windows.Forms.Button()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStatistics = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSaveToNotes
        '
        Me.btnSaveToNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToNotes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveToNotes.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveToNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveToNotes.ForeColor = System.Drawing.Color.White
        Me.btnSaveToNotes.Location = New System.Drawing.Point(347, 324)
        Me.btnSaveToNotes.Name = "btnSaveToNotes"
        Me.btnSaveToNotes.Size = New System.Drawing.Size(125, 25)
        Me.btnSaveToNotes.TabIndex = 1
        Me.btnSaveToNotes.Text = "Save to Notes"
        Me.btnSaveToNotes.UseVisualStyleBackColor = False
        '
        'btnDiscardDraft
        '
        Me.btnDiscardDraft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiscardDraft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnDiscardDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnDiscardDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscardDraft.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDiscardDraft.Location = New System.Drawing.Point(216, 324)
        Me.btnDiscardDraft.Name = "btnDiscardDraft"
        Me.btnDiscardDraft.Size = New System.Drawing.Size(125, 25)
        Me.btnDiscardDraft.TabIndex = 2
        Me.btnDiscardDraft.Text = "Discard Draft"
        Me.btnDiscardDraft.UseVisualStyleBackColor = False
        '
        'btnPreferences
        '
        Me.btnPreferences.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreferences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreferences.ForeColor = System.Drawing.Color.DimGray
        Me.btnPreferences.Location = New System.Drawing.Point(12, 324)
        Me.btnPreferences.Name = "btnPreferences"
        Me.btnPreferences.Size = New System.Drawing.Size(125, 25)
        Me.btnPreferences.TabIndex = 3
        Me.btnPreferences.Text = "Preferences"
        Me.btnPreferences.UseVisualStyleBackColor = True
        '
        'txtHeader
        '
        Me.txtHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtHeader.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtHeader.Location = New System.Drawing.Point(57, 12)
        Me.txtHeader.MaxLength = 256
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(418, 16)
        Me.txtHeader.TabIndex = 4
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBody.Enabled = False
        Me.txtBody.Location = New System.Drawing.Point(15, 36)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(460, 250)
        Me.txtBody.TabIndex = 5
        '
        'labelCaption
        '
        Me.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.labelCaption.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.labelCaption.ForeColor = System.Drawing.Color.DimGray
        Me.labelCaption.Location = New System.Drawing.Point(148, 146)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(194, 30)
        Me.labelCaption.TabIndex = 6
        Me.labelCaption.Text = "Start writing here..."
        Me.labelCaption.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TITLE"
        '
        'txtStatistics
        '
        Me.txtStatistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatistics.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStatistics.ForeColor = System.Drawing.Color.DarkGray
        Me.txtStatistics.Location = New System.Drawing.Point(220, 289)
        Me.txtStatistics.Name = "txtStatistics"
        Me.txtStatistics.Size = New System.Drawing.Size(256, 32)
        Me.txtStatistics.TabIndex = 8
        Me.txtStatistics.Text = "Statistics"
        Me.txtStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtStatistics.Visible = False
        '
        'NewNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtStatistics)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelCaption)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.btnPreferences)
        Me.Controls.Add(Me.btnDiscardDraft)
        Me.Controls.Add(Me.btnSaveToNotes)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(435, 300)
        Me.Name = "NewNote"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Note"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveToNotes As Button
    Friend WithEvents btnDiscardDraft As Button
    Friend WithEvents btnPreferences As Button
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents labelCaption As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStatistics As Label
End Class
