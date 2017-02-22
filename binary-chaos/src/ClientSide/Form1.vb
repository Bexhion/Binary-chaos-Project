Imports WindowsApplication1.ListControl

Public Class Window_main

    Dim listBox As New ListControl()

    Private Sub Window_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 5
            Dim btn As New Button
            With btn
                .Name = "b" & i
                .Text = "Button" & i
                .Height = 25
                .Margin = New Padding(0)
            End With
            listBox.Add(btn)
        Next
        listBox.Location = New Point(0, 0)
        listBox.Size = New Size(100, 300)
        Controls.Add(listBox)
    End Sub
End Class