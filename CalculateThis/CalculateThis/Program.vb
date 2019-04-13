Module ProgramCalculadora
    Sub Main()
        Dim opcion As Integer
        While opcion >= 0 And opcion <= 5
            Console.WriteLine("1.Suma")
            Console.WriteLine("2.Resta")
            Console.WriteLine("3.Multiplicacion")
            Console.WriteLine("4.Dvision")
            Console.WriteLine("5.Todas")
            Console.WriteLine("Elija una opcion <1-5> o presione cualquier otro numero para salir")
            opcion = Console.ReadLine()

            Select Case opcion
                Case Is = 1
                    Dim SUMA As Calculadora = New Calculadora
                    SUMA.Suma()
                Case Is = 2
                    Dim RESTA As Calculadora = New Calculadora
                    RESTA.Resta()
                Case Is = 3
                    Dim MULTIPLICACION As Calculadora = New Calculadora
                    MULTIPLICACION.Multiplicacion()
                Case Is = 4
                    Dim DIVISION As Calculadora = New Calculadora
                    DIVISION.Division()
                Case Is = 5
                    Dim TODASLASOPERACIONES As Calculadora = New Calculadora
                    TODASLASOPERACIONES.Todaslasoperaciones()
            End Select
        End While
        Console.ReadLine()
    End Sub
End Module
