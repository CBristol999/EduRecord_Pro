<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationApproval))
        dgvArchive = New TabControl()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBoxStudentImage = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        dgvPending = New DataGridView()
        getAccept = New DataGridViewImageColumn()
        getReject = New DataGridViewImageColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Colum4 = New DataGridViewTextBoxColumn()
        Colum5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        dgvArchives = New DataGridView()
        getRestore = New DataGridViewImageColumn()
        getRemove = New DataGridViewImageColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel3 = New Panel()
        ptbExit = New PictureBox()
        dgvArchive.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPending, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvArchives, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(ptbExit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvArchive
        ' 
        dgvArchive.Controls.Add(TabPage1)
        dgvArchive.Controls.Add(TabPage2)
        dgvArchive.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvArchive.Location = New Point(0, 48)
        dgvArchive.Name = "dgvArchive"
        dgvArchive.SelectedIndex = 0
        dgvArchive.Size = New Size(915, 485)
        dgvArchive.SizeMode = TabSizeMode.Fixed
        dgvArchive.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(dgvPending)
        TabPage1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(907, 457)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Pending"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(158), CByte(223), CByte(156))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBoxStudentImage)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(901, 40)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label2.Location = New Point(213, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 63
        Label2.Text = "Reject"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(182, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 62
        PictureBox1.TabStop = False
        ' 
        ' PictureBoxStudentImage
        ' 
        PictureBoxStudentImage.Image = CType(resources.GetObject("PictureBoxStudentImage.Image"), Image)
        PictureBoxStudentImage.Location = New Point(85, 10)
        PictureBoxStudentImage.Name = "PictureBoxStudentImage"
        PictureBoxStudentImage.Size = New Size(29, 23)
        PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStudentImage.TabIndex = 61
        PictureBoxStudentImage.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label3.Location = New Point(117, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 2
        Label3.Text = "Accept"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 17)
        Label1.TabIndex = 0
        Label1.Text = "Legend:"
        ' 
        ' dgvPending
        ' 
        dgvPending.AllowUserToAddRows = False
        dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPending.Columns.AddRange(New DataGridViewColumn() {getAccept, getReject, Column3, Colum4, Colum5, Column6, Column7, Column8, Column9, Column10})
        dgvPending.Dock = DockStyle.Bottom
        dgvPending.EnableHeadersVisualStyles = False
        dgvPending.Location = New Point(3, 49)
        dgvPending.Name = "dgvPending"
        dgvPending.ReadOnly = True
        dgvPending.RowHeadersVisible = False
        dgvPending.Size = New Size(901, 405)
        dgvPending.TabIndex = 0
        ' 
        ' getAccept
        ' 
        getAccept.HeaderText = ""
        getAccept.Image = CType(resources.GetObject("getAccept.Image"), Image)
        getAccept.ImageLayout = DataGridViewImageCellLayout.Stretch
        getAccept.Name = "getAccept"
        getAccept.ReadOnly = True
        getAccept.Width = 40
        ' 
        ' getReject
        ' 
        getReject.HeaderText = ""
        getReject.Image = CType(resources.GetObject("getReject.Image"), Image)
        getReject.ImageLayout = DataGridViewImageCellLayout.Stretch
        getReject.Name = "getReject"
        getReject.ReadOnly = True
        getReject.Width = 40
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Student ID"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 92
        ' 
        ' Colum4
        ' 
        Colum4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Colum4.HeaderText = "FullName"
        Colum4.Name = "Colum4"
        Colum4.ReadOnly = True
        Colum4.Width = 94
        ' 
        ' Colum5
        ' 
        Colum5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Colum5.HeaderText = "Gender"
        Colum5.Name = "Colum5"
        Colum5.ReadOnly = True
        Colum5.Width = 80
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Educational Level"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 135
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Program"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 89
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Year Level"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 92
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "School Period"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 113
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Registration Status"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 120
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvArchives)
        TabPage2.Controls.Add(Panel2)
        TabPage2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(907, 457)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Archive"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvArchives
        ' 
        dgvArchives.AllowUserToAddRows = False
        dgvArchives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvArchives.Columns.AddRange(New DataGridViewColumn() {getRestore, getRemove, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8})
        dgvArchives.Dock = DockStyle.Bottom
        dgvArchives.EnableHeadersVisualStyles = False
        dgvArchives.Location = New Point(3, 49)
        dgvArchives.Name = "dgvArchives"
        dgvArchives.ReadOnly = True
        dgvArchives.RowHeadersVisible = False
        dgvArchives.Size = New Size(901, 405)
        dgvArchives.TabIndex = 1
        ' 
        ' getRestore
        ' 
        getRestore.HeaderText = ""
        getRestore.Image = CType(resources.GetObject("getRestore.Image"), Image)
        getRestore.ImageLayout = DataGridViewImageCellLayout.Stretch
        getRestore.Name = "getRestore"
        getRestore.ReadOnly = True
        getRestore.Width = 40
        ' 
        ' getRemove
        ' 
        getRemove.HeaderText = ""
        getRemove.Image = CType(resources.GetObject("getRemove.Image"), Image)
        getRemove.ImageLayout = DataGridViewImageCellLayout.Stretch
        getRemove.Name = "getRemove"
        getRemove.ReadOnly = True
        getRemove.Width = 40
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 92
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn2.HeaderText = "FullName"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 94
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn3.HeaderText = "Gender"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 80
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn4.HeaderText = "Educational Level"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 135
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn5.HeaderText = "Program"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Width = 89
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn6.HeaderText = "Year Level"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        DataGridViewTextBoxColumn6.Width = 92
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn7.HeaderText = "School Period"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        DataGridViewTextBoxColumn7.Width = 113
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "Registration Status"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        DataGridViewTextBoxColumn8.Width = 120
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(158), CByte(223), CByte(156))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(901, 40)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label4.Location = New Point(213, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 15)
        Label4.TabIndex = 63
        Label4.Text = "Remove Completely"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.remove
        PictureBox2.Location = New Point(182, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(85, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(29, 23)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 61
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label5.Location = New Point(117, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 2
        Label5.Text = "Restore"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 17)
        Label6.TabIndex = 0
        Label6.Text = "Legend:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(ptbExit)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(915, 42)
        Panel3.TabIndex = 1
        ' 
        ' ptbExit
        ' 
        ptbExit.Cursor = Cursors.Hand
        ptbExit.Image = CType(resources.GetObject("ptbExit.Image"), Image)
        ptbExit.Location = New Point(875, 7)
        ptbExit.Name = "ptbExit"
        ptbExit.Size = New Size(33, 32)
        ptbExit.SizeMode = PictureBoxSizeMode.StretchImage
        ptbExit.TabIndex = 2
        ptbExit.TabStop = False
        ' 
        ' RegistrationApproval
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(915, 534)
        ControlBox = False
        Controls.Add(Panel3)
        Controls.Add(dgvArchive)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "RegistrationApproval"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        dgvArchive.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPending, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgvArchives, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(ptbExit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvArchive As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvPending As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents getAccept As DataGridViewImageColumn
    Friend WithEvents getReject As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Colum4 As DataGridViewTextBoxColumn
    Friend WithEvents Colum5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxStudentImage As PictureBox
    Friend WithEvents dgvArchives As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents getRestore As DataGridViewImageColumn
    Friend WithEvents getRemove As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ptbExit As PictureBox
End Class
