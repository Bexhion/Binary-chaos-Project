Public Class Form1

    'The amount space screen our program is going to occupy
    Dim windowRelativeSize As Double = 0.85

    Private Sub StartUp(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub Planificação_Click(sender As Object, e As EventArgs) Handles Planificação.Click
        RecoverPassword.Show()
    End Sub
    Private Sub segurança_Click(sender As Object, e As EventArgs) Handles segurança.Click
        RegistryPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
