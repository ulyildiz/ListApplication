
Public Class Student
    Private _GPA As Double
    Private _studentID As String
    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                _name = value
            Else
                Throw New ArgumentException("Name must not be empty or null.")
            End If
        End Set
    End Property
    Public Property StudentID As String
        Get
            Return _studentID
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) And (IsNumeric(value) And Not value.Contains(".")) Then
                _studentID = value
            Else
                Throw New ArgumentException("Student ID must not be empty, null or non-numeric.")
            End If
        End Set
    End Property
    Public Property GPA As Double
        Get
            Return _GPA
        End Get
        Set(value As Double)
            If value < 0.0 OrElse value > 4.0 Then
                Throw New ArgumentException("GPA must be a positive number between 0 and 4.")
            Else
                _GPA = value
            End If
        End Set
    End Property

    Public Sub New(name As String, studentID As String, GPA As Double)
        Me.Name = name
        Me.StudentID = studentID
        Me.GPA = GPA
    End Sub
End Class
