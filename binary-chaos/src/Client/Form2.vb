Imports System.IO
Public Class RecoverPassword

    Public userName As String
    Dim pass As Boolean = False

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        LoginUser.Show()
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim user As MyJsonParser.User = MyJsonParser.SetProperties(userName, Path.Combine(MyJsonParser.applicationPath, "users"))
        If Not pass Then
            Dim answer1 As String = user.securityAnswer1
            Dim answer2 As String = user.securityAnswer2
            Dim answer3 As String = user.securityAnswer3
            If TxtAnswer1.Text = answer1 And TxtAnswer2.Text = answer2 And TxtAnswer3.Text = answer3 Then
                Label1.Text = "New password:"
                Label2.Text = "New password (again):"
                Label2.Hide()
                TxtAnswer3.Hide()
                Submit.Location = New Point(73, 214)
                Height = 260
                pass = True
            End If
        Else
            If TxtAnswer1.Text = TxtAnswer2.Text Then
                user.password = TxtAnswer1.Text
                MyJsonParser.User.SaveUser(user)
                LoginUser.Show()
                Me.Close()
            Else
                MsgBox("Passwords do not match")
            End If
        End If
    End Sub
End Class