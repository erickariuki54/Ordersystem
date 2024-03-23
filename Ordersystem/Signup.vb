Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Signup
    ' Define your connection string
    ' Retrieve other bookings based on storeduserid
    ' Use relative path for the database file
    Dim dbFilePath As String = Path.Combine(Application.StartupPath, "Fastfoodordersystem.accdb")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};"

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Function IsValidEmail(email As String) As Boolean
        ' Define a regular expression pattern for email validation
        Dim pattern As String = "^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[\w-]+$"

        ' Create a Regex object with the pattern
        Dim regex As New Regex(pattern)

        ' Check if the email matches the pattern
        Return regex.IsMatch(email)
    End Function


    Private Sub createaccount_Click(sender As Object, e As EventArgs) Handles createaccount.Click
        ' Check if any of the input fields are empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please fill in all the fields.")
            Return ' Exit the event handler if any field is empty
        End If
        ' Check if the email is in a valid format
        If Not IsValidEmail(txtEmail.Text) Then
            MsgBox("Please enter a valid email address.")
            Return ' Exit the event handler if the email is invalid
        End If
        Try
            ' Create a new connection using the connection string
            Using connection As New OleDbConnection(connectionString)
                ' Open the connection
                connection.Open()
                Dim firstname As String = txtFirstName.Text
                Dim lastname As String = txtLastName.Text
                Dim email As String = txtEmail.Text
                Dim password As String = txtPassword.Text

                ' Define your SQL INSERT command with parameters
                Dim sql As String = "INSERT INTO users ([Firstname], [Lastname], [Email], [Password]) VALUES (?, ?, ?, ?)"

                ' Create a new command object with the SQL command and connection
                Using command As New OleDbCommand(sql, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@firstname", firstname)
                    command.Parameters.AddWithValue("@lastname", lastname)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)

                    ' Execute the command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        MsgBox("Account created successfully.")
                    Else
                        MsgBox("Failed to create account.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message if something goes wrong
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        ' Create an instance of the login form
        Dim loginForm As New Login()

        ' Show the login form
        loginForm.Show()
        Me.Hide()

    End Sub
    Private Sub Signup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the form is being closed by the user
        If e.CloseReason = CloseReason.UserClosing Then
            ' Hide the login form instead of closing

            Application.Exit() 'to close the whole application
        End If
    End Sub

End Class
