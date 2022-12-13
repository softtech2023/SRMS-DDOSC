Imports MySql.Data.MySqlClient
Public Class frmReceiveGradeSheets
    Dim str As String
    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectGS.Show()
    End Sub

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub FormLoad()
        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        txtInstructor.Clear()
        cboPeriod.ResetText()
        dtpDate.Text = Today

        tsReceive.Enabled = False
        tsPreview.Enabled = False
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
   
    Private Sub frmReceiveGradeSheets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReceive.Click
        Try
            If txtsubjectcode.Text = "" Then
                MsgBox("Required fields must be filled up properly!", MsgBoxStyle.Exclamation)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "insert into gsreceiver values (0,'" & txtsubjectcode.Text & "','" & txtDescription.Text & "','" & txtSection.Text & "','" & txtInstructor.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblUser.Text & "','" & cboPeriod.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "update grades set sStatus='Closed' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Grading Sheet accepted!", MsgBoxStyle.Information)

            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "SELECT g.StudentNumber, CONCAT(p.LastName, ', ', p.FirstName) AS StudeName, g.SubjectCode, g.Description, g.LecUnit, g.LabUnit, g.Instructor, g.Section, g.Final, g.Semester, g.SY, g.gradesID, st.SchoolName, st.SchoolAddress, st.registrar, st.registrarPosition FROM grades g INNER JOIN studeprofile p ON g.StudentNumber = p.StudentNumber join srms_settings st on g.settingsID=st.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' order by StudeName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, grades")
            Dim obj As New GradingSheet
            obj.SetDataSource(mysds.Tables("studeprofile, grades"))
            CrystalReportViewer1.ReportSource = obj
            CrystalReportViewer1.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class