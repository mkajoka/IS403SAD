<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEnrollmentCount = New System.Windows.Forms.Label()
        Me.dgvCurrentEnrollments = New System.Windows.Forms.DataGridView()
        Me.btnUnenroll = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvAvailableOfferings = New System.Windows.Forms.DataGridView()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnViewTranscript = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCurrentEnrollments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAvailableOfferings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(396, 153)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(396, 189)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(46, 17)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(310, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(396, 228)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(46, 17)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(310, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contact:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(396, 267)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(46, 17)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(323, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(396, 304)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 17)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Label11"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.BackColor = System.Drawing.Color.Transparent
        Me.lblGPA.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.Location = New System.Drawing.Point(337, 340)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(51, 17)
        Me.lblGPA.TabIndex = 12
        Me.lblGPA.Text = "Label13"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Student Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(657, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 27)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Enrollments"
        '
        'lblEnrollmentCount
        '
        Me.lblEnrollmentCount.AutoSize = True
        Me.lblEnrollmentCount.BackColor = System.Drawing.Color.Transparent
        Me.lblEnrollmentCount.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentCount.Location = New System.Drawing.Point(659, 126)
        Me.lblEnrollmentCount.Name = "lblEnrollmentCount"
        Me.lblEnrollmentCount.Size = New System.Drawing.Size(46, 17)
        Me.lblEnrollmentCount.TabIndex = 17
        Me.lblEnrollmentCount.Text = "Label9"
        '
        'dgvCurrentEnrollments
        '
        Me.dgvCurrentEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentEnrollments.Location = New System.Drawing.Point(662, 171)
        Me.dgvCurrentEnrollments.Name = "dgvCurrentEnrollments"
        Me.dgvCurrentEnrollments.RowHeadersWidth = 51
        Me.dgvCurrentEnrollments.RowTemplate.Height = 24
        Me.dgvCurrentEnrollments.Size = New System.Drawing.Size(672, 150)
        Me.dgvCurrentEnrollments.TabIndex = 18
        '
        'btnUnenroll
        '
        Me.btnUnenroll.BackColor = System.Drawing.Color.Tomato
        Me.btnUnenroll.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnenroll.Location = New System.Drawing.Point(662, 340)
        Me.btnUnenroll.Name = "btnUnenroll"
        Me.btnUnenroll.Size = New System.Drawing.Size(106, 34)
        Me.btnUnenroll.TabIndex = 19
        Me.btnUnenroll.Text = "Unenroll"
        Me.btnUnenroll.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(657, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 27)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Available Offerings "
        '
        'dgvAvailableOfferings
        '
        Me.dgvAvailableOfferings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailableOfferings.Location = New System.Drawing.Point(662, 459)
        Me.dgvAvailableOfferings.Name = "dgvAvailableOfferings"
        Me.dgvAvailableOfferings.RowHeadersWidth = 51
        Me.dgvAvailableOfferings.RowTemplate.Height = 24
        Me.dgvAvailableOfferings.Size = New System.Drawing.Size(672, 150)
        Me.dgvAvailableOfferings.TabIndex = 21
        '
        'btnEnroll
        '
        Me.btnEnroll.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEnroll.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnroll.Location = New System.Drawing.Point(662, 631)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(106, 34)
        Me.btnEnroll.TabIndex = 22
        Me.btnEnroll.Text = "Enroll"
        Me.btnEnroll.UseVisualStyleBackColor = False
        '
        'btnViewTranscript
        '
        Me.btnViewTranscript.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewTranscript.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTranscript.Location = New System.Drawing.Point(783, 631)
        Me.btnViewTranscript.Name = "btnViewTranscript"
        Me.btnViewTranscript.Size = New System.Drawing.Size(146, 34)
        Me.btnViewTranscript.TabIndex = 23
        Me.btnViewTranscript.Text = "View Transcript"
        Me.btnViewTranscript.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Tomato
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(37, 631)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(115, 34)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmStudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1373, 699)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewTranscript)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.dgvAvailableOfferings)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUnenroll)
        Me.Controls.Add(Me.dgvCurrentEnrollments)
        Me.Controls.Add(Me.lblEnrollmentCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStudentDashboard"
        Me.Text = "Student Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCurrentEnrollments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAvailableOfferings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEnrollmentCount As Label
    Friend WithEvents dgvCurrentEnrollments As DataGridView
    Friend WithEvents btnUnenroll As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvAvailableOfferings As DataGridView
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnViewTranscript As Button
    Friend WithEvents btnLogout As Button
End Class
