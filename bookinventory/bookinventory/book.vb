Public Class book

    Private _title As String
    Private _author As String
    Private _isbn As String
    Private _publicator As String
    Private _category As String
    Private _genre As String
    Private _datepublication As Date
    Private _available As Integer
    Private _description As String
    Private _rate As Single
    Private _listrate As List(Of Integer)

    Public Sub New()

    End Sub
    Public Sub New(ByVal title As String, ByVal author As String, ByVal isbn As String,
                   ByVal publicator As String, ByVal category As String, ByVal genre As String,
                   ByVal datepublication As Date, ByVal available As Integer, ByVal description As String)
        _title = title
        _author = author
        _isbn = isbn
        _publicator = publicator
        _category = category
        _genre = genre
        _datepublication = datepublication
        _available = available
        _description = description
    End Sub

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

    Public Property Author As String
        Get
            Return _author
        End Get
        Set(ByVal value As String)
            _author = value
        End Set
    End Property

    Public Property ISBN As String
        Get
            Return _isbn
        End Get
        Set(ByVal value As String)
            _isbn = value
        End Set
    End Property

    Public Property Publicator As String
        Get
            Return _publicator
        End Get
        Set(ByVal value As String)
            _publicator = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return _genre
        End Get
        Set(ByVal value As String)
            _genre = value
        End Set
    End Property

    Public Property Datepublication As Date
        Get
            Return _datepublication
        End Get
        Set(ByVal value As Date)
            _datepublication = value
        End Set
    End Property

    Public Property Available As Integer
        Get
            Return _available
        End Get
        Set(ByVal value As Integer)
            _available = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Property Rate As Single
        Get
            Return _rate
        End Get
        Set(ByVal value As Single)
            _rate = value
        End Set
    End Property

    Public Property Listrate As List(Of Integer)
        Get
            Return _listrate
        End Get
        Set(ByVal value As List(Of Integer))
            _listrate = value
        End Set
    End Property

End Class
