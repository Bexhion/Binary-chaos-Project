Imports System.Drawing.Drawing2D
Public Class TimeMarkerItemCLB

#Region "Properties"
    Public Event SelectionChanged(sender As TimeMarkerItemCLB)
    Public Event MarkerSetForDeletion(sender As TimeMarkerItemCLB)
    Public Event TimeMarkerEnd(sender As TimeMarkerItemCLB)
    Public Event PushInformation(information As TimeMarkerItemCLB)

    Public WithEvents timeMarker As TimeMarker

    Dim _title As String = ""
    Dim _description As String = ""
    Dim _points As List(Of String)
    Dim accomplishedPointsNumber As Integer = 0
    Dim _accomplishedPoints As List(Of String)
    Dim _priority As CustomListBox.Priority = Nothing
    Dim priorityBrush As SolidBrush
    Dim _timespan As Integer = 0
    Dim _thisDate As DateTime? = Nothing
    Dim _endDate As DateTime? = Nothing
    Dim _mode As CustomListBox.EditorMode = Nothing
    Dim _progress As Double = 0
    Dim _renderProgress As Boolean = False
    Dim _selectedForDeletion As Boolean = False
    Public WithEvents _updateTimer As New Timer With {.Interval = 1000}

    Dim _backColor As Color = Color.FromArgb(38, 38, 38)
    Dim _renderOutline As Boolean = True
    Dim _outlineColor As Color = Color.FromArgb(90, 90, 90)

    Dim path As GraphicsPath
    Dim _selected As Boolean = False

#Region "Setters and Getters"
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            Label_Title.Text = value
            Refresh()
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
            Label_Desc.Text = value
            Refresh()
        End Set
    End Property

    Public Property Points() As List(Of String)
        Get
            Return _points
        End Get
        Set(value As List(Of String))
            _points = value
            If _points IsNot Nothing Then
                Points1.SetPointNumber(_points.Count)
                Refresh()
            End If
        End Set
    End Property

    Public Property FullDate() As DateTime?
        Get
            Return _thisDate
        End Get
        Set(value As DateTime?)
            _thisDate = value
            FullDate1.FullDate = _thisDate
            RecalculateTimeMarker()
            Refresh()
        End Set
    End Property

    Public Property FullDateEnd() As DateTime?
        Get
            Return _endDate
        End Get
        Set(value As DateTime?)
            _endDate = value
            If FullDate IsNot Nothing Then
                Dim span As TimeSpan = _endDate.Value.Subtract(FullDate)
                _timespan = span.TotalMinutes
            End If
            RecalculateTimeMarker()
        End Set
    End Property

    Public Property Priority() As CustomListBox.Priority
        Get
            Return _priority
        End Get
        Set(value As CustomListBox.Priority)
            If Not value = CustomListBox.Priority.NONE Then
                _priority = value
                priorityBrush = GetPriorityBrush(value)
                Refresh()
            End If
        End Set
    End Property

    Public Property Progress() As Double
        Get
            Return _progress
        End Get
        Set(value As Double)
            _progress = value
            Refresh()
        End Set
    End Property

    Public Property ShowProgress() As Boolean
        Get
            Return _renderProgress
        End Get
        Set(value As Boolean)
            _renderProgress = value
            Refresh()
        End Set
    End Property

    Public Property EditorMode() As CustomListBox.EditorMode
        Get
            Return _mode
        End Get
        Set(value As CustomListBox.EditorMode)
            _mode = value
            Select Case _mode
                Case CustomListBox.EditorMode.REMOVE
                    FullDate1.OverlayMethod = AddressOf RenderForDeletionMode
                Case Else
                    FullDate1.OverlayMethod = Nothing
            End Select
        End Set
    End Property

    Public Property OutlineColor() As Color
        Get
            Return _outlineColor
        End Get
        Set(value As Color)
            _outlineColor = value
            Refresh()
        End Set
    End Property

    Public Property DoRenderOutline() As Boolean
        Get
            Return _renderOutline
        End Get
        Set(value As Boolean)
            _renderOutline = value
        End Set
    End Property

    Public Property BackgroundColor() As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            BackColor = value
            Refresh()
        End Set
    End Property

    Public Property SelectMe() As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
            Refresh()
        End Set
    End Property

    Public Property SelectedForDeletion() As Boolean
        Get
            Return _selectedForDeletion
        End Get
        Set(value As Boolean)
            _selectedForDeletion = value
            FullDate1.ConstantOverlay = value
            Refresh()
        End Set
    End Property

    Public Property AccomplishedPoints() As List(Of String)
        Get
            Return _accomplishedPoints
        End Get
        Set(value As List(Of String))
            _accomplishedPoints = value
            If _accomplishedPoints IsNot Nothing Then
                accomplishedPointsNumber = value.Count
            Else
                accomplishedPointsNumber = 0
            End If
        End Set
    End Property

    Public Property UpdateTimerRate() As Integer
        Get
            Return _updateTimer.Interval
        End Get
        Set(value As Integer)
            _updateTimer.Interval = value
        End Set
    End Property

    Private Function GetPriorityBrush(priority As CustomListBox.Priority) As SolidBrush
        Dim brush As SolidBrush
        Select Case priority
            Case CustomListBox.Priority.HIGH
                brush = New SolidBrush(Color.FromArgb(142, 0, 0))
            Case CustomListBox.Priority.MEDIUM
                brush = New SolidBrush(Color.FromArgb(196, 94, 18))
            Case CustomListBox.Priority.LOW
                brush = New SolidBrush(Color.FromArgb(60, 92, 38))
            Case Else
                brush = New SolidBrush(Color.Black)
        End Select
        Return brush
    End Function

    Public Sub RecalculateTimeMarker()
        If FullDate IsNot Nothing And FullDateEnd IsNot Nothing Then
            timeMarker.SetTime(FullDate, FullDateEnd)
        End If
    End Sub
