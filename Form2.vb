Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Form2
    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim SQLSTATEMENT As String = "SELECT * FROM `user`"
        SearchedRec(SQLSTATEMENT)
    End Sub

    Public Sub SearchedRec(ByRef SQLSTATEMENT As String)
        SQLCONN.ConnectionString = con
        SQLCONN.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim MyCommand As New MySqlCommand(SQLSTATEMENT, SQLCONN)
        Dim myDataAdapter As New MySqlDataAdapter(SQLSTATEMENT, SQLCONN)
        myDataAdapter.Fill(dt)
        Dim count As Integer = dt.Rows.Count
        If count = 0 Then

            SQLCONN.Close()
            SQLCONN.Dispose()
            DataGridView1.DataSource = Nothing
            Exit Sub
        Else
            myDataAdapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            SQLCONN.Close()
            SQLCONN.Dispose()

        End If

        SQLCONN.Close()
        SQLCONN.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Visible = False
    End Sub
End Class