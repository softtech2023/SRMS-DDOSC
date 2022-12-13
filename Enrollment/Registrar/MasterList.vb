Imports MySql.Data.MySqlClient
Public Class frmMasterList
    Dim str As String
    Private Sub btnMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, p.Sex, p.email, p.contactNo, ss.Course, ss.Major, ss.YearLevel, r.Section, r.Term, r.SubjectCode, r.Description, concat(r.SchedTime,' ',r.LabTime) as Schedule, r.Instructor, r.Sem, r.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on p.settingsID=st.SettingsID where r.SubjectCode='" & txtsubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SchedTime='" & txtTime.Text & "' and r.Instructor='" & txtInstructor.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber ORDER by StudentName"
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, p.Sex, p.email, p.contactNo, p.Course, ss.Major, ss.YearLevel, r.Section, r.Term, r.SubjectCode, r.Description, concat(r.SchedTime,' ',r.LabTime) as Schedule, r.Instructor, r.Sem, r.SY, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on p.settingsID=st.SettingsID where r.SubjectCode='" & txtsubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SchedTime='" & txtTime.Text & "' and r.Instructor='" & txtInstructor.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber ORDER by StudentName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "semsubjects, registration, staff")
            Dim obj As New Class_List
            obj.SetDataSource(mysds.Tables("semsubjects, registration, staff"))
            frmMainViewer.ReportViewer.ReportSource = obj
            obj.SetParameterValue("name", frmParent.lblName.Text)
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub

    Private Sub txtsubjectcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubjectcode.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub

End Class