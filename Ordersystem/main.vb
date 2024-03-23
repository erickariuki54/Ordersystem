Imports System.IO
Imports System.Data.OleDb ' Import the OleDb namespace

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ' Adding username to label
        Dim storedUserId As String = SessionManager.Instance.Userid
        Dim storedUsername As String = SessionManager.Instance.Username
        Dim storedFirstname As String = SessionManager.Instance.Firstname
        Dim storedLastname As String = SessionManager.Instance.Lastname
        user.Text += storedFirstname + " " + storedLastname

        ' Retrieve other bookings based on storeduserid
        ' Use relative path for the database file
        Dim dbFilePath As String = Path.Combine(Application.StartupPath, "Fastfoodordersystem.accdb")
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath};"
        Dim query As String = "SELECT Booktitle, Datetime FROM Users_borrowings WHERE userid = ?"

        Try
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@userid", storedUserId)

                    ' Create a DataTable to hold the retrieved data
                    Dim dataTable As New DataTable()

                    ' Add a column for serial numbers
                    Dim serialColumn As New DataColumn("S/No", GetType(Integer))
                    dataTable.Columns.Add(serialColumn)

                    ' Execute the query and fill the DataTable
                    Using adapter As New OleDbDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using

                    ' Add serial numbers to each row
                    For i As Integer = 0 To dataTable.Rows.Count - 1
                        dataTable.Rows(i)("S/No") = i + 1
                    Next

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if something goes wrong with database query
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class
