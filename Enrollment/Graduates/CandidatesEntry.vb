﻿Imports MySql.Data.MySqlClient
Public Class frmCandidatesEntry
    Dim str As String
    Private Sub CandidatesEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub formload()
        getCourse()
        getMajor()
        btnSave.Enabled = False
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
            'cboCourseCode.DisplayMember = "CourseCode"
            cboCourse.DataSource = ds.Tables("course_table")
            conn.Close()
            conn.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
            conn.Close()
        End Try
    End Sub
    Public Sub getMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboMajor.ValueMember = "course_table"
            cboMajor.DisplayMember = "Major"
            cboMajor.DataSource = ds.Tables("course_table")

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT * FROM semesterstude where Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and YearLevel='4th' and SY='" & frmParent.lblSY.Text & "'group by StudentNumber order by LName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dglist.DataSource = ds.Tables("semesterstude")
            conn.Close()

            dglist.Columns(0).Visible = False
            dglist.Columns(1).HeaderText = "Student No."
            dglist.Columns(1).Width = 100
            dglist.Columns(2).HeaderText = "First Name"
            dglist.Columns(2).Width = 225
            dglist.Columns(3).HeaderText = "Middle Name"
            dglist.Columns(3).Width = 200
            dglist.Columns(4).HeaderText = "Last Name"
            dglist.Columns(4).Width = 225
            dglist.Columns(5).Visible = False
            dglist.Columns(6).Visible = False
            dglist.Columns(7).Visible = False
            dglist.Columns(8).Visible = False
            dglist.Columns(9).Visible = False
            dglist.Columns(10).Visible = False
            dglist.Columns(11).Visible = False
            dglist.Columns(12).Visible = False
            dglist.Columns(13).Visible = False
            dglist.Columns(14).Visible = False
            dglist.Columns(15).Visible = False
            dglist.Columns(16).Visible = False
            dglist.Columns(17).Visible = False
            dglist.Columns(18).Visible = False
            dglist.Columns(19).Visible = False
            dglist.Columns(20).Visible = False
            dglist.Columns(21).Visible = False
            dglist.Columns(22).Visible = False
            dglist.Columns(23).Visible = False
            dglist.Columns(24).Visible = False
            dglist.Columns(25).Visible = False
            dglist.Columns(26).Visible = False

            btnSave.Enabled = True

           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getMajor()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            
            str = "select * from  gradcandidates where Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and SY='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gradcandidates")
            If ds.Tables("gradcandidates").Rows.Count >= 1 Then
                'code kung nag exist


                'For x As Integer = 0 To dglist.Rows.Count - 1

                '    str = "delete from gradcandidates where Course='" & dglist.Item(5, x).Value & "' and Major='" & dglist.Item(21, x).Value & "' and SY='" & dglist.Item(9, x).Value & "'"
                '    conn1.Open()
                '    Dim mysC1 As New MySqlCommand(str, conn1)
                '    mysC1.ExecuteNonQuery()
                '    conn1.Close()

                'Next
                'save()
                MsgBox("Duplicate records found!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub

                'kung wala nag exist
            Else
                save()
                MsgBox("Saved successfully!", MsgBoxStyle.Information)
                btnSave.Enabled = False
            End If
            btnSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Public Sub save()
        Try
            For x As Integer = 0 To dglist.Rows.Count - 1

                str = "insert into gradcandidates values('0','" & dglist.Item(1, x).Value & "','" & dglist.Item(5, x).Value & "','" & dglist.Item(21, x).Value & "','" & dglist.Item(9, x).Value & "')"
                conn1.Open()
                Dim mysC2 As New MySqlCommand(str, conn1)
                mysC2.ExecuteNonQuery()
                conn1.Close()

                ' str = "update users set position='Alumni' where username='" & dglist.Item(1, x).Value & "'"
                ' conn1.Open()
                'Dim mysC3 As New MySqlCommand(str, conn1)
                'mysC3.ExecuteNonQuery()
                ' conn1.Close()

            Next
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
    End Sub
End Class