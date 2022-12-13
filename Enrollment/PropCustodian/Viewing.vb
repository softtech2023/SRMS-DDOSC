Imports MySql.Data.MySqlClient
Public Class frmViewing
    Dim str As String
    
    Public Sub itemDetails()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from ls_items where ctrlNo='" & txtCtrlNo.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtItemName.Text = dtReader.Item(2)
                txtDescription.Text = dtReader.Item(3)
                txtQty.Text = dtReader.Item(4)
                txtUnit.Text = dtReader.Item(5)
                txtBrand.Text = dtReader.Item(6)
                txtModel.Text = dtReader.Item(7)
                txtSerialNo.Text = dtReader.Item(8)
                txtCapacity.Text = dtReader.Item(9)
                txtCondition.Text = dtReader.Item(10)
                txtCategory.Text = dtReader.Item(17)
                txtsubCategory.Text = dtReader.Item(18)
                txtAccountable.Text = dtReader.Item(11)
                txtAcquireDate.Text = dtReader.Item(13)
                txtProcessDate.Text = dtReader.Item(19)
                txtPPrice.Text = dtReader.Item(14)
                txtShortage.Text = dtReader.Item(20)
                txtShortageValue.Text = dtReader.Item(21)
                txtBrand.Text = dtReader.Item(6)
                txtModel.Text = dtReader.Item(7)
                txtSerialNo.Text = dtReader.Item(8)
                txtCapacity.Text = dtReader.Item(9)
                txtNotes.Text = dtReader.Item(15)

                getTotalPrice()

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub txtCtrlNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtrlNo.TextChanged
        itemDetails()
    End Sub
    Public Sub getTotalPrice()
        Dim total As Double
        total = Val(txtQty.Text) * Val(txtPPrice.Text)
        txtTotalPrice.Text = total
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        txtCtrlNo.Clear()
        txtItemName.Clear()
        txtDescription.Clear()
        txtQty.Clear()
        txtUnit.Clear()
        txtBrand.Clear()
        txtModel.Clear()
        txtSerialNo.Clear()
        txtCapacity.Clear()
        txtCondition.Clear()
        txtCategory.Clear()
        txtAcquireDate.Clear()
        txtShortage.Clear()
        txtShortageValue.Clear()
        txtAccountable.Clear()
        txtNotes.Clear()
        txtPPrice.Clear()
        txtProcessDate.Clear()
        txtsubCategory.Clear()
        txtTotalPrice.Clear()

        txtCtrlNo.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class