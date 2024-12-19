<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcademicYearForm
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcademicYearForm))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        btnDelete = New Button()
        Label1 = New Label()
        lblAcademicYear = New Label()
        btnCreate = New Button()
        dgvAyYear = New DataGridView()
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        getOpen = New DataGridViewImageColumn()
        getClose = New DataGridViewImageColumn()
        Panel3.SuspendLayout()
        CType(dgvAyYear, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(lblAcademicYear)
        Panel3.Controls.Add(btnCreate)
        Panel3.Controls.Add(dgvAyYear)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Label6)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(18, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(943, 788)
        Panel3.TabIndex = 11
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial Rounded MT Bold", 12F)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(280, 99)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(203, 39)
        btnDelete.TabIndex = 74
        btnDelete.Text = "Delete Academic Year"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 17)
        Label1.TabIndex = 70
        Label1.Text = "Currently Open Academic Year:"
        ' 
        ' lblAcademicYear
        ' 
        lblAcademicYear.AutoSize = True
        lblAcademicYear.BackColor = Color.DarkOrange
        lblAcademicYear.BorderStyle = BorderStyle.Fixed3D
        lblAcademicYear.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAcademicYear.ForeColor = Color.Black
        lblAcademicYear.Location = New Point(30, 48)
        lblAcademicYear.Name = "lblAcademicYear"
        lblAcademicYear.Size = New Size(341, 35)
        lblAcademicYear.TabIndex = 73
        lblAcademicYear.Text = "No Open Academic Year"
        lblAcademicYear.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnCreate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnCreate.FlatStyle = FlatStyle.Flat
        btnCreate.Font = New Font("Arial Rounded MT Bold", 12F)
        btnCreate.ForeColor = Color.White
        btnCreate.Location = New Point(30, 98)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(240, 39)
        btnCreate.TabIndex = 72
        btnCreate.Text = "Create New Academic Year"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' dgvAyYear
        ' 
        dgvAyYear.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAyYear.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAyYear.ColumnHeadersHeight = 40
        dgvAyYear.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAyYear.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column2, getOpen, getClose})
        dgvAyYear.Location = New Point(30, 151)
        dgvAyYear.Name = "dgvAyYear"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvAyYear.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvAyYear.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvAyYear.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvAyYear.Size = New Size(881, 601)
        dgvAyYear.TabIndex = 71
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(653, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(258, 48)
        Panel1.TabIndex = 70
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label4.Location = New Point(120, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 66
        Label4.Text = "Open"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label2.Location = New Point(199, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 69
        Label2.Text = "Close"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 65
        Label5.Text = "Legend:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(168, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 68
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(88, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 67
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(635, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(276, 42)
        Label6.TabIndex = 0
        Label6.Text = "Academic Year"
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Academic Year"
        Column1.Name = "Column1"
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        Column3.DefaultCellStyle = DataGridViewCellStyle3
        Column3.HeaderText = "Academic Period"
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Column2.DefaultCellStyle = DataGridViewCellStyle4
        Column2.HeaderText = "Status"
        Column2.Name = "Column2"
        Column2.Width = 74
        ' 
        ' getOpen
        ' 
        getOpen.HeaderText = ""
        getOpen.ImageLayout = DataGridViewImageCellLayout.Stretch
        getOpen.Name = "getOpen"
        getOpen.Width = 40
        ' 
        ' getClose
        ' 
        getClose.HeaderText = ""
        getClose.ImageLayout = DataGridViewImageCellLayout.Stretch
        getClose.Name = "getClose"
        getClose.Width = 40
        ' 
        ' AcademicYearForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(Panel3)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "AcademicYearForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AcademicYearForm"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvAyYear, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvAyYear As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblAcademicYear As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents getOpen As DataGridViewImageColumn
    Friend WithEvents getClose As DataGridViewImageColumn
End Class
