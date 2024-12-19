<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoosePeriod
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
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        btnView = New Button()
        cbYear = New ComboBox()
        cbPeriod = New ComboBox()
        Label18 = New Label()
        Label17 = New Label()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(166), CByte(174), CByte(191))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel2)
        Panel3.Controls.Add(Panel1)
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(233, 232)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(424, 353)
        Panel3.TabIndex = 93
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(420, 42)
        Panel2.TabIndex = 91
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnView)
        Panel1.Controls.Add(cbYear)
        Panel1.Controls.Add(cbPeriod)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label17)
        Panel1.Location = New Point(39, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(334, 260)
        Panel1.TabIndex = 90
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.FromArgb(CByte(33), CByte(8), CByte(97))
        btnView.FlatAppearance.BorderSize = 0
        btnView.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(72), CByte(8), CByte(138))
        btnView.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(249), CByte(84), CByte(84))
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnView.ForeColor = Color.White
        btnView.Location = New Point(112, 178)
        btnView.Name = "btnView"
        btnView.Size = New Size(111, 56)
        btnView.TabIndex = 94
        btnView.Text = "VIEW"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Location = New Point(36, 60)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(262, 23)
        cbYear.TabIndex = 70
        ' 
        ' cbPeriod
        ' 
        cbPeriod.FormattingEnabled = True
        cbPeriod.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        cbPeriod.Location = New Point(36, 127)
        cbPeriod.Name = "cbPeriod"
        cbPeriod.Size = New Size(262, 23)
        cbPeriod.TabIndex = 69
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label18.Location = New Point(37, 26)
        Label18.Name = "Label18"
        Label18.Size = New Size(155, 22)
        Label18.TabIndex = 66
        Label18.Text = "Academic Year:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Rounded MT Bold", 14.25F)
        Label17.Location = New Point(36, 98)
        Label17.Name = "Label17"
        Label17.Size = New Size(173, 22)
        Label17.TabIndex = 68
        Label17.Text = "Academic Period:"
        ' 
        ' ChoosePeriod
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(979, 827)
        ControlBox = False
        Controls.Add(Panel3)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "ChoosePeriod"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChoosePeriod"
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbPeriod As ComboBox
    Friend WithEvents btnView As Button
End Class
