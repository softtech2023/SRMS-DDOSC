Imports MySql.Data.MySqlClient
Public Class frmCollectionDashboard
    Dim str As String
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try

            If cboSource.Text = "" Then
                MsgBox("Please enter collection source", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboPaymentMode.Text = "" Then
                MsgBox("Please select payment mode!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboSource.SelectedIndex = 0 And cboPaymentMode.SelectedIndex = 0 Then

                str = "SELECT * from paymentsaccounts where PDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and PDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' and ORStatus='" & lblORStatus.Text & "' order by ORNumber"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "paymentsaccounts")
                Dim obj As New DailyCollections
                obj.SetDataSource(ds.Tables("paymentsaccounts"))
                obj.SetParameterValue("dtpFrom", dtpFrom.Text)
                obj.SetParameterValue("dtpTo", dtpTo.Text)
                obj.SetParameterValue("name", frmParent.lblName.Text)
                'obj.SetParameterValue("preparedby", frmParent.lblName.Text)
                frmMainViewer.ReportViewer.ReportSource = obj
                frmMainViewer.ReportViewer.Refresh()
                conn.Close()
                frmMainViewer.MdiParent = frmParent
                frmMainViewer.Show()
                Me.Hide()

            Else
                Dim paymentSource As String
                paymentSource = cboSource.Text.Replace("'", "''")

                str = "SELECT * FROM paymentsaccounts where PDate>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and PDate<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "' and ORStatus='" & lblORStatus.Text & "' and CollectionSource='" & paymentSource & "' and PaymentType='" & cboPaymentMode.Text & "' order by ORNumber"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "paymentsaccounts")
                Dim obj As New DailyCollections
                obj.SetDataSource(ds.Tables("paymentsaccounts"))
                obj.SetParameterValue("dtpFrom", dtpFrom.Text)
                obj.SetParameterValue("dtpTo", dtpTo.Text)
                'obj.SetParameterValue("preparedby", frmParent.lblName.Text)
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
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class