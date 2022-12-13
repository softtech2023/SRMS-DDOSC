Imports MySql.Data.MySqlClient
Public Class frmMasterlistDashboardbyCourse
    Dim str As String
    Dim str2 As String
    Private Sub btnStudentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentList.Click
        Try
            If cboCourse.Text = "" And cboYearLevel.Text = "" And cboYearStat.Text = "" Then
                'str = "select StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, Course, Major, YearLevel, Status, Scholarship, Semester, SY, YearLevelStat, Section, semstudentid from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by Fullname"
                str = "SELECT ss.StudentNumber, CONCAT(ss.LName, ', ', ss.FName, ' ', ss.MName) AS Fullname, ss.Course, ss.Major, ss.YearLevel, ss.Status, ss.YearLevelStat, ss.Scholarship, ss.Semester, ss.SY, ss.Term, ss.Section, ss.semstudentid, s.SchoolName, s.SchoolAddress, s.SchoolHead, s.sHeadPosition, s.Registrar, s.registrarPosition, s.letterHead FROM semesterstude ss join srms_settings s on ss.settingsID=s.settingsID where ss.Status='Enrolled' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by Fullname"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                Dim obj As New SemesterStudeList
                obj.SetDataSource(mysds.Tables("semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                obj.SetParameterValue("name", frmParent.lblName.Text)
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                Me.Hide()

            Else
                str = "SELECT ss.StudentNumber, CONCAT(ss.LName, ', ', ss.FName, ' ', ss.MName) AS Fullname, ss.Course, ss.Major, ss.YearLevel, ss.Status, ss.YearLevelStat, ss.Scholarship, ss.Semester, ss.SY, ss.Term, ss.Section, ss.semstudentid, s.SchoolName, s.SchoolAddress, s.SchoolHead, s.sHeadPosition, s.Registrar, s.registrarPosition, s.letterHead FROM semesterstude ss join srms_settings s on ss.settingsID=s.settingsID where ss.Status='Enrolled' and Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and YearLevel='" & cboYearLevel.Text & "' order by Fullname"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                'Dim mysDA2 As New MySqlDataAdapter(str2, conn)
                Dim mysds As New DataSet
                'Dim mysds2 As New DataSet
                mysDA.Fill(mysds, "semesterstude")
                ' mysDA2.Fill(mysds2, "school_details")

                Dim obj As New StudentList
                obj.SetDataSource(mysds.Tables("semesterstude"))
                'obj.Subreports.Item("Heading.rpt").SetDataSource(mysds2.Tables("school_details"))
                frmMainViewer.ReportViewer.ReportSource = obj
                obj.SetParameterValue("name", frmParent.lblName.Text)
                frmMainViewer.ReportViewer.EnableDrillDown = False
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
                Me.Hide()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmMasterlistDashboardbyCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        cboYearLevel.ResetText()
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
End Class