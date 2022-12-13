Imports MySql.Data.MySqlClient
Public Class frmStudeTOR
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If mskStudeNumber.Text = "" Then
                MsgBox("Please enter student number!", MsgBoxStyle.Exclamation)
                mskStudeNumber.Focus()
                Exit Sub
            End If

            If rdoOld.Checked = True Then
                str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, p.civilStatus, p.birthDate, p.BirthPlace, p.father, p.mother, concat(p.brgy,', ',p.city,', ',p.province) as address, p.lastSchool, p.lastSchoolDate, p.admissionDate, p.admissionSem, p.admissionSY, p.admissionBasis, p.lastAttended, p.graduationDate, p.honors, p.rotcSerial, p.cwtsSerial, p.ltsSerialNo, ss.Course, ss.Major, g.SubjectCode, g.Description, g.Final, g.Complied, (g.LecUnit+g.LabUnit) as Credits, concat(g.Semester,' - A.Y. ', g.SY,'  -  ',g.Course,'  -  ',st.branchCode) as Semester, st.SchoolName, st.SchoolAddress, st.website, st.emailad, st.registrar, st.registrarPosition, pi.profImage, st.registrarEmail, st.schoolLogo from studeprofile p join profimage pi on p.StudentNumber=pi.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudeNumber.Text & "' group by g.SY, g.Semester, SubjectCode, description order by g.SY, g.semSeq, g.SubjectCode"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, g.grades")
                Dim obj As New TOR2
                obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                obj.SetParameterValue("remarks", txtRemarks.Text)
                obj.SetParameterValue("clerk", txtPreparedBy.Text)
                obj.SetParameterValue("clerkPosition", txtPreparedByPosition.Text)
                obj.SetParameterValue("checked", txtChecked.Text)
                obj.SetParameterValue("checkPosition", txtCheckPosition.Text)
                obj.SetParameterValue("certified", txtCertified.Text)
                obj.SetParameterValue("certifiedPosition", txtCertifiedPosition.Text)
                obj.SetParameterValue("ORNumber", txtORNumber.Text)
                obj.SetParameterValue("datePaid", txtDatePaid.Text)
                obj.SetParameterValue("courseGroup", lblCouseGroup.Text)
                obj.SetParameterValue("dateIssued", txtDateIssued.Text)
                conn.Close()
                Me.Hide()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()

                mskStudeNumber.Clear()
                txtRemarks.Clear()
                Me.Close()

            ElseIf rdoTransferee.Checked = True Then
                str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, p.civilStatus, p.birthDate, p.BirthPlace, p.father, p.mother, concat(p.brgy,', ',p.city,', ',p.province) as address, p.lastSchool, p.lastSchoolDate, p.admissionDate, p.admissionSem, p.admissionSY, p.admissionBasis, p.lastAttended, p.graduationDate, p.honors, p.rotcSerial, p.cwtsSerial, p.ltsSerialNo, p.transfereeSchool, p.transfereeAddress, ss.Course, ss.Major, g.SubjectCode, g.Description, g.Final, g.Complied, (g.LecUnit+g.LabUnit) as Credits, concat(g.Semester,' - A.Y. ', g.SY,'  -  ',g.Course,'  -  ',st.branchCode) as Semester, st.SchoolName, st.SchoolAddress, st.website, st.emailad, st.registrar, st.registrarPosition, pi.profImage, st.registrarEmail, st.schoolLogo from studeprofile p join profimage pi on p.StudentNumber=pi.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudeNumber.Text & "' group by g.SY, g.Semester, SubjectCode, description order by g.SY, g.semSeq, g.SubjectCode"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, g.grades")
                Dim obj As New TOR_transferee
                obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                obj.SetParameterValue("remarks", txtRemarks.Text)
                obj.SetParameterValue("clerk", txtPreparedBy.Text)
                obj.SetParameterValue("clerkPosition", txtPreparedByPosition.Text)
                obj.SetParameterValue("checked", txtChecked.Text)
                obj.SetParameterValue("checkPosition", txtCheckPosition.Text)
                obj.SetParameterValue("certified", txtCertified.Text)
                obj.SetParameterValue("certifiedPosition", txtCertifiedPosition.Text)
                obj.SetParameterValue("ORNumber", txtORNumber.Text)
                obj.SetParameterValue("datePaid", txtDatePaid.Text)
                obj.SetParameterValue("courseGroup", lblCouseGroup.Text)
                obj.SetParameterValue("dateIssued", txtDateIssued.Text)
                conn.Close()
                Me.Hide()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()

                mskStudeNumber.Clear()
                txtRemarks.Clear()
                Me.Close()
            Else
                str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, p.civilStatus, p.birthDate, p.BirthPlace, p.father, p.mother, concat(p.brgy,', ',p.city,', ',p.province) as address, p.lastSchool, p.lastSchoolDate, p.admissionDate, p.admissionSem, p.admissionSY, p.admissionBasis, p.lastAttended, p.graduationDate, p.honors, p.rotcSerial, p.cwtsSerial, p.ltsSerialNo, ss.Course, ss.Major, g.SubjectCode, g.Description, g.Final, g.Complied, (g.LecUnit+g.LabUnit) as Credits, concat(g.Semester,' - A.Y. ', g.SY,'  -  ',g.Course,'  -  ',st.branchCode) as Semester, st.SchoolName, st.SchoolAddress, st.website, st.emailad, st.registrar, st.registrarPosition, pi.profImage, st.registrarEmail, st.schoolLogo from studeprofile p join profimage pi on p.StudentNumber=pi.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudeNumber.Text & "' group by g.SY, g.Semester, SubjectCode, description order by g.SY, g.semSeq, g.SubjectCode"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, g.grades")
                Dim obj As New TOR
                obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                obj.SetParameterValue("remarks", txtRemarks.Text)
                obj.SetParameterValue("clerk", txtPreparedBy.Text)
                obj.SetParameterValue("clerkPosition", txtPreparedByPosition.Text)
                obj.SetParameterValue("checked", txtChecked.Text)
                obj.SetParameterValue("checkPosition", txtCheckPosition.Text)
                obj.SetParameterValue("certified", txtCertified.Text)
                obj.SetParameterValue("certifiedPosition", txtCertifiedPosition.Text)
                obj.SetParameterValue("ORNumber", txtORNumber.Text)
                obj.SetParameterValue("datePaid", txtDatePaid.Text)
                obj.SetParameterValue("courseGroup", lblCouseGroup.Text)
                obj.SetParameterValue("dateIssued", txtDateIssued.Text)
                conn.Close()
                Me.Hide()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()

                mskStudeNumber.Clear()
                txtRemarks.Clear()
                Me.Close()
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        mskStudeNumber.Clear()
        Me.Close()
    End Sub

    Private Sub mskStudeNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudeNumber.Click
        frmQSearch.ShowDialog()
    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtChecked.Text = dtReader(5)
                txtCheckPosition.Text = dtReader(6)
                txtPreparedBy.Text = dtReader(7)
                txtPreparedByPosition.Text = dtReader(8)
                txtCertified.Text = "MERLA D. GETUBIG"
                txtCertifiedPosition.Text = "Registrar I"
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmStudeTOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
        rdoNew.Checked = True
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmQSearch.ShowDialog()
    End Sub
    Public Sub getCourseGroup()
        Try
            'str = "select * from course_table where CourseDescription='" & lblCourse.Text & "' group by courseGroup"
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from course_table where CourseDescription='" & lblCourse.Text & "' group by courseGroup"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                'txtChecked.Text = dtReader(5)
                lblCouseGroup.Text = dtReader(5)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub lblCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCourse.Click
        getCourseGroup()
    End Sub
End Class