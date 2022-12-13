<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradUpdate
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudeNo = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsemgrad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDateGrad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtgpa = New System.Windows.Forms.TextBox
        Me.txtCompAddress = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtsygraduated = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtWorkNature = New System.Windows.Forms.TextBox
        Me.cboEmpStat = New System.Windows.Forms.ComboBox
        Me.cboEmpType = New System.Windows.Forms.ComboBox
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Number"
        '
        'txtStudeNo
        '
        Me.txtStudeNo.Location = New System.Drawing.Point(149, 48)
        Me.txtStudeNo.Name = "txtStudeNo"
        Me.txtStudeNo.ReadOnly = True
        Me.txtStudeNo.Size = New System.Drawing.Size(221, 29)
        Me.txtStudeNo.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(149, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(498, 29)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(149, 118)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(498, 29)
        Me.txtCourse.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(662, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Major"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(721, 118)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.ReadOnly = True
        Me.txtMajor.Size = New System.Drawing.Size(285, 29)
        Me.txtMajor.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sem Graduated"
        '
        'txtsemgrad
        '
        Me.txtsemgrad.Location = New System.Drawing.Point(149, 153)
        Me.txtsemgrad.Name = "txtsemgrad"
        Me.txtsemgrad.ReadOnly = True
        Me.txtsemgrad.Size = New System.Drawing.Size(166, 29)
        Me.txtsemgrad.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Graduated"
        '
        'txtDateGrad
        '
        Me.txtDateGrad.Location = New System.Drawing.Point(446, 153)
        Me.txtDateGrad.Name = "txtDateGrad"
        Me.txtDateGrad.ReadOnly = True
        Me.txtDateGrad.Size = New System.Drawing.Size(201, 29)
        Me.txtDateGrad.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Employment Status"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(149, 51)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(504, 29)
        Me.txtCompany.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Company"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Company Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(662, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Position"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(662, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Salary"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 21)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Employment Type"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(662, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 21)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Work Nature"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 203)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 21)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "GPA"
        '
        'txtgpa
        '
        Me.txtgpa.Location = New System.Drawing.Point(149, 195)
        Me.txtgpa.Name = "txtgpa"
        Me.txtgpa.Size = New System.Drawing.Size(166, 29)
        Me.txtgpa.TabIndex = 22
        '
        'txtCompAddress
        '
        Me.txtCompAddress.Location = New System.Drawing.Point(149, 86)
        Me.txtCompAddress.Name = "txtCompAddress"
        Me.txtCompAddress.Size = New System.Drawing.Size(504, 29)
        Me.txtCompAddress.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsygraduated)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtgpa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDateGrad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStudeNo)
        Me.GroupBox1.Controls.Add(Me.txtsemgrad)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtMajor)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 242)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alumni Information"
        '
        'txtsygraduated
        '
        Me.txtsygraduated.Location = New System.Drawing.Point(773, 158)
        Me.txtsygraduated.Name = "txtsygraduated"
        Me.txtsygraduated.ReadOnly = True
        Me.txtsygraduated.Size = New System.Drawing.Size(233, 29)
        Me.txtsygraduated.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(662, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "SY Graduated"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtWorkNature)
        Me.GroupBox2.Controls.Add(Me.cboEmpStat)
        Me.GroupBox2.Controls.Add(Me.cboEmpType)
        Me.GroupBox2.Controls.Add(Me.txtPosition)
        Me.GroupBox2.Controls.Add(Me.txtSalary)
        Me.GroupBox2.Controls.Add(Me.txtCompAddress)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCompany)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 178)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Status"
        '
        'txtWorkNature
        '
        Me.txtWorkNature.Location = New System.Drawing.Point(767, 121)
        Me.txtWorkNature.Name = "txtWorkNature"
        Me.txtWorkNature.Size = New System.Drawing.Size(239, 29)
        Me.txtWorkNature.TabIndex = 30
        '
        'cboEmpStat
        '
        Me.cboEmpStat.FormattingEnabled = True
        Me.cboEmpStat.Location = New System.Drawing.Point(478, 121)
        Me.cboEmpStat.Name = "cboEmpStat"
        Me.cboEmpStat.Size = New System.Drawing.Size(175, 29)
        Me.cboEmpStat.TabIndex = 29
        '
        'cboEmpType
        '
        Me.cboEmpType.FormattingEnabled = True
        Me.cboEmpType.Location = New System.Drawing.Point(149, 121)
        Me.cboEmpType.Name = "cboEmpType"
        Me.cboEmpType.Size = New System.Drawing.Size(173, 29)
        Me.cboEmpType.TabIndex = 28
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(733, 86)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(273, 29)
        Me.txtPosition.TabIndex = 27
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(733, 51)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(273, 29)
        Me.txtSalary.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1042, 89)
        Me.Panel1.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.SIMS.My.Resources.Resources.search_icon__1_
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(916, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 64)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.SIMS.My.Resources.Resources.Delete_icon
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(902, 541)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 64)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.SIMS.My.Resources.Resources.add_32px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(779, 541)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 64)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Update"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmGradUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmGradUpdate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graduates' Update"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudeNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsemgrad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDateGrad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtgpa As System.Windows.Forms.TextBox
    Friend WithEvents txtCompAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWorkNature As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpStat As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtsygraduated As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
