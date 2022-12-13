Imports MySql.Data.MySqlClient
Public Class frmStudeProfile
    Dim str As String
    Dim imgpath As String
    Dim profImage() As Byte

    Public Sub FormLoad()
        Try
            mskStudentNumber.Clear()
            txtFName.Clear()
            txtMName.Clear()
            txtLName.Clear()
            cboSex.ResetText()
            cboCivilStatus.ResetText()
            txtReligion.ResetText()
            txtEmail.Clear()
            mskMobileNumber.Clear()
            cboWorkingStudent.ResetText()
            txtOccupation.Clear()
            txtSalary.Text = 0.0
            txtEmployer.Clear()
            txtCompanyAddress.Clear()
            dtpBirthDate.Text = Today
            dtpAdmission.Text = Today
            'dtpGraduation.Text = Today
            txtGuardian.Clear()
            txtGuardianRelationship.Clear()
            txtGuardianContact.Clear()
            txtGuardianAddress.Clear()
            txtSpouse.Clear()
            txtSpouseRelationShip.Clear()
            txtSpouseContact.Clear()
            txtNoChildren.Clear()
            txtSpouseIncome.Clear()
            cboCourse.ResetText()
            cboYearLevel.ResetText()
            txtFather.Clear()
            txtFatherOccupation.Clear()
            txtFatherAddress.Clear()
            txtMother.Clear()
            txtMotherOccupation.Clear()
            txtMotherAddress.Clear()
            txtSiblings.Clear()
            txtBirthOrder.Clear()
            txtAge.Text = 0
            cboScholarship.ResetText()
            cboEthnicity.ResetText()
            cbo4Ps.ResetText()
            cboSenior.ResetText()
            cboAls.ResetText()
            txtDisability.Clear()
            cboParentsIncome.ResetText()
            cboProvince.ResetText()
            cboMuncipality.ResetText()
            cboBrgy.ResetText()
            txtSubdivision.Clear()
            cboProvincePresent.ResetText()
            cboMunPresent.ResetText()
            cboBarangayPresent.ResetText()
            txtSubPresent.ResetText()
            txtElementary.Clear()
            txtElemAddress.Clear()
            txtElemYear.Clear()
            txtElemMerits.Clear()
            txtHighSchool.Clear()
            txtHSAddress.Clear()
            txtHSYear.Clear()
            txtHSMerit.Clear()
            txtVocational.Clear()
            txtVocationalAddress.Clear()
            txtVocYearGrad.Clear()
            txtVocCourse.Clear()
            txtVocNC.Clear()
            txtSchoolTransferee.Clear()
            txtSchoolTransAddress.Clear()
            txtCourseTransferee.Clear()
            txtYearGradTransferee.Clear()
            cboSkills.ResetText()

            cboProvince.ResetText()
            cboMuncipality.ResetText()
            cboBrgy.ResetText()
            txtSubdivision.Clear()
            txtElemYear.Clear()
            txtHSYear.Clear()
            txtVocYearGrad.Clear()
            dtpTestDate.Text = Today
            txtTestCenter.Clear()

            cboSemester.ResetText()
            txtSY.Clear()
            txtGraduationDate.Clear()
            txtAdmissionReq.Clear()
            txtLastSchool.Clear()
            txtDateLastAttended.Clear()
            txtHonors.Clear()
            txtROTC.Clear()
            txtCWTS.Clear()
            txtLRN.Clear()
            txtLTSSerialNo.Clear()
            txtBirthPlace.Clear()
            cboVaccinationStat.Text = "No Status"

            chk1.Checked = False
            chk2.Checked = False
            chk3.Checked = False
            chk4.Checked = False
            chk5.Checked = False
            chk6.Checked = False
            chk7.Checked = False
            chk8.Checked = False
            chk9.Checked = False
            chk10.Checked = False
            chk11.Checked = False
            chk12.Checked = False
            chk13.Checked = False
            chk14.Checked = False
            chk15.Checked = False
            chk16.Checked = False
            chk17.Checked = False
            chk18.Checked = False
            chk19.Checked = False

            PictureBox1.Image = My.Resources.Untitled_1

            txtFName.Focus()
            mskStudentNumber.ReadOnly = False

            getApplicationNo()
            getProvince()
            getCity()
            getBrgy()
            getReligion()
            getEthnicity()
            getCourse()
            getScholarship()
            schoolInfo()
            getAcctLevel()
            getStudentNumber()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        tsLRN.Enabled = False
    End Sub

    Private Sub frmStudeProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub checkBox()
        If chk1.Checked = True Then
            txtStatt1.Text = "Submitted"
        Else
            txtStatt1.Text = "Not Yet Submitted"
        End If

        If chk2.Checked = True Then
            txtStatt2.Text = "Submitted"
        Else
            txtStatt2.Text = "Not Yet Submitted"
        End If

        If chk3.Checked = True Then
            txtStatt3.Text = "Submitted"
        Else
            txtStatt3.Text = "Not Yet Submitted"
        End If

        If chk4.Checked = True Then
            txtStatt4.Text = "Submitted"
        Else
            txtStatt4.Text = "Not Yet Submitted"
        End If

        If chk5.Checked = True Then
            txtStatt5.Text = "Submitted"
        Else
            txtStatt5.Text = "Not Yet Submitted"
        End If

        If chk6.Checked = True Then
            txtStatt6.Text = "Submitted"
        Else
            txtStatt6.Text = "Not Yet Submitted"
        End If

        If chk7.Checked = True Then
            txtStatt7.Text = "Submitted"
        Else
            txtStatt7.Text = "Not Yet Submitted"
        End If

        If chk8.Checked = True Then
            txtStatt8.Text = "Submitted"
        Else
            txtStatt8.Text = "Not Yet Submitted"
        End If

        If chk9.Checked = True Then
            txtStatt9.Text = "Submitted"
        Else
            txtStatt9.Text = "Not Yet Submitted"
        End If

        If chk10.Checked = True Then
            txtStatt10.Text = "Submitted"
        Else
            txtStatt10.Text = "Not Yet Submitted"
        End If

        If chk11.Checked = True Then
            txtStatt11.Text = "Submitted"
        Else
            txtStatt11.Text = "Not Yet Submitted"
        End If

        If chk12.Checked = True Then
            txtStatt12.Text = "Submitted"
        Else
            txtStatt12.Text = "Not Yet Submitted"
        End If

        If chk13.Checked = True Then
            txtStatt13.Text = "Submitted"
        Else
            txtStatt13.Text = "Not Yet Submitted"
        End If

        If chk14.Checked = True Then
            txtStatt14.Text = "Submitted"
        Else
            txtStatt14.Text = "Not Yet Submitted"
        End If

        If chk15.Checked = True Then
            txtStatt15.Text = "Submitted"
        Else
            txtStatt15.Text = "Not Yet Submitted"
        End If

        If chk16.Checked = True Then
            txtStatt16.Text = "Submitted"
        Else
            txtStatt16.Text = "Not Yet Submitted"
        End If

        If chk17.Checked = True Then
            txtStatt17.Text = "Submitted"
        Else
            txtStatt17.Text = "Not Yet Submitted"
        End If

        If chk18.Checked = True Then
            txtStatt18.Text = "Submitted"
        Else
            txtStatt18.Text = "Not Yet Submitted"
        End If

        If chk19.Checked = True Then
            txtStatt19.Text = "Submitted"
        Else
            txtStatt19.Text = "Not Yet Submitted"
        End If
    End Sub
    Public Sub CheckTheRequirements()
        If txtStatt1.Text = "Submitted" Then
            chk1.Checked = True
        Else
            chk1.Checked = False
        End If

        If txtStatt2.Text = "Submitted" Then
            chk2.Checked = True
        Else
            chk2.Checked = False
        End If

        If txtStatt3.Text = "Submitted" Then
            chk3.Checked = True
        Else
            chk3.Checked = False
        End If

        If txtStatt4.Text = "Submitted" Then
            chk4.Checked = True
        Else
            chk4.Checked = False
        End If

        If txtStatt5.Text = "Submitted" Then
            chk5.Checked = True
        Else
            chk5.Checked = False
        End If

        If txtStatt6.Text = "Submitted" Then
            chk6.Checked = True
        Else
            chk6.Checked = False
        End If

        If txtStatt7.Text = "Submitted" Then
            chk7.Checked = True
        Else
            chk7.Checked = False
        End If

        If txtStatt8.Text = "Submitted" Then
            chk8.Checked = True
        Else
            chk8.Checked = False
        End If

        If txtStatt9.Text = "Submitted" Then
            chk9.Checked = True
        Else
            chk9.Checked = False
        End If

        If txtStatt10.Text = "Submitted" Then
            chk10.Checked = True
        Else
            chk10.Checked = False
        End If

        If txtStatt11.Text = "Submitted" Then
            chk11.Checked = True
        Else
            chk11.Checked = False
        End If

        If txtStatt12.Text = "Submitted" Then
            chk12.Checked = True
        Else
            chk12.Checked = False
        End If

        If txtStatt13.Text = "Submitted" Then
            chk13.Checked = True
        Else
            chk13.Checked = False
        End If

        If txtStatt14.Text = "Submitted" Then
            chk14.Checked = True
        Else
            chk14.Checked = False
        End If

        If txtStatt15.Text = "Submitted" Then
            chk15.Checked = True
        Else
            chk15.Checked = False
        End If

        If txtStatt16.Text = "Submitted" Then
            chk16.Checked = True
        Else
            chk16.Checked = False
        End If

        If txtStatt17.Text = "Submitted" Then
            chk17.Checked = True
        Else
            chk17.Checked = False
        End If

        If txtStatt18.Text = "Submitted" Then
            chk18.Checked = True
        Else
            chk18.Checked = False
        End If

        If txtStatt19.Text = "Submitted" Then
            chk19.Checked = True
        Else
            chk19.Checked = False
        End If
    End Sub
    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool1.ShowDialog()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool2.ShowDialog()
    End Sub
    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            'check duplicate student number
            str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")

            If ds.Tables("studeprofile").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If
            If mskStudentNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()
            'end


            'check duplicate names
            str = "select * from studeprofile where FirstName='" & txtFName.Text & "' and LastName='" & txtLName.Text & "'"
            conn.Open()
            Dim mysda1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet
            mysda1.Fill(ds1, "studeprofile")

            If ds1.Tables("studeprofile").Rows.Count = 1 Then
                MsgBox("Record already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If
            'end

            If mskStudentNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()
            'end


            If txtFName.Text = "" Then
                MsgBox("First name is required!", MsgBoxStyle.Exclamation)
                txtFName.Focus()
                Exit Sub
            End If
            If txtLName.Text = "" Then
                MsgBox("Last name is required!", MsgBoxStyle.Exclamation)
                txtLName.Focus()
                Exit Sub
            End If

            If cboProvince.Text = "" Then
                MsgBox("Provincial address is required!", MsgBoxStyle.Exclamation)
                cboProvince.Focus()
                Exit Sub
            End If

            If cboMuncipality.Text = "" Then
                MsgBox("City or Municipality is required!", MsgBoxStyle.Exclamation)
                cboMuncipality.Focus()
                Exit Sub
            End If

            If cboSex.Text = "" Then
                MsgBox("Sex/Gender is required!", MsgBoxStyle.Exclamation)
                cboSex.Focus()
                Exit Sub
            End If

            If cboCivilStatus.Text = "" Then
                MsgBox("Civil status is required!", MsgBoxStyle.Exclamation)
                cboCivilStatus.Focus()
                Exit Sub
            End If

            str = "insert into studeprofile values('" & mskStudentNumber.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & cboSex.Text & "','" & cboCivilStatus.Text & "','" & txtBirthPlace.Text & "','" & txtReligion.Text & "','" & txtEmail.Text & "','" & mskMobileNumber.Text & "','" & cboWorkingStudent.Text & "','" & txtOccupation.Text & "','" & txtSalary.Text & "','" & txtEmployer.Text & "','" & txtCompanyAddress.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "','" & txtGraduationDate.Text & "','" & txtGuardian.Text & "','" & txtGuardianRelationship.Text & "','" & txtGuardianContact.Text & "','" & txtGuardianAddress.Text & "','" & txtSpouse.Text & "','" & txtSpouseRelationShip.Text & "','" & txtSpouseContact.Text & "','" & txtNoChildren.Text & "','" & txtSpouseIncome.Text & "','','" & cboCourse.Text & "','" & cboYearLevel.Text & "','" & txtFather.Text & "','" & txtFatherOccupation.Text & "','" & txtFatherAddress.Text & "','" & txtMother.Text & "','" & txtMotherOccupation.Text & "','" & txtMotherAddress.Text & "','" & txtSiblings.Text & "','" & txtBirthOrder.Text & "','" & txtAge.Text & "','" & lblTitle.Text & "','" & lblPronoun.Text & "','" & lblPronoun2.Text & "','" & lblPronoun3.Text & "','" & cboScholarship.Text & "','" & cboEthnicity.Text & "','" & cbo4Ps.Text & "','" & cboSenior.Text & "','" & cboAls.Text & "','" & txtDisability.Text & "','" & cboParentsIncome.Text & "','" & cboProvince.Text & "','" & cboMuncipality.Text & "','" & cboBrgy.Text & "','" & txtSubdivision.Text & "','" & cboProvincePresent.Text & "','" & cboMunPresent.Text & "','" & cboBarangayPresent.Text & "','" & txtSubPresent.Text & "','" & txtElementary.Text & "','" & txtElemAddress.Text & "','" & txtElemYear.Text & "','" & txtElemMerits.Text & "','" & txtHighSchool.Text & "','" & txtHSAddress.Text & "','" & txtHSYear.Text & "','" & txtHSMerit.Text & "','" & txtVocational.Text & "','" & txtVocationalAddress.Text & "','" & txtVocYearGrad.Text & "','" & txtVocCourse.Text & "','" & txtVocNC.Text & "','" & txtSchoolTransferee.Text & "','" & txtSchoolTransAddress.Text & "','" & txtCourseTransferee.Text & "','" & txtYearGradTransferee.Text & "','" & cboSkills.Text & "','" & lblSettingsID.Text & "','" & txtApplicationNo.Text & "','" & txtTestCenter.Text & "','" & Convert.ToDateTime(dtpTestDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblUser.Text & "','" & cboSemester.Text & "','" & txtSY.Text & "','" & txtAdmissionReq.Text & "','" & txtGraduationDate.Text & "','" & txtLastSchool.Text & "','" & txtDateLastAttended.Text & "','" & txtHonors.Text & "','" & txtROTC.Text & "','" & txtCWTS.Text & "','" & txtLRN.Text & "','" & txtLTSSerialNo.Text & "','" & cboVaccinationStat.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.Parameters.AddWithValue("@imagePath", profImage)
            mysC.ExecuteNonQuery()
            conn.Close()

            'Save Image
            saveImage()

            'Audit Trail
            str = "insert into atrail values('0','Encoded Student''s Profile','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'create user account
            Dim pass As String

            pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

            str = "insert into users values('" & mskStudentNumber.Text & "','" & pass & "','Student','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtEmail.Text & "','avatar.png','active','" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "','" & txtFName.Text & " " & txtLName.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            'SAVE REQUIREMENTS
            str = "insert into stude_requirements values(0,'" & mskStudentNumber.Text & "','" & chk1.Text & "','" & chk2.Text & "','" & chk3.Text & "','" & chk4.Text & "','" & chk5.Text & "','" & chk6.Text & "','" & chk7.Text & "','" & chk8.Text & "','" & chk9.Text & "','" & chk10.Text & "','" & chk11.Text & "','" & chk12.Text & "','" & chk13.Text & "','" & chk14.Text & "','" & chk15.Text & "','" & chk16.Text & "','" & chk17.Text & "','" & chk18.Text & "','" & chk19.Text & "','','" & txtStatt1.Text & "','" & txtStatt2.Text & "','" & txtStatt3.Text & "','" & txtStatt4.Text & "','" & txtStatt5.Text & "','" & txtStatt6.Text & "','" & txtStatt7.Text & "','" & txtStatt8.Text & "','" & txtStatt9.Text & "','" & txtStatt10.Text & "','" & txtStatt11.Text & "','" & txtStatt12.Text & "','" & txtStatt13.Text & "','" & txtStatt14.Text & "','" & txtStatt15.Text & "','" & txtStatt16.Text & "','" & txtStatt17.Text & "','" & txtStatt18.Text & "','" & txtStatt19.Text & "','')"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            conn.Close()


            If (MsgBox("Record successfully saved.  Would you like to save another record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                mskStudentNumber.Focus()
            Else
                Me.Close()
            End If

            mskStudentNumber.Focus()
            conn.Close()
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click

        Dim pass As String
        pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

        Try
            str = "update studeprofile set FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "',Sex='" & cboSex.Text & "',CivilStatus='" & cboCivilStatus.Text & "',BirthPlace='" & txtBirthPlace.Text & "',Religion='" & txtReligion.Text & "',email='" & txtEmail.Text & "',contactNo='" & mskMobileNumber.Text & "',working='" & cboWorkingStudent.Text & "',occupation='" & txtOccupation.Text & "',salary='" & txtSalary.Text & "',employer='" & txtEmployer.Text & "',employerAddress='" & txtCompanyAddress.Text & "',birthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',admissionDate='" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "',graduationDate='" & txtGraduationDate.Text & "',guardian='" & txtGuardian.Text & "',guardianRelationship='" & txtGuardianRelationship.Text & "',guardianContact='" & txtGuardianContact.Text & "',guardianAddress='" & txtGuardianAddress.Text & "',spouse='" & txtSpouse.Text & "',spouseRelationship='" & txtSpouseRelationShip.Text & "',spouseContact='" & txtSpouseContact.Text & "',children='" & txtNoChildren.Text & "',spouseIncome='" & txtSpouseIncome.Text & "',course='" & cboCourse.Text & "',yearLevel='" & cboYearLevel.Text & "',father='" & txtFather.Text & "',fOccupation='" & txtFatherOccupation.Text & "',fatherAddress='" & txtFatherAddress.Text & "',mother='" & txtMother.Text & "',mOccupation='" & txtMotherOccupation.Text & "',motherAddress='" & txtMotherAddress.Text & "',siblings='" & txtSiblings.Text & "',birthOrder='" & txtBirthOrder.Text & "',age='" & txtAge.Text & "',title='" & lblTitle.Text & "',pronoun='" & lblPronoun.Text & "',pronoun2='" & lblPronoun2.Text & "',pronoun3='" & lblPronoun3.Text & "',scholarship='" & cboScholarship.Text & "',ethnicity='" & cboEthnicity.Text & "',fourPs='" & cbo4Ps.Text & "',seniorCitizen='" & cboSenior.Text & "',als='" & cboAls.Text & "',disability='" & txtDisability.Text & "',parentsMonthly='" & cboParentsIncome.Text & "',province='" & cboProvince.Text & "',city='" & cboMuncipality.Text & "',brgy='" & cboBrgy.Text & "',sitio='" & txtSubdivision.Text & "',provincePresent='" & cboProvincePresent.Text & "',cityPresent='" & cboMunPresent.Text & "',brgyPresent='" & cboBarangayPresent.Text & "',sitioPresent='" & txtSubPresent.Text & "',elementary='" & txtElementary.Text & "',elementaryAddress='" & txtElemAddress.Text & "',elemGraduated='" & txtElemYear.Text & "',elemMerits='" & txtElemMerits.Text & "',secondary='" & txtHighSchool.Text & "',secondaryAddress='" & txtHSAddress.Text & "',secondaryGraduated='" & txtHSYear.Text & "',secondaryMerits='" & txtHSMerit.Text & "',vocational='" & txtVocational.Text & "',vocationalAddress='" & txtVocationalAddress.Text & "',vocationalGraduated='" & txtVocYearGrad.Text & "',vocationalCourse='" & txtVocCourse.Text & "',ncLevel='" & txtVocNC.Text & "',transfereeSchool='" & txtSchoolTransferee.Text & "',transfereeAddress='" & txtSchoolTransAddress.Text & "',transfereeCourse='" & txtCourseTransferee.Text & "',transfereeGraduated='" & txtYearGradTransferee.Text & "',skills='" & cboSkills.Text & "',applicationNo='" & txtApplicationNo.Text & "',testCenter='" & txtTestCenter.Text & "',testDate='" & Convert.ToDateTime(dtpTestDate.Text).ToString("yyyy-MM-dd") & "',admissionSem='" & cboSemester.Text & "',admissionSY='" & txtSY.Text & "',admissionBasis='" & txtAdmissionReq.Text & "',lastAttended='" & txtGraduationDate.Text & "',lastSchool='" & txtLastSchool.Text & "',lastSchoolDate='" & txtDateLastAttended.Text & "',honors='" & txtHonors.Text & "',rotcSerial='" & txtROTC.Text & "',cwtsSerial='" & txtCWTS.Text & "',lrn='" & txtLRN.Text & "',ltsSerialNo='" & txtLTSSerialNo.Text & "',vacStat='" & cboVaccinationStat.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            'update semesterstude
            str = "update semesterstude set FName='" & txtFName.Text & "',MName='" & txtMName.Text & "',LName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'update payments accounts
            str = "update paymentsaccounts set FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()

            'update students accounts
            str = "update studeaccount set FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc3 As New MySqlCommand(str, conn)
            mysc3.ExecuteNonQuery()
            conn.Close()

            'update user accounts
            str = "update users set password='" & pass & "' where username='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc4 As New MySqlCommand(str, conn)
            mysc4.ExecuteNonQuery()
            conn.Close()

            'update profile image
            str = "delete from profimage where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc6 As New MySqlCommand(str, conn)
            mysc6.ExecuteNonQuery()
            conn.Close()

            saveImage()

            'Audit Trail
            str = "insert into atrail values('0','Updated Student''s Profile','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc7 As New MySqlCommand(str, conn)
            mysc7.ExecuteNonQuery()
            conn.Close()

            'update requirements
            str = "update stude_requirements set req1='" & chk1.Text & "',req2='" & chk2.Text & "',req3='" & chk3.Text & "',req4='" & chk4.Text & "',req5='" & chk5.Text & "',req6='" & chk6.Text & "',req7='" & chk7.Text & "',req8='" & chk8.Text & "',req9='" & chk9.Text & "',req10='" & chk10.Text & "',req11='" & chk11.Text & "',req12='" & chk12.Text & "',req13='" & chk13.Text & "',req14='" & chk14.Text & "',req15='" & chk15.Text & "',req16='" & chk16.Text & "',req17='" & chk17.Text & "',req18='" & chk18.Text & "',stat1='" & txtStatt1.Text & "',stat2='" & txtStatt2.Text & "',stat3='" & txtStatt3.Text & "',stat4='" & txtStatt4.Text & "',stat5='" & txtStatt5.Text & "',stat6='" & txtStatt6.Text & "',stat7='" & txtStatt7.Text & "',stat8='" & txtStatt8.Text & "',stat9='" & txtStatt9.Text & "',stat10='" & txtStatt10.Text & "',stat11='" & txtStatt11.Text & "',stat12='" & txtStatt12.Text & "',stat13='" & txtStatt13.Text & "',stat14='" & txtStatt14.Text & "',stat15='" & txtStatt15.Text & "',stat16='" & txtStatt16.Text & "',stat17='" & txtStatt17.Text & "',stat18='" & txtStatt18.Text & "',stat19='" & txtStatt19.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysC9 As New MySqlCommand(str, conn)
            mysC9.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information, "Prompt")
            FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If mskStudentNumber.Text = "" Then
                MsgBox("Please select records to delete!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'delete from useraccounts
                str = "delete from users where username='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Deleted Student''s Profile','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc2 As New MySqlCommand(str, conn)
                mysc2.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                FormLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If txtImagePath.Text = "" Then
                MsgBox("Cannot find any image to view", MsgBoxStyle.Information)
                Exit Sub
            End If
            Process.Start(txtImagePath.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCapture.Click
        frmCapture.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        tsSave.PerformClick()
    End Sub

    Public Sub getTitle()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "MR."
            lblTitle.Text = i
        Else
            i = "MS."
            lblTitle.Text = i
        End If
    End Sub
    Public Sub getPronoun()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "him"
            lblPronoun.Text = i
        Else
            i = "her"
            lblPronoun.Text = i
        End If
    End Sub
    Public Sub getPronoun2()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "He"
            lblPronoun2.Text = i
        Else
            i = "She"
            lblPronoun2.Text = i
        End If
    End Sub
    Public Sub getPronoun3()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "His"
            lblPronoun3.Text = i
        Else
            i = "Her"
            lblPronoun3.Text = i
        End If
    End Sub

    Private Sub cboSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSex.SelectedIndexChanged
        getTitle()
        getPronoun()
        getPronoun2()
        getPronoun3()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectSchool2.ShowDialog()
    End Sub

    Private Sub dtpBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBirthDate.ValueChanged
        getAge()
    End Sub
    Public Sub getAge()
        Try
            Dim strBirth As String
            Dim intAge As Integer
            strBirth = dtpBirthDate.Text
            intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(strBirth), Now()) / 12)
            txtAge.Text = intAge
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Public Sub getProvince()
        Try
            str = "select Province from studeprofile group by Province order by Province"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboProvince.ValueMember = "studeprofile"
            cboProvince.DisplayMember = "Province"
            cboProvince.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCity()
        Try
            str = "select City from studeprofile group by City order by City"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboMuncipality.ValueMember = "studeprofile"
            cboMuncipality.DisplayMember = "City"
            cboMuncipality.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getBrgy()
        Try
            str = "select Brgy from studeprofile group by Brgy order by Brgy"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboBrgy.ValueMember = "studeprofile"
            cboBrgy.DisplayMember = "Brgy"
            cboBrgy.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getReligion()
        Try
            str = "select Religion from studeprofile group by Religion order by Religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            txtReligion.ValueMember = "studeprofile"
            txtReligion.DisplayMember = "Religion"
            txtReligion.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getEthnicity()
        Try
            str = "select Ethnicity from studeprofile group by Ethnicity order by Ethnicity"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            conn.Close()
            cboEthnicity.ValueMember = "studeprofile"
            cboEthnicity.DisplayMember = "Ethnicity"
            cboEthnicity.DataSource = ds.Tables("studeprofile")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboCourse.ValueMember = "course_table"
            cboCourse.DisplayMember = "CourseDescription"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmSelectSchool1.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSelectSchool2.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmChangeLRN.ShowDialog()
    End Sub

    Private Sub tsLRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLRN.Click
        frmChangeLRN.ShowDialog()
    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
                lblStudeNoPrefix.Text = dtReader(14)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSeletPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeletPicture.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub getPresentAddress()
        If chkPresent.Checked = True Then
            cboProvincePresent.Text = cboProvince.Text
            cboMunPresent.Text = cboMuncipality.Text
            cboBarangayPresent.Text = cboBrgy.Text
            txtSubPresent.Text = txtSubdivision.Text
        Else
            chkPresent.Checked = False
            cboProvincePresent.ResetText()
            cboMunPresent.ResetText()
            cboBarangayPresent.ResetText()
            txtSubPresent.Clear()
        End If
    End Sub

    Private Sub chkPresent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPresent.CheckedChanged
        getPresentAddress()
    End Sub
    Public Sub getScholarship()
        Try
            str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "scholarships")

            cboScholarship.ValueMember = "scholarships"
            cboScholarship.DisplayMember = "Scholarship"
            cboScholarship.DataSource = ds.Tables("scholarships")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Public Sub getApplicationNo()
        Dim num As New System.Text.StringBuilder
        Dim rnd As New Random

        For count As Integer = 0 To 6
            num.Append(rnd.Next(0, 10).ToString)

        Next
        Dim Result As Decimal = CDec(num.ToString)
        txtApplicationNo.Text = Result
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSelectSchool3.ShowDialog()
    End Sub

    Public Sub getPhoto()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select profImage from profimage where StudentNumber='" & mskStudentNumber.Text & "'"

            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                Dim arrImage() As Byte
                arrImage = dtReader.Item(0)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox1.Image = Image.FromStream(mstream)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getPhoto()
    End Sub
    Public Sub saveImage()
        'convert image to byte
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        'declare arrImage as Byte to read buffer
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        str = "INSERT INTO profimage (profImage, StudentNumber) values(@Sub_Image,'" & mskStudentNumber.Text & "')"
        conn.Open()
        Dim mysc5 As New MySqlCommand(str, conn)
        'parameters for image
        mysc5.Parameters.AddWithValue("@Sub_Image", arrImage)
        mysc5.ExecuteNonQuery()
        'MessageBox.Show("Done!", "DialogBox", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Public Sub getStudentNumber()
        Try
            Dim StudentNo As String

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select StudentNumber from studeprofile order by StudentNumber desc"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                StudentNo = dtReader.Item(0).ToString

                Dim leftString = StudentNo.Split("-"c)(1)
                lblStudentNo.Text = leftString + 1
            End If

            mskStudentNumber.Text = lblStudeNoPrefix.Text & "-" & lblStudentNo.Text

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getAcctLevel()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from users where username='" & frmParent.lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblUserLevel.Text = dtReader(2)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub disableButtons()
        If lblUserLevel.Text = "Admin" Or lblUserLevel.Text = "Super Admin" Then
            tsDelete.Enabled = True

        Else
            tsDelete.Enabled = False

        End If
    End Sub



    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk5.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk6.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk7.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk8.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk9.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk10.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk11.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk12.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk13.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk14.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk15.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk16.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk17.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk18.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk19.CheckedChanged
        checkBox()
    End Sub

    Private Sub txtStatt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt1.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt10.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt2.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt11.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt3.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt12.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt4.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt13.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt5.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt14.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt6.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt15.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt7.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt16.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt8.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt17.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt9.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt18.TextChanged
        CheckTheRequirements()
    End Sub

    Private Sub txtStatt19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatt19.TextChanged
        CheckTheRequirements()
    End Sub

    Public Sub getRequirements()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from stude_requirements where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtStatt1.Text = dtReader.Item(22)
                txtStatt2.Text = dtReader.Item(23)
                txtStatt3.Text = dtReader.Item(24)
                txtStatt4.Text = dtReader.Item(25)
                txtStatt5.Text = dtReader.Item(26)
                txtStatt6.Text = dtReader.Item(27)
                txtStatt7.Text = dtReader.Item(28)
                txtStatt8.Text = dtReader.Item(29)
                txtStatt9.Text = dtReader.Item(30)
                txtStatt10.Text = dtReader.Item(31)
                txtStatt11.Text = dtReader.Item(32)
                txtStatt12.Text = dtReader.Item(33)
                txtStatt13.Text = dtReader.Item(34)
                txtStatt14.Text = dtReader.Item(35)
                txtStatt15.Text = dtReader.Item(36)
                txtStatt16.Text = dtReader.Item(37)
                txtStatt17.Text = dtReader.Item(38)
                txtStatt18.Text = dtReader.Item(39)
                txtStatt19.Text = dtReader.Item(40)

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class