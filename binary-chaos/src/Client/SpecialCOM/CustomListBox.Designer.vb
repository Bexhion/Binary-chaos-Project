<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomListBox
    Inherits System.Windows.Forms.UserControl

    Private Sub InitializeComponent()
        Me.ActualList = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'ActualList
        '
        Me.ActualList.AllowDrop = True
        Me.ActualList.AutoScroll = True
        Me.ActualList.BackColor = System.Drawing.Color.Transparent
        Me.ActualList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActualList.Location = New System.Drawing.Point(0, 0)
        Me.ActualList.Name = "ActualList"
        Me.ActualList.Size = New System.Drawing.Size(322, 403)
        Me.ActualList.TabIndex = 0
        '
        'CustomListBox
        '
        Me.Controls.Add(Me.ActualList)
        Me.Name = "CustomListBox"
        Me.Size = New System.Drawing.Size(322, 403)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActualList As FlowLayoutPanel
End Class
