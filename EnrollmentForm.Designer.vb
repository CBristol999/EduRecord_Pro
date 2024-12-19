<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        Panel1 = New Panel()
        btnClear = New Button()
        btnSearch = New Button()
        txtLimit = New TextBox()
        cbStudentStatus = New ComboBox()
        Label10 = New Label()
        Label8 = New Label()
        lblStatus = New Label()
        txtStudentID = New TextBox()
        Label1 = New Label()
        txtFullname = New TextBox()
        btnRemove = New Button()
        btnEnroll = New Button()
        dgvEnrollment = New DataGridView()
        Label6 = New Label()
        lblAycode = New Label()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvEnrollment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblAycode)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(btnRemove)
        Panel3.Controls.Add(btnEnroll)
        Panel3.Controls.Add(dgvEnrollment)
        Panel3.Controls.Add(Label6)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(18, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(943, 788)
        Panel3.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtLimit)
        Panel1.Controls.Add(cbStudentStatus)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(txtStudentID)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtFullname)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(426, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(485, 141)
        Panel1.TabIndex = 76
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 12F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(392, 19)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(73, 46)
        btnClear.TabIndex = 85
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(297, 19)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 46)
        btnSearch.TabIndex = 77
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(337, 101)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(117, 23)
        txtLimit.TabIndex = 83
        ' 
        ' cbStudentStatus
        ' 
        cbStudentStatus.FormattingEnabled = True
        cbStudentStatus.Items.AddRange(New Object() {"Regular", "Irregular"})
        cbStudentStatus.Location = New Point(174, 101)
        cbStudentStatus.Name = "cbStudentStatus"
        cbStudentStatus.Size = New Size(144, 23)
        cbStudentStatus.TabIndex = 84
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(334, 77)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 18)
        Label10.TabIndex = 77
        Label10.Text = "Limit Display"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(18, 77)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 18)
        Label8.TabIndex = 74
        Label8.Text = "StudentID:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(174, 77)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(132, 18)
        lblStatus.TabIndex = 75
        lblStatus.Text = "Student Status:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(18, 102)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(144, 23)
        txtStudentID.TabIndex = 70
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 18)
        Label1.TabIndex = 73
        Label1.Text = "Student Firstname Or Lastname:"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(18, 42)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(267, 23)
        txtFullname.TabIndex = 71
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnRemove.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(239, 113)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(105, 46)
        btnRemove.TabIndex = 74
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnEnroll
        ' 
        btnEnroll.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnEnroll.FlatAppearance.BorderSize = 0
        btnEnroll.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnEnroll.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnEnroll.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnEnroll.FlatStyle = FlatStyle.Flat
        btnEnroll.Font = New Font("Arial Rounded MT Bold", 12F)
        btnEnroll.ForeColor = Color.White
        btnEnroll.Location = New Point(30, 113)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(186, 47)
        btnEnroll.TabIndex = 72
        btnEnroll.Text = "ENROLL STUDENT"
        btnEnroll.UseVisualStyleBackColor = False
        ' 
        ' dgvEnrollment
        ' 
        dgvEnrollment.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEnrollment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEnrollment.ColumnHeadersHeight = 40
        dgvEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvEnrollment.Location = New Point(30, 180)
        dgvEnrollment.Name = "dgvEnrollment"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEnrollment.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvEnrollment.RowHeadersVisible = False
        dgvEnrollment.Size = New Size(881, 572)
        dgvEnrollment.TabIndex = 71
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(360, 35)
        Label6.TabIndex = 0
        Label6.Text = "ENROLLMENT PROCESS"
        ' 
        ' lblAycode
        ' 
        lblAycode.AutoSize = True
        lblAycode.BackColor = Color.Orange
        lblAycode.BorderStyle = BorderStyle.Fixed3D
        lblAycode.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAycode.ForeColor = Color.Black
        lblAycode.Location = New Point(30, 75)
        lblAycode.Name = "lblAycode"
        lblAycode.Size = New Size(272, 25)
        lblAycode.TabIndex = 90
        lblAycode.Text = "No Selected Academic Year"
        lblAycode.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EnrollmentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(Panel3)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "EnrollmentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EnrollmentForm"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvEnrollment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents cbStudentStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAycode As Label
End Class
