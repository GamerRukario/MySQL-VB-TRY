Imports MySql.DATA.MySqlClient
Public Class Form1
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlConnection
    Dim sqlQuery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "9876test"
    Dim database As String = "test_db"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub updateTable()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database = " + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * FROM testTable"
        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            name_tb.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            age_tb.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        Catch ex As Exception
            MsgBox("bad")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles add.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database = " + database
        Try
            sqlConn.Open()
            sqlCmd.Connection = sqlConn
            sqlQuery = "Insert into testTable(name,age) VALUES ('" & name_tb.Text & "','" & age_tb.Text & "')"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch
            MsgBox("error")
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub


    Private Sub name_tb_TextChanged(sender As Object, e As EventArgs) Handles name_tb.TextChanged

    End Sub

    Private Sub age_tb_TextChanged(sender As Object, e As EventArgs) Handles age_tb.TextChanged

    End Sub

    Private Sub delete_bt_Click(sender As Object, e As EventArgs) Handles delete_bt.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database = " + database
        Try
            sqlConn.Open()
            sqlCmd.Connection = sqlConn
            sqlQuery = "DELETE FROM testTable where name = '" & name_tb.Text & "' AND age = '" & age_tb.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch
            MsgBox("error")
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub
End Class
