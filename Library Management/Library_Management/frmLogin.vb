Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim PassChar As Boolean = False
    Dim MysqlConn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.Click
        'If Me.txtUsername.Text = "admin" And txtPaswd.Text = "admin" Then
        '    'MsgBox("You are right !")
        '    Me.Hide()
        '    frmMenu.Show()
        'Else
        '    MsgBox("You are wrong, please try again")
        '    Me.txtUsername.Focus()
        'End If
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=library_management"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from tbl_user where uname='" & txtUsername.Text & "' and pwd='" & txtPaswd.Text & "'"
            cmd = New MySqlCommand(Query, MysqlConn)
            READER = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                frmMenu.Show()
                Me.Hide()
                'MessageBox.Show("Username and password  are correct")
            ElseIf count > 1 Then
                MessageBox.Show("Username and password  are Duplicate")
            Else
                MessageBox.Show("Username and password  are not correct")
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCancel.Click
        Me.Close()
    End Sub

    Private Sub btnShowNHide_Click(sender As Object, e As EventArgs) Handles btnShowNHide.Click
        If PassChar = False Then
            txtPaswd.PasswordChar = ""
            PassChar = True
        Else
            txtPaswd.PasswordChar = "*"
            PassChar = False
        End If

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

    End Sub
End Class
