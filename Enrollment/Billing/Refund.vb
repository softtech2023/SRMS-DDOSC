Imports MySql.Data.MySqlClient
Public Class frmRefund
    Dim str As String
    Public Sub computeRefund()
        Dim refund, balance As Double
        refund = Val(lblRefund.Text) + Val(txtAmount.Text)
        lblTotalRefund.Text = refund
        balance = Val(lblTotalPayments.Text) - Val(txtAmount.Text)
        lblCurrentPayments.Text = balance
        lblCurrentBalance.Text = Val(lblTotalAcct.Text) - Val(lblCurrentPayments.Text)
    End Sub
    Public Sub FormLoad()
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        txtStudentNo.Clear()
        txtName.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtAmount.Text = 0
        dtpDate.Text = Today
        dtpDateReq.Text = Today
        txtdebit.Clear()
        txtReasons.Clear()
        txtNotes.Clear()
        txtdebit.Clear()

        refundRecords()
        txtStudentNo.Focus()
    End Sub

    Private Sub frmRefund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            str = "insert into refund values (0,'" & txtStudentNo.Text & "','" & txtName.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & txtAmount.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtReasons.Text & "','" & txtNotes.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtdebit.Text & "','" & Convert.ToDateTime(dtpDateReq.Text).ToString("yyyy-MM-dd") & "','1')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "insert into expenses values ('0','Refund','" & txtAmount.Text & "','" & txtName.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','Refund')"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'str = "update studeaccount set CurrentBalance='" & lblCurrentBalance.Text & "',Refund='" & lblTotalRefund.Text & "' where StudentNumber='" & txtStudentNo.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            'conn.Open()
            'Dim mysc2 As New MySqlCommand(str, conn)
            'mysc2.ExecuteNonQuery()
            'conn.Close()

            MsgBox("Record has been saved!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchStudeforRefund.ShowDialog()
    End Sub

    Public Sub refundRecords()
        Try
            str = "select * from refund where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "refund")
            dg1.DataSource = ds.Tables("refund")
            conn.Close()

            dg1.Columns(0).Visible = True
            dg1.Columns(0).HeaderText = "Transaction No."
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(6).HeaderText = "Date Refunded"
            dg1.Columns(7).Visible = True
            dg1.Columns(7).HeaderText = "Reason/s"
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = True
            dg1.Columns(11).HeaderText = "Debit Memo"
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        lblID.Text = dg1.Item(0, i).Value
        txtStudentNo.Text = dg1.Item(1, i).Value
        txtName.Text = dg1.Item(2, i).Value
        txtMName.Text = dg1.Item(3, i).Value
        txtLastName.Text = dg1.Item(4, i).Value
        txtAmount.Text = dg1.Item(5, i).Value
        dtpDate.Text = dg1.Item(6, i).Value
        txtReasons.Text = dg1.Item(7, i).Value
        txtNotes.Text = dg1.Item(8, i).Value
        txtdebit.Text = dg1.Item(11, i).Value
        dtpDateReq.Text = dg1.Item(12, i).Value

        tsSave.Enabled = False
        tsUpdate.Enabled = True
        tsDelete.Enabled = True

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from refund where refundID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()
                refundRecords()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub accountInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from studeaccount where StudentNumber='" & txtStudentNo.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblTotalAcct.Text = dtReader(19)
                lblTotalPayments.Text = dtReader(20)
                lblRefund.Text = dtReader(37)
                lblTotalDiscount.Text = dtReader(18)
                lblBalance.Text = dtReader(21)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtStudentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNo.TextChanged
        accountInfo()
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        computeRefund()
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update refund set Amount= '" & txtAmount.Text & "',DateRefunded='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "',DateRequest='" & Convert.ToDateTime(dtpDateReq.Text).ToString("yyyy-MM-dd") & "',Reasons='" & txtReasons.Text & "',Notes='" & txtNotes.Text & "',DebitMemo='" & txtdebit.Text & "' where refundID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'str = "update expenses set Amount='" & txtAmount.Text & "',ExpenseDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','Refund')"
            'conn.Open()
            'Dim mysc1 As New MySqlCommand(str, conn)
            'mysc1.ExecuteNonQuery()
            'conn.Close()


            MsgBox("Record updated successfully!", MsgBoxStyle.Information)
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from refund where LastName like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "refund")
            dg1.DataSource = ds.Tables("refund")
            conn.Close()

            dg1.Columns(0).Visible = True
            dg1.Columns(0).HeaderText = "Transaction No."
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(6).HeaderText = "Date Refunded"
            dg1.Columns(7).Visible = True
            dg1.Columns(7).HeaderText = "Reason/s"
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = True
            dg1.Columns(11).HeaderText = "Debit Memo"
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class