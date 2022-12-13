Imports MySql.Data.MySqlClient
Public Class frmSelectSubjects
    Dim str As String
    Private Sub frmSelectSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from subjects order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgSubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).Width = 80
            dgSubjects.Columns(3).Width = 250
            dgSubjects.Columns(3).Width = 70
            dgSubjects.Columns(4).Width = 70
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from subjects where SubjectCode like '%" & txtSearch.Text & "%' or description like '%" & txtSearch.Text & "%' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "subjects")
            dgSubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgSubjects.Columns(0).Visible = False
            dgSubjects.Columns(1).Width = 80
            dgSubjects.Columns(3).Width = 250
            dgSubjects.Columns(3).Width = 70
            dgSubjects.Columns(4).Width = 70
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgSubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSubjects.DoubleClick
        Dim i As Integer
        i = dgSubjects.CurrentRow.Index
        frmGradesOld.cboSubjectCode.Text = dgSubjects.Item(1, i).Value
        frmGradesOld.cboDescription.Text = dgSubjects.Item(2, i).Value

        txtSearch.Clear()
        Me.Close()

    End Sub
End Class