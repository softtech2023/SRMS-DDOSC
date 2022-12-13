Imports MySql.Data.MySqlClient
Public Class frmSelectStudes
    Dim str As String
    Private Sub frmSelectStudes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, concat(LastName,', ',FirstName) as studeName from studeprofile order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgStudes.DataSource = ds.Tables("studeprofile")
            conn.Close()
            dgStudes.Columns(1).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, concat(LastName,', ',FirstName) as studeName from studeprofile where LastName like '%" & txtSearch.Text & "%' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades_old")
            dgStudes.DataSource = ds.Tables("grades_old")
            conn.Close()
            dgStudes.Columns(1).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgStudes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStudes.DoubleClick
        Dim i As Integer
        i = dgStudes.CurrentRow.Index
        frmGradesOld.txtStudentNumber.Text = dgStudes.Item(0, i).Value
        frmGradesOld.txtName.Text = dgStudes.Item(1, i).Value

        txtSearch.Clear()
        Me.Close()

    End Sub
End Class