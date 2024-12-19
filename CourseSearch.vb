Imports MySql.Data.MySqlClient

Public Class CourseSearch
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Dim picCol As DataGridViewImageColumn
    Dim aceyear As String = Nothing
    Private mainForm As Courses

    Public Sub New(parentForm As Courses)
        InitializeComponent()
        mainForm = parentForm
    End Sub
    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Load
        DBConnect()
        getDisplay()
    End Sub

    Public Sub getDisplay()
        Aycode()
        picCol = New DataGridViewImageColumn()
        Try
            conn.Open()
            table = New DataTable()
            query = "SELECT 
                        e.studentID AS 'Student ID',
                        CONCAT(s.firstname, ' ', IFNULL(s.middle, ''), ', ', s.lastname, ' ', ' ', IFNULL(s.extensionName, '')) AS 'Student Name',
	                    s.currentyearLevel AS 'Student Year',
	                    s.currentschoolPeriod AS 'School Period',
                        e.academicYear AS 'Academic Year',
                        e.dateEnrolled AS 'Date Enrolled',
                        e.studentStatus AS 'Student Status',
                        s.profile_photo  As Profile
                    FROM enrollment e INNER JOIN students s ON e.studentID = s.studentID 
                    WHERE academicYear = @year AND course1 IS NULL AND course2 IS NULL AND course3 IS NULL AND course4 IS NULL"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@year", aceyear)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occured: ", ex.Message)
        End Try

        dgvGetStudent.RowTemplate.Height = 40
        dgvGetStudent.DataSource = table

        picCol = dgvGetStudent.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        dgvGetStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub Aycode()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE status = 'Open'", conn)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    aceyear = read("id").ToString()
                Else
                    aceyear = "No Selected Academic Year"
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
            query = "SELECT 
                    e.studentID AS 'Student ID',
                    CONCAT(s.firstname, ' ', s.lastname, ' ', IFNULL(s.middle, ''), ' ', IFNULL(s.extensionName, '')) AS 'Student Name',
                    s.currentyearLevel AS 'Student Year',
                    s.currentschoolPeriod AS 'School Period',
                    e.academicYear AS 'Academic Year',
                    e.dateEnrolled AS 'Date Enrolled',
                    e.studentStatus AS 'Student Status',
                    s.profile_photo AS Profile
                FROM enrollment e 
                INNER JOIN students s ON e.studentID = s.studentID 
                WHERE course1 IS NULL AND course2 IS NULL AND course3 IS NULL AND course4 IS NULL"

            ' Dynamically add conditions
            If Not String.IsNullOrWhiteSpace(txtName.Text) Then
                query += " AND CONCAT(s.firstname, ' ', s.lastname, ' ', IFNULL(s.middle, ''), ' ', IFNULL(s.extensionName, '')) LIKE @fullname"
            End If

            If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                query += " AND e.studentID = @ID"
            End If

            If cbStatus.SelectedItem IsNot Nothing Then
                query += " AND e.studentStatus = @status"
            End If

            If aceyear <> "No Selected Academic Year" Then
                query += " AND e.academicYear = @year"
            End If

            If Not String.IsNullOrWhiteSpace(txtLimit.Text) AndAlso IsNumeric(txtLimit.Text) Then
                query += " LIMIT " & txtLimit.Text
            End If

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrWhiteSpace(txtName.Text) Then
                    cmd.Parameters.AddWithValue("@fullname", "%" & txtName.Text.Trim & "%")
                End If

                If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text.Trim)
                End If

                If cbStatus.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString)
                End If

                If aceyear <> "No Selected Academic Year" Then
                    cmd.Parameters.AddWithValue("@year", aceyear)
                End If

                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgvGetStudent.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtStudentID.Text = ""
        cbStatus.SelectedItem = Nothing
        cbStatus.Text = ""
        txtLimit.Text = ""
        getDisplay()
    End Sub

    Private Sub dgvGetStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvGetStudent.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = dgvGetStudent.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim dr As DataGridViewRow = dgvGetStudent.Rows(hit.RowIndex)
                Dim studentID As String = dr.Cells(0).Value.ToString()
                Dim aceid As String = dr.Cells(4).Value.ToString()
                mainForm.StudentID = studentID
                mainForm.actID = aceid
                mainForm.GetDisplay()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("An Error Occured During Mouse Click: ", ex.Message)
        End Try
    End Sub

End Class