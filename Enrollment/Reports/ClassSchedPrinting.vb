Imports MySql.Data.MySqlClient
Public Class frmClassSchedPrinting
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "select * from semsubjects where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            Dim obj As New Schedules
            obj.SetDataSource(ds.Tables("semsubjects"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmClassSchedPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reports2.sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.Reports2.sections)
        'TODO: This line of code loads data into the 'DataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.DataSet.courses)

    End Sub
End Class