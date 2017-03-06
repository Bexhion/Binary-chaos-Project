<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeMarkerDescription
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
        Me.Txt_Title = New System.Windows.Forms.TextBox()
        Me.Txt_Description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionPanel = New System.Windows.Forms.Panel()
        Me.PointsPanel = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DescriptionPanel.SuspendLayout()
        Me.PointsPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Title
        '
        Me.Txt_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Title.Location = New System.Drawing.Point(10, 9)
        Me.Txt_Title.Name = "Txt_Title"
        Me.Txt_Title.Size = New System.Drawing.Size(254, 22)
        Me.Txt_Title.TabIndex = 0
        Me.Txt_Title.Text = "Title"
        '
        'Txt_Description
        '
        Me.Txt_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Description.Location = New System.Drawing.Point(9, 33)
        Me.Txt_Description.Multiline = True
        Me.Txt_Description.Name = "Txt_Description"
        Me.Txt_Description.Size = New System.Drawing.Size(256, 20)
        Me.Txt_Description.TabIndex = 1
        Me.Txt_Description.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'DescriptionPanel
        '
        Me.DescriptionPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionPanel.Controls.Add(Me.Label1)
        Me.DescriptionPanel.Controls.Add(Me.Txt_Description)
        Me.DescriptionPanel.Location = New System.Drawing.Point(0, 45)
        Me.DescriptionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DescriptionPanel.Name = "DescriptionPanel"
        Me.DescriptionPanel.Size = New System.Drawing.Size(276, 56)
        Me.DescriptionPanel.TabIndex = 3
        '
        'PointsPanel
        '
        Me.PointsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PointsPanel.Controls.Add(Me.CheckBox1)
        Me.PointsPanel.Controls.Add(Me.Label2)
        Me.PointsPanel.Location = New System.Drawing.Point(0, 159)
        Me.PointsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PointsPanel.Name = "PointsPanel"
        Me.PointsPanel.Size = New System.Drawing.Size(276, 75)
        Me.PointsPanel.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(20, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(237, 26)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Points to accomplish"
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsPanel.Controls.Add(Me.Label4)
        Me.DetailsPanel.Controls.Add(Me.Label5)
        Me.DetailsPanel.Controls.Add(Me.Label3)
        Me.DetailsPanel.Location = New System.Drawing.Point(0, 101)
        Me.DetailsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(276, 58)
        Me.DetailsPanel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Details"
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 234)
        Me.ProgressPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(276, 50)
        Me.ProgressPanel.TabIndex = 5
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.Controls.Add(Me.Panel1)
        Me.TitlePanel.Controls.Add(Me.Txt_Title)
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(275, 45)
        Me.TitlePanel.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 45)
        Me.Panel1.TabIndex = 1
        '
        'TimeMarkerDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.PointsPanel)
        Me.Controls.Add(Me.DescriptionPanel)
        Me.Name = "TimeMarkerDescription"
        Me.Size = New System.Drawing.Size(276, 284)
        Me.DescriptionPanel.ResumeLayout(False)
        Me.DescriptionPanel.PerformLayout()
        Me.PointsPanel.ResumeLayout(False)
        Me.PointsPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_Title As TextBox
    Friend WithEvents Txt_Description As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionPanel As Panel
    Friend WithEvents PointsPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressPanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents Panel1 As Panel
End Class
