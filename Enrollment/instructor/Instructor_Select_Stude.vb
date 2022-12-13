Imports MySql.Data.MySqlClient
Public Class frmInstructor_Select_Stude
    Dim str As String
    Private Sub frmInstructor_Select_Stude_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select r.StudentNumber, concat(p.LastName,', ',p.FirstName) as studeName, r.Course, r.YearLevel from registration r join studeprofile p on r.StudentNumber=p.StudentNumber where r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.SubjectCode='" & frminstructor_input.txtSubjectCode.Text & "' and r.Section='" & frminstructor_input.txtSection.Text & "' group by r.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(0).Width = 110
            dg1.Columns(1).HeaderText = "Student Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select r.StudentNumber, concat(p.LastName,', ',p.FirstName) as studeName, r.Course, r.YearLevel from registration r join studeprofile p on r.StudentNumber=p.StudentNumber where p.LastName like '%" & txtSearch.Text & "%' and r.Sem='" & frmParent.lblSem.Text & "' and r.SY='" & frmParent.lblSY.Text & "' and r.SubjectCode='" & frmGrades.txtSubjectCode.Text & "' and r.Section='" & frmGrades.txtSection.Text & "' group by r.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dg1.DataSource = ds.Tables("registration")
            conn.Close()

            dg1.Columns(0).HeaderText = "Student No."
            dg1.Columns(0).Width = 110
            dg1.Columns(1).HeaderText = "Student Name"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).Width = 250
            dg1.Columns(3).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

End Class