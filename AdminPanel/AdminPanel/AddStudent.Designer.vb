<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 21)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(314, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(112, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(314, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(7, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 21)
        Label2.TabIndex = 2
        Label2.Text = "Middle Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(112, 108)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(314, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(14, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 4
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(20, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 21)
        Label4.TabIndex = 6
        Label4.Text = "BirthDate"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(155, 140)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' AddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 478)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "AddStudent"
        Text = "AddStudent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
