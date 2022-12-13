Imports MySql.Data.MySqlClient
Public Class frmStaffBooks
    Dim str As String
    Dim i As String

    Private Sub StaffBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            str = "select BookID,BookNo,Title,BorDate,DueDate,ProcBy from libloans where StudentNumber='" & frmStaffRet.txtStudentNo.Text & "' and Returned='No'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "libloans")
            dg1.DataSource = ds.Tables("libloans")
            conn.Close()

            dg1.Columns(3).HeaderText = "Borrowed Date"
            dg1.Columns(4).HeaderText = "Due Date"
            dg1.Columns(5).HeaderText = "Proccessed By"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try

    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmStaffRet.lblBookID.Text = dg1.Item(0, i).Value
        frmStaffRet.txtbookno.Text = dg1.Item(1, i).Value
        frmStaffRet.txttitle.Text = dg1.Item(2, i).Value
        frmStaffRet.dtpborroweddate.Text = dg1.Item(3, i).Value
        frmStaffRet.dtpduedate.Text = dg1.Item(4, i).Value

        frmStaffRet.txtprocby.Text = frmParent.lblUser.Text
        frmStaffRet.txtreturndate.Text = Today
        frmStaffRet.tsSave.Enabled = True
        Me.Close()

    End Sub
End Class