#End Region

#End Region
    Public Sub New()
        InitializeComponent()
        BackgroundColor = Color.FromArgb(38, 38, 38)
        DoRenderOutline = True
        OutlineColor = Color.FromArgb(90, 90, 90)
        Points1.DoRenderOutline = True
        Points1.OutlineColor = Color.FromArgb(90, 90, 90)
        FullDate1.DoRenderOutline = True
        FullDate1.OutlineColor = Color.FromArgb(90, 90, 90)
        totalProgress = (Me.Width - 5) - (Points1.Width + Points1.Location.X)
        GetContourPath()
        startingPoint = New Point(Points1.Right, 0)
        endingPoint = New Point(totalProgress, 0)
    End Sub

#Region "Events"
#Region "Mouse Hover Me"
    Private Sub MouseEnterEvent(sender As Object, e As EventArgs) Handles Me.MouseEnter, Label_Title.MouseEnter, Label_Desc.MouseEnter, Points1.MouseEnter
        Label_Title.ForeColor = Color.White
        Label_Desc.ForeColor = Color.White
        Refresh()
    End Sub

    Private Sub MouseLeaveEvent(sender As Object, e As EventArgs) Handles Me.MouseLeave, Label_Title.MouseLeave, Label_Desc.MouseLeave, Points1.MouseLeave
        Label_Title.ForeColor = Color.White
        Label_Desc.ForeColor = Color.FromArgb(166, 166, 166)
        Refresh()
    End Sub
#End Region
#Region "Click"
    Private Sub MouseClickEvent(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, Label_Title.MouseClick, Label_Desc.MouseClick, Points1.MouseClick
        SelectMarker()
    End Sub

    Public Sub SelectMarker()
        RaiseEvent SelectionChanged(Me)
        PushMarker()
    End Sub
#End Region
#Region "Date"

    Private Sub EnterChildren(sender As Object, e As EventArgs) Handles FullDate1.MouseHover
        If Not EditorMode = CustomListBox.EditorMode.REMOVE Then
            MouseEnterEvent(sender, e)
        End If
    End Sub

    Private Sub LeaveChildren(sender As Object, e As EventArgs) Handles FullDate1.MouseLeave
        If Not EditorMode = CustomListBox.EditorMode.REMOVE Then
            MouseLeaveEvent(sender, e)
        End If
    End Sub

    Private Sub DateClickEvent(sender As Object, e As MouseEventArgs) Handles FullDate1.MouseClick
        If EditorMode = CustomListBox.EditorMode.REMOVE Then
            RaiseEvent MarkerSetForDeletion(Me)
        Else
            MouseClickEvent(sender, e)
        End If
    End Sub
#End Region
#Region "Timer"
    Private Sub TimeMarkerStart(marker As TimeMarker) Handles timeMarker.TimerStart
        ShowProgress = True
    End Sub

    Private Sub TimeMarkerFinished(marker As TimeMarker) Handles timeMarker.TimerEnd
        ShowProgress = False
        TimeMarkerEndHandler()
    End Sub

    Public Sub TimeMarkerEndHandler()
        RaiseEvent TimeMarkerEnd(Me)
    End Sub

    Private Sub TimeMarkerTickHandler(sender As Object, e As EventArgs) Handles _updateTimer.Tick
        PushMarker()
    End Sub
#End Region
#Region "Renderers"
    Private Sub RenderForDeletionMode(graphics As Graphics)
        Dim rectangle As New Rectangle(FullDate1.Location, FullDate1.Size)
        Dim brush As New SolidBrush(Color.FromArgb(75, 192, 63, 63))
        graphics.FillRectangle(brush, rectangle)
    End Sub
#End Region
    Public Sub PushMarker()
        RaiseEvent PushInformation(Me)
    End Sub
#End Region

    Public Overrides Sub Refresh()
        MyBase.Refresh()
        Points1.Refresh()
        FullDate1.Refresh()
    End Sub

#Region "Rendering"
    Private Sub PaintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphics As Graphics = e.Graphics
        RenderPriority(graphics)
        If DoRenderOutline Then
            RenderOutline(graphics, OutlineColor)
        End If
        If ShowProgress Then
            RenderProgress(graphics)
        End If
        graphics.Dispose()
    End Sub

    Public Sub GetContourPath()
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddLine(0, 0, Me.Width - 1, 0)
        path.AddLine(Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)
        path.AddLine(Me.Width - 1, Me.Height - 1, 0, Me.Height - 1)
        path.AddLine(0, Me.Height - 1, 0, 0)
        path.CloseFigure()
        Me.path = path
    End Sub

    Dim totalProgress As Integer
    Dim startingPoint As Point
    Dim endingPoint As Point
    Private Sub RenderProgress(graphics As Graphics)
        Dim path As New GraphicsPath
        Dim prog As New Point(totalProgress * Progress, 0)
        graphics.DrawLine(New Pen(Color.FromArgb(89, 89, 89), 4), startingPoint, prog)
        graphics.DrawLine(New Pen(Color.FromArgb(0, 112, 192), 4), prog, endingPoint)
    End Sub

    Private Sub RenderOutline(graphics As Graphics, color As Color)
        graphics.DrawPath(New Pen(color), path)
    End Sub

    Dim priorect As Rectangle
    Private Sub RenderPriority(graphics As Graphics)
        priorect = New Rectangle(Width - 5, 0, 5, Height)
        graphics.FillRectangle(priorityBrush, priorect)
    End Sub
#End Region
End Class