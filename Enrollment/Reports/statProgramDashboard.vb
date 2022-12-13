
Imports MySql.Data.MySqlClient
Public Class frmstatProgramDashboard
    Dim str As String
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourseList.ValueMember = "course_table"
            cboCourseList.DisplayMember = "CourseDescription"
            cboCourseList.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmstatCourseDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getCourse()
    End Sub

    Private Sub frmstatCourseDashboard_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub btnView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView1.Click
        Try

            If cboCourseList.Text = "" Then
                str = "SELECT count(p.StudentNumber) as StudentCount, ss.Course, ss.Semester, ss.SY FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Status='Enrolled' group by ss.SY, ss.Semester"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statCourseReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "SELECT count(p.StudentNumber) as StudentCount, ss.Course, ss.Semester, ss.SY FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' group by ss.SY, ss.Semester"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statCourseReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView2.Click
        Try

            If cboCourseList.Text = "" Then
                str = "SELECT count(p.StudentNumber) as StudentCount, ss.Course, ss.Semester, ss.SY FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by ss.SY, ss.Semester"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statCourseReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "SELECT count(p.StudentNumber) as StudentCount, ss.Course, ss.Semester, ss.SY FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber where ss.SY='" & frmParent.lblSY.Text & "' and ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' group by ss.SY, ss.Semester"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statCourseReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnView3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView3.Click
        Try

            str = "SELECT count(p.StudentNumber) as StudentCount, ss.Course, ss.Semester, ss.SY, st.letterHead FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' group by ss.Course"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New statCourseReportTable
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))

            CrystalReportViewer2.ReportSource = obj
            CrystalReportViewer2.Refresh()
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnResidence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResidence.Click
        Try

            If cboCourseList.Text = "" Then
                str = "select p.City, count(ss.StudentNumber) as studeCount, st.letterHead, ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.City"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statResidenceReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.City, count(ss.StudentNumber) as studeCount, st.letterHead, ss.Semester, ss.SY from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' group by p.City"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statResidenceReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            str = "select ss.Course, count(ss.StudentNumber) as studeCount, ss.Semester, ss.SY, st.letterHead from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by ss.Course"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New statProgramChart
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            'obj.SetParameterValue("Course", "(All)")
            CrystalReportViewer2.ReportSource = obj
            CrystalReportViewer2.Refresh()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            str = "select p.Sex, count(ss.StudentNumber) as studeCount, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled'  group by ss.Course, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New statGenderReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            'obj.SetParameterValue("Course", "(All)")
            CrystalReportViewer2.ReportSource = obj
            CrystalReportViewer2.Refresh()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, p.ethnicity, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Ethnicity"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statEthnicityReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, p.ethnicity, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Ethnicity"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statEthnicityReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.Ethnicity, count(Ethnicity), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.Ethnicity order by p.Ethnicity"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New EthnicityChart
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "All")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.Ethnicity, count(Ethnicity), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.Ethnicity order by p.Ethnicity"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New EthnicityChart
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.Religion, count(Religion), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.Religion order by p.Religion"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New ReligionCounts
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "All")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.Religion, count(Religion), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.Religion order by p.Religion"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New ReligionCounts
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, p.Religion, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Religion"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statReligionReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, p.Religion, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled' group by p.Religion"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statReligionReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.City, count(City), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.City order by p.City "
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New EnrolledPerMunicipality
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "All")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.City, count(City), ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Status='Enrolled' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' group by p.City order by p.City "
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, semesterstude")
                Dim obj As New EnrolledPerMunicipality
                obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", cboCourseList.Text)
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            If cboCourseList.Text = "" Then
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled'  group by p.Sex"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statPerProgramGender
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            Else
                str = "select p.Sex, count(ss.StudentNumber) as studeCount, ss.Course, ss.Semester, ss.SY, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.Course='" & cboCourseList.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Status='Enrolled'  group by p.Sex"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New statPerProgramGender
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                obj.SetParameterValue("Course", "(All)")
                CrystalReportViewer2.ReportSource = obj
                CrystalReportViewer2.Refresh()
                conn.Close()
            End If
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            str = "SELECT mid(p.Sex,1,1) as Sex, s.Course, s.Major, count(s.Status) as StatusCount, s.Status, s.YearLevel, count(s.Course) as EnrolledCount, s.Semester, s.SY, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead FROM studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Status='Enrolled' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.Course, s.Major, s.YearLevel, s.Status, p.Sex order by s.Course"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New StatisticsReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            CrystalReportViewer2.ReportSource = obj
            CrystalReportViewer2.Refresh()
            conn.Close()
          
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class