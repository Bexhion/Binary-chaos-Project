Public Class MainForm

    Public Shared userDetails As MyJsonParser.User
    Dim windowRelativeSize As Double = 0.85
    Dim contextMenuMinimized As New ContextMenu
    Dim isRemoving As Boolean = True
    'every minute
    Dim WithEvents checkTimer As New Timer With {.Interval = 1000}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Close()
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
        Dim userAccount As New UserAccount
        userAccount.Location = Me.PointToScreen(userAccount.PointToClient(New Point(0, 45)))
        userAccount.Show()
    End Sub
End Class