Imports MySql.Data.MySqlClient
Public Class frmSelectSubtoAdd
    Dim str As String
  
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If chkSubjectCode.Checked = True Then
                str = "select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Slot>0"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Subject Code"
                dg1.Columns(2).HeaderText = "Description"
                dg1.Columns(2).Width = 150
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = True
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = True
                dg1.Columns(7).HeaderText = "Schedule"
                dg1.Columns(7).Width = 150
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = True
                dg1.Columns(9).HeaderText = "Remaining Slot"
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = True
                dg1.Columns(14).Visible = False
                dg1.Columns(15).Visible = False
                dg1.Columns(16).Visible = False
                dg1.Columns(17).Visible = False
                dg1.Columns(18).Visible = False
                dg1.Columns(19).Visible = False
                dg1.Columns(20).Visible = False
                dg1.Columns(21).Visible = False
                dg1.Columns(22).Visible = False
                dg1.Columns(23).Visible = False
                dg1.Columns(24).Visible = True
                dg1.Columns(25).Visible = True
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = True
                dg1.Columns(28).Visible = False
                dg1.Columns(29).Visible = False
            End If

            If chkDescription.Checked = True Then
                str = "select * from semsubjects where description like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Slot>0"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Subject Code"
                dg1.Columns(2).HeaderText = "Description"
                dg1.Columns(2).Width = 150
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = True
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = True
                dg1.Columns(9).HeaderText = "Remaining Slot"
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = True
                dg1.Columns(14).Visible = False
                dg1.Columns(15).Visible = False
                dg1.Columns(16).Visible = False
                dg1.Columns(17).Visible = False
                dg1.Columns(18).Visible = False
                dg1.Columns(19).Visible = False
                dg1.Columns(20).Visible = False
                dg1.Columns(21).Visible = False
                dg1.Columns(22).Visible = False
                dg1.Columns(23).Visible = False
                dg1.Columns(24).Visible = True
                dg1.Columns(25).Visible = True
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = True
                dg1.Columns(28).Visible = False
                dg1.Columns(29).Visible = False
            End If

            If chkSection.Checked = True Then
                str = "select * from semsubjects where Section like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Slot>0"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Subject Code"
                dg1.Columns(2).HeaderText = "Description"
                dg1.Columns(2).Width = 150
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = True
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = True
                dg1.Columns(9).HeaderText = "Remaining Slot"
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = True
                dg1.Columns(14).Visible = False
                dg1.Columns(15).Visible = False
                dg1.Columns(16).Visible = False
                dg1.Columns(17).Visible = False
                dg1.Columns(18).Visible = False
                dg1.Columns(19).Visible = False
                dg1.Columns(20).Visible = False
                dg1.Columns(21).Visible = False
                dg1.Columns(22).Visible = False
                dg1.Columns(23).Visible = False
                dg1.Columns(24).Visible = True
                dg1.Columns(25).Visible = True
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = True
                dg1.Columns(28).Visible = False
                dg1.Columns(29).Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSelectSubtoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSubjectCode.Checked = True
        Try
            str = "select * from semsubjects where SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Course='" & frmCOR.txtCourse.Text & "' and cMajor='" & frmCOR.txtMajor.Text & "' and YearLevel='" & frmCOR.txtYearLevel.Text & "' and Section='" & frmCOR.lblSection.Text & "' and Slot>0  order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Subject Code"
            dg1.Columns(2).HeaderText = "Description"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = True
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = True
            dg1.Columns(7).HeaderText = "Schedule"
            dg1.Columns(7).Width = 150
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = True
            dg1.Columns(9).HeaderText = "Remaining Slot"
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = True
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False
            dg1.Columns(18).Visible = False
            dg1.Columns(19).Visible = False
            dg1.Columns(20).Visible = False
            dg1.Columns(21).Visible = False
            dg1.Columns(22).Visible = False
            dg1.Columns(23).Visible = False
            dg1.Columns(24).Visible = True
            dg1.Columns(25).Visible = True
            dg1.Columns(26).Visible = False
            dg1.Columns(27).Visible = True
            dg1.Columns(28).Visible = False
            dg1.Columns(29).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index

            For x As Integer = 0 To frmAdding.lvCOR.Items.Count - 1
                If dg1.Item(1, i).Value = frmAdding.lvCOR.Items(x).SubItems(0).Text Then
                    MsgBox("Adding the same subject to the same student is not allowed!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If


            Next

            frmAdding.lblSubjectCode.Text = dg1.Item(1, i).Value
            frmAdding.lblDescription.Text = dg1.Item(2, i).Value
            frmAdding.lblSlot.Text = dg1.Item(9, i).Value


            frmAdding.getFinalSlot()


            AddSemSubjects(frmAdding.lvCOR, dg1.Item(1, i).Value, dg1.Item(2, i).Value, dg1.Item(7, i).Value, dg1.Item(6, i).Value, dg1.Item(8, i).Value, dg1.Item(5, i).Value, dg1.Item(3, i).Value, dg1.Item(4, i).Value, dg1.Item(13, i).Value, frmAdding.lblFinalSlot.Text, dg1.Item(28, i).Value, frmAdding.lblFinalSlot.Text)

            frmAdding.tsSave.Enabled = True
            frmAdding.btnRemoveSubjects.Enabled = True
            frmAdding.getTotalLecUnits()
            frmAdding.getTotalLabUnits()
            frmAdding.TotalUnits()
            frmAdding.newTotalUnits()
            frmAdding.getTotalLab()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
   
End Class