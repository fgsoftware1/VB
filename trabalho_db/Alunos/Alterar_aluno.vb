Imports System.IO

Public Class Alterar_aluno
    Dim imageUpload As Image
    Dim imageFilename As String
    Dim valor_ID = Module_BD.ID
    Dim localizacao As String

    Private Sub Alterar_aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                localizacao = result("Imagem").ToString

                result.Close()
            Else
                MsgBox("Ocorreu um erro na consulta à BD", vbCritical, "Erro consulta")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If Validacoes_BD.Valida_Numeros(txt_contato.Text, "Contato") = -1 Then
            txt_contato.Text = ""
            Exit Sub
        End If

        If IsNothing(pic_imagem.Image) Then
            MsgBox("nao tem imagem")
            Exit Sub
        End If

        Dim ativo = IIf(cmb_ativo.Text = "Sim", 1, 0)
        Dim nome_ficheiro = System.IO.Path.GetFileName(imageFilename)
        Dim extensao_ficheiro = System.IO.Path.GetExtension(imageFilename)
        Dim src = AppDomain.CurrentDomain.BaseDirectory

        src = Directory.GetParent(src).Parent.Parent.FullName & "\imagens\"

        If File.Exists(src & nome_ficheiro) Then
            MsgBox("já existe a imagem")
            pic_imagem.Image = Nothing
            Exit Sub
        Else
            If localizacao <> nome_ficheiro Then
                File.Copy(imageFilename, src & nome_ficheiro)
            End If
        End If

            Try
            Dim result = Module_BD.Executar_Sql_Command("UPDATE alunos " &
                                                    "SET Nome = '" & txt_nome.Text & "', Morada = '" & txt_morada.Text & "', Data_Nasc = " &
                                                    "'" & txt_data.Text & "', Genero = '" & cmb_genero.Text & "', Contato = " &
                                                    "" & txt_contato.Text & ", Imagem = '" & nome_ficheiro & "', Ativo = " &
                                                    "" & ativo & " WHERE ID_Aluno = " & valor_ID & "")
            If IsNothing(result) Then
                File.Delete(src & nome_ficheiro)
                MsgBox("Erro na inserçao dos dados")
            ElseIf result.RecordsAffected = 1 Then
                MsgBox("dados inseridos")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
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