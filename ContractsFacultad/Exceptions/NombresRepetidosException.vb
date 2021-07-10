

Namespace Exeptions


    Public Class NombresRepetidosException
        Inherits Exception


        Sub New()

            MyBase.New("Materia ya registrada, porfavor seleccione una distinta")
        End Sub

    End Class


End Namespace
