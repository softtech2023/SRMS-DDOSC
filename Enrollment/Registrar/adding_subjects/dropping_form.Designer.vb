<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDroppingForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsubjectcode = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.lblCurrentSlot = New System.Windows.Forms.Label
        Me.lblFinalSlot = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.txtStudentNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.dgSubjects = New System.Windows.Forms.DataGridView
        Me.btnDropSelectedSubject = New System.Windows.Forms.Button
        Me.lblLecUnits = New System.Windows.Forms.Label
        Me.lblLabUnits = New System.Windows.Forms.Label
        Me.lblTotalUnits = New System.Windows.Forms.Label
        Me.lblNewTotal = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblRegNumber = New System.Windows.Forms.Label
        Me.lblFinalSpecialLab = New System.Windows.Forms.Label
        Me.lblCurrentSpecialLal = New System.Windows.Forms.Label
        Me.lblLabFee = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(105, 72)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(304, 26)
        Me.txtDescription.TabIndex = 42
        Me.txtDescription.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Description"
        '
        'txtInstructor
        '
        Me.txtInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(105, 144)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(304, 26)
        Me.txtInstructor.TabIndex = 4
        Me.txtInstructor.TabStop = False
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(105, 108)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(304, 26)
        Me.txtSection.TabIndex = 2
        Me.txtSection.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(35, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Instructor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(49, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Subject Code"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectcode.ForeColor = System.Drawing.Color.Black
        Me.txtsubjectcode.Location = New System.Drawing.Point(105, 36)
        Me.txtsubjectcode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.ReadOnly = True
        Me.txtsubjectcode.Size = New System.Drawing.Size(112, 26)
        Me.txtsubjectcode.TabIndex = 1
        Me.txtsubjectcode.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.txtsubjectcode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSection)
        Me.GroupBox2.Controls.Add(Me.txtInstructor)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Details"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(272, 26)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 23)
        Me.txtCourse.TabIndex = 43
        Me.txtCourse.Visible = False
        '
        'lblCurrentSlot
        '
        Me.lblCurrentSlot.AutoSize = True
        Me.lblCurrentSlot.Location = New System.Drawing.Point(359, 19)
        Me.lblCurrentSlot.Name = "lblCurrentSlot"
        Me.lblCurrentSlot.Size = New System.Drawing.Size(58, 15)
        Me.lblCurrentSlot.TabIndex = 48
        Me.lblCurrentSlot.Text = "CurrentSlot"
        '
        'lblFinalSlot
        '
        Me.lblFinalSlot.AutoSize = True
        Me.lblFinalSlot.Location = New System.Drawing.Point(449, 19)
        Me.lblFinalSlot.Name = "lblFinalSlot"
        Me.lblFinalSlot.Size = New System.Drawing.Size(46, 15)
        Me.lblFinalSlot.TabIndex = 49
        Me.lblFinalSlot.Text = "FinalSlot"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSelect)
        Me.GroupBox3.Controls.Add(Me.txtStudentNo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtFName)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtMName)
        Me.GroupBox3.Controls.Add(Me.txtLName)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 186)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Student Details"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(223, 36)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 28)
        Me.btnSelect.TabIndex = 43
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNo.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNo.Location = New System.Drawing.Point(105, 36)
        Me.txtStudentNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.ReadOnly = True
        Me.txtStudentNo.Size = New System.Drawing.Size(112, 26)
        Me.txtStudentNo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Student No."
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.Black
        Me.txtFName.Location = New System.Drawing.Point(105, 72)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(193, 26)
        Me.txtFName.TabIndex = 42
        Me.txtFName.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Middle Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "First Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Last Name"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(105, 108)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(193, 26)
        Me.txtMName.TabIndex = 2
        Me.txtMName.TabStop = False
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.Color.Black
        Me.txtLName.Location = New System.Drawing.Point(105, 144)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(193, 26)
        Me.txtLName.TabIndex = 4
        Me.txtLName.TabStop = False
        '
        'dgSubjects
        '
        Me.dgSubjects.AllowUserToAddRows = False
        Me.dgSubjects.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgSubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSubjects.Location = New System.Drawing.Point(2, 254)
        Me.dgSubjects.Name = "dgSubjects"
        Me.dgSubjects.ReadOnly = True
        Me.dgSubjects.Size = New System.Drawing.Size(759, 219)
        Me.dgSubjects.TabIndex = 47
        Me.dgSubjects.TabStop = False
        '
        'btnDropSelectedSubject
        '
        Me.btnDropSelectedSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDropSelectedSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropSelectedSubject.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDropSelectedSubject.ForeColor = System.Drawing.Color.White
        Me.btnDropSelectedSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDropSelectedSubject.Location = New System.Drawing.Point(586, 207)
        Me.btnDropSelectedSubject.Name = "btnDropSelectedSubject"
        Me.btnDropSelectedSubject.Size = New System.Drawing.Size(161, 41)
        Me.btnDropSelectedSubject.TabIndex = 7
        Me.btnDropSelectedSubject.Text = "Remove Selected Subject"
        Me.btnDropSelectedSubject.UseVisualStyleBackColor = False
        '
        'lblLecUnits
        '
        Me.lblLecUnits.AutoSize = True
        Me.lblLecUnits.Location = New System.Drawing.Point(27, 19)
        Me.lblLecUnits.Name = "lblLecUnits"
        Me.lblLecUnits.Size = New System.Drawing.Size(49, 15)
        Me.lblLecUnits.TabIndex = 50
        Me.lblLecUnits.Text = "Lec Units"
        '
        'lblLabUnits
        '
        Me.lblLabUnits.AutoSize = True
        Me.lblLabUnits.Location = New System.Drawing.Point(102, 16)
        Me.lblLabUnits.Name = "lblLabUnits"
        Me.lblLabUnits.Size = New System.Drawing.Size(50, 15)
        Me.lblLabUnits.TabIndex = 51
        Me.lblLabUnits.Text = "Lab Units"
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.AutoSize = True
        Me.lblTotalUnits.Location = New System.Drawing.Point(178, 16)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(57, 15)
        Me.lblTotalUnits.TabIndex = 52
        Me.lblTotalUnits.Text = "Total Units"
        '
        'lblNewTotal
        '
        Me.lblNewTotal.AutoSize = True
        Me.lblNewTotal.Location = New System.Drawing.Point(266, 19)
        Me.lblNewTotal.Name = "lblNewTotal"
        Me.lblNewTotal.Size = New System.Drawing.Size(54, 15)
        Me.lblNewTotal.TabIndex = 54
        Me.lblNewTotal.Text = "New Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.lblFinalSlot)
        Me.GroupBox1.Controls.Add(Me.lblCurrentSlot)
        Me.GroupBox1.Controls.Add(Me.lblLecUnits)
        Me.GroupBox1.Controls.Add(Me.lblNewTotal)
        Me.GroupBox1.Controls.Add(Me.lblLabUnits)
        Me.GroupBox1.Controls.Add(Me.lblTotalUnits)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 41)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hidden Controls"
        Me.GroupBox1.Visible = False
        '
        'lblRegNumber
        '
        Me.lblRegNumber.AutoSize = True
        Me.lblRegNumber.Location = New System.Drawing.Point(39, 3)
        Me.lblRegNumber.Name = "lblRegNumber"
        Me.lblRegNumber.Size = New System.Drawing.Size(37, 15)
        Me.lblRegNumber.TabIndex = 44
        Me.lblRegNumber.Text = "Label3"
        Me.lblRegNumber.Visible = False
        '
        'lblFinalSpecialLab
        '
        Me.lblFinalSpecialLab.AutoSize = True
        Me.lblFinalSpecialLab.Location = New System.Drawing.Point(190, 3)
        Me.lblFinalSpecialLab.Name = "lblFinalSpecialLab"
        Me.lblFinalSpecialLab.Size = New System.Drawing.Size(13, 15)
        Me.lblFinalSpecialLab.TabIndex = 84
        Me.lblFinalSpecialLab.Text = "0"
        Me.lblFinalSpecialLab.Visible = False
        '
        'lblCurrentSpecialLal
        '
        Me.lblCurrentSpecialLal.AutoSize = True
        Me.lblCurrentSpecialLal.Location = New System.Drawing.Point(125, 3)
        Me.lblCurrentSpecialLal.Name = "lblCurrentSpecialLal"
        Me.lblCurrentSpecialLal.Size = New System.Drawing.Size(13, 15)
        Me.lblCurrentSpecialLal.TabIndex = 83
        Me.lblCurrentSpecialLal.Text = "0"
        Me.lblCurrentSpecialLal.Visible = False
        '
        'lblLabFee
        '
        Me.lblLabFee.AutoSize = True
        Me.lblLabFee.Location = New System.Drawing.Point(151, 3)
        Me.lblLabFee.Name = "lblLabFee"
        Me.lblLabFee.Size = New System.Drawing.Size(13, 15)
        Me.lblLabFee.TabIndex = 82
        Me.lblLabFee.Text = "0"
        Me.lblLabFee.Visible = False
        '
        'frmDroppingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 479)
        Me.Controls.Add(Me.lblFinalSpecialLab)
        Me.Controls.Add(Me.lblRegNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblLabFee)
        Me.Controls.Add(Me.lblCurrentSpecialLal)
        Me.Controls.Add(Me.dgSubjects)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDropSelectedSubject)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmDroppingForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remove Subject/s"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblCurrentSlot As System.Windows.Forms.Label
    Friend WithEvents lblFinalSlot As System.Windows.Forms.Label
    Friend WithEvents btnDropSelectedSubject As System.Windows.Forms.Button
    Friend WithEvents lblTotalUnits As System.Windows.Forms.Label
    Friend WithEvents lblLabUnits As System.Windows.Forms.Label
    Friend WithEvents lblLecUnits As System.Windows.Forms.Label
    Friend WithEvents lblNewTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblRegNumber As System.Windows.Forms.Label
    Friend WithEvents lblFinalSpecialLab As System.Windows.Forms.Label
    Friend WithEvents lblCurrentSpecialLal As System.Windows.Forms.Label
    Friend WithEvents lblLabFee As System.Windows.Forms.Label
End Class
