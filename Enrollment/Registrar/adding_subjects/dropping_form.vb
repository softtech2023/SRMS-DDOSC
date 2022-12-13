Imports MySql.Data.MySqlClient
Public Class frmDroppingForm
    Dim str As String
    Dim str2 As String
    Dim str3 As String
    Private Sub txtStudentNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentNo.Click
        frmSelectStudeDrop.ShowDialog()
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        FormLoad()
        'loadEnrolledSubjects()
        frmSelectStudeDrop.ShowDialog()
    End Sub

    Public Sub loadEnrolledSubjects()
        Try
            str = "select regnumber, SubjectCode, Description, Section, Instructor, LecUnit, LabUnit from registration where StudentNumber='" & txtStudentNo.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgSubjects.DataSource = ds.Tables("registration")
            conn.Close()

            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).HeaderText = "Subject Code"
            dgSubjects.Columns(2).Width = 270
            dgSubjects.Columns(3).Width = 120
            dgSubjects.Columns(4).Width = 205

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        btnDropSelectedSubject.Enabled = False

        txtStudentNo.Clear()
        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()

        txtsubjectcode.Clear()
        txtDescription.Clear()
        txtSection.Clear()
        txtInstructor.Clear()

    End Sub

    Private Sub frmDroppingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
        'loadEnrolledSubjects()
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index

        lblRegNumber.Text = dgSubjects.Item(0, i).Value
        txtsubjectcode.Text = dgSubjects.Item(1, i).Value
        txtDescription.Text = dgSubjects.Item(2, i).Value
        txtSection.Text = dgSubjects.Item(3, i).Value
        txtInstructor.Text = dgSubjects.Item(4, i).Value
        lblLecUnits.Text = dgSubjects.Item(5, i).Value
        lblLabUnits.Text = dgSubjects.Item(6, i).Value
        'lblTotalUnits.Text = dgSubjects.Item(6, i).Value


        loadSlot()
        getTotalUnits()
        getNewTotal()
        getTotalLab()

        btnDropSelectedSubject.Enabled = True

    End Sub

    Public Sub loadSlot()
        Try
            str = "select Slot from semsubjects where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                lblCurrentSlot.Text = Val(mysDR(0))
            End While

            lblFinalSlot.Text = lblCurrentSlot.Text + 1

            mysDR.Close()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDropSelectedSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDropSelectedSubject.Click
        Try
            If (MsgBox("Are you sure you want drop this subject?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from registration where regnumber='" & lblRegNumber.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'update subject slot
                str2 = "update semsubjects set Slot='" & lblFinalSlot.Text & "' where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str2, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                'update totalUnits
                str2 = "update registration set totalUnits='" & lblNewTotal.Text & "',labfee='" & lblFinalSpecialLab.Text & "' where StudentNumber='" & txtStudentNo.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc2 As New MySqlCommand(str2, conn)
                mysc2.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Dropped subject/s','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & txtStudentNo.Text & "')"
                conn.Open()
                Dim mysc8 As New MySqlCommand(str, conn)
                mysc8.ExecuteNonQuery()
                conn.Close()


                MsgBox("Record deleted successfully!", MsgBoxStyle.Information)

                loadEnrolledSubjects()

                txtsubjectcode.Clear()
                txtDescription.Clear()
                txtSection.Clear()
                txtInstructor.Clear()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getNewTotal()
        Dim unitTotal, grandTotal As Double
        unitTotal = Val(lblLecUnits.Text) + Val(lblLabUnits.Text)
        grandTotal = Val(lblTotalUnits.Text) - unitTotal
        lblNewTotal.Text = grandTotal

    End Sub
    Public Sub getTotalUnits()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select totalUnits, labfee from registration where StudentNumber='" & txtStudentNo.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblTotalUnits.Text = dtReader(0)
                lblCurrentSpecialLal.Text = dtReader(1)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalLab()
        Try

            Dim totalLab As Double
            str = "select * from subjects where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalLab += Val(mysDR(14))
            End While
            lblLabFee.Text = totalLab
            conn.Close()

            Dim finalLabFee As Double
            finalLabFee = Val(lblCurrentSpecialLal.Text) - Val(lblLabFee.Text)
            lblFinalSpecialLab.Text = finalLabFee

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class