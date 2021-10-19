Public Class Form2
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Dim valor As Integer = 1
        Dim dados(0 To valor) As Integer

        valor = Val(InputBox("Quantos dados pretende inserir?", "quantidade"))

        For i = 0 To valor
            valor = Convert.ToInt32(InputBox("Introduza os valores"))

            dados(i) = valor

            ListBox1.Items.Add(valor)
        Next
    End Sub
End Class