Imports MySql.Data.MySqlClient
Public Class frmGrades
    Dim str As String

    Public Sub getAverage()
        Dim ave As Double
        ave = (Val(txtPrelim.Text) + Val(txtMidterm.Text) + Val(txtFinal.Text)) / 3
        txtAverage.Text = Format(ave, "0.00")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmselect_input_grades.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSubjectCode.Text = "" Then
            MsgBox("Select Subject first!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmselect_input_stude.ShowDialog()
    End Sub

    Private Sub tsSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Subject details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtStudentNumber.Text = "" Then
                MsgBox("Student details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "select * from grades where StudentNumber='" & txtStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtDescription.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()

            If ds.Tables("grades").Rows.Count = 1 Then
                MsgBox("Record exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If

            str = "insert into grades values (0,'" & txtStudentNumber.Text & "','" & txtName.Text & "','" & txtSubjectCode.Text & "','" & txtDescription.Text & "','" & txtLecUnit.Text & "','" & txtLabUnit.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txtPrelim.Text & "','" & txtMidterm.Text & "','" & txtFinal.Text & "','" & txtAverage.Text & "','" & txtEqv.Text & "','" & txtRemarks.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','Open','" & lblCourse.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record added successfully!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtStudentNumber.Clear()
        txtName.Clear()
        txtPrelim.Clear()
        txtMidterm.Clear()
        txtFinal.Clear()
        txtAverage.Clear()
        txtEqv.Clear()
        txtRemarks.Clear()

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub frmGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtLecUnit.Clear()
        txtLabUnit.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
    End Sub
    Public Sub getEQV()
        Try
            Dim i As Double

            If (txtAverage.Text = 100) Then
                i = 1.0
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 99) Then
                i = 1.1
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 98) Then
                i = 1.2
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 97) Then
                i = 1.3
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 96) Then
                i = 1.4
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 95) Then
                i = 1.5
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 94) Then
                i = 1.6
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 93) Then
                i = 1.7
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 92) Then
                i = 1.8
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 91) Then
                i = 1.9
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 90) Then
                i = 2.0
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 89) Then
                i = 2.1
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 88) Then
                i = 2.2
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 87) Then
                i = 2.3
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 86) Then
                i = 2.4
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 85) Then
                i = 2.5
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 84) Then
                i = 2.6
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 83) Then
                i = 2.7
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 82) Then
                i = 2.8
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 81) Then
                i = 2.9
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 80) Then
                i = 3.0
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 79) Then
                i = 3.1
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 78) Then
                i = 3.2
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 77) Then
                i = 3.3
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 76) Then
                i = 3.4
                txtEqv.Text = i
            ElseIf (txtAverage.Text >= 75) Then
                i = 3.5
                txtEqv.Text = i
            ElseIf (txtAverage.Text < 75) Then
                i = 5.0
                txtEqv.Text = i
            ElseIf (txtAverage.Text = "") Then
                i = ""
                txtEqv.Text = i
            Else
                i = 9.0
                txtEqv.Text = i
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub getRemarks()
        Try
            If txtEqv.Text <= 3.5 Then
                txtRemarks.Text = "Passed"
            ElseIf txtEqv.Text = 5.0 Then
                txtRemarks.Text = "Failed"
            ElseIf txtEqv.Text = "" Then
                txtRemarks.Text = "INC."
            Else
                txtRemarks.Text = "Dropped"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getAverage()
        getEQV()
        getRemarks()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchGrades.ShowDialog()
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                str = "delete from grades where gradeID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()

                FormLoad()
                btnReset.PerformClick()
                tsSave.Enabled = True
                tsUpdate.Enabled = False
                tsDelete.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            If txtSubjectCode.Text = "" Then
                MsgBox("Subject details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtStudentNumber.Text = "" Then
                MsgBox("Student details is required!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "update grades set StudentNumber='" & txtStudentNumber.Text & "',StudentName='" & txtName.Text & "',SubjectCode='" & txtSubjectCode.Text & "',Description='" & txtDescription.Text & "',LecUnit='" & txtLecUnit.Text & "',LabUnit='" & txtLabUnit.Text & "',Instructor='" & txtInstructor.Text & "',Section='" & txtSection.Text & "',PGrade='" & txtPrelim.Text & "',MGrade='" & txtMidterm.Text & "',FGrade='" & txtFinal.Text & "',Average='" & txtAverage.Text & "',Eqv='" & txtEqv.Text & "',Remarks='" & txtRemarks.Text & "' where gradeID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated successfully!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            btnReset.PerformClick()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtPrelim.Clear()
        txtMidterm.Clear()
        txtFinal.Clear()
        txtAverage.Clear()
        txtEqv.Clear()
        txtRemarks.Clear()
    End Sub
End Class
