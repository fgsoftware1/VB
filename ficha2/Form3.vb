Public Class Form3
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim comprimento As Integer, largura
        Dim area As Integer, perimetro

        comprimento = Convert.ToInt32(txt_comprimento.Text)
        largura = Convert.ToInt32(txt_largura.Text)

        area = comprimento * largura
        perimetro = 2 * comprimento + 2 * largura

        txt_resultado.Text = "A área é igual a: " & area
        txt_resultado.Text += vbNewLine & "O perimetro é igual a: " & perimetro
    End Sub
End Class