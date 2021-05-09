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
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.LabelSlogan = New System.Windows.Forms.Label()
        Me.LabelPowered = New System.Windows.Forms.Label()
        Me.LabelAbout = New System.Windows.Forms.Label()
        Me.LabelCopyrightInfo = New System.Windows.Forms.Label()
        Me.LinkX = New System.Windows.Forms.LinkLabel()
        Me.TableMain = New System.Windows.Forms.TableLayoutPanel()
        Me.labelCaptionVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelAuthor = New System.Windows.Forms.Label()
        Me.labelCaptionCopyright = New System.Windows.Forms.Label()
        Me.labelCaptionAuthor = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(12, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(96, 96)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.LabelHeader.ForeColor = System.Drawing.Color.DimGray
        Me.LabelHeader.Location = New System.Drawing.Point(114, 12)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(105, 45)
        Me.LabelHeader.TabIndex = 5
        Me.LabelHeader.Text = "Notes"
        '
        'LabelSlogan
        '
        Me.LabelSlogan.AutoSize = True
        Me.LabelSlogan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSlogan.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelSlogan.Location = New System.Drawing.Point(119, 57)
        Me.LabelSlogan.Name = "LabelSlogan"
        Me.LabelSlogan.Size = New System.Drawing.Size(263, 15)
        Me.LabelSlogan.TabIndex = 6
        Me.LabelSlogan.Text = "Take your notes with you. Anytime, anywhere."
        '
        'LabelPowered
        '
        Me.LabelPowered.AutoSize = True
        Me.LabelPowered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPowered.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPowered.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelPowered.Location = New System.Drawing.Point(119, 93)
        Me.LabelPowered.Name = "LabelPowered"
        Me.LabelPowered.Size = New System.Drawing.Size(188, 15)
        Me.LabelPowered.TabIndex = 7
        Me.LabelPowered.Text = "Powered by Technosoft Labs Inc."
        '
        'LabelAbout
        '
        Me.LabelAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelAbout.ForeColor = System.Drawing.Color.DimGray
        Me.LabelAbout.Location = New System.Drawing.Point(12, 111)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(476, 125)
        Me.LabelAbout.TabIndex = 8
        Me.LabelAbout.Text = resources.GetString("LabelAbout.Text")
        Me.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyrightInfo
        '
        Me.LabelCopyrightInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCopyrightInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCopyrightInfo.ForeColor = System.Drawing.Color.DimGray
        Me.LabelCopyrightInfo.Location = New System.Drawing.Point(12, 326)
        Me.LabelCopyrightInfo.Name = "LabelCopyrightInfo"
        Me.LabelCopyrightInfo.Size = New System.Drawing.Size(476, 40)
        Me.LabelCopyrightInfo.TabIndex = 9
        Me.LabelCopyrightInfo.Text = "© 2021 Technosoft Labs Inc. All rights reserved."
        Me.LabelCopyrightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkX
        '
        Me.LinkX.AutoSize = True
        Me.LinkX.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LinkX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkX.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkX.Location = New System.Drawing.Point(445, 9)
        Me.LinkX.Name = "LinkX"
        Me.LinkX.Size = New System.Drawing.Size(43, 45)
        Me.LinkX.TabIndex = 10
        Me.LinkX.TabStop = True
        Me.LinkX.Text = "×"
        '
        'TableMain
        '
        Me.TableMain.ColumnCount = 2
        Me.TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableMain.Controls.Add(Me.labelCaptionVersion, 0, 2)
        Me.TableMain.Controls.Add(Me.LabelCopyright, 1, 1)
        Me.TableMain.Controls.Add(Me.LabelAuthor, 1, 0)
        Me.TableMain.Controls.Add(Me.labelCaptionCopyright, 0, 1)
        Me.TableMain.Controls.Add(Me.labelCaptionAuthor, 0, 0)
        Me.TableMain.Controls.Add(Me.LabelVersion, 1, 2)
        Me.TableMain.Location = New System.Drawing.Point(12, 239)
        Me.TableMain.Name = "TableMain"
        Me.TableMain.RowCount = 3
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMain.Size = New System.Drawing.Size(476, 84)
        Me.TableMain.TabIndex = 11
        '
        'labelCaptionVersion
        '
        Me.labelCaptionVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCaptionVersion.AutoSize = True
        Me.labelCaptionVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCaptionVersion.Location = New System.Drawing.Point(3, 62)
        Me.labelCaptionVersion.Name = "labelCaptionVersion"
        Me.labelCaptionVersion.Size = New System.Drawing.Size(119, 15)
        Me.labelCaptionVersion.TabIndex = 4
        Me.labelCaptionVersion.Text = "Current App Version"
        Me.labelCaptionVersion.UseMnemonic = False
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCopyright.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelCopyright.Location = New System.Drawing.Point(145, 34)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(188, 15)
        Me.LabelCopyright.TabIndex = 3
        Me.LabelCopyright.Text = "GNU General Public License v3.0"
        Me.LabelCopyright.UseMnemonic = False
        '
        'LabelAuthor
        '
        Me.LabelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAuthor.AutoSize = True
        Me.LabelAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelAuthor.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelAuthor.Location = New System.Drawing.Point(145, 6)
        Me.LabelAuthor.Name = "LabelAuthor"
        Me.LabelAuthor.Size = New System.Drawing.Size(67, 15)
        Me.LabelAuthor.TabIndex = 2
        Me.LabelAuthor.Text = "Rohan Bari"
        Me.LabelAuthor.UseMnemonic = False
        '
        'labelCaptionCopyright
        '
        Me.labelCaptionCopyright.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labelCaptionCopyright.AutoSize = True
        Me.labelCaptionCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelCaptionCopyright.Location = New System.Drawing.Point(3, 34)
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
        'LabelVersion
        '
        Me.LabelVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelVersion.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelVersion.Location = New System.Drawing.Point(145, 62)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(48, 15)
        Me.LabelVersion.TabIndex = 5
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.UseMnemonic = False
        '
        'AboutNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(500, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableMain)
        Me.Controls.Add(Me.LinkX)
        Me.Controls.Add(Me.LabelCopyrightInfo)
        Me.Controls.Add(Me.LabelAbout)
        Me.Controls.Add(Me.LabelPowered)
        Me.Controls.Add(Me.LabelSlogan)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.PicLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AboutNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Notes"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableMain.ResumeLayout(False)
        Me.TableMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LabelHeader As Label
    Friend WithEvents LabelSlogan As Label
    Friend WithEvents LabelPowered As Label
    Friend WithEvents LabelAbout As Label
    Friend WithEvents LabelCopyrightInfo As Label
    Friend WithEvents LinkX As LinkLabel
    Friend WithEvents TableMain As TableLayoutPanel
    Friend WithEvents labelCaptionCopyright As Label
    Friend WithEvents labelCaptionAuthor As Label
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelAuthor As Label
    Friend WithEvents labelCaptionVersion As Label
    Friend WithEvents LabelVersion As Label
End Class
