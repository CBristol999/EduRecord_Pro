<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseSearch))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        ptbExit = New PictureBox()
        dgvGetStudent = New DataGridView()
        btnClear = New Button()
        btnSearch = New Button()
        txtLimit = New TextBox()
        cbStatus = New ComboBox()
        Label10 = New Label()
        Label8 = New Label()
        lblStatus = New Label()
        txtStudentID = New TextBox()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ptbExit, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvGetStudent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ptbExit)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(751, 43)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(712, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ptbExit
        ' 
        ptbExit.Cursor = Cursors.Hand
        ptbExit.Image = CType(resources.GetObject("ptbExit.Image"), Image)
        ptbExit.Location = New Point(1064, 7)
        ptbExit.Name = "ptbExit"
        ptbExit.Size = New Size(33, 32)
        ptbExit.SizeMode = PictureBoxSizeMode.StretchImage
        ptbExit.TabIndex = 1
        ptbExit.TabStop = False
        ' 
        ' dgvGetStudent
        ' 
        dgvGetStudent.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        dgvGetStudent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvGetStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGetStudent.Location = New Point(17, 188)
        dgvGetStudent.Name = "dgvGetStudent"
        dgvGetStudent.ReadOnly = True
        dgvGetStudent.RowHeadersVisible = False
        dgvGetStudent.Size = New Size(717, 374)
        dgvGetStudent.TabIndex = 93
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
        btnClear.Location = New Point(641, 126)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(95, 46)
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
        btnSearch.Location = New Point(518, 126)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(110, 46)
        btnSearch.TabIndex = 77
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(178, 147)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(108, 23)
        txtLimit.TabIndex = 83
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Regular", "Irregular"})
        cbStatus.Location = New Point(307, 147)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(144, 23)
        cbStatus.TabIndex = 84
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(178, 123)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 18)
        Label10.TabIndex = 77
        Label10.Text = "Limit Display"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(19, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 18)
        Label8.TabIndex = 74
        Label8.Text = "StudentID:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(307, 123)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(132, 18)
        lblStatus.TabIndex = 75
        lblStatus.Text = "Student Status:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(19, 148)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(144, 23)
        txtStudentID.TabIndex = 70
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 18)
        Label1.TabIndex = 73
        Label1.Text = "Student Firstname/Lastname:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(19, 94)
        txtName.Name = "txtName"
        txtName.Size = New Size(144, 23)
        txtName.TabIndex = 71
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(478, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(256, 37)
        Label2.TabIndex = 94
        Label2.Text = "Search Student"
        ' 
        ' CourseSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(751, 574)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(dgvGetStudent)
        Controls.Add(txtLimit)
        Controls.Add(Panel1)
        Controls.Add(cbStatus)
        Controls.Add(txtName)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Controls.Add(txtStudentID)
        Controls.Add(lblStatus)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "CourseSearch"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ptbExit, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvGetStudent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ptbExit As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvGetStudent As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
End Class
