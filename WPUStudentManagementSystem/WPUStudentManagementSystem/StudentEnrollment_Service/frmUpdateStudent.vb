Public Class frmUpdateStudent
    Private dbHelper As New DBHelper()
    Private studentID As Integer

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        studentID = id
        LoadStudentData()
    End Sub

    Private Sub LoadStudentData()
        Dim query As String = "SELECT u.FirstName, u.LastName, u.Gender, u.Address, 
                              u.ContactNumber, u.Email, s.GPA 
                              FROM Users u 
                              INNER JOIN Students s ON u.UserID = s.StudentID 
                              WHERE u.UserID = @studentID"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@studentID", studentID}
        }

        Dim dt As DataTable = dbHelper.ExecuteQuery(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtFirstName.Text = row("FirstName").ToString()
            txtLastName.Text = row("LastName").ToString()
            cmbGender.Text = row("Gender").ToString()
            txtAddress.Text = row("Address").ToString()
            txtContact.Text = row("ContactNumber").ToString()
            txtEmail.Text = row("Email").ToString()
            txtGPA.Text = row("GPA").ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs
        If String.IsNullOrEmpty(txtFirstName.Text) Or String.IsNullOrEmpty(txtLastName.Text) Or
           String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtAddress.Text) Or
           String.IsNullOrEmpty(txtContact.Text) Or String.IsNullOrEmpty(txtGPA.Text) Or
           cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate GPA
        Dim gpa As Decimal
        If Not Decimal.TryParse(txtGPA.Text, gpa) Or gpa < 0 Or gpa > 4.0 Then
            MessageBox.Show("Please enter a valid GPA between 0.00 and 4.00.", "Invalid GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Update Users table
            Dim userParams As New Dictionary(Of String, Object) From {
                {"@firstName", txtFirstName.Text},
                {"@lastName", txtLastName.Text},
                {"@gender", cmbGender.SelectedItem.ToString()},
                {"@address", txtAddress.Text},
                {"@contact", txtContact.Text},
                {"@email", txtEmail.Text},
                {"@userID", studentID}
            }

            Dim userResult As Integer = dbHelper.ExecuteNonQuery(
                "UPDATE Users SET FirstName = @firstName, LastName = @lastName, 
                 Gender = @gender, Address = @address, ContactNumber = @contact, 
                 Email = @email WHERE UserID = @userID", userParams)

            ' Update Students table (GPA)
            Dim studentResult As Integer = dbHelper.ExecuteNonQuery(
                "UPDATE Students SET GPA = @gpa WHERE StudentID = @studentID",
                New Dictionary(Of String, Object) From {
                    {"@gpa", gpa},
                    {"@studentID", studentID}
                })

            If userResult > 0 Or studentResult > 0 Then
                MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("No changes were made to the student record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error updating student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class