<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.user = New System.Windows.Forms.Label()
        Me.Library = New System.Windows.Forms.Label()
        Me.FastfoodordersystemDataSet1 = New Ordersystem.FastfoodordersystemDataSet1()
        Me.FastfoodordersystemDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Ordersystem.FastfoodordersystemDataSet1TableAdapters.usersTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblbooking = New System.Windows.Forms.Label()
        CType(Me.FastfoodordersystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastfoodordersystemDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(332, 49)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(74, 16)
        Me.user.TabIndex = 0
        Me.user.Text = "Welcome , "
        Me.user.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Library
        '
        Me.Library.AutoSize = True
        Me.Library.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Library.Location = New System.Drawing.Point(322, 22)
        Me.Library.Name = "Library"
        Me.Library.Size = New System.Drawing.Size(199, 17)
        Me.Library.TabIndex = 1
        Me.Library.Text = "Velvet Library Booking"
        '
        'FastfoodordersystemDataSet1
        '
        Me.FastfoodordersystemDataSet1.DataSetName = "FastfoodordersystemDataSet1"
        Me.FastfoodordersystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FastfoodordersystemDataSet1BindingSource
        '
        Me.FastfoodordersystemDataSet1BindingSource.DataSource = Me.FastfoodordersystemDataSet1
        Me.FastfoodordersystemDataSet1BindingSource.Position = 0
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.FastfoodordersystemDataSet1
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(382, 321)
        Me.DataGridView1.TabIndex = 2
        '
        'lblbooking
        '
        Me.lblbooking.AutoSize = True
        Me.lblbooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbooking.Location = New System.Drawing.Point(145, 67)
        Me.lblbooking.Name = "lblbooking"
        Me.lblbooking.Size = New System.Drawing.Size(119, 20)
        Me.lblbooking.TabIndex = 3
        Me.lblbooking.Text = "my booking record"
        Me.lblbooking.UseCompatibleTextRendering = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblbooking)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Library)
        Me.Controls.Add(Me.user)
        Me.Name = "main"
        Me.Text = "Mainpage"
        CType(Me.FastfoodordersystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastfoodordersystemDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user As Label
    Friend WithEvents Library As Label
    Friend WithEvents FastfoodordersystemDataSet1BindingSource As BindingSource
    Friend WithEvents FastfoodordersystemDataSet1 As FastfoodordersystemDataSet1
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As FastfoodordersystemDataSet1TableAdapters.usersTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblbooking As Label
End Class
