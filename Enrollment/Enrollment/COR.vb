Imports MySql.Data.MySqlClient
Public Class frmCOR
    Dim str As String

    Private Sub frmAddStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        lvCOR.Items.Clear()
        frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmSearchSemSubjects.ShowDialog()
    End Sub

    Private Sub btnRemoveSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
        Try
            Dim i As Integer

            lvCOR.Select()

            If lvCOR.Items.Count = 0 Then
                MsgBox("Cannot find subject(s) to remove", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            Else
                i = lvCOR.FocusedItem.Index
                lvCOR.Items.RemoveAt(i)
            End If

            getTotalLecUnits()
            getTotalLabUnits()
            TotalUnits()
            getTotalLab()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmCOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            ' lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 100)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Lec Time", 90)
            Me.lvCOR.Columns.Add("Lab Time", 90)
            Me.lvCOR.Columns.Add("Room", 90)
            Me.lvCOR.Columns.Add("Section", 70)
            Me.lvCOR.Columns.Add("Lec Unit", 80)
            Me.lvCOR.Columns.Add("Lab Unit", 80)
            Me.lvCOR.Columns.Add("Instructor", 0)
            Me.lvCOR.Columns.Add("Sched Type", 0)
            Me.lvCOR.Columns.Add("Slot", 0)

            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True

            mskStudentNumber.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            txtYearLevel.Clear()
            txtTotalLab.Text = 0
            txtTotalLecUnits.Text = 0
            txtTotalUnits.Text = 0
            lblLabFee.Text = 0


            btnAddSubject.Enabled = False
            btnRemoveSubjects.Enabled = False

            tsSave.Enabled = False
            tsUpdate.Enabled = False
            tsDelete.Enabled = False
            tsPrint.Enabled = False

            schoolInfo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadSubjects()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM semsubjects where Course='" & txtCourse.Text & "' and cMajor='" & txtMajor.Text & "' and YearLevel='" & txtYearLevel.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & lblSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvCOR.Items.Add(newrow.Item(1))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(13))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(28))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(9))
            Next
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFind.Click
        lvCOR.Items.Clear()
        frmSearchCOR.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If mskStudentNumber.Text = "" Or lvCOR.Items.Count = 0 Then
                MsgBox("Cannot save data! Add Student and subject first before saving!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet

            mysda.Fill(ds, "registration")

            If ds.Tables("registration").Rows.Count >= 1 Then
                MsgBox("Student already advised!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If
            conn.Close()

            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtCourse.Text & "','" & txtYearLevel.Text & "','" & txtMajor.Text & "','" & lblSettingsID.Text & "','" & lvCOR.Items(i).SubItems(9).Text & "','" & txtTotalUnits.Text & "','" & lblLabFee.Text & "','" & txtCourseCode.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'update slots
                str = "update semsubjects set Slot='" & lvCOR.Items(i).SubItems(10).Text & "' where SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "' and Section='" & lvCOR.Items(i).SubItems(5).Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

            Next

            'Audit Trail
            str = "insert into atrail values('0','Encoded student''s subjects','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            If (MsgBox("Registration has been processed successfully! Do you want to print the Cert. of Enrollment?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, st.scholarshipCoordinator, st.clerk, st.clerkPosition, st.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' order by r.SubjectCode"
                conn.Open()
                Dim mysda2 As New MySqlDataAdapter(str, conn)
                Dim ds2 As New DataSet
                mysda2.Fill(ds2, "registration, studeprofile, srms_settings")
                Dim obj As New COR1
                obj.SetDataSource(ds2.Tables("registration, studeprofile, srms_settings"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                obj.SetParameterValue("yearLevelStat", lblYearLevelStat.Text)
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If



            lvCOR.Items.Clear()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()
            tsSave.PerformClick()
            lvCOR.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClear.Click
        lvCOR.Items.Clear()
        mskStudentNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        tsFind.PerformClick()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        btnAddStudent.PerformClick()
    End Sub

    Private Sub AddSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectsToolStripMenuItem.Click
        btnAddSubject.PerformClick()
    End Sub
    Public Sub getTotalLecUnits()
        Dim LecUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LecUnits += Val(lvCOR.Items(x).SubItems(6).Text)
        Next
        txtTotalLecUnits.Text = Format(LecUnits, "0.00")
    End Sub
    Public Sub getTotalLabUnits()
        Dim LabUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LabUnits += Val(lvCOR.Items(x).SubItems(7).Text)
        Next
        txtTotalLab.Text = Format(LabUnits, "0.00")
    End Sub
    Public Sub TotalUnits()
        Dim totalUnits As Double
        totalUnits = Val(txtTotalLecUnits.Text) + Val(txtTotalLab.Text)
        txtTotalUnits.Text = Format(totalUnits, "0.00")
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record from the Certificate of Enrollment?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Deleted student from registration','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc8 As New MySqlCommand(str, conn)
                mysc8.ExecuteNonQuery()
                conn.Close()

                MsgBox("Selected record has been deleted", MsgBoxStyle.Information)
                FormLoad()
                lvCOR.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub loadEnrolledSubjects()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvCOR.Items.Add(newrow.Item(1))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(7))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(8))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(9))
                'lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(10))
                'lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(21))
            Next

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Public Sub getRemainSlot()
        Try
            Dim remainSlot As Integer

            str = "select * from semsubjects where SubjectCode='" & lvCOR.Items(0).Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
            conn.Open()

            Dim mysda As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysda.ExecuteReader

            While mysDR.Read
                remainSlot = Val(mysDR(9)) - 1
            End While
            lblSlot.Text = remainSlot
            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getFinalSlot()
        Dim finalslot As Integer
        finalslot = lblSlot.Text - 1
        lblFinalSlot.Text = finalslot
    End Sub

    Private Sub lblSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSlot.Click
        getFinalSlot()
    End Sub

    Private Sub tsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        Try
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, scholarshipCoordinator, st.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' order by r.SubjectCode"
            conn.Open()
            Dim mysda2 As New MySqlDataAdapter(str, conn)
            Dim ds2 As New DataSet
            mysda2.Fill(ds2, "registration, studeprofile, srms_settings")
            Dim obj As New COR1
            obj.SetDataSource(ds2.Tables("registration, studeprofile, srms_settings"))
            obj.SetParameterValue("name", frmParent.lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getTotalLab()
        Try

            Dim totalLab As Double
            For i As Integer = 0 To lvCOR.Items.Count - 1
                'get total lab fee
                str = "select * from subjects where SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                Dim mysDR As MySqlDataReader = mysC.ExecuteReader

                While mysDR.Read
                    totalLab += Val(mysDR(14))
                End While
                lblLabFee.Text = totalLab
                conn.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getCourseShortName()
        Try
            'str = "select * from course_table where CourseDescription='" & lblCourse.Text & "' group by courseGroup"
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from course_table where CourseDescription='" & txtCourse.Text & "' and Major='" & txtMajor.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                'txtChecked.Text = dtReader(5)
                txtCourseCode.Text = dtReader(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

End Class