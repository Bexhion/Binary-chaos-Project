Public Class ItemCustomListBox

#Region "Properties"
    Dim vTitle As String
    Public Property Title() As String
        Get
            Return vTitle
        End Get
        Set(value As String)
            vTitle = value
            Refresh()
        End Set
    End Property

    Dim vDescription As String
    Public Property Description() As String
        Get
            Return vDescription
        End Get
        Set(value As String)
            vDescription = value
            Refresh()
        End Set
    End Property
    Public Property d() As String
        Get
            Return vDescription
        End Get
        Set(value As String)
            vDescription = value
            Refresh()
        End Set
    End Property

    Private Sub Label_Day_Click(sender As Object, e As EventArgs) Handles Label_Day.Click

    End Sub
#End Region
End Class
