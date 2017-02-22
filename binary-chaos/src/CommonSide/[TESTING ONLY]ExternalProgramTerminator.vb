Public Class _TESTING_ONLY_ExternalProgramTerminator
    Implements IComparer(Of Boolean)

    'The blacklisted programs, as a string, which will be used to chose and close down the process
    Dim blackListPrograms As List(Of String)
    'Each time timer.tick is called, the program will check for blacklisted programs
    Dim periodicCheck As New Timer
    'Time, in seconds, taken for the program to wait for closing program to close
    Dim elapsedTime As Integer = 10

    Public Function ShutDownProcess(processName As String) As Integer
        If processName.Contains(".exe") Then
            processName.TrimEnd(".exe")
        End If
        Dim processes() As Process = System.Diagnostics.Process.GetProcessesByName(processName)
        If processes.Count > 0 Then
            For i As Integer = 0 To processes.Count
                Dim processTerm As Process = processes(i)
                If processTerm.HasExited = False Then
                    processTerm.CloseMainWindow()
                    processTerm.WaitForExit(elapsedTime * 1000)
                    'TODO: add a notification handler so users can safely close the program
                    'The program has not exited yet, force close it
                    If processTerm.HasExited = False Then
                        processTerm.Kill()
                    End If
                End If
            Next
        End If
    End Function

    Public Function Compare(x As Boolean, y As Boolean) As Integer Implements IComparer(Of Boolean).Compare
        If x Then
            If y Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return -1
        End If
    End Function
End Class
