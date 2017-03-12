Imports System.Drawing.Drawing2D
Public Class TimeMarkerDescription
#Region "Properties"
    Dim panelColection As New Dictionary(Of Panel, List(Of Control))
    Dim markedForUpdate As New List(Of Panel)
    Dim initialDropDown As New Dictionary(Of Panel, Integer)
    Dim deletePointsColection As New List(Of CheckBox)
    Dim todelete As New List(Of CheckBox)

    Public Event UpdatePanels()
    Public Event UpdateEditorMode(mode As CustomListBox.EditorMode)
    Public Event PushInformation(doesOverride As Boolean, description As TimeMarkerDescription)

    Public Sub PushMyInformation()
        Dim missingInformation As String = ""
        If Title IsNot Nothing Then
            If Description IsNot Nothing Then
                If FullDateStart IsNot Nothing Then
                    If FullDateEnd IsNot Nothing Then
                        If Not IsNothing(Priority) Then
                            Select Case EditorMode
                                Case CustomListBox.EditorMode.ADD
                                    RaiseEvent PushInformation(False, Me)
                                Case Else
                                    If ThisTimeMarker IsNot Nothing Then
                                        RaiseEvent PushInformation(True, Me)
                                    End If
                            End Select
                        Else
                            missingInformation = "priority"
                        End If
                    Else
                        missingInformation = "finish date"
                    End If
                Else
                    missingInformation = "starting date"
                End If
            Else
                missingInformation = "description"
            End If
        Else
            missingInformation = "title"
        End If
        If missingInformation IsNot "" Then
            MsgBox("Unable to create a new marker. Please introduce a valid " & missingInformation)
        End If
    End Sub

    Dim hasScrollBar As Boolean = False
    Dim _editorMode As CustomListBox.EditorMode
    Dim _pointProgress As Boolean
    Dim deletePoints As Boolean = False

    Dim _timerMarker As TimeMarkerItemCLB
    Dim _title As String = ""
    Dim _description As String = ""
    Dim _fullDateStart As DateTime? = Nothing
    Dim _fullDateEnd As DateTime? = Nothing
    Dim _priority As CustomListBox.Priority = CustomListBox.Priority.NONE
    Dim _points As List(Of String)
    Dim _accomplishedPoints As List(Of String) = Nothing
    Dim _pointsNumber As Integer = 0
    Dim _accomplishedPointsNumber As Integer = 0
    Dim _progress As Double
    Dim _renderInformation As Boolean = False

#Region "Paint render"
    Dim diff As Integer = 10
    Dim bColor As SolidBrush = New SolidBrush(Color.FromArgb(48, 48, 48))
    Dim fColorNormal As SolidBrush = New SolidBrush(Color.FromArgb(0, 112, 192))
    Dim fColorStart As SolidBrush = New SolidBrush(Color.FromArgb(0, 112, 192))
    Dim startPoint As Point
    Dim widthB As Integer
    Dim endPoint As Point
    Dim yPos As Integer
    Dim triangularPath As GraphicsPath
#End Region
#Region "Information Income"
    Public Sub HandleInformationUpdate()
        Title = ThisTimeMarker.Title
        Description = ThisTimeMarker.Description
        FullDateStart = ThisTimeMarker.FullDate
        Dim filler As DateTime = ThisTimeMarker.FullDate
        FullDateEnd = filler.AddMinutes(ThisTimeMarker.timeMarker.totalTime)
        Priority = ThisTimeMarker.Priority
        Points = Nothing
        Points = ThisTimeMarker.Points
        AccomplishedPoints = Nothing
        AccomplishedPoints = ThisTimeMarker.AccomplishedPoints
        Progress = ThisTimeMarker.Progress
        Select Case Priority
            Case CustomListBox.Priority.HIGH
                If EditorMode = 1 Then
                    PanelStart.Visible = True
                    PanelStart.Enabled = True
                End If
            Case Else
                PanelStart.Visible = False
                PanelStart.Enabled = False
        End Select
    End Sub
