Imports MySql.Data.MySqlClient
Public Class frmStudeAccount
    Dim str As String
    
    Private Sub frmStudeAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourse()
        cboCourseAccount.ResetText()
        cboYearLevelAccount.ResetText()
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourseAccount.ValueMember = "course_table"
            cboCourseAccount.DisplayMember = "CourseDescription"
            'cboCourseCode.DisplayMember = "CourseCode"
            cboCourseAccount.DataSource = ds.Tables("course_table")
            conn.Close()
            conn.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
            conn.Close()
        End Try
    End Sub
    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVersion1.Click
        Try

            If cboCourseAccount.Text = "" And cboYearLevelAccount.Text = "" Then
                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts_All
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()

            Else

                'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where b.Course='" & cboCourseAccount.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Sem, b.SY, st.SchoolName, st.SchoolAddress, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on b.settingsID=st.settingsID where b.Course='" & cboCourseAccount.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmParent.lblSem.Text & "' and b.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnVersion2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVersion2.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, p.Sex, a.Course, a.YearLevel, a.TotalLec, a.FeesDesc, a.FeesAmount, a.feesType, a.Sem, a.SY, st.SchoolName, st.SchoolAddress, st.cashier, st.cashierPosition, st.letterHead from studeprofile p join studeaccount a on p.StudentNumber=a.StudentNumber join srms_settings st on a.settingsID=st.settingsID where a.Course='" & cboCourseAccount.Text & "' and a.YearLevel='" & cboYearLevelAccount.Text & "' and a.Sem='" & frmParent.lblSem.Text & "' and a.SY='" & frmParent.lblSY.Text & "' group by p.StudentNumber, a.FeesDesc"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, studeaccount, srms_settings")
            'Dim obj As New paymentsReports
            Dim obj As New AccountingSummary
            obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, srms_settings"))
            obj.SetParameterValue("name", frmParent.lblName.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class