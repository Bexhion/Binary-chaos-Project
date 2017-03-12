Public Class Form3

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        RegistryPage.Show()
    End Sub

    'Private Sub Label4_Click(sender As Object, e As EventArgs) Handles RecoverPassword.Click
    '    RecoverPassword.Show()
    'End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        CheckCredentials(TextBox2.Text, TextBox1.Text)
    End Sub

    Private Sub CheckCredentials(username As String, password As String)
        Dim result As MyJsonParser.User = MyJsonParser.User.LoadUser(username, password)
        If result Is Nothing Then
            MsgBox("Couldn't")
        Else
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "USERNAME" And TextBox2.ForeColor = Color.Gray Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "PASSWORD" And TextBox1.ForeColor = Color.Gray Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "USERNAME"
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox2.Text = "PASSWORD"
        End If
    End Sub
End Class