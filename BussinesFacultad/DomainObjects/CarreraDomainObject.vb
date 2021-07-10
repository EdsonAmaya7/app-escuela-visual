Imports System.ComponentModel
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter
Imports ContractsFacultad.Services

Namespace DomainObjects


    Public Class CarreraDomainObject
        Implements ICarrera

        Public Sub Insert(car As CarreraDTO) Implements ICarrera.Insert
            Dim dao As New CarreraDAO
            dao.Insert(car)
        End Sub

        Public Sub Delete(id As Integer) Implements ICarrera.Delete
            Dim dao As New CarreraDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(car As CarreraDTO) Implements ICarrera.Update
            Dim dao As New CarreraDAO
            dao.Update(car)
        End Sub

        Public Function GetList() As BindingList(Of CarreraDisplayObject) Implements ICarrera.GetList
            Dim dao As New CarreraDAO
            Return dao.GetList()
        End Function

        Public Function Buscar(filter As CarreraFilter) As BindingList(Of CarreraDisplayObject) Implements ICarrera.Buscar
            Dim dao As New CarreraDAO
            Return dao.Buscar(filter)
        End Function

        Public Function GetById(id As Integer) As CarreraDTO Implements ICarrera.GetById
            Dim dao As New CarreraDAO
            Return dao.GetById(id)
        End Function
    End Class
End Namespace