
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace Services


    Public Interface ICarrera
        Sub Insert(ByVal car As CarreraDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal car As CarreraDTO)
        Function GetList() As BindingList(Of CarreraDisplayObject)
        Function Buscar(ByVal filter As CarreraFilter) As BindingList(Of CarreraDisplayObject)
        Function GetById(ByVal id As Integer) As CarreraDTO
    End Interface
End Namespace