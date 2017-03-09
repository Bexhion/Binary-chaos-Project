Imports System.Drawing.Drawing2D
Public Class TimeMarkerDescription

#Region "Properties"
    Dim panelColection As New Dictionary(Of Panel, List(Of Control))
    Dim markedForUpdate As New List(Of Panel)
    Dim initialDropDown As New Dictionary(Of Panel, Integer)
    Dim checkBoxColection As New List(Of CheckBox)

    Public Event UpdatePanels()
    Public Event UpdateEditorMode(mode As CustomListBox.EditorMode)

    Dim hasScrollBar As Boolean = False

    Dim _editorMode As CustomListBox.EditorMode

    Dim _title As String
    Dim _description As String
    Dim _fullDateStart As Date
    Dim _fullDateEnd As Date
    Dim _priority As CustomListBox.Priority
    Dim _points As List(Of String)
    Dim _accomplishedPoints As List(Of String)
    Dim _pointsNumber As Integer

#Region "Getters and setters"
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            TxtboxTitle.Text = _title
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
            TxtboxDesc.Text = _description
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property FullDateStart() As Date
        Get
            Return _fullDateStart
        End Get
        Set(value As Date)
            _fullDateStart = value
            SetDetailsStartDate(value)
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property FullDateEnd() As Date
        Get
            Return _fullDateEnd
        End Get
        Set(value As Date)
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
        End Set
    End Property

    Public Property Points() As List(Of String)
        Get
            Return _points
        End Get
        Set(value As List(Of String))
            _points = value
            If _points IsNot Nothing Then
                PointsNumber = _points.Count
                Dim list As New List(Of Control)
                For i = 0 To _points.Count - 1
                    Dim entry As String = _points(i)
                    Dim checkBox As CheckBox = CreateCheckBox(entry, (20 * i) + 30)
                    list.Add(checkBox)
                    PanelPoints.Controls.Add(checkBox)
                Next
                panelColection(PanelPoints) = list
                markedForUpdate.Add(PanelPoints)
            End If
            RaiseEvent UpdatePanels()
        End Set
    End Property

    Public Property AccomplishedPoints() As List(Of String)
        Get
            Return _accomplishedPoints
        End Get
        Set(value As List(Of String))
            _accomplishedPoints = value
        End Set
    End Property

    Public Property PointsNumber() As Integer
        Get
            Return _pointsNumber
        End Get
        Set(value As Integer)
            _pointsNumber = value
            Refresh()
        End Set
    End Property

    Public Property EditorMode() As CustomListBox.EditorMode
        Get
            Return _editorMode
        End Get
        Set(value As CustomListBox.EditorMode)
            _editorMode = value
            RaiseEvent UpdateEditorMode(value)
        End Set
    End Property
#End Region
#End Region
    Public Sub New()
        InitializeComponent()
        AddHandler TxtboxTitle.ContentsResized, AddressOf ResizeRichTextBox
        AddHandler TxtboxDesc.ContentsResized, AddressOf ResizeRichTextBox
        SetControls()
        PopulateInitialDropDown()
        'Testing
        Title = "This is a title"
        Description = "And this is a description! This will be used to explain what the marker does and how it will behave!"
        FullDateStart = Date.Now
        FullDateEnd = New Date(2017, 3, 9, 7, 30, 0)
        Priority = CustomListBox.Priority.HIGH
        Dim pptp = New List(Of String)
        pptp.Add("Point 1")
        pptp.Add("Point 2")
        pptp.Add("Point 3")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        pptp.Add("GO GO POINTERS GOOOOO")
        Points = pptp
        EditorMode = CustomListBox.EditorMode.EDIT
    End Sub

#Region "Events"
    Private Sub UpdatePanelSequence() Handles Me.UpdatePanels
        Dim lastPanel As Panel = Nothing
        For Each panel As Panel In markedForUpdate
            If panel IsNot Nothing Then
                Dim dropDown As Integer
                If initialDropDown.ContainsKey(panel) Then
                    dropDown = initialDropDown(panel)
                Else
                    dropDown = 5
                End If
                Dim height As Integer = GetMaxControlHeight(panel)
                If panel Is PanelPoints Then
                End If
                panel.Height = height + dropDown
                DockPanelToPanel(panel, lastPanel)
            End If
        Next
        markedForUpdate.Clear()
    End Sub

    Private Sub EditorChanged(mode As CustomListBox.EditorMode) Handles Me.UpdateEditorMode
        Select Case mode
            Case CustomListBox.EditorMode.ADD
            Case CustomListBox.EditorMode.EDIT
            Case CustomListBox.EditorMode.REMOVE, CustomListBox.EditorMode.FIXED
                SetButtonVisibility(ButtonAddPoint, False)
                SetButtonVisibility(ButtonRemovePoint, False)
                SetButtonVisibility(ButtonEndDate, False)
                SetButtonVisibility(ButtonStartDate, False)
                SetButtonVisibility(ButtonPriority, False)
        End Select
    End Sub

