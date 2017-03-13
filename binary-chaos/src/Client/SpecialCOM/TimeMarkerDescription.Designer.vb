<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimeMarkerDescription
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Descriptor = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.TxtboxTitle = New System.Windows.Forms.RichTextBox()
        Me.PanelDescription = New System.Windows.Forms.Panel()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.TxtboxDesc = New System.Windows.Forms.RichTextBox()
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.ButtonStartDate = New System.Windows.Forms.Button()
        Me.ButtonPriority = New System.Windows.Forms.Button()
        Me.ButtonEndDate = New System.Windows.Forms.Button()
        Me.PanelStart = New System.Windows.Forms.Panel()
        Me.LabelPriority = New System.Windows.Forms.Label()
        Me.LabelEndDate = New System.Windows.Forms.Label()
        Me.LabelStartDate = New System.Windows.Forms.Label()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.PanelPoints = New System.Windows.Forms.Panel()
        Me.ButtonRemovePoint = New System.Windows.Forms.Button()
        Me.ButtonAddPoint = New System.Windows.Forms.Button()
        Me.LabelPoints = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Descriptor.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.PanelDescription.SuspendLayout()
        Me.PanelDetails.SuspendLayout()
        Me.PanelPoints.SuspendLayout()
        Me.SuspendLayout()
        '
        'Descriptor
        '
        Me.Descriptor.AutoScroll = True
        Me.Descriptor.BackColor = System.Drawing.Color.Transparent
        Me.Descriptor.Controls.Add(Me.PanelTitle)
        Me.Descriptor.Controls.Add(Me.PanelDescription)
        Me.Descriptor.Controls.Add(Me.PanelDetails)
        Me.Descriptor.Controls.Add(Me.PanelPoints)
        Me.Descriptor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Descriptor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Descriptor.Location = New System.Drawing.Point(0, 0)
        Me.Descriptor.Name = "Descriptor"
        Me.Descriptor.Size = New System.Drawing.Size(437, 487)
        Me.Descriptor.TabIndex = 0
        Me.Descriptor.WrapContents = False
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.TxtboxTitle)
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(420, 44)
        Me.PanelTitle.TabIndex = 0
        '
        'TxtboxTitle
        '
        Me.TxtboxTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TxtboxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtboxTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtboxTitle.Location = New System.Drawing.Point(9, 10)
        Me.TxtboxTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtboxTitle.Name = "TxtboxTitle"
        Me.TxtboxTitle.ReadOnly = True
        Me.TxtboxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TxtboxTitle.Size = New System.Drawing.Size(402, 25)
        Me.TxtboxTitle.TabIndex = 0
        Me.TxtboxTitle.Text = "Title"
        '
        'PanelDescription
        '
        Me.PanelDescription.Controls.Add(Me.LabelDesc)
        Me.PanelDescription.Controls.Add(Me.TxtboxDesc)
        Me.PanelDescription.Location = New System.Drawing.Point(0, 44)
        Me.PanelDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelDescription.Name = "PanelDescription"
        Me.PanelDescription.Size = New System.Drawing.Size(420, 58)
        Me.PanelDescription.TabIndex = 2
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.BackColor = System.Drawing.Color.Transparent
        Me.LabelDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabelDesc.Location = New System.Drawing.Point(5, 2)
        Me.LabelDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(104, 24)
        Me.LabelDesc.TabIndex = 1
        Me.LabelDesc.Text = "Description"
        '
        'TxtboxDesc
        '
        Me.TxtboxDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TxtboxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtboxDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtboxDesc.Location = New System.Drawing.Point(9, 29)
        Me.TxtboxDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtboxDesc.Name = "TxtboxDesc"
        Me.TxtboxDesc.ReadOnly = True
        Me.TxtboxDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TxtboxDesc.Size = New System.Drawing.Size(402, 18)
        Me.TxtboxDesc.TabIndex = 0
        Me.TxtboxDesc.Text = "Description"
        '
        'PanelDetails
        '
        Me.PanelDetails.BackColor = System.Drawing.Color.Transparent
        Me.PanelDetails.Controls.Add(Me.ButtonStartDate)
        Me.PanelDetails.Controls.Add(Me.ButtonPriority)
        Me.PanelDetails.Controls.Add(Me.ButtonEndDate)
        Me.PanelDetails.Controls.Add(Me.PanelStart)
        Me.PanelDetails.Controls.Add(Me.LabelPriority)
        Me.PanelDetails.Controls.Add(Me.LabelEndDate)
        Me.PanelDetails.Controls.Add(Me.LabelStartDate)
        Me.PanelDetails.Controls.Add(Me.LabelDetails)
        Me.PanelDetails.Location = New System.Drawing.Point(0, 102)
        Me.PanelDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(420, 95)
        Me.PanelDetails.TabIndex = 3
        '
        'ButtonStartDate
        '
        Me.ButtonStartDate.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStartDate.FlatAppearance.BorderSize = 0
        Me.ButtonStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonStartDate.Location = New System.Drawing.Point(106, 23)
        Me.ButtonStartDate.Name = "ButtonStartDate"
        Me.ButtonStartDate.Size = New System.Drawing.Size(32, 20)
        Me.ButtonStartDate.TabIndex = 6
        Me.ButtonStartDate.Text = "Set"
        Me.ButtonStartDate.UseVisualStyleBackColor = False
        '
        'ButtonPriority
        '
        Me.ButtonPriority.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPriority.FlatAppearance.BorderSize = 0
        Me.ButtonPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPriority.Location = New System.Drawing.Point(74, 67)
        Me.ButtonPriority.Name = "ButtonPriority"
        Me.ButtonPriority.Size = New System.Drawing.Size(32, 20)
        Me.ButtonPriority.TabIndex = 8
        Me.ButtonPriority.Text = "Set"
        Me.ButtonPriority.UseVisualStyleBackColor = False
        '
        'ButtonEndDate
        '
        Me.ButtonEndDate.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEndDate.FlatAppearance.BorderSize = 0
        Me.ButtonEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEndDate.Location = New System.Drawing.Point(97, 45)
        Me.ButtonEndDate.Name = "ButtonEndDate"
        Me.ButtonEndDate.Size = New System.Drawing.Size(32, 20)
        Me.ButtonEndDate.TabIndex = 7
        Me.ButtonEndDate.Text = "Set"
        Me.ButtonEndDate.UseVisualStyleBackColor = False
        '
        'PanelStart
        '
        Me.PanelStart.Location = New System.Drawing.Point(320, 17)
        Me.PanelStart.Name = "PanelStart"
        Me.PanelStart.Size = New System.Drawing.Size(60, 60)
        Me.PanelStart.TabIndex = 5
        '
        'LabelPriority
        '
        Me.LabelPriority.AutoSize = True
        Me.LabelPriority.BackColor = System.Drawing.Color.Transparent
        Me.LabelPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPriority.ForeColor = System.Drawing.Color.Silver
        Me.LabelPriority.Location = New System.Drawing.Point(24, 69)
        Me.LabelPriority.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPriority.Name = "LabelPriority"
        Me.LabelPriority.Size = New System.Drawing.Size(47, 15)
        Me.LabelPriority.TabIndex = 4
        Me.LabelPriority.Text = "Priority:"
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEndDate.ForeColor = System.Drawing.Color.Silver
        Me.LabelEndDate.Location = New System.Drawing.Point(24, 47)
        Me.LabelEndDate.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(70, 15)
        Me.LabelEndDate.TabIndex = 3
        Me.LabelEndDate.Text = "Finish date:"
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStartDate.ForeColor = System.Drawing.Color.Silver
        Me.LabelStartDate.Location = New System.Drawing.Point(24, 25)
        Me.LabelStartDate.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(79, 15)
        Me.LabelStartDate.TabIndex = 2
        Me.LabelStartDate.Text = "Starting date:"
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.BackColor = System.Drawing.Color.Transparent
        Me.LabelDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDetails.ForeColor = System.Drawing.Color.Silver
        Me.LabelDetails.Location = New System.Drawing.Point(24, 5)
        Me.LabelDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(57, 16)
        Me.LabelDetails.TabIndex = 1
        Me.LabelDetails.Text = "Details"
        '
        'PanelPoints
        '
        Me.PanelPoints.BackColor = System.Drawing.Color.Transparent
        Me.PanelPoints.Controls.Add(Me.ButtonRemovePoint)
        Me.PanelPoints.Controls.Add(Me.ButtonAddPoint)
        Me.PanelPoints.Controls.Add(Me.LabelPoints)
        Me.PanelPoints.Location = New System.Drawing.Point(0, 197)
        Me.PanelPoints.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPoints.Name = "PanelPoints"
        Me.PanelPoints.Size = New System.Drawing.Size(420, 40)
        Me.PanelPoints.TabIndex = 5
        '
        'ButtonRemovePoint
        '
        Me.ButtonRemovePoint.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRemovePoint.FlatAppearance.BorderSize = 0
        Me.ButtonRemovePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemovePoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemovePoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRemovePoint.Location = New System.Drawing.Point(199, 6)
        Me.ButtonRemovePoint.Name = "ButtonRemovePoint"
        Me.ButtonRemovePoint.Size = New System.Drawing.Size(58, 20)
        Me.ButtonRemovePoint.TabIndex = 10
        Me.ButtonRemovePoint.Text = "Remove"
        Me.ButtonRemovePoint.UseVisualStyleBackColor = False
        '
        'ButtonAddPoint
        '
        Me.ButtonAddPoint.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAddPoint.FlatAppearance.BorderSize = 0
        Me.ButtonAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddPoint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddPoint.Location = New System.Drawing.Point(157, 6)
        Me.ButtonAddPoint.Name = "ButtonAddPoint"
        Me.ButtonAddPoint.Size = New System.Drawing.Size(36, 20)
        Me.ButtonAddPoint.TabIndex = 9
        Me.ButtonAddPoint.Text = "Add"
        Me.ButtonAddPoint.UseVisualStyleBackColor = False
        '
        'LabelPoints
        '
        Me.LabelPoints.AutoSize = True
        Me.LabelPoints.BackColor = System.Drawing.Color.Transparent
        Me.LabelPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LabelPoints.Location = New System.Drawing.Point(5, 2)
        Me.LabelPoints.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPoints.Name = "LabelPoints"
        Me.LabelPoints.Size = New System.Drawing.Size(149, 24)
        Me.LabelPoints.TabIndex = 2
        Me.LabelPoints.Text = "Goals to achieve"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TimeMarkerDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Controls.Add(Me.Descriptor)
        Me.Name = "TimeMarkerDescription"
        Me.Size = New System.Drawing.Size(437, 487)
        Me.Descriptor.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelDescription.ResumeLayout(False)
        Me.PanelDescription.PerformLayout()
        Me.PanelDetails.ResumeLayout(False)
        Me.PanelDetails.PerformLayout()
        Me.PanelPoints.ResumeLayout(False)
        Me.PanelPoints.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Descriptor As FlowLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents TxtboxTitle As RichTextBox
    Friend WithEvents PanelDescription As Panel
    Friend WithEvents TxtboxDesc As RichTextBox
    Friend WithEvents LabelDesc As Label
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents LabelPriority As Label
    Friend WithEvents LabelEndDate As Label
    Friend WithEvents LabelStartDate As Label
    Friend WithEvents LabelDetails As Label
    Friend WithEvents PanelStart As Panel
    Friend WithEvents ButtonStartDate As Button
    Friend WithEvents ButtonPriority As Button
    Friend WithEvents ButtonEndDate As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PanelPoints As Panel
    Friend WithEvents ButtonRemovePoint As Button
    Friend WithEvents ButtonAddPoint As Button
    Friend WithEvents LabelPoints As Label
End Class
