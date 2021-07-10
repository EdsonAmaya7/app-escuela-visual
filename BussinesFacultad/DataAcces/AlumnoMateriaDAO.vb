
Imports ContractsFacultad.DataTransferObject
Imports ContractsFacultad.Enums
Imports ContractsFacultad.DisplayObject
Imports System.ComponentModel

Namespace DataAcces

    Public Class AlumnoMateriaDAO
        Inherits DataAcessObject

        Const SP_INSERT = "spAlumnoMateriaInsert"
        Const SP_UPDATE = "spAlumnoMateriaUpdate"
        Const SP_DELETE = "spAlumnoMateriaDelete"
        Const SP_GETLIST = "spAlumnoMateriaGetList"


        Public Sub Insert(ByVal aluMat As AlumnoMateriaDTO)
            AddParameter(AlumnoMateriaEnum.AlumnoMateriaId.ToString(), aluMat.AlumnoMateriaId)
            AddParameter(AlumnoMateriaEnum.AlumnoId.ToString(), aluMat.AlumnoId)
            AddParameter(AlumnoMateriaEnum.MateriaId.ToString(), aluMat.MateriaId)
            Excecute(SP_INSERT)
        End Sub

        Public Sub Update(ByVal aluMat As AlumnoMateriaDTO)
            AddParameter(AlumnoMateriaEnum.AlumnoMateriaId.ToString(), aluMat.AlumnoMateriaId)
            AddParameter(AlumnoMateriaEnum.AlumnoId.ToString(), aluMat.AlumnoId)
            AddParameter(AlumnoMateriaEnum.MateriaId.ToString(), aluMat.MateriaId)
            Excecute(SP_UPDATE)
        End Sub

        Public Sub Delete(ByVal id As Integer)
            AddParameter(AlumnoMateriaEnum.AlumnoMateriaId.ToString(), id)
            Excecute(SP_DELETE)
        End Sub

        Public Function GetList() As BindingList(Of AlumnoMateriaDisplayObject)

            Dim ds As DataSet

            ds = ExcetuteResultSet(SP_GETLIST)

            Dim car As AlumnoMateriaDisplayObject
            Dim lista As New BindingList(Of AlumnoMateriaDisplayObject)

            For Each renglon As DataRow In ds.Tables(0).Rows
                car = New AlumnoMateriaDisplayObject
                car.AlumnoMateriaId = renglon(AlumnoMateriaEnum.AlumnoMateriaId.ToString())
                car.AlumnoId = renglon(AlumnoMateriaEnum.AlumnoId.ToString())
                car.MateriaId = renglon(AlumnoMateriaEnum.MateriaId.ToString())
                lista.Add(car)
            Next

            Return lista

        End Function

    End Class
End Namespace