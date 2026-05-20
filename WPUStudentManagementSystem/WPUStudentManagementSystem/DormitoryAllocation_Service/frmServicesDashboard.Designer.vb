<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicesDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicesDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFloors = New System.Windows.Forms.ComboBox()
        Me.cmbDormitories = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.btnAllocate = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewOccupants = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvOccupants = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOccupants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dormitory:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Floor:"
        '
        'cmbFloors
        '
        Me.cmbFloors.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFloors.FormattingEnabled = True
        Me.cmbFloors.Location = New System.Drawing.Point(172, 131)
        Me.cmbFloors.Name = "cmbFloors"
        Me.cmbFloors.Size = New System.Drawing.Size(499, 25)
        Me.cmbFloors.TabIndex = 3
        '
        'cmbDormitories
        '
        Me.cmbDormitories.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDormitories.FormattingEnabled = True
        Me.cmbDormitories.Location = New System.Drawing.Point(172, 103)
        Me.cmbDormitories.Name = "cmbDormitories"
        Me.cmbDormitories.Size = New System.Drawing.Size(499, 25)
        Me.cmbDormitories.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Rooms"
        '
        'dgvRooms
        '
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(58, 223)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.RowHeadersWidth = 51
        Me.dgvRooms.RowTemplate.Height = 24
        Me.dgvRooms.Size = New System.Drawing.Size(676, 150)
        Me.dgvRooms.TabIndex = 6
        '
        'btnAllocate
        '
        Me.btnAllocate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAllocate.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllocate.Location = New System.Drawing.Point(58, 379)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(148, 37)
        Me.btnAllocate.TabIndex = 7
        Me.btnAllocate.Text = "Allocate Student"
        Me.btnAllocate.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Tomato
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(58, 694)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(148, 37)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnViewOccupants
        '
        Me.btnViewOccupants.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewOccupants.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOccupants.Location = New System.Drawing.Point(58, 619)
        Me.btnViewOccupants.Name = "btnViewOccupants"
        Me.btnViewOccupants.Size = New System.Drawing.Size(148, 37)
        Me.btnViewOccupants.TabIndex = 9
        Me.btnViewOccupants.Text = "View Occupants"
        Me.btnViewOccupants.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cascadia Code SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Occupants"
        '
        'dgvOccupants
        '
        Me.dgvOccupants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOccupants.Location = New System.Drawing.Point(63, 463)
        Me.dgvOccupants.Name = "dgvOccupants"
        Me.dgvOccupants.RowHeadersWidth = 51
        Me.dgvOccupants.RowTemplate.Height = 24
        Me.dgvOccupants.Size = New System.Drawing.Size(671, 150)
        Me.dgvOccupants.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(222, 619)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(148, 37)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmServicesDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(801, 752)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvOccupants)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnViewOccupants)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnAllocate)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDormitories)
        Me.Controls.Add(Me.cmbFloors)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServicesDashboard"
        Me.Text = "Services Dashboard"
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOccupants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFloors As ComboBox
    Friend WithEvents cmbDormitories As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAllocate As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewOccupants As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvOccupants As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
