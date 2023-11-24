Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Logs
    ' ...

    ' Method to update the DataGridView or UI element with the database logs.
    Private Sub UpdateDataGridView()
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;database=my_database;user id=root;password=your_password")
                connection.Open()

                ' Create a SQL query to retrieve logs from the database.
                Dim query As String = "SELECT timestamp, username FROM logged_users"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Clear any existing rows in the DataGridView.
                        DataGridView1.Rows.Clear()

                        ' Loop through the results and add them to the DataGridView.
                        While reader.Read()
                            DataGridView1.Rows.Add(reader("timestamp"), reader("username"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations.
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Display the Logs form with the DataGridView populated with database logs.
        UpdateDataGridView()
        Me.Show()
    End Sub
End Class
