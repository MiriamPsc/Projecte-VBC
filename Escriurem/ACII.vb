Imports System.IO

Public Class ACII
    Public Shared Sub Imagen()
        Dim dibujo As String
        dibujo = "C:\Users\miria\Desktop\LA CASA DE PAPEL\mask.txt"
        Dim archivo As String = File.ReadAllText(dibujo)
        Console.WriteLine(archivo)
    End Sub

    Public Shared Sub Title()
        Dim titulo As String
        titulo = "C:\Users\miria\Desktop\LA CASA DE PAPEL\tit.txt"
        Dim archivo2 As String = File.ReadAllText(titulo)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(archivo2)
    End Sub

End Class
