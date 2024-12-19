Imports MySql.Data.MySqlClient

Public Class CreateAcademicYearForm
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim mainForm As AcademicYearForm
    Dim aceID As String = Nothing
    Dim academicID As String = Nothing
    Private Sub CreateAcademicYearForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
    End Sub

    Public Sub New(form As AcademicYearForm)
        InitializeComponent()
        mainForm = form
    End Sub

    Private Sub txtCreate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCreate_TextChanged(sender As Object, e As EventArgs) Handles txtCreate.TextChanged
        Try
            If Not String.IsNullOrWhiteSpace(txtCreate.Text) Then
                txtIncrement.Text = (Long.Parse(txtCreate.Text) + 1).ToString
            Else
                txtIncrement.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim year As String


        If Not String.IsNullOrWhiteSpace(txtCreate.Text) Then
            year = txtCreate.Text & "-" & txtIncrement.Text
            academicID = txtCreate.Text & "-" & txtIncrement.Text & " " & cbSemester.SelectedItem
        Else
            MsgBox("Please Input An Academic Year First!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If cbSemester.SelectedItem Is Nothing Then
            MsgBox("Please Select An Academic Period!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If DuplicateEntry() Then
            MsgBox("Duplicate Academic Year!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCreate.Text = ""
            cbSemester.SelectedIndex = -1
            cbSemester.SelectedText = Nothing
            Return
        End If

        Try
            conn.Open()
            Using cmd = New MySqlCommand("UPDATE academicyear SET status = 'Close'", conn)
                cmd.ExecuteNonQuery()
            End Using
            Using cmd = New MySqlCommand("INSERT INTO academicyear (id, aycode, schoolperiod) VALUES (@id, @aycode, @period)", conn)
                cmd.Parameters.AddWithValue("@id", academicID)
                cmd.Parameters.AddWithValue("@aycode", year)
                cmd.Parameters.AddWithValue("@period", cbSemester.SelectedItem)

                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Successfully Created Academic Year " & year & " " & cbSemester.SelectedItem, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    mainForm.getDisplay(mainForm.dgvAyYear)
                    txtCreate.Text = ""
                    cbSemester.SelectedIndex = -1
                    cbSemester.SelectedText = Nothing
                End If
            End Using

            conn.Close()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Function DuplicateEntry() As Boolean
        Dim duplicate As Boolean = False
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT * FROM academicyear WHERE id = @year", conn)
                cmd.Parameters.AddWithValue("@year", academicID)
                Using read As MySqlDataReader = cmd.ExecuteReader()
                    If (read.HasRows) Then
                        duplicate = True
                    Else
                        duplicate = False
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("An Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return duplicate
    End Function

    Public Sub Aycode()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id FROM academicyear", conn)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    aceID = read("id").ToString()
                Else
                    aceID = "No Selected Academic Year"
                End If
                read.Close()
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class