Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EnrollmentForm
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Dim picCol As DataGridViewImageColumn
    Dim query As String
    Dim userID As String = Nothing
    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getDisplay()
    End Sub

    Public Sub getDisplay()
        Aycode()
        picCol = New DataGridViewImageColumn()
        Try
            conn.Open()
            table = New DataTable()
            Using cmd As New MySqlCommand("SELECT * FROM viewEnrollment WHERE `Academic Year` = @year", conn)
                cmd.Parameters.AddWithValue("@year", lblAycode.Text)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occured: ", ex.Message)
        End Try

        dgvEnrollment.RowTemplate.Height = 40
        dgvEnrollment.DataSource = table

        picCol = dgvEnrollment.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        dgvEnrollment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim enrollForm As New EnrollTab(Me)
        enrollForm.ShowDialog()
    End Sub

    Private Sub dgvEnrollment_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEnrollment.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = dgvEnrollment.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                Dim dr As DataGridViewRow = dgvEnrollment.Rows(hit.RowIndex)
                userID = dr.Cells(0).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If userID Is Nothing OrElse userID = "" Then
                MessageBox.Show("Please select an Academic Year to delete.")
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are You Sure You Want to Remove Student: " & userID & " From Being Enrolled?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return


            Using cmd = New MySqlCommand("DELETE FROM enrollment WHERE studentID = @ID AND academicYear = @aycode", conn)
                cmd.Parameters.AddWithValue("@ID", userID)
                cmd.Parameters.AddWithValue("@aycode", lblAycode.Text)
                conn.Open()
                Dim check As Integer = cmd.ExecuteNonQuery()

                If check > 0 Then
                    MsgBox("the Selected Academic Year was Successfully Deleted.", MsgBoxStyle.Information, "Deleted Academic Year")
                    conn.Close()
                    getDisplay()
                Else
                    MessageBox.Show("No Academic Year found.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Aycode()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE status = 'Open'", conn)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    lblAycode.Text = read("id").ToString()
                Else
                    lblAycode.Text = "No Selected Academic Year"
                End If
                read.Close()
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Base query
            query = "SELECT * FROM viewenrollment WHERE 1=1"

            ' Dynamically add conditions
            If Not String.IsNullOrWhiteSpace(txtFullname.Text) Then
                query += " AND `Student Name` LIKE @fullname"
            End If

            If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                query += " AND `Student ID` = @ID"
            End If

            If cbStudentStatus.SelectedItem IsNot Nothing Then
                query += " AND `Student Status` = @status"
            End If

            If lblAycode.Text <> "No Selected Academic Year" Then
                query += " AND `Academic Year` = @year"
            End If

            ' Append LIMIT if provided
            If Not String.IsNullOrWhiteSpace(txtLimit.Text) AndAlso IsNumeric(txtLimit.Text) Then
                query += " LIMIT " & txtLimit.Text
            End If

            ' Create command
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters
                If Not String.IsNullOrWhiteSpace(txtFullname.Text) Then
                    cmd.Parameters.AddWithValue("@fullname", "%" & txtFullname.Text.Trim & "%")
                End If

                If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text.Trim)
                End If

                If cbStudentStatus.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@status", cbStudentStatus.SelectedItem.ToString)
                End If

                If lblAycode.Text <> "No Selected Academic Year" Then
                    cmd.Parameters.AddWithValue("@year", lblAycode.Text.Trim)
                End If

                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgvEnrollment.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullname.Text = ""
        txtStudentID.Text = ""
        cbStudentStatus.SelectedItem = Nothing
        cbStudentStatus.SelectedIndex = -1
        txtLimit.Text = ""
        getDisplay()
    End Sub
End Class