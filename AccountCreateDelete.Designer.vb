<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreateDelete
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
        btnCancel = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        Panel3 = New Panel()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtUsername = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblFullname = New Label()
        txtFullname = New TextBox()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(btnCancel)
        Panel6.Controls.Add(btnSave)
        Panel6.Controls.Add(btnDelete)
        Panel6.Location = New Point(36, 315)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(287, 60)
        Panel6.TabIndex = 13
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(188, 7)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(82, 42)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnSave.ForeColor = SystemColors.Window
        btnSave.Location = New Point(10, 8)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(78, 42)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnDelete.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(100, 7)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(78, 42)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(lblEmail)
        Panel3.Controls.Add(txtEmail)
        Panel3.Controls.Add(lblFullname)
        Panel3.Controls.Add(txtFullname)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(22, 23)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(318, 267)
        Panel3.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 18)
        Label2.TabIndex = 78
        Label2.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(22, 223)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(274, 23)
        txtPassword.TabIndex = 75
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 18)
        Label3.TabIndex = 77
        Label3.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(22, 161)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(274, 23)
        txtUsername.TabIndex = 76
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(20, 74)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 18)
        lblEmail.TabIndex = 74
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(20, 99)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(274, 23)
        txtEmail.TabIndex = 70
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullname.Location = New Point(20, 12)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(91, 18)
        lblFullname.TabIndex = 73
        lblFullname.Text = "Full Name:"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(20, 36)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(274, 23)
        txtFullname.TabIndex = 71
        ' 
        ' AccountCreateDelete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(361, 405)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        ForeColor = Color.White
        Name = "AccountCreateDelete"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AccountCreateDelete"
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFullname As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
End Class
