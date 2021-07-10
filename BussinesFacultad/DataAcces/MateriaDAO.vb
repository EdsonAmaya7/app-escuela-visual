Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports ContractsFacultad.DisplayObject
Imports System.ComponentModel
Imports ContractsFacultad.Filter

Namespace DataAcces

    Public Class MateriaDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spMateriaInsert"
        Const SP_UPDATE = "spMateriaUpdate"
        Const SP_DELETE = "spMateriaDelete"
        Const SP_GETLIST = "spMateriaGetList"
        Const SP_BUSCAR = "spMateriaBuscar"
        Const SP_GETBYID = "spMateriaGetById"
        Const SP_EXISTE = "spMateriaExiste"
        Public Sub Insert(ByVal mat As MateriaDTO)
            AddParameter(MateriaEnum.MateriaId.ToString(), mat.MateriaId)
            AddParameter(MateriaEnum.Nombre.ToString(), mat.Nombre)
            Excecute(SP_INSERT)
        End Sub

        Public Sub Update(ByVal mat As MateriaDTO)
            AddParameter(MateriaEnum.MateriaId.ToString(), mat.MateriaId)
            AddParameter(MateriaEnum.Nombre.ToString(), mat.Nombre)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(MateriaEnum.MateriaId.ToString(), id)
            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of MateriaDisplayObject)
            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

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

        Public Function Buscar(ByVal filter As MateriaFilter) As BindingList(Of MateriaDisplayObject)

            AddParameter(MateriaEnum.Nombre.ToString(), filter.Nombre)


            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_BUSCAR)

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

        Public Function GetById(ByVal id As Integer) As MateriaDTO
            AddParameter(MateriaEnum.MateriaId.ToString(), id)
            AddOutputParameter(MateriaEnum.Nombre.ToString(), "", DbType.String, 50)


            Excecute(SP_GETBYID)

            Dim obj As New MateriaDTO
            obj.MateriaId = id
            obj.Nombre = CStr(GetParameter(MateriaEnum.Nombre.ToString()).Value)


            Return obj
        End Function

        Public Function Existe(ByVal nombre As String) As Boolean
            AddParameter(MateriaEnum.Nombre.ToString(), nombre)

            Dim ds As DataSet

            ds = ExcetuteResultSet(SP_EXISTE)

            Dim numero As Integer

            numero = CInt(ds.Tables(0).Rows(0)(MateriaEnum.Numero.ToString()))

            Return numero = 1
        End Function







    End Class
End Namespace