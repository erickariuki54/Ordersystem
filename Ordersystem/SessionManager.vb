Public Class SessionManager
    Private Shared _instance As SessionManager
    Public Shared ReadOnly Property Instance As SessionManager
        Get
            If _instance Is Nothing Then
                _instance = New SessionManager()
            End If
            Return _instance
        End Get
    End Property

    Private _username As String
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Private _firstname As String
    Public Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Private _lastname As String
    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property
    Private _userid As String
    Public Property Userid As String
        Get
            Return _userid
        End Get
        Set(value As String)
            _userid = value
        End Set
    End Property
End Class
