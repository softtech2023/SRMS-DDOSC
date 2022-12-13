Imports MySql.Data.MySqlClient
Public Class frmSearchStudents
    Dim str As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If rdoLocal.Checked = True Then
                str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dg1.DataSource = ds.Tables("studeprofile")
                conn.Close()

                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(0).Width = 130
                dg1.Columns(1).HeaderText = "First Name"
                dg1.Columns(1).Width = 130
                dg1.Columns(2).HeaderText = "Middle Name"
                dg1.Columns(2).Width = 130
                dg1.Columns(3).HeaderText = "Last Name"
                dg1.Columns(3).Width = 130

                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = False
                dg1.Columns(6).Visible = False
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
                dg1.Columns(29).Visible = False
                dg1.Columns(30).Visible = False
                dg1.Columns(31).Visible = False
                dg1.Columns(32).Visible = False
                dg1.Columns(33).Visible = False
                dg1.Columns(34).Visible = False
                dg1.Columns(35).Visible = False
                dg1.Columns(36).Visible = False
                dg1.Columns(37).Visible = False
                dg1.Columns(38).Visible = False
                dg1.Columns(39).Visible = False
                dg1.Columns(40).Visible = False
                dg1.Columns(41).Visible = False
                dg1.Columns(42).Visible = False
                dg1.Columns(43).Visible = False
                dg1.Columns(44).Visible = False
                dg1.Columns(45).Visible = False
                dg1.Columns(46).Visible = False
                dg1.Columns(47).Visible = False
                dg1.Columns(48).Visible = False
                dg1.Columns(49).Visible = False
                dg1.Columns(50).Visible = False
                dg1.Columns(51).Visible = False
                dg1.Columns(52).Visible = False
                dg1.Columns(53).Visible = False
                dg1.Columns(54).Visible = False
                dg1.Columns(55).Visible = False
                dg1.Columns(56).Visible = False
                dg1.Columns(57).Visible = False
                dg1.Columns(58).Visible = False
                dg1.Columns(59).Visible = False
                dg1.Columns(60).Visible = False
                dg1.Columns(61).Visible = False
                dg1.Columns(62).Visible = False
                dg1.Columns(63).Visible = False
                dg1.Columns(64).Visible = False
                dg1.Columns(65).Visible = False
                dg1.Columns(66).Visible = False
                dg1.Columns(67).Visible = False
                dg1.Columns(68).Visible = False
                dg1.Columns(69).Visible = False
                dg1.Columns(70).Visible = False
                dg1.Columns(71).Visible = False
                dg1.Columns(72).Visible = False
                dg1.Columns(73).Visible = False
                dg1.Columns(74).Visible = False
                dg1.Columns(75).Visible = False
                dg1.Columns(76).Visible = False
                dg1.Columns(77).Visible = False
                dg1.Columns(78).Visible = False
                dg1.Columns(79).Visible = False
                dg1.Columns(80).Visible = False
                dg1.Columns(81).Visible = False
                dg1.Columns(82).Visible = False
                dg1.Columns(83).Visible = False
                dg1.Columns(84).Visible = False
                dg1.Columns(85).Visible = False
                dg1.Columns(86).Visible = False
                dg1.Columns(87).Visible = False
                dg1.Columns(88).Visible = False
                dg1.Columns(89).Visible = False
                dg1.Columns(90).Visible = False
                dg1.Columns(91).Visible = False
                dg1.Columns(92).Visible = False
                ' dg1.Columns(93).Visible = False

            Else
                str = "select * from online_enrollment where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and enrolStatus='For Validation' and LastName like '%" & txtSearch.Text & "%'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "online_enrollment")
                dg1.DataSource = ds.Tables("online_enrollment")
                conn.Close()

                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(1).Width = 130
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(2).Width = 130
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(3).Width = 130
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(4).Width = 130
                dg1.Columns(5).HeaderText = "Course"
                dg1.Columns(5).Width = 130

                dg1.Columns(6).HeaderText = "Major"
                dg1.Columns(6).Width = 130

                dg1.Columns(7).HeaderText = "Year Level"
                dg1.Columns(7).Width = 80

                dg1.Columns(0).Visible = False
                dg1.Columns(5).Visible = False
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            If rdoLocal.Checked = True Then
                Dim dclick As Integer

                dclick = dg1.CurrentRow.Index
                frmSemStudent.Reload()
                frmSemStudent.mskStudentNumber.Text = dg1.Item(0, dclick).Value
                frmSemStudent.txtFname.Text = dg1.Item(1, dclick).Value
                frmSemStudent.txtMName.Text = dg1.Item(2, dclick).Value
                frmSemStudent.txtLastName.Text = dg1.Item(3, dclick).Value
                frmSemStudent.cboScholarship.Text = dg1.Item(43, dclick).Value
                Me.Close()
                frmSemStudent.Show()
                frmSemStudent.tsSave.Enabled = True
                frmSemStudent.tsUpdate.Enabled = False
                frmSemStudent.tsDelete.Enabled = False

                frmSemStudent.getCourse()

            Else
                Dim dclick As Integer
                frmSemStudent.getCourse()

                dclick = dg1.CurrentRow.Index
                frmSemStudent.Reload()
                frmSemStudent.mskStudentNumber.Text = dg1.Item(1, dclick).Value
                frmSemStudent.txtFname.Text = dg1.Item(2, dclick).Value
                frmSemStudent.txtMName.Text = dg1.Item(3, dclick).Value
                frmSemStudent.txtLastName.Text = dg1.Item(4, dclick).Value
                frmSemStudent.cboCourse.Text = dg1.Item(5, dclick).Value
                frmSemStudent.cboMajor.Text = dg1.Item(6, dclick).Value
                frmSemStudent.cboYear.Text = dg1.Item(7, dclick).Value
                Me.Close()
                frmSemStudent.Show()
                frmSemStudent.tsSave.Enabled = True
                frmSemStudent.tsUpdate.Enabled = False
                frmSemStudent.tsDelete.Enabled = False


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSearchStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoLocal.Checked = True

        txtSearch.Clear()
        txtSearch.Focus()
        loadRecords()


    End Sub
    Public Sub loadRecords()
        Try
            If rdoLocal.Checked = True Then
                str = "select * from studeprofile"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dg1.DataSource = ds.Tables("studeprofile")
                conn.Close()

                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(0).Width = 130
                dg1.Columns(1).HeaderText = "First Name"
                dg1.Columns(1).Width = 130
                dg1.Columns(2).HeaderText = "Middle Name"
                dg1.Columns(2).Width = 130
                dg1.Columns(3).HeaderText = "Last Name"
                dg1.Columns(3).Width = 130

                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = False
                dg1.Columns(6).Visible = False
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
                dg1.Columns(29).Visible = False
                dg1.Columns(30).Visible = False
                dg1.Columns(31).Visible = False
                dg1.Columns(32).Visible = False
                dg1.Columns(33).Visible = False
                dg1.Columns(34).Visible = False
                dg1.Columns(35).Visible = False
                dg1.Columns(36).Visible = False
                dg1.Columns(37).Visible = False
                dg1.Columns(38).Visible = False
                dg1.Columns(39).Visible = False
                dg1.Columns(40).Visible = False
                dg1.Columns(41).Visible = False
                dg1.Columns(42).Visible = False
                dg1.Columns(43).Visible = False
                dg1.Columns(44).Visible = False
                dg1.Columns(45).Visible = False
                dg1.Columns(46).Visible = False
                dg1.Columns(47).Visible = False
                dg1.Columns(48).Visible = False
                dg1.Columns(49).Visible = False
                dg1.Columns(50).Visible = False
                dg1.Columns(51).Visible = False
                dg1.Columns(52).Visible = False
                dg1.Columns(53).Visible = False
                dg1.Columns(54).Visible = False
                dg1.Columns(55).Visible = False
                dg1.Columns(56).Visible = False
                dg1.Columns(57).Visible = False
                dg1.Columns(58).Visible = False
                dg1.Columns(59).Visible = False
                dg1.Columns(60).Visible = False
                dg1.Columns(61).Visible = False
                dg1.Columns(62).Visible = False
                dg1.Columns(63).Visible = False
                dg1.Columns(64).Visible = False
                dg1.Columns(65).Visible = False
                dg1.Columns(66).Visible = False
                dg1.Columns(67).Visible = False
                dg1.Columns(68).Visible = False
                dg1.Columns(69).Visible = False
                dg1.Columns(70).Visible = False
                dg1.Columns(71).Visible = False
                dg1.Columns(72).Visible = False
                dg1.Columns(73).Visible = False
                dg1.Columns(74).Visible = False
                dg1.Columns(75).Visible = False
                dg1.Columns(76).Visible = False
                dg1.Columns(77).Visible = False
                dg1.Columns(78).Visible = False
                dg1.Columns(79).Visible = False
                dg1.Columns(80).Visible = False
                dg1.Columns(81).Visible = False
                dg1.Columns(82).Visible = False
                dg1.Columns(83).Visible = False
                dg1.Columns(84).Visible = False
                dg1.Columns(85).Visible = False
                dg1.Columns(86).Visible = False
                dg1.Columns(87).Visible = False
                dg1.Columns(88).Visible = False
                dg1.Columns(89).Visible = False
                dg1.Columns(90).Visible = False
                dg1.Columns(91).Visible = False
                dg1.Columns(92).Visible = False


            Else
                str = "select * from online_enrollment where Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and enrolStatus='For Validation'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "online_enrollment")
                dg1.DataSource = ds.Tables("online_enrollment")
                conn.Close()

                dg1.Columns(1).HeaderText = "Student No."
                dg1.Columns(1).Width = 130
                dg1.Columns(2).HeaderText = "First Name"
                dg1.Columns(2).Width = 130
                dg1.Columns(3).HeaderText = "Middle Name"
                dg1.Columns(3).Width = 130
                dg1.Columns(4).HeaderText = "Last Name"
                dg1.Columns(4).Width = 130
                dg1.Columns(5).HeaderText = "Course"
                dg1.Columns(5).Width = 130

                dg1.Columns(6).HeaderText = "Major"
                dg1.Columns(6).Width = 130

                dg1.Columns(7).HeaderText = "Year Level"
                dg1.Columns(7).Width = 80

                dg1.Columns(0).Visible = False
                dg1.Columns(5).Visible = False
                dg1.Columns(6).Visible = False
                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                dg1.Columns(12).Visible = False
                dg1.Columns(13).Visible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rdoLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLocal.CheckedChanged
        loadRecords()
    End Sub

    Private Sub rdoOnline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOnline.CheckedChanged
        loadRecords()
    End Sub
End Class