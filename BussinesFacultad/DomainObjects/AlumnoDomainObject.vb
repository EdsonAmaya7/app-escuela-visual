Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Services
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.Filter

Namespace DomainObjects


    Public Class AlumnoDomainObject
        Implements IAlumno

        Public Sub Insert(alum As AlumnoDTO) Implements IAlumno.Insert
            Dim dao As New AlumnoDAO
            dao.Insert(alum)
        End Sub

        Public Sub Delete(id As Integer) Implements IAlumno.Delete
            Dim dao As New AlumnoDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(alum As AlumnoDTO) Implements IAlumno.Update
            Dim dao As New AlumnoDAO
            dao.Update(alum)
        End Sub

        Public Function GetList() As BindingList(Of AlumnoDisplayObject) Implements IAlumno.GetList
            Dim dao As New AlumnoDAO
            Return dao.GetList()
        End Function

        Public Function Buscar(filter As AlumnoFilter) As BindingList(Of AlumnoDisplayObject) Implements IAlumno.Buscar
            Dim dao As New AlumnoDAO
            Return dao.Buscar(filter)
        End Function

        Public Function GetById(id As Integer) As AlumnoDTO Implements IAlumno.GetById
            Dim dao As New AlumnoDAO
            Return dao.GetById(id)
        End Function
    End Class
End Namespace