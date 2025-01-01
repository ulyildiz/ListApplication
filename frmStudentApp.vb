
Public Class frmStudentApp
    Public Shared listStudents As New List(Of Student)
    Private bindingSource As New BindingSource()

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim AddStudent As New frmAddStudent()
        AddStudent.ShowDialog()
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim DeleteStudent As New frmDeleteStudent()
        DeleteStudent.ShowDialog()
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub frmStudentApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindingSource.DataSource = listStudents
        lstStudents.DataSource = bindingSource
        lstStudents.DisplayMember = "StudentID"
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        If lstStudents.SelectedIndex <> -1 Then
            Dim selectedStudent As Student = CType(lstStudents.SelectedItem, Student)
            Dim studentDetails As New frmStudentDetails(selectedStudent)
            studentDetails.Show()
        End If
    End Sub
End Class
