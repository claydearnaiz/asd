Public Class Form1
    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Dim addStd As New AddStudent()
        addStd.ShowDialog()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        Dim StdList As New StudentList()
        StdList.ShowDialog()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
