Public Class borrowings
    Inherits Collections.CollectionBase
    Public Sub Add(ByVal newborrow As borrowing)
        Me.List.Add(newborrow)
    End Sub
    Public Sub Remove(ByVal oldborrow As borrowing)
        Me.List.Remove(oldborrow)
    End Sub
    Default Public Property item(ByVal index As Integer) As borrowing
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As borrowing)
            Me.List.Item(index) = value
        End Set
    End Property
    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub
    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

End Class
