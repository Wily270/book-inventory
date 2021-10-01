Public Class user

    Private _firstname As String
    Private _lastname As String
    Private _email As String
    Private _phone As String
    Private _password As String
    Private _username
    Private _bookobj As book
    Private _bookhistory As New List(Of String)

    Public Sub New()

    End Sub

    Public Sub New(ByVal firstname As String, ByVal lastname As String, ByVal email As String, ByVal phone As String,
                   ByVal bookobj As book, ByVal password As String, ByVal username As String)

        _firstname = firstname
        _lastname = lastname
        _email = email
        _phone = phone
        _bookobj = bookobj
        _password = password
        _username = username

    End Sub

    Public Property Firstname() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Public Property EMAIL As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
        End Set
    End Property

    Public Property Bookhistory As List(Of String)
        Get
            Return _bookhistory
        End Get
        Set(ByVal value As List(Of String))
            _bookhistory = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

End Class
