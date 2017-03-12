Public Class DateChoser
    Dim pos As Point

    Public initialDate As Date = Date.Now

    Dim vday As Integer = initialDate.Day
    Dim vmonth As Integer = initialDate.Month
    Dim vyear As Integer = initialDate.Year

    Dim vhour As Integer = initialDate.Hour
    Dim vminute As Integer = initialDate.Minute

    Public Property ResultDate As Date

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(control As UserControl, pos As Point)
        InitializeComponent()
        pos.Y = pos.Y - Height
        Dim p As Point = Me.PointToClient(pos)
        Me.pos = control.Parent.PointToScreen(pos)
    End Sub

    Private Sub DateChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = pos
        vday = initialDate.Day
        vmonth = initialDate.Month
        vyear = initialDate.Year
        vhour = initialDate.Hour
        vminute = initialDate.Minute

        CDay.Text = vday
        CMonth.Text = vmonth
        CYear.Text = vyear
        CHour.Text = vhour
        CMinute.Text = vminute
    End Sub

    Private Sub SetDate_Click(sender As Object, e As EventArgs) Handles SetDate.Click
        resultDate = New Date(vyear, vmonth, vday, vhour, vminute, 0)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

#Region "Increasers"
    Private Sub DayInc_Click(sender As Object, e As EventArgs) Handles DayInc.Click
        AddDay(1)
    End Sub

    Private Sub MonthInc_Click(sender As Object, e As EventArgs) Handles MonthInc.Click
        AddMonth(1)
    End Sub

    Private Sub YearInc_Click(sender As Object, e As EventArgs) Handles YearInc.Click
        AddYear(1)
    End Sub

    Private Sub HourInc_Click(sender As Object, e As EventArgs) Handles HourInc.Click
        AddHour(1)
    End Sub

    Private Sub MinuteInc_Click(sender As Object, e As EventArgs) Handles MinuteInc.Click
        AddMinute(1)
    End Sub
#End Region
#Region "Decreasers"
    Private Sub DayDc_Click(sender As Object, e As EventArgs) Handles DayDc.Click
        AddDay(-1)
    End Sub

    Private Sub MonthDc_Click(sender As Object, e As EventArgs) Handles MonthDc.Click
        AddMonth(-1)
    End Sub

    Private Sub YearDc_Click(sender As Object, e As EventArgs) Handles YearDc.Click
        AddYear(-1)
    End Sub

    Private Sub HourDc_Click(sender As Object, e As EventArgs) Handles HourDc.Click
        AddHour(-1)
    End Sub

    Private Sub MinuteDc_Click(sender As Object, e As EventArgs) Handles MinuteDc.Click
        AddMinute(-1)
    End Sub
#End Region

    Private Sub AddDay(increment As Integer)
        vday += increment
        If vday > Date.DaysInMonth(vyear, vmonth) Then
            vday = 1
            AddMonth(1)
        End If
        If vday < 1 Then
            vday = Date.DaysInMonth(vyear, vmonth)
            AddMonth(-1)
        End If
        CDay.Text = vday
    End Sub

    Private Sub AddMonth(increment As Integer)
        vmonth += increment
        If vmonth > 12 Then
            vmonth = 1
            AddYear(1)
        End If
        If vmonth < 1 Then
            vmonth = 12
            AddYear(-1)
        End If
        CMonth.Text = vmonth
    End Sub

    Private Sub AddYear(increment As Integer)
        vyear += increment
        If vyear > Date.MaxValue.Year Then
            vyear = Date.MaxValue.Year
        End If
        If vyear < Date.MinValue.Year Then
            vyear = Date.MinValue.Year
        End If
        CYear.Text = vyear
    End Sub

    Private Sub AddHour(increment As Integer)
        vhour += increment
        If vhour > 23 Then
            vhour = 1
            AddDay(1)
        End If
        If vhour < 0 Then
            vhour = 23
            AddDay(-1)
        End If
        CHour.Text = vhour
    End Sub

    Private Sub AddMinute(increment As Integer)
        vminute += increment
        If vhour > 59 Then
            vhour = 1
            AddHour(1)
        End If
        If vhour < 1 Then
            vhour = 59
            AddHour(-1)
        End If
        CMinute.Text = vminute
    End Sub

#Region "Cuteness :3"
#Region "MouseEnter"
    Private Sub DayIncE(sender As Object, e As EventArgs) Handles DayInc.MouseEnter
        DayInc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MonthIncE(sender As Object, e As EventArgs) Handles MonthInc.MouseEnter
        MonthInc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub YearIncE(sender As Object, e As EventArgs) Handles YearInc.MouseEnter
        YearInc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub HourIncE(sender As Object, e As EventArgs) Handles HourInc.MouseEnter
        HourInc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MinuteIncE(sender As Object, e As EventArgs) Handles MinuteInc.MouseEnter
        MinuteInc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub
    Private Sub DayDcE(sender As Object, e As EventArgs) Handles DayDc.MouseEnter
        DayDc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MonthDcE(sender As Object, e As EventArgs) Handles MonthDc.MouseEnter
        MonthDc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub YearDcE(sender As Object, e As EventArgs) Handles YearDc.MouseEnter
        YearDc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub HourDcE(sender As Object, e As EventArgs) Handles HourDc.MouseEnter
        HourDc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MinuteDcE(sender As Object, e As EventArgs) Handles MinuteDc.MouseEnter
        MinuteDc.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub SetDateE(sender As Object, e As EventArgs) Handles SetDate.MouseEnter
        SetDate.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub CancelE(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub
#End Region

#Region "MouseLeave"
    Private Sub DayIncL(sender As Object, e As EventArgs) Handles DayInc.MouseLeave
        DayInc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MonthIncL(sender As Object, e As EventArgs) Handles MonthInc.MouseLeave
        MonthInc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub YearIncL(sender As Object, e As EventArgs) Handles YearInc.MouseLeave
        YearInc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub HourIncL(sender As Object, e As EventArgs) Handles HourInc.MouseLeave
        HourInc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MinuteIncL(sender As Object, e As EventArgs) Handles MinuteInc.MouseLeave
        MinuteInc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
    Private Sub DayDcL(sender As Object, e As EventArgs) Handles DayDc.MouseLeave
        DayDc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MonthDcL(sender As Object, e As EventArgs) Handles MonthDc.MouseLeave
        MonthDc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub YearDcL(sender As Object, e As EventArgs) Handles YearDc.MouseLeave
        YearDc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub HourDcL(sender As Object, e As EventArgs) Handles HourDc.MouseLeave
        HourDc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MinuteDcL(sender As Object, e As EventArgs) Handles MinuteDc.MouseLeave
        MinuteDc.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub SetDateL(sender As Object, e As EventArgs) Handles SetDate.MouseLeave
        SetDate.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub CancelL(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#End Region
End Class