#End Region

#Region "Getters and setters"
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            If value = "" Then
                _title = "ADD A TITLE"
                TxtboxTitle.ForeColor = Color.FromArgb(100, 100, 100)
            Else
                _title = value
                TxtboxTitle.ForeColor = Color.FromArgb(240, 240, 240)
            End If
            TxtboxTitle.Text = _title
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            If value = "" Then
                _description = "Add a description"
                TxtboxDesc.ForeColor = Color.FromArgb(130, 130, 130)
            Else
                _description = value
                TxtboxDesc.ForeColor = Color.FromArgb(240, 240, 240)
            End If
            TxtboxDesc.Text = _description
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property FullDateStart() As DateTime?
        Get
            Return _fullDateStart
        End Get
        Set(value As DateTime?)
            _fullDateStart = value
            SetDetailsStartDate(value)
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property FullDateEnd() As DateTime?
        Get
            Return _fullDateEnd
        End Get
        Set(value As DateTime?)
            _fullDateEnd = value
            SetDetailsEndDate(value)
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property Priority() As CustomListBox.Priority
        Get
            Return _priority
        End Get
        Set(value As CustomListBox.Priority)
            _priority = value
            SetDetailsPriority(value)
            RaiseEvent UpdatePanels()
            PanelDetails.Refresh()
        End Set
    End Property

    Public Property Points() As List(Of String)
        Get
            Return _points
        End Get
        Set(value As List(Of String))
            If value IsNot Nothing Then
                If _points IsNot Nothing Then
                    _points.AddRange(value)
                Else
                    _points = New List(Of String)(value)
                End If
            Else
                _points = Nothing
            End If
            ClearCheckBoxes()
            Dim list As New List(Of Control)
            list.Add(LabelPoints)
            list.Add(ButtonAddPoint)
            list.Add(ButtonRemovePoint)
            If _points IsNot Nothing Then
                For i = 0 To _points.Count - 1
                    Dim entry As String = _points(i)
                    Dim checkBox As CheckBox = CreateCheckBox(entry, (20 * i) + 30)
                    list.Add(checkBox)
                Next
                PointsNumber = _points.Count
            End If
            panelColection(PanelPoints) = list
            markedForUpdate.Add(PanelPoints)
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Private Sub ClearCheckBoxes()
        PanelPoints.Hide()
        For index = PanelPoints.Controls.Count - 1 To 0 Step -1
            Dim control As Control = PanelPoints.Controls(index)
            If TypeOf control Is CheckBox Then
                PanelPoints.Controls.Remove(control)
                RemoveHandler CType(control, CheckBox).MouseClick, AddressOf CheckBoxClicked
                control.Dispose()
            End If
        Next
        PanelPoints.Show()
    End Sub

    Public Property AccomplishedPoints() As List(Of String)
        Get
            Return _accomplishedPoints
        End Get
        Set(value As List(Of String))
            If value IsNot Nothing Then
                _accomplishedPoints = value
            Else
                _accomplishedPoints = Nothing
            End If
            If value IsNot Nothing Then
                For Each c As Control In PanelPoints.Controls
                    If TypeOf c Is CheckBox Then
                        Dim check As CheckBox = CType(c, CheckBox)
                        If value.Contains(check.Text) Then
                            CType(c, CheckBox).Checked = True
                        End If
                    End If
                Next
                AccomplishedPointsNumber = _accomplishedPoints.Count
            Else
                AccomplishedPointsNumber = 0
            End If
        End Set
    End Property

    Public Property PointsNumber() As Integer
        Get
            Return _pointsNumber
        End Get
        Set(value As Integer)
            _pointsNumber = value
            If _pointsNumber = 0 Then
                RenderPointsProgress = False
            Else
                RenderPointsProgress = True
            End If
            PanelPoints.Refresh()
        End Set
    End Property

    Public Property AccomplishedPointsNumber() As Integer
        Get
            Return _accomplishedPointsNumber
        End Get
        Set(value As Integer)
            _accomplishedPointsNumber = value
            PanelPoints.Refresh()
        End Set
    End Property

    Public Property Progress() As Double
        Get
            Return _progress
        End Get
        Set(value As Double)
            _progress = value
            PanelTitle.Refresh()
        End Set
    End Property

    Public Property EditorMode() As CustomListBox.EditorMode
        Get
            Return _editorMode
        End Get
        Set(value As CustomListBox.EditorMode)
            If Not value = CustomListBox.EditorMode.NONE Then
                _editorMode = value
            End If
            RaiseEvent UpdateEditorMode(value)
        End Set
    End Property

    Public Property RenderPointsProgress() As Boolean
        Get
            Return _pointProgress
        End Get
        Set(value As Boolean)
            Select Case EditorMode
                Case CustomListBox.EditorMode.FIXED, CustomListBox.EditorMode.REMOVE
                    _pointProgress = value
                Case Else
                    _pointProgress = False
            End Select
            PanelPoints.Refresh()
        End Set
    End Property

    Public Property ThisTimeMarker() As TimeMarkerItemCLB
        Get
            Return _timerMarker
        End Get
        Set(value As TimeMarkerItemCLB)
            If value IsNot Nothing Then
                _timerMarker = value
            End If
        End Set
    End Property
