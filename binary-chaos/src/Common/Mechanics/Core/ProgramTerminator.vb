Public Class _EXP_ProgramTerminator

    'List of process names that are meant to be shut down
    Public Shared blackListedPrograms As New List(Of String)
    'Time, in seconds, that the program waits before force closing the program
    Public Shared timeExpected As Integer = 10

    Public Shared Sub PreformRoutine()
        'For Each program As String In blackListedPrograms
        TerminateBrowsers()
        'Next
    End Sub

    Public Shared Sub TerminateProgram(proces As String)
        If Not IsNothing(proces) Then
            If (proces.Contains(".exe")) Then
                proces.TrimEnd(".exe")
            End If
            Dim knownProcesses() As Process = System.Diagnostics.Process.GetProcessesByName(proces)
            If knownProcesses IsNot Nothing Then
                For Each proc As Process In knownProcesses
                    If proc.HasExited = False Then
                        proc.CloseMainWindow()
                        proc.WaitForExit(timeExpected * 1000)

                        If proc.HasExited = False Then
                            proc.Kill()
                        End If
                    End If
                Next
            Else
            End If
        End If
    End Sub

    Public Shared Sub TerminateBrowsers()
        TerminateProgram("chrome")
        TerminateProgram("ie")
        TerminateProgram("firefox")
    End Sub

    Public Shared Sub AddProcessToBlacklist(process As String)
        If process IsNot Nothing Then
            If Not blackListedPrograms.Contains(process) Then
                blackListedPrograms.Add(process)
            End If
        End If
    End Sub
End Class