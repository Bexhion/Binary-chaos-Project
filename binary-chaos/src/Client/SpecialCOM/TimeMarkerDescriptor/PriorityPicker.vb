Public Class PriorityPicker
    Public Property Priority As CustomListBox.Priority

    Dim pos As Point

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(control As UserControl, pos As Point)
        InitializeComponent()
        pos.Y = pos.Y - Height
        Dim p As Point = Me.PointToClient(pos)
        Me.pos = control.Parent.PointToScreen(pos)
    End Sub

    Private Sub LoadFakeInputBox(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = pos
    End Sub

    Private Sub PriorityHigh_Click(sender As Object, e As EventArgs) Handles PriorityHigh.Click
        Priority = CustomListBox.Priority.HIGH
        Me.Close()
    End Sub

    Private Sub PriorityMedium_Click(sender As Object, e As EventArgs) Handles PriorityMedium.Click
        Priority = CustomListBox.Priority.MEDIUM
        Me.Close()
    End Sub

    Private Sub PriorityLow_Click(sender As Object, e As EventArgs) Handles PriorityLow.Click
        Priority = CustomListBox.Priority.LOW
        Me.Close()
    End Sub

#Region "Even more cuteness!! :3"
#Region "Mouse enter"
    Private Sub PriorityHigh_MouseEnter(sender As Object, e As EventArgs) Handles PriorityHigh.MouseEnter
        PriorityHigh.BackColor = Color.FromArgb(64, 142, 0, 0)
        PriorityHigh.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub PriorityMedium_MouseEnter(sender As Object, e As EventArgs) Handles PriorityMedium.MouseEnter
        PriorityMedium.BackColor = Color.FromArgb(64, 196, 94, 18)
        PriorityMedium.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub PriorityLow_MouseEnter(sender As Object, e As EventArgs) Handles PriorityLow.MouseEnter
        PriorityLow.BackColor = Color.FromArgb(64, 60, 92, 38)
        PriorityLow.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub
#End Region
#Region "Mouse leave"
    Private Sub PriorityHigh_MouseLeave(sender As Object, e As EventArgs) Handles PriorityHigh.MouseLeave
        PriorityHigh.BackColor = Color.Transparent
        PriorityHigh.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub PriorityMedium_MouseLeave(sender As Object, e As EventArgs) Handles PriorityMedium.MouseLeave
        PriorityMedium.BackColor = Color.Transparent
        PriorityMedium.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub PriorityLow_MouseLeave(sender As Object, e As EventArgs) Handles PriorityLow.MouseLeave
        PriorityLow.BackColor = Color.Transparent
        PriorityLow.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#End Region
End Class