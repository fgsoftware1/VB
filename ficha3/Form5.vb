Public Class Form5
    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        txt_data.Text = DateTime.Now.Date.ToString("dd MM yyyy")
    End Sub
End Class