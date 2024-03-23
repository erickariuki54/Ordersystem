<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.createaccount = New System.Windows.Forms.Button()
        Me.fname = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'createaccount
        '
        Me.createaccount.BackColor = System.Drawing.Color.Indigo
        Me.createaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createaccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createaccount.Location = New System.Drawing.Point(216, 227)
        Me.createaccount.Name = "createaccount"
        Me.createaccount.Size = New System.Drawing.Size(385, 33)
        Me.createaccount.TabIndex = 0
        Me.createaccount.Text = "Create Account"
        Me.createaccount.UseVisualStyleBackColor = False
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(213, 39)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(72, 16)
        Me.fname.TabIndex = 1
        Me.fname.Text = "FirstName:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(216, 58)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(385, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(213, 92)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(72, 16)
        Me.lname.TabIndex = 3
        Me.lname.Text = "LastName:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(216, 111)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(385, 22)
        Me.txtLastName.TabIndex = 4
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(213, 136)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(41, 16)
        Me.lbl_email.TabIndex = 5
        Me.lbl_email.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(216, 155)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(385, 22)
        Me.txtEmail.TabIndex = 6
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(213, 180)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(67, 16)
        Me.lbl_pass.TabIndex = 7
        Me.lbl_pass.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(216, 199)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(385, 22)
        Me.txtPassword.TabIndex = 8
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.Lime
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Loginbtn.Location = New System.Drawing.Point(216, 266)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(382, 29)
        Me.Loginbtn.TabIndex = 9
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(804, 390)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.createaccount)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents createaccount As Button
    Friend WithEvents fname As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lname As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbl_pass As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Loginbtn As Button
End Class
