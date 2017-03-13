Public Class CustomListBox

    Public Event UpdateDescriptorInformation()
    Public Event EditorModeChanged(mode As CustomListBox.EditorMode)
    Public Event SelectionChange(sender As TimeMarkerItemCLB)
    Public Event ItemClick(sender As CustomListBox, subObject As TimeMarkerItemCLB)
    'Internal
    Public Event CheckForScrollbar()

    Dim hasScrollBar As Boolean = False
    Dim internalMode As EditorMode

    Public Enum Priority
        NONE
        HIGH
        MEDIUM
        LOW
    End Enum

    Public Enum EditorMode
        NONE
        FIXED
        ADD
        EDIT
        REMOVE
    End Enum

    Public Enum Months
        JAN
        FEB
        MAR
        APR
        MAY
        JUN
        JUL
        AUG
        SEP
        OCT
        NOV
        DEC
    End Enum

    Public Property CurrentEditorMode() As EditorMode
        Get
            Return internalMode
        End Get
        Set(value As EditorMode)
            internalMode = value
        End Set
    End Property

    Public listToDelete As New List(Of TimeMarkerItemCLB)

    Public WithEvents descriptor As TimeMarkerDescription
    Public currentActiveControl As TimeMarkerItemCLB

    Public Sub New()
        InitializeComponent()
        BackColor = Color.FromArgb(38, 38, 38)
    End Sub

    'Call this before anything else
    Public Sub SetDescriptor(descriptor As TimeMarkerDescription)
        Me.descriptor = descriptor
        AddHandler UpdateDescriptorInformation, AddressOf descriptor.HandleInformationUpdate
        AddHandler descriptor.PushInformation, AddressOf RegisterInformationToMarker
    End Sub

    Public Function Add(startDate As DateTime, endDate As DateTime, title As String, description As String, points As List(Of String), priority As Priority) As TimeMarkerItemCLB
        Dim marker As New TimeMarkerItemCLB
        With marker
            .Name = Guid.NewGuid().ToString("N")
            .Title = title
            .Description = description
            .timeMarker = New TimeMarker(startDate, endDate)
            .FullDate = startDate
            .FullDateEnd = endDate
            .Points = points
            .AccomplishedPoints = New List(Of String)
            .Priority = priority
            .EditorMode = internalMode
        End With

        AddHandler marker.Click, AddressOf ItemClicked
        AddHandler marker.SelectionChanged, AddressOf SetActiveControl
        AddHandler marker.MarkerSetForDeletion, AddressOf OnSetForDeletion
        AddHandler marker.TimeMarkerEnd, AddressOf OnTimeMarkerEnd
        AddHandler marker.PushInformation, AddressOf PushInformationToDescriptor
        AddHandler marker.PushProgress, AddressOf TimeUpdate

        ActualList.Controls.Add(marker)
        RaiseEvent CheckForScrollbar()
        SetupAnchors()
        Refresh()
        Return marker
    End Function

    Public Sub Remove(index As Integer)
        Dim control As TimeMarkerItemCLB = ActualList.Controls(index)
        If IsNothing(control) Then Exit Sub
        Remove(control.Name)
    End Sub

    Public Sub Remove(name As String)
        Dim marker As TimeMarkerItemCLB = ActualList.Controls(name)
        If IsNothing(marker) Then
            Exit Sub
        End If
        ActualList.Controls.Remove(marker)
        RemoveHandler marker.Click, AddressOf ItemClicked
        RemoveHandler marker.SelectionChanged, AddressOf SetActiveControl
        RemoveHandler marker.MarkerSetForDeletion, AddressOf OnSetForDeletion
        RemoveHandler marker.TimeMarkerEnd, AddressOf OnTimeMarkerEnd
        RemoveHandler marker.PushInformation, AddressOf PushInformationToDescriptor
        RemoveHandler marker.PushProgress, AddressOf TimeUpdate

        marker.Dispose()
        SetupAnchors()
        Refresh()
    End Sub

    Private Sub SetupAnchors()
        If ActualList.Controls.Count > 0 Then
            For i = 0 To ActualList.Controls.Count - 1
                Dim control As TimeMarkerItemCLB = ActualList.Controls(i)
                If i = 0 Then
                    control.Anchor = AnchorStyles.Left + AnchorStyles.Top
                Else
                    control.Anchor = AnchorStyles.Left + AnchorStyles.Right
                End If
                If hasScrollBar Then
                    control.Width = ActualList.Width - SystemInformation.VerticalScrollBarWidth
                Else
                    control.Width = ActualList.Width
                End If
                control.GetContourPath()
                control.FullDate1.GetPath()
                control.Points1.GetPath()
                control.Label_Title.Width = (Width - control.Label_Title.Location.X) - 15
                control.Label_Desc.Width = (Width - control.Label_Desc.Location.X) - 15
                control.totalProgress = Width - 5 - control.Points1.Right
                control.startingPoint = New Point(control.Points1.Right, 0)
                control.endingPoint = New Point(Width - 5, 0)
            Next
        End If
    End Sub

    Public Sub Clear(list As List(Of TimeMarkerItemCLB))
        If list.Count > 0 Then
            For i = list.Count - 1 To 0 Step -1
                Dim item As TimeMarkerItemCLB = list(i)
                If ActualList.Controls.Contains(item) Then
                    Remove(item.Name)
                End If
            Next
            list.Clear()
        End If
        Refresh()
    End Sub

    Public Sub ChangeEditorMode(mode As CustomListBox.EditorMode)
        If Not mode = EditorMode.NONE Then
            RaiseEvent EditorModeChanged(mode)
        End If
    End Sub

