Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AccountCreateDelete
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String


    Private Sub AccountCreateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If verif() Then
                conn.Open()

                If Duplicate() Then MsgBox("The Username And Password Entry is already exists in the database. Please ensure the details are unique!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Return
                If DuplicateAccount() Then Return
                If IsDuplicateInfo(txtEmail.Text) Then Return

                Dim role As String = "Admin"
                cmd = New MySqlCommand("INSERT INTO useraccount (username, password, owner, email, role) VALUES (@username,@password, @name, @email, @role)", conn)
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtFullname.Text
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role
                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Successfully Created Co-Admin Account.", MsgBoxStyle.Information, "Created Co-Admin Account")
                    clearText()
                Else
                    MsgBox("Insert Error Co-Admin Info", MsgBoxStyle.Critical, "Created Co-Admin Account")
                End If
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Created Co-Admin Account")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.Open()
            Dim userID As Integer
            Dim role As String = "Admin"
            Using cmd = New MySqlCommand("SELECT id FROM useraccount WHERE username = @username AND password = @password AND role = @role", conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@role", role)
                Try
                    Dim reader = cmd.ExecuteReader
                    If reader.Read Then
                        userID = reader("id")
                    Else
                        MsgBox("No No Admin Account Found")
                    End If
                    reader.Close()
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                End Try
            End Using

            cmd = New MySqlCommand("DELETE FROM useraccount WHERE id = @id", conn)
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = userID
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Successfully Deleted An Account.", MsgBoxStyle.Information, "Deleted An Account")
                clearText()
            Else
                MsgBox("Insert Error Co-Admin Info", MsgBoxStyle.Critical, "Deleted An Account")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Function DuplicateAccount() As Boolean
        Dim isDuplicate As Boolean = False
        query = "SELECT COUNT(*) FROM useraccount WHERE owner = @fullname AND email = @email AND username = @username AND password = @password"

        Using cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = txtFullname.Text
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text

            Try
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If result > 0 Then
                    isDuplicate = True
                    MsgBox("This Account is already exists in the database. Please ensure the details are unique.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while checking for duplicate records: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return isDuplicate
    End Function


    Function Duplicate() As Boolean
        Dim duplicates As Boolean = False

        Using cmd = New MySqlCommand("SELECT username, password FROM useraccount WHERE username = @username AND password = @password ", conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            Try
                Dim reader = cmd.ExecuteReader
                If reader.Read Then
                    If (reader.HasRows) Then duplicates = True Else duplicates = False
                End If
                reader.Close()
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try
        End Using

        Return duplicates
    End Function

    Function IsDuplicateInfo(email As String) As Boolean
        Dim isDuplicate As Boolean = False

        Using cmd As New MySqlCommand("SELECT email FROM useraccount WHERE email = @Email LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@Email", email)

            Dim reader As MySqlDataReader = Nothing
            Try
                reader = cmd.ExecuteReader()
                If reader.Read() Then
                    isDuplicate = True
                    MsgBox("The Inserted 'Email Address' Is Already in the Database, Please use a Different Email Address.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while checking for duplicate information: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the reader is closed
                If reader IsNot Nothing Then
                    reader.Close()
                End If
            End Try
        End Using

        Return isDuplicate
    End Function

    Function verif() As Boolean
        If txtFullname.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub clearText()
        txtFullname.Text = ""
        txtEmail.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtFullname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullname.KeyDown, txtEmail.KeyDown, txtUsername.KeyDown, txtPassword.KeyDown, btnSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim controls As Control() = {txtFullname, txtEmail, txtUsername, txtPassword, btnSave}
            For i As Integer = 0 To controls.Length - 2
                If sender Is controls(i) Then controls(i + 1).Focus()
            Next
        End If
    End Sub

End Class