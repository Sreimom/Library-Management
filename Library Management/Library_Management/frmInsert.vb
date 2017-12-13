Public Class frmInsert
    
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim i As ListViewItem
        i = LVBook.Items.Add(txtID.Text)
        i.SubItems.Add(txtBook.Text)
        i.SubItems.Add(txtYear.Text)
        i.SubItems.Add(txtAuthor.Text)
    End Sub


End Class