#Region "Button setters"
    Private Sub ButtonStartDate_Click(sender As Object, e As EventArgs) Handles ButtonStartDate.Click
        Dim inputBox As New DateChoser(New Point(0, Bottom))
        If inputBox.DialogResult = DialogResult.OK Then
            FullDateStart = inputBox.ResultDate
        End If
    End Sub

    Private Sub ButtonEndDate_Click(sender As Object, e As EventArgs) Handles ButtonEndDate.Click
        Dim inputBox As New DateChoser(New Point(0, Bottom))
        If inputBox.DialogResult = DialogResult.OK Then
            FullDateEnd = inputBox.ResultDate
        End If
    End Sub

    Private Sub ButtonAddPoint_Click(sender As Object, e As EventArgs) Handles ButtonAddPoint.Click

    End Sub

    Private Sub ButtonRemovePoint_Click(sender As Object, e As EventArgs) Handles ButtonRemovePoint.Click

    End Sub
#End Region

#Region "Write down details"
    Private Sub SetDetailsStartDate(startDate As Date)
        If Not IsNothing(startDate) Then
            LabelStartDate.Text = "Beginning date: " & startDate.ToString("dd/MM/yyyy") & " at " & startDate.ToString("HH:mm")
            SetButtonVisibility(ButtonStartDate, False)
        Else
            LabelStartDate.Text = "Beginning date:"
            SetButtonVisibility(ButtonStartDate, True)
        End If
    End Sub

    Private Sub SetDetailsEndDate(endDate As Date)
        If Not IsNothing(endDate) Then
            LabelEndDate.Text = "Finish date: " & endDate.ToString("dd/MM/yyyy") & " at " & endDate.ToString("HH:mm")
            SetButtonVisibility(ButtonEndDate, False)
        Else
            LabelEndDate.Text = "Finish date:"
            SetButtonVisibility(ButtonEndDate, True)
        End If
    End Sub

    Private Sub SetDetailsPriority(priority As CustomListBox.Priority)
        If Not IsNothing(priority) Then
            LabelPriority.Text = "Priority: " & StrConv(priority.ToString, VbStrConv.ProperCase)
            SetButtonVisibility(ButtonPriority, False)
        Else
            LabelPriority.Text = "Priority:"
            SetButtonVisibility(ButtonPriority, True)
        End If
    End Sub
#End Region
#Region "Do checkBoxes"
    Private Function CreateCheckBox(title As String, yPos As Integer) As CheckBox
        Dim checkBox As New CheckBox
        With checkBox
            .Name = Guid.NewGuid.ToString("N")
            .Text = title
            .Font = New Font("Microsoft Sans Serif", 9)
            .Margin = New Padding(0)
            .ForeColor = Color.FromArgb(240, 240, 240)
            .AutoEllipsis = True
            .BackColor = Color.Transparent
            .Size = New Size(384, 17)
            .Location = New Point(18, yPos)
        End With
        AddHandler checkBox.MouseClick, AddressOf CheckBoxClicked
        PanelPoints.Controls.Add(checkBox)
        Return checkBox
    End Function

    Private Sub CheckBoxClicked(sender As CheckBox, e As MouseEventArgs)
        Select Case EditorMode
            'Case CustomListBox.EditorMode.EDIT
            '    Dim inputBox As New FakeInputBox(New Point(0, Bottom))
            '    If inputBox.ShowDialog = DialogResult.OK Then
            '        Dim text = inputBox.Text
            '        If text = "" Then
            '            MsgBox("Please introduce a valid description", MsgBoxStyle.Exclamation)
            '        Else
            '            sender.Text = text
            '        End If
            '        End Iff
            Case CustomListBox.EditorMode.FIXED
                If sender.Checked Then
                    sender.Checked = False
                    If AccomplishedPoints.Contains(sender.Text) Then
                        AccomplishedPoints.Remove(sender.Text)
                    End If
                Else
                    sender.Checked = True
                    AccomplishedPoints.Add(sender.Text)
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
        If Not textBox.Height = e.NewRectangle.Height Then
            Dim panel As Panel = GetPanelFromControl(textBox)
            textBox.Height = e.NewRectangle.Height
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
        control.Visible = value
        control.Enabled = value
    End Sub

    Private Function GetMaxControlHeight(panel As Panel) As Integer
        If Not panelColection.ContainsKey(panel) Then Return -1
        Dim controlList As List(Of Control) = panelColection(panel)
        Dim maxHeight As Integer = 0
        For Each control As Control In controlList
            If panel Is PanelPoints Then
            End If
            If control.Bottom > maxHeight Then
                maxHeight = control.Bottom
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
#End Region
End Class