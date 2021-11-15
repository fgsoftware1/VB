Public Class Alterar_Sumario
    Dim valor_ID = Module_BD.ID

    Private Sub Alterar_Sumario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result = Module_BD.Executar_Sql_Command("SELECT * FROM sumarios " & " WHERE ID_Sumario = " & valor_ID)

        Try
            If result.Read = True And result.HasRows Then
                txt_id.Text = result("ID_Aluno").ToString()

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

    Private Sub btn_Alterar_Click(sender As Object, e As EventArgs) Handles btn_Alterar.Click
        Dim ativo = IIf(cmb_ativo.Text = "Sim", 1, 0)

        Try
            Dim result = Module_BD.Executar_Sql_Command("UPDATE sumarios " &
                                                    "SET Descricao = '" & txt_summary.Text & "', Data_Sumario = '" & txt_Data.Text & "', 
                                                    '" & txt_summary.Text & "', Disciplina = '" & cmb_disciplina.Text & "', 
                                                    Ativo = " & "" & ativo & ") ")
            If IsNothing(result) Then
                MsgBox("Erro na inserçao dos dados")
            ElseIf result.RecordsAffected = 1 Then
                MsgBox("dados inseridos")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class