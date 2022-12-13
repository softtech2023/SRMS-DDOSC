Imports MySql.Data.MySqlClient
Public Class frmGradUpdate
    Dim str As String
    Private Sub GradUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub formload()
        txtStudeNo.Clear()
        txtName.Clear()
        txtCourse.Clear()
        txtMajor.Clear()
        txtsemgrad.Clear()
        txtDateGrad.Clear()
        txtgpa.Clear()
        txtCompany.Clear()
        txtCompAddress.Clear()
        txtSalary.Clear()
        txtPosition.Clear()
        txtWorkNature.Clear()
        txtsygraduated.Clear()
        btnSave.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmsearchalumni.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "update alum_reg set empStat='" & cboEmpStat.Text & "',company='" & txtCompany.Text & "',companyAd='" & txtCompAddress.Text & "',empPosition='" & txtPosition.Text & "',salary='" & txtSalary.Text & "',empType='" & cboEmpType.Text & "',workNature='" & txtWorkNature.Text & "',gpa='" & txtgpa.Text & "' where StudentNumber='" & txtStudeNo.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information, "Prompt")
            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from alum_reg where StudentNumber='" & txtStudeNo.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Deleted alumni Profile','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & txtStudeNo.Text & "')"
                conn.Open()
                Dim mysc2 As New MySqlCommand(str, conn)
                mysc2.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class