Public Class _EXP_ProgramTerminator
    Implements IComparer(Of Boolean)

    'List of process names that are meant to be shut down
    Dim blackListedPrograms As List(Of String)
    'Time, in seconds, that the program waits before force closing the program
    Dim timeExpected As Integer = 10

    Public Function TerminateProgram(proces As String) As Integer
        Dim sucess As Boolean = True
        Dim graceful As Boolean = True
        If Not IsNothing(proces) Then
            If (proces.Contains(".exe")) Then
                proces.TrimEnd(".exe")
            End If
            For Each curProcess As String In blackListedPrograms
                Dim knownProcesses() As Process = System.Diagnostics.Process.GetProcessesByName(curProcess)
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
            Next
        Else
            sucess = False
        End If
        Return Compare(sucess, graceful)
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
