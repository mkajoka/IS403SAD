<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvHECASEligible = New System.Windows.Forms.DataGridView()
        Me.lblEligibleCount = New System.Windows.Forms.Label()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnCalculateHECAS = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHECASEligible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "All Students"
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(26, 143)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.Size = New System.Drawing.Size(738, 150)
        Me.dgvStudents.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HECAS Eligible Students"
        '
        'dgvHECASEligible
        '
        Me.dgvHECASEligible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHECASEligible.Location = New System.Drawing.Point(26, 363)
        Me.dgvHECASEligible.Name = "dgvHECASEligible"
        Me.dgvHECASEligible.RowHeadersWidth = 51
        Me.dgvHECASEligible.RowTemplate.Height = 24
        Me.dgvHECASEligible.Size = New System.Drawing.Size(738, 150)
        Me.dgvHECASEligible.TabIndex = 4
        '
        'lblEligibleCount
        '
        Me.lblEligibleCount.AutoSize = True
        Me.lblEligibleCount.BackColor = System.Drawing.Color.Transparent
        Me.lblEligibleCount.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEligibleCount.Location = New System.Drawing.Point(486, 331)
        Me.lblEligibleCount.Name = "lblEligibleCount"
        Me.lblEligibleCount.Size = New System.Drawing.Size(46, 17)
        Me.lblEligibleCount.TabIndex = 5
        Me.lblEligibleCount.Text = "Label4"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(184, 532)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(117, 34)
        Me.btnAddStudent.TabIndex = 6
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnCalculateHECAS
        '
        Me.btnCalculateHECAS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalculateHECAS.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateHECAS.Location = New System.Drawing.Point(612, 532)
        Me.btnCalculateHECAS.Name = "btnCalculateHECAS"
        Me.btnCalculateHECAS.Size = New System.Drawing.Size(152, 34)
        Me.btnCalculateHECAS.TabIndex = 7
        Me.btnCalculateHECAS.Text = "Calculate HECAS"
        Me.btnCalculateHECAS.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Tomato
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(28, 665)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(117, 34)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(47, 532)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(117, 34)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnEditStudent
        '
        Me.btnEditStudent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEditStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudent.Location = New System.Drawing.Point(318, 532)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(117, 34)
        Me.btnEditStudent.TabIndex = 10
        Me.btnEditStudent.Text = "Edit Student"
        Me.btnEditStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.Location = New System.Drawing.Point(454, 532)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(140, 34)
        Me.btnDeleteStudent.TabIndex = 11
        Me.btnDeleteStudent.Text = "Delete Student"
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'frmRegistrarDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 723)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnEditStudent)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCalculateHECAS)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lblEligibleCount)
        Me.Controls.Add(Me.dgvHECASEligible)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegistrarDashboard"
        Me.Text = "Registrar Dashboard"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHECASEligible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvHECASEligible As DataGridView
    Friend WithEvents lblEligibleCount As Label
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnCalculateHECAS As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnDeleteStudent As Button
End Class
