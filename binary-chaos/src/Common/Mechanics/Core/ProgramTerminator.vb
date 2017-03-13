Public Class _EXP_ProgramTerminator

    'List of process names that are meant to be shut down
    Public Shared blackListedPrograms As New List(Of String)
    'Time, in seconds, that the program waits before force closing the program
    Public Shared timeExpected As Integer = 10

    Public Shared Function PreformRoutine() As Integer
        Dim time As Integer = 0
        time += TerminateBrowsers()
        Return time
    End Function

    Public Shared Function TerminateProgram(proces As String) As Integer
        Dim time As Integer = 0
        If Not IsNothing(proces) Then
            If (proces.Contains(".exe")) Then
                proces.TrimEnd(".exe")
            End If
            Dim knownProcesses() As Process = Process.GetProcessesByName(proces)
            If knownProcesses IsNot Nothing Then
                For Each proc As Process In knownProcesses
                    If proc.HasExited = False Then
                        proc.CloseMainWindow()
                        proc.WaitForExit(timeExpected * 1000)
                        time = timeExpected
                        If proc.HasExited = False Then
                            proc.Kill()
                        End If
                    End If
                Next
            Else
            End If
        End If
        Return time
    End Function

    Public Shared Function TerminateBrowsers() As Integer
        Dim time As Integer = 0
        time += TerminateProgram("chrome")
        time += TerminateProgram("ie")
        time += TerminateProgram("firefox")
        Return time
    End Function

    Public Shared Sub AddProcessToBlacklist(process As String)
        If process IsNot Nothing Then
            If Not blackListedPrograms.Contains(process) Then
                blackListedPrograms.Add(process)
            End If
        End If
    End Sub
End Class