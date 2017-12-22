
Public Class frmMenu

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        frmBook.Show()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        frmBorrow.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmReturn.Show()
    End Sub

    Private Sub btnStuManage_Click(sender As Object, e As EventArgs) Handles btnStuManage.Click
        frmStuMa.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class