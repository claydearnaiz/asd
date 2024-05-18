<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        STUDENTToolStripMenuItem = New ToolStripMenuItem()
        AddNewStudentToolStripMenuItem = New ToolStripMenuItem()
        StudentListToolStripMenuItem = New ToolStripMenuItem()
        COURSEToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {STUDENTToolStripMenuItem, COURSEToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' STUDENTToolStripMenuItem
        ' 
        STUDENTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddNewStudentToolStripMenuItem, StudentListToolStripMenuItem})
        STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        STUDENTToolStripMenuItem.Size = New Size(68, 20)
        STUDENTToolStripMenuItem.Text = "STUDENT"
        ' 
        ' AddNewStudentToolStripMenuItem
        ' 
        AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        AddNewStudentToolStripMenuItem.Size = New Size(180, 22)
        AddNewStudentToolStripMenuItem.Text = "Add New Student"
        ' 
        ' StudentListToolStripMenuItem
        ' 
        StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        StudentListToolStripMenuItem.Size = New Size(180, 22)
        StudentListToolStripMenuItem.Text = "Student List"
        ' 
        ' COURSEToolStripMenuItem
        ' 
        COURSEToolStripMenuItem.Name = "COURSEToolStripMenuItem"
        COURSEToolStripMenuItem.Size = New Size(63, 20)
        COURSEToolStripMenuItem.Text = "COURSE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COURSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem

End Class
