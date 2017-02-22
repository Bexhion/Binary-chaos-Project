<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomListBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ActualList = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'ActualList
        '
        Me.ActualList.AutoScroll = True
        Me.ActualList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActualList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ActualList.Location = New System.Drawing.Point(0, 0)
        Me.ActualList.Margin = New System.Windows.Forms.Padding(0)
        Me.ActualList.Name = "ActualList"
        Me.ActualList.Size = New System.Drawing.Size(248, 334)
        Me.ActualList.TabIndex = 0
        Me.ActualList.WrapContents = False
        '
        'CustomListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ActualList)
        Me.Name = "CustomListBox"
        Me.Size = New System.Drawing.Size(248, 334)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActualList As FlowLayoutPanel
End Class
