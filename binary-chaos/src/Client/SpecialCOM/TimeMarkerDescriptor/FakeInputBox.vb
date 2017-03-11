Public Class FakeInputBox
    Public Property Text As String
    Dim pos As Point
    Dim validatedInput As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(control As UserControl, pos As Point)
        InitializeComponent()
        pos.Y = pos.Y - Height
        Dim p As Point = Me.PointToClient(pos)
        Me.pos = control.Parent.PointToScreen(pos)
    End Sub

    Private Sub RichTextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        If Input.Text = "" Or (Input.Text = "Add a description to your checkbox" And Input.ForeColor = Color.Gray) Then
            validatedInput = False
            AddButton.Enabled = False
        Else
            validatedInput = True
            AddButton.ForeColor = Color.FromArgb(0, 112, 192)
            AddButton.Enabled = True
        End If
    End Sub

    Private Sub ClickAddButton(sender As Object, e As EventArgs) Handles AddButton.Click
        If validatedInput Then
            Text = Input.Text
            Me.Close()
        Else
            MsgBox("Checkbox description is not valid")
        End If
    End Sub

    Private Sub LoadFakeInputBox(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = pos
        Input.Text = "Add a description to your checkbox"
        Input.ForeColor = Color.Gray
    End Sub

    Private Sub TextBoxWrite(sender As Object, e As EventArgs) Handles Input.GotFocus
        If Input.Text = "Add a description to your checkbox" And Input.ForeColor = Color.Gray Then
            Input.ForeColor = Color.FromArgb(240, 240, 240)
            Input.Text = ""
        End If
    End Sub

    Private Sub TextBoxStopWrite(sender As Object, e As EventArgs) Handles Input.LostFocus
        If Input.Text = "" And Input.ForeColor = Color.FromArgb(240, 240, 240) Then
            Input.ForeColor = Color.Gray
            Input.Text = "Add a description to your checkbox"
        End If
    End Sub

#Region "ALL THE CUTENESS"
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
        Me.Close()
    End Sub
#End Region
End Class