<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Courses))
        panels = New Panel()
        PictureBoxSearch = New PictureBox()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        cbCourse1 = New ComboBox()
        cbCourse4 = New ComboBox()
        cbCourse3 = New ComboBox()
        cbCourse2 = New ComboBox()
        txtProgram = New TextBox()
        Label5 = New Label()
        txtSemester = New TextBox()
        txtYear = New TextBox()
        Label3 = New Label()
        txtStudentID = New TextBox()
        Label12 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Panel6 = New Panel()
        btnClear = New Button()
        btnSave = New Button()
        txtFullName = New TextBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        cbStatusFind = New ComboBox()
        cbCourseFind = New ComboBox()
        Label7 = New Label()
        btnRefresh = New Button()
        btnSearch = New Button()
        Label18 = New Label()
        cbSemester = New ComboBox()
        cbProgram = New ComboBox()
        txtLimit = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        cbYear = New ComboBox()
        Label6 = New Label()
        Label19 = New Label()
        txtFullnameFind = New TextBox()
        Label14 = New Label()
        txtStudentIDFind = New TextBox()
        dgvCourse = New DataGridView()
        BindingSource1 = New BindingSource(components)
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        panels.SuspendLayout()
        CType(PictureBoxSearch, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvCourse, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panels
        ' 
        panels.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        panels.BorderStyle = BorderStyle.FixedSingle
        panels.Controls.Add(PictureBoxSearch)
        panels.Controls.Add(GroupBox1)
        panels.Controls.Add(txtProgram)
        panels.Controls.Add(Label5)
        panels.Controls.Add(txtSemester)
        panels.Controls.Add(txtYear)
        panels.Controls.Add(Label3)
        panels.Controls.Add(txtStudentID)
        panels.Controls.Add(Label12)
        panels.Controls.Add(Label9)
        panels.Controls.Add(Label11)
        panels.Controls.Add(Panel6)
        panels.Controls.Add(txtFullName)
        panels.Location = New Point(21, 531)
        panels.Name = "panels"
        panels.Size = New Size(940, 283)
        panels.TabIndex = 8
        ' 
        ' PictureBoxSearch
        ' 
        PictureBoxSearch.Cursor = Cursors.Hand
        PictureBoxSearch.Image = CType(resources.GetObject("PictureBoxSearch.Image"), Image)
        PictureBoxSearch.Location = New Point(317, 20)
        PictureBoxSearch.Name = "PictureBoxSearch"
        PictureBoxSearch.Size = New Size(32, 26)
        PictureBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxSearch.TabIndex = 56
        PictureBoxSearch.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Silver
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cbCourse1)
        GroupBox1.Controls.Add(cbCourse4)
        GroupBox1.Controls.Add(cbCourse3)
        GroupBox1.Controls.Add(cbCourse2)
        GroupBox1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(473, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(438, 229)
        GroupBox1.TabIndex = 55
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enroll Student Course"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label8.Location = New Point(20, 39)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 20)
        Label8.TabIndex = 34
        Label8.Text = "Course 1:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.Location = New Point(20, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 39
        Label4.Text = "Course 2:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label1.Location = New Point(20, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 40
        Label1.Text = "Course 3:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label2.Location = New Point(20, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 41
        Label2.Text = "Course 4:"
        ' 
        ' cbCourse1
        ' 
        cbCourse1.FormattingEnabled = True
        cbCourse1.Items.AddRange(New Object() {"s"})
        cbCourse1.Location = New Point(127, 40)
        cbCourse1.Name = "cbCourse1"
        cbCourse1.Size = New Size(281, 25)
        cbCourse1.TabIndex = 42
        ' 
        ' cbCourse4
        ' 
        cbCourse4.FormattingEnabled = True
        cbCourse4.Location = New Point(127, 178)
        cbCourse4.Name = "cbCourse4"
        cbCourse4.Size = New Size(281, 25)
        cbCourse4.TabIndex = 43
        ' 
        ' cbCourse3
        ' 
        cbCourse3.FormattingEnabled = True
        cbCourse3.Location = New Point(127, 131)
        cbCourse3.Name = "cbCourse3"
        cbCourse3.Size = New Size(281, 25)
        cbCourse3.TabIndex = 44
        ' 
        ' cbCourse2
        ' 
        cbCourse2.FormattingEnabled = True
        cbCourse2.Location = New Point(127, 86)
        cbCourse2.Name = "cbCourse2"
        cbCourse2.Size = New Size(281, 25)
        cbCourse2.TabIndex = 45
        ' 
        ' txtProgram
        ' 
        txtProgram.Location = New Point(167, 91)
        txtProgram.Name = "txtProgram"
        txtProgram.ReadOnly = True
        txtProgram.Size = New Size(276, 23)
        txtProgram.TabIndex = 54
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label5.Location = New Point(29, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 53
        Label5.Text = "Program:"
        ' 
        ' txtSemester
        ' 
        txtSemester.Location = New Point(167, 158)
        txtSemester.Name = "txtSemester"
        txtSemester.ReadOnly = True
        txtSemester.Size = New Size(130, 23)
        txtSemester.TabIndex = 52
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(167, 124)
        txtYear.Name = "txtYear"
        txtYear.ReadOnly = True
        txtYear.Size = New Size(130, 23)
        txtYear.TabIndex = 51
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label3.Location = New Point(29, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 46
        Label3.Text = "Year:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(167, 23)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.ReadOnly = True
        txtStudentID.Size = New Size(130, 23)
        txtStudentID.TabIndex = 41
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label12.Location = New Point(29, 22)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 40
        Label12.Text = "Student ID:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label9.Location = New Point(29, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 38
        Label9.Text = "Semester:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label11.Location = New Point(29, 57)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 34
        Label11.Text = "Student Name:"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnClear)
        Panel6.Controls.Add(btnSave)
        Panel6.Location = New Point(92, 204)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(266, 60)
        Panel6.TabIndex = 9
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(140, 9)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(100, 38)
        btnClear.TabIndex = 10
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 12.75F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(19, 9)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(93, 38)
        btnSave.TabIndex = 8
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(167, 57)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(276, 23)
        txtFullName.TabIndex = 35
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(dgvCourse)
        Panel3.Location = New Point(21, 22)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 498)
        Panel3.TabIndex = 7
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(cbStatusFind)
        Panel4.Controls.Add(cbCourseFind)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(btnRefresh)
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(Label18)
        Panel4.Controls.Add(cbSemester)
        Panel4.Controls.Add(cbProgram)
        Panel4.Controls.Add(txtLimit)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label17)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(cbYear)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label19)
        Panel4.Controls.Add(txtFullnameFind)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(txtStudentIDFind)
        Panel4.Location = New Point(19, 8)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(896, 122)
        Panel4.TabIndex = 3
        ' 
        ' cbStatusFind
        ' 
        cbStatusFind.FormattingEnabled = True
        cbStatusFind.Items.AddRange(New Object() {"Regular", "Irregular"})
        cbStatusFind.Location = New Point(586, 30)
        cbStatusFind.Name = "cbStatusFind"
        cbStatusFind.Size = New Size(138, 23)
        cbStatusFind.TabIndex = 88
        ' 
        ' cbCourseFind
        ' 
        cbCourseFind.FormattingEnabled = True
        cbCourseFind.Location = New Point(510, 83)
        cbCourseFind.Name = "cbCourseFind"
        cbCourseFind.Size = New Size(214, 23)
        cbCourseFind.TabIndex = 46
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label7.Location = New Point(586, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 87
        Label7.Text = "Student Status:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(748, 13)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 44)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(748, 65)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 44)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label18.Location = New Point(510, 64)
        Label18.Name = "Label18"
        Label18.Size = New Size(58, 15)
        Label18.TabIndex = 72
        Label18.Text = "Course:"
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        cbSemester.Location = New Point(394, 83)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(99, 23)
        cbSemester.TabIndex = 80
        ' 
        ' cbProgram
        ' 
        cbProgram.FormattingEnabled = True
        cbProgram.Location = New Point(295, 30)
        cbProgram.Name = "cbProgram"
        cbProgram.Size = New Size(273, 23)
        cbProgram.TabIndex = 85
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(184, 80)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(91, 23)
        txtLimit.TabIndex = 83
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label16.Location = New Point(295, 9)
        Label16.Name = "Label16"
        Label16.Size = New Size(68, 15)
        Label16.TabIndex = 76
        Label16.Text = "Program:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label17.Location = New Point(394, 64)
        Label17.Name = "Label17"
        Label17.Size = New Size(74, 15)
        Label17.TabIndex = 79
        Label17.Text = "Semester:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label15.Location = New Point(48, 9)
        Label15.Name = "Label15"
        Label15.Size = New Size(217, 15)
        Label15.TabIndex = 73
        Label15.Text = "Student Firstname Or Lastname:"
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cbYear.Location = New Point(295, 83)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(83, 23)
        cbYear.TabIndex = 81
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label6.Location = New Point(184, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 77
        Label6.Text = "Limit Display"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label19.Location = New Point(295, 64)
        Label19.Name = "Label19"
        Label19.Size = New Size(41, 15)
        Label19.TabIndex = 69
        Label19.Text = "Year:"
        ' 
        ' txtFullnameFind
        ' 
        txtFullnameFind.Location = New Point(48, 30)
        txtFullnameFind.Name = "txtFullnameFind"
        txtFullnameFind.Size = New Size(227, 23)
        txtFullnameFind.TabIndex = 71
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label14.Location = New Point(46, 62)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 15)
        Label14.TabIndex = 74
        Label14.Text = "StudentID:"
        ' 
        ' txtStudentIDFind
        ' 
        txtStudentIDFind.Location = New Point(48, 80)
        txtStudentIDFind.Name = "txtStudentIDFind"
        txtStudentIDFind.Size = New Size(128, 23)
        txtStudentIDFind.TabIndex = 70
        ' 
        ' dgvCourse
        ' 
        dgvCourse.AllowUserToAddRows = False
        dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourse.Location = New Point(19, 136)
        dgvCourse.Name = "dgvCourse"
        dgvCourse.RowHeadersVisible = False
        dgvCourse.Size = New Size(896, 345)
        dgvCourse.TabIndex = 1
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Courses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(panels)
        Controls.Add(Panel3)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "Courses"
        Text = "Courses"
        panels.ResumeLayout(False)
        panels.PerformLayout()
        CType(PictureBoxSearch, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvCourse, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panels As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents cbCourse2 As ComboBox
    Friend WithEvents cbCourse3 As ComboBox
    Friend WithEvents cbCourse4 As ComboBox
    Friend WithEvents cbCourse1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents txtStudentIDFind As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFullnameFind As TextBox
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbCourseFind As ComboBox
    Friend WithEvents cbStatusFind As ComboBox
    Friend WithEvents PictureBoxSearch As PictureBox
End Class
