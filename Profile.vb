Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Profile
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Dim UserID As Integer
    Private _userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getstudentinfo()
    End Sub

    Public Sub getstudentinfo()
        Using cmd = New MySqlCommand("SELECT * FROM students WHERE useraccount_id = @id", conn)
            cmd.Parameters.AddWithValue("@id", _userId)
            Try
                conn.Open() ' Open the connection
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' If a record is found, populate the text boxes
                    txtFirstname.Text = reader("firstname").ToString()
                    txtLastname.Text = reader("lastname").ToString()
                    txtMiddle.Text = reader("middle").ToString()
                    txtExtension.Text = reader("extensionName").ToString()
                    cbGender.SelectedItem = reader("gender").ToString()
                    dtpBirthDate.Value = reader("birthdate").ToString()
                    txtPhoneNumber.Text = reader("phoneNumber").ToString()
                    txtEmail.Text = reader("email").ToString()
                    txtCitizenship.Text = reader("citizenship").ToString()
                    txtBirthCountry.Text = reader("birthcountry").ToString()
                    txtBirthPlace.Text = reader("birthplace").ToString()
                    txtReligion.Text = reader("religion").ToString()
                    txtAddress.Text = reader("address").ToString()

                    txtMotherFirstname.Text = reader("motherName").ToString()
                    txtMotherLastname.Text = reader("motherLast").ToString()
                    txtMotherMiddle.Text = reader("motherMiddle").ToString()
                    txtMotherExt.Text = reader("motherExtension").ToString()
                    txtMotherResisdential.Text = reader("motherResidential").ToString()
                    txtMotherCitizen.Text = reader("motherCitizenship").ToString()
                    txtMotherPhone.Text = reader("motherPhone").ToString()
                    txtMotherEmail.Text = reader("motherEmail").ToString()

                    txtFatherFirstname.Text = reader("fatherName").ToString()
                    txtFatherLastname.Text = reader("fatherLast").ToString()
                    txtFatherMiddle.Text = reader("fatherMiddle").ToString()
                    txtFatherExt.Text = reader("fatherExtension").ToString()
                    txtFatherResisdential.Text = reader("fatherResidential").ToString()
                    txtFatherCitizen.Text = reader("fatherCitizenship").ToString()
                    txtFatherPhone.Text = reader("fatherPhone").ToString()
                    txtFatherEmail.Text = reader("fatherEmail").ToString()
                    txtEmergencyContactName.Text = reader("contactName").ToString()
                    txtEmergencyNumber.Text = reader("contactNumber").ToString()

                    'get image
                    Dim imageData As Byte() = DirectCast(reader("profile_photo"), Byte())
                    Using ms As New MemoryStream(imageData)
                        PictureBoxStudentImage.Image = Image.FromStream(ms)
                    End Using
                Else
                    MsgBox("No Student Found")
                End If
                reader.Close() ' Close the reader
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then
            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim born_year As Integer = dtpBirthDate.Value.Year
        Dim this_year As Integer = Date.Now.Year

        Try
            If this_year - born_year < 0 Or this_year - born_year > 150 Then
                MsgBox("The Student Age Must Be Between 1 and 150 year old", MsgBoxStyle.Exclamation, "Birth Date Error")
            Else
                conn.Open()
                query = "UPDATE students SET firstname = @first, lastname = @last, middle = @mid, extensionName = @ext, gender = @gender, birthdate = @bday, 
                phoneNumber = @phone, email = @email, citizenship = @citizen, birthcountry = @bcountry, birthplace = @bplace, religion = @religion, 
                address = @addr, profile_photo = @photo, motherName = @momfirst, motherLast = @momlast, motherMiddle = @mommid, motherExtension = @momext, 
                motherResidential = @momaddr, motherCitizenship = @momcitizen, motherPhone = @momphone, motherEmail = @momemail, fatherName = @dadfirst, 
                fatherLast = @dadlast, fatherMiddle = @dadmid, fatherExtension = @dadext, fatherResidential = @dadaddr, fatherCitizenship = @dadcitizen, 
                fatherPhone = @dadphone, fatherEmail = @dademail, contactName = @contactname, contactNumber = @contactphone WHERE useraccount_id = @id;
"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = _userId
                cmd.Parameters.Add("@first", MySqlDbType.VarChar).Value = txtFirstname.Text
                cmd.Parameters.Add("@last", MySqlDbType.VarChar).Value = txtLastname.Text
                    cmd.Parameters.Add("@mid", MySqlDbType.VarChar).Value = txtMiddle.Text
                    cmd.Parameters.Add("@ext", MySqlDbType.VarChar).Value = txtExtension.Text
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = cbGender.SelectedItem
                    cmd.Parameters.Add("@bday", MySqlDbType.Date).Value = Format(dtpBirthDate.Value, "yyyy/MM/dd")
                    cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhoneNumber.Text
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
                    cmd.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = txtCitizenship.Text
                    cmd.Parameters.Add("@bcountry", MySqlDbType.VarChar).Value = txtBirthCountry.Text
                    cmd.Parameters.Add("@bplace", MySqlDbType.VarChar).Value = txtBirthPlace.Text
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
                    MsgBox("Successfully Update Student Information.", MsgBoxStyle.Information, "Update Student Info")
                Else
                    MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Update Student Info")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class