Imports MySql.Data.MySqlClient
Public Class frmFTE_Records
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try

            str = "SELECT LastName, FirstName, MiddleName, Sem, SY, Course, Major, YearLevel, sum(LecUnit), sum(LabUnit), st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.clerk, st.clerkPosition, st.administrative, st.administrativePosition, st.letterHead FROM registration r join srms_settings st on r.settingsID=st.settingsID where r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and r.YearLevel='" & cboYearLevel.Text & "' group by r.StudentNumber order by r.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "registration")
            Dim obj As New FTE
            obj.SetDataSource(mysds.Tables("registration"))
            obj.SetParameterValue("clerk", frmParent.lblName.Text)
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

    Private Sub frmFTE_Records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
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