Imports MySql.Data.MySqlClient
Public Class frmEnrollmentReportDashboard
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If rdoFilipino.Checked = True Then
                str = "SELECT p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.nationality, p.sex, p.BirthDate, concat(p.brgyPresent,' ',p.cityPresent,', ',p.provincePresent) as address, ss.Course, ss.Semester, ss.SY, ss.yearLevel, profImage FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join profimage pi on p.StudentNumber=pi.StudentNumber where ss.Course='" & cboCourse.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Nationality='Filipino' order by p.LastName"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude, profimage")
                Dim obj As New caapEnrollmentReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, profimage"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            Else
                str = "SELECT p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.nationality, p.sex, p.BirthDate, concat(p.brgyPresent,' ',p.cityPresent,', ',p.provincePresent) as address, ss.Course, ss.Semester, ss.SY, ss.yearLevel, profImage FROM studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join profimage pi on p.StudentNumber=pi.StudentNumber where ss.Course='" & cboCourse.Text & "' and ss.YearLevel='" & cboYearLevel.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and p.Nationality!='Filipino' order by p.LastName"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude, profimage")
                Dim obj As New caapEnrollmentReport
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude, profimage"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmEnrollmentReportDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
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

End Class