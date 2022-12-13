<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribution
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
        Me.lvPOS = New System.Windows.Forms.ListView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.txtProductCode = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtempNo = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ItemLookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemLookupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveSelectedItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveAllItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtremainQTY = New System.Windows.Forms.TextBox
        Me.txtTransactionNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblsettingsID = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btnSelectEmployee = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnItemlookup = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvPOS
        '
        Me.lvPOS.BackColor = System.Drawing.Color.White
        Me.lvPOS.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPOS.ForeColor = System.Drawing.Color.Black
        Me.lvPOS.FullRowSelect = True
        Me.lvPOS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPOS.Location = New System.Drawing.Point(2, 48)
        Me.lvPOS.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvPOS.Name = "lvPOS"
        Me.lvPOS.Size = New System.Drawing.Size(633, 341)
        Me.lvPOS.TabIndex = 2
        Me.lvPOS.TabStop = False
        Me.lvPOS.UseCompatibleStateImageBehavior = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtQTY)
        Me.Panel1.Controls.Add(Me.txtProductCode)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(2, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 34)
        Me.Panel1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 19)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Product Code"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(67, 5)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(65, 26)
        Me.txtQTY.TabIndex = 1
        Me.txtQTY.Text = "1"
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProductCode
        '
        Me.txtProductCode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(239, 5)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(262, 26)
        Me.txtProductCode.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(426, 5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 48
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(345, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtempNo
        '
        Me.txtempNo.Location = New System.Drawing.Point(734, 167)
        Me.txtempNo.Name = "txtempNo"
        Me.txtempNo.ReadOnly = True
        Me.txtempNo.Size = New System.Drawing.Size(130, 26)
        Me.txtempNo.TabIndex = 6
        Me.txtempNo.TabStop = False
        Me.txtempNo.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(734, 199)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(130, 26)
        Me.txtFirstName.TabIndex = 7
        Me.txtFirstName.TabStop = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(734, 231)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(130, 26)
        Me.txtLastName.TabIndex = 8
        Me.txtLastName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(640, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Employee No."
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(640, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(640, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemLookupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ItemLookupToolStripMenuItem
        '
        Me.ItemLookupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemLookupToolStripMenuItem1, Me.SelectEmployeeToolStripMenuItem, Me.SaveToolStripMenuItem, Me.RemoveSelectedItemToolStripMenuItem, Me.RemoveAllItemsToolStripMenuItem})
        Me.ItemLookupToolStripMenuItem.Name = "ItemLookupToolStripMenuItem"
        Me.ItemLookupToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ItemLookupToolStripMenuItem.Text = "Menu"
        Me.ItemLookupToolStripMenuItem.Visible = False
        '
        'ItemLookupToolStripMenuItem1
        '
        Me.ItemLookupToolStripMenuItem1.Name = "ItemLookupToolStripMenuItem1"
        Me.ItemLookupToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ItemLookupToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.ItemLookupToolStripMenuItem1.Text = "Item Lookup"
        '
        'SelectEmployeeToolStripMenuItem
        '
        Me.SelectEmployeeToolStripMenuItem.Name = "SelectEmployeeToolStripMenuItem"
        Me.SelectEmployeeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SelectEmployeeToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SelectEmployeeToolStripMenuItem.Text = "Select Employee"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'RemoveSelectedItemToolStripMenuItem
        '
        Me.RemoveSelectedItemToolStripMenuItem.Name = "RemoveSelectedItemToolStripMenuItem"
        Me.RemoveSelectedItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RemoveSelectedItemToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RemoveSelectedItemToolStripMenuItem.Text = "Remove Selected Item"
        '
        'RemoveAllItemsToolStripMenuItem
        '
        Me.RemoveAllItemsToolStripMenuItem.Name = "RemoveAllItemsToolStripMenuItem"
        Me.RemoveAllItemsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.RemoveAllItemsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RemoveAllItemsToolStripMenuItem.Text = "Remove All Items"
        '
        'txtremainQTY
        '
        Me.txtremainQTY.Location = New System.Drawing.Point(645, 273)
        Me.txtremainQTY.Name = "txtremainQTY"
        Me.txtremainQTY.Size = New System.Drawing.Size(51, 26)
        Me.txtremainQTY.TabIndex = 14
        Me.txtremainQTY.Visible = False
        '
        'txtTransactionNo
        '
        Me.txtTransactionNo.Location = New System.Drawing.Point(746, 12)
        Me.txtTransactionNo.Name = "txtTransactionNo"
        Me.txtTransactionNo.ReadOnly = True
        Me.txtTransactionNo.Size = New System.Drawing.Size(118, 26)
        Me.txtTransactionNo.TabIndex = 15
        Me.txtTransactionNo.TabStop = False
        Me.txtTransactionNo.Text = "20190125"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(641, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Transaction No."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(867, 24)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel3.Text = "Exit [Esc]"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(157, 19)
        Me.ToolStripStatusLabel2.Text = "Remove Selected Item [ F5 ]"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 19)
        Me.ToolStripStatusLabel1.Text = "Remove All Items [ F6 ]"
        '
        'lblsettingsID
        '
        Me.lblsettingsID.AutoSize = True
        Me.lblsettingsID.Location = New System.Drawing.Point(742, 299)
        Me.lblsettingsID.Name = "lblsettingsID"
        Me.lblsettingsID.Size = New System.Drawing.Size(71, 19)
        Me.lblsettingsID.TabIndex = 18
        Me.lblsettingsID.Text = "Settings ID"
        Me.lblsettingsID.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnSelectEmployee
        '
        Me.btnSelectEmployee.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectEmployee.Location = New System.Drawing.Point(715, 103)
        Me.btnSelectEmployee.Name = "btnSelectEmployee"
        Me.btnSelectEmployee.Size = New System.Drawing.Size(149, 49)
        Me.btnSelectEmployee.TabIndex = 4
        Me.btnSelectEmployee.TabStop = False
        Me.btnSelectEmployee.Text = "Select Employee/ Student (F4)"
        Me.btnSelectEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSelectEmployee.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(544, 58)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(68, 22)
        Me.btnexit.TabIndex = 19
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnItemlookup
        '
        Me.btnItemlookup.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemlookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemlookup.Location = New System.Drawing.Point(715, 48)
        Me.btnItemlookup.Name = "btnItemlookup"
        Me.btnItemlookup.Size = New System.Drawing.Size(149, 49)
        Me.btnItemlookup.TabIndex = 5
        Me.btnItemlookup.TabStop = False
        Me.btnItemlookup.Text = "Item Lookup (F3)"
        Me.btnItemlookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemlookup.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(746, 271)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(33, 19)
        Me.lblType.TabIndex = 20
        Me.lblType.Text = "type"
        Me.lblType.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.SIMS.My.Resources.Resources.save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(715, 339)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 43)
        Me.btnSave.TabIndex = 12
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save [CTRL + S]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmDistribution
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.CancelButton = Me.btnexit
        Me.ClientSize = New System.Drawing.Size(867, 416)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblsettingsID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransactionNo)
        Me.Controls.Add(Me.txtremainQTY)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtempNo)
        Me.Controls.Add(Me.btnItemlookup)
        Me.Controls.Add(Me.btnSelectEmployee)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lvPOS)
        Me.Controls.Add(Me.btnexit)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmDistribution"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::  DISTRIBUTION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvPOS As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectEmployee As System.Windows.Forms.Button
    Friend WithEvents btnItemlookup As System.Windows.Forms.Button
    Friend WithEvents txtempNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ItemLookupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemLookupToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtremainQTY As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RemoveSelectedItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblsettingsID As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblType As System.Windows.Forms.Label
End Class
