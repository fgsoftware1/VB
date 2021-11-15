Imports System.IO

Public Class Inserir_Sumario
    Private Sub Inserir_Sumario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_ativo.Items.Add("Sim")
        cmb_ativo.Items.Add("Nao")
        cmb_disciplina.Items.Add("FQ")
        cmb_disciplina.Items.Add("LP")
        cmb_disciplina.Items.Add("RSBD")
        cmb_disciplina.Items.Add("EF")
    End Sub

    Private Sub btn_Inserir_Click(sender As Object, e As EventArgs) Handles btn_Inserir.Click
        Dim ativo = IIf(cmb_ativo.Text = "Sim", 1, 0)

        Try
            Dim result = Module_BD.Executar_Sql_Command("INSERT INTO " &
                                                    "sumarios (Data_Sumario, Descricao, Disciplina, Ativo) " &
                                                    "VALUES ('" & txt_Data.Text & "', " &
                                                    "'" & txt_summary.Text & "', '" & cmb_disciplina.Text & "', " & "" & ativo & ") ")
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