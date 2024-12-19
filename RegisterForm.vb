Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class RegisterForm
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private ReadOnly _isReadOnly As Boolean

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        PopulateProgram_AcamedicYear()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(studentData As Dictionary(Of String, Object))
        InitializeComponent()
        If studentData IsNot Nothing Then
            txtFirstName.Text = studentData("firstname")
            txtLastName.Text = studentData("lastname")
            txtMiddle.Text = studentData("middle")
            txtExtension.Text = studentData("extensionName")
            cbGender.SelectedItem = studentData("gender")
            dtpBirthDate.Value = Date.Parse(studentData("birthdate"))
            txtPhoneNumber.Text = studentData("phoneNumber")
            txtEmail.Text = studentData("email")
            txtCitizenship.Text = studentData("citizenship")
            txtBirthCountry.Text = studentData("birthcountry")
            txtBirthplace.Text = studentData("birthplace")
            txtReligion.Text = studentData("religion")
            txtAddress.Text = studentData("address")
            txtMotherFirstname.Text = studentData("motherName")
            txtMotherLastname.Text = studentData("motherLast")
            txtMotherMiddle.Text = studentData("motherMiddle")
            txtMotherExt.Text = studentData("motherExtension")
            txtMotherResisdential.Text = studentData("motherResidential")
            txtMotherCitizen.Text = studentData("motherCitizenship")
            txtMotherPhone.Text = studentData("motherPhone")
            txtMotherEmail.Text = studentData("motherEmail")
            txtFatherFirstname.Text = studentData("fatherName")
            txtFatherLastname.Text = studentData("fatherLast")
            txtFatherMiddle.Text = studentData("fatherMiddle")
            txtFatherExt.Text = studentData("fatherExtension")
            txtFatherResisdential.Text = studentData("fatherResidential")
            txtFatherCitizen.Text = studentData("fatherCitizenship")
            txtFatherPhone.Text = studentData("fatherPhone")
            txtFatherEmail.Text = studentData("fatherEmail")
            txtEmergencyContactName.Text = studentData("contactName")
            txtEmergencyNumber.Text = studentData("contactNumber")
            cbPreviousEducationLvl.SelectedItem = studentData("previousEducationllvl")
            txtProgramSHS.Text = studentData("previousprogramSHS")
            txtSchool.Text = studentData("previousschool")
            txtYearAttendent.Text = studentData("previousyearAttendent")
            cbAwards.SelectedItem = studentData("previousaward")
            cbEducationalLvl.SelectedItem = studentData("currentEducationallvl")
            cbProgram.SelectedItem = studentData("currentProgram")
            cbYearLevel.SelectedItem = studentData("currentyearLevel")
            cbSchoolPeriod.SelectedItem = studentData("currentschoolPeriod")
            cbSchoolYear.SelectedItem = studentData("currentschoolYear")
            txtAccountUsername.Text = studentData("username")
            txtAccountPassword.Text = studentData("password")

            Dim imageData As Byte() = CType(studentData("profile_photo"), Byte())
            Using ms As New MemoryStream(imageData)
                PictureBoxStudentImage.Image = Image.FromStream(ms)
            End Using
        End If
        SetControlsReadOnly(True)
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click, btnCancel.Click
        SetControlsReadOnly(False)
        Close()
        Login.Show()
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged, txtMotherPhone.TextChanged, txtFatherPhone.TextChanged, txtEmergencyNumber.TextChanged
        ' Check if the length of the text exceeds 11 characters
        If CType(sender, TextBox).Text.Length > 11 Then
            CType(sender, TextBox).Text = CType(sender, TextBox).Text.Substring(0, 11)
            CType(sender, TextBox).SelectionStart = CType(sender, TextBox).Text.Length
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress, txtMotherPhone.KeyPress, txtFatherPhone.KeyPress, txtEmergencyNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim born_year As Integer = dtpBirthDate.Value.Year
        Dim this_year As Integer = Date.Now.Year

        Try
            If this_year - born_year < 0 Or this_year - born_year > 150 Then
                If verif() Then
                    MsgBox("The Student Age Must Be Between 1 and 150 year old", MsgBoxStyle.Exclamation, "Birth Date Error")
                Else
                    MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Sumbit Registration Form")
                End If
            Else
                If verif() Then
                    conn.Open()

                    If DuplicateAccount() Then MsgBox("Duplicate User Account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Return
                    If DuplicateStudent() Then Return
                    If IsDuplicateInfo(txtEmail.Text, txtPhoneNumber.Text, txtMotherEmail.Text, txtMotherPhone.Text, txtFatherEmail.Text, txtFatherPhone.Text, txtEmergencyNumber.Text) Then Return

                    Dim studentrole As String = "Student"
                    Dim userID As Integer

                    cmd = New MySqlCommand("INSERT INTO useraccount (username, password, owner, email, role) VALUES (@username,@password, @name, @email, @role)", conn)
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtAccountUsername.Text
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtAccountPassword.Text
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtFirstName.Text & " " & txtLastName.Text
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
                    cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = studentrole

                    cmd.ExecuteNonQuery()

                    Using cmd = New MySqlCommand("SELECT id FROM useraccount WHERE username = @username AND password = @password AND role = @role", conn)
                        cmd.Parameters.AddWithValue("@username", txtAccountUsername.Text)
                        cmd.Parameters.AddWithValue("@password", txtAccountPassword.Text)
                        cmd.Parameters.AddWithValue("@role", studentrole)
                        Try
                            Dim reader = cmd.ExecuteReader
                            If reader.Read Then
                                userID = reader("id")
                            Else
                                MsgBox("No useraccount Found")
                            End If
                            reader.Close()
                        Catch ex As Exception
                            MsgBox("An error occurred: " & ex.Message)
                        End Try
                    End Using

                    query = "INSERT INTO students (useraccount_id, firstname, lastname, middle, extensionName, gender, birthdate, phoneNumber, email, 
                        citizenship, birthcountry, birthplace, religion, address, profile_photo, motherName, motherLast, motherMiddle, motherExtension, 
                        motherResidential, motherCitizenship, motherPhone, motherEmail, fatherName, fatherLast, fatherMiddle, fatherExtension, 
                        fatherResidential, fatherCitizenship, fatherPhone, fatherEmail, contactName, contactNumber, previousEducationllvl, 
                        previousprogramSHS, previousschool, previousyearAttendent, previousaward, currentEducationallvl, currentProgram, currentyearLevel, 
                        currentschoolPeriod, currentschoolYear) 
                        VALUES (@userid, @first, @last, @mid, @ext, @gender, @bday, @phone, @email, @citizen, @bcountry, @bplace, @religion, @addr, @photo, 
                        @momfirst, @momlast, @mommid, @momext, @momaddr, @momcitizen, @momphone, @momemail, @dadfirst, @dadlast, @dadmid, @dadext, @dadaddr, 
                        @dadcitizen, @dadphone, @dademail, @contactname, @contactphone, @prevlvl, @prevprog, @prevschool, @prevyear, @prevaward, @currlvl, 
                        @currprog, @curryear, @currperiod, @currsy)"

                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@userid", MySqlDbType.Int32).Value = userID
                    cmd.Parameters.Add("@first", MySqlDbType.VarChar).Value = txtFirstName.Text
                    cmd.Parameters.Add("@last", MySqlDbType.VarChar).Value = txtLastName.Text
                    cmd.Parameters.Add("@mid", MySqlDbType.VarChar).Value = txtMiddle.Text
                    cmd.Parameters.Add("@ext", MySqlDbType.VarChar).Value = txtExtension.Text
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = cbGender.SelectedItem
                    cmd.Parameters.Add("@bday", MySqlDbType.Date).Value = Format(dtpBirthDate.Value, "yyyy/MM/dd")
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhoneNumber.Text
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
                    cmd.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = txtCitizenship.Text
                    cmd.Parameters.Add("@bcountry", MySqlDbType.VarChar).Value = txtBirthCountry.Text
                    cmd.Parameters.Add("@bplace", MySqlDbType.VarChar).Value = txtBirthplace.Text
                    cmd.Parameters.Add("@religion", MySqlDbType.VarChar).Value = txtReligion.Text
                    cmd.Parameters.Add("@addr", MySqlDbType.Text).Value = txtAddress.Text
                    cmd.Parameters.Add("@momfirst", MySqlDbType.VarChar).Value = txtMotherFirstname.Text
                    cmd.Parameters.Add("@momlast", MySqlDbType.VarChar).Value = txtMotherLastname.Text
                    cmd.Parameters.Add("@mommid", MySqlDbType.VarChar).Value = txtMotherMiddle.Text
                    cmd.Parameters.Add("@momext", MySqlDbType.VarChar).Value = txtMotherExt.Text
                    cmd.Parameters.Add("@momaddr", MySqlDbType.Text).Value = txtMotherResisdential.Text
                    cmd.Parameters.Add("@momcitizen", MySqlDbType.VarChar).Value = txtMotherCitizen.Text
                    cmd.Parameters.Add("@momphone", MySqlDbType.VarChar).Value = txtMotherPhone.Text
                    cmd.Parameters.Add("@momemail", MySqlDbType.VarChar).Value = txtMotherEmail.Text
                    cmd.Parameters.Add("@dadfirst", MySqlDbType.VarChar).Value = txtFatherFirstname.Text
                    cmd.Parameters.Add("@dadlast", MySqlDbType.VarChar).Value = txtFatherLastname.Text
                    cmd.Parameters.Add("@dadmid", MySqlDbType.VarChar).Value = txtFatherMiddle.Text
                    cmd.Parameters.Add("@dadext", MySqlDbType.VarChar).Value = txtFatherExt.Text
                    cmd.Parameters.Add("@dadaddr", MySqlDbType.Text).Value = txtFatherResisdential.Text
                    cmd.Parameters.Add("@dadcitizen", MySqlDbType.VarChar).Value = txtFatherCitizen.Text
                    cmd.Parameters.Add("@dadphone", MySqlDbType.VarChar).Value = txtFatherPhone.Text
                    cmd.Parameters.Add("@dademail", MySqlDbType.VarChar).Value = txtFatherEmail.Text
                    cmd.Parameters.Add("@contactname", MySqlDbType.VarChar).Value = txtEmergencyContactName.Text
                    cmd.Parameters.Add("@contactphone", MySqlDbType.VarChar).Value = txtEmergencyNumber.Text
                    cmd.Parameters.Add("@prevlvl", MySqlDbType.VarChar).Value = cbPreviousEducationLvl.SelectedItem
                    cmd.Parameters.Add("@prevprog", MySqlDbType.VarChar).Value = txtProgramSHS.Text
                    cmd.Parameters.Add("@prevschool", MySqlDbType.VarChar).Value = txtSchool.Text
                    cmd.Parameters.Add("@prevyear", MySqlDbType.VarChar).Value = txtYearAttendent.Text
                    cmd.Parameters.Add("@prevaward", MySqlDbType.VarChar).Value = cbAwards.SelectedItem
                    cmd.Parameters.Add("@currlvl", MySqlDbType.VarChar).Value = cbEducationalLvl.SelectedItem
                    cmd.Parameters.Add("@currprog", MySqlDbType.VarChar).Value = cbProgram.SelectedItem
                    cmd.Parameters.Add("@curryear", MySqlDbType.Int32).Value = cbYearLevel.SelectedItem
                    cmd.Parameters.Add("@currperiod", MySqlDbType.VarChar).Value = cbSchoolPeriod.SelectedItem
                    cmd.Parameters.Add("@currsy", MySqlDbType.VarChar).Value = cbSchoolYear.SelectedItem
                    ' Input for image
                    If PictureBoxStudentImage.Image IsNot Nothing Then
                        Using ms As New MemoryStream()
                            Dim img As New Bitmap(PictureBoxStudentImage.Image)
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim data As Byte() = ms.ToArray()
                            Dim p As New MySqlParameter("@photo", MySqlDbType.LongBlob)
                            p.Value = data
                            cmd.Parameters.Add(p)
                        End Using
                    Else
                        ' Handle case where no image is provided
                        cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = DBNull.Value
                    End If

                    If cmd.ExecuteNonQuery() = 1 Then
                        MsgBox("Successfully Sumbited Your Registration, Wait for the Admin Approval.", MsgBoxStyle.Information, "Sumbit Registration Form")
                        Me.Close()
                        Login.Show()
                    Else
                        MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Sumbit Registration Form")
                    End If
                Else
                    MsgBox("Please fill-in all required fields.", MsgBoxStyle.Exclamation, "Sumbit Registration Form")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then
            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Function verif() As Boolean
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtMiddle.Text.Trim() = "" Or txtExtension.Text.Trim() = "" Or cbGender.SelectedItem Is Nothing Or
           txtPhoneNumber.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtCitizenship.Text.Trim() = "" Or txtBirthCountry.Text.Trim() = "" Or txtBirthplace.Text.Trim() = "" Or
           txtReligion.Text.Trim() = "" Or txtAddress.Text.Trim() = "" Or txtMotherFirstname.Text.Trim() = "" Or txtMotherLastname.Text.Trim() = "" Or txtMotherMiddle.Text.Trim() = "" Or
           txtMotherExt.Text.Trim() = "" Or txtMotherResisdential.Text.Trim() = "" Or txtMotherCitizen.Text.Trim() = "" Or txtMotherPhone.Text.Trim() = "" Or
           txtMotherEmail.Text.Trim() = "" Or txtFatherFirstname.Text.Trim() = "" Or txtFatherLastname.Text.Trim() = "" Or txtFatherMiddle.Text.Trim() = "" Or
           txtFatherExt.Text.Trim() = "" Or txtFatherResisdential.Text.Trim() = "" Or txtFatherCitizen.Text.Trim() = "" Or txtFatherPhone.Text.Trim() = "" Or
           txtFatherEmail.Text.Trim() = "" Or txtEmergencyContactName.Text.Trim() = "" Or txtEmergencyNumber.Text.Trim() = "" Or cbPreviousEducationLvl.SelectedItem Is Nothing Or
           txtProgramSHS.Text.Trim() = "" Or txtSchool.Text.Trim() = "" Or txtYearAttendent.Text.Trim() = "" Or cbAwards.SelectedItem Is Nothing Or
           cbEducationalLvl.SelectedItem Is Nothing Or cbProgram.SelectedItem Is Nothing Or cbYearLevel.SelectedItem Is Nothing Or cbSchoolPeriod.SelectedItem Is Nothing Or
           cbSchoolYear.SelectedItem Is Nothing Or txtAccountUsername.Text.Trim() = "" Or txtAccountPassword.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function DuplicateStudent() As Boolean
        Dim isDuplicate As Boolean = False
        query = "SELECT COUNT(*) FROM students WHERE firstname = @first AND lastname = @last AND middle = @mid AND extensionName = @ext AND gender = @gender 
            AND birthdate = @bday AND phoneNumber = @phone AND email = @email AND citizenship = @citizen AND birthcountry = @bcountry AND birthplace = 
            @bplace AND religion = @religion AND address = @addr AND motherName = @momfirst AND motherLast = @momlast AND motherMiddle = @mommid AND 
            motherExtension = @momext AND motherResidential = @momaddr AND motherCitizenship = @momcitizen AND motherPhone = @momphone AND 
            motherEmail = @momemail AND fatherName = @dadfirst AND fatherLast = @dadlast AND fatherMiddle = @dadmid AND fatherExtension = @dadext AND 
            fatherResidential = @dadaddr AND fatherCitizenship = @dadcitizen AND fatherPhone = @dadphone AND fatherEmail = @dademail AND contactName = 
            @contactname AND contactNumber = @contactphone AND previousEducationllvl = @prevlvl AND previousprogramSHS = @prevprog AND previousschool = 
            @prevschool And previousyearAttendent = @prevyear And previousaward = @prevaward And currentEducationallvl = @currlvl And currentProgram = 
            @currprog AND currentyearLevel = @curryear AND currentschoolPeriod = @currperiod AND currentschoolYear = @currsy"

        Using cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@first", MySqlDbType.VarChar).Value = txtFirstName.Text
            cmd.Parameters.Add("@last", MySqlDbType.VarChar).Value = txtLastName.Text
            cmd.Parameters.Add("@mid", MySqlDbType.VarChar).Value = txtMiddle.Text
            cmd.Parameters.Add("@ext", MySqlDbType.VarChar).Value = txtExtension.Text
            cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = cbGender.SelectedItem
            cmd.Parameters.Add("@bday", MySqlDbType.Date).Value = Format(dtpBirthDate.Value, "yyyy/MM/dd")
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhoneNumber.Text
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
            cmd.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = txtCitizenship.Text
            cmd.Parameters.Add("@bcountry", MySqlDbType.VarChar).Value = txtBirthCountry.Text
            cmd.Parameters.Add("@bplace", MySqlDbType.VarChar).Value = txtBirthplace.Text
            cmd.Parameters.Add("@religion", MySqlDbType.VarChar).Value = txtReligion.Text
            cmd.Parameters.Add("@addr", MySqlDbType.Text).Value = txtAddress.Text
            cmd.Parameters.Add("@momfirst", MySqlDbType.VarChar).Value = txtMotherFirstname.Text
            cmd.Parameters.Add("@momlast", MySqlDbType.VarChar).Value = txtMotherLastname.Text
            cmd.Parameters.Add("@mommid", MySqlDbType.VarChar).Value = txtMotherMiddle.Text
            cmd.Parameters.Add("@momext", MySqlDbType.VarChar).Value = txtMotherExt.Text
            cmd.Parameters.Add("@momaddr", MySqlDbType.Text).Value = txtMotherResisdential.Text
            cmd.Parameters.Add("@momcitizen", MySqlDbType.VarChar).Value = txtMotherCitizen.Text
            cmd.Parameters.Add("@momphone", MySqlDbType.VarChar).Value = txtMotherPhone.Text
            cmd.Parameters.Add("@momemail", MySqlDbType.VarChar).Value = txtMotherEmail.Text
            cmd.Parameters.Add("@dadfirst", MySqlDbType.VarChar).Value = txtFatherFirstname.Text
            cmd.Parameters.Add("@dadlast", MySqlDbType.VarChar).Value = txtFatherLastname.Text
            cmd.Parameters.Add("@dadmid", MySqlDbType.VarChar).Value = txtFatherMiddle.Text
            cmd.Parameters.Add("@dadext", MySqlDbType.VarChar).Value = txtFatherExt.Text
            cmd.Parameters.Add("@dadaddr", MySqlDbType.Text).Value = txtFatherResisdential.Text
            cmd.Parameters.Add("@dadcitizen", MySqlDbType.VarChar).Value = txtFatherCitizen.Text
            cmd.Parameters.Add("@dadphone", MySqlDbType.VarChar).Value = txtFatherPhone.Text
            cmd.Parameters.Add("@dademail", MySqlDbType.VarChar).Value = txtFatherEmail.Text
            cmd.Parameters.Add("@contactname", MySqlDbType.VarChar).Value = txtEmergencyContactName.Text
            cmd.Parameters.Add("@contactphone", MySqlDbType.VarChar).Value = txtEmergencyNumber.Text
            cmd.Parameters.Add("@prevlvl", MySqlDbType.VarChar).Value = cbPreviousEducationLvl.SelectedItem
            cmd.Parameters.Add("@prevprog", MySqlDbType.VarChar).Value = txtProgramSHS.Text
            cmd.Parameters.Add("@prevschool", MySqlDbType.VarChar).Value = txtSchool.Text
            cmd.Parameters.Add("@prevyear", MySqlDbType.VarChar).Value = txtYearAttendent.Text
            cmd.Parameters.Add("@prevaward", MySqlDbType.VarChar).Value = cbAwards.SelectedItem
            cmd.Parameters.Add("@currlvl", MySqlDbType.VarChar).Value = cbEducationalLvl.SelectedItem
            cmd.Parameters.Add("@currprog", MySqlDbType.VarChar).Value = cbProgram.SelectedItem
            cmd.Parameters.Add("@curryear", MySqlDbType.Int32).Value = cbYearLevel.SelectedItem
            cmd.Parameters.Add("@currperiod", MySqlDbType.VarChar).Value = cbSchoolPeriod.SelectedItem
            cmd.Parameters.Add("@currsy", MySqlDbType.VarChar).Value = cbSchoolYear.SelectedItem
            Try
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If result > 0 Then
                    isDuplicate = True
                    MsgBox("This record already exists in the database. Please ensure the details are unique.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while checking for duplicate records: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return isDuplicate
    End Function

    Function DuplicateAccount() As Boolean
        Dim duplicates As Boolean = False

        Using cmd = New MySqlCommand("SELECT * FROM useraccount WHERE username = @username AND password = @password ", conn)
            cmd.Parameters.AddWithValue("@username", txtAccountUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtAccountPassword.Text)
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


    Function IsDuplicateInfo(email As String, phone As String, motherEmail As String, motherPhone As String, fatherEmail As String, fatherPhone As String, emergencyPhone As String) As Boolean
        Dim isDuplicate As Boolean = False
        Dim duplicateFields As New List(Of String)()

        Using cmd = New MySqlCommand("
        SELECT 
            (CASE WHEN email = @Email THEN 1 ELSE 0 END) AS EmailDuplicate,
            (CASE WHEN phoneNumber = @Phone THEN 1 ELSE 0 END) AS PhoneDuplicate,
            (CASE WHEN motherEmail = @MotherEmail THEN 1 ELSE 0 END) AS MotherEmailDuplicate,
            (CASE WHEN motherPhone = @MotherPhone THEN 1 ELSE 0 END) AS MotherPhoneDuplicate,
            (CASE WHEN fatherEmail = @FatherEmail THEN 1 ELSE 0 END) AS FatherEmailDuplicate,
            (CASE WHEN fatherPhone = @FatherPhone THEN 1 ELSE 0 END) AS FatherPhoneDuplicate,
            (CASE WHEN contactNumber = @EmergencyPhone THEN 1 ELSE 0 END) AS EmergencyPhoneDuplicate
        FROM students
        WHERE 
            email = @Email OR
            phoneNumber = @Phone OR
            motherEmail = @MotherEmail OR
            motherPhone = @MotherPhone OR
            fatherEmail = @FatherEmail OR
            fatherPhone = @FatherPhone OR
            contactNumber = @EmergencyPhone
        LIMIT 1", conn)

            ' Add parameters for all fields
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Phone", phone)
            cmd.Parameters.AddWithValue("@MotherEmail", motherEmail)
            cmd.Parameters.AddWithValue("@MotherPhone", motherPhone)
            cmd.Parameters.AddWithValue("@FatherEmail", fatherEmail)
            cmd.Parameters.AddWithValue("@FatherPhone", fatherPhone)
            cmd.Parameters.AddWithValue("@EmergencyPhone", emergencyPhone)

            Try
                Dim reader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Check for duplicates in each field
                    If reader("EmailDuplicate") = 1 Then duplicateFields.Add("Email")
                    If reader("PhoneDuplicate") = 1 Then duplicateFields.Add("Phone Number")
                    If reader("MotherEmailDuplicate") = 1 Then duplicateFields.Add("Mother's Email")
                    If reader("MotherPhoneDuplicate") = 1 Then duplicateFields.Add("Mother's Phone")
                    If reader("FatherEmailDuplicate") = 1 Then duplicateFields.Add("Father's Email")
                    If reader("FatherPhoneDuplicate") = 1 Then duplicateFields.Add("Father's Phone")
                    If reader("EmergencyPhoneDuplicate") = 1 Then duplicateFields.Add("Emergency Contact Phone")
                End If
                reader.Close()

                ' If there are duplicates, show a message
                If duplicateFields.Count > 0 Then
                    isDuplicate = True
                    MsgBox("The following field(s) have duplicate values: " & String.Join(", ", duplicateFields) & ". Please use unique values.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while checking for duplicate information: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return isDuplicate
    End Function

    Private Sub txtFirstName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtLastName.KeyDown, txtMiddle.KeyDown, txtExtension.KeyDown, txtPhoneNumber.KeyDown, txtEmail.KeyDown, txtCitizenship.KeyDown, txtBirthCountry.KeyDown, txtBirthplace.KeyDown, txtReligion.KeyDown, txtAddress.KeyDown, txtMotherFirstname.KeyDown, txtMotherLastname.KeyDown, txtMotherMiddle.KeyDown, txtMotherExt.KeyDown, txtMotherResisdential.KeyDown, txtMotherCitizen.KeyDown, txtMotherPhone.KeyDown, txtMotherEmail.KeyDown, txtFatherFirstname.KeyDown, txtFatherLastname.KeyDown, txtFatherMiddle.KeyDown, txtFatherExt.KeyDown, txtFatherResisdential.KeyDown, txtFatherCitizen.KeyDown, txtFatherPhone.KeyDown, txtFatherEmail.KeyDown, txtEmergencyContactName.KeyDown, txtEmergencyNumber.KeyDown, txtProgramSHS.KeyDown, txtSchool.KeyDown, txtYearAttendent.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim controls As Control() = {txtFirstName, txtLastName, txtMiddle, txtExtension, txtPhoneNumber, txtEmail, txtCitizenship, txtBirthCountry, txtBirthplace, txtReligion, txtAddress, txtMotherFirstname, txtMotherLastname, txtMotherMiddle, txtMotherExt, txtMotherResisdential, txtMotherCitizen, txtMotherPhone, txtMotherEmail, txtFatherFirstname, txtFatherLastname, txtFatherMiddle, txtFatherExt, txtFatherResisdential, txtFatherCitizen, txtFatherPhone, txtFatherEmail, txtEmergencyContactName, txtEmergencyNumber, txtProgramSHS, txtSchool, txtYearAttendent}
            For i As Integer = 0 To controls.Length - 2
                If sender Is controls(i) Then controls(i + 1).Focus()
            Next
        End If
    End Sub

    Private Sub SetControlsReadOnly(isReadOnly As Boolean)
        ' Group TextBox controls
        Dim readOnlyTextBoxes As TextBox() = {
        txtFirstName, txtLastName, txtMiddle, txtExtension, txtPhoneNumber, txtEmail,
        txtCitizenship, txtBirthCountry, txtBirthplace, txtReligion, txtAddress,
        txtMotherFirstname, txtMotherLastname, txtMotherMiddle, txtMotherExt,
        txtMotherResisdential, txtMotherCitizen, txtMotherPhone, txtMotherEmail,
        txtFatherFirstname, txtFatherLastname, txtFatherMiddle, txtFatherExt,
        txtFatherResisdential, txtFatherCitizen, txtFatherPhone, txtFatherEmail,
        txtEmergencyContactName, txtEmergencyNumber, txtProgramSHS, txtSchool,
        txtYearAttendent, txtAccountUsername, txtAccountPassword
    }

        For Each txt In readOnlyTextBoxes
            txt.ReadOnly = isReadOnly
        Next

        Dim enabledComboBoxes As ComboBox() = {
        cbGender, cbPreviousEducationLvl, cbAwards, cbEducationalLvl,
        cbProgram, cbYearLevel, cbSchoolPeriod, cbSchoolYear
    }

        For Each cb In enabledComboBoxes
            cb.Enabled = Not isReadOnly
        Next

        dtpBirthDate.Enabled = Not isReadOnly
        btnUpload.Enabled = Not isReadOnly
    End Sub

    Private Sub PopulateProgram_AcamedicYear()
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

            Using cmd As New MySqlCommand("SELECT * FROM academicyear", conn)
                adapter = New MySqlDataAdapter(cmd)
                table = New DataTable()
                adapter.Fill(table)

                cbSchoolYear.Items.Clear()
                For Each dr As DataRow In table.Rows
                    cbSchoolYear.Items.Add(dr("id").ToString())
                Next
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub lblExtraExit_Click(sender As Object, e As EventArgs) Handles lblExtraExit.Click
        SetControlsReadOnly(False)
        Close()
    End Sub
End Class