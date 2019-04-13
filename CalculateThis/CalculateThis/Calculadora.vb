Public Class Calculadora
    Function Suma()
        Dim sumar As Integer
        Console.WriteLine("Ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        Dim num2 As Double = Console.ReadLine()
        sumar = num1 + num2
        Console.WriteLine("La suma de los numeros ingresados es: " & sumar)
        Console.ReadLine()
    End Function

    Function Resta()
        Dim restar As Integer
        Console.WriteLine("Ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        Dim num2 As Double = Console.ReadLine()
        restar = num1 - num2
        Console.WriteLine("La resta de los numeros ingresados es: " & restar)
        Console.ReadLine()
    End Function

    Function Multiplicacion()
        Dim multiplicar As Integer
        Console.WriteLine("Ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        Dim num2 As Double = Console.ReadLine()
        multiplicar = num1 * num2
        Console.WriteLine("La multiplicacion de los numeros ingresados es:  " & multiplicar)
        Console.ReadLine()
    End Function
    Function Division()
        Dim dividir As Integer
        Dim multiplicar As Integer
        Console.WriteLine("Ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        Dim num2 As Double = Console.ReadLine()
        dividir = num1 / num2
        Console.WriteLine("La division de los numeros ingresados es: " & dividir)
        Console.ReadLine()
    End Function
    Function Todaslasoperaciones()
        Console.WriteLine("Ingrese el primer numero")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 + num2
        Console.WriteLine("Suma: " & sumar)
        Console.ReadLine()
        Dim restar As Double = num1 - num2
        Console.WriteLine("Resta: " & restar)
        Console.ReadLine()
        Dim mult As Double = num1 * num2
        Console.WriteLine("Multiplicacion: " & mult)
        Console.ReadLine()
        Dim dividir As Double = num1 / num2
        Console.WriteLine("Division: " & dividir)
        Console.ReadLine()
    End Function
End Class
