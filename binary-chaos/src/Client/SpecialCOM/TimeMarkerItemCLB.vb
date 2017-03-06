Imports System.Drawing.Drawing2D
Public Class TimeMarkerItemCLB

#Region "Properties"
    Public Event SelectionChanged(sender As TimeMarkerItemCLB)
    Public Event MarkerSetForDeletion(sender As TimeMarkerItemCLB)
    Public Event TimeMarkerEnd(sender As TimeMarkerItemCLB)

    Public WithEvents timeMarker As TimeMarker

    Public _title As String = "This is a title!"
    Public _description As String = "And this is a description used to describe the title!"
    Public _points As List(Of String)
    Public _pointNumber As Integer
    Public accomplishedPointsNumber As Integer = 0
    Public _accomplishedPoints As List(Of String)
    Public _priority As CustomListBox.Priority
    Dim priorityBrush As SolidBrush
    Public _thisDate As Date
    Public _mode As CustomListBox.EditorMode = CustomListBox.EditorMode.FIXED
    Public _progress As Double
    Public _renderProgress As Boolean = False
    Public _selectedForDeletion As Boolean = False

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
            _pointNumber = 1
            Points1.SetPointNumber(_pointNumber)
            Refresh()
        End Set
    End Property

    Public Property FullDate() As Date
        Get
            Return _thisDate
        End Get
        Set(value As Date)
            _thisDate = value
            Refresh()
        End Set
    End Property

    Public Property Priority() As CustomListBox.Priority
        Get
            Return _priority
        End Get
        Set(value As CustomListBox.Priority)
            _priority = value
            priorityBrush = GetPriorityBrush(value)
            Refresh()
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
            accomplishedPointsNumber = value.Count
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
#End Region

#End Region
    Public Sub New()
        InitializeComponent()
        GetPath()
        BackgroundColor = Color.FromArgb(38, 38, 38)
        DoRenderOutline = True
        OutlineColor = Color.FromArgb(90, 90, 90)
        Points1.DoRenderOutline = True
        Points1.OutlineColor = Color.FromArgb(90, 90, 90)
        FullDate1.DoRenderOutline = True
        FullDate1.OutlineColor = Color.FromArgb(90, 90, 90)
        totalProgress = (Me.Width - 5) - (Points1.Width + Points1.Location.X)
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
        If Not SelectMe Then
            SelectMe = True
            FullDate1.BackgroundColor = Color.FromArgb(63, 63, 63)
            Points1.BackgroundColor = Color.FromArgb(63, 63, 63)
            BackgroundColor = Color.FromArgb(63, 63, 63)
        End If
        RaiseEvent SelectionChanged(Me)
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
        RaiseEvent TimeMarkerEnd(Me)
    End Sub
#End Region
#Region "Renderers"
    Private Sub RenderForDeletionMode(graphics As Graphics)
        Dim rectangle As New Rectangle(FullDate1.Location, FullDate1.Size)
        Dim brush As New SolidBrush(Color.FromArgb(75, 192, 63, 63))
        graphics.FillRectangle(brush, rectangle)
    End Sub
#End Region
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
            RenderOutline(graphics, _outlineColor)
        End If
        If ShowProgress Then
            RenderProgress(graphics)
        End If
    End Sub

    Public Sub GetPath()
        Dim path As New GraphicsPath
        path.StartFigure()
        path.AddLine(0, 0, Me.Width - 1, 0)
        path.AddLine(Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)
        path.AddLine(Me.Width - 1, Me.Height - 1, 0, Me.Height - 1)
        path.AddLine(0, Me.Height - 1, 0, 0)
        path.CloseFigure()
        Me.path = path
    End Sub

    Dim totalProgress As Integer
    Private Sub RenderProgress(graphics As Graphics)
        Dim path As New GraphicsPath
        Dim pointsProgress As PointF() = {
            New Point(Points1.Width + Points1.Location.X, 0),
            New Point(totalProgress * Progress, 0)
            }
        Dim pointsFree As PointF() = {
            New Point(totalProgress * Progress, 0),
            New Point(totalProgress, 0)
            }
        graphics.DrawLine(New Pen(Color.FromArgb(89, 89, 89), 2), pointsProgress(0), pointsProgress(1))
        graphics.DrawLine(New Pen(Color.FromArgb(0, 112, 192), 2), pointsFree(0), pointsFree(1))
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