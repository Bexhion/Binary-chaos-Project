Public Class FakeInputBox
    Public Property Text As String
    Dim pos As Point

    Public Sub New(pos As Point)
        InitializeComponent()
        Me.pos = pos
    End Sub

    Private Sub ClickAddButton(sender As Object, e As EventArgs) Handles AddButton.Click
        text = Input.Text
        Me.Close()
    End Sub

    Private Sub LoadFakeInputBox(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = pos
        Input.Text = "Add a description to your check box"
        Input.ForeColor = Color.Gray
    End Sub

    Private Sub TextBoxWrite(sender As Object, e As EventArgs) Handles Input.GotFocus
        If Input.Text = "Add a description to your check box" Then
            Input.ForeColor = Color.White
            Input.Text = ""
        End If
    End Sub

    Private Sub TextBoxStopWrite(sender As Object, e As EventArgs) Handles Input.LostFocus
        If Input.Text = "" Then
            Input.ForeColor = Color.Gray
            Input.Text = "Add a description to your check box"
        End If
    End Sub

    Private Sub ButtonAddMEnter(sender As Object, e As EventArgs) Handles AddButton.MouseEnter
        AddButton.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub ButtonCloseMEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter
        CloseButton.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub ButtonAddMLeave(sender As Object, e As EventArgs) Handles AddButton.MouseLeave
        AddButton.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub ButtonCloseMLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

    End Sub
End Class