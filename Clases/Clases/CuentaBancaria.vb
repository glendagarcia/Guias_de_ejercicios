Public Class CuentaBancaria
    Private numeroCuenta As Integer
    Private Balance As Double


    Public Sub New(numeroCuenta, Balance)
        Me.numeroCuenta = numeroCuenta
        Me.Balance = Balance
    End Sub

    Public Sub Depositar(total As Double)
        Balance = Balance + total
    End Sub

    Public Sub Retirar(total As Double)
        Balance = Balance - total
    End Sub

    Public Sub Mostrar()
        Console.WriteLine("Mostrar Balance" & Balance)
        Console.ReadLine()
    End Sub
End Class
