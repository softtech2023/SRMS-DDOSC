Imports MySql.Data.MySqlClient
Public Class frmSubjects
    Dim str As String
    Private Sub frmSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCourseMajor()
        FormLoad()
    End Sub

    Public Sub FormLoad()
        Try
            txtSubjectCode.Clear()
            txtdescription.Clear()
            txtLecUnits.Clear()
            txtLabUnits.Clear()
            txtPreq.Clear()
            txtCurriculum.Clear()
            txtLabFee.Text = 0
            txtSubjectCode.Focus()

            str = "select * from subjects order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 250
            dgsubjects.Columns(2).HeaderText = "Subject Description"
            dgsubjects.Columns(3).HeaderText = "Lec Unit"
            dgsubjects.Columns(3).Width = 40
            dgsubjects.Columns(4).HeaderText = "Lab Unit"
            dgsubjects.Columns(4).Width = 40
            dgsubjects.Columns(5).Width = 210
            dgsubjects.Columns(5).HeaderText = "Prerequisite"
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(14).Visible = False

            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

            getCourse()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            lblID.Text = dgsubjects.Item(0, dclick).Value
            txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            txtdescription.Text = dgsubjects.Item(2, dclick).Value
            txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
            txtLabUnits.Text = dgsubjects.Item(4, dclick).Value
            txtPreq.Text = dgsubjects.Item(5, dclick).Value
            txtCurriculum.Text = dgsubjects.Item(6, dclick).Value
            cboYearLevel.Text = dgsubjects.Item(7, dclick).Value
            cboSemester.Text = dgsubjects.Item(8, dclick).Value
            cboCourse.Text = dgsubjects.Item(9, dclick).Value
            cboSemEffective.Text = dgsubjects.Item(10, dclick).Value
            txtSYEffective.Text = dgsubjects.Item(11, dclick).Value
            cboMajor.Text = dgsubjects.Item(13, dclick).Value
            txtLabFee.Text = dgsubjects.Item(14, dclick).Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from subjects where SubjectCode like '%" & txtsearch.Text & "%' or description like '%" & txtsearch.Text & "%' "
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).Width = 250
            dgsubjects.Columns(2).HeaderText = "Subject Description"
            dgsubjects.Columns(3).HeaderText = "Lec Unit"
            dgsubjects.Columns(3).Width = 60
            dgsubjects.Columns(4).HeaderText = "Lab Unit"
            dgsubjects.Columns(4).Width = 60
            dgsubjects.Columns(5).Width = 200
            dgsubjects.Columns(5).HeaderText = "Prerequisite"
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(10).Visible = False
            dgsubjects.Columns(11).Visible = False
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(14).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Year Level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtSubjectCode.Text = "" Then
                MsgBox("Subject Code is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtdescription.Text = "" Then
                MsgBox("Subject Description is required", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSemEffective.Text = "" And txtSYEffective.Text = "" Then
                MsgBox("Effectivity is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            txtEffective.Text = cboSemEffective.Text + ", SY " + txtSYEffective.Text

            Dim Description As String
            Description = txtdescription.Text.Replace("'", "''")
            'Description = txtdescription.Text.Replace("/", "//")

            str = "insert into subjects values('0','" & txtSubjectCode.Text & "','" & Description & "','" & txtLecUnits.Text & "','" & txtLabUnits.Text & "','" & txtPreq.Text & "','" & txtCurriculum.Text & "','" & cboYearLevel.Text & "','" & cboSemester.Text & "','" & cboCourse.Text & "','" & cboSemEffective.Text & "','" & txtSYEffective.Text & "','" & txtEffective.Text & "','" & cboMajor.Text & "','" & txtLabFee.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            FormLoad()
            btnViewSubjects.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try


            If txtSubjectCode.Text = "" Then
                MsgBox("Please select a subject you want to update!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Year Level is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSemEffective.Text = "" And txtSYEffective.Text = "" Then
                MsgBox("Effectivity is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            txtEffective.Text = cboSemEffective.Text + ", SY " + txtSYEffective.Text

            Dim Description As String
            Description = txtdescription.Text.Replace("'", "''")
            'Description = txtdescription.Text.Replace("/", "//")

            str = "update subjects set SubjectCode='" & txtSubjectCode.Text & "',description='" & Description & "',lecunit='" & txtLecUnits.Text & "',labunit='" & txtLabUnits.Text & "',prereq='" & txtPreq.Text & "',curriculum='" & txtCurriculum.Text & "',YearLevel='" & cboYearLevel.Text & "',Semester='" & cboSemester.Text & "',Course='" & cboCourse.Text & "',SemEffective='" & cboSemEffective.Text & "',SYEffective='" & txtSYEffective.Text & "',Effectivity='" & txtEffective.Text & "',Major='" & cboMajor.Text & "',labFee='" & txtLabFee.Text & "' where subjectid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            str = "update semsubjects set Description='" & Description & "',LecUnit='" & txtLecUnits.Text & "',LabUnit='" & txtLabUnits.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Course='" & cboCourse.Text & "' and cMajor='" & cboMajor.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC1 As New MySqlCommand(str, conn)
            mysC1.ExecuteNonQuery()
            conn.Close()

            str = "update registration set Description='" & Description & "',LecUnit='" & txtLecUnits.Text & "',LabUnit='" & txtLabUnits.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            'update grades
            'str = "update grades set Description='" & Description & "',LecUnit='" & txtLecUnits.Text & "',LabUnit='" & txtLabUnits.Text & "' where SubjectCode='" & txtSubjectCode.Text & "'"
            'conn.Open()
            'Dim mysC3 As New MySqlCommand(str, conn)
            'mysC3.ExecuteNonQuery()
            'conn.Close()

            MsgBox("Data has been updated!", MsgBoxStyle.Information)
            FormLoad()
            btnViewSubjects.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Please select a subject you want to delete!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from subjects where subjectid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                FormLoad()
                btnViewSubjects.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        tsSave.PerformClick()
    End Sub

    Private Sub btnViewSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSubjects.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If
            If cboYearLevel.Text = "" Then
                MsgBox("Year level is required!", MsgBoxStyle.Exclamation)
                cboYearLevel.Focus()
                Exit Sub
            End If

            If cboSemester.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Exclamation)
                cboSemester.Focus()
                Exit Sub
            End If

            str = "select * from subjects where Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Semester='" & cboSemester.Text & "' and Major='" & cboMajor.Text & "' order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")

            cboMajor.ValueMember = "course_table"
            cboMajor.DisplayMember = "Major"
            cboMajor.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getCourseMajor()
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourse.ValueMember = "course_table"
            cboCourse.DisplayMember = "CourseDescription"
            'cboCourseCode.DisplayMember = "CourseCode"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
            conn.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
            conn.Close()
        End Try
    End Sub
   
    Private Sub cboCourse_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub
End Class