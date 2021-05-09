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
        Me.BtnSaveToNotes = New System.Windows.Forms.Button()
        Me.BtnDiscardDraft = New System.Windows.Forms.Button()
        Me.BtnPreferences = New System.Windows.Forms.Button()
        Me.TextBody = New System.Windows.Forms.TextBox()
        Me.LabelCaption = New System.Windows.Forms.Label()
        Me.LabelStatistics = New System.Windows.Forms.Label()
        Me.TextHeader = New System.Windows.Forms.TextBox()
        Me.LabelHeaderCaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSaveToNotes
        '
        Me.BtnSaveToNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveToNotes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnSaveToNotes.Enabled = False
        Me.BtnSaveToNotes.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.BtnSaveToNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveToNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveToNotes.ForeColor = System.Drawing.Color.White
        Me.BtnSaveToNotes.Location = New System.Drawing.Point(347, 324)
        Me.BtnSaveToNotes.Name = "BtnSaveToNotes"
        Me.BtnSaveToNotes.Size = New System.Drawing.Size(125, 25)
        Me.BtnSaveToNotes.TabIndex = 2
        Me.BtnSaveToNotes.Text = "Save to Notes"
        Me.BtnSaveToNotes.UseVisualStyleBackColor = False
        '
        'BtnDiscardDraft
        '
        Me.BtnDiscardDraft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDiscardDraft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnDiscardDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnDiscardDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiscardDraft.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDiscardDraft.Location = New System.Drawing.Point(216, 324)
        Me.BtnDiscardDraft.Name = "BtnDiscardDraft"
        Me.BtnDiscardDraft.Size = New System.Drawing.Size(125, 25)
        Me.BtnDiscardDraft.TabIndex = 3
        Me.BtnDiscardDraft.Text = "Discard Draft"
        Me.BtnDiscardDraft.UseVisualStyleBackColor = False
        '
        'BtnPreferences
        '
        Me.BtnPreferences.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPreferences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreferences.ForeColor = System.Drawing.Color.DimGray
        Me.BtnPreferences.Location = New System.Drawing.Point(12, 324)
        Me.BtnPreferences.Name = "BtnPreferences"
        Me.BtnPreferences.Size = New System.Drawing.Size(125, 25)
        Me.BtnPreferences.TabIndex = 4
        Me.BtnPreferences.Text = "Preferences"
        Me.BtnPreferences.UseVisualStyleBackColor = True
        '
        'TextBody
        '
        Me.TextBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBody.Enabled = False
        Me.TextBody.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBody.ForeColor = System.Drawing.Color.DimGray
        Me.TextBody.Location = New System.Drawing.Point(12, 61)
        Me.TextBody.Multiline = True
        Me.TextBody.Name = "TextBody"
        Me.TextBody.Size = New System.Drawing.Size(460, 225)
        Me.TextBody.TabIndex = 1
        '
        'LabelCaption
        '
        Me.LabelCaption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCaption.AutoSize = True
        Me.LabelCaption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LabelCaption.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.LabelCaption.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCaption.Location = New System.Drawing.Point(146, 158)
        Me.LabelCaption.Name = "LabelCaption"
        Me.LabelCaption.Size = New System.Drawing.Size(194, 30)
        Me.LabelCaption.TabIndex = 6
        Me.LabelCaption.Text = "Start writing here..."
        Me.LabelCaption.Visible = False
        '
        'LabelStatistics
        '
        Me.LabelStatistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatistics.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelStatistics.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelStatistics.Location = New System.Drawing.Point(220, 289)
        Me.LabelStatistics.Name = "LabelStatistics"
        Me.LabelStatistics.Size = New System.Drawing.Size(256, 32)
        Me.LabelStatistics.TabIndex = 5
        Me.LabelStatistics.Text = "Statistics"
        Me.LabelStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelStatistics.Visible = False
        '
        'TextHeader
        '
        Me.TextHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TextHeader.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TextHeader.Location = New System.Drawing.Point(14, 21)
        Me.TextHeader.Name = "TextHeader"
        Me.TextHeader.Size = New System.Drawing.Size(458, 20)
        Me.TextHeader.TabIndex = 0
        '
        'LabelHeaderCaption
        '
        Me.LabelHeaderCaption.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelHeaderCaption.AutoSize = True
        Me.LabelHeaderCaption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LabelHeaderCaption.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LabelHeaderCaption.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelHeaderCaption.Location = New System.Drawing.Point(121, 17)
        Me.LabelHeaderCaption.Name = "LabelHeaderCaption"
        Me.LabelHeaderCaption.Size = New System.Drawing.Size(242, 25)
        Me.LabelHeaderCaption.TabIndex = 10
        Me.LabelHeaderCaption.Text = "Provide a suitable title here"
        '
        'NewNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelHeaderCaption)
        Me.Controls.Add(Me.TextHeader)
        Me.Controls.Add(Me.LabelStatistics)
        Me.Controls.Add(Me.LabelCaption)
        Me.Controls.Add(Me.TextBody)
        Me.Controls.Add(Me.BtnPreferences)
        Me.Controls.Add(Me.BtnDiscardDraft)
        Me.Controls.Add(Me.BtnSaveToNotes)
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

    Friend WithEvents BtnSaveToNotes As Button
    Friend WithEvents BtnDiscardDraft As Button
    Friend WithEvents BtnPreferences As Button
    Friend WithEvents TextBody As TextBox
    Friend WithEvents LabelCaption As Label
    Friend WithEvents LabelStatistics As Label
    Friend WithEvents TextHeader As TextBox
    Friend WithEvents LabelHeaderCaption As Label
End Class
