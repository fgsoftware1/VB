Public Class Inserir_aluno
    Dim imageUpload As Image
    Dim imageFilename As String

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click

    End Sub

    Private Sub pic_imagem_Click(sender As Object, e As EventArgs) Handles pic_imagem.Click
        Dim openFileDialog1 As New OpenFileDialog

        With openFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp; *.gif; *.jpg"

            If .ShowDialog = DialogResult.OK Then
                pic_imagem.Image = Image.FromFile(.FileName)

                imageFilename = openFileDialog1.FileName
                imageUpload = Image.FromFile(openFileDialog1.FileName)
            End If
        End With
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

    End Sub
End Class