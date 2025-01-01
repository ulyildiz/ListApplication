Public Class frmAddStudent
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For Each student In frmStudentApp.listStudents
            If student.StudentID = txtStudentID.Text Then
                MessageBox.Show("Student ID already exists.")
                Exit Sub
            End If
        Next
        Try
            frmStudentApp.listStudents.Add(New Student(txtName.Text, txtStudentID.Text, txtGPA.Text))
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class