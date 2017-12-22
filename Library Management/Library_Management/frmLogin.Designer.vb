<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPaswd As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.Button
    Friend WithEvents txtCancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPaswd = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.Button()
        Me.txtCancel = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnShowNHide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(28, 40)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(101, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(93, 42)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(142, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPaswd
        '
        Me.txtPaswd.Location = New System.Drawing.Point(93, 84)
        Me.txtPaswd.Name = "txtPaswd"
        Me.txtPaswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPaswd.Size = New System.Drawing.Size(142, 20)
        Me.txtPaswd.TabIndex = 3
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(93, 135)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(60, 23)
        Me.txtLogin.TabIndex = 4
        Me.txtLogin.Text = "&OK"
        '
        'txtCancel
        '
        Me.txtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.txtCancel.Location = New System.Drawing.Point(172, 135)
        Me.txtCancel.Name = "txtCancel"
        Me.txtCancel.Size = New System.Drawing.Size(59, 23)
        Me.txtCancel.TabIndex = 5
        Me.txtCancel.Text = "&Cancel"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(28, 83)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(63, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 164)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(79, 23)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        '
        'btnShowNHide
        '
        Me.btnShowNHide.Location = New System.Drawing.Point(241, 84)
        Me.btnShowNHide.Name = "btnShowNHide"
        Me.btnShowNHide.Size = New System.Drawing.Size(26, 20)
        Me.btnShowNHide.TabIndex = 7
        Me.btnShowNHide.Text = "..."
        Me.btnShowNHide.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.txtLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.txtCancel
        Me.ClientSize = New System.Drawing.Size(290, 192)
        Me.Controls.Add(Me.btnShowNHide)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtCancel)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtPaswd)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnShowNHide As System.Windows.Forms.Button

End Class
