<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Signup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Blue
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.loginbtn.Location = New System.Drawing.Point(293, 232)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(237, 28)
        Me.loginbtn.TabIndex = 0
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(290, 126)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(84, 16)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "Username:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(290, 178)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(76, 16)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(293, 145)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(237, 22)
        Me.txtusername.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(293, 200)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(237, 22)
        Me.txtpassword.TabIndex = 4
        '
        'Signup
        '
        Me.Signup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Signup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup.Location = New System.Drawing.Point(293, 266)
        Me.Signup.Name = "Signup"
        Me.Signup.Size = New System.Drawing.Size(237, 29)
        Me.Signup.TabIndex = 5
        Me.Signup.Text = "Signup"
        Me.Signup.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Signup)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.loginbtn)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Signup As Button
End Class
