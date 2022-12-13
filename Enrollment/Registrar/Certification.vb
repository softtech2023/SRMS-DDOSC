Imports MySql.Data.MySqlClient
Public Class frmCertification
    Dim str As String

    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try
            'Admission History
            If cboStudeReport.SelectedIndex = 0 Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, s.Course, s.YearLevel, s.SY, s.Semester, st.letterHead from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, registration")
                Dim obj As New EnrollHistory
                obj.SetDataSource(ds.Tables("studeprofile, registration"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'CERT OF ENROLLMENT
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join semsubjects ss on ss.Instructor=r.Instructor join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New COR
                obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'COR
            If cboStudeReport.SelectedIndex = 2 Then
                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, st.scholarshipCoordinator, st.letterHead, st.SchoolHead, st.sHeadPosition from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join semsubjects ss on ss.Instructor=r.Instructor join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' order by r.SubjectCode"
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, st.scholarshipCoordinator, st.letterHead, st.SchoolHead, st.sHeadPosition, st.clerk, st.clerkPosition from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, studeprofile, srms_settings")
                Dim obj As New COR1
                obj.SetDataSource(mysds.Tables("registration, studeprofile, srms_settings"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                obj.SetParameterValue("yearLevelStat", lblYearLevelStat.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'COR2
            'If cboStudeReport.SelectedIndex = 3 Then
            'Dim str1 As String
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, p.Birthdate, p.Sex, r.Sem, r.SY, r.Course, r.Major, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.LecUnit, r.LabUnit, (r.LecUnit+r.LabUnit) as Units, r.LabTime, r.SchedTime, r.Room, r.Instructor, r.schedType, r.Term, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.cashier, st.cashierPosition, st.scholarshipCoordinator, st.letterHead, st.SchoolHead, st.sHeadPosition from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join semsubjects ss on ss.Instructor=r.Instructor join srms_settings st on r.settingsID=st.settingsID where p.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
            'str1 = "SELECT StudentNumber, TotalLec, TotalLab, lecNight, labNight, FeesDesc, FeesAmount, feesType, AcctTotal, Sem, SY, specialTuition, AccountID, tuitionDay FROM studeaccount where StudentNumber = '" & mskStudentNumber.Text & "' and Sem = '" & frmParent.lblSem.Text & "' and SY = '" & frmParent.lblSY.Text & "'"
            'conn.Open()

            'Dim mysDa As New MySqlDataAdapter(str, conn)
            'Dim mysds As New DataSet

            'Dim mysDa1 As New MySqlDataAdapter(str1, conn)
            'Dim mysdsb As New DataSet

            'mysDa.Fill(mysds, "registration, studeprofile, srms_settings")
            'mysDa1.Fill(mysdsb, "studeaccount")

            'Dim obj As New COR2
            'obj.SetDataSource(mysds.Tables("registration, studeprofile, srms_settings"))
            'obj.Subreports.Item("SOASubRep.rpt").SetDataSource(mysdsb.Tables("studeaccount"))
            'obj.SetParameterValue("name", frmParent.lblName.Text)
            'obj.SetParameterValue("Scholarship", lblScholarship.Text)
            'obj.SetParameterValue("AmountGranted", lblamountgranted.Text)
            'obj.SetParameterValue("Status", lblstatus.Text)
            'obj.SetParameterValue("TuitionFee", lblTuitionFee.Text)
            'obj.SetParameterValue("TotalLabFee", lblLabFee.Text)
            'obj.SetParameterValue("MiscFee", lblMiscFee.Text)
            'obj.SetParameterValue("TotalAssessment", lbltotalassessment.Text)
            'obj.SetParameterValue("DownPayment", lblDp.Text)
            'obj.SetParameterValue("Balance", lblBalance.Text)
            'obj.SetParameterValue("LastAmountPaid", lblLastAmountPaid.Text)
            'obj.SetParameterValue("LastTransactionDate", lblTransDate.Text)
            'obj.SetParameterValue("SchedPay", lblSchedPay.Text)
            'specialReportViewer.ReportSource = obj
            'specialReportViewer.Refresh()
            'conn.Close()

            'End If

            'Cert. of Good Moral Character
            If cboStudeReport.SelectedIndex = 3 Then
                'str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, ss.Course, ss.YearLevel, ss.Semester, ss.SY from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
                str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, p.pronoun3, ss.Course, ss.Major, ss.YearLevel, ss.Semester, ss.SY, st.letterHead, st.Registrar, st.registrarPosition, st.SchoolAddress, st.SchoolHead, st.sHeadPosition from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.StudentNumber='" & mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New GoodMoral
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Clearance
            If cboStudeReport.SelectedIndex = 4 Then
                Dim myValue As String = InputBox("Enter Purpose", "Enter Purpose", "Please Enter Purpose")

                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, concat(sf.FirstName,' ',sf.LastName) as Instructor, st.SchoolName, st.schoolAddress, st.letterHead from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings st on p.settingsID=st.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' and s.Semester = '" & frmParent.lblSem.Text & "' and s.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New Clearance
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                obj.SetParameterValue("purpose", myValue)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'Report of Grades
            If cboStudeReport.SelectedIndex = 5 Then
                'str = "select (g.Lecunit+g.LabUnit) as TotalUnits, g.SY, g.Semester, g.Section, concat(g.Semester,', ',g.SY) as Semester, ss.StudentNumber, concat(ss.FName,' ',ss.MName,' ',ss.LName) as StudentName, ss.Course, ss.Major, g.SubjectCode, g.Description, g.Final, g.Complied, (g.Final*(g.LecUnit+g.LabUnit)) as gradesPoint, ss.YearLevel, st.SchoolHead, st.sHeadPosition, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead from semesterstude ss join grades g on g.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.StudentNumber='" & mskStudentNumber.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' group by g.SubjectCode, g.description, g.Semester, g.SY"
                str = "select (g.Lecunit+g.LabUnit) as TotalUnits, g.SY, g.Semester, concat(g.Semester,', ',g.SY) as Semester, ss.StudentNumber, concat(ss.FName,' ',ss.MName,' ',ss.LName) as StudentName, ss.Course, ss.Major, g.SubjectCode, g.Description, g.Final, g.Complied, (g.Final*(g.LecUnit+g.LabUnit)) as gradesPoint, ss.YearLevel, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.administrative, st.administrativePosition, st.letterHead from semesterstude ss join grades g on g.StudentNumber=ss.StudentNumber join srms_settings st on ss.settingsID=st.settingsID where ss.StudentNumber='" & mskStudentNumber.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' and ss.SY='" & frmParent.lblSY.Text & "' and ss.Semester='" & frmParent.lblSem.Text & "' group by g.SubjectCode, g.Semester, g.SY"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, g.grades")
                Dim obj As New ReportofGrades
                obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                frmMainViewer.ReportViewer.ReportSource = obj
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Honorable Dismissal
            If cboStudeReport.SelectedIndex = 6 Then
                'str = "select p.StudentNumber, p.Title, p.Pronoun, p.Pronoun2, p.Pronoun3, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudeName, s.Course, s.YearLevel, s.Semester, s.SY, s.YearLevel, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on p.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' order by s.semstudentid desc limit 1"
                str = "select p.StudentNumber, p.Title, p.Pronoun, p.Pronoun2, p.Pronoun3, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudeName, s.Course, s.YearLevel, s.Semester, s.SY, s.YearLevel, s.Major, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead, st.SchoolHead, st.sHeadPosition from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber join srms_settings st on p.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' order by s.semstudentid desc limit 1"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, s.semesterstude")
                'Dim obj As New HonDismissalVer2
                Dim obj As New HonDismissal
                obj.SetDataSource(mysds.Tables("p.studeprofile, s.semesterstude"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If


            'Request for Form 137
            If cboStudeReport.SelectedIndex = 7 Then
                Dim myValue As String = InputBox("Section", "Section", "Please enter section!")

                str = "select p.FirstName, p.MiddleName, p.LastName, p.secondary, p.secondaryAddress, p.secondaryGraduated, p.pronoun, p.pronoun3, st.SchoolName, st.SchoolAddress, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, srms_settings")
                Dim obj As New Form137_request
                obj.SetDataSource(mysds.Tables("studeprofile, srms_settings"))
                obj.SetParameterValue("section", myValue)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Permit
            If cboStudeReport.SelectedIndex = 8 Then
                Dim myValue As String = InputBox("", "Period", "Please enter examination period.")

                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, concat(sf.FirstName,' ',sf.LastName) as Instructor, st.SchoolName, st.schoolAddress, st.letterHead, st.registrar, st.registrarPosition from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings st on p.settingsID=st.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' and s.Semester = '" & frmParent.lblSem.Text & "' and s.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New ExamPermit
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                obj.SetParameterValue("permitPeriod", myValue)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If
            'Permanent Record
            If cboStudeReport.SelectedIndex = 9 Then
                str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.BirthDate, p.BirthPlace, p.lastschool, p.admissionSem, p.admissionSY, p.Sex, concat(p.Brgy,', ',p.City,', ',p.Province) as Address, p.AdmissionDate, p.Course, concat(g.Semester,', ',g.SY) as Semester, g.SubjectCode, g.Description, (g.LecUnit+g.LabUnit) as Units, g.Complied, g.Final, st.SchoolName, st.SchoolAddress, st.SchoolHead, st.sHeadPosition, st.Registrar, st.registrarPosition, st.letterHead from studeprofile p join grades g on g.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' order by g.SY, g.Semester, g.SubjectCode"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, g.grades")
                Dim obj As New Permanent_Record
                obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades"))
                obj.SetParameterValue("preparedBy", frmParent.lblName.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Student's Profile
            If cboStudeReport.SelectedIndex = 10 Then
                str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile")
                Dim obj As New StudeProfile
                obj.SetDataSource(mysds.Tables("studeprofile"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If


            'Graduates Certification
            If cboStudeReport.SelectedIndex = 11 Then
                str = "SELECT p.FirstName, p.MiddleName, p.LastName, a.course, a.major, a.semgraduated, a.sygraduated, a.dategraduated, a.gpa, st.schoolName, st.branch, st.schoolAddress, st.letterHead FROM studeprofile p join alum_reg a on p.StudentNumber=a.StudentNumber join srms_settings st on a.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, alum_reg")
                Dim obj As New gradCertification
                obj.SetDataSource(mysds.Tables("studeprofile, alum_reg"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmQSearch.ShowDialog()
    End Sub

    Public Sub getStudeName()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as StudeName from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtName.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getScholar()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select Scholarship from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblScholarship.Text = dtReader(0)
                
            End If
            If lblScholarship.Text = "" Then
                lblScholarship.Text = "N/A"
            End If
            If lblScholarship.Text = "N/A" Then
                lblamountgranted.Text = "N/A"
            Else
                lblamountgranted.Text = "100%"
            End If

            If lblamountgranted.Text = "N/A" Then
                lblstatus.Text = "N/A"
            Else
                lblstatus.Text = "AVAILED"
            End If

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCertification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblScholarship.Text = ""
        lblamountgranted.Text = ""
        lblstatus.Text = ""
        lblTuitionFee.Text = 0
        lblLabFee.Text = 0
        lblMiscFee.Text = 0
        lbltotalassessment.Text = 0
        lblDp.Text = 0
        lblBalance.Text = 0
        lblLastAmountPaid.Text = 0
        lblTransDate.Text = frmParent.dtpDate.Text
        lblSchedPay.Text = 0
    End Sub

    Private Sub lblScholarship_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScholarship.Click
       
    End Sub

    Private Sub mskStudentNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        getScholar()
        getPaymentInformation()
        getPRevPay()
        getSchedulePayment()
    End Sub
    Public Sub getPaymentInformation()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select tuitionDay, labDay, (select sum(FeesAmount) as MiscFee from studeaccount where feesType='Miscellaneous' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'), AcctTotal, TotalPayments, CurrentBalance from studeaccount where SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblTuitionFee.Text = dtReader(0)
                lblLabFee.Text = dtReader(1)
                lblMiscFee.Text = dtReader(2)
                lbltotalassessment.Text = dtReader(3)
                lblDp.Text = dtReader(4)
                lblBalance.Text = dtReader(5)


            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getPRevPay()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT PDate, Amount FROM paymentsaccounts where SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' and StudentNumber='" & mskStudentNumber.Text & "' order by ID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblTransDate.Text = dtReader(0)
                lblLastAmountPaid.Text = dtReader(1)
                


            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getSchedulePayment()
        Dim Dist As Double
        Dist = Val(lbltotalassessment.Text) / 8
        lblSchedPay.Text = Dist
    End Sub

    Public Sub yearLevelStat()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblYearLevelStat.Text = dtReader(20)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStudentNumber.MaskInputRejected
        yearLevelStat()
    End Sub
End Class