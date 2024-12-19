Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class RegistrationApproval
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Dim picCol As DataGridViewImageColumn
    Dim query As String

    Dim Pen As String = "Pending"
    Dim Rej As String = "Rejected"
    Private Sub RegistrationApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getDisplay(dgvPending, Pen)
        getDisplay(dgvArchives, Rej)
    End Sub

    Public Sub getDisplay(dgv As DataGridView, status As String)
        query = "SELECT studentID AS 'Student ID', CONCAT(firstname, ' ', middle, ', ', lastname, ' ', extensionName) AS FullName, gender AS Gender, 
                 currentEducationallvl AS 'Educational Level',  currentProgram AS Program, currentyearLevel AS 'Year Level', currentschoolPeriod AS 
                'School Period', approval AS 'Registration Status' FROM students WHERE approval = @status"

        dgv.Rows.Clear()

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@status", status)
            conn.Open()
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    Dim acceptImage As Image = My.Resources.check
                    Dim rejectImage As Image = My.Resources.remove

                    dgv.Rows.Add(acceptImage, rejectImage, dr("Student ID"), dr("FullName"), dr("Gender"), dr("Educational Level"), dr("Program"),
                             dr("Year Level"), dr("School Period"), dr("Registration Status"))
                End While
            End Using
            conn.Close()
        End Using

        dgv.ClearSelection()
    End Sub

    Private Sub dgvPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPending.CellContentClick
        ' Ensure the clicked cell is not a header
        If e.RowIndex < 0 Then Return

        Dim columnName = dgvPending.Columns(e.ColumnIndex).Name
        Dim studentID = dgvPending.Rows(e.RowIndex).Cells(2).Value.ToString

        If columnName = "getAccept" Then
            If MsgBox("Do you want to accept this student registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateStudentApproval(studentID, "Accepted")
                MsgBox("Student has been successfully accepted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                getDisplay(dgvPending, Pen) ' Refresh the DataGridView
            End If
        ElseIf columnName = "getReject" Then
            If MsgBox("Do you want to reject this student registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateStudentApproval(studentID, "Rejected")
                MsgBox("Student has been successfully rejected!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                getDisplay(dgvPending, Pen) ' Refresh the DataGridView
                getDisplay(dgvArchives, Rej)
            End If
        End If
    End Sub

    Private Sub UpdateStudentApproval(studentID As String, approvalStatus As String)
        Using cmd As New MySqlCommand("UPDATE students SET approval = @approval WHERE studentID = @studentID", conn)
            conn.Open()
            cmd.Parameters.AddWithValue("@approval", approvalStatus)
            cmd.Parameters.AddWithValue("@studentID", studentID)

            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Private Sub dgvArchives_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchives.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim columnName = dgvArchives.Columns(e.ColumnIndex).Name
        Dim studentID = dgvArchives.Rows(e.RowIndex).Cells(2).Value.ToString

        If columnName = "getRestore" Then
            If MsgBox("Do you want to Restore this student registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateStudentApproval(studentID, "Pending")
                MsgBox("Student has been successfully Restore!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                getDisplay(dgvPending, Pen) ' Refresh the DataGridView
                getDisplay(dgvArchives, Rej)
            End If
        ElseIf columnName = "getRemove" Then
            If MsgBox("Do you want to Delete this student registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim ids As Integer
                    query = "SELECT useraccount_id FROM students WHERE studentID = @id"
                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        Try
                            Dim reader = cmd.ExecuteReader
                            If reader.Read Then
                                ids = reader("useraccount_id")
                            Else
                                MsgBox("No useraccount Found")
                            End If
                            reader.Close()
                        Catch ex As Exception
                            MsgBox("An error occurred: " & ex.Message)
                        End Try
                    End Using

                    query = "DELETE FROM useraccount WHERE id = @id"
                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", ids)
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Student has been successfully Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            getDisplay(dgvPending, Pen)
                            getDisplay(dgvArchives, Rej)
                        Else
                            MsgBox("Insert Error Student Info", MsgBoxStyle.Critical, "Delete Registration Form")
                        End If
                    End Using
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ptbExit_Click(sender As Object, e As EventArgs) Handles ptbExit.Click
        Me.Close()
    End Sub
End Class