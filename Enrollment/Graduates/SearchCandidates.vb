Imports MySql.Data.MySqlClient
Public Class frmSearchCandidates
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSearchCandidates_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmListCandidates.preview()
    End Sub

    Private Sub frmSearchCandidates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT * FROM semesterstude where Course='" & frmListCandidates.cboCourse.Text & "' and Major='" & frmListCandidates.cboMajor.Text & "' and YearLevel='4th' and SY='" & frmParent.lblSY.Text & "'group by StudentNumber order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dglist.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dglist.Columns(0).Visible = False
            dglist.Columns(1).HeaderText = "Student No."
            dglist.Columns(1).Width = 120
            dglist.Columns(2).HeaderText = "First Name"
            dglist.Columns(2).Width = 190
            dglist.Columns(3).HeaderText = "Middle Name"
            dglist.Columns(3).Width = 170
            dglist.Columns(4).HeaderText = "Last Name"
            dglist.Columns(4).Width = 205
            dglist.Columns(5).Visible = False
            dglist.Columns(6).Visible = False
            dglist.Columns(7).Visible = False
            dglist.Columns(8).Visible = False
            dglist.Columns(9).Visible = False
            dglist.Columns(10).Visible = False
            dglist.Columns(11).Visible = False
            dglist.Columns(12).Visible = False
            dglist.Columns(13).Visible = False
            dglist.Columns(14).Visible = False
            dglist.Columns(15).Visible = False
            dglist.Columns(16).Visible = False
            dglist.Columns(17).Visible = False
            dglist.Columns(18).Visible = False
            dglist.Columns(19).Visible = False
            dglist.Columns(20).Visible = False
            dglist.Columns(21).Visible = False
            dglist.Columns(22).Visible = False
            dglist.Columns(23).Visible = False
            dglist.Columns(24).Visible = False
            dglist.Columns(25).Visible = False
            dglist.Columns(26).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT * FROM semesterstude where LName like '%" & txtSearch.Text & "%' and Course='" & frmListCandidates.cboCourse.Text & "' and Major='" & frmListCandidates.cboMajor.Text & "' and YearLevel='4th' and SY='" & frmParent.lblSY.Text & "'group by StudentNumber order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dglist.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dglist.Columns(0).Visible = False
            dglist.Columns(1).HeaderText = "Student No."
            dglist.Columns(1).Width = 120
            dglist.Columns(2).HeaderText = "First Name"
            dglist.Columns(2).Width = 190
            dglist.Columns(3).HeaderText = "Middle Name"
            dglist.Columns(3).Width = 170
            dglist.Columns(4).HeaderText = "Last Name"
            dglist.Columns(4).Width = 205
            dglist.Columns(5).Visible = False
            dglist.Columns(6).Visible = False
            dglist.Columns(7).Visible = False
            dglist.Columns(8).Visible = False
            dglist.Columns(9).Visible = False
            dglist.Columns(10).Visible = False
            dglist.Columns(11).Visible = False
            dglist.Columns(12).Visible = False
            dglist.Columns(13).Visible = False
            dglist.Columns(14).Visible = False
            dglist.Columns(15).Visible = False
            dglist.Columns(16).Visible = False
            dglist.Columns(17).Visible = False
            dglist.Columns(18).Visible = False
            dglist.Columns(19).Visible = False
            dglist.Columns(20).Visible = False
            dglist.Columns(21).Visible = False
            dglist.Columns(22).Visible = False
            dglist.Columns(23).Visible = False
            dglist.Columns(24).Visible = False
            dglist.Columns(25).Visible = False
            dglist.Columns(26).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub dglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dglist.DoubleClick
        Try
            Dim i As Integer
            i = dglist.CurrentRow.Index

            str = "select * from  gradcandidates where Course='" & frmListCandidates.cboCourse.Text & "' and Major='" & frmListCandidates.cboMajor.Text & "' and SY='" & frmParent.lblSY.Text & "' and StudentNumber='" & dglist.Item(1, i).Value & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gradcandidates")
            If ds.Tables("gradcandidates").Rows.Count >= 1 Then
              
                MsgBox("Duplicate records found!", MsgBoxStyle.Exclamation)
                Exit Sub
                'kung wala nag exist
            Else

                str = "insert into gradcandidates values('0','" & dglist.Item(1, i).Value & "','" & dglist.Item(5, i).Value & "','" & dglist.Item(21, i).Value & "','" & dglist.Item(9, i).Value & "')"
                conn1.Open()
                Dim mysC2 As New MySqlCommand(str, conn1)
                mysC2.ExecuteNonQuery()
                conn1.Close()

                ' str = "update users set position='Alumni' where username='" & dglist.Item(1, x).Value & "'"
                ' conn1.Open()
                'Dim mysC3 As New MySqlCommand(str, conn1)
                'mysC3.ExecuteNonQuery()
                ' conn1.Close()
                MsgBox("Saved successfully!", MsgBoxStyle.Information)
                conn1.Close()
                '

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
    End Sub
End Class