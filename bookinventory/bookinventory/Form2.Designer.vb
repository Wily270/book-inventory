<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.usernamebox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.enterbt = New System.Windows.Forms.Button()
        Me.errorlb = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(60, 22)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(83, 20)
        Me.username.TabIndex = 0
        Me.username.Text = "Username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(60, 68)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(78, 20)
        Me.password.TabIndex = 1
        Me.password.Text = "Password"
        '
        'usernamebox
        '
        Me.usernamebox.Location = New System.Drawing.Point(156, 22)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(100, 26)
        Me.usernamebox.TabIndex = 1
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(156, 68)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordbox.Size = New System.Drawing.Size(100, 26)
        Me.passwordbox.TabIndex = 2
        '
        'enterbt
        '
        Me.enterbt.Location = New System.Drawing.Point(90, 142)
        Me.enterbt.Name = "enterbt"
        Me.enterbt.Size = New System.Drawing.Size(127, 52)
        Me.enterbt.TabIndex = 3
        Me.enterbt.Text = "Enter"
        Me.enterbt.UseVisualStyleBackColor = True
        '
        'errorlb
        '
        Me.errorlb.AutoSize = True
        Me.errorlb.ForeColor = System.Drawing.Color.Red
        Me.errorlb.Location = New System.Drawing.Point(47, 108)
        Me.errorlb.Name = "errorlb"
        Me.errorlb.Size = New System.Drawing.Size(225, 20)
        Me.errorlb.TabIndex = 5
        Me.errorlb.Text = "Wrong Username or Password"
        Me.errorlb.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(115, 220)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 20)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sign up !"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 260)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.errorlb)
        Me.Controls.Add(Me.enterbt)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.usernamebox)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Name = "Form2"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents usernamebox As TextBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents enterbt As Button
    Friend WithEvents errorlb As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
