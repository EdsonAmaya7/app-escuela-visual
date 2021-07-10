
Namespace DisplayObject


    Public Class MateriaDisplayObject

        Private _MateriaId As Integer
        Private _Nombre As String

        Public Property MateriaId As Integer
            Get
                Return _MateriaId
            End Get
            Set(value As Integer)
                _MateriaId = value
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