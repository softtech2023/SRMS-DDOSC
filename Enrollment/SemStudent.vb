Imports MySql.Data.MySqlClient
Public Class frmSemStudent
    Dim str As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub frmSemStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Reload()
        cboCourse.ResetText()
        getAcctStat()
        cboScholarship.ResetText()

        Try
            cboCourse.ResetText()
            cboYear.ResetText()
            tsSave.Enabled = False
            tsUpdate.Enabled = False
            tsDelete.Enabled = False
            tsDrop.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        cboCourse.ResetText()
    End Sub

    Private Sub btnCOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.MdiParent = Me
        frmCOR.Show()
        frmCOR.mskStudentNumber.Text = mskStudentNumber.Text
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        Reload()
    End Sub

    Public Sub PayingStatus()
        If cboAccountStatus.SelectedIndex = 0 Then
            txtGrantAmount.Enabled = False
            cboScholarship.Enabled = False
            cboScholarship.ResetText()
        End If
        If cboAccountStatus.SelectedIndex = 1 Then
            txtGrantAmount.Enabled = True
            cboScholarship.Enabled = True
        End If
    End Sub

    Private Sub txtGrantAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrantAmount.TextChanged
        PayingStatus()
    End Sub

    Private Sub cboScholarship_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboScholarship.SelectedIndexChanged
        PayingStatus()
    End Sub

    Private Sub cboAccountStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccountStatus.SelectedIndexChanged
        PayingStatus()
        getAcctStat()
    End Sub
    Public Sub Reload()
        Try

            mskStudentNumber.Clear()
            txtFname.Clear()
            txtMName.Clear()
            txtLastName.Clear()
            cboYear.ResetText()
            cboSection.ResetText()
            cboCourse.ResetText()
            cboMajor.ResetText()
            cboScholarship.ResetText()
            mskFrom.Clear()
            mskTo.Clear()
            mskAssessmentDate.Clear()
            cboAssessmentResult.ResetText()
            cboAccountStatus.ResetText()
            cboStudeStatus.ResetText()
            cboYearStat.ResetText()
            mskStudentNumber.Focus()
            txtPrevGPA.Clear()

            getCourse()
            getSection()
            schoolInfo()
            'getScholarship()
            getAcctStat()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If

            If cboYear.Text = "" Then
                MsgBox("Year level is required!", MsgBoxStyle.Exclamation)
                cboYear.Focus()
                Exit Sub
            End If

            If cboYearStat.Text = "" Then
                MsgBox("Year level status is required!", MsgBoxStyle.Exclamation)
                cboYearStat.Focus()
                Exit Sub
            End If

            If cboStudeStatus.Text = "" Then
                MsgBox("Student Status is required!", MsgBoxStyle.Exclamation)
                cboStudeStatus.Focus()
                Exit Sub
            End If

            If cboSection.Text = "" Then
                MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                cboSection.Focus()
                Exit Sub
            End If

            If cboAccountStatus.Text = "" Then
                MsgBox("Account status is required", MsgBoxStyle.Exclamation)
                cboAccountStatus.Focus()
                Exit Sub
            End If

            str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            conn.Close()

            If ds.Tables("semesterstude").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "insert into semesterstude values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblTerm.Text & "','" & cboSection.Text & "','" & cboStudeStatus.Text & "','" & cboScholarship.Text & "','" & mskFrom.Text & "','" & mskTo.Text & "','" & mskAssessmentDate.Text & "','" & cboAssessmentResult.Text & "','" & cboAccountStatus.Text & "','" & txtGrantAmount.Text & "','" & cboYearStat.Text & "','" & cboMajor.Text & "','" & lblSettingsID.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & cboCrossEnrollee.Text & "','" & cboSession.Text & "','" & txtPrevGPA.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            'MsgBox("Data successfully saved!", MsgBoxStyle.Information, "Prompt")
            conn.Close()

            'update profile
            str = "update studeprofile set Course='" & cboCourse.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            'Audit Trail
            str = "insert into atrail values('0','Enrolled a student','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()


            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            Reload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try

            str = "update semesterstude set StudentNumber='" & mskStudentNumber.Text & "',FName='" & txtFname.Text & "',MName='" & txtMName.Text & "',LName='" & txtLastName.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "',Status='" & cboStatus.Text & "',Semester='" & frmParent.lblSem.Text & "',SY='" & frmParent.lblSY.Text & "',Term='" & frmParent.lblTerm.Text & "',Section='" & cboSection.Text & "',StudeStatus='" & cboStudeStatus.Text & "',Scholarship='" & cboScholarship.Text & "',DurationFrom='" & mskFrom.Text & "',DurationTo='" & mskTo.Text & "',AssessmentDate='" & mskAssessmentDate.Text & "',AssessmentResult='" & cboAssessmentResult.Text & "',PayingStatus='" & cboAccountStatus.Text & "',GrantAmount='" & txtGrantAmount.Text & "',YearLevelStat='" & cboYearStat.Text & "',semstudentid='" & lblID.Text & "',Major='" & cboMajor.Text & "',crossEnrollee='" & cboCrossEnrollee.Text & "',classSession='" & cboSession.Text & "',prevGPA='" & txtPrevGPA.Text & "' where semstudentid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            '  MsgBox("Data successfully updated!", MsgBoxStyle.Information)
            conn.Close()

            'update profile
            str = "update studeprofile set Course='" & cboCourse.Text & "',yearLevel='" & cboYear.Text & "',scholarship='" & cboScholarship.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            'MsgBox("Data successfully updated", MsgBoxStyle.Information)
            conn.Close()

            'update registration
            str = "update registration set Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "',Major='" & cboMajor.Text & "',Section='" & cboSection.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC4 As New MySqlCommand(str, conn)
            mysC4.ExecuteNonQuery()
            '  MsgBox("Data successfully updated!", MsgBoxStyle.Information)
            conn.Close()

            'update course in student's account
            str = "update studeaccount set Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            conn.Close()

            'Audit Trail
            str = "insert into atrail values('0','Updated enrolled student','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated", MsgBoxStyle.Information)
            Reload()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from semesterstude where semstudentid='" & lblID.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Deleted enrolled student','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc8 As New MySqlCommand(str, conn)
                mysc8.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data successfully updated", MsgBoxStyle.Information)
                Reload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Reload()
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        tsDelete.PerformClick()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub tsNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Reload()
        frmSearchStudents.ShowDialog()
        frmSearchStudents.txtSearch.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        tsSave.PerformClick()
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourse.ValueMember = "course_table"
            cboCourse.DisplayMember = "CourseDescription"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")

            cboMajor.ValueMember = "course_table"
            cboMajor.DisplayMember = "Major"
            cboMajor.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub
    Public Sub getSection()
        Try
            str = "select * from sections"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getScholarship()
        Try
            str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "scholarships")

            cboScholarship.ValueMember = "scholarships"
            cboScholarship.DisplayMember = "Scholarship"
            cboScholarship.DataSource = ds.Tables("scholarships")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getAcctStat()
        If cboAccountStatus.Text = "Paying" Or cboAccountStatus.Text = "" Then
            cboScholarship.ResetText()
        Else
            getScholarship()
        End If
    End Sub

    Private Sub tsDrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDrop.Click
        Try

            str = "update semesterstude set Status='Dropped' where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            'Delete from CoR
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()

            'Audit Trail
            str = "insert into atrail values('0','Dropped student','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("The selected student has been dropped successfully.", MsgBoxStyle.Information)
            Reload()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub
End Class