Imports System.ComponentModel
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Services

Namespace DomainObjects

    Public Class MateriaPrerequisitoDomainObject
        Implements IMateriaPrerequisito

        Public Sub Insert(matPre As MateriaPrerequisitoDTO) Implements IMateriaPrerequisito.Insert
            Dim dao As New MateriaPrerequisitoDAO
            dao.Insert(matPre)
        End Sub

        Public Sub Delete(id As Integer) Implements IMateriaPrerequisito.Delete
            Dim dao As New MateriaPrerequisitoDAO
            dao.Delete(id)

        End Sub

        Public Sub Update(matPre As MateriaPrerequisitoDTO) Implements IMateriaPrerequisito.Update
            Dim dao As New MateriaPrerequisitoDAO
            dao.Update(matPre)
        End Sub

        Public Sub Insert2(matPre As MateriaPrerequisitoDTO) Implements IMateriaPrerequisito.Insert2
            Dim dao As New MateriaPrerequisitoDAO
            dao.Insert2(matPre)
        End Sub

        Public Function GetList() As BindingList(Of MateriaPrerequisitoDisplayObject) Implements IMateriaPrerequisito.GetList
            Dim dao As New MateriaPrerequisitoDAO
            Return dao.GetList()

        End Function




        Public Function GetMateriasDisponibles(id As Integer) As BindingList(Of MateriaDisplayObject) Implements IMateriaPrerequisito.GetMateriasDisponibles
            Dim dao As New MateriaPrerequisitoDAO
            Return dao.GetListMateriasDisponibles(id)
        End Function

        Public Function GetMateriasPrerequisitos(id As Integer) As BindingList(Of MateriaDisplayObject) Implements IMateriaPrerequisito.GetMateriasPrerequisitos
            Dim dao As New MateriaPrerequisitoDAO
            Return dao.GetListMateriasPrerequisito(id)
        End Function
    End Class
End Namespace