#End Region
#End Region
    Public Sub New()
        InitializeComponent()
        yPos = LabelPoints.Height / 2
        widthB = PanelPoints.Width - diff - 187
        startPoint = New Point(187, yPos)
        endPoint = New Point(PanelPoints.Width - diff, yPos)
        endPointTime = New Point(PanelTitle.Width, 1)
        triangularPath = GetTrianglePath(30)
        AddHandler TxtboxTitle.ContentsResized, AddressOf ResizeRichTextBox
        AddHandler TxtboxDesc.ContentsResized, AddressOf ResizeRichTextBox
        PopulateInitialDropDown()
        SetControls()
        CreatePanelStartTooltip()

    End Sub

#Region "Events"
    Private Sub CreatePanelStartTooltip()
        Dim tooltip As New ToolTip
        tooltip.SetToolTip(PanelStart, "Start this marker")
    End Sub

    Private Sub UpdatePanelSequence() Handles Me.UpdatePanels
        Dim lastPanel As Panel = Nothing
        For Each panel As Panel In markedForUpdate
            If panel IsNot Nothing Then
                panel.Height = GetMaxControlHeight(panel)
                DockPanelToPanel(panel, lastPanel)
            End If
        Next
        markedForUpdate.Clear()
    End Sub

    Private Sub EditorChanged(mode As CustomListBox.EditorMode) Handles Me.UpdateEditorMode
        Select Case mode
            Case CustomListBox.EditorMode.ADD

                ThisTimeMarker = Nothing
                RenderPointsProgress = False

                TxtboxTitle.ReadOnly = False
                TxtboxDesc.ReadOnly = False
                Title = ""
                Description = ""

                FullDateStart = Nothing
                FullDateEnd = Nothing
                Priority = Nothing

                Points = Nothing
                ClearCheckBoxes()
                AccomplishedPoints = New List(Of String)

                SetButtonVisibility(ButtonStartDate, True)
                AppendButtonToControl(ButtonStartDate, LabelStartDate)

                SetButtonVisibility(ButtonEndDate, True)
                AppendButtonToControl(ButtonEndDate, LabelEndDate)

                SetButtonVisibility(ButtonPriority, True)
                AppendButtonToControl(ButtonPriority, LabelPriority)

                SetButtonVisibility(ButtonRemovePoint, True)
                SetButtonVisibility(ButtonAddPoint, True)

                PanelStart.Visible = False
                PanelStart.Enabled = False
                'Manual way for reasons
                PanelPoints.Height = GetMaxControlHeight(PanelPoints)

            Case CustomListBox.EditorMode.EDIT

                RenderPointsProgress = False
                TxtboxTitle.ReadOnly = False
                TxtboxDesc.ReadOnly = False

                SetButtonVisibility(ButtonStartDate, True)
                AppendButtonToControl(ButtonStartDate, LabelStartDate)

                SetButtonVisibility(ButtonEndDate, True)
                AppendButtonToControl(ButtonEndDate, LabelEndDate)

                SetButtonVisibility(ButtonPriority, True)
                AppendButtonToControl(ButtonPriority, LabelPriority)

                SetButtonVisibility(ButtonRemovePoint, True)
                SetButtonVisibility(ButtonAddPoint, True)

                PanelStart.Visible = False
                PanelStart.Enabled = False

            Case CustomListBox.EditorMode.REMOVE
                RenderPointsProgress = False
                TxtboxTitle.ReadOnly = True
                TxtboxDesc.ReadOnly = True

                SetButtonVisibility(ButtonStartDate, False)
                SetButtonVisibility(ButtonEndDate, False)
                SetButtonVisibility(ButtonPriority, False)
                SetButtonVisibility(ButtonRemovePoint, False)
                SetButtonVisibility(ButtonAddPoint, False)

                PanelStart.Visible = False
                PanelStart.Enabled = False

            Case CustomListBox.EditorMode.FIXED
                RenderPointsProgress = True
                TxtboxTitle.ReadOnly = True
                TxtboxDesc.ReadOnly = True

                SetButtonVisibility(ButtonStartDate, False)
                SetButtonVisibility(ButtonEndDate, False)
                SetButtonVisibility(ButtonPriority, False)
                SetButtonVisibility(ButtonRemovePoint, False)
                SetButtonVisibility(ButtonAddPoint, False)

                PanelStart.Visible = True
                PanelStart.Enabled = True

            Case CustomListBox.EditorMode.NONE
                RenderPointsProgress = False
                TxtboxTitle.ReadOnly = True
                TxtboxDesc.ReadOnly = True
                SetButtonVisibility(ButtonStartDate, False)
                SetButtonVisibility(ButtonEndDate, False)
                SetButtonVisibility(ButtonPriority, False)
                SetButtonVisibility(ButtonRemovePoint, False)
                SetButtonVisibility(ButtonAddPoint, False)
                PanelStart.Visible = False
                PanelStart.Enabled = False
        End Select
    End Sub

    Private Sub StartButtonClick(sender As Object, e As MouseEventArgs) Handles PanelStart.MouseClick
        fColorStart.Color = Color.FromArgb(45, 45, 45)
        If ThisTimeMarker IsNot Nothing Then
            ThisTimeMarker.timeMarker.StartTimeMarker()
        End If
    End Sub

