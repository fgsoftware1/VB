Public Class Form4
    Private Sub btn_random_Click(sender As Object, e As EventArgs) Handles btn_random.Click
        Dim num1 As Integer

        Randomize()

        num1 = Convert.ToInt32(Rnd() * 100) + 1
        MessageBox.Show("numero gerado foi: " & num1)
    End Sub
End Class