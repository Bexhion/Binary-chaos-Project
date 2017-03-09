<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FakeInputBox
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
        Me.Input = New System.Windows.Forms.RichTextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Input.ForeColor = System.Drawing.Color.Gray
        Me.Input.Location = New System.Drawing.Point(12, 9)
        Me.Input.Margin = New System.Windows.Forms.Padding(0)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(332, 42)
        Me.Input.TabIndex = 2
        Me.Input.Text = "ADD A CHECK BOX"
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddButton.Location = New System.Drawing.Point(357, 7)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(50, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(357, 30)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'FakeInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 61)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FakeInputBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Input As RichTextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CloseButton As Button
End Class
