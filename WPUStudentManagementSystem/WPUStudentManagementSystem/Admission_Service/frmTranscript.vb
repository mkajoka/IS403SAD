Public Class frmTranscript
    Private dbHelper As New DBHelper()

    Private Sub frmTranscript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTranscript()
    End Sub

    Private Sub LoadTranscript()
        ' Get student information
        Dim studentQuery As String = "SELECT u.FirstName, u.LastName, u.StudentID, s.GPA 
                                     FROM Users u 
                                     INNER JOIN Students s ON u.UserID = s.StudentID 
                                     WHERE u.UserID = @userID"

        Dim studentParams As New Dictionary(Of String, Object) From {
            {"@userID", GlobalVariables.UserID}
        }

        Dim studentDt As DataTable = dbHelper.ExecuteQuery(studentQuery, studentParams)

        If studentDt.Rows.Count > 0 Then
            Dim row As DataRow = studentDt.Rows(0)
            lblStudentName.Text = row("FirstName").ToString() & " " & row("LastName").ToString()
            lblStudentID.Text = "ID: " & row("StudentID").ToString()
            lblGPA.Text = "Overall GPA: " & row("GPA").ToString()
        End If

        ' Get enrollment history
        Dim transcriptQuery As String = "SELECT u.UnitCode, u.UnitName, s.Year, s.Semester, 
                                        e.Mark, e.Grade 
                                        FROM Enrollments e 
                                        INNER JOIN UnitOfferings o ON e.OfferingID = o.OfferingID 
                                        INNER JOIN Units u ON o.UnitCode = u.UnitCode 
                                        INNER JOIN Semesters s ON o.SemesterID = s.SemesterID 
                                        WHERE e.StudentID = @studentID 
                                        ORDER BY s.Year DESC, s.Semester DESC, u.UnitCode"

        Dim transcriptParams As New Dictionary(Of String, Object) From {
            {"@studentID", GlobalVariables.StudentID}
        }

        Dim transcriptDt As DataTable = dbHelper.ExecuteQuery(transcriptQuery, transcriptParams)
        dgvTranscript.DataSource = transcriptDt
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' In a real application, this would generate a PDF or printed transcript
        MessageBox.Show("Transcript printing functionality would be implemented here.")
    End Sub
End Class