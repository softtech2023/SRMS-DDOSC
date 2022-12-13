Imports MySql.Data.MySqlClient
Public Class frmSearchAccountable
    Dim str As String

    Private Sub SearchAccountable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, transactionNo, transactionDate, transactionTime from ls_distribution"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_distribution")
            dgProfile.DataSource = ds.Tables("ls_distribution")
            conn.Close()

            dgProfile.Columns(0).Visible = False
            dgProfile.Columns(1).Width = 160
            dgProfile.Columns(2).HeaderText = "Transaction No."
            dgProfile.Columns(3).HeaderText = "Date"
            dgProfile.Columns(4).HeaderText = "Time"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select IDNumber, concat(FirstName,' ',LastName) as Name, transactionNo, transactionDate, transactionTime from ls_distribution where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_distribution")
            dgProfile.DataSource = ds.Tables("ls_distribution")
            conn.Close()

            dgProfile.Columns(0).Visible = False
            dgProfile.Columns(1).Width = 160
            dgProfile.Columns(2).HeaderText = "Transaction No."
            dgProfile.Columns(3).HeaderText = "Date"
            dgProfile.Columns(4).HeaderText = "Time"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index
        frmPARform.lblIDNumber.Text = dgProfile.Item(0, i).Value
        frmPARform.txtAccountable.Text = dgProfile.Item(1, i).Value

        frmPARform.btnPreview.Enabled = True

        'frmProducts.getMRPerStaff()

        Me.Close()
        conn.Close()
        conn.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class