Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection("Database=ddosc_montevista;" & _
                                       "Server =180.193.185.0;" & _
                                       "User ID = root; Password =moth34board;")
    Public conn1 As New MySqlConnection("Database=ddosc_montevista;" & _
                                   "Server =180.193.185.0;" & _
                                   "User ID = root; Password =moth34board;")

    'DDOSC Server
    'Main 210.5.83.195
    'Main New IP 210.5.83.195
    'Maragusan 120.72.20.232
    'Montevista 180.193.185.0
    'New Bataan  120.72.20.239
    'Laak 210.5.83.195

    'Database Name
    'Main: ddosc_montevista
    'Montevista: ddosc_montevista
    'Maragusan: ddosc_montevista
    'New Bataan: ddosc_montevista

    Public Sub AddSemSubjects(ByVal ls As ListView, ByVal subjectcode As String, ByVal Description As String, ByVal LecTime As String, ByVal LabTime As String, ByVal Room As String, ByVal Section As String, ByVal LecUnits As String, ByVal LabUnits As String, ByVal Instructor As String, ByVal Slot As String, ByVal SchedType As String, ByVal remainSlot As Integer)
        Dim lv As New ListViewItem
        ls.Items.Add(lv)
        lv.Text = subjectcode
        lv.SubItems.Add(Description)
        lv.SubItems.Add(LecTime)
        lv.SubItems.Add(LabTime)
        lv.SubItems.Add(Room)
        lv.SubItems.Add(Section)
        lv.SubItems.Add(LecUnits)
        lv.SubItems.Add(LabUnits)
        lv.SubItems.Add(Instructor)
        lv.SubItems.Add(SchedType)
        lv.SubItems.Add(Slot)

    End Sub
    Public Sub AddRequirements(ByVal ls As ListView, ByVal requirements As String)
        Dim lv As New ListViewItem
        ls.Items.Add(lv)
        lv.Text = requirements

    End Sub

    Public Sub AddFees(ByVal lv As ListView, ByVal Description As String, ByVal Amount As Double, ByVal FeesType As String)
        Dim n As New ListViewItem
        lv.Items.Add(n)
        n.Text = Description
        n.SubItems.Add(Amount)
        n.SubItems.Add(FeesType)

    End Sub
    Public Sub ListView(ByVal lv As ListView, ByVal BookNo As String, ByVal BookTitle As String, ByVal Author As String, ByVal DueDate As Date, ByVal BookStatus As String, ByVal BookID As Integer)
        Dim i As New ListViewItem
        lv.Items.Add(i)
        i.Text = BookNo
        i.SubItems.Add(BookTitle)
        i.SubItems.Add(Author)
        i.SubItems.Add(DueDate)
        i.SubItems.Add(BookStatus)
        i.SubItems.Add(BookID)

    End Sub

    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next
    End Sub
    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", _
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", _
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundreds " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousands " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Millions " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function
End Module
