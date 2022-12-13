Imports MySql.Data.MySqlClient
Public Class frmAdding
    Dim str As String
    Dim str2 As String
    Dim str3 As String

    Private Sub btnAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        frmSelectStudetoAdd.ShowDialog()
    End Sub

    Public Sub FormLoad()
        Try
            lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 100)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Lec Time", 90)
            Me.lvCOR.Columns.Add("Lab Time", 90)
            Me.lvCOR.Columns.Add("Room", 90)
            Me.lvCOR.Columns.Add("Section", 70)
            Me.lvCOR.Columns.Add("Lec Unit", 80)
            Me.lvCOR.Columns.Add("Lab Unit", 80)
            Me.lvCOR.Columns.Add("Instructor", 0)
            Me.lvCOR.Columns.Add("Sched Type", 0)
            Me.lvCOR.Columns.Add("Slot", 0)
            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True

            mskStudentNumber.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            lblYearLevel.Text = "Year Level"
            txtTotalLecUnits.Clear()
            txtTotalLab.Clear()
            txtTotalUnits.Clear()
            lblNewTotalUnits.Text = 0
            lblTotalUnits.Text = 0


            btnAddSubject.Enabled = False
            btnRemoveSubjects.Enabled = False

            tsSave.Enabled = False
            schoolInfo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAdding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmSelectSubtoAdd.ShowDialog()
    End Sub
    Public Sub getTotalLecUnits()
        Dim LecUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LecUnits += Val(lvCOR.Items(x).SubItems(6).Text)
        Next
        txtTotalLecUnits.Text = Format(LecUnits, "0.00")
    End Sub
    Public Sub getTotalLabUnits()
        Dim LabUnits As Double
        For x As Integer = 0 To lvCOR.Items.Count - 1
            LabUnits += Val(lvCOR.Items(x).SubItems(7).Text)
        Next
        txtTotalLab.Text = Format(LabUnits, "0.00")
    End Sub
    Public Sub TotalUnits()
        Dim totalUnits As Double
        totalUnits = Val(txtTotalLecUnits.Text) + Val(txtTotalLab.Text) + Val(lblOldTotalUnits.Text)
        txtTotalUnits.Text = Format(totalUnits, "0.00")
    End Sub
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            'check if subject exist
            str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and SubjectCode='" & lblSubjectCode.Text & "' and Description='" & lblDescription.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            conn.Close()
            If ds.Tables("registration").Rows.Count = 1 Then
                MsgBox("The selected subject has been enrolled already by this student!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If

            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration values('0','" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & lvCOR.Items(i).SubItems(7).Text & "','" & lvCOR.Items(i).SubItems(5).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(8).Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & mskStudentNumber.Text & "','" & frmParent.lblTerm.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtCourse.Text & "','" & lblYearLevel.Text & "','" & txtMajor.Text & "','" & lblSettingsID.Text & "','" & lvCOR.Items(i).SubItems(9).Text & "','" & lblNewTotalUnits.Text & "','" & lblFinalSpecialLab.Text & "','" & txtCourseCode.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()


                'update slots
                str = "update semsubjects set Slot='" & lvCOR.Items(i).SubItems(10).Text & "' where SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "' and Section='" & lvCOR.Items(i).SubItems(5).Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                str = "update registration set totalUnits='" & lblNewTotalUnits.Text & "',labfee='" & lblFinalSpecialLab.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()

            Next

            'Audit Trail
            str = "insert into atrail values('0','Added subject/s to student','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()


            If (MsgBox("Registration has been processed successfully! Do you want to print the Cert. of Enrollment?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                'str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.Sex, p.BirthPlace, p.BirthDate, s.Course, s.Major, s.StudeStatus, s.YearLevel, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, sum(r.LecUnit+r.LabUnit) as totalUnits, r.Section, ss.LabTime, ss.SchedTime, ss.Room, ss.SchedType, r.Sem, r.SY, r.Term, concat(sf.LastName,', ',sf.FirstName) as Instructor, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                'str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, scholarshipCoordinator from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join semsubjects ss on ss.Instructor=r.Instructor join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, st.scholarshipCoordinator, st.clerk, st.clerkPosition, st.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' order by r.SubjectCode"
                conn.Open()
                Dim mysda2 As New MySqlDataAdapter(str, conn)
                Dim ds2 As New DataSet
                mysda2.Fill(ds2, "registration, studeprofile, srms_settings")
                Dim obj As New COR1
                obj.SetDataSource(ds2.Tables("registration, studeprofile, srms_settings"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                obj.SetParameterValue("yearLevelStat", lblYearLevelStat.Text)
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            lvCOR.Items.Clear()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnRemoveSubjects_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
        Try
            Dim i As Integer

            lvCOR.Select()

            If lvCOR.Items.Count = 0 Then
                MsgBox("Cannot find subject(s) to remove", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            Else
                i = lvCOR.FocusedItem.Index
                lvCOR.Items.RemoveAt(i)
            End If

            getTotalLecUnits()
            getTotalLabUnits()
            TotalUnits()
            newTotalUnits()
            getTotalLabUnits()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub newTotalUnits()
        Dim i As Double
        i = Val(txtTotalUnits.Text) + Val(lblTotalUnits.Text)
        lblNewTotalUnits.Text = i
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
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getRemainSlot()
        Try
            Dim remainSlot As Integer

            str = "select * from semsubjects where SubjectCode='" & lvCOR.Items(0).Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
            conn.Open()

            Dim mysda As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysda.ExecuteReader

            While mysDR.Read
                remainSlot = Val(mysDR(9)) - 1
            End While
            lblSlot.Text = remainSlot
            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getFinalSlot()
        Dim finalslot As Integer
        finalslot = lblSlot.Text - 1
        lblFinalSlot.Text = finalslot
    End Sub

    Public Sub getTotalUnits()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select totalUnits, labfee from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblOldTotalUnits.Text = dtReader(0)
                lblCurrentSpecialLal.Text = dtReader(1)
            End If
            conn.Close()

            Dim finalSpecialLab As Double
            finalSpecialLab = Val(lblCurrentSpecialLal.Text) + Val(lblLabFee.Text)
            lblFinalSpecialLab.Text = finalSpecialLab

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalLab()
        Try

            Dim totalLab As Double
            For i As Integer = 0 To lvCOR.Items.Count - 1
                'get total lab fee
                str = "select * from subjects where SubjectCode='" & lvCOR.Items(i).SubItems(0).Text & "' and Description='" & lvCOR.Items(i).SubItems(1).Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                Dim mysDR As MySqlDataReader = mysC.ExecuteReader

                While mysDR.Read
                    totalLab += Val(mysDR(14))
                End While
                lblLabFee.Text = totalLab
                conn.Close()

                Dim finalSpecialLab As Double
                finalSpecialLab = Val(lblCurrentSpecialLal.Text) + Val(lblLabFee.Text)
                lblFinalSpecialLab.Text = finalSpecialLab

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourseShortName()
        Try
            'str = "select * from course_table where CourseDescription='" & lblCourse.Text & "' group by courseGroup"
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from course_table where CourseDescription='" & txtCourse.Text & "' and Major='" & txtMajor.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                'txtChecked.Text = dtReader(5)
                txtCourseCode.Text = dtReader(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class