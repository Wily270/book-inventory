<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clearbt = New System.Windows.Forms.Button()
        Me.writeexcelbt = New System.Windows.Forms.Button()
        Me.ratecombo = New System.Windows.Forms.ComboBox()
        Me.readexcelbt = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.writexmlbt = New System.Windows.Forms.Button()
        Me.returnbt = New System.Windows.Forms.Button()
        Me.readxmlbt = New System.Windows.Forms.Button()
        Me.deletebt = New System.Windows.Forms.Button()
        Me.editbt = New System.Windows.Forms.Button()
        Me.descriptionbox = New System.Windows.Forms.TextBox()
        Me.randombt = New System.Windows.Forms.Button()
        Me.availablebox = New System.Windows.Forms.TextBox()
        Me.availablelb = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.Label()
        Me.findbt = New System.Windows.Forms.Button()
        Me.createbt = New System.Windows.Forms.Button()
        Me.publicatorbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datebook = New System.Windows.Forms.DateTimePicker()
        Me.genrebox = New System.Windows.Forms.TextBox()
        Me.categorybox = New System.Windows.Forms.TextBox()
        Me.isbnbox = New System.Windows.Forms.TextBox()
        Me.authorbox = New System.Windows.Forms.TextBox()
        Me.titlebox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quotesgroupbox = New System.Windows.Forms.GroupBox()
        Me.quotesbox = New System.Windows.Forms.TextBox()
        Me.bookcountlabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.loginbt = New System.Windows.Forms.Button()
        Me.logoutbt = New System.Windows.Forms.Button()
        Me.loginlb = New System.Windows.Forms.Label()
        Me.booklistview = New System.Windows.Forms.ListView()
        Me.returnlistview = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.googlebt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.userlistview = New System.Windows.Forms.ListView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.quotesgroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearbt)
        Me.GroupBox1.Controls.Add(Me.writeexcelbt)
        Me.GroupBox1.Controls.Add(Me.ratecombo)
        Me.GroupBox1.Controls.Add(Me.readexcelbt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.writexmlbt)
        Me.GroupBox1.Controls.Add(Me.returnbt)
        Me.GroupBox1.Controls.Add(Me.readxmlbt)
        Me.GroupBox1.Controls.Add(Me.deletebt)
        Me.GroupBox1.Controls.Add(Me.editbt)
        Me.GroupBox1.Controls.Add(Me.descriptionbox)
        Me.GroupBox1.Controls.Add(Me.randombt)
        Me.GroupBox1.Controls.Add(Me.availablebox)
        Me.GroupBox1.Controls.Add(Me.availablelb)
        Me.GroupBox1.Controls.Add(Me.description)
        Me.GroupBox1.Controls.Add(Me.findbt)
        Me.GroupBox1.Controls.Add(Me.createbt)
        Me.GroupBox1.Controls.Add(Me.publicatorbox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.datebook)
        Me.GroupBox1.Controls.Add(Me.genrebox)
        Me.GroupBox1.Controls.Add(Me.categorybox)
        Me.GroupBox1.Controls.Add(Me.isbnbox)
        Me.GroupBox1.Controls.Add(Me.authorbox)
        Me.GroupBox1.Controls.Add(Me.titlebox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 398)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book"
        '
        'clearbt
        '
        Me.clearbt.Location = New System.Drawing.Point(607, 329)
        Me.clearbt.Name = "clearbt"
        Me.clearbt.Size = New System.Drawing.Size(102, 42)
        Me.clearbt.TabIndex = 21
        Me.clearbt.Text = "Clear"
        Me.clearbt.UseVisualStyleBackColor = True
        '
        'writeexcelbt
        '
        Me.writeexcelbt.Location = New System.Drawing.Point(427, 329)
        Me.writeexcelbt.Name = "writeexcelbt"
        Me.writeexcelbt.Size = New System.Drawing.Size(115, 42)
        Me.writeexcelbt.TabIndex = 20
        Me.writeexcelbt.Text = "Write Excel"
        Me.writeexcelbt.UseVisualStyleBackColor = True
        '
        'ratecombo
        '
        Me.ratecombo.FormattingEnabled = True
        Me.ratecombo.Location = New System.Drawing.Point(159, 165)
        Me.ratecombo.Name = "ratecombo"
        Me.ratecombo.Size = New System.Drawing.Size(121, 28)
        Me.ratecombo.TabIndex = 5
        '
        'readexcelbt
        '
        Me.readexcelbt.Location = New System.Drawing.Point(306, 329)
        Me.readexcelbt.Name = "readexcelbt"
        Me.readexcelbt.Size = New System.Drawing.Size(115, 42)
        Me.readexcelbt.TabIndex = 19
        Me.readexcelbt.Text = "Read Excel"
        Me.readexcelbt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(109, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Rate"
        '
        'writexmlbt
        '
        Me.writexmlbt.Location = New System.Drawing.Point(146, 329)
        Me.writexmlbt.Name = "writexmlbt"
        Me.writexmlbt.Size = New System.Drawing.Size(102, 42)
        Me.writexmlbt.TabIndex = 18
        Me.writexmlbt.Text = "Write XML"
        Me.writexmlbt.UseVisualStyleBackColor = True
        '
        'returnbt
        '
        Me.returnbt.Location = New System.Drawing.Point(579, 271)
        Me.returnbt.Name = "returnbt"
        Me.returnbt.Size = New System.Drawing.Size(102, 42)
        Me.returnbt.TabIndex = 16
        Me.returnbt.Text = "Return"
        Me.returnbt.UseVisualStyleBackColor = True
        '
        'readxmlbt
        '
        Me.readxmlbt.Location = New System.Drawing.Point(38, 329)
        Me.readxmlbt.Name = "readxmlbt"
        Me.readxmlbt.Size = New System.Drawing.Size(102, 42)
        Me.readxmlbt.TabIndex = 17
        Me.readxmlbt.Text = "Read XML"
        Me.readxmlbt.UseVisualStyleBackColor = True
        '
        'deletebt
        '
        Me.deletebt.Enabled = False
        Me.deletebt.Location = New System.Drawing.Point(255, 270)
        Me.deletebt.Name = "deletebt"
        Me.deletebt.Size = New System.Drawing.Size(102, 42)
        Me.deletebt.TabIndex = 13
        Me.deletebt.Text = "Delete"
        Me.deletebt.UseVisualStyleBackColor = True
        '
        'editbt
        '
        Me.editbt.Enabled = False
        Me.editbt.Location = New System.Drawing.Point(147, 270)
        Me.editbt.Name = "editbt"
        Me.editbt.Size = New System.Drawing.Size(102, 42)
        Me.editbt.TabIndex = 12
        Me.editbt.Text = "Edit"
        Me.editbt.UseVisualStyleBackColor = True
        '
        'descriptionbox
        '
        Me.descriptionbox.Location = New System.Drawing.Point(471, 133)
        Me.descriptionbox.Multiline = True
        Me.descriptionbox.Name = "descriptionbox"
        Me.descriptionbox.ReadOnly = True
        Me.descriptionbox.Size = New System.Drawing.Size(200, 116)
        Me.descriptionbox.TabIndex = 10
        '
        'randombt
        '
        Me.randombt.Location = New System.Drawing.Point(471, 271)
        Me.randombt.Name = "randombt"
        Me.randombt.Size = New System.Drawing.Size(102, 42)
        Me.randombt.TabIndex = 15
        Me.randombt.Text = "Random"
        Me.randombt.UseVisualStyleBackColor = True
        '
        'availablebox
        '
        Me.availablebox.Location = New System.Drawing.Point(159, 199)
        Me.availablebox.Name = "availablebox"
        Me.availablebox.ReadOnly = True
        Me.availablebox.Size = New System.Drawing.Size(100, 26)
        Me.availablebox.TabIndex = 6
        '
        'availablelb
        '
        Me.availablelb.AutoSize = True
        Me.availablelb.Location = New System.Drawing.Point(42, 202)
        Me.availablelb.Name = "availablelb"
        Me.availablelb.Size = New System.Drawing.Size(111, 20)
        Me.availablelb.TabIndex = 18
        Me.availablelb.Text = "Book available"
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Location = New System.Drawing.Point(376, 136)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(89, 20)
        Me.description.TabIndex = 17
        Me.description.Text = "Description"
        '
        'findbt
        '
        Me.findbt.Location = New System.Drawing.Point(363, 270)
        Me.findbt.Name = "findbt"
        Me.findbt.Size = New System.Drawing.Size(102, 43)
        Me.findbt.TabIndex = 14
        Me.findbt.Text = "Find"
        Me.findbt.UseVisualStyleBackColor = True
        '
        'createbt
        '
        Me.createbt.Enabled = False
        Me.createbt.Location = New System.Drawing.Point(38, 269)
        Me.createbt.Name = "createbt"
        Me.createbt.Size = New System.Drawing.Size(103, 43)
        Me.createbt.TabIndex = 11
        Me.createbt.Text = "Create"
        Me.createbt.UseVisualStyleBackColor = True
        '
        'publicatorbox
        '
        Me.publicatorbox.Location = New System.Drawing.Point(471, 33)
        Me.publicatorbox.Name = "publicatorbox"
        Me.publicatorbox.Size = New System.Drawing.Size(200, 26)
        Me.publicatorbox.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(386, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Publicator"
        '
        'datebook
        '
        Me.datebook.Location = New System.Drawing.Point(159, 133)
        Me.datebook.Name = "datebook"
        Me.datebook.Size = New System.Drawing.Size(200, 26)
        Me.datebook.TabIndex = 4
        '
        'genrebox
        '
        Me.genrebox.Location = New System.Drawing.Point(471, 101)
        Me.genrebox.Name = "genrebox"
        Me.genrebox.Size = New System.Drawing.Size(200, 26)
        Me.genrebox.TabIndex = 9
        '
        'categorybox
        '
        Me.categorybox.Location = New System.Drawing.Point(471, 67)
        Me.categorybox.Name = "categorybox"
        Me.categorybox.Size = New System.Drawing.Size(200, 26)
        Me.categorybox.TabIndex = 8
        '
        'isbnbox
        '
        Me.isbnbox.Location = New System.Drawing.Point(159, 101)
        Me.isbnbox.Name = "isbnbox"
        Me.isbnbox.Size = New System.Drawing.Size(200, 26)
        Me.isbnbox.TabIndex = 3
        '
        'authorbox
        '
        Me.authorbox.Location = New System.Drawing.Point(159, 67)
        Me.authorbox.Name = "authorbox"
        Me.authorbox.Size = New System.Drawing.Size(200, 26)
        Me.authorbox.TabIndex = 2
        '
        'titlebox
        '
        Me.titlebox.Location = New System.Drawing.Point(159, 33)
        Me.titlebox.Name = "titlebox"
        Me.titlebox.Size = New System.Drawing.Size(200, 26)
        Me.titlebox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Publication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'quotesgroupbox
        '
        Me.quotesgroupbox.Controls.Add(Me.quotesbox)
        Me.quotesgroupbox.Location = New System.Drawing.Point(1033, 340)
        Me.quotesgroupbox.Name = "quotesgroupbox"
        Me.quotesgroupbox.Size = New System.Drawing.Size(360, 183)
        Me.quotesgroupbox.TabIndex = 10
        Me.quotesgroupbox.TabStop = False
        Me.quotesgroupbox.Text = "Quotes"
        '
        'quotesbox
        '
        Me.quotesbox.Location = New System.Drawing.Point(0, 25)
        Me.quotesbox.Multiline = True
        Me.quotesbox.Name = "quotesbox"
        Me.quotesbox.ReadOnly = True
        Me.quotesbox.Size = New System.Drawing.Size(356, 152)
        Me.quotesbox.TabIndex = 1
        '
        'bookcountlabel
        '
        Me.bookcountlabel.AutoSize = True
        Me.bookcountlabel.Location = New System.Drawing.Point(19, 558)
        Me.bookcountlabel.Name = "bookcountlabel"
        Me.bookcountlabel.Size = New System.Drawing.Size(66, 20)
        Me.bookcountlabel.TabIndex = 9
        Me.bookcountlabel.Text = "Label11"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'loginbt
        '
        Me.loginbt.Location = New System.Drawing.Point(23, 12)
        Me.loginbt.Name = "loginbt"
        Me.loginbt.Size = New System.Drawing.Size(100, 47)
        Me.loginbt.TabIndex = 12
        Me.loginbt.Text = "Login"
        Me.loginbt.UseVisualStyleBackColor = True
        '
        'logoutbt
        '
        Me.logoutbt.Enabled = False
        Me.logoutbt.Location = New System.Drawing.Point(147, 13)
        Me.logoutbt.Name = "logoutbt"
        Me.logoutbt.Size = New System.Drawing.Size(99, 46)
        Me.logoutbt.TabIndex = 13
        Me.logoutbt.Text = "Logout"
        Me.logoutbt.UseVisualStyleBackColor = True
        '
        'loginlb
        '
        Me.loginlb.AutoSize = True
        Me.loginlb.Location = New System.Drawing.Point(348, 26)
        Me.loginlb.Name = "loginlb"
        Me.loginlb.Size = New System.Drawing.Size(54, 20)
        Me.loginlb.TabIndex = 14
        Me.loginlb.Text = "loginlb"
        Me.loginlb.Visible = False
        '
        'booklistview
        '
        Me.booklistview.AllowColumnReorder = True
        Me.booklistview.HideSelection = False
        Me.booklistview.Location = New System.Drawing.Point(23, 581)
        Me.booklistview.Name = "booklistview"
        Me.booklistview.Size = New System.Drawing.Size(883, 222)
        Me.booklistview.TabIndex = 19
        Me.booklistview.UseCompatibleStateImageBehavior = False
        Me.booklistview.View = System.Windows.Forms.View.Details
        '
        'returnlistview
        '
        Me.returnlistview.AllowColumnReorder = True
        Me.returnlistview.HideSelection = False
        Me.returnlistview.Location = New System.Drawing.Point(935, 581)
        Me.returnlistview.Name = "returnlistview"
        Me.returnlistview.Size = New System.Drawing.Size(693, 222)
        Me.returnlistview.TabIndex = 20
        Me.returnlistview.UseCompatibleStateImageBehavior = False
        Me.returnlistview.View = System.Windows.Forms.View.Details
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(931, 558)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Label7"
        '
        'googlebt
        '
        Me.googlebt.Location = New System.Drawing.Point(553, 498)
        Me.googlebt.Name = "googlebt"
        Me.googlebt.Size = New System.Drawing.Size(121, 44)
        Me.googlebt.TabIndex = 22
        Me.googlebt.Text = "Google"
        Me.googlebt.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Find this book"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 507)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(372, 26)
        Me.TextBox1.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(844, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "History of:"
        '
        'userlistview
        '
        Me.userlistview.AllowColumnReorder = True
        Me.userlistview.HideSelection = False
        Me.userlistview.Location = New System.Drawing.Point(848, 88)
        Me.userlistview.Name = "userlistview"
        Me.userlistview.Size = New System.Drawing.Size(780, 246)
        Me.userlistview.TabIndex = 27
        Me.userlistview.UseCompatibleStateImageBehavior = False
        Me.userlistview.View = System.Windows.Forms.View.Details
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(931, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Label12"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1698, 823)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.userlistview)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.googlebt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.returnlistview)
        Me.Controls.Add(Me.booklistview)
        Me.Controls.Add(Me.loginlb)
        Me.Controls.Add(Me.logoutbt)
        Me.Controls.Add(Me.loginbt)
        Me.Controls.Add(Me.bookcountlabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.quotesgroupbox)
        Me.Name = "Form1"
        Me.Text = "Book Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.quotesgroupbox.ResumeLayout(False)
        Me.quotesgroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents datebook As DateTimePicker
    Friend WithEvents genrebox As TextBox
    Friend WithEvents categorybox As TextBox
    Friend WithEvents isbnbox As TextBox
    Friend WithEvents authorbox As TextBox
    Friend WithEvents titlebox As TextBox
    Friend WithEvents publicatorbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents createbt As Button
    Friend WithEvents findbt As Button
    Friend WithEvents description As Label
    Friend WithEvents bookcountlabel As Label
    Friend WithEvents availablelb As Label
    Friend WithEvents availablebox As TextBox
    Friend WithEvents quotesgroupbox As GroupBox
    Friend WithEvents randombt As Button
    Friend WithEvents quotesbox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents loginbt As Button
    Friend WithEvents logoutbt As Button
    Friend WithEvents loginlb As Label
    Friend WithEvents descriptionbox As TextBox
    Friend WithEvents booklistview As ListView
    Friend WithEvents returnlistview As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents deletebt As Button
    Friend WithEvents editbt As Button
    Friend WithEvents returnbt As Button
    Friend WithEvents readxmlbt As Button
    Friend WithEvents writexmlbt As Button
    Friend WithEvents readexcelbt As Button
    Friend WithEvents writeexcelbt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ratecombo As ComboBox
    Friend WithEvents clearbt As Button
    Friend WithEvents googlebt As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents userlistview As ListView
    Friend WithEvents Label12 As Label
End Class
