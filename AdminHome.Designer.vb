<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        Panel1 = New Panel()
        PictureBoxExit = New PictureBox()
        Label2 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        btnStudent = New Button()
        btnAddCourse = New Button()
        btnLogOut = New Button()
        panels = New Panel()
        btnDashboard = New Button()
        btnAccount = New Button()
        btnAcademicYear = New Button()
        btnEnrollment = New Button()
        Panel2 = New Panel()
        lblEmail = New Label()
        lblUsername = New Label()
        panelHome = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBoxExit, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBoxExit)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1216, 46)
        Panel1.TabIndex = 0
        ' 
        ' PictureBoxExit
        ' 
        PictureBoxExit.Cursor = Cursors.Hand
        PictureBoxExit.Image = CType(resources.GetObject("PictureBoxExit.Image"), Image)
        PictureBoxExit.Location = New Point(1175, 8)
        PictureBoxExit.Name = "PictureBoxExit"
        PictureBoxExit.Size = New Size(33, 32)
        PictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxExit.TabIndex = 3
        PictureBoxExit.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 19)
        Label2.TabIndex = 2
        Label2.Text = "EduRecord Pro"
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
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(991, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 16)
        Label1.TabIndex = 1
        Label1.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(52, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(68, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 23)
        Label3.TabIndex = 3
        Label3.Text = "Welcome!"
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(18, 485)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(200, 40)
        btnStudent.TabIndex = 4
        btnStudent.Text = "Student"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAddCourse.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCourse.ForeColor = Color.White
        btnAddCourse.Location = New Point(18, 429)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(200, 40)
        btnAddCourse.TabIndex = 5
        btnAddCourse.Text = "Courses"
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(18, 772)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(200, 40)
        btnLogOut.TabIndex = 8
        btnLogOut.Text = "Log out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' panels
        ' 
        panels.Location = New Point(236, 0)
        panels.Name = "panels"
        panels.Size = New Size(1301, 827)
        panels.TabIndex = 2
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(18, 256)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(200, 40)
        btnDashboard.TabIndex = 9
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAccount
        ' 
        btnAccount.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAccount.ForeColor = Color.White
        btnAccount.Location = New Point(18, 316)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(200, 40)
        btnAccount.TabIndex = 10
        btnAccount.Text = "Account"
        btnAccount.UseVisualStyleBackColor = False
        ' 
        ' btnAcademicYear
        ' 
        btnAcademicYear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAcademicYear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAcademicYear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAcademicYear.FlatStyle = FlatStyle.Flat
        btnAcademicYear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAcademicYear.ForeColor = Color.White
        btnAcademicYear.Location = New Point(18, 542)
        btnAcademicYear.Name = "btnAcademicYear"
        btnAcademicYear.Size = New Size(200, 40)
        btnAcademicYear.TabIndex = 11
        btnAcademicYear.Text = "Academic Year"
        btnAcademicYear.UseVisualStyleBackColor = False
        ' 
        ' btnEnrollment
        ' 
        btnEnrollment.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnEnrollment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnEnrollment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnEnrollment.FlatStyle = FlatStyle.Flat
        btnEnrollment.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnrollment.ForeColor = Color.White
        btnEnrollment.Location = New Point(18, 373)
        btnEnrollment.Name = "btnEnrollment"
        btnEnrollment.Size = New Size(200, 40)
        btnEnrollment.TabIndex = 12
        btnEnrollment.Text = "Enrollment"
        btnEnrollment.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        Panel2.Controls.Add(lblEmail)
        Panel2.Controls.Add(lblUsername)
        Panel2.Controls.Add(btnEnrollment)
        Panel2.Controls.Add(btnAcademicYear)
        Panel2.Controls.Add(btnAccount)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(panels)
        Panel2.Controls.Add(btnLogOut)
        Panel2.Controls.Add(btnAddCourse)
        Panel2.Controls.Add(btnStudent)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 46)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(237, 827)
        Panel2.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Arial Narrow", 9F)
        lblEmail.ForeColor = Color.Lime
        lblEmail.Location = New Point(18, 745)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 16)
        lblEmail.TabIndex = 18
        lblEmail.Text = "@Email"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = SystemColors.Control
        lblUsername.Location = New Point(18, 726)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(63, 15)
        lblUsername.TabIndex = 17
        lblUsername.Text = "@Owner"
        ' 
        ' panelHome
        ' 
        panelHome.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        panelHome.Location = New Point(237, 46)
        panelHome.Name = "panelHome"
        panelHome.Size = New Size(979, 827)
        panelHome.TabIndex = 2
        ' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1216, 873)
        ControlBox = False
        Controls.Add(panelHome)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "AdminHome"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxExit, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents panels As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnAcademicYear As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelHome As Panel
    Friend WithEvents PictureBoxExit As PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label

End Class
