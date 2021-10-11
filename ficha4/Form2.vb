Public Class Form2
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_unidades.Text = ""
        txt_preço.Text = ""
        radio_taxa10.Checked = False
        radio_taxa15.Checked = False
        check_desconto5.Checked = False
        txt_resultado.Text = ""
    End Sub
End Class