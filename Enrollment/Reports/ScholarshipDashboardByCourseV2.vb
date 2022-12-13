Imports MySql.Data.MySqlClient
Public Class frmScholarshipDashboardByCourseV2
    Dim str As String
    Public Sub getCourse()
        Try
            Str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
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

    Private Sub frmScholarshipDashboardByCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select p.StudentNumber, p.LastName, p.FirstName, MID(p.MiddleName,1,1) as MI, s.YearLevel, s.YearLevel, s.Course, s.Scholarship, s.prevGPA, s.Semester, s.SY, st.SchoolName, st.SchoolAddress from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Status='Enrolled' and s.Course='" & cboCourse.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' order by s.YearLevel, p.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New ScholarsByCourse
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class