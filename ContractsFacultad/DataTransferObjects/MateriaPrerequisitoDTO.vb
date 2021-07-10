Imports System.ComponentModel
Namespace DataTransferObject


    Public Class MateriaPrerequisitoDTO
        Private _MateriaId As Integer
        Private _MateriaIdPrereq As Integer



        Public Property MateriaId As Integer
            Get
                Return _MateriaId
            End Get
            Set(value As Integer)
                _MateriaId = value
            End Set
        End Property

        Public Property MateriaIdPrereq As Integer
            Get
                Return _MateriaIdPrereq
            End Get
            Set(value As Integer)
                _MateriaIdPrereq = value
            End Set
        End Property


    End Class
End Namespace
