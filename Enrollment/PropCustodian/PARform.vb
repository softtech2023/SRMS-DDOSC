Imports MySql.Data.MySqlClient
Public Class frmPARform
    Dim str As String
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchAccountable.ShowDialog()
    End Sub
    Public Sub formload()
        btnPreview.Enabled = False

        txtAccountable.Clear()
        cboTransNo.ResetText()
        lblIDNumber.Text = ""
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try

            str = "select d.distID, d.transactionNo, d.transactionDate, d.productCode, d.description, d.qty, d.itemName, concat (d.FirstName,' ',d.LastName) as EmployeeName, d.IDNumber, st.letterHead from ls_distribution d join srms_settings st on d.settingsID = st.settingsID where transactionNo = '" & cboTransNo.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_distribution, srms_settings")
            Dim obj As New acknowledgementreceipt
            obj.SetDataSource(mysds.Tables("ls_distribution, srms_settings"))
            frmReportViewer.CRViewer.ReportSource = obj
            conn.Close()
            frmReportViewer.MdiParent = frmParent
            frmReportViewer.Show()
            Me.Close()

            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getTransactionNo()
        Try
            str = "select * from ls_distribution where IDNumber = '" & lblIDNumber.Text & "'  group by transactionNo"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_distribution")

            cboTransNo.ValueMember = "ls_distribution"
            cboTransNo.DisplayMember = "transactionNo"
            cboTransNo.DataSource = ds.Tables("ls_distribution")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub txtAccountable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountable.TextChanged
        getTransactionNo()
    End Sub

    Private Sub frmPARform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnPreview.Enabled = False
        txtAccountable.Clear()
    End Sub

    Private Sub lblIDNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIDNumber.Click

    End Sub
End Class