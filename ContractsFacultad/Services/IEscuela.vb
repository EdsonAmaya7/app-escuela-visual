
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace Services

    Public Interface IEscuela

        Sub Insert(ByVal esc As EscuelaDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal esc As EscuelaDTO)
        Function GetList() As BindingList(Of EscuelaDisplayObject)
        Function Buscar(ByVal filter As EscuelaFilter) As BindingList(Of EscuelaDisplayObject)
        Function GetById(ByVal id As Integer) As EscuelaDTO
    End Interface

End Namespace