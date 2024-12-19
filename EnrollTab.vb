Imports System.IO
Imports MySql.Data.MySqlClient

Public Class EnrollTab
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Dim picCol As DataGridViewImageColumn
    Dim query As String
    Private mainForm As EnrollmentForm

    Public Sub New(form As EnrollmentForm)
        InitializeComponent()
        mainForm = form
    End Sub

    Private Sub EnrollTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getDisplay(dgvGetStudent)
        Aycode()
        getPeriod()
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MessageBox.Show("Please select a student in dataGridView.")
            Return
        ElseIf lblAcademicYear.Text = "No Selected Academic Year" Then
            MessageBox.Show("Please Open An Academic Year First.")
            Return
        End If

        If DuplicateEntry() Then
            MsgBox("Student " & txtStudentID.Text & " Is Already Enrolled.", MsgBoxStyle.Critical, "Enroll Student")
            Return
        End If

        Try
            If verif() Then
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO enrollment (studentID, studentYear, schoolperiod, academicYear, dateEnrolled, studentStatus) 
                                        VALUES (@ID, @year, @period, @aycode, @date, @status)", conn)
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = txtStudentID.Text
                cmd.Parameters.Add("@year", MySqlDbType.Int32).Value = cbYear.SelectedItem.ToString()
                cmd.Parameters.Add("@period", MySqlDbType.VarChar).Value = cbSemester.SelectedItem
                cmd.Parameters.Add("@aycode", MySqlDbType.VarChar).Value = lblAcademicYear.Text
                cmd.Parameters.Add("@date", MySqlDbType.Date).Value = Date.Today
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cbStatus.SelectedItem.ToString()

                cmd.ExecuteNonQuery()

                Using cmdUpdate = New MySqlCommand("UPDATE students SET currentyearLevel = @yearlvl, currentschoolPeriod = @semester WHERE studentID = @id", conn)
                    cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(txtStudentID.Text)
                    cmdUpdate.Parameters.Add("@yearlvl", MySqlDbType.Int32).Value = cbYear.SelectedItem.ToString()
                    cmdUpdate.Parameters.Add("@semester", MySqlDbType.VarChar).Value = cbSemester.SelectedItem.ToString()
                    Dim check As String = cmdUpdate.ExecuteNonQuery()
                    If check > 0 Then
                        MsgBox("Student Enrolled Successfully.", MsgBoxStyle.Information, "Enroll Student")
                        conn.Close()
                        mainForm.getDisplay()
                        clearText()
                    End If
                End Using
                conn.Close()
            Else
                MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Enroll Student")
            End If
        Catch ex As Exception
            MsgBox("An Error Occured: ", ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvGetStudent_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvGetStudent.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = dgvGetStudent.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim dr As DataGridViewRow = dgvGetStudent.Rows(hit.RowIndex)
                txtStudentID.Text = dr.Cells(0).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("An Error Occured During Mouse Click: ", ex.Message)
        End Try

        Try
            conn.Open()
            query = "SELECT CONCAT(firstname, ' ', IFNULL(middle, ''), ', ', lastname, ' ', ' ', IFNULL(extensionName, '')) AS StudentName, currentyearLevel
                  FROM students WHERE studentID = @ID"
            Using cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)
                Dim reader = cmd.ExecuteReader
                If reader.Read Then
                    txtFullName.Text = reader("StudentName").ToString()
                    cbYear.SelectedItem = reader("currentyearLevel").ToString()
                    cbSemester.SelectedIndex = 0
                    cbStatus.SelectedIndex = 0
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("An Error Occured: ", ex.Message)
        End Try
    End Sub

    Public Sub getDisplay(dgv As DataGridView)

        query = "SELECT studentID, firstname, lastname, middle, extensionName, gender, birthdate, phoneNumber, email, citizenship, birthcountry, birthplace, 
        religion, address, profile_photo, motherName, motherLast, motherMiddle, motherExtension, motherResidential, motherCitizenship, motherPhone, 
        motherEmail, fatherName, fatherLast, fatherMiddle, fatherExtension, fatherResidential, fatherCitizenship, fatherPhone, fatherEmail, contactName, 
        contactNumber, previousEducationllvl, previousprogramSHS, previousschool, previousyearAttendent, previousaward, currentEducationallvl, 
        currentProgram, currentyearLevel, currentschoolPeriod, currentschoolYear FROM students WHERE approval = 'Accepted'"

        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 45
        Using cmd As New MySqlCommand(query, conn)
            conn.Open()
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    dgv.Rows.Add(dr("studentID"), dr("firstname"), dr("lastname"), dr("middle"), dr("extensionName"), dr("gender"),
                                 CType(dr("birthdate"), DateTime).ToString("MM/dd/yyyy"), dr("phoneNumber"), dr("email"), dr("citizenship"), dr("birthcountry"), dr("birthplace"), dr("religion"),
                                 dr("address"), dr("profile_photo"), dr("motherName"), dr("motherLast"), dr("motherMiddle"), dr("motherExtension"),
                                 dr("motherResidential"), dr("motherCitizenship"), dr("motherPhone"), dr("motherEmail"), dr("fatherName"), dr("fatherLast"),
                                 dr("fatherMiddle"), dr("fatherExtension"), dr("fatherResidential"), dr("fatherCitizenship"), dr("fatherPhone"),
                                 dr("fatherEmail"), dr("contactName"), dr("contactNumber"), dr("previousEducationllvl"), dr("previousprogramSHS"),
                                 dr("previousschool"), dr("previousyearAttendent"), dr("previousaward"), dr("currentEducationallvl"), dr("currentProgram"),
                                 dr("currentyearLevel"), dr("currentschoolPeriod"), dr("currentschoolYear"))
                End While
            End Using
            conn.Close()
        End Using

        dgv.ClearSelection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, ptbExit.Click
        Close()
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim filterForm As New FilterSearch2(Me)
        filterForm.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        GetDisplay(dgvGetStudent)
    End Sub

    Public Sub clearText()
        txtFullName.Text = ""
        txtStudentID.Text = ""
        cbYear.SelectedItem = Nothing
        cbSemester.SelectedItem = Nothing
        cbStatus.SelectedItem = Nothing
    End Sub

    Function verif() As Boolean
        If txtFullName.Text.Trim() = "" Or txtStudentID.Text.Trim() = "" Or cbYear.SelectedItem Is Nothing Or cbSemester.SelectedItem Is Nothing Or
            cbStatus.SelectedItem Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Aycode()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE status = 'Open'", conn)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    lblAcademicYear.Text = read("id").ToString()
                Else
                    lblAcademicYear.Text = "No Selected Academic Year"
                End If
                read.Close()
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Function DuplicateEntry() As Boolean
        Dim duplicate As Boolean = False
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT * FROM viewenrollment WHERE `Student ID` = @id AND `Academic Year` = @year", conn)
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txtStudentID.Text
                cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = lblAcademicYear.Text
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

    Public Sub getPeriod()
        Dim periods As String = Nothing
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT schoolperiod FROM academicyear WHERE id = @year", conn)
                cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = lblAcademicYear.Text
                Using read As MySqlDataReader = cmd.ExecuteReader()
                    If (read.Read) Then
                        periods = read("schoolperiod").ToString
                    End If
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("An Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        If periods = "1st Sem" Then
            cbSemester.Items.Clear()
            cbSemester.Items.Add("1st Sem")
        End If

        If periods = "2nd Sem" Then
            cbSemester.Items.Clear()
            cbSemester.Items.Add("2nd Sem")
        End If

        If periods = "Summer" Then
            cbSemester.Items.Clear()
            cbSemester.Items.Add("Summer")
        End If
    End Sub
End Class