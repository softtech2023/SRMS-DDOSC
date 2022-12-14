Imports MySql.Data.MySqlClient
Public Class frmSearchEmployeeName
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StaffName, empPosition, Department from staff where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
            dgProfile.Columns(1).HeaderText = "Name"
            dgProfile.Columns(1).Width = 200

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub SearchEmployeeName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StaffName, empPosition, Department from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()

            dgProfile.Columns(1).HeaderText = "Name"
            dgProfile.Columns(1).Width = 200

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmConsumableSummary.lblEmployeeNo.Text = dgProfile.Item(0, i).Value
        frmConsumableSummary.txtAccountable.Text = dgProfile.Item(1, i).Value
        

        frmConsumableSummary.btnPreview.Enabled = True


        frmProducts.getMRPerStaff()

        Me.Close()
        conn.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class