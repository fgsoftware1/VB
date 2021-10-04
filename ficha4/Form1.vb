Public Class Form1
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_num1.Text = ""
        txt_num2.Text = ""
        txt_resultado.Text = ""

        radio_somar.Checked = False
        radio_subtrair.Checked = False
        radio_multiplicar.Checked = False
        radio_dividir.Checked = False
    End Sub
End Class