#Region "Rich text boxes"

    Private Sub TextBoxesGotFocus(sender As RichTextBox, e As EventArgs) Handles TxtboxTitle.GotFocus, TxtboxDesc.GotFocus
        Select Case EditorMode
            Case CustomListBox.EditorMode.ADD, CustomListBox.EditorMode.EDIT
                If Not sender.ForeColor = Color.FromArgb(240, 240, 240) And (sender.Text = "ADD A TITLE" Or sender.Text = "Add a description") Then
                    sender.ForeColor = Color.FromArgb(240, 240, 240)
                    sender.Text = ""
                End If
            Case Else
        End Select
    End Sub

    Private Sub TextBoxesLostFocus(sender As RichTextBox, e As EventArgs) Handles TxtboxTitle.LostFocus, TxtboxDesc.LostFocus
        Select Case EditorMode
            Case CustomListBox.EditorMode.ADD, CustomListBox.EditorMode.EDIT
                If (sender.ForeColor = Color.FromArgb(240, 240, 240) And (sender.Text = "ADD A TITLE" Or sender.Text = "Add a description" Or sender.Text = "")) Then
                    If sender.Name = TxtboxTitle.Name Then
                        sender.ForeColor = Color.FromArgb(100, 100, 100)
                        sender.Text = "ADD A TITLE"
                    Else
                        sender.ForeColor = Color.FromArgb(130, 130, 130)
                        sender.Text = "Add a description"
                    End If
                Else
                    If sender.Name = TxtboxTitle.Name Then
                        Title = TxtboxTitle.Text
                    Else
                        Description = TxtboxDesc.Text
                    End If
                End If
            Case Else
        End Select
    End Sub
