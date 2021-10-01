Public Class Form2

    Public admin As Boolean = False
    Public nouser As Boolean = False
    Private j As Integer
    Private Sub enterbt_Click(sender As Object, e As EventArgs) Handles enterbt.Click
        Dim firstform As New Form1
        Dim myverification = verification()

        If myverification.ok Then
            'Form1.selecteduser = Form1.frm5.userlist(myverification.selecteduser)
            Me.Close()
        Else
            Me.errorlb.Visible = True
        End If
    End Sub

    Function verification() As (ok As Boolean, selecteduser As Integer)
        Dim ok As Boolean = False

        If usernamebox.Text = "admin" And passwordbox.Text = "admin" Then
            ok = True
            admin = True
        Else
            admin = False
            For i As Integer = 0 To Form1.frm5.userlist.Count - 1
                If Me.usernamebox.Text = Form1.frm5.userlist(i).Username And Me.passwordbox.Text = Form1.frm5.userlist(i).Password Then
                    ok = True
                    j = i
                Else
                    ok = False
                End If
            Next
        End If

        Return (ok, j)
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.frm5.ShowDialog()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.usernamebox.Text = ""
        Me.passwordbox.Text = ""
    End Sub
End Class