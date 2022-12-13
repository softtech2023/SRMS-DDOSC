Imports MySql.Data.MySqlClient
Public Class frmAccountable
    Dim str As String

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmSearchPersonnel2.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If rdoAll.Checked = True Then
                str = "SELECT i.ctrlNo, i.itemName, i.description, i.itemCondition, i.accountable, i.serialNo, i.model, i.acquiredDate, ss.SchoolName, ss.SchoolAddress, ss.letterHead, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian, st.empPosition FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID join staff st on i.IDNumber=st.IDNumber where accountable='" & txtAccountable.Text & "' order by itemName, description, serialNo"
                'conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "ls_items, staff, srms_settings")
                Dim obj As New accountablereport
                obj.SetDataSource(mysds.Tables("ls_items, staff, srms_settings"))
                frmReportViewer.CRViewer.ReportSource = obj
                conn.Close()
                frmReportViewer.MdiParent = frmParent
                frmReportViewer.Show()
                Me.Close()
            Else
                str = "SELECT i.itemName, sum(i.qty) as itemCounts, i.settingsID, i.accountable, ss.SchoolName, ss.SchoolAddress, ss.letterHead, ss.SchoolHead, ss.sHeadPosition, ss.PropertyCustodian, st.empPosition FROM ls_items i join srms_settings ss on i.settingsID=ss.settingsID join staff st on i.IDNumber=st.IDNumber where accountable='" & txtAccountable.Text & "' group by itemName order by itemName "
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "ls_items, staff, srms_settings")
                Dim obj As New CSummaryReport
                obj.SetDataSource(mysds.Tables("ls_items, staff, srms_settings"))
                frmReportViewer.CRViewer.ReportSource = obj
                conn.Close()
                frmReportViewer.MdiParent = frmParent
                frmReportViewer.Show()
                Me.Close()
            End If
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAccountable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class