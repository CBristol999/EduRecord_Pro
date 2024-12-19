Imports System.Resources
Imports MySql.Data.MySqlClient

Public Class AdminHome
    Dim dash As New Dashboard()
    Private _userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        btnDashboard.PerformClick()
        getUserEmail()
    End Sub

    Private Sub addFormWindow(FormWindow)
        FormWindow.TopLevel = False
        FormWindow.FormBorderStyle = FormBorderStyle.None
        FormWindow.Dock = DockStyle.Fill
        panelHome.Controls.Add(FormWindow)
        panelHome.Tag = FormWindow
        FormWindow.BringToFront()
        FormWindow.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim adds As New StudentForm
        addFormWindow(adds)
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim adds As New Courses
        addFormWindow(adds)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim log As DialogResult = MessageBox.Show("Do You Want To Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If log = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim adds As New Dashboard
        addFormWindow(adds)
    End Sub


    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim adds As New AccountForm
        addFormWindow(adds)
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        Dim adds As New EnrollmentForm
        addFormWindow(adds)
    End Sub

    Private Sub btnAcademicYear_Click(sender As Object, e As EventArgs) Handles btnAcademicYear.Click
        Dim adds As New AcademicYearForm
        addFormWindow(adds)
    End Sub

    Private Sub PictureBoxExit_Click(sender As Object, e As EventArgs) Handles PictureBoxExit.Click
        Login.Close()
    End Sub

    Public Sub getUserEmail()
        Using cmd As New MySqlCommand("SELECT owner, email, role FROM useraccount WHERE id = @ID", conn)
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = _userId

            Using read As MySqlDataReader = cmd.ExecuteReader()
                If read.Read() Then
                    lblUsername.Text = read("owner").ToString & ", " & read("role").ToString
                    lblEmail.Text = read("email").ToString
                End If
            End Using
        End Using
    End Sub

End Class
