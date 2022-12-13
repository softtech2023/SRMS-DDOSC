Imports MySql.Data.MySqlClient
Public Class frmCompleteList
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try

            str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%' or StudentNumber like '%" & txtSearch.Text & "%' order by StudentNumber desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dg1.DataSource = ds.Tables("studeprofile")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(0).Width = 150
            dg1.Columns(1).HeaderText = "First Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).HeaderText = "Middle Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(3).HeaderText = "Last Name"
            dg1.Columns(1).Width = 200

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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCompleteList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from studeprofile order by StudentNumber DESC"
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmStudeProfile.mskStudentNumber.Text = dg1.Item(0, i).Value
            frmStudeProfile.txtFName.Text = dg1.Item(1, i).Value
            frmStudeProfile.txtMName.Text = dg1.Item(2, i).Value
            frmStudeProfile.txtLName.Text = dg1.Item(3, i).Value
            frmStudeProfile.cboSex.Text = dg1.Item(4, i).Value
            frmStudeProfile.cboCivilStatus.Text = dg1.Item(5, i).Value
            frmStudeProfile.txtBirthPlace.Text = dg1.Item(6, i).Value
            frmStudeProfile.txtReligion.Text = dg1.Item(7, i).Value
            frmStudeProfile.txtEmail.Text = dg1.Item(8, i).Value
            frmStudeProfile.mskMobileNumber.Text = dg1.Item(9, i).Value
            frmStudeProfile.cboWorkingStudent.Text = dg1.Item(10, i).Value
            frmStudeProfile.txtOccupation.Text = dg1.Item(11, i).Value
            frmStudeProfile.txtSalary.Text = dg1.Item(12, i).Value
            frmStudeProfile.txtEmployer.Text = dg1.Item(13, i).Value
            frmStudeProfile.txtCompanyAddress.Text = dg1.Item(14, i).Value
            frmStudeProfile.dtpBirthDate.Text = dg1.Item(15, i).Value

            frmStudeProfile.dtpAdmission.Text = dg1.Item(16, i).Value
            frmStudeProfile.txtGraduationDate.Text = dg1.Item(17, i).Value
            frmStudeProfile.txtGuardian.Text = dg1.Item(18, i).Value
            frmStudeProfile.txtGuardianRelationship.Text = dg1.Item(19, i).Value
            frmStudeProfile.txtGuardianContact.Text = dg1.Item(20, i).Value
            frmStudeProfile.txtGuardianAddress.Text = dg1.Item(21, i).Value
            frmStudeProfile.txtSpouse.Text = dg1.Item(22, i).Value
            frmStudeProfile.txtSpouseRelationShip.Text = dg1.Item(23, i).Value
            frmStudeProfile.txtSpouseContact.Text = dg1.Item(24, i).Value
            frmStudeProfile.txtNoChildren.Text = dg1.Item(25, i).Value
            frmStudeProfile.txtSpouseIncome.Text = dg1.Item(26, i).Value

            'load Profile Pic


            '27 is intended for the profile pic
            frmStudeProfile.cboCourse.Text = dg1.Item(28, i).Value
            frmStudeProfile.cboYearLevel.Text = dg1.Item(29, i).Value
            frmStudeProfile.txtFather.Text = dg1.Item(30, i).Value
            frmStudeProfile.txtFatherOccupation.Text = dg1.Item(31, i).Value
            frmStudeProfile.txtFatherAddress.Text = dg1.Item(32, i).Value
            frmStudeProfile.txtMother.Text = dg1.Item(33, i).Value
            frmStudeProfile.txtMotherOccupation.Text = dg1.Item(34, i).Value
            frmStudeProfile.txtMotherAddress.Text = dg1.Item(35, i).Value
            frmStudeProfile.txtSiblings.Text = dg1.Item(36, i).Value
            frmStudeProfile.txtBirthOrder.Text = dg1.Item(37, i).Value
            frmStudeProfile.txtAge.Text = dg1.Item(38, i).Value
            frmStudeProfile.lblTitle.Text = dg1.Item(39, i).Value
            frmStudeProfile.lblPronoun.Text = dg1.Item(40, i).Value
            frmStudeProfile.lblPronoun2.Text = dg1.Item(41, i).Value
            frmStudeProfile.lblPronoun3.Text = dg1.Item(42, i).Value
            frmStudeProfile.cboScholarship.Text = dg1.Item(43, i).Value
            frmStudeProfile.cboEthnicity.Text = dg1.Item(44, i).Value
            frmStudeProfile.cbo4Ps.Text = dg1.Item(45, i).Value
            frmStudeProfile.cboSenior.Text = dg1.Item(46, i).Value
            frmStudeProfile.cboAls.Text = dg1.Item(47, i).Value
            frmStudeProfile.txtDisability.Text = dg1.Item(48, i).Value
            frmStudeProfile.cboParentsIncome.Text = dg1.Item(49, i).Value
            frmStudeProfile.cboProvince.Text = dg1.Item(50, i).Value
            frmStudeProfile.cboMuncipality.Text = dg1.Item(51, i).Value
            frmStudeProfile.cboBrgy.Text = dg1.Item(52, i).Value
            frmStudeProfile.txtSubdivision.Text = dg1.Item(53, i).Value
            frmStudeProfile.cboProvincePresent.Text = dg1.Item(54, i).Value
            frmStudeProfile.cboMunPresent.Text = dg1.Item(55, i).Value
            frmStudeProfile.cboBarangayPresent.Text = dg1.Item(56, i).Value
            frmStudeProfile.txtSubPresent.Text = dg1.Item(57, i).Value
            frmStudeProfile.txtElementary.Text = dg1.Item(58, i).Value
            frmStudeProfile.txtElemAddress.Text = dg1.Item(59, i).Value
            frmStudeProfile.txtElemYear.Text = dg1.Item(60, i).Value
            frmStudeProfile.txtElemMerits.Text = dg1.Item(61, i).Value
            frmStudeProfile.txtHighSchool.Text = dg1.Item(62, i).Value
            frmStudeProfile.txtHSAddress.Text = dg1.Item(63, i).Value
            frmStudeProfile.txtHSYear.Text = dg1.Item(64, i).Value
            frmStudeProfile.txtHSMerit.Text = dg1.Item(65, i).Value
            frmStudeProfile.txtVocational.Text = dg1.Item(66, i).Value
            frmStudeProfile.txtVocationalAddress.Text = dg1.Item(67, i).Value
            frmStudeProfile.txtVocYearGrad.Text = dg1.Item(68, i).Value
            frmStudeProfile.txtVocCourse.Text = dg1.Item(69, i).Value
            frmStudeProfile.txtVocNC.Text = dg1.Item(70, i).Value
            frmStudeProfile.txtSchoolTransferee.Text = dg1.Item(71, i).Value
            frmStudeProfile.txtSchoolTransAddress.Text = dg1.Item(72, i).Value
            frmStudeProfile.txtCourseTransferee.Text = dg1.Item(73, i).Value
            frmStudeProfile.txtYearGradTransferee.Text = dg1.Item(74, i).Value
            frmStudeProfile.cboSkills.Text = dg1.Item(75, i).Value
            'settings id - 76
            frmStudeProfile.txtApplicationNo.Text = dg1.Item(77, i).Value
            frmStudeProfile.txtTestCenter.Text = dg1.Item(78, i).Value
            frmStudeProfile.dtpTestDate.Text = dg1.Item(79, i).Value
            'encoder - 80
            frmStudeProfile.cboSemester.Text = dg1.Item(81, i).Value
            frmStudeProfile.txtSY.Text = dg1.Item(82, i).Value
            frmStudeProfile.txtAdmissionReq.Text = dg1.Item(83, i).Value
            frmStudeProfile.txtGraduationDate.Text = dg1.Item(84, i).Value
            frmStudeProfile.txtLastSchool.Text = dg1.Item(85, i).Value
            frmStudeProfile.txtDateLastAttended.Text = dg1.Item(86, i).Value
            frmStudeProfile.txtHonors.Text = dg1.Item(87, i).Value
            frmStudeProfile.txtROTC.Text = dg1.Item(88, i).Value
            frmStudeProfile.txtCWTS.Text = dg1.Item(89, i).Value
            frmStudeProfile.txtLRN.Text = dg1.Item(90, i).Value
            frmStudeProfile.txtLTSSerialNo.Text = dg1.Item(91, i).Value
            frmStudeProfile.cboVaccinationStat.Text = dg1.Item(92, i).Value

            frmStudeProfile.tsSave.Enabled = False
            frmStudeProfile.tsUpdate.Enabled = True
            'frmStudeProfile.tsDelete.Enabled = True
            frmStudeProfile.tsLRN.Enabled = True


            frmStudeProfile.Tab.Show()

            frmStudeProfile.getAge()

            frmStudeProfile.getPhoto()

            frmStudeProfile.disableButtons()
            frmStudeProfile.getRequirements()

            frmStudeProfile.mskStudentNumber.ReadOnly = True

            txtSearch.Clear()
            txtSearch.Focus()

            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class