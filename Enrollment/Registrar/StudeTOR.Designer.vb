<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeTOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudeTOR))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mskStudeNumber = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.rdoOld = New System.Windows.Forms.RadioButton
        Me.rdoNew = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtChecked = New System.Windows.Forms.TextBox
        Me.txtCheckPosition = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCertifiedPosition = New System.Windows.Forms.TextBox
        Me.txtCertified = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtORNumber = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDatePaid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPreparedByPosition = New System.Windows.Forms.TextBox
        Me.txtPreparedBy = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.rdoTransferee = New System.Windows.Forms.RadioButton
        Me.lblCourse = New System.Windows.Forms.Label
        Me.lblCouseGroup = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDateIssued = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mskStudeNumber)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 92)
        Me.Panel1.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(229, 7)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 26)
        Me.btnSelect.TabIndex = 47
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(49, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(107, 38)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(337, 51)
        Me.txtRemarks.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Student No."
        '
        'mskStudeNumber
        '
        Me.mskStudeNumber.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudeNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudeNumber.Location = New System.Drawing.Point(107, 7)
        Me.mskStudeNumber.Name = "mskStudeNumber"
        Me.mskStudeNumber.ReadOnly = True
        Me.mskStudeNumber.Size = New System.Drawing.Size(116, 25)
        Me.mskStudeNumber.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(165, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 17)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPreview.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(348, 350)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(97, 41)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'rdoOld
        '
        Me.rdoOld.AutoSize = True
        Me.rdoOld.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOld.Location = New System.Drawing.Point(223, 354)
        Me.rdoOld.Name = "rdoOld"
        Me.rdoOld.Size = New System.Drawing.Size(46, 23)
        Me.rdoOld.TabIndex = 13
        Me.rdoOld.TabStop = True
        Me.rdoOld.Text = "Old"
        Me.rdoOld.UseVisualStyleBackColor = True
        '
        'rdoNew
        '
        Me.rdoNew.AutoSize = True
        Me.rdoNew.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNew.Location = New System.Drawing.Point(289, 354)
        Me.rdoNew.Name = "rdoNew"
        Me.rdoNew.Size = New System.Drawing.Size(53, 23)
        Me.rdoNew.TabIndex = 14
        Me.rdoNew.TabStop = True
        Me.rdoNew.Text = "New"
        Me.rdoNew.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Checked by"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Certified by"
        '
        'txtChecked
        '
        Me.txtChecked.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChecked.Location = New System.Drawing.Point(108, 185)
        Me.txtChecked.Name = "txtChecked"
        Me.txtChecked.Size = New System.Drawing.Size(337, 26)
        Me.txtChecked.TabIndex = 5
        '
        'txtCheckPosition
        '
        Me.txtCheckPosition.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckPosition.Location = New System.Drawing.Point(108, 217)
        Me.txtCheckPosition.Name = "txtCheckPosition"
        Me.txtCheckPosition.Size = New System.Drawing.Size(116, 26)
        Me.txtCheckPosition.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Position"
        '
        'txtCertifiedPosition
        '
        Me.txtCertifiedPosition.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertifiedPosition.Location = New System.Drawing.Point(108, 281)
        Me.txtCertifiedPosition.Name = "txtCertifiedPosition"
        Me.txtCertifiedPosition.Size = New System.Drawing.Size(116, 26)
        Me.txtCertifiedPosition.TabIndex = 8
        '
        'txtCertified
        '
        Me.txtCertified.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertified.Location = New System.Drawing.Point(108, 249)
        Me.txtCertified.Name = "txtCertified"
        Me.txtCertified.Size = New System.Drawing.Size(337, 26)
        Me.txtCertified.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "O.R. No."
        '
        'txtORNumber
        '
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNumber.Location = New System.Drawing.Point(108, 313)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(116, 26)
        Me.txtORNumber.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date Paid"
        '
        'txtDatePaid
        '
        Me.txtDatePaid.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatePaid.Location = New System.Drawing.Point(317, 317)
        Me.txtDatePaid.Name = "txtDatePaid"
        Me.txtDatePaid.Size = New System.Drawing.Size(128, 26)
        Me.txtDatePaid.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Position"
        '
        'txtPreparedByPosition
        '
        Me.txtPreparedByPosition.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedByPosition.Location = New System.Drawing.Point(108, 154)
        Me.txtPreparedByPosition.Name = "txtPreparedByPosition"
        Me.txtPreparedByPosition.Size = New System.Drawing.Size(116, 26)
        Me.txtPreparedByPosition.TabIndex = 4
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedBy.Location = New System.Drawing.Point(108, 122)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(337, 26)
        Me.txtPreparedBy.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Prepared by"
        '
        'rdoTransferee
        '
        Me.rdoTransferee.AutoSize = True
        Me.rdoTransferee.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTransferee.Location = New System.Drawing.Point(127, 354)
        Me.rdoTransferee.Name = "rdoTransferee"
        Me.rdoTransferee.Size = New System.Drawing.Size(89, 23)
        Me.rdoTransferee.TabIndex = 12
        Me.rdoTransferee.TabStop = True
        Me.rdoTransferee.Text = "Transferee"
        Me.rdoTransferee.UseVisualStyleBackColor = True
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(251, 157)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblCourse.TabIndex = 23
        Me.lblCourse.Text = "Course"
        Me.lblCourse.Visible = False
        '
        'lblCouseGroup
        '
        Me.lblCouseGroup.AutoSize = True
        Me.lblCouseGroup.Location = New System.Drawing.Point(251, 224)
        Me.lblCouseGroup.Name = "lblCouseGroup"
        Me.lblCouseGroup.Size = New System.Drawing.Size(72, 13)
        Me.lblCouseGroup.TabIndex = 25
        Me.lblCouseGroup.Text = "Course Group"
        Me.lblCouseGroup.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(230, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Date Issued"
        '
        'txtDateIssued
        '
        Me.txtDateIssued.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateIssued.Location = New System.Drawing.Point(317, 285)
        Me.txtDateIssued.Name = "txtDateIssued"
        Me.txtDateIssued.Size = New System.Drawing.Size(128, 26)
        Me.txtDateIssued.TabIndex = 9
        '
        'frmStudeTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(452, 394)
        Me.Controls.Add(Me.txtDateIssued)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCouseGroup)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.rdoTransferee)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPreparedByPosition)
        Me.Controls.Add(Me.txtPreparedBy)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDatePaid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCertifiedPosition)
        Me.Controls.Add(Me.txtCertified)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCheckPosition)
        Me.Controls.Add(Me.txtChecked)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdoNew)
        Me.Controls.Add(Me.rdoOld)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPreview)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudeTOR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student's TOR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskStudeNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents rdoOld As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNew As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtChecked As System.Windows.Forms.TextBox
    Friend WithEvents txtCheckPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCertifiedPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtCertified As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtORNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDatePaid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPreparedByPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtPreparedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdoTransferee As System.Windows.Forms.RadioButton
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblCouseGroup As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDateIssued As System.Windows.Forms.TextBox
End Class
