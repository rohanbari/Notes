<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutNotes))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.labelHeader = New System.Windows.Forms.Label()
        Me.labelSlogan = New System.Windows.Forms.Label()
        Me.labelPowered = New System.Windows.Forms.Label()
        Me.labelAbout = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.linkX = New System.Windows.Forms.LinkLabel()
        Me.tableMain = New System.Windows.Forms.TableLayoutPanel()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.labelAuthor = New System.Windows.Forms.Label()
        Me.labelCaptionCopyright = New System.Windows.Forms.Label()
        Me.labelCaptionAuthor = New System.Windows.Forms.Label()
        Me.labelCaptionVersion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(96, 96)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'labelHeader
        '
        Me.labelHeader.AutoSize = True
        Me.labelHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.labelHeader.ForeColor = System.Drawing.Color.DimGray
        Me.labelHeader.Location = New System.Drawing.Point(114, 12)
        Me.labelHeader.Name = "labelHeader"
        Me.labelHeader.Size = New System.Drawing.Size(105, 45)
        Me.labelHeader.TabIndex = 5
        Me.labelHeader.Text = "Notes"
        '
        'labelSlogan
        '
        Me.labelSlogan.AutoSize = True
        Me.labelSlogan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelSlogan.ForeColor = System.Drawing.Color.DarkGray
        Me.labelSlogan.Location = New System.Drawing.Point(119, 57)
        Me.labelSlogan.Name = "labelSlogan"
        Me.labelSlogan.Size = New System.Drawing.Size(263, 15)
        Me.labelSlogan.TabIndex = 6
        Me.labelSlogan.Text = "Take your notes with you. Anytime, anywhere."
        '
        'labelPowered
        '
        Me.labelPowered.AutoSize = True
        Me.labelPowered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelPowered.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelPowered.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.labelPowered.Location = New System.Drawing.Point(119, 93)
        Me.labelPowered.Name = "labelPowered"
        Me.labelPowered.Size = New System.Drawing.Size(188, 15)
        Me.labelPowered.TabIndex = 7
        Me.labelPowered.Text = "Powered by Technosoft Labs Inc."
        '
        'labelAbout
        '
        Me.labelAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.labelAbout.ForeColor = System.Drawing.Color.DimGray
        Me.labelAbout.Location = New System.Drawing.Point(12, 111)
        Me.labelAbout.Name = "labelAbout"
        Me.labelAbout.Size = New System.Drawing.Size(476, 125)
        Me.labelAbout.TabIndex = 8
        Me.labelAbout.Text = resources.GetString("labelAbout.Text")
        Me.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "© 2021 Technosoft Labs Inc. All rights reserved."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'linkX
        '
        Me.linkX.AutoSize = True
        Me.linkX.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.linkX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkX.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.linkX.Location = New System.Drawing.Point(445, 9)
        Me.linkX.Name = "linkX"
        Me.linkX.Size = New System.Drawing.Size(43, 45)
        Me.linkX.TabIndex = 10
        Me.linkX.TabStop = True
        Me.linkX.Text = "×"
        '
        'tableMain
        '
        Me.tableMain.ColumnCount = 2
        Me.tableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tableMain.Controls.Add(Me.labelCaptionVersion, 0, 2)
        Me.tableMain.Controls.Add(Me.labelCopyright, 1, 1)
        Me.tableMain.Controls.Add(Me.labelAuthor, 1, 0)
        Me.tableMain.Controls.Add(Me.labelCaptionCopyright, 0, 1)
        Me.tableMain.Controls.Add(Me.labelCaptionAuthor, 0, 0)
        Me.tableMain.Controls.Add(Me.Label2, 1, 2)
        Me.tableMain.Location = New System.Drawing.Point(12, 239)
        Me.tableMain.Name = "tableMain"
        Me.tableMain.RowCount = 3
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableMain.Size = New System.Drawing.Size(476, 84)
        Me.tableMain.TabIndex = 11
        '
        'labelCopyright
        '
        Me.labelCopyright.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCopyright.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.labelCopyright.Location = New System.Drawing.Point(145, 33)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(188, 15)
        Me.labelCopyright.TabIndex = 3
        Me.labelCopyright.Text = "GNU General Public License v3.0"
        Me.labelCopyright.UseMnemonic = False
        '
        'labelAuthor
        '
        Me.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelAuthor.AutoSize = True
        Me.labelAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelAuthor.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.labelAuthor.Location = New System.Drawing.Point(145, 6)
        Me.labelAuthor.Name = "labelAuthor"
        Me.labelAuthor.Size = New System.Drawing.Size(67, 15)
        Me.labelAuthor.TabIndex = 2
        Me.labelAuthor.Text = "Rohan Bari"
        Me.labelAuthor.UseMnemonic = False
        '
        'labelCaptionCopyright
        '
        Me.labelCaptionCopyright.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCaptionCopyright.AutoSize = True
        Me.labelCaptionCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCaptionCopyright.Location = New System.Drawing.Point(3, 33)
        Me.labelCaptionCopyright.Name = "labelCaptionCopyright"
        Me.labelCaptionCopyright.Size = New System.Drawing.Size(61, 15)
        Me.labelCaptionCopyright.TabIndex = 1
        Me.labelCaptionCopyright.Text = "Copyright"
        Me.labelCaptionCopyright.UseMnemonic = False
        '
        'labelCaptionAuthor
        '
        Me.labelCaptionAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCaptionAuthor.AutoSize = True
        Me.labelCaptionAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCaptionAuthor.Location = New System.Drawing.Point(3, 6)
        Me.labelCaptionAuthor.Name = "labelCaptionAuthor"
        Me.labelCaptionAuthor.Size = New System.Drawing.Size(121, 15)
        Me.labelCaptionAuthor.TabIndex = 0
        Me.labelCaptionAuthor.Text = "Author & Developer"
        Me.labelCaptionAuthor.UseMnemonic = False
        '
        'labelCaptionVersion
        '
        Me.labelCaptionVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCaptionVersion.AutoSize = True
        Me.labelCaptionVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCaptionVersion.Location = New System.Drawing.Point(3, 61)
        Me.labelCaptionVersion.Name = "labelCaptionVersion"
        Me.labelCaptionVersion.Size = New System.Drawing.Size(119, 15)
        Me.labelCaptionVersion.TabIndex = 4
        Me.labelCaptionVersion.Text = "Current App Version"
        Me.labelCaptionVersion.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(145, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Version"
        Me.Label2.UseMnemonic = False
        '
        'AboutNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(500, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.tableMain)
        Me.Controls.Add(Me.linkX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelAbout)
        Me.Controls.Add(Me.labelPowered)
        Me.Controls.Add(Me.labelSlogan)
        Me.Controls.Add(Me.labelHeader)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AboutNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Notes"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableMain.ResumeLayout(False)
        Me.tableMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents labelHeader As Label
    Friend WithEvents labelSlogan As Label
    Friend WithEvents labelPowered As Label
    Friend WithEvents labelAbout As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents linkX As LinkLabel
    Friend WithEvents tableMain As TableLayoutPanel
    Friend WithEvents labelCaptionCopyright As Label
    Friend WithEvents labelCaptionAuthor As Label
    Friend WithEvents labelCopyright As Label
    Friend WithEvents labelAuthor As Label
    Friend WithEvents labelCaptionVersion As Label
    Friend WithEvents Label2 As Label
End Class
