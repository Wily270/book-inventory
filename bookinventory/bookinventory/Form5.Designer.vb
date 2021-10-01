<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.phonebox = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.Label()
        Me.emailbox = New System.Windows.Forms.TextBox()
        Me.lastnamebox = New System.Windows.Forms.TextBox()
        Me.firstnamebox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.createbt = New System.Windows.Forms.Button()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usernamebox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'phonebox
        '
        Me.phonebox.Location = New System.Drawing.Point(155, 128)
        Me.phonebox.Name = "phonebox"
        Me.phonebox.Size = New System.Drawing.Size(200, 26)
        Me.phonebox.TabIndex = 4
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(94, 131)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(55, 20)
        Me.phone.TabIndex = 14
        Me.phone.Text = "Phone"
        '
        'emailbox
        '
        Me.emailbox.Location = New System.Drawing.Point(155, 96)
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(200, 26)
        Me.emailbox.TabIndex = 3
        '
        'lastnamebox
        '
        Me.lastnamebox.Location = New System.Drawing.Point(155, 64)
        Me.lastnamebox.Name = "lastnamebox"
        Me.lastnamebox.Size = New System.Drawing.Size(200, 26)
        Me.lastnamebox.TabIndex = 2
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(155, 32)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(200, 26)
        Me.firstnamebox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "First Name"
        '
        'createbt
        '
        Me.createbt.Location = New System.Drawing.Point(177, 261)
        Me.createbt.Name = "createbt"
        Me.createbt.Size = New System.Drawing.Size(103, 43)
        Me.createbt.TabIndex = 7
        Me.createbt.Text = "Create"
        Me.createbt.UseVisualStyleBackColor = True
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(155, 210)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordbox.Size = New System.Drawing.Size(200, 26)
        Me.passwordbox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Password"
        '
        'usernamebox
        '
        Me.usernamebox.Location = New System.Drawing.Point(155, 178)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(200, 26)
        Me.usernamebox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Username"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 350)
        Me.Controls.Add(Me.usernamebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createbt)
        Me.Controls.Add(Me.phonebox)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.emailbox)
        Me.Controls.Add(Me.lastnamebox)
        Me.Controls.Add(Me.firstnamebox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents phonebox As TextBox
    Friend WithEvents phone As Label
    Friend WithEvents emailbox As TextBox
    Friend WithEvents lastnamebox As TextBox
    Friend WithEvents firstnamebox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents createbt As Button
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usernamebox As TextBox
    Friend WithEvents Label2 As Label
End Class
