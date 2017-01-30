'We will probably have to work on the scaling and positioning of the objects when the form is resized
Public Class Window_main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub changeWindowTitle(text As String)
        Me.Text = text
    End Sub
End Class