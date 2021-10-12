Public Class Form3
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_notas.Text = ""
        txt_resultado.Text = ""
    End Sub

    Private Sub btn_converter_Click(sender As Object, e As EventArgs) Handles btn_converter.Click
        Dim nota As Integer = 0

        nota = Convert.ToInt32(txt_notas.Text)

        Select Case nota
            Case 1 : txt_resultado.Text = "mau"
            Case 2 : txt_resultado.Text = "mediocre"
            Case 3 : txt_resultado.Text = "suficiente"
            Case 4 : txt_resultado.Text = "bom"
            Case 5 : txt_resultado.Text = "muito bom"
            Case Else : MsgBox("valor fora dos limites(1-5)")
        End Select
    End Sub
End Class