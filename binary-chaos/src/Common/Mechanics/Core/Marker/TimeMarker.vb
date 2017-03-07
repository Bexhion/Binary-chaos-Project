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

    Public totalTime As Integer
    Public startingDate As Date
    Dim elapsedTime As Integer = 0
    Public progress As Double
    Public currentState As State = State.STATE_INACTIVE
    Public checkFrequency As Integer = 30
    Public WithEvents timer As New Timer With {.Interval = 1000}

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles timer.Tick
        If elapsedTime = totalTime Then
            timer.Dispose()
            Exit Sub
        End If
        If elapsedTime Mod checkFrequency = 0 Then
            CheckForBlackListed()
        End If
        Me.progress = GetProgress(Me.elapsedTime, Me.totalTime)
        Me.elapsedTime += 1
    End Sub

    Private Sub CheckForBlackListed()

    End Sub

    Private Function GetProgress(curTime As Integer, totalTime As Integer) As Double
        Return curTime / totalTime
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

    Public Sub New(startingDate As Date, totalTime As Integer, state As State)
        Me.startingDate = startingDate
        Me.totalTime = totalTime
        Me.currentState = state
    End Sub
End Class