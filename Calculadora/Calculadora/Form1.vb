Public Class Form1
    Private Sub limpriar()
        txtnum1.Clear()
        txtnum2.Clear()
        txtresultado.Clear()
    End Sub
    Function operaciones(num1 As Integer, num2 As Integer, opc As String)
        Dim resultado As Double
        Select Case opc
            Case "S"
                resultado = num1 + num2
            Case "R"
                resultado = num1 - num2
            Case "M"
                resultado = num1 * num2
            Case "D"
                resultado = num1 / num2
        End Select
        Return resultado
    End Function

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        limpriar()
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Double
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        resultado = operaciones(num1, num2, "S")
        txtresultado.Text = resultado
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Double
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        resultado = operaciones(num1, num2, "R")
        txtresultado.Text = resultado
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Double
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        resultado = operaciones(num1, num2, "M")
        txtresultado.Text = resultado
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Double
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        resultado = operaciones(num1, num2, "D")
        txtresultado.Text = resultado
    End Sub
End Class
