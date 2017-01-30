Public Class Window_main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim width As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim height As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Size = New Size(width * 0.75, height * 0.75)
        Me.Location = New Point(width * 0.125, height * 0.125)
    End Sub

    Public Sub changeWindowTitle(text As String)
        Me.Text = text
    End Sub
End Class