Public Class frmServicesDashboard
    Private dbHelper As New DBHelper()

    Private Sub frmServicesDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDormitories()
    End Sub

    Private Sub LoadDormitories()
        Try
            Dim query As String = "SELECT DormID, DormName FROM Dormitories ORDER BY DormName"
            Dim dt As DataTable = dbHelper.ExecuteQuery(query, Nothing)

            cmbDormitories.DataSource = dt
            cmbDormitories.DisplayMember = "DormName"
            cmbDormitories.ValueMember = "DormID"

            ' Clear floors and rooms when loading new dormitories
            cmbFloors.DataSource = Nothing
            dgvRooms.DataSource = Nothing
            dgvOccupants.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error loading dormitories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDormitories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDormitories.SelectedIndexChanged
        If cmbDormitories.SelectedValue IsNot Nothing AndAlso cmbDormitories.SelectedValue.ToString() <> "System.Data.DataRowView" Then
            Try
                Dim dormID As Integer = Convert.ToInt32(cmbDormitories.SelectedValue)
                LoadFloors(dormID)
            Catch ex As Exception
                MessageBox.Show("Error selecting dormitory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadFloors(dormID As Integer)
        Try
            Dim query As String = "SELECT FloorID, FloorNumber FROM Floors 
                                  WHERE DormID = @dormID ORDER BY FloorNumber"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@dormID", dormID}
            }

            Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)
            cmbFloors.DataSource = dt
            cmbFloors.DisplayMember = "FloorNumber"
            cmbFloors.ValueMember = "FloorID"

            ' Clear rooms when loading new floors
            dgvRooms.DataSource = Nothing
            dgvOccupants.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error loading floors: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbFloors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFloors.SelectedIndexChanged
        If cmbFloors.SelectedValue IsNot Nothing AndAlso cmbFloors.SelectedValue.ToString() <> "System.Data.DataRowView" Then
            Try
                Dim floorID As Integer = Convert.ToInt32(cmbFloors.SelectedValue)
                LoadRooms(floorID)
            Catch ex As Exception
                MessageBox.Show("Error selecting floor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadRooms(floorID As Integer)
        Try
            Dim query As String = "SELECT r.RoomID, r.RoomNumber, r.Capacity, 
                                  CASE WHEN da.StudentID IS NOT NULL THEN 'Occupied' ELSE 'Vacant' END AS Status,
                                  COALESCE(CONCAT(u.FirstName, ' ', u.LastName), 'No Occupant') AS Occupant
                                  FROM Rooms r 
                                  LEFT JOIN DormAllocations da ON r.RoomID = da.RoomID 
                                  LEFT JOIN Students s ON da.StudentID = s.StudentID 
                                  LEFT JOIN Users u ON s.StudentID = u.UserID 
                                  WHERE r.FloorID = @floorID 
                                  ORDER BY r.RoomNumber"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@floorID", floorID}
            }

            Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)
            dgvRooms.DataSource = dt

            ' Auto-size columns for better display
            If dgvRooms.Columns.Count > 0 Then
                dgvRooms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAllocate_Click(sender As Object, e As EventArgs) Handles btnAllocate.Click
        If dgvRooms.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a room from the list.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim roomID As Integer = Convert.ToInt32(dgvRooms.SelectedRows(0).Cells("RoomID").Value)
            Dim roomNumber As String = dgvRooms.SelectedRows(0).Cells("RoomNumber").Value.ToString()
            Dim status As String = dgvRooms.SelectedRows(0).Cells("Status").Value.ToString()

            If status = "Occupied" Then
                MessageBox.Show($"Room {roomNumber} is already occupied. Please select a vacant room.", "Room Occupied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim studentID As String = InputBox($"Enter Student ID to allocate to Room {roomNumber}:", "Allocate Student")

            If String.IsNullOrEmpty(studentID) Then
                Return
            End If

            ' Validate student ID input
            Dim studentIDInt As Integer
            If Not Integer.TryParse(studentID, studentIDInt) Then
                MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if student exists
            Dim studentExists As DataTable = dbHelper.ExecuteQuery(
                "SELECT COUNT(*) as StudentCount FROM Students WHERE StudentID = @studentID",
                New Dictionary(Of String, Object) From {{"@studentID", studentIDInt}}
            )

            If Convert.ToInt32(studentExists.Rows(0)("StudentCount")) = 0 Then
                MessageBox.Show("Student ID does not exist. Please check the Student ID and try again.", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if student already has an allocation
            Dim existingAllocation As DataTable = dbHelper.ExecuteQuery(
                "SELECT COUNT(*) as AllocationCount FROM DormAllocations WHERE StudentID = @studentID",
                New Dictionary(Of String, Object) From {{"@studentID", studentIDInt}}
            )

            If Convert.ToInt32(existingAllocation.Rows(0)("AllocationCount")) > 0 Then
                MessageBox.Show("This student already has a room allocation. Students can only be allocated to one room.", "Already Allocated", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Allocate room to student
            Dim result As Integer = dbHelper.ExecuteNonQuery(
                "INSERT INTO DormAllocations (StudentID, RoomID) VALUES (@studentID, @roomID)",
                New Dictionary(Of String, Object) From {
                    {"@studentID", studentIDInt},
                    {"@roomID", roomID}
                }
            )

            If result > 0 Then
                MessageBox.Show($"Student {studentIDInt} successfully allocated to Room {roomNumber}.", "Allocation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Refresh the rooms list to show updated status
                If cmbFloors.SelectedValue IsNot Nothing Then
                    LoadRooms(Convert.ToInt32(cmbFloors.SelectedValue))
                End If
            Else
                MessageBox.Show("Failed to allocate student to room. Please try again.", "Allocation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during allocation: " & ex.Message, "Allocation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnViewOccupants_Click(sender As Object, e As EventArgs) Handles btnViewOccupants.Click
        If cmbDormitories.SelectedValue Is Nothing Or cmbDormitories.SelectedValue.ToString() = "System.Data.DataRowView" Then
            MessageBox.Show("Please select a dormitory first.", "No Dormitory Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dormID As Integer = Convert.ToInt32(cmbDormitories.SelectedValue)
            Dim dormName As String = cmbDormitories.Text

            Dim query As String = "SELECT u.FirstName, u.LastName, u.Email, u.ContactNumber, 
                                  d.DormName, f.FloorNumber, r.RoomNumber 
                                  FROM DormAllocations da 
                                  INNER JOIN Students s ON da.StudentID = s.StudentID 
                                  INNER JOIN Users u ON s.StudentID = u.UserID 
                                  INNER JOIN Rooms r ON da.RoomID = r.RoomID 
                                  INNER JOIN Floors f ON r.FloorID = f.FloorID 
                                  INNER JOIN Dormitories d ON f.DormID = d.DormID 
                                  WHERE d.DormID = @dormID 
                                  ORDER BY f.FloorNumber, r.RoomNumber"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@dormID", dormID}
            }

            Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)
            dgvOccupants.DataSource = dt

            ' Auto-size columns for better display
            If dgvOccupants.Columns.Count > 0 Then
                dgvOccupants.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End If

            MessageBox.Show($"Showing occupants for {dormName}. Total occupants: {dt.Rows.Count}", "Occupants", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error loading occupants: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                   "Confirm Logout",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Reset global variables
            GlobalVariables.UserID = 0
            GlobalVariables.FirstName = ""
            GlobalVariables.LastName = ""
            GlobalVariables.UserType = ""
            GlobalVariables.StaffID = 0
            GlobalVariables.Role = ""

            ' Show login form and close current form
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' Refresh button to reload all data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDormitories()
        MessageBox.Show("Dormitory data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class