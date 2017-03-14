<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.UserBoxTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Help = New System.Windows.Forms.Button()
        Me.FakeTop = New System.Windows.Forms.Panel()
        Me.UserBox = New System.Windows.Forms.Panel()
        Me.Username = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Greeting = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.FakeIcon = New System.Windows.Forms.PictureBox()
        Me.WindowMinimizedIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.AddMarker = New System.Windows.Forms.Button()
        Me.EditMarker = New System.Windows.Forms.Button()
        Me.RemoveMarker = New System.Windows.Forms.Button()
        Me.SetMarker = New System.Windows.Forms.Button()
        Me.CancelMarker = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TimeMarkerDescription1 = New WindowsApplication1.TimeMarkerDescription()
        Me.CustomListBox1 = New WindowsApplication1.CustomListBox()
        Me.FakeTop.SuspendLayout()
        Me.UserBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FakeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserBoxTooltip
        '
        Me.UserBoxTooltip.IsBalloon = True
        Me.UserBoxTooltip.ToolTipTitle = "Username"
        '
        'Help
        '
        Me.Help.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.help
        resources.ApplyResources(Me.Help, "Help")
        Me.Help.FlatAppearance.BorderSize = 0
        Me.Help.Name = "Help"
        Me.UserBoxTooltip.SetToolTip(Me.Help, resources.GetString("Help.ToolTip"))
        Me.Help.UseVisualStyleBackColor = True
        '
        'FakeTop
        '
        Me.FakeTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.FakeTop.Controls.Add(Me.UserBox)
        Me.FakeTop.Controls.Add(Me.Help)
        Me.FakeTop.Controls.Add(Me.MinimizeButton)
        Me.FakeTop.Controls.Add(Me.CloseButton)
        Me.FakeTop.Controls.Add(Me.Title)
        Me.FakeTop.Controls.Add(Me.FakeIcon)
        resources.ApplyResources(Me.FakeTop, "FakeTop")
        Me.FakeTop.Name = "FakeTop"
        '
        'UserBox
        '
        resources.ApplyResources(Me.UserBox, "UserBox")
        Me.UserBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.UserBox.Controls.Add(Me.Username)
        Me.UserBox.Controls.Add(Me.PictureBox1)
        Me.UserBox.Controls.Add(Me.Greeting)
        Me.UserBox.Name = "UserBox"
        '
        'Username
        '
        resources.ApplyResources(Me.Username, "Username")
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Username.Name = "Username"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.user
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Greeting
        '
        resources.ApplyResources(Me.Greeting, "Greeting")
        Me.Greeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Greeting.Name = "Greeting"
        '
        'MinimizeButton
        '
        resources.ApplyResources(Me.MinimizeButton, "MinimizeButton")
        Me.MinimizeButton.ForeColor = System.Drawing.Color.Silver
        Me.MinimizeButton.Name = "MinimizeButton"
        '
        'CloseButton
        '
        resources.ApplyResources(Me.CloseButton, "CloseButton")
        Me.CloseButton.ForeColor = System.Drawing.Color.Silver
        Me.CloseButton.Name = "CloseButton"
        '
        'Title
        '
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.ForeColor = System.Drawing.Color.Silver
        Me.Title.Name = "Title"
        '
        'FakeIcon
        '
        Me.FakeIcon.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sloth1main
        resources.ApplyResources(Me.FakeIcon, "FakeIcon")
        Me.FakeIcon.Name = "FakeIcon"
        Me.FakeIcon.TabStop = False
        '
        'WindowMinimizedIcon
        '
        resources.ApplyResources(Me.WindowMinimizedIcon, "WindowMinimizedIcon")
        '
        'AddMarker
        '
        resources.ApplyResources(Me.AddMarker, "AddMarker")
        Me.AddMarker.FlatAppearance.BorderSize = 0
        Me.AddMarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddMarker.Name = "AddMarker"
        Me.AddMarker.UseVisualStyleBackColor = True
        '
        'EditMarker
        '
        resources.ApplyResources(Me.EditMarker, "EditMarker")
        Me.EditMarker.FlatAppearance.BorderSize = 0
        Me.EditMarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditMarker.Name = "EditMarker"
        Me.EditMarker.UseVisualStyleBackColor = True
        '
        'RemoveMarker
        '
        resources.ApplyResources(Me.RemoveMarker, "RemoveMarker")
        Me.RemoveMarker.FlatAppearance.BorderSize = 0
        Me.RemoveMarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RemoveMarker.Name = "RemoveMarker"
        Me.RemoveMarker.UseVisualStyleBackColor = True
        '
        'SetMarker
        '
        resources.ApplyResources(Me.SetMarker, "SetMarker")
        Me.SetMarker.FlatAppearance.BorderSize = 0
        Me.SetMarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SetMarker.Name = "SetMarker"
        Me.SetMarker.UseVisualStyleBackColor = True
        '
        'CancelMarker
        '
        resources.ApplyResources(Me.CancelMarker, "CancelMarker")
        Me.CancelMarker.FlatAppearance.BorderSize = 0
        Me.CancelMarker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelMarker.Name = "CancelMarker"
        Me.CancelMarker.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'TimeMarkerDescription1
        '
        Me.TimeMarkerDescription1.AccomplishedPoints = Nothing
        Me.TimeMarkerDescription1.AccomplishedPointsNumber = 0
        Me.TimeMarkerDescription1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TimeMarkerDescription1.Description = "Add a description"
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
        Me.TimeMarkerDescription1.Title = "ADD A TITLE"
        '
        'CustomListBox1
        '
        Me.CustomListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CustomListBox1.CurrentEditorMode = WindowsApplication1.CustomListBox.EditorMode.NONE
        Me.CustomListBox1.descriptor = Nothing
        resources.ApplyResources(Me.CustomListBox1, "CustomListBox1")
        Me.CustomListBox1.Name = "CustomListBox1"
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.CustomListBox1)
        Me.Controls.Add(Me.TimeMarkerDescription1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CancelMarker)
        Me.Controls.Add(Me.SetMarker)
        Me.Controls.Add(Me.RemoveMarker)
        Me.Controls.Add(Me.EditMarker)
        Me.Controls.Add(Me.AddMarker)
        Me.Controls.Add(Me.FakeTop)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.FakeTop.ResumeLayout(False)
        Me.FakeTop.PerformLayout()
        Me.UserBox.ResumeLayout(False)
        Me.UserBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FakeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Help As Button
    Friend WithEvents UserBoxTooltip As ToolTip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FakeTop As Panel
    Friend WithEvents Title As Label
    Friend WithEvents FakeIcon As PictureBox
    Friend WithEvents WindowMinimizedIcon As NotifyIcon
    Friend WithEvents MinimizeButton As Label
    Friend WithEvents CloseButton As Label
    Friend WithEvents UserBox As Panel
    Friend WithEvents Greeting As Label
    Friend WithEvents Username As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddMarker As Button
    Friend WithEvents EditMarker As Button
    Friend WithEvents RemoveMarker As Button
    Friend WithEvents SetMarker As Button
    Friend WithEvents CancelMarker As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimeMarkerDescription1 As TimeMarkerDescription
    Friend WithEvents CustomListBox1 As CustomListBox
End Class
