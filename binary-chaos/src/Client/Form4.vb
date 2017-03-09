Public Class RegistryPage
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub
End Class