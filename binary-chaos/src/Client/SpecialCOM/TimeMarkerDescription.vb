Imports System.Drawing.Drawing2D
Public Class TimeMarkerDescription

#Region "Properties"
    'Public Event StartTimer()

    Public timeMarker As TimeMarkerItemCLB

    Private Declare Function HideCaret Lib “user32" (ByVal wHandle As Int32) As Int32

    Public textToPoint As New Dictionary(Of Panel, Point)
    Public Sub AddTextSection(id As Panel, point As Point)
        If textToPoint.ContainsKey(id) Or textToPoint.ContainsValue(point) Then Exit Sub
        textToPoint.Add(id, point)
    End Sub

    'Dim _title As String
    'Public Property Title() As String
    '    Get
    '        Return _title
    '    End Get
    '    Set(value As String)
    '        _title = value
    '        Refresh()
    '    End Set
    'End Property
    'Dim _description As String
    'Public Property Description() As String
    '    Get
    '        Return _description
    '    End Get
    '    Set(value As String)
    '        _description = value
    '        Refresh()
    '    End Set
    'End Property
    'Dim _date As Date
    'Public Property MyDate() As Date
    '    Get
    '        Return _date
    '    End Get
    '    Set(value As Date)
    '        _date = value
    '        Refresh()
    '    End Set
    'End Property
    'Dim _priority As CustomListBox.Priority
    'Public Property Priority() As CustomListBox.Priority
    '    Get
    '        Return _priority
    '    End Get
    '    Set(value As CustomListBox.Priority)
    '        _priority = value
    '        If value = CustomListBox.Priority.HIGH Then
    '            ForceStart = True
    '        End If
    '        Refresh()
    '    End Set
    'End Property
    'Dim _pointNumber As Integer = 0
    'Dim accomplishedPointsNumber As Integer = 0
    'Dim _accomplishedPoints As List(Of CheckBox)
    'Dim pointsAsCheckBox As List(Of CheckBox)
    'Dim _points As List(Of String)
    'Public Property Points() As List(Of String)
    '    Get
    '        Return _points
    '    End Get
    '    Set(value As List(Of String))
    '        _points = value
    '        ConstructCheckBoxList(_points, pointsAsCheckBox)
    '        _pointNumber = 0
    '        Refresh()
    '    End Set
    'End Property
    'Public Property AccomplishedPoints() As List(Of CheckBox)
    '    Get
    '        Return _accomplishedPoints
    '    End Get
    '    Set(value As List(Of CheckBox))
    '        _accomplishedPoints = value
    '        accomplishedPointsNumber = value.Count
    '    End Set
    'End Property
    'Dim _forceStart As Boolean = False
    'Public Property ForceStart() As Boolean
    '    Get
    '        Return _forceStart
    '    End Get
    '    Set(value As Boolean)
    '        _forceStart = value
    '        Refresh()
    '    End Set
    'End Property
    'Dim _progress As Double
    'Public Property ProgressStatus() As Double
    '    Get
    '        Return _progress
    '    End Get
    '    Set(value As Double)
    '        _progress = value
    '        Refresh()
    '    End Set
    'End Property

    ''Internal
    'Dim displayProgress As Boolean
    'Public Property ShouldDisplayProgress As Boolean
    '    Get
    '        Return displayProgress
    '    End Get
    '    Set(value As Boolean)
    '        displayProgress = value
    '        Refresh()
    '    End Set
    'End Property
