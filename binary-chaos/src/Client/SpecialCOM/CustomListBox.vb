Public Class CustomListBox

    Public Event UpdateDescriptorInformation()
    Public Event EditorModeChanged(mode As CustomListBox.EditorMode)
    Public Event SelectionChange(sender As TimeMarkerItemCLB)
    Public Event ItemClick(sender As CustomListBox, subObject As TimeMarkerItemCLB)
    'Internal
    Public Event CheckForScrollbar()

    Dim hasScrollBar As Boolean = False
    Dim internalMode As EditorMode = EditorMode.FIXED

    Public Enum Priority
        HIGH
        MEDIUM
        LOW
    End Enum

    Public Enum EditorMode
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
        AddHandler Me.UpdateDescriptorInformation, AddressOf descriptor.HandleInformationUpdate
    End Sub

    Public Sub Add(timeMarker As TimeMarker, title As String, description As String, points As List(Of String), priority As Priority)
        Dim marker As New TimeMarkerItemCLB
        With marker
            .Name = Guid.NewGuid().ToString("N")
            .Title = title
            .Description = description
            .FullDate = timeMarker.startingDate
            .Points = points
            .Priority = priority
            .timeMarker = timeMarker
            .EditorMode = internalMode
        End With

        AddHandler marker.Click, AddressOf ItemClicked
        AddHandler marker.SelectionChanged, AddressOf SetActiveControl
        AddHandler marker.MarkerSetForDeletion, AddressOf OnSetForDeletion
        AddHandler marker.TimeMarkerEnd, AddressOf OnTimeMarkerEnd
        AddHandler marker.PushInformation, AddressOf PushInformationToDescriptor

        ActualList.Controls.Add(marker)
        RaiseEvent CheckForScrollbar()
        SetupAnchors()
        Refresh()
    End Sub

    Public Sub Remove(index As Integer)
        Dim control As TimeMarkerItemCLB = ActualList.Controls(index)
        If IsNothing(control) Then Exit Sub
        Remove(control.Name)
    End Sub

    Public Sub Remove(name As String)
        Dim marker As TimeMarkerItemCLB = ActualList.Controls(name)
        If IsNothing(marker) Then
            Beep()
            Exit Sub
        End If
        ActualList.Controls.Remove(marker)
        Console.Beep()
        RemoveHandler marker.Click, AddressOf ItemClicked
        RemoveHandler marker.SelectionChanged, AddressOf SetActiveControl
        RemoveHandler marker.MarkerSetForDeletion, AddressOf OnSetForDeletion
        RemoveHandler marker.TimeMarkerEnd, AddressOf OnTimeMarkerEnd
        RemoveHandler marker.PushInformation, AddressOf PushInformationToDescriptor

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
                control.GetPath()
                control.FullDate1.GetPath()
                control.Points1.GetPath()
                control.Label_Title.Width = (Width - control.Label_Title.Location.X) + (Width - 15)
                control.Label_Desc.Width = (Width - control.Label_Desc.Location.X) + (Width - 15)
            Next
        End If
    End Sub

    Public Sub Clear(list As List(Of TimeMarkerItemCLB))
        If list.Count > 0 Then
            For Each item As TimeMarkerItemCLB In list
                If ActualList.Controls.Contains(item) Then
                    Remove(item.Name)
                End If
            Next
            For Each item As TimeMarkerItemCLB In list
                MsgBox("Item object: " & item.ToString & "; Item Date: " & item.FullDate.ToString)
            Next
            list.Clear()
        End If
        Refresh()
    End Sub

    Public Sub ChangeEditorMode(mode As CustomListBox.EditorMode)
        internalMode = mode
        RaiseEvent EditorModeChanged(mode)
    End Sub

#Region "Events"

#Region "TimeMarkerItem"
#End Region
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
        If Not IsNothing(currentActiveControl) And marker IsNot currentActiveControl Then
            If currentActiveControl.ShowProgress Then
                currentActiveControl._updateTimer.Start()
            End If
            currentActiveControl.SelectMe = False
            currentActiveControl.FullDate1.BackgroundColor = Color.FromArgb(38, 38, 38)
            currentActiveControl.Points1.BackgroundColor = Color.FromArgb(38, 38, 38)
            currentActiveControl.BackgroundColor = Color.FromArgb(38, 38, 38)
        End If
        If currentActiveControl IsNot marker Then
            currentActiveControl = marker
        End If
        marker.PushMarker(marker)
    End Sub

    Private Sub ChangeMode(newMode As EditorMode) Handles Me.EditorModeChanged
        If ActualList.Controls.Count > 0 Then
            For i = 0 To ActualList.Controls.Count - 1
                Dim control As TimeMarkerItemCLB = ActualList.Controls(i)
                control.EditorMode = newMode
            Next
        End If
        descriptor.EditorMode = newMode
    End Sub

    Private Sub ItemClicked(sender As Object, e As EventArgs)
        RaiseEvent ItemClick(Me, ActualList.Controls(ActualList.Controls.IndexOfKey(sender.name)))
    End Sub

    Private Sub OnTimeMarkerEnd(sender As TimeMarkerItemCLB)
        Remove(sender.Name)
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
        descriptor.marker = information
        descriptor._showMore = False
        descriptor.Title = information.Title
        descriptor.Description = information.Description
        descriptor.FullDate = information.FullDate
        descriptor.Priority = descriptor.Priority
        descriptor.Points = information.Points
        descriptor.AccomplishedPoints = information.AccomplishedPoints
        descriptor.PointNumber = information.Points.Count
        descriptor.RenderProgress = information.ShowProgress
        descriptor.Progress = information.Progress
        RaiseEvent UpdateDescriptorInformation()
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