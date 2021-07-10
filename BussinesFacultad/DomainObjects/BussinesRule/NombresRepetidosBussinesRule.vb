Imports ContractsFacultad.Exeptions
Imports ContractsFacultad.Services


Namespace BussinesRule

    Public Class NombresRepetidosBussinesRule

        Public Sub exist(ByVal nombre As String)
            Dim servicio As IMateria
            servicio = New DomainObjects.MateriaDomainObject

            Dim existe As Boolean
            existe = servicio.Existe(nombre)

            If existe Then
                Throw New NombresRepetidosException
            End If
        End Sub
    End Class

End Namespace