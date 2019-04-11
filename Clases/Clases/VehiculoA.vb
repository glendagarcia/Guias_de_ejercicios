Public Class VehiculoA
    Private marca As String
    Private modelo As String
    Private anho As String
    Private color As String

    Public Sub New(marca, modelo, anho, color)
        Me.marca = marca
        Me.modelo = modelo
        Me.anho = anho
        Me.color = color
    End Sub

    Public Sub Mostrainfor()
        Console.WriteLine("Marca: " & marca)
        Console.WriteLine("Modelo: " & modelo)
        Console.WriteLine("Anho: " & anho)
        Console.WriteLine("Color: " & color)
    End Sub




End Class
