Public Class Form3

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        RegistryPage.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles RecoverPassword.Click
        RecoverPassword.Show()
    End Sub

    Private Sub Label4_Hover(sender As Object, e As EventArgs) Handles RecoverPassword.MouseHover

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Form1.Show()

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub
End Class