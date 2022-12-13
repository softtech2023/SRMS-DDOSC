Imports MySql.Data.MySqlClient
Public Class frmBilling
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFees.Click
        frmAddFees.ShowDialog()
    End Sub

    Private Sub frmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formload()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFees.Click
        Try
            Dim i As Integer

            lvAccts.Select()

            If lvAccts.Items.Count = 0 Then
                MsgBox("Cannot find any date to remove", MsgBoxStyle.Information)
                Exit Sub

            Else
                i = lvAccts.FocusedItem.Index
                lvAccts.Items.RemoveAt(i)
            End If

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Public Sub getSubTotals()
        Dim SubTotal As Double
        For x As Integer = 0 To lvAccts.Items.Count - 1
            SubTotal += Val(lvAccts.Items(x).SubItems(1).Text)
        Next

        txtTotalFees.Text = SubTotal

    End Sub

    Public Sub getTotalAccount()
        Dim TotalAccount As Double
        TotalAccount = Val(txtTotalFees.Text) + Val(txtTuition.Text) + Val(txtSpecialTuition.Text)
        txtTotalAcct.Text = TotalAccount

    End Sub

    Public Sub getBalance()
        Dim Balance As Double
        Balance = (Val(txtTotalAcct.Text)) - (Val(txtPayments.Text) + Val(txtDiscount.Text))
        txtBalance.Text = Balance
    End Sub

    Public Sub getDiscount()
        Dim Discount As Double
        Discount = Val(txtTotalAcct.Text) - Val(txtDiscount.Text)
        txtBalance.Text = Discount

    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getSubTotals()
        getTotalAccount()
        getBalance()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub txtTotalLecUnits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalLecUnits.TextChanged
        ComputeTuition()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtLecRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecRate.TextChanged
        ComputeTuition()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtDiscountPerecentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getDiscount()
        getBalance()
    End Sub

    Public Sub Formload()
        btnPayment.Enabled = False
        btnPaymentHistory.Enabled = False
        'btnPrintLedger.Enabled = False

        lvAccts.Columns.Add("Description", 410)
        lvAccts.Columns.Add("Amount", 95)
        lvAccts.Columns.Add("Fees Type", 0)
        Me.lvAccts.View = View.Details
        Me.lvAccts.GridLines = True

        lvAccts.Items.Clear()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboCourse.ResetText()
        cboYear.ResetText()
        txtSection.Clear()
        txtTotalLecUnits.Text = 0
        txtTotalLabUnits.Text = 0
        txtTotalAcct.Text = 0
        txtPayments.Text = 0
        txtTuition.Text = 0
        txtLab.Text = 0
        txtOldAccount.Text = 0
        txtDiscount.Text = 0
        txtSpecialTuition.Text = 0
        lblSpecialLabFee.Text = 0
        lblTotalLab.Text = 0

        tsNew.Enabled = True
        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        btnLoadUpdatedFees.Enabled = False
        btnCompute.PerformClick()

        schoolInfo()

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPayment.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchBilling.ShowDialog()
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub
    Private Sub txtTuition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTuition.TextChanged
        getTotalAccount()
    End Sub

    Private Sub txtLab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLab.TextChanged
        getTotalAccount()
    End Sub
    Public Sub ComputeTuition()
        Dim tuitionfee As Double
        tuitionfee = ((Val(txtTotalLecUnits.Text) + Val(txtTotalLabUnits.Text)) * Val(txtLecRate.Text)) + (Val(txtTotalLecUnitsNight.Text) + Val(txtTotalLabUnitsNight.Text)) * Val(txtLecRateNight.Text)
        txtTuition.Text = tuitionfee

        txtTotalLecDay.Text = (Val(txtTotalLecUnits.Text) + Val(txtTotalLabUnits.Text)) * Val(txtLecRate.Text)
        txtTotalLecNight.Text = (Val(txtTotalLecUnitsNight.Text) + Val(txtTotalLabUnitsNight.Text)) * Val(txtLecRateNight.Text)

    End Sub

    Private Sub txtTotalAcct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAcct.TextChanged
        getBalance()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getBalance()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldAcct.Click
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.LecUnits, b.LecRate, b.LabUnits, b.LabRate, b.OldAccount, TotalLec, b.TotalLab, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, b.Sem, b.SY, b.AccountID from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' order by b.AccountID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtOldAccount.Text = dtReader.Item(14)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvAccts.Clear()
    End Sub
    Private Sub txtRegFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getTotalAccount()
    End Sub

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        lvAccts.Items.Clear()
        Formload()
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from studeaccount where StudentNumber like '" & mskStudentNumber.Text & "%' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysDA1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet

            mysDA1.Fill(ds1, "studeaccount")

            If ds1.Tables("studeaccount").Rows.Count > 0 Then

                MsgBox("Cannot save this account.  Student number already exist!", MsgBoxStyle.Critical)
                conn.Close()
                Exit Sub

            End If

            conn.Close()
            'str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & Me.lblSem.Text & "' and SY='" & Me.lblSY.Text & "'"
            'conn.Open()
            'Dim mysc1 As New MySqlCommand(str, conn)
            'mysc1.ExecuteNonQuery()
            'conn.Close()

            If lvAccts.Items.Count = 0 Then
                MsgBox("No Fees Added!", MsgBoxStyle.Critical)
                Exit Sub
            End If


            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & txtTotalLecUnits.Text & "','" & txtLecRate.Text & "','" & txtTotalLecDay.Text & "','" & txtTotalLabUnits.Text & "','" & txtLabRate.Text & "','" & txtTotalLabDay.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & lvAccts.Items(i).SubItems(2).Text & "','" & txtTotalFees.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtSection.Text & "','" & lblSettingsID.Text & "','" & txtTotalLecDay.Text & "','" & txtTotalLabDay.Text & "','" & txtTotalLecNight.Text & "','" & txtTotalLabNight.Text & "','" & txtTotalLecNight.Text & "','" & txtLecRateNight.Text & "','" & txtTotalLabNight.Text & "','" & txtLabRateNight.Text & "','" & txtTuition.Text & "','" & txtLab.Text & "','" & txtSpecialTuition.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

            'Audit Trail
            str = "insert into atrail values('0','Encoded student''s account','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record Saved!!", MsgBoxStyle.Information)
            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "select * from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount")

            If ds.Tables("studeaccount").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Information)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & txtTotalLecUnits.Text & "','" & txtLecRate.Text & "','" & txtTotalLecDay.Text & "','" & txtTotalLabUnits.Text & "','" & txtLabRate.Text & "','" & txtTotalLabDay.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & lvAccts.Items(i).SubItems(2).Text & "','" & txtTotalFees.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & txtSection.Text & "','" & lblSettingsID.Text & "','" & txtTotalLecDay.Text & "','" & txtTotalLabDay.Text & "','" & txtTotalLecNight.Text & "','" & txtTotalLabNight.Text & "','" & txtTotalLecNight.Text & "','" & txtLecRateNight.Text & "','" & txtTotalLabNight.Text & "','" & txtLabRateNight.Text & "','" & txtTuition.Text & "','" & txtLab.Text & "')"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()
            Next

            'Audit Trail
            str = "insert into atrail values('0','Encoded student''s account','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record Saved!!", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsViewAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsViewAccounts.Click
        Try
            Formload()
            lvAccts.Items.Clear()
            frmSearchBilling.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        tsViewAccounts.PerformClick()
    End Sub
    Public Sub LoadFees()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM fees where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Major='" & lblMajor.Text & "' and Description!='Laboratory Fee'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(1)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(7))
                'lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(0)
                'lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(2))
                'lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(3)
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
   
    Public Sub CourseFees()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from coursefees where Course='" & cboCourse.Text & "' and Major='" & lblMajor.Text & "' and Session='DAY'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtLecRate.Text = dtReader.Item(3)
                txtLabRate.Text = dtReader.Item(4)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub CourseFees_Night()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from coursefees where Course='" & cboCourse.Text & "' and Major='" & lblMajor.Text & "' and Session='NIGHT'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtLecRateNight.Text = dtReader.Item(3)
                txtLabRateNight.Text = dtReader.Item(4)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAcct()
        Try

            Dim dt As New DataTable
            str = "SELECT * FROM studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(14)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(15))
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(16))
            Next
            conn.Close()
            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Deleted student''s account','" & frmParent.dtpDate.Text & "','" & frmParent.stTime.Text & "','" & frmParent.lblUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc8 As New MySqlCommand(str, conn)
                mysc8.ExecuteNonQuery()
                conn.Close()

                MsgBox("Selected account has been deleted!", MsgBoxStyle.Information)
                Formload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtInstallmentFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getTotalAccount()
    End Sub

    Private Sub txtDiscount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged

        getDiscount()
        getBalance()
    End Sub

    Private Sub btnPaymentHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmViewPaymentHistory.ShowDialog()
    End Sub
    Public Sub addTuition()
        lvAccts.Items.Add("Tuition Fee") '
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(txtTuition.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(0)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(txtTuition.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add("Unpaid")
        getSubTotals()
    End Sub
    Public Sub addLaboratory()
        lvAccts.Items.Add("Laboratory Fee") '
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(txtLab.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(0)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(txtLab.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add("Unpaid")

        getSubTotals()
    End Sub

    Public Sub oldAccount()

        lvAccts.Items.Add("Old Account") '
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(txtOldAccount.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add("Other Fees")

        getSubTotals()

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
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalUnitsDay()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select p.StudentNumber, sum(r.LecUnit), sum(r.LabUnit), r.SY, r.Sem from studeprofile p join registration r on p.StudentNumber=r.StudentNumber where r.SubjectCode!='NSTP 1' and r.SubjectCode!='NSTP 2' and r.SubjectCode!='ROTC 1' and r.SubjectCode!='ROTC 2' and r.schedType='DAY' and p.StudentNumber='" & mskStudentNumber.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' group by r.StudentNumber"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtTotalLecUnits.Text = dtReader.Item(1)
                txtTotalLabUnits.Text = dtReader.Item(2)
            End If
            'Dim test As Double
            'test = Val(lblInitialUnits.Text) - Val(lblNSTP.Text)
            'txtTotalLecUnits.Text = test
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalUnitsNight()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select p.StudentNumber, sum(r.LecUnit), sum(r.LabUnit), r.SY, r.Sem from studeprofile p join registration r on p.StudentNumber=r.StudentNumber where r.SubjectCode!='NSTP 1' and r.SubjectCode!='NSTP 2' and r.SubjectCode!='ROTC 1' and r.SubjectCode!='ROTC 2' and r.schedType='NIGHT' and p.StudentNumber='" & mskStudentNumber.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' group by r.StudentNumber"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtTotalLecUnitsNight.Text = dtReader.Item(1)
                txtTotalLabUnitsNight.Text = dtReader.Item(2)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
   
    Private Sub mskStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        getTotalUnitsDay()
        getTotalUnitsNight()
        ComputeTuition()
    End Sub

    Private Sub txtTotalLecUnitsNight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalLecUnitsNight.TextChanged
        ComputeTuition()
        getTotalAccount()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtLecRateNight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecRateNight.TextChanged
        ComputeTuition()
        getTotalAccount()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtTotalLabUnitsNight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalLabUnitsNight.TextChanged
        getTotalAccount()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtLabRateNight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLabRateNight.TextChanged
        getTotalAccount()
        btnCompute.PerformClick()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaymentHistory.Click
        frmViewPaymentHistory.ShowDialog()
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        frmPayment.ShowDialog()

        frmPayment.mskStudentNumber.Text = mskStudentNumber.Text
    End Sub

    Private Sub btnAddLabFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLabFees.Click
        'frmAdditionalLabFee.lblCurrentLabFee.Text = txtLab.Text
        Dim labunits As Integer
        labunits = Val(txtTotalLabUnits.Text) + Val(txtTotalLabUnitsNight.Text)
        frmAdditionalLabFee.txtLabUnit.Text = labunits
        frmAdditionalLabFee.lblLabFeeRate.Text = txtLabRate.Text

        frmAdditionalLabFee.ShowDialog()

    End Sub

    Private Sub btnAddOldAcct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOldAcct.Click
        oldAccount()
        btnCompute.PerformClick()
    End Sub

    Private Sub txtSpecialTuition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSpecialTuition.TextChanged
        getTotalAccount()
    End Sub
    Public Sub specialLabFee()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSpecialLabFee.Text = dtReader.Item(23)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub regularLabFee()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT * FROM fees where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Major='" & lblMajor.Text & "' and Description!='Laboratory Fee'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSpecialLabFee.Text = dtReader.Item(23)
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getTotalLab()
        Dim labfee As Double
        Dim totalLab As Double
        labfee = (Val(txtTotalLabUnits.Text) * Val(txtLabRate.Text)) + (Val(txtTotalLabUnitsNight.Text) * Val(txtLabRateNight.Text))
        totalLab = Val(lblSpecialLabFee.Text) + labfee
        txtLab.Text = totalLab
        lblTotalLab.Text = totalLab

        lvAccts.Items.Add("Laboratory Fee") '
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(lblTotalLab.Text)
        lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add("Other Fees")

        'frmBilling.txtLab.Text = txtNewLabTotal.Text
        getSubTotals()
        btnCompute.PerformClick()

    End Sub
End Class