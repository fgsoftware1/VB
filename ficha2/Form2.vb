Public Class Form2
    Private Sub btn_apagar_Click_1(sender As Object, e As EventArgs) Handles btn_apagar.Click
        lbl_rotulo.Text = ""
        txt_texto1.Text = ""
    End Sub

    Private Sub btn_repor_Click(sender As Object, e As EventArgs) Handles btn_repor.Click
        lbl_rotulo.Text = "isto é um rótulo"
        txt_texto1.Text = "isto é uma caixa de texto"
    End Sub
End Class