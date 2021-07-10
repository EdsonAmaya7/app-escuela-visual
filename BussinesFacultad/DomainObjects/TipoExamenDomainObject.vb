
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Services
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.Filter

Namespace DomainObjects

    Public Class TipoExamenDomainObject
        Implements ITipoExamen

        Public Sub Insert(tipExam As TipoExamenDTO) Implements ITipoExamen.Insert
            Dim dao As New TipoExamenDAO
            dao.Insert(tipExam)
        End Sub

        Public Sub Delete(id As Integer) Implements ITipoExamen.Delete
            Dim dao As New TipoExamenDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(tipExam As TipoExamenDTO) Implements ITipoExamen.Update
            Dim dao As New TipoExamenDAO
            dao.Update(tipExam)
        End Sub

        Public Function GetList() As BindingList(Of TipoExamenDisplayObject) Implements ITipoExamen.GetList
            Dim dao As New TipoExamenDAO
            Return dao.GetList()
        End Function

        Public Function Buscar(filter As TipoExamenFilter) As BindingList(Of TipoExamenDisplayObject) Implements ITipoExamen.Buscar
            Dim dao As New TipoExamenDAO
            Return dao.Buscar(filter)
        End Function
    End Class
End Namespace