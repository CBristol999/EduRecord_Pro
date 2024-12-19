Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Courses
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Dim aceYear As String = Nothing
    Public StudentID, actID As String

    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        GetDisplay()
        UpdateCourses()
    End Sub

    Public Sub GetDisplay()
        Aycode()
        Try
            table = New DataTable()
            Using cmd As New MySqlCommand("SELECT * FROM viewCourses WHERE `Academic Year` = @year AND (`Course 1` IS NOT NULL OR `Course 2` IS NOT NULL OR 
                                          `Course 3` IS NOT NULL OR `Course 4` IS NOT NULL);", conn)
                cmd.Parameters.AddWithValue("@year", aceYear)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
            dgvCourse.RowTemplate.Height = 35
            dgvCourse.DataSource = table
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        If StudentID IsNot Nothing Then
            Try
                If conn.State <> ConnectionState.Open Then conn.Open()
                Using cmd As New MySqlCommand("SELECT `Student ID`, `Student Name`, `Program`, `Student Year`, `School Period` FROM viewCourses WHERE `Student ID` = @id AND `Academic Year` = @ay", conn)
                    cmd.Parameters.AddWithValue("@id", StudentID)
                    cmd.Parameters.AddWithValue("@ay", actID)
                    Using read = cmd.ExecuteReader()
                        If read.Read() Then
                            ' Access fields using proper column names
                            txtStudentID.Text = read("Student ID").ToString()
                            txtFullName.Text = read("Student Name").ToString()
                            txtProgram.Text = read("Program").ToString()
                            txtYear.Text = read("Student Year").ToString()
                            txtSemester.Text = read("School Period").ToString()
                            read.Close()
                            SelectCourses()
                        End If
                        read.Close()
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                MsgBox("Please Select a Student First.", MsgBoxStyle.Exclamation, "Selection Required")
                Return
            End If

            If Not AreCoursesUnique() Then
                MsgBox("Please Select Unique Courses For Each Course ComboBoxes.", MsgBoxStyle.Exclamation, "Duplicate Course Selection")
                Return
            End If

            If verif() Then
                conn.Open()

                Dim query As String = "UPDATE enrollment SET "
                Dim updates As New List(Of String)

                If cbCourse1.SelectedItem IsNot Nothing Then
                    updates.Add("course1 = @Course1")
                End If

                If cbCourse2.SelectedItem IsNot Nothing Then
                    updates.Add("course2 = @Course2")
                End If

                If cbCourse3.SelectedItem IsNot Nothing Then
                    updates.Add("course3 = @Course3")
                End If

                If cbCourse4.SelectedItem IsNot Nothing Then
                    updates.Add("course4 = @Course4")
                End If

                query &= String.Join(", ", updates) & " WHERE studentID = @ID AND academicYear = @aycode"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = txtStudentID.Text
                cmd.Parameters.Add("@aycode", MySqlDbType.VarChar).Value = aceYear

                If cbCourse1.SelectedItem IsNot Nothing Then
                    cmd.Parameters.Add("@Course1", MySqlDbType.VarChar).Value = cbCourse1.SelectedItem
                End If

                If cbCourse2.SelectedItem IsNot Nothing Then
                    cmd.Parameters.Add("@Course2", MySqlDbType.VarChar).Value = cbCourse2.SelectedItem
                End If

                If cbCourse3.SelectedItem IsNot Nothing Then
                    cmd.Parameters.Add("@Course3", MySqlDbType.VarChar).Value = cbCourse3.SelectedItem
                End If

                If cbCourse4.SelectedItem IsNot Nothing Then
                    cmd.Parameters.Add("@Course4", MySqlDbType.VarChar).Value = cbCourse4.SelectedItem
                End If

                If cmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Student Course Updated Successfully", MsgBoxStyle.Information, "Update Student Course")
                    conn.Close()
                    GetDisplay()
                Else
                    MsgBox("Error Updating Student Course Info", MsgBoxStyle.Critical, "Update Student Course")
                End If
            Else
                MsgBox("Please Fill At Least One Course To Add/Update.", MsgBoxStyle.Exclamation, "No Course Selected")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function AreCoursesUnique() As Boolean
        Dim selectedCourses As New HashSet(Of String)()

        For Each cb As ComboBox In {cbCourse1, cbCourse2, cbCourse3, cbCourse4}
            If cb.SelectedItem IsNot Nothing Then
                If Not selectedCourses.Add(cb.SelectedItem.ToString()) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each txtBox In {txtStudentID, txtFullName, txtProgram, txtYear, txtSemester}
            txtBox.Text = ""
        Next

        ' Clear and reset combo boxes
        For Each cb In {cbCourse1, cbCourse2, cbCourse3, cbCourse4}
            cb.Items.Clear()
            cb.SelectedItem = Nothing
            cb.Text = ""
        Next
        btnSave.Text = "SAVE"
    End Sub


    'create a function to verify if all field is filled
    Function verif() As Boolean
        If cbCourse1.SelectedItem Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub dgvCourse_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvCourse.MouseClick
        If dgvCourse.Rows.Count = 0 Then Return

        Try
            Dim hit As DataGridView.HitTestInfo = dgvCourse.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then ' Ensure a valid row index is clicked
                Dim dr As DataGridViewRow = dgvCourse.Rows(hit.RowIndex)
                txtStudentID.Text = dr.Cells(0).Value.ToString()
                txtFullName.Text = dr.Cells(1).Value.ToString()
                txtProgram.Text = dr.Cells(3).Value.ToString()
                txtYear.Text = dr.Cells(4).Value.ToString()
                txtSemester.Text = dr.Cells(5).Value.ToString()
                conn.Open()
                SelectCourses()
                conn.Close()
                cbCourse1.SelectedItem = dr.Cells(6).Value.ToString()
                cbCourse2.SelectedItem = dr.Cells(7).Value.ToString()
                cbCourse3.SelectedItem = dr.Cells(8).Value.ToString()
                cbCourse4.SelectedItem = dr.Cells(9).Value.ToString()
                If {cbCourse1, cbCourse2, cbCourse3, cbCourse4}.All(Function(cb) cb.SelectedItem Is Nothing) Then
                    For Each cb In {cbCourse1, cbCourse2, cbCourse3, cbCourse4}
                        cb.SelectedItem = Nothing
                        cb.Text = ""
                    Next
                End If
                btnSave.Text = "UPDATE"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clearSearch()
        GetDisplay()
    End Sub

    Private Sub SelectCourses()
        Dim proID As Integer
        Try
            Using cmd As New MySqlCommand("SELECT ProgramID FROM programs WHERE ProgramName = @Program", conn)
                cmd.Parameters.AddWithValue("@Program", txtProgram.Text)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    proID = read("ProgramID")
                End If
                read.Close()
            End Using

            Using cmd As New MySqlCommand("SELECT course_name FROM courses WHERE ProgramID = @Program AND year = @Year AND semester = @Semester", conn)
                cmd.Parameters.AddWithValue("@Program", proID)
                cmd.Parameters.AddWithValue("@Year", txtYear.Text)
                cmd.Parameters.AddWithValue("@Semester", txtSemester.Text)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbCourse1.Items.Clear()
                cbCourse2.Items.Clear()
                cbCourse3.Items.Clear()
                cbCourse4.Items.Clear()
                cbCourse1.SelectedItem = Nothing
                cbCourse2.SelectedItem = Nothing
                cbCourse3.SelectedItem = Nothing
                cbCourse4.SelectedItem = Nothing
                cbCourse1.Text = ""
                cbCourse2.Text = ""
                cbCourse3.Text = ""
                cbCourse4.Text = ""

                For Each dr As DataRow In table.Rows
                    cbCourse1.Items.Add(dr("course_name").ToString())
                    cbCourse2.Items.Add(dr("course_name").ToString())
                    cbCourse3.Items.Add(dr("course_name").ToString())
                    cbCourse4.Items.Add(dr("course_name").ToString())
                Next
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateCourses()
        Try
            Using cmd As New MySqlCommand("SELECT * FROM programs", conn)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbProgram.Items.Clear()

                For Each dr As DataRow In table.Rows
                    cbProgram.Items.Add(dr("ProgramName").ToString())
                Next
            End Using


            Using cmd As New MySqlCommand("SELECT course_name FROM courses WHERE ProgramID = @Program AND year = @Year AND semester = @Semester", conn)
                cmd.Parameters.AddWithValue("@Program", cbProgram.SelectedValue + 1)
                cmd.Parameters.AddWithValue("@Year", cbYear.SelectedItem)
                cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbCourseFind.Items.Clear()
                cbCourseFind.SelectedIndex = -1
                cbCourseFind.SelectedItem = Nothing

                ' Populate the course ComboBoxes
                For Each dr As DataRow In table.Rows
                    cbCourseFind.Items.Add(dr("course_name").ToString())
                Next
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cbYear_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        cbSemester.SelectedIndex = -1
        cbSemester.SelectedItem = Nothing
        UpdateCourses()
    End Sub

    Private Sub cbSemester_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        cbCourseFind.SelectedIndex = -1
        cbCourseFind.SelectedItem = Nothing
        UpdateCourses()
    End Sub

    Private Sub cbProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgram.SelectedIndexChanged
        cbYear.SelectedIndex = -1
        cbYear.SelectedItem = Nothing
        cbSemester.SelectedIndex = -1
        cbSemester.SelectedItem = Nothing
        cbCourseFind.SelectedIndex = -1
        cbCourseFind.SelectedItem = Nothing
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Base query
            query = "SELECT e.studentID AS 'Student ID', " &
                "CONCAT(s.firstname, ' ', s.lastname, ' ', IFNULL(s.middle, ''), ' ', IFNULL(s.extensionName, '')) AS 'Student Name', " &
                "e.studentStatus AS 'Student Status', " &
                "s.currentProgram AS Program, " &
                "s.currentyearLevel AS 'Student Year', " &
                "s.currentschoolPeriod AS 'School Period', " &
                "e.course1 AS 'Course 1', e.course2 AS 'Course 2', e.course3 AS 'Course 3', e.course4 AS 'Course 4' " &
                "FROM enrollment e " &
                "INNER JOIN students s ON e.studentID = s.studentID " &
                "LEFT JOIN courses b ON e.course1 = b.course_name " &
                "WHERE 1=1"

            ' Dynamically add conditions
            If Not String.IsNullOrWhiteSpace(txtFullnameFind.Text) Then
                query += " AND CONCAT(s.firstname, ' ', s.lastname, ' ', IFNULL(s.middle, ''), ' ', IFNULL(s.extensionName, '')) LIKE @fullname"
            End If

            If Not String.IsNullOrWhiteSpace(txtStudentIDFind.Text) Then
                query += " AND e.studentID = @ID"
            End If

            If cbStatusFind.SelectedItem IsNot Nothing Then
                query += " AND e.studentStatus = @status"
            End If

            If cbProgram.SelectedItem IsNot Nothing Then
                query += " AND s.currentProgram = @program"
            End If

            If cbYear.SelectedItem IsNot Nothing Then
                query += " AND s.currentyearLevel = @year"
            End If

            If cbSemester.SelectedItem IsNot Nothing Then
                query += " AND s.currentschoolPeriod = @semester"
            End If

            If cbCourseFind.SelectedItem IsNot Nothing Then
                query += " AND (e.course1 = @course OR e.course2 = @course OR e.course3 = @course OR e.course4 = @course)"
            End If

            If Not String.IsNullOrWhiteSpace(txtLimit.Text) AndAlso IsNumeric(txtLimit.Text) Then
                query += " LIMIT " & txtLimit.Text
            End If

            ' Create command
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters
                If Not String.IsNullOrWhiteSpace(txtFullnameFind.Text) Then
                    cmd.Parameters.AddWithValue("@fullname", "%" & txtFullnameFind.Text.Trim() & "%")
                End If

                If Not String.IsNullOrWhiteSpace(txtStudentIDFind.Text) Then
                    cmd.Parameters.AddWithValue("@ID", txtStudentIDFind.Text.Trim())
                End If

                If cbStatusFind.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@status", cbStatusFind.SelectedItem.ToString())
                End If

                If cbProgram.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@program", cbProgram.SelectedItem.ToString())
                End If

                If cbYear.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@year", cbYear.SelectedItem.ToString())
                End If

                If cbSemester.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@semester", cbSemester.SelectedItem.ToString())
                End If

                If cbCourseFind.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@course", cbCourseFind.SelectedItem.ToString())
                End If

                ' Execute and bind results
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)
                dgvCourse.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Public Sub clearSearch()
        ' Clear text boxes
        For Each txtBox In {txtFullnameFind, txtStudentIDFind, txtLimit}
            txtBox.Text = ""
        Next

        ' Reset combo boxes
        For Each cb In {cbProgram, cbSemester, cbYear, cbStatusFind, cbCourseFind}
            cb.SelectedIndex = -1
            cb.SelectedItem = Nothing
        Next
    End Sub

    Private Sub PictureBoxSearch_Click(sender As Object, e As EventArgs) Handles PictureBoxSearch.Click
        Dim courseSearchForm As New CourseSearch(Me)
        courseSearchForm.Show()
    End Sub

    Public Sub Aycode()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE status = 'Open'", conn)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    aceYear = read("id").ToString()
                Else
                    aceYear = "No Selected Academic Year"
                End If
                read.Close()
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class