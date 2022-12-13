Imports MySql.Data.MySqlClient
Public Class frmListGraduates
    Dim str As String
    Private Sub ListGraduates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub formload()
        getCourse()
        getMajor()
        preview()
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
            'cboCourseCode.DisplayMember = "CourseCode"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
            conn.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
            conn.Close()
        End Try
    End Sub
    Public Sub getMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboMajor.ValueMember = "course_table"
            cboMajor.DisplayMember = "Major"
            cboMajor.DataSource = ds.Tables("course_table")

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub preview()
        Try
            str = "SELECT g.StudentNumber, concat(s.FirstName,' ',s.LastName) as Name, g.Course, g.Major, g.sygraduated FROM alum_reg g join studeprofile s on s.StudentNumber = g.StudentNumber where g.Course='" & cboCourse.Text & "' and g.Major='" & cboMajor.Text & "' and g.sygraduated='" & frmParent.lblSY.Text & "'group by g.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "alum_reg, studeprofile")
            dglist.DataSource = ds.Tables("alum_reg, studeprofile")
            conn.Close()


            dglist.Columns(0).HeaderText = "Student No."
            dglist.Columns(0).Width = 100
            dglist.Columns(1).HeaderText = "Name"
            dglist.Columns(1).Width = 200
            dglist.Columns(2).HeaderText = "Course"
            dglist.Columns(2).Width = 300
            dglist.Columns(3).HeaderText = "Major"
            dglist.Columns(3).Width = 250
            dglist.Columns(4).HeaderText = "School Year"
            dglist.Columns(4).Width = 100


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            str = "SELECT a.*, s.FirstName, s.MiddleName, s.LastName, t.SchoolName, t.SchoolAddress, t.SchoolHead, t.sHeadPosition, t.letterHead FROM  alum_reg a INNER JOIN studeprofile s ON a.StudentNumber = s.StudentNumber INNER JOIN srms_settings t ON s.settingsID = t.settingsID where a.sygraduated='" & frmParent.lblSY.Text & "' and a.Course='" & cboCourse.Text & "' and a.Major='" & cboMajor.Text & "' order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, alum_reg, srms_settings")
            Dim obj As New ListofGraduates
            obj.SetDataSource(mysds.Tables("studeprofile, alum_reg, srms_settings"))
            obj.SetParameterValue("SEMESTER", frmParent.lblSem.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getMajor()
        preview()
    End Sub

    Private Sub cboMajor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajor.SelectedIndexChanged
        preview()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

    End Sub
End Class