<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.លេខសំងាត់ = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(167, 164)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(105, 34)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "ចូលប្រើប្រាស់"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(139, 50)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(178, 26)
        Me.txtUser.TabIndex = 2
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(139, 105)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(178, 26)
        Me.txtPwd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "អ្នកប្រើ :"
        '
        'លេខសំងាត់
        '
        Me.លេខសំងាត់.AutoSize = True
        Me.លេខសំងាត់.Location = New System.Drawing.Point(41, 105)
        Me.លេខសំងាត់.Name = "លេខសំងាត់"
        Me.លេខសំងាត់.Size = New System.Drawing.Size(98, 27)
        Me.លេខសំងាត់.TabIndex = 5
        Me.លេខសំងាត់.Text = "លេខសំងាត់ :"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 219)
        Me.Controls.Add(Me.លេខសំងាត់)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Khmer OS Muol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmLogin"
        Me.Text = "ចូលប្រើប្រាស់"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents លេខសំងាត់ As System.Windows.Forms.Label

End Class
