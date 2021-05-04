<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnNewNote = New System.Windows.Forms.Button()
        Me.btnManageNotes = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnAboutNotes = New System.Windows.Forms.Button()
        Me.labelHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNewNote
        '
        Me.btnNewNote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewNote.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNewNote.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewNote.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewNote.ForeColor = System.Drawing.Color.White
        Me.btnNewNote.Location = New System.Drawing.Point(92, 112)
        Me.btnNewNote.Name = "btnNewNote"
        Me.btnNewNote.Size = New System.Drawing.Size(200, 25)
        Me.btnNewNote.TabIndex = 0
        Me.btnNewNote.Text = "New Note"
        Me.btnNewNote.UseVisualStyleBackColor = False
        '
        'btnManageNotes
        '
        Me.btnManageNotes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnManageNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageNotes.ForeColor = System.Drawing.Color.DimGray
        Me.btnManageNotes.Location = New System.Drawing.Point(92, 143)
        Me.btnManageNotes.Name = "btnManageNotes"
        Me.btnManageNotes.Size = New System.Drawing.Size(200, 25)
        Me.btnManageNotes.TabIndex = 1
        Me.btnManageNotes.Text = "Manage Notes"
        Me.btnManageNotes.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistics.ForeColor = System.Drawing.Color.DimGray
        Me.btnStatistics.Location = New System.Drawing.Point(92, 174)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(200, 25)
        Me.btnStatistics.TabIndex = 2
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'btnAboutNotes
        '
        Me.btnAboutNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAboutNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAboutNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutNotes.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAboutNotes.Location = New System.Drawing.Point(90, 274)
        Me.btnAboutNotes.Name = "btnAboutNotes"
        Me.btnAboutNotes.Size = New System.Drawing.Size(200, 25)
        Me.btnAboutNotes.TabIndex = 3
        Me.btnAboutNotes.Text = "About Notes"
        Me.btnAboutNotes.UseVisualStyleBackColor = True
        '
        'labelHeader
        '
        Me.labelHeader.AutoSize = True
        Me.labelHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.labelHeader.ForeColor = System.Drawing.Color.DimGray
        Me.labelHeader.Location = New System.Drawing.Point(12, 9)
        Me.labelHeader.Name = "labelHeader"
        Me.labelHeader.Size = New System.Drawing.Size(199, 30)
        Me.labelHeader.TabIndex = 4
        Me.labelHeader.Text = "Welcome to Notes!"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.labelHeader)
        Me.Controls.Add(Me.btnAboutNotes)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnManageNotes)
        Me.Controls.Add(Me.btnNewNote)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 350)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewNote As Button
    Friend WithEvents btnManageNotes As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnAboutNotes As Button
    Friend WithEvents labelHeader As Label
End Class
