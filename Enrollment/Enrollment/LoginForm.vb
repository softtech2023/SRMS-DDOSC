Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim str As String
    Dim str2 As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim level As String

        str = "select * from users where username='" & txtUserName.Text & "' and password='" & txtpassword.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "users")

        ' MsgBox(level, MsgBoxStyle.Information)

        If ds.Tables("users").Rows.Count = 1 Then
            level = ds.Tables("users").Rows(0).Item(3)
            If level.Equals("Admin") Then
                frmParent.tsAdmin.Enabled = True
                frmParent.tsAdmission.Enabled = True

            End If
            If level.Equals("Registrar") Then
                frmParent.tsAdmin.Enabled = False
                frmParent.tsAdmission.Enabled = False


            End If


            If level.Equals("Student") Then
                frmParent.tsAdmin.Enabled = False

                frmParent.tsAdmission.Enabled = False

                frmParent.tsmMaintenance.Enabled = False

            End If

            frmParent.lblUser.Text = txtUserName.Text
            ChangeSem.ShowDialog()
            Me.Hide()

        Else
            MsgBox("Access Denied", MsgBoxStyle.Information)
            txtUserName.Clear()
            txtpassword.Clear()
            conn.Close()
            Exit Sub
        End If
        conn.Close()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtUserName.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim level As String
            Dim pass As String

            pass = getSHA1Hash(txtpassword.Text)

            str = "select * from users where username='" & txtUserName.Text & "' and password='" & pass & "' and acctStat='active'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")

            ' MsgBox(level, MsgBoxStyle.Information)

            If ds.Tables("users").Rows.Count = 1 Then
                level = ds.Tables("users").Rows(0).Item(2)
                If level.Equals("Super Admin") Then
                    frmPayment.tsView.Visible = True
                    frmParent.tsHR.Visible = False
                  
                End If
                If level.Equals("Admin") Or level.Equals("President") Or level.Equals("VP/Dean") Then
                    frmPayment.tsView.Visible = False
                    frmPayment.tsUpdate.Visible = False
                    frmPayment.tsView.Visible = False
                    frmParent.tsHR.Visible = False
                    frmParent.tsUpdateScholarship.Visible = True
                    'frmParent.StudToolStripMenuItem.Visible = True
                End If

                If level.Equals("Accounting") Or level.Equals("Cashier") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.tsAdmission.Visible = False
                    frmParent.tsCashier.Visible = True
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem1.Visible = False
                    frmParent.MasterlistToolStripMenuItem.Visible = False
                    frmParent.MasterlistToolStripMenuItem2.Visible = False
                    frmParent.FTERecordsToolStripMenuItem.Visible = False
                    frmParent.PromissoryNotesToolStripMenuItem.Visible = False
                    frmParent.PromissoryNoteToolStripMenuItem1.Visible = False
                    frmParent.ClassRoomSchedulesToolStripMenuItem.Visible = False
                    frmParent.ClassSchedule.Visible = False
                    frmParent.tsmFinancialReports.Visible = True
                    frmParent.tsUpdateScholarship.Visible = False
                    frmParent.tsGraduates.Visible = False
                End If

                If level.Equals("Guidance") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.tsAdmission.Visible = True
                    frmParent.SemesterStudentToolStripMenuItem.Visible = False
                    'frmParent.CertificateOfRegistrationToolStripMenuItem1.Visible = False
                    frmParent.CertificateOfRegistrationToolStripMenuItem2.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem1.Visible = False
                    frmParent.FacultyToolStripMenuItem.Visible = False
                    frmParent.FTERecordsToolStripMenuItem.Visible = False
                    frmParent.FTERecordsToolStripMenuItem1.Visible = False
                    frmParent.PromissoryNotesToolStripMenuItem.Visible = False
                    frmParent.PromissoryNoteToolStripMenuItem1.Visible = False
                    frmParent.ClassRoomSchedulesToolStripMenuItem.Visible = False
                    frmParent.ClassSchedule.Visible = False
                    frmParent.tsmFinancialReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    'frmParent.StudToolStripMenuItem.Visible = False
                End If

                If level.Equals("HR Staff") Then
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsAdmission.Visible = False
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem.Enabled = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Enabled = False
                    frmParent.CoursesToolStripMenuItem1.Enabled = False
                    frmParent.RoomsAndSectionsToolStripMenuItem.Enabled = False
                    frmParent.RoomsAndSectionsToolStripMenuItem1.Enabled = False
                    frmParent.SubjectsToolStripMenuItem2.Enabled = False
                    frmParent.SemesterSchedulingToolStripMenuItem.Enabled = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Enabled = False
                    frmParent.ScholarshipsToolStripMenuItem.Enabled = False
                    frmParent.ScholarshipToolStripMenuItem.Enabled = False
                    frmParent.tsReports.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.FTERecordsToolStripMenuItem.Visible = False
                    frmParent.FTERecordsToolStripMenuItem1.Visible = False
                    frmParent.PromissoryNotesToolStripMenuItem.Visible = False
                    frmParent.PromissoryNoteToolStripMenuItem1.Visible = False
                    frmParent.ClassRoomSchedulesToolStripMenuItem.Visible = False
                    frmParent.ClassSchedule.Visible = False
                    frmParent.tsmFinancialReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    frmParent.StudToolStripMenuItem.Visible = False
                    frmParent.tsCustodianMenu.Visible = False
                End If

                If level.Equals("Registrar") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = True
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.tsAdmission.Visible = True
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = True
                    frmParent.tsReports.Visible = True
                    frmParent.tsmFinancialReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    'frmParent.StudToolStripMenuItem.Visible = True
                    frmParent.tsCustodianMenu.Visible = False
                End If

                If level.Equals("Program Coordinator") Then
                    frmParent.progCoor.Visible = True
                    frmParent.tsFile.Visible = False
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.tsAdmission.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = False
                    frmParent.tsmFinancialReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    'frmParent.StudToolStripMenuItem.Visible = False
                    frmParent.msMain.Visible = False
                End If

                If level.Equals("Encoder") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.FacultyAndStaffToolStripMenuItem.Visible = False
                    frmParent.FacultyToolStripMenuItem.Visible = False
                    frmParent.CoursesToolStripMenuItem1.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem1.Visible = False
                    frmParent.SubjectsToolStripMenuItem2.Visible = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.ScholarshipsToolStripMenuItem.Visible = False
                    frmParent.ScholarshipToolStripMenuItem.Visible = False
                    frmParent.tsAdmission.Visible = True
                    frmParent.AddingFormToolStripMenuItem.Visible = True
                    frmParent.DroppingFormToolStripMenuItem.Visible = True
                    frmParent.NewStudentToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolFormToolStripMenuItem1.Visible = False
                    frmParent.PreviousSchoolsToolStripMenuItem.Visible = False
                    frmParent.tsGraduates.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    frmParent.StudToolStripMenuItem.Visible = False


                End If

                If level.Equals("Property Custodian") Then
                    frmParent.tsFile.Visible = False
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.FacultyAndStaffToolStripMenuItem.Visible = False
                    frmParent.FacultyToolStripMenuItem.Visible = False
                    frmParent.CoursesToolStripMenuItem1.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem1.Visible = False
                    frmParent.SubjectsToolStripMenuItem2.Visible = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.ScholarshipsToolStripMenuItem.Visible = False
                    frmParent.ScholarshipToolStripMenuItem.Visible = False
                    frmParent.tsAdmission.Visible = False
                    frmParent.AddingFormToolStripMenuItem.Visible = True
                    frmParent.DroppingFormToolStripMenuItem.Visible = True
                    frmParent.NewStudentToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolFormToolStripMenuItem1.Visible = False
                    frmParent.PreviousSchoolsToolStripMenuItem.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    frmParent.StudToolStripMenuItem.Visible = False
                    frmParent.tsGraduates.Visible = False

                End If

                If level.Equals("Scholarship Coordinator") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.FacultyAndStaffToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyToolStripMenuItem.Visible = False
                    frmParent.CoursesToolStripMenuItem1.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem1.Visible = False
                    frmParent.SubjectsToolStripMenuItem2.Visible = False
                    frmParent.SemesterSchedulingToolStripMenuItem.Visible = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolsToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolFormToolStripMenuItem1.Visible = False
                    frmParent.tsAdmission.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.EnrollmentReportToolStripMenuItem1.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem1.Visible = False
                    frmParent.FTERecordsToolStripMenuItem.Visible = False
                    frmParent.FTERecordsToolStripMenuItem1.Visible = False
                    frmParent.PromissoryNotesToolStripMenuItem.Visible = False
                    frmParent.PromissoryNoteToolStripMenuItem1.Visible = False
                    frmParent.ClassRoomSchedulesToolStripMenuItem.Visible = False
                    frmParent.ClassSchedule.Visible = False
                    frmParent.CashReceiptsRecordToolStripMenuItem.Visible = False
                    frmParent.CashReceiptsRecordToolStripMenuItem1.Visible = False
                    frmParent.DailyCollectionReportsToolStripMenuItem.Visible = False
                    frmParent.DailyCollectionReportsToolStripMenuItem1.Visible = False
                    frmParent.DailyCollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.ExpensesReportsToolStripMenuItem.Visible = False
                    frmParent.ExpensesToolStripMenuItem1.Visible = False
                    frmParent.IncomeStatementToolStripMenuItem.Visible = False
                    frmParent.ORTrackingToolStripMenuItem.Visible = False
                    frmParent.ListOfVoidReceiptsToolStripMenuItem.Visible = False
                    frmParent.DailyCollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.CollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.tsUpdateScholarship.Visible = True
                    'frmParent.StudToolStripMenuItem.Visible = True
                    frmParent.tsCustodianMenu.Visible = False
                End If

                If level.Equals("Student") Then
                    'frmParent.msMain.Hide()
                    'frmParent.mnuStudent.Show()
                    'frmParent.tsHR.Visible = False
                    MsgBox("Access Denied", MsgBoxStyle.Exclamation)
                    conn.Close()
                    Exit Sub

                End If



                If level.Equals("Instructor") Then
                    frmParent.msMain.Hide()
                    frmParent.Instuctor.Show()
                End If

                If level.Equals("OSAS Personnel") Then
                    frmParent.tsFile.Visible = True
                    frmParent.tsmMaintenance.Visible = False
                    frmParent.tsAdmin.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem.Visible = False
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.FacultyAndStaffToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyToolStripMenuItem.Visible = False
                    frmParent.CoursesToolStripMenuItem1.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem.Visible = False
                    frmParent.RoomsAndSectionsToolStripMenuItem1.Visible = False
                    frmParent.SubjectsToolStripMenuItem2.Visible = False
                    frmParent.SemesterSchedulingToolStripMenuItem.Visible = False
                    frmParent.ManageUserAcctsToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolsToolStripMenuItem.Visible = False
                    frmParent.PreviousSchoolFormToolStripMenuItem1.Visible = False
                    frmParent.tsAdmission.Visible = True
                    frmParent.NewStudentToolStripMenuItem.Visible = True
                    frmStudeProfile.tsSave.Visible = False
                    frmStudeProfile.tsUpdate.Visible = False
                    frmStudeProfile.tsDelete.Visible = False
                    frmParent.SemesterStudentToolStripMenuItem.Visible = False
                    'frmParent.CertificateOfRegistrationToolStripMenuItem1.Visible = False
                    frmParent.CertificateOfRegistrationToolStripMenuItem2.Visible = False
                    frmParent.PreviousSchoolFormToolStripMenuItem1.Visible = False
                    frmParent.PreviousSchoolsToolStripMenuItem.Visible = False
                    frmParent.tsCashier.Visible = False
                    frmParent.tsRegistrar.Visible = False
                    frmParent.tsReports.Visible = True
                    frmParent.AcademicCalendarToolStripMenuItem1.Visible = False
                    frmParent.EnrollmentReportToolStripMenuItem1.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem.Visible = False
                    frmParent.FacultyLoadingToolStripMenuItem1.Visible = False
                    frmParent.FTERecordsToolStripMenuItem.Visible = False
                    frmParent.FTERecordsToolStripMenuItem1.Visible = False
                    frmParent.PromissoryNotesToolStripMenuItem.Visible = False
                    frmParent.PromissoryNoteToolStripMenuItem1.Visible = False
                    frmParent.ClassRoomSchedulesToolStripMenuItem.Visible = False
                    frmParent.ClassSchedule.Visible = False
                    frmParent.CashReceiptsRecordToolStripMenuItem.Visible = False
                    frmParent.CashReceiptsRecordToolStripMenuItem1.Visible = False
                    frmParent.DailyCollectionReportsToolStripMenuItem.Visible = False
                    frmParent.DailyCollectionReportsToolStripMenuItem1.Visible = False
                    frmParent.DailyCollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.ExpensesReportsToolStripMenuItem.Visible = False
                    frmParent.ExpensesToolStripMenuItem1.Visible = False
                    frmParent.IncomeStatementToolStripMenuItem.Visible = False
                    frmParent.ORTrackingToolStripMenuItem.Visible = False
                    frmParent.ListOfVoidReceiptsToolStripMenuItem.Visible = False
                    frmParent.DailyCollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.CollectionSummaryToolStripMenuItem.Visible = False
                    frmParent.tsUpdateScholarship.Visible = False
                    'frmParent.StudToolStripMenuItem.Visible = False
                    frmParent.tsCustodianMenu.Visible = False
                End If

                frmParent.lblUser.Text = txtUserName.Text
                ChangeSem.ShowDialog()
                Me.Hide()

            Else
                MsgBox("Access Denied", MsgBoxStyle.Exclamation)
                txtUserName.Clear()
                txtpassword.Clear()
                conn.Close()
                Exit Sub
            End If
            conn.Close()
            Me.Close()

            frmParent.getAcctLevel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

End Class
