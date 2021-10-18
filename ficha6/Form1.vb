Public Class btn_calcular
    Dim dados(3) As Integer, valor = 0

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_soma.Text = ""
        txt_media.Text = ""
        txt_maximo.Text = ""
        txt_minimo.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub btn_terminar_Click(sender As Object, e As EventArgs) Handles btn_terminar.Click
        End
    End Sub

    Private Sub btn_introduzir_Click(sender As Object, e As EventArgs) Handles btn_introduzir.Click

        For i = 0 To 3
            valor = Convert.ToInt32(InputBox("Introduza os valores"))

            dados(i) = valor

            ListBox1.Items.Add(valor)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim soma As Integer
        Dim maximo As Integer = dados(0)
        Dim minimo As Integer = dados(0)

        For i = 0 To 3
            soma = soma + dados(3)
        Next

        txt_soma.Text = soma
        txt_soma.Text = soma / dados.Count
    End Sub
End Class
