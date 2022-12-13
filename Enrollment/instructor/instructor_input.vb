Imports MySql.Data.MySqlClient
Public Class frminstructor_input
    Dim str As String
  
    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & frmParent.lblUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        tsSave.Enabled = False
        Clear()
        schoolInfo()
        seqID()
    End Sub

    Private Sub frminstructor_input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()

    End Sub
    Public Sub Clear()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
        dg1.DataSource = Nothing
        dg1.Rows.Clear()
        dg1.Columns.Clear()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmInstructor_Search_Grades.ShowDialog()
    End Sub
    Public Sub Grades()
        Try
            'str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, r.courseCode, s.Major from registration r join semesterstude s on s.StudentNumber=r.StudentNumber where r.SubjectCode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
            str = "select StudentNumber, concat(LastName,', ',FirstName) as Fullname, Course, Major from registration where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Section='" & txtSection.Text & "' order by Fullname"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet
            mysDA.Fill(ds1, "registration, semesterstude")
            dg1.DataSource = ds1.Tables("registration, semesterstude")
            'dg1.Columns.Add("FGrade", "Final Grade")
            ' dg1.Columns(0).Visible = False
            conn.Close()

            dg1.Columns(0).Width = 100
            dg1.Columns(1).Width = 180
            dg1.Columns(1).Visible = True
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False

            conn.Close()

            'getNames()
            'getGrades()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        'Grades()
        getStatus()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtSubjectcode.Text = "" Then
                MsgBox("Select subject first before saving!", MsgBoxStyle.Information)
                Exit Sub
            End If

            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            conn.Close()

            If ds.Tables("grades").Rows.Count >= 1 Then
                'code kung nag exist

                str = "delete from grades where Section='" & txtSection.Text & "' and SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                conn1.Open()
                Dim mysC1 As New MySqlCommand(str, conn1)
                mysC1.ExecuteNonQuery()

                conn1.Close()
            End If

            For x As Integer = 0 To dg1.Rows.Count - 1

                str = "insert into grades values('0','" & dg1.Item(4, x).Value & "','','" & txtSubjectcode.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblTerm.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txtDescription.Text & "','" & lblSchool.Text & "','" & lblLecUnit.Text & "','" & lblLabUnit.Text & "','" & cboStatus.Text & "','" & lblSettingsID.Text & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & lblSeqID.Text & "')"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()
            Next
            MsgBox("Grades successfully saved!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
        Clear()
    End Sub
    Public Sub getStatus()
        Try
            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Instructor='" & txtInstructor.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by sStatus"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")

            cboStatus.ValueMember = "grades"
            cboStatus.DisplayMember = "sStatus"
            cboStatus.DataSource = ds.Tables("grades")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub disableSave()
        If cboStatus.Text = "Closed" Then
            tsSave.Enabled = False
            dg1.ReadOnly = True
        Else
            tsSave.Enabled = True
            dg1.ReadOnly = False
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub SelectSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectSubjectToolStripMenuItem.Click
        frmInstructor_Search_Grades.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
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
                lblSchool.Text = dtReader(1)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub seqID()
        If frmParent.lblSem.Text = "First Semester" Then
            lblSeqID.Text = 1

        ElseIf frmParent.lblSem.Text = "Second Semester" Then
            lblSeqID.Text = 2
        Else
            lblSeqID.Text = 3
        End If
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged

    End Sub
End Class