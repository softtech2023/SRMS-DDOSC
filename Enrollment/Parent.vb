Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.IO
Public Class frmParent
    Dim str As String

    Private Sub frmParent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Parent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
        Me.Text = lblSchoolName.Text + " | " + "POWERED BY SOFTTECH SOLUTIONS"
        Timer1.Start()
        dtpDate.Text = Convert.ToDateTime(Today).ToString("yyyy-MM-dd")
        LoginForm.ShowDialog()
        getclassDate()

    End Sub
    Public Sub getclassDate()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT classStart FROM classsched where Semester='" & lblSem.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblclassDate.Text = dtReader(0)
              
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.Show()
    End Sub

    Private Sub BySubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySubjectToolStripMenuItem.Click
        frmMasterList.Show()
    End Sub

    Private Sub ByCourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCourseToolStripMenuItem1.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub StudentsAccountsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAccountsToolStripMenuItem1.Click
        frmStudeAccount.Show()
    End Sub

    Private Sub DailyCollectionReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCollectionReportsToolStripMenuItem.Click
        frmCollectionDashboard.ShowDialog()
    End Sub

    Private Sub ExpensesReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesReportsToolStripMenuItem.Click
        frmExpReportDashobard.ShowDialog()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.Guardian, p.GuardianAddress, p.GuardianContact, s.Course, s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' order by StudentName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New SemesterStudeList
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ByCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInsurance.ShowDialog()
    End Sub

    Private Sub StudentsAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAccountsToolStripMenu.Click
        frmBilling.Show()
    End Sub

    Private Sub EditPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub PromissoryNoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromissoryNoteToolStripMenuItem1.Click
        frmPromissory.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem1.Click
        frmExpenses.ShowDialog()
    End Sub

    Private Sub SearchOfficialReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOfficialReceiptToolStripMenuItem.Click
        frmSearchOR.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStudentToolStripMenuItem.Click
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterStudentToolStripMenuItem.Click
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CertificateOfRegistrationToolStripMenuItem2.Click
        frmCOR.Show()
    End Sub

    Private Sub PreviousSchoolFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousSchoolFormToolStripMenuItem1.Click
        frmPrevSchool.Show()
    End Sub


    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        ' frmStaff.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem1.Click
        frmCourses.ShowDialog()
    End Sub

    Private Sub SubjectsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem2.Click
        frmSubjects.ShowDialog()
    End Sub

    Private Sub SemesterSchedulingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterSchedulingToolStripMenuItem.Click
        frmSemSubjects.ShowDialog()
    End Sub

    Private Sub ManageUserAcctsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserAcctsToolStripMenuItem.Click
        frmuseraccounts.ShowDialog()
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMaintenance.Click
        Try
            If Not Directory.Exists("d:\db_backup") Then
                Directory.CreateDirectory("d:\db_backup")
            End If

            Dim dateM, dateD, dateY, dateAll As String

            dateM = System.DateTime.Now.Month
            dateD = System.DateTime.Now.Day
            dateY = System.DateTime.Now.Year

            dateAll = dateM + "-" + dateD + "-" + dateY
            Process.Start("C:\Program Files\MySQL\MySQL Server 5.0\bin\mysqldump.exe", "--user=root --password=candortci  --host=localhost  --databases srmscollege_demo -r ""D:\db_backup\" + dateAll + "-enrollment-sims.sql")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmChangeSemester.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub PaymentHistoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportOfGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


    Private Sub StudentsProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeProfile.Show()
    End Sub

    Private Sub SemesterStudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub CertificateOfRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCOR.Show()
    End Sub

    Private Sub PreviousSchoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrevSchool.Show()
    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSubjects.ShowDialog()
    End Sub

    Private Sub SemesterSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSemSubjects.ShowDialog()
    End Sub

    Private Sub StudentsAccountToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBilling.Show()
    End Sub

    Private Sub FacultyLoadingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyLoadingToolStripMenuItem1.Click
        frmLoading.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginForm.txtUserName.Clear()
        LoginForm.txtpassword.Clear()
        LoginForm.ShowDialog()
        LoginForm.txtUserName.Focus()
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeStatementToolStripMenuItem.Click
        frmIncomeStatement.ShowDialog()
    End Sub

    Private Sub PromissoryNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromissoryNotesToolStripMenuItem.Click
        Try
            str = "select promissoryID, DateApplied, StudentNumber, concat(LastName,', ',FirstName) as Name, Guardian, Amount, PromisedDate, Status, Sem, SY from promissory where Sem='" & lblSem.Text & "' and SY='" & lblSY.Text & "' and Status='For Compliance' order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "promissory")
            Dim obj As New PromissoryReport
            obj.SetDataSource(ds.Tables("promissory"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub StudentsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassSchedule.Click
        frmClassSchedPrinting.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub ExitToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub tsFacultyLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFacultyLoading.Click
        Try

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()
            'str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, (s.LecUnit + s.LabUnit) as Units, s.SY, s.Semester, s.term, s.Course, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead, st.VPResExt, st.VPAcadAffair, st.VPREposition, st.VPAAposition from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings st on s.settingsID=st.settingsID where s.Instructor='" & lblInstructor.Text & "' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, (s.LecUnit + s.LabUnit) as Units, s.SY, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings st on s.settingsID=st.settingsID where i.IDNumber='" & lblUser.Text & "' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            'Dim obj As New TeachingLoad
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
            'obj.SetParameterValue("classDate", lblclassDate.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmPrintGradingSheet.Show()
    End Sub

    Private Sub tsSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSwitch.Click
        ChangeSem.Show()
    End Sub

    Private Sub PrevGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrevGrades.ShowDialog()
    End Sub

    Private Sub CurriculumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCurriculumPrinting.ShowDialog()
    End Sub


    Private Sub VoidOfficialReceiptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoidOfficialReceiptsToolStripMenuItem.Click
        frmVoidOR.ShowDialog()
    End Sub

    Private Sub ORTrackingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORTrackingToolStripMenuItem.Click
        frmCollectionSummaryDashboard.Show()
    End Sub

    Private Sub ListOfVoidReceiptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfVoidReceiptsToolStripMenuItem.Click
        frmVoidReport.ShowDialog()
    End Sub

    Private Sub CurriculumToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCurriculumPrinting.ShowDialog()
    End Sub

    Private Sub StudentsWithBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithBalanceToolStripMenuItem.Click
        Try
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance>'0' group by p.StudentNumber order by Fullname"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance>'0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsWithoutBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithoutBalanceToolStripMenuItem.Click
        Try
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance<='0' group by p.StudentNumber order by Fullname"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance<='0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub BySectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySectionToolStripMenuItem.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub CollectionSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionSummaryToolStripMenuItem.Click
        frmCourseCollectionSummary.ShowDialog()
    End Sub

    Private Sub tsInputGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInputGrades.Click
        frminstructor_input.Show()
    End Sub

    Private Sub AcademicCalendarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicCalendarToolStripMenuItem.Click
        frmAcademic_Calendar.Show()
    End Sub

    Private Sub AcademicCalendarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicCalendarToolStripMenuItem1.Click
        Try
            str = "select * from calendar where SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "calendar")
            Dim obj As New ACalendar
            obj.SetDataSource(ds.Tables("calendar"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub RoomsAndSectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsAndSectionsToolStripMenuItem.Click
        frmRooms.Show()
    End Sub

    Private Sub CertificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ForeignStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForeignStudentsToolStripMenuItem.Click
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.MobileNumber, s.Course, p.Citizenship,  s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where p.Citizenship !='Filipino' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' order by s.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ForeignStudents
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ForeignStudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select concat(s.LName,', ',s.FName,' ',s.MName) as StudentName, p.Address, p.MobileNumber, s.Course, p.Citizenship,  s.Semester, s.Term, s.SY from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where p.Citizenship !='Filipino' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' order by s.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ForeignStudents
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub GraduatingStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGraduatingStudes.ShowDialog()
    End Sub

    Private Sub ApplicationForGraduationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGradApplication.ShowDialog()
    End Sub

    Private Sub ClassRoomSchedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassRoomSchedulesToolStripMenuItem.Click
        frmRoomSched.ShowDialog()
    End Sub

    Private Sub OtherReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeSpecialReport.Show()
    End Sub

    Private Sub OtherReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherReportsToolStripMenuItem1.Click
        frmStudeSpecialReport.ShowDialog()
    End Sub

    Private Sub ReligionCountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select p.Religion, count(Religion), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Religion order by p.Religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ReligionCounts
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub MunicipalityCountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select p.City, count(City), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.City order by p.City "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New EnrolledPerMunicipality
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub GenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderToolStripMenuItem.Click
        Try
            str = "select p.Sex, count(Sex), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Sex order by p.Sex"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New Sex
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByMunicipalityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByMunicipalityToolStripMenuItem.Click
        Try
            str = "select p.City, count(City), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.City order by p.City "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New PerMunChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByReligionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByReligionToolStripMenuItem.Click
        Try
            str = "select p.Religion, count(Religion), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Religion order by p.Religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New ReligionChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByEthnicityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEthnicityToolStripMenuItem.Click
        Try
            str = "select p.Ethnicity, count(Ethnicity), ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' group by p.Religion order by p.Ethnicity"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New EthnicityChart
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsFinancialReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsFinancialReportsToolStripMenuItem1.Click
        frmStudeReport_Accounting.Show()
    End Sub

    Private Sub ReportOfGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStudeReport_Old.Show()
    End Sub

    Private Sub OldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldToolStripMenuItem.Click
        frmPrevGrades.ShowDialog()
    End Sub

    Private Sub ReceivedGradingSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceivedGradingSheetToolStripMenuItem.Click
        frmReceiveGradeSheets.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        End
    End Sub

    Private Sub ByStudentStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByStudentStatusToolStripMenuItem1.Click
        frmByStudentStat.Show()
    End Sub

    Private Sub ByYearLevelStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByYearLevelStatusToolStripMenuItem1.Click
        frmByYearLevelStat.Show()
    End Sub

    Private Sub OtherReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TranscriptOfRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInputGrades.ShowDialog()
    End Sub

    Private Sub OldToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGradesOld.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "select r.SubjectCode, r.Description, count(*) as Enrolled, r.Section, r.Sem, r.SY from registration r where r.Sem='" & lblSem.Text & "' and r.SY='" & lblSY.Text & "' group by r.SubjectCode, r.Section order by r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            Dim obj As New SlotsMonitoring
            obj.SetDataSource(ds.Tables("registration"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub LockUnlockGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockUnlockGradesToolStripMenuItem.Click
        frmLockUnlockGrades.Show()
    End Sub
    Private Sub PaymentDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentDescriptionToolStripMenuItem.Click
        frmOtherIncomDesc.ShowDialog()
    End Sub

    Private Sub ScholarshipsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScholarshipsToolStripMenuItem.Click
        frmScholarship.Show()
    End Sub

    Private Sub FacultyAndStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyAndStaffToolStripMenuItem.Click
        'frmStaff.Show()
    End Sub

    Private Sub RoomsAndSectionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsAndSectionsToolStripMenuItem1.Click
        frmRooms.Show()
    End Sub

    Private Sub SchedulingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulingToolStripMenuItem.Click
        frmSemSubjects.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ChangeSemesterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeSemesterToolStripMenuItem.Click
        ChangeSem.ShowDialog()
    End Sub

    Private Sub InputGradesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputGradesToolStripMenuItem1.Click
        frmInputGrades.ShowDialog()
    End Sub

    Private Sub FacultyLoadingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyLoadingToolStripMenuItem.Click
        frmLoading.Show()
    End Sub

    Private Sub StudentsSubjectSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsSubjectSummaryToolStripMenuItem.Click
        frmstudeSubSummary.ShowDialog()
    End Sub

    Private Sub SchoolFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolFeesToolStripMenuItem.Click
        frmPayment.Show()
    End Sub

    Private Sub OthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersToolStripMenuItem.Click
        frmOtherIncome.ShowDialog()
    End Sub

    Private Sub TutionFeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutionFeesToolStripMenuItem.Click
        frmCourseFees.ShowDialog()
    End Sub

    Private Sub CourseFeesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseFeesToolStripMenuItem1.Click
        frmFees.ShowDialog()
    End Sub

    Private Sub CashReceiptsRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReceiptsRecordToolStripMenuItem.Click
        frmCRR_Dashboard.Show()
    End Sub

    Private Sub FTERecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTERecordsToolStripMenuItem.Click
        frmFTE_Records.Show()
    End Sub

    Private Sub PromotionalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EnrollmentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ScholarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScholarToolStripMenuItem.Click
        frmScholarship.Show()
    End Sub

    Private Sub PreviousSchoolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousSchoolsToolStripMenuItem.Click
        frmPrevSchool.Show()
    End Sub

    Private Sub StudentsReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsReportsToolStripMenuItem.Click
        frmCertification.Show()
    End Sub

    Private Sub TranscriptOfRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranscriptOfRecordsToolStripMenuItem1.Click
        frmStudeTOR.Show()
    End Sub

    Private Sub PromotionalReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotionalReportToolStripMenuItem1.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as studeName, p.Sex, ss.Course, ss.Major, ss.YearLevel, g.SubjectCode, g.Description, g.Final, (g.LecUnit+g.LabUnit) as Units, g.Semester, g.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' and g.Semester='" & lblSem.Text & "' and g.SY='" & lblSY.Text & "' order by studeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, grades")
            Dim obj As New Promotional
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, grades"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub EnrollmentReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentReportToolStripMenuItem1.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as studeName, p.Sex, ss.Course, ss.Major, ss.YearLevel, g.SubjectCode, g.Description, (g.LecUnit+g.LabUnit) as Units, g.Sem, g.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join registration g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' and g.Sem='" & lblSem.Text & "' and g.SY='" & lblSY.Text & "' order by studeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, registration")
            Dim obj As New enrollReport
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, registration"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub OtherReportsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherReportsToolStripMenuItem.Click
        frmStudeSpecialReport.Show()
    End Sub

    Private Sub GradingSheetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingSheetToolStripMenuItem1.Click
        frmGradingSheets.Show()
    End Sub

    Private Sub SlotsMonitoringToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlotsMonitoringToolStripMenuItem1.Click
        Try
            str = "select r.SubjectCode, r.Description, count(*) as Enrolled, r.Section, r.Term, r.SchedTime, r.Instructor, r.Sem, r.SY from registration r where r.Sem='" & lblSem.Text & "' and r.SY='" & lblSY.Text & "' group by r.SubjectCode, r.Section, r.Instructor, r.SchedTime order by r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            Dim obj As New SlotsMonitoring
            obj.SetDataSource(ds.Tables("registration"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsSubjectsSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsSubjectsSummaryToolStripMenuItem.Click
        frmstudeSubSummary.ShowDialog()
    End Sub


    Private Sub BySubjectToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySubjectToolStripMenuItem2.Click
        frmMasterList.Show()
    End Sub

    Private Sub ByCourseToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCourseToolStripMenuItem3.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub BySectionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySectionToolStripMenuItem2.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub ByStudentStatusToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByStudentStatusToolStripMenuItem2.Click
        frmByStudentStat.Show()
    End Sub

    Private Sub ByYearLevelStatusToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByYearLevelStatusToolStripMenuItem2.Click
        frmByYearLevelStat.Show()
    End Sub

    Private Sub ListOfCrossEnrolleesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfCrossEnrolleesToolStripMenuItem.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, p.Sex, ss.Course, ss.classSession, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead  from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.crossEnrollee='Yes' and ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New crossEnrolleesList
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ListOfTransfereesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfTransfereesToolStripMenuItem.Click
      
    End Sub

    Private Sub FTERecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTERecordsToolStripMenuItem1.Click
        frmFTE_Records.Show()
    End Sub

    Private Sub StudentsFinancialReportsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsFinancialReportsToolStripMenuItem2.Click
        frmStudeReport_Accounting.Show()
    End Sub

    Private Sub StudentsAccountsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsAccountsToolStripMenuItem.Click
        frmStudeAccount.Show()
    End Sub

    Private Sub StudentsWithBalanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithBalanceToolStripMenuItem1.Click
        Try
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance>'0' group by p.StudentNumber order by Fullname"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance>'0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentsWithoutBalanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsWithoutBalanceToolStripMenuItem1.Click
        Try
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance<='0' group by p.StudentNumber order by Fullname"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Sem='" & lblSem.Text & "' and b.SY='" & lblSY.Text & "' and b.CurrentBalance<='0' group by p.StudentNumber order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccounts_All
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub CashReceiptsRecordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReceiptsRecordToolStripMenuItem1.Click
        frmCRR_Dashboard.Show()
    End Sub

    Private Sub DailyCollectionReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCollectionReportsToolStripMenuItem1.Click
        frmCollectionDashboard.ShowDialog()
    End Sub

    Private Sub DailyCollectionSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCollectionSummaryToolStripMenuItem.Click
        frmCourseCollectionSummary.ShowDialog()
    End Sub

    Public Sub getAcctLevel()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from users where username='" & lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblUserLevel.Text = dtReader(2)
                lblName.Text = dtReader(10)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub ByScholarshipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByScholarshipToolStripMenuItem.Click
        frmScholarshipDashboard.Show()
    End Sub

    Private Sub ByCourseToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCourseToolStripMenuItem.Click
        frmScholarshipDashboardByCourse.Show()
    End Sub

    Private Sub cboCivilStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCivilStatus.TextChanged
        Try
            str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.CivilStatus, s.YearLevel, s.YearLevel, s.Course, s.Scholarship, s.prevGPA, s.Semester, s.SY, st.SchoolName, st.SchoolAddress from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Status='Enrolled' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' and p.CivilStatus='" & cboCivilStatus.Text & "' order by p.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New civilStatReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ListOf4PsBeneficiariesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOf4PsBeneficiariesToolStripMenuItem.Click
        Try
            str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where fourPs='Yes' and Status='Enrolled' group by s.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New FourPs
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub AddingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingFormToolStripMenuItem.Click
        frmAdding.Show()
    End Sub

    Private Sub AddingFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingFormToolStripMenuItem1.Click
        frmAdding.Show()
    End Sub

    Private Sub DroppingFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DroppingFormToolStripMenuItem1.Click
        frmDroppingForm.Show()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2ToolStripMenuItem.Click
        Try
            'str = "select p.StudentNumber, p.FirstName, p.LastName, mid(p.MiddleName, 1,1) as MI, mid(p.Sex, 1,1) as Sex, p.email, p.contactNo, s.Course, s.Major, s.YearLevel, s.Scholarship, s.GrantAmount, a.LecUnits, a.LabUnits, a.LecUnits+a.LabUnits as totalUnits, a.AcctTotal, a.Sem, a.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.scholarshipCoordinator, st.accountant, st.Registrar from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join studeaccount a on p.StudentNumber=a.StudentNumber join srms_settings st on a.settingsID=st.settingsID where a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and s.Scholarship!='' group by a.StudentNumber order by a.LastName"
            str = "select DISTINCT p.StudentNumber, p.FirstName, p.LastName, mid(p.MiddleName, 1,1) as MI, mid(p.Sex, 1,1) as Sex, p.email, p.contactNo, s.Course, s.Major, s.YearLevel, s.Scholarship, s.GrantAmount, r.totalUnits, a.AcctTotal, a.Sem, a.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.scholarshipCoordinator, st.accountant, st.Registrar from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join registration r on p.StudentNumber=r.StudentNumber join studeaccount a on p.StudentNumber=a.StudentNumber join srms_settings st on a.settingsID=st.settingsID where r.Sem='" & lblSem.Text & "' and r.SY='" & lblSY.Text & "' and a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and s.Scholarship!='' group by p.StudentNumber order by a.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude, studeaccount, srms_settings")
            Dim obj As New FormBilling
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, studeaccount, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub DroppingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DroppingFormToolStripMenuItem.Click
        frmDroppingForm.Show()
    End Sub

    Private Sub stTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stTime.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        stTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub UpdateStudentScholarshipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdateScholarship.Click
        frmUpdateScholarship.Show()
    End Sub

    Private Sub Version2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version2ToolStripMenuItem.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as studeName, p.Sex, ss.Course, ss.Major, ss.YearLevel, g.SubjectCode, g.Description, (g.LecUnit+g.LabUnit) as Units, g.Sem, g.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join registration g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' and g.Sem='" & lblSem.Text & "' and g.SY='" & lblSY.Text & "' order by studeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, registration")
            Dim obj As New enrollReport
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, registration"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Version1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version1ToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, p.Sex, r.SubjectCode, sum(r.LecUnit+r.LabUnit) as Units, r.Sem, r.SY, st.SchoolName, st.SchoolAddress, st.registrar, st.registrarPosition from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on r.settingsID=st.settingsID where r.Sem='" & lblSem.Text & "' and r.SY='" & lblSY.Text & "' group by p.StudentNumber, r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, registration, srms_settings")
            Dim obj As New enrolReportv1
            obj.SetDataSource(ds.Tables("studeprofile, registration, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem.Click

    End Sub

    Private Sub ListOfReturneesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfReturneesToolStripMenuItem.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, p.Sex, ss.Course, ss.classSession, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead  from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.StudeStatus='Returnee' and ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New ReturneesList
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, srms_settings"))
            obj.SetParameterValue("name", lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ListOfWorkingStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfWorkingStudentsToolStripMenuItem.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, p.Sex, ss.Course, ss.classSession, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead  from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where p.working='Yes' and ss.Status='Enrolled' and ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New WorkingStudents
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, srms_settings"))
            obj.SetParameterValue("name", lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub SRMSSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SRMSSettingsToolStripMenuItem.Click
        frmSystemSettings.Show()
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
                lblSchoolName.Text = dtReader(1)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ListOfSoloParentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfSoloParentsToolStripMenuItem.Click

    End Sub

    Private Sub tsCataloging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCataloging.Click
        frmBooksInfo.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        ChangeSem.Show()
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorToolStripMenuItem.Click
        frmAuthors.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        frmCategory.Show()
    End Sub

    Private Sub LocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationToolStripMenuItem.Click
        frmLocation.Show()
    End Sub

    Private Sub PublisherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PublisherToolStripMenuItem.Click
        frmPublisher.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmSearchBooksMain.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        frmLoanBooks.Show()
    End Sub

    Private Sub TeacherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherToolStripMenuItem.Click
        frmStaffLoan.Show()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        frmReturnBooks.Show()
    End Sub

    Private Sub StudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem1.Click
        frmReturnBooks.Show()
    End Sub

    Private Sub StudentsGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsGradesToolStripMenuItem.Click
        frmStudeGrades.Show()
    End Sub

    Private Sub BorrowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowToolStripMenuItem.Click
        frmLoanBooks.Show()
    End Sub

    Private Sub ListOfAllBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfAllBooksToolStripMenuItem.Click
        Try
            str = "SELECT l.BookNo, l.Title, count(l.Title) as BookCounts, l.Author, l.Category, l.Publisher, l.Subject, l.ISBN, l.Edition, l.CallNum, l.Location, l.AccNo, st.letterHead FROM libbookentry l join srms_settings st on l.settingsID=st.settingsID group by Title order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry, srms_settings")
            Dim obj As New BooksList
            obj.SetDataSource(ds.Tables("libbookentry, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCivilStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCivilStatus.Click

    End Sub

    Private Sub EquipmentMachineryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentMachineryToolStripMenuItem.Click
        frmProducts.Show()
    End Sub

    Private Sub PARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARToolStripMenuItem.Click
        frmMRDashboard.Show()
    End Sub

    Private Sub ConsumablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesToolStripMenuItem.Click
        frmProductEntry.Show()
    End Sub

    Private Sub InventoryInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryInputToolStripMenuItem.Click
        frmConsumable.Show()
    End Sub

    Private Sub ReleaseItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseItemToolStripMenuItem.Click
        frmDistribution.Show()
    End Sub

    Private Sub ReturnItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnItemToolStripMenuItem.Click
        frmmodifyform.Show()
    End Sub

    Private Sub ReprintAcknowledgementReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintAcknowledgementReceiptToolStripMenuItem.Click
        frmPARform.ShowDialog()
    End Sub

    Private Sub ConsumablesSummaryPerEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesSummaryPerEmployeeToolStripMenuItem.Click
        frmConsumableSummary.Show()
    End Sub

    Private Sub AllToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.SchoolName, ss.SchoolAddress, ss.letterHead, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub GoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodToolStripMenuItem.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.Division, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.letterHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Good' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub DefectiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectiveToolStripMenuItem.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.Division, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.letterHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Defective' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub PerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerToolStripMenuItem.Click
        frmAccountable.Show()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        frmViewing.Show()
    End Sub

    Private Sub BorrowItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowItemToolStripMenuItem.Click
        frmSettingsForm.Show()
    End Sub

    Private Sub ReturnBorrowedItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBorrowedItemToolStripMenuItem.Click
        frmCategories.Show()
    End Sub

    Private Sub AuthoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthoriToolStripMenuItem.Click
        frmbyauthor.ShowDialog()
    End Sub

    Private Sub ByCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCategoryToolStripMenuItem.Click
        frmbycat.ShowDialog()
    End Sub

    Private Sub ImportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ImportsStaffAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportsStaffAttendanceToolStripMenuItem.Click
        frmImportDTR.Show()
    End Sub

    Private Sub ImportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportsToolStripMenuItem1.Click
        frmEditDTR.Show()
    End Sub

    Private Sub CataloginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CataloginToolStripMenuItem.Click
        frmBooksInfo.Show()
    End Sub

    Private Sub BorrowToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowToolStripMenuItem1.Click
        frmLoanBooks.Show()
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem1.Click
        frmReturnBooks.Show()
    End Sub

    Private Sub SearchBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBooksToolStripMenuItem.Click
        frmSearchBooksMain.Show()
    End Sub

    Private Sub AuthorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorToolStripMenuItem1.Click
        frmAuthors.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem1.Click
        frmCategory.Show()
    End Sub

    Private Sub LocationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationToolStripMenuItem1.Click
        frmLocation.Show()
    End Sub

    Private Sub PublisherToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PublisherToolStripMenuItem1.Click
        frmPublisher.Show()
    End Sub

    Private Sub ListOfAllBooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfAllBooksToolStripMenuItem1.Click
        Try
            str = "SELECT l.BookNo, l.Title, count(l.Title) as BookCounts, l.Author, l.Category, l.Publisher, l.Subject, l.ISBN, l.Edition, l.CallNum, l.Location, l.AccNo, st.letterHead FROM libbookentry l join srms_settings st on l.settingsID=st.settingsID group by Title order by Title"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libbookentry, srms_settings")
            Dim obj As New BooksList
            obj.SetDataSource(ds.Tables("libbookentry, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByAuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByAuthorToolStripMenuItem.Click
        frmbyauthor.ShowDialog()
    End Sub

    Private Sub ByCategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCategoryToolStripMenuItem1.Click
        frmbycat.ShowDialog()
    End Sub

    Private Sub EquipmentMachineryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentMachineryToolStripMenuItem1.Click
        frmProducts.Show()
    End Sub

    Private Sub ConsumablesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesToolStripMenuItem1.Click

    End Sub

    Private Sub QuickSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickSearchToolStripMenuItem.Click
        frmViewing.Show()
    End Sub

    Private Sub UnitsAndBrandsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitsAndBrandsToolStripMenuItem.Click
        frmSettingsForm.Show()
    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesToolStripMenuItem.Click
        frmCategories.Show()
    End Sub

    Private Sub ConsumablesPerEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesPerEmployeeToolStripMenuItem.Click
        frmConsumableSummary.Show()
    End Sub

    Private Sub ReprintPARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintPARToolStripMenuItem.Click
        frmMRDashboard.Show()
    End Sub

    Private Sub ReprintAcknowledgementReceiptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintAcknowledgementReceiptToolStripMenuItem1.Click
        frmPARform.ShowDialog()
    End Sub

    Private Sub AllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem1.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.SchoolName, ss.SchoolAddress, ss.letterHead, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub DefectiveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectiveToolStripMenuItem1.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.letterHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Good' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub DefectiveToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectiveToolStripMenuItem2.Click
        Try
            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.acquiredDate, ss.SchoolName, ss.SchoolAddress, ss.SchoolHead, ss.letterHead, ss.sHeadPosition, ss.PropertyCustodian FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID where i.itemCondition='Defective' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items")
            Dim obj As New itemsList
            obj.SetDataSource(mysds.Tables("ls_items"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub PerAccountableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerAccountableToolStripMenuItem.Click
        frmAccountable.Show()
    End Sub

    Private Sub PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PToolStripMenuItem.Click
        frmProspectusDashboard.Show()
    End Sub

    Private Sub ConsumablesInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesInventoryToolStripMenuItem.Click
        Try
            str = "SELECT p.ProductName, p.ProductDescription, p.ProductCode, c.QtyDelivered, c.prodUnit, st.letterhead, st.SchoolHead, st.sHeadPosition, st.PropertyCustodian FROM ls_productentry p INNER JOIN ls_consumables c ON p.ProductCode = c.ProductCode join srms_settings st on c.settingsID=st.settingsID order by p.productName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_productentry, ls_consumables, srms_settings")
            Dim obj As New ConsumablesInventoryReport
            obj.SetDataSource(mysds.Tables("ls_productentry, ls_consumables, srms_settings"))
            frmReportViewer.CRViewer.ReportSource = obj
            frmReportViewer.CRViewer.Refresh()
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ConsumablesInventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumablesInventoryToolStripMenuItem1.Click
        Try
            str = "SELECT p.ProductName, p.ProductDescription, p.ProductCode, c.QtyDelivered, c.prodUnit, st.letterhead, st.SchoolHead, st.sHeadPosition, st.PropertyCustodian FROM ls_productentry p INNER JOIN ls_consumables c ON p.ProductCode = c.ProductCode join srms_settings st on c.settingsID=st.settingsID order by p.productName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_productentry, ls_consumables, srms_settings")
            Dim obj As New ConsumablesInventoryReport
            obj.SetDataSource(mysds.Tables("ls_productentry, ls_consumables, srms_settings"))
            frmReportViewer.CRViewer.ReportSource = obj
            frmReportViewer.CRViewer.Refresh()
            conn.Close()
            frmReportViewer.MdiParent = Me
            frmReportViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub EnrollmentSummaryDailyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentSummaryDailyToolStripMenuItem.Click
        frmStatisticsDashboard.Show()
    End Sub

    Private Sub ByScholarshipV2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByScholarshipV2ToolStripMenuItem.Click
        frmScholarshipDashboardV2.Show()
    End Sub

    Private Sub AdmissionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionReportToolStripMenuItem.Click
        Try
            'str = "SELECT s.Course, s.YearLevel, s.Status, st.SchoolName, st.schooladdress, st.letterHead FROM semesterstude s join srms_settings st on s.settingsID=st.settingsID where s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "'"
            str = "select * from semesterstude where Semester='" & lblSem.Text & "' and SY='" & lblSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New AdReport
            obj.SetDataSource(mysds.Tables("semesterstude"))
            obj.SetParameterValue("sem", lblSem.Text)
            obj.SetParameterValue("sy", lblSY.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            'frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            'frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ByEnrollmentmentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEnrollmentmentStatusToolStripMenuItem.Click
        frmByEnrollmentStat.Show()
    End Sub

    Private Sub ByEnrollmentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByEnrollmentStatusToolStripMenuItem.Click
        frmByEnrollmentStat.Show()
    End Sub

    Private Sub EnrollmentReportToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentReportToolStripMenuItem2.Click
        frmEnrollmentReportDashboard.Show()
    End Sub

    Private Sub TerminalReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminalReportToolStripMenuItem1.Click
        frmTerminalReport.Show()
    End Sub

    Private Sub PromotedStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotedStudentsToolStripMenuItem.Click
        MsgBox("Under Development!", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Try
            'str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, s.StudeStatus, r.Class, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, sf.Name from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where r.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' and s.Semester = '" & lblSem.Text & "' and s.SY = '" & lblSY.Text & "' order by r.SubjectCode"
            str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, p.BirthPlace, p.BirthDate, s.Course, s.Major, s.StudeStatus, s.YearLevel, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, sum(r.LecUnit+r.LabUnit) as totalUnits, r.Section, ss.LabTime, ss.SchedTime, ss.Room, ss.SchedType, r.Sem, r.SY, r.Term, concat(sf.LastName,', ',sf.FirstName) as Instructor, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.admissionOfficer from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings st on p.settingsID=st.settingsID where r.StudentNumber = '" & lblUser.Text & "' and r.Sem = '" & lblSem.Text & "' and r.SY = '" & lblSY.Text & "' and ss.Semester = '" & lblSem.Text & "' and ss.SY = '" & lblSY.Text & "' and s.Semester = '" & lblSem.Text & "' and s.SY = '" & lblSY.Text & "' order by r.SubjectCode"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff")
            Dim obj As New COR1
            obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
            obj.SetParameterValue("name", lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        Try
            'str = "SELECT p.StudentNumber, concat(s.FirstName,' ',s.LastName) as sStudentName, s.PDate, s.ORNumber, s.Amount, s.Sem, s.SY FROM paymentsaccounts s join studeprofile p on p.StudentNumber=s.StudentNumber where p.StudentNumber='" & lblUser.Text & "' and s.Sem='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "'"
            str = "select s.StudentNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as StudentName, s.AcctTotal, s.Discount, s.CurrentBalance, s.Sem, s.SY, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.ORStatus, pa.Sem, pa.SY, st.SchoolName, st.SchoolAddress from studeaccount s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & lblUser.Text & "' and s.Sem='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' and pa.CollectionSource!='Services' group by pa.ORNumber"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, payments")
            Dim obj As New PaymentHistory
            obj.SetDataSource(mysds.Tables("studeprofile, payments"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        Try
            'str = "select (s.lecunit+s.labunit) as TotalUnits, g.SY, g.Semester, g.Term, p.StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as StudentName, p.BirthDate, p.BirthPlace, p.Address, p.GraduationDate, p.AdmissionDate, p.HighSchool, p.HSAddress, p.College, p.CAddress, s.SubjectCode, s.Description, g.Final, g.Complied from studeprofile p join grades g on g.StudentNumber=p.StudentNumber join subjects s on s.SubjectCode=g.SubjectCode where p.StudentNumber='" & lblUser.Text & "' group by g.SY, g.Semester, g.SubjectCode"
            str = "select (g.Lecunit+g.LabUnit) as TotalUnits, g.SY, g.Semester, concat(g.Semester,', ',g.SY) as Semester, ss.StudentNumber, concat(ss.FName,' ',ss.MName,' ',ss.LName) as StudentName, ss.Course, g.SubjectCode, g.Description, g.Final, g.Complied, (g.Final*(g.LecUnit+g.LabUnit)) as gradesPoint, ss.YearLevel, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition from semesterstude ss join grades g on g.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.StudentNumber='" & lblUser.Text & "' group by g.SY, g.Semester, g.SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "p.studeprofile, r.registration, g.grades")
            Dim obj As New ReportofGrades
            obj.SetDataSource(mysds.Tables("p.studeprofile, r.registration, g.grades"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        End
    End Sub

    Private Sub StudentsReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsStudentsReports.Click
        frmCertification.Show()
    End Sub

    Private Sub StatisticalReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatisticalReportsToolStripMenuItem.Click
        frmstatProgramDashboard.MdiParent = Me
        frmstatProgramDashboard.Show()
    End Sub


    Private Sub RefundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundToolStripMenuItem.Click
        frmRefund.Show()
    End Sub

    Private Sub AccountsSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsSummaryToolStripMenuItem.Click
        Try
            'str = "select a.StudentNumber, a.FirstName, a.MiddleName, a.LastName, a.OldAccount, a.AcctTotal, a.TotalPayments, a.CurrentBalance, p.PDate, p.ORNumber, p.Amount, p.description, p.PaymentType from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber where a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and p.Sem='" & lblSem.Text & "' and p.SY='" & lblSY.Text & "' and p.ORStatus='Valid' and CollectionSource!='Services' group by a.StudentNumber order by LastName"
            str = "select * from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber where a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and p.Sem='" & lblSem.Text & "' and p.SY='" & lblSY.Text & "' and p.ORStatus='Valid' and CollectionSource!='Services' group by p.ORNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeaccount, paymentsaccounts")
            Dim obj As New AccountSummary
            obj.SetDataSource(mysds.Tables("studeaccount, paymentsaccounts"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            obj.SetParameterValue("SY", lblSY.Text)
            obj.SetParameterValue("Semester", lblSem.Text)
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub AccountSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountSummaryToolStripMenuItem.Click
        Try
            'str = "select a.StudentNumber, a.FirstName, a.MiddleName, a.LastName, a.OldAccount, a.AcctTotal, a.TotalPayments, a.CurrentBalance, p.PDate, p.ORNumber, p.Amount, p.description, p.PaymentType from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber where a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and p.Sem='" & lblSem.Text & "' and p.SY='" & lblSY.Text & "' and p.ORStatus='Valid' and CollectionSource!='Services' group by a.StudentNumber order by LastName"
            str = "select * from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber where a.Sem='" & lblSem.Text & "' and a.SY='" & lblSY.Text & "' and p.Sem='" & lblSem.Text & "' and p.SY='" & lblSY.Text & "' and p.ORStatus='Valid' and CollectionSource!='Services' group by p.ORNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeaccount, paymentsaccounts")
            Dim obj As New AccountSummary
            obj.SetDataSource(mysds.Tables("studeaccount, paymentsaccounts"))
            frmMainViewer.ReportViewer.ReportSource = obj

            obj.SetParameterValue("SY", lblSY.Text)
            obj.SetParameterValue("Semester", lblSem.Text)
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub RefundSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundSummaryToolStripMenuItem.Click
        frmrefundrange.ShowDialog()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsToolStripMenuItem.Click
        frmProductEntry.Show()
    End Sub

    Private Sub InventoryInputToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryInputToolStripMenuItem2.Click
        frmConsumable.Show()
    End Sub

    Private Sub ReleaseItemToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReleaseItemToolStripMenuItem2.Click
        frmDistribution.Show()
    End Sub

    Private Sub ReturnItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnItemsToolStripMenuItem.Click
        frmmodifyform.Show()
    End Sub

    Private Sub DroppedWithdrawnStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DroppedWithdrawnStudentsToolStripMenuItem.Click
        Try
            str = "SELECT s.StudentNumber, s.FName, s.MName, s.LName, s.Course, s.Major, s.YearLevel, s.Status, s.Semester, s.SY, sa.AcctTotal, sa.TotalPayments, sa.Discount, sa.CurrentBalance FROM semesterstude s join studeaccount sa on s.StudentNumber=sa.StudentNumber where s.Status!='Enrolled' and s.Semester='" & lblSem.Text & "' and s.SY='" & lblSY.Text & "' group by s.StudentNumber order by s.LName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeaccount, semesterstude")
            Dim obj As New Drp_WithdrawnStudes
            obj.SetDataSource(mysds.Tables("studeaccount, semesterstude"))
            'obj.SetParameterValue("sem", lblSem.Text)
            'obj.SetParameterValue("sy", lblSY.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub CurrentlyEnrolledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentlyEnrolledToolStripMenuItem.Click
        Try
            str = "SELECT s.StudentNumber, s.FirstName, s.MiddleName, s.LastName, s.Sex, s.BirthDate, concat(s.sitioPresent,', ',s.brgyPresent,', ',s.cityPresent,', ',s.provincePresent) as Address, s.guardian, st.Course, st.YearLevel, st.Major, st.SY, st.Semester from studeprofile s join semesterstude st on s.StudentNumber=st.StudentNumber where st.Semester='" & lblSem.Text & "' and st.SY='" & lblSY.Text & "' group by st.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New StudeAssessmentSummary
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()

            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsScheduling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsScheduling.Click
        frmSemSubjects.ShowDialog()
    End Sub

    Private Sub tsLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLoading.Click
        frmLoading.Show()
    End Sub

    Private Sub tsMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMasterlist.Click
        frmMasterList.Show()
    End Sub

    Private Sub StudentsReportsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudToolStripMenuItem.Click
        frmCertification.Show()
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        frmCertification.Show()
    End Sub

    Private Sub DataEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataEntryToolStripMenuItem.Click
        frmCandidatesEntry.ShowDialog()
    End Sub

    Private Sub ListOfCandidatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfCandidatesToolStripMenuItem.Click
        frmListCandidates.Show()
    End Sub

    Private Sub lblSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSem.Click

    End Sub

    Private Sub GraduatesEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraduatesEntryToolStripMenuItem.Click
        frmGraduateEntry.ShowDialog()
    End Sub

    Private Sub ListOfGraduatesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfGraduatesToolStripMenuItem2.Click
        frmListGraduates.ShowDialog()
    End Sub

    Private Sub ListOfTransfereesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfTransfereesToolStripMenuItem1.Click
        Try
            str = "select * from semesterstude s join srms_settings st on s.settingsID=st.settingsID where Semester='" & lblSem.Text & "' and SY='" & lblSY.Text & "' and StudeStatus='Transferee' order by lName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New ListOfTransfereeReport
            obj.SetDataSource(mysds.Tables("semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()

            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub StudentVerificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentVerificationToolStripMenuItem.Click
        frmStudentVerification.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmCAV.Show()
    End Sub

    Private Sub UpdateAlumniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAlumniToolStripMenuItem.Click
        frmGradUpdate.ShowDialog()
    End Sub

    Private Sub Version1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version1ToolStripMenuItem1.Click
        Try
            str = "select concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.YearLevel, p.Sex, ss.Course, ss.classSession, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead  from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.StudeStatus='Transferee' and ss.Semester='" & lblSem.Text & "' and ss.SY='" & lblSY.Text & "' order by ss.LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, srms_settings")
            Dim obj As New transfereesList
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude, srms_settings"))
            obj.SetParameterValue("name", lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Version2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version2ToolStripMenuItem1.Click
        Try
            str = "select * from semesterstude s join srms_settings st on s.settingsID=st.settingsID where Semester='" & lblSem.Text & "' and SY='" & lblSY.Text & "' and StudeStatus='Transferee' order by lName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New ListOfTransfereeReport
            obj.SetDataSource(mysds.Tables("semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()

            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub AllToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem2.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "All")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ForValidationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForValidationToolStripMenuItem.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where enrolStatus='For Validation' and downPaymentStat='Paid'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "For Validation")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub EnrolledToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolledToolStripMenuItem.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where enrolStatus='Enrolled'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "Validated")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub AllToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem3.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "All")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ForVerificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForVerificationToolStripMenuItem.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where enrolStatus='For Validation' and downPaymentStat='Paid'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "For Validation")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub EnrolledToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolledToolStripMenuItem1.Click
        Try
            str = "SELECT * FROM online_enrollment o join studeprofile p on o.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where enrolStatus='Enrolled'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, srms_settings, online_enrollment")
            Dim obj As New OEnrollees
            obj.SetDataSource(mysds.Tables("studeprofile, srms_settings, online_enrollment"))
            obj.SetParameterValue("enrolStatus", "Validated")
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = Me
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        frmInputGrades.ShowDialog()
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        frmGradingSheets.Show()
    End Sub
End Class