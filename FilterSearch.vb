Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class FilterSearch
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private mainForm As StudentForm

    Public Sub New(form As StudentForm)
        InitializeComponent()
        mainForm = form
    End Sub

    Private Sub FilterSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        PopulateProgram()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            mainForm.dgvStudentRecord.Rows.Clear()
            query = "SELECT studentID, firstname, lastname, middle, extensionName, gender, birthdate, phoneNumber, email, citizenship, birthcountry, birthplace, 
                religion, address, profile_photo, motherName, motherLast, motherMiddle, motherExtension, motherResidential, motherCitizenship, motherPhone, 
                motherEmail, fatherName, fatherLast, fatherMiddle, fatherExtension, fatherResidential, fatherCitizenship, fatherPhone, fatherEmail, contactName, 
                contactNumber, previousEducationllvl, previousprogramSHS, previousschool, previousyearAttendent, previousaward, currentEducationallvl, 
                currentProgram, currentyearLevel, currentschoolPeriod, currentschoolYear 
                FROM students WHERE 1=1"

            ' Dynamically add conditions
            If Not String.IsNullOrWhiteSpace(txtFullname.Text) Then
                query += " AND (firstname LIKE @fullname OR lastname LIKE @fullname)"
            End If

            If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                query += " AND studentID = @ID"
            End If

            If cbGender.SelectedItem IsNot Nothing Then
                query += " AND gender = @gender"
            End If

            If cbProgram.SelectedItem IsNot Nothing Then
                query += " AND currentProgram = @program"
            End If

            If cbYear.SelectedItem IsNot Nothing Then
                query += " AND currentyearLevel = @year"
            End If

            If cbSemester.SelectedItem IsNot Nothing Then
                query += " AND currentschoolPeriod = @semester"
            End If

            ' Append approval condition
            query += " AND approval = 'Accepted'"

            ' Append LIMIT if provided
            If Not String.IsNullOrWhiteSpace(txtLimit.Text) AndAlso IsNumeric(txtLimit.Text) Then
                query += " LIMIT " & txtLimit.Text
            End If

            ' Create command
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters
                If Not String.IsNullOrWhiteSpace(txtFullname.Text) Then
                    cmd.Parameters.AddWithValue("@fullname", "%" & txtFullname.Text & "%")
                End If

                If Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
                    cmd.Parameters.AddWithValue("@ID", txtStudentID.Text)
                End If

                If cbGender.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@gender", cbGender.SelectedItem.ToString)
                End If

                If cbProgram.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@program", cbProgram.SelectedItem.ToString)
                End If

                If cbYear.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@year", cbYear.SelectedItem.ToString)
                End If

                If cbSemester.SelectedItem IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@semester", cbSemester.SelectedItem.ToString)
                End If

                ' Execute query
                Using dr = cmd.ExecuteReader
                    While dr.Read
                        Dim acceptImage As Image = My.Resources.pen

                        ' Add rows to DataGridView
                        mainForm.dgvStudentRecord.Rows.Add(acceptImage, dr("studentID"), dr("firstname"), dr("lastname"), dr("middle"), dr("extensionName"), dr("gender"),
                         CType(dr("birthdate"), Date).ToString("MM/dd/yyyy"), dr("phoneNumber"), dr("email"), dr("citizenship"), dr("birthcountry"), dr("birthplace"), dr("religion"),
                         dr("address"), dr("profile_photo"), dr("motherName"), dr("motherLast"), dr("motherMiddle"), dr("motherExtension"),
                         dr("motherResidential"), dr("motherCitizenship"), dr("motherPhone"), dr("motherEmail"), dr("fatherName"), dr("fatherLast"),
                         dr("fatherMiddle"), dr("fatherExtension"), dr("fatherResidential"), dr("fatherCitizenship"), dr("fatherPhone"),
                         dr("fatherEmail"), dr("contactName"), dr("contactNumber"), dr("previousEducationllvl"), dr("previousprogramSHS"),
                         dr("previousschool"), dr("previousyearAttendent"), dr("previousaward"), dr("currentEducationallvl"), dr("currentProgram"),
                         dr("currentyearLevel"), dr("currentschoolPeriod"), dr("currentschoolYear"))
                    End While
                End Using
            End Using

            ' Clear selection in DataGridView
            mainForm.dgvStudentRecord.ClearSelection()
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Me.Close()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Public Sub clearText()
        txtFullname.Text = ""
        txtStudentID.Text = ""
        txtLimit.Text = ""
        cbGender.SelectedItem = Nothing
        cbProgram.SelectedItem = Nothing
        cbYear.SelectedItem = Nothing
        cbSemester.SelectedItem = Nothing
    End Sub

    Private Sub PopulateProgram()
        Try
            conn.Open()
            Using cmd As New MySqlCommand("SELECT * FROM programs", conn)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbProgram.Items.Clear()

                For Each dr As DataRow In table.Rows
                    cbProgram.Items.Add(dr("ProgramName").ToString())
                Next
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class