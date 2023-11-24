Imports MySql.Data.MySqlClient
Imports System.Configuration
Module Functions
    Public con As String = ConfigurationManager.ConnectionStrings("dbconnections").ConnectionString
    Public SQLCONN As MySqlConnection = New MySqlConnection

    Public Sub save(ByRef SQLSTATEMENT As String)
        SQLCONN.ConnectionString = con
        Try
            If SQLCONN.State = ConnectionState.Closed Then

                SQLCONN.Open()

                Dim cmd As MySqlCommand = New MySqlCommand

                With cmd

                    .CommandText = SQLSTATEMENT
                    .CommandType = CommandType.Text
                    .Connection = SQLCONN
                    .ExecuteNonQuery()

                End With

                SQLCONN.Close()
                SQLCONN.Dispose()

            Else
                Dim cmd As MySqlCommand = New MySqlCommand

                With cmd

                    .CommandText = SQLSTATEMENT
                    .CommandType = CommandType.Text
                    .Connection = SQLCONN
                    .ExecuteNonQuery()

                End With

                SQLCONN.Close()
                SQLCONN.Dispose()


                SQLCONN.Close()
                SQLCONN.Dispose()


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





    End Sub
End Module
