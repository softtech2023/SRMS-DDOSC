Public Class frmAdditionalLabFee

    Public Sub getNewLabFee()
        Dim NewLabFee As Double
        NewLabFee = (Val(txtAdditionalUnits.Text) * Val(lblLabFeeRate.Text)) + Val(lblCurrentLabFee.Text)
        txtNewLabTotal.Text = NewLabFee
    End Sub

    Private Sub txtAdditionalUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditionalUnits.TextChanged
        getNewLabFee()
    End Sub

    Private Sub lblCurrentLabFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCurrentLabFee.TextChanged
        getNewLabFee()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmBilling.lvAccts.Items.Add("Laboratory Fee") '
        frmBilling.lvAccts.Items(frmBilling.lvAccts.Items.Count - 1).SubItems.Add(txtNewLabTotal.Text)
        frmBilling.lvAccts.Items(frmBilling.lvAccts.Items.Count - 1).SubItems.Add("Other Fees")

        frmBilling.txtLab.Text = txtNewLabTotal.Text
        frmBilling.getSubTotals()
        frmBilling.btnCompute.PerformClick()

    End Sub


    Private Sub frmAdditionalLabFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim labfee As Double
        labfee = (Val(frmBilling.txtTotalLabUnits.Text) * Val(frmBilling.txtLabRate.Text)) + (Val(frmBilling.txtTotalLabUnitsNight.Text) * Val(frmBilling.txtLabRateNight.Text))
        lblCurrentLabFee.Text = Format(labfee, "00.00")
    End Sub
End Class