Public Class TimeMarker

    Public Event TimerStart(timer As TimeMarker)
    Public Event TimerEnd(timer As TimeMarker)
#Region "Properties"
    'State enum - represents the state this marker is in
    Public Enum State
        STATE_RUNNING 'The current TimeMarker is running
        STATE_INACTIVE 'The current TimeMarker has not started yet
        STATE_FINISHED 'The current TimeMarker has run/cannot run due to problems or scheduel changes - invalidate temporarely the current TimeMarker
    End Enum

    Public totalTime As Integer 'The time, in seconds, the TimeMarker will be active
    Public startingDate As Date 'A date instance, which contains the minute, hour, day, month and year the TimeMarker will turn on
    Dim elapsedTime As Integer = 0 'The time, in seconds, the TimeMarker has been active for
    Public progress As Double 'The percentage of completion for this TimeMarker
    Public currentState As State = State.STATE_INACTIVE 'The current state this TimeMarker is in
    Dim WithEvents timer As New Timer With {.Interval = 30000} 'timer

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles timer.Tick
        If elapsedTime = totalTime Then
            Me.timer.Dispose()
            Me.currentState = State.STATE_FINISHED
            Me.progress = 1
        End If
        If elapsedTime Mod 5 = 0 Then
            CheckForBlackListed()
        End If
        Me.progress = GetProgress(Me.elapsedTime, Me.totalTime)
        Me.elapsedTime += 1
    End Sub

    Private Sub CheckForBlackListed()

    End Sub

    Private Function GetProgress(curTime As Integer, totalTime As Integer)
        Return curTime / totalTime
    End Function

    Public Sub StartTimeMarker()
        Me.currentState = State.STATE_RUNNING
        Me.timer.Start()
    End Sub


#End Region

    Public Sub New(startingDate As Date, totalTime As Integer, state As State)
        Me.startingDate = startingDate
        Me.totalTime = totalTime
        Me.currentState = state
    End Sub
End Class