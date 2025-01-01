Public Class frmStudentDetails
    Private student As Student

    Public Sub New(selectedStudent As Student)
        InitializeComponent()
        student = selectedStudent
    End Sub

    Private Sub frmStudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = student.Name
        lblStudentID.Text = student.StudentID
        lblGPA.Text = student.GPA.ToString()
    End Sub
End Class