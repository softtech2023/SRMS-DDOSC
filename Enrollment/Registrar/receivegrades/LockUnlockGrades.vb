Imports MySql.Data.MySqlClient
Public Class frmLockUnlockGrades
    Dim str As String
    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmselectGradeStat.ShowDialog()
    End Sub

    Public Sub buttonValue()
        If lblGradeStat.Text = "Open" Then
            tsReceive.Text = "Lock"
        Else
            tsReceive.Text = "Unlock"
        End If
    End Sub

    Private Sub lblGradeStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGradeStat.Click
        buttonValue()
    End Sub

    Private Sub tsReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReceive.Click
        If txtsubjectcode.Text = "" Then
            MsgBox("Please select subject to unlock/lock", MsgBoxStyle.Exclamation)
            txtsubjectcode.Focus()
            Exit Sub
        End If


        Try
            If tsReceive.Text = "Unlock" Then
                str = "update grades set sStatus='Open' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Grades successfully unlocked!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            Else
                str = "update grades set sStatus='Closed' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Grades successfully locked!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
        lblGradeStat.Text = ""
        tsReceive.Text = "Lock/Unlock Grades"

    End Sub

    Private Sub tsPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "SELECT g.StudentNumber, CONCAT(p.LastName, ', ', p.FirstName) AS StudeName, g.SubjectCode, g.Description, g.LecUnit, g.LabUnit, g.Instructor, g.Section, g.Final, g.Semester, g.SY, g.gradesID, st.SchoolName, st.SchoolAddress, st.registrar, st.registrarPosition FROM grades g INNER JOIN studeprofile p ON g.StudentNumber = p.StudentNumber join srms_settings st on g.settingsID=st.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' order by StudeName"
            'str = "SELECT g.StudentNumber, CONCAT(p.LastName, ', ', p.FirstName) AS StudeName, g.SubjectCode, g.Description, g.LecUnit, g.LabUnit, g.Instructor, g.Section, g.Final, g.Semester, g.SY, g.gradesID FROM grades g INNER JOIN studeprofile p ON g.StudentNumber = p.StudentNumber where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' order by StudeName"
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