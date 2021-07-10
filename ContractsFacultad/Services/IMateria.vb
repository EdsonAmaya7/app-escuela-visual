
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace Services


    Public Interface IMateria
        Sub Insert(ByVal mat As MateriaDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal mat As MateriaDTO)
        Function GetList() As BindingList(Of MateriaDisplayObject)
        Function Buscar(ByVal filter As MateriaFilter) As BindingList(Of MateriaDisplayObject)
        Function GetByid(ByVal id As Integer) As MateriaDTO
        Function Existe(ByVal nombre As String) As Boolean
    End Interface

End Namespace