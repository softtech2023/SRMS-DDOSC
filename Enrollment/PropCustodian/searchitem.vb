Imports MySql.Data.MySqlClient
Public Class frmsearchitem
    Dim str As String
    Public Sub Formload()
        Try
            str = "Select * from ls_consumables where QtyDelivered >0 order by ProductName"
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_consumables")
            dg1.DataSource = ds.Tables("ls_consumables")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Product Code"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "Product Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Description"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            'dg1.Columns(3).HeaderText = "Brand"

            txtqty.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub searchitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formload()
    End Sub

    Private Sub txtsearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "select * from ls_consumables where ProductCode like '%" & txtsearch.Text & "%' or ProductName like '%" & txtsearch.Text & "%' or ProductDescription like '%" & txtsearch.Text & "%' order by ProductName "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_consumables")
            dg1.DataSource = ds.Tables("ls_consumables")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            Dim remainItem As Double

            i = dg1.CurrentRow.Index

            i = dg1.CurrentRow.Index

            For x As Integer = 0 To frmDistribution.lvPOS.Items.Count - 1
                If dg1.Item(1, i).Value = frmDistribution.lvPOS.Items(x).SubItems(0).Text Then
                    MsgBox("Items already added!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next


            remainItem = Val(dg1.Item(4, i).Value) - Val(txtqty.Text)

            frmDistribution.lvPOS.Items.Add(dg1.Item(1, i).Value)  'product Code
            frmDistribution.lvPOS.Items(frmDistribution.lvPOS.Items.Count - 1).SubItems.Add(dg1.Item(2, i).Value) 'ItemName
            frmDistribution.lvPOS.Items(frmDistribution.lvPOS.Items.Count - 1).SubItems.Add(dg1.Item(3, i).Value) 'Description
            frmDistribution.lvPOS.Items(frmDistribution.lvPOS.Items.Count - 1).SubItems.Add(txtqty.Text) 'QTY
            frmDistribution.lvPOS.Items(frmDistribution.lvPOS.Items.Count - 1).SubItems.Add(remainItem)

            frmDistribution.txtProductCode.Focus()
            frmDistribution.btnSelectEmployee.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class