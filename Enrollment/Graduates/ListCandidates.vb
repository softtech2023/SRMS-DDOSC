Imports MySql.Data.MySqlClient
Public Class frmListCandidates
    Dim str As String
    Private Sub frmListCandidates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Public Sub formload()
        getCourse()
        getMajor()
        preview()
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
    Public Sub clearlist()
        For index = 0 To dglist.RowCount - 1
            For i = dglist.RowCount - 1 To 0 Step -1
                i = dglist.CurrentCell.RowIndex
                dglist.Rows.RemoveAt(i)
            Next
        Next
    End Sub
    Public Sub preview()
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
            dglist.Columns(2).Width = 300
            dglist.Columns(3).HeaderText = "Major"
            dglist.Columns(3).Width = 250
            dglist.Columns(4).HeaderText = "School Year"
            dglist.Columns(4).Width = 100


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'clearlist()
            str = "SELECT g.gradID, g.StudentNumber, concat(s.FirstName,' ',s.LastName) as Name, g.Course, g.Major, g.sy FROM gradcandidates g join studeprofile s on s.StudentNumber = g.StudentNumber where g.Course='" & cboCourse.Text & "' and g.Major='" & cboMajor.Text & "' and g.SY='" & frmParent.lblSY.Text & "'group by g.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "gradcandidates, studeprofile")
            dglist.DataSource = ds.Tables("gradcandidates, studeprofile")
            conn.Close()

            'Dim chkBoxCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
            'chkBoxCol.HeaderText = "Select"

            ' Add this column to the DataGridView
            'dglist.Columns.Add(chkBoxCol)

            'Dim ChkBox As New DataGridViewCheckBoxColumn

            'dglist.Columns.Add(ChkBox)
            'ChkBox.FlatStyle = FlatStyle.Standard
            'ChkBox.HeaderText = "Select"
            'ChkBox.Name = "ChkBox"

            'dim chkbox as new datagridviewcheckboxcolumn

            'chkbox.flatstyle = flatstyle.standard
            'chkbox.headertext = "select"
            'chkbox.name = "select"
            'chkbox.width = 50
            'dglist.columns(0, chkbox)

            dglist.Columns(0).Visible = False
            dglist.Columns(1).HeaderText = "Student No."
            dglist.Columns(1).Width = 100
            dglist.Columns(2).HeaderText = "Name"
            dglist.Columns(2).Width = 200
            dglist.Columns(3).HeaderText = "Coursee"
            dglist.Columns(3).Width = 300
            dglist.Columns(4).HeaderText = "Major"
            dglist.Columns(4).Width = 250
            dglist.Columns(5).HeaderText = "School Year"
            dglist.Columns(5).Width = 100

            'Dim chk As New DataGridViewCheckBoxColumn()
            'dglist.Columns.Add(chk)
            'chk.HeaderText = " "
            'chk.Name = "chk"
            'dglist.Rows(2).Cells(3).Value = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCourse.SelectedIndexChanged
        getMajor()
        preview()
    End Sub

    
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            str = "SELECT g.*, s.FirstName, s.MiddleName, s.LastName, s.birthDate, st.SchoolHead, st.sHeadPosition, st.VPAA, st.letterHead FROM gradcandidates g INNER JOIN studeprofile s ON g.StudentNumber = s.StudentNumber INNER JOIN srms_settings st ON s.settingsID = st.settingsID where g.SY='" & frmParent.lblSY.Text & "' and g.Course='" & cboCourse.Text & "' and g.Major='" & cboMajor.Text & "' order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, gradcandidates, srms_settings")
            Dim obj As New gradCandidate
            obj.SetDataSource(mysds.Tables("studeprofile, gradcandidates, srms_settings"))
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If (MsgBox("Are you sure you want to exclude this candidate from the list?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Dim i As Integer
                i = dglist.CurrentRow.Index
                str = "delete from gradcandidates where StudentNumber='" & dglist.Item(0, i).Value & "' and Course='" & cboCourse.Text & "' and Major='" & cboMajor.Text & "' and SY='" & frmParent.lblSY.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                MsgBox("The selected candidate has been removed!", MsgBoxStyle.Information, "Prompt")
                formload()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmSearchCandidates.ShowDialog()
    End Sub

    Private Sub cboMajor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajor.SelectedIndexChanged
        preview()
    End Sub

    Private Sub btnprintlrgs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprintlrgs.Click
        Try
            str = "SELECT g.*, s.FirstName, s.MiddleName, s.LastName, s.birthDate, st.SchoolHead, st.sHeadPosition, st.VPAA, st.letterHead FROM gradcandidates g INNER JOIN studeprofile s ON g.StudentNumber = s.StudentNumber INNER JOIN srms_settings st ON s.settingsID = st.settingsID where g.SY='" & frmParent.lblSY.Text & "' and g.Course='" & cboCourse.Text & "' and g.Major='" & cboMajor.Text & "' order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "studeprofile, gradcandidates, srms_settings")
            Dim obj As New RecGradStude
            obj.SetDataSource(mysds.Tables("studeprofile, gradcandidates, srms_settings"))
            obj.SetParameterValue("SEMESTER", frmParent.lblSem.Text)
            frmMainViewer.ReportViewer.ReportSource = obj
            frmMainViewer.ReportViewer.Refresh()
            conn.Close()
            frmMainViewer.MdiParent = frmParent
            frmMainViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class