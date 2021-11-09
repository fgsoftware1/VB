Imports System.IO

Public Class Alterar_aluno
    Private Sub Alterar_aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor_ID = Module_BD.ID
        Dim result = Module_BD.Executar_Sql_Command("SELECT * FROM alunos " & " WHERE ID_Aluno = " & valor_ID)
        Dim src = AppDomain.CurrentDomain.BaseDirectory

        src = Directory.GetParent(src).Parent.Parent.FullName & "\imagens\"

        Try
            If result.Read = True And result.HasRows Then
                txt_id.Text = result("ID_Aluno").ToString()
                txt_nome.Text = result("Nome").ToString()
                txt_morada.Text = result("Morada").ToString()
                txt_data.Text = result("Data_Nasc").ToString()
                cmb_genero.SelectedItem = result("Genero").ToString
                txt_contato.Text = result("Contato").ToString()
                cmb_ativo.SelectedItem = IIf(result("Ativo") = 1, "Sim", "Nao")
                pic_imagem.ImageLocation = src & result("Imagem").ToString

                result.Close()
            Else
                MsgBox("Ocorreu um erro na consulta à BD", vbCritical, "Erro consulta")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class