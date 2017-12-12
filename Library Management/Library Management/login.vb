Public Class login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If Me.txtuser.Text = "admin" And txtpassword.Text = "admin" Then
            'MsgBox("You are right!")
            frmmain.Show()

        Else
            MsgBox("You are wrong, please try again", MsgBoxStyle.Critical)
            Me.txtuser.Focus()

        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim opt As String = MsgBox("Do you want to Close?", vbYesNo)
        If opt = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtuser.Text = "" Then
                MsgBox("Enter User !")
                txtuser.Focus()
            Else
                MsgBox("Enter Password !")
                txtpassword.Focus()
            End If
         End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtpassword.Text = "" Then
                MsgBox("Enter Password !")
                txtpassword.Focus()
            Else
                If Me.txtuser.Text = "admin" And txtpassword.Text = "admin" Then
                    'MsgBox("You are right!")
                    frmmain.Show()
                Else
                    MsgBox("You are wrong, please try again", MsgBoxStyle.Critical)
                    Me.txtuser.Focus()


                End If

            End If
        End If

    End Sub



   



    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown ',MyBase.MouseMove
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub


End Class
