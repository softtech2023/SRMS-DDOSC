<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffRet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffRet))
        Me.lblBookID = New System.Windows.Forms.Label
        Me.txtreturndate = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtgetfines = New System.Windows.Forms.TextBox
        Me.txtfines = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdays = New System.Windows.Forms.TextBox
        Me.btnselectbook = New System.Windows.Forms.Button
        Me.txtprocby = New System.Windows.Forms.TextBox
        Me.dtpduedate = New System.Windows.Forms.DateTimePicker
        Me.dtpborroweddate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblReturnedDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtbookno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtptoday = New System.Windows.Forms.DateTimePicker
        Me.lblloanID = New System.Windows.Forms.Label
        Me.lblNo = New System.Windows.Forms.Label
        Me.lblYes = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSelectStaff = New System.Windows.Forms.Button
        Me.txtStudentNo = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(160, 22)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(49, 19)
        Me.lblBookID.TabIndex = 16
        Me.lblBookID.Text = "bookID"
        Me.lblBookID.Visible = False
        '
        'txtreturndate
        '
        Me.txtreturndate.Location = New System.Drawing.Point(114, 232)
        Me.txtreturndate.Name = "txtreturndate"
        Me.txtreturndate.ReadOnly = True
        Me.txtreturndate.Size = New System.Drawing.Size(151, 26)
        Me.txtreturndate.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(740, 58)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(51, 55)
        Me.tsSave.Text = "Return"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtgetfines)
        Me.GroupBox2.Controls.Add(Me.txtfines)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtdays)
        Me.GroupBox2.Controls.Add(Me.btnselectbook)
        Me.GroupBox2.Controls.Add(Me.lblBookID)
        Me.GroupBox2.Controls.Add(Me.txtreturndate)
        Me.GroupBox2.Controls.Add(Me.txtprocby)
        Me.GroupBox2.Controls.Add(Me.dtpduedate)
        Me.GroupBox2.Controls.Add(Me.dtpborroweddate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblReturnedDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtbookno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txttitle)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 293)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrowed Book's Information"
        '
        'txtgetfines
        '
        Me.txtgetfines.Location = New System.Drawing.Point(215, 261)
        Me.txtgetfines.Name = "txtgetfines"
        Me.txtgetfines.ReadOnly = True
        Me.txtgetfines.Size = New System.Drawing.Size(50, 26)
        Me.txtgetfines.TabIndex = 25
        '
        'txtfines
        '
        Me.txtfines.Location = New System.Drawing.Point(271, 168)
        Me.txtfines.Name = "txtfines"
        Me.txtfines.ReadOnly = True
        Me.txtfines.Size = New System.Drawing.Size(50, 26)
        Me.txtfines.TabIndex = 24
        Me.txtfines.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Fines"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Days"
        '
        'txtdays
        '
        Me.txtdays.Location = New System.Drawing.Point(114, 261)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.ReadOnly = True
        Me.txtdays.Size = New System.Drawing.Size(45, 26)
        Me.txtdays.TabIndex = 14
        '
        'btnselectbook
        '
        Me.btnselectbook.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectbook.Location = New System.Drawing.Point(271, 77)
        Me.btnselectbook.Name = "btnselectbook"
        Me.btnselectbook.Size = New System.Drawing.Size(58, 39)
        Me.btnselectbook.TabIndex = 20
        Me.btnselectbook.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book"
        Me.btnselectbook.UseVisualStyleBackColor = True
        '
        'txtprocby
        '
        Me.txtprocby.Location = New System.Drawing.Point(114, 200)
        Me.txtprocby.Name = "txtprocby"
        Me.txtprocby.ReadOnly = True
        Me.txtprocby.Size = New System.Drawing.Size(151, 26)
        Me.txtprocby.TabIndex = 14
        '
        'dtpduedate
        '
        Me.dtpduedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpduedate.Location = New System.Drawing.Point(114, 168)
        Me.dtpduedate.Name = "dtpduedate"
        Me.dtpduedate.Size = New System.Drawing.Size(151, 26)
        Me.dtpduedate.TabIndex = 13
        '
        'dtpborroweddate
        '
        Me.dtpborroweddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpborroweddate.Location = New System.Drawing.Point(114, 130)
        Me.dtpborroweddate.Name = "dtpborroweddate"
        Me.dtpborroweddate.Size = New System.Drawing.Size(151, 26)
        Me.dtpborroweddate.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Borrowed Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Due Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Proccessed By"
        '
        'lblReturnedDate
        '
        Me.lblReturnedDate.AutoSize = True
        Me.lblReturnedDate.Location = New System.Drawing.Point(12, 235)
        Me.lblReturnedDate.Name = "lblReturnedDate"
        Me.lblReturnedDate.Size = New System.Drawing.Size(92, 19)
        Me.lblReturnedDate.TabIndex = 8
        Me.lblReturnedDate.Text = "Returned Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Book No."
        '
        'txtbookno
        '
        Me.txtbookno.Location = New System.Drawing.Point(114, 56)
        Me.txtbookno.Name = "txtbookno"
        Me.txtbookno.ReadOnly = True
        Me.txtbookno.Size = New System.Drawing.Size(151, 26)
        Me.txtbookno.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Title"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(114, 94)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.ReadOnly = True
        Me.txttitle.Size = New System.Drawing.Size(151, 26)
        Me.txttitle.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtptoday)
        Me.GroupBox1.Controls.Add(Me.lblloanID)
        Me.GroupBox1.Controls.Add(Me.lblNo)
        Me.GroupBox1.Controls.Add(Me.lblYes)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSelectStaff)
        Me.GroupBox1.Controls.Add(Me.txtStudentNo)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 293)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff's Information"
        '
        'dtptoday
        '
        Me.dtptoday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptoday.Location = New System.Drawing.Point(89, 171)
        Me.dtptoday.Name = "dtptoday"
        Me.dtptoday.Size = New System.Drawing.Size(146, 26)
        Me.dtptoday.TabIndex = 13
        '
        'lblloanID
        '
        Me.lblloanID.AutoSize = True
        Me.lblloanID.Location = New System.Drawing.Point(166, 124)
        Me.lblloanID.Name = "lblloanID"
        Me.lblloanID.Size = New System.Drawing.Size(46, 19)
        Me.lblloanID.TabIndex = 12
        Me.lblloanID.Text = "semID"
        Me.lblloanID.Visible = False
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(301, 227)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(26, 19)
        Me.lblNo.TabIndex = 11
        Me.lblNo.Text = "No"
        Me.lblNo.Visible = False
        '
        'lblYes
        '
        Me.lblYes.AutoSize = True
        Me.lblYes.Location = New System.Drawing.Point(231, 227)
        Me.lblYes.Name = "lblYes"
        Me.lblYes.Size = New System.Drawing.Size(29, 19)
        Me.lblYes.TabIndex = 10
        Me.lblYes.Text = "Yes"
        Me.lblYes.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(158, 22)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(46, 19)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "semID"
        Me.lblID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Staff Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 90)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(210, 26)
        Me.txtName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Staff No."
        '
        'btnSelectStaff
        '
        Me.btnSelectStaff.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectStaff.Location = New System.Drawing.Point(305, 77)
        Me.btnSelectStaff.Name = "btnSelectStaff"
        Me.btnSelectStaff.Size = New System.Drawing.Size(58, 39)
        Me.btnSelectStaff.TabIndex = 1
        Me.btnSelectStaff.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrower"
        Me.btnSelectStaff.UseVisualStyleBackColor = True
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(89, 56)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.ReadOnly = True
        Me.txtStudentNo.Size = New System.Drawing.Size(210, 26)
        Me.txtStudentNo.TabIndex = 0
        '
        'frmStaffRet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 398)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmStaffRet"
        Me.Text = "Staff Return Book"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents txtreturndate As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtprocby As System.Windows.Forms.TextBox
    Friend WithEvents dtpduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpborroweddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblReturnedDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbookno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblYes As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectStaff As System.Windows.Forms.Button
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents btnselectbook As System.Windows.Forms.Button
    Friend WithEvents lblloanID As System.Windows.Forms.Label
    Friend WithEvents dtptoday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdays As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfines As System.Windows.Forms.TextBox
    Friend WithEvents txtgetfines As System.Windows.Forms.TextBox
End Class
