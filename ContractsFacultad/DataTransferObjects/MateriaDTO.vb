
Imports System.ComponentModel

Namespace DataTransferObject


    Public Class MateriaDTO
        Private _MateriaId As Integer
        Private _Nombre As String
        Private _MateriasLista As BindingList(Of MateriaPrerequisitoDTO)

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

        Public Property MateriasLista As BindingList(Of MateriaPrerequisitoDTO)
            Get
                Return _MateriasLista
            End Get
            Set(value As BindingList(Of MateriaPrerequisitoDTO))
                _MateriasLista = value
            End Set
        End Property
    End Class

End Namespace
