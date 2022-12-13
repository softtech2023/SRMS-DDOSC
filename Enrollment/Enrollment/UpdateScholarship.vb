Imports MySql.Data.MySqlClient
Public Class frmUpdateScholarship
    Dim str As String
    Public Sub getScholarship()
        Try
            Str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "scholarships")

            cboScholarship.ValueMember = "scholarships"
            cboScholarship.DisplayMember = "Scholarship"
            cboScholarship.DataSource = ds.Tables("scholarships")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmUpdateScholarship_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getScholarship()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update semesterstude set Scholarship='" & cboScholarship.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update profile
            str = "update studeprofile set scholarship='" & cboScholarship.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'Audit Trail
            str = "insert into atrail values('0','Updated student scholarship','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("Scholarship for the selected student has been updated!", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class