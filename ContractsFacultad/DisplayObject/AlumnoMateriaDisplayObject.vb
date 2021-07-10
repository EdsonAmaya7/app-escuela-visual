
Namespace DisplayObject


    Public Class AlumnoMateriaDisplayObject


        Private _AlumnoMateriaId As Integer
        Private _AlumnoId As Integer
        Private _MateriaId As Integer

        Public Property AlumnoMateriaId As Integer
            Get
                Return _AlumnoMateriaId
            End Get
            Set(value As Integer)
                _AlumnoMateriaId = value
            End Set
        End Property

        Public Property AlumnoId As Integer
            Get
                Return _AlumnoId
            End Get
            Set(value As Integer)
                _AlumnoId = value
            End Set
        End Property

        Public Property MateriaId As Integer
            Get
                Return _MateriaId
            End Get
            Set(value As Integer)
                _MateriaId = value
            End Set

        End Property

    End Class
End Namespace



