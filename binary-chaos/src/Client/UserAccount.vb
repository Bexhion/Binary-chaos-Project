Imports System.IO
Public Class UserAccount

    Dim currentlySelectedProgram As Label = Nothing
    Public Shared picture As Image = Nothing
    Public Event PhotoChanged()

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        'Animate()
        Me.Hide()
    End Sub

    Private Sub ChangePicture_Click(sender As Object, e As EventArgs) Handles ChangePicture.Click
        Dim folderBrowser As New OpenFileDialog
        With folderBrowser
            .Title = "Select a picture"
            .Multiselect = False
            .CheckFileExists = True
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            .Filter = "Image Files (*.PNG)|*.PNG"
            .RestoreDirectory = True
        End With
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            Dim stream As Stream = Nothing
            Try
                stream = folderBrowser.OpenFile
                If stream IsNot Nothing Then
                    Dim thisPath As String = Path.Combine(MyJsonParser.applicationPath, "users", "images")
                    SaveImage(stream, thisPath)
                    If File.Exists(Path.Combine(thisPath, MainForm.userDetails.username & ".png")) Then
                        LoadImage(Path.Combine(thisPath, MainForm.userDetails.username & ".png"))
                    End If
                End If
            Catch ex As Exception
                MsgBox("Could not open file")
            Finally
                If stream IsNot Nothing Then
                    stream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub AddProgram_Click(sender As Object, e As EventArgs) Handles AddProgram.Click
        Dim folderBrowser As New OpenFileDialog
        With folderBrowser
            .Title = "Select an executable file"
            .Multiselect = True
            .CheckFileExists = True
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
            .Filter = "Executable Files (*.EXE)|*.EXE|All Files (*.*)|*.*"
            .RestoreDirectory = True
        End With
        If folderBrowser.ShowDialog = DialogResult.OK Then
            Dim programString() As String = Nothing
            Try
                programString = folderBrowser.SafeFileNames
                For Each file As String In programString
                    Dim label As New Label
                    With label
                        .Name = "labelFile" & file
                        .Text = file
                        .ForeColor = Color.White
                        .Font = New Font("Microsoft Sans Serif", 9)
                    End With
                    AddHandler label.Click, AddressOf LabelClick
                    If Not Programs.Controls.Contains(label) Then
                        Programs.Controls.Add(label)
                        _EXP_ProgramTerminator.blackListedPrograms.Add(file)
                        MainForm.userDetails.blacklistedPrograms = _EXP_ProgramTerminator.blackListedPrograms
                        MyJsonParser.User.SaveUser(MainForm.userDetails)
                    Else
                        MsgBox("That program is already blacklisted")
                    End If
                Next
            Catch ex As Exception
                MsgBox("Program is not valid")
            End Try
        End If
    End Sub

    Private Sub RemoveProgram_Click(sender As Object, e As EventArgs) Handles RemoveProgram.Click
        If currentlySelectedProgram IsNot Nothing Then
            If Programs.Controls.Contains(currentlySelectedProgram) And _EXP_ProgramTerminator.blackListedPrograms.Contains(currentlySelectedProgram.Text) Then
                _EXP_ProgramTerminator.blackListedPrograms.Remove(currentlySelectedProgram.Text)
                Programs.Controls.Remove(currentlySelectedProgram)
                RemoveHandler currentlySelectedProgram.Click, AddressOf LabelClick
                currentlySelectedProgram.Dispose()
                currentlySelectedProgram = Nothing
                MyJsonParser.User.SaveUser(MainForm.userDetails)
            End If
        End If
    End Sub

    Private Sub PasswordChange_Click(sender As Object, e As EventArgs) Handles PasswordChange.Click
        UserChange(False)
        RecoverPassword.userName = MainForm.userDetails.username
        MainForm.userDetails = Nothing
        RecoverPassword.Show()
        Me.Hide()
        MainForm.Hide()
    End Sub

    Private Sub MarkerDelete_Click(sender As Object, e As EventArgs) Handles MarkerDelete.Click
        Dim markerList As New List(Of TimeMarkerItemCLB)
        For Each control As TimeMarkerItemCLB In MainForm.CustomListBox1.ActualList.Controls
            markerList.Add(control)
        Next
        MainForm.CustomListBox1.Clear(markerList)
        Dim simplifedMarker As New List(Of MyJsonParser.User.Marker)
        For i = MainForm.CustomListBox1.ActualList.Controls.Count - 1 To 0 Step -1
            Dim control As TimeMarkerItemCLB = MainForm.CustomListBox1.ActualList.Controls(i)
            Dim newMarker As New MyJsonParser.User.Marker
            With newMarker
                .Title = control.Title
                .Description = control.Description
                .DateStart = control.FullDate
                .DateEnd = control.FullDateEnd
                .Points = control.Points
                .Priority = control.Priority
                .AccomplishedPoints = control.AccomplishedPoints
            End With
            simplifedMarker.Add(newMarker)
        Next
        MainForm.userDetails.allTimeMarkers = simplifedMarker
        MyJsonParser.User.SaveUser(MainForm.userDetails)
        Markers.Text = "Currently saved markers: " & MainForm.userDetails.allTimeMarkers.Count
    End Sub

    Private Sub UserDelete_Click(sender As Object, e As EventArgs) Handles UserDelete.Click
        UserChange(True)
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        MainForm.Hide()
        UserChange(False)
        LoginUser.Show()
    End Sub

    Private Sub UserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainForm.userDetails IsNot Nothing Then
            If File.Exists(Path.Combine(MyJsonParser.applicationPath, "users", "images", MainForm.userDetails.username & ".png")) Then
                LoadImage(Path.Combine(MyJsonParser.applicationPath, "users", "images", MainForm.userDetails.username & ".png"))
            End If
        End If
        Username.Text = "Welcome, " & MainForm.userDetails.username
        Fitness.Text = "Fitness: " & MainForm.userDetails.fitness.ToString & "%"
        Markers.Text = "Currently saved markers: " & MainForm.userDetails.allTimeMarkers.Count
        Tooltip()
        If _EXP_ProgramTerminator.blackListedPrograms.Count > 0 Then
            For Each program As String In _EXP_ProgramTerminator.blackListedPrograms
                Dim label As New Label
                With label
                    .Name = "labelFile" & program
                    .Text = program
                    .ForeColor = Color.White
                    .Font = New Font("Microsoft Sans Serif", 9)
                End With
                AddHandler label.Click, AddressOf LabelClick
                Programs.Controls.Add(label)
            Next
        End If
    End Sub

    Public Sub SaveImage(stream As Stream, toPath As String)
        If Not Directory.Exists(toPath) Then
            Directory.CreateDirectory(toPath)
        End If
        Using btm As Bitmap = New Bitmap(stream)
            picture = Nothing
            Photo.BackgroundImage = Nothing
            Threading.Thread.Sleep(30)
            btm.Save(Path.Combine(toPath, MainForm.userDetails.username & ".png"))
        End Using
    End Sub

    Public Sub LoadImage(thispath As String)
        If File.Exists(thispath) Then
            Dim pic As Image = Image.FromFile(thispath)
            picture = New Bitmap(pic)
            Photo.BackgroundImage = picture
            pic.Dispose()
            RaiseEvent PhotoChanged()
        End If
    End Sub

    Private Sub UserChange(fullClearMode As Boolean)
        Dim blackListedPrograms As List(Of String) = _EXP_ProgramTerminator.blackListedPrograms
        Dim markerList As New List(Of TimeMarkerItemCLB)
        For Each control As TimeMarkerItemCLB In MainForm.CustomListBox1.ActualList.Controls
            markerList.Add(control)
        Next
        If Not fullClearMode Then
            Dim simplifedMarker As New List(Of MyJsonParser.User.Marker)
            For i = MainForm.CustomListBox1.ActualList.Controls.Count - 1 To 0 Step -1
                Dim control As TimeMarkerItemCLB = MainForm.CustomListBox1.ActualList.Controls(i)
                Dim newMarker As New MyJsonParser.User.Marker
                With newMarker
                    .Title = control.Title
                    .Description = control.Description
                    .DateStart = control.FullDate
                    .DateEnd = control.FullDateEnd
                    .Points = control.Points
                    .Priority = control.Priority
                    .AccomplishedPoints = control.AccomplishedPoints
                End With
                simplifedMarker.Add(newMarker)
            Next
            If blackListedPrograms IsNot Nothing Then
                MainForm.userDetails.blacklistedPrograms = blackListedPrograms
            End If
            If simplifedMarker IsNot Nothing Then
                MainForm.userDetails.allTimeMarkers = simplifedMarker
            End If
            Dim jsonString As String = MyJsonParser.WriteToJson(MainForm.userDetails)
        Else
            If File.Exists(Path.Combine(MyJsonParser.applicationPath, "users", MainForm.userDetails.username & "file.json")) Then
                File.Delete(Path.Combine(MyJsonParser.applicationPath, "users", MainForm.userDetails.username & "file.json"))
                MainForm.Hide()
                Me.Hide()
                LoginUser.Show()
            End If
        End If
        _EXP_ProgramTerminator.blackListedPrograms.Clear()
        MainForm.CustomListBox1.Clear(markerList)
        Me.Hide()
    End Sub

    Private Sub LabelClick(sender As Object, e As EventArgs)
        If currentlySelectedProgram IsNot Nothing Then
            currentlySelectedProgram.BackColor = Color.FromArgb(89, 89, 89)
        End If
        currentlySelectedProgram = sender
        sender.backColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub Tooltip()
        Dim tooltip As New ToolTip
        tooltip.SetToolTip(Fitness, "Fitness is a value that represents how much of a good job you are doing at achieving your goals. The higher the fitness, the better!")
    End Sub
End Class