#End Region

#Region "Button setters"
    Private Sub ButtonStartDate_Click(sender As Object, e As EventArgs) Handles ButtonStartDate.Click
        Dim inputBox As New DateChoser(Me, New Point(Left, Bottom))
        If FullDateStart IsNot Nothing Then
            inputBox.initialDate = FullDateStart
        End If
        If inputBox.ShowDialog() = DialogResult.OK Then
            FullDateStart = inputBox.ResultDate
        End If
    End Sub

    Private Sub ButtonEndDate_Click(sender As Object, e As EventArgs) Handles ButtonEndDate.Click
        Dim inputBox As New DateChoser(Me, New Point(Left, Bottom))
        If FullDateEnd IsNot Nothing Then
            inputBox.initialDate = FullDateEnd
        End If
        If inputBox.ShowDialog = DialogResult.OK Then
            FullDateEnd = inputBox.ResultDate
        End If
    End Sub

    Private Sub ButtonPriority_Click(sender As Object, e As EventArgs) Handles ButtonPriority.Click
        Dim inputBox As New PriorityPicker(Me, New Point(Left, Bottom))
        If inputBox.ShowDialog = DialogResult.OK Then
            Priority = inputBox.Priority
        End If
    End Sub

    Private Sub ButtonAddPoint_Click(sender As Object, e As EventArgs) Handles ButtonAddPoint.Click
        Dim inputBox As New FakeInputBox(Me, New Point(Left, Bottom))
        If inputBox.ShowDialog = DialogResult.OK Then
            Dim list As List(Of String)
            'why won't '.add' do this?
            list = New List(Of String)
            If Points IsNot Nothing Then
                If Points.Contains(inputBox.Text) Then
                    MsgBox("A checkbox with this name already exists in this marker. Please choose another name")
                Else
                    list.Add(inputBox.Text)
                    Points = list
                End If
            Else
                list.Add(inputBox.Text)
                Points = list
            End If
        End If
    End Sub

    Private Sub ButtonRemovePoint_Click(sender As Object, e As EventArgs) Handles ButtonRemovePoint.Click
        deletePoints = Not deletePoints
        If deletePoints Then
            ButtonRemovePoint.BackColor = Color.FromArgb(128, 255, 255, 255)
        Else
            ButtonRemovePoint.BackColor = Color.Transparent
        End If
        If Not deletePoints Then
            If Points IsNot Nothing Then
                Dim pnts As List(Of String) = Points
                Dim list As List(Of String) = AccomplishedPoints
                For i = PanelPoints.Controls.Count - 1 To 0 Step -1
                    If TypeOf PanelPoints.Controls(i) Is CheckBox Then
                        Dim checkBox As CheckBox = CType(PanelPoints.Controls(i), CheckBox)
                        If deletePointsColection.Contains(checkBox) Then
                            PanelPoints.Controls.Remove(checkBox)
                            RemoveHandler checkBox.MouseClick, AddressOf CheckBoxClicked
                            checkBox.Dispose()
                            If Points.Contains(checkBox.Text) Then
                                pnts.Remove(checkBox.Text)
                            End If
                            If list IsNot Nothing Then
                                If AccomplishedPoints.Contains(checkBox.Text) Then
                                    list.Remove(checkBox.Text)
                                End If
                            End If
                        End If
                    End If
                Next
                Points = Nothing
                Points = pnts
                AccomplishedPoints = list
            End If
        End If
    End Sub
#End Region

