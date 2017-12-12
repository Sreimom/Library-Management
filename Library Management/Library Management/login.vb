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



   
End Class
