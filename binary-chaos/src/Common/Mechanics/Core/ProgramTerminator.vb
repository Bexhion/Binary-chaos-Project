Public Class _EXP_ProgramTerminator

    'List of process names that are meant to be shut down
    Public Shared blackListedPrograms As List(Of String)
    'Time, in seconds, that the program waits before force closing the program
    Public Shared timeExpected As Integer = 10

    Public Shared Function PreformRoutine() As Integer
        Dim result As Integer = 0
        For Each program As String In blackListedPrograms
            Dim r As Integer = TerminateProgram(program)
            If result = r Then
                result = r
            Else
                result = 0
            End If
        Next
        Return result
    End Function

    Public Shared Function TerminateProgram(proces As String) As Integer
        Dim sucess As Boolean = True
        Dim graceful As Boolean = True
        If Not IsNothing(proces) Then
            If (proces.Contains(".exe")) Then
                proces.TrimEnd(".exe")
            End If
            Dim knownProcesses() As Process = System.Diagnostics.Process.GetProcessesByName(proces)
            If IsNothing(knownProcesses) Then
                Return -1
            End If
            For Each proc As Process In knownProcesses
                If proc.HasExited = False Then
                    proc.CloseMainWindow()
                    proc.WaitForExit(timeExpected * 1000)

                    If proc.HasExited = False Then
                        proc.Kill()
                        graceful = False
                    End If
                End If
            Next
        Else
            sucess = False
        End If
        Return Compare(sucess, graceful)
    End Function

    Public Shared Function Compare(x As Boolean, y As Boolean) As Integer
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

    Public Shared Sub TerminateBrowsers()
        Dim chrome As Integer = TerminateProgram("chrome")
        Dim ie As Integer = TerminateProgram("ie")
        Dim firefox As Integer = TerminateProgram("firefox")
    End Sub

    Public Shared Sub AddProcessToBlacklist(process As String)
        If process IsNot Nothing Then
            If Not blackListedPrograms.Contains(process) Then
                blackListedPrograms.Add(process)
            End If
        End If
    End Sub
End Class