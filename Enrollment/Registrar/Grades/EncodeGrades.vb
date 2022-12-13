Imports MySql.Data.MySqlClient
Public Class frmEncodeGrades
    Dim str As String

    Public Sub formLoad()

        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtGrade.Clear()
        tsSave.Enabled = False

        cboCourse.Text = frmStudeGrades.lblCourse.Text
        cboMajor.Text = frmStudeGrades.lblMajor.Text

        Try
            str = "select * from subjects group by SubjectCode, description order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgSubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).HeaderText = "Course Code"
            dgSubjects.Columns(2).HeaderText = "Course Title"
            dgSubjects.Columns(2).Width = 250
            dgSubjects.Columns(3).HeaderText = "Lec"
            dgSubjects.Columns(4).HeaderText = "Lab"

            dgSubjects.Columns(5).Visible = False
            dgSubjects.Columns(6).Visible = False
            dgSubjects.Columns(7).Visible = False
            dgSubjects.Columns(8).Visible = False
            dgSubjects.Columns(9).Visible = False
            dgSubjects.Columns(10).Visible = False
            dgSubjects.Columns(11).Visible = False
            dgSubjects.Columns(12).Visible = False
            dgSubjects.Columns(13).Visible = False
            dgSubjects.Columns(14).Visible = False

            getCourseShortName()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmEncodeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from subjects where SubjectCode like '%" & txtSearch.Text & "%' or description like '%" & txtSearch.Text & "%' group by SubjectCode, description order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgSubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).HeaderText = "Course Code"
            dgSubjects.Columns(2).HeaderText = "Course Title"
            dgSubjects.Columns(2).Width = 250
            dgSubjects.Columns(3).HeaderText = "Lec"
            dgSubjects.Columns(4).HeaderText = "Lab"

            dgSubjects.Columns(5).Visible = False
            dgSubjects.Columns(6).Visible = False
            dgSubjects.Columns(7).Visible = False
            dgSubjects.Columns(8).Visible = False
            dgSubjects.Columns(9).Visible = False
            dgSubjects.Columns(10).Visible = False
            dgSubjects.Columns(11).Visible = False
            dgSubjects.Columns(12).Visible = False
            dgSubjects.Columns(13).Visible = False
            dgSubjects.Columns(14).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index
        txtsubjectcode.Text = dgSubjects.Item(1, i).Value
        txtDescription.Text = dgSubjects.Item(2, i).Value
        lblLec.Text = dgSubjects.Item(3, i).Value
        lblLab.Text = dgSubjects.Item(4, i).Value

        tsSave.Enabled = True

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtSY.Text = "" Then
                MsgBox("School Year is required!", MsgBoxStyle.Exclamation)
                Exit Sub
                txtSY.Focus()
            End If

            If txtGrade.Text = "" Then
                MsgBox("Grade is required!", MsgBoxStyle.Exclamation)
                Exit Sub
                txtGrade.Focus()
            End If

            Dim Description As String
            Description = txtDescription.Text.Replace("'", "''")

            str = "insert into grades values(0,'" & txtGrade.Text & "','','" & txtsubjectcode.Text & "','" & txtSY.Text & "','" & cboSemester.Text & "','','" & frmStudeGrades.txtStudentNo.Text & "','','','" & Description & "','" & frmStudeGrades.lblSchool.Text & "','" & lblLec.Text & "','" & lblLab.Text & "','Closed','" & frmStudeGrades.lblSettingsID.Text & "','" & lblCourseShortcut.Text & "','','" & lblSeqID.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("One record added!", MsgBoxStyle.Information)

            formLoad()
            frmStudeGrades.getGrades()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        tsSave.PerformClick()
    End Sub
    Public Sub seqID()
        If cboSemester.Text = "First Semester" Then
            lblSeqID.Text = 1

        ElseIf cboSemester.Text = "Second Semester" Then
            lblSeqID.Text = 2
        Else
            lblSeqID.Text = 3
        End If
    End Sub

    Private Sub cboSemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSemester.SelectedIndexChanged
        seqID()
    End Sub
    Public Sub getCourseShortName()
        Try
            'str = "select * from course_table where CourseDescription='" & lblCourse.Text & "' group by courseGroup"
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                'txtChecked.Text = dtReader(5)
                lblCourseShortcut.Text = dtReader(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseShortName()
    End Sub
End Class