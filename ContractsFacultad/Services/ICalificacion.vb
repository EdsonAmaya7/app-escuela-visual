
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject

Namespace Services



    Public Interface ICalificacion
        Sub Insert(ByVal cal As CalificacionDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal cal As CalificacionDTO)
        Function GetList() As BindingList(Of CalificacionDisplayObject)


    End Interface
End Namespace
