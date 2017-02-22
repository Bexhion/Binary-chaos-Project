Public Class ListControl
    Public Sub Add(c As Control)
        FlowLayoutPanel1.Controls.Add(c)
    End Sub

    Public Sub Remove(name As String)
        Dim c As Control = FlowLayoutPanel1.Controls(name)
        FlowLayoutPanel1.Controls.Remove(c)
        c.Dispose()
    End Sub

    Public Sub Clear()
        Do
            If FlowLayoutPanel1.Controls.Count Then Exit Do
            Dim c As Control = FlowLayoutPanel1.Controls(0)
            FlowLayoutPanel1.Controls.Remove(c)
            c.Dispose()
        Loop
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return FlowLayoutPanel1.Controls.Count
        End Get
    End Property
End Class
