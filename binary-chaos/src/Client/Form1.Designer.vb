<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.user = New System.Windows.Forms.Button()
        Me.MainPage = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Planificação = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Help = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TimeMarkerDescription1 = New WindowsApplication1.TimeMarkerDescription()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.SystemColors.ControlText
        Me.user.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.user
        resources.ApplyResources(Me.user, "user")
        Me.user.FlatAppearance.BorderSize = 0
        Me.user.Name = "user"
        Me.user.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.MainPage.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.clog
        resources.ApplyResources(Me.MainPage, "MainPage")
        Me.MainPage.FlatAppearance.BorderSize = 0
        Me.MainPage.Name = "MainPage"
        Me.MainPage.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Edit, "Edit")
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Edit.Name = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Planificação
        '
        resources.ApplyResources(Me.Planificação, "Planificação")
        Me.Planificação.Name = "Planificação"
        Me.Planificação.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.Transparent
        Me.Add.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Add, "Add")
        Me.Add.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Add.Name = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Remove
        '
        Me.Remove.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Remove, "Remove")
        Me.Remove.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Remove.Name = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Help)
        Me.Panel1.Controls.Add(Me.Planificação)
        Me.Panel1.Controls.Add(Me.MainPage)
        Me.Panel1.Controls.Add(Me.user)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Help
        '
        Me.Help.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.help
        resources.ApplyResources(Me.Help, "Help")
        Me.Help.Name = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Name = "Label1"
        '
        'UsernameLabel
        '
        resources.ApplyResources(Me.UsernameLabel, "UsernameLabel")
        Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.UsernameLabel.Name = "UsernameLabel"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TimeMarkerDescription1
        '
        Me.TimeMarkerDescription1.AccomplishedPoints = Nothing
        Me.TimeMarkerDescription1.AccomplishedPointsNumber = 0
        Me.TimeMarkerDescription1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TimeMarkerDescription1.Description = ""
        Me.TimeMarkerDescription1.EditorMode = WindowsApplication1.CustomListBox.EditorMode.NONE
        Me.TimeMarkerDescription1.FullDateEnd = Nothing
        Me.TimeMarkerDescription1.FullDateStart = Nothing
        resources.ApplyResources(Me.TimeMarkerDescription1, "TimeMarkerDescription1")
        Me.TimeMarkerDescription1.Name = "TimeMarkerDescription1"
        Me.TimeMarkerDescription1.Points = Nothing
        Me.TimeMarkerDescription1.PointsNumber = 0
        Me.TimeMarkerDescription1.Priority = WindowsApplication1.CustomListBox.Priority.NONE
        Me.TimeMarkerDescription1.Progress = 0R
        Me.TimeMarkerDescription1.RenderPointsProgress = False
        Me.TimeMarkerDescription1.ThisTimeMarker = Nothing
        Me.TimeMarkerDescription1.Title = ""
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.TimeMarkerDescription1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As Button
    Friend WithEvents MainPage As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Planificação As Button
    Friend WithEvents Add As Button
    Friend WithEvents Remove As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Help As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TimeMarkerDescription1 As TimeMarkerDescription
End Class
