Imports MySql.Data.MySqlClient
Public Class frmSearchPersonnel2
    Dim str As String
    Private Sub frmSearchPersonnel2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StaffName, empPosition, Department from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()

            dgProfile.Columns(0).HeaderText = "Employee No."
            dgProfile.Columns(1).HeaderText = "Name"
            dgProfile.Columns(1).Width = 200
            dgProfile.Columns(2).Width = 150
            dgProfile.Columns(2).HeaderText = "Position"
            dgProfile.Columns(3).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index

        frmProducts.lblIDNumber.Text = dgProfile.Item(0, i).Value
        frmProducts.txtAccountable.Text = dgProfile.Item(1, i).Value

        frmMRDashboard.lblIDNumber.Text = dgProfile.Item(0, i).Value
        frmMRDashboard.txtAccountable.Text = dgProfile.Item(1, i).Value

        frmAccountable.lblIDNumber.Text = dgProfile.Item(0, i).Value
        frmAccountable.txtAccountable.Text = dgProfile.Item(1, i).Value

        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StaffName, empPosition, Department from staff where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
            dgProfile.Columns(0).HeaderText = "Employee No."
            dgProfile.Columns(1).HeaderText = "Name"
            dgProfile.Columns(1).Width = 200
            dgProfile.Columns(2).Width = 150
            dgProfile.Columns(2).HeaderText = "Position"
            dgProfile.Columns(3).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class