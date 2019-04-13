Public Class VehiculoB
    Private marca As String
    Private modelo As String
    Private anho As String
    Private color As String

    Public Property _marca() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property
    Public Property _modelo() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property _anho() As String
        Get
            Return anho
        End Get
        Set(value As String)
            anho = value
        End Set
    End Property
    Public Property _color() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property
    Public Sub Datos()
        Console.WriteLine("Marca: " & marca)
        Console.WriteLine("Modelo: " & modelo)
        Console.WriteLine("Anho: " & anho)
        Console.WriteLine("Color: " & color)
    End Sub

End Class
