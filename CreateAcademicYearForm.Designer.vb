<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAcademicYearForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnCancel = New Button()
        btnSave = New Button()
        Label4 = New Label()
        txtCreate = New TextBox()
        Panel5 = New Panel()
        Label3 = New Label()
        txtIncrement = New TextBox()
        cbSemester = New ComboBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label1 = New Label()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(218, 267)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 47)
        btnCancel.TabIndex = 44
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(84, 267)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 47)
        btnSave.TabIndex = 51
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(34, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 22)
        Label4.TabIndex = 61
        Label4.Text = "Academic Year:"
        ' 
        ' txtCreate
        ' 
        txtCreate.Location = New Point(203, 125)
        txtCreate.Name = "txtCreate"
        txtCreate.Size = New Size(168, 23)
        txtCreate.TabIndex = 60
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(44, 26)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(298, 54)
        Panel5.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(17, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(258, 22)
        Label3.TabIndex = 52
        Label3.Tag = ""
        Label3.Text = "CREATE ACADEMIC YEAR"
        ' 
        ' txtIncrement
        ' 
        txtIncrement.Enabled = False
        txtIncrement.Location = New Point(203, 164)
        txtIncrement.Name = "txtIncrement"
        txtIncrement.Size = New Size(168, 23)
        txtIncrement.TabIndex = 63
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        cbSemester.Location = New Point(203, 206)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(168, 23)
        cbSemester.TabIndex = 82
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 207)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 22)
        Label1.TabIndex = 83
        Label1.Text = "Academic Period:"
        ' 
        ' CreateAcademicYearForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        ClientSize = New Size(403, 346)
        Controls.Add(Label1)
        Controls.Add(cbSemester)
        Controls.Add(btnCancel)
        Controls.Add(txtIncrement)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(txtCreate)
        Controls.Add(Panel5)
        ForeColor = Color.White
        Name = "CreateAcademicYearForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create New Academic Year"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCreate As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIncrement As TextBox
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label1 As Label
End Class
