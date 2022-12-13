Imports MySql.Data.MySqlClient
Public Class frmSearchStudeforRefund
    Dim str As String
    Private Sub frmSearchStudeforRefund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmRefund.txtStudentNo.Text = dg1.Item(1, i).Value
        frmRefund.txtName.Text = dg1.Item(2, i).Value
        frmRefund.txtMName.Text = dg1.Item(3, i).Value
        frmRefund.txtLastName.Text = dg1.Item(4, i).Value
        frmRefund.refundRecords()
        frmRefund.txtAmount.Focus()

        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and LName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            'dg1.Columns(22).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub formLoad()
        Try
            str = "select * from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            'dg1.Columns(22).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class
