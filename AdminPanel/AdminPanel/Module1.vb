Module Module1
    Public CNN As New ADODB.Connection
    Public Sub DBConnect()
        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-I7S9QD1\SQLEXPRESS;User ID=clayde;Password=test123;Initial Catalog=Login"
        CNN.Open()
    End Sub
End Module
