Imports MySql.Data.MySqlClient
Public Class frmInputGrades
    Dim str As String
    'Public ds1 As New DataSet

  
    Private Sub txtSubjectcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubjectcode.Click
        frmSearchSemSub_InputGrades.Show()
    End Sub

    Private Sub txtSubjectcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectcode.TextChanged
        Grades()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Clear()
        Me.Close()
    End Sub
    Public Sub Clear()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()
        dg1.DataSource = Nothing
    End Sub

    Public Sub Grades()
        Try
            str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, g.Final, g.Complied, g.Section, r.course, s.Major from registration r left outer join semesterstude s on s.studentnumber=r.studentnumber left outer join grades g on g.studentnumber=s.studentnumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.Semester='" & frmParent.lblSem.Text & "' and g.SY='" & frmParent.lblSY.Text & "' and g.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
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
                dg1.Columns(2).Visible = True
                dg1.Columns(3).Visible = True
                dg1.Columns(4).Visible = False
                dg1.Columns(5).Visible = False
                dg1.Columns(6).Visible = False
                conn.Close()

                tsDeleteGrades.Enabled = True

            Else
                str = "select r.StudentNumber, concat(s.LName,', ',s.FName) as Fullname, r.courseCode, r.Major from registration r join semesterstude s on s.studentnumber=r.studentnumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname"
                conn1.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn1)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "registration, semesterstude")
                dg1.DataSource = ds1.Tables("registration, semesterstude")
                dg1.Columns.Add("FGrade", "Final Grade")
                ' dg1.Columns(0).Visible = False
                conn1.Close()
                conn.Close()

                dg1.Columns(0).Width = 100
                dg1.Columns(1).Width = 180
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False

                tsDeleteGrades.Enabled = False

            End If
            conn.Close()

            'getNames()
            'getGrades()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        Grades()
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
                

                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "update grades set Final='" & dg1.Item(2, x).Value & "',Complied='" & dg1.Item(3, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and Section='" & txtSection.Text & "' and SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and SY='" & frmParent.lblSY.Text & "' and Semester='" & frmParent.lblSem.Text & "'"
                    conn1.Open()
                    Dim mysC1 As New MySqlCommand(str, conn1)
                    mysC1.ExecuteNonQuery()

                    conn1.Close()

                Next
                MsgBox("Grades successfully saved", MsgBoxStyle.Information)
                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "insert into grades values('0','" & dg1.Item(4, x).Value & "','','" & txtSubjectcode.Text & "','" & frmParent.lblSY.Text & "','" & frmParent.lblSem.Text & "','" & frmParent.lblTerm.Text & "','" & dg1.Item(0, x).Value & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & txtDescription.Text & "','" & lblSchool.Text & "','" & lblLecUnit.Text & "','" & lblLabUnit.Text & "','Closed','" & lblSettingsID.Text & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & lblSeqID.Text & "')"
                    conn1.Open()
                    Dim mysC2 As New MySqlCommand(str, conn1)
                    mysC2.ExecuteNonQuery()
                    conn1.Close()
                Next
                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
        Clear()
    End Sub

    Private Sub tsSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSearch.Click
        frmSearchSemSub_InputGrades.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub SelectSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectSubjectToolStripMenuItem.Click
        tsSearch.PerformClick()
    End Sub

    Public Sub FormLoad()
        tsSave.Enabled = False
        tsDeleteGrades.Enabled = False
        Clear()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        FormLoad()
    End Sub

    Private Sub frmInputGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
        schoolInfo()
        seqID()
    End Sub
    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & lblInsID.Text & "'"
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

    Private Sub tsDeleteGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDeleteGrades.Click
        Try
            If (MsgBox("Are you sure you want to delete the selected grades?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Section='" & txtSection.Text & "' and Semester='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                MsgBox("Selected records have been deleted!", MsgBoxStyle.Information)
            End If

            FormLoad()
            Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
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
End Class
