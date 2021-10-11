Public Class Form2
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_unidades.Text = ""
        txt_preço.Text = ""
        radio_taxa10.Checked = False
        radio_taxa15.Checked = False
        check_desconto5.Checked = False
        txt_resultado.Text = ""
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim preco As Double = 0, quantidade, resultado, desconto, taxa

        preco = Convert.ToDouble(txt_preço.Text)
        quantidade = Convert.ToDouble(txt_unidades.Text)

        If radio_taxa10.Checked = True Then
            taxa = 0.1
        ElseIf radio_taxa15.Checked = True Then
            taxa = 0.15
        Else
            MsgBox("Nao foi selecionada a taxa")
            Exit Sub
        End If

        If check_desconto5.Checked = True Then
            resultado = preco * quantidade * (1 + taxa) * (1 + 0.05)
        Else
            resultado = preco * quantidade * (1 + taxa)
        End If

        txt_resultado.Text = resultado
    End Sub
End Class