Imports MySql.Data.MySqlClient
Public Class frmStudeReport_Accounting
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try

            'Account Tracking
            If cboStudeReport.SelectedIndex = 0 Then
                'str = "select a.StudentNumber, concat(a.FirstName,' ',a.LastName) as StudentName, a.Course, YearLevel, a.AcctTotal, a.TotalPayments, a.CurrentBalance, concat(a.Sem,', ',a.SY) as Semester, concat(p.Sem,', ',p.SY) as SemPayment, p.PDate, p.ORNumber, p.Amount, p.description from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and p.CollectionSource!='Services' and ORStatus='Valid' group by Semester order by a.SY, a.Sem"
                str = "select a.StudentNumber, concat(a.FirstName,' ',a.LastName) as StudentName, a.Course, YearLevel, a.AcctTotal, a.TotalPayments, a.CurrentBalance, concat(a.Sem,', ',a.SY) as Semester, p.PDate, p.ORNumber, p.Amount, p.description, st.SchoolName, st.SchoolAddress, st.letterHead from studeaccount a join paymentsaccounts p on a.StudentNumber=p.StudentNumber join srms_settings st on a.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and p.CollectionSource!='Services' and ORStatus='Valid' group by Semester order by a.SY, a.Sem"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "paymentsaccounts, studeaccount")
                Dim obj As New AcctTracking
                obj.SetDataSource(ds.Tables("paymentsaccounts, studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'payment history
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select s.StudentNumber, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as StudentName, s.AcctTotal, s.Discount, s.CurrentBalance, s.Sem, s.SY, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.ORStatus, pa.Sem, pa.SY, st.SchoolName, st.SchoolAddress from studeaccount s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and s.Sem='" & frmParent.lblSem.Text & "' and s.SY='" & frmParent.lblSY.Text & "' and pa.Sem='" & frmParent.lblSem.Text & "' and pa.SY='" & frmParent.lblSY.Text & "' and pa.ORStatus='Valid' and pa.CollectionSource!='Services' group by pa.ORNumber"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts")
                Dim obj As New PaymentHistory
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If


            'Statement of Account
            If cboStudeReport.SelectedIndex = 2 Then
                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.OldAccount, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, (Amount1+Amount2+Amount3+Amount4+Amount5) as AdditionalFees, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' order by b.FeesDesc"
                str = "SELECT StudentNumber, TotalLec, TotalLab, lecNight, labNight, feesDesc, FeesAmount, feesType, AcctTotal, specialTuition, Sem, SY  FROM studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeaccount")
                Dim obj As New SOA
                obj.SetDataSource(mysds.Tables("studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Statement of Account 2
            If cboStudeReport.SelectedIndex = 3 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, p.Sex, a.Course, a.YearLevel, a.TotalLec, a.FeesDesc, a.FeesAmount, a.feesType, a.AcctTotal, a.tuitionDay, a.specialTuition, a.Sem, a.SY, st.SchoolName, st.SchoolAddress, st.cashier, st.cashierPosition from studeprofile p join studeaccount a on p.StudentNumber=a.StudentNumber join srms_settings st on a.settingsID=st.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and a.Sem='" & frmParent.lblSem.Text & "' and a.SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, studeaccount, srms_settings")
                Dim obj As New SOA2
                obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, srms_settings"))
                obj.SetParameterValue("name", frmParent.lblName.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmQSearch.ShowDialog()
    End Sub

    
End Class