Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class StudentHome

    Private _userId As Integer
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub StudentHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        btnProfile.PerformClick()
        getUserEmail()
    End Sub
    Public Sub addFormWindow(FormWindow)
        FormWindow.TopLevel = False
        FormWindow.FormBorderStyle = FormBorderStyle.None
        FormWindow.Dock = DockStyle.Fill
        panelHome.Controls.Add(FormWindow)
        panelHome.Tag = FormWindow
        FormWindow.BringToFront()
        FormWindow.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim adds As New Profile(_userId) 'Pass user ID to profile
        addFormWindow(adds)
    End Sub

    Private Sub btnStudyLoad_Click(sender As Object, e As EventArgs) Handles btnStudyLoad.Click
        Dim adds As New StudyLoad(_userId)
        addFormWindow(adds)
    End Sub
    Private Sub PictureBoxExit_Click(sender As Object, e As EventArgs) Handles PictureBoxExit.Click
        Login.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim log = MessageBox.Show("Do You Want To Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If log = DialogResult.Yes Then
            Close()
            Login.Show()
        End If
    End Sub

    Public Sub getUserEmail()
        conn.Open()
        Using cmd As New MySqlCommand("SELECT owner, email, role FROM useraccount WHERE id = @ID", conn)
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = _userId

            Using read As MySqlDataReader = cmd.ExecuteReader()
                If read.Read() Then
                    lblUsername.Text = read("owner").ToString & ", " & read("role").ToString
                    lblEmail.Text = read("email").ToString
                End If
            End Using
        End Using
        conn.Close()
    End Sub

    Private Sub btnAcademicPeriod_Click(sender As Object, e As EventArgs) Handles btnAcademicPeriod.Click
        Dim addss As New ChoosePeriod(Me, _userId) ' Pass user ID here
        addFormWindow(addss)
    End Sub
End Class