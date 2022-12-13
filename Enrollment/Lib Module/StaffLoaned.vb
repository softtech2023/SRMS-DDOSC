Imports MySql.Data.MySqlClient
Public Class frmStaffLoaned
    Dim str As String
    Dim i As Integer
    Public Sub formload()
        Try
            str = " select loanID,StudentNumber, Name from libloans where Returned='No' and borrower='Teacher' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 350
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Private Sub frmStaffLoaned_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = " select loanID,StudentNumber, Name from libloans where Returned='No' and borrower='Teacher' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 350
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        i = dg1.CurrentRow.Index
        frmStaffRet.lblloanID.Text = dg1.Item(0, i).Value
        frmStaffRet.txtStudentNo.Text = dg1.Item(1, i).Value
        frmStaffRet.txtName.Text = dg1.Item(2, i).Value
        frmStaffRet.btnselectbook.Enabled = True
        frmStaffRet.tsSave.Enabled = False
        Me.Close()

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try

            If txtsearch.Text = "" Then
                formload()
                Exit Sub
            End If

            str = " select semstudentID, StudentNumber, Name, Course, YearLevel from libloans where Returned='No' and borrower='Teacher' or Name like '%" & txtsearch.Text & "%' or StudentNumber like '%" & txtsearch.Text & "%' order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Width = 150
            dg1.Columns(4).Width = 150
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
End Class