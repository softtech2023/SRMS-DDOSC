<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumableSummary
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
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.lblEmployeeNo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Location = New System.Drawing.Point(372, 91)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(108, 40)
        Me.btnPreview.TabIndex = 52
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(400, 40)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(80, 26)
        Me.btnFind.TabIndex = 51
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(6, 43)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(68, 19)
        Me.lblAccountableName.TabIndex = 50
        Me.lblAccountableName.Text = "Employee "
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(80, 40)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(314, 26)
        Me.txtAccountable.TabIndex = 49
        '
        'lblEmployeeNo
        '
        Me.lblEmployeeNo.AutoSize = True
        Me.lblEmployeeNo.Location = New System.Drawing.Point(12, 9)
        Me.lblEmployeeNo.Name = "lblEmployeeNo"
        Me.lblEmployeeNo.Size = New System.Drawing.Size(81, 19)
        Me.lblEmployeeNo.TabIndex = 53
        Me.lblEmployeeNo.Text = "EmployeeNo"
        Me.lblEmployeeNo.Visible = False
        '
        'frmConsumableSummary
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 161)
        Me.Controls.Add(Me.lblEmployeeNo)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblAccountableName)
        Me.Controls.Add(Me.txtAccountable)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsumableSummary"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeNo As System.Windows.Forms.Label
End Class
