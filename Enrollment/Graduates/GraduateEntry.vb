Imports MySql.Data.MySqlClient
Public Class frmGraduateEntry
    Dim str As String
    Private Sub frmGraduateEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        dglist.Refresh()
        getMajor()
    End Sub

    Private Sub cboMajor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajor.SelectedIndexChanged
        dglist.Refresh()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            str = "select * from  alum_reg where Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and sygraduated='" & frmParent.lblSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "alum_reg")
            conn.Close()
            If ds.Tables("alum_reg").Rows.Count >= 1 Then

                MsgBox("Duplicate records found!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            Else
                save()
                conn.Close()
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

                str = "insert into alum_reg values('0','" & dglist.Item(0, x).Value & "','" & dglist.Item(2, x).Value & "','" & dglist.Item(3, x).Value & "','" & frmParent.lblSem.Text & "', '" & dglist.Item(4, x).Value & "','" & Convert.ToDateTime(dtpGraduationDate.Text).ToString("yyyy-MM-dd") & "','No Status','','','','0','No Data','No Status','','1','0')"
                conn1.Open()
                Dim mysC2 As New MySqlCommand(str, conn1)
                mysC2.ExecuteNonQuery()
                conn1.Close()

                'update users
                str = "update users set position='Alumni' where username='" & dglist.Item(0, x).Value & "'"
                conn.Open()
                Dim mysC3 As New MySqlCommand(str, conn)
                mysC3.ExecuteNonQuery()
                conn.Close()

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            str = "SELECT g.StudentNumber, concat(s.FirstName,' ',s.LastName) as Name, g.Course, g.Major, g.sy FROM gradcandidates g join studeprofile s on s.StudentNumber = g.StudentNumber where g.Course='" & cboCourse.Text & "' and g.Major='" & cboMajor.Text & "' and g.SY='" & frmParent.lblSY.Text & "'group by g.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gradcandidates, studeprofile")
            dglist.DataSource = ds.Tables("gradcandidates, studeprofile")
            conn.Close()

            dglist.Columns(0).HeaderText = "Student No."
            dglist.Columns(0).Width = 100
            dglist.Columns(1).HeaderText = "Name"
            dglist.Columns(1).Width = 200
            dglist.Columns(2).HeaderText = "Course"
            dglist.Columns(2).Width = 150
            dglist.Columns(3).HeaderText = "Major"
            dglist.Columns(3).Width = 100
            dglist.Columns(4).HeaderText = "AY"
            dglist.Columns(4).Width = 100


            btnSave.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class