Imports MySql.Data.MySqlClient
Public Class frmselect_instructor_subjects
    Dim str As String
    Private Sub frmselect_instructor_subjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, LecUnit, LabUnit, Section, Sem, SY from registration where Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' and Instructor='" & frminstructor_input.txtInstructor.Text & "' group by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "registration")
            dgSubjects.DataSource = ds.Tables("registration")
            conn.Close()

            dgSubjects.Columns(0).HeaderText = "Subject Code"
            dgSubjects.Columns(0).Width = 80
            dgSubjects.Columns(1).Width = 250
            dgSubjects.Columns(2).Visible = False
            dgSubjects.Columns(2).Width = 70
            dgSubjects.Columns(3).Visible = False

            dgSubjects.Columns(5).Visible = False
            dgSubjects.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index
        frminstructor_input.txtSubjectCode.Text = dgSubjects.Item(0, i).Value
        frminstructor_input.txtDescription.Text = dgSubjects.Item(1, i).Value
        frminstructor_input.txtSection.Text = dgSubjects.Item(4, i).Value

        Me.Hide()
    End Sub
End Class