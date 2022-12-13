Imports MySql.Data.MySqlClient
Public Class frmLoading
    Dim str As String

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, (s.LecUnit + s.LabUnit) as Units, s.SY, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings st on s.settingsID=st.settingsID where i.IDNumber='" & lblInstructorID.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, (s.LecUnit + s.LabUnit) as Units, s.SY, s.Semester, s.Course, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead, st.Registrar, st.registrarPosition from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings st on s.settingsID=st.settingsID where i.IDNumber='" & lblInstructorID.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSelectInstructor.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'str = "select s.SubjectCode, s.Description, s.SchedTime, s.LabTime, s.Room, (s.LecUnit + s.LabUnit) as Units, s.SY, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.letterHead from semsubjects s join staff i on s.IDNumber=i.IDNumber join srms_settings st on s.settingsID=st.settingsID where i.IDNumber='" & lblInstructorID.Text & "' and s.Semester='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            str = "SELECT r.Subjectcode, r.Description, (LecUnit+LabUnit), Section, count(StudentNumber) as EnrolledCounts, r.Sem, r.SY, r.Instructor, st.Registrar, st.registrarPosition, st.letterHead FROM registration r join srms_settings st on r.settingsID=st.settingsID where r.Instructor='" & cboInstructor.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' group by r.Section, r.SubjectCode, r.Description order by r.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration, srms_settings")
            Dim obj As New WorkLoad2
            obj.SetDataSource(ds.Tables("registration, srms_settings"))
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