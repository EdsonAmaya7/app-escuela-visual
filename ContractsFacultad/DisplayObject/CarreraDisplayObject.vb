
Namespace DisplayObject


    Public Class CarreraDisplayObject
        Private _CarreraId As Integer
        Private _Nombre As String

        Public Property CarreraId As Integer
            Get
                Return _CarreraId
            End Get
            Set(value As Integer)
                _CarreraId = value
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