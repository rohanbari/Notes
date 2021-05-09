<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.BtnNewNote = New System.Windows.Forms.Button()
        Me.BtnManageNotes = New System.Windows.Forms.Button()
        Me.BtnStatistics = New System.Windows.Forms.Button()
        Me.BtnAboutNotes = New System.Windows.Forms.Button()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnNewNote
        '
        Me.BtnNewNote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNewNote.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnNewNote.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.BtnNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewNote.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNewNote.ForeColor = System.Drawing.Color.White
        Me.BtnNewNote.Location = New System.Drawing.Point(92, 112)
        Me.BtnNewNote.Name = "BtnNewNote"
        Me.BtnNewNote.Size = New System.Drawing.Size(200, 25)
        Me.BtnNewNote.TabIndex = 0
        Me.BtnNewNote.Text = "New Note"
        Me.BtnNewNote.UseVisualStyleBackColor = False
        '
        'BtnManageNotes
        '
        Me.BtnManageNotes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnManageNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnManageNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageNotes.ForeColor = System.Drawing.Color.DimGray
        Me.BtnManageNotes.Location = New System.Drawing.Point(92, 143)
        Me.BtnManageNotes.Name = "BtnManageNotes"
        Me.BtnManageNotes.Size = New System.Drawing.Size(200, 25)
        Me.BtnManageNotes.TabIndex = 1
        Me.BtnManageNotes.Text = "Manage Notes"
        Me.BtnManageNotes.UseVisualStyleBackColor = True
        '
        'BtnStatistics
        '
        Me.BtnStatistics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatistics.ForeColor = System.Drawing.Color.DimGray
        Me.BtnStatistics.Location = New System.Drawing.Point(92, 174)
        Me.BtnStatistics.Name = "BtnStatistics"
        Me.BtnStatistics.Size = New System.Drawing.Size(200, 25)
        Me.BtnStatistics.TabIndex = 2
        Me.BtnStatistics.Text = "Statistics"
        Me.BtnStatistics.UseVisualStyleBackColor = True
        '
        'BtnAboutNotes
        '
        Me.BtnAboutNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAboutNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAboutNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAboutNotes.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.BtnAboutNotes.Location = New System.Drawing.Point(90, 274)
        Me.BtnAboutNotes.Name = "BtnAboutNotes"
        Me.BtnAboutNotes.Size = New System.Drawing.Size(200, 25)
        Me.BtnAboutNotes.TabIndex = 3
        Me.BtnAboutNotes.Text = "About Notes"
        Me.BtnAboutNotes.UseVisualStyleBackColor = True
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.LabelHeader.ForeColor = System.Drawing.Color.DimGray
        Me.LabelHeader.Location = New System.Drawing.Point(12, 9)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(199, 30)
        Me.LabelHeader.TabIndex = 4
        Me.LabelHeader.Text = "Welcome to Notes!"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.BtnAboutNotes)
        Me.Controls.Add(Me.BtnStatistics)
        Me.Controls.Add(Me.BtnManageNotes)
        Me.Controls.Add(Me.BtnNewNote)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 350)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNewNote As Button
    Friend WithEvents BtnManageNotes As Button
    Friend WithEvents BtnStatistics As Button
    Friend WithEvents BtnAboutNotes As Button
    Friend WithEvents LabelHeader As Label
End Class
