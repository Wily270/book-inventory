Public Class borrowing

    Private _dateborrow As Date
    Private _datereturn As Date
    Private _bookobj As book
    Private _quantity As Integer
    Private _ticket As String
    Private _userobj As user

    Public Sub New()

    End Sub

    Public Sub New(ByVal userobj As user, ByVal bookobj As book, ByVal quantity As Integer,
                   ByVal ticket As String, ByVal dateborrow As Date, ByVal datereturn As Date)

        _userobj = userobj
        _dateborrow = dateborrow
        _datereturn = datereturn
        _bookobj = bookobj
        _quantity = quantity
        _ticket = ticket
    End Sub

    Public Property DateBorrow As Date
        Get
            Return _dateborrow
        End Get
        Set(ByVal value As Date)
            _dateborrow = value
        End Set
    End Property

    Public Property DateReturn As Date
        Get
            Return _datereturn
        End Get
        Set(ByVal value As Date)
            _datereturn = value
        End Set
    End Property

    Public Property BookOBJ As book
        Get
            Return _bookobj
        End Get
        Set(ByVal value As book)
            _bookobj = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

    Public Property Ticket As String
        Get
            Return _ticket
        End Get
        Set(ByVal value As String)
            _ticket = value
        End Set
    End Property

    Public Property UserOBJ As user
        Get
            Return _userobj
        End Get
        Set(ByVal value As user)
            _userobj = value
        End Set
    End Property

End Class
