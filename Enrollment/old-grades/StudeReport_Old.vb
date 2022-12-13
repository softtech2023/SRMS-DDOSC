Imports MySql.Data.MySqlClient
Public Class frmStudeReport_Old
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        Try
            str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudeName, p.Course, g.SubjectCode, g.Description, (g.LecUnit+g.LabUnit) as Units, g.FinalGrade, concat(g.Sem,', ',g.SY) as Semester from studeprofile p join grades_old g on p.StudentNumber=g.StudentNumber where p.StudentNumber='" & txtStudentNumber.Text & "' order by Semester"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, grades_old")
            Dim obj As New GradingSheet_Old
            obj.SetDataSource(mysds.Tables("studeprofile, grades_old"))
            specialReportViewer.ReportSource = obj
            specialReportViewer.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

End Class