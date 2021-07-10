

Imports System.ComponentModel
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.DisplayObject
Imports ContractsFacultad.Enums
Imports ContractsFacultad.Filter


Namespace DataAcces

    Public Class AlumnoDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spAlumnoInsert"
        Const SP_UPDATE = "spAlumnoUpdate"
        Const SP_DELETE = "spAlumnoDelete"
        Const SP_GETLIST = "spAlumnoGetList"
        Const SP_BUSCAR = "spAlumnoBuscar"
        Const SP_GETBYID = "spAlumnoGetById"

        Public Sub Insert(ByVal alu As AlumnoDTO)
            AddParameter(AlumnoEnum.AlumnoId.ToString(), alu.AlumnoId)
            AddParameter(AlumnoEnum.Matricula.ToString(), alu.Matricula)
            AddParameter(AlumnoEnum.ApPaterno.ToString(), alu.ApPaterno)
            AddParameter(AlumnoEnum.ApMaterno.ToString(), alu.ApMaterno)
            AddParameter(AlumnoEnum.Nombre.ToString(), alu.Nombre)
            AddParameter(AlumnoEnum.CarreraId.ToString(), alu.CarreraId)
            AddParameter(AlumnoEnum.EscuelaId.ToString(), alu.EscuelaId)
            Excecute(SP_INSERT)

        End Sub

        Public Sub Update(ByVal alu As AlumnoDTO)
            AddParameter(AlumnoEnum.AlumnoId.ToString(), alu.AlumnoId)
            AddParameter(AlumnoEnum.Matricula.ToString(), alu.Matricula)
            AddParameter(AlumnoEnum.ApPaterno.ToString(), alu.ApPaterno)
            AddParameter(AlumnoEnum.ApMaterno.ToString(), alu.ApMaterno)
            AddParameter(AlumnoEnum.Nombre.ToString(), alu.Nombre)
            AddParameter(AlumnoEnum.CarreraId.ToString(), alu.CarreraId)
            AddParameter(AlumnoEnum.EscuelaId.ToString(), alu.EscuelaId)
            Excecute(SP_UPDATE)

        End Sub
        Public Sub Delete(ByVal AlumnoId As Integer)
            AddParameter(AlumnoEnum.AlumnoId.ToString(), AlumnoId)
            Excecute(SP_DELETE)

        End Sub
        Public Function GetList() As BindingList(Of AlumnoDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

            Dim alu As AlumnoDisplayObject
            Dim lista As New BindingList(Of AlumnoDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                alu = New AlumnoDisplayObject

                alu.AlumnoId = renglon(AlumnoEnum.AlumnoId.ToString())
                alu.Matricula = renglon(AlumnoEnum.Matricula.ToString())
                alu.ApPaterno = renglon(AlumnoEnum.ApPaterno.ToString())
                alu.ApMaterno = renglon(AlumnoEnum.ApMaterno.ToString())
                alu.Nombre = renglon(AlumnoEnum.Nombre.ToString())
                alu.CarreraId = renglon(AlumnoEnum.CarreraId.ToString())
                alu.EscuelaId = renglon(AlumnoEnum.EscuelaId.ToString())

                lista.Add(alu)

            Next

            Return lista

        End Function

        Public Function Buscar(ByVal filter As AlumnoFilter) As BindingList(Of AlumnoDisplayObject)
            AddParameter(AlumnoEnum.Matricula.ToString(), filter.Matricula)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_BUSCAR)

            Dim alu As AlumnoDisplayObject
            Dim lista As New BindingList(Of AlumnoDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                alu = New AlumnoDisplayObject
                alu.AlumnoId = renglon(AlumnoEnum.AlumnoId.ToString())
                alu.Matricula = renglon(AlumnoEnum.Matricula.ToString())
                alu.ApPaterno = renglon(AlumnoEnum.ApPaterno.ToString())
                alu.ApMaterno = renglon(AlumnoEnum.ApMaterno.ToString())
                alu.Nombre = renglon(AlumnoEnum.Nombre.ToString())
                alu.CarreraId = renglon(AlumnoEnum.CarreraId.ToString())
                alu.EscuelaId = renglon(AlumnoEnum.EscuelaId.ToString())

                lista.Add(alu)

            Next

            Return lista

        End Function

        Public Function GetById(ByVal id As Integer) As AlumnoDTO
            AddParameter(AlumnoEnum.AlumnoId.ToString(), id)

            AddOutputParameter(AlumnoEnum.Matricula.ToString(), "", DbType.Int32, 0)
            AddOutputParameter(AlumnoEnum.ApPaterno.ToString(), "", DbType.String, 50)
            AddOutputParameter(AlumnoEnum.ApMaterno.ToString(), "", DbType.String, 50)
            AddOutputParameter(AlumnoEnum.Nombre.ToString(), "", DbType.String, 50)
            AddOutputParameter(AlumnoEnum.CarreraId.ToString(), "", DbType.Int32, 0)
            AddOutputParameter(AlumnoEnum.EscuelaId.ToString(), "", DbType.Int32, 0)

            Excecute(SP_GETBYID)
            Dim obj As New AlumnoDTO

            obj.CarreraId = id
            obj.Matricula = CStr(GetParameter(AlumnoEnum.Matricula.ToString()).Value)
            obj.ApPaterno = CStr(GetParameter(AlumnoEnum.ApPaterno.ToString()).Value)
            obj.ApMaterno = CStr(GetParameter(AlumnoEnum.ApMaterno.ToString()).Value)
            obj.Nombre = CStr(GetParameter(AlumnoEnum.Nombre.ToString()).Value)
            obj.CarreraId = CStr(GetParameter(AlumnoEnum.CarreraId.ToString()).Value)
            obj.EscuelaId = CStr(GetParameter(AlumnoEnum.EscuelaId.ToString()).Value)

            Return obj


        End Function

    End Class
End Namespace

