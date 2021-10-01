Public Class Form3

    Public borrowlist As New borrowings

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If checkuser() Then
            Me.firstnamebox.Text = Form1.selecteduser.Firstname
            Me.lastnamebox.Text = Form1.selecteduser.Lastname
            Me.emailbox.Text = Form1.selecteduser.EMAIL
            Me.phonebox.Text = Form1.selecteduser.Phone
        End If

        Me.TextBox1.Text = Form1.selectedbook.Title
        Me.TextBox2.Text = Form1.selectedbook.Author
        Me.datereturn.MinDate = Today

        For i As Integer = 0 To Form1.selectedbook.Available - 1
            Me.ComboBox1.Items.Add(i + 1)
        Next

        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Public Sub refreshreturn()

        Form1.returnlistview.Items.Clear()

        For i As Integer = 0 To Form1.frm3.borrowlist.Count - 1
            Dim str(8) As String
            Dim itm As ListViewItem
            str(0) = Form1.frm3.borrowlist(i).Quantity
            str(1) = Form1.frm3.borrowlist(i).BookOBJ.Title
            str(2) = Form1.frm3.borrowlist(i).DateBorrow
            str(3) = Form1.frm3.borrowlist(i).DateReturn
            str(4) = Form1.frm3.borrowlist(i).UserOBJ.Firstname & " " & Form1.frm3.borrowlist(i).UserOBJ.Lastname
            str(5) = Form1.frm3.borrowlist(i).UserOBJ.EMAIL
            str(6) = Form1.frm3.borrowlist(i).UserOBJ.Phone
            str(7) = Form1.frm3.borrowlist(i).Ticket

            itm = New ListViewItem(str)

            Form1.returnlistview.Items.Add(itm)
        Next

        Form1.userlistview.Items.Clear()

        If Form1.selecteduser Is Nothing Then

        Else
            For j As Integer = 0 To Form1.selecteduser.Bookhistory.Count - 1
                Form1.userlistview.Items.Add(Form1.selecteduser.Bookhistory(j))
            Next
        End If


    End Sub

    Private Sub borrowbt_Click(sender As Object, e As EventArgs) Handles borrowbt.Click
        Dim myborrowing As borrowing
        Dim myuser As user

        If check() = False Then
            MsgBox("You have to fill everything")
        Else
            If Form1.selecteduser Is Nothing Then
                myuser = New user(Me.firstnamebox.Text, Me.lastnamebox.Text, Me.emailbox.Text, Me.phonebox.Text, Form1.selectedbook,
                                  Nothing, Nothing)

                Dim ticket As String = CInt(Int(Rnd() * 100))

                myborrowing = New borrowing(myuser, Form1.selectedbook, Me.ComboBox1.SelectedItem, ticket, Today, Me.datereturn.Value)

                borrowlist.Add(myborrowing)

                Form1.selectedbook.Available = Form1.selectedbook.Available - myborrowing.Quantity

                Form1.showbooks()
                refreshreturn()

                MsgBox("Your ticket is: " & ticket)

                Me.Close()
            Else
                Dim ticket As String = CInt(Int(Rnd() * 100))

                myborrowing = New borrowing(Form1.selecteduser, Form1.selectedbook, Me.ComboBox1.SelectedItem, ticket, Today, Me.datereturn.Value)

                borrowlist.Add(myborrowing)

                Form1.selectedbook.Available = Form1.selectedbook.Available - myborrowing.Quantity
                Form1.selecteduser.Bookhistory.Add(Form1.selectedbook.Title)

                Form1.showbooks()
                refreshreturn()

                MsgBox("Your ticket is: " & ticket)

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Text = ""
        Me.firstnamebox.Text = ""
        Me.lastnamebox.Text = ""
        Me.emailbox.Text = ""
        Me.phonebox.Text = ""
    End Sub

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles firstnamebox.Click, lastnamebox.Click, emailbox.Click,
            phonebox.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Function check()
        Dim valid As Boolean

        If String.IsNullOrEmpty(firstnamebox.Text) Or String.IsNullOrEmpty(lastnamebox.Text) Or String.IsNullOrEmpty(emailbox.Text) Or
            String.IsNullOrEmpty(phonebox.Text) Or String.IsNullOrEmpty(ComboBox1.Text) Or Not IsNumeric(Me.phonebox.Text) Then

            valid = False
        Else
            valid = True
        End If

        Return valid
    End Function

    Private Function checkuser()
        Dim validuser As Boolean

        If Form1.selecteduser Is Nothing Then
            validuser = False
        Else
            For i As Integer = 0 To Form1.frm5.userlist.Count - 1
                If Form1.selecteduser.Username = Form1.frm5.userlist(i).Username Then
                    validuser = True
                End If
            Next
        End If

        Return validuser
    End Function

End Class