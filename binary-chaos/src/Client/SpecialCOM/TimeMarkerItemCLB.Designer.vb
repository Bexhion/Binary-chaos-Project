<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimeMarkerItemCLB
    Inherits System.Windows.Forms.UserControl

    Private Sub InitializeComponent()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Desc = New System.Windows.Forms.Label()
        Me.Points1 = New WindowsApplication1.Points()
        Me.FullDate1 = New WindowsApplication1.FullDate()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Title.AutoEllipsis = True
        Me.Label_Title.BackColor = System.Drawing.Color.Transparent
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.ForeColor = System.Drawing.Color.White
        Me.Label_Title.Location = New System.Drawing.Point(74, 9)
        Me.Label_Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(209, 24)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "This is a title of a time marker!"
        '
        'Label_Desc
        '
        Me.Label_Desc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Desc.AutoEllipsis = True
        Me.Label_Desc.BackColor = System.Drawing.Color.Transparent
        Me.Label_Desc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label_Desc.Location = New System.Drawing.Point(76, 33)
        Me.Label_Desc.Margin = New System.Windows.Forms.Padding(0)
        Me.Label_Desc.Name = "Label_Desc"
        Me.Label_Desc.Size = New System.Drawing.Size(207, 31)
        Me.Label_Desc.TabIndex = 1
        Me.Label_Desc.Text = "This is a description. It will be used to describe a certain time marker"
        '
        'Points1
        '
        Me.Points1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Points1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Points1.DoRenderOutline = True
        Me.Points1.Location = New System.Drawing.Point(60, 0)
        Me.Points1.Margin = New System.Windows.Forms.Padding(0)
        Me.Points1.Name = "Points1"
        Me.Points1.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Points1.PointCount = 0
        Me.Points1.Size = New System.Drawing.Size(12, 70)
        Me.Points1.TabIndex = 2
        '
        'FullDate1
        '
        Me.FullDate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FullDate1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FullDate1.ConstantOverlay = False
        Me.FullDate1.DoRenderOutline = True
        Me.FullDate1.FullDate = Nothing
        Me.FullDate1.Location = New System.Drawing.Point(0, 0)
        Me.FullDate1.Margin = New System.Windows.Forms.Padding(0)
        Me.FullDate1.Name = "FullDate1"
        Me.FullDate1.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FullDate1.OverlayMethod = Nothing
        Me.FullDate1.Size = New System.Drawing.Size(60, 70)
        Me.FullDate1.TabIndex = 3
        Me.FullDate1.UseOverlay = False
        '
        'TimeMarkerItemCLB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.FullDate1)
        Me.Controls.Add(Me.Points1)
        Me.Controls.Add(Me.Label_Desc)
        Me.Controls.Add(Me.Label_Title)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TimeMarkerItemCLB"
        Me.Size = New System.Drawing.Size(300, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Desc As Label
    Friend WithEvents Points1 As Points
    Friend WithEvents FullDate1 As FullDate
End Class
