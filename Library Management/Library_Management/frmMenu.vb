Public Class frmMenu

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        frmInsert.Show()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        frmBorrow.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmReturn.Show()
    End Sub

    Private Sub btnStuManage_Click(sender As Object, e As EventArgs) Handles btnStuManage.Click
        frmStuManage.Show()
    End Sub
End Class