Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports System.ComponentModel
Imports ContractsFacultad.Filter

Namespace DataAcces

    Public Class TipoExamenDAO
        Inherits DataAcessObject


        Const SP_INSERT = "spTipoExamenInsert"
        Const SP_UPDATE = "spTipoExamenUpdate"
        Const SP_DELETE = "spTipoExamenDelete"
        Const SP_GETLIST = "spTipoExamenGetList"
        Const SP_BUSCAR = "spTipoExamenBuscar"


        Public Sub Insert(ByVal tipEx As TipoExamenDTO)
            AddParameter(TipoExamenEnum.TipoExamenId.ToString(), tipEx.TipoExamenId)
            AddParameter(TipoExamenEnum.Nombre.ToString(), tipEx.Nombre)
            Excecute(SP_INSERT)
        End Sub
        Public Sub Update(ByVal tipEx As TipoExamenDTO)
            AddParameter(TipoExamenEnum.TipoExamenId.ToString(), tipEx.TipoExamenId)
            AddParameter(TipoExamenEnum.Nombre.ToString(), tipEx.Nombre)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(TipoExamenEnum.TipoExamenId.ToString(), id)
            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of TipoExamenDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

            Dim tipEx As TipoExamenDisplayObject
            Dim lista As New BindingList(Of TipoExamenDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                tipEx = New TipoExamenDisplayObject
                tipEx.TipoExamenId = renglon(TipoExamenEnum.TipoExamenId.ToString())
                tipEx.Nombre = renglon(TipoExamenEnum.Nombre.ToString())
                lista.Add(tipEx)
            Next

            Return lista
        End Function

        Public Function Buscar(ByVal filter As TipoExamenFilter) As BindingList(Of TipoExamenDisplayObject)

            AddParameter(TipoExamenEnum.Nombre, filter.Nombre)


            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_BUSCAR)

            Dim tip As TipoExamenDisplayObject
            Dim lista As New BindingList(Of TipoExamenDisplayObject)


            For Each renglon As DataRow In ds.Tables(0).Rows
                tip = New TipoExamenDisplayObject
                tip.TipoExamenId = renglon(TipoExamenEnum.TipoExamenId.ToString())
                tip.Nombre = renglon(TipoExamenEnum.Nombre.ToString())

                lista.Add(tip)

            Next

            Return lista
        End Function



    End Class
End Namespace