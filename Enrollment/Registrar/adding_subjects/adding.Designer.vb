<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdding
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
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsClear = New System.Windows.Forms.ToolStripButton
        Me.lblSection = New System.Windows.Forms.Label
        Me.txtTotalUnits = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalLab = New System.Windows.Forms.TextBox
        Me.txtTotalLecUnits = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtCourseCode = New System.Windows.Forms.TextBox
        Me.btnRemoveSubjects = New System.Windows.Forms.Button
        Me.btnAddSubject = New System.Windows.Forms.Button
        Me.btnAddStudent = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsFind = New System.Windows.Forms.ToolStripButton
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblYearLevel = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lvCOR = New System.Windows.Forms.ListView
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblTotalUnits = New System.Windows.Forms.Label
        Me.lblNewTotalUnits = New System.Windows.Forms.Label
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.lblSlot = New System.Windows.Forms.Label
        Me.lblFinalSlot = New System.Windows.Forms.Label
        Me.lblSubjectCode = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblOldTotalUnits = New System.Windows.Forms.Label
        Me.lblLabFee = New System.Windows.Forms.Label
        Me.lblCurrentSpecialLal = New System.Windows.Forms.Label
        Me.lblFinalSpecialLab = New System.Windows.Forms.Label
        Me.lblYearLevelStat = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'tsClear
        '
        Me.tsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClear.Name = "tsClear"
        Me.tsClear.Size = New System.Drawing.Size(23, 36)
        Me.tsClear.Text = "Clear Fields"
        Me.tsClear.Visible = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(16, 395)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(43, 13)
        Me.lblSection.TabIndex = 73
        Me.lblSection.Text = "Section"
        Me.lblSection.Visible = False
        '
        'txtTotalUnits
        '
        Me.txtTotalUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUnits.Location = New System.Drawing.Point(659, 381)
        Me.txtTotalUnits.Name = "txtTotalUnits"
        Me.txtTotalUnits.ReadOnly = True
        Me.txtTotalUnits.Size = New System.Drawing.Size(123, 30)
        Me.txtTotalUnits.TabIndex = 72
        Me.txtTotalUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CORToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 55)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(886, 24)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CORToolStripMenuItem
        '
        Me.CORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AddStudentToolStripMenuItem, Me.AddSubjectsToolStripMenuItem})
        Me.CORToolStripMenuItem.Name = "CORToolStripMenuItem"
        Me.CORToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.CORToolStripMenuItem.Text = "COR"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AddSubjectsToolStripMenuItem
        '
        Me.AddSubjectsToolStripMenuItem.Name = "AddSubjectsToolStripMenuItem"
        Me.AddSubjectsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.AddSubjectsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddSubjectsToolStripMenuItem.Text = "Add Subjects"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Lec/Lab Units"
        '
        'txtTotalLab
        '
        Me.txtTotalLab.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLab.Location = New System.Drawing.Point(449, 381)
        Me.txtTotalLab.Name = "txtTotalLab"
        Me.txtTotalLab.ReadOnly = True
        Me.txtTotalLab.Size = New System.Drawing.Size(94, 30)
        Me.txtTotalLab.TabIndex = 70
        Me.txtTotalLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLecUnits
        '
        Me.txtTotalLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnits.Location = New System.Drawing.Point(349, 381)
        Me.txtTotalLecUnits.Name = "txtTotalLecUnits"
        Me.txtTotalLecUnits.ReadOnly = True
        Me.txtTotalLecUnits.Size = New System.Drawing.Size(94, 30)
        Me.txtTotalLecUnits.TabIndex = 69
        Me.txtTotalLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(549, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "TOTAL UNITS"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(349, 470)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(194, 20)
        Me.txtCourse.TabIndex = 66
        Me.txtCourse.Visible = False
        Me.txtCourse.WordWrap = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCourseCode)
        Me.Panel2.Controls.Add(Me.btnRemoveSubjects)
        Me.Panel2.Controls.Add(Me.btnAddSubject)
        Me.Panel2.Controls.Add(Me.btnAddStudent)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 46)
        Me.Panel2.TabIndex = 65
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(83, 11)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(321, 20)
        Me.txtCourseCode.TabIndex = 82
        Me.txtCourseCode.Visible = False
        Me.txtCourseCode.WordWrap = False
        '
        'btnRemoveSubjects
        '
        Me.btnRemoveSubjects.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveSubjects.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSubjects.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemoveSubjects.Location = New System.Drawing.Point(653, 5)
        Me.btnRemoveSubjects.Name = "btnRemoveSubjects"
        Me.btnRemoveSubjects.Size = New System.Drawing.Size(111, 35)
        Me.btnRemoveSubjects.TabIndex = 9
        Me.btnRemoveSubjects.Text = "&Remove Subjects"
        Me.btnRemoveSubjects.UseVisualStyleBackColor = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddSubject.Location = New System.Drawing.Point(536, 5)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(111, 35)
        Me.btnAddSubject.TabIndex = 8
        Me.btnAddSubject.Text = "&Add Subjects "
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(419, 5)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(111, 35)
        Me.btnAddStudent.TabIndex = 7
        Me.btnAddStudent.Text = "Select Student "
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(9, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 24)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "ADD SUBJECTS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsFind, Me.tsClear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(789, 39)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = Global.SIMS.My.Resources.Resources.Save_icon__1_
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(72, 36)
        Me.tsSave.Text = "Save"
        '
        'tsFind
        '
        Me.tsFind.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFind.Image = Global.SIMS.My.Resources.Resources.Start_Menu_Search_icon
        Me.tsFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFind.Name = "tsFind"
        Me.tsFind.Size = New System.Drawing.Size(175, 36)
        Me.tsFind.Text = "Search Existing Record"
        Me.tsFind.Visible = False
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(160, 71)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(157, 25)
        Me.mskStudentNumber.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblYearLevel)
        Me.GroupBox2.Controls.Add(Me.lblSection)
        Me.GroupBox2.Controls.Add(Me.txtTotalUnits)
        Me.GroupBox2.Controls.Add(Me.txtTotalLab)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTotalLecUnits)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.lvCOR)
        Me.GroupBox2.Controls.Add(Me.txtMiddleName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(788, 420)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(174, 393)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(58, 13)
        Me.lblYearLevel.TabIndex = 69
        Me.lblYearLevel.Text = "Year Level"
        Me.lblYearLevel.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(633, 71)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(149, 25)
        Me.txtLastName.TabIndex = 5
        '
        'lvCOR
        '
        Me.lvCOR.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCOR.ForeColor = System.Drawing.Color.Black
        Me.lvCOR.FullRowSelect = True
        Me.lvCOR.Location = New System.Drawing.Point(6, 102)
        Me.lvCOR.Name = "lvCOR"
        Me.lvCOR.Size = New System.Drawing.Size(777, 277)
        Me.lvCOR.TabIndex = 0
        Me.lvCOR.UseCompatibleStateImageBehavior = False
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.Location = New System.Drawing.Point(478, 71)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(149, 25)
        Me.txtMiddleName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(323, 71)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(149, 25)
        Me.txtFirstName.TabIndex = 3
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.AutoSize = True
        Me.lblTotalUnits.Location = New System.Drawing.Point(259, 473)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalUnits.TabIndex = 69
        Me.lblTotalUnits.Text = "Total Units"
        Me.lblTotalUnits.Visible = False
        '
        'lblNewTotalUnits
        '
        Me.lblNewTotalUnits.AutoSize = True
        Me.lblNewTotalUnits.Location = New System.Drawing.Point(174, 473)
        Me.lblNewTotalUnits.Name = "lblNewTotalUnits"
        Me.lblNewTotalUnits.Size = New System.Drawing.Size(67, 13)
        Me.lblNewTotalUnits.TabIndex = 70
        Me.lblNewTotalUnits.Text = "New Total U"
        Me.lblNewTotalUnits.Visible = False
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(42, 470)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(100, 20)
        Me.txtMajor.TabIndex = 71
        Me.txtMajor.Visible = False
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(463, 32)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(54, 13)
        Me.lblSettingsID.TabIndex = 72
        Me.lblSettingsID.Text = "settingsID"
        Me.lblSettingsID.Visible = False
        '
        'lblSlot
        '
        Me.lblSlot.AutoSize = True
        Me.lblSlot.Location = New System.Drawing.Point(594, 29)
        Me.lblSlot.Name = "lblSlot"
        Me.lblSlot.Size = New System.Drawing.Size(13, 13)
        Me.lblSlot.TabIndex = 75
        Me.lblSlot.Text = "0"
        Me.lblSlot.Visible = False
        '
        'lblFinalSlot
        '
        Me.lblFinalSlot.AutoSize = True
        Me.lblFinalSlot.Location = New System.Drawing.Point(656, 32)
        Me.lblFinalSlot.Name = "lblFinalSlot"
        Me.lblFinalSlot.Size = New System.Drawing.Size(13, 13)
        Me.lblFinalSlot.TabIndex = 74
        Me.lblFinalSlot.Text = "0"
        Me.lblFinalSlot.Visible = False
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.AutoSize = True
        Me.lblSubjectCode.Location = New System.Drawing.Point(215, 23)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(71, 13)
        Me.lblSubjectCode.TabIndex = 76
        Me.lblSubjectCode.Text = "Subject Code"
        Me.lblSubjectCode.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(330, 23)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 77
        Me.lblDescription.Text = "Description"
        Me.lblDescription.Visible = False
        '
        'lblOldTotalUnits
        '
        Me.lblOldTotalUnits.AutoSize = True
        Me.lblOldTotalUnits.Location = New System.Drawing.Point(571, 477)
        Me.lblOldTotalUnits.Name = "lblOldTotalUnits"
        Me.lblOldTotalUnits.Size = New System.Drawing.Size(56, 13)
        Me.lblOldTotalUnits.TabIndex = 78
        Me.lblOldTotalUnits.Text = "Final Total"
        Me.lblOldTotalUnits.Visible = False
        '
        'lblLabFee
        '
        Me.lblLabFee.AutoSize = True
        Me.lblLabFee.Location = New System.Drawing.Point(702, 32)
        Me.lblLabFee.Name = "lblLabFee"
        Me.lblLabFee.Size = New System.Drawing.Size(13, 13)
        Me.lblLabFee.TabIndex = 79
        Me.lblLabFee.Text = "0"
        Me.lblLabFee.Visible = False
        '
        'lblCurrentSpecialLal
        '
        Me.lblCurrentSpecialLal.AutoSize = True
        Me.lblCurrentSpecialLal.Location = New System.Drawing.Point(702, 9)
        Me.lblCurrentSpecialLal.Name = "lblCurrentSpecialLal"
        Me.lblCurrentSpecialLal.Size = New System.Drawing.Size(13, 13)
        Me.lblCurrentSpecialLal.TabIndex = 80
        Me.lblCurrentSpecialLal.Text = "0"
        Me.lblCurrentSpecialLal.Visible = False
        '
        'lblFinalSpecialLab
        '
        Me.lblFinalSpecialLab.AutoSize = True
        Me.lblFinalSpecialLab.Location = New System.Drawing.Point(736, 29)
        Me.lblFinalSpecialLab.Name = "lblFinalSpecialLab"
        Me.lblFinalSpecialLab.Size = New System.Drawing.Size(13, 13)
        Me.lblFinalSpecialLab.TabIndex = 81
        Me.lblFinalSpecialLab.Text = "0"
        Me.lblFinalSpecialLab.Visible = False
        '
        'lblYearLevelStat
        '
        Me.lblYearLevelStat.AutoSize = True
        Me.lblYearLevelStat.Location = New System.Drawing.Point(684, 476)
        Me.lblYearLevelStat.Name = "lblYearLevelStat"
        Me.lblYearLevelStat.Size = New System.Drawing.Size(39, 13)
        Me.lblYearLevelStat.TabIndex = 82
        Me.lblYearLevelStat.Text = "Label4"
        Me.lblYearLevelStat.Visible = False
        '
        'frmAdding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 502)
        Me.Controls.Add(Me.lblYearLevelStat)
        Me.Controls.Add(Me.lblFinalSpecialLab)
        Me.Controls.Add(Me.lblCurrentSpecialLal)
        Me.Controls.Add(Me.lblLabFee)
        Me.Controls.Add(Me.lblOldTotalUnits)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSubjectCode)
        Me.Controls.Add(Me.lblSlot)
        Me.Controls.Add(Me.lblSettingsID)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.lblFinalSlot)
        Me.Controls.Add(Me.lblNewTotalUnits)
        Me.Controls.Add(Me.lblTotalUnits)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdding"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adding Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents txtTotalUnits As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLab As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lvCOR As System.Windows.Forms.ListView
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveSubjects As System.Windows.Forms.Button
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblTotalUnits As System.Windows.Forms.Label
    Friend WithEvents lblNewTotalUnits As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents lblSlot As System.Windows.Forms.Label
    Friend WithEvents lblFinalSlot As System.Windows.Forms.Label
    Friend WithEvents lblSubjectCode As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalUnits As System.Windows.Forms.Label
    Friend WithEvents lblLabFee As System.Windows.Forms.Label
    Friend WithEvents lblCurrentSpecialLal As System.Windows.Forms.Label
    Friend WithEvents lblFinalSpecialLab As System.Windows.Forms.Label
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevelStat As System.Windows.Forms.Label
End Class
