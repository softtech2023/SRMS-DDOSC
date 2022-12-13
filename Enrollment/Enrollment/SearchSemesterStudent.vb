Imports MySql.Data.MySqlClient
Public Class frmSearchSemesterStudent
    Dim str As String

    Private Sub frmSearchSemesterStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reports2.sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.Reports2.sections)
        Try
            str = "select * from semesterstude where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            'str = "select semstudentid, StudentNumber, FName, LName, Course, YearLevel, Status, Semester, SY, Term from semesterstude where Semester='" & Me.lblSem.Text & "' and SY='" & Me.lblSY.Text & "' and Term='" & Me.lblTerm.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(5).Width = 250
            dg1.Columns(6).Width = 60

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semesterstude where LName like '%" & txtSearch.Text & "%' and Semester like '%" & frmParent.lblSem.Text & "%' and SY like '%" & frmParent.lblSY.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsemstudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmCOR.mskStudentNumber.Text = dg1(1, i).Value
            frmCOR.txtFirstName.Text = dg1(2, i).Value
            frmCOR.txtMiddleName.Text = dg1(3, i).Value
            frmCOR.txtLastName.Text = dg1(4, i).Value
            frmCOR.txtCourse.Text = dg1(5, i).Value
            frmCOR.txtYearLevel.Text = dg1(6, i).Value
            frmCOR.lblSection.Text = dg1(11, i).Value
            frmCOR.txtMajor.Text = dg1(21, i).Value
            frmCOR.lblYearLevelStat.Text = dg1.Item(20, i).Value


            frmCOR.btnAddSubject.Enabled = True
            frmCOR.tsSave.Enabled = True
            frmCOR.tsUpdate.Enabled = True
            frmCOR.btnAddSubject.Enabled = True
            frmCOR.btnRemoveSubjects.Enabled = True

            'frmCOR.LoadSubjects()
            frmCOR.getTotalLecUnits()
            frmCOR.getTotalLabUnits()
            frmCOR.TotalUnits()
            frmCOR.getCourseShortName()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class