#Region "Write down details"
    Private Sub SetDetailsStartDate(startDate As DateTime?)
        If Not EditorMode = 0 Then
            If startDate.HasValue Then
                LabelStartDate.Text = "Starting date: " & startDate.Value.ToString("dd/MM/yyyy") & " at " & startDate.Value.ToString("HH:mm")
            Else
                LabelStartDate.Text = "Starting date:"
                SetButtonVisibility(ButtonStartDate, True)
            End If
            AppendButtonToControl(ButtonStartDate, LabelStartDate)
        End If
    End Sub

    Private Sub SetDetailsEndDate(endDate As DateTime?)
        If Not EditorMode = 0 Then
            If endDate.HasValue Then
                LabelEndDate.Text = "Finish date: " & endDate.Value.ToString("dd/MM/yyyy") & " at " & endDate.Value.ToString("HH:mm")
            Else
                LabelEndDate.Text = "Finish date:"
                SetButtonVisibility(ButtonEndDate, True)
            End If
            AppendButtonToControl(ButtonEndDate, LabelEndDate)
        End If
    End Sub

    Private Sub SetDetailsPriority(priority As CustomListBox.Priority)
        If Not IsNothing(priority) And Not priority = 0 Then
            LabelPriority.Text = "Priority: " & StrConv(priority.ToString, VbStrConv.ProperCase)
        Else
            LabelPriority.Text = "Priority:"
            If Not EditorMode = 0 Then
                SetButtonVisibility(ButtonPriority, True)
            End If
        End If
            AppendButtonToControl(ButtonPriority, LabelPriority)
    End Sub
#End Region
#Region "Do checkBoxes"
    Private Function CreateCheckBox(title As String, yPos As Integer) As CheckBox
        Dim checkBox As New CheckBox
        With checkBox
            .Name = Guid.NewGuid.ToString("N")
            .AutoCheck = False
            .Text = title
            .Font = New Font("Microsoft Sans Serif", 9)
            .Margin = New Padding(0)
            .ForeColor = Color.FromArgb(240, 240, 240)
            .AutoEllipsis = True
            .BackColor = Color.Transparent
            .Size = New Size(384, 19)
            .Location = New Point(18, yPos)
        End With
        AddHandler checkBox.MouseClick, AddressOf CheckBoxClicked
        PanelPoints.Controls.Add(checkBox)
        Return checkBox
    End Function

    Private Sub CheckBoxClicked(obj As Object, e As MouseEventArgs)
        Dim sender As CheckBox = TryCast(obj, CheckBox)
        If sender Is Nothing Then Exit Sub
        Select Case EditorMode
            Case CustomListBox.EditorMode.FIXED
                Dim list As List(Of String)
                If Not IsNothing(AccomplishedPoints) Then
                    list = AccomplishedPoints
                Else
                    list = New List(Of String)
                End If
                If Not sender.Checked Then
                    sender.Checked = True
                    'why wont
                    list.Add(sender.Text)
                    AccomplishedPoints = list
                Else
                    sender.Checked = False
                    'that work
                    If list.Contains(sender.Text) Then
                        list.Remove(sender.Text)
                    End If
                    AccomplishedPoints = list
                End If
                If ThisTimeMarker IsNot Nothing Then
                    ThisTimeMarker.AccomplishedPoints = AccomplishedPoints
                End If
            Case CustomListBox.EditorMode.ADD, CustomListBox.EditorMode.EDIT
                If deletePoints Then
                    If Not sender.CheckState = CheckState.Indeterminate Then
                        sender.CheckState = CheckState.Indeterminate
                        deletePointsColection.Add(sender)
                    Else
                        sender.CheckState = CheckState.Unchecked
                        deletePointsColection.Remove(sender)
                    End If
                End If
        End Select
    End Sub
