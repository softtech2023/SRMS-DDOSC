Imports MySql.Data.MySqlClient
Public Class frmViewPaymentHistory
    Dim str As String
    Private Sub frmViewPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select PDate, ORNumber, Amount, description, PaymentType from paymentsaccounts where StudentNumber='" & frmBilling.mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and CollectionSource!='Services'  order by PDate desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dg1.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()

            dg1.Columns(0).HeaderText = "Date"
            dg1.Columns(1).HeaderText = "O.R. No."
            'Format(dg1.Columns(2), "00.00")
            dg1.Columns(3).HeaderText = "Descrption"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).HeaderText = "Payment Type"

            getTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotal()
        Try
            Dim max As Integer = dg1.Rows.Count - 1
            Dim tot As Integer = 0
            'getting the values of a specific rows


            For Each row As DataGridViewRow In dg1.Rows
                'formula for adding the values in the rows
                tot += row.Cells(2).Value
            Next

            lblTotal.Text = tot.ToString("C", New System.Globalization.CultureInfo("fil-PH"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class