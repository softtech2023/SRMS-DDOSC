<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewing
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
        Me.txtShortageValue = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtShortage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblItemID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.lblIDNumber = New System.Windows.Forms.Label
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.lblAcquireDate = New System.Windows.Forms.Label
        Me.lblPurchasePrice = New System.Windows.Forms.Label
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.txtCapacity = New System.Windows.Forms.TextBox
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtCtrlNo = New System.Windows.Forms.TextBox
        Me.lblBrand = New System.Windows.Forms.Label
        Me.lblCapacity = New System.Windows.Forms.Label
        Me.lblItemCodition = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.lblControlNo = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.lblItemName = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.txtBrand = New System.Windows.Forms.TextBox
        Me.txtCondition = New System.Windows.Forms.TextBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtAcquireDate = New System.Windows.Forms.TextBox
        Me.txtProcessDate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsubCategory = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotalPrice = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtShortageValue
        '
        Me.txtShortageValue.Location = New System.Drawing.Point(308, 185)
        Me.txtShortageValue.Name = "txtShortageValue"
        Me.txtShortageValue.ReadOnly = True
        Me.txtShortageValue.Size = New System.Drawing.Size(124, 26)
        Me.txtShortageValue.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 19)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Value"
        '
        'txtShortage
        '
        Me.txtShortage.Location = New System.Drawing.Point(131, 185)
        Me.txtShortage.Name = "txtShortage"
        Me.txtShortage.ReadOnly = True
        Me.txtShortage.Size = New System.Drawing.Size(124, 26)
        Me.txtShortage.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 19)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Shortage/Overage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(475, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Processed Date"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(537, 284)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(47, 19)
        Me.lblItemID.TabIndex = 89
        Me.lblItemID.Text = "itemID"
        Me.lblItemID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Unit"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(119, 147)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(119, 26)
        Me.txtQty.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Qty"
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(549, 259)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(71, 19)
        Me.lblSettingsID.TabIndex = 86
        Me.lblSettingsID.Text = "Settings ID"
        Me.lblSettingsID.Visible = False
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(668, 282)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(69, 19)
        Me.lblIDNumber.TabIndex = 85
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(542, 121)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(259, 26)
        Me.txtAccountable.TabIndex = 13
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(132, 89)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(297, 58)
        Me.txtDescription.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Description"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(131, 249)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.ReadOnly = True
        Me.txtSerialNo.Size = New System.Drawing.Size(167, 26)
        Me.txtSerialNo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Serial No."
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(530, 246)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(342, 82)
        Me.txtNotes.TabIndex = 17
        '
        'txtPPrice
        '
        Me.txtPPrice.Location = New System.Drawing.Point(530, 179)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.ReadOnly = True
        Me.txtPPrice.Size = New System.Drawing.Size(122, 26)
        Me.txtPPrice.TabIndex = 16
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAcquireDate
        '
        Me.lblAcquireDate.AutoSize = True
        Me.lblAcquireDate.Location = New System.Drawing.Point(658, 214)
        Me.lblAcquireDate.Name = "lblAcquireDate"
        Me.lblAcquireDate.Size = New System.Drawing.Size(90, 19)
        Me.lblAcquireDate.TabIndex = 82
        Me.lblAcquireDate.Text = "Acquired Date"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(430, 182)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(93, 19)
        Me.lblPurchasePrice.TabIndex = 81
        Me.lblPurchasePrice.Text = "Purchase Price"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(464, 259)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(59, 19)
        Me.lblRemarks.TabIndex = 80
        Me.lblRemarks.Text = "Remarks"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(529, 147)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCapacity.Size = New System.Drawing.Size(122, 26)
        Me.txtCapacity.TabIndex = 10
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(457, 124)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountableName.TabIndex = 79
        Me.lblAccountableName.Text = "Accountable"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(131, 281)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(167, 26)
        Me.txtModel.TabIndex = 8
        '
        'txtCtrlNo
        '
        Me.txtCtrlNo.Location = New System.Drawing.Point(131, 25)
        Me.txtCtrlNo.Name = "txtCtrlNo"
        Me.txtCtrlNo.Size = New System.Drawing.Size(231, 26)
        Me.txtCtrlNo.TabIndex = 0
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(82, 217)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(43, 19)
        Me.lblBrand.TabIndex = 78
        Me.lblBrand.Text = "Brand"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(466, 154)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(57, 19)
        Me.lblCapacity.TabIndex = 72
        Me.lblCapacity.Text = "Capacity"
        '
        'lblItemCodition
        '
        Me.lblItemCodition.AutoSize = True
        Me.lblItemCodition.Location = New System.Drawing.Point(473, 28)
        Me.lblItemCodition.Name = "lblItemCodition"
        Me.lblItemCodition.Size = New System.Drawing.Size(62, 19)
        Me.lblItemCodition.TabIndex = 69
        Me.lblItemCodition.Text = "Condition"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(81, 281)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(44, 19)
        Me.lblModel.TabIndex = 67
        Me.lblModel.Text = "Model"
        '
        'lblControlNo
        '
        Me.lblControlNo.AutoSize = True
        Me.lblControlNo.Location = New System.Drawing.Point(44, 28)
        Me.lblControlNo.Name = "lblControlNo"
        Me.lblControlNo.Size = New System.Drawing.Size(81, 19)
        Me.lblControlNo.TabIndex = 63
        Me.lblControlNo.Text = "Property No."
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(132, 57)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(296, 26)
        Me.txtItemName.TabIndex = 1
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(51, 60)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(74, 19)
        Me.lblItemName.TabIndex = 54
        Me.lblItemName.Text = "Item Name"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(296, 147)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(124, 26)
        Me.txtUnit.TabIndex = 4
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(131, 217)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(167, 26)
        Me.txtBrand.TabIndex = 7
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(541, 25)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.ReadOnly = True
        Me.txtCondition.Size = New System.Drawing.Size(151, 26)
        Me.txtCondition.TabIndex = 11
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(542, 57)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(259, 26)
        Me.txtCategory.TabIndex = 12
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(219, 26)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(107, 23)
        Me.btnOk.TabIndex = 98
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(589, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 99
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtAcquireDate
        '
        Me.txtAcquireDate.Location = New System.Drawing.Point(754, 211)
        Me.txtAcquireDate.Name = "txtAcquireDate"
        Me.txtAcquireDate.ReadOnly = True
        Me.txtAcquireDate.Size = New System.Drawing.Size(118, 26)
        Me.txtAcquireDate.TabIndex = 14
        '
        'txtProcessDate
        '
        Me.txtProcessDate.Location = New System.Drawing.Point(529, 214)
        Me.txtProcessDate.Name = "txtProcessDate"
        Me.txtProcessDate.ReadOnly = True
        Me.txtProcessDate.Size = New System.Drawing.Size(123, 26)
        Me.txtProcessDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Sub-Category"
        '
        'txtsubCategory
        '
        Me.txtsubCategory.Location = New System.Drawing.Point(541, 89)
        Me.txtsubCategory.Name = "txtsubCategory"
        Me.txtsubCategory.ReadOnly = True
        Me.txtsubCategory.Size = New System.Drawing.Size(259, 26)
        Me.txtsubCategory.TabIndex = 101
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtProcessDate)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Controls.Add(Me.txtAcquireDate)
        Me.GroupBox1.Controls.Add(Me.txtUnit)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPPrice)
        Me.GroupBox1.Controls.Add(Me.lblPurchasePrice)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAcquireDate)
        Me.GroupBox1.Controls.Add(Me.lblSettingsID)
        Me.GroupBox1.Controls.Add(Me.lblIDNumber)
        Me.GroupBox1.Controls.Add(Me.lblRemarks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 421)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(755, 179)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(117, 26)
        Me.txtTotalPrice.TabIndex = 83
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(658, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 19)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Total Price"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 430)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(905, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 103
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel1.Text = "Exit [Esc]"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(127, 19)
        Me.ToolStripStatusLabel2.Text = "Clear Information [F6]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 24)
        Me.MenuStrip1.TabIndex = 104
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "menu"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem.Text = "clear"
        '
        'frmViewing
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(905, 454)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtsubCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtCondition)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtShortageValue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtShortage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountable)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAccountableName)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblItemCodition)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblControlNo)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.txtCtrlNo)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblItemID)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUICK SEARCH: EQUIPMENT AND MACHINERY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShortageValue As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtShortage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtPPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblAcquireDate As System.Windows.Forms.Label
    Friend WithEvents lblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtCtrlNo As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents lblItemCodition As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblControlNo As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtAcquireDate As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsubCategory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
