<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDetails
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
        lblName = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblGPA = New Label()
        lblStudentID = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(205, 26)
        lblName.Name = "lblName"
        lblName.Size = New Size(36, 15)
        lblName.TabIndex = 0
        lblName.Text = "None"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label2.Location = New Point(12, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 21)
        Label2.TabIndex = 1
        Label2.Text = "Name / Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label3.Location = New Point(12, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 21)
        Label3.TabIndex = 2
        Label3.Text = "Student ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label4.Location = New Point(12, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 20)
        Label4.TabIndex = 3
        Label4.Text = "GPA"
        ' 
        ' lblGPA
        ' 
        lblGPA.AutoSize = True
        lblGPA.Location = New Point(205, 107)
        lblGPA.Name = "lblGPA"
        lblGPA.Size = New Size(36, 15)
        lblGPA.TabIndex = 4
        lblGPA.Text = "None"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(205, 68)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(36, 15)
        lblStudentID.TabIndex = 5
        lblStudentID.Text = "None"
        ' 
        ' frmStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 172)
        Controls.Add(lblStudentID)
        Controls.Add(lblGPA)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblName)
        Name = "frmStudentDetails"
        Text = "Student Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblStudentID As Label
End Class
