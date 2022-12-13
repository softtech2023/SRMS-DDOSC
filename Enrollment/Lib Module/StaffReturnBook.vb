Imports MySql.Data.MySqlClient
Public Class frmStaffRet
    Dim str As String
    Private Sub btnSelectStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectStaff.Click
        frmStaffLoaned.Show()
    End Sub

    Private Sub btnselectbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselectbook.Click
        frmStaffBooks.Show()
    End Sub
    Public Sub formload()
        Try
            Dim day As Double
            day = frmParent.cboDays.Text

          
            txtbookno.Clear()
            txttitle.Clear()
            dtpborroweddate.Text = Today
            dtpduedate.Text = dtpborroweddate.Value.AddDays(day).ToShortDateString
            txtprocby.Clear()
            txtreturndate.Text = Today
            dtptoday.Text = Today
            txtfines.Text = frmParent.cbofines.Text
            dtptoday.Visible = False
            tsSave.Enabled = False
            btnselectbook.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub
    Private Sub frmStaffRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
        txtStudentNo.Clear()
        txtName.Clear()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            'update libloans returndate and returned into yes
            str = "update libloans set RetDate='" & txtreturndate.Text & "',Returned='" & lblYes.Text & "' where loanID='" & lblloanID.Text & "'"
            conn.Open()
            Dim com As New MySqlCommand(Str, conn)
            com.ExecuteNonQuery()
            conn.Close()
            'update libbookentry BookStatus into In
            Str = "update libbookentry set BookStatus='In' where BookID='" & lblBookID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            formload()
            MsgBox("Successfully Returned Book!", MsgBoxStyle.Information)
            'insert into libfines
            str = "insert into libfines values (0,'" & txtName.Text & "','" & txttitle.Text & "','" & txtfines.Text & "','" & txtdays.Text & "','Unpaid','" & txtreturndate.Text & "',0,1)"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Public Sub getfines()
        Dim fines As String
        fines = Val(txtdays.Text) * Val(txtfines.Text)
        txtgetfines.Text = fines
        If txtgetfines.Text < 0 Then
            txtgetfines.Text = 0
            Exit Sub
        End If
    End Sub
    Public Sub datesubtract()
        Try
            Dim result As String
            result = DateDiff("d", dtpduedate.Text, dtptoday.Text)
            txtdays.Text = result
            If txtdays.Text < 0 Then
                txtdays.Text = 0
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtdays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdays.TextChanged
        getfines()
    End Sub

    Private Sub txtfines_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfines.TextChanged
        getfines()
    End Sub

    Private Sub dtptoday_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtptoday.ValueChanged
        datesubtract()
    End Sub

    Private Sub dtpduedate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpduedate.ValueChanged
        datesubtract()
    End Sub
End Class