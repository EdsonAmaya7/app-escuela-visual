Imports ContractsFacultad.Services
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports System.ComponentModel
Imports ContractsFacultad.DisplayObject

Namespace DomainObjects



    Public Class CalificacionDomainObject
        Implements ICalificacion

        Public Sub Insert(cal As CalificacionDTO) Implements ICalificacion.Insert
            Dim dao As New CalificacionDAO
            dao.Insert(cal)
        End Sub

        Public Sub Delete(id As Integer) Implements ICalificacion.Delete
            Dim dao As New CalificacionDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(cal As CalificacionDTO) Implements ICalificacion.Update
            Dim dao As New CalificacionDAO
            dao.Update(cal)
        End Sub

        Public Function GetList() As BindingList(Of CalificacionDisplayObject) Implements ICalificacion.GetList
            Dim dao As New CalificacionDAO
            Return dao.GetList()
        End Function
    End Class
End Namespace