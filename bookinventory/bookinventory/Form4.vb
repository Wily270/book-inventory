Public Class Form4

    Public j As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 4
            Me.ratecombofrm4.Items.Add(i + 1)
        Next

        Me.ratecombofrm4.Enabled = False
        Me.dateborrow.Enabled = False
        Me.datereturn.Enabled = False
    End Sub

    Private Sub enterbt_Click(sender As Object, e As EventArgs) Handles enterbt.Click
        Dim found As Boolean = False

        For i As Integer = 0 To Form1.frm3.borrowlist.Count - 1
            If Form1.frm3.borrowlist(i).Ticket = Me.ticketbox.Text Then

                Me.firstnamebox.Text = Form1.frm3.borrowlist(i).UserOBJ.Firstname
                Me.lastnamebox.Text = Form1.frm3.borrowlist(i).UserOBJ.Lastname
                Me.emailbox.Text = Form1.frm3.borrowlist(i).UserOBJ.EMAIL
                Me.phonebox.Text = Form1.frm3.borrowlist(i).UserOBJ.Phone
                Me.titlebox.Text = Form1.frm3.borrowlist(i).BookOBJ.Title
                Me.authorbox.Text = Form1.frm3.borrowlist(i).BookOBJ.Author
                Me.isbnbox.Text = Form1.frm3.borrowlist(i).BookOBJ.ISBN
                Me.quantitybox.Text = Form1.frm3.borrowlist(i).Quantity
                Me.dateborrow.Value = Form1.frm3.borrowlist(i).DateBorrow
                Me.datereturn.Value = Form1.frm3.borrowlist(i).DateReturn

                j = i

                found = True

                Me.ratecombofrm4.Enabled = True
                Me.confirmbt.Enabled = True
            End If
        Next

        If found = False Then
            Me.ticketbox.Text = ""
            Me.firstnamebox.Text = ""
            Me.lastnamebox.Text = ""
            Me.emailbox.Text = ""
            Me.phonebox.Text = ""
            Me.titlebox.Text = ""
            Me.authorbox.Text = ""
            Me.isbnbox.Text = ""
            Me.quantitybox.Text = ""
            Me.dateborrow.Value = Today
            Me.datereturn.Value = Today

            MsgBox("We didn't find your ticket")

            Me.ratecombofrm4.Enabled = False
            Me.confirmbt.Enabled = False
        End If
    End Sub

    Private Sub confirmbt_Click(sender As Object, e As EventArgs) Handles confirmbt.Click
        Form1.frm3.borrowlist(j).BookOBJ.Available = Form1.frm3.borrowlist(j).BookOBJ.Available + Form1.frm3.borrowlist(j).Quantity
        Form1.frm3.borrowlist(j).BookOBJ.Rate = average()

        Form1.frm3.borrowlist.RemoveAt(j)

        Form1.showbooks()
        Form3.refreshreturn()

        Me.Close()
    End Sub

    Public Function average() As Single
        Dim score As Single
        Dim total As Single

        total = Form1.frm3.borrowlist(j).BookOBJ.Listrate.Sum

        score = (total + Me.ratecombofrm4.SelectedItem) / (Form1.frm3.borrowlist(j).BookOBJ.Listrate.Count + 1)

        Form1.frm3.borrowlist(j).BookOBJ.Listrate.Add(Me.ratecombofrm4.SelectedItem)

        Return score
    End Function

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.ticketbox.Text = ""
        Me.firstnamebox.Text = ""
        Me.lastnamebox.Text = ""
        Me.emailbox.Text = ""
        Me.phonebox.Text = ""
        Me.titlebox.Text = ""
        Me.authorbox.Text = ""
        Me.isbnbox.Text = ""
        Me.quantitybox.Text = ""
        Me.dateborrow.Value = Today
        Me.datereturn.Value = Today
        Me.ratecombofrm4.Items.Clear()
        Me.ratecombofrm4.Text = ""
        Me.ratecombofrm4.Enabled = False
        Me.confirmbt.Enabled = False
    End Sub

End Class