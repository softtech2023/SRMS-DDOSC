Imports MySql.Data.MySqlClient
Public Class frmSearchGrades_old
    Dim str As String
    Private Sub SearchGrades_old_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select gradesid, StudentNumber, SubjectCode, Description, Final, Semester, SY, TakenAt from grades order by StudentNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dgGrades.DataSource = ds.Tables("grades")
            conn.Close()
            dgGrades.Columns(0).Visible = False
            dgGrades.Columns(3).Width = 200
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select gradesid, StudentNumber, SubjectCode, Description, Final, Semester, SY, TakenAt from grades where StudentNumber like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dgGrades.DataSource = ds.Tables("grades")
            conn.Close()
            dgGrades.Columns(0).Visible = False
            dgGrades.Columns(3).Width = 200
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgGrades_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrades.DoubleClick
        Dim i As Integer
        i = dgGrades.CurrentRow.Index
        frmGradesOld.lblID.Text = dgGrades.Item(0, i).Value
        frmGradesOld.txtStudentNumber.Text = dgGrades.Item(1, i).Value
        frmGradesOld.cboSubjectCode.Text = dgGrades.Item(2, i).Value
        frmGradesOld.cboDescription.Text = dgGrades.Item(3, i).Value
        frmGradesOld.txtFinalGrade.Text = dgGrades.Item(4, i).Value
        frmGradesOld.cboSem.Text = dgGrades.Item(5, i).Value
        frmGradesOld.txtSY.Text = dgGrades.Item(6, i).Value
        frmGradesOld.cboSchool.Text = dgGrades.Item(7, i).Value

        txtSearch.Clear()
        frmGradesOld.getStudeName()
        Me.Close()
        frmGradesOld.tsSave.Enabled = False
        frmGradesOld.tsUpdate.Enabled = True
        frmGradesOld.tsDelete.Enabled = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class