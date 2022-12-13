﻿Imports MySql.Data.MySqlClient
Public Class frmRooms
    Dim str As String
    Private Sub btnSectionSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSectionSave.Click
        Try
            str = "insert into sections values (0,'" & txtSection.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            LoadSection()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub LoadSection()
        Try
            str = "select * from sections order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            dgSection.DataSource = ds.Tables("sections")
            conn.Close()
            dgSection.Columns(0).Visible = False
            dgSection.Columns(1).Width = 250

            btnSectionSave.Enabled = True
            btnSectionUpdate.Enabled = False
            btnSectionDelete.Enabled = False

            txtSection.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSection()
        LoadRoom()
    End Sub

    Private Sub dgSection_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSection.DoubleClick
        Dim i As Integer
        i = dgSection.CurrentRow.Index
        lblSectionID.Text = dgSection.Item(0, i).Value
        txtSection.Text = dgSection.Item(1, i).Value

        btnSectionSave.Enabled = False
        btnSectionUpdate.Enabled = True
        btnSectionDelete.Enabled = True
    End Sub

    Private Sub btnSectionDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSectionDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                str = "delete from sections where sectionID='" & lblSectionID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                LoadSection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSectionUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSectionUpdate.Click
        Try
            str = "update sections set Section='" & txtSection.Text & "' where sectionID='" & lblSectionID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            LoadSection()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadRoom()
        Try
            str = "select * from rooms order by Room"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "rooms")
            dgRoom.DataSource = ds.Tables("rooms")
            conn.Close()
            dgRoom.Columns(0).Visible = False
            dgRoom.Columns(1).Width = 250

            btnRoomSave.Enabled = True
            btnRoomUpdate.Enabled = False
            btnRoomDelete.Enabled = False

            txtRoom.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgRoom.DoubleClick
        Dim x As Integer
        x = dgRoom.CurrentRow.Index
        lblRoomID.Text = dgRoom.Item(0, x).Value
        txtRoom.Text = dgRoom.Item(1, x).Value

        btnRoomSave.Enabled = False
        btnRoomUpdate.Enabled = True
        btnRoomDelete.Enabled = True
    End Sub

    Private Sub btnRoomSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomSave.Click
        Try
            str = "insert into rooms values (0,'" & txtRoom.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record saved!", MsgBoxStyle.Information)
            conn.Close()
            LoadRoom()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnRoomUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomUpdate.Click
        Try
            str = "update rooms set Room='" & txtRoom.Text & "' where roomID='" & lblRoomID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            MsgBox("Record updated!", MsgBoxStyle.Information)
            conn.Close()
            LoadRoom()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnRoomDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                str = "delete from rooms where roomID='" & lblRoomID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Record deleted!", MsgBoxStyle.Information)
                conn.Close()
                LoadRoom()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class