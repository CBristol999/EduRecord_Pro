Imports MySql.Data.MySqlClient

Public Class ChoosePeriod
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Private mainForm As StudentHome
    Private _userId As Integer

    Public Sub New(form As StudentHome, userId As Integer)
        InitializeComponent()
        mainForm = form
        _userId = userId ' Store the userId
    End Sub

    Private Sub ChoosePeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        loadAcademicYear()
    End Sub



    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            conn.Open()

            ' First, get the selected academic year ID
            Dim aceID As String = "" ' Initialize with an invalid value
            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE aycode = @ay AND schoolPeriod = @period", conn)
                cmd.Parameters.AddWithValue("@ay", cbYear.SelectedItem)
                cmd.Parameters.AddWithValue("@period", cbPeriod.SelectedItem)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    aceID = read("id").ToString()
                End If
                read.Close()
            End Using



            'Second, check if it's a match in the enrollment table
            Dim isMatch As Boolean = False
            Using cmd = New MySqlCommand("SELECT 1 FROM enrollment e INNER JOIN students s ON e.studentID = s.studentID WHERE s.useraccount_id = @userId AND e.academicYear = @academicYearId", conn)
                cmd.Parameters.AddWithValue("@userId", _userId)
                cmd.Parameters.AddWithValue("@academicYearId", aceID)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    isMatch = True
                End If
            End Using

            If isMatch Then
                ' If there's a match proceed to studyload
                Dim studyLoadForm As New StudyLoad(_userId, aceID)
                mainForm.addFormWindow(studyLoadForm)
                Me.Close()

            Else
                MessageBox.Show("The Selected Academic Year Does Not Match Your Enrolled Academic Year. ", "Mismatch Academic Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub








    Public Sub loadAcademicYear()
        Try
            conn.Open()
            Using cmd As New MySqlCommand("SELECT DISTINCT aycode FROM academicyear", conn)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbYear.Items.Clear()

                For Each dr As DataRow In table.Rows
                    cbYear.Items.Add(dr("aycode").ToString())
                Next
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class