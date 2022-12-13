Imports MySql.Data.MySqlClient
Public Class frmScholarshipDashboard

    Dim str As String
    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            str = "select p.StudentNumber, p.LastName, p.FirstName, MID(p.MiddleName,1,1) as MI, s.YearLevel, concat(s.YearLevel,' - ',s.Course) as Course, s.Scholarship, s.prevGPA, s.Semester, s.SY, st.SchoolName, st.SchoolAddress, st.letterHead from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.Status='Enrolled' and s.Scholarship='" & cboScholarship.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' order by s.YearLevel, p.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New ScholarsListing
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

    Private Sub frmScholarshipDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboScholarship.ResetText()
        getScholarship()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
   
    Public Sub getScholarship()
        Try
            str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "scholarships")

            cboScholarship.ValueMember = "scholarships"
            cboScholarship.DisplayMember = "Scholarship"
            cboScholarship.DataSource = ds.Tables("scholarships")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class