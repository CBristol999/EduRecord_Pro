Imports MySql.Data.MySqlClient
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        Dim dash As New Dashboard()
        Dim totals = dash.GetStudentTotals()

        lblTotals.Text = totals.total.ToString()
        lblAdmin.Text = totals.admin.ToString()
        lblEnrolledStudents.Text = totals.enrolledtotal.ToString
        lblMales.Text = totals.male.ToString()
        lblFemales.Text = totals.female.ToString()
    End Sub

    Public Function GetStudentTotals() As (total As Integer, admin As Integer, enrolledtotal As Integer, male As Integer, female As Integer)
        Dim totals As Integer = Convert.ToInt32(totalStudent())
        Dim admin As Integer = Convert.ToInt32(totalAdmin())
        Dim Enrolledtotals As Integer = Convert.ToInt32(totalEnrolledStudent())
        Dim totalMaleStudent As Integer = Convert.ToInt32(totalEnrolledMale())
        Dim totalFemaleStudent As Integer = Convert.ToInt32(totalEnrolledFemale())

        Return (totals, admin, Enrolledtotals, totalMaleStudent, totalFemaleStudent)
    End Function

    Function exeCount(ByVal query As String) As String
        Using command As New MySqlCommand(query, conn)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return command.ExecuteScalar().ToString()
        End Using
    End Function

    Function totalStudent() As String
        Return exeCount("SELECT COUNT(*) FROM students")
    End Function

    Function totalAdmin() As String
        Return exeCount("SELECT COUNT(*) FROM useraccount WHERE role = 'Admin'")
    End Function

    Function totalEnrolledStudent() As String
        Return exeCount("SELECT COUNT(*) FROM viewenrollment")
    End Function

    Function totalEnrolledMale() As String
        Return exeCount("SELECT COUNT(*) FROM enrollment e INNER JOIN students s ON e.studentID = s.studentID WHERE s.gender = 'Male'")
    End Function

    Function totalEnrolledFemale() As String
        Return exeCount("SELECT COUNT(*) FROM enrollment e INNER JOIN students s ON e.studentID = s.studentID WHERE s.gender = 'Femail'")
    End Function
End Class