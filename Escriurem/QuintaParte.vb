Public Class QuintaParte
    Inherits CuartaParte
    Implements ParaProbar, Colores

    Public Shared Sub Respuesta5()
        If resp5 = "34655854" Then
            Final()
        ElseIf resp5 <> "34655854" Then
            Console.WriteLine("Comienzo a creer que no te mereces el premio.")
            Console.WriteLine("RESPUESTA:")
            resp5 = Console.ReadLine()
            Respuesta5()
        End If
    End Sub

    Public Shared Sub Final()

        Console.WriteLine("Separa la respuesta en 4 numeros.")
        Console.WriteLine("Parecen coordenadas, no?")
        Console.WriteLine("Se notificará a mi contacto que has completado el reto,")
        Console.WriteLine("Se pondrá en contacto contigo cuando sea seguro. EXITO, Y FELICIDADES.")
        Console.WriteLine("")
        Console.WriteLine("El profesor.")
        Console.WriteLine("")

    End Sub

    Public Function Mens() As String Implements ParaProbar.Mensaje
        Dim Fin As String
        Fin = ("SE ACABÓ")
        Return Fin
    End Function

    Public Sub Color() Implements Colores.Color
        Console.ForegroundColor = ConsoleColor.White
    End Sub

End Class
