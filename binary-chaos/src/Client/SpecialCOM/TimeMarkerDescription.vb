Imports System.Drawing.Drawing2D
Public Class TimeMarkerDescription
    Public Event PushInformation(information As Dictionary(Of String, Object), sendTo As TimeMarkerItemCLB, doesOverride As Boolean)

    Public marker As TimeMarkerItemCLB

#Region "My properties"
    Dim _editorMode As CustomListBox.EditorMode = CustomListBox.EditorMode.FIXED
    Dim _backColor As Color
    Dim _informationToPoint As New Dictionary(Of Panel, Point)
#End Region

#Region "Internal 'inherited' properties"
    Dim _title As String
    Dim _description As String
    Dim _fullDate As Date
    Dim _priority As CustomListBox.Priority
    Public _showMore As Boolean = False
    Dim _pointNumber As Integer
    Dim _points As List(Of String)
    Dim _accomplishedPoints As List(Of String)
    Dim _renderProgress As Boolean
    Dim _progress As Double

#Region "Getters and setters"
    Public Property EditorMode As CustomListBox.EditorMode
        Get
            Return _editorMode
        End Get
        Set(value As CustomListBox.EditorMode)
            _editorMode = value
        End Set
    End Property
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property FullDate As Date
        Get
            Return _fullDate
        End Get
        Set(value As Date)
            _fullDate = value
        End Set
    End Property

    Public Property Priority As CustomListBox.Priority
        Get
            Return _priority
        End Get
        Set(value As CustomListBox.Priority)
            _priority = value
        End Set
    End Property

    Public Property PointNumber As Integer
        Get
            Return _pointNumber
        End Get
        Set(value As Integer)
            _pointNumber = value
        End Set
    End Property

    Public Property Points As List(Of String)
        Get
            Return _points
        End Get
        Set(value As List(Of String))
            _points = value
        End Set
    End Property
    Public Property AccomplishedPoints As List(Of String)
        Get
            Return _accomplishedPoints
        End Get
        Set(value As List(Of String))
            _accomplishedPoints = value
        End Set
    End Property
    Public Property RenderProgress As Boolean
        Get
            Return _renderProgress
        End Get
        Set(value As Boolean)
            _renderProgress = value
        End Set
    End Property
    Public Property Progress As Double
        Get
            Return _progress
        End Get
        Set(value As Double)
            _progress = value
        End Set
    End Property
#End Region
#End Region

#Region "Events"
    Public Sub HandleInformationUpdate()
        HandleTitlePanel()
        HandleDescriptionPanel()
        HandleDetailsPanel()
        HandlePointsPanel()
    End Sub

    Private Sub HandleShowMore(sender As Object, e As MouseEventArgs) Handles Label7.MouseClick
        _showMore = True
        Label7.Visible = False
        Label7.Enabled = False
    End Sub

    Private Sub CheckBoxClick(sender As CheckBox, e As EventArgs)
        If sender.Checked Then
            AccomplishedPoints.Add(sender.Text)
        End If
    End Sub
#End Region

#Region "Rendering"
    Private Sub HandleTitlePanel()
        Dim initialDifference As Integer = TitlePanel.Height - (Txt_Title.Location.Y + Txt_Title.Height)
        If Priority = 2 Then
            Dim decrement As Integer = (Panel1.Width - Txt_Title.Location.X) + 3
            With Txt_Title
                .Location = New Point(.Location.X - decrement, .Location.Y)
                .Width = .Width - decrement
            End With
        End If
        Txt_Title.Text = Title
        FitInformationInTextbox(Txt_Title.Text, Txt_Title)
        AppendPanelToPanel(Nothing, TitlePanel)
        TitlePanel.Height = Txt_Title.Height + Txt_Title.Location.Y + initialDifference
    End Sub

    Private Sub HandleDescriptionPanel()
        Dim initialDifference As Integer = DescriptionPanel.Height - (Txt_Description.Location.Y + Txt_Description.Height)
        Txt_Description.Text = Description
        FitInformationInTextbox(Txt_Description.Text, Txt_Description)
        AppendPanelToPanel(TitlePanel, DescriptionPanel)
        DescriptionPanel.Height = Txt_Description.Height + Txt_Description.Location.Y + initialDifference
    End Sub

    Private Sub HandleDetailsPanel()
        Label4.Text = "Starting time: " & FullDate.ToString
        Label5.Text = "Ending time: " & FullDate.ToString
        Dim prir As String
        Select Case Priority
            Case CustomListBox.Priority.HIGH
                prir = "High"
            Case CustomListBox.Priority.HIGH
                prir = "Medium"
            Case CustomListBox.Priority.HIGH
                prir = "Low"
            Case Else
                prir = "Not defined"
        End Select
        Label6.Text = "Priority: " & prir
        AppendPanelToPanel(DescriptionPanel, DetailsPanel)
    End Sub

    Private Sub HandlePointsPanel()
        Dim increment As Integer = Label7.Height - (CheckBox1.Location.X + CheckBox1.Height)
        If PointNumber < 5 Then
            Label7.Visible = False
            Label7.Enabled = False
        End If
        Dim pos As Point = CheckBox1.Location
        Dim size As Size = CheckBox1.Size
        CheckBox1.Dispose()
        If _showMore Then
            For i = 0 To Points.Count - 1
                Dim item As String = Points(i)
                Dim newPos As New Point(pos.X, pos.Y + (i * (increment + size.Height)))
                CreateCheckBox("ItemCheckBox" & i, item, pos, size)
            Next
        Else
            For i = 0 To 4
                Dim item As String = Points(i)
                Dim newPos As New Point(pos.X, pos.Y + (i * (increment + Size.Height)))
                CreateCheckBox("ItemCheckBox" & i, item, pos, Size)
            Next
        End If
    End Sub

    Private Sub CreateCheckBox(name As String, title As String, pos As Point, size As Size)
        Dim checkBox As New CheckBox
        With checkBox
            .Name = name
            .Text = title
            .Location = pos
            .Size = size
        End With
        AddHandler checkBox.MouseClick, AddressOf CheckBoxClick
    End Sub

    Private Sub AppendPanelToPanel(panelFrom As Panel, panelTo As Panel)
        Dim location As Point
        Dim tempLocation As Point
        If Not IsNothing(panelFrom) Then
            location = New Point(panelFrom.Location.X, panelFrom.Location.Y + panelFrom.Height)
        Else
            tempLocation = New Point(0, 0)
            location = New Point(tempLocation.X, tempLocation.Y)
        End If
        panelTo.Location = location
        _informationToPoint.Add(panelTo, location)
    End Sub

    Private Sub FitInformationInTextbox(str As String, box As TextBox)
        With box
            Dim g As Graphics = CreateGraphics()
            Dim size As SizeF = g.MeasureString(str, .Font, .ClientSize.Width)
            .Height = Int(size.Height)
        End With
    End Sub

    Private Sub PaintTitle(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint
        Dim graphics As Graphics = e.Graphics
        Dim path As New GraphicsPath
        Dim pointsProgress As PointF() = {
            New Point(0, 0),
            New Point(Width * Progress, 0)
            }
        Dim pointsFree As PointF() = {
            New Point(Width * Progress, 0),
            New Point(Width, 0)
            }
        graphics.DrawLine(New Pen(Color.FromArgb(0, 112, 192), 5), pointsProgress(0), pointsProgress(1))
        graphics.DrawLine(New Pen(Color.FromArgb(89, 89, 89), 5), pointsFree(0), pointsFree(1))
    End Sub
#End Region
End Class