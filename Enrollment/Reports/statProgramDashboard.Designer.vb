<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstatProgramDashboard
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
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnView2 = New System.Windows.Forms.Button
        Me.btnView1 = New System.Windows.Forms.Button
        Me.cboCourseList = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnResidence = New System.Windows.Forms.Button
        Me.btnView3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.DisplayGroupTree = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(311, 7)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(713, 585)
        Me.CrystalReportViewer2.TabIndex = 10
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'btnView2
        '
        Me.btnView2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView2.Location = New System.Drawing.Point(171, 88)
        Me.btnView2.Name = "btnView2"
        Me.btnView2.Size = New System.Drawing.Size(134, 40)
        Me.btnView2.TabIndex = 8
        Me.btnView2.Text = "View Chart (this SY)"
        Me.btnView2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView2.UseVisualStyleBackColor = True
        '
        'btnView1
        '
        Me.btnView1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView1.Location = New System.Drawing.Point(7, 88)
        Me.btnView1.Name = "btnView1"
        Me.btnView1.Size = New System.Drawing.Size(134, 40)
        Me.btnView1.TabIndex = 7
        Me.btnView1.Text = "View Chart (All)"
        Me.btnView1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView1.UseVisualStyleBackColor = True
        '
        'cboCourseList
        '
        Me.cboCourseList.FormattingEnabled = True
        Me.cboCourseList.Location = New System.Drawing.Point(7, 55)
        Me.cboCourseList.Name = "cboCourseList"
        Me.cboCourseList.Size = New System.Drawing.Size(298, 27)
        Me.cboCourseList.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Note: Clear the Course combo box to generate reports of all courses."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "FILTERED BY SEMESTER"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.SIMS.My.Resources.Resources.Christian_cross_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(7, 367)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 40)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Religion (Chart)"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.SIMS.My.Resources.Resources.people_icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(7, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 40)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Ethnicity (Chart)"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.SIMS.My.Resources.Resources.age
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(7, 487)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 40)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Age (Chart)"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.SIMS.My.Resources.Resources.users_mixed_gender_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(7, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 40)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Gender (Chart)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SIMS.My.Resources.Resources.Courses_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(7, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Course (Chart)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnResidence
        '
        Me.btnResidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidence.Image = Global.SIMS.My.Resources.Resources.home_icon
        Me.btnResidence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResidence.Location = New System.Drawing.Point(7, 229)
        Me.btnResidence.Name = "btnResidence"
        Me.btnResidence.Size = New System.Drawing.Size(145, 40)
        Me.btnResidence.TabIndex = 12
        Me.btnResidence.Text = "City/Mun. (Chart)"
        Me.btnResidence.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResidence.UseVisualStyleBackColor = True
        '
        'btnView3
        '
        Me.btnView3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView3.Image = Global.SIMS.My.Resources.Resources.Database_Table_icon
        Me.btnView3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView3.Location = New System.Drawing.Point(7, 134)
        Me.btnView3.Name = "btnView3"
        Me.btnView3.Size = New System.Drawing.Size(298, 40)
        Me.btnView3.TabIndex = 9
        Me.btnView3.Text = "Comparative Data (in Table)"
        Me.btnView3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.SIMS.My.Resources.Resources.people_icon
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(158, 321)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 40)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Ethnicity (Table)"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.SIMS.My.Resources.Resources.Christian_cross_icon
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(158, 367)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(145, 40)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Religion (Table)"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.SIMS.My.Resources.Resources.home_icon
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(158, 229)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(145, 40)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "City/Mun. (Table)"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.SIMS.My.Resources.Resources.users_mixed_gender_icon
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(158, 275)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(145, 40)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "Gender (Table)"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.SIMS.My.Resources.Resources.Courses_icon
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(158, 413)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(145, 40)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "Course (Table)"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.SIMS.My.Resources.Resources.age
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(158, 487)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(145, 40)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "Age (Table)"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'frmstatProgramDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 599)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnResidence)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.btnView3)
        Me.Controls.Add(Me.btnView2)
        Me.Controls.Add(Me.btnView1)
        Me.Controls.Add(Me.cboCourseList)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmstatProgramDashboard"
        Me.ShowIcon = False
        Me.Text = "::  COMPARATIVE ENROLLMENT DATA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnView3 As System.Windows.Forms.Button
    Friend WithEvents btnView2 As System.Windows.Forms.Button
    Friend WithEvents btnView1 As System.Windows.Forms.Button
    Friend WithEvents cboCourseList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnResidence As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
End Class
