Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Ocsp

Public Class AcademicYearForm
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim table As DataTable
    Dim query As String
    Dim aycodes As String = Nothing
    Dim aceid As String = Nothing
    Dim period As String = Nothing
    Private Sub AcademicYearForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        getDisplay(dgvAyYear)
    End Sub

    Private Sub dgvAyYear_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAyYear.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim columnName = dgvAyYear.Columns(e.ColumnIndex).Name
        'Dim' ay = dgvAyYear.Rows(e.RowIndex).Cells(0).Value.ToString

        Try
            conn.Open()
            If columnName = "getOpen" Then
                If MsgBox("Do you want to Open this academic year?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Using cmd = New MySqlCommand("UPDATE academicyear SET status = 'Close'", conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd = New MySqlCommand("UPDATE academicyear SET status = 'Open' WHERE id = @id", conn)
                        cmd.Parameters.AddWithValue("@id", aceid)
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Successfully Opened Academic Year " & aceid, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            conn.Close()
                            getDisplay(dgvAyYear)
                        End If
                    End Using
                End If
            ElseIf columnName = "getClose" Then
                If MsgBox("Do you want to Close this academic year?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Using cmd = New MySqlCommand("UPDATE academicyear SET status = 'Close'", conn)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfully Closed Academic Year " & aceid, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        conn.Close()
                        getDisplay(dgvAyYear)
                    End Using

                End If
            End If
            conn.Close()
            aceId = Nothing
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub getDisplay(dgv As DataGridView)

        dgv.Rows.Clear()
        dgv.RowTemplate.Height = 30
        Using cmd As New MySqlCommand("SELECT aycode, schoolperiod, status FROM academicyear ORDER BY aycode DESC", conn)
            conn.Open()
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    Dim open As Image = My.Resources.check
                    Dim close As Image = My.Resources.remove
                    dgv.Rows.Add(dr("aycode"), dr("schoolperiod"), dr("status"), open, close)
                End While
            End Using
            conn.Close()
        End Using

        dgv.ClearSelection()
        getAcademicYear()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim createAcademicYearForm As New CreateAcademicYearForm(Me)
        createAcademicYearForm.ShowDialog()
    End Sub

    Public Sub getAcademicYear()
        conn.Open()
        Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE status = 'Open'", conn)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                lblAcademicYear.Text = reader("id")
            Else
                lblAcademicYear.Text = "No Open Academic Year"
            End If
            reader.Close()
        End Using
        conn.Close()
    End Sub


    Private Sub dgvAyYear_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvAyYear.MouseClick
        Try
            Dim hit As DataGridView.HitTestInfo = dgvAyYear.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim dr As DataGridViewRow = dgvAyYear.Rows(hit.RowIndex)
                aycodes = dr.Cells(0).Value.ToString()
                period = dr.Cells(1).Value.ToString()
            End If

            Using cmd = New MySqlCommand("SELECT id FROM academicyear WHERE aycode = @aycode AND schoolperiod = @period", conn)
                cmd.Parameters.AddWithValue("@aycode", aycodes)
                cmd.Parameters.AddWithValue("@period", period)
                conn.Open()
                Dim read = cmd.ExecuteReader()
                If read.Read Then
                    aceid = read("id").ToString()
                Else
                    MessageBox.Show("No Academic Year found.")
                End If
                read.Close()
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occured: " & ex.Message)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If aceId Is Nothing OrElse aceId = "" Then
                MessageBox.Show("Please select an Academic Year to delete.")
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete Academic Year: " & aceId & " Data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return

            Using cmd = New MySqlCommand("DELETE FROM academicyear WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", aceid)
                conn.Open()
                Dim check As Integer = cmd.ExecuteNonQuery()

                If check > 0 Then
                    MsgBox("the Selected Academic Year was Successfully Deleted.", MsgBoxStyle.Information, "Deleted Academic Year")
                    conn.Close()
                    getDisplay(dgvAyYear)
                Else
                    MessageBox.Show("No Academic Year found.")
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class