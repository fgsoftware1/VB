Public Class Form2
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim resultado As Integer = 0

        resultado = Module_Calculos.SomaDados(num_n1.Value, num_n2.Value)

        txt_resultado.Text = resultado
    End Sub
End Class