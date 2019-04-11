Module Module1

    Sub Main()
        Dim saludar As HolaMundo = New HolaMundo()
        saludar.Saludo()

        Dim carro1 As VehiculoA = New VehiculoA("audi", "r8", "2015", "blanco")
        Dim carro2 As VehiculoA = New VehiculoA("toyota", "corola", "2017", "negro")
        Dim carro3 As VehiculoA = New VehiculoA("ford", "focus", "2018", "rosado")

        carro1.Mostrainfor()
        carro2.Mostrainfor()
        carro3.Mostrainfor()
        Console.ReadLine()
    End Sub


End Module
