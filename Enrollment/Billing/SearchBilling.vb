Imports MySql.Data.MySqlClient
Public Class frmSearchBilling
    Dim str As String

    Private Sub frmSearchBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            str = "select * from studeaccount where SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "' group by StudentNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount")
            dg1.DataSource = ds.Tables("studeaccount")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Course"
            dg1.Columns(5).Width = 250

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
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False
            dg1.Columns(33).Visible = False
            dg1.Columns(36).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from studeaccount where StudentNumber like '%" & txtSearch.Text & "%' or LastName like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeaccount")
            dg1.DataSource = ds.Tables("studeaccount")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Course"
            dg1.Columns(5).Width = 250

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
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = False
            dg1.Columns(25).Visible = False
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = False
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
            dg1.Columns(30).Visible = False
            dg1.Columns(31).Visible = False
            dg1.Columns(32).Visible = False
            dg1.Columns(33).Visible = False
            dg1.Columns(36).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
           
            Dim n As Integer
            n = dg1.CurrentRow.Index

            frmBilling.lblID.Text = dg1.Item(0, n).Value
            frmBilling.mskStudentNumber.Text = dg1.Item(1, n).Value
            frmBilling.txtFname.Text = dg1.Item(2, n).Value
            frmBilling.txtMName.Text = dg1.Item(3, n).Value
            frmBilling.txtLastName.Text = dg1.Item(4, n).Value
            frmBilling.cboCourse.Text = dg1.Item(5, n).Value
            frmBilling.cboYear.Text = dg1.Item(6, n).Value
            frmBilling.txtTotalLecUnits.Text = dg1.Item(7, n).Value
            frmBilling.txtLecRate.Text = dg1.Item(8, n).Value
            frmBilling.txtTotalLecDay.Text = dg1.Item(9, n).Value
            frmBilling.txtTotalLabUnits.Text = dg1.Item(10, n).Value
            frmBilling.txtLabRate.Text = dg1.Item(11, n).Value
            frmBilling.txtTotalLabDay.Text = dg1.Item(12, n).Value
            frmBilling.txtOldAccount.Text = dg1.Item(13, n).Value
            frmBilling.txtTotalFees.Text = dg1.Item(17, n).Value
            frmBilling.txtDiscount.Text = dg1.Item(18, n).Value
            frmBilling.txtTotalAcct.Text = dg1.Item(19, n).Value
            frmBilling.txtPayments.Text = dg1.Item(19, n).Value
            frmBilling.txtBalance.Text = dg1.Item(21, n).Value
            frmBilling.txtSection.Text = dg1.Item(24, n).Value

            frmBilling.txtTotalLecDay.Text = dg1.Item(26, n).Value
            frmBilling.txtTotalLabDay.Text = dg1.Item(27, n).Value
            frmBilling.txtTotalLecNight.Text = dg1.Item(28, n).Value
            frmBilling.txtTotalLabNight.Text = dg1.Item(29, n).Value
            frmBilling.txtTotalLecNight.Text = dg1.Item(30, n).Value
            frmBilling.txtLecRateNight.Text = dg1.Item(31, n).Value
            frmBilling.txtTotalLabNight.Text = dg1.Item(32, n).Value
            frmBilling.txtLabRateNight.Text = dg1.Item(33, n).Value
            frmBilling.txtTuition.Text = dg1.Item(34, n).Value
            frmBilling.txtLab.Text = dg1.Item(35, n).Value
            frmBilling.txtSpecialTuition.Text = dg1.Item(36, n).Value

            Dim totalpayment As Double

            str = "select * from paymentsaccounts where StudentNumber='" & frmBilling.mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(8))
            End While

            frmBilling.txtPayments.Text = totalpayment
            mysDR.Close()
            conn.Close()

            frmBilling.btnPayment.Enabled = True
            frmBilling.btnPaymentHistory.Enabled = True
            'frmBilling.btnPrintLedger.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmBilling.tsSave.Enabled = False
        frmBilling.tsUpdate.Enabled = True
        frmBilling.tsDelete.Enabled = True
        frmBilling.tsNew.Enabled = True
        frmBilling.btnOldAcct.Enabled = True
        frmBilling.btnLoadUpdatedFees.Enabled = True
        frmBilling.LoadAcct()
        txtSearch.Clear()

        frmBilling.btnOldAcct.Enabled = False
        frmBilling.specialLabFee()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class