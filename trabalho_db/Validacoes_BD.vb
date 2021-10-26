Module Validacoes_BD
    Public Function Valida_Numeros(valor As Object, nome_campo As String)
        If IsNumeric(valor) = False Then
            MsgBox("campo" & "nome_campo" & "nao é numérico", vbCritical + vbOKOnly,
                   "erro de validaçao numérica")

            Valida_Numeros = -1
        End If
    End Function
End Module
