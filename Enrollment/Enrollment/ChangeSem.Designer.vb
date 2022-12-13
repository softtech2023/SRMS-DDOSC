<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeSem))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSYfrom = New System.Windows.Forms.TextBox
        Me.txtSYto = New System.Windows.Forms.TextBox
        Me.cboSem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calendar Year"
        '
        'txtSYfrom
        '
        Me.txtSYfrom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSYfrom.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSYfrom.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSYfrom.Location = New System.Drawing.Point(169, 48)
        Me.txtSYfrom.Name = "txtSYfrom"
        Me.txtSYfrom.Size = New System.Drawing.Size(153, 35)
        Me.txtSYfrom.TabIndex = 2
        Me.txtSYfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSYto
        '
        Me.txtSYto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSYto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSYto.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSYto.Location = New System.Drawing.Point(346, 48)
        Me.txtSYto.Name = "txtSYto"
        Me.txtSYto.ReadOnly = True
        Me.txtSYto.Size = New System.Drawing.Size(153, 35)
        Me.txtSYto.TabIndex = 3
        Me.txtSYto.TabStop = False
        Me.txtSYto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSem
        '
        Me.cboSem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Items.AddRange(New Object() {"First Semester", "Second Semester", "Off-Semester"})
        Me.cboSem.Location = New System.Drawing.Point(169, 89)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(330, 38)
        Me.cboSem.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(65, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Semester"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSYto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSYfrom)
        Me.GroupBox1.Controls.Add(Me.cboSem)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 172)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(323, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(137, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CHANGE SEMESTER"
        '
        'ChangeSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(550, 273)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangeSem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Semester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSYfrom As System.Windows.Forms.TextBox
    Friend WithEvents txtSYto As System.Windows.Forms.TextBox
    Friend WithEvents cboSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
