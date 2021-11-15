Imports System.IO

Public Class Inserir_aluno
    Dim imageUpload As Image
    Dim imageFilename As String

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
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
            File.Copy(imageFilename, src & nome_ficheiro)
        End If

        Try
            Dim result = Module_BD.Executar_Sql_Command("INSERT INTO " &
                                                    "alunos (Nome, Morada, Data_Nasc, Genero, Contato, Imagem, Ativo) " &
                                                    "VALUES ('" & txt_nome.Text & "', '" & txt_morada.Text & "', " &
                                                    "'" & txt_Data.Text & "', '" & cmb_genero.Text & "', " &
                                                    "" & txt_contato.Text & ", '" & nome_ficheiro & "', " &
                                                    "" & ativo & ") ")
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