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

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim valor1 As Integer = 0, valor2 = 0

        valor1 = Val(txt_num1.Text)
        valor2 = Val(txt_num2.Text)

        If radio_somar.Checked = True Then
            txt_resultado.Text = valor1 + valor2
        ElseIf radio_subtrair.Checked = True Then
            txt_resultado.Text = valor1 - valor2
        ElseIf radio_multiplicar.Checked = True Then
            txt_resultado.Text = valor1 * valor2
        ElseIf radio_dividir.Checked = True Then
            txt_resultado.Text = valor1 / valor2
        Else
            MsgBox("nenhuma operaçao selecionada")
        End If
    End Sub
End Class
