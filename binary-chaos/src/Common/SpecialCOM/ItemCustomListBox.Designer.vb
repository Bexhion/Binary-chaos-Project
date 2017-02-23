<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemCustomListBox
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
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Desc = New System.Windows.Forms.Label()
        Me.Label_Points = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Day = New System.Windows.Forms.Label()
        Me.Label_Month = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(62, 3)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(50, 24)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "Title"
        '
        'Label_Desc
        '
        Me.Label_Desc.AutoEllipsis = True
        Me.Label_Desc.AutoSize = True
        Me.Label_Desc.Location = New System.Drawing.Point(63, 27)
        Me.Label_Desc.Name = "Label_Desc"
        Me.Label_Desc.Size = New System.Drawing.Size(60, 13)
        Me.Label_Desc.TabIndex = 1
        Me.Label_Desc.Text = "Description"
        Me.Label_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Points
        '
        Me.Label_Points.AutoEllipsis = True
        Me.Label_Points.AutoSize = True
        Me.Label_Points.Location = New System.Drawing.Point(63, 49)
        Me.Label_Points.Name = "Label_Points"
        Me.Label_Points.Size = New System.Drawing.Size(74, 13)
        Me.Label_Points.TabIndex = 2
        Me.Label_Points.Text = "Points number"
        Me.Label_Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Month)
        Me.Panel1.Controls.Add(Me.Label_Day)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(60, 70)
        Me.Panel1.TabIndex = 3
        '
        'Label_Day
        '
        Me.Label_Day.AutoEllipsis = True
        Me.Label_Day.AutoSize = True
        Me.Label_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Day.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label_Day.Location = New System.Drawing.Point(17, 8)
        Me.Label_Day.Name = "Label_Day"
        Me.Label_Day.Size = New System.Drawing.Size(27, 29)
        Me.Label_Day.TabIndex = 4
        Me.Label_Day.Text = "0"
        Me.Label_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Month
        '
        Me.Label_Month.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Month.AutoEllipsis = True
        Me.Label_Month.AutoSize = True
        Me.Label_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Month.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label_Month.Location = New System.Drawing.Point(8, 36)
        Me.Label_Month.Name = "Label_Month"
        Me.Label_Month.Size = New System.Drawing.Size(44, 16)
        Me.Label_Month.TabIndex = 5
        Me.Label_Month.Text = "Month"
        Me.Label_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemCustomListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_Points)
        Me.Controls.Add(Me.Label_Desc)
        Me.Controls.Add(Me.Label_Title)
        Me.Name = "ItemCustomListBox"
        Me.Size = New System.Drawing.Size(308, 70)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Desc As Label
    Friend WithEvents Label_Points As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Month As Label
    Friend WithEvents Label_Day As Label
End Class
