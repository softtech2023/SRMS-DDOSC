Imports MySql.Data.MySqlClient
Public Class frmSearchEmployee
    Dim str As String
    Private Sub frmSearchEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoStaff.Checked = True
        getOptions()
    End Sub

    Public Sub getOptions()
        Try
            If rdoStaff.Checked = True Then
                str = "select IDNumber, FirstName, LastName, empPosition, Department from staff"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "staff")
                dgProfile.DataSource = ds.Tables("staff")
                conn.Close()

                dgProfile.Columns(0).HeaderText = "Employee No."
                dgProfile.Columns(1).HeaderText = "First Name"
                dgProfile.Columns(2).HeaderText = "Last Name"
                dgProfile.Columns(3).HeaderText = "Position"

            Else
                str = "select StudentNumber, FirstName, LastName from studeprofile"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgProfile.DataSource = ds.Tables("studeprofile")
                conn.Close()

                dgProfile.Columns(0).HeaderText = "Student No."
                dgProfile.Columns(1).HeaderText = "First Name"
                dgProfile.Columns(1).Width = 150
                dgProfile.Columns(2).HeaderText = "Last Name"
                dgProfile.Columns(2).Width = 150

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If rdoStaff.Checked = True Then
                str = "select IDNumber, FirstName, LastName, empPosition, Department from staff where LastName like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "staff")
                dgProfile.DataSource = ds.Tables("staff")
                conn.Close()

                dgProfile.Columns(0).HeaderText = "Employee No."
                dgProfile.Columns(1).HeaderText = "First Name"
                dgProfile.Columns(2).HeaderText = "Last Name"
                dgProfile.Columns(3).HeaderText = "Position"
            Else
                str = "select StudentNumber, FirstName, LastName from studeprofile where Lastname like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgProfile.DataSource = ds.Tables("studeprofile")
                conn.Close()

                dgProfile.Columns(0).HeaderText = "Student No."
                dgProfile.Columns(1).HeaderText = "First Name"
                dgProfile.Columns(1).Width = 150
                dgProfile.Columns(2).HeaderText = "Last Name"
                dgProfile.Columns(2).Width = 150

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        If rdoStaff.Checked = True Then
            Dim i As Integer
            i = dgProfile.CurrentRow.Index
            frmDistribution.txtempNo.Text = dgProfile.Item(0, i).Value
            frmDistribution.txtFirstName.Text = dgProfile.Item(1, i).Value
            frmDistribution.txtLastName.Text = dgProfile.Item(2, i).Value
            frmDistribution.lblType.Text = "Staff"
            frmProducts.getMRPerStaff()
            frmDistribution.btnSave.Enabled = True

        Else
            Dim i As Integer
            i = dgProfile.CurrentRow.Index
            frmDistribution.txtempNo.Text = dgProfile.Item(0, i).Value
            frmDistribution.txtFirstName.Text = dgProfile.Item(1, i).Value
            frmDistribution.txtLastName.Text = dgProfile.Item(2, i).Value
            frmDistribution.lblType.Text = "Student"

            frmProducts.getMRPerStaff()
            frmDistribution.btnSave.Enabled = True
        End If

        

        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rdoStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStaff.CheckedChanged
        getOptions()
    End Sub

    Private Sub rdoStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoStudent.CheckedChanged
        getOptions()
    End Sub
End Class