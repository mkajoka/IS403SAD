Public Class frmAddStudent
    Private dbHelper As New DBHelper()

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs
        If String.IsNullOrEmpty(txtFirstName.Text) Or String.IsNullOrEmpty(txtLastName.Text) Or
           String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtPassword.Text) Or
           String.IsNullOrEmpty(txtAddress.Text) Or String.IsNullOrEmpty(txtContact.Text) Or
           cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Generate a unique student ID (in real application, use a proper sequence)
        Dim random As New Random()
        Dim studentID As Integer = random.Next(100000, 999999)

        ' First insert into Users table
        Dim userParams As New Dictionary(Of String, Object) From {
            {"@userID", studentID},
            {"@firstName", txtFirstName.Text},
            {"@lastName", txtLastName.Text},
            {"@gender", cmbGender.SelectedItem.ToString()},
            {"@address", txtAddress.Text},
            {"@contact", txtContact.Text},
            {"@email", txtEmail.Text},
            {"@password", txtPassword.Text},
            {"@userType", "Student"}
        }

        Dim userResult As Integer = dbHelper.ExecuteNonQuery(
            "INSERT INTO Users (UserID, FirstName, LastName, Gender, Address, 
             ContactNumber, Email, Password, UserType) 
             VALUES (@userID, @firstName, @lastName, @gender, @address, 
             @contact, @email, @password, @userType)",
            userParams
        )

        If userResult > 0 Then
            ' Then insert into Students table
            Dim studentResult As Integer = dbHelper.ExecuteNonQuery(
                "INSERT INTO Students (StudentID, GPA) VALUES (@studentID, 0.00)",
                New Dictionary(Of String, Object) From {{"@studentID", studentID}}
            )

            If studentResult > 0 Then
                MessageBox.Show("Student added successfully with ID: " & studentID)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                ' Rollback user insertion if student insertion fails
                dbHelper.ExecuteNonQuery(
                    "DELETE FROM Users WHERE UserID = @userID",
                    New Dictionary(Of String, Object) From {{"@userID", studentID}}
                )
                MessageBox.Show("Failed to add student.")
            End If
        Else
            MessageBox.Show("Failed to add user.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class