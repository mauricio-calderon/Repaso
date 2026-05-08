Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim operacion = Val(num1.Text) * 2
        Label2.Text = operacion
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero1 = Val(num1.Text)
        Dim numero2 = Val(num2.Text)
        Dim resultado = numero1 + numero2
        Label2.Text = resultado
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Label2.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Label2.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        If Val(num2.Text) = 0 Then
            Label2.Text = "Error"
        Else
            Label2.Text = Val(num1.Text) / Val(num2.Text)
        End If

    End Sub
End Class
