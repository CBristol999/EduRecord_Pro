<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterSearch2
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
        Panel6 = New Panel()
        btnSearch = New Button()
        btnCancel = New Button()
        btnClear = New Button()
        Panel3 = New Panel()
        txtLimit = New TextBox()
        Label10 = New Label()
        Label8 = New Label()
        cbProgram = New ComboBox()
        txtStudentID = New TextBox()
        Label1 = New Label()
        Label11 = New Label()
        txtFullname = New TextBox()
        cbSemester = New ComboBox()
        Label9 = New Label()
        Label4 = New Label()
        cbGender = New ComboBox()
        cbYear = New ComboBox()
        Label2 = New Label()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnSearch)
        Panel6.Controls.Add(btnCancel)
        Panel6.Controls.Add(btnClear)
        Panel6.Location = New Point(135, 253)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(346, 71)
        Panel6.TabIndex = 13
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(15, 10)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(97, 50)
        btnSearch.TabIndex = 14
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(233, 10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(96, 50)
        btnCancel.TabIndex = 13
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(127, 10)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(87, 50)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(txtLimit)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(cbProgram)
        Panel3.Controls.Add(txtStudentID)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(txtFullname)
        Panel3.Controls.Add(cbSemester)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(cbGender)
        Panel3.Controls.Add(cbYear)
        Panel3.Controls.Add(Label2)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(18, 22)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(605, 211)
        Panel3.TabIndex = 12
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(23, 164)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(117, 23)
        txtLimit.TabIndex = 83
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(21, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 18)
        Label10.TabIndex = 77
        Label10.Text = "Limit Display"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 18)
        Label8.TabIndex = 74
        Label8.Text = "StudentID:"
        ' 
        ' cbProgram
        ' 
        cbProgram.FormattingEnabled = True
        cbProgram.Location = New Point(323, 37)
        cbProgram.Name = "cbProgram"
        cbProgram.Size = New Size(247, 23)
        cbProgram.TabIndex = 85
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(21, 100)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(144, 23)
        txtStudentID.TabIndex = 70
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 18)
        Label1.TabIndex = 73
        Label1.Text = "Student Firstname Or Lastname:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(323, 13)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 18)
        Label11.TabIndex = 76
        Label11.Text = "Program:"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(21, 37)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(274, 23)
        txtFullname.TabIndex = 71
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        cbSemester.Location = New Point(449, 100)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(121, 23)
        cbSemester.TabIndex = 80
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(449, 75)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 18)
        Label9.TabIndex = 79
        Label9.Text = "Semester:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(176, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 18)
        Label4.TabIndex = 72
        Label4.Text = "Gender:"
        ' 
        ' cbGender
        ' 
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Male", "Female"})
        cbGender.Location = New Point(176, 100)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(119, 23)
        cbGender.TabIndex = 82
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(323, 100)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(113, 23)
        cbYear.TabIndex = 81
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(323, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 18)
        Label2.TabIndex = 69
        Label2.Text = "Year:"
        ' 
        ' FilterSearch2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(641, 346)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Name = "FilterSearch2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FilterSearch"
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label2 As Label
End Class
