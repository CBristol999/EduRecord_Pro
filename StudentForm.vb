Imports System.Drawing.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Ocsp

Public Class StudentForm
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Dim query As String
    Dim stuID, userID As Integer
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getDisplay(dgvStudentRecord)
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
                    Dim acceptImage As Image = My.Resources.pen

                    dgv.Rows.Add(acceptImage, dr("studentID"), dr("firstname"), dr("lastname"), dr("middle"), dr("extensionName"), dr("gender"),
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


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim enrollForm As New FilterSearch(Me)
        enrollForm.ShowDialog()
    End Sub

    Private Sub dgvStudentRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentRecord.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim columnName = dgvStudentRecord.Columns(e.ColumnIndex).Name
        Dim studentIDD = dgvStudentRecord.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim row = dgvStudentRecord.Rows(e.RowIndex)

        If columnName = "getView" Then

            Try
                Dim int As Integer
                Dim str As String = String.Empty
                Dim str2 As String = String.Empty
                Using cmd As New MySqlCommand("SELECT useraccount_id FROM students WHERE studentID = @studentID", conn)
                    cmd.Parameters.AddWithValue("@studentID", studentIDD)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Int = reader("useraccount_id").ToString()
                        End If
                        reader.Close()
                    End Using
                    conn.Close()
                End Using

                Using cmd As New MySqlCommand("SELECT username, password FROM useraccount WHERE id = @ID", conn)
                    cmd.Parameters.AddWithValue("@ID", Int)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            str = reader("username").ToString()
                            str2 = reader("password").ToString()
                        End If
                        reader.Close()
                    End Using
                    conn.Close()
                End Using

                Dim studentData As New Dictionary(Of String, Object) From {
                {"studentID", row.Cells("Column1").Value?.ToString()},
                {"firstname", row.Cells("Column2").Value?.ToString()},
                {"lastname", row.Cells("Column3").Value?.ToString()},
                {"middle", row.Cells("Column4").Value?.ToString()},
                {"extensionName", row.Cells("Column5").Value?.ToString()},
                {"gender", row.Cells("Column6").Value?.ToString()},
                {"birthdate", row.Cells("Column7").Value?.ToString()},
                {"phoneNumber", row.Cells("Column8").Value?.ToString()},
                {"email", row.Cells("Column9").Value?.ToString()},
                {"citizenship", row.Cells("Column10").Value?.ToString()},
                {"birthcountry", row.Cells("Column11").Value?.ToString()},
                {"birthplace", row.Cells("Column12").Value?.ToString()},
                {"religion", row.Cells("Column13").Value?.ToString()},
                {"address", row.Cells("Column14").Value?.ToString()},
                {"profile_photo", CType(row.Cells("Column15").Value, Byte())},
                {"motherName", row.Cells("Column16").Value?.ToString()},
                {"motherLast", row.Cells("Column17").Value?.ToString()},
                {"motherMiddle", row.Cells("Column18").Value?.ToString()},
                {"motherExtension", row.Cells("Column19").Value?.ToString()},
                {"motherResidential", row.Cells("Column20").Value?.ToString()},
                {"motherCitizenship", row.Cells("Column21").Value?.ToString()},
                {"motherPhone", row.Cells("Column22").Value?.ToString()},
                {"motherEmail", row.Cells("Column23").Value?.ToString()},
                {"fatherName", row.Cells("Column24").Value?.ToString()},
                {"fatherLast", row.Cells("Column25").Value?.ToString()},
                {"fatherMiddle", row.Cells("Column26").Value?.ToString()},
                {"fatherExtension", row.Cells("Column27").Value?.ToString()},
                {"fatherResidential", row.Cells("Column28").Value?.ToString()},
                {"fatherCitizenship", row.Cells("Column29").Value?.ToString()},
                {"fatherPhone", row.Cells("Column30").Value?.ToString()},
                {"fatherEmail", row.Cells("Column31").Value?.ToString()},
                {"contactName", row.Cells("Column32").Value?.ToString()},
                {"contactNumber", row.Cells("Column33").Value?.ToString()},
                {"previousEducationllvl", row.Cells("Column34").Value?.ToString()},
                {"previousprogramSHS", row.Cells("Column35").Value?.ToString()},
                {"previousschool", row.Cells("Column36").Value?.ToString()},
                {"previousyearAttendent", row.Cells("Column37").Value?.ToString()},
                {"previousaward", row.Cells("Column38").Value?.ToString()},
                {"currentEducationallvl", row.Cells("Column39").Value?.ToString()},
                {"currentProgram", row.Cells("Column40").Value?.ToString()},
                {"currentyearLevel", row.Cells("Column41").Value?.ToString()},
                {"currentschoolPeriod", row.Cells("Column42").Value?.ToString()},
                {"currentschoolYear", row.Cells("Column43").Value?.ToString()},
                {"username", str.ToString()},
                {"password", str2.ToString()}
                }

                Dim form1 As New RegisterForm(studentData)
                form1.btnSubmit.Visible = False
                form1.btnCancel.Visible = False
                form1.lblClose.Visible = False
                form1.lblExtraExit.Visible = True
                form1.ShowDialog()
                stuID = 0
            Catch ex As Exception
                MsgBox("error occured:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvStudentRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvStudentRecord.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = dgvStudentRecord.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim dr As DataGridViewRow = dgvStudentRecord.Rows(hit.RowIndex)
                stuID = dr.Cells(1).Value.ToString()
            End If

            Using cmd As New MySqlCommand("SELECT useraccount_id FROM students WHERE studentID = @studentID", conn)
                cmd.Parameters.AddWithValue("@studentID", stuID)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userID = reader("useraccount_id").ToString()
                    End If
                    reader.Close()
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If stuID = 0 Then
                MessageBox.Show("Please select a student to delete.")
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete student ID: " & stuID & " Data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return

            Using cmd = New MySqlCommand("DELETE FROM useraccount WHERE id = " & userID & "", conn)
                conn.Open()
                Dim check As Integer = cmd.ExecuteNonQuery()

                If check > 0 Then
                    MsgBox("Student Record Deleted Successfully.", MsgBoxStyle.Information, "Delete Student")
                    conn.Close()
                    getDisplay(dgvStudentRecord)
                Else
                    MessageBox.Show("No Record found With The Provided ID.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub lblExtraExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        getDisplay(dgvStudentRecord)
    End Sub
End Class