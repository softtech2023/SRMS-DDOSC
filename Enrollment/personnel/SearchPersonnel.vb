Imports MySql.Data.MySqlClient
Public Class frmSearchPersonnel
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from staff where LastName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()

            dgProfile.Columns(0).HeaderText = "Employee No."
            dgProfile.Columns(1).HeaderText = "First Name"
            dgProfile.Columns(1).Width = 150
            dgProfile.Columns(2).HeaderText = "Middle Name"
            dgProfile.Columns(2).Width = 150
            dgProfile.Columns(3).HeaderText = "Last Name"
            dgProfile.Columns(3).Width = 150
            dgProfile.Columns(4).HeaderText = "Extn."
            dgProfile.Columns(5).Visible = False
            dgProfile.Columns(6).Visible = False
            dgProfile.Columns(7).Visible = False
            dgProfile.Columns(8).Visible = False
            dgProfile.Columns(9).Visible = False
            dgProfile.Columns(10).Visible = False
            dgProfile.Columns(11).Visible = False
            dgProfile.Columns(12).Visible = False
            dgProfile.Columns(13).Visible = False
            dgProfile.Columns(14).Visible = False
            dgProfile.Columns(15).Visible = False
            dgProfile.Columns(16).Visible = False
            dgProfile.Columns(17).Visible = False
            dgProfile.Columns(18).Visible = False
            dgProfile.Columns(19).Visible = False
            dgProfile.Columns(20).Visible = False
            dgProfile.Columns(21).Visible = False
            dgProfile.Columns(22).Visible = False
            dgProfile.Columns(23).Visible = False
            dgProfile.Columns(24).Visible = False
            dgProfile.Columns(25).Visible = False
            dgProfile.Columns(26).Visible = False
            dgProfile.Columns(27).Visible = False
            dgProfile.Columns(28).Visible = False
            dgProfile.Columns(29).Visible = False
            dgProfile.Columns(30).Visible = False
            dgProfile.Columns(31).Visible = False
            dgProfile.Columns(32).Visible = False
            dgProfile.Columns(33).Visible = False
            dgProfile.Columns(34).Visible = False
            dgProfile.Columns(35).Visible = False
            dgProfile.Columns(36).Visible = False
            dgProfile.Columns(37).Visible = False
            dgProfile.Columns(38).Visible = False
            dgProfile.Columns(39).Visible = False
            dgProfile.Columns(40).Visible = False
            dgProfile.Columns(41).Visible = False
            dgProfile.Columns(42).Visible = False
            dgProfile.Columns(43).Visible = False
            dgProfile.Columns(44).Visible = False
            dgProfile.Columns(45).Visible = False
            dgProfile.Columns(46).Visible = False
            dgProfile.Columns(47).Visible = False
            dgProfile.Columns(48).Visible = False
            dgProfile.Columns(49).Visible = False
            dgProfile.Columns(50).Visible = False
            dgProfile.Columns(51).Visible = False
            dgProfile.Columns(52).Visible = False
            dgProfile.Columns(53).Visible = False
            dgProfile.Columns(54).Visible = False
            dgProfile.Columns(55).Visible = False
            dgProfile.Columns(56).Visible = False
            dgProfile.Columns(57).Visible = False
            dgProfile.Columns(58).Visible = False
            dgProfile.Columns(59).Visible = False
            dgProfile.Columns(60).Visible = False
            dgProfile.Columns(61).Visible = False
            dgProfile.Columns(62).Visible = False
            dgProfile.Columns(63).Visible = False
            dgProfile.Columns(64).Visible = False
            dgProfile.Columns(65).Visible = False
            dgProfile.Columns(66).Visible = False
            dgProfile.Columns(67).Visible = False
            dgProfile.Columns(68).Visible = False
            dgProfile.Columns(69).Visible = False
            dgProfile.Columns(70).Visible = False
            dgProfile.Columns(71).Visible = False
            dgProfile.Columns(72).Visible = False
            dgProfile.Columns(73).Visible = False
            dgProfile.Columns(74).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSearchPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select * from staff"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "staff")
            dgProfile.DataSource = ds.Tables("staff")
            conn.Close()
            dgProfile.Columns(0).HeaderText = "Employee No."
            dgProfile.Columns(1).HeaderText = "First Name"
            dgProfile.Columns(1).Width = 150
            dgProfile.Columns(2).HeaderText = "Middle Name"
            dgProfile.Columns(2).Width = 150
            dgProfile.Columns(3).HeaderText = "Last Name"
            dgProfile.Columns(3).Width = 150
            dgProfile.Columns(4).HeaderText = "Extn."
            dgProfile.Columns(5).Visible = False
            dgProfile.Columns(6).Visible = False
            dgProfile.Columns(7).Visible = False
            dgProfile.Columns(8).Visible = False
            dgProfile.Columns(9).Visible = False
            dgProfile.Columns(10).Visible = False
            dgProfile.Columns(11).Visible = False
            dgProfile.Columns(12).Visible = False
            dgProfile.Columns(13).Visible = False
            dgProfile.Columns(14).Visible = False
            dgProfile.Columns(15).Visible = False
            dgProfile.Columns(16).Visible = False
            dgProfile.Columns(17).Visible = False
            dgProfile.Columns(18).Visible = False
            dgProfile.Columns(19).Visible = False
            dgProfile.Columns(20).Visible = False
            dgProfile.Columns(21).Visible = False
            dgProfile.Columns(22).Visible = False
            dgProfile.Columns(23).Visible = False
            dgProfile.Columns(24).Visible = False
            dgProfile.Columns(25).Visible = False
            dgProfile.Columns(26).Visible = False
            dgProfile.Columns(27).Visible = False
            dgProfile.Columns(28).Visible = False
            dgProfile.Columns(29).Visible = False
            dgProfile.Columns(30).Visible = False
            dgProfile.Columns(31).Visible = False
            dgProfile.Columns(32).Visible = False
            dgProfile.Columns(33).Visible = False
            dgProfile.Columns(34).Visible = False
            dgProfile.Columns(35).Visible = False
            dgProfile.Columns(36).Visible = False
            dgProfile.Columns(37).Visible = False
            dgProfile.Columns(38).Visible = False
            dgProfile.Columns(39).Visible = False
            dgProfile.Columns(40).Visible = False
            dgProfile.Columns(41).Visible = False
            dgProfile.Columns(42).Visible = False
            dgProfile.Columns(43).Visible = False
            dgProfile.Columns(44).Visible = False
            dgProfile.Columns(45).Visible = False
            dgProfile.Columns(46).Visible = False
            dgProfile.Columns(47).Visible = False
            dgProfile.Columns(48).Visible = False
            dgProfile.Columns(49).Visible = False
            dgProfile.Columns(50).Visible = False
            dgProfile.Columns(51).Visible = False
            dgProfile.Columns(52).Visible = False
            dgProfile.Columns(53).Visible = False
            dgProfile.Columns(54).Visible = False
            dgProfile.Columns(55).Visible = False
            dgProfile.Columns(56).Visible = False
            dgProfile.Columns(57).Visible = False
            dgProfile.Columns(58).Visible = False
            dgProfile.Columns(59).Visible = False
            dgProfile.Columns(60).Visible = False
            dgProfile.Columns(61).Visible = False
            dgProfile.Columns(62).Visible = False
            dgProfile.Columns(63).Visible = False
            dgProfile.Columns(64).Visible = False
            dgProfile.Columns(65).Visible = False
            dgProfile.Columns(66).Visible = False
            dgProfile.Columns(67).Visible = False
            dgProfile.Columns(68).Visible = False
            dgProfile.Columns(69).Visible = False
            dgProfile.Columns(70).Visible = False
            dgProfile.Columns(71).Visible = False
            dgProfile.Columns(72).Visible = False
            dgProfile.Columns(73).Visible = False
            dgProfile.Columns(74).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub dgProfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProfile.DoubleClick
        Dim i As Integer
        i = dgProfile.CurrentRow.Index

        frmuseraccounts.txtUsername.Text = dgProfile.Item(0, i).Value
        frmuseraccounts.txtFName.Text = dgProfile.Item(1, i).Value
        frmuseraccounts.txtMName.Text = dgProfile.Item(2, i).Value
        frmuseraccounts.txtLName.Text = dgProfile.Item(3, i).Value

        Me.Close()

    End Sub
End Class