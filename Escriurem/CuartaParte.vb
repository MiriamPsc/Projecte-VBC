Imports System.IO

Public Class CuartaParte
    Inherits TerceraParte
    Implements ParaProbar

    Public Shared O As New CuartaParte()

    Public Shared pregunta_5, archivo5, resp5 As String
    Public Shared Sub Respuesta4()
        If clave3 = "648" Then
            Dim respuesta4 As String = "C:\Users\miria\source\repos\OnAnother\LA CASA DE PAPEL\4.txt"
            Dim archivo4 As String = File.ReadAllText(respuesta4)
            Console.WriteLine(archivo4)
            Console.WriteLine()
            Pregunta5()
        ElseIf clave3 <> "648" Then
            Console.WriteLine("¿No estás anotando lo que descubres?")
            Console.WriteLine("Recuerda que aquí sí son números.")
            Console.WriteLine(O.Mens())
            Console.WriteLine()
        End If
    End Sub

    Public Shared Sub Pregunta5()
        Console.WriteLine("ESTA ES LA ULTIMA")
        respuesta = "C:\Users\miria\source\repos\OnAnother\LA CASA DE PAPEL\4.txt"
        archivo3 = File.ReadAllText(respuesta)
        Console.WriteLine("RESPUESTA")
        resp5 = Console.ReadLine()
        Console.WriteLine("")
        QuintaParte.Respuesta5()
    End Sub
    Public Function Mens() As String Implements ParaProbar.Mensaje
        Dim Animo As String
        Animo = ("SE QUE PUEDES RECORDAR")
        Return Animo
    End Function


End Class
