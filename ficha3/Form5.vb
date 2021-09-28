Public Class Form5
    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        txt_data.Text = DateTime.Now.Date.ToString("dd MM yyyy")
        txt_hora.Text = DateTime.Now.TimeOfDay.ToString()
        txt_data_hora.Text = DateTime.Now.ToString
    End Sub
End Class