Imports MySql.Data.MySqlClient
Public Class frmCollectionSummaryDashboard
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboCashier.Text = "" Then

                str = "SELECT PDate, ORNumber, Amount, StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as Payor, Cashier, ORStatus, ID FROM paymentsaccounts where ORStatus='Valid' and PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'order by ORNumber desc"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "paymentsaccounts")
                Dim obj As New CollectionsSummary
                obj.SetDataSource(mysds.Tables("paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            Else

                str = "SELECT PDate, ORNumber, Amount, StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as Payor, Cashier, ORStatus, ID FROM paymentsaccounts where ORStatus='Valid' and PDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and PDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' and Cashier='" & cboCashier.Text & "' order by ORNumber desc"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "paymentsaccounts")
                Dim obj As New CollectionSummaryPerCashier
                obj.SetDataSource(mysds.Tables("paymentsaccounts"))
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

   
    Private Sub frmCollectionSummaryDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.cashierAcct' table. You can move, or remove it, as needed.
        Me.CashierAcctTableAdapter.Fill(Me.DataSet2.cashierAcct)

    End Sub
End Class