#Region "Events"

    Public Sub CheckAll(checkDate As Date)
        For i = ActualList.Controls.Count - 1 To 0 Step -1
            Dim timeMarker As TimeMarkerItemCLB = ActualList.Controls(i)
            Dim thisDate As Date = timeMarker.FullDate.Value
            If Not IsNothing(thisDate) Then
                If thisDate.Day = checkDate.Day And thisDate.Month = checkDate.Month And thisDate.Year = checkDate.Year And thisDate.Hour = checkDate.Hour And thisDate.Minute = checkDate.Minute Then
                    timeMarker.timeMarker.StartTimeMarker()
                End If
            End If
        Next
    End Sub

    Private Sub TimeUpdate(marker As TimeMarkerItemCLB, progress As Double)
        If marker Is descriptor.ThisTimeMarker Then
            descriptor.Progress = progress
        End If
    End Sub

    Private Sub ResizeMe(sender As Object, e As EventArgs) Handles Me.Resize
        If ActualList.Controls.Count Then
            For i = 0 To ActualList.Controls.Count - 1
                If hasScrollBar Then
                    ActualList.Controls(i).Width = ActualList.Width - SystemInformation.VerticalScrollBarWidth
                Else
                    ActualList.Controls(i).Width = ActualList.Width
                End If
            Next
        End If
    End Sub

    Public Sub SetActiveControl(marker As TimeMarkerItemCLB)
        Select Case internalMode
            Case EditorMode.FIXED, EditorMode.REMOVE
                If marker IsNot Nothing Then
                    If Not marker.SelectMe Then
                        marker.SelectMe = True
                        marker.FullDate1.BackgroundColor = Color.FromArgb(63, 63, 63)
                        marker.Points1.BackgroundColor = Color.FromArgb(63, 63, 63)
                        marker.BackgroundColor = Color.FromArgb(63, 63, 63)
                    End If
                    If Not IsNothing(currentActiveControl) And currentActiveControl IsNot marker Then
                        currentActiveControl.SelectMe = False
                        currentActiveControl.FullDate1.BackgroundColor = Color.FromArgb(38, 38, 38)
                        currentActiveControl.Points1.BackgroundColor = Color.FromArgb(38, 38, 38)
                        currentActiveControl.BackgroundColor = Color.FromArgb(38, 38, 38)
                    End If
                    If marker IsNot currentActiveControl Then
                        currentActiveControl = marker
                    End If
                End If
                currentActiveControl.PushMarker()
            Case EditorMode.ADD
                If currentActiveControl IsNot Nothing Then
                    currentActiveControl.SelectMe = False
                    currentActiveControl.FullDate1.BackgroundColor = Color.FromArgb(38, 38, 38)
                    currentActiveControl.Points1.BackgroundColor = Color.FromArgb(38, 38, 38)
                    currentActiveControl.BackgroundColor = Color.FromArgb(38, 38, 38)
                    currentActiveControl = Nothing
                End If
            Case EditorMode.EDIT
                currentActiveControl.PushMarker()
        End Select
        If currentActiveControl Is Nothing And Not internalMode = 2 Then
            descriptor.hiddingPanel.Visible = True
            descriptor.hiddingPanel.BringToFront()
        End If
    End Sub

    Private Sub ChangeMode(newMode As EditorMode) Handles Me.EditorModeChanged
        If newMode = EditorMode.NONE Then Exit Sub
        If ActualList.Controls.Count > 0 Then
            For i = 0 To ActualList.Controls.Count - 1
                Dim control As TimeMarkerItemCLB = ActualList.Controls(i)
                control.EditorMode = newMode
            Next
        End If
        CurrentEditorMode = newMode
        If currentActiveControl IsNot Nothing Then
            SetActiveControl(Nothing)
        End If
        descriptor.EditorMode = newMode
    End Sub

    Private Sub ItemClicked(sender As Object, e As EventArgs)
        RaiseEvent ItemClick(Me, ActualList.Controls(ActualList.Controls.IndexOfKey(sender.name)))
    End Sub

    Private Sub OnTimeMarkerEnd(sender As TimeMarkerItemCLB)
        Remove(sender.Name)
        descriptor.ThisTimeMarker = Nothing
        descriptor.Title = Nothing
        descriptor.Description = Nothing
        descriptor.FullDateStart = Nothing
        descriptor.FullDateEnd = Nothing
        descriptor.Priority = Nothing
        descriptor.Points = Nothing
        descriptor.AccomplishedPoints = Nothing
        descriptor.hiddingPanel.Visible = True
        descriptor.hiddingPanel.BringToFront()
    End Sub

    Private Sub OnSetForDeletion(sender As TimeMarkerItemCLB)
        If ActualList.Controls.Contains(sender) Then
            If listToDelete.Contains(sender) Then
                sender.SelectedForDeletion = False
                listToDelete.Remove(sender)
            Else
                sender.SelectedForDeletion = True
                listToDelete.Add(sender)
            End If
        End If
    End Sub

    Private Sub CheckScrollbarEnabled() Handles Me.CheckForScrollbar
        Dim totalSize As Integer = 0
        For i = 0 To ActualList.Controls.Count - 1
            Dim control As TimeMarkerItemCLB = ActualList.Controls(i)
            totalSize += control.Height
        Next
        If totalSize > Height Then
            hasScrollBar = True
        Else
            hasScrollBar = False
        End If
    End Sub

    Private Sub PushInformationToDescriptor(information As TimeMarkerItemCLB)
        descriptor.ThisTimeMarker = information
        RaiseEvent UpdateDescriptorInformation()
    End Sub

    Public Sub RegisterInformationToMarker(doesOverride As Boolean, descriptor As TimeMarkerDescription)
        Dim startTime As DateTime = descriptor.FullDateStart
        Dim endTime As DateTime = descriptor.FullDateEnd
        If Not doesOverride Then
            Dim control As TimeMarkerItemCLB = Add(startTime, endTime, descriptor.Title, descriptor.Description, descriptor.Points, descriptor.Priority)
            control.AccomplishedPoints = descriptor.AccomplishedPoints
            control.SelectMarker()
        Else
            If currentActiveControl IsNot Nothing Then
                currentActiveControl.timeMarker.SetTime(startTime, endTime)
                currentActiveControl.Title = descriptor.Title
                currentActiveControl.Description = descriptor.Description
                currentActiveControl.Points = descriptor.Points
                currentActiveControl.AccomplishedPoints = descriptor.AccomplishedPoints
                currentActiveControl.FullDate = startTime.Date
            End If
        End If
    End Sub
#End Region

#Region "Rendering"
    Private Sub PaintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If ActualList.Controls.Count = 0 Then
            Dim graphics As Graphics = e.Graphics
            Dim font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
            Dim myColor As SolidBrush = New SolidBrush(Color.FromArgb(191, 191, 191))
            RenderString(graphics, "You have no markers present", font, myColor, True)
            font = New Font("Microsoft Sans Serif", 12)
            myColor.Color = Color.FromArgb(127, 127, 127)
            RenderString(graphics, "Add markers by pressing the ADD button", font, myColor, False)
        End If
    End Sub

    Private Sub RenderString(graphics As Graphics, str As String, font As Font, brush As SolidBrush, upMiddle As Boolean)
        Dim size As SizeF = graphics.MeasureString(str, font)
        Dim point As Point
        Dim x As Integer = (Me.Width - size.Width) / 2
        Dim y As Integer
        If upMiddle Then
            y = (Me.Height - size.Height - 1) / 2
        Else
            y = (Me.Height + size.Height + 1) / 2
        End If
        point = New Point(x, y)
        Dim layoutRectangle As New RectangleF(point, size)
        graphics.DrawString(str, font, brush, layoutRectangle)
    End Sub
#End Region
End Class