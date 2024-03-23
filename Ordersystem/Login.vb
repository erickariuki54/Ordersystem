Imports System.IO
Imports System.Data.OleDb

Public Class Login
    Dim usernamestored As New SessionManager()
    ' Define your connection string
    ' Retrieve other bookings based on storeduserid
    ' Use relative path for the database file
    Dim dbFilePath As String = Path.Combine(Application.StartupPath, "Fastfoodordersystem.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Get the relative path to the image folder
            Dim imagePath As String = Path.Combine(Application.StartupPath, "assets\login.jpg")
            ' Load the image
            Me.BackgroundImage = Image.FromFile(imagePath)
            Me.BackgroundImageLayout = ImageLayout.Stretch ' Adjust the image layout as needed
            Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Fixed border style
            Me.MaximizeBox = False ' Disable maximize button
            Me.MinimizeBox = False ' Disable minimize button
        Catch ex As Exception
            MsgBox("Error loading background image: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the form is being closed by the user
        If e.CloseReason = CloseReason.UserClosing Then
            ' Hide the login form instead of closing

            Application.Exit() 'to close the whole application
        End If
    End Sub

    Private Sub Signup_Click(sender As Object, e As EventArgs) Handles Signup.Click
        ' Create an instance of the login form
        Dim SignupForm As New Signup()

        ' Show the login form
        SignupForm.Show()
        Me.Hide()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse
           String.IsNullOrWhiteSpace(txtpassword.Text) Then
            MsgBox("Please fill in all the fields.")
            Return ' Exit the event handler if any field is empty
        End If
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        ' Create a connection to the database
        Using connection As New OleDbConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Define the SQL query to retrieve the user with the given email
                Dim sql As String = "SELECT * FROM users WHERE Email = ?"

                ' Create a command object with the SQL query and connection
                Using command As New OleDbCommand(sql, connection)
                    ' Add parameter for email
                    command.Parameters.AddWithValue("@Email", username)

                    ' Execute the query
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        ' Check if any rows were returned
                        If reader.Read() Then
                            ' If the user exists, check the password
                            Dim storedPassword As String = reader("Password").ToString()
                            Dim fname As String = reader("Firstname").ToString()
                            Dim lname As String = reader("Lastname").ToString()
                            Dim userid As String = reader("ID").ToString()

                            ' Validate the password
                            If password = storedPassword Then
                                SessionManager.Instance.Username = username
                                SessionManager.Instance.Firstname = fname
                                SessionManager.Instance.Lastname = lname
                                SessionManager.Instance.Userid = userid

                                MsgBox("Login successful!")
                                Dim userdash As New main()
                                userdash.Show()
                                Me.Hide()


                            Else
                                MsgBox("Incorrect password!")
                            End If
                        Else
                            MsgBox("Account does not exist!")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Display an error message if something goes wrong
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub
End Class