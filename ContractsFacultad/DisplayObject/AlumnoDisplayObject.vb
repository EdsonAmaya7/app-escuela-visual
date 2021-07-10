
Namespace DisplayObject


    Public Class AlumnoDisplayObject
        Private _AlumnoId As Integer
        Private _Matricula As Integer
        Private _ApMaterno As String
        Private _ApPaterno As String
        Private _nombre As String
        Private _CarreraId As Integer
        Private _EscuelaId As Integer

        Public Property AlumnoId As Integer
            Get
                Return _AlumnoId
            End Get
            Set(value As Integer)
                _AlumnoId = value
            End Set
        End Property

        Public Property Matricula As Integer
            Get
                Return _Matricula
            End Get
            Set(value As Integer)
                _Matricula = value
            End Set
        End Property

        Public Property ApMaterno As String
            Get
                Return _ApMaterno
            End Get
            Set(value As String)
                _ApMaterno = value
            End Set
        End Property

        Public Property ApPaterno As String
            Get
                Return _ApPaterno
            End Get
            Set(value As String)
                _ApPaterno = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property CarreraId As Integer
            Get
                Return _CarreraId
            End Get
            Set(value As Integer)
                _CarreraId = value
            End Set
        End Property

        Public Property EscuelaId As Integer
            Get
                Return _EscuelaId
            End Get
            Set(value As Integer)
                _EscuelaId = value
            End Set
        End Property
    End Class
End Namespace