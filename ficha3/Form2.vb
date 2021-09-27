Public Class Form2
    Private Sub btn_invocar_Click(sender As Object, e As EventArgs) Handles btn_invocar.Click
        Dim valor As String

        valor = MsgBox("mostrou mensagem", vbQuestion + vbYesNo, "título da janela")

        If valor = vbYes Then
            End
        Else
            MsgBox("entao vamos continuar")
        End If
    End Sub
End Class