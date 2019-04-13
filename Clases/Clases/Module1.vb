Module Module1

    Sub Main()
        Dim saludar As HolaMundo = New HolaMundo()
        saludar.Saludo()

        Dim carro1 As VehiculoA = New VehiculoA("Audi", "R8", "2015", "Blanco")
        Dim carro2 As VehiculoA = New VehiculoA("Toyota", "Corola", "2017", "Negro")
        Dim carro3 As VehiculoA = New VehiculoA("Ford", "Focus", "2018", "rosado")

        carro1.Mostrainfor()
        carro2.Mostrainfor()
        carro3.Mostrainfor()
        Console.ReadLine()

        Dim car1 As VehiculoB = New VehiculoB()
        car1._marca = "Toyota"
        car1._modelo = "Yaris"
        car1._anho = "2016"
        car1._color = "Gris"

        Dim car2 As VehiculoB = New VehiculoB()
        car2._marca = "BMW"
        car2._modelo = "Serie 2"
        car2._anho = "2019"
        car2._color = "Rojo"

        Dim car3 As VehiculoB = New VehiculoB()
        car3._marca = "Chevrlolet"
        car3._modelo = "Camaro ZL1"
        car3._anho = "2016"
        car3._color = "Amarillo"

        car1.Datos()
        car2.Datos()
        car3.Datos()
        Console.ReadLine()

        Dim Cuenta As CuentaBancaria = New CuentaBancaria(10, 220)
        Console.WriteLine("Balance = 220")
        Console.WriteLine("Deposito = 40 ")
        Console.WriteLine("Retiro = 30")
        Cuenta.Depositar(40)
        Cuenta.Retirar(10)
        Cuenta.Mostrar()
        Console.ReadLine()

    End Sub

End Module
