<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditionalLabFee
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCurrentLabFee = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblLabFeeRate = New System.Windows.Forms.TextBox
        Me.txtAdditionalUnits = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNewLabTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtLabUnit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Lab. Fee"
        '
        'lblCurrentLabFee
        '
        Me.lblCurrentLabFee.Location = New System.Drawing.Point(213, 84)
        Me.lblCurrentLabFee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblCurrentLabFee.Name = "lblCurrentLabFee"
        Me.lblCurrentLabFee.ReadOnly = True
        Me.lblCurrentLabFee.Size = New System.Drawing.Size(110, 26)
        Me.lblCurrentLabFee.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lab. Fee Rate"
        Me.Label2.Visible = False
        '
        'lblLabFeeRate
        '
        Me.lblLabFeeRate.Location = New System.Drawing.Point(213, 17)
        Me.lblLabFeeRate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblLabFeeRate.Name = "lblLabFeeRate"
        Me.lblLabFeeRate.ReadOnly = True
        Me.lblLabFeeRate.Size = New System.Drawing.Size(110, 26)
        Me.lblLabFeeRate.TabIndex = 5
        Me.lblLabFeeRate.Visible = False
        '
        'txtAdditionalUnits
        '
        Me.txtAdditionalUnits.Location = New System.Drawing.Point(213, 135)
        Me.txtAdditionalUnits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAdditionalUnits.Name = "txtAdditionalUnits"
        Me.txtAdditionalUnits.Size = New System.Drawing.Size(110, 26)
        Me.txtAdditionalUnits.TabIndex = 8
        Me.txtAdditionalUnits.Text = "0"
        Me.txtAdditionalUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Addt'l. No. of Units"
        '
        'txtNewLabTotal
        '
        Me.txtNewLabTotal.Location = New System.Drawing.Point(213, 169)
        Me.txtNewLabTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewLabTotal.Name = "txtNewLabTotal"
        Me.txtNewLabTotal.Size = New System.Drawing.Size(110, 26)
        Me.txtNewLabTotal.TabIndex = 10
        Me.txtNewLabTotal.Text = "0"
        Me.txtNewLabTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "New Lab Fee Total"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(213, 220)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(110, 32)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtLabUnit
        '
        Me.txtLabUnit.Location = New System.Drawing.Point(213, 52)
        Me.txtLabUnit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLabUnit.Name = "txtLabUnit"
        Me.txtLabUnit.ReadOnly = True
        Me.txtLabUnit.Size = New System.Drawing.Size(110, 26)
        Me.txtLabUnit.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Lab Unit"
        '
        'frmAdditionalLabFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(399, 274)
        Me.Controls.Add(Me.txtLabUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtNewLabTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAdditionalUnits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLabFeeRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCurrentLabFee)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdditionalLabFee"
        Me.ShowIcon = False
        Me.Text = "Lab Fee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentLabFee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLabFeeRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAdditionalUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewLabTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtLabUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