#End Region
#End Region

    Private Sub SetControls()
        For Each control As Control In Descriptor.Controls
            If control.GetType = GetType(Panel) Then
                Dim panel As Panel = CType(control, Panel)
                Dim controlList As New List(Of Control)
                For Each subControl As Control In panel.Controls
                    controlList.Add(subControl)
                Next
                panelColection.Add(panel, controlList)
            End If
        Next
    End Sub

    Private Sub PopulateInitialDropDown()
        For Each panel As Panel In panelColection.Keys
            Dim height As Integer = GetMaxControlHeight(panel)
            Dim dropDown As Integer = panel.Height - height
            initialDropDown.Add(panel, dropDown)
        Next
    End Sub

    Private Sub ResizeRichTextBox(textBox As RichTextBox, e As ContentsResizedEventArgs)
        If Not textBox.Height = e.NewRectangle.Height + 2 Then
            Dim panel As Panel = GetPanelFromControl(textBox)
            textBox.Height = e.NewRectangle.Height + 2
            If panel Is Nothing Then Exit Sub
            Dim index As Integer = GetIndexFromPanel(panel)
            For i = index To panelColection.Count
                Dim p As Panel = panelColection.Keys(i)
                markedForUpdate.Add(p)
            Next
            If markedForUpdate.Count > 0 Then
                RaiseEvent UpdatePanels()
            End If
        End If
    End Sub

#Region "Util"
    Private Sub SetButtonVisibility(control As Button, value As Boolean)
        control.Enabled = value
        control.Visible = value
    End Sub

    Private Function GetMaxControlHeight(panel As Panel) As Integer
        If Not panelColection.ContainsKey(panel) Then Return -1
        Dim controlList As List(Of Control) = panelColection(panel)
        Dim maxHeight As Integer = 0
        Dim dropDown As Integer
        If initialDropDown.ContainsKey(panel) Then
            dropDown = initialDropDown(panel)
        Else
            dropDown = 5
        End If
        For Each control As Control In controlList
            If control.Bottom + dropDown > maxHeight Then
                maxHeight = control.Bottom + dropDown
            End If
        Next
        Return maxHeight
    End Function

    Private Sub DockPanelToPanel(panelFrom As Panel, panelTo As Panel)
        If panelFrom Is Nothing Then Exit Sub
        Dim pos As Point
        If panelTo Is Nothing Then
            pos = New Point(0, 0)
        Else
            pos = New Point(0, panelTo.Bottom)
        End If
        panelFrom.Location = pos
    End Sub

    Private Function GetPanelFromControl(control As Control) As Control
        If control Is Nothing Then Exit Function
        For Each kvPair As KeyValuePair(Of Panel, List(Of Control)) In panelColection
            Dim panel As Panel = kvPair.Key
            Dim controls As List(Of Control) = kvPair.Value
            For Each cont As Control In controls
                If cont Is control Then
                    Return panel
                End If
            Next
        Next
        Return Nothing
    End Function

    Private Function GetIndexFromPanel(panel As Panel) As Integer
        For i = 0 To panelColection.Count
            Dim p As Panel = panelColection.Keys(i)
            If p Is panel Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub AppendButtonToControl(button As Button, control As Control)
        If button Is Nothing Then Exit Sub
        Dim pos As Point
        If control Is Nothing Then
            pos = New Point(0, 0)
        Else
            pos = New Point(control.Right + 2, control.Top + (control.Height - button.Height) / 2)
        End If
        button.Location = pos
    End Sub
#End Region

