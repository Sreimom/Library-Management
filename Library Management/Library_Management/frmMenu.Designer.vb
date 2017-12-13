<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnStuManage = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(174, 125)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "បន្តែម​​សៀវភៅ"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(174, 168)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(107, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "ប្រគល់​សៀវភៅ"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnStuManage
        '
        Me.btnStuManage.Location = New System.Drawing.Point(327, 168)
        Me.btnStuManage.Name = "btnStuManage"
        Me.btnStuManage.Size = New System.Drawing.Size(95, 23)
        Me.btnStuManage.TabIndex = 2
        Me.btnStuManage.Text = "គ្រប់គ្រង​សិស្ស"
        Me.btnStuManage.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(327, 125)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "ខ្ចីសៀវភៅ"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 359)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnStuManage)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmMenu"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnStuManage As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
End Class
