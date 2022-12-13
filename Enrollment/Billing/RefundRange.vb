Imports MySql.Data.MySqlClient
Public Class frmrefundrange
    Dim str As String

    Private Sub frmrefundrange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Try

            str = "SELECT r.refundID, r.StudentNumber, r.FirstName, r.MiddleName, r.LastName, r.Amount, r.DateRefunded, r.Sem, r.SY, r.DebitMemo, r.DateRequest, st.letterHead FROM refund r join srms_settings st on  st.settingsID = r.settingsID  where r.DateRefunded>='" & Convert.ToDateTime(dtpFrom.Text).ToString("yyyy-MM-dd") & "' and r.DateRefunded<='" & Convert.ToDateTime(dtpTo.Text).ToString("yyyy-MM-dd") & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "refund, srms_settings")
            Dim obj As New RefundSummary
            obj.SetDataSource(mysds.Tables("refund, srms_settings"))
            obj.SetParameterValue("DateFrom", dtpFrom.Text)
            obj.SetParameterValue("DateTo", dtpTo.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class