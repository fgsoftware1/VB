Public Class Alterar_Sumario
    Dim valor_ID = Module_BD.ID

    Private Sub btn_Alterar_Click(sender As Object, e As EventArgs) Handles btn_Alterar.Click
        Dim result = Module_BD.Executar_Sql_Command("SELECT * FROM sumarios " & " WHERE ID_Sumario = " & valor_ID)

        Try
            If result.Read = True And result.HasRows Then
                txt_id.Text = result("ID_Aluno").ToString()
                txt_title.Text = result("Nome_Sumario").ToString()
                txt_Data.Text = result("Data_Sumario").ToString()
                txt_summary.Text = result("Descricao").ToString()
                cmb_disciplina.SelectedItem = result("Discipina").ToString
                cmb_ativo.SelectedItem = IIf(result("Ativo") = 1, "Sim", "Nao")

                result.Close()
            Else
                MsgBox("Ocorreu um erro na consulta à BD", vbCritical, "Erro consulta")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class