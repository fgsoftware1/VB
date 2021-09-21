Public Class Form2
    Private Sub btn_apagar_Click_1(sender As Object, e As EventArgs) Handles btn_apagar.Click
        lbl_rotulo.Text = ""
        txt_texto1.Text = ""
    End Sub

    Private Sub btn_repor_Click(sender As Object, e As EventArgs) Handles btn_repor.Click
        lbl_rotulo.Text = "isto é um rótulo"
        txt_texto1.Text = "isto é uma caixa de texto"
    End Sub

    Private Sub btn_corFundo_Click(sender As Object, e As EventArgs) Handles btn_corFundo.Click
        lbl_rotulo.BackColor = Color.Red
        txt_texto1.ForeColor = Color.Purple
    End Sub

    Private Sub btn_corTexto_Click(sender As Object, e As EventArgs) Handles btn_corTexto.Click
        lbl_rotulo.ForeColor = Color.Blue
        txt_texto1.ForeColor = Color.GreenYellow
    End Sub
End Class