Public Class Form1
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        On Error GoTo Erro1

        MsgBox("resultado da divisao: " & num_n1.Value / num_n2.Value)

        Exit Sub

Erro1:
        MsgBox("saida do procedimento por causa de um erro!" & vbNewLine & Err.Description)
    End Sub
End Class
