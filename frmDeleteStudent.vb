Public Class frmDeleteStudent
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsNumeric(txtDeleteStudentID.Text) Then '' find with ID
            For Each student As Student In frmStudentApp.listStudents
                If student.StudentID = txtDeleteStudentID.Text Then
                    frmStudentApp.listStudents.Remove(student)
                    Me.Close()
                    Exit For
                End If
            Next
        End If
    End Sub
End Class