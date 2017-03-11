Public Class Form1

    Dim windowRelativeSize As Double = 0.85

    Private Sub MainFormLoad(sender As Object, e As EventArgs)
        'Check if our relative size isn't inferior to 0% or superior to 100%
        If windowRelativeSize > 1 Then
            windowRelativeSize = 1
        End If
        If windowRelativeSize < 0 Then
            windowRelativeSize = 0
        End If

        Dim size As New Size(0, 0)
        Dim location As New Point(0, 0)

        'Perform calculations with Screen.PrimaryScreen.Bounds.Size
        size.Width = Screen.PrimaryScreen.Bounds.Size.Width * windowRelativeSize
        size.Height = Screen.PrimaryScreen.Bounds.Size.Height * windowRelativeSize

        location.X = (Screen.PrimaryScreen.Bounds.Size.Width * (1 - windowRelativeSize)) / 2
        location.Y = (Screen.PrimaryScreen.Bounds.Size.Height * (1 - windowRelativeSize)) / 2

        'Setting the properties
        Me.Size = size
        Me.Location = location
    End Sub
    'Private Sub Planificação_Click(sender As Object, e As EventArgs) Handles Planificação.Click
    '    RecoverPassword.Show()
    'End Sub

    'Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click
    '    Form3.Show()
    'End Sub

    'Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
    '    Process.Start("http://franciscocardoso7.wixsite.com/studyroom")
    'End Sub

    'Private Sub definições_Click(sender As Object, e As EventArgs) Handles MainPage.Click
    '    RecoverPassword.Show()
    'End Sub

    'Dim newlist As New List(Of String)
    'Dim marker As TimeMarker
    Private Sub f(sender As Object, e As EventArgs) Handles user.MouseClick
        'newlist.Add("media")
        'newlist.Add("rosa")
        'newlist.Add("caderno")
        'newlist.Add("papel")
        'newlist.Add("escada")
        'newlist.Add("carteira")
        'newlist.Add("bolsa")
        'newlist.Add("caneta")
        'newlist.Add("armario")
        'newlist.Add("regua")
        'newlist.Add("tesoura")
        'marker = New TimeMarker(New Date(2017, 6, 15, 13, 9, 0), 89, TimeMarker.State.STATE_INACTIVE)
        'CustomListBox1.Add(marker, "oh look son", "your dead parents! you're adopted!", newlist, CustomListBox.Priority.MEDIUM
        Dim chooser As New FakeInputBox()
        If chooser.ShowDialog() = DialogResult.OK Then
            MsgBox("yeah")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim chooser As New DateChoser()
        'If chooser.ShowDialog() = DialogResult.OK Then

        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TimeMarkerDescription1.EditorMode = CustomListBox.EditorMode.ADD
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TimeMarkerDescription1.EditorMode = CustomListBox.EditorMode.EDIT
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TimeMarkerDescription1.EditorMode = CustomListBox.EditorMode.FIXED
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TimeMarkerDescription1.EditorMode = CustomListBox.EditorMode.REMOVE
    End Sub
End Class
