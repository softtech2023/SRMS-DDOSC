Imports MySql.Data.MySqlClient
Public Class frmGraduatingStudes
    Dim str As String
    Public Sub getDuration()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "Select * from course_table where CourseDescription='" & cboCourse.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblDuration.Text = dtReader.Item(3)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub


    Private Sub frmGraduatingStudes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getDuration()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'str = "SELECT g.StudentNumber, CONCAT(p.LastName, ', ', p.FirstName) AS StudeName, g.SubjectCode, g.Description, g.LecUnit, g.LabUnit, g.Instructor, g.Section, g.PGrade, g.MGrade, g.FGrade, g.Average, g.Eqv, g.Remarks, g.Sem, g.SY, g.gradeID FROM grades g INNER JOIN studeprofile p ON g.StudentNumber = p.StudentNumber where g.SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and g.Sem='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, grades")
            Dim obj As New GradingSheet
            obj.SetDataSource(mysds.Tables("studeprofile, grades"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class