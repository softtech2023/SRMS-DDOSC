Imports MySql.Data.MySqlClient
Public Class frmReportPerSection
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Year level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSection.Text = "" Then
                MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "SELECT ss.StudentNumber, CONCAT(ss.LName, ', ', ss.FName, ' ', ss.MName) AS Fullname, ss.Course, ss.Major, ss.YearLevel, ss.Status, ss.YearLevelStat, ss.Scholarship, ss.Semester, ss.SY, ss.Term, ss.Section, ss.semstudentid, s.SchoolName, s.SchoolAddress, s.SchoolHead, s.sHeadPosition, s.Registrar, s.registrarPosition, s.letterHead FROM semesterstude ss join srms_settings s on ss.settingsID=s.settingsID where ss.Status='Enrolled' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "' order by Fullname"
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmReportPerSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        getSection()
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
    Public Sub getSection()
        Try
            str = "select * from sections group by Section order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()
            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class