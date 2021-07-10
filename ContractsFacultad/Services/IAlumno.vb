Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace Services


    Public Interface IAlumno
        Sub Insert(ByVal alum As AlumnoDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal alum As AlumnoDTO)
        Function GetList() As BindingList(Of AlumnoDisplayObject)
        Function Buscar(ByVal filter As AlumnoFilter) As BindingList(Of AlumnoDisplayObject)
        Function GetById(ByVal id As Integer) As AlumnoDTO
    End Interface
End Namespace