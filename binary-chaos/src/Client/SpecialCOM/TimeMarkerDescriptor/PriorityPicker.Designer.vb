<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriorityPicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PriorityHigh = New System.Windows.Forms.Button()
        Me.PriorityMedium = New System.Windows.Forms.Button()
        Me.PriorityLow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PriorityHigh
        '
        Me.PriorityHigh.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.PriorityHigh.FlatAppearance.BorderSize = 0
        Me.PriorityHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityHigh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityHigh.Location = New System.Drawing.Point(0, 0)
        Me.PriorityHigh.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityHigh.Name = "PriorityHigh"
        Me.PriorityHigh.Size = New System.Drawing.Size(140, 65)
        Me.PriorityHigh.TabIndex = 2
        Me.PriorityHigh.Text = "High Priority"
        Me.PriorityHigh.UseVisualStyleBackColor = True
        '
        'PriorityMedium
        '
        Me.PriorityMedium.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.PriorityMedium.FlatAppearance.BorderSize = 0
        Me.PriorityMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityMedium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityMedium.Location = New System.Drawing.Point(140, 0)
        Me.PriorityMedium.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityMedium.Name = "PriorityMedium"
        Me.PriorityMedium.Size = New System.Drawing.Size(140, 65)
        Me.PriorityMedium.TabIndex = 3
        Me.PriorityMedium.Text = "MediumPriority"
        Me.PriorityMedium.UseVisualStyleBackColor = True
        '
        'PriorityLow
        '
        Me.PriorityLow.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.PriorityLow.FlatAppearance.BorderSize = 0
        Me.PriorityLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityLow.Location = New System.Drawing.Point(280, 0)
        Me.PriorityLow.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityLow.Name = "PriorityLow"
        Me.PriorityLow.Size = New System.Drawing.Size(140, 65)
        Me.PriorityLow.TabIndex = 4
        Me.PriorityLow.Text = "Low Priority"
        Me.PriorityLow.UseVisualStyleBackColor = True
        '
        'PriorityPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 65)
        Me.Controls.Add(Me.PriorityLow)
        Me.Controls.Add(Me.PriorityMedium)
        Me.Controls.Add(Me.PriorityHigh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PriorityPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PriorityPicker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PriorityHigh As Button
    Friend WithEvents PriorityMedium As Button
    Friend WithEvents PriorityLow As Button
End Class
