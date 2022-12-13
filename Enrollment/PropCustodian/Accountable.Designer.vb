<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountable
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
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.lblIDNumber = New System.Windows.Forms.Label
        Me.dtpAcquireDate = New System.Windows.Forms.DateTimePicker
        Me.rdoAll = New System.Windows.Forms.RadioButton
        Me.rdoCounts = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(351, 68)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(98, 26)
        Me.btnPreview.TabIndex = 48
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(351, 25)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(52, 26)
        Me.btnFind.TabIndex = 47
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(96, 25)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(248, 26)
        Me.txtAccountable.TabIndex = 45
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(12, 28)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountableName.TabIndex = 46
        Me.lblAccountableName.Text = "Accountable"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(153, 114)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(69, 19)
        Me.lblIDNumber.TabIndex = 49
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'dtpAcquireDate
        '
        Me.dtpAcquireDate.Location = New System.Drawing.Point(264, 108)
        Me.dtpAcquireDate.Name = "dtpAcquireDate"
        Me.dtpAcquireDate.Size = New System.Drawing.Size(138, 26)
        Me.dtpAcquireDate.TabIndex = 50
        Me.dtpAcquireDate.Visible = False
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(96, 57)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(41, 23)
        Me.rdoAll.TabIndex = 51
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(167, 57)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(124, 23)
        Me.rdoCounts.TabIndex = 52
        Me.rdoCounts.TabStop = True
        Me.rdoCounts.Text = "Counts Summary"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'frmAccountable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 140)
        Me.Controls.Add(Me.rdoCounts)
        Me.Controls.Add(Me.rdoAll)
        Me.Controls.Add(Me.dtpAcquireDate)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtAccountable)
        Me.Controls.Add(Me.lblAccountableName)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accountable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents dtpAcquireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCounts As System.Windows.Forms.RadioButton
End Class
