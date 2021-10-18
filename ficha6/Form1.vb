Public Class btn_calcular
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_soma.Text = ""
        txt_media.Text = ""
        txt_maximo.Text = ""
        txt_minimo.Text = ""
    End Sub

    Private Sub btn_terminar_Click(sender As Object, e As EventArgs) Handles btn_terminar.Click
        End
    End Sub
End Class