#End Region

    Public Sub New()
        InitializeComponent()
        AddTextSection(TitlePanel, New Point(0, 0))
        AddTextSection(DescriptionPanel, New Point(0, TitlePanel.Height))
        AddTextSection(DetailsPanel, New Point(0, TitlePanel.Height + DescriptionPanel.Height))
        AddTextSection(PointsPanel, New Point(0, TitlePanel.Height + DescriptionPanel.Height + DetailsPanel.Height))
        AddTextSection(ProgressPanel, New Point(0, TitlePanel.Height + DescriptionPanel.Height + DetailsPanel.Height + PointsPanel.Height))
    End Sub

    Private Sub ConstructCheckBoxList(listFrom As List(Of String), listTo As List(Of CheckBox))
        Dim panelInUse As Panel = PointsPanel
        Dim pos As Point = CheckBox1.Location
        Dim size As Size = CheckBox1.Size
        Dim space As Integer = 2
        CheckBox1.Dispose()
        For i = 0 To listFrom.Count - 1
            Dim item As String = listFrom(i)
            Dim newPos As Point = pos
            newPos.Y = i * (size.Height + space) + pos.X
            Dim checkBox As CheckBox = CreateCheckBox("ItemCheckBox" & i, item, newPos, size)
            listTo.Add(checkBox)
            AddHandler checkBox.CheckedChanged, AddressOf CheckBoxMarked
        Next
    End Sub

    Private Function CreateCheckBox(id As String, text As String, pos As Point, size As Size) As CheckBox
        Dim checkBox As New CheckBox()
        checkBox.Name = id
        checkBox.Text = text
        checkBox.Location = pos
        checkBox.Size = size
        Return checkBox
    End Function

    Private Sub RenderPanelTitle(panel As Panel)
        Dim newTitle As String = timeMarker.Title
    End Sub

    Private Sub RenderPanelDescription(panel As Panel)
        Dim newDesc As String = timeMarker.Description
        Dim lastPoint As Integer = (Txt_Description.Height + Txt_Description.Location.Y)
        Dim distance As Integer = panel.Height - lastPoint
        With Txt_Description
            Dim g As Graphics = CreateGraphics()
            Dim size As SizeF = g.MeasureString(.Text, .Font, .ClientSize.Width)
            .Height = Int(size.Height)
        End With
        Dim panelSize = New Size(panel.Width, lastPoint + distance + Txt_Description.Height)
    End Sub

    Private Sub RenderPanelDetails(panel As Panel)

    End Sub

    Private Sub RenderPanelPoints(panel As Panel)

    End Sub

    Public Overrides Sub Refresh()
        MyBase.Refresh()
        ProgressPanel.Visible = timeMarker.ShowProgress
    End Sub

#Region "Event"

    Private Sub ClickPanel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        'RaiseEvent StartTimer()
    End Sub

    Private Sub HoverPanel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseHover
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(Panel1, "Force start this maker")
    End Sub

    Private Sub CheckBoxMarked(sender As CheckBox, e As EventArgs)
        Dim accomplishedPoints As List(Of String) = timeMarker.AccomplishedPoints
        If sender.Checked Then
            If accomplishedPoints.Contains(sender.Name) Then Exit Sub
            accomplishedPoints.Add(sender.Name)
        Else
            If Not accomplishedPoints.Contains(sender.Name) Then Exit Sub
            accomplishedPoints.Remove(sender.Name)
        End If
    End Sub
#End Region

#Region "Rendering"
    Private Sub RenderStartButton(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim graphics As Graphics = e.Graphics

    End Sub

    Private Sub DrawTriangle(graphics As Graphics)

    End Sub

    Private Sub PaintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphics As Graphics = e.Graphics
        If ShouldDisplayProgress Then
            RenderProgress(graphics)
        End If
        graphics.Dispose()
    End Sub

    Private Sub RenderProgress(graphics As Graphics)
        Dim lineStart As New Point(0, 0)
        Dim progress As Single = Width * ProgressStatus
        Dim lineEnd As New Point(progress, 0)
        graphics.DrawLine(New Pen(Color.FromArgb(0, 122, 192), 2), lineStart, lineEnd)
        lineStart = lineEnd
        lineEnd = New Point(Width, 0)
        graphics.DrawLine(New Pen(Color.FromArgb(38, 38, 38), 2), lineStart, lineEnd)
    End Sub
#End Region
End Class