#Region "Rendering"
    Dim startPointTime As New Point(0, 1)
    Dim endPointTime As Point
    Private Sub PaintTitle(sender As Object, e As PaintEventArgs) Handles PanelTitle.Paint
        '0 to width of panel
        If ThisTimeMarker IsNot Nothing Then
            If ThisTimeMarker.ShowProgress Then
                Dim graphics As Graphics = e.Graphics
                Dim progressToX As Double = Progress * PanelTitle.Width
                Dim progPoint As New Point(progressToX, 1)
                graphics.DrawLine(New Pen(fColorNormal, 3), startPointTime, progPoint)
                graphics.DrawLine(New Pen(bColor, 3), progPoint, endPointTime)
                graphics.Dispose()
            End If
        End If
    End Sub

    Private Sub PaintStart(sender As Object, e As PaintEventArgs) Handles PanelStart.Paint
        Select Case Priority
            Case CustomListBox.Priority.HIGH
                Dim graphics As Graphics = e.Graphics
                Dim pen As New Pen(fColorStart, 5)
                Dim rectangle As Rectangle = PanelStart.DisplayRectangle
                Dim path As GraphicsPath = triangularPath
                rectangle.Inflate(-pen.Width, -pen.Width)
                graphics.DrawEllipse(pen, rectangle)
                graphics.FillPath(fColorStart, path)
                graphics.Dispose()
        End Select
    End Sub

    Private Function GetTrianglePath(dist As Integer) As GraphicsPath
        'dont make me do math...
        Dim rectangle As New Rectangle(21, 15, (dist / Math.Sqrt(2)) + 1, dist)
        Dim path As New GraphicsPath
        Dim p1 As New Point(rectangle.Left, rectangle.Top)
        Dim p2 As New Point(rectangle.Left, rectangle.Bottom)
        Dim p3 As New Point(rectangle.Right, rectangle.Top + rectangle.Height / 2)
        path.StartFigure()
        path.AddLine(p1, p2)
        path.AddLine(p2, p3)
        path.AddLine(p3, p1)
        path.CloseFigure()
        Return path
    End Function

    Dim Pprogress As Double
    Private Sub PaintPoints(sender As Object, e As PaintEventArgs) Handles PanelPoints.Paint
        If RenderPointsProgress Then
            Dim graphics As Graphics = e.Graphics
            If Not PointsNumber = 0 Then
                Pprogress = startPoint.X + ((AccomplishedPointsNumber / PointsNumber) * widthB)
                Dim pnt As New Point(Pprogress, yPos)
                graphics.DrawLine(New Pen(fColorNormal, 3), startPoint, pnt)
                graphics.DrawLine(New Pen(bColor, 3), pnt, endPoint)
            End If
            graphics.Dispose()
        End If
    End Sub
#End Region
#Region "Fake hover events for cuteness :3"
#Region "Button add date start"
    Private Sub AddDateSButtonEnter(sender As Object, e As EventArgs) Handles ButtonStartDate.MouseEnter
        ButtonStartDate.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub AddDateSButtonLeave(sender As Object, e As EventArgs) Handles ButtonStartDate.MouseLeave
        ButtonStartDate.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#Region "Button add date end"
    Private Sub AddDateEButtonEnter(sender As Object, e As EventArgs) Handles ButtonEndDate.MouseEnter
        ButtonEndDate.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub AddDateEButtonLeave(sender As Object, e As EventArgs) Handles ButtonEndDate.MouseLeave
        ButtonEndDate.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#Region "Button priority set"
    Private Sub AddDatePButtonEnter(sender As Object, e As EventArgs) Handles ButtonPriority.MouseEnter
        ButtonPriority.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub AddDatePButtonLeave(sender As Object, e As EventArgs) Handles ButtonPriority.MouseLeave
        ButtonPriority.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#Region "Button add point"
    Private Sub AddPointButtonEnter(sender As Object, e As EventArgs) Handles ButtonAddPoint.MouseEnter
        ButtonAddPoint.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub AddPointButtonLeave(sender As Object, e As EventArgs) Handles ButtonAddPoint.MouseLeave
        ButtonAddPoint.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#Region "Button add point"
    Private Sub RemovePointButtonEnter(sender As Object, e As EventArgs) Handles ButtonRemovePoint.MouseEnter
        ButtonRemovePoint.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub RemovePointButtonLeave(sender As Object, e As EventArgs) Handles ButtonRemovePoint.MouseLeave
        ButtonRemovePoint.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#Region "Start timer"
    Private Sub PanelStartEnter(sender As Object, e As EventArgs) Handles PanelStart.MouseEnter
        fColorStart.Color = Color.FromArgb(25, 156, 255)
        Refresh()
    End Sub

    Private Sub PanelStartLeave(sender As Object, e As EventArgs) Handles PanelStart.MouseLeave
        fColorStart.Color = Color.FromArgb(0, 112, 192)
        Refresh()
    End Sub
#End Region
#End Region
End Class