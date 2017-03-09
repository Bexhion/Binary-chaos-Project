Imports System.Drawing.Drawing2D
Public Class FullDate

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

    Delegate Sub RenderOverlay(graphics As Graphics)

    Dim path As GraphicsPath

    Dim _fullDate As Date
    Public Property FullDate() As Date
        Get
            Return _fullDate
        End Get
        Set(value As Date)
            _fullDate = value
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
    Dim _overlayMethod As RenderOverlay
    Property OverlayMethod() As RenderOverlay
        Get
            Return _overlayMethod
        End Get
        Set(value As RenderOverlay)
            _overlayMethod = value
            Refresh()
        End Set
    End Property
    Dim useConstantOverLay As Boolean = False
    Public Property ConstantOverlay() As Boolean
        Get
            Return useConstantOverLay
        End Get
        Set(value As Boolean)
            useConstantOverLay = value
            Refresh()
        End Set
    End Property
    Dim shouldUseOverlay As Boolean = False
    Public Property UseOverlay() As Boolean
        Get
            Return shouldUseOverlay
        End Get
        Set(value As Boolean)
            shouldUseOverlay = value
            Refresh()
        End Set
    End Property
    Dim shouldRenderOutline As Boolean = True
    Public Property DoRenderOutline As Boolean
        Get
            Return shouldRenderOutline
        End Get
        Set(value As Boolean)
            shouldRenderOutline = value
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
    'Const
    Const space As Integer = 5

    Sub New()
        InitializeComponent()
        BackgroundColor = Color.FromArgb(38, 38, 38)
        GetPath()
    End Sub

#Region "Mouse Events"
    Private Sub MouseEnterHanlder(sender As Object, e As EventArgs) Handles Me.MouseEnter
        shouldUseOverlay = True
        Refresh()
    End Sub

    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles Me.MouseLeave
        shouldUseOverlay = False
        Refresh()
    End Sub
#End Region

#Region "Rendering"
#Region "Information"
    Private Function GetMonth(monthNumber As Integer) As String
        If monthNumber < 1 Or monthNumber > 12 Then
            Return 0
        End If
        Return [Enum].GetNames(GetType(Months)).GetValue(monthNumber - 1)
    End Function

    Private Sub DrawInformation(graphics As Graphics)
        Dim brush As SolidBrush = New SolidBrush(Color.FromArgb(0, 112, 192))
        Dim size As SizeF
        Dim font As Font
        Dim layoutRect As RectangleF
        Dim str As String
        Dim point As Point

        'Month
        str = GetMonth(FullDate.Month)
        font = New Font("Microsoft Sans Serif", 10)
        size = graphics.MeasureString(str, font)
        point.X = (Me.Width - size.Width) / 2
        point.Y = Me.Height - (space + size.Height)
        layoutRect = New RectangleF(point, size)
        graphics.DrawString(str, font, brush, layoutRect)

        'Day
        str = FullDate.Day
        font = New Font("Microsoft Sans Serif", 25)
        size = graphics.MeasureString(str, font)
        point.X = (Me.Width - size.Width) / 2
        point.Y = Me.Height - (size.Height + layoutRect.Height)
        layoutRect = New RectangleF(point, size)
        graphics.DrawString(str, font, brush, layoutRect)
    End Sub
#End Region

    Public Sub GetPath()
        Dim path As New GraphicsPath
        path.StartFigure()
        path.AddLine(0, 0, Width - 1, 0)
        path.AddLine(Width - 1, 0, Width - 1, Height - 1)
        path.AddLine(Width - 1, Height - 1, 0, Height - 1)
        path.AddLine(0, Height - 1, 0, 0)
        path.CloseFigure()
        Me.path = path
    End Sub

    Private Sub RenderOutline(graphics As Graphics, color As Color)
        graphics.DrawPath(New Pen(color), Me.path)
    End Sub

    Private Sub PaintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphics As Graphics = e.Graphics
        DrawInformation(graphics)
        If (UseOverlay Or ConstantOverlay) And Not IsNothing(OverlayMethod) Then
            OverlayMethod.Invoke(graphics)
        End If
        If DoRenderOutline Then
            RenderOutline(graphics, OutlineColor)
        End If
        graphics.Dispose()
    End Sub
#End Region
End Class