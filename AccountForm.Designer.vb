<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountForm
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
        Panel10 = New Panel()
        btnApproval = New Button()
        Label8 = New Label()
        Panel5 = New Panel()
        btnDeleteAcc = New Button()
        Label3 = New Label()
        Panel8 = New Panel()
        btnCoAdmin = New Button()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel10.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel8)
        Panel1.Location = New Point(26, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 410)
        Panel1.TabIndex = 14
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(btnApproval)
        Panel10.Controls.Add(Label8)
        Panel10.ForeColor = Color.Black
        Panel10.Location = New Point(49, 223)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(376, 150)
        Panel10.TabIndex = 12
        ' 
        ' btnApproval
        ' 
        btnApproval.BackColor = Color.White
        btnApproval.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnApproval.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnApproval.FlatStyle = FlatStyle.Flat
        btnApproval.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnApproval.Location = New Point(49, 75)
        btnApproval.Name = "btnApproval"
        btnApproval.Size = New Size(263, 49)
        btnApproval.TabIndex = 13
        btnApproval.Text = "View Here"
        btnApproval.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 15.75F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(33, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(292, 25)
        Label8.TabIndex = 9
        Label8.Text = "Student Registration Approval"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(btnDeleteAcc)
        Panel5.Controls.Add(Label3)
        Panel5.ForeColor = Color.Black
        Panel5.Location = New Point(472, 36)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(376, 150)
        Panel5.TabIndex = 12
        ' 
        ' btnDeleteAcc
        ' 
        btnDeleteAcc.BackColor = Color.White
        btnDeleteAcc.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnDeleteAcc.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnDeleteAcc.FlatStyle = FlatStyle.Flat
        btnDeleteAcc.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteAcc.Location = New Point(54, 79)
        btnDeleteAcc.Name = "btnDeleteAcc"
        btnDeleteAcc.Size = New Size(263, 49)
        btnDeleteAcc.TabIndex = 14
        btnDeleteAcc.Text = "Delete Account"
        btnDeleteAcc.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 15.75F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(36, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(301, 25)
        Label3.TabIndex = 9
        Label3.Text = "Delete Student/Admin Account"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(btnCoAdmin)
        Panel8.Controls.Add(Label7)
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(49, 36)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(376, 150)
        Panel8.TabIndex = 8
        ' 
        ' btnCoAdmin
        ' 
        btnCoAdmin.BackColor = Color.White
        btnCoAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnCoAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(93), CByte(185), CByte(150))
        btnCoAdmin.FlatStyle = FlatStyle.Flat
        btnCoAdmin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCoAdmin.Location = New Point(49, 79)
        btnCoAdmin.Name = "btnCoAdmin"
        btnCoAdmin.Size = New Size(263, 49)
        btnCoAdmin.TabIndex = 13
        btnCoAdmin.Text = "Create Account"
        btnCoAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 15.75F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(38, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(287, 25)
        Label7.TabIndex = 9
        Label7.Text = "Create Account for Co-Admin"
        ' 
        ' AccountForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "AccountForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AccountForm"
        Panel1.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnApproval As Button
    Friend WithEvents btnDeleteAcc As Button
    Friend WithEvents btnCoAdmin As Button
End Class
