Imports MySql.Data.MySqlClient
Public Class frmGS_Select_Subject
    Dim str As String
    Private Sub frmGS_Select_Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, LecUnit, LabUnit, Section, Sem, SY from registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frmPrintGradingSheet.txtInstructor.Text & "' group by Section, SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()
            dg1.Columns(0).HeaderText = "Subject Code"
            dg1.Columns(0).Width = 80
            dg1.Columns(1).Width = 250
            dg1.Columns(2).Visible = False
            dg1.Columns(2).Width = 70
            dg1.Columns(3).Visible = False

            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        frmPrintGradingSheet.txtsubjectcode.Text = dg1.Item(0, i).Value
        frmPrintGradingSheet.txtDescription.Text = dg1.Item(1, i).Value
        frmPrintGradingSheet.txtSection.Text = dg1.Item(4, i).Value

        Me.Close()
    End Sub


End Class