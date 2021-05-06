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
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.txtStatistics = New System.Windows.Forms.Label()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.txtHeaderCaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSaveToNotes
        '
        Me.btnSaveToNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToNotes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveToNotes.Enabled = False
        Me.btnSaveToNotes.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveToNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveToNotes.ForeColor = System.Drawing.Color.White
        Me.btnSaveToNotes.Location = New System.Drawing.Point(347, 324)
        Me.btnSaveToNotes.Name = "btnSaveToNotes"
        Me.btnSaveToNotes.Size = New System.Drawing.Size(125, 25)
        Me.btnSaveToNotes.TabIndex = 2
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
        Me.btnDiscardDraft.TabIndex = 3
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
        Me.btnPreferences.TabIndex = 4
        Me.btnPreferences.Text = "Preferences"
        Me.btnPreferences.UseVisualStyleBackColor = True
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBody.Enabled = False
        Me.txtBody.Location = New System.Drawing.Point(12, 61)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(460, 225)
        Me.txtBody.TabIndex = 1
        '
        'labelCaption
        '
        Me.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.labelCaption.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.labelCaption.ForeColor = System.Drawing.Color.DimGray
        Me.labelCaption.Location = New System.Drawing.Point(146, 158)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(194, 30)
        Me.labelCaption.TabIndex = 6
        Me.labelCaption.Text = "Start writing here..."
        Me.labelCaption.Visible = False
        '
        'txtStatistics
        '
        Me.txtStatistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatistics.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStatistics.ForeColor = System.Drawing.Color.DarkGray
        Me.txtStatistics.Location = New System.Drawing.Point(220, 289)
        Me.txtStatistics.Name = "txtStatistics"
        Me.txtStatistics.Size = New System.Drawing.Size(256, 32)
        Me.txtStatistics.TabIndex = 5
        Me.txtStatistics.Text = "Statistics"
        Me.txtStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtStatistics.Visible = False
        '
        'txtHeader
        '
        Me.txtHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtHeader.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtHeader.Location = New System.Drawing.Point(14, 21)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(458, 20)
        Me.txtHeader.TabIndex = 0
        '
        'txtHeaderCaption
        '
        Me.txtHeaderCaption.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHeaderCaption.AutoSize = True
        Me.txtHeaderCaption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeaderCaption.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtHeaderCaption.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtHeaderCaption.Location = New System.Drawing.Point(121, 17)
        Me.txtHeaderCaption.Name = "txtHeaderCaption"
        Me.txtHeaderCaption.Size = New System.Drawing.Size(242, 25)
        Me.txtHeaderCaption.TabIndex = 10
        Me.txtHeaderCaption.Text = "Provide a suitable title here"
        '
        'NewNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtHeaderCaption)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.txtStatistics)
        Me.Controls.Add(Me.labelCaption)
        Me.Controls.Add(Me.txtBody)
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
    Friend WithEvents txtBody As TextBox
    Friend WithEvents labelCaption As Label
    Friend WithEvents txtStatistics As Label
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents txtHeaderCaption As Label
End Class
