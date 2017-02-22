Public Class CustomListBox
    Public Sub Add(cont As Control)
        ActualList.Controls.Add(cont)
    End Sub

    Public Sub Remove(name As String)
        Dim cont As Control = ActualList.Controls(name)
        ActualList.Controls.Remove(cont)
        cont.Dispose()
    End Sub

    Public Sub Remove(index As Integer)
        Dim cont As Control = ActualList.Controls(index)
        ActualList.Controls.Remove(cont)
        cont.Dispose()
    End Sub

    Public Sub Clear()
        Do
            If ActualList.Controls.Count = 0 Then Exit Do
            Remove(0)
        Loop
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return ActualList.Controls.Count
        End Get
    End Property
End Class
