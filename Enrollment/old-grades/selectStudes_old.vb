Imports MySql.Data.MySqlClient
Public Class frmSelectStudes
    Dim str As String
    Private Sub frmSelectStudes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select semstudentid, StudentNumber,concat (LName,', ', FName,' ', MName) as Name, Course, YearLevel from semesterstude where SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(3).HeaderText = "Course"
            dg1.Columns(4).HeaderText = "Year Level"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 200
            dg1.Columns(3).Width = 100
            dg1.Columns(4).Width = 80

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select semstudentid, StudentNumber,concat (LName,', ', FName,' ', MName) as Name, Course, YearLevel from semesterstude where StudentNumber like '%" & txtSearch.Text & "%' or LName like '%" & txtSearch.Text & "%' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by Name"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student No."
            dg1.Columns(2).HeaderText = "Name"
            dg1.Columns(3).HeaderText = "Course"
            dg1.Columns(4).HeaderText = "Year Level"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).Width = 200
            dg1.Columns(3).Width = 100
            dg1.Columns(4).Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgStudes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index

        i = dg1.CurrentRow.Index
        'frmLoanBooks.lblID.Text = dg1.Item(0, i).Value
        frmLoanBooks.txtStudentNo.Text = dg1.Item(1, i).Value
        frmLoanBooks.txtName.Text = dg1.Item(2, i).Value
        frmLoanBooks.txtCourse.Text = dg1.Item(3, i).Value
        frmLoanBooks.txtYearLevel.Text = dg1.Item(4, i).Value
        frmLoanBooks.btnselectbook.Enabled = True
        frmLoanBooks.tsSave.Enabled = False
        Me.Close()

    End Sub
End Class