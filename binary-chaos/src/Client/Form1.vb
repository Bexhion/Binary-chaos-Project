Imports System.IO
Public Class MainForm

    Public Shared userDetails As MyJsonParser.User
    Dim windowRelativeSize As Double = 0.85
    Dim contextMenuMinimized As New ContextMenu
    Dim isRemoving As Boolean = True
    Dim blackListedPrograms As New List(Of String)
    Dim WithEvents userAccountForm As UserAccount

    'set to every minute after checking
    Dim WithEvents checkTimer As New Timer With {.Interval = 1000}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userDetails Is Nothing Then
            Application.Exit()
        End If
        'Check if our relative size isn't inferior to 0% or superior to 100%
        If windowRelativeSize > 1 Then
            windowRelativeSize = 1
        End If
        If windowRelativeSize < 0 Then
            windowRelativeSize = 0
        End If

        Dim size As New Size(0, 0)
        Dim location As New Point(0, 0)

        'Perform calculations with Screen.PrimaryScreen.Bounds.Size
        size.Width = Screen.PrimaryScreen.Bounds.Size.Width * windowRelativeSize
        size.Height = Screen.PrimaryScreen.Bounds.Size.Height * windowRelativeSize

        location.X = (Screen.PrimaryScreen.Bounds.Size.Width * (1 - windowRelativeSize)) / 2
        location.Y = (Screen.PrimaryScreen.Bounds.Size.Height * (1 - windowRelativeSize)) / 2

        'Setting the properties
        Me.Size = size
        Me.Location = location

        contextMenuMinimized.MenuItems.Add(NewMenuItem(0, "Exit", AddressOf MenuItemExit))
        WindowMinimizedIcon.ContextMenu = contextMenuMinimized
        CustomListBox1.SetDescriptor(TimeMarkerDescription1)
        SetMarker.Hide()
        CancelMarker.Hide()
        checkTimer.Start()
        userAccountForm = New UserAccount
        PopulateListBox()
        AddHandler CustomListBox1.ListChanged, AddressOf WriteMarkersToUser
        TestForMarkers(Date.Now)
        CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.FIXED)
        SetUsername(userDetails.username)
        userAccountForm.LoadImage(Path.Combine(MyJsonParser.applicationPath, "users", "images", userDetails.username & ".png"))
        userAccountForm.Location = Me.PointToScreen(userAccountForm.PointToClient(New Point(0, 45)))
        _EXP_ProgramTerminator.blackListedPrograms = userDetails.blacklistedPrograms
    End Sub

    Public Function NewMenuItem(index As Integer, text As String, handler As EventHandler) As MenuItem
        Dim item As New MenuItem
        With item
            .Index = index
            .Text = text
        End With
        AddHandler item.Click, handler
        Return item
    End Function

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        System.Diagnostics.Process.Start("http://franciscocardoso7.wixsite.com/studyroom")

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles WindowMinimizedIcon.MouseDoubleClick
        ShowInTaskbar = True
        WindowState = FormWindowState.Normal
        WindowMinimizedIcon.Visible = False
    End Sub

    Private Sub UserBoxMouseOver(sender As Object, e As EventArgs) Handles UserBox.MouseHover
        UserBoxTooltip.SetToolTip(UserBox, "Username")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If userAccountForm IsNot Nothing Then
            userAccountForm.Hide()
        End If
        WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
        WindowMinimizedIcon.Visible = True
        WindowMinimizedIcon.Icon = Icon
        WindowMinimizedIcon.BalloonTipIcon = ToolTipIcon.Info
        WindowMinimizedIcon.BalloonTipTitle = "Sloth no more is now running in the background"
        WindowMinimizedIcon.BalloonTipText = "Markers will be automatically handled"
        WindowMinimizedIcon.ShowBalloonTip(5000)
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuItemExit(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub EditClick(sender As Object, e As EventArgs) Handles EditMarker.Click
        If CustomListBox1.currentActiveControl IsNot Nothing Then
            EditMarker.BackColor = Color.FromArgb(50, 50, 50)
            AddMarker.Enabled = False
            EditMarker.Enabled = False
            RemoveMarker.Enabled = False
            SetMarker.Show()
            CancelMarker.Show()
            CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.EDIT)
        Else
            MsgBox("There is no marker to be edited. Select a marker")
        End If
    End Sub

    Private Sub AddClick(sender As Object, e As EventArgs) Handles AddMarker.Click
        AddMarker.BackColor = Color.FromArgb(50, 50, 50)
        AddMarker.Enabled = False
        EditMarker.Enabled = False
        RemoveMarker.Enabled = False
        SetMarker.Show()
        CancelMarker.Show()
        CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.ADD)
    End Sub

    Private Sub RemoveMarker_Click(sender As Object, e As EventArgs) Handles RemoveMarker.Click
        If CustomListBox1.ActualList.Controls.Count > 0 Then
            isRemoving = Not isRemoving
            If Not isRemoving Then
                RemoveMarker.BackColor = Color.FromArgb(50, 50, 50)
                AddMarker.Enabled = False
                EditMarker.Enabled = False
            Else
                RemoveMarker.BackColor = Color.Transparent
                AddMarker.Enabled = True
                EditMarker.Enabled = True
            End If
            If Not isRemoving Then
                CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.REMOVE)
            Else
                If CustomListBox1.listToDelete.Count > 0 Then
                    CustomListBox1.Clear(CustomListBox1.listToDelete)
                    CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.FIXED)
                Else
                    MsgBox("There are no markers set for deletion")
                End If
            End If
        Else
            MsgBox("There are no registered markers")
        End If
    End Sub

    Private Sub SetMarker_Click(sender As Object, e As EventArgs) Handles SetMarker.Click
        If TimeMarkerDescription1.PushMyInformation() Then
            SetMarker.Hide()
            CancelMarker.Hide()
            AddMarker.Enabled = True
            AddMarker.BackColor = Color.Transparent
            EditMarker.Enabled = True
            EditMarker.BackColor = Color.Transparent
            RemoveMarker.Enabled = True
            RemoveMarker.BackColor = Color.Transparent
            CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.FIXED)
        End If
    End Sub

    Private Sub CancelMarker_Click(sender As Object, e As EventArgs) Handles CancelMarker.Click
        CustomListBox1.ChangeEditorMode(CustomListBox.EditorMode.FIXED)
        SetMarker.Hide()
        CancelMarker.Hide()
        AddMarker.Enabled = True
        AddMarker.BackColor = Color.Transparent
        EditMarker.Enabled = True
        EditMarker.BackColor = Color.Transparent
        RemoveMarker.Enabled = True
        RemoveMarker.BackColor = Color.Transparent
    End Sub

    Private Sub CheckTimerTick(sender As Object, e As EventArgs) Handles checkTimer.Tick
        If Date.Now.Second = 0 And Not checkTimer.Interval = 60000 Then
            checkTimer.Interval = 60000
            Exit Sub
        End If
        CustomListBox1.CheckAll(Date.Now)
    End Sub

    Private Sub UserClick(sender As Object, e As EventArgs) Handles PictureBox1.Click, Greeting.Click, Username.Click, UserBox.Click
        userAccountForm.Show()
    End Sub

    Private Sub WriteMarkersToUser(list As CustomListBox)
        If userDetails Is Nothing Then Exit Sub
        Dim markerList As New List(Of MyJsonParser.User.Marker)
        For i = list.ActualList.Controls.Count - 1 To 0 Step -1
            Dim control As TimeMarkerItemCLB = list.ActualList.Controls(i)
            Dim newMarker As New MyJsonParser.User.Marker
            With newMarker
                .Name = control.Name
                .Title = control.Title
                .Description = control.Description
                .DateStart = control.FullDate
                .DateEnd = control.FullDateEnd
                .Points = control.Points
                .AccomplishedPoints = control.AccomplishedPoints
                .Priority = control.Priority
            End With
            markerList.Add(newMarker)
        Next
        userDetails.allTimeMarkers = markerList
        MyJsonParser.User.SaveUser(userDetails)
        userAccountForm.Markers.Text = "Currently saved markers: " & MainForm.userDetails.allTimeMarkers.Count
    End Sub

    Private Sub PopulateListBox()
        If userDetails Is Nothing Then Exit Sub
        Dim markerList As List(Of MyJsonParser.User.Marker) = userDetails.allTimeMarkers
        For i = markerList.Count - 1 To 0 Step -1
            Dim marker As MyJsonParser.User.Marker = markerList(i)
            Dim timeMarker As New TimeMarkerItemCLB
            With timeMarker
                .Name = marker.name
                .Title = marker.Title
                .Description = marker.Description
                .Points = marker.Points
                .AccomplishedPoints = marker.AccomplishedPoints
                .Priority = marker.Priority
                .timeMarker = New TimeMarker(marker.DateStart, marker.DateEnd)
                .FullDate = marker.DateStart
                .FullDateEnd = marker.DateEnd
            End With
            CustomListBox1.Add(timeMarker)
        Next
    End Sub

    Private Sub OnUserAccountClose(sender As Object, e As EventArgs) Handles userAccountForm.FormClosed
        userAccountForm = Nothing
    End Sub

    Private Sub TestForMarkers(thisDate As Date)
        Dim removed As Boolean = False
        For i = CustomListBox1.ActualList.Controls.Count - 1 To 0 Step -1
            Dim control As TimeMarkerItemCLB = CustomListBox1.ActualList.Controls(i)
            If control.FullDate <= thisDate Then
                CustomListBox1.Remove(i)
                removed = True
            End If
        Next
        If removed Then
            MsgBox("Some time markers have become invalid and were removed", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub CalculateFitness(accPoints As Integer, totalPoints As Integer)
        Dim fitness As Double = userDetails.fitness
        Dim prevAccPoints As Double = fitness * 100
        Dim accPointsTo100 As Double = (accPoints * 100) / totalPoints
        Dim totalAccPoints As Double = accPointsTo100 + prevAccPoints
        Dim newFitness As Double = totalAccPoints / 200
        userDetails.fitness = newFitness
        MyJsonParser.User.SaveUser(userDetails)
        userAccountForm.Text = "Fitness: " & userDetails.fitness.ToString & "%"
    End Sub

    Private Sub SetUsername(text As String)
        Dim right As Integer = UserBox.Right
        Username.Text = text
        If Username.Width > 81 Then
            UserBox.Width += PictureBox1.Width + 5
            Dim xPos As Integer = right - UserBox.Width
            UserBox.Location = New Point(xPos, UserBox.Location.Y)
            Help.Location = New Point(xPos - 3 - Help.Width, Help.Location.Y)
        End If
    End Sub

    Private Sub PhotoChanged() Handles userAccountForm.PhotoChanged
        PictureBox1.BackgroundImage = UserAccount.picture
    End Sub
End Class