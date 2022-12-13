<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertification))
        Me.btnStudeReport = New System.Windows.Forms.Button
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.cboStudeReport = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblYearLevelStat = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.MaskedTextBox
        Me.lblScholarship = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblday = New System.Windows.Forms.Label
        Me.lblSchedPay = New System.Windows.Forms.Label
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.lblLastAmountPaid = New System.Windows.Forms.Label
        Me.lblDp = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lbltotalassessment = New System.Windows.Forms.Label
        Me.lblMiscFee = New System.Windows.Forms.Label
        Me.lblLabFee = New System.Windows.Forms.Label
        Me.lblTuitionFee = New System.Windows.Forms.Label
        Me.lblstatus = New System.Windows.Forms.Label
        Me.lblamountgranted = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStudeReport
        '
        Me.btnStudeReport.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeReport.ForeColor = System.Drawing.Color.Black
        Me.btnStudeReport.Image = CType(resources.GetObject("btnStudeReport.Image"), System.Drawing.Image)
        Me.btnStudeReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudeReport.Location = New System.Drawing.Point(642, 0)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(88, 28)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "&Preview"
        Me.btnStudeReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeReport.UseVisualStyleBackColor = False
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(90, 2)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(99, 25)
        Me.mskStudentNumber.TabIndex = 1
        Me.mskStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboStudeReport
        '
        Me.cboStudeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudeReport.ForeColor = System.Drawing.Color.Black
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Admission History", "Certificate of Enrollment", "Certificate of Registration", "Certificate of GMC", "Clearance", "Report of Grades", "Honorable Dismissal", "Form 137-A Request", "Examination Permit", "Permanent Record", "Student's Profile", "Graduates Certification"})
        Me.cboStudeReport.Location = New System.Drawing.Point(438, 2)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(198, 26)
        Me.cboStudeReport.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(573, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 19)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.DisplayGroupTree = False
        Me.specialReportViewer.Location = New System.Drawing.Point(2, 43)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(862, 372)
        Me.specialReportViewer.TabIndex = 5
        Me.specialReportViewer.TabStop = False
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblYearLevelStat)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.btnStudeReport)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboStudeReport)
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(2, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 28)
        Me.Panel2.TabIndex = 0
        '
        'lblYearLevelStat
        '
        Me.lblYearLevelStat.AutoSize = True
        Me.lblYearLevelStat.Location = New System.Drawing.Point(748, 8)
        Me.lblYearLevelStat.Name = "lblYearLevelStat"
        Me.lblYearLevelStat.Size = New System.Drawing.Size(46, 19)
        Me.lblYearLevelStat.TabIndex = 38
        Me.lblYearLevelStat.Text = "Label2"
        Me.lblYearLevelStat.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(195, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(236, 25)
        Me.txtName.TabIndex = 36
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblScholarship
        '
        Me.lblScholarship.AutoSize = True
        Me.lblScholarship.Location = New System.Drawing.Point(18, 51)
        Me.lblScholarship.Name = "lblScholarship"
        Me.lblScholarship.Size = New System.Drawing.Size(74, 19)
        Me.lblScholarship.TabIndex = 0
        Me.lblScholarship.Text = "Scholarship"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblday)
        Me.GroupBox1.Controls.Add(Me.lblSchedPay)
        Me.GroupBox1.Controls.Add(Me.lblTransDate)
        Me.GroupBox1.Controls.Add(Me.lblLastAmountPaid)
        Me.GroupBox1.Controls.Add(Me.lblDp)
        Me.GroupBox1.Controls.Add(Me.lblBalance)
        Me.GroupBox1.Controls.Add(Me.lbltotalassessment)
        Me.GroupBox1.Controls.Add(Me.lblMiscFee)
        Me.GroupBox1.Controls.Add(Me.lblLabFee)
        Me.GroupBox1.Controls.Add(Me.lblTuitionFee)
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.lblamountgranted)
        Me.GroupBox1.Controls.Add(Me.lblScholarship)
        Me.GroupBox1.Location = New System.Drawing.Point(463, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 163)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "hidden controls"
        Me.GroupBox1.Visible = False
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.Location = New System.Drawing.Point(97, 137)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(29, 19)
        Me.lblday.TabIndex = 12
        Me.lblday.Text = "day"
        '
        'lblSchedPay
        '
        Me.lblSchedPay.AutoSize = True
        Me.lblSchedPay.Location = New System.Drawing.Point(238, 80)
        Me.lblSchedPay.Name = "lblSchedPay"
        Me.lblSchedPay.Size = New System.Drawing.Size(63, 19)
        Me.lblSchedPay.TabIndex = 11
        Me.lblSchedPay.Text = "SchedPay"
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Location = New System.Drawing.Point(242, 51)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(91, 19)
        Me.lblTransDate.TabIndex = 10
        Me.lblTransDate.Text = "LastTransDate"
        '
        'lblLastAmountPaid
        '
        Me.lblLastAmountPaid.AutoSize = True
        Me.lblLastAmountPaid.Location = New System.Drawing.Point(238, 22)
        Me.lblLastAmountPaid.Name = "lblLastAmountPaid"
        Me.lblLastAmountPaid.Size = New System.Drawing.Size(100, 19)
        Me.lblLastAmountPaid.TabIndex = 9
        Me.lblLastAmountPaid.Text = "LastAmountPaid"
        '
        'lblDp
        '
        Me.lblDp.AutoSize = True
        Me.lblDp.Location = New System.Drawing.Point(157, 118)
        Me.lblDp.Name = "lblDp"
        Me.lblDp.Size = New System.Drawing.Size(90, 19)
        Me.lblDp.TabIndex = 8
        Me.lblDp.Text = "DownPayment"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(158, 137)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(54, 19)
        Me.lblBalance.TabIndex = 7
        Me.lblBalance.Text = "Balance"
        '
        'lbltotalassessment
        '
        Me.lbltotalassessment.AutoSize = True
        Me.lbltotalassessment.Location = New System.Drawing.Point(157, 99)
        Me.lbltotalassessment.Name = "lbltotalassessment"
        Me.lbltotalassessment.Size = New System.Drawing.Size(105, 19)
        Me.lbltotalassessment.TabIndex = 6
        Me.lbltotalassessment.Text = "TotalAssessment"
        '
        'lblMiscFee
        '
        Me.lblMiscFee.AutoSize = True
        Me.lblMiscFee.Location = New System.Drawing.Point(157, 80)
        Me.lblMiscFee.Name = "lblMiscFee"
        Me.lblMiscFee.Size = New System.Drawing.Size(55, 19)
        Me.lblMiscFee.TabIndex = 5
        Me.lblMiscFee.Text = "MiscFee"
        '
        'lblLabFee
        '
        Me.lblLabFee.AutoSize = True
        Me.lblLabFee.Location = New System.Drawing.Point(157, 51)
        Me.lblLabFee.Name = "lblLabFee"
        Me.lblLabFee.Size = New System.Drawing.Size(49, 19)
        Me.lblLabFee.TabIndex = 4
        Me.lblLabFee.Text = "LabFee"
        '
        'lblTuitionFee
        '
        Me.lblTuitionFee.AutoSize = True
        Me.lblTuitionFee.Location = New System.Drawing.Point(157, 22)
        Me.lblTuitionFee.Name = "lblTuitionFee"
        Me.lblTuitionFee.Size = New System.Drawing.Size(67, 19)
        Me.lblTuitionFee.TabIndex = 3
        Me.lblTuitionFee.Text = "TuitionFee"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(18, 110)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(44, 19)
        Me.lblstatus.TabIndex = 2
        Me.lblstatus.Text = "Status"
        '
        'lblamountgranted
        '
        Me.lblamountgranted.AutoSize = True
        Me.lblamountgranted.Location = New System.Drawing.Point(18, 80)
        Me.lblamountgranted.Name = "lblamountgranted"
        Me.lblamountgranted.Size = New System.Drawing.Size(103, 19)
        Me.lblamountgranted.TabIndex = 1
        Me.lblamountgranted.Text = "Amount Granted"
        '
        'frmCertification
        '
        Me.AcceptButton = Me.btnStudeReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(865, 420)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCertification"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENTS' REPORT"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboStudeReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblScholarship As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents lblamountgranted As System.Windows.Forms.Label
    Friend WithEvents lbltotalassessment As System.Windows.Forms.Label
    Friend WithEvents lblMiscFee As System.Windows.Forms.Label
    Friend WithEvents lblLabFee As System.Windows.Forms.Label
    Friend WithEvents lblTuitionFee As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblDp As System.Windows.Forms.Label
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents lblLastAmountPaid As System.Windows.Forms.Label
    Friend WithEvents lblSchedPay As System.Windows.Forms.Label
    Friend WithEvents lblday As System.Windows.Forms.Label
    Friend WithEvents lblYearLevelStat As System.Windows.Forms.Label
End Class
