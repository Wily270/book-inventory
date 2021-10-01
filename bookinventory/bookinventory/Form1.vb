Imports System.IO
Imports System.Diagnostics

Public Class Form1

    Private booklist As New books
    Private editbook As book
    Private mybook As book
    Private numero As Integer = 0
    Public frm2 As Form2 = New Form2()
    Public frm3 As Form3 = New Form3()
    Public frm4 As Form4 = New Form4()
    Public frm5 As Form5 = New Form5()
    Public selecteduser As user
    Public selectedbook As book
    Private WithEvents myexcel As excel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'showbooks()

        For i As Integer = 0 To 4
            Me.ratecombo.Items.Add(i + 1)
        Next

        Me.Label7.Text = "Books to Return:"

        With booklistview
            .FullRowSelect = True
            .Columns.Add("Available", 55)
            .Columns.Add("Title", 75)
            .Columns.Add("Author")
            .Columns.Add("ISBN")
            .Columns.Add("Publicator")
            .Columns.Add("Category")
            .Columns.Add("Genre")
            .Columns.Add("Date of Publication")
            .Columns.Add("Rate")
        End With

        With returnlistview
            .FullRowSelect = True
            .Columns.Add("Quantity")
            .Columns.Add("Book", 75)
            .Columns.Add("Date of Borrow")
            .Columns.Add("Date of Return")
            .Columns.Add("Name")
            .Columns.Add("Email")
            .Columns.Add("Phone")
            .Columns.Add("Ticket")
        End With

        With userlistview
            .FullRowSelect = True
            .Columns.Add("Title")
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With

    End Sub

    Public Sub showbooks()
        booklistview.Items.Clear()

        For i As Integer = 0 To booklist.Count - 1
            Dim str(9) As String
            Dim itm As ListViewItem
            str(0) = booklist(i).Available
            str(1) = booklist(i).Title
            str(2) = booklist(i).Author
            str(3) = booklist(i).ISBN
            str(4) = booklist(i).Publicator
            str(5) = booklist(i).Category
            str(6) = booklist(i).Genre
            str(7) = booklist(i).Datepublication
            str(8) = booklist(i).Rate

            itm = New ListViewItem(str)

            Me.booklistview.Items.Add(itm).Tag = booklist(i)
        Next

        Me.bookcountlabel.Text = "Number of books: " & booklist.Count
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        Dim value As Integer = CInt(Int(Rnd() * 29 + 1))
        Dim numlines As Integer = 0

        Dim line As String
        Using reader As New System.IO.StreamReader("quotes.txt")
            While numlines <> value
                numlines = numlines + 1
                line = reader.ReadLine
            End While
            Me.quotesbox.Text = line
        End Using
    End Sub

    Private Sub loginbt_Click(sender As Object, e As EventArgs) Handles loginbt.Click

        If frm2 Is Nothing Then
            frm2 = New Form2
        End If

        frm2.ShowDialog()

        If Me.frm2.admin Then
            Me.loginlb.Visible = True
            Me.loginlb.Text = "You are connected as Admin"
            Me.loginbt.Enabled = False
            Me.logoutbt.Enabled = True
            Me.createbt.Enabled = True
            Me.editbt.Enabled = True
            Me.deletebt.Enabled = True
            Me.availablebox.ReadOnly = False
            Me.descriptionbox.ReadOnly = False
        Else
            selecteduser = frm5.userlist(frm2.verification.selecteduser)
            Me.loginlb.Visible = True
            Me.loginlb.Text = "Welcome " + Me.selecteduser.Username
            Me.loginbt.Enabled = False
            Me.logoutbt.Enabled = True
            Me.Label12.Text = Me.selecteduser.Username

            For j As Integer = 0 To selecteduser.Bookhistory.Count - 1
                userlistview.Items.Add(selecteduser.Bookhistory(j))
            Next
        End If

    End Sub

    Private Sub logoutbt_Click(sender As Object, e As EventArgs) Handles logoutbt.Click
        selecteduser = Nothing

        Me.loginlb.Visible = False
        Me.loginbt.Enabled = True
        Me.logoutbt.Enabled = False
        Me.createbt.Enabled = False
        Me.editbt.Enabled = False
        Me.deletebt.Enabled = False
        Me.availablebox.ReadOnly = True
        Me.descriptionbox.ReadOnly = True
        Me.Label12.Text = ""
        Me.userlistview.Items.Clear()

    End Sub

    Private Sub createbt_Click(sender As Object, e As EventArgs) Handles createbt.Click
        Dim alreadyexist As Boolean = False
        Dim create As Boolean = False

        If IsNumeric(Me.availablebox.Text) Then
            create = True
            mybook = New book(Me.titlebox.Text, Me.authorbox.Text, Me.isbnbox.Text, Me.publicatorbox.Text,
                          Me.categorybox.Text, Me.genrebox.Text, Me.datebook.Value, Me.availablebox.Text,
                          Me.descriptionbox.Text)

            For i As Integer = 0 To booklist.Count - 1
                If booklist(i).Title = Me.titlebox.Text Then
                    MsgBox("Already exist")
                    alreadyexist = True
                End If
            Next

            If alreadyexist = False Then
                booklist.Add(mybook)
            End If
        End If

        If create = False Then
            MsgBox("Only numbers in 'Available'")
        End If


        showbooks()
    End Sub

    Private Sub findbt_Click(sender As Object, e As EventArgs) Handles findbt.Click
        Dim found As Boolean = False
        Dim empty As Boolean = False

        If String.IsNullOrEmpty(Me.titlebox.Text) And String.IsNullOrEmpty(Me.authorbox.Text) And String.IsNullOrEmpty(Me.isbnbox.Text) And
            String.IsNullOrEmpty(Me.publicatorbox.Text) And String.IsNullOrEmpty(Me.categorybox.Text) And
            String.IsNullOrEmpty(Me.genrebox.Text) Then

            showbooks()
            empty = True
            found = True

        End If

        If empty = False Then
            For i As Integer = 0 To booklist.Count - 1
                If booklist(i).Title.Contains(Me.titlebox.Text) And booklist(i).Author.Contains(Me.authorbox.Text) And
                    booklist(i).ISBN.Contains(Me.isbnbox.Text) And booklist(i).Publicator.Contains(Me.publicatorbox.Text) And
                    booklist(i).Category.Contains(Me.categorybox.Text) And booklist(i).Genre.Contains(Me.genrebox.Text) And
                    booklist(i).Rate.ToString.Contains(Me.ratecombo.Text) Then

                    Dim str(9) As String
                    Dim itm As ListViewItem
                    str(0) = booklist(i).Available
                    str(1) = booklist(i).Title
                    str(2) = booklist(i).Author
                    str(3) = booklist(i).ISBN
                    str(4) = booklist(i).Publicator
                    str(5) = booklist(i).Category
                    str(6) = booklist(i).Genre
                    str(7) = booklist(i).Datepublication
                    str(8) = booklist(i).Rate

                    itm = New ListViewItem(str)

                    Me.booklistview.Items.Clear()
                    Me.booklistview.Items.Add(itm).Tag = booklist(i)

                    found = True
                End If
            Next
        End If


        If found = False Then
            MsgBox("We didn't find your book")
        End If
    End Sub

    Private Sub Randombt_Click(sender As Object, e As EventArgs) Handles randombt.Click
        Randomize()
        Dim value As Integer = CInt(Int(Rnd() * booklist.Count))

        Dim str(9) As String
        Dim itm As ListViewItem
        str(0) = booklist(value).Available
        str(1) = booklist(value).Title
        str(2) = booklist(value).Author
        str(3) = booklist(value).ISBN
        str(4) = booklist(value).Publicator
        str(5) = booklist(value).Category
        str(6) = booklist(value).Genre
        str(7) = booklist(value).Datepublication
        str(8) = booklist(value).Rate

        itm = New ListViewItem(str)

        Me.booklistview.Items.Clear()
        Me.booklistview.Items.Add(itm).Tag = booklist(value)
    End Sub

    Private Sub booklistview_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles booklistview.DoubleClick
        For Each item As ListViewItem In booklistview.SelectedItems
            selectedbook = DirectCast(item.Tag, book)
        Next

        frm3.ShowDialog()
    End Sub

    Private Sub booklistview_Click(sender As Object, e As EventArgs) Handles booklistview.Click
        For Each item As ListViewItem In booklistview.SelectedItems
            editbook = DirectCast(item.Tag, book)
        Next

        Me.titlebox.Text = editbook.Title
        Me.authorbox.Text = editbook.Author
        Me.isbnbox.Text = editbook.ISBN
        Me.publicatorbox.Text = editbook.Publicator
        Me.categorybox.Text = editbook.Category
        Me.genrebox.Text = editbook.Genre
        Me.availablebox.Text = editbook.Available
        Me.datebook.Value = editbook.Datepublication
        Me.descriptionbox.Text = editbook.Description
        Me.ratecombo.Text = editbook.Rate

        Me.TextBox1.Text = editbook.Title
    End Sub

    Private Sub editbt_Click(sender As Object, e As EventArgs) Handles editbt.Click
        For Each item As ListViewItem In booklistview.SelectedItems
            editbook = DirectCast(item.Tag, book)
        Next

        editbook.Title = Me.titlebox.Text
        editbook.Author = Me.authorbox.Text
        editbook.ISBN = Me.isbnbox.Text
        editbook.Publicator = Me.publicatorbox.Text
        editbook.Category = Me.categorybox.Text
        editbook.Genre = Me.genrebox.Text
        editbook.Available = Me.availablebox.Text
        editbook.Datepublication = Me.datebook.Value
        editbook.Description = Me.descriptionbox.Text
        editbook.Rate = Me.ratecombo.Text

        showbooks()
        Form3.refreshreturn()
    End Sub

    Private Sub deletebt_Click(sender As Object, e As EventArgs) Handles deletebt.Click
        For Each item As ListViewItem In booklistview.SelectedItems
            editbook = DirectCast(item.Tag, book)
        Next

        booklist.Remove(editbook)

        showbooks()
        Form3.refreshreturn()
    End Sub

    Private Sub returnbt_Click(sender As Object, e As EventArgs) Handles returnbt.Click
        frm4.ShowDialog()
    End Sub

    Public Sub TextBox_Click(sender As Object, e As EventArgs) Handles titlebox.Click,
        authorbox.Click, isbnbox.Click, availablebox.Click, publicatorbox.Click, categorybox.Click, genrebox.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub readxmlbt_Click(sender As Object, e As EventArgs) Handles readxmlbt.Click
        booklist = booklist.read()
        showbooks()
    End Sub

    Private Sub writexmlbt_Click(sender As Object, e As EventArgs) Handles writexmlbt.Click
        booklist.write()
    End Sub

    Private Sub writeexcelbt_Click(sender As Object, e As EventArgs) Handles writeexcelbt.Click
        Dim line As Integer = 1
        Dim nameexcel As String = Application.StartupPath & "bli.xlsx"

        myexcel = New excel(nameexcel, True)

        myexcel.selectSheet("Books")
        myexcel.Worksheet.Cells(line, 1) = "Title"
        myexcel.Worksheet.Cells(line, 2) = "Author"
        myexcel.Worksheet.Cells(line, 3) = "ISBN"
        myexcel.Worksheet.Cells(line, 4) = "Publicator"
        myexcel.Worksheet.Cells(line, 5) = "Category"
        myexcel.Worksheet.Cells(line, 6) = "Genre"
        myexcel.Worksheet.Cells(line, 7) = "Date of Publication"
        myexcel.Worksheet.Cells(line, 8) = "Available"
        myexcel.Worksheet.Cells(line, 9) = "Description"
        myexcel.Worksheet.Cells(line, 10) = "Rate"

        For i = 0 To booklist.Count - 1
            line = line + 1

            myexcel.Worksheet.Cells(line, 1) = booklist(i).Title
            myexcel.Worksheet.Cells(line, 2) = booklist(i).Author
            myexcel.Worksheet.Cells(line, 3) = booklist(i).ISBN
            myexcel.Worksheet.Cells(line, 4) = booklist(i).Publicator
            myexcel.Worksheet.Cells(line, 5) = booklist(i).Category
            myexcel.Worksheet.Cells(line, 6) = booklist(i).Genre
            myexcel.Worksheet.Cells(line, 7) = booklist(i).Datepublication
            myexcel.Worksheet.Cells(line, 8) = booklist(i).Available
            myexcel.Worksheet.Cells(line, 9) = booklist(i).Description
            myexcel.Worksheet.Cells(line, 10) = booklist(i).Rate
        Next
    End Sub

    Private Sub readexcelbt_Click(sender As Object, e As EventArgs) Handles readexcelbt.Click
        Dim booktemp As book
        Dim line As Integer = 1
        Dim nameexcel As String = Application.StartupPath & "bli.xlsx"

        myexcel = New excel(nameexcel, True)

        Dim table As Microsoft.Office.Interop.Excel.Range

        table = myexcel.ExcelApp.Range("a1").CurrentRegion

        For line = 2 To table.Rows.Count
            booktemp = New book

            booktemp.Title = myexcel.ExcelApp.Cells(line, 1).value
            booktemp.Author = myexcel.ExcelApp.Cells(line, 2).value
            booktemp.ISBN = myexcel.ExcelApp.Cells(line, 3).value
            booktemp.Publicator = myexcel.ExcelApp.Cells(line, 4).value
            booktemp.Category = myexcel.ExcelApp.Cells(line, 5).value
            booktemp.Genre = myexcel.ExcelApp.Cells(line, 6).value
            booktemp.Datepublication = myexcel.ExcelApp.Cells(line, 7).value
            booktemp.Available = myexcel.ExcelApp.Cells(line, 8).value
            booktemp.Description = myexcel.ExcelApp.Cells(line, 9).value
            booktemp.Rate = myexcel.ExcelApp.Cells(line, 10).value

            booklist.Add(booktemp)
        Next

        showbooks()
    End Sub

    Private Sub booklistview_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles booklistview.ColumnClick
        If booklistview.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            booklistview.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf booklistview.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            booklistview.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If
    End Sub

    Private Sub returnlistview_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles returnlistview.ColumnClick
        If returnlistview.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Descending Then
            returnlistview.Columns.Item(e.Column).ListView.Sorting = SortOrder.Descending
        ElseIf returnlistview.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            returnlistview.Columns.Item(e.Column).ListView.Sorting = SortOrder.Ascending
        End If
    End Sub

    Private Sub clearbt_Click(sender As Object, e As EventArgs) Handles clearbt.Click
        Me.titlebox.Text = ""
        Me.authorbox.Text = ""
        Me.isbnbox.Text = ""
        Me.publicatorbox.Text = ""
        Me.categorybox.Text = ""
        Me.genrebox.Text = ""
        Me.descriptionbox.Text = ""
        Me.availablebox.Text = ""
        Me.datebook.Value = Today
    End Sub

    Private Sub googlebt_Click(sender As Object, e As EventArgs) Handles googlebt.Click
        Dim search As String

        For Each item As ListViewItem In booklistview.SelectedItems
            search = booklistview.FocusedItem.SubItems(1).Text
        Next

        Process.Start("www.google.com/search?q=" + search)
    End Sub
End Class