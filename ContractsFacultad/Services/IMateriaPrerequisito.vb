
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject

Namespace Services

    Public Interface IMateriaPrerequisito

        Sub Insert(ByVal matPre As MateriaPrerequisitoDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal matPre As MateriaPrerequisitoDTO)
        Function GetList() As BindingList(Of MateriaPrerequisitoDisplayObject)
        Function GetMateriasDisponibles(ByVal id As Integer) As BindingList(Of MateriaDisplayObject)
        Function GetMateriasPrerequisitos(ByVal id As Integer) As BindingList(Of MateriaDisplayObject)
        Sub Insert2(ByVal matPre As MateriaPrerequisitoDTO)
    End Interface
End Namespace