<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteStudent
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
        txtDeleteStudentID = New TextBox()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(41, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 25)
        Label1.TabIndex = 0
        Label1.Text = "The student ID that student own"
        ' 
        ' txtDeleteStudentID
        ' 
        txtDeleteStudentID.Location = New Point(41, 92)
        txtDeleteStudentID.Name = "txtDeleteStudentID"
        txtDeleteStudentID.Size = New Size(289, 23)
        txtDeleteStudentID.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        btnDelete.Location = New Point(41, 159)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(289, 102)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' frmDeleteStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 308)
        Controls.Add(btnDelete)
        Controls.Add(txtDeleteStudentID)
        Controls.Add(Label1)
        Name = "frmDeleteStudent"
        Text = "Delete Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeleteStudentID As TextBox
    Friend WithEvents btnDelete As Button
End Class
