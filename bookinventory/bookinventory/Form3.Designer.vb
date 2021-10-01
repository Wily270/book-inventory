<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.quantitylb = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.borrowbt = New System.Windows.Forms.Button()
        Me.datereturn = New System.Windows.Forms.DateTimePicker()
        Me.datereturnlb = New System.Windows.Forms.Label()
        Me.phonebox = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.Label()
        Me.emailbox = New System.Windows.Forms.TextBox()
        Me.lastnamebox = New System.Windows.Forms.TextBox()
        Me.firstnamebox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.quantitylb)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.borrowbt)
        Me.GroupBox2.Controls.Add(Me.datereturn)
        Me.GroupBox2.Controls.Add(Me.datereturnlb)
        Me.GroupBox2.Controls.Add(Me.phonebox)
        Me.GroupBox2.Controls.Add(Me.phone)
        Me.GroupBox2.Controls.Add(Me.emailbox)
        Me.GroupBox2.Controls.Add(Me.lastnamebox)
        Me.GroupBox2.Controls.Add(Me.firstnamebox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 318)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'quantitylb
        '
        Me.quantitylb.AutoSize = True
        Me.quantitylb.Location = New System.Drawing.Point(68, 156)
        Me.quantitylb.Name = "quantitylb"
        Me.quantitylb.Size = New System.Drawing.Size(68, 20)
        Me.quantitylb.TabIndex = 16
        Me.quantitylb.Text = "Quantity"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'borrowbt
        '
        Me.borrowbt.Location = New System.Drawing.Point(142, 242)
        Me.borrowbt.Name = "borrowbt"
        Me.borrowbt.Size = New System.Drawing.Size(103, 43)
        Me.borrowbt.TabIndex = 7
        Me.borrowbt.Text = "Borrow"
        Me.borrowbt.UseVisualStyleBackColor = True
        '
        'datereturn
        '
        Me.datereturn.Location = New System.Drawing.Point(142, 187)
        Me.datereturn.MinDate = New Date(2020, 5, 4, 0, 0, 0, 0)
        Me.datereturn.Name = "datereturn"
        Me.datereturn.Size = New System.Drawing.Size(200, 26)
        Me.datereturn.TabIndex = 6
        '
        'datereturnlb
        '
        Me.datereturnlb.AutoSize = True
        Me.datereturnlb.Location = New System.Drawing.Point(21, 192)
        Me.datereturnlb.Name = "datereturnlb"
        Me.datereturnlb.Size = New System.Drawing.Size(115, 20)
        Me.datereturnlb.TabIndex = 8
        Me.datereturnlb.Text = "Date of Return"
        '
        'phonebox
        '
        Me.phonebox.Location = New System.Drawing.Point(142, 121)
        Me.phonebox.Name = "phonebox"
        Me.phonebox.Size = New System.Drawing.Size(200, 26)
        Me.phonebox.TabIndex = 4
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(81, 124)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(55, 20)
        Me.phone.TabIndex = 6
        Me.phone.Text = "Phone"
        '
        'emailbox
        '
        Me.emailbox.Location = New System.Drawing.Point(142, 89)
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(200, 26)
        Me.emailbox.TabIndex = 3
        '
        'lastnamebox
        '
        Me.lastnamebox.Location = New System.Drawing.Point(142, 57)
        Me.lastnamebox.Name = "lastnamebox"
        Me.lastnamebox.Size = New System.Drawing.Size(200, 26)
        Me.lastnamebox.TabIndex = 2
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(142, 25)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(200, 26)
        Me.firstnamebox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "You choose:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please fill all the informations:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "from:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(284, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(65, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(183, 26)
        Me.TextBox2.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 554)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form3"
        Me.Text = "Borrow Book"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents phonebox As TextBox
    Friend WithEvents phone As Label
    Friend WithEvents emailbox As TextBox
    Friend WithEvents lastnamebox As TextBox
    Friend WithEvents firstnamebox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents datereturnlb As Label
    Friend WithEvents datereturn As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents borrowbt As Button
    Friend WithEvents quantitylb As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
