<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentHome))
        Panel2 = New Panel()
        lblEmail = New Label()
        btnProfile = New Button()
        lblUsername = New Label()
        panels = New Panel()
        btnLogOut = New Button()
        btnAcademicPeriod = New Button()
        btnStudyLoad = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        panelHome = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBoxExit = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBoxExit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        Panel2.Controls.Add(lblEmail)
        Panel2.Controls.Add(btnProfile)
        Panel2.Controls.Add(lblUsername)
        Panel2.Controls.Add(panels)
        Panel2.Controls.Add(btnLogOut)
        Panel2.Controls.Add(btnAcademicPeriod)
        Panel2.Controls.Add(btnStudyLoad)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(0, 46)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(237, 827)
        Panel2.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Arial Narrow", 9F)
        lblEmail.ForeColor = Color.Lime
        lblEmail.Location = New Point(18, 737)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 16)
        lblEmail.TabIndex = 16
        lblEmail.Text = "@Email"
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(18, 256)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(200, 40)
        btnProfile.TabIndex = 9
        btnProfile.Text = "Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = SystemColors.Control
        lblUsername.Location = New Point(18, 718)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(63, 15)
        lblUsername.TabIndex = 15
        lblUsername.Text = "@Owner"
        ' 
        ' panels
        ' 
        panels.Location = New Point(236, 0)
        panels.Name = "panels"
        panels.Size = New Size(1301, 827)
        panels.TabIndex = 2
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(18, 763)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(200, 40)
        btnLogOut.TabIndex = 8
        btnLogOut.Text = "Log out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnAcademicPeriod
        ' 
        btnAcademicPeriod.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnAcademicPeriod.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAcademicPeriod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnAcademicPeriod.FlatStyle = FlatStyle.Flat
        btnAcademicPeriod.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAcademicPeriod.ForeColor = Color.White
        btnAcademicPeriod.Location = New Point(18, 373)
        btnAcademicPeriod.Name = "btnAcademicPeriod"
        btnAcademicPeriod.Size = New Size(200, 40)
        btnAcademicPeriod.TabIndex = 5
        btnAcademicPeriod.Text = "View Academic Period"
        btnAcademicPeriod.UseVisualStyleBackColor = False
        ' 
        ' btnStudyLoad
        ' 
        btnStudyLoad.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnStudyLoad.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnStudyLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnStudyLoad.FlatStyle = FlatStyle.Flat
        btnStudyLoad.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStudyLoad.ForeColor = Color.White
        btnStudyLoad.Location = New Point(18, 313)
        btnStudyLoad.Name = "btnStudyLoad"
        btnStudyLoad.Size = New Size(200, 40)
        btnStudyLoad.TabIndex = 4
        btnStudyLoad.Text = "Study Load"
        btnStudyLoad.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(68, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 23)
        Label3.TabIndex = 3
        Label3.Text = "Welcome!"
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
        ' panelHome
        ' 
        panelHome.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        panelHome.Dock = DockStyle.Fill
        panelHome.Location = New Point(237, 46)
        panelHome.Name = "panelHome"
        panelHome.Size = New Size(979, 827)
        panelHome.TabIndex = 4
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBoxExit)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1216, 46)
        Panel1.TabIndex = 2
        ' 
        ' PictureBoxExit
        ' 
        PictureBoxExit.Cursor = Cursors.Hand
        PictureBoxExit.Image = CType(resources.GetObject("PictureBoxExit.Image"), Image)
        PictureBoxExit.Location = New Point(1173, 8)
        PictureBoxExit.Name = "PictureBoxExit"
        PictureBoxExit.Size = New Size(33, 32)
        PictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxExit.TabIndex = 12
        PictureBoxExit.TabStop = False
        ' 
        ' StudentHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1216, 873)
        ControlBox = False
        Controls.Add(panelHome)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "StudentHome"
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxExit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents panels As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnAcademicPeriod As Button
    Friend WithEvents btnStudyLoad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelHome As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxExit As PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
End Class
