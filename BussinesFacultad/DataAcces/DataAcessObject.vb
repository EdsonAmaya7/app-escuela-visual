
Imports System.Data.SqlClient





Namespace DataAcces

    Public Class DataAcessObject

        Private conexion As SqlConnection
        Private comando As SqlCommand


        Sub New()
            conexion = New SqlConnection
            conexion.ConnectionString = "Data Source=DESKTOP-DFI47ML\MSQLSERVER2016;Integrated Security = true; Initial Catalog=Facultad;"
            conexion.Open()
            comando = New SqlCommand
            comando.Connection = conexion
        End Sub

        Public Sub AddParameter(ByVal nombre As String, ByVal valor As Object)

            Dim parametro As New SqlParameter
            parametro.ParameterName = nombre
            parametro.Value = valor

            comando.Parameters.Add(parametro)
        End Sub

        Public Sub AddOutputParameter(ByVal nombre As String, ByVal valor As Object, ByVal tipo As System.Data.DbType, ByVal size As Integer)

            Dim parametro As SqlParameter = New SqlParameter
            parametro.ParameterName = nombre
            parametro.Direction = ParameterDirection.Output
            parametro.DbType = tipo
            parametro.Value = valor

            If size <> 0 Then
                parametro.Size = size
            End If

            comando.Parameters.Add(parametro)


        End Sub


        Public Function GetParameter(ByVal nombre As String) As SqlParameter

            Return comando.Parameters(nombre)

        End Function


        Public Sub Excecute(ByVal sp As String)
            comando.CommandText = sp
            comando.CommandType = CommandType.StoredProcedure
            comando.ExecuteNonQuery()
        End Sub

        Public Function ExcetuteResultSet(ByVal sp As String) As DataSet
            comando.CommandText = sp
            comando.CommandType = CommandType.StoredProcedure
            Dim ds As DataSet
            ds = New DataSet

            Dim adapter = New SqlDataAdapter
            adapter.SelectCommand = comando
            adapter.Fill(ds)

            Return ds

        End Function


    End Class

End Namespace