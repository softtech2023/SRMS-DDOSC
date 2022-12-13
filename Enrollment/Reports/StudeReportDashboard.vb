Imports MySql.Data.MySqlClient
Public Class frmStudeReportDashboard
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try
            'COR
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, s.StudeStatus, r.Class, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, (ss.LecUnit+ss.LabUnit) as Unit, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, sf.Name from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' and s.Semester = '" & frmParent.lblSem.Text & "' and s.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New COR
                obj.SetDataSource(mysds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If
            'Statement of Account
            If cboStudeReport.SelectedIndex = 5 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.LecUnits, b.LecRate, b.LabUnits, b.LabRate, b.OldAccount, TotalLec, b.TotalLab, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, b.DiscPercentage, (Amount1+Amount2+Amount3+Amount4+Amount5) as AdditionalFees, b.RegFee, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' order by b.FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, studeaccount, paymentsaccounts")
                Dim obj As New SOA
                obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            'Statement of Account Version 2
            If cboStudeReport.SelectedIndex = 6 Then
                str = "select * from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeaccount")
                Dim obj As New DetailedAssessment
                obj.SetDataSource(mysds.Tables("studeaccount"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            'payment history
            If cboStudeReport.SelectedIndex = 3 Then
                str = "SELECT p.StudentNumber, concat(s.FirstName,' ',s.LastName) as sStudentName, s.PDate, s.ORNumber, s.Amount, s.description, s.Sem, s.SY FROM paymentsaccounts s join studeprofile p on p.StudentNumber=s.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and s.Sem='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts")
                Dim obj As New PaymentHistory
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            'Report of Grades
            If cboStudeReport.SelectedIndex = 4 Then
                str = "select (s.lecunit+s.labunit) as TotalUnits, g.SY, g.Semester, g.Term, p.StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as StudentName, p.BirthDate, p.BirthPlace, p.Address, p.GraduationDate, p.AdmissionDate, p.HighSchool, p.HSAddress, p.College, p.CAddress, p.Course, concat(g.Semester,', ',g.SY) as Semester, s.SubjectCode, s.Description, g.Final, g.Complied, ss.Course, ss.YearLevel from studeprofile p join grades g on g.StudentNumber=p.StudentNumber join semesterstude ss on ss.StudentNumber=g.StudentNumber join subjects s on s.SubjectCode=g.SubjectCode where p.StudentNumber='" & mskStudentNumber.Text & "' group by g.SY, g.Semester, g.SubjectCode"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "p.studeprofile, r.registration, g.grades, ss.semesterstude")
                Dim obj As New ReportofGrades
                obj.SetDataSource(mysds.Tables("p.studeprofile, r.registration, g.grades, ss.semesterstude"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If

            'Clearance
            If cboStudeReport.SelectedIndex = 2 Then
                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.Class, r.SubjectCode, r.Description, r.LecUnit, r.LabUnit, r.Section, ss.SchedTime, ss.LabTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, sf.Name from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmParent.lblSem.Text & "' and r.SY = '" & frmParent.lblSY.Text & "' and ss.Semester = '" & frmParent.lblSem.Text & "' and ss.SY = '" & frmParent.lblSY.Text & "' and s.Semester = '" & frmParent.lblSem.Text & "' and s.SY = '" & frmParent.lblSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New Clearance
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If
          

            'Admission History
            If cboStudeReport.SelectedIndex = 0 Then
                Str = "select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, s.Course, s.YearLevel, s.SY, s.Semester from studeprofile p join semesterstude s on p.StudentNumber=s.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, registration")
                Dim obj As New EnrollHistory
                obj.SetDataSource(ds.Tables("studeprofile, registration"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                conn.Close()
            End If
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class