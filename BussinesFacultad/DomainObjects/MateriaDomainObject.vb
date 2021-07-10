
Imports ContractsFacultad.Services
Imports BussinesFacultad.DataAcces
Imports ContractsFacultad.DataTransferObject
Imports System.ComponentModel
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter
Imports BussinesFacultad.BussinesRule

Namespace DomainObjects

    Public Class MateriaDomainObject
        Implements IMateria

        Public Sub Insert(mat As MateriaDTO) Implements IMateria.Insert
            Dim servicio As IMateriaPrerequisito
            servicio = New MateriaPrerequisitoDomainObject


            'Dim dao As New MateriaDAO
            'dao.Insert(mat)

            For Each materia As MateriaPrerequisitoDTO In mat.MateriasLista
                Dim PrerequisitoDao As New MateriaPrerequisitoDAO
                materia.MateriaId = mat.MateriaId

                PrerequisitoDao.Insert(materia)
            Next


        End Sub

        Public Sub Delete(id As Integer) Implements IMateria.Delete
            Dim dao As New MateriaDAO
            dao.Delete(id)
        End Sub

        Public Sub Update(mat As MateriaDTO) Implements IMateria.Update
            Dim dao As New MateriaDAO
            dao.Update(mat)
        End Sub

        Public Function GetList() As BindingList(Of MateriaDisplayObject) Implements IMateria.GetList
            Dim dao As New MateriaDAO
            Return dao.GetList()
        End Function

        Public Function Buscar(filter As MateriaFilter) As BindingList(Of MateriaDisplayObject) Implements IMateria.Buscar
            Dim dao As New MateriaDAO
            Return dao.Buscar(filter)
        End Function

        Public Function GetByid(id As Integer) As MateriaDTO Implements IMateria.GetByid
            Dim dao As New MateriaDAO
            Return dao.GetById(id)
        End Function

        Public Sub validate(dto As MateriaDisplayObject)
            Dim regla1 As New NombresRepetidosBussinesRule
            regla1.exist(dto.Nombre)
        End Sub

        Public Function Existe(nombre As String) As Boolean Implements IMateria.Existe
            Dim dao As New MateriaDAO
            Return dao.Existe(nombre)
        End Function
    End Class
End Namespace