<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudyLoad
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel3 = New Panel()
        Panel1 = New Panel()
        Label2 = New Label()
        txtAyCode = New TextBox()
        Label19 = New Label()
        txtStatus = New TextBox()
        Label21 = New Label()
        txtSemester = New TextBox()
        Label23 = New Label()
        txtYear = New TextBox()
        Label18 = New Label()
        txtStudentID = New TextBox()
        Label17 = New Label()
        txtFullName = New TextBox()
        Label16 = New Label()
        txtProgram = New TextBox()
        Label22 = New Label()
        txtDataEnrolled = New TextBox()
        PictureBoxStudentImage = New PictureBox()
        Label6 = New Label()
        Panel2 = New Panel()
        dgvStudyLoad = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvStudyLoad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(PictureBoxStudentImage)
        Panel3.Controls.Add(Label6)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(53, 25)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(869, 332)
        Panel3.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtAyCode)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(txtStatus)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(txtSemester)
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(txtYear)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(txtStudentID)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(txtFullName)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtProgram)
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(txtDataEnrolled)
        Panel1.Location = New Point(34, 95)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(796, 209)
        Panel1.TabIndex = 90
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label2.Location = New Point(531, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 17)
        Label2.TabIndex = 110
        Label2.Text = "Academic Year:"
        ' 
        ' txtAyCode
        ' 
        txtAyCode.Location = New Point(531, 104)
        txtAyCode.Name = "txtAyCode"
        txtAyCode.ReadOnly = True
        txtAyCode.Size = New Size(160, 23)
        txtAyCode.TabIndex = 111
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label19.Location = New Point(529, 24)
        Label19.Name = "Label19"
        Label19.Size = New Size(119, 17)
        Label19.TabIndex = 106
        Label19.Text = "Student Status:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(531, 49)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(160, 23)
        txtStatus.TabIndex = 107
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label21.Location = New Point(330, 79)
        Label21.Name = "Label21"
        Label21.Size = New Size(115, 17)
        Label21.TabIndex = 108
        Label21.Text = "School Period:"
        ' 
        ' txtSemester
        ' 
        txtSemester.Location = New Point(330, 104)
        txtSemester.Name = "txtSemester"
        txtSemester.ReadOnly = True
        txtSemester.Size = New Size(171, 23)
        txtSemester.TabIndex = 109
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label23.Location = New Point(330, 24)
        Label23.Name = "Label23"
        Label23.Size = New Size(107, 17)
        Label23.TabIndex = 106
        Label23.Text = "Student Year:"
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(330, 49)
        txtYear.Name = "txtYear"
        txtYear.ReadOnly = True
        txtYear.Size = New Size(170, 23)
        txtYear.TabIndex = 107
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label18.Location = New Point(36, 24)
        Label18.Name = "Label18"
        Label18.Size = New Size(89, 17)
        Label18.TabIndex = 66
        Label18.Text = "Student ID:"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(36, 48)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.ReadOnly = True
        txtStudentID.Size = New Size(262, 23)
        txtStudentID.TabIndex = 67
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label17.Location = New Point(37, 79)
        Label17.Name = "Label17"
        Label17.Size = New Size(115, 17)
        Label17.TabIndex = 68
        Label17.Text = "Student Name:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(37, 103)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(261, 23)
        txtFullName.TabIndex = 71
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label16.Location = New Point(330, 135)
        Label16.Name = "Label16"
        Label16.Size = New Size(77, 17)
        Label16.TabIndex = 76
        Label16.Text = "Program:"
        ' 
        ' txtProgram
        ' 
        txtProgram.Location = New Point(330, 159)
        txtProgram.Name = "txtProgram"
        txtProgram.ReadOnly = True
        txtProgram.Size = New Size(361, 23)
        txtProgram.TabIndex = 77
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label22.Location = New Point(37, 135)
        Label22.Name = "Label22"
        Label22.Size = New Size(107, 17)
        Label22.TabIndex = 81
        Label22.Text = "Date Enrolled"
        ' 
        ' txtDataEnrolled
        ' 
        txtDataEnrolled.Location = New Point(37, 159)
        txtDataEnrolled.Name = "txtDataEnrolled"
        txtDataEnrolled.ReadOnly = True
        txtDataEnrolled.Size = New Size(261, 23)
        txtDataEnrolled.TabIndex = 82
        ' 
        ' PictureBoxStudentImage
        ' 
        PictureBoxStudentImage.BorderStyle = BorderStyle.FixedSingle
        PictureBoxStudentImage.Image = My.Resources.Resources.profile
        PictureBoxStudentImage.Location = New Point(741, 18)
        PictureBoxStudentImage.Name = "PictureBoxStudentImage"
        PictureBoxStudentImage.Size = New Size(87, 67)
        PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStudentImage.TabIndex = 89
        PictureBoxStudentImage.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(198, 29)
        Label6.TabIndex = 0
        Label6.Text = "Student Record"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(dgvStudyLoad)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(53, 385)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(869, 412)
        Panel2.TabIndex = 91
        ' 
        ' dgvStudyLoad
        ' 
        dgvStudyLoad.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudyLoad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudyLoad.ColumnHeadersHeight = 60
        dgvStudyLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvStudyLoad.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvStudyLoad.Location = New Point(22, 21)
        dgvStudyLoad.Name = "dgvStudyLoad"
        dgvStudyLoad.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvStudyLoad.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvStudyLoad.RowHeadersVisible = False
        dgvStudyLoad.Size = New Size(818, 369)
        dgvStudyLoad.TabIndex = 0
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Code"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 70
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Column2.DefaultCellStyle = DataGridViewCellStyle3
        Column2.HeaderText = "Course Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Column3.DefaultCellStyle = DataGridViewCellStyle4
        Column3.HeaderText = "Unit"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 60
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle5.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Column4.DefaultCellStyle = DataGridViewCellStyle5
        Column4.HeaderText = "Assign Teacher"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 170
        ' 
        ' StudyLoad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "StudyLoad"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudyLoad"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxStudentImage, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgvStudyLoad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDataEnrolled As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents PictureBoxStudentImage As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAyCode As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvStudyLoad As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
