
Namespace DisplayObject


    Public Class EscuelaDisplayObject

        Private _EscuelaId As Integer
        Private _Nombre As String

        Public Property EscuelaId As Integer
            Get
                Return _EscuelaId
            End Get
            Set(value As Integer)
                _EscuelaId = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(value As String)
                _Nombre = value
            End Set
        End Property
    End Class
End Namespace
