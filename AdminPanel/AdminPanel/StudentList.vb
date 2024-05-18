Public Class StudentList
    Dim CNN As New ADODB.Connection
    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        AddColumn()
        ShowRecords()

    End Sub
    Private Sub DBConnect()
        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-I7S9QD1\SQLEXPRESS;User ID=clayde;Password=test123;Initial Catalog=SIS"
        CNN.Open()
    End Sub

    Private Sub AddColumn()
        Dim x As Integer = ListView1.Width / 9

        ListView1.Columns.Clear()
        With ListView1.Columns
            .Add("Student ID", x)
            .Add("Full Name", x)
            .Add("Birthdate", x)
            .Add("Mobile Number", x)
            .Add("Street", x)
            .Add("City", x)
            .Add("Province", x)
            .Add("Student No", x)
            .Add("Course ID", x)
        End With
        ListView1.Font = New Font(ListView1.Font, FontStyle.Bold)
        ListView1.FullRowSelect = True
    End Sub
    Private Sub ShowRecords()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String

        STRSQL = "SELECT StudentNo, LastName + ', ' + FirstName + ' ' + MiddleName AS Name, " &
             "Birthdate, MobileNo, Street, City, Province, StudentID, CourseID FROM Student"
        STRSQL = STRSQL & vbCrLf & "where (StudentID like '%" & TextBox1.Text & "%' or LastName like '%" & TextBox1.Text & "%' or FirstName like '%" & TextBox1.Text & "%')"

        Try
            RST.Open(STRSQL, CNN)

            ListView1.Items.Clear()
            While Not RST.EOF
                Dim listViewItem As New ListViewItem(RST.Fields("StudentNo").Value.ToString())
                With listViewItem.SubItems
                    .Add(RST.Fields("Name").Value.ToString())
                    .Add(RST.Fields("Birthdate").Value.ToString())
                    .Add(RST.Fields("MobileNo").Value.ToString())
                    .Add(RST.Fields("Street").Value.ToString())
                    .Add(RST.Fields("City").Value.ToString())
                    .Add(RST.Fields("Province").Value.ToString())
                    .Add(RST.Fields("StudentID").Value.ToString())
                    .Add(RST.Fields("CourseID").Value.ToString())
                End With
                ListView1.Items.Add(listViewItem)
                RST.MoveNext()
            End While
        Catch ex As Exception
            MessageBox.Show("Error retrieving records: " & ex.Message)
        Finally
            RST.Close()
        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowRecords()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Textbox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim clickedItem As ListViewItem = ListView1.HitTest(e.Location).Item

        If clickedItem IsNot Nothing Then
            Dim newForm As New testform()
            newForm.StudentID2.Text = clickedItem.SubItems(0).Text
            newForm.FullName.Text = clickedItem.SubItems(1).Text
            newForm.Show()
        End If
    End Sub



End Class