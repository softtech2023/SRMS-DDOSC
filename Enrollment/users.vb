Imports MySql.Data.MySqlClient
Public Class frmuseraccounts
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = "insert into users values('0','" & txtusername.Text & "','" & txtpassword.Text & "','" & cboposition.Text & "')"
        conn.Open()
        Dim mysC As New MySqlCommand(str, conn)
        mysC.ExecuteNonQuery()
        MsgBox("User account has been added!", MsgBoxStyle.Information)
        conn.Close()
        txtusername.Clear()
        txtpassword.Clear()
        cboposition.ResetText()


    End Sub
End Class