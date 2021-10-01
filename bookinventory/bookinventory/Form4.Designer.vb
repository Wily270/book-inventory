<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ticketbox = New System.Windows.Forms.TextBox()
        Me.enterbt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ratecombofrm4 = New System.Windows.Forms.ComboBox()
        Me.ratelb = New System.Windows.Forms.Label()
        Me.dateborrow = New System.Windows.Forms.DateTimePicker()
        Me.dateborrowlb = New System.Windows.Forms.Label()
        Me.isbnbox = New System.Windows.Forms.TextBox()
        Me.authorbox = New System.Windows.Forms.TextBox()
        Me.titlebox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantitybox = New System.Windows.Forms.TextBox()
        Me.quantitylb = New System.Windows.Forms.Label()
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
        Me.confirmbt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ticket"
        '
        'ticketbox
        '
        Me.ticketbox.Location = New System.Drawing.Point(77, 28)
        Me.ticketbox.Name = "ticketbox"
        Me.ticketbox.Size = New System.Drawing.Size(100, 26)
        Me.ticketbox.TabIndex = 1
        '
        'enterbt
        '
        Me.enterbt.Location = New System.Drawing.Point(198, 20)
        Me.enterbt.Name = "enterbt"
        Me.enterbt.Size = New System.Drawing.Size(103, 43)
        Me.enterbt.TabIndex = 2
        Me.enterbt.Text = "Enter"
        Me.enterbt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ratecombofrm4)
        Me.GroupBox1.Controls.Add(Me.ratelb)
        Me.GroupBox1.Controls.Add(Me.dateborrow)
        Me.GroupBox1.Controls.Add(Me.dateborrowlb)
        Me.GroupBox1.Controls.Add(Me.isbnbox)
        Me.GroupBox1.Controls.Add(Me.authorbox)
        Me.GroupBox1.Controls.Add(Me.titlebox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.quantitybox)
        Me.GroupBox1.Controls.Add(Me.quantitylb)
        Me.GroupBox1.Controls.Add(Me.datereturn)
        Me.GroupBox1.Controls.Add(Me.datereturnlb)
        Me.GroupBox1.Controls.Add(Me.phonebox)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.emailbox)
        Me.GroupBox1.Controls.Add(Me.lastnamebox)
        Me.GroupBox1.Controls.Add(Me.firstnamebox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 529)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'ratecombofrm4
        '
        Me.ratecombofrm4.Enabled = False
        Me.ratecombofrm4.FormattingEnabled = True
        Me.ratecombofrm4.Location = New System.Drawing.Point(124, 438)
        Me.ratecombofrm4.Name = "ratecombofrm4"
        Me.ratecombofrm4.Size = New System.Drawing.Size(121, 28)
        Me.ratecombofrm4.TabIndex = 13
        '
        'ratelb
        '
        Me.ratelb.AutoSize = True
        Me.ratelb.Location = New System.Drawing.Point(74, 441)
        Me.ratelb.Name = "ratelb"
        Me.ratelb.Size = New System.Drawing.Size(44, 20)
        Me.ratelb.TabIndex = 39
        Me.ratelb.Text = "Rate"
        '
        'dateborrow
        '
        Me.dateborrow.Enabled = False
        Me.dateborrow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dateborrow.Location = New System.Drawing.Point(124, 374)
        Me.dateborrow.MinDate = New Date(2020, 5, 4, 0, 0, 0, 0)
        Me.dateborrow.Name = "dateborrow"
        Me.dateborrow.Size = New System.Drawing.Size(200, 26)
        Me.dateborrow.TabIndex = 11
        '
        'dateborrowlb
        '
        Me.dateborrowlb.AutoSize = True
        Me.dateborrowlb.Location = New System.Drawing.Point(3, 379)
        Me.dateborrowlb.Name = "dateborrowlb"
        Me.dateborrowlb.Size = New System.Drawing.Size(116, 20)
        Me.dateborrowlb.TabIndex = 38
        Me.dateborrowlb.Text = "Date of Borrow"
        '
        'isbnbox
        '
        Me.isbnbox.Location = New System.Drawing.Point(124, 310)
        Me.isbnbox.Name = "isbnbox"
        Me.isbnbox.ReadOnly = True
        Me.isbnbox.Size = New System.Drawing.Size(200, 26)
        Me.isbnbox.TabIndex = 9
        '
        'authorbox
        '
        Me.authorbox.Location = New System.Drawing.Point(124, 276)
        Me.authorbox.Name = "authorbox"
        Me.authorbox.ReadOnly = True
        Me.authorbox.Size = New System.Drawing.Size(200, 26)
        Me.authorbox.TabIndex = 8
        '
        'titlebox
        '
        Me.titlebox.Location = New System.Drawing.Point(124, 242)
        Me.titlebox.Name = "titlebox"
        Me.titlebox.ReadOnly = True
        Me.titlebox.Size = New System.Drawing.Size(200, 26)
        Me.titlebox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "You borrowed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "You are:"
        '
        'quantitybox
        '
        Me.quantitybox.Location = New System.Drawing.Point(124, 342)
        Me.quantitybox.Name = "quantitybox"
        Me.quantitybox.ReadOnly = True
        Me.quantitybox.Size = New System.Drawing.Size(200, 26)
        Me.quantitybox.TabIndex = 10
        '
        'quantitylb
        '
        Me.quantitylb.AutoSize = True
        Me.quantitylb.Location = New System.Drawing.Point(50, 345)
        Me.quantitylb.Name = "quantitylb"
        Me.quantitylb.Size = New System.Drawing.Size(68, 20)
        Me.quantitylb.TabIndex = 28
        Me.quantitylb.Text = "Quantity"
        '
        'datereturn
        '
        Me.datereturn.Enabled = False
        Me.datereturn.Location = New System.Drawing.Point(124, 406)
        Me.datereturn.MinDate = New Date(2020, 5, 4, 0, 0, 0, 0)
        Me.datereturn.Name = "datereturn"
        Me.datereturn.Size = New System.Drawing.Size(200, 26)
        Me.datereturn.TabIndex = 12
        '
        'datereturnlb
        '
        Me.datereturnlb.AutoSize = True
        Me.datereturnlb.Location = New System.Drawing.Point(3, 411)
        Me.datereturnlb.Name = "datereturnlb"
        Me.datereturnlb.Size = New System.Drawing.Size(115, 20)
        Me.datereturnlb.TabIndex = 27
        Me.datereturnlb.Text = "Date of Return"
        '
        'phonebox
        '
        Me.phonebox.Location = New System.Drawing.Point(124, 157)
        Me.phonebox.Name = "phonebox"
        Me.phonebox.ReadOnly = True
        Me.phonebox.Size = New System.Drawing.Size(200, 26)
        Me.phonebox.TabIndex = 6
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(63, 160)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(55, 20)
        Me.phone.TabIndex = 26
        Me.phone.Text = "Phone"
        '
        'emailbox
        '
        Me.emailbox.Location = New System.Drawing.Point(124, 125)
        Me.emailbox.Name = "emailbox"
        Me.emailbox.ReadOnly = True
        Me.emailbox.Size = New System.Drawing.Size(200, 26)
        Me.emailbox.TabIndex = 5
        '
        'lastnamebox
        '
        Me.lastnamebox.Location = New System.Drawing.Point(124, 93)
        Me.lastnamebox.Name = "lastnamebox"
        Me.lastnamebox.ReadOnly = True
        Me.lastnamebox.Size = New System.Drawing.Size(200, 26)
        Me.lastnamebox.TabIndex = 4
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(124, 61)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.ReadOnly = True
        Me.firstnamebox.Size = New System.Drawing.Size(200, 26)
        Me.firstnamebox.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "First Name"
        '
        'confirmbt
        '
        Me.confirmbt.Enabled = False
        Me.confirmbt.Location = New System.Drawing.Point(148, 638)
        Me.confirmbt.Name = "confirmbt"
        Me.confirmbt.Size = New System.Drawing.Size(103, 43)
        Me.confirmbt.TabIndex = 14
        Me.confirmbt.Text = "Confirm"
        Me.confirmbt.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 710)
        Me.Controls.Add(Me.confirmbt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.enterbt)
        Me.Controls.Add(Me.ticketbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Return"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ticketbox As TextBox
    Friend WithEvents enterbt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents quantitybox As TextBox
    Friend WithEvents quantitylb As Label
    Friend WithEvents datereturn As DateTimePicker
    Friend WithEvents datereturnlb As Label
    Friend WithEvents phonebox As TextBox
    Friend WithEvents phone As Label
    Friend WithEvents emailbox As TextBox
    Friend WithEvents lastnamebox As TextBox
    Friend WithEvents firstnamebox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents isbnbox As TextBox
    Friend WithEvents authorbox As TextBox
    Friend WithEvents titlebox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dateborrow As DateTimePicker
    Friend WithEvents dateborrowlb As Label
    Friend WithEvents confirmbt As Button
    Friend WithEvents ratelb As Label
    Friend WithEvents ratecombofrm4 As ComboBox
End Class
