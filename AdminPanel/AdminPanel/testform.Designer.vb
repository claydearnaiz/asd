<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        StudentID2 = New Label()
        StudentID = New Label()
        FullName = New Label()
        SuspendLayout()
        ' 
        ' StudentID2
        ' 
        StudentID2.AutoSize = True
        StudentID2.Location = New Point(178, 104)
        StudentID2.Name = "StudentID2"
        StudentID2.Size = New Size(41, 15)
        StudentID2.TabIndex = 0
        StudentID2.Text = "Label1"
        ' 
        ' StudentID
        ' 
        StudentID.AutoSize = True
        StudentID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentID.Location = New Point(81, 99)
        StudentID.Name = "StudentID"
        StudentID.Size = New Size(91, 21)
        StudentID.TabIndex = 1
        StudentID.Text = "Student ID"
        ' 
        ' FullName
        ' 
        FullName.AutoSize = True
        FullName.Font = New Font("Bodoni MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FullName.Location = New Point(81, 37)
        FullName.Name = "FullName"
        FullName.Size = New Size(94, 34)
        FullName.TabIndex = 2
        FullName.Text = "Label3"
        ' 
        ' testform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(FullName)
        Controls.Add(StudentID)
        Controls.Add(StudentID2)
        Name = "testform"
        Text = "testform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StudentID2 As Label
    Friend WithEvents StudentID As Label
    Friend WithEvents FullName As Label
End Class
