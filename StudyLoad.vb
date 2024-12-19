Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class StudyLoad
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim query As String
    Private _userId As Integer
    Private _aceID As String ' Add a field for aceID

    ' Constructor accepting userId and aceID (aceID is optional)
    Public Sub New(userId As Integer, Optional aceID As String = Nothing)
        InitializeComponent()
        _userId = userId
        _aceID = aceID ' Store the aceID if provided
    End Sub

    Private Sub StudyLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        If _aceID IsNot Nothing Then
            getView(_aceID)
        Else
            getDisplay()
        End If
    End Sub

    Public Sub getDisplay()
        Try
            conn.Open()
            Using cmd As New MySqlCommand("SELECT * FROM students WHERE useraccount_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", _userId)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    txtStudentID.Text = read("studentID").ToString
                    txtFullName.Text = read("firstname").ToString & " " & read("middle").ToString & ", " & read("lastname").ToString & " " & read("extensionName").ToString
                    txtProgram.Text = read("currentProgram").ToString
                    'get image
                    Dim imageData As Byte() = DirectCast(read("profile_photo"), Byte())
                    Using ms As New MemoryStream(imageData)
                        PictureBoxStudentImage.Image = Image.FromStream(ms)
                    End Using
                End If
                read.Close()
            End Using

            Using cmd As New MySqlCommand("SELECT MAX(`Academic Year`) AS MaxAcademicYear FROM viewcourses WHERE `Student ID` = @id", conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                Dim read = cmd.ExecuteReader()
                If read.Read() AndAlso Not IsDBNull(read("MaxAcademicYear")) Then
                    txtAyCode.Text = read("MaxAcademicYear").ToString()
                Else
                    txtAyCode.Text = "No Academic Year Found"
                End If
                read.Close()
            End Using

            Using cmd As New MySqlCommand("SELECT * FROM enrollment WHERE studentID = @id AND academicYear = @year", conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@year", txtAyCode.Text)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    txtDataEnrolled.Text = Convert.ToDateTime(read("dateEnrolled")).ToString("yyyy-MM-dd")
                    txtStatus.Text = read("studentStatus").ToString
                    txtYear.Text = read("studentYear").ToString
                    txtSemester.Text = read("schoolperiod").ToString
                End If
                read.Close()
            End Using

            dgvStudyLoad.Rows.Clear()
            dgvStudyLoad.RowTemplate.Height = 50
            Using cmd As New MySqlCommand("SELECT b.courseCode AS Code, b.course_name AS 'Course Name', b.unit AS Unit ,b.teacher AS 'Assign Teacher' FROM enrollment a 
                              INNER JOIN courses b ON b.course_name IN (a.course1, a.course2, a.course3, a.course4) WHERE a.studentID = @id AND a.academicYear = @year", conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@year", txtAyCode.Text)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgvStudyLoad.Rows.Add(dr("Code"), dr("Course Name"), dr("Unit"), dr("Assign Teacher"))
                    End While
                End Using
            End Using
            dgvStudyLoad.ClearSelection()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub getView(academicYear As String)
        Try
            conn.Open()
            Using cmd As New MySqlCommand("SELECT * FROM students WHERE useraccount_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", _userId)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    txtStudentID.Text = read("studentID").ToString
                    txtFullName.Text = read("firstname").ToString & " " & read("middle").ToString & ", " & read("lastname").ToString & " " & read("extensionName").ToString
                    txtProgram.Text = read("currentProgram").ToString
                    'get image
                    Dim imageData As Byte() = DirectCast(read("profile_photo"), Byte())
                    Using ms As New MemoryStream(imageData)
                        PictureBoxStudentImage.Image = Image.FromStream(ms)
                    End Using
                End If
                read.Close()
            End Using

            Using cmd As New MySqlCommand("SELECT * FROM enrollment WHERE studentID = @id AND academicYear = @year", conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@year", academicYear)
                Dim read = cmd.ExecuteReader
                If read.Read Then
                    txtDataEnrolled.Text = Convert.ToDateTime(read("dateEnrolled")).ToString("yyyy-MM-dd")
                    txtStatus.Text = read("studentStatus").ToString
                    txtYear.Text = read("studentYear").ToString
                    txtSemester.Text = read("schoolperiod").ToString
                End If
                read.Close()
            End Using

            txtAyCode.Text = academicYear

            dgvStudyLoad.Rows.Clear()
            dgvStudyLoad.RowTemplate.Height = 50
            Using cmd As New MySqlCommand("SELECT b.courseCode AS Code, b.course_name AS 'Course Name', b.unit AS Unit ,b.teacher AS 'Assign Teacher' FROM enrollment a 
                              INNER JOIN courses b ON b.course_name IN (a.course1, a.course2, a.course3, a.course4) WHERE a.studentID = @id AND a.academicYear = @year", conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@year", academicYear)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgvStudyLoad.Rows.Add(dr("Code"), dr("Course Name"), dr("Unit"), dr("Assign Teacher"))
                    End While
                End Using
            End Using
            dgvStudyLoad.ClearSelection()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class