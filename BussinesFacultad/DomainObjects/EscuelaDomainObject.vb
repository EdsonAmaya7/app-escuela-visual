Imports System.ComponentModel
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter
Imports ContractsFacultad.Services

Namespace DomainObjects



    Public Class EscuelaDomainObject
        Implements IEscuela

        Public Sub Insert(esc As EscuelaDTO) Implements IEscuela.Insert
            Dim dao As New EscuelaDAO
            dao.Insert(esc)
        End Sub

        Public Sub Delete(id As Integer) Implements IEscuela.Delete
            Dim dao As New EscuelaDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(esc As EscuelaDTO) Implements IEscuela.Update
            Dim dao As New EscuelaDAO
            dao.Update(esc)
        End Sub

        Public Function GetList() As BindingList(Of EscuelaDisplayObject) Implements IEscuela.GetList
            Dim dao As New EscuelaDAO
            Return dao.GetList()
        End Function

        Public Function Buscar(filter As EscuelaFilter) As BindingList(Of EscuelaDisplayObject) Implements IEscuela.Buscar
            Dim dao As New EscuelaDAO
            Return dao.Buscar(filter)
        End Function

        Public Function GetById(id As Integer) As EscuelaDTO Implements IEscuela.GetById
            Dim dao As New EscuelaDAO
            Return dao.GetById(id)
        End Function
    End Class
End Namespace