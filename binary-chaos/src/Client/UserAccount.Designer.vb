<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccount
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
        Me.ChangePicture = New System.Windows.Forms.Label()
        Me.UserDesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordDesc = New System.Windows.Forms.Label()
        Me.MarkerDelete = New System.Windows.Forms.Label()
        Me.PasswordChange = New System.Windows.Forms.Label()
        Me.UserDelete = New System.Windows.Forms.Label()
        Me.AccountManagement = New System.Windows.Forms.Label()
        Me.RemoveProgram = New System.Windows.Forms.Label()
        Me.AddProgram = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Management = New System.Windows.Forms.Label()
        Me.Markers = New System.Windows.Forms.Label()
        Me.Fitness = New System.Windows.Forms.Label()
        Me.LogOut = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.PictureBox()
        Me.Photo = New System.Windows.Forms.PictureBox()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChangePicture
        '
        Me.ChangePicture.AutoSize = True
        Me.ChangePicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChangePicture.Location = New System.Drawing.Point(17, 216)
        Me.ChangePicture.Name = "ChangePicture"
        Me.ChangePicture.Size = New System.Drawing.Size(92, 16)
        Me.ChangePicture.TabIndex = 39
        Me.ChangePicture.Text = "Change photo"
        '
        'UserDesc
        '
        Me.UserDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UserDesc.Location = New System.Drawing.Point(22, 568)
        Me.UserDesc.Name = "UserDesc"
        Me.UserDesc.Size = New System.Drawing.Size(405, 49)
        Me.UserDesc.TabIndex = 37
        Me.UserDesc.Text = "Warning: deleting a user is permanent.  This deletes all markers and settings of " &
    "a user." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Deleting a user's current markers will also delete all running markers "
        '
        'PasswordDesc
        '
        Me.PasswordDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PasswordDesc.Location = New System.Drawing.Point(22, 485)
        Me.PasswordDesc.Name = "PasswordDesc"
        Me.PasswordDesc.Size = New System.Drawing.Size(308, 25)
        Me.PasswordDesc.TabIndex = 36
        Me.PasswordDesc.Text = "If you change your password, you'll have to relog"
        '
        'MarkerDelete
        '
        Me.MarkerDelete.AutoSize = True
        Me.MarkerDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkerDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MarkerDelete.Location = New System.Drawing.Point(22, 508)
        Me.MarkerDelete.Name = "MarkerDelete"
        Me.MarkerDelete.Size = New System.Drawing.Size(135, 16)
        Me.MarkerDelete.TabIndex = 35
        Me.MarkerDelete.Text = "Clear current markers"
        '
        'PasswordChange
        '
        Me.PasswordChange.AutoSize = True
        Me.PasswordChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PasswordChange.Location = New System.Drawing.Point(22, 469)
        Me.PasswordChange.Name = "PasswordChange"
        Me.PasswordChange.Size = New System.Drawing.Size(117, 16)
        Me.PasswordChange.TabIndex = 34
        Me.PasswordChange.Text = "Change password"
        '
        'UserDelete
        '
        Me.UserDelete.AutoSize = True
        Me.UserDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UserDelete.Location = New System.Drawing.Point(22, 552)
        Me.UserDelete.Name = "UserDelete"
        Me.UserDelete.Size = New System.Drawing.Size(120, 16)
        Me.UserDelete.TabIndex = 33
        Me.UserDelete.Text = "Delete current user"
        '
        'AccountManagement
        '
        Me.AccountManagement.AutoSize = True
        Me.AccountManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountManagement.ForeColor = System.Drawing.Color.White
        Me.AccountManagement.Location = New System.Drawing.Point(13, 434)
        Me.AccountManagement.Name = "AccountManagement"
        Me.AccountManagement.Size = New System.Drawing.Size(196, 24)
        Me.AccountManagement.TabIndex = 32
        Me.AccountManagement.Text = "Account management"
        '
        'RemoveProgram
        '
        Me.RemoveProgram.AutoSize = True
        Me.RemoveProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RemoveProgram.Location = New System.Drawing.Point(120, 401)
        Me.RemoveProgram.Name = "RemoveProgram"
        Me.RemoveProgram.Size = New System.Drawing.Size(114, 16)
        Me.RemoveProgram.TabIndex = 31
        Me.RemoveProgram.Text = "Remove program"
        '
        'AddProgram
        '
        Me.AddProgram.AutoSize = True
        Me.AddProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddProgram.Location = New System.Drawing.Point(22, 401)
        Me.AddProgram.Name = "AddProgram"
        Me.AddProgram.Size = New System.Drawing.Size(87, 16)
        Me.AddProgram.TabIndex = 30
        Me.AddProgram.Text = "Add program"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(25, 280)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(15)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(402, 116)
        Me.FlowLayoutPanel1.TabIndex = 29
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'Management
        '
        Me.Management.AutoSize = True
        Me.Management.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Management.ForeColor = System.Drawing.Color.White
        Me.Management.Location = New System.Drawing.Point(13, 247)
        Me.Management.Name = "Management"
        Me.Management.Size = New System.Drawing.Size(256, 24)
        Me.Management.TabIndex = 28
        Me.Management.Text = "Manage blacklisted programs"
        '
        'Markers
        '
        Me.Markers.AutoSize = True
        Me.Markers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Markers.ForeColor = System.Drawing.Color.White
        Me.Markers.Location = New System.Drawing.Point(174, 169)
        Me.Markers.Name = "Markers"
        Me.Markers.Size = New System.Drawing.Size(127, 20)
        Me.Markers.TabIndex = 27
        Me.Markers.Text = "Current markers:"
        '
        'Fitness
        '
        Me.Fitness.AutoSize = True
        Me.Fitness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fitness.ForeColor = System.Drawing.Color.White
        Me.Fitness.Location = New System.Drawing.Point(174, 137)
        Me.Fitness.Name = "Fitness"
        Me.Fitness.Size = New System.Drawing.Size(65, 20)
        Me.Fitness.TabIndex = 25
        Me.Fitness.Text = "Fitness:"
        '
        'LogOut
        '
        Me.LogOut.AutoSize = True
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LogOut.Location = New System.Drawing.Point(175, 89)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(52, 16)
        Me.LogOut.TabIndex = 24
        Me.LogOut.Text = "Log out"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(174, 69)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(87, 20)
        Me.Username.TabIndex = 23
        Me.Username.Text = "Username:"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(53, 16)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(98, 29)
        Me.Title.TabIndex = 21
        Me.Title.Text = "Account"
        '
        'Back
        '
        Me.Back.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.userbackbutton
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.Location = New System.Drawing.Point(17, 16)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(30, 30)
        Me.Back.TabIndex = 22
        Me.Back.TabStop = False
        '
        'Photo
        '
        Me.Photo.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Photo.Location = New System.Drawing.Point(17, 63)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(150, 150)
        Me.Photo.TabIndex = 20
        Me.Photo.TabStop = False
        '
        'UserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 608)
        Me.Controls.Add(Me.ChangePicture)
        Me.Controls.Add(Me.UserDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordDesc)
        Me.Controls.Add(Me.MarkerDelete)
        Me.Controls.Add(Me.PasswordChange)
        Me.Controls.Add(Me.UserDelete)
        Me.Controls.Add(Me.AccountManagement)
        Me.Controls.Add(Me.RemoveProgram)
        Me.Controls.Add(Me.AddProgram)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Management)
        Me.Controls.Add(Me.Markers)
        Me.Controls.Add(Me.Fitness)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Photo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "UserAccount"
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChangePicture As Label
    Friend WithEvents UserDesc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordDesc As Label
    Friend WithEvents MarkerDelete As Label
    Friend WithEvents PasswordChange As Label
    Friend WithEvents UserDelete As Label
    Friend WithEvents AccountManagement As Label
    Friend WithEvents RemoveProgram As Label
    Friend WithEvents AddProgram As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Management As Label
    Friend WithEvents Markers As Label
    Friend WithEvents Fitness As Label
    Friend WithEvents LogOut As Label
    Friend WithEvents Username As Label
    Friend WithEvents Back As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Photo As PictureBox
End Class
