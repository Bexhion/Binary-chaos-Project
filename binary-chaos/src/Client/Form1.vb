Public Class Form1

    Public Function maketimemarker(day As Integer, month As Integer, year As Integer, hour As Integer, minute As Integer, seconds As Integer) As TimeMarker
        If month = 2 Then
            month = 1
        End If
        If month = 2 Or month = 4 Or month = 6 Or month = 9 Or month = 11 Then
            If day = 31 Then
                day = 30
            End If
        End If

        Return New TimeMarker(New Date(year, month, day, hour, minute, seconds), 19, TimeMarker.State.STATE_INACTIVE)
    End Function
    Dim list As New List(Of String)

    'The amount space screen our program is going to occupy
    Dim windowRelativeSize As Double = 0.85
    Private Sub StartUp(sender As Object, e As EventArgs) Handles Me.Load
        'Check if our relative size isn't inferior to 0% or superior to 100%
        ItemCLBColors.CreateBrushes(True)
        ItemCLBColors.CreateColors(True)
        ItemCLBColors.CreateOverlayBrushes(True)
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


        'CustomListBox1.Add(time, "Xixi", "Urina", list, CustomListBox.Priority.MEDIUM)
        'CustomListBox1.Add(time, "Xixi", "Urina", list, CustomListBox.Priority.MEDIUM)
        'CustomListBox1.Add(time, "Xixi", "Urina", list, CustomListBox.Priority.HIGH)
        'CustomListBox1.Add(time, "Xixi", "Urina", list, CustomListBox.Priority.HIGH)
        'CustomListBox1.Add(time, "Xixi", "Urina", list, CustomListBox.Priority.LOW)
        'Label1.Text = CustomListBox1.ActualList.Controls.Count
        list.Add("this")
        list.Add("that")
        list.Add("everything")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        list.Add("Tell em to shut up")
        CustomListBox1.SetDescriptor(TimeMarkerDescription1)
    End Sub

    Private Sub Planificação_Click(sender As Object, e As EventArgs) Handles Planificação.Click
        RecoverPassword.Show()
    End Sub
    Private Sub segurança_Click(sender As Object, e As EventArgs) Handles segurança.Click
        RegistryPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim time As TimeMarker = maketimemarker(random(31), random(12), random(2017), random(23), random(59), random(59))
        CustomListBox1.Add(time, "Doot doot: a time of living in prosperity and some other shits", "Noot noot is the principle of life that tells us how to live it the fullest and without any sort of worrying... Oh wait... new information... that is Hakuna Batata", list, CustomListBox.Priority.HIGH)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CustomListBox1.ChangeEditorMode(3)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CustomListBox1.Clear(CustomListBox1.listToDelete)
        MsgBox(CustomListBox1.ActualList.Controls.Count)
    End Sub

    'Magical code
    'For Each c As Control In Me.Controls
    '    If TypeOf c Is TextBox Then
    '        With CType(c, TextBox)
    '            Dim g As Graphics = CreateGraphics()
    '            Dim sz As SizeF = g.MeasureString(.Text, .Font, .ClientSize.Width)
    '            .Height = CType(sz.Height, Integer)
    '        End With
    '    End If
    'Next

    Public Function random(max As Integer) As Integer
        Randomize()
        Return Int(Rnd() * max + 1)
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each item As TimeMarkerItemCLB In CustomListBox1.ActualList.Controls
            MsgBox("Item name: " & item.Name & "; Item date: " & item.FullDate.ToString)
        Next
    End Sub
End Class