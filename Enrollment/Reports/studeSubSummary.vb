Imports MySql.Data.MySqlClient
Public Class frmstudeSubSummary
    Dim str As String
    Private Sub frmstudeSubSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        cboCourse.ResetText()
        cboYearLevelAccount.ResetText()
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
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If cboYearLevelAccount.Text = "" Then
                MsgBox("Year Level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Name, p.Sex, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Course, r.YearLevel, r.Section, r.Sem, r.SY  from studeprofile p join registration r on p.StudentNumber=r.StudentNumber where r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Course='" & cboCourse.Text & "' and r.YearLevel='" & cboYearLevelAccount.Text & "' order by Name"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "registration, studeprofile")
            Dim obj As New StudeSubjectsSummary
            obj.SetDataSource(mysds.Tables("registration, studeprofile"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class