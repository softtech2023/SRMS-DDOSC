Imports MySql.Data.MySqlClient
Public Class frmSelectGMC
    Dim str As String
    Private Sub frmSelectGMC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdononGrad.Checked = True
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        If rdononGrad.Checked Then
            str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, p.pronoun3, ss.Course, ss.Major, ss.YearLevel, ss.Semester, ss.SY, st.letterHead, st.Registrar, st.registrarPosition, st.SchoolAddress, st.GuidanceCounselor, st.GuidancePosition, st.SchoolHead, st.sHeadPosition, st.footer from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.StudentNumber='" & frmCertification.mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New GMCNonGrad
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmCertification.specialReportViewer.ReportSource = obj
            frmCertification.specialReportViewer.Refresh()
            conn.Close()
            Me.Close()
        Else
            str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, p.pronoun3, ss.Course, ss.Major, ss.YearLevel, ss.Semester, ss.SY, st.letterHead, st.Registrar, st.registrarPosition, st.SchoolAddress, st.GuidanceCounselor, st.GuidancePosition, st.SchoolHead, st.sHeadPosition, st.footer from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber join srms_settings st on p.settingsID=st.settingsID where ss.StudentNumber='" & frmCertification.mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New GMCGrad
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            frmCertification.specialReportViewer.ReportSource = obj
            frmCertification.specialReportViewer.Refresh()
            conn.Close()
            Me.Close()
        End If

    End Sub
End Class