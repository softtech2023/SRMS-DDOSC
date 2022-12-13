<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAV
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
        Me.dtpDateReleased = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblStudentNumber = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.txtGraduationDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblLab = New System.Windows.Forms.Label
        Me.lblLec = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtYearLevel = New System.Windows.Forms.TextBox
        Me.txtUnitsEarned = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDateAttended = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDegree = New System.Windows.Forms.TextBox
        Me.txtStudentName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSeries = New System.Windows.Forms.TextBox
        Me.txtSVNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtReviewedBy = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtORNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtProcessedBy = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDateReleased
        '
        Me.dtpDateReleased.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateReleased.Location = New System.Drawing.Point(429, 269)
        Me.dtpDateReleased.Name = "dtpDateReleased"
        Me.dtpDateReleased.Size = New System.Drawing.Size(173, 26)
        Me.dtpDateReleased.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(34, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(544, 31)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CERTIFICATION, AUTHENTICATION AND VERIFICATION"
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(16, 4)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(99, 19)
        Me.lblStudentNumber.TabIndex = 44
        Me.lblStudentNumber.Text = "StudentNumber"
        Me.lblStudentNumber.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Location = New System.Drawing.Point(527, 77)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 26)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "SEARCH"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Location = New System.Drawing.Point(498, 316)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 31)
        Me.btnPreview.TabIndex = 13
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'txtGraduationDate
        '
        Me.txtGraduationDate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGraduationDate.Location = New System.Drawing.Point(429, 173)
        Me.txtGraduationDate.Name = "txtGraduationDate"
        Me.txtGraduationDate.Size = New System.Drawing.Size(173, 26)
        Me.txtGraduationDate.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Year Level"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(321, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 19)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Date Released"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblLab)
        Me.Panel1.Controls.Add(Me.lblLec)
        Me.Panel1.Location = New System.Drawing.Point(1, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 40)
        Me.Panel1.TabIndex = 45
        '
        'lblLab
        '
        Me.lblLab.AutoSize = True
        Me.lblLab.Location = New System.Drawing.Point(548, 5)
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Size = New System.Drawing.Size(53, 19)
        Me.lblLab.TabIndex = 20
        Me.lblLab.Text = "Label10"
        Me.lblLab.Visible = False
        '
        'lblLec
        '
        Me.lblLec.AutoSize = True
        Me.lblLec.Location = New System.Drawing.Point(496, 5)
        Me.lblLec.Name = "lblLec"
        Me.lblLec.Size = New System.Drawing.Size(46, 19)
        Me.lblLec.TabIndex = 19
        Me.lblLec.Text = "Label9"
        Me.lblLec.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(320, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Graduation Date"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtYearLevel.Location = New System.Drawing.Point(115, 173)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(199, 26)
        Me.txtYearLevel.TabIndex = 5
        '
        'txtUnitsEarned
        '
        Me.txtUnitsEarned.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUnitsEarned.Location = New System.Drawing.Point(429, 141)
        Me.txtUnitsEarned.Name = "txtUnitsEarned"
        Me.txtUnitsEarned.Size = New System.Drawing.Size(173, 26)
        Me.txtUnitsEarned.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Units Earned"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Date Attended"
        '
        'txtDateAttended
        '
        Me.txtDateAttended.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDateAttended.Location = New System.Drawing.Point(115, 141)
        Me.txtDateAttended.Name = "txtDateAttended"
        Me.txtDateAttended.Size = New System.Drawing.Size(199, 26)
        Me.txtDateAttended.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Degree"
        '
        'txtDegree
        '
        Me.txtDegree.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDegree.Location = New System.Drawing.Point(115, 109)
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.Size = New System.Drawing.Size(487, 26)
        Me.txtDegree.TabIndex = 2
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtStudentName.Location = New System.Drawing.Point(114, 77)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(407, 26)
        Me.txtStudentName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Student Name"
        '
        'txtSeries
        '
        Me.txtSeries.Location = New System.Drawing.Point(325, -14)
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(48, 26)
        Me.txtSeries.TabIndex = 29
        Me.txtSeries.Visible = False
        '
        'txtSVNo
        '
        Me.txtSVNo.Location = New System.Drawing.Point(197, -14)
        Me.txtSVNo.Name = "txtSVNo"
        Me.txtSVNo.Size = New System.Drawing.Size(55, 26)
        Me.txtSVNo.TabIndex = 28
        Me.txtSVNo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, -11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Series of"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, -7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "SV No."
        Me.Label1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Reviewed By"
        '
        'txtReviewedBy
        '
        Me.txtReviewedBy.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtReviewedBy.Location = New System.Drawing.Point(429, 205)
        Me.txtReviewedBy.Name = "txtReviewedBy"
        Me.txtReviewedBy.Size = New System.Drawing.Size(173, 26)
        Me.txtReviewedBy.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Amount Paid"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAmountPaid.Location = New System.Drawing.Point(114, 237)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(200, 26)
        Me.txtAmountPaid.TabIndex = 9
        Me.txtAmountPaid.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(321, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 19)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "O.R. No."
        '
        'txtORNo
        '
        Me.txtORNo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtORNo.Location = New System.Drawing.Point(429, 237)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(173, 26)
        Me.txtORNo.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Date Paid"
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePaid.Location = New System.Drawing.Point(115, 269)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(199, 26)
        Me.dtpDatePaid.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 19)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Processed By"
        '
        'txtProcessedBy
        '
        Me.txtProcessedBy.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtProcessedBy.Location = New System.Drawing.Point(114, 205)
        Me.txtProcessedBy.Name = "txtProcessedBy"
        Me.txtProcessedBy.Size = New System.Drawing.Size(200, 26)
        Me.txtProcessedBy.TabIndex = 7
        '
        'frmCAV
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 359)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtProcessedBy)
        Me.Controls.Add(Me.dtpDatePaid)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtReviewedBy)
        Me.Controls.Add(Me.dtpDateReleased)
        Me.Controls.Add(Me.lblStudentNumber)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.txtGraduationDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtYearLevel)
        Me.Controls.Add(Me.txtUnitsEarned)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDateAttended)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDegree)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtSVNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAV"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDateReleased As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStudentNumber As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtGraduationDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblLab As System.Windows.Forms.Label
    Friend WithEvents lblLec As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsEarned As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDateAttended As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDegree As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSeries As System.Windows.Forms.TextBox
    Friend WithEvents txtSVNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtReviewedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtORNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpDatePaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProcessedBy As System.Windows.Forms.TextBox
End Class
