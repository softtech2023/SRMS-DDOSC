Imports MySql.Data.MySqlClient
Public Class frmSelectStudeDrop
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub frmSelectStudeDrop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName, Course, YearLevel, Section, Sem, SY, Major from registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(1).HeaderText = "Last Name"
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).HeaderText = "Course"
            dg1.Columns(4).Width = 250
            dg1.Columns(5).HeaderText = "Yr. Level"
            dg1.Columns(5).Width = 50
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select StudentNumber, LastName, FirstName, MiddleName, Course, YearLevel, Section, Sem, SY, Major from registration where LastName like '%" & txtSearch.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by StudentNumber order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(1).HeaderText = "Last Name"
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).HeaderText = "Course"
            dg1.Columns(4).Width = 250
            dg1.Columns(5).HeaderText = "Yr. Level"
            dg1.Columns(5).Width = 50
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsemstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index

            frmDroppingForm.txtStudentNo.Text = dg1.Item(0, i).Value
            frmDroppingForm.txtLName.Text = dg1.Item(1, i).Value
            frmDroppingForm.txtFName.Text = dg1.Item(2, i).Value
            frmDroppingForm.txtMName.Text = dg1.Item(3, i).Value
            frmDroppingForm.txtCourse.Text = dg1.Item(4, i).Value

            frmDroppingForm.loadEnrolledSubjects()

            frmStudeGrades.txtStudentNo.Text = dg1.Item(0, i).Value
            frmStudeGrades.txtLName.Text = dg1.Item(1, i).Value
            frmStudeGrades.txtFName.Text = dg1.Item(2, i).Value
            frmStudeGrades.txtMName.Text = dg1.Item(3, i).Value

            frmStudeGrades.lblCourse.Text = dg1.Item(4, i).Value
            frmStudeGrades.lblMajor.Text = dg1.Item(9, i).Value

            frmStudeGrades.btnAdd.Enabled = True

            txtSearch.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class