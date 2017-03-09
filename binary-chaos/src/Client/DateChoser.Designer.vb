<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateChoser
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
        Me.Day = New System.Windows.Forms.Panel()
        Me.DDay = New System.Windows.Forms.Label()
        Me.CDay = New System.Windows.Forms.Label()
        Me.Month = New System.Windows.Forms.Panel()
        Me.DMonth = New System.Windows.Forms.Label()
        Me.CMonth = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.Panel()
        Me.DYear = New System.Windows.Forms.Label()
        Me.CYear = New System.Windows.Forms.Label()
        Me.Hour = New System.Windows.Forms.Panel()
        Me.DHour = New System.Windows.Forms.Label()
        Me.CHour = New System.Windows.Forms.Label()
        Me.YearDec = New System.Windows.Forms.Button()
        Me.HourDec = New System.Windows.Forms.Button()
        Me.Minutes = New System.Windows.Forms.Panel()
        Me.DMinute = New System.Windows.Forms.Label()
        Me.CMinute = New System.Windows.Forms.Label()
        Me.MonthDec = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SetDate = New System.Windows.Forms.Button()
        Me.DayDc = New System.Windows.Forms.Button()
        Me.MinuteDc = New System.Windows.Forms.Button()
        Me.DayInc = New System.Windows.Forms.Button()
        Me.MonthDc = New System.Windows.Forms.Button()
        Me.YearDc = New System.Windows.Forms.Button()
        Me.HourDc = New System.Windows.Forms.Button()
        Me.MonthInc = New System.Windows.Forms.Button()
        Me.YearInc = New System.Windows.Forms.Button()
        Me.HourInc = New System.Windows.Forms.Button()
        Me.MinuteInc = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Day.SuspendLayout()
        Me.Month.SuspendLayout()
        Me.Year.SuspendLayout()
        Me.Hour.SuspendLayout()
        Me.Minutes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Day
        '
        Me.Day.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Day.Controls.Add(Me.DDay)
        Me.Day.Controls.Add(Me.CDay)
        Me.Day.Location = New System.Drawing.Point(5, 28)
        Me.Day.Margin = New System.Windows.Forms.Padding(0)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(65, 65)
        Me.Day.TabIndex = 0
        '
        'DDay
        '
        Me.DDay.AutoSize = True
        Me.DDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDay.ForeColor = System.Drawing.Color.White
        Me.DDay.Location = New System.Drawing.Point(18, 49)
        Me.DDay.Name = "DDay"
        Me.DDay.Size = New System.Drawing.Size(29, 13)
        Me.DDay.TabIndex = 0
        Me.DDay.Text = "DAY"
        '
        'CDay
        '
        Me.CDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDay.ForeColor = System.Drawing.Color.White
        Me.CDay.Location = New System.Drawing.Point(0, 0)
        Me.CDay.Name = "CDay"
        Me.CDay.Size = New System.Drawing.Size(65, 65)
        Me.CDay.TabIndex = 1
        Me.CDay.Text = "00"
        Me.CDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Month
        '
        Me.Month.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Month.Controls.Add(Me.DMonth)
        Me.Month.Controls.Add(Me.CMonth)
        Me.Month.Location = New System.Drawing.Point(77, 28)
        Me.Month.Margin = New System.Windows.Forms.Padding(0)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(65, 65)
        Me.Month.TabIndex = 1
        '
        'DMonth
        '
        Me.DMonth.AutoSize = True
        Me.DMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMonth.ForeColor = System.Drawing.Color.White
        Me.DMonth.Location = New System.Drawing.Point(9, 49)
        Me.DMonth.Name = "DMonth"
        Me.DMonth.Size = New System.Drawing.Size(47, 13)
        Me.DMonth.TabIndex = 1
        Me.DMonth.Text = "MONTH"
        '
        'CMonth
        '
        Me.CMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMonth.ForeColor = System.Drawing.Color.White
        Me.CMonth.Location = New System.Drawing.Point(0, 0)
        Me.CMonth.Name = "CMonth"
        Me.CMonth.Size = New System.Drawing.Size(65, 65)
        Me.CMonth.TabIndex = 2
        Me.CMonth.Text = "00"
        Me.CMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Year
        '
        Me.Year.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Year.Controls.Add(Me.DYear)
        Me.Year.Controls.Add(Me.CYear)
        Me.Year.Location = New System.Drawing.Point(149, 28)
        Me.Year.Margin = New System.Windows.Forms.Padding(0)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(65, 65)
        Me.Year.TabIndex = 1
        '
        'DYear
        '
        Me.DYear.AutoSize = True
        Me.DYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DYear.ForeColor = System.Drawing.Color.White
        Me.DYear.Location = New System.Drawing.Point(14, 49)
        Me.DYear.Name = "DYear"
        Me.DYear.Size = New System.Drawing.Size(36, 13)
        Me.DYear.TabIndex = 2
        Me.DYear.Text = "YEAR"
        '
        'CYear
        '
        Me.CYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CYear.ForeColor = System.Drawing.Color.White
        Me.CYear.Location = New System.Drawing.Point(0, 0)
        Me.CYear.Name = "CYear"
        Me.CYear.Size = New System.Drawing.Size(65, 65)
        Me.CYear.TabIndex = 3
        Me.CYear.Text = "00"
        Me.CYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hour
        '
        Me.Hour.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Hour.Controls.Add(Me.DHour)
        Me.Hour.Controls.Add(Me.CHour)
        Me.Hour.Controls.Add(Me.YearDec)
        Me.Hour.Controls.Add(Me.HourDec)
        Me.Hour.Location = New System.Drawing.Point(261, 28)
        Me.Hour.Margin = New System.Windows.Forms.Padding(0)
        Me.Hour.Name = "Hour"
        Me.Hour.Size = New System.Drawing.Size(65, 65)
        Me.Hour.TabIndex = 2
        '
        'DHour
        '
        Me.DHour.AutoSize = True
        Me.DHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DHour.ForeColor = System.Drawing.Color.White
        Me.DHour.Location = New System.Drawing.Point(9, 49)
        Me.DHour.Name = "DHour"
        Me.DHour.Size = New System.Drawing.Size(46, 13)
        Me.DHour.TabIndex = 3
        Me.DHour.Text = "HOURS"
        '
        'CHour
        '
        Me.CHour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHour.ForeColor = System.Drawing.Color.White
        Me.CHour.Location = New System.Drawing.Point(0, 0)
        Me.CHour.Name = "CHour"
        Me.CHour.Size = New System.Drawing.Size(65, 65)
        Me.CHour.TabIndex = 4
        Me.CHour.Text = "00"
        Me.CHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YearDec
        '
        Me.YearDec.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.YearDec.FlatAppearance.BorderSize = 0
        Me.YearDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.YearDec.Location = New System.Drawing.Point(6, 49)
        Me.YearDec.Margin = New System.Windows.Forms.Padding(0)
        Me.YearDec.Name = "YearDec"
        Me.YearDec.Size = New System.Drawing.Size(65, 23)
        Me.YearDec.TabIndex = 7
        Me.YearDec.Text = "\/"
        Me.YearDec.UseVisualStyleBackColor = False
        '
        'HourDec
        '
        Me.HourDec.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.HourDec.FlatAppearance.BorderSize = 0
        Me.HourDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HourDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HourDec.Location = New System.Drawing.Point(6, 16)
        Me.HourDec.Margin = New System.Windows.Forms.Padding(0)
        Me.HourDec.Name = "HourDec"
        Me.HourDec.Size = New System.Drawing.Size(65, 23)
        Me.HourDec.TabIndex = 8
        Me.HourDec.Text = "\/"
        Me.HourDec.UseVisualStyleBackColor = False
        '
        'Minutes
        '
        Me.Minutes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Minutes.Controls.Add(Me.DMinute)
        Me.Minutes.Controls.Add(Me.CMinute)
        Me.Minutes.Controls.Add(Me.MonthDec)
        Me.Minutes.Location = New System.Drawing.Point(348, 28)
        Me.Minutes.Margin = New System.Windows.Forms.Padding(0)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(65, 65)
        Me.Minutes.TabIndex = 1
        '
        'DMinute
        '
        Me.DMinute.AutoSize = True
        Me.DMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMinute.ForeColor = System.Drawing.Color.White
        Me.DMinute.Location = New System.Drawing.Point(4, 49)
        Me.DMinute.Name = "DMinute"
        Me.DMinute.Size = New System.Drawing.Size(56, 13)
        Me.DMinute.TabIndex = 4
        Me.DMinute.Text = "MINUTES"
        '
        'CMinute
        '
        Me.CMinute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMinute.ForeColor = System.Drawing.Color.White
        Me.CMinute.Location = New System.Drawing.Point(0, 0)
        Me.CMinute.Name = "CMinute"
        Me.CMinute.Size = New System.Drawing.Size(65, 65)
        Me.CMinute.TabIndex = 5
        Me.CMinute.Text = "00"
        Me.CMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthDec
        '
        Me.MonthDec.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MonthDec.FlatAppearance.BorderSize = 0
        Me.MonthDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MonthDec.Location = New System.Drawing.Point(-33, -7)
        Me.MonthDec.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthDec.Name = "MonthDec"
        Me.MonthDec.Size = New System.Drawing.Size(65, 23)
        Me.MonthDec.TabIndex = 6
        Me.MonthDec.Text = "\/"
        Me.MonthDec.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.Location = New System.Drawing.Point(229, 118)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(53, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'SetDate
        '
        Me.SetDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SetDate.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SetDate.FlatAppearance.BorderSize = 0
        Me.SetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SetDate.Location = New System.Drawing.Point(138, 118)
        Me.SetDate.Margin = New System.Windows.Forms.Padding(0)
        Me.SetDate.Name = "SetDate"
        Me.SetDate.Size = New System.Drawing.Size(53, 23)
        Me.SetDate.TabIndex = 3
        Me.SetDate.Text = "Set"
        Me.SetDate.UseVisualStyleBackColor = False
        '
        'DayDc
        '
        Me.DayDc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DayDc.FlatAppearance.BorderSize = 0
        Me.DayDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DayDc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DayDc.Location = New System.Drawing.Point(5, 93)
        Me.DayDc.Margin = New System.Windows.Forms.Padding(0)
        Me.DayDc.Name = "DayDc"
        Me.DayDc.Size = New System.Drawing.Size(65, 23)
        Me.DayDc.TabIndex = 5
        Me.DayDc.Text = "\/"
        Me.DayDc.UseVisualStyleBackColor = False
        '
        'MinuteDc
        '
        Me.MinuteDc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MinuteDc.FlatAppearance.BorderSize = 0
        Me.MinuteDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinuteDc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MinuteDc.Location = New System.Drawing.Point(348, 93)
        Me.MinuteDc.Margin = New System.Windows.Forms.Padding(0)
        Me.MinuteDc.Name = "MinuteDc"
        Me.MinuteDc.Size = New System.Drawing.Size(65, 23)
        Me.MinuteDc.TabIndex = 9
        Me.MinuteDc.Text = "\/"
        Me.MinuteDc.UseVisualStyleBackColor = False
        '
        'DayInc
        '
        Me.DayInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DayInc.FlatAppearance.BorderSize = 0
        Me.DayInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DayInc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DayInc.Location = New System.Drawing.Point(5, 5)
        Me.DayInc.Margin = New System.Windows.Forms.Padding(0)
        Me.DayInc.Name = "DayInc"
        Me.DayInc.Size = New System.Drawing.Size(65, 23)
        Me.DayInc.TabIndex = 10
        Me.DayInc.Text = "/\"
        Me.DayInc.UseVisualStyleBackColor = False
        '
        'MonthDc
        '
        Me.MonthDc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MonthDc.FlatAppearance.BorderSize = 0
        Me.MonthDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthDc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MonthDc.Location = New System.Drawing.Point(77, 93)
        Me.MonthDc.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthDc.Name = "MonthDc"
        Me.MonthDc.Size = New System.Drawing.Size(65, 23)
        Me.MonthDc.TabIndex = 11
        Me.MonthDc.Text = "\/"
        Me.MonthDc.UseVisualStyleBackColor = False
        '
        'YearDc
        '
        Me.YearDc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.YearDc.FlatAppearance.BorderSize = 0
        Me.YearDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearDc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.YearDc.Location = New System.Drawing.Point(149, 93)
        Me.YearDc.Margin = New System.Windows.Forms.Padding(0)
        Me.YearDc.Name = "YearDc"
        Me.YearDc.Size = New System.Drawing.Size(65, 23)
        Me.YearDc.TabIndex = 12
        Me.YearDc.Text = "\/"
        Me.YearDc.UseVisualStyleBackColor = False
        '
        'HourDc
        '
        Me.HourDc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.HourDc.FlatAppearance.BorderSize = 0
        Me.HourDc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HourDc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HourDc.Location = New System.Drawing.Point(261, 93)
        Me.HourDc.Margin = New System.Windows.Forms.Padding(0)
        Me.HourDc.Name = "HourDc"
        Me.HourDc.Size = New System.Drawing.Size(65, 23)
        Me.HourDc.TabIndex = 13
        Me.HourDc.Text = "\/"
        Me.HourDc.UseVisualStyleBackColor = False
        '
        'MonthInc
        '
        Me.MonthInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MonthInc.FlatAppearance.BorderSize = 0
        Me.MonthInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthInc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MonthInc.Location = New System.Drawing.Point(77, 5)
        Me.MonthInc.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthInc.Name = "MonthInc"
        Me.MonthInc.Size = New System.Drawing.Size(65, 23)
        Me.MonthInc.TabIndex = 14
        Me.MonthInc.Text = "/\"
        Me.MonthInc.UseVisualStyleBackColor = False
        '
        'YearInc
        '
        Me.YearInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.YearInc.FlatAppearance.BorderSize = 0
        Me.YearInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearInc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.YearInc.Location = New System.Drawing.Point(149, 5)
        Me.YearInc.Margin = New System.Windows.Forms.Padding(0)
        Me.YearInc.Name = "YearInc"
        Me.YearInc.Size = New System.Drawing.Size(65, 23)
        Me.YearInc.TabIndex = 15
        Me.YearInc.Text = "/\"
        Me.YearInc.UseVisualStyleBackColor = False
        '
        'HourInc
        '
        Me.HourInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.HourInc.FlatAppearance.BorderSize = 0
        Me.HourInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HourInc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HourInc.Location = New System.Drawing.Point(261, 5)
        Me.HourInc.Margin = New System.Windows.Forms.Padding(0)
        Me.HourInc.Name = "HourInc"
        Me.HourInc.Size = New System.Drawing.Size(65, 23)
        Me.HourInc.TabIndex = 16
        Me.HourInc.Text = "/\"
        Me.HourInc.UseVisualStyleBackColor = False
        '
        'MinuteInc
        '
        Me.MinuteInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MinuteInc.FlatAppearance.BorderSize = 0
        Me.MinuteInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinuteInc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MinuteInc.Location = New System.Drawing.Point(348, 5)
        Me.MinuteInc.Margin = New System.Windows.Forms.Padding(0)
        Me.MinuteInc.Name = "MinuteInc"
        Me.MinuteInc.Size = New System.Drawing.Size(65, 23)
        Me.MinuteInc.TabIndex = 17
        Me.MinuteInc.Text = "/\"
        Me.MinuteInc.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(332, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 7)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(332, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 7)
        Me.Panel2.TabIndex = 19
        '
        'DateChoser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 150)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MinuteInc)
        Me.Controls.Add(Me.HourInc)
        Me.Controls.Add(Me.YearInc)
        Me.Controls.Add(Me.MonthInc)
        Me.Controls.Add(Me.HourDc)
        Me.Controls.Add(Me.YearDc)
        Me.Controls.Add(Me.MonthDc)
        Me.Controls.Add(Me.DayInc)
        Me.Controls.Add(Me.MinuteDc)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.DayDc)
        Me.Controls.Add(Me.SetDate)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Hour)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Month)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DateChoser"
        Me.Text = "DateChoser"
        Me.Day.ResumeLayout(False)
        Me.Day.PerformLayout()
        Me.Month.ResumeLayout(False)
        Me.Month.PerformLayout()
        Me.Year.ResumeLayout(False)
        Me.Year.PerformLayout()
        Me.Hour.ResumeLayout(False)
        Me.Hour.PerformLayout()
        Me.Minutes.ResumeLayout(False)
        Me.Minutes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Day As Panel
    Friend WithEvents Month As Panel
    Friend WithEvents Year As Panel
    Friend WithEvents Hour As Panel
    Friend WithEvents Minutes As Panel
    Friend WithEvents DDay As Label
    Friend WithEvents DMonth As Label
    Friend WithEvents DYear As Label
    Friend WithEvents DHour As Label
    Friend WithEvents DMinute As Label
    Friend WithEvents CDay As Label
    Friend WithEvents CMonth As Label
    Friend WithEvents CYear As Label
    Friend WithEvents CHour As Label
    Friend WithEvents CMinute As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents SetDate As Button
    Friend WithEvents DayDc As Button
    Friend WithEvents MonthDec As Button
    Friend WithEvents YearDec As Button
    Friend WithEvents HourDec As Button
    Friend WithEvents MinuteDc As Button
    Friend WithEvents DayInc As Button
    Friend WithEvents MonthDc As Button
    Friend WithEvents YearDc As Button
    Friend WithEvents HourDc As Button
    Friend WithEvents MonthInc As Button
    Friend WithEvents YearInc As Button
    Friend WithEvents HourInc As Button
    Friend WithEvents MinuteInc As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
