Imports MySql.Data.MySqlClient
Public Class frmCAV
    Dim str As String

    Public Sub getDetails()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "SELECT StudentNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StudentName, course, concat(admissionSem,', ',admissionSY) as admissionDate, graduationDate FROM studeprofile where StudentNumber='" & lblStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                txtStudentName.Text = dtReader(1)
                txtDegree.Text = dtReader(2)
                txtDateAttended.Text = dtReader(3)
                txtGraduationDate.Text = dtReader(4)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getYearLevel()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "SELECT YearLevel FROM semesterstude where StudentNumber='" & lblStudentNumber.Text & "' order by semstudentid desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                txtYearLevel.Text = dtReader(0)

            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getUnitsEarned()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "SELECT sum(LecUnit), sum(LabUnit) FROM grades where StudentNumber='" & lblStudentNumber.Text & "' and Final!='INC' and Final!=''"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblLec.Text = dtReader(0)
                lblLab.Text = dtReader(1)

                txtUnitsEarned.Text = Val(lblLec.Text) + Val(lblLab.Text)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "DELETE from stude_cav where StudentNumber='" & lblStudentNumber.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(Str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            str = "insert into stude_cav values(0,'" & txtSVNo.Text & "','" & txtSeries.Text & "','" & lblStudentNumber.Text & "','" & txtStudentName.Text & "','" & txtDegree.Text & "','" & txtDateAttended.Text & "','" & txtUnitsEarned.Text & "','" & txtYearLevel.Text & "','" & txtGraduationDate.Text & "','" & txtReviewedBy.Text & "','" & txtORNo.Text & "','" & txtAmountPaid.Text & "','" & dtpDateReleased.Text & "','" & dtpDatePaid.Text & "','1','" & txtProcessedBy.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'Print Verification
            str = "SELECT * FROM stude_cav s join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & lblStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "srms_settings, stude_cav")
            Dim obj As New CAVReport
            obj.SetDataSource(ds.Tables("srms_settings, stude_cav"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearchProfileForVerification.Show()
    End Sub

    Private Sub frmCAV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        btnPreview.Enabled = False
        txtSeries.Text = Date.Now.ToString("yyyy")

    End Sub
End Class