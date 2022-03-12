<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fexplore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fexplore))
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.FileExplorer = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.AddressBar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DesktopButton = New System.Windows.Forms.Button()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HomeFolderButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.VideosButton = New System.Windows.Forms.Button()
        Me.DocumentsButton = New System.Windows.Forms.Button()
        Me.ComputerButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SystemRootButton = New System.Windows.Forms.Button()
        Me.PicturesButton = New System.Windows.Forms.Button()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppIcon
        '
        Me.AppIcon.BackColor = System.Drawing.Color.Transparent
        Me.AppIcon.Image = CType(resources.GetObject("AppIcon.Image"), System.Drawing.Image)
        Me.AppIcon.Location = New System.Drawing.Point(5, 5)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(24, 24)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 14
        Me.AppIcon.TabStop = False
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.BackColor = System.Drawing.Color.White
        Me.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshButton.Location = New System.Drawing.Point(655, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(74, 30)
        Me.RefreshButton.TabIndex = 4
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.BackColor = System.Drawing.Color.White
        Me.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForwardButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForwardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForwardButton.ForeColor = System.Drawing.Color.Black
        Me.ForwardButton.Location = New System.Drawing.Point(171, 2)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 30)
        Me.ForwardButton.TabIndex = 1
        Me.ForwardButton.Text = "->"
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'FileExplorer
        '
        Me.FileExplorer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileExplorer.Location = New System.Drawing.Point(162, 36)
        Me.FileExplorer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.FileExplorer.Name = "FileExplorer"
        Me.FileExplorer.Size = New System.Drawing.Size(738, 444)
        Me.FileExplorer.TabIndex = 4
        Me.FileExplorer.Url = New System.Uri("", System.UriKind.Relative)
        Me.FileExplorer.WebBrowserShortcutsEnabled = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Inter Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Personal"
        '
        'GoButton
        '
        Me.GoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoButton.BackColor = System.Drawing.Color.White
        Me.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GoButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoButton.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoButton.ForeColor = System.Drawing.Color.Black
        Me.GoButton.Location = New System.Drawing.Point(728, 2)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(48, 30)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = False
        '
        'AddressBar
        '
        Me.AddressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressBar.BackColor = System.Drawing.Color.White
        Me.AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressBar.ForeColor = System.Drawing.Color.Black
        Me.AddressBar.Location = New System.Drawing.Point(213, 6)
        Me.AddressBar.Name = "AddressBar"
        Me.AddressBar.Size = New System.Drawing.Size(436, 22)
        Me.AddressBar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Inter Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "System"
        '
        'DesktopButton
        '
        Me.DesktopButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DesktopButton.BackColor = System.Drawing.Color.White
        Me.DesktopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DesktopButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.DesktopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.DesktopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DesktopButton.Location = New System.Drawing.Point(0, 49)
        Me.DesktopButton.Name = "DesktopButton"
        Me.DesktopButton.Size = New System.Drawing.Size(162, 27)
        Me.DesktopButton.TabIndex = 8
        Me.DesktopButton.Text = "Desktop"
        Me.DesktopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DesktopButton.UseVisualStyleBackColor = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.White
        Me.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleBar.Controls.Add(Me.AppTitle)
        Me.TitleBar.Controls.Add(Me.AppIcon)
        Me.TitleBar.Controls.Add(Me.MinimizeButton)
        Me.TitleBar.Controls.Add(Me.RefreshButton)
        Me.TitleBar.Controls.Add(Me.MaximizeButton)
        Me.TitleBar.Controls.Add(Me.GoButton)
        Me.TitleBar.Controls.Add(Me.CloseButton)
        Me.TitleBar.Controls.Add(Me.AddressBar)
        Me.TitleBar.Controls.Add(Me.ForwardButton)
        Me.TitleBar.Controls.Add(Me.BackButton)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(900, 36)
        Me.TitleBar.TabIndex = 3
        '
        'AppTitle
        '
        Me.AppTitle.AutoSize = True
        Me.AppTitle.BackColor = System.Drawing.Color.Transparent
        Me.AppTitle.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle.Location = New System.Drawing.Point(35, 8)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(33, 15)
        Me.AppTitle.TabIndex = 15
        Me.AppTitle.Text = "Files"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BackgroundImage = CType(resources.GetObject("MinimizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Location = New System.Drawing.Point(782, -1)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(37, 36)
        Me.MinimizeButton.TabIndex = 13
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'MaximizeButton
        '
        Me.MaximizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.BackgroundImage = CType(resources.GetObject("MaximizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Location = New System.Drawing.Point(822, -1)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(37, 36)
        Me.MaximizeButton.TabIndex = 12
        Me.MaximizeButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(862, -1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(37, 36)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Black
        Me.BackButton.Location = New System.Drawing.Point(136, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 30)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "<-"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'HomeFolderButton
        '
        Me.HomeFolderButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeFolderButton.BackColor = System.Drawing.Color.White
        Me.HomeFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.HomeFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.HomeFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeFolderButton.Location = New System.Drawing.Point(0, 179)
        Me.HomeFolderButton.Name = "HomeFolderButton"
        Me.HomeFolderButton.Size = New System.Drawing.Size(162, 27)
        Me.HomeFolderButton.TabIndex = 7
        Me.HomeFolderButton.Text = "Home Folder"
        Me.HomeFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeFolderButton.UseVisualStyleBackColor = False
        '
        'MusicButton
        '
        Me.MusicButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MusicButton.BackColor = System.Drawing.Color.White
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.MusicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.MusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MusicButton.Location = New System.Drawing.Point(0, 153)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(162, 27)
        Me.MusicButton.TabIndex = 5
        Me.MusicButton.Text = "Music"
        Me.MusicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MusicButton.UseVisualStyleBackColor = False
        '
        'VideosButton
        '
        Me.VideosButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideosButton.BackColor = System.Drawing.Color.White
        Me.VideosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VideosButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.VideosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.VideosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VideosButton.Location = New System.Drawing.Point(0, 127)
        Me.VideosButton.Name = "VideosButton"
        Me.VideosButton.Size = New System.Drawing.Size(162, 27)
        Me.VideosButton.TabIndex = 4
        Me.VideosButton.Text = "Videos"
        Me.VideosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VideosButton.UseVisualStyleBackColor = False
        '
        'DocumentsButton
        '
        Me.DocumentsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocumentsButton.BackColor = System.Drawing.Color.White
        Me.DocumentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DocumentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.DocumentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.DocumentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DocumentsButton.Location = New System.Drawing.Point(0, 75)
        Me.DocumentsButton.Name = "DocumentsButton"
        Me.DocumentsButton.Size = New System.Drawing.Size(162, 27)
        Me.DocumentsButton.TabIndex = 2
        Me.DocumentsButton.Text = "Documents" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DocumentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DocumentsButton.UseVisualStyleBackColor = False
        '
        'ComputerButton
        '
        Me.ComputerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComputerButton.BackColor = System.Drawing.Color.White
        Me.ComputerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ComputerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ComputerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.ComputerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComputerButton.Location = New System.Drawing.Point(-1, 243)
        Me.ComputerButton.Name = "ComputerButton"
        Me.ComputerButton.Size = New System.Drawing.Size(162, 27)
        Me.ComputerButton.TabIndex = 0
        Me.ComputerButton.Text = "Computer"
        Me.ComputerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComputerButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DesktopButton)
        Me.Panel2.Controls.Add(Me.HomeFolderButton)
        Me.Panel2.Controls.Add(Me.SystemRootButton)
        Me.Panel2.Controls.Add(Me.MusicButton)
        Me.Panel2.Controls.Add(Me.VideosButton)
        Me.Panel2.Controls.Add(Me.PicturesButton)
        Me.Panel2.Controls.Add(Me.DocumentsButton)
        Me.Panel2.Controls.Add(Me.ComputerButton)
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 444)
        Me.Panel2.TabIndex = 5
        '
        'SystemRootButton
        '
        Me.SystemRootButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SystemRootButton.BackColor = System.Drawing.Color.White
        Me.SystemRootButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SystemRootButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.SystemRootButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.SystemRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemRootButton.Location = New System.Drawing.Point(-1, 269)
        Me.SystemRootButton.Name = "SystemRootButton"
        Me.SystemRootButton.Size = New System.Drawing.Size(162, 27)
        Me.SystemRootButton.TabIndex = 6
        Me.SystemRootButton.Text = "System Root"
        Me.SystemRootButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemRootButton.UseVisualStyleBackColor = False
        '
        'PicturesButton
        '
        Me.PicturesButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicturesButton.BackColor = System.Drawing.Color.White
        Me.PicturesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicturesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.PicturesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.PicturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PicturesButton.Location = New System.Drawing.Point(0, 101)
        Me.PicturesButton.Name = "PicturesButton"
        Me.PicturesButton.Size = New System.Drawing.Size(162, 27)
        Me.PicturesButton.TabIndex = 3
        Me.PicturesButton.Text = "Pictures"
        Me.PicturesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PicturesButton.UseVisualStyleBackColor = False
        '
        'Fexplore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 480)
        Me.Controls.Add(Me.FileExplorer)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Fexplore"
        Me.Text = "Files"
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AppIcon As PictureBox
    Friend WithEvents RefreshButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents FileExplorer As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents GoButton As Button
    Friend WithEvents AddressBar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DesktopButton As Button
    Friend WithEvents TitleBar As Panel
    Friend WithEvents AppTitle As Label
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents HomeFolderButton As Button
    Friend WithEvents MusicButton As Button
    Friend WithEvents VideosButton As Button
    Friend WithEvents DocumentsButton As Button
    Friend WithEvents ComputerButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SystemRootButton As Button
    Friend WithEvents PicturesButton As Button
End Class
