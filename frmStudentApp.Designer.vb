<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentApp
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
        components = New ComponentModel.Container()
        lstStudents = New ListBox()
        StudentBindingSource = New BindingSource(components)
        Label1 = New Label()
        btnDeleteStudent = New Button()
        btnAddStudent = New Button()
        Label2 = New Label()
        CType(StudentBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstStudents
        ' 
        lstStudents.DataSource = StudentBindingSource
        lstStudents.DisplayMember = "StudentID"
        lstStudents.FormattingEnabled = True
        lstStudents.ItemHeight = 15
        lstStudents.Location = New Point(232, 49)
        lstStudents.Name = "lstStudents"
        lstStudents.Size = New Size(218, 289)
        lstStudents.TabIndex = 0
        ' 
        ' StudentBindingSource
        ' 
        StudentBindingSource.DataSource = GetType(Student)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(253, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 37)
        Label1.TabIndex = 1
        Label1.Text = "Student(s)"
        ' 
        ' btnDeleteStudent
        ' 
        btnDeleteStudent.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnDeleteStudent.Location = New Point(12, 152)
        btnDeleteStudent.Name = "btnDeleteStudent"
        btnDeleteStudent.Size = New Size(214, 85)
        btnDeleteStudent.TabIndex = 2
        btnDeleteStudent.Text = "Delete Student"
        btnDeleteStudent.UseVisualStyleBackColor = True
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnAddStudent.Location = New Point(12, 61)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(214, 85)
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "Add Student"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(162))
        Label2.Location = New Point(12, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 32)
        Label2.TabIndex = 4
        Label2.Text = "Students are represented by their IDs." & vbCrLf & "Double click for detailed informations."
        ' 
        ' frmStudentApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(461, 358)
        Controls.Add(Label2)
        Controls.Add(btnAddStudent)
        Controls.Add(btnDeleteStudent)
        Controls.Add(Label1)
        Controls.Add(lstStudents)
        Name = "frmStudentApp"
        Text = "Student App"
        CType(StudentBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstStudents As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents Label2 As Label

End Class
