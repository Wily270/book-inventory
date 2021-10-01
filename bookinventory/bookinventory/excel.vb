Imports Microsoft.Office.Interop.Excel


Public Class excel

    Public Event ErroFilename(ByVal mensagem As String, ByVal filename As String)

    'Criar o objecto excel
    Private _excelApp As New Microsoft.Office.Interop.Excel.Application
    Private _workbook As Microsoft.Office.Interop.Excel.Workbook
    Private _worksheet As Microsoft.Office.Interop.Excel.Worksheet
    Private _range As Microsoft.Office.Interop.Excel.Range


    Private _filename As String
    Public Sub New()
        Workbook = ExcelApp.Workbooks.Add()
    End Sub
    Public Sub New(ByVal Filename As String, Optional Create As Boolean = False)
        Me.Filename = Filename

        If IO.File.Exists(Filename) Then
            Workbook = ExcelApp.Workbooks.Open(Filename)
        ElseIf Create = True Then
            Workbook = ExcelApp.Workbooks.Add()
            Workbook.SaveAs(Filename)
        Else

            Workbook = ExcelApp.Workbooks.Add()
            RaiseEvent ErroFilename("Filename incorrect", Filename)
        End If

        ExcelApp.Visible = True

    End Sub

#Region "Property"


    Public Property ExcelApp As Application
        Get
            Return _excelApp
        End Get
        Set(value As Application)
            _excelApp = value
        End Set
    End Property

    Public Property Workbook As Workbook
        Get
            Return _workbook
        End Get
        Set(value As Workbook)
            _workbook = value
        End Set
    End Property

    Public Property Worksheet As Worksheet
        Get
            Return _worksheet
        End Get
        Set(value As Worksheet)
            _worksheet = value
        End Set
    End Property

    Public Property Filename As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
        End Set
    End Property

    Public Property Range As Range
        Get
            Return _range
        End Get
        Set(value As Range)
            _range = value
        End Set
    End Property

#End Region

    Public Function selectSheet(ByVal SheetName As String) As Worksheet
        Dim Isold As Boolean = False

        For Each paper In Workbook.Sheets
            If paper.name = SheetName Then
                Isold = True
                Worksheet = paper
            End If
        Next
        If Isold = False Then
            Worksheet = Workbook.Worksheets.Add()
            Worksheet.Name = SheetName
        End If

        Return Worksheet
    End Function
    Public Function LerRange(ByRef RefTL As String) As Range


        Range = ExcelApp.Range(RefTL).CurrentRegion

        Return Range
    End Function


End Class