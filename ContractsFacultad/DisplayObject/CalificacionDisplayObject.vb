

Namespace DisplayObject


    Public Class CalificacionDisplayObject
        Private _AlumnoMateriaId As Integer
        Private _TipoExamenId As Integer
        Private _Fecha As Date
        Private _Calificacion As Double

        Public Property AlumnoMateriaId As Integer
            Get
                Return _AlumnoMateriaId
            End Get
            Set(value As Integer)
                _AlumnoMateriaId = value
            End Set
        End Property

        Public Property TipoExamenId As Integer
            Get
                Return _TipoExamenId
            End Get
            Set(value As Integer)
                _TipoExamenId = value
            End Set
        End Property

        Public Property Fecha As Date
            Get
                Return _Fecha
            End Get
            Set(value As Date)
                _Fecha = value
            End Set
        End Property

        Public Property Calificacion As Double
            Get
                Return _Calificacion
            End Get
            Set(value As Double)
                _Calificacion = value
            End Set
        End Property
    End Class
End Namespace