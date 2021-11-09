Imports System.IO

Public Class Alterar_aluno
    Dim imageUpload As Image
    Dim imageFilename As String

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

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click

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
End Class