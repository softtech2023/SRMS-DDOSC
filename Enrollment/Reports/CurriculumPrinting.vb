Imports MySql.Data.MySqlClient
Public Class frmCurriculumPrinting
    Dim str As String
    Private Sub frmCurriculumPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'str = "Select subjectid, SubjectCode, description, lecunit, labunit, prereq, YearLevel, Semester, Course, SemEffective, SYEffective, Effectivity from subjects where Course='" & cboCourse.Text & "'"
            str = "Select * FROM subjects where Course='" & cboCourse.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "subjects")
            Dim obj As New CurrPrint
            obj.SetDataSource(mysds.Tables("subjects"))
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