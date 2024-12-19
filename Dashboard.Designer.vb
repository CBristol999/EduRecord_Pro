<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblAdmin = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        lblFemales = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Panel10 = New Panel()
        lblMales = New Label()
        Label8 = New Label()
        PictureBox6 = New PictureBox()
        Panel5 = New Panel()
        lblEnrolledStudents = New Label()
        Label3 = New Label()
        PictureBox8 = New PictureBox()
        Panel8 = New Panel()
        lblTotals = New Label()
        Label7 = New Label()
        PictureBox7 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pexels_pixabay_356065
        PictureBox3.Location = New Point(37, 478)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(904, 311)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel8)
        Panel1.Location = New Point(37, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 428)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblAdmin)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox2)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(43, 156)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(376, 109)
        Panel2.TabIndex = 12
        ' 
        ' lblAdmin
        ' 
        lblAdmin.AutoSize = True
        lblAdmin.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdmin.ForeColor = Color.White
        lblAdmin.Location = New Point(29, 45)
        lblAdmin.Name = "lblAdmin"
        lblAdmin.Size = New Size(37, 42)
        lblAdmin.TabIndex = 10
        lblAdmin.Text = "0"
        lblAdmin.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 21)
        Label2.TabIndex = 9
        Label2.Text = "Total Admin"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.student
        PictureBox2.Location = New Point(257, 14)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(95, 78)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblFemales)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(PictureBox1)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(475, 288)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(376, 109)
        Panel3.TabIndex = 13
        ' 
        ' lblFemales
        ' 
        lblFemales.AutoSize = True
        lblFemales.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFemales.ForeColor = Color.White
        lblFemales.Location = New Point(32, 50)
        lblFemales.Name = "lblFemales"
        lblFemales.Size = New Size(37, 42)
        lblFemales.TabIndex = 10
        lblFemales.Text = "0"
        lblFemales.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(13, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(228, 21)
        Label9.TabIndex = 9
        Label9.Text = "Enrolled Female Students"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.woman
        PictureBox1.Location = New Point(265, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(lblMales)
        Panel10.Controls.Add(Label8)
        Panel10.Controls.Add(PictureBox6)
        Panel10.ForeColor = Color.Black
        Panel10.Location = New Point(475, 156)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(376, 109)
        Panel10.TabIndex = 12
        ' 
        ' lblMales
        ' 
        lblMales.AutoSize = True
        lblMales.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMales.ForeColor = Color.White
        lblMales.Location = New Point(29, 50)
        lblMales.Name = "lblMales"
        lblMales.Size = New Size(37, 42)
        lblMales.TabIndex = 10
        lblMales.Text = "0"
        lblMales.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(13, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(207, 21)
        Label8.TabIndex = 9
        Label8.Text = "Enrolled Male Students"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.man
        PictureBox6.Location = New Point(264, 14)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(87, 74)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(lblEnrolledStudents)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(PictureBox8)
        Panel5.ForeColor = Color.Black
        Panel5.Location = New Point(475, 23)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(376, 109)
        Panel5.TabIndex = 12
        ' 
        ' lblEnrolledStudents
        ' 
        lblEnrolledStudents.AutoSize = True
        lblEnrolledStudents.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnrolledStudents.ForeColor = Color.White
        lblEnrolledStudents.Location = New Point(29, 45)
        lblEnrolledStudents.Name = "lblEnrolledStudents"
        lblEnrolledStudents.Size = New Size(37, 42)
        lblEnrolledStudents.TabIndex = 10
        lblEnrolledStudents.Text = "0"
        lblEnrolledStudents.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 21)
        Label3.TabIndex = 9
        Label3.Text = "Total Enrolled Students"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.student
        PictureBox8.Location = New Point(258, 14)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(95, 78)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 11
        PictureBox8.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(75), CByte(8), CByte(138))
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(lblTotals)
        Panel8.Controls.Add(Label7)
        Panel8.Controls.Add(PictureBox7)
        Panel8.ForeColor = Color.Black
        Panel8.Location = New Point(43, 23)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(376, 109)
        Panel8.TabIndex = 8
        ' 
        ' lblTotals
        ' 
        lblTotals.AutoSize = True
        lblTotals.Font = New Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotals.ForeColor = Color.White
        lblTotals.Location = New Point(29, 45)
        lblTotals.Name = "lblTotals"
        lblTotals.Size = New Size(37, 42)
        lblTotals.TabIndex = 10
        lblTotals.Text = "0"
        lblTotals.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(13, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 21)
        Label7.TabIndex = 9
        Label7.Text = "Total Students"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.student
        PictureBox7.Location = New Point(257, 14)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(95, 78)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFemales As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTotals As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblMales As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblEnrolledStudents As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
