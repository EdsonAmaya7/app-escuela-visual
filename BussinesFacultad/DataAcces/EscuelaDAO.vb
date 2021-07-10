
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports System.ComponentModel
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Filter

Namespace DataAcces


    Public Class EscuelaDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spEscuelaInsert"
        Const SP_DELETE = "spEscuelaDelete"
        Const SP_UPDATE = "spEscuelaUpdate"
        Const SP_GETLIST = "spEscuelaGetList"
        Const SP_BUSCAR = "spEscuelaBuscar"
        Const SP_GETBYID = "spEscuelaGetById"

        Public Sub Insert(ByVal esc As EscuelaDTO)
            AddParameter(EscuelaEnum.EscuelaId.ToString(), esc.EscuelaId)
            AddParameter(EscuelaEnum.Nombre.ToString(), esc.Nombre)
            Excecute(SP_INSERT)

        End Sub
        Public Sub Update(ByVal esc As EscuelaDTO)
            AddParameter(EscuelaEnum.EscuelaId.ToString(), esc.EscuelaId)
            AddParameter(EscuelaEnum.Nombre.ToString(), esc.Nombre)
            Excecute(SP_UPDATE)

        End Sub
        Public Sub Delete(ByVal id As Integer)
            AddParameter(EscuelaEnum.EscuelaId.ToString(), id)
            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of EscuelaDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

            Dim esc As EscuelaDisplayObject
            Dim lista As New BindingList(Of EscuelaDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                esc = New EscuelaDisplayObject
                esc.EscuelaId = renglon(EscuelaEnum.EscuelaId.ToString())
                esc.Nombre = renglon(EscuelaEnum.Nombre.ToString())
                lista.Add(esc)
            Next

            Return lista
        End Function

        Public Function Buscar(ByVal filter As EscuelaFilter) As BindingList(Of EscuelaDisplayObject)

            AddParameter(EscuelaEnum.Nombre.ToString(), filter.Nombre)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_BUSCAR)

            Dim lista As New BindingList(Of EscuelaDisplayObject)

            Dim esc As EscuelaDisplayObject

            For Each renglon As DataRow In ds.Tables(0).Rows
                esc = New EscuelaDisplayObject
                esc.Nombre = renglon(EscuelaEnum.Nombre.ToString())
                esc.EscuelaId = renglon(EscuelaEnum.EscuelaId.ToString())
                lista.Add(esc)
            Next

            Return lista
        End Function

        Public Function GetById(ByVal id As Integer) As EscuelaDTO
            AddParameter(EscuelaEnum.EscuelaId.ToString(), id)
            AddOutputParameter(EscuelaEnum.Nombre.ToString(), "", DbType.String, 50)

            Excecute(SP_GETBYID)

            Dim obj As New EscuelaDTO


            obj.EscuelaId = id

            obj.Nombre = CStr(GetParameter(EscuelaEnum.Nombre.ToString()).Value)

            Return obj

        End Function





    End Class
End Namespace