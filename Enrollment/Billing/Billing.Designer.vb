<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilling
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.lblID = New System.Windows.Forms.Label
        Me.txtLabRate = New System.Windows.Forms.TextBox
        Me.txtLecRate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPayments = New System.Windows.Forms.TextBox
        Me.txtTotalLabUnits = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTotalAcct = New System.Windows.Forms.TextBox
        Me.btnCompute = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtTotalFees = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.lvAccts = New System.Windows.Forms.ListView
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnRemoveFees = New System.Windows.Forms.Button
        Me.btnAddFees = New System.Windows.Forms.Button
        Me.mskStudentNumber = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnLoadUpdatedFees = New System.Windows.Forms.Button
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblTotalLab = New System.Windows.Forms.Label
        Me.lblSpecialLabFee = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSpecialTuition = New System.Windows.Forms.TextBox
        Me.txtTotalLabDay = New System.Windows.Forms.TextBox
        Me.txtTotalLecDay = New System.Windows.Forms.TextBox
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.txtOldAccount = New System.Windows.Forms.TextBox
        Me.btnOldAcct = New System.Windows.Forms.Button
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtTotalLecUnits = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTuition = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtLab = New System.Windows.Forms.TextBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cboCourse = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtTotalLabNight = New System.Windows.Forms.TextBox
        Me.txtTotalLecNight = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtLabRateNight = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtLecRateNight = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalLabUnitsNight = New System.Windows.Forms.TextBox
        Me.txtTotalLecUnitsNight = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.lblMajor = New System.Windows.Forms.Label
        Me.lblEnrolled = New System.Windows.Forms.Label
        Me.InstallmentfeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New SIMS.DataSet2
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPayment = New System.Windows.Forms.Button
        Me.btnPaymentHistory = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsNew = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsViewAccounts = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallmentfeeTableAdapter = New SIMS.DataSet2TableAdapters.installmentfeeTableAdapter
        Me.btnAddLabFees = New System.Windows.Forms.Button
        Me.btnAddOldAcct = New System.Windows.Forms.Button
        Me.Panel6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.InstallmentfeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(281, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtLabRate
        '
        Me.txtLabRate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLabRate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabRate.ForeColor = System.Drawing.Color.Black
        Me.txtLabRate.Location = New System.Drawing.Point(232, 3)
        Me.txtLabRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLabRate.Name = "txtLabRate"
        Me.txtLabRate.Size = New System.Drawing.Size(77, 26)
        Me.txtLabRate.TabIndex = 29
        Me.txtLabRate.TabStop = False
        Me.txtLabRate.Text = "0"
        Me.txtLabRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLecRate
        '
        Me.txtLecRate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLecRate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecRate.ForeColor = System.Drawing.Color.Black
        Me.txtLecRate.Location = New System.Drawing.Point(232, 4)
        Me.txtLecRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLecRate.Name = "txtLecRate"
        Me.txtLecRate.Size = New System.Drawing.Size(77, 26)
        Me.txtLecRate.TabIndex = 28
        Me.txtLecRate.TabStop = False
        Me.txtLecRate.Text = "0"
        Me.txtLecRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(174, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 19)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Rate"
        '
        'txtPayments
        '
        Me.txtPayments.BackColor = System.Drawing.Color.DarkOrange
        Me.txtPayments.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayments.ForeColor = System.Drawing.Color.Black
        Me.txtPayments.Location = New System.Drawing.Point(121, 0)
        Me.txtPayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(192, 30)
        Me.txtPayments.TabIndex = 19
        Me.txtPayments.TabStop = False
        Me.txtPayments.Text = "0"
        Me.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLabUnits
        '
        Me.txtTotalLabUnits.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLabUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLabUnits.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLabUnits.Location = New System.Drawing.Point(91, 4)
        Me.txtTotalLabUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLabUnits.Name = "txtTotalLabUnits"
        Me.txtTotalLabUnits.Size = New System.Drawing.Size(78, 26)
        Me.txtTotalLabUnits.TabIndex = 10
        Me.txtTotalLabUnits.TabStop = False
        Me.txtTotalLabUnits.Text = "0"
        Me.txtTotalLabUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(15, 7)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 19)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Lab Units"
        '
        'txtTotalAcct
        '
        Me.txtTotalAcct.BackColor = System.Drawing.Color.Chartreuse
        Me.txtTotalAcct.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAcct.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAcct.Location = New System.Drawing.Point(121, 1)
        Me.txtTotalAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalAcct.Name = "txtTotalAcct"
        Me.txtTotalAcct.Size = New System.Drawing.Size(191, 30)
        Me.txtTotalAcct.TabIndex = 18
        Me.txtTotalAcct.TabStop = False
        Me.txtTotalAcct.Text = "0"
        Me.txtTotalAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.Black
        Me.btnCompute.Location = New System.Drawing.Point(406, 2)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(122, 42)
        Me.btnCompute.TabIndex = 21
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboYear.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboYear.Location = New System.Drawing.Point(99, 3)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(139, 27)
        Me.cboYear.TabIndex = 6
        Me.cboYear.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student No."
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(389, 4)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(139, 26)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.TabStop = False
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(99, 4)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(139, 26)
        Me.txtFname.TabIndex = 2
        Me.txtFname.TabStop = False
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(244, 4)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(139, 26)
        Me.txtMName.TabIndex = 3
        Me.txtMName.TabStop = False
        '
        'txtTotalFees
        '
        Me.txtTotalFees.BackColor = System.Drawing.Color.Chartreuse
        Me.txtTotalFees.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFees.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFees.Location = New System.Drawing.Point(386, 488)
        Me.txtTotalFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.Size = New System.Drawing.Size(146, 30)
        Me.txtTotalFees.TabIndex = 23
        Me.txtTotalFees.TabStop = False
        Me.txtTotalFees.Text = "0"
        Me.txtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Chartreuse
        Me.txtBalance.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.Black
        Me.txtBalance.Location = New System.Drawing.Point(121, 1)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(191, 30)
        Me.txtBalance.TabIndex = 39
        Me.txtBalance.TabStop = False
        Me.txtBalance.Text = "0"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvAccts
        '
        Me.lvAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccts.ForeColor = System.Drawing.Color.Black
        Me.lvAccts.Location = New System.Drawing.Point(0, 228)
        Me.lvAccts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvAccts.Name = "lvAccts"
        Me.lvAccts.Size = New System.Drawing.Size(532, 252)
        Me.lvAccts.TabIndex = 20
        Me.lvAccts.TabStop = False
        Me.lvAccts.UseCompatibleStateImageBehavior = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Controls.Add(Me.btnRemoveFees)
        Me.Panel6.Controls.Add(Me.btnAddFees)
        Me.Panel6.Controls.Add(Me.btnCompute)
        Me.Panel6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 177)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(532, 47)
        Me.Panel6.TabIndex = 19
        '
        'btnRemoveFees
        '
        Me.btnRemoveFees.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFees.Location = New System.Drawing.Point(278, 2)
        Me.btnRemoveFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoveFees.Name = "btnRemoveFees"
        Me.btnRemoveFees.Size = New System.Drawing.Size(122, 42)
        Me.btnRemoveFees.TabIndex = 2
        Me.btnRemoveFees.Text = "Remove Fees"
        Me.btnRemoveFees.UseVisualStyleBackColor = True
        '
        'btnAddFees
        '
        Me.btnAddFees.Location = New System.Drawing.Point(150, 2)
        Me.btnAddFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddFees.Name = "btnAddFees"
        Me.btnAddFees.Size = New System.Drawing.Size(122, 42)
        Me.btnAddFees.TabIndex = 1
        Me.btnAddFees.Text = "Add Fees"
        Me.btnAddFees.UseVisualStyleBackColor = True
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.Location = New System.Drawing.Point(99, 3)
        Me.mskStudentNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(139, 26)
        Me.mskStudentNumber.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 62)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(873, 555)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLoadUpdatedFees)
        Me.TabPage1.Controls.Add(Me.lblSettingsID)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.lblID)
        Me.TabPage1.Controls.Add(Me.lvAccts)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.txtTotalFees)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(865, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Account Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLoadUpdatedFees
        '
        Me.btnLoadUpdatedFees.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadUpdatedFees.Location = New System.Drawing.Point(6, 483)
        Me.btnLoadUpdatedFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLoadUpdatedFees.Name = "btnLoadUpdatedFees"
        Me.btnLoadUpdatedFees.Size = New System.Drawing.Size(130, 36)
        Me.btnLoadUpdatedFees.TabIndex = 22
        Me.btnLoadUpdatedFees.Text = "Load Updated Fees"
        Me.btnLoadUpdatedFees.UseVisualStyleBackColor = True
        Me.btnLoadUpdatedFees.Visible = False
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(357, 24)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(89, 20)
        Me.lblSettingsID.TabIndex = 53
        Me.lblSettingsID.Text = "Settings ID"
        Me.lblSettingsID.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalLab)
        Me.GroupBox3.Controls.Add(Me.lblSpecialLabFee)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.txtTotalLabDay)
        Me.GroupBox3.Controls.Add(Me.txtTotalLecDay)
        Me.GroupBox3.Controls.Add(Me.Panel15)
        Me.GroupBox3.Controls.Add(Me.Panel14)
        Me.GroupBox3.Controls.Add(Me.Panel13)
        Me.GroupBox3.Controls.Add(Me.Panel12)
        Me.GroupBox3.Controls.Add(Me.Panel11)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(538, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 510)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Summary"
        '
        'lblTotalLab
        '
        Me.lblTotalLab.AutoSize = True
        Me.lblTotalLab.Location = New System.Drawing.Point(119, 174)
        Me.lblTotalLab.Name = "lblTotalLab"
        Me.lblTotalLab.Size = New System.Drawing.Size(16, 19)
        Me.lblTotalLab.TabIndex = 67
        Me.lblTotalLab.Text = "0"
        Me.lblTotalLab.Visible = False
        '
        'lblSpecialLabFee
        '
        Me.lblSpecialLabFee.AutoSize = True
        Me.lblSpecialLabFee.Location = New System.Drawing.Point(46, 173)
        Me.lblSpecialLabFee.Name = "lblSpecialLabFee"
        Me.lblSpecialLabFee.Size = New System.Drawing.Size(16, 19)
        Me.lblSpecialLabFee.TabIndex = 62
        Me.lblSpecialLabFee.Text = "0"
        Me.lblSpecialLabFee.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSpecialTuition)
        Me.Panel1.Location = New System.Drawing.Point(6, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 33)
        Me.Panel1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Special Tuition Fee"
        '
        'txtSpecialTuition
        '
        Me.txtSpecialTuition.BackColor = System.Drawing.Color.White
        Me.txtSpecialTuition.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecialTuition.ForeColor = System.Drawing.Color.Black
        Me.txtSpecialTuition.Location = New System.Drawing.Point(149, 1)
        Me.txtSpecialTuition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSpecialTuition.Name = "txtSpecialTuition"
        Me.txtSpecialTuition.Size = New System.Drawing.Size(160, 30)
        Me.txtSpecialTuition.TabIndex = 12
        Me.txtSpecialTuition.TabStop = False
        Me.txtSpecialTuition.Text = "0"
        Me.txtSpecialTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLabDay
        '
        Me.txtTotalLabDay.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLabDay.Location = New System.Drawing.Point(241, 313)
        Me.txtTotalLabDay.Name = "txtTotalLabDay"
        Me.txtTotalLabDay.Size = New System.Drawing.Size(77, 26)
        Me.txtTotalLabDay.TabIndex = 66
        Me.txtTotalLabDay.Text = "0"
        Me.txtTotalLabDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLabDay.Visible = False
        '
        'txtTotalLecDay
        '
        Me.txtTotalLecDay.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecDay.Location = New System.Drawing.Point(98, 314)
        Me.txtTotalLecDay.Name = "txtTotalLecDay"
        Me.txtTotalLecDay.Size = New System.Drawing.Size(77, 26)
        Me.txtTotalLecDay.TabIndex = 65
        Me.txtTotalLecDay.Text = "0"
        Me.txtTotalLecDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLecDay.Visible = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel15.Controls.Add(Me.txtOldAccount)
        Me.Panel15.Controls.Add(Me.btnOldAcct)
        Me.Panel15.Location = New System.Drawing.Point(6, 43)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(312, 33)
        Me.Panel15.TabIndex = 58
        '
        'txtOldAccount
        '
        Me.txtOldAccount.BackColor = System.Drawing.Color.Chartreuse
        Me.txtOldAccount.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOldAccount.Location = New System.Drawing.Point(191, 0)
        Me.txtOldAccount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldAccount.Multiline = True
        Me.txtOldAccount.Name = "txtOldAccount"
        Me.txtOldAccount.Size = New System.Drawing.Size(118, 31)
        Me.txtOldAccount.TabIndex = 32
        Me.txtOldAccount.TabStop = False
        Me.txtOldAccount.Text = "0"
        Me.txtOldAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOldAcct
        '
        Me.btnOldAcct.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOldAcct.ForeColor = System.Drawing.Color.Black
        Me.btnOldAcct.Location = New System.Drawing.Point(98, 1)
        Me.btnOldAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOldAcct.Name = "btnOldAcct"
        Me.btnOldAcct.Size = New System.Drawing.Size(87, 30)
        Me.btnOldAcct.TabIndex = 22
        Me.btnOldAcct.TabStop = False
        Me.btnOldAcct.Text = "View Old Acct."
        Me.ToolTip1.SetToolTip(Me.btnOldAcct, "Old Account")
        Me.btnOldAcct.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Label15)
        Me.Panel14.Controls.Add(Me.txtBalance)
        Me.Panel14.Location = New System.Drawing.Point(6, 468)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(315, 33)
        Me.Panel14.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Current Balance"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.txtPayments)
        Me.Panel13.Location = New System.Drawing.Point(6, 430)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(315, 33)
        Me.Panel13.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Payments"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.txtTotalAcct)
        Me.Panel12.Location = New System.Drawing.Point(6, 352)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(315, 33)
        Me.Panel12.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(14, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 19)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Total Account"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Controls.Add(Me.txtDiscount)
        Me.Panel11.Location = New System.Drawing.Point(6, 391)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(315, 33)
        Me.Panel11.TabIndex = 58
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(14, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 19)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(121, 1)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(192, 30)
        Me.txtDiscount.TabIndex = 40
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.txtTotalLecUnits)
        Me.Panel4.Controls.Add(Me.txtLecRate)
        Me.Panel4.Location = New System.Drawing.Point(7, 239)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 33)
        Me.Panel4.TabIndex = 57
        Me.Panel4.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(14, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 19)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Lec Units"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(174, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 19)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Rate"
        '
        'txtTotalLecUnits
        '
        Me.txtTotalLecUnits.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnits.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLecUnits.Location = New System.Drawing.Point(91, 3)
        Me.txtTotalLecUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLecUnits.Name = "txtTotalLecUnits"
        Me.txtTotalLecUnits.Size = New System.Drawing.Size(77, 26)
        Me.txtTotalLecUnits.TabIndex = 9
        Me.txtTotalLecUnits.TabStop = False
        Me.txtTotalLecUnits.Text = "0"
        Me.txtTotalLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.txtTotalLabUnits)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtLabRate)
        Me.Panel7.Location = New System.Drawing.Point(7, 277)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(312, 33)
        Me.Panel7.TabIndex = 58
        Me.Panel7.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtTuition)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtLab)
        Me.Panel3.Location = New System.Drawing.Point(6, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 33)
        Me.Panel3.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tuition Fee"
        '
        'txtTuition
        '
        Me.txtTuition.BackColor = System.Drawing.Color.White
        Me.txtTuition.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuition.ForeColor = System.Drawing.Color.Black
        Me.txtTuition.Location = New System.Drawing.Point(91, 1)
        Me.txtTuition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.ReadOnly = True
        Me.txtTuition.Size = New System.Drawing.Size(77, 30)
        Me.txtTuition.TabIndex = 11
        Me.txtTuition.TabStop = False
        Me.txtTuition.Text = "0"
        Me.txtTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(174, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Lab Fee"
        '
        'txtLab
        '
        Me.txtLab.BackColor = System.Drawing.Color.White
        Me.txtLab.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLab.ForeColor = System.Drawing.Color.Black
        Me.txtLab.Location = New System.Drawing.Point(232, 1)
        Me.txtLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(77, 30)
        Me.txtLab.TabIndex = 12
        Me.txtLab.TabStop = False
        Me.txtLab.Text = "0"
        Me.txtLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.cboYear)
        Me.Panel9.Controls.Add(Me.Label34)
        Me.Panel9.Controls.Add(Me.txtSection)
        Me.Panel9.Location = New System.Drawing.Point(0, 134)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(532, 33)
        Me.Panel9.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Year Level"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(333, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(50, 19)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(389, 4)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(139, 26)
        Me.txtSection.TabIndex = 43
        Me.txtSection.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.cboCourse)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(0, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(532, 29)
        Me.Panel5.TabIndex = 60
        '
        'cboCourse
        '
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.Location = New System.Drawing.Point(99, 0)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.ReadOnly = True
        Me.cboCourse.Size = New System.Drawing.Size(429, 26)
        Me.cboCourse.TabIndex = 5
        Me.cboCourse.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.txtFname)
        Me.Panel8.Controls.Add(Me.txtMName)
        Me.Panel8.Controls.Add(Me.txtLastName)
        Me.Panel8.Location = New System.Drawing.Point(0, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(532, 33)
        Me.Panel8.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 33)
        Me.Panel2.TabIndex = 58
        '
        'txtTotalLabNight
        '
        Me.txtTotalLabNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLabNight.Location = New System.Drawing.Point(1047, 464)
        Me.txtTotalLabNight.Name = "txtTotalLabNight"
        Me.txtTotalLabNight.Size = New System.Drawing.Size(42, 26)
        Me.txtTotalLabNight.TabIndex = 64
        Me.txtTotalLabNight.Text = "0"
        Me.txtTotalLabNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLabNight.Visible = False
        '
        'txtTotalLecNight
        '
        Me.txtTotalLecNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecNight.Location = New System.Drawing.Point(914, 464)
        Me.txtTotalLecNight.Name = "txtTotalLecNight"
        Me.txtTotalLecNight.Size = New System.Drawing.Size(42, 26)
        Me.txtTotalLecNight.TabIndex = 63
        Me.txtTotalLecNight.Text = "0"
        Me.txtTotalLecNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLecNight.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(1006, 436)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 19)
        Me.Label31.TabIndex = 33
        Me.Label31.Text = "Rate"
        Me.Label31.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(873, 436)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 19)
        Me.Label30.TabIndex = 29
        Me.Label30.Text = "Rate"
        Me.Label30.Visible = False
        '
        'txtLabRateNight
        '
        Me.txtLabRateNight.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLabRateNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabRateNight.ForeColor = System.Drawing.Color.Black
        Me.txtLabRateNight.Location = New System.Drawing.Point(1046, 433)
        Me.txtLabRateNight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLabRateNight.Name = "txtLabRateNight"
        Me.txtLabRateNight.Size = New System.Drawing.Size(42, 26)
        Me.txtLabRateNight.TabIndex = 32
        Me.txtLabRateNight.TabStop = False
        Me.txtLabRateNight.Text = "0"
        Me.txtLabRateNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLabRateNight.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(967, 402)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 19)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Lab (Night)"
        Me.Label29.Visible = False
        '
        'txtLecRateNight
        '
        Me.txtLecRateNight.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLecRateNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecRateNight.ForeColor = System.Drawing.Color.Black
        Me.txtLecRateNight.Location = New System.Drawing.Point(914, 433)
        Me.txtLecRateNight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLecRateNight.Name = "txtLecRateNight"
        Me.txtLecRateNight.Size = New System.Drawing.Size(42, 26)
        Me.txtLecRateNight.TabIndex = 30
        Me.txtLecRateNight.TabStop = False
        Me.txtLecRateNight.Text = "0"
        Me.txtLecRateNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLecRateNight.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(837, 402)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 19)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Lec (Night)"
        Me.Label28.Visible = False
        '
        'txtTotalLabUnitsNight
        '
        Me.txtTotalLabUnitsNight.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLabUnitsNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLabUnitsNight.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLabUnitsNight.Location = New System.Drawing.Point(1045, 399)
        Me.txtTotalLabUnitsNight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLabUnitsNight.Name = "txtTotalLabUnitsNight"
        Me.txtTotalLabUnitsNight.Size = New System.Drawing.Size(43, 26)
        Me.txtTotalLabUnitsNight.TabIndex = 32
        Me.txtTotalLabUnitsNight.TabStop = False
        Me.txtTotalLabUnitsNight.Text = "0"
        Me.txtTotalLabUnitsNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLabUnitsNight.Visible = False
        '
        'txtTotalLecUnitsNight
        '
        Me.txtTotalLecUnitsNight.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLecUnitsNight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnitsNight.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLecUnitsNight.Location = New System.Drawing.Point(914, 399)
        Me.txtTotalLecUnitsNight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLecUnitsNight.Name = "txtTotalLecUnitsNight"
        Me.txtTotalLecUnitsNight.Size = New System.Drawing.Size(42, 26)
        Me.txtTotalLecUnitsNight.TabIndex = 30
        Me.txtTotalLecUnitsNight.TabStop = False
        Me.txtTotalLecUnitsNight.Text = "0"
        Me.txtTotalLecUnitsNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLecUnitsNight.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDiscountPercentage)
        Me.GroupBox2.Controls.Add(Me.lblMajor)
        Me.GroupBox2.Controls.Add(Me.lblEnrolled)
        Me.GroupBox2.Location = New System.Drawing.Point(885, 537)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(99, 73)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hidden Controls"
        Me.GroupBox2.Visible = False
        '
        'txtDiscountPercentage
        '
        Me.txtDiscountPercentage.Location = New System.Drawing.Point(18, 26)
        Me.txtDiscountPercentage.Name = "txtDiscountPercentage"
        Me.txtDiscountPercentage.Size = New System.Drawing.Size(100, 26)
        Me.txtDiscountPercentage.TabIndex = 57
        Me.txtDiscountPercentage.Text = "0"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(29, 53)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(42, 19)
        Me.lblMajor.TabIndex = 56
        Me.lblMajor.Text = "Major"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Location = New System.Drawing.Point(29, 71)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(55, 19)
        Me.lblEnrolled.TabIndex = 50
        Me.lblEnrolled.Text = "Enrolled"
        Me.lblEnrolled.Visible = False
        '
        'InstallmentfeeBindingSource
        '
        Me.InstallmentfeeBindingSource.DataMember = "installmentfee"
        Me.InstallmentfeeBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayment.Location = New System.Drawing.Point(885, 279)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(180, 46)
        Me.btnPayment.TabIndex = 56
        Me.btnPayment.TabStop = False
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnPayment, "Alt + P")
        Me.btnPayment.UseVisualStyleBackColor = True
        Me.btnPayment.Visible = False
        '
        'btnPaymentHistory
        '
        Me.btnPaymentHistory.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaymentHistory.Image = CType(resources.GetObject("btnPaymentHistory.Image"), System.Drawing.Image)
        Me.btnPaymentHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPaymentHistory.Location = New System.Drawing.Point(885, 333)
        Me.btnPaymentHistory.Name = "btnPaymentHistory"
        Me.btnPaymentHistory.Size = New System.Drawing.Size(180, 46)
        Me.btnPaymentHistory.TabIndex = 63
        Me.btnPaymentHistory.TabStop = False
        Me.btnPaymentHistory.Text = "Payment &History"
        Me.btnPaymentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnPaymentHistory, "Alt + H")
        Me.btnPaymentHistory.UseVisualStyleBackColor = True
        Me.btnPaymentHistory.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsViewAccounts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1073, 54)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(36, 51)
        Me.tsNew.Text = "New"
        Me.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsNew.ToolTipText = "New (Ctrl + N)"
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 51)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Save (Ctrl + S)"
        '
        'tsUpdate
        '
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(49, 51)
        Me.tsUpdate.Text = "Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Update (Ctrl + U)"
        Me.tsUpdate.Visible = False
        '
        'tsDelete
        '
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(44, 51)
        Me.tsDelete.Text = "Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsViewAccounts
        '
        Me.tsViewAccounts.Image = CType(resources.GetObject("tsViewAccounts.Image"), System.Drawing.Image)
        Me.tsViewAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsViewAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsViewAccounts.Name = "tsViewAccounts"
        Me.tsViewAccounts.Size = New System.Drawing.Size(89, 51)
        Me.tsViewAccounts.Text = "View Accounts"
        Me.tsViewAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsViewAccounts.ToolTipText = "View Accounts (Ctrl + F)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1144, 35)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 29)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'InstallmentfeeTableAdapter
        '
        Me.InstallmentfeeTableAdapter.ClearBeforeFill = True
        '
        'btnAddLabFees
        '
        Me.btnAddLabFees.Location = New System.Drawing.Point(876, 192)
        Me.btnAddLabFees.Name = "btnAddLabFees"
        Me.btnAddLabFees.Size = New System.Drawing.Size(108, 30)
        Me.btnAddLabFees.TabIndex = 64
        Me.btnAddLabFees.Text = "Add Lab Fee"
        Me.btnAddLabFees.UseVisualStyleBackColor = True
        Me.btnAddLabFees.Visible = False
        '
        'btnAddOldAcct
        '
        Me.btnAddOldAcct.Location = New System.Drawing.Point(876, 151)
        Me.btnAddOldAcct.Name = "btnAddOldAcct"
        Me.btnAddOldAcct.Size = New System.Drawing.Size(108, 30)
        Me.btnAddOldAcct.TabIndex = 65
        Me.btnAddOldAcct.Text = "Add Old Acct."
        Me.btnAddOldAcct.UseVisualStyleBackColor = True
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 619)
        Me.Controls.Add(Me.btnAddOldAcct)
        Me.Controls.Add(Me.btnAddLabFees)
        Me.Controls.Add(Me.txtTotalLabNight)
        Me.Controls.Add(Me.btnPaymentHistory)
        Me.Controls.Add(Me.txtTotalLecNight)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtLabRateNight)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtLecRateNight)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtTotalLecUnitsNight)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtTotalLabUnitsNight)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBilling"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ Student's Accounts  ]"
        Me.Panel6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.InstallmentfeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAcct As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lvAccts As System.Windows.Forms.ListView
    Friend WithEvents btnAddFees As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFees As System.Windows.Forms.Button
    Friend WithEvents txtTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents txtLabRate As System.Windows.Forms.TextBox
    Friend WithEvents txtLecRate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsViewAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataSet2 As SIMS.DataSet2
    Friend WithEvents InstallmentfeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstallmentfeeTableAdapter As SIMS.DataSet2TableAdapters.installmentfeeTableAdapter
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents cboCourse As System.Windows.Forms.TextBox
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLecUnitsNight As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLabUnitsNight As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtLabRateNight As System.Windows.Forms.TextBox
    Friend WithEvents txtLecRateNight As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecNight As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLabNight As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLabDay As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecDay As System.Windows.Forms.TextBox
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnPaymentHistory As System.Windows.Forms.Button
    Friend WithEvents txtTotalLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents btnAddLabFees As System.Windows.Forms.Button
    Friend WithEvents btnAddOldAcct As System.Windows.Forms.Button
    Friend WithEvents btnLoadUpdatedFees As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSpecialTuition As System.Windows.Forms.TextBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents txtOldAccount As System.Windows.Forms.TextBox
    Friend WithEvents btnOldAcct As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTuition As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents lblSpecialLabFee As System.Windows.Forms.Label
    Friend WithEvents lblTotalLab As System.Windows.Forms.Label
End Class
