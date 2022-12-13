Imports MySql.Data.MySqlClient
Public Class frmCourses
    Dim str As String

    Private Sub dgcourse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgcourse.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgcourse.CurrentRow.Index
            lblID.Text = dgcourse.Item(0, dclick).Value
            txtCourseCode.Text = dgcourse.Item(1, dclick).Value
            txtCourse.Text = dgcourse.Item(2, dclick).Value
            lblCourse.Text = dgcourse.Item(2, dclick).Value
            txtMajor.Text = dgcourse.Item(3, dclick).Value
            lblMajor.Text = dgcourse.Item(3, dclick).Value
            cboDuration.Text = dgcourse.Item(4, dclick).Value
            cboCourseGroup.Text = dgcourse.Item(5, dclick).Value
            tsSave.Enabled = False
            tsUpdate.Enabled = True
            tsDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCourses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            str = "select * from course_table order by CourseCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "course_table")
            dgcourse.DataSource = ds.Tables("course_table")
            conn.Close()
            dgcourse.Columns(0).Visible = False
            dgcourse.Columns(1).Width = 80
            dgcourse.Columns(2).Width = 250
            dgcourse.Columns(3).Width = 150
            dgcourse.Columns(4).Width = 120
            dgcourse.Columns(5).HeaderText = "Course Group"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False

        txtCourse.Clear()
        txtMajor.Clear()
        txtCourseCode.Clear()
        cboDuration.ResetText()
        cboCourseGroup.ResetText()
        txtCourseCode.Focus()

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If txtCourse.Text = "" Then
                MsgBox("Type the course you want to add!", MsgBoxStyle.Information)
                Exit Sub
            End If
            str = "insert into course_table values('0','" & txtCourseCode.Text & "','" & txtCourse.Text & "','" & txtMajor.Text & "','" & cboDuration.Text & "','" & cboCourseGroup.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            MsgBox("Data successfully added!", MsgBoxStyle.Information)
            conn.Close()
            FormLoad()
            txtCourse.Clear()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            If txtCourse.Text = "" Then
                MsgBox("Please select a COURSE you want to update!", MsgBoxStyle.Information)
                Exit Sub
            End If
            str = "update course_table set courseid='" & lblID.Text & "',CourseCode='" & txtCourseCode.Text & "',CourseDescription='" & txtCourse.Text & "',Major='" & txtMajor.Text & "',Duration='" & cboDuration.Text & "',courseGroup='" & cboCourseGroup.Text & "' where courseid='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            'update semesterstudent
            str = "update semesterstude set Course='" & txtCourse.Text & "',Major='" & txtMajor.Text & "' where Course='" & lblCourse.Text & "' and Major='" & lblMajor.Text & "'"
            conn.Open()
            Dim mysC1 As New MySqlCommand(str, conn)
            mysC1.ExecuteNonQuery()
            conn.Close()

            'update registration
            str = "update registration set Course='" & txtCourse.Text & "',Major='" & txtMajor.Text & "',courseCode='" & txtCourseCode.Text & "' where Course='" & lblCourse.Text & "' and Major='" & lblMajor.Text & "'"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            mysC2.ExecuteNonQuery()
            conn.Close()

            'update accounts
            str = "update studeaccount set Course='" & txtCourse.Text & "' where Course='" & lblCourse.Text & "'"
            conn.Open()
            Dim mysC3 As New MySqlCommand(str, conn)
            mysC3.ExecuteNonQuery()
            conn.Close()

            'update grades
            str = "update grades set Course='" & txtCourseCode.Text & "',Major='" & txtMajor.Text & "' where Course='" & lblCourse.Text & "' and Major='" & lblMajor.Text & "'"
            conn.Open()
            Dim mysC4 As New MySqlCommand(str, conn)
            mysC4.ExecuteNonQuery()
            conn.Close()

            MsgBox("Data successfully updated!", MsgBoxStyle.Information)
            FormLoad()
            txtCourse.Clear()
            tsSave.Enabled = True
            tsUpdate.Enabled = False
            tsDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If txtCourse.Text = "" Then
                MsgBox("Please select the COURSE you want to delete!", MsgBoxStyle.Information)
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from course_table where courseid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                FormLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class