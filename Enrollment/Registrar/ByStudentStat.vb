Imports MySql.Data.MySqlClient
Public Class frmByStudentStat
    Dim str As String
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudeName, ss.YearLevel, ss.Course, ss.StudeStatus, ss.YearLevelStat, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.Status='Enrolled' and ss.StudeStatus='" & cboStudeStat.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude")
            Dim obj As New StudeStatReport
            obj.SetDataSource(ds.Tables("studeprofile, semesterstude"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class