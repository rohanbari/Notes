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
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.labelAbout.Location = New System.Drawing.Point(12, 140)
        Me.labelAbout.Name = "labelAbout"
        Me.labelAbout.Size = New System.Drawing.Size(476, 115)
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
        Me.Label1.Location = New System.Drawing.Point(12, 301)
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
        'AboutNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.ControlBox = False
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
End Class
