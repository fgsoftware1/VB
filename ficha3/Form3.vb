Public Class Form3
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        txt_sqrt_resultado.Text = Math.Sqrt(Convert.ToDouble(txt_sqrt_num1.Text))
    End Sub
End Class