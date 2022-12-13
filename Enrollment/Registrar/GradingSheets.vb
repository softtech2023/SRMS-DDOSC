Imports MySql.Data.MySqlClient
Public Class frmGradingSheets
    Dim str As String

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "SELECT g.StudentNumber, CONCAT(p.LastName, ', ', p.FirstName) AS StudeName, g.SubjectCode, g.Description, g.LecUnit, g.LabUnit, g.Instructor, g.Section, g.Final, g.Semester, g.SY, g.gradesID, st.SchoolName, st.SchoolAddress, st.registrar, st.registrarPosition, st.letterHead FROM grades g INNER JOIN studeprofile p ON g.StudentNumber = p.StudentNumber join srms_settings st on g.settingsID=st.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
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
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmselect_report_gradingsheet.ShowDialog()
    End Sub

    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) from staff where IDNumber='" & lblIDNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtsubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubjectcode.TextChanged
        getInstructor()
    End Sub

    Private Sub frmGradingSheets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class