<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginUser))
        Me.Username = New System.Windows.Forms.TextBox()
        Me.SignIn = New System.Windows.Forms.Label()
        Me.RecoverPasswordLabel = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.FakeTop = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.IconPic = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.FakeTop.SuspendLayout()
        CType(Me.IconPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(56, 109)
        Me.Username.Margin = New System.Windows.Forms.Padding(0)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(152, 20)
        Me.Username.TabIndex = 2
        Me.Username.Text = "USERNAME"
        '
        'SignIn
        '
        Me.SignIn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SignIn.AutoSize = True
        Me.SignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SignIn.Location = New System.Drawing.Point(102, 245)
        Me.SignIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(56, 16)
        Me.SignIn.TabIndex = 6
        Me.SignIn.Text = "Sign Up"
        '
        'RecoverPasswordLabel
        '
        Me.RecoverPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecoverPasswordLabel.AutoSize = True
        Me.RecoverPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RecoverPasswordLabel.Location = New System.Drawing.Point(111, 168)
        Me.RecoverPasswordLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.RecoverPasswordLabel.Name = "RecoverPasswordLabel"
        Me.RecoverPasswordLabel.Size = New System.Drawing.Size(97, 13)
        Me.RecoverPasswordLabel.TabIndex = 7
        Me.RecoverPasswordLabel.Text = "Recover Password"
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Login.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Login.FlatAppearance.BorderSize = 0
        Me.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Login.Location = New System.Drawing.Point(76, 201)
        Me.Login.Margin = New System.Windows.Forms.Padding(2)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(109, 28)
        Me.Login.TabIndex = 8
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'FakeTop
        '
        Me.FakeTop.Controls.Add(Me.CloseButton)
        Me.FakeTop.Controls.Add(Me.IconPic)
        Me.FakeTop.Controls.Add(Me.Title)
        Me.FakeTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.FakeTop.Location = New System.Drawing.Point(0, 0)
        Me.FakeTop.Margin = New System.Windows.Forms.Padding(0)
        Me.FakeTop.Name = "FakeTop"
        Me.FakeTop.Size = New System.Drawing.Size(261, 89)
        Me.FakeTop.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.AutoSize = True
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(234, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(15, 13)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "X"
        '
        'IconPic
        '
        Me.IconPic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sloth1sub1
        Me.IconPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPic.Location = New System.Drawing.Point(8, 24)
        Me.IconPic.Margin = New System.Windows.Forms.Padding(0)
        Me.IconPic.Name = "IconPic"
        Me.IconPic.Size = New System.Drawing.Size(60, 60)
        Me.IconPic.TabIndex = 2
        Me.IconPic.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Title.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Title.Location = New System.Drawing.Point(68, 38)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(184, 32)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Sloth no more"
        '
        'Password
        '
        Me.Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(56, 144)
        Me.Password.Margin = New System.Windows.Forms.Padding(0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(152, 20)
        Me.Password.TabIndex = 3
        Me.Password.Text = "PASSWORD"
        '
        'LoginUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(261, 285)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.FakeTop)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.RecoverPasswordLabel)
        Me.Controls.Add(Me.SignIn)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoginUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.FakeTop.ResumeLayout(False)
        Me.FakeTop.PerformLayout()
        CType(Me.IconPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As TextBox
    Friend WithEvents SignIn As Label
    Friend WithEvents RecoverPasswordLabel As Label
    Friend WithEvents Login As Button
    Friend WithEvents FakeTop As Panel
    Friend WithEvents Password As TextBox
    Friend WithEvents IconPic As PictureBox
    Friend WithEvents CloseButton As Label
    Friend WithEvents Title As Label
End Class
