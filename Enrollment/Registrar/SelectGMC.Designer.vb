<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectGMC
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
        Me.btnok = New System.Windows.Forms.Button
        Me.rdononGrad = New System.Windows.Forms.RadioButton
        Me.rdoGrad = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(113, 77)
        Me.btnok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(87, 29)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'rdononGrad
        '
        Me.rdononGrad.AutoSize = True
        Me.rdononGrad.Location = New System.Drawing.Point(41, 4)
        Me.rdononGrad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdononGrad.Name = "rdononGrad"
        Me.rdononGrad.Size = New System.Drawing.Size(109, 23)
        Me.rdononGrad.TabIndex = 1
        Me.rdononGrad.TabStop = True
        Me.rdononGrad.Text = "Non-Graduate"
        Me.rdononGrad.UseVisualStyleBackColor = True
        '
        'rdoGrad
        '
        Me.rdoGrad.AutoSize = True
        Me.rdoGrad.Location = New System.Drawing.Point(186, 4)
        Me.rdoGrad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoGrad.Name = "rdoGrad"
        Me.rdoGrad.Size = New System.Drawing.Size(80, 23)
        Me.rdoGrad.TabIndex = 2
        Me.rdoGrad.TabStop = True
        Me.rdoGrad.Text = "Graduate"
        Me.rdoGrad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.rdononGrad)
        Me.Panel1.Controls.Add(Me.rdoGrad)
        Me.Panel1.Location = New System.Drawing.Point(1, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 31)
        Me.Panel1.TabIndex = 3
        '
        'frmSelectGMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 128)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnok)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectGMC"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Select Certificate of GMC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents rdononGrad As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGrad As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
