Public Class frmRegistrarDashboard
    Private dbHelper As New DBHelper()

    Private Sub frmRegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllStudents()
        LoadHECASEligible()
    End Sub

    Private Sub LoadAllStudents()
        Dim query As String = "SELECT u.UserID, u.FirstName, u.LastName, u.Email, 
                              u.ContactNumber, s.GPA 
                              FROM Users u 
                              INNER JOIN Students s ON u.UserID = s.StudentID 
                              ORDER BY u.LastName, u.FirstName"

        Dim dt As DataTable = dbHelper.ExecuteQuery(query, Nothing)
        dgvStudents.DataSource = dt
    End Sub

    Private Sub LoadHECASEligible()
        Dim query As String = "SELECT u.UserID, u.FirstName, u.LastName, u.Email, s.GPA 
                              FROM Users u 
                              INNER JOIN Students s ON u.UserID = s.StudentID 
                              WHERE s.GPA >= 2.5 
                              ORDER BY s.GPA DESC"

        Dim dt As DataTable = dbHelper.ExecuteQuery(query, Nothing)
        dgvHECASEligible.DataSource = dt
        lblEligibleCount.Text = "Eligible Students: " & dt.Rows.Count
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim addStudentForm As New frmAddStudent()
        If addStudentForm.ShowDialog() = DialogResult.OK Then
            LoadAllStudents()
            LoadHECASEligible()
        End If
    End Sub

    Private Sub btnCalculateHECAS_Click(sender As Object, e As EventArgs) Handles btnCalculateHECAS.Click
        ' Update HECAS eligibility for all students
        Dim result As Integer = dbHelper.ExecuteNonQuery(
            "INSERT INTO HECASScholarships (StudentID, Eligible) 
             SELECT StudentID, CASE WHEN GPA >= 2.5 THEN TRUE ELSE FALSE END 
             FROM Students 
             ON DUPLICATE KEY UPDATE Eligible = VALUES(Eligible), DateEvaluated = NOW()",
            Nothing
        )

        If result > 0 Then
            MessageBox.Show("HECAS eligibility updated for all students.")
            LoadHECASEligible()
        Else
            MessageBox.Show("Failed to update HECAS eligibility.")
        End If
    End Sub

    ' REFRESH BUTTON
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllStudents()
        LoadHECASEligible()
        MessageBox.Show("Data refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' EDIT STUDENT BUTTON
    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        Dim studentID As Integer = GetSelectedStudentID()

        If studentID > 0 Then
            Dim updateForm As New frmUpdateStudent(studentID)
            If updateForm.ShowDialog() = DialogResult.OK Then
                LoadAllStudents()
                LoadHECASEligible()
            End If
        Else
            MessageBox.Show("Please select a student to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' DELETE STUDENT BUTTON
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim studentID As Integer = GetSelectedStudentID()

        If studentID > 0 Then
            Dim studentName As String = GetSelectedStudentName()

            Dim confirmResult As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete student: {studentName}? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If confirmResult = DialogResult.Yes Then
                DeleteStudent(studentID, studentName)
            End If
        Else
            MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' HELPER METHOD TO GET SELECTED STUDENT ID FROM EITHER GRID
    Private Function GetSelectedStudentID() As Integer
        ' Check which DataGridView has selection
        If dgvStudents.SelectedRows.Count > 0 Then
            Return Convert.ToInt32(dgvStudents.SelectedRows(0).Cells("UserID").Value)
        ElseIf dgvHECASEligible.SelectedRows.Count > 0 Then
            Return Convert.ToInt32(dgvHECASEligible.SelectedRows(0).Cells("UserID").Value)
        Else
            Return 0
        End If
    End Function

    ' HELPER METHOD TO GET SELECTED STUDENT NAME FROM EITHER GRID
    Private Function GetSelectedStudentName() As String
        If dgvStudents.SelectedRows.Count > 0 Then
            Dim row = dgvStudents.SelectedRows(0)
            Return row.Cells("FirstName").Value.ToString() & " " & row.Cells("LastName").Value.ToString()
        ElseIf dgvHECASEligible.SelectedRows.Count > 0 Then
            Dim row = dgvHECASEligible.SelectedRows(0)
            Return row.Cells("FirstName").Value.ToString() & " " & row.Cells("LastName").Value.ToString()
        Else
            Return ""
        End If
    End Function

    ' METHOD TO DELETE STUDENT AND ALL RELATED RECORDS
    Private Sub DeleteStudent(studentID As Integer, studentName As String)
        Try
            ' Start transaction to ensure data integrity
            ' First delete from child tables, then parent tables

            ' Delete from HECASScholarships
            dbHelper.ExecuteNonQuery("DELETE FROM HECASScholarships WHERE StudentID = @studentID",
                                   New Dictionary(Of String, Object) From {{"@studentID", studentID}})

            ' Delete from Transcripts
            dbHelper.ExecuteNonQuery("DELETE FROM Transcripts WHERE StudentID = @studentID",
                                   New Dictionary(Of String, Object) From {{"@studentID", studentID}})

            ' Delete from DormAllocations
            dbHelper.ExecuteNonQuery("DELETE FROM DormAllocations WHERE StudentID = @studentID",
                                   New Dictionary(Of String, Object) From {{"@studentID", studentID}})

            ' Delete from Enrollments
            dbHelper.ExecuteNonQuery("DELETE FROM Enrollments WHERE StudentID = @studentID",
                                   New Dictionary(Of String, Object) From {{"@studentID", studentID}})

            ' Delete from Students table
            Dim studentResult As Integer = dbHelper.ExecuteNonQuery(
                "DELETE FROM Students WHERE StudentID = @studentID",
                New Dictionary(Of String, Object) From {{"@studentID", studentID}})

            ' Finally delete from Users table
            Dim userResult As Integer = dbHelper.ExecuteNonQuery(
                "DELETE FROM Users WHERE UserID = @userID",
                New Dictionary(Of String, Object) From {{"@userID", studentID}})

            If userResult > 0 And studentResult > 0 Then
                MessageBox.Show($"Student {studentName} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadAllStudents()
                LoadHECASEligible()
            Else
                MessageBox.Show("Failed to delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error deleting student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' DOUBLE-CLICK TO EDIT STUDENT
    Private Sub dgvStudents_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnEditStudent_Click(sender, e)
        End If
    End Sub

    Private Sub dgvHECASEligible_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHECASEligible.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnEditStudent_Click(sender, e)
        End If
    End Sub

    ' LOGOUT BUTTON
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

End Class