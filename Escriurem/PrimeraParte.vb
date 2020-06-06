Imports System.IO

Public Class PrimeraParte
    Public Shared dibujo, archivo, titulo, archivo2, clave1, respuesta, archivo3, pregunta_2, archivo4, clave2 As String

    Public Shared Sub MensajeInicial()
        dibujo = "C:\Users\miria\Desktop\LA CASA DE PAPEL\NOTAS.txt"
        archivo = File.ReadAllText(dibujo)
        Console.WriteLine(archivo)
        titulo = "C:\Users\miria\Desktop\LA CASA DE PAPEL\INICIO.txt"
        archivo2 = File.ReadAllText(titulo)
        Console.WriteLine(archivo2)
        Resp1()
    End Sub

    Public Shared Sub Resp1()
        Console.WriteLine("CLAVE:")
        clave1 = (Console.ReadLine())
        Console.WriteLine()
        SegundaParte.Respuesta1()
    End Sub
End Class
