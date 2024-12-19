<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlStudentRecord = New Panel()
        PictureBoxStudentImage = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        pnlDeletePanel = New Panel()
        btnDelete = New Button()
        Panel4 = New Panel()
        btnReset = New Button()
        btnFilter = New Button()
        Label7 = New Label()
        dgvStudentRecord = New DataGridView()
        getView = New DataGridViewImageColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewImageColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        Column24 = New DataGridViewTextBoxColumn()
        Column25 = New DataGridViewTextBoxColumn()
        Column26 = New DataGridViewTextBoxColumn()
        Column27 = New DataGridViewTextBoxColumn()
        Column28 = New DataGridViewTextBoxColumn()
        Column29 = New DataGridViewTextBoxColumn()
        Column30 = New DataGridViewTextBoxColumn()
        Column31 = New DataGridViewTextBoxColumn()
        Column32 = New DataGridViewTextBoxColumn()
        Column33 = New DataGridViewTextBoxColumn()
        Column34 = New DataGridViewTextBoxColumn()
        Column35 = New DataGridViewTextBoxColumn()
        Column36 = New DataGridViewTextBoxColumn()
        Column37 = New DataGridViewTextBoxColumn()
        Column38 = New DataGridViewTextBoxColumn()
        Column39 = New DataGridViewTextBoxColumn()
        Column40 = New DataGridViewTextBoxColumn()
        Column41 = New DataGridViewTextBoxColumn()
        Column42 = New DataGridViewTextBoxColumn()
        Column43 = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        pnlStudentRecord.SuspendLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).BeginInit()
        pnlDeletePanel.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvStudentRecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlStudentRecord
        ' 
        pnlStudentRecord.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        pnlStudentRecord.BorderStyle = BorderStyle.Fixed3D
        pnlStudentRecord.Controls.Add(PictureBoxStudentImage)
        pnlStudentRecord.Controls.Add(Label3)
        pnlStudentRecord.Controls.Add(Label1)
        pnlStudentRecord.Controls.Add(pnlDeletePanel)
        pnlStudentRecord.Controls.Add(Panel4)
        pnlStudentRecord.Controls.Add(dgvStudentRecord)
        pnlStudentRecord.Controls.Add(Label6)
        pnlStudentRecord.ForeColor = Color.Black
        pnlStudentRecord.Location = New Point(18, 21)
        pnlStudentRecord.Name = "pnlStudentRecord"
        pnlStudentRecord.Size = New Size(943, 788)
        pnlStudentRecord.TabIndex = 10
        ' 
        ' PictureBoxStudentImage
        ' 
        PictureBoxStudentImage.Image = CType(resources.GetObject("PictureBoxStudentImage.Image"), Image)
        PictureBoxStudentImage.Location = New Point(96, 119)
        PictureBoxStudentImage.Name = "PictureBoxStudentImage"
        PictureBoxStudentImage.Size = New Size(29, 23)
        PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStudentImage.TabIndex = 64
        PictureBoxStudentImage.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label3.Location = New Point(129, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 63
        Label3.Text = "View Record"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 62
        Label1.Text = "Legend:"
        ' 
        ' pnlDeletePanel
        ' 
        pnlDeletePanel.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        pnlDeletePanel.BorderStyle = BorderStyle.Fixed3D
        pnlDeletePanel.Controls.Add(btnDelete)
        pnlDeletePanel.Location = New Point(426, 57)
        pnlDeletePanel.Name = "pnlDeletePanel"
        pnlDeletePanel.Size = New Size(128, 71)
        pnlDeletePanel.TabIndex = 12
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
        btnDelete.Location = New Point(15, 10)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(91, 46)
        btnDelete.TabIndex = 8
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(btnReset)
        Panel4.Controls.Add(btnFilter)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(581, 33)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(330, 95)
        Panel4.TabIndex = 2
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(201, 47)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(106, 33)
        btnReset.TabIndex = 6
        btnReset.Text = "Refresh"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnFilter.FlatAppearance.BorderSize = 0
        btnFilter.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnFilter.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(20, 47)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(164, 33)
        btnFilter.TabIndex = 5
        btnFilter.Text = "Filter Display Record"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(85, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 23)
        Label7.TabIndex = 3
        Label7.Text = "Search Student"
        ' 
        ' dgvStudentRecord
        ' 
        dgvStudentRecord.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        dgvStudentRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStudentRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudentRecord.Columns.AddRange(New DataGridViewColumn() {getView, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21, Column22, Column23, Column24, Column25, Column26, Column27, Column28, Column29, Column30, Column31, Column32, Column33, Column34, Column35, Column36, Column37, Column38, Column39, Column40, Column41, Column42, Column43})
        dgvStudentRecord.Location = New Point(30, 151)
        dgvStudentRecord.Name = "dgvStudentRecord"
        dgvStudentRecord.ReadOnly = True
        dgvStudentRecord.RowHeadersVisible = False
        dgvStudentRecord.Size = New Size(881, 607)
        dgvStudentRecord.TabIndex = 1
        ' 
        ' getView
        ' 
        getView.HeaderText = "View"
        getView.Image = My.Resources.Resources.pen
        getView.ImageLayout = DataGridViewImageCellLayout.Stretch
        getView.Name = "getView"
        getView.ReadOnly = True
        getView.Width = 40
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Student ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Firstname"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 84
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Lastname"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 83
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Middlename"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 99
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Extension"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 83
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Gender"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 70
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "BirthDate"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 81
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "PhoneNumber"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 110
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Email"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 61
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Citizenship"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 90
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "Birth Country"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 95
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column12.HeaderText = "Birth Place"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 81
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column13.HeaderText = "Religion"
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 75
        ' 
        ' Column14
        ' 
        Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column14.HeaderText = "Address"
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 74
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Profile"
        Column15.ImageLayout = DataGridViewImageCellLayout.Stretch
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Resizable = DataGridViewTriState.True
        Column15.SortMode = DataGridViewColumnSortMode.Automatic
        Column15.Width = 60
        ' 
        ' Column16
        ' 
        Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column16.HeaderText = "Mother Firstname"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Width = 115
        ' 
        ' Column17
        ' 
        Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column17.HeaderText = "Mother Lastname"
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Width = 115
        ' 
        ' Column18
        ' 
        Column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column18.HeaderText = "Mother Middlename"
        Column18.Name = "Column18"
        Column18.ReadOnly = True
        Column18.Width = 129
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Mother Extension"
        Column19.Name = "Column19"
        Column19.ReadOnly = True
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "Mother Residenntial"
        Column20.Name = "Column20"
        Column20.ReadOnly = True
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "Mother Citizenship"
        Column21.Name = "Column21"
        Column21.ReadOnly = True
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "Mother PhoneNumber"
        Column22.Name = "Column22"
        Column22.ReadOnly = True
        ' 
        ' Column23
        ' 
        Column23.HeaderText = "Mother Email"
        Column23.Name = "Column23"
        Column23.ReadOnly = True
        ' 
        ' Column24
        ' 
        Column24.HeaderText = "Father Firstname"
        Column24.Name = "Column24"
        Column24.ReadOnly = True
        ' 
        ' Column25
        ' 
        Column25.HeaderText = "Father Lastname"
        Column25.Name = "Column25"
        Column25.ReadOnly = True
        ' 
        ' Column26
        ' 
        Column26.HeaderText = "Father Middlename"
        Column26.Name = "Column26"
        Column26.ReadOnly = True
        ' 
        ' Column27
        ' 
        Column27.HeaderText = "Father Extension"
        Column27.Name = "Column27"
        Column27.ReadOnly = True
        ' 
        ' Column28
        ' 
        Column28.HeaderText = "Father Residenntial"
        Column28.Name = "Column28"
        Column28.ReadOnly = True
        ' 
        ' Column29
        ' 
        Column29.HeaderText = "Father Citizenship"
        Column29.Name = "Column29"
        Column29.ReadOnly = True
        ' 
        ' Column30
        ' 
        Column30.HeaderText = "Father PhoneNumber"
        Column30.Name = "Column30"
        Column30.ReadOnly = True
        ' 
        ' Column31
        ' 
        Column31.HeaderText = "Father Email"
        Column31.Name = "Column31"
        Column31.ReadOnly = True
        ' 
        ' Column32
        ' 
        Column32.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column32.HeaderText = "Emergency ContactName"
        Column32.Name = "Column32"
        Column32.ReadOnly = True
        Column32.Width = 153
        ' 
        ' Column33
        ' 
        Column33.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column33.HeaderText = "Emergency ContactNumber"
        Column33.Name = "Column33"
        Column33.ReadOnly = True
        Column33.Width = 164
        ' 
        ' Column34
        ' 
        Column34.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column34.HeaderText = "Previous Educational Level"
        Column34.Name = "Column34"
        Column34.ReadOnly = True
        Column34.Width = 133
        ' 
        ' Column35
        ' 
        Column35.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column35.HeaderText = "Previous Program & Track"
        Column35.Name = "Column35"
        Column35.ReadOnly = True
        Column35.Width = 130
        ' 
        ' Column36
        ' 
        Column36.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column36.HeaderText = "Previous School"
        Column36.Name = "Column36"
        Column36.ReadOnly = True
        Column36.Width = 106
        ' 
        ' Column37
        ' 
        Column37.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column37.HeaderText = "Previous Year Attendent"
        Column37.Name = "Column37"
        Column37.ReadOnly = True
        Column37.Width = 144
        ' 
        ' Column38
        ' 
        Column38.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column38.HeaderText = "Previous Award"
        Column38.Name = "Column38"
        Column38.ReadOnly = True
        Column38.Width = 105
        ' 
        ' Column39
        ' 
        Column39.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column39.HeaderText = "Educational Level"
        Column39.Name = "Column39"
        Column39.ReadOnly = True
        Column39.Width = 114
        ' 
        ' Column40
        ' 
        Column40.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column40.HeaderText = "Program"
        Column40.Name = "Column40"
        Column40.ReadOnly = True
        Column40.Width = 78
        ' 
        ' Column41
        ' 
        Column41.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column41.HeaderText = "Year Level"
        Column41.Name = "Column41"
        Column41.ReadOnly = True
        Column41.Width = 78
        ' 
        ' Column42
        ' 
        Column42.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column42.HeaderText = "School Period"
        Column42.Name = "Column42"
        Column42.ReadOnly = True
        Column42.Width = 97
        ' 
        ' Column43
        ' 
        Column43.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column43.HeaderText = "School Year"
        Column43.Name = "Column43"
        Column43.ReadOnly = True
        Column43.Width = 86
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(241, 35)
        Label6.TabIndex = 0
        Label6.Text = "Student Record"
        ' 
        ' StudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(pnlStudentRecord)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentForm"
        pnlStudentRecord.ResumeLayout(False)
        pnlStudentRecord.PerformLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).EndInit()
        pnlDeletePanel.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvStudentRecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlStudentRecord As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvStudentRecord As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlDeletePanel As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBoxStudentImage As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents getView As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewImageColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents Column33 As DataGridViewTextBoxColumn
    Friend WithEvents Column34 As DataGridViewTextBoxColumn
    Friend WithEvents Column35 As DataGridViewTextBoxColumn
    Friend WithEvents Column36 As DataGridViewTextBoxColumn
    Friend WithEvents Column37 As DataGridViewTextBoxColumn
    Friend WithEvents Column38 As DataGridViewTextBoxColumn
    Friend WithEvents Column39 As DataGridViewTextBoxColumn
    Friend WithEvents Column40 As DataGridViewTextBoxColumn
    Friend WithEvents Column41 As DataGridViewTextBoxColumn
    Friend WithEvents Column42 As DataGridViewTextBoxColumn
    Friend WithEvents Column43 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As Label

End Class
