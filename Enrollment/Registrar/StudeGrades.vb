Imports MySql.Data.MySqlClient
Public Class frmStudeGrades
    Dim str As String
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSelectStudeDrop.ShowDialog()
    End Sub
    Public Sub getGrades()
        Try
            str = "select gradesid, SubjectCode, Description, Section, Final, Complied, Semester, SY from grades where StudentNumber='" & txtStudentNo.Text & "' and Semester='" & cboSemester.Text & "' and SY='" & txtSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            dgSubjects.DataSource = ds.Tables("grades")
            conn.Close()

            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).HeaderText = "Subject Code"
            dgSubjects.Columns(1).Width = 90
            dgSubjects.Columns(2).HeaderText = "Description"
            dgSubjects.Columns(2).Width = 300
            dgSubjects.Columns(3).Width = 110
            dgSubjects.Columns(4).HeaderText = "Grades"
            dgSubjects.Columns(4).ReadOnly = False
            dgSubjects.Columns(5).ReadOnly = False
            dgSubjects.Columns(6).ReadOnly = False
            dgSubjects.Columns(7).ReadOnly = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtStudentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNo.TextChanged
        getGrades()
    End Sub

    Private Sub frmStudeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
        schoolInfo()
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index

        lblGradesID.Text = dgSubjects.Item(0, i).Value
        txtsubjectcode.Text = dgSubjects.Item(1, i).Value
        txtDescription.Text = dgSubjects.Item(2, i).Value
        txtGrade.Text = dgSubjects.Item(4, i).Value
        txtComplied.Text = dgSubjects.Item(5, i).Value
        cboSemester.Text = dgSubjects.Item(6, i).Value
        txtSY.Text = dgSubjects.Item(7, i).Value

        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Public Sub formLoad()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = False

        'txtsubjectcode.Clear()
        'txtDescription.Clear()
        'txtGrade.Clear()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update grades set Final='" & txtGrade.Text & "',Complied='" & txtComplied.Text & "',Semester='" & cboSemester.Text & "',SY='" & txtSY.Text & "' where gradesid='" & lblGradesID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            MsgBox("1 record updated successfully!", MsgBoxStyle.Information)

            formLoad()
            getGrades()
            btnAdd.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from grades where gradesid='" & lblGradesID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("One record deleted successfully!", MsgBoxStyle.Information)
                formLoad()
                getGrades()

                btnAdd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getGrades()
    End Sub
    Private Sub btnView_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        getGrades()
    End Sub
    Private Sub cboSemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSemester.SelectedIndexChanged
        getGrades()
    End Sub
    Private Sub txtSY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSY.TextChanged
        getGrades()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmEncodeGrades.ShowDialog()
        lblCourse.Text = frmEncodeGrades.cboCourse.Text
        frmEncodeGrades.getCourseShortName()
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
                lblSchool.Text = dtReader(1)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class