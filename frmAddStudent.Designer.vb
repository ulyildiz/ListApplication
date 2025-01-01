<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAdd = New Button()
        txtGPA = New TextBox()
        txtStudentID = New TextBox()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 25)
        Label1.TabIndex = 0
        Label1.Text = "GPA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        Label2.Location = New Point(12, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 1
        Label2.Text = "Student ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        Label3.Location = New Point(12, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 2
        Label3.Text = "Name / Surname"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnAdd.Location = New Point(95, 197)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(180, 86)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtGPA
        ' 
        txtGPA.Location = New Point(163, 38)
        txtGPA.Name = "txtGPA"
        txtGPA.Size = New Size(195, 23)
        txtGPA.TabIndex = 4
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(163, 91)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(195, 23)
        txtStudentID.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(163, 150)
        txtName.Name = "txtName"
        txtName.Size = New Size(195, 23)
        txtName.TabIndex = 6
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 308)
        Controls.Add(txtName)
        Controls.Add(txtStudentID)
        Controls.Add(txtGPA)
        Controls.Add(btnAdd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmAddStudent"
        Text = "Add Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtName As TextBox
End Class
