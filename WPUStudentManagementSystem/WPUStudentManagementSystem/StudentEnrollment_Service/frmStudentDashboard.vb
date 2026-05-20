Public Class frmStudentDashboard
    Private dbHelper As New DBHelper()

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentProfile()
        LoadCurrentEnrollments()
        LoadAvailableOfferings()
    End Sub

    Private Sub LoadStudentProfile()
        Dim query As String = "SELECT u.FirstName, u.LastName, u.Gender, u.Address, 
                          u.ContactNumber, u.Email, s.GPA 
                          FROM Users u 
                          INNER JOIN Students s ON u.UserID = s.StudentID 
                          WHERE u.UserID = @userID"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@userID", GlobalVariables.UserID}
    }

        Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            lblName.Text = row("FirstName").ToString() & " " & row("LastName").ToString()
            lblGender.Text = row("Gender").ToString()
            lblAddress.Text = row("Address").ToString()
            lblContact.Text = row("ContactNumber").ToString()
            lblEmail.Text = row("Email").ToString()
            lblGPA.Text = "GPA: " & row("GPA").ToString()

            ' Make sure StudentID is set in GlobalVariables
            If GlobalVariables.StudentID = 0 Then
                GlobalVariables.StudentID = GlobalVariables.UserID
            End If
        End If
    End Sub

    Private Sub LoadCurrentEnrollments()
        ' Check if StudentID is valid
        If GlobalVariables.StudentID = 0 Then
            MessageBox.Show("Student ID not found. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT u.UnitCode, u.UnitName, s.Year, s.Semester 
                          FROM Enrollments e 
                          INNER JOIN UnitOfferings o ON e.OfferingID = o.OfferingID 
                          INNER JOIN Units u ON o.UnitCode = u.UnitCode 
                          INNER JOIN Semesters s ON o.SemesterID = s.SemesterID 
                          WHERE e.StudentID = @studentID 
                          AND s.Year = YEAR(CURDATE()) 
                          AND s.Semester = CASE 
                              WHEN MONTH(CURDATE()) BETWEEN 1 AND 6 THEN 1 
                              ELSE 2 
                          END"

        Dim parameters As New Dictionary(Of String, Object) From {
        {"@studentID", GlobalVariables.StudentID}
    }

        Try
            Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)
            dgvCurrentEnrollments.DataSource = dt
            lblEnrollmentCount.Text = "Current Enrollments: " & dt.Rows.Count & "/4"
        Catch ex As Exception
            MessageBox.Show("Error loading enrollments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAvailableOfferings()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim currentSemester As Integer = If(DateTime.Now.Month >= 1 AndAlso DateTime.Now.Month <= 6, 1, 2)


        Dim query As String = "SELECT o.OfferingID, u.UnitCode, u.UnitName, u.Description 
                              FROM UnitOfferings o 
                              INNER JOIN Units u ON o.UnitCode = u.UnitCode 
                              INNER JOIN Semesters s ON o.SemesterID = s.SemesterID 
                              WHERE s.Year = @year AND s.Semester = @semester 
                              AND o.OfferingID NOT IN (
                                  SELECT OfferingID FROM Enrollments 
                                  WHERE StudentID = @studentID
                              )"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@year", currentYear},
            {"@semester", currentSemester},
            {"@studentID", GlobalVariables.StudentID}
        }

        Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)
        dgvAvailableOfferings.DataSource = dt
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If dgvAvailableOfferings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a unit to enroll in.")
            Return
        End If

        ' Check if student has reached maximum enrollment (4 units)
        Dim enrollmentCount As Integer = Convert.ToInt32(dbHelper.ExecuteQuery(
            "SELECT COUNT(*) FROM Enrollments e 
             INNER JOIN UnitOfferings o ON e.OfferingID = o.OfferingID 
             INNER JOIN Semesters s ON o.SemesterID = s.SemesterID 
             WHERE e.StudentID = @studentID 
             AND s.Year = YEAR(CURDATE()) 
             AND s.Semester = CASE 
                 WHEN MONTH(CURDATE()) BETWEEN 1 AND 6 THEN 1 
                 ELSE 2 
             END",
            New Dictionary(Of String, Object) From {{"@studentID", GlobalVariables.StudentID}}
        ).Rows(0)(0))

        If enrollmentCount >= 4 Then
            MessageBox.Show("You have already enrolled in the maximum of 4 units for this semester.")
            Return
        End If

        Dim offeringID As Integer = Convert.ToInt32(dgvAvailableOfferings.SelectedRows(0).Cells("OfferingID").Value)

        Dim result As Integer = dbHelper.ExecuteNonQuery(
            "INSERT INTO Enrollments (StudentID, OfferingID) VALUES (@studentID, @offeringID)",
            New Dictionary(Of String, Object) From {
                {"@studentID", GlobalVariables.StudentID},
                {"@offeringID", offeringID}
            }
        )

        If result > 0 Then
            MessageBox.Show("Successfully enrolled in the unit.")
            LoadCurrentEnrollments()
            LoadAvailableOfferings()
        Else
            MessageBox.Show("Failed to enroll in the unit.")
        End If
    End Sub

    Private Sub btnUnenroll_Click(sender As Object, e As EventArgs) Handles btnUnenroll.Click
        If dgvCurrentEnrollments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a unit to unenroll from.")
            Return
        End If

        Dim unitCode As String = dgvCurrentEnrollments.SelectedRows(0).Cells("UnitCode").Value.ToString()

        Dim result As Integer = dbHelper.ExecuteNonQuery(
            "DELETE e FROM Enrollments e 
             INNER JOIN UnitOfferings o ON e.OfferingID = o.OfferingID 
             INNER JOIN Units u ON o.UnitCode = u.UnitCode 
             WHERE e.StudentID = @studentID AND u.UnitCode = @unitCode",
            New Dictionary(Of String, Object) From {
                {"@studentID", GlobalVariables.StudentID},
                {"@unitCode", unitCode}
            }
        )

        If result > 0 Then
            MessageBox.Show("Successfully unenrolled from the unit.")
            LoadCurrentEnrollments()
            LoadAvailableOfferings()
        Else
            MessageBox.Show("Failed to unenroll from the unit.")
        End If
    End Sub

    Private Sub btnViewTranscript_Click(sender As Object, e As EventArgs) Handles btnViewTranscript.Click
        Dim transcriptForm As New frmTranscript()
        transcriptForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Properly clear global variables
            GlobalVariables.UserID = 0
            GlobalVariables.StudentID = 0
            GlobalVariables.FirstName = ""
            GlobalVariables.LastName = ""
            GlobalVariables.UserType = ""

            ' Show login form
            Dim loginForm As New frmLogin()
            loginForm.Show()

            ' Close current form
            Me.Close()
        End If
    End Sub


End Class