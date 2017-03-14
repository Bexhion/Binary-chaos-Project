Public Class RegistryPage
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim security1 As String = TextBox3.Text
        Dim security2 As String = TextBox4.Text
        Dim security3 As String = TextBox5.Text
        Dim user As New MyJsonParser.User
        With user
            .id = Guid.NewGuid.ToString("N")
            .username = username
            .password = password
            .securityAnswer1 = security1
            .securityAnswer2 = security2
            .securityAnswer3 = security3
            .blacklistedPrograms = _EXP_ProgramTerminator.blackListedPrograms
            .allTimeMarkers = New List(Of MyJsonParser.User.Marker)
        End With
        MyJsonParser.User.SaveUser(user)
        LoginUser.Show()
        Me.Close()
    End Sub

    Private Sub RegistryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class