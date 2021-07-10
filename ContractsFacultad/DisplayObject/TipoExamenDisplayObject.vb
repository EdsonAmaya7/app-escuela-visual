Namespace DisplayObject


    Public Class TipoExamenDisplayObject
        Private _TipoExamenId As Integer
        Private _Nombre As String

        Public Property TipoExamenId As Integer
            Get
                Return _TipoExamenId
            End Get
            Set(value As Integer)
                _TipoExamenId = value
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