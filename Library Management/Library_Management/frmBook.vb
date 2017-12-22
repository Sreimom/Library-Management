Imports MySql.Data.MySqlClient

Public Class frmBook
    Dim MysqlConn As MySqlConnection
    'Dim cmd As MySqlCommand
    Dim READER As MySqlDataReader



    Private Sub LVBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVBook.SelectedIndexChanged
        'LVBook.Items.Clear()
        'Try
        '    conn = New MySqlConnection
        '    conn.ConnectionString = My.Settings.Conn
        '    conn.Open()
        '    Dim sql As String
        '    sql = "SELECT user_id,FName,LName,Gender,BOD,Email,Province,Phone,Salary FROM tbl_users"
        '    cmd = New MySqlCommand(sql, conn)
        '    dr = cmd.ExecuteReader
        '    Dim list As ListViewItem
        '    Do While dr.Read = True
        '        list = New ListViewItem(dr(0).ToString)
        '        list.SubItems.Add(dr(1))
        '        list.SubItems.Add(dr(2))
        '        list.SubItems.Add(dr(3))
        '        list.SubItems.Add(dr(4))
        '        list.SubItems.Add(dr(5))
        '        list.SubItems.Add(dr(6))
        '        LVBook.Items.Add(list)
        '    Loop
        'Catch ex As MySqlException
        '    conn.Close()
        '    MsgBox(ex.Message)
        '    Exit Try

        'Finally
        '    conn.Close()
        '    dr.Close()
        'End Try
    End Sub

    Private Sub txtAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=library_management"
        Try

            MysqlConn.Open()
            Dim Query As String

            Query = "insert into tbl_book (b_id, bname, description, year, author, type) values ('" & txtID.Text & "','" & txtDesc.Text & "','" & txtBook.Text & "','" & txtDesc.Text & "','" & txtAuthor.Text & "','" & txtType.Text & "')"

            'Query = "INSERT INTO table_Name (F1,F2,F3,F4,...,Fn) Value(" & txtFName.Text & ",'" & txtFName.Text & "','" & txtFName.Text & "')"


            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class