Imports YourNamespace.LogsNamespace ' Replace with your actual namespaces

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private loginAttempts As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredUsername As String = TextBox1.Text ' Get the entered username
        Dim enteredPassword As String = TextBox2.Text ' Get the entered password

        If enteredUsername = "Admin" AndAlso enteredPassword = "Password" Then
            ' If correct, show Form2 and reset the login attempts.
            Form2.Show()
            Me.Visible = False
            loginAttempts = 0

            ' Log the username in the "Logs.vb" form.
            Logs.LogUsername(enteredUsername)
        Else
            ' If incorrect, display a warning message.
            MessageBox.Show("Incorrect username or password. You have " & (3 - loginAttempts) & " attempts left.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            loginAttempts += 1

            ' Check if the maximum login attempts (3) have been reached.
            If loginAttempts >= 3 Then
                MessageBox.Show("Maximum login attempts reached. Application will now exit.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit() ' Terminate the application after 3 failed attempts.
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registration.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Forgot.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Logs.Show()
        Me.Visible = False
    End Sub
End Class
