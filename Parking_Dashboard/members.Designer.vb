<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class members
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtapartnum = New System.Windows.Forms.TextBox()
        Me.txtnumplate = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.listMembers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnnew)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtmodel)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtapartnum)
        Me.GroupBox1.Controls.Add(Me.txtnumplate)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEMBER DETAILS"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(511, 211)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(110, 34)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(370, 211)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(110, 34)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(201, 211)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(110, 34)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(55, 211)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 34)
        Me.btnnew.TabIndex = 6
        Me.btnnew.Text = "ADD NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtemail.Location = New System.Drawing.Point(425, 151)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PlaceholderText = "EMAIL"
        Me.txtemail.Size = New System.Drawing.Size(196, 33)
        Me.txtemail.TabIndex = 5
        '
        'txtmodel
        '
        Me.txtmodel.Enabled = False
        Me.txtmodel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtmodel.Location = New System.Drawing.Point(425, 98)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.PlaceholderText = "CAR MODEL"
        Me.txtmodel.Size = New System.Drawing.Size(196, 33)
        Me.txtmodel.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtname.Location = New System.Drawing.Point(425, 42)
        Me.txtname.Name = "txtname"
        Me.txtname.PlaceholderText = "FULL NAME"
        Me.txtname.Size = New System.Drawing.Size(196, 33)
        Me.txtname.TabIndex = 3
        '
        'txtapartnum
        '
        Me.txtapartnum.Enabled = False
        Me.txtapartnum.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtapartnum.Location = New System.Drawing.Point(52, 151)
        Me.txtapartnum.Name = "txtapartnum"
        Me.txtapartnum.PlaceholderText = "APRT NUMBER"
        Me.txtapartnum.Size = New System.Drawing.Size(222, 33)
        Me.txtapartnum.TabIndex = 2
        '
        'txtnumplate
        '
        Me.txtnumplate.Enabled = False
        Me.txtnumplate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtnumplate.Location = New System.Drawing.Point(52, 98)
        Me.txtnumplate.Name = "txtnumplate"
        Me.txtnumplate.PlaceholderText = "NUMBER PLATE"
        Me.txtnumplate.Size = New System.Drawing.Size(222, 33)
        Me.txtnumplate.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtid.Location = New System.Drawing.Point(52, 42)
        Me.txtid.Name = "txtid"
        Me.txtid.PlaceholderText = "MEMBER ID"
        Me.txtid.Size = New System.Drawing.Size(222, 33)
        Me.txtid.TabIndex = 0
        '
        'listMembers
        '
        Me.listMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listMembers.GridLines = True
        Me.listMembers.HideSelection = False
        Me.listMembers.Location = New System.Drawing.Point(29, 294)
        Me.listMembers.Name = "listMembers"
        Me.listMembers.Size = New System.Drawing.Size(791, 217)
        Me.listMembers.TabIndex = 10
        Me.listMembers.UseCompatibleStateImageBehavior = False
        Me.listMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Member Id"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Full Name"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Number Plate"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Car Model"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Apart Number"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 100
        '
        'members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 536)
        Me.Controls.Add(Me.listMembers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "members"
        Me.Text = "members"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtapartnum As TextBox
    Friend WithEvents txtnumplate As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents listMembers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
