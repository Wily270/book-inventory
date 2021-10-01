Public Class books
    Inherits Collections.CollectionBase
    Public Sub Add(ByVal newbook As book)
        Me.List.Add(newbook)
    End Sub
    Public Sub Remove(ByVal oldbook As book)
        Me.List.Remove(oldbook)
    End Sub
    Default Public Property item(ByVal index As Integer) As book
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As book)
            Me.List.Item(index) = value
        End Set
    End Property
    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub
    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Function read() As books
        Dim MyFilename As String = "blo.xml"
        Dim MyObject As New books

        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(books))

        If System.IO.File.Exists(MyFilename) Then
            Dim file As New System.IO.StreamReader(MyFilename)

            MyObject = CType(reader.Deserialize(file), books)

            file.Close()
        End If

        Return MyObject
    End Function

    Public Function write() As Boolean
        Dim resultado As Boolean = True

        Try
            Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(books))

            Dim file As New System.IO.StreamWriter("blo.xml")

            writer.Serialize(file, Me)
            file.Close()
        Catch ex As Exception
            resultado = False
        End Try

        Return resultado


    End Function

End Class
