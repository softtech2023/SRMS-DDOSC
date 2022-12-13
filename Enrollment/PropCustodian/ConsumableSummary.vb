Imports MySql.Data.MySqlClient
Public Class frmConsumableSummary
    Dim str As String

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchEmployeeName.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try

            str = "select d.distID, d.transactionNo, d.transactionDate, d.productCode, d.description, d.qty, d.itemName, concat (d.FirstName,' ',d.LastName) as EmployeeName, d.IDNumber, st.letterHead from ls_distribution d join srms_settings st on d.settingsID = st.settingsID where IDNumber = '" & lblEmployeeNo.Text & "' order by transactionDate desc"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_distribution, srms_settings")
            Dim obj As New CSEmployeeReport
            obj.SetDataSource(mysds.Tables("ls_distribution, srms_settings"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = frmParent
            frmReportViewer.Show()
            Me.Close()





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmConsumableSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnPreview.Enabled = False
    End Sub
End Class