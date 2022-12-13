Imports MySql.Data.MySqlClient
Public Class frmsearchalumni
    Dim str As String
    Private Sub frmsearchalumni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT g.StudentNumber, concat(s.FirstName,' ',s.LastName) as Name, g.Course, g.Major, g.sygraduated, g.semgraduated, g.dategraduated, g.empstat, g.company, g.companyAd, g.empPosition, g.salary, g.empType, g.workNature, g.gpa FROM alum_reg g join studeprofile s on s.StudentNumber = g.StudentNumber order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "alum_reg, studeprofile")
            dg1.DataSource = ds.Tables("alum_reg, studeprofile")
            conn.Close()


            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(0).Width = 100
            dg1.Columns(1).HeaderText = "Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).HeaderText = "Course"
            dg1.Columns(2).Width = 300
            dg1.Columns(3).HeaderText = "Major"
            dg1.Columns(3).Width = 250
            dg1.Columns(4).HeaderText = "School Year"
            dg1.Columns(4).Width = 100
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub


    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            str = "SELECT g.StudentNumber, concat(s.FirstName,' ',s.LastName) as Name, g.Course, g.Major, g.sygraduated, g.semgraduated, g.dategraduated, g.empstat, g.company, g.companyAd, g.empPosition, g.salary, g.empType, g.workNature, g.gpa FROM alum_reg g join studeprofile s on s.StudentNumber = g.StudentNumber where s.LastName like '%" & txtsearch.Text & "%' or g.StudentNumber like '%" & txtsearch.Text & "%' order by s.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "alum_reg, studeprofile")
            dg1.DataSource = ds.Tables("alum_reg, studeprofile")
            conn.Close()


            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(0).Width = 100
            dg1.Columns(1).HeaderText = "Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).HeaderText = "Course"
            dg1.Columns(2).Width = 300
            dg1.Columns(3).HeaderText = "Major"
            dg1.Columns(3).Width = 250
            dg1.Columns(4).HeaderText = "School Year"
            dg1.Columns(4).Width = 100
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim dclick As Integer

            dclick = dg1.CurrentRow.Index
            frmGradUpdate.txtStudeNo.Text = dg1.Item(0, dclick).Value
            frmGradUpdate.txtName.Text = dg1.Item(1, dclick).Value
            frmGradUpdate.txtCourse.Text = dg1.Item(2, dclick).Value
            frmGradUpdate.txtMajor.Text = dg1.Item(3, dclick).Value
            frmGradUpdate.txtsygraduated.Text = dg1.Item(4, dclick).Value
            frmGradUpdate.txtsemgrad.Text = dg1.Item(5, dclick).Value
            frmGradUpdate.txtDateGrad.Text = dg1.Item(6, dclick).Value
            frmGradUpdate.cboEmpStat.Text = dg1.Item(7, dclick).Value
            frmGradUpdate.txtCompany.Text = dg1.Item(8, dclick).Value
            frmGradUpdate.txtCompAddress.Text = dg1.Item(9, dclick).Value
            frmGradUpdate.txtPosition.Text = dg1.Item(10, dclick).Value
            frmGradUpdate.txtSalary.Text = dg1.Item(11, dclick).Value
            frmGradUpdate.cboEmpType.Text = dg1.Item(12, dclick).Value
            frmGradUpdate.txtWorkNature.Text = dg1.Item(13, dclick).Value
            frmGradUpdate.txtgpa.Text = dg1.Item(14, dclick).Value
            Me.Close()
            frmGradUpdate.Show()
            frmGradUpdate.btnSave.Enabled = True
            frmGradUpdate.btnDelete.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class