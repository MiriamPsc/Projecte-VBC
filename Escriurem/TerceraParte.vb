Public Class TerceraParte
    Inherits SegundaParte

    Public Shared clave3 As String

    Public Shared Sub Respuesta3()
        If clave2 = "LA RESISTENCIA" Then
            Console.WriteLine(archivo3)
            Console.WriteLine()
            Pregunta4()
        ElseIf clave1 <> "LA RESISTENCIA" Then
            Console.WriteLine("Empieza por lo que tienes claro. Una de las opciones dice: Nada es correcto, por lo que ninguno de esos números está en la clave.")
            Console.WriteLine("O tal vez no estas escribiendo en mayusculas")
            Console.WriteLine("¿QUIENES SOMOS?:")
            clave2 = (Console.ReadLine())
            Respuesta3()

            If clave1 <> "LA RESISTENCIA" Then
                Console.WriteLine("¿Ya la tienes?")
                Console.WriteLine("¿QUIENES SOMOS?:")
                clave2 = (Console.ReadLine())
                Respuesta3()

                If clave1 <> "LA RESISTENCIA" Then
                    Console.WriteLine("Creo que te pudiste dar cuenta de que la clave no va en el recuadro de abajo.")
                    Console.WriteLine("¿Leíste bien los textos anteriores?")
                    Console.WriteLine("¿QUIENES SOMOS?:")
                    clave2 = (Console.ReadLine())
                    Respuesta3()
                End If
            End If
        End If
    End Sub

    Public Shared Sub Pregunta4()
        Console.WriteLine("Ahora, para continuar con la siguiente pregunta necesitas tener a la mano la clave que te servirá para llegar a la siguiente prueba.")
        Console.WriteLine()
        clave3 = (Console.ReadLine())
        CuartaParte.Respuesta4()
    End Sub
End Class
