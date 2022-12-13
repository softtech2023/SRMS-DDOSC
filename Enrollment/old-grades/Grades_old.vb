Imports MySql.Data.MySqlClient
Public Class frmGradesOld
    Dim str As String


    Private Sub tsSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
         btnSave.PerformClick()
    End Sub
    Public Sub FormLoad()

        getSchool()
        getSubjectCode()
        getDescription()

        txtStudentNumber.Clear()
        txtName.Clear()
        txtFinalGrade.Clear()
        cboSubjectCode.ResetText()
        cboDescription.ResetText()
        cboSchool.ResetText()
        txtSY.Clear()
        cboSem.ResetText()
        txtLecUnit.Clear()
        txtLabUnit.Clear()

        txtStudentNumber.Focus()

        btnSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSelectStudes.ShowDialog()
    End Sub

    Private Sub frmGradesOld_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
        getSchool()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSubjects.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtStudentNumber.Text = "" Then
                MsgBox("Student Number is required!", MsgBoxStyle.Critical)
                txtStudentNumber.Focus()
                Exit Sub
            End If

            If cboDescription.Text = "" Then
                MsgBox("Description is required!", MsgBoxStyle.Critical)
                cboDescription.Focus()
                Exit Sub
            End If

            If cboSchool.Text = "" Then
                MsgBox("Instructor is required!", MsgBoxStyle.Exclamation)
                cboSchool.Focus()
                Exit Sub
            End If

            If cboSem.Text = "" Then
                MsgBox("Semester is required!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtSY.Text = "" Then
                MsgBox("SY is required!", MsgBoxStyle.Critical)
                txtSY.Focus()
                Exit Sub
            End If

            If cboSubjectCode.Text = "" Then
                MsgBox("Subject code is required!", MsgBoxStyle.Critical)
                cboSubjectCode.Focus()
                Exit Sub
            End If

            'check record if it exist
            str = "select * from grades where StudentNumber='" & txtStudentNumber.Text & "' and SubjectCode='" & cboSubjectCode.Text & "' and Description='" & cboDescription.Text & "' and Semester='" & cboSem.Text & "' and SY='" & txtSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()

            If ds.Tables("grades").Rows.Count = 1 Then
                MsgBox("Record already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If

            str = "insert into grades values('0','" & txtFinalGrade.Text & "','','" & cboSubjectCode.Text & "','" & txtSY.Text & "','" & cboSem.Text & "','','" & txtStudentNumber.Text & "','','','" & cboDescription.Text & "','" & cboSchool.Text & "','" & txtLecUnit.Text & "','" & txtLabUnit.Text & "','Closed')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update grades set Semester='" & cboSem.Text & "',SY='" & txtSY.Text & "',Final='" & txtFinalGrade.Text & "',SubjectCode='" & cboSubjectCode.Text & "',Description='" & cboDescription.Text & "',TakenAt='" & cboSchool.Text & "',LecUnit='" & txtLecUnit.Text & "',LabUnit='" & txtLabUnit.Text & "' where gradesID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            cboSubjectCode.ResetText()
            cboDescription.ResetText()
            cboSem.ResetText()
            txtSY.Clear()
            txtFinalGrade.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from grades where gradesID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
                cboSubjectCode.ResetText()
                cboDescription.ResetText()
                cboSem.ResetText()
                txtSY.Clear()

                txtFinalGrade.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchGrades_old.ShowDialog()
    End Sub
    Public Sub getSchool()
        Try
            str = "select * from prevschool group by School order by School"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "prevschool")
            conn.Close()
            cboSchool.ValueMember = "prevschool"
            cboSchool.DisplayMember = "School"
            cboSchool.DataSource = ds.Tables("prevschool")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getSubjectCode()
        Try
            str = "select * from grades group by SubjectCode order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()
            cboSubjectCode.ValueMember = "grades"
            cboSubjectCode.DisplayMember = "SubjectCode"
            cboSubjectCode.DataSource = ds.Tables("grades")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getDescription()
        Try
            str = "select * from grades group by Description order by Description"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()
            cboDescription.ValueMember = "grades"
            cboDescription.DisplayMember = "Description"
            cboDescription.DataSource = ds.Tables("grades")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getStudeName()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from studeprofile where StudentNumber='" & txtStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtName.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
