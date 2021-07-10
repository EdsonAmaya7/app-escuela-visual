Imports ContractsFacultad.Services
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports System.ComponentModel
Imports ContractsFacultad.DisplayObject

Namespace DomainObjects


    Public Class AlumnoMateriaDomainObject
        Implements IAlumnoMateria

        Public Sub Insert(aluMat As AlumnoMateriaDTO) Implements IAlumnoMateria.Insert
            Dim dao As New AlumnoMateriaDAO
            dao.Insert(aluMat)
        End Sub

        Public Sub Delete(id As Integer) Implements IAlumnoMateria.Delete
            Dim dao As New AlumnoMateriaDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(aluMat As AlumnoMateriaDTO) Implements IAlumnoMateria.Update
            Dim dao As New AlumnoMateriaDAO
            dao.Update(aluMat)
        End Sub

        Public Function GetList() As BindingList(Of AlumnoMateriaDisplayObject) Implements IAlumnoMateria.GetList
            Dim dao As New AlumnoMateriaDAO
            Return dao.GetList()
        End Function
    End Class
End Namespace