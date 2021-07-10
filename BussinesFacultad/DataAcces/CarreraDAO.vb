
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports ContractsFacultad.DisplayObject
Imports System.ComponentModel
Imports ContractsFacultad.Filter

Namespace DataAcces

    Public Class CarreraDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spCarreraInsert"
        Const SP_UPDATE = "spCarreraUpdate"
        Const SP_DELETE = "spCarreraDelete"
        Const SP_GETLIST = "spCarreraGetList"
        Const SP_BUSCAR = "spCarreraBuscar"
        Const SP_GETBYID = "spCarreraById"

        Public Sub Insert(ByVal car As CarreraDTO)
            'AddParameter(CarreraEnum.CarreraId.ToString(), car.CarreraId)
            AddParameter(CarreraEnum.Nombre.ToString(), car.Nombre)
            Excecute(SP_INSERT)
        End Sub

        Public Sub Update(ByVal car As CarreraDTO)
            AddParameter(CarreraEnum.CarreraId.ToString(), car.CarreraId)
            AddParameter(CarreraEnum.Nombre.ToString(), car.Nombre)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(CarreraEnum.CarreraId.ToString(), id)
            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of CarreraDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)
            Dim car As CarreraDisplayObject
            Dim lista As New BindingList(Of CarreraDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                car = New CarreraDisplayObject
                car.CarreraId = renglon(CarreraEnum.CarreraId.ToString())
                car.Nombre = renglon(CarreraEnum.Nombre.ToString())
                lista.Add(car)
            Next
            Return lista
        End Function

        Public Function Buscar(ByVal filter As CarreraFilter) As BindingList(Of CarreraDisplayObject)
            AddParameter(CarreraEnum.Nombre.ToString(), filter.Nombre)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_BUSCAR)
            Dim lista As New BindingList(Of CarreraDisplayObject)
            Dim car As CarreraDisplayObject
            For Each renglon As DataRow In ds.Tables(0).Rows
                car = New CarreraDisplayObject
                car.CarreraId = renglon(CarreraEnum.CarreraId.ToString())
                car.Nombre = renglon(CarreraEnum.Nombre.ToString())
                lista.Add(car)

            Next

            Return lista

        End Function

        Public Function GetById(ByVal id As Integer) As CarreraDTO
            AddParameter(CarreraEnum.CarreraId.ToString(), id)
            AddOutputParameter(CarreraEnum.Nombre.ToString(), "", DbType.String, 100)

            Excecute(SP_GETBYID)
            Dim obj As New CarreraDTO

            obj.CarreraId = id
            obj.Nombre = CStr(GetParameter(CarreraEnum.Nombre.ToString()).Value)

            Return obj


        End Function
    End Class
End Namespace

