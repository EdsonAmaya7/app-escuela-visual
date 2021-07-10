Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports ContractsFacultad.DisplayObject
Imports System.ComponentModel
Namespace DataAcces


    Public Class CalificacionDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spCalificacionInsert"
        Const SP_UPDATE = "spCalificacionUpdate"
        Const SP_DELETE = "spCalificacionDelete"
        Const SP_GETLIST = "spCalificacionGetList"

        Public Sub Insert(ByVal cal As CalificacionDTO)
            AddParameter(CalificacionEnum.AlumnoMateriaId.ToString(), cal.AlumnoMateriaId)
            AddParameter(CalificacionEnum.Calificacion.ToString(), cal.Calificacion)
            AddParameter(CalificacionEnum.Fecha.ToString(), cal.Fecha)
            AddParameter(CalificacionEnum.TipoExamenId.ToString(), cal.TipoExamenId)
            Excecute(SP_INSERT)
        End Sub

        Public Sub Update(ByVal cal As CalificacionDTO)
            AddParameter(CalificacionEnum.AlumnoMateriaId.ToString(), cal.AlumnoMateriaId)
            AddParameter(CalificacionEnum.Calificacion.ToString(), cal.Calificacion)
            AddParameter(CalificacionEnum.Fecha.ToString(), cal.Fecha)
            AddParameter(CalificacionEnum.TipoExamenId.ToString(), cal.TipoExamenId)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(CalificacionEnum.AlumnoMateriaId.ToString(), id)

            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of CalificacionDisplayObject)

            Dim ds As DataSet
            ds = ExcetuteResultSet(SP_GETLIST)

            Dim cal As CalificacionDisplayObject
            Dim lista As New BindingList(Of CalificacionDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                cal = New CalificacionDisplayObject
                cal.AlumnoMateriaId = renglon(CalificacionEnum.AlumnoMateriaId.ToString())
                cal.Calificacion = renglon(CalificacionEnum.Calificacion.ToString())
                cal.Fecha = renglon(CalificacionEnum.Fecha.ToString())
                cal.TipoExamenId = renglon(CalificacionEnum.TipoExamenId.ToString())
                lista.Add(cal)
            Next
            Return lista
        End Function

    End Class
End Namespace
