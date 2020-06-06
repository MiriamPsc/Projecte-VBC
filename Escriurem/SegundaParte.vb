Imports System.IO

Public Class SegundaParte
    Inherits PrimeraParte

    Public Shared Sub Respuesta1()
        If clave1 = "DALI" Then
            respuesta = "C:\Users\miria\Desktop\LA CASA DE PAPEL\2.txt"
            archivo3 = File.ReadAllText(respuesta)
            Console.WriteLine(archivo3)
            Console.WriteLine()
            Pregunta2()
        ElseIf clave1 <> "DALI" Then
            Console.WriteLine("¿No te has percatado que algunas palabras están mal escritas? Quizá uniendo esas letras que faltan conseguimos algo...")
            Console.WriteLine("O tal vez no estas escribiendo en mayusculas")
            Resp1()
        End If
    End Sub

    Public Shared Sub Pregunta2()
        pregunta_2 = "C:\Users\miria\Desktop\LA CASA DE PAPEL\3.txt"
        archivo4 = File.ReadAllText(pregunta_2)
        Console.WriteLine(archivo4)
        Console.WriteLine()
        Console.WriteLine("¿QUIENES SOMOS?:")
        clave2 = (Console.ReadLine())
        TerceraParte.Respuesta3()
    End Sub
End Class
