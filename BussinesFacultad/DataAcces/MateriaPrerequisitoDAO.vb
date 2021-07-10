Imports ContractsFacultad.Enums
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports System.ComponentModel

Namespace DataAcces

    Public Class MateriaPrerequisitoDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spMateriaRequisitoInsert"
        Const SP_UPDATE = "spMateriaRequisitoUpdate"
        Const SP_DELETE = "spMateriaRequisitoDelete"
        Const SP_GETLIST = "spMateriaRequisitoGetList"
        Const SP_GETLISTMATDISPONIBLE = "spMateriaDisponibleJoin"
        Const SP_GETLISTPREREQUISITO = "spMateriaPrerequisitoJoin"

        Public Sub Insert(ByVal matPre As MateriaPrerequisitoDTO)
            AddParameter(MateriaPrerequisitoEnum.MateriaId.ToString(), matPre.MateriaId)
            AddParameter(MateriaPrerequisitoEnum.MateriaIdprereq.ToString(), matPre.MateriaIdPrereq)


            Excecute(SP_INSERT)
        End Sub
        Public Sub Insert2(ByVal matPre As MateriaPrerequisitoDTO)
            AddParameter(MateriaPrerequisitoEnum.MateriaId.ToString(), matPre.MateriaId)
            AddParameter(MateriaPrerequisitoEnum.MateriaIdprereq.ToString(), matPre.MateriaIdPrereq)


            Excecute(SP_INSERT)
        End Sub
        Public Sub Update(ByVal matPre As MateriaPrerequisitoDTO)
            AddParameter(MateriaPrerequisitoEnum.MateriaIdprereq.ToString(), matPre.MateriaIdPrereq)
            AddParameter(MateriaPrerequisitoEnum.MateriaId.ToString(), matPre.MateriaId)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(MateriaPrerequisitoEnum.MateriaIdprereq.ToString(), id)

            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of MateriaPrerequisitoDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

            Dim matPre As MateriaPrerequisitoDisplayObject
            Dim lista As New BindingList(Of MateriaPrerequisitoDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                matPre = New MateriaPrerequisitoDisplayObject
                matPre.MateriaIdPrereq = renglon(MateriaPrerequisitoEnum.MateriaIdprereq.ToString())
                matPre.MateriaId = renglon(MateriaPrerequisitoEnum.MateriaId.ToString())
                lista.Add(matPre)
            Next

            Return lista
        End Function

        Public Function GetListMateriasDisponibles(ByVal id As Integer) As BindingList(Of MateriaDisplayObject)
            AddParameter(MateriaEnum.MateriaId.ToString(), id)
            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLISTMATDISPONIBLE)

            Dim mat As MateriaDisplayObject
            Dim lista As New BindingList(Of MateriaDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                mat = New MateriaDisplayObject
                mat.MateriaId = renglon(MateriaEnum.MateriaId.ToString())
                mat.Nombre = renglon(MateriaEnum.Nombre.ToString())

                lista.Add(mat)
            Next

            Return lista
        End Function

        Public Function GetListMateriasPrerequisito(ByVal id As Integer) As BindingList(Of MateriaDisplayObject)
            AddParameter(MateriaPrerequisitoEnum.MateriaId.ToString(), id)
            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLISTPREREQUISITO)

            Dim mat As MateriaDisplayObject
            Dim lista As New BindingList(Of MateriaDisplayObject)



            For Each renglon As DataRow In ds.Tables(0).Rows
                mat = New MateriaDisplayObject
                mat.Nombre = renglon(MateriaEnum.Nombre.ToString())
                mat.MateriaId = renglon(MateriaEnum.MateriaId.ToString())
                lista.Add(mat)
            Next

            Return lista
        End Function
    End Class
End Namespace