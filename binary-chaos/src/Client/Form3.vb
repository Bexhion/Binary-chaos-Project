Public Class LoginUser

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Me.Hide()
        RegistryPage.Show()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        CheckCredentials(Username.Text, Password.Text)
    End Sub

    Private Sub CheckCredentials(username As String, password As String)
        Dim result As MyJsonParser.User = MyJsonParser.User.LoadUser(username, password)
        If result IsNot Nothing Then
            MainForm.userDetails = result
            MainForm.Show()
            Me.Hide()
        Else
            MsgBox("User login failed")
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles Username.GotFocus
        If Username.Text = "USERNAME" And Username.ForeColor = Color.FromArgb(64, 64, 64) Then
            Username.Text = ""
            Username.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles Password.GotFocus
        If Password.Text = "PASSWORD" And Password.ForeColor = Color.FromArgb(64, 64, 64) Then
            Password.Text = ""
            Password.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles Username.LostFocus
        If Username.Text = "" Then
            Username.Text = "USERNAME"
            Username.ForeColor = Color.FromArgb(64, 64, 64)
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles Password.LostFocus
        If Password.Text = "" Then
            Password.Text = "PASSWORD"
            Password.ForeColor = Color.FromArgb(64, 64, 64)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub RecoverPassword_Click(sender As Object, e As EventArgs) Handles RecoverPasswordLabel.Click
        If Not Username.Text = "" Or Not (Username.Text = "USERNAME" And Username.ForeColor = Color.FromArgb(64, 64, 64)) Then
            RecoverPassword.userName = Username.Text
            Me.Hide()
            RecoverPassword.Show()
        Else
            Username.Focus()
        End If
    End Sub
End Class