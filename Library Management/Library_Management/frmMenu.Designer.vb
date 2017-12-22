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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pl1 = New System.Windows.Forms.Panel()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnStuManage = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "បញ្ជី"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Pl1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Controls.Add(Me.btnStuManage)
        Me.Panel1.Controls.Add(Me.btnBorrow)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 445)
        Me.Panel1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Library_Management.My.Resources.Resources.icons8_Books_32px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(2, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 39)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "បញ្ជីសៀវភៅ"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Library_Management.My.Resources.Resources.icons8_Exit_32px_2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ចាក​ចេញ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pl1
        '
        Me.Pl1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Pl1.Location = New System.Drawing.Point(209, 76)
        Me.Pl1.Name = "Pl1"
        Me.Pl1.Size = New System.Drawing.Size(6, 38)
        Me.Pl1.TabIndex = 6
        '
        'btnInsert
        '
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInsert.FlatAppearance.BorderSize = 0
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInsert.Image = Global.Library_Management.My.Resources.Resources.icons8_Add_New_32px
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(2, 115)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(210, 38)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "បន្តែម​​សៀវភៅ"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnStuManage
        '
        Me.btnStuManage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStuManage.FlatAppearance.BorderSize = 0
        Me.btnStuManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStuManage.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStuManage.Image = Global.Library_Management.My.Resources.Resources.icons8_Students_32px
        Me.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStuManage.Location = New System.Drawing.Point(2, 156)
        Me.btnStuManage.Name = "btnStuManage"
        Me.btnStuManage.Size = New System.Drawing.Size(210, 38)
        Me.btnStuManage.TabIndex = 2
        Me.btnStuManage.Text = "គ្រប់គ្រង​សិស្ស"
        Me.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStuManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStuManage.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBorrow.FlatAppearance.BorderSize = 0
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.Image = Global.Library_Management.My.Resources.Resources.icons8_Borrow_Book_32px
        Me.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrow.Location = New System.Drawing.Point(2, 239)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(210, 38)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "ខ្ចីសៀវភៅ"
        Me.btnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Image = Global.Library_Management.My.Resources.Resources.icons8_Return_Book_32px
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.Location = New System.Drawing.Point(2, 197)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(210, 38)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "ប្រគល់​សៀវភៅ"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 445)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnStuManage As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pl1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
