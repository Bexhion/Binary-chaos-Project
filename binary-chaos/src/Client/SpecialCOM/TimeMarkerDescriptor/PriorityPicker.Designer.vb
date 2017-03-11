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
        Me.SetPriorityButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PriorityHigh = New System.Windows.Forms.Button()
        Me.PriorityMedium = New System.Windows.Forms.Button()
        Me.PriorityLow = New System.Windows.Forms.Button()
        Me.ImmutableLabel = New System.Windows.Forms.Label()
        Me.PDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SetPriorityButton
        '
        Me.SetPriorityButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SetPriorityButton.FlatAppearance.BorderSize = 0
        Me.SetPriorityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetPriorityButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SetPriorityButton.Location = New System.Drawing.Point(333, 6)
        Me.SetPriorityButton.Name = "SetPriorityButton"
        Me.SetPriorityButton.Size = New System.Drawing.Size(75, 23)
        Me.SetPriorityButton.TabIndex = 0
        Me.SetPriorityButton.Text = "Set"
        Me.SetPriorityButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(333, 35)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PriorityHigh
        '
        Me.PriorityHigh.FlatAppearance.BorderSize = 0
        Me.PriorityHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityHigh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityHigh.Location = New System.Drawing.Point(22, 1)
        Me.PriorityHigh.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityHigh.Name = "PriorityHigh"
        Me.PriorityHigh.Size = New System.Drawing.Size(83, 21)
        Me.PriorityHigh.TabIndex = 2
        Me.PriorityHigh.Text = "High Priority"
        Me.PriorityHigh.UseVisualStyleBackColor = True
        '
        'PriorityMedium
        '
        Me.PriorityMedium.FlatAppearance.BorderSize = 0
        Me.PriorityMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityMedium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityMedium.Location = New System.Drawing.Point(22, 22)
        Me.PriorityMedium.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityMedium.Name = "PriorityMedium"
        Me.PriorityMedium.Size = New System.Drawing.Size(83, 21)
        Me.PriorityMedium.TabIndex = 3
        Me.PriorityMedium.Text = "MediumPriority"
        Me.PriorityMedium.UseVisualStyleBackColor = True
        '
        'PriorityLow
        '
        Me.PriorityLow.FlatAppearance.BorderSize = 0
        Me.PriorityLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriorityLow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PriorityLow.Location = New System.Drawing.Point(22, 43)
        Me.PriorityLow.Margin = New System.Windows.Forms.Padding(0)
        Me.PriorityLow.Name = "PriorityLow"
        Me.PriorityLow.Size = New System.Drawing.Size(83, 21)
        Me.PriorityLow.TabIndex = 4
        Me.PriorityLow.Text = "Low Priority"
        Me.PriorityLow.UseVisualStyleBackColor = True
        '
        'ImmutableLabel
        '
        Me.ImmutableLabel.AutoSize = True
        Me.ImmutableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImmutableLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ImmutableLabel.Location = New System.Drawing.Point(123, 3)
        Me.ImmutableLabel.Name = "ImmutableLabel"
        Me.ImmutableLabel.Size = New System.Drawing.Size(87, 16)
        Me.ImmutableLabel.TabIndex = 5
        Me.ImmutableLabel.Text = "Description"
        '
        'PDescription
        '
        Me.PDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PDescription.Location = New System.Drawing.Point(126, 23)
        Me.PDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.PDescription.Name = "PDescription"
        Me.PDescription.Size = New System.Drawing.Size(194, 40)
        Me.PDescription.TabIndex = 6
        Me.PDescription.Text = "Label1"
        '
        'PriorityPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 65)
        Me.Controls.Add(Me.PDescription)
        Me.Controls.Add(Me.ImmutableLabel)
        Me.Controls.Add(Me.PriorityLow)
        Me.Controls.Add(Me.PriorityMedium)
        Me.Controls.Add(Me.PriorityHigh)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SetPriorityButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PriorityPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PriorityPicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetPriorityButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents PriorityHigh As Button
    Friend WithEvents PriorityMedium As Button
    Friend WithEvents PriorityLow As Button
    Friend WithEvents ImmutableLabel As Label
    Friend WithEvents PDescription As Label
End Class
