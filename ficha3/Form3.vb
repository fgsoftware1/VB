Public Class Form3
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        txt_sqrt_resultado.Text = Math.Sqrt(Convert.ToDouble(txt_sqrt_num1.Text))
        txt_potencia_resultado.Text = Math.Pow(Convert.ToDouble(txt_potencia_num1), Convert.ToDouble(txt_potencia_num2))
        txt_arredondar_inteiros_resultado.Text = Math.Round(Convert.ToInt64(txt_arredondar_inteiros_num1.Text))
        txt_arredondar_decimal_resultado.Text = Math.Round(Convert.ToDouble(txt_arredondar_decimal_num1))
    End Sub
End Class