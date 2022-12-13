Imports MySql.Data.MySqlClient
Public Class frmSearchEnrollees
    Dim str As String

    Private Sub frmSearchEnrollees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoEnrolled.Checked = True
        rdo()
    End Sub
    Public Sub rdo()

        Try
            If rdoEnrolled.Checked = True Then
                str = "select * from semesterstude where Status='Enrolled' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Width = 250
                dg1.Columns(6).Visible = True
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False
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
                dg1.Columns(24).Visible = False
                dg1.Columns(25).Visible = False
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = False
                dg1.Columns(28).Visible = False
            Else
                str = "select * from semesterstude where Status='Dropped' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Width = 250
                dg1.Columns(6).Visible = True
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False
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
                dg1.Columns(24).Visible = False
                dg1.Columns(25).Visible = False
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = False
                dg1.Columns(28).Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            If rdoEnrolled.Checked = True Then
                str = "select * from semesterstude where LName like '%" & txtSearch.Text & "%' and Status='Enrolled' and  Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Width = 250
                dg1.Columns(6).Visible = True
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False
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
                dg1.Columns(24).Visible = False
                dg1.Columns(25).Visible = False
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = False
                dg1.Columns(28).Visible = False
            Else
                str = "select * from semesterstude where LName like '%" & txtSearch.Text & "%' and Status='Dropped' and  Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' order by LName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "semesterstude")
                dg1.DataSource = ds.Tables("semesterstude")
                conn.Close()
                dg1.Columns(0).Visible = False
                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(5).Width = 250
                dg1.Columns(6).Visible = True
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False
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
                dg1.Columns(24).Visible = False
                dg1.Columns(25).Visible = False
                dg1.Columns(26).Visible = False
                dg1.Columns(27).Visible = False
                dg1.Columns(28).Visible = False

            End If
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmSemStudent.lblID.Text = dg1(0, i).Value
            frmSemStudent.mskStudentNumber.Text = dg1(1, i).Value
            frmUpdateScholarship.mskStudentNumber.Text = dg1.Item(1, i).Value
            frmSemStudent.txtFname.Text = dg1(2, i).Value
            frmUpdateScholarship.txtFName.Text = dg1.Item(2, i).Value
            frmSemStudent.txtMName.Text = dg1(3, i).Value
            frmUpdateScholarship.txtMName.Text = dg1.Item(3, i).Value
            frmSemStudent.txtLastName.Text = dg1(4, i).Value
            frmUpdateScholarship.txtLName.Text = dg1.Item(4, i).Value
            frmSemStudent.cboCourse.Text = dg1(5, i).Value
            frmSemStudent.cboYear.Text = dg1(6, i).Value
            frmSemStudent.cboStatus.Text = dg1(7, i).Value
            frmSemStudent.cboSection.Text = dg1(11, i).Value
            frmSemStudent.cboStudeStatus.Text = dg1(12, i).Value
            frmSemStudent.cboScholarship.Text = dg1(13, i).Value
            frmUpdateScholarship.cboScholarship.Text = dg1.Item(13, i).Value
            frmSemStudent.mskFrom.Text = dg1(14, i).Value
            frmSemStudent.mskTo.Text = dg1(15, i).Value
            frmSemStudent.mskAssessmentDate.Text = dg1(16, i).Value
            frmSemStudent.cboAssessmentResult.Text = dg1(17, i).Value
            frmSemStudent.cboAccountStatus.Text = dg1(18, i).Value
            frmSemStudent.cboYearStat.Text = dg1(20, i).Value
            frmSemStudent.txtGrantAmount.Text = dg1(19, i).Value
            frmSemStudent.cboYearStat.Text = dg1(20, i).Value
            frmSemStudent.cboMajor.Text = dg1(21, i).Value
            frmSemStudent.cboCrossEnrollee.Text = dg1.Item(24, i).Value
            frmSemStudent.cboSession.Text = dg1.Item(25, i).Value
            frmSemStudent.txtPrevGPA.Text = dg1.Item(26, i).Value
            frmSemStudent.txtSchool.Text = dg1.Item(27, i).Value
            frmSemStudent.txtSchoolAddress.Text = dg1.Item(28, i).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        If rdoEnrolled.Checked = True Then
            frmSemStudent.tsSave.Enabled = False
            frmSemStudent.tsUpdate.Enabled = True
            frmSemStudent.tsDelete.Enabled = True
            frmSemStudent.tsDrop.Enabled = True
        Else
            frmSemStudent.tsSave.Enabled = False
            frmSemStudent.tsUpdate.Enabled = True
            frmSemStudent.tsDelete.Enabled = True
            frmSemStudent.tsDrop.Enabled = True
            frmSemStudent.tsDrop.Text = "Enroll"
        End If

        

        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rdoEnrolled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoEnrolled.CheckedChanged
        rdo()
    End Sub

    Private Sub rdoDropped_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDropped.CheckedChanged
        rdo()
    End Sub
End Class