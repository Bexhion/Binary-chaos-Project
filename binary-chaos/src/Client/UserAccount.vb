Imports System.IO
Public Class UserAccount

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
    End Sub

    Private Sub ChangePicture_Click(sender As Object, e As EventArgs) Handles ChangePicture.Click
        Dim folderBrowser As New OpenFileDialog
        With folderBrowser
            .Title = "Select a picture"
            .Multiselect = False
            .CheckFileExists = True
            .InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            .Filter = "Image Files (*.PNG;*.JPG)|*.PGN;*.JPG|All Files (*.*)|*.*"
        End With
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            Dim stream As Stream = Nothing
            Try
                stream = folderBrowser.OpenFile
                If stream IsNot Nothing Then
                    Dim thisPath As String = Path.Combine(MyJsonParser.applicationPath, "users", "images")
                    SaveImage(stream, thisPath)
                    LoadImage(Path.Combine(thisPath, "test" & ".jpg"))
                End If
            Catch ex As Exception
                MsgBox("Could not open file")
            Finally
                If stream IsNot Nothing Then
                    stream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub AddProgram_Click(sender As Object, e As EventArgs) Handles AddProgram.Click
        Dim folderBrowser As New OpenFileDialog
        With folderBrowser
            .Title = "Select a picture"
            .Multiselect = False
            .CheckFileExists = True
            .InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
            .Filter = "Executable Files (*.EXE)|*.EXE|All Files (*.*)|*.*"
        End With
        If folderBrowser.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub RemoveProgram_Click(sender As Object, e As EventArgs) Handles RemoveProgram.Click

    End Sub

    Private Sub PasswordChange_Click(sender As Object, e As EventArgs) Handles PasswordChange.Click

    End Sub

    Private Sub MarkerDelete_Click(sender As Object, e As EventArgs) Handles MarkerDelete.Click

    End Sub

    Private Sub UserDelete_Click(sender As Object, e As EventArgs) Handles UserDelete.Click

    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click

    End Sub

    Private Sub UserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveImage(stream As Stream, toPath As String)
        Dim bitmap As New Bitmap(stream)
        If Not Directory.Exists(toPath) Then
            Directory.CreateDirectory(toPath)
        End If
        bitmap.Save(Path.Combine(toPath, "test" & ".jpg"), Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub LoadImage(thispath As String)
        If File.Exists(thispath) Then
            Dim bitmap As New Bitmap(thispath)
            Photo.BackgroundImage = bitmap
        End If
    End Sub
End Class