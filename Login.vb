Imports MySql.Data.MySqlClient
Imports Windows.Win32.System
Public Class Login
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM useraccount WHERE Username=@Username AND Password=@Password", conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            Dim EntryPoint = cmd.ExecuteScalar
            If EntryPoint IsNot Nothing Then
                ' Retrieve user ID
                Dim cmd2 As New MySqlCommand("SELECT id, role FROM useraccount WHERE Username=@Username AND Password=@Password", conn)
                cmd2.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd2.Parameters.AddWithValue("@Password", txtPassword.Text)
                Dim reader As MySqlDataReader = cmd2.ExecuteReader()

                If reader.Read() Then
                    Dim userId As Integer = Convert.ToInt32(reader("id"))
                    Dim userRole As String = reader("role").ToString()
                    MsgBox("Login successful!", MsgBoxStyle.Information, "Add Student")
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Hide()

                    Select Case userRole.ToLower()
                        Case "admin"
                            Dim adminhome As New AdminHome(userId)
                            adminhome.Show()
                        Case "student"
                            Dim studentHome As New StudentHome(userId)
                            studentHome.Show()
                    End Select
                Else
                    MsgBox("Error: Could not retrieve user role.", MsgBoxStyle.Critical, "Error")
                End If
                reader.Close()
            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Add Student")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnRegisterCancel.Click
        Close()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Select Case sender.Name
                Case "txtUsername"
                    txtPassword.Focus()
                Case "txtPassword"
                    btnLogin.PerformClick()
            End Select
        End If
    End Sub

    Private Sub btnRegisterHere_Click(sender As Object, e As EventArgs) Handles btnRegisterHere.Click
        Me.Hide()
        RegisterForm.Show()
    End Sub
End Class