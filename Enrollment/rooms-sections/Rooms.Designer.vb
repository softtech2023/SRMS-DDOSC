<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnRoomDelete = New System.Windows.Forms.Button
        Me.btnRoomUpdate = New System.Windows.Forms.Button
        Me.btnRoomSave = New System.Windows.Forms.Button
        Me.txtRoom = New System.Windows.Forms.TextBox
        Me.dgRoom = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblSectionID = New System.Windows.Forms.Label
        Me.btnSectionDelete = New System.Windows.Forms.Button
        Me.btnSectionUpdate = New System.Windows.Forms.Button
        Me.btnSectionSave = New System.Windows.Forms.Button
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.dgSection = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblRoomID = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(477, 299)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblRoomID)
        Me.TabPage1.Controls.Add(Me.btnRoomDelete)
        Me.TabPage1.Controls.Add(Me.btnRoomUpdate)
        Me.TabPage1.Controls.Add(Me.btnRoomSave)
        Me.TabPage1.Controls.Add(Me.txtRoom)
        Me.TabPage1.Controls.Add(Me.dgRoom)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(469, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rooms"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRoomDelete
        '
        Me.btnRoomDelete.Location = New System.Drawing.Point(363, 15)
        Me.btnRoomDelete.Name = "btnRoomDelete"
        Me.btnRoomDelete.Size = New System.Drawing.Size(75, 26)
        Me.btnRoomDelete.TabIndex = 5
        Me.btnRoomDelete.Text = "Delete"
        Me.btnRoomDelete.UseVisualStyleBackColor = True
        '
        'btnRoomUpdate
        '
        Me.btnRoomUpdate.Location = New System.Drawing.Point(282, 15)
        Me.btnRoomUpdate.Name = "btnRoomUpdate"
        Me.btnRoomUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnRoomUpdate.TabIndex = 4
        Me.btnRoomUpdate.Text = "Update"
        Me.btnRoomUpdate.UseVisualStyleBackColor = True
        '
        'btnRoomSave
        '
        Me.btnRoomSave.Location = New System.Drawing.Point(201, 15)
        Me.btnRoomSave.Name = "btnRoomSave"
        Me.btnRoomSave.Size = New System.Drawing.Size(75, 26)
        Me.btnRoomSave.TabIndex = 3
        Me.btnRoomSave.Text = "Add"
        Me.btnRoomSave.UseVisualStyleBackColor = True
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(6, 15)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(189, 26)
        Me.txtRoom.TabIndex = 2
        '
        'dgRoom
        '
        Me.dgRoom.AllowUserToAddRows = False
        Me.dgRoom.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgRoom.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRoom.Location = New System.Drawing.Point(6, 58)
        Me.dgRoom.Name = "dgRoom"
        Me.dgRoom.ReadOnly = True
        Me.dgRoom.Size = New System.Drawing.Size(456, 203)
        Me.dgRoom.TabIndex = 1
        Me.dgRoom.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblSectionID)
        Me.TabPage2.Controls.Add(Me.btnSectionDelete)
        Me.TabPage2.Controls.Add(Me.btnSectionUpdate)
        Me.TabPage2.Controls.Add(Me.btnSectionSave)
        Me.TabPage2.Controls.Add(Me.txtSection)
        Me.TabPage2.Controls.Add(Me.dgSection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(469, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sections"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblSectionID
        '
        Me.lblSectionID.AutoSize = True
        Me.lblSectionID.Location = New System.Drawing.Point(211, 34)
        Me.lblSectionID.Name = "lblSectionID"
        Me.lblSectionID.Size = New System.Drawing.Size(35, 19)
        Me.lblSectionID.TabIndex = 11
        Me.lblSectionID.Text = "lblID"
        Me.lblSectionID.Visible = False
        '
        'btnSectionDelete
        '
        Me.btnSectionDelete.Location = New System.Drawing.Point(363, 10)
        Me.btnSectionDelete.Name = "btnSectionDelete"
        Me.btnSectionDelete.Size = New System.Drawing.Size(75, 26)
        Me.btnSectionDelete.TabIndex = 10
        Me.btnSectionDelete.Text = "Delete"
        Me.btnSectionDelete.UseVisualStyleBackColor = True
        '
        'btnSectionUpdate
        '
        Me.btnSectionUpdate.Location = New System.Drawing.Point(282, 10)
        Me.btnSectionUpdate.Name = "btnSectionUpdate"
        Me.btnSectionUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnSectionUpdate.TabIndex = 9
        Me.btnSectionUpdate.Text = "Update"
        Me.btnSectionUpdate.UseVisualStyleBackColor = True
        '
        'btnSectionSave
        '
        Me.btnSectionSave.Location = New System.Drawing.Point(201, 10)
        Me.btnSectionSave.Name = "btnSectionSave"
        Me.btnSectionSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSectionSave.TabIndex = 8
        Me.btnSectionSave.Text = "Add"
        Me.btnSectionSave.UseVisualStyleBackColor = True
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(6, 10)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(189, 26)
        Me.txtSection.TabIndex = 7
        '
        'dgSection
        '
        Me.dgSection.AllowUserToAddRows = False
        Me.dgSection.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgSection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSection.Location = New System.Drawing.Point(6, 53)
        Me.dgSection.Name = "dgSection"
        Me.dgSection.ReadOnly = True
        Me.dgSection.Size = New System.Drawing.Size(456, 203)
        Me.dgSection.TabIndex = 6
        Me.dgSection.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 43)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ROOM AND SECTION SETUP"
        '
        'lblRoomID
        '
        Me.lblRoomID.AutoSize = True
        Me.lblRoomID.Location = New System.Drawing.Point(174, 36)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(35, 19)
        Me.lblRoomID.TabIndex = 21
        Me.lblRoomID.Text = "lblID"
        Me.lblRoomID.Visible = False
        '
        'frmRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 376)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRooms"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRoomDelete As System.Windows.Forms.Button
    Friend WithEvents btnRoomUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRoomSave As System.Windows.Forms.Button
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents dgRoom As System.Windows.Forms.DataGridView
    Friend WithEvents btnSectionDelete As System.Windows.Forms.Button
    Friend WithEvents btnSectionUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSectionSave As System.Windows.Forms.Button
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents dgSection As System.Windows.Forms.DataGridView
    Friend WithEvents lblSectionID As System.Windows.Forms.Label
    Friend WithEvents lblRoomID As System.Windows.Forms.Label
End Class
