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
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmInstructor_Search_Grades.ShowDialog()
    End Sub
    Public Sub Grades()
        Try
            str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.Final, g.Complied, g.Section from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "registration, semsubjects, grades")

            dg1.Columns.Clear()
            If ds.Tables("registration, semsubjects, grades").Rows.Count >= 1 Then
                'kung naa nay grades e-display sa datagrid

                'dg1.Columns(0).Visible = False
                dg1.DataSource = ds.Tables("registration, semsubjects, grades")

                conn.Close()
                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(4).Visible = False
                conn.Close()
            Else
                str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname from registration r join semesterstude s on s.StudentNumber=r.StudentNumber where r.SubjectCode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
                conn1.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn1)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "registration, semesterstude")
                dg1.DataSource = ds1.Tables("registration, semesterstude")
                dg1.Columns.Add("FGrade", "Final Grade")
                ' dg1.Columns(0).Visible = False
                conn1.Close()
                conn.Close()
            End If
            conn.Close()

            'getNames()
            'getGrades()

            dg1.Columns(0).Width = 100
            dg1.Columns(1).Width = 180
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        Grades()
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
            If ds.Tables("grades").Rows.Count >= 1 Then
                'code kung nag exist
                str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "' and Section='" & txtSection.Text & "'"
                conn1.Open()
                Dim mysC As New MySqlCommand(str, conn1)
                mysC.ExecuteNonQuery()
                conn1.Close()

                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & txtSubjectcode.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblTerm.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txtDescription.Text & "','" & lblSchool.Text & "','" & lblLecUnit.Text & "','" & lblLabUnit.Text & "','" & cboStatus.Text & "','" & lblSettingsID.Text & "')"
                    conn1.Open()
                    Dim mysC1 As New MySqlCommand(str, conn1)
                    mysC1.ExecuteNonQuery()

                    conn1.Close()

                Next
                MsgBox("Grades successfully inserted", MsgBoxStyle.Information)
                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(2, x).Value & "','','" & txtSubjectcode.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblTerm.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txtDescription.Text & "','" & lblSchool.Text & "','" & lblLecUnit.Text & "','" & lblLabUnit.Text & "','" & cboStatus.Text & "','" & lblSettingsID.Text & "')"
                    conn1.Open()
                    Dim mysC2 As New MySqlCommand(str, conn1)
                    mysC2.ExecuteNonQuery()
                    conn1.Close()
                Next
                MsgBox("Grades successfully inserted", MsgBoxStyle.Information)
            End If
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
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class