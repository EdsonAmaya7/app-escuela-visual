
Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject

Namespace Services


    Public Interface IAlumnoMateria

        Sub Insert(ByVal aluMat As AlumnoMateriaDTO)
        Sub Delete(ByVal id As Integer)
        Sub Update(ByVal aluMat As AlumnoMateriaDTO)
        Function GetList() As BindingList(Of AlumnoMateriaDisplayObject)


    End Interface
End Namespace
