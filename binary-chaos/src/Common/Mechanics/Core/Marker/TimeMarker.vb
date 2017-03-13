Public Class TimeMarker

    Public Event TimerStart(timer As TimeMarker)
    Public Event TimerEnd(timer As TimeMarker)
    Public Event TimerStateChanged(timer As TimeMarker, state As State)

#Region "Properties"
    Public Enum State
        STATE_RUNNING
        STATE_INACTIVE
        STATE_FINISHED
    End Enum

    Public totalTime As Integer 'In minutes
    Public startingDate As DateTime?
    Public endingDate As DateTime?
    Dim elapsedTime As Integer = 0
    Public progress As Double
    Public currentState As State = State.STATE_INACTIVE
    Public checkFrequency As Integer = 30 'In seconds
    Public WithEvents timer As New Timer With {.Interval = 1000}

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles timer.Tick
        If elapsedTime >= totalTime * 60 Then
            timer.Stop()
            timer.Dispose()
            Exit Sub
        End If
        If elapsedTime Mod (checkFrequency * 1000) = 0 Then
            Me.elapsedTime += _EXP_ProgramTerminator.PreformRoutine() + 1
        Else
            Me.elapsedTime += 1
        End If
        Me.progress = GetProgress(Me.elapsedTime, Me.totalTime)
    End Sub

    Private Function GetProgress(curTime As Integer, totalTime As Integer) As Double
        Return curTime / (totalTime * 60)
    End Function

    Public Sub StartTimeMarker()
        Me.timer.Start()
        RaiseEvent TimerStart(Me)
        RaiseEvent TimerStateChanged(Me, State.STATE_RUNNING)
    End Sub

    Public Sub TimerDispose(sender As Object, e As EventArgs) Handles timer.Disposed
        progress = 1
        RaiseEvent TimerEnd(Me)
        RaiseEvent TimerStateChanged(Me, State.STATE_FINISHED)
    End Sub
#End Region

    Public Sub New(startingDate As DateTime, endingDate As DateTime)
        SetTime(startingDate, endingDate)
        Me.currentState = State.STATE_INACTIVE
    End Sub

    Public Sub SetTime(startingDate As DateTime, endingDate As DateTime)
        Me.startingDate = startingDate
        Me.endingDate = endingDate
        Me.totalTime = endingDate.Subtract(startingDate).TotalMinutes
    End Sub
End Class