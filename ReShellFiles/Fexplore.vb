Public Class Fexplore
    ' This is for dragging the form
    Dim drag As Boolean
    Dim PointClicked As Point
    Dim Documents As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim Pictures As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
    Dim Videos As String = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
    Dim Music As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
    Dim SystemRoot As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
    Dim HomeFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Dim Desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim Computer As String = Environment.GetFolderPath(Environment.SpecialFolder.AdminTools)
    Private Sub Fexplore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileExplorer.Navigate(HomeFolder) ' Navigates to the computer path
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        FileExplorer.GoBack() ' Makes the file browser go back
    End Sub

    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        FileExplorer.GoForward() ' Makes the file browser go forward
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        FileExplorer.Refresh() ' Refreshes the current page
    End Sub

    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        FileExplorer.Navigate(AddressBar.Text) ' Navigates the file browser to the text path entered in the address bar
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerButton.Click
        FileExplorer.Navigate(Computer) ' Navigates to the computer path
    End Sub

    Private Sub DocumentsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentsButton.Click
        FileExplorer.Navigate(Documents) ' Navigates to the documents path
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideosButton.Click
        FileExplorer.Navigate(Videos) ' Navigates to the videos path
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicButton.Click
        FileExplorer.Navigate(Music) ' Navigates to the music path
    End Sub

    Private Sub PicturesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicturesButton.Click
        FileExplorer.Navigate(Pictures) ' Navigates to the pictures path
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeFolderButton.Click
        FileExplorer.Navigate(HomeFolder) ' Navigates to the user folder path
    End Sub

    Private Sub SystemRootButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemRootButton.Click
        FileExplorer.Navigate(SystemRoot) ' Navigates to the system root
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesktopButton.Click
        FileExplorer.Navigate(Desktop) ' Navigates to the desktop folder
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown

        If e.Button = MouseButtons.Left Then
            drag = True
            PointClicked = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        If drag Then
            Dim PointMoveTo As Point


            PointMoveTo = Me.PointToScreen(New Point(e.X, e.Y))


            PointMoveTo.Offset(-PointClicked.X, -PointClicked.Y - (Me.Height - Me.ClientRectangle.Height))

            Me.Location = PointMoveTo
        End If
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseUp
        drag = False
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AppIcon_MouseDown(sender As Object, e As MouseEventArgs) Handles AppIcon.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            PointClicked = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub

    Private Sub AppIcon_MouseMove(sender As Object, e As MouseEventArgs) Handles AppIcon.MouseMove
        If drag Then
            Dim PointMoveTo As Point


            PointMoveTo = Me.PointToScreen(New Point(e.X, e.Y))


            PointMoveTo.Offset(-PointClicked.X, -PointClicked.Y - (Me.Height - Me.ClientRectangle.Height))

            Me.Location = PointMoveTo
        End If
    End Sub

    Private Sub AppIcon_MouseUp(sender As Object, e As MouseEventArgs) Handles AppIcon.MouseUp
        drag = False
    End Sub

    Private Sub MaximizeButton_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal Else Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub AppTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            PointClicked = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub

    Private Sub AppTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseMove
        If drag Then
            Dim PointMoveTo As Point


            PointMoveTo = Me.PointToScreen(New Point(e.X, e.Y))


            PointMoveTo.Offset(-PointClicked.X, -PointClicked.Y - (Me.Height - Me.ClientRectangle.Height))

            Me.Location = PointMoveTo
        End If
    End Sub

    Private Sub AppTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles AppTitle.MouseUp
        drag = False
    End Sub
End Class