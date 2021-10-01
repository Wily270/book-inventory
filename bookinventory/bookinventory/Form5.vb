Public Class Form5

    Public userlist As New users
    Private Sub createbt_Click(sender As Object, e As EventArgs) Handles createbt.Click
        Dim myuser As user
        Dim alreadyexist As Boolean = False

        If check() = False Then
            MsgBox("You have to fill everything")
        Else
            For i As Integer = 0 To userlist.Count - 1
                If userlist(i).Username = Me.usernamebox.Text Then
                    MsgBox("Username already taken")
                    alreadyexist = True
                End If
            Next

            If alreadyexist = False Then
                myuser = New user(Me.firstnamebox.Text, Me.lastnamebox.Text, Me.emailbox.Text, Me.phonebox.Text, Form1.selectedbook,
                          Me.passwordbox.Text, Me.usernamebox.Text)

                userlist.Add(myuser)

                Me.Close()
            End If
        End If

    End Sub

    Private Function check()
        Dim valid As Boolean

        If String.IsNullOrEmpty(firstnamebox.Text) Or String.IsNullOrEmpty(lastnamebox.Text) Or String.IsNullOrEmpty(emailbox.Text) Or
            String.IsNullOrEmpty(phonebox.Text) Or String.IsNullOrEmpty(Me.usernamebox.Text) Or String.IsNullOrEmpty(Me.passwordbox.Text) Then

            valid = False
        Else
            valid = True
        End If

        Return valid
    End Function
End Class