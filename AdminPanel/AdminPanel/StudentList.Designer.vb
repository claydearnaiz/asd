<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentList
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
        ListView1 = New ListView()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 72)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1023, 411)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(91, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(314, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 2
        Label1.Text = "Search"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(415, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(72, 24)
        Button1.TabIndex = 3
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(674, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 41)
        Button2.TabIndex = 4
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(925, 18)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 41)
        Button3.TabIndex = 5
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(802, 18)
        Button4.Name = "Button4"
        Button4.Size = New Size(98, 41)
        Button4.TabIndex = 6
        Button4.Text = "Edit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' StudentList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1048, 491)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Name = "StudentList"
        Text = "StudentList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
