<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnLogin = New Button()
        btnClose = New Button()
        TabControl1 = New TabControl()
        tpLogin = New TabPage()
        tpRegister = New TabPage()
        btnRegisterCancel = New Button()
        btnRegisterHere = New Button()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tpLogin.SuspendLayout()
        tpRegister.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(248, 323)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(28, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 29)
        Label3.TabIndex = 5
        Label3.Text = "EduRecord Pro"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(51, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(16, 25)
        Label11.Name = "Label11"
        Label11.Size = New Size(158, 24)
        Label11.TabIndex = 27
        Label11.Text = "Login Account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label1.Location = New Point(16, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 28
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label2.Location = New Point(16, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 29
        Label2.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Tahoma", 11.25F)
        txtPassword.Location = New Point(19, 157)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(234, 30)
        txtPassword.TabIndex = 30
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Tahoma", 11.25F)
        txtUsername.Location = New Point(19, 93)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(234, 30)
        txtUsername.TabIndex = 31
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(39, 220)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(78, 37)
        btnLogin.TabIndex = 32
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(158, 218)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(78, 37)
        btnClose.TabIndex = 34
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpLogin)
        TabControl1.Controls.Add(tpRegister)
        TabControl1.Location = New Point(254, 7)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(290, 309)
        TabControl1.TabIndex = 6
        ' 
        ' tpLogin
        ' 
        tpLogin.Controls.Add(Label11)
        tpLogin.Controls.Add(btnClose)
        tpLogin.Controls.Add(Label1)
        tpLogin.Controls.Add(btnLogin)
        tpLogin.Controls.Add(Label2)
        tpLogin.Controls.Add(txtUsername)
        tpLogin.Controls.Add(txtPassword)
        tpLogin.Location = New Point(4, 24)
        tpLogin.Name = "tpLogin"
        tpLogin.Padding = New Padding(3)
        tpLogin.Size = New Size(282, 281)
        tpLogin.TabIndex = 0
        tpLogin.Text = "Login"
        tpLogin.UseVisualStyleBackColor = True
        ' 
        ' tpRegister
        ' 
        tpRegister.Controls.Add(btnRegisterCancel)
        tpRegister.Controls.Add(btnRegisterHere)
        tpRegister.Controls.Add(Label4)
        tpRegister.Location = New Point(4, 24)
        tpRegister.Name = "tpRegister"
        tpRegister.Padding = New Padding(3)
        tpRegister.Size = New Size(282, 281)
        tpRegister.TabIndex = 1
        tpRegister.Text = "Register"
        tpRegister.UseVisualStyleBackColor = True
        ' 
        ' btnRegisterCancel
        ' 
        btnRegisterCancel.BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        btnRegisterCancel.FlatAppearance.BorderSize = 0
        btnRegisterCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRegisterCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRegisterCancel.FlatStyle = FlatStyle.Flat
        btnRegisterCancel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegisterCancel.ForeColor = Color.White
        btnRegisterCancel.Location = New Point(18, 181)
        btnRegisterCancel.Name = "btnRegisterCancel"
        btnRegisterCancel.Size = New Size(245, 50)
        btnRegisterCancel.TabIndex = 38
        btnRegisterCancel.Text = "Cancel"
        btnRegisterCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegisterHere
        ' 
        btnRegisterHere.BackColor = Color.FromArgb(CByte(33), CByte(11), CByte(97))
        btnRegisterHere.FlatAppearance.BorderSize = 0
        btnRegisterHere.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRegisterHere.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRegisterHere.FlatStyle = FlatStyle.Flat
        btnRegisterHere.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegisterHere.ForeColor = Color.White
        btnRegisterHere.Location = New Point(18, 125)
        btnRegisterHere.Name = "btnRegisterHere"
        btnRegisterHere.Size = New Size(245, 50)
        btnRegisterHere.TabIndex = 37
        btnRegisterHere.Text = "Register Here"
        btnRegisterHere.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 28)
        Label4.TabIndex = 36
        Label4.Text = "Create Account!"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 323)
        ControlBox = False
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tpLogin.ResumeLayout(False)
        tpLogin.PerformLayout()
        tpRegister.ResumeLayout(False)
        tpRegister.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents tpRegister As TabPage
    Friend WithEvents btnRegisterHere As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegisterCancel As Button
End Class
