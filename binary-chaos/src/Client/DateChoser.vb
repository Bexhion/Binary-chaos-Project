Public Class DateChoser
    Dim pos As Point

    Dim initialDate As Date = Date.Now

    Dim vday As Integer = initialDate.Day
    Dim vmonth As Integer = initialDate.Month
    Dim vyear As Integer = initialDate.Year

    Dim vhour As Integer = initialDate.Hour
    Dim vminute As Integer = initialDate.Minute

    Public Property ResultDate As Date

    Public Sub New(pos As Point)
        InitializeComponent()
        Me.pos = pos
    End Sub

    Private Sub DateChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = pos
        CDay.Text = vday
        CMonth.Text = vmonth
        CYear.Text = vyear
        CHour.Text = vhour
        CMinute.Text = vmonth
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

#Region "decreasers"
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
    End Sub

    Private Sub AddYear(increment As Integer)
        vyear += increment
        If vyear > Date.MaxValue.Year Then
            vyear = Date.MaxValue.Year
        End If
        If vyear < Date.MinValue.Year Then
            vyear = Date.MinValue.Year
        End If
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
    End Sub

    Private Function GetMaxDaysInMonth(monthIndex As Integer) As Integer
        Select Case monthIndex
            Case 1, 3, 5, 7, 8, 10
                Return 31
        End Select
    End Function

#Region "Cuteness"
#Region "MouseEnter"
    Private Sub DayDcE(sender As Object, e As EventArgs) Handles DayDc.MouseEnter
        CDay.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MonthDcE(sender As Object, e As EventArgs) Handles MonthDc.MouseEnter
        CMonth.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub YearDcE(sender As Object, e As EventArgs) Handles YearDc.MouseEnter
        CYear.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub HourDcE(sender As Object, e As EventArgs) Handles HourDc.MouseEnter
        CHour.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub MinuteDcE(sender As Object, e As EventArgs) Handles MinuteDc.MouseEnter
        CMinute.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub SetDateE(sender As Object, e As EventArgs) Handles SetDate.MouseEnter
        SetDate.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub

    Private Sub CancelE(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        CDay.ForeColor = Color.FromArgb(25, 156, 255)
    End Sub
#End Region

#Region "MouseLeave"
    Private Sub DayDcL(sender As Object, e As EventArgs) Handles DayDc.MouseLeave
        CDay.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MonthDcL(sender As Object, e As EventArgs) Handles MonthDc.MouseLeave
        CMonth.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub YearDcL(sender As Object, e As EventArgs) Handles YearDc.MouseLeave
        CYear.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub HourDcL(sender As Object, e As EventArgs) Handles HourDc.MouseLeave
        CHour.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub MinuteDcL(sender As Object, e As EventArgs) Handles MinuteDc.MouseLeave
        CMinute.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub SetDateL(sender As Object, e As EventArgs) Handles SetDate.MouseLeave
        SetDate.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub CancelL(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        CDay.ForeColor = Color.FromArgb(0, 112, 192)
    End Sub
#End Region
#End Region
End Class