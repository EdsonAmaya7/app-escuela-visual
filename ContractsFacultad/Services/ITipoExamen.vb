
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace Services


    Public Interface ITipoExamen

        Sub Insert(ByVal tipExam As TipoExamenDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal tipExam As TipoExamenDTO)
        Function GetList() As BindingList(Of TipoExamenDisplayObject)
        Function Buscar(ByVal filter As TipoExamenFilter) As BindingList(Of TipoExamenDisplayObject)
    End Interface
End Namespace