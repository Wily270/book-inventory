Public Class users

    Inherits Collections.CollectionBase
    Public Sub Add(ByVal newuser As user)
        Me.List.Add(newuser)
    End Sub
    Public Sub Remove(ByVal olduser As user)
        Me.List.Remove(olduser)
    End Sub
    Default Public Property item(ByVal index As Integer) As user
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As user)
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
