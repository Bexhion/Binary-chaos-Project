Imports System.Drawing.Drawing2D
Public Class Points

    Dim path As GraphicsPath
#Region "Properties"
    Public pointNumber As Integer = 0
    Public Property PointCount() As Integer
        Get
            Return pointNumber
        End Get
        Set(value As Integer)
            pointNumber = value
            Refresh()
        End Set
    End Property
    Dim _backColor As Color = Color.FromArgb(38, 38, 38)
    Public Property BackgroundColor() As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            Me.BackColor = value
            Refresh()
        End Set
    End Property
    Dim _renderOutline As Boolean = True
    Public Property DoRenderOutline() As Boolean
        Get
            Return _renderOutline
        End Get
        Set(value As Boolean)
            _renderOutline = value
            Refresh()
        End Set
    End Property
    Dim _outlineColor As Color = Color.FromArgb(90, 90, 90)
    Public Property OutlineColor() As Color
        Get
            Return _outlineColor
        End Get
        Set(value As Color)
            _outlineColor = value
            Refresh()
        End Set
    End Property

    'Consts
    Const pointRepresentationNumber As Integer = 10
    Const spaceBetween As Integer = 2
    Const rate As Double = 0.6
#End Region

    Public Sub New()
        InitializeComponent()
        Height = 70
        Width = 12
        BackgroundColor = Color.FromArgb(38, 38, 38)
        GetPath()
        AddHandler Me.MouseHover, AddressOf CreateToolTip
    End Sub

    Public Sub SetPointNumber(number As Integer)
        pointNumber = number
    End Sub

    Private Sub CreateToolTip()
        Dim tooltip As New ToolTip()
        If pointNumber >= 0 Then
            If pointNumber = 1 Then
                tooltip.SetToolTip(Me, pointNumber & " goal to accomplish")
            Else
                tooltip.SetToolTip(Me, pointNumber & " goals to accomplish")
            End If
        End If
    End Sub

    Private Function GetMaxNumberOfSquares(squareHeight As Integer) As Integer
        Dim myHeight As Integer = Me.Height
        Dim exactPoints As Integer = pointNumber \ pointRepresentationNumber
        If Not pointNumber Mod pointRepresentationNumber = 0 Then
            exactPoints += 1
        End If
        Dim maxPoints As Integer = Int((myHeight - spaceBetween) / (squareHeight + spaceBetween))
        If maxPoints > exactPoints Then
            Return exactPoints
        Else
            Return maxPoints
        End If
    End Function

    Private Sub PaintRepresentationSquares(graphics As Graphics)
        Dim square As Rectangle = GetRepresentationSquares()
        Dim brush As SolidBrush = ItemCLBColors.SpecialAdditions
        Dim maxPoints As Integer = GetMaxNumberOfSquares(square.Height)
        Dim point As Point = New Point()
        point.X = (Me.Width - square.Width) / 2

        For i As Integer = 1 To maxPoints
            point.Y = Me.Height - (i * (spaceBetween + square.Height))
            square.Location = point
            graphics.FillRectangle(brush, square)
        Next
    End Sub

    Private Function GetRepresentationSquares() As Rectangle
        Dim width = Me.Width * rate
        Return New Rectangle(0, 0, width, width)
    End Function

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

    Private Sub RenderOutline(graphics As Graphics, color As Color)
        graphics.DrawPath(New Pen(color), path)
    End Sub

    Private Sub PaintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphics As Graphics = e.Graphics
        If DoRenderOutline Then
            RenderOutline(graphics, _outlineColor)
        End If
        PaintRepresentationSquares(graphics)
    End Sub
End Class
