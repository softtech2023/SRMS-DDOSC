Imports MySql.Data.MySqlClient
Public Class frmMRDashboard
    Dim str As String
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchPersonnel2.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try

            str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.serialNo, i.model, i.notes, i.qty, i.unit, i.acquiredDate, concat(s.FirstName,' ',s.MiddleName,' ',s.LastName) as Accountable, s.empPosition, s.Department, st.SchoolName, st.SchoolAddress, st.PropertyCustodian, st.letterHead from ls_items i join staff s on i.IDNumber=s.IDNumber join srms_settings st on i.settingsID=st.settingsID where s.IDNumber='" & lblIDNumber.Text & "' and i.acquiredDate='" & Convert.ToDateTime(cboAcquiredate.Text).ToString("yyyy-MM-dd") & "' order by i.itemName, i.description"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "ls_items, staff, srms_settings")
            Dim obj As New MR
            obj.SetDataSource(mysds.Tables("ls_items, staff, srms_settings"))
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

    Public Sub getAcquireDate()
        Try
            str = "select * from ls_items where IDNumber='" & lblIDNumber.Text & "' group by acquiredDate"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "ls_items")

            cboAcquiredate.ValueMember = "ls_items"
            cboAcquiredate.DisplayMember = "acquiredDate"
            cboAcquiredate.DataSource = ds.Tables("ls_items")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtAccountable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountable.TextChanged
        getAcquireDate()
    End Sub

    Private Sub lblIDNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIDNumber.Click
        'getAcquireDate()
    End Sub
End Class