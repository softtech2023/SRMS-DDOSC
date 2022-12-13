﻿Imports MySql.Data.MySqlClient
Public Class frmPayment
    Dim str As String
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
        PaymentHistory()
    End Sub

    Public Sub FormLoad()

        getDescription()

        mskStudentNumber.Text = frmBilling.mskStudentNumber.Text
        txtFname.Text = frmBilling.txtFname.Text
        txtMName.Text = frmBilling.txtMName.Text
        txtLastName.Text = frmBilling.txtLastName.Text

        tsSave.Enabled = True
        tsUpdate.Enabled = False

        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        txtAmount.Text = 0.0
        txtAddress.Clear()
        txtcheck.Clear()
        txtOR.Clear()
        txtTotalAccts.Text = 0.0
        txtCurrentPayments.Text = 0.0
        txtTotalPayments.Text = 0.0
        txtBalance.Text = 0.0
        txtDiscount.Text = 0.0

        'txtDiscount.Text = 0.0
        txtDescription.ResetText()
        mskStudentNumber.Focus()

        RadioButtonCash.Checked = True
        txtBalance.Enabled = False
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select max(ORNumber) from paymentsaccounts"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtOR.Text = dtReader.Item(0).ToString
                txtOR.Text = txtOR.Text + 1
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getDescription()
        Try
            str = "select * from otherfees_desc where feesType='Account' order by feesDesc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "otherfees_desc")

            txtDescription.ValueMember = "otherfees_desc"
            txtDescription.DisplayMember = "feesDesc"
            txtDescription.DataSource = ds.Tables("otherfees_desc")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub rdoCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCheck.Click
        txtcheck.Enabled = True
        txtcheck.Focus()
        txtBank.Enabled = True
    End Sub
    Private Sub rdocash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonCash.Click
        txtcheck.Enabled = False
        txtcheck.Clear()
        txtBank.Clear()
        txtBalance.Enabled = False
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ViewPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub CurrentBalance()
        Dim balance As Double
        balance = (Val(txtTotalAccts.Text)) - (Val(txtAmount.Text) + Val(txtCurrentPayments.Text) + Val(txtDiscount.Text))
        txtBalance.Text = Format(balance, "00.00")
    End Sub
    Public Sub getTotalPayments()
        Dim totalpayments As Double
        totalpayments = Val(txtAmount.Text) + Val(txtCurrentPayments.Text)
        txtTotalPayments.Text = Format(totalpayments, "00.00")
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        getTotalPayments()
        CurrentBalance()
    End Sub

    Private Sub txtTotalAccts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAccts.TextChanged
        CurrentBalance()
    End Sub

    Private Sub txtTotalPayments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrentPayments.TextChanged
        CurrentBalance()
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnSave.PerformClick()
    End Sub

    Public Sub CourseCode()
        Try
            str = "select * from course_table where CourseDescription='" & lblCourse.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                lblCourseCode.Text = mysDR(1)
            End While


            mysDR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        CourseCode()
        PaymentHistory()
        CurrentBalance()
    End Sub
    Public Sub PaymentHistory()
        Try
            str = "select description, Amount,  PDate, ORNumber from paymentsaccounts where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and CollectionSource!='Services'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            dg1.DataSource = ds.Tables("paymentsaccounts")
            conn.Close()

            dg1.Columns(0).HeaderText = "Description"
            dg1.Columns(0).Width = 115
            dg1.Columns(1).Width = 70
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(3).HeaderText = "O.R. No"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub SelectPayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectPayorToolStripMenuItem.Click
        frmSearchAccountforPayments.ShowDialog()
    End Sub

    Private Sub AcceptPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Dim Source As String
        Source = lblSource.Text.Replace("'", "''")

        Dim radiobutton As String
        radiobutton = ""
        If RadioButtonCash.Checked = True Then
            radiobutton = "Cash"
        End If
        If RadioButtonCheck.Checked = True Then
            radiobutton = "Check"
        End If

        If mskStudentNumber.Text = "" Then
            MsgBox("Student Number is missing!", MsgBoxStyle.Critical)
            mskStudentNumber.Focus()
            Exit Sub
        End If

        If txtOR.Text = "" Then
            MsgBox("Please enter O.R. Number!", MsgBoxStyle.Critical)
            txtOR.Focus()
            Exit Sub
        End If
        If txtAmount.Text = "" Or txtAmount.Text = 0 Then
            MsgBox("Please enter the correct amount!", MsgBoxStyle.Critical)
            txtAmount.Focus()
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Payment description is required!", MsgBoxStyle.Critical)
            txtDescription.Focus()
            Exit Sub
        End If

        Try
            str = "select * from paymentsaccounts where ORNumber='" & txtOR.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "paymentsaccounts")
            conn.Close()

            If ds.Tables("paymentsaccounts").Rows.Count = 1 Then
                MsgBox("O.R. Number already in used!", MsgBoxStyle.Exclamation)
                conn.Close()
                txtOR.Focus()
                Exit Sub
            End If

            str = "insert into paymentsaccounts values('0','" & mskStudentNumber.Text & "','" & txtFname.Text & "','" & txtMName.Text & "','" & txtLastName.Text & "','" & lblCourseCode.Text & "','" & Convert.ToDateTime(frmParent.dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtOR.Text & "','" & txtAmount.Text & "','" & txtDescription.Text & "','" & radiobutton & "','" & txtcheck.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "','" & Source & "','" & txtBank.Text & "','" & lblORStatus.Text & "','" & frmParent.lblUser.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()


            'confirm enrollment
            str = "update semesterstude set StudentNumber='" & mskStudentNumber.Text & "',Status='" & lblEnrolled.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysc3 As New MySqlCommand(str, conn)
            mysc3.ExecuteNonQuery()
            conn.Close()


            'update billing
            str = "update studeaccount set StudentNumber='" & mskStudentNumber.Text & "',AcctTotal='" & txtTotalAccts.Text & "',TotalPayments='" & txtTotalPayments.Text & "',CurrentBalance='" & txtBalance.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmParent.lblSY.Text & "' and Sem='" & frmParent.lblSem.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            MsgBox("Payment has been acknowledged!", MsgBoxStyle.Information)
            conn.Close()

            'Printing

            'If (MsgBox("Payment has been acknowledged! Do you want to print the Official Receipt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            'str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.Course, ss.YearLevel, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.CheckNumber, pa.Sem, pa.SY, sa.CurrentBalance from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join studeaccount sa on pa.StudentNumber=sa.StudentNumber where pa.ORNumber='" & txtOR.Text & "' and pa.Sem='" & frmParent.lblSem.Text & "' and pa.SY='" & frmParent.lblSY.Text & "'"
            'conn.Open()
            'Dim mysda2 As New MySqlDataAdapter(str, conn)
            'Dim ds2 As New DataSet
            'mysda2.Fill(ds2, "studeprofile, semesterstude, paymentsaccounts")
            'Dim obj As New OfficialReceipt
            'obj.SetDataSource(ds2.Tables("studeprofile, semesterstude, paymentsaccounts"))
            'frmMainViewer.ReportViewer.ReportSource = obj
            'frmMainViewer.ReportViewer.Refresh()
            'frmMainViewer.MdiParent = frmParent
            'frmMainViewer.Show()
            conn.Close()
            'End If

            FormLoad()
            PaymentHistory()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ReprintORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintORToolStripMenuItem.Click
        Try
            If txtOR.Text = "" Then
                MsgBox("Please enter O.R. Number!", MsgBoxStyle.Critical)
                txtOR.Focus()
                Exit Sub
            End If
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, ss.Course, ss.YearLevel, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.CheckNumber, pa.Sem, pa.SY, pa.Address, sa.CurrentBalance from studeprofile p join paymentsaccounts pa on p.StudentNumber=pa.StudentNumber join semesterstude ss on p.StudentNumber=ss.StudentNumber join studeaccount sa on pa.StudentNumber=sa.StudentNumber where pa.ORNumber='" & txtOR.Text & "' and pa.Sem='" & frmParent.lblSem.Text & "' and pa.SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile, semesterstude, paymentsaccounts")
            'Dim obj As New OfficialReceipt
            'obj.SetDataSource(ds.Tables("studeprofile, semesterstude, paymentsaccounts"))
            'frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub UpdatePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "update paymentsaccounts set ORNumber='" & txtOR.Text & "',Amount='" & txtAmount.Text & "',description='" & txtDescription.Text & "' where ID='" & lblPaymentID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record has been updated!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub SearchPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsView.Click
        frmEditPayments.ShowDialog()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        CurrentBalance()
    End